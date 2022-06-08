using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionHotel
{
    public partial class Home : Form
    {
        private Button CurrentButton;
        private Form activeForm;
        public Home()
        {
            InitializeComponent();
        }

        void ActivateButton(Object btnSender)
        {
            if(btnSender != null)
            {
                if(CurrentButton != (Button)btnSender)
                {
                    disableButton();
                    Color color = Color.FromArgb(255, 191, 0);
                    CurrentButton = (Button)btnSender;
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;

                }
            }
        }


        void disableButton()
        {
            foreach(Control previousbtn in panelMenu.Controls)
            {
                if(previousbtn.GetType() == typeof(Button))
                {
                   previousbtn.BackColor = Color.DimGray;
                   previousbtn.ForeColor = Color.White;
                   

                     
                }
            }
        }


        void OpenChildForm(Form childform, Object btnsender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
              
            }
            ActivateButton(btnsender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.PanelChild.Controls.Add(childform);
            this.PanelChild.Tag = childform;
            childform.BringToFront();
            childform.Show();
            label1.Text = childform.Text;

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new forms.Reservation(), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new forms.hotels(),sender);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new forms.Clients(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new forms.Consommation(), sender);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
