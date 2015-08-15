using System;
using System.ComponentModel.DataAnnotations;
using FireAndExplosionHazards.BLL.Abstract;

namespace FireAndExplosionHazards.BLL.Concrete.OC
{
    public class FlamLiq : OverpressCalc
    {
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Fи - площадь испарения, м^2")]
        public double Fи { get; set; }

        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "τи - продолжительность испарения, с")]
        public double τи { get; set; }

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

        /// <summary>
        /// Масса паров ЛВЖ и ГЖ, которые попали в результате расчетной аварии в помещение
        /// </summary>
        /// <returns>Масса паров ЛВЖ и ГЖ</returns>
        public override double m()
        {
            return W() * Fи * τи;
        }

        /// <summary>
        /// Интенсивность испарения
        /// </summary>
        /// <returns>Интенсивность испарения</returns>
        public double W()
        {
            return Math.Pow(10, -6) * η * Math.Pow(M / 1000, (1.0 / 2.0)) * Pн();
        }

        /// <summary>
        /// Давление насыщенного пара при расчетной температуре жидкости
        /// </summary>
        /// <returns>Давление насыщенного пара</returns>
        public double Pн()
        {
            return 0.133 * Math.Pow(10, (A - (B / (C + tp))));
        }
    }
}
