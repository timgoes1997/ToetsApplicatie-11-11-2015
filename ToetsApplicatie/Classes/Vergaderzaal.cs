using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Vergaderzaal : Verhuur
    {
        public BTWTarief BTWTarief { get { return BTWtarief; } }
        public decimal PrijsPerUur { get { return prijsPerUur; } }

        private BTWTarief BTWtarief;
        private decimal prijsPerUur;

        public Vergaderzaal(DateTime tijdstip, int urenVerhuurd) 
            : base(tijdstip, urenVerhuurd)
        {
            this.BTWtarief = BTWTarief.Hoog;
            this.prijsPerUur = Convert.ToDecimal(40.00);
        }

        public override string ToString()
        {
            return GetType().Name + " | " + BTWTarief.ToString() + " | " + base.ToString();
        }
    }
}
