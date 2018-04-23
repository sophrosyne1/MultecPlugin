using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultecPlugin
{
    public partial class DoorOpenDialogBox : Form
    {
        private bool redPictureActive;
        private int count;
        public DoorOpenDialogBox()
        {
            this.ControlBox = false;
            InitializeComponent();
            redPictureActive = false;
            timerChangePic.Start();
        }

        private void timerChangePic_Tick(object sender, EventArgs e)
        {
            count++;
            if (count > 10)
            {
                timerChangePic.Stop();
                timerChangePic.Start();
                count = 0;
            }

            if (!redPictureActive)
            {
                pictureBox1.Image = Properties.Resources.WarnungGrey;
                redPictureActive = true;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Warnung;
                redPictureActive = false;
            }
        }

        private void DoorOpenDialogBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerChangePic.Stop();
            
        }

        
    }
}
