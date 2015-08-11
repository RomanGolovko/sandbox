using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Abstract.TermRadIntens;

namespace FireAndExplosionHazards.BLL.Concrete.TermRadIntens
{
    public class TermRadIntens_FB : ITermRadIntens_FB
    {
        [HiddenInput(DisplayValue = false)]
        public double g { get { return 9.81; } }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Ef - среднеповерхностная плотность теплового потока излучения пламени, кВт * м^-2")]
        public double Ef { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "r - расстояние от геометрического центра пролива до облучаемого объекта, м")]
        public double r { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "m - масса горючего вещества, кг")]
        public double m { get; set; }

        public double q()
        {
            return Ef * Fq() * ψ();
        }

        public double Fq()
        {

            return (H() / Ds() + 0.5) / (4 * Math.Pow((Math.Pow((H() / Ds() + 0.5), 2) + Math.Pow((r / Ds()), 2)), 1.5));
        }

        public double H()
        {
            return Ds() / 2;
        }

        public double Ds()
        {
            return 5.33 * Math.Pow(m, 0.327);
        }

        public double ts()
        {
            return 0.92 * Math.Pow(m, 0.303);
        }

        public double ψ()
        {
            return Math.Exp(-7.0 * Math.Pow(10, -4) * (Math.Sqrt(Math.Pow(r, 2) + Math.Pow(H(), 2)) - (Ds() / 2)));
        }
    }
}
