using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToetsApplicatie
{
    public class Administratie
    {
        // TODO om op polymorfisme te oefenen:
        // List<IInkopen>
        public List<Verkoop> verkopen { get; set; }
        public List<Verhuur> verhuringen { get; set; }

        public Administratie()
        {
            verkopen = new List<Verkoop>();
            verhuringen = new List<Verhuur>();
        }

        public void Voegtoe(Verhuur verhuur)
        {
            verhuringen.Add(verhuur);
        }

        public void Voegtoe(Verkoop verkoop)
        {
            verkopen.Add(verkoop);
        }

        public List<IInkomsten> Overzicht(DateTime van, DateTime tot)
        {
            List<IInkomsten> inkomsten = new List<IInkomsten>();
            foreach (Verkoop v in verkopen)
            {
                if (v.Tijdstip >= van && v.Tijdstip <= tot)
                {
                    inkomsten.Add(v);
                }
            }

            foreach (Verhuur v in verhuringen)
            {
                if (v.Tijdstip >= van && v.Tijdstip <= tot)
                {
                    inkomsten.Add(v);
                }
            }

            inkomsten.OrderByDescending(i => i.Tijdstip); 
            //gebruik maken van Icomparable in verhuur en verkoop i.p.v lambda
            // (Merel) Goed om eens te oefenen, maar voor mij is dit ook oke.

            return inkomsten;
        }

        public List<IInkomsten> Overzicht(BTWTarief tarief)
        {

            // Opgelet: je methode geeft geen inkomsten terug.

            List<IInkomsten> inkomsten = new List<IInkomsten>();
            foreach (Verkoop v in verkopen) 
           //Fout gevonden, om een van der reden is het tarief niet zichtbaar 
           // in de hoofdklasse maar wel in de subklasse.
            {
                string test = v.BTWTarief.ToString();
                string testTarief = tarief.ToString();

                if (v.BTWTarief == tarief || tarief == BTWTarief.Ongespecifeerd)
                {
                    inkomsten.Add(v);
                }
            }

            foreach (Verhuur v in verhuringen)
            {
                if (v.BTWTarief == tarief || tarief == BTWTarief.Ongespecifeerd)
                {
                    inkomsten.Add(v);
                }
            }

            inkomsten.OrderByDescending(i => i.Tijdstip); //gebruik maken van Icomparable in verhuur en verkoop i.p.v lambda

            return inkomsten;
        }

        public void Exporteer(string path, BTWTarief tarief)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine("Tarieven op basis van het gegeven tarief:");
                List<IInkomsten> inkomsten = Overzicht(tarief);
                foreach (IInkomsten i in inkomsten)
                {
                    sw.WriteLine(i.ToString());
                    // TODO tostring methode gebruiken van i.
                }
            }
        }
    }
}
