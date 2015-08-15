using System;
using System.ComponentModel.DataAnnotations;
using FireAndExplosionHazards.BLL.Abstract;

namespace FireAndExplosionHazards.BLL.Concrete.TRI
{
    public class FireBall : TermRadIntens
    {
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "m - масса горючего вещества, кг")]
        public double m { get; set; }

        /// <summary>
        /// Интенсивность теплового излучения
        /// </summary>
        /// <returns>Интенсивность теплового излучения</returns>
        public override double q()
        {
            return Ef * Fq() * ψ();
        }

        /// <summary>
        /// Угловой коэффициент излучения
        /// </summary>
        /// <returns>Угловой коэффициент излучения</returns>
        public override double Fq()
        {

            return (H() / Ds() + 0.5) / (4 * Math.Pow((Math.Pow((H() / Ds() + 0.5), 2) + Math.Pow((r / Ds()), 2)), 1.5));
        }

        /// <summary>
        /// Высота пламени
        /// </summary>
        /// <returns>Высоту пламени</returns>
        public override double H()
        {
            return Ds() / 2;
        }

        /// <summary>
        /// Эффективный диаметр "огненного шара"
        /// </summary>
        /// <returns>Эффективный диаметр "огненного шара"</returns>
        public double Ds()
        {
            return 5.33 * Math.Pow(m, 0.327);
        }

        /// <summary>
        /// Время существования "огненного шара"
        /// </summary>
        /// <returns>Время существования "огненного шара"</returns>
        public double ts()
        {
            return 0.92 * Math.Pow(m, 0.303);
        }

        /// <summary>
        /// Коэффициент пропускания теплового излучения сквозь атмосферу
        /// </summary>
        /// <returns>Коэффициент пропускания теплового излучения сквозь атмосферу</returns>
        public override double ψ()
        {
            return Math.Exp(-7.0 * Math.Pow(10, -4) * (Math.Sqrt(Math.Pow(r, 2) + Math.Pow(H(), 2)) - (Ds() / 2)));
        }
    }
}
