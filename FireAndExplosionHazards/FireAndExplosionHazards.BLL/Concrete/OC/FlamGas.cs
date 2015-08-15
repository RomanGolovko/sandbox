using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Abstract;

namespace FireAndExplosionHazards.BLL.Concrete.OC
{
    public class FlamGas : OverpressCalc
    {
        /// <summary>
        /// Мольный объем
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public double Vo { get { return 22.413; } } // 22,413 м^3• кмоль^(-1);

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "P1 - давление в аппарате, кПа")]
        public double P1 { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "V - объем аппарата, м^3")]
        public double V { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "q - расход газа, м^3*с^-1")]
        public double q { get; set; }               // определяют согласно технологическому регламенту в зависимости 
                                                    // от давления в трубопроводе, его диаметра, температуры газовой среды и т.п.;

        [Required(ErrorMessage = "Поле должно быть установлено, с")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "t - время")]
        public double τ712 { get; set; }            // определяют по п. 7.1.2;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]{*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "P2 - максимальное давление в трубопроводе по технологическому регламенту, кПа")]
        public double P2 { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "r - внутренний радиус трубопроводов, м")]
        public double r { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "L - длина трубопроводов от аварийного аппарата до задвижек, м")]
        public double L { get; set; }

        /// <summary>
        /// Масса газа, который поступил в помещение во время расчетной аварии
        /// </summary>
        /// <returns>Массу газа</returns>
        public override double m()
        {
            return (Vа() + Vт()) * Pгп();
        }

        /// <summary>
        /// Плотность газа или пара при расчетной температуре
        /// </summary>
        /// <returns>Плотность газа или пара при расчетной температуре</returns>
        public double Pгп()
        {
            return M / (Vo * (1 + 0.00367 * tp));
        }

        /// <summary>
        /// Объем газа, который вышел из аппарата
        /// </summary>
        /// <returns>Объем газа</returns>
        public double Vа()
        {
            return (P1 / P0) * V;
        }

        /// <summary>
        /// Объем газа, который вышел из трубопроводов
        /// </summary>
        /// <returns>Объем газа</returns>
        public double Vт()
        {
            return V1т() + V2т();
        }

        /// <summary>
        /// Объем газа, который вышел из трубопровода до перекрытия
        /// </summary>
        /// <returns>Объем газа</returns>
        public double V1т()
        {
            return q * τ712;
        }

        /// <summary>
        /// Объем газа, который вышел из трубопровода после перекрытия
        /// </summary>
        /// <returns>Объем газа</returns>
        public double V2т()
        {
            return Math.PI * (P2 / P0) * V * (Math.Pow(r, 2) * L);
        }
    }
}
