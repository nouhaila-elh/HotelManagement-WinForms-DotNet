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
    public partial class Prestation : Form
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

        public Prestation()
        {
            InitializeComponent();

            textDescription.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textDescription.Width, textDescription.Height, 30, 30));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Prestation_Load(object sender, EventArgs e)
        {

        }

        private void BoxNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            reservations1 rsrvtnobject = db.reservations1.AsEnumerable().FirstOrDefault(s => s.id == int.Parse(BoxNom.Text));

            prestations1 prst = new prestations1() { reservations1 = rsrvtnobject,
                date_consommation = DateTime.Parse(dateDebut.Text),
                prix_prestation = float.Parse(textPrix.Text),
                description = textDescription.Text,
                type_prestation = textPrestation.Text,

            };
            db.prestations1.Add(prst);

            db.SaveChanges();

            BoxNom.ResetText();
            textPrestation.ResetText();
            textPrix.ResetText();
            textDescription.ResetText();


        }
    }
}
