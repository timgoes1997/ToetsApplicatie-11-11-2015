using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Sterkedrank : Verkoop
    {
        public BTWTarief BTWTarief { get { return BTWtarief; } }
        public decimal Prijs { get { return prijs; } }

        private BTWTarief BTWtarief;
        private decimal prijs;

        public Sterkedrank(int aantal)
            : base(aantal)
        {
            this.BTWtarief = BTWTarief.Hoog;
            this.prijs = Convert.ToDecimal(10);
        }

        public override string ToString()
        {
            return GetType().Name + " | " + BTWTarief.ToString() + " | " + base.ToString();
        }
    }
}
