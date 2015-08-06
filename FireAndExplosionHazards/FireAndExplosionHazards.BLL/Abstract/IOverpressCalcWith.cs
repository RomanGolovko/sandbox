namespace FireAndExplosionHazards.BLL.Abstract
{
    interface IOverpressCalcWith
    {
        /// <summary>
        /// Избыточное давление взрыва
        /// </summary>
        /// <returns>Избыточное давление взрыва</returns>
        double ΔР();

        /// <summary>
        /// Плотность газа или пара при расчетной температуре
        /// </summary>
        /// <returns>Плотность газа или пара при расчетной температуре</returns>
        double Pгп();

        /// <summary>
        ///  Стехиометрическая концентрация ГГ
        /// </summary>
        /// <returns>Стехиометрическая концентрация ГГ</returns>
        double Cct();

        /// <summary>
        /// Стехиометрический коэффициент кислорода в реакции горения
        /// </summary>
        /// <returns>Стехиометрический коэффициент кислорода в реакции горения</returns>
        double β();

        /// <summary>
        /// Масса газа, который поступил в помещение во время расчетной аварии
        /// </summary>
        /// <returns>Масса газа</returns>
        double m();
    }
}
