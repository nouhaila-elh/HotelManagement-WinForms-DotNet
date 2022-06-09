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

    

    public partial class hotels : Form
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
        public hotels()
        {
            InitializeComponent();
            picturehotel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picturehotel1.Width, picturehotel1.Height, 15, 15));
            panelhotel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelhotel1.Width, panelhotel1.Height, 15, 15));

            picturehotel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picturehotel2.Width, picturehotel2.Height, 15, 15));
            panelhotel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelhotel2.Width, panelhotel2.Height, 15, 15));

            picturehotel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picturehotel3.Width, picturehotel3.Height, 15, 15));
            panelhotel3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelhotel3.Width, panelhotel3.Height, 15, 15));
            
            picturehotel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picturehotel4.Width, picturehotel4.Height, 15, 15));
            panelhotel4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelhotel4.Width, panelhotel4.Height, 15, 15));

            picturehotel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picturehotel5.Width, picturehotel5.Height, 15, 15));
            panelhotel5.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelhotel5.Width, panelhotel5.Height, 15, 15));

            picturehotel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picturehotel6.Width, picturehotel6.Height, 15, 15));
            panelhotel6.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelhotel6.Width, panelhotel6.Height, 15, 15));

            picturehotel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picturehotel7.Width, picturehotel7.Height, 15, 15));
            panelhotel7.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelhotel7.Width, panelhotel7.Height, 15, 15));

            picturehotel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, picturehotel8.Width, picturehotel8.Height, 15, 15));
            panelhotel8.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panelhotel8.Width, panelhotel8.Height, 15, 15));

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picturehotel7_Click(object sender, EventArgs e)
        {

        }

        private void hotels_Load(object sender, EventArgs e)
        {

        }
    }
}
