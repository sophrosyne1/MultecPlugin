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
            T0_On = false;
            T1_On = false;
            T2_On = false;
            T3_On = false;
            Bed_On = false;
            trackBar_NozzleTemp.Value = 205;
        }



        #region IHostComponent implementation

        // Name inside component repository
        public string ComponentName { get { return "Multec"; } }
        // Name for tab
        public string ComponentDescription { get { return "Multec"; } }
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

//////////Movement Controls//////////

        private double step_dist;
        private string temp_Zeil;
        private string temp_Zeil_bed;
        private bool T0_On;
        private bool T1_On;
        private bool T2_On;
        private bool T3_On;
        private bool Bed_On;
        private string selected_nozzle;

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

        private void but_Retract_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 E" + -step_dist + " F500");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G90");
        }

        private void but_Extrude_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 E" + -step_dist + " F500");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G90");
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G28");
        }

        #endregion

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

        private void but_G222_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G222");
        }

        private void but_G224_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G224");
        }

        private void but_G295_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G295");
        }

        private void but_G297_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G297");
        }

        private void but_MotorAus_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("M18");
        }

//////////Nozzle Selection and Heating//////////

        private void but_T0_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("T0");
            selected_nozzle = "T0";
        }

        private void but_T1_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("T1");
            selected_nozzle = "T1";
        }

        private void but_T2_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("T2");
            selected_nozzle = "T2";
        }

        private void but_T3_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("T3");
            selected_nozzle = "T3";
        }

        private void but_MOVE_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("T4");
            selected_nozzle = "T4";
        }

        private void but_T0_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                T0_On = !T0_On;

            if (T0_On == true)
            {
                host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T0");
                but_T0_OnOff.Text = "Ein";
                host.LogInfo("M104 S" + temp_Zeil + " T0");
                host.LogInfo(T0_On.ToString());
                
            }
            else
            {
                host.Connection.injectManualCommand("M104 S0 T0");
                but_T0_OnOff.Text = "Aus";
                host.LogInfo("T0_ON"+T0_On.ToString());
            }
        }

        private void but_T1_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                T1_On = !T1_On;

            if (T1_On == true)
            {
                host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T1");
                but_T1_OnOff.Text = "Ein";
            }
            else
            {
                host.Connection.injectManualCommand("M104 S0 T1");
                but_T1_OnOff.Text = "Aus";
            }
        }

        private void but_T2_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                T2_On = !T2_On;

            if (T2_On == true)
            {
                host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T2");
                but_T2_OnOff.Text = "Ein";
            }
            else
            {
                host.Connection.injectManualCommand("M104 S0 T2");
                but_T2_OnOff.Text = "Aus";
            }
        }

        private void but_T3_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                T3_On = !T3_On;

            if (T3_On == true)
            {
                host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T3");
                but_T3_OnOff.Text = "Ein";
            }
            else
            {
                host.Connection.injectManualCommand("M104 S0 T3");
                but_T3_OnOff.Text = "Aus";
            }
        }

        private void but_NozzleMinus_Click(object sender, EventArgs e)
        {
            trackBar_NozzleTemp.Value = trackBar_NozzleTemp.Value - 5;
        }

        private void but_NozzlePlus_Click(object sender, EventArgs e)
        {
            trackBar_NozzleTemp.Value = trackBar_NozzleTemp.Value + 5;
        }

        private void trackBar_NozzleTemp_ValueChanged(object sender, EventArgs e)
        {
            var bar = (TrackBar)sender;
            if (bar.Value % bar.SmallChange != 0)
            {
                bar.Value = bar.SmallChange * ((bar.Value + bar.SmallChange / 2) / bar.SmallChange);
            }
            if (host.Connection.connector.IsConnected())
            {
                temp_Zeil = trackBar_NozzleTemp.Value.ToString();
                if (selected_nozzle == "T0")
                {
                    text_T0_ziel.Text = temp_Zeil;
                    if (T0_On == true)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T0");
                    }
                }
                else if (selected_nozzle == "T1")
                {
                    text_T1_ziel.Text = temp_Zeil;
                    if (T1_On == true)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T1");
                    }
                }
                else if (selected_nozzle == "T2")
                {
                    text_T2_ziel.Text = temp_Zeil;
                    if (T2_On == true)
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T2");
                }
                else if (selected_nozzle == "T3")
                {
                    text_T3_ziel.Text = temp_Zeil;
                    if (T3_On == true)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T3");
                    }
                }
                else
                {

                }
            }
        }

//////////Heated Bed//////////

        private void but_bed_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                Bed_On = !Bed_On;

            if (Bed_On == true)
            {
                host.Connection.injectManualCommand("M140 S" + temp_Zeil_bed + " T5");
                but_bed_OnOff.Text = "Ein";
            }
            else
            {
                host.Connection.injectManualCommand("M140 S0 T5");
                but_bed_OnOff.Text = "Aus";
            }
        }

        private void but_BedMinus_Click(object sender, EventArgs e)
        {
            trackBar_BedTemp.Value = trackBar_BedTemp.Value - 5;
        }

        private void but_BedPlus_Click(object sender, EventArgs e)
        {
            trackBar_BedTemp.Value = trackBar_BedTemp.Value + 5;
        }

        private void trackBar_BedTemp_ValueChanged(object sender, EventArgs e)
        {
            var bar = (TrackBar)sender;
            if (bar.Value % bar.SmallChange != 0)
            {
                bar.Value = bar.SmallChange * ((bar.Value + bar.SmallChange / 2) / bar.SmallChange);
            }
            if (host.Connection.connector.IsConnected())
            {
                temp_Zeil_bed = trackBar_BedTemp.Value.ToString();
                if (Bed_On == true)
                {
                    host.Connection.injectManualCommand("M140 S" + temp_Zeil_bed + " T5");
                }
            }
        }

        private void Connection_eventResponse(string response, ref RepetierHostExtender.basic.LogLevel level)
        {
            // update position from analyzer

            text_T0_Aktuell.Text = host.Connection.ExtruderTemp.ToString();
            text_T1_Aktuell.Text = host.Connection.Analyzer.GetTemperature(1).ToString();
            text_T2_Aktuell.Text = host.Connection.Analyzer.GetTemperature(2).ToString();
            text_T3_Aktuell.Text = host.Connection.Analyzer.GetTemperature(3).ToString();
            text_Bed_Aktuell.Text = host.Connection.Analyzer.GetTemperature(5).ToString();
        }

        //////////Kalibrierung//////////

        private string tool_M218;


        private void but_M218_T1_Click(object sender, EventArgs e)
        {
            tool_M218 = "T1";
            
        }

        private void but_M218_T2_Click(object sender, EventArgs e)
        {
            tool_M218 = "T2";
        }

        private void but_M218_T3_Click(object sender, EventArgs e)
        {
            tool_M218 = "T3";
        }

        private void text_T0_Aktuell_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_tester_Click(object sender, EventArgs e)
        {
            text_T0_Aktuell.Text = host.Connection.ExtruderTemp.ToString();
            //text_T0_Aktuell.Text = host.Connection.getTemperature(0).ToString;
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
