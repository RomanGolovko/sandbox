using System.ComponentModel.DataAnnotations;
using FireAndExplosionHazards.BLL.Abstract;

namespace FireAndExplosionHazards.BLL.Concrete.OC
{
    public class CombDust : OverpressCalc
    {
        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "F - массовая доля частичек пыли размером меньше критического")]
        public double F { get; set; } = 1;      // в случае отсутствия возможности получения данных относительно массовой доли
                                                // частиц пыли размером частичек меньше критического допускается принимать F = 1;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Kвз - часть пыли, которая отложилась в помещении, способная перейти в состояние аэрозоля")]
        public double Kвз { get; set; } = 0.9;  // допускается принимать Квз = 0,9;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "mап - масса горючей пыли, которая поступает в помещение из аппарата, кг")]
        public double mап { get; set; }         // принимают в соответствии с п. 7.1.1 и п. 7.1.3;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "q - расход, с которым продолжают поступать пылевидные вещества в аварийный аппарат по трубопроводам до момента их перекрытия, кг•с^-1")]
        public double q { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "τ - время перекрывания, с")]
        public double τ { get; set; }           // определяется по п. 7.1.2в;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Kп - коэффициент пыления")]
        public double Kп { get; set; }          // в случае отсутствия экспериментальных данных допускается принимать:
                                                // для пыли с дисперсностью не меньше чем 350 мкм Кп = 0,5;
                                                // для пыли с дисперсностью меньше чем 350 мкм Кп = 1,0;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Kг - доля горючей пыли в общей массе собравшейся пыли")]
        public double Kг { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Kубор - коэффициент эффективности уборки пыли")]
        public double Kубор { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "n - количество едениц оборудования, которое пылит")]
        public double n { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "α - доля пыли, которая попадает в объем помещения и которая удаляется вытяжными вентиляционными системами")]
        public double α { get; set; } = 0;      // в случае отсутствия экспериментальных данных принимают α = 0;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "β1 - доля выделяющейся в объем помещения пыли, оседающей на труднодоступных для уборки поверхностях помещения")]
        public double β1 { get; set; }          // β1 + β2 = 1;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "β2 - доля выделяющейся в объем помещения пыли, оседающей на доступных для уборки поверхностях помещения")]
        public double β2 { get; set; }          // β1 + β2 = 1;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "M1 - масса пыли, которая попадает в объем помещения за период времени между генеральными уборками пыли, кг")]
        public double M1 { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "M2 - масса пыли, которая выделяется оборудованием, за период времени между текущими уборками, кг")]
        public double M2 { get; set; }

        public double SetZ()
        {
            return 0.5 * F;
        }

        /// <summary>
        /// Масса пыли
        /// </summary>
        /// <returns>Массу пыли</returns>
        public override double m()
        {
            return mвз() + mав();
        }

        /// <summary>
        /// Расчетная масса части отложившейся в помещении пыли, которая перешла в состояние аэрозоля
        /// </summary>
        /// <returns>Массу пыли</returns>
        public double mвз()
        {
            return Kвз * mп();
        }

        /// <summary>
        /// Расчетная масса пыли, которая поступила в помещение в результате аварийной ситуации из аппаратов 
        /// и технологического оборудования
        /// </summary>
        /// <returns>Массу пыли</returns>
        public double mав()
        {
            return (mап + q * τ) * Kп;
        }

        /// <summary>
        /// Масса пыли, которая отложилась в помещении к моменту аварии
        /// </summary>
        /// <returns>Массу пыли</returns>
        public double mп()
        {
            return Kг * (1 - Kубор) * (m1() + m2());
        }

        /// <summary>
        /// Масса пыли в труднодоступные местах
        /// </summary>
        /// <returns>Массу пыли</returns>
        public double m1()
        {
            return M1 * (1 - α) * β1;
        }

        /// <summary>
        ///  Масса пыли в доступные местах
        /// </summary>
        /// <returns>Массу пыли</returns>
        public double m2()
        {
            return M2 * (1 - α) * β2;
        }
    }
}
