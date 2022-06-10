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

        }
    }
}
