namespace FireAndExplosionHazards.BLL.Abstract.OverpressCalcWithOut
{
    interface IOverpressCalcWithOut_FL
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
        /// Теплоемкость воздуха
        /// </summary>
        double Cр { get; }

        /// <summary>
        /// Температура вспышки
        /// </summary>
        double Tв { get; set; }

        /// <summary>
        /// Теплота сгорания
        /// </summary>
        double Hт { get; set; }

        /// <summary>
        /// Коэффициент участия ГГ во взрыве
        /// </summary>
        double Z { get; set; }

        /// <summary>
        /// Свободный объем помещения
        /// </summary>
        double Vсвоб { get; set; }

        /// <summary>
        /// Плотность воздуха до взрыва
        /// </summary>
        double Pв { get; set; }

        /// <summary>
        /// Начальная температура воздуха
        /// </summary>
        double T0 { get; set; }

        /// <summary>
        /// Кратность воздухообмена, которую создает аварийная вентиляция
        /// </summary>
        double Aв { get; set; }

        /// <summary>
        /// Продолжительность поступления паров ЛВЖ и ГЖ в объем помещения
        /// </summary>
        double τ { get; set; }

        /// <summary>
        /// Молярная масса
        /// </summary>
        double M { get; set; }

        /// <summary>
        /// Расчетная температура
        /// </summary>
        double tp { get; set; }

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
        /// Коэффициент
        /// </summary>
        /// <returns>Коэффициент</returns>
        double K();

        /// <summary>
        /// Плотность пара при расчетной температуре
        /// </summary>
        /// <returns>Плотность пара при расчетной температуре</returns>
        double Pгп();

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
