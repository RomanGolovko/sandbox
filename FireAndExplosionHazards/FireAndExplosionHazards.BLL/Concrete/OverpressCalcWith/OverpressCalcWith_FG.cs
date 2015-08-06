using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Abstract.OverpressCalcWith;

namespace FireAndExplosionHazards.BLL.Concrete.OverpressCalcWith
{
    public class OverpressCalcWith_FG : IOverpressureCalculationWith_FG
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
        [Display(Name = "Pmax - максимальное давление взрыва стехиометрической газовоздушной смеси в закрытом объеме, кПа")]
        public double Pmax { get; set; } = 900;     // определяется исследовательским путем или
                                                    // принимается по справочным данным согласно требованиям п. 5.4. В случае 
                                                    // отсутствия таких данных, допускается принимать Рmах таким, что равняется 900; 

        [Display(Name = "Z - коэффициент участия ГГ во взрыве")]
        public double Z { get; set; }               // коэффициент участия ГГ во взрыве;

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
        [Display(Name = "Nc - число атомов углерода в молекуле ГГ")]
        public double Nc { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Nh - число атомов водорода в молекуле ГГ")]
        public double Nh { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "No - число атомов кислорода в молекуле ГГ")]
        public double No { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Nx - число атомов галогенов в молекуле ГГ")]
        public double Nx { get; set; }

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
        [Display(Name = "r - Внутренний радиус трубопроводов, м")]
        public double r { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "L - длина трубопроводов от аварийного аппарата до задвижек, м")]
        public double L { get; set; }

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
            return (Vа() + Vт()) * Pгп();
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
