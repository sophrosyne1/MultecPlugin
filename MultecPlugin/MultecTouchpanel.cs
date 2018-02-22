using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RepetierHostExtender.interfaces;
using RepetierHostExtender.geom;


namespace MultecPlugin
{
    public partial class MultecTouchpanel : UserControl, IHostComponent
    {

        private IHost host;
        public MultecTouchpanel()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Store reference to host for later use
        /// </summary>
        /// <param name="_host">Host instance</param>
        public void Connect(IHost _host)
        {
            host = _host;
        }
        #region IHostComponent implementation

        // Name inside component repository
        public string ComponentName { get { return "CoolControl"; } }
        // Name for tab
        public string ComponentDescription { get { return "Cool Control"; } }
        // Used for positioning.
        public int ComponentOrder { get { return 8000; } }
        // Where to add it. We want it on the right tab.
        public PreferredComponentPositions PreferredPosition { get { return PreferredComponentPositions.SIDEBAR; } }
        // Return the UserControl.
        public Control ComponentControl { get { return this; } }

        public ThreeDView Associated3DView { get { return null; } }

        public void ComponentActivated()
        {
            //throw new NotImplementedException();
        }

        #endregion

        #region Button functions

        private void but_Xminus_Click(object sender, EventArgs e)
        {
            if(host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 X"+ -step_dist);
                host.Connection.injectManualCommand("G90");
        }

        private void but_Xplus_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 X" + step_dist);
                host.Connection.injectManualCommand("G90");
        }

        private void but_Yplus_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 Y" + step_dist);
                host.Connection.injectManualCommand("G90");
        }

        private void but_Yminus_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 Y" + -step_dist);
                host.Connection.injectManualCommand("G90");
        }

        private void but_Zplus_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 Z" + step_dist);
                host.Connection.injectManualCommand("G90");
        }

        private void but_Zminus_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 Z" + -step_dist);
                host.Connection.injectManualCommand("G90");
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G28");
        }

        #endregion

        private double step_dist;

        private void but_step_50_Click(object sender, EventArgs e)
        {
            step_dist = 50;
        }

        private void but_step_10_Click(object sender, EventArgs e)
        {
            step_dist = 10;
        }

        private void but_step_1_Click(object sender, EventArgs e)
        {
            step_dist = 1;
        }

    }
}
