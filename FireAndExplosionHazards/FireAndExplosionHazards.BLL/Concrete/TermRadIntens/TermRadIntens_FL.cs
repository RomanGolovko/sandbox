using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Abstract.TermRadIntens;

namespace FireAndExplosionHazards.BLL.Concrete.TermRadIntens
{
    public class TermRadIntens_FL : ITermRadIntens_FL
    {
        [HiddenInput(DisplayValue = false)]
        public double g { get { return 9.81; } }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Ef - среднеповерхностная плотность теплового потока излучения пламени, кВт * м^-2")]
        public double Ef { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "F - площадь разлива, м^2")]
        public double F { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Mv - удельная массовая скорость выгорания топлива, кг * м^-2 * с^-1")]
        public double Mv { get; set; }


        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Pв - плотность окружающего воздуха, кг * м^-3")]
        public double Pв { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "r - расстояние от геометрического центра пролива до облучаемого объекта, м")]
        public double r { get; set; }

        public double q()
        {
            return Ef * Fq() * ψ();
        }

        public double d()
        {
            return Math.Sqrt((4 * F) / Math.PI);
        }

        public double H()
        {
            return 42 * d() * Math.Pow(Mv / (Pв * Math.Sqrt(g * d())), 0.61);
        }

        public double Fq()
        {
            return Math.Sqrt(Math.Pow(Fв(), 2) + Math.Pow(Fг(), 2));
        }

        public double Fв()
        {
            return (1 / Math.PI) * ((1 / S()) * Math.Atan(h() / Math.Sqrt(Math.Pow(S(), 2) - 1)) - (h() / S()) * (Math.Atan(Math.Sqrt((S() - 1) / (S() + 1)) - (A() / Math.Sqrt(Math.Pow(A(), 2) - 1)) * Math.Atan(Math.Sqrt(((A() + 1) * (S() - 1)) / ((A() - 1) * (S() + 1)))))));
        }

        public double Fг()
        {
            return (1 / Math.PI) * (((B() - (1 / S())) / Math.Sqrt(Math.Pow(B(), 2) - 1)) * Math.Atan(Math.Sqrt(((B() + 1) * (S() - 1)) / ((B() - 1) * (S() + 1)))) - ((A() - 1 / S()) / Math.Sqrt(Math.Pow(A(), 2) - 1)) * Math.Atan(Math.Sqrt(((A() + 1) * (S() - 1)) / ((A() - 1) * (S() + 1)))));
        }

        public double A()
        {
            return (Math.Pow(h(), 2) + Math.Pow(S(), 2) + 1) / (2 * S());
        }
        public double B()
        {
            return (1 + Math.Pow(S(), 2)) / (2 * S());
        }
        public double S()
        {
            return (2 * r) / d();
        }
        public double h()
        {
            return (2 * H()) / d();
        }

        public double ψ()
        {
                return Math.Exp(-7.0 * Math.Pow(10, -4) * (r - (0.5 * d())));
        }
    }
}
