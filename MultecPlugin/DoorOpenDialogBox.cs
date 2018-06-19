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
        public bool PreventClosing { get; set; } = true;
        private bool redPictureActive;
        private int count;
        public DoorOpenDialogBox()
        {
          
            InitializeComponent();
            redPictureActive = false;
            this.ControlBox = false;
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
            if (PreventClosing)
            {
                e.Cancel = true;
            }
            else
            {
                timerChangePic.Stop();
            }
           
            
        }

        private void DoorOpenDialogBox_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                Capture = false;
                Message msg = Message.Create(Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                WndProc(ref msg);
            }
        }
    }
}
