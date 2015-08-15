using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using FireAndExplosionHazards.BLL.Abstract;

namespace FireAndExplosionHazards.BLL.Concrete.TRI
{
    public class FlamLiq : TermRadIntens
    {
        /// <summary>
        /// Ускорение свободного падения
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public double g { get { return 9.81; } }

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

        /// <summary>
        /// Интенсивность теплового излучения
        /// </summary>
        /// <returns>Интенсивность теплового излучения</returns>
        public override double q()
        {
            return Ef * Fq() * ψ();
        }

        /// <summary>
        /// Эффективный диаметр разлива
        /// </summary>
        /// <returns>Эффективный диаметр разлива</returns>
        public double d()
        {
            return Math.Sqrt((4 * F) / Math.PI);
        }

        /// <summary>
        /// Высота пламени
        /// </summary>
        /// <returns>Высоту пламени</returns>
        public override double H()
        {
            return 42 * d() * Math.Pow(Mv / (Pв * Math.Sqrt(g * d())), 0.61);
        }

        /// <summary>
        /// Угловой коэффициент излучения
        /// </summary>
        /// <returns>Угловой коэффициент излучения</returns>
        public override double Fq()
        {
            return Math.Sqrt(Math.Pow(Fв(), 2) + Math.Pow(Fг(), 2));
        }

        /// <summary>
        /// Фактор облученности для вертикальной площадки
        /// </summary>
        /// <returns>Фактор облученности для вертикальной площадки</returns>
        public double Fв()
        {
            return (1 / Math.PI) * ((1 / S()) * Math.Atan(h() / Math.Sqrt(Math.Pow(S(), 2) - 1)) - (h() / S()) * (Math.Atan(Math.Sqrt((S() - 1) / (S() + 1)) - (A() / Math.Sqrt(Math.Pow(A(), 2) - 1)) * Math.Atan(Math.Sqrt(((A() + 1) * (S() - 1)) / ((A() - 1) * (S() + 1)))))));
        }

        /// <summary>
        /// Фактор облученности для горизонтальной площадки
        /// </summary>
        /// <returns>Фактор облученности для горизонтальной площадки</returns>
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

        /// <summary>
        /// Коэффициент пропускания теплового излучения сквозь атмосферу
        /// </summary>
        /// <returns>Коэффициент пропускания теплового излучения сквозь атмосферу</returns>
        public override double ψ()
        {
            return Math.Exp(-7.0 * Math.Pow(10, -4) * (r - (0.5 * d())));
        }
    }
}
