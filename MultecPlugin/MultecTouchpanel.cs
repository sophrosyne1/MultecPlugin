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
using RepetierHost.view;
using RepetierHostExtender.basic;
using RepetierHostExtender.utils;
using Microsoft.Win32;


namespace MultecPlugin
{
    public partial class MultecTouchpanel : UserControl, IHostComponent
    {

        private IHost host;
        RegistryKey key;
        private RepetierHostExtender.basic.ExtruderDefinition extruderData;
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

            reset_parameters(); //function to reset all parameters and text boxes

        }
        //resets all parameters and textboxes to default
       

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
            {
                host.Connection.injectManualCommand("T0");
                selected_nozzle = "T0";
                trackBar_NozzleTemp.Value = Convert.ToInt32(text_T0_ziel.Text);
            }
        }

        private void but_T1_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("T1");
            selected_nozzle = "T1";
            trackBar_NozzleTemp.Value = Convert.ToInt32(text_T1_ziel.Text);
        }

        private void but_T2_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("T2");
            selected_nozzle = "T2";
            trackBar_NozzleTemp.Value = Convert.ToInt32(text_T2_ziel.Text);
        }

        private void but_T3_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("T3");
            selected_nozzle = "T3";
            trackBar_NozzleTemp.Value = Convert.ToInt32(text_T3_ziel.Text);
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
            {

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
                    host.LogInfo("T0_ON" + T0_On.ToString());
                   
                }
            }
        }

        private void but_T1_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
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
            try
            {
                if (trackBar_NozzleTemp.Value > 170)
                {
                    trackBar_NozzleTemp.Value = trackBar_NozzleTemp.Value - 5;
                }
                else
                {
                    MessageBox.Show("Minimum Temperature Limit reached!! Not possible to set temperature less than 170.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Ocurred! " + ex);
            }
        }
        private void but_NozzlePlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (trackBar_NozzleTemp.Value < 270)
                {
                    trackBar_NozzleTemp.Value = trackBar_NozzleTemp.Value + 5;
                }
                else
                {
                    MessageBox.Show("Minimum Temperature Limit reached!! Not possible to set temperature greater than 270.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Ocurred! " + ex);
            }
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
            try
            {
                if (trackBar_BedTemp.Value > 0)
                {
                    trackBar_BedTemp.Value = trackBar_BedTemp.Value - 5;
                }
                else
                {
                    MessageBox.Show("Minimum Temperature Limit reached!! Not possible to set temperature less than 0.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Ocurred! " + ex);
            }
        }

        private void but_BedPlus_Click(object sender, EventArgs e)
        {
            try
            {
                if (trackBar_BedTemp.Value < 100)
                {
                    trackBar_BedTemp.Value = trackBar_BedTemp.Value + 5;
                }
                else
                {
                    MessageBox.Show("Minimum Temperature Limit reached!! Not possible to set temperature greater than 100.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Ocurred! " + ex);
            }
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
                text_Bed_ziel.Text = temp_Zeil_bed;
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
            /*
            if (!host.Connection.connector.IsConnected())
            {
                but_BedMinus.Enabled = false;

            }
            else but_BedMinus.Enabled = true; */
        }

        //////////Kalibrierung//////////

        private string tool_M218 = string.Empty;


        private void but_M218_T1_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                try
                {
                    //host.Connection.analyzeResponse(, );
                    /*tool_M218 = "T1";
                    host.Connection.numExtruder = 1;
                    host.Connection.numberExtruder = 1;
                    double xoffset_value = 0;
                    
                    extruderData.ExtruderId = 1;
                    xoffset_value = extruderData.OffsetX;
                    text_M218_Y.Text = xoffset_value.ToString();
                     */   
            
                    //text_M218_X.Text = string.Format("{0:N2}", host.Connection.x);
                    //text_M218_Y.Text = string.Format("{0:N2}", host.Connection.disposeX); 
                }
                catch(Exception ex)
                {
                    MessageBox.Show("There was an error!! " + ex);
                }
               
            }
        }

        private void but_M218_T2_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                tool_M218 = "T2";
                host.Connection.numExtruder = 2;
                text_M218_X.Text = string.Format("{0:N2}", host.Connection.x);
                text_M218_Y.Text = string.Format("{0:N2}", host.Connection.y);
            }
        }

        private void but_M218_T3_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                tool_M218 = "T3";
                host.Connection.numExtruder = 3;
                //text_M218_X.Text = string.Format("{0:N2}", host.Connection.x);
                //text_M218_Y.Text = string.Format("{0:N2}", host.Connection.y);
                text_M218_Y.Text = string.Format("{0:N2}", host.Connection.disposeX);
            }
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

        

       

        
        private void timer_temp_Tick(object sender, EventArgs e)
        {
            try
            {
                if (worker.IsBusy != true)
                {
                    worker.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Ocurred! " + ex + " Temperature not updating!");
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                DoTheLoop();
            }
            else
            {
                reset_parameters();
            }
        }

        //function to remove temperature readings from textboxes
       
        //function to add temperature readings to the textboxes
        private void DoTheLoop()
        {
            text_T0_Aktuell.Text = string.Format("{0:N2}", host.Connection.getTemperature(0));
            text_T1_Aktuell.Text = string.Format("{0:N2}", host.Connection.getTemperature(1));
            text_T2_Aktuell.Text = string.Format("{0:N2}", host.Connection.getTemperature(2));
            text_T3_Aktuell.Text = string.Format("{0:N2}", host.Connection.getTemperature(3));
            text_Bed_Aktuell.Text = string.Format("{0:N2}", host.Connection.CurrentBedTemp);
            but_BedMinus.Enabled = true;
            but_BedPlus.Enabled = true;
            but_bed_OnOff.Enabled = true;
            but_NozzleMinus.Enabled = true;
            but_NozzlePlus.Enabled = true;
            but_T0.Enabled = true;
            but_T0_OnOff.Enabled = true;
            but_T1.Enabled = true;
            but_T1_OnOff.Enabled = true;
            but_T2.Enabled = true;
            but_T2_OnOff.Enabled = true;
            but_T3.Enabled = true;
            but_T3_OnOff.Enabled = true;
            but_MOVE.Enabled = true;

        }

        public void reset_parameters()
        {
            text_T0_Aktuell.Text = String.Empty;
            text_T1_Aktuell.Text = String.Empty;
            text_T2_Aktuell.Text = String.Empty;
            text_T3_Aktuell.Text = String.Empty;
            text_Bed_Aktuell.Text = String.Empty;
            trackBar_NozzleTemp.Value = 205;
            trackBar_BedTemp.Value = 60;
            temp_Zeil = trackBar_NozzleTemp.Value.ToString();
            temp_Zeil_bed = trackBar_BedTemp.Value.ToString();
            text_T0_ziel.Text = "205";
            text_T1_ziel.Text = "205";
            text_T2_ziel.Text = "205";
            text_T3_ziel.Text = "205";
            text_Bed_ziel.Text = "60";
            selected_nozzle = "T0";
            but_T0_OnOff.Text = "Aus";
            but_T1_OnOff.Text = "Aus";
            but_T2_OnOff.Text = "Aus";
            but_T3_OnOff.Text = "Aus";
            but_bed_OnOff.Text = "Aus";
            but_BedMinus.Enabled = false;
            but_BedPlus.Enabled = false;
            but_bed_OnOff.Enabled = false;
            but_NozzleMinus.Enabled = false;
            but_NozzlePlus.Enabled = false;
            but_T0.Enabled = false;
            but_T0_OnOff.Enabled = false;
            but_T1.Enabled = false;
            but_T1_OnOff.Enabled = false;
            but_T2.Enabled = false;
            but_T2_OnOff.Enabled = false;
            but_T3.Enabled = false;
            but_T3_OnOff.Enabled = false;
            but_MOVE.Enabled = false;
        }

        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            try
            {
                //RepetierHostExtender.basic.LogLine.EnableLogFile("M104");
                //RepetierHostExtender.basic.LogLine.EnableLogFile("M104 S205 T0"); 
                //listBox1.Items.Add(host.Connection.extract("M104 S205 T0", ""));
                //host.LogInfo("M119");
                listBox1.Items.Add(RepetierHostExtender.basic.LogLine.logList);
            }
            catch(Exception ex)
            {
                MessageBox.Show("There was an Error" + ex.ToString());
                
            }
        }



        private void but_Xminus_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btn_xOffset_send_Click(object sender, EventArgs e)
        {

        }

        
    }
}
