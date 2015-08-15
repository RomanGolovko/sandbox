using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FireAndExplosionHazards.BLL.Abstract
{
    public abstract class OverpressCalcWith
    {
        /// <summary>
        /// Начальное давление
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public double P0 { get { return 101.3; } }  // допускается принимать таким, что равняется 101,3 кПа;

        /// <summary>
        /// Мольный объем
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public double Vo { get { return 22.413; } } // 22,413 м^3• кмоль^(-1);

        /// <summary>
        /// Коэффициент негерметичности помещения и неадиабатичность процесса горения
        /// </summary>
        [HiddenInput(DisplayValue = false)]
        public double Kн { get { return 3; } }      // допускается принимать равным 3;

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Tв - температура вспышки, °С")]
        public double Tв { get; set; }

        [Required(ErrorMessage = "Поле должно быть установлено")]
        [RegularExpression("[0-9.,]*", ErrorMessage = "Некорректный ввод, толко цифры")]
        [Display(Name = "Pmax - максимальное давление взрыва стехиометрической газовоздушной смеси в закрытом объеме, кПа")]
        public double Pmax { get; set; } = 900;     // определяется исследовательским путем или
                                                    // принимается по справочным данным согласно требованиям п. 5.4. В случае 
                                                    // отсутствия таких данных, допускается принимать Рmах таким, что равняется 900; 

        [Display(Name = "Z - коэффициент участия вещества во взрыве")]
        public double Z { get; set; }

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

        /// <summary>
        /// Избыточное давление взрыва
        /// </summary>
        /// <returns>Избыточное давление взрыва</returns>
        public double ΔР()
        {
            return (Pmax - P0) * ((m() * Z) / (Vсвоб * Pгп())) * (100 / Cct()) * (1 / Kн);
        }

        /// <summary>
        /// Плотность газа или пара при расчетной температуре
        /// </summary>
        /// <returns>Плотность газа или пара при расчетной температуре</returns>
        public double Pгп()
        {
            return M / (Vo * (1 + 0.00367 * tp));
        }

        /// <summary>
        ///  Стехиометрическая концентрация веществ
        /// </summary>
        /// <returns>Стехиометрическая концентрация веществ</returns>
        public double Cct()
        {
            return 100 / (1 + 4.84 * β());
        }

        /// <summary>
        /// Стехиометрический коэффициент кислорода в реакции горения
        /// </summary>
        /// <returns>Стехиометрический коэффициент кислорода в реакции горения</returns>
        public double β()
        {
            return Nc + ((Nh - Nx) / 4) - (No / 2);
        }

        /// <summary>
        /// Масса газа, который поступил в помещение во время расчетной аварии
        /// </summary>
        /// <returns>Масса газа</returns>
        public abstract double m();
    }
}
