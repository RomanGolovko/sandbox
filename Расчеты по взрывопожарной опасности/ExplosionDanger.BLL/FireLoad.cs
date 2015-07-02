using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplosionDanger.BLL
{
    class FireLoad
    {
        public double S { get; set; }   // площадь размещения материалов пожарной нагрузки, м^2 (не менее чем 10 м^2);
        public double G { get; set; }   // количество материала из пожарной нагрузки, кг;
        public double Qp { get; set; }  // нижняя теплота сгорания i-гo материала из пожарной нагрузки, МДж/кг;


        public double g()
        {
            return Q() / S;
        }

        public double Q()
        {
            return G * Qp;
        }
    }
}
