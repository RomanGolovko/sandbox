using System.ComponentModel.DataAnnotations;
using FireAndExplosionHazards.BLL.Abstract.FireLoad;

namespace FireAndExplosionHazards.BLL.Concrete.FireLoad
{
    public class FireLoad : IFireLoad
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

        
        public double Q ()
        {
            return G * Qp;
        }

        public double g()
        {
            return  Q() / S;
        }
    }
}
