using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplotionDanger.DAL
{
    public class Data
    {
        public Dictionary<string, double>Z = new Dictionary<string, double>(5);
        public Data()
        {
            Z.Add("Водород", 1.0);
            Z.Add("ГГ (кроме водорода)", 0.5);
            Z.Add("ЛВЖ и ГЖ, которые нагреты до температуры вспышки и выше", 0.3);
            Z.Add("ЛВЖ и ГЖ, которые нагреты ниже температуры вспышки, при условии возможности образования аэрозоля", 0.3);
            Z.Add("ЛВЖ и ГЖ, которые нагреты ниже температуры вспышки, при условии невозможности образования аэрозоля", 0.0);
        }
    }
}
