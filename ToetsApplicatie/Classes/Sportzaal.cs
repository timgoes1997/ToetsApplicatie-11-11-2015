using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Sportzaal : Verhuur
    {
        public override BTWTarief BTWTarief { get { return BTWtarief; } }
        public decimal PrijsPerUur { get { return prijsPerUur; } }

        private BTWTarief BTWtarief;
        private decimal prijsPerUur;

        public Sportzaal(DateTime tijdstip, int urenVerhuurd)
            : base(tijdstip, urenVerhuurd)
        {
            this.BTWtarief = BTWTarief.Hoog;
            this.prijsPerUur = Convert.ToDecimal(250.00);
        }

        public override string ToString()
        {
            return GetType().Name + " | " + BTWTarief.ToString() + " | " + base.ToString();
        }
    }
}
