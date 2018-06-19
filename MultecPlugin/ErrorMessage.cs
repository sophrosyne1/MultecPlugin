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
    public partial class ErrorMessage : Form
    {
        
       
       
        private bool PreventClosing = true;
        public ErrorMessage(string msg)
        {
           
            InitializeComponent();
            DynamicText.Text = msg;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PreventClosing = false;
            this.Close();
           
        }

        private void ErrorMessage_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void ErrorMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (PreventClosing)
            {
                e.Cancel= true;
            }
        }
    }
}
