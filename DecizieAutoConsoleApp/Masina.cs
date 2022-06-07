using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecizieAuto
{
    class Masina
    {
        public string nume { get; set; }
        public double pret { get; set; }
        public List<int> cheltuieli { get; set; }
        public int cai_putere { get; set; }
        public int confort { get; set; }
        public double nrTriunghiular { get; set; }
        public double gradApartPret { get; set; }
        public double gradApartCosturi { get; set; }
        public double gradApartCaiPutere { get; set; }
        public double gradApartConfort { get; set; }
        public double importanta { get; set; }
       
        public Masina(string n, double pret, List<int> cheltuieli, int cai_putere, int confort)
        {
            this.nume = n;
            this.pret = pret;
            this.cheltuieli = cheltuieli;
            this.cai_putere = cai_putere;
            this.confort = confort;
        }

        public Masina()
        {

        }
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
