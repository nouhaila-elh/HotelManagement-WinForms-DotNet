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

            var hotel_id = db.hotels.Where(x => x.nom == (string)hotel_name).Select(r => r.id).First();

            var query = db.hotelcategories.Include(x => x.category).Where(entry => entry.hotelid == hotel_id).Select(entry => entry.category.description);

            Console.WriteLine(query.ToList());
            comboBoxcat.DataSource = query.ToList();
        }

        private void BoxCat_OnDropDownClosed(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            var cat_description = comboBoxcat.SelectedItem;

            var cat_id = db.categories.Where(x => x.description == (string)cat_description).Select(r => r.id).First();

            var query = db.chambres.Where(x=> x.categorieid == cat_id).Select(r=> r.id);

            Console.WriteLine(query.ToList());
            comboBoxchambre.DataSource = query.ToList();

        }
    }
}
