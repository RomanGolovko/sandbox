using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Abstract.OverpressCalcWith;

namespace FireAndExplosionHazards.BLL.Concrete.OverpressCalcWith
{
    public class OverpressCalcWith_FL : IOverpressureCalculationWith_FL
    {
        [HiddenInput(DisplayValue = false)]
        public double P0 { get { return 101.3; } }  // начальное давление, кПа (допускается принимать таким, что равняется 101,3 кПа);

        [HiddenInput(DisplayValue = false)]
        public double Vo { get { return 22.413; } } // мольный объем, который равняется 22,413 м^3• кмоль^(-1);

        [HiddenInput(DisplayValue = false)]
        public double Kн { get { return 3; } }      // коэффициент, который учитывает негерметичность помещения 
                                                    // и неадиабатичность процесса горения. Допускается принимать Кн равным 3;


        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Tв - температура вспышки, °С")]
        public double Tв { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Pmax - максимальное давление взрыва стехиометрической паровоздушной смеси в закрытом объеме, кПа")]
        public double Pmax { get; set; } = 900;     // определяется исследовательским путем или
                                                    // принимается по справочным данным согласно требованиям п. 5.4. В случае 
                                                    // отсутствия таких данных, допускается принимать Рmах таким, что равняется 900 ; 

        [Display(Name = "Z - коэффициент участия ГГ")]
        public double Z { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Vсвоб - свободный объем помещения, м^3")]
        public double Vсвоб { get; set; }

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
        [Display(Name = "Nc - число атомов углерода в молекуле паров ГЖ")]
        public double Nc { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Nh - число атомов водорода в молекуле паров ГЖ")]
        public double Nh { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "No - число атомов кислорода в молекуле паров ГЖ")]
        public double No { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Nx - число атомов галогенов в молекуле паров ГЖ")]
        public double Nx { get; set; }

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
            return (Pmax - P0) * ((m() * Z) / (Vсвоб * Pгп())) * (100 / Cct()) * (1 / Kн);
        }

        public double Pгп()
        {
            return M / (Vo * (1 + 0.00367 * tp));
        }

        public double Cct()
        {
            return 100 / (1 + 4.84 * β());
        }
        public double β()
        {
            return Nc + ((Nh - Nx) / 4) - (No / 2);
        }

        public double m()
        {
            return W() * Fи * τи;
        }

        public double W()
        {
            return Math.Pow(10, -6) * η * Math.Pow(147.3, (1.0 / 2.0)) * Pн();                                
        }

        public double Pн()
        {
            return 0.133 * Math.Pow(10, (A - (B / (C + tp))));
        }
    }
}
