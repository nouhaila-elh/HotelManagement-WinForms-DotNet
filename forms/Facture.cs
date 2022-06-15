using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel.forms
{
    public partial class Facture : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(
          int nleft,
          int nTop,
          int nRight,
          int nBottom,
          int nWidthEllipse,
          int nHeightEllipse


          );
        public Facture()
        {
            InitializeComponent();

            buttonSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonSearch.Width, buttonSearch.Height, 12, 12));
            buttonGen.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonGen.Width, buttonGen.Height, 12, 12));
            BoxNom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxNom.Width, BoxNom.Height, 12, 12));
            BoxPrenom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxPrenom.Width, BoxPrenom.Height, 12, 12));
            TextDateRes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TextDateRes.Width, TextDateRes.Height, 12, 12));
            textDateArrhes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textDateArrhes.Width, textDateArrhes.Height, 12, 12));
            textDateDebut.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textDateDebut.Width, textDateDebut.Height, 12, 12));
            textDateFin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textDateFin.Width, textDateFin.Height, 12, 12));
            textSearch.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textSearch.Width, textSearch.Height, 12, 12));
            buttonImp.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonImp.Width, buttonImp.Height, 12, 12));
            buttonReset.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, buttonReset.Width, buttonReset.Height, 12, 12));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void dateDebut_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            var id_reservation = int.Parse(textSearch.Text);
            var res = db.reservations1.Where(x => x.id ==  id_reservation ).First();

            var id_client = res.clientid;

            var clt = db.clients1.Where(x => x.id == id_client).First();

            BoxNom.Text= clt.nom;
            BoxPrenom.Text = clt.prenom;
            TextDateRes.Text =  res.date_res.ToString();
            textDateArrhes.Text = res.date_pay_arrhes.ToString();
            textDateDebut.Text = res.date_debut.ToString();
            textDateFin.Text = res.date_fin.ToString();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            TextFacture.Clear();
          
            TextFacture.Text += "\n FACTURE           \n\n";

            TextFacture.Text += "Date :" + DateTime.Now + "\n\n";

            TextFacture.Text += " Nom :" + BoxNom.Text +"\n\n";
            TextFacture.Text += " Prénom :" + BoxPrenom.Text+"\n\n";
            TextFacture.Text += " TextDateRes :" + TextDateRes.Text+"\n\n";
            TextFacture.Text += " textDateArrhes :" + textDateArrhes.Text+"\n\n";
            TextFacture.Text += " textDateDebut :" + textDateDebut.Text+"\n\n";
            TextFacture.Text += " textDateFin :" + textDateFin.Text+"\n\n";

            Model1 db = new Model1();
            var id_reservation = int.Parse(textSearch.Text);
            var res = db.reservations1.Where(x => x.id == id_reservation).First();

            var prixReservation = res.prix_res;

            var prixArrhes = res.arrhes;
            
            var id_client = res.clientid;

            var clt = db.clients1.Where(x => x.id == id_client).First();

            var prestationList = db.prestations1.Where(x => x.reservationid == id_reservation).ToList();

            TextFacture.Text += " Prestation : \n\n";
            var PrixTotalePrestation = 0.0;

            foreach (var prs in prestationList)
            {
                Console.WriteLine(PrixTotalePrestation);
                TextFacture.Text += " Type de prestation : " + prs.type_prestation + "\n";
                TextFacture.Text += " Détail de prestation : " + prs.description + "\n";
                TextFacture.Text += " Prix de prestation : " + prs.prix_prestation + "\n\n";
                PrixTotalePrestation +=prs.prix_prestation;
                Console.WriteLine(PrixTotalePrestation);
            }

            TextFacture.Text += "\n Prix de réservation : " + prixReservation + " MAD\n";

            

            var prixTotale = PrixTotalePrestation + prixReservation  ;
            TextFacture.Text += "\n Prix Totale: " + prixTotale + " MAD \n";

            TextFacture.Text += "\n Arrhes : " + prixArrhes + " MAD\n";

            var prixTotalePayer = PrixTotalePrestation + prixReservation - prixArrhes;
            TextFacture.Text += "\n Prix Totale à payer  : " + prixTotalePayer + " MAD \n";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BoxNom.ResetText();
            BoxPrenom.ResetText();
            TextDateRes.ResetText();
            textDateArrhes.ResetText();
            textDateDebut.ResetText();
            textDateFin.ResetText();
            textSearch.ResetText();
            TextFacture.ResetText();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TextFacture.Text, new Font("Microsoft JhengHei",12,FontStyle.Bold),Brushes.Black,new Point(10,10));
        }

        private void buttonImp_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
