using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplosionDanger.BLL
{
    public class ExplosionParticipation
    {
        public double Z { get; private set; }           // Коэффициент Z участия горючих газов и паров легковоспламеняющихся веществ во
                                                        // взрыве и заданном уровне значимости Q(С > |c)
        public double C0 { get; private set; }          // предэкспоненциальный множитель, % (об.);
        public double m { get; set; }                   // масса газа или паров ЛВЖ, поступающих в помещение 
                                                        // (в соответствии с разделом 7 НАПБ Б.03.002-2007), кг;
        public double δ { get; set; }                   // допустимые отклонения концентрации при задаваемом уровне значимости Q(С > |c), 
                                                        // приведены в таблице НАПБ Б.03.002-2007)
        public double Xнкпр { get; set; }               // расстояния по оси X от источника поступления газа или пара, ограниченные нижним 
                                                        // концентрационным пределом распространения пламени соответственно, м;
        public double Yнкпр { get; set; }               // расстояния по оси Y от источника поступления газа или пара, ограниченные нижним 
                                                        // концентрационным пределом распространения пламени соответственно, м;
        public double Zнкпр { get; set; }               // расстояния по оси Z от источника поступления газа или пара, ограниченные нижним 
                                                        // концентрационным пределом распространения пламени соответственно, м;
        public double L { get; set; }                   // длина помещения, м;
        public double S { get; set; }                   // ширина помещения , м;
        public double H { get; set; }                   // высота помещения, м;
        public double F { get; set; }                   // площадь пола помещения, м^2;
        public double U { get; set; }                   // подвижность воздушного пространства, м • с^(-1);
        public double Сн { get; set; }                  // концентрация насыщенных паров при расчетной 
                                                        // температуре t, °C, воздуха в помещении, % (об.);
        public double Рн { get; set; }                  // давление насыщенных паров при расчетной температуре
                                                        // (принимается по справочным данным ), кПа;
        public double Р0 { get { return 101.3; } }      // атмосферное давление, равняется 101,3 кПа;
        public double Сзв { get; set; }                 // 
        public double j { get { return 1.9; } }         // эффективный коэффициент избытка горючего вещества, который принимается равным 1,9;
        public double Сст { get; set; }                 // стехиометрическая концентрация;
        public double K1гг { get { return 1.1314; } }   // коэфициент для горючих газов (ГГ);
        public double K1лв { get { return 1.1314; } }   // коэфициент для легковоспламеняющихся веществ (ЛВ);
        public double K2гг { get { return 1; } }        // коэфициент для горючих газов (ГГ);
        public double K2лв { get { return τ / 3600; } } // коэфициент для легковоспламеняющихся веществ (ЛВ);
        public double K3ггбд { get { return 0.0253; } } // коэфициент для горючих газов (ГГ) при отсутствии движения воздушной среды;
        public double K3ггд { get { return 0.02828; } } // коэфициент для горючих газов (ГГ) при движения воздушной среды;
        public double K3лвбд { get { return 0.04714; } }// коэфициент для легковоспламеняющихся веществ (ЛВ) 
                                                        // при отсутствии движения воздушной среды;
        public double K3лвд { get { return 0.3536; } }  // коэфициент для легковоспламеняющихся веществ (ЛВ) при движения воздушной среды;
        public double τ { get; set; }                   // продолжительность поступления паров ЛВЖ во внешнюю среду, с; 
        public double Cснкр { get; set; }               // нижний концентрационный предел распространения пламени ГГ или паров ЛВЖ, % (об.);
        public double Pгп { get; set; }                 // плотность газа или пара при расчетной температуре tp, кг • м^-3;

        public double SetZ ()
        {
            if ((Xнкпр <= ((1 / 2) * L)) && (Yнкпр <= ((1 / 2) * S)))
                return Z = ((5 * Math.Pow(10, -3) * Math.PI) / m) * Pгп * (C0 + (Cснкр / δ)) * Xнкпр * Yнкпр * Zнкпр;
            else if ((Xнкпр > ((1 / 2) * L)) && (Yнкпр > ((1 / 2) * S)))
                return Z = ((5 * Math.Pow(10, -3)) / m) * Pгп * (C0 + (Cснкр / δ)) * F * Zнкпр;
            else
                throw new Exception();
        }
        public void SetCн(double Рн, double P0)
        {
            Сн = 100 * (Рн / P0);
        }
        public void SetAllнкпр(double δ, double C0, double Cснкр, double K1, double K2, double K3, double L, double S, double H)
        {
            double log = Math.Log((δ * C0) / Cснкр);
            if (log > 0)
            {
                Xнкпр = K1 * L * Math.Pow((K2 * log), 0.5);
                Yнкпр = K1 * S * Math.Pow((K2 * log), 0.5);
                Zнкпр = K3 * H * Math.Pow((K2 * log), 0.5);
            }
            else
            {
                Xнкпр = K1 * L * Math.Pow((K2 * 0), 0.5);
                Yнкпр = K1 * S * Math.Pow((K2 * 0), 0.5);
                Zнкпр = K3 * H * Math.Pow((K2 * 0), 0.5);
            }
        }
    }
}
