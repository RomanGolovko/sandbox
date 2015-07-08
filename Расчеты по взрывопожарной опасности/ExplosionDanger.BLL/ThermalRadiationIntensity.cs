using System;

namespace ExplosionDanger.BLL
{
    public class ThermalRadiationIntensity
    {
        double g = 9.81;                    // ускорение свободного падения, м * с^-2;

        public bool лвжFlag { get; set; }    // флаг расчета огненного шара;
        public double Ef { get; set; }      // среднеповерхностная плотность теплового потока излучения пламени, кВт * м^-2;
        public double F { get; set; }       // площадь разлива, м^2;
        public double Mv { get; set; }      // удельная массовая скорость выгорания топлива, кг * м^-2 * с^-1;
        public double Pв { get; set; }      // плотность окружающего воздуха, кг * м^-3;
        public double r { get; set; }       // расстояние от геометрического центра пролива до облучаемого объекта, м;
        public double m { get; set; }       // масса горючего вещества, кг;


        /// <summary>
        /// Время существования "огненного шара"
        /// </summary>
        /// <returns>Время существования "огненного шара"</returns>
        public double ts()
        {
            return 0.92 * Math.Pow(m, 0.303);
        }

        /// <summary>
        /// Интенсивность теплового излучения
        /// </summary>
        /// <returns>Интенсивность теплового излучения</returns>
        public double q()
        {
            return Ef * Fq() * ψ();
        }

        /// <summary>
        ///  Эффективный диаметр разлива
        /// </summary>
        /// <returns>Эффективный диаметр разлива</returns>
        double d()
        {
            return Math.Sqrt((4 * F) / Math.PI);
        }

        /// <summary>
        /// Высота пламени
        /// </summary>
        /// <returns>Высоту пламени</returns>
        double H()
        {
            if (лвжFlag)
                return 42 * d() * Math.Pow(Mv / (Pв * Math.Sqrt(g * d())), 0.61);
            else
                return Ds() / 2;
        }

        /// <summary>
        /// Угловой коэффициент излучения
        /// </summary>
        /// <returns>Угловой коэффициент излучения</returns>
        double Fq()
        {
            if (лвжFlag)
                return Math.Sqrt(Math.Pow(Fв(), 2) + Math.Pow(Fг(), 2));
            else
                return (H() / Ds() + 0.5) / (4 * Math.Pow((Math.Pow((H() / Ds() + 0.5), 2) + Math.Pow((r / Ds()), 2)), 1.5));
        }

        /// <summary>
        /// Фактор облученности для вертикальной площадки
        /// </summary>
        /// <returns>Фактор облученности для вертикальной площадки</returns>
        double Fв()
        {
            return (1 / Math.PI) * ((1 / S()) * Math.Atan(h() / Math.Sqrt(Math.Pow(S(), 2) - 1)) - (h() / S()) * (Math.Atan(Math.Sqrt((S() - 1) / (S() + 1)) - (A() / Math.Sqrt(Math.Pow(A(), 2) - 1)) * Math.Atan(Math.Sqrt(((A() + 1) * (S() - 1)) / ((A() - 1) * (S() + 1)))))));
        }

        /// <summary>
        /// Фактор облученности для горизонтальной площадки
        /// </summary>
        /// <returns>Фактор облученности для горизонтальной площадки</returns>
        double Fг()
        {
            return (1 / Math.PI) * (((B() - (1 / S())) / Math.Sqrt(Math.Pow(B(), 2) - 1)) * Math.Atan(Math.Sqrt(((B() + 1) * (S() - 1)) / ((B() - 1) * (S() + 1)))) - ((A() - 1 / S()) / Math.Sqrt(Math.Pow(A(), 2) - 1)) * Math.Atan(Math.Sqrt(((A() + 1) * (S() - 1)) / ((A() - 1) * (S() + 1)))));
        }

        double A()
        {
            return (Math.Pow(h(), 2) + Math.Pow(S(), 2) + 1) / (2 * S());
        }
        double B()
        {
            return (1 + Math.Pow(S(), 2)) / (2 * S());
        }
        double S()
        {
            return (2 * r) / d();
        }
        double h()
        {
            return (2 * H()) / d();
        }

        /// <summary>
        /// Эффективный диаметр "огненного шара"
        /// </summary>
        /// <returns>Эффективный диаметр "огненного шара"</returns>
        double Ds()
        {
            return 5.33 * Math.Pow(m, 0.327);
        }

        /// <summary>
        /// Коэффициент пропускания теплового излучения сквозь атмосферу
        /// </summary>
        /// <returns>Коэффициент пропускания теплового излучения сквозь атмосферу</returns>
        double ψ()
        {
            if (лвжFlag)
                return Math.Exp(-7.0 * Math.Pow(10, -4) * (r - (0.5 * d())));
            else
                return Math.Exp(-7.0 * Math.Pow(10, -4) * (Math.Sqrt(Math.Pow(r, 2) + Math.Pow(H(), 2)) - (Ds() / 2)));
        }
    }
}
