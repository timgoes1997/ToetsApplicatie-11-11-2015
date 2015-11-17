using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public abstract class Verkoop : IInkomsten
    {
        public int Aantal { get; set; }
        public decimal Bedrag { get; set; }
        public DateTime Tijdstip { get; set; }

        // in abstracte klasse moet btw tarief ook abstract
        // zijn. anders krijg je 2x een property.
        public abstract BTWTarief BTWTarief { get; }

        public decimal Prijs { get { return prijs; } }

        private BTWTarief BTWtarief;
        private decimal prijs;


        public Verkoop(int aantal)
        {
            this.Aantal = aantal;
            this.Tijdstip = DateTime.Now;
        }

        public override string ToString()
        {
            return "Aantal: " + Aantal.ToString() + " | " + Tijdstip.ToString(); 
        }
    }
}
