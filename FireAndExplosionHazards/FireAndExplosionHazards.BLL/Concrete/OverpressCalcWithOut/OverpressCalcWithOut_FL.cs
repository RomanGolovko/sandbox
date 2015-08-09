using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Abstract.OverpressCalcWithOut;

namespace FireAndExplosionHazards.BLL.Concrete.OverpressCalcWithOut
{
    public class OverpressCalcWithOut_FL : IOverpressCalcWithOut_FL
    {
        [HiddenInput(DisplayValue = false)]
        public double P0 { get { return 101.3; } }  // начальное давление, кПа (допускается принимать таким, что равняется 101,3 кПа);

        [HiddenInput(DisplayValue = false)]
        public double Vo { get { return 22.413; } } // мольный объем, который равняется 22,413 м^3• кмоль^(-1);

        [HiddenInput(DisplayValue = false)]
        public double Kн { get { return 3; } }      // коэффициент, который учитывает негерметичность помещения 
                                                    // и неадиабатичность процесса горения.Допускается принимать Кн равным 3;

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

        [Display(Name = "Z - коэффициент участия ГГ")]
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
        [Display(Name = "Aв - кратность воздухообмена, которую создает аварийная вентиляция, с^-1")]
        public double Aв { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "τ - продолжительность поступления паров ЛВЖ и ГЖ в объем помещения, с")]
        public double τ { get; set; }               // принимается по п. 7.1.2;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "M - молярная масса, кг * кмоль^(-1)")]
        public double M { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "tp - расчетная температура, °С")]
        public double tp { get; set; }

        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Fи - площадь испарения, м^2")]
        public double Fи { get; set; } = 0;

        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "τи - продолжительность испарения, с")]
        public double τи { get; set; } = 0;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "η - коэффициент")]
        public double η { get; set; } = 1;          // коэффициент, который принимают по таблице 3 в зависимости от скорости воздушного 
                                                    // потока, который создается аварийной вентиляцией, и температуры воздушного потока
                                                    // над поверхностью испарения(в случае отсутствия аварийной вентиляции η равняется 1)

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Константа Антуана A")]
        public double A { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Константа Антуана B")]
        public double B { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Константа Антуана C")]
        public double C { get; set; }

        public double ΔР()
        {
            return ((m() * Hт * P0 * Z) / (Vсвоб * Pв * Cр * T0)) * (1 / Kн);
        }

        public double K()
        {
            return Aв * τ + 1;
        }

        public double Pгп()
        {
            return M / (Vo * (1 + 0.00367 * tp));
        }

        public double m()
        {
            return W() * Fи * τи;
        }

        public double W()
        {
            return Math.Pow(10, -6) * η * Math.Pow(M / 1000, (1.0 / 2.0)) * Pн();
        }

        public double Pн()
        {
            return 0.133 * Math.Pow(10, (A - (B / (C + tp))));
        }
    }
}
