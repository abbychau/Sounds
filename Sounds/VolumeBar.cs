using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sounds
{
    public partial class VolumeBar : Form
    {
        public VolumeBar()
        {
            InitializeComponent();


        }

        int hideCounter = 0;

        private void VolumeBar_Load(object sender, EventArgs e)
        {
            //window border
            this.FormBorderStyle = FormBorderStyle.None;

            //position is middle bottom of the screen
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                Screen.PrimaryScreen.WorkingArea.Width / 2 - this.Width / 2, 
                Screen.PrimaryScreen.WorkingArea.Height - this.Height - 90);
            //this.Size = new Size(100, 20);
            timer1.Enabled = true;

            this.Hide();
        }

        public void SetVolume(int volume)
        {
            pgVolume.Value = volume;
            lblVolume.Text = volume.ToString() + "%";
            this.Show();
            hideCounter = 30;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hideCounter > 0)
            {
                hideCounter--;
            }
            else
            {
                this.Hide();
            }
        }
    }
}
