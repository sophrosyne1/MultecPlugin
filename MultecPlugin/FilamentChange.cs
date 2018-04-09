using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;


namespace MultecPlugin
{
    public partial class FilamentChange : Form
    {
        private IHost host;
        private string tempValue;
        public FilamentChange(IHost _host)
        {
            InitializeComponent();
            
            host = _host;
            tempValue = "205";
            txtBoxTemp.Text = tempValue;
        }

        private void txtBoxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRetractT0_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M104 S" + tempValue + " T0");
                host.Connection.injectManualCommand("M109 S" + tempValue + " T0");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-50.0 F300");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-1600.0 F600");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnLoadT0_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M104 S" + tempValue + " T0");
                host.Connection.injectManualCommand("M109 S" + tempValue + " T0");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E1600.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E50.0 F200");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnRetractT1_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M104 S" + tempValue + " T1");
                host.Connection.injectManualCommand("M109 S" + tempValue + " T1");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-50.0 F300");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-1600.0 F600");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnRetractT2_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M104 S" + tempValue + " T2");
                host.Connection.injectManualCommand("M109 S" + tempValue + " T2");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-50.0 F300");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-1600.0 F600");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnRetractT3_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M104 S" + tempValue + " T3");
                host.Connection.injectManualCommand("M109 S" + tempValue + " T3");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-50.0 F300");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-1600.0 F600");
                host.Connection.injectManualCommand("G92 E0");
            }

        }

        private void btnLoadT1_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M104 S" + tempValue + " T1");
                host.Connection.injectManualCommand("M109 S" + tempValue + " T1");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E1600.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E50.0 F200");
                host.Connection.injectManualCommand("G92 E0");
            }

        }

        private void btnLoadT2_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M104 S" + tempValue + " T2");
                host.Connection.injectManualCommand("M109 S" + tempValue + " T2");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E1600.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E50.0 F200");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnLoadT3_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M104 S" + tempValue + " T3");
                host.Connection.injectManualCommand("M109 S" + tempValue + " T3");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E1600.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E50.0 F200");
                host.Connection.injectManualCommand("G92 E0");
            }
        }
    }
}
