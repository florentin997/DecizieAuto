using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecizieAuto
{
    class GradApartenenta
    {
        public double gradApartPret { get; set; }
        public double gradApartCosturi { get; set; }
        public double gradApartCaiPutere { get; set; }
        public double gradApartConfort { get; set; }

        public GradApartenenta(double apPret, double apCost, double apCP, double apConf)
        {
            this.gradApartPret = apPret;
            this.gradApartCosturi = apCost;
            this.gradApartCaiPutere = apCP;
            this.gradApartConfort = apConf;
        }
    }
}
