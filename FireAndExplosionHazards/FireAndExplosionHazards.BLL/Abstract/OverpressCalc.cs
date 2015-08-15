using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FireAndExplosionHazards.BLL.Abstract
{
    public abstract class OverpressCalc
    {
        /// <summary>
        /// Начальное давление
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public double P0 { get { return 101.3; } }  // допускается принимать таким, что равняется 101,3 кПа;

        /// <summary>
        /// Коэффициент негерметичности помещения и неадиабатичность процесса горения
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public double Kн { get { return 3; } }      // коэффициент, который учитывает негерметичность помещения 
                                                    // и неадиабатичность процесса горения.Допускается принимать Кн равным 3;

        /// <summary>
        /// Теплоемкость воздуха
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public double Cр { get { return 1.01 * Math.Pow(10, 3); } } // допускается принимать равной 1,01 * 10^3 Дж * кг^(-1) * К^(-1);

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Tв - температура вспышки, °С")]
        public double Tв { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Hт - теплота сгорания, Дж * кг^-1")]
        public double Hт { get; set; }

        [Display(Name = "Z - коэффициент участия веществ")]
        public double Z { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Vсвоб - свободный объем помещения, м^3")]
        public double Vсвоб { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Pв - плотность воздуха до взрыва при начальной температуре, кг*м^-3")]
        public double Pв { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "T0 - начальная температура воздуха, К")]
        public double T0 { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "M - молярная масса, кг * кмоль^(-1)")]
        public double M { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "tp - расчетная температура, °С")]
        public double tp { get; set; }

        /// <summary>
        /// Избыточное давление взрыва
        /// </summary>
        /// <returns>Избыточное давление взрыва</returns>
        public double ΔР()
        {
            return ((m() * Hт * P0 * Z) / (Vсвоб * Pв * Cр * T0)) * (1 / Kн);
        }

        /// <summary>
        /// Масса паров веществ, которые попали в результате расчетной аварии в помещение
        /// </summary>
        /// <returns>Массу паров вещества</returns>
        public abstract double m();
    }
}
