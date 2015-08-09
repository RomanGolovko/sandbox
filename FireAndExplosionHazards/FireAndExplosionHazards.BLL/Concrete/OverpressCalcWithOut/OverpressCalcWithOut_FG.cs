using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Abstract.OverpressCalcWithOut;

namespace FireAndExplosionHazards.BLL.Concrete.OverpressCalcWithOut
{
    public class OverpressCalcWithOut_FG : IOverpressCalcWithOut_FG
    {
        [HiddenInput(DisplayValue = false)]
        public double P0 { get { return 101.3; } }  // начальное давление, кПа (допускается принимать таким, что равняется 101,3 кПа);

        [HiddenInput(DisplayValue = false)]
        public double Vo { get { return 22.413; } } // мольный объем, который равняется 22,413 м^3• кмоль^(-1);

        [HiddenInput(DisplayValue = false)]
        public double Kн { get { return 3; } }      // коэффициент, который учитывает негерметичность помещения 
                                                    // и неадиабатичность процесса горения. Допускается принимать Кн равным 3;

        [HiddenInput(DisplayValue = false)]
        public double Cр { get { return 1.01 * Math.Pow(10, 3); } } // теплоемкость воздуха, Дж * кг^-1 * К^-1,
                                                                    // (допускается принимать равной 1,01 * 10^3);

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Tв - температура вспышки, °С")]
        public double Tв { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Hт - теплота сгорания, Дж * кг^-1")]
        public double Hт { get; set; }

        [Display(Name = "Z - коэффициент участия ГГ во взрыве")]
        public double Z { get; set; }               // коэффициент участия ГГ во взрыве;

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
        [Display(Name = "Aв - кратность воздухообмена, которую создает аварийная вентиляция, с^-1")]
        public double Aв { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "τ - продолжительность поступления ГГ в объем помещения, с")]
        public double τ { get; set; }       // принимается по п. 7.1.2;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "M - молярная масса, кг * кмоль^(-1)")]
        public double M { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "tp - расчетная температура, °С")]
        public double tp { get; set; }

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

        public double ΔР()
        {
            return ((m() * Hт * P0 * Z) / (Vсвоб * Pв * Cр * T0)) * (1 / Kн);
        }

        public double K()
        {
            return Aв * τ + 1;
        }

        public double m()
        {
            return (Vа() + Vт()) * Pгп();
        }

        public double Pгп()
        {
            return M / (Vo * (1 + 0.00367 * tp));
        }

        public double Vа()
        {
            return (P1 / P0) * V;
        }

        public double Vт()
        {
            return V1т() + V2т();
        }

        public double V1т()
        {
            return q * τ712;
        }

        public double V2т()
        {
            return Math.PI * (P2 / P0) * V * (Math.Pow(r, 2) * L);
        }
    }
}
