using System;

namespace ExplosionDanger.BLL
{
    public class ThermalRadiationIntensity
    {
        double g = 9.81;                    // ускорение свободного падения, м * с^-2;

        public bool ошFlag { get; set; }    // флаг расчета огненного шара;
        public double Ef { get; set; }      // среднеповерхностная плотность теплового потока излучения пламени, кВт * м^-2;
        public double F { get; set; }       // площадь разлива, м^2;
        public double Mv { get; set; }      // удельная массовая скорость выгорания топлива, кг * м^-2 * с^-1;
        public double Pв { get; set; }      // плотность окружающего воздуха, кг * м^-3;
        public double r { get; set; }       // расстояние от геометрического центра пролива до облучаемого объекта, м;
        public double m { get; set; }       // масса горючего вещества, кг;

        public double q()
        {
            return Ef * Fq() * ψ();
        }

        public double d()
        {
            return Math.Sqrt((4 * F) / Math.PI);
        }

        public double H()
        {
            if (!ошFlag)
                return 42 * d() * Math.Pow(Mv / (Pв * Math.Sqrt(g * d())), 0.61);
            else
                return Ds() / 2;
        }

        double Fq()
        {
            if (!ошFlag)
                return Math.Sqrt(Math.Pow(Fв(), 2) + Math.Pow(Fг(), 2));
            else
                return (H() / Ds() + 0.5) / (4 * Math.Pow((Math.Pow((H() / Ds() + 0.5), 2) + Math.Pow((r / Ds()), 2)), 1.5));
        }

        double Fв()
        {
            return (1 / Math.PI) * ((1 / S()) * Math.Atan(h() / Math.Sqrt(Math.Pow(S(), 2) - 1)) - (h() / S()) * (Math.Atan(Math.Sqrt((S() - 1) / (S() + 1)) - (A() / Math.Sqrt(Math.Pow(A(), 2) - 1)) * Math.Atan(Math.Sqrt(((A() + 1) * (S() - 1)) / ((A() - 1) * (S() + 1)))))));
        }

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

        double Ds()
        {
            return 5.33 * Math.Pow(m, 0.327);
        }

        double ψ()
        {
            if (!ошFlag)
                return Math.Exp(-7.0 * Math.Pow(10, -4) * (r - (0.5 * d())));
            else
                return Math.Exp(-7.0 * Math.Pow(10, -4) * (Math.Sqrt(Math.Pow(r, 2) + Math.Pow(H(), 2)) - (Ds() / 2)));
        }
    }
}
