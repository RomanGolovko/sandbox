namespace FireAndExplosionHazards.BLL.Abstract.OverpressCalcWithOut
{
    interface IOverpressCalcWithOut_FG
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
        /// Давление в аппарате
        /// </summary>
        double P1 { get; set; }

        /// <summary>
        /// Объем аппарата
        /// </summary>
        double V { get; set; }

        /// <summary>
        /// Расход газа
        /// </summary>
        double q { get; set; }

        /// <summary>
        /// Время
        /// </summary>
        double τ712 { get; set; }

        /// <summary>
        /// Максимальное давление в трубопроводе по технологическому регламенту
        /// </summary>
        double P2 { get; set; }

        /// <summary>
        /// Внутренний радиус трубопроводов
        /// </summary>
        double r { get; set; }

        /// <summary>
        /// Длина трубопроводов от аварийного аппарата до задвижек
        /// </summary>
        double L { get; set; }

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
