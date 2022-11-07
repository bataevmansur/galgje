using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Galgje
{
    public partial class Galgje : Form
    {
        public Galgje()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                FormBorderStyle = FormBorderStyle.None;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        bool muisdown = false;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            muisdown = true;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (muisdown)
            {
                int mousex = MousePosition.X;
                int mousy = MousePosition.Y;
                this.SetDesktopLocation(mousex, mousy);
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            muisdown = false;
        }
    }
}
