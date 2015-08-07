namespace FireAndExplosionHazards.BLL.Abstract.FireLoad
{
    interface IFireLoad
    {
        /// <summary>
        /// Площадь размещения материалов пожарной нагрузки
        /// </summary>
        double S { get; set; }

        /// <summary>
        /// Количество материала из пожарной нагрузки
        /// </summary>
        double G { get; set; }

        /// <summary>
        /// Нижняя теплота сгорания материала из пожарной нагрузки
        /// </summary>
        double Qp { get; set; }

        /// <summary>
        /// Величина пожарной нагрузки
        /// </summary>
        double Q();

        /// <summary>
        /// Удельная пожарная нагрузка
        /// </summary>
        /// <returns>Удельную пожарную нагрузку</returns>
        double g();
    }
}
