using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Linq;
using System.Data.Entity;

namespace GestionHotel.forms
{
    public partial class Reservation : Form
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


        public Reservation()
        {
           
            InitializeComponent();
            
            BoxNom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxNom.Width, BoxNom.Height, 30, 30));
            BoxPrenom.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxPrenom.Width, BoxPrenom.Height, 30, 30));
            BoxAdresse.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxAdresse.Width, BoxAdresse.Height, 30, 30));
            BoxPays.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxPays.Width, BoxPays.Height, 30, 30));
            BoxVille.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxVille.Width, BoxVille.Height, 30, 30));
            BoxCodePostale.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxCodePostale.Width, BoxCodePostale.Height, 30, 30));
            BoxEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxEmail.Width, BoxEmail.Height, 30, 30));
            BoxTel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxTel.Width, BoxTel.Height, 30, 30));
            BoxArrhes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BoxArrhes.Width, BoxArrhes.Height, 30, 30));
            Valider.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Valider.Width, Valider.Height, 15, 15));
            textPrixTotale.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textPrixTotale.Width, textPrixTotale.Height, 30, 30));


            Model1 db = new Model1();
            var hotel = db.hotels.Select(u => u.nom);
            hotelbox.DataSource = hotel.ToList();

            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'postgresDataSet.categories'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.categoriesTableAdapter.Fill(this.postgresDataSet.categories);

        }

        private void hotelbox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void OnDropDownClosed(object sender, EventArgs e)
        {

            
        }

        private void comboBoxcat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void hotelbox_OnDropDownClosed(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            var hotel_name = hotelbox.SelectedItem;

            var hotel_id = db.hotels1.Where(x => x.nom == (string)hotel_name).Select(r => r.id).First();

            var query = db.hotelcategories.Include(x => x.categories1).Where(entry => entry.hotelid == hotel_id).Select(entry => entry.categories1.description);

            Console.WriteLine(query.ToList());
            comboBoxcat.DataSource = query.ToList();
        }

        private void BoxCat_OnDropDownClosed(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            var cat_description = comboBoxcat.SelectedItem;

            var cat_id = db.categories1.Where(x => x.description == (string)cat_description).Select(r => r.id).First();

            var query = db.chambres1.Where(x=> x.categorieid == cat_id && x.isreserves == false).Select(r=> r.id);

            Console.WriteLine(query.ToList());
            comboBoxchambre.DataSource = query.ToList();

        }

       

        private void Valider_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            clients1 clnt = new clients1() { nom = BoxNom.Text, address =BoxAdresse.Text , prenom = BoxPrenom.Text, ville=BoxVille.Text, code_postale = int.Parse(BoxCodePostale.Text), pays = BoxPays.Text, tel = int.Parse(BoxTel.Text) , email = BoxEmail.Text};
            db.clients1.Add(clnt);
            db.SaveChanges();

            var clntId = clnt.id;
            clients1 clntobjct = db.clients1.FirstOrDefault(s => s.id == clntId);


            // get l'id de la chambre sélectionnée :

            /*  var chambre = comboBoxcat.SelectedItem;

              var cat_id = db.categories1.Where(x => x.description == (string)cat_description).Select(r => r.id).First();

              var query = db.chambres1.Where(x => x.categorieid == cat_id && x.isreserves == false).Select(r => r.id);
  */


            reservations1 resrv = new reservations1() {
                chambreid = int.Parse(comboBoxchambre.Text),
                clientid = clntId,
                clients1 = clntobjct, // why ? 
                date_res = DateTime.UtcNow,
                date_debut = DateTime.Parse(dateDebut.Text),
                date_fin = DateTime.Parse(dateTimePicker1.Text),
                date_pay_arrhes = DateTime.Parse(dateTimePicker2.Text),
                prix_res = double.Parse(textPrixTotale.Text),
                arrhes = double.Parse(BoxArrhes.Text),
            };

            db.reservations1.Add(resrv);

            db.SaveChanges();

            // update is reserve for chambre id to true
            var Update = db.chambres1.Find(comboBoxchambre.SelectedItem);
            Update.isreserves = true;

            // Mark as Changed
            db.Entry(Update).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();


            BoxNom.ResetText();
            BoxPrenom.ResetText();
            BoxAdresse.ResetText();
            BoxPays.ResetText();
            BoxVille.ResetText();
            BoxCodePostale.ResetText();
            BoxEmail.ResetText();
            BoxTel.ResetText();
            hotelbox.ResetText();
            comboBoxcat.ResetText();
            comboBoxchambre.ResetText();
            BoxArrhes.ResetText();
            textPrixTotale.ResetText();
           

        }

        private void BoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxchambre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BoxTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BoxVille_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
