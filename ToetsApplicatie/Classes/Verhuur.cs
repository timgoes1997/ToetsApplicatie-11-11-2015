using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public abstract class Verhuur : IInkomsten
    {
        public int UrenVerhuurd { get; set; }
        public decimal Bedrag { get; set; }
        public DateTime Tijdstip { get; set; }
        public abstract BTWTarief BTWTarief { get; }
        public decimal PrijsPerUur { get { return prijsPerUur; } }

        private BTWTarief BTWtarief;
        private decimal prijsPerUur;

        public Verhuur(DateTime tijdstip, int urenVerhuurd)
        {
            this.Tijdstip = tijdstip;
            this.UrenVerhuurd = urenVerhuurd;
        }

        public override bool Equals(Object a)
        {
            if (a is Verhuur)
            {
                Verhuur b = (Verhuur)a;
                return this.Tijdstip.Equals(b.Tijdstip) && this.PrijsPerUur == b.PrijsPerUur && this.UrenVerhuurd == b.UrenVerhuurd && this.GetType().Equals(a.GetType()); ;
            }
            return false;
        }
        public override string ToString()
        {
            return Tijdstip + " | " + UrenVerhuurd;
        }
    }
}
