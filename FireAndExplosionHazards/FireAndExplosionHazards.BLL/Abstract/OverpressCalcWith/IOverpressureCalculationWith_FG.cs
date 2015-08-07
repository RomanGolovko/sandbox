namespace FireAndExplosionHazards.BLL.Abstract.OverpressCalcWith
{
    interface IOverpressureCalculationWith_FG
    {
        /// <summary>
        /// Начальное давление
        /// </summary>
        double P0 { get; }

        /// <summary>
        /// Мольный объем
        /// </summary>
        double Vo { get ; }

        /// <summary>
        /// Коэффициент негерметичности помещения и неадиабатичность процесса горения
        /// </summary>
        double Kн { get ; }

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
