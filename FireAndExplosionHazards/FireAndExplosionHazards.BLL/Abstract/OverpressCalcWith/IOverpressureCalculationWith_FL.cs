namespace FireAndExplosionHazards.BLL.Abstract.OverpressCalcWith
{
    interface IOverpressureCalculationWith_FL
    {
        /// <summary>
        /// Избыточное давление взрыва
        /// </summary>
        /// <returns>Избыточное давление взрыва</returns>
        double ΔР();

        /// <summary>
        /// Плотность пара при расчетной температуре
        /// </summary>
        /// <returns>Плотность пара при расчетной температуре</returns>
        double Pгп();

        /// <summary>
        ///  Стехиометрическая концентрация паров ЛВЖ и ГЖ
        /// </summary>
        /// <returns>Стехиометрическая концентрация паров ЛВЖ и ГЖ</returns>
        double Cct();

        /// <summary>
        /// Стехиометрический коэффициент кислорода в реакции горения
        /// </summary>
        /// <returns>Стехиометрический коэффициент кислорода в реакции горения</returns>
        double β();

        /// <summary>
        /// Масса паров ЛВЖ и ГЖ, которые попали в результате расчетной аварии в помещение
        /// </summary>
        /// <returns>Масса паров ЛВЖ и ГЖ</returns>
        double m();

        /// <summary>
        /// Интенсивность испарения
        /// </summary>
        /// <returns>Интенсивность испарения</returns>
        double W();

        /// <summary>
        /// Давление насыщенного пара при расчетной температуре жидкости
        /// </summary>
        /// <returns>Давление насыщенного пара</returns>
        double Pн();
    }
}
