using System.ComponentModel.DataAnnotations;

namespace FireAndExplosionHazards.BLL.Abstract
{
    public abstract class TermRadIntens
    {
        /// <summary>
        /// Cреднеповерхностная плотность теплового потока излучения пламени
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Ef - среднеповерхностная плотность теплового потока излучения пламени, кВт * м^-2")]
        public double Ef { get; set; }

        /// <summary>
        /// Расстояние
        /// </summary>
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "r - расстояние, м")]
        public double r { get; set; }

        /// <summary>
        /// Интенсивность теплового излучения
        /// </summary>
        /// <returns>Интенсивность теплового излучения</returns>
        public abstract double q();

        /// <summary>
        /// Угловой коэффициент излучения
        /// </summary>
        /// <returns>Угловой коэффициент излучения</returns>
        public abstract double Fq();

        /// <summary>
        /// Высота пламени
        /// </summary>
        /// <returns>Высоту пламени</returns>
        public abstract double H();

        /// <summary>
        /// Коэффициент пропускания теплового излучения сквозь атмосферу
        /// </summary>
        /// <returns>Коэффициент пропускания теплового излучения сквозь атмосферу</returns>
        public abstract double ψ();
    }
}
