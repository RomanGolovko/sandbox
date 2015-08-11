namespace FireAndExplosionHazards.BLL.Abstract.TermRadIntens
{
    interface ITermRadIntens_FL
    {
        /// <summary>
        /// Ускорение свободного падения
        /// </summary>
        double g { get; }

        /// <summary>
        /// Cреднеповерхностная плотность теплового потока излучения пламени
        /// </summary>
        double Ef { get; set; }

        /// <summary>
        /// Площадь разлива
        /// </summary>
        double F { get; set; }

        /// <summary>
        /// Удельная массовая скорость выгорания топлива
        /// </summary>
        double Mv { get; set; }

        /// <summary>
        /// Плотность окружающего воздуха
        /// </summary>
        double Pв { get; set; }

        /// <summary>
        /// Расстояние от геометрического центра пролива до облучаемого объекта
        /// </summary>
        double r { get; set; }

        /// <summary>
        /// Интенсивность теплового излучения
        /// </summary>
        /// <returns>Интенсивность теплового излучения</returns>
        double q();

        /// <summary>
        /// Эффективный диаметр разлива
        /// </summary>
        /// <returns>Эффективный диаметр разлива</returns>
        double d();

        /// <summary>
        /// Высота пламени
        /// </summary>
        /// <returns>Высоту пламени</returns>
        double H();

        /// <summary>
        /// Угловой коэффициент излучения
        /// </summary>
        /// <returns>Угловой коэффициент излучения</returns>
        double Fq();

        /// <summary>
        /// Фактор облученности для вертикальной площадки
        /// </summary>
        /// <returns>Фактор облученности для вертикальной площадки</returns>
        double Fв();

        /// <summary>
        /// Фактор облученности для горизонтальной площадки
        /// </summary>
        /// <returns></returns>
        double Fг();

        double A();
        double B();
        double S();
        double h();

        /// <summary>
        /// Коэффициент пропускания теплового излучения сквозь атмосферу
        /// </summary>
        /// <returns>Коэффициент пропускания теплового излучения сквозь атмосферу</returns>
        double ψ();
    }
}
