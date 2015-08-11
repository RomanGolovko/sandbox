namespace FireAndExplosionHazards.BLL.Abstract.TermRadIntens
{
    interface ITermRadIntens_FB
    {
        /// <summary>
        /// Cреднеповерхностная плотность теплового потока излучения пламени
        /// </summary>
        double Ef { get; set; }

        /// <summary>
        /// Расстояние от геометрического центра пролива до облучаемого объекта
        /// </summary>
        double r { get; set; }

        /// <summary>
        /// Масса горючего вещества
        /// </summary>
        double m { get; set; }

        /// <summary>
        /// Интенсивность теплового излучения
        /// </summary>
        /// <returns>Интенсивность теплового излучения</returns>
        double q();

        /// <summary>
        /// Угловой коэффициент излучения
        /// </summary>
        /// <returns>Угловой коэффициент излучения</returns>
        double Fq();

        /// <summary>
        /// Высота пламени
        /// </summary>
        /// <returns>Высоту пламени</returns>
        double H();

        /// <summary>
        /// Эффективный диаметр "огненного шара"
        /// </summary>
        /// <returns>Эффективный диаметр "огненного шара"</returns>
        double Ds();

        /// <summary>
        /// Время существования "огненного шара"
        /// </summary>
        /// <returns>Время существования "огненного шара"</returns>
        double ts();

        /// <summary>
        /// Коэффициент пропускания теплового излучения сквозь атмосферу
        /// </summary>
        /// <returns>Коэффициент пропускания теплового излучения сквозь атмосферу</returns>
        double ψ();
    }
}
