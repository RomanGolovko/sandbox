using System.ComponentModel.DataAnnotations;

namespace FireAndExplosionHazards.BLL.Concrete.FireLoad
{
    public class FireLoad
    {
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "S - площадь размещения материалов пожарной нагрузки, м^2")]
        public double S { get; set; }   // не менее чем 10 м^2;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "G - количество материала из пожарной нагрузки, кг")]
        public double G { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [Display(Name = "Qp - нижняя теплота сгорания материала из пожарной нагрузки, МДж/кг")]
        public double Qp { get; set; }

        /// <summary>
        /// Величина пожарной нагрузки
        /// </summary>
        /// <returns>Величину пожарной нагрузки</returns>
        public double Q()
        {
            return G * Qp;
        }

        /// <summary>
        /// Удельная пожарная нагрузка
        /// </summary>
        /// <returns>Удельную пожарную нагрузку</returns>
        public double g()
        {
            return Q() / S;
        }
    }
}
