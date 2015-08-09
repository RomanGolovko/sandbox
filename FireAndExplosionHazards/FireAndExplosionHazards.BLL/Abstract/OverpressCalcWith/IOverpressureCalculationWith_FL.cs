namespace FireAndExplosionHazards.BLL.Abstract.OverpressCalcWith
{
    interface IOverpressureCalculationWith_FL
    {
        /// <summary>
        /// Начальное давление
        /// </summary>
        double P0 { get; }

        /// <summary>
        /// Мольный объем
        /// </summary>
        double Vo { get; }

        /// <summary>
        /// Коэффициент негерметичности помещения и неадиабатичность процесса горения
        /// </summary>
        double Kн { get; }

        /// <summary>
        /// Температура вспышки
        /// </summary>
        double Tв { get; set; }

        /// <summary>
        /// Максимальное давление взрыва
        /// </summary>
        double Pmax { get; set; }

        /// <summary>
        /// Коэффициент участия ГГ во взрыве
        /// </summary>
        double Z { get; set; }

        /// <summary>
        /// Свободный объем помещения
        /// </summary>
        double Vсвоб { get; set; }

        /// <summary>
        /// Молярная масса
        /// </summary>
        double M { get; set; }

        /// <summary>
        /// Расчетная температура
        /// </summary>
        double tp { get; set; }

        /// <summary>
        /// Число атомов углерода в молекуле ГГ
        /// </summary>
        double Nc { get; set; }

        /// <summary>
        /// Число атомов водорода в молекуле ГГ
        /// </summary>
        double Nh { get; set; }

        /// <summary>
        /// Число атомов кислорода в молекуле ГГ
        /// </summary>
        double No { get; set; }

        /// <summary>
        /// Число атомов галогенов в молекуле ГГ
        /// </summary>
        double Nx { get; set; }

        /// <summary>
        /// Площадь испарения
        /// </summary>
        double Fи { get; set; }

        /// <summary>
        /// Продолжительность испарения
        /// </summary>
        double τи { get; set; }


        /// <summary>
        /// Коэффициент
        /// </summary>
        double η { get; set; }

        /// <summary>
        /// Константа Антуана A
        /// </summary>
        double A { get; set; }

        /// <summary>
        /// Константа Антуана B
        /// </summary>
        double B { get; set; }

        /// <summary>
        /// Константа Антуана C
        /// </summary>
        double C { get; set; }

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
