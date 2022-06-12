using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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

            Model1 db = new Model1();
            var hotel = db.hotels.Select(u => u.nom);
            hotelbox.DataSource = hotel.ToList();

           // var hotel_id = 1; // Change this variable for your real cat_id

          /*  var query = from categorie in db.categories
                        where categorie.hotels.Any(c => c.id == hotel_id)
                        select categorie.description;

            var querycat = db.hotels.Where(c => c.id == hotel_id).SelectMany(c => c.categories.Select(u => u.id));

        */   // Console.WriteLine(querycat.ToList());
           // comboBoxcat.DataSource = query.ToList();

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

        private void comboBoxcat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Valider_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            client clnt = new client() { nom = BoxNom.Text, address =BoxAdresse.Text , prenom = BoxPrenom.Text, ville=BoxVille.Text, code_postale = int.Parse(BoxCodePostale.Text), pays = BoxPays.Text, tel = int.Parse(BoxTel.Text) , email = BoxEmail.Text};
            db.clients.Add(clnt);
            db.SaveChanges();

            var clntId = clnt.id;
            client clntobjct = db.clients.FirstOrDefault(s => s.id == clntId);

            reservation resrv = new reservation() { 
                chambreid = int.Parse(comboBox2.Text),
                clientid = clntId,
                client = clntobjct,
                date_res = DateTime.UtcNow,
                date_debut = DateTime.Parse(dateDebut.Text),
                date_fin = DateTime.Parse(dateTimePicker1.Text),
                date_pay_arrhes = DateTime.Parse(dateTimePicker2.Text)
             };

            db.reservations.Add(resrv);

            db.SaveChanges();


        }

        private void BoxNom_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
