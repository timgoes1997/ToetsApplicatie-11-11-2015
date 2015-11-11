using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToetsApplicatie
{
    public partial class Form1 : Form
    {
        private Administratie admin;

        public Form1()
        {
            InitializeComponent();
            admin = new Administratie();
            /*
            cbOverzichtBTW.Items.Add(BTWTarief.Hoog.ToString());
            cbOverzichtBTW.Items.Add(BTWTarief.Laag.ToString());
            cbOverzichtBTW.Items.Add(BTWTarief.Ongespecifeerd.ToString());*/
        }

        private void btnNieuweVerhuringToevoegen_Click(object sender, EventArgs e)
        {
            if (cbNieuweVerhuring.SelectedItem != null)
            {
                if (cbNieuweVerhuring.SelectedItem.ToString() == "Feestzaal")
                {
                    admin.Voegtoe(new Feestzaal(dtpNieuweVerhuringTijdstip.Value, Convert.ToInt32(nudNieuweVerhuringUren.Value)));
                }
                if (cbNieuweVerhuring.SelectedItem.ToString() == "Sportzaal")
                {
                    admin.Voegtoe(new Sportzaal(dtpNieuweVerhuringTijdstip.Value, Convert.ToInt32(nudNieuweVerhuringUren.Value)));
                }
                if (cbNieuweVerhuring.SelectedItem.ToString() == "Vergaderzaal")
                {
                    admin.Voegtoe(new Vergaderzaal(dtpNieuweVerhuringTijdstip.Value, Convert.ToInt32(nudNieuweVerhuringUren.Value)));
                }
                RefreshVerhuurBox(); 
            }
            else
            {
                MessageBox.Show("Er is niets in de combobox gevult");
            }
        }

        private void RefreshVerhuurBox()
        {
            lbVerhuringen.Items.Clear();
            foreach (Verhuur v in admin.verhuringen)
            {
                lbVerhuringen.Items.Add(v.ToString());
            }
        }

        private void btnNieuweVerkoopToevoegen_Click(object sender, EventArgs e)
        {
            if (cbNieuweVerkoop.SelectedItem != null)
            {
                if (cbNieuweVerkoop.SelectedItem.ToString() == "Frisdrank")
                {
                    admin.Voegtoe(new Frisdrank(Convert.ToInt32(nudNieuweVerkoopAantal.Value)));
                }
                if (cbNieuweVerkoop.SelectedItem.ToString() == "Snack")
                {
                    admin.Voegtoe(new Snack(Convert.ToInt32(nudNieuweVerkoopAantal.Value)));
                }
                if (cbNieuweVerkoop.SelectedItem.ToString() == "Sterkedrank")
                {
                    admin.Voegtoe(new Sterkedrank(Convert.ToInt32(nudNieuweVerkoopAantal.Value)));
                }
                RefreshVerkoopBox();
            }
            else
            {
                MessageBox.Show("Er is niets in de combobox gevult");
            }
        }

        private void RefreshVerkoopBox()
        {
            lbVerkopen.Items.Clear();
            foreach (Verkoop v in admin.verkopen)
            {
                lbVerkopen.Items.Add(v.ToString());
            }
        }

        private void btnOverzichtDatumbereik_Click(object sender, EventArgs e)
        {
            if (cbOverzichtBTW.SelectedItem != null)
            {
                if (cbOverzichtBTW.SelectedItem.ToString() == "Ongespecificeerd")
                {
                    SorteerBijDatum();
                }
                else if (cbOverzichtBTW.SelectedItem.ToString() == "Hoog")
                {
                    SorteerOpBTW(BTWTarief.Hoog);
                }
                else
                {
                    SorteerOpBTW(BTWTarief.Laag);
                }
            }
            else
            {
                SorteerBijDatum();
            }
        }

        private void SorteerOpBTW(BTWTarief BTWtarief)
        {
            List<IInkomsten> inkomsten = admin.Overzicht(BTWtarief);
            string msgBoxString = "";
            foreach (IInkomsten i in inkomsten)
            {
                if (i is Verkoop)
                {
                    Verkoop verkoop = (Verkoop)i;
                    msgBoxString = msgBoxString + VerkoopString(verkoop) + Environment.NewLine;
                }
                else if (i is Verhuur)
                {
                    Verhuur verhuur = (Verhuur)i;
                    msgBoxString = msgBoxString + VerhuurString(verhuur) + Environment.NewLine;
                }
                else
                {
                    msgBoxString = msgBoxString + "Onbekend item";
                }
            }
            MessageBox.Show(msgBoxString);
        }

        private void SorteerBijDatum()
        {
            List<IInkomsten> inkomsten = admin.Overzicht(dtpOverzichtVan.Value, dtpOverzichtTot.Value);
            string msgBoxString = "";
            foreach (IInkomsten i in inkomsten)
            {
                if (i is Verkoop)
                {
                    Verkoop verkoop = (Verkoop)i;
                    msgBoxString = msgBoxString + VerkoopString(verkoop) + Environment.NewLine;
                }
                else if (i is Verhuur)
                {
                    Verhuur verhuur = (Verhuur)i;
                    msgBoxString = msgBoxString + VerhuurString(verhuur) + Environment.NewLine;
                }
                else
                {
                    msgBoxString = msgBoxString + "Onbekend item";
                }
            }
            MessageBox.Show(msgBoxString);
        }

        private string VerkoopString(Verkoop verkoop)
        {
            if (verkoop is Frisdrank)
            {
                Frisdrank f = (Frisdrank)verkoop;
                return f.ToString();
            }
            if (verkoop is Snack)
            {
                Snack snack = (Snack)verkoop;
                return snack.ToString();
            }
            if (verkoop is Sterkedrank)
            {
                Sterkedrank sterkedrank = (Sterkedrank)verkoop;
                return sterkedrank.ToString();
            }
            return "";
        }

        private string VerhuurString(Verhuur verhuur)
        {
            if (verhuur is Feestzaal)
            {
                Feestzaal f = (Feestzaal)verhuur;
                return f.ToString();
            }
            if (verhuur is Sportzaal)
            {
                Sportzaal s = (Sportzaal)verhuur;
                return s.ToString();
            }
            if (verhuur is Vergaderzaal)
            {
                Vergaderzaal v = (Vergaderzaal)verhuur;
                return v.ToString();
            }
            return "";
        }

        private void btnOverzichtExporteer_Click(object sender, EventArgs e)
        {
            if (cbOverzichtBTW.SelectedItem != null)
            {
                if (cbOverzichtBTW.SelectedItem.ToString() == "Hoog")
                {
                    admin.Exporteer(filename(), BTWTarief.Hoog);
                }
                if (cbOverzichtBTW.SelectedItem.ToString() == "Laag")
                {
                    admin.Exporteer(filename(), BTWTarief.Laag);
                }
                if (cbOverzichtBTW.SelectedItem.ToString() == "Ongespecifeerd")
                {
                    admin.Exporteer(filename(), BTWTarief.Ongespecifeerd);
                }
            }
            else
            {
                MessageBox.Show("U moet een btw tarief selecteren");
            }
        }

        //Voor pad van tekstbestand.
        public string filename()
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.FileName = "Log.txt";
            fd.Filter = ".txt file|*.txt";
            DialogResult d = fd.ShowDialog();
            string file = "";
            if (d == DialogResult.OK)
            {
                file = fd.FileName;
            }
            return file;
        }
    }
}
