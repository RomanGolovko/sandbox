namespace FireAndExplosionHazards.BLL.Abstract.OverpressCalcWith
{
    interface IOverpressureCalculationWith_FG
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

        /// <summary>
        /// Объем газа, который вышел из аппарата
        /// </summary>
        /// <returns>Объем газа</returns>
        double Vа();

        /// <summary>
        /// Объем газа, который вышел из трубопроводов
        /// </summary>
        /// <returns>Объем газа</returns>
        double Vт();

        /// <summary>
        /// Объем газа, который вышел из трубопровода до перекрытия
        /// </summary>
        /// <returns>Объем газа</returns>
        double V1т();

        /// <summary>
        /// Объем газа, который вышел из трубопровода после перекрытия
        /// </summary>
        /// <returns>Объем газа</returns>
        double V2т();
    }
}
