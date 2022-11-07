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
    public partial class Loadingscreen : Form
    {
        public Loadingscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Main form = new Main();
                form.Show();
            }
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            muisdown = true;

        }
        bool muisdown = false;
        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (muisdown)
            {
                int mousex = MousePosition.X;
                int mousy = MousePosition.Y;
                this.SetDesktopLocation(mousex, mousy);
            }
        }

        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            muisdown = false;

        }

        private void topPanel_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
