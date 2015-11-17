using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Snack : Verkoop
    {
        public override BTWTarief BTWTarief { get { return BTWtarief; } }
        public decimal Prijs { get { return prijs; } }

        private BTWTarief BTWtarief;
        private decimal prijs;

        public Snack(int aantal)
            : base(aantal)
        {
            this.BTWtarief = BTWTarief.Laag;
            this.prijs = Convert.ToDecimal(3);
        }

        public override string ToString()
        {
            return GetType().Name + " | " + BTWTarief.ToString() + " | " + base.ToString();
        }
    }
}
