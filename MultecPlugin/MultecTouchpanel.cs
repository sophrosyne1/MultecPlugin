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
using System.IO.Ports;
using System.IO;
using System.Timers;
using System.Threading;
using System.Globalization;


namespace MultecPlugin
{
    public partial class MultecTouchpanel : UserControl, IHostComponent
    {

        private IHost host;

        //event OnResponse eventResponse;
        //ExtruderDefinition extruderdata = new ExtruderDefinition(

        private bool isFormActive = true;
        private bool fineAdjustment;


        public MultecTouchpanel()
        {

            InitializeComponent();
            Trans.host.Connection.eventResponse += AddtoListBox;

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

            //reset_parameters(); //function to reset all parameters and text boxes


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
        private int count = 0;



        private void but_Zplus_Click(object sender, EventArgs e)
        {

            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 Z" + step_dist);
                host.Connection.injectManualCommand("G90");
            }
        }

        private void but_Zminus_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 Z" + -step_dist);
                host.Connection.injectManualCommand("G90");

            }
        }

        private void but_Retract_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 E" + -step_dist + " F500");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G90");
            }
        }

        private void but_Extrude_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 E" + step_dist + " F500");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G90");
            }
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
            {
                host.Connection.injectManualCommand("G295");
                host.Connection.injectManualCommand("G296");
            }
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
                if (!host.IsJobRunning)
                {
                    host.Connection.injectManualCommand("T0");
                }
                selected_nozzle = "T0";
                trackBar_NozzleTemp.Value = Convert.ToInt32(text_T0_ziel.Text);
            }
        }

        private void but_T1_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                if (!host.IsJobRunning)
                {
                    host.Connection.injectManualCommand("T1");
                }
                selected_nozzle = "T1";
                trackBar_NozzleTemp.Value = Convert.ToInt32(text_T1_ziel.Text);
            }
        }

        private void but_T2_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                if (!host.IsJobRunning)
                {
                    host.Connection.injectManualCommand("T2");
                }
                selected_nozzle = "T2";
                trackBar_NozzleTemp.Value = Convert.ToInt32(text_T2_ziel.Text);
            }
        }

        private void but_T3_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                if (!host.IsJobRunning)
                {
                    host.Connection.injectManualCommand("T3");
                }
                selected_nozzle = "T3";
                trackBar_NozzleTemp.Value = Convert.ToInt32(text_T3_ziel.Text);
            }
        }

        private void but_MOVE_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("T4");
                selected_nozzle = "T4";
            }
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
            {
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
        }

        private void but_T3_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
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
            {

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
        private int startindex;
        private int endindex;
        private string xOffset = string.Empty;
        private string yOffset = string.Empty;
        private double newOffset;


        private void but_M218_T1_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                tool_M218 = "T1";
                host.Connection.injectManualCommand("M503");

            }
        }

        private void but_M218_T2_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                tool_M218 = "T2";
                host.Connection.injectManualCommand("M503");

            }
        }

        private void but_M218_T3_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                tool_M218 = "T3";
                host.Connection.injectManualCommand("M503");
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
                //++count;
                count = count + 1;
                if (worker.IsBusy != true)
                {
                    if (count >= 10)
                    {
                        timer_temp.Stop();
                        timer_temp.Start();
                        count = 0;
                    }
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
        public void AddtoListBox(string response, ref RepetierHostExtender.basic.LogLevel level)
        {
            if (response.IndexOf("M218", StringComparison.CurrentCultureIgnoreCase) != -1)
            {

                if (tool_M218 == "T1")
                {
                    if (response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);

                        xOffset = response.Substring(startindex + 1, endindex - startindex);
                        text_M218_X.Text = xOffset;
                        startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);
                        yOffset = response.Substring(startindex + 1, endindex - startindex);
                        text_M218_Y.Text = yOffset;
                    }
                }
                else if (tool_M218 == "T2")
                {
                    if (response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);

                        xOffset = response.Substring(startindex + 1, endindex - startindex);
                        text_M218_X.Text = xOffset;
                        startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);
                        yOffset = response.Substring(startindex + 1, endindex - startindex);
                        text_M218_Y.Text = yOffset;
                    }
                }
                else if (tool_M218 == "T3")
                {
                    if (response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);

                        xOffset = response.Substring(startindex + 1, endindex - startindex);
                        text_M218_X.Text = xOffset;
                        startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);
                        yOffset = response.Substring(startindex + 1, endindex - startindex);
                        text_M218_Y.Text = yOffset;
                    }
                }
            }
            if (response.IndexOf("dz_T0_MS_opt", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                if (response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase);
                    lbl_zOffset.Text = response.Substring(startindex + 4);
                }
                else if (response.IndexOf("=", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("=", StringComparison.CurrentCultureIgnoreCase);
                    lbl_zOffset.Text = response.Substring(startindex + 1);
                }
                else startindex = 0;
                lbl_zOffset.Text = response.Substring(startindex + 1);
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
            if (!isFormActive)
            {
                enableDisableControls(true, this);
                isFormActive = true;
            }
            if (fineAdjustment)
            {
                btn_zOffset_plus.Enabled = true;
                btn_zOffset_minus.Enabled = true;
            }
            else
            {
                btn_xOffset_send.Enabled = false;
                btn_yOffset_send.Enabled = false;
            }

            if (!host.IsJobRunning)
            {

                enablDisablWhenPrinting(true);
                if (text_M218_X.Text == string.Empty || text_M218_Y.Text == string.Empty)
                {
                    host.Connection.injectManualCommand("M503");
                }
            }
            if (host.IsJobRunning)
            {
                enablDisablWhenPrinting(false);
                text_M218_X.Text = string.Empty;
                text_M218_Y.Text = string.Empty;
            }
            if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
            {
                btn_xOffset_send.Enabled = true;
                btn_yOffset_send.Enabled = true;
            }




        }
        private void enablDisablWhenPrinting(bool val)
        {
            but_G224.Enabled = val;
            but_G222.Enabled = val;
            but_MotorAus.Enabled = val;
            but_MOVE.Enabled = val;
            buttonHome.Enabled = val;
            but_step_1.Enabled = val;
            but_step_10.Enabled = val;
            but_step_50.Enabled = val;
            btnXMinus.Enabled = val;
            btnXPlus.Enabled = val;
            btnYMinus.Enabled = val;
            btnYPlus.Enabled = val;
            but_Zminus.Enabled = val;
            btnZPlus.Enabled = val;
            but_Extrude.Enabled = val;
            but_Retract.Enabled = val;
            but_G295.Enabled = val;
            but_G297.Enabled = val;
            btnFeinadjustment.Enabled = val;
            button1.Enabled = val;
            button2.Enabled = val;
            btn_xOffset_minus.Enabled = val;
            btn_xOffset_plus.Enabled = val;
            btn_xOffset_send.Enabled = val;
            btn_yOffset_minus.Enabled = val;
            btn_yOffset_plus.Enabled = val;
            btn_yOffset_send.Enabled = val;
            btn_zOffset_minus.Enabled = val;
            btn_zOffset_plus.Enabled = val;
            but_M218_T1.Enabled = val;
            but_M218_T2.Enabled = val;
            but_M218_T3.Enabled = val;
        }
        private void enableDisableControls(bool val, Control container)
        {
            foreach (Control c in container.Controls)
            {
                if (c is Panel || c is GroupBox)
                {
                    enableDisableControls(val, c);
                }
                else
                {
                    c.Enabled = val;
                }
            }
        }

        //resets all parameters and textboxes to default
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
            if (isFormActive)
            {
                enableDisableControls(false, this);
                isFormActive = false;
            }
        }

        private void myCustomButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXMinus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 X" + -step_dist);
                    host.Connection.injectManualCommand("G90");
                }
            }
        }

        private void myCustomButton3_Click(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXMinus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 X" + step_dist);
                    host.Connection.injectManualCommand("G90");
                }
            }
        }


        private void myCustomButton2_Click(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXMinus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 Y" + step_dist);
                    host.Connection.injectManualCommand("G90");
                }
            }
        }

        private void myCustomButton4_Click(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXMinus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 Y" + -step_dist);
                    host.Connection.injectManualCommand("G90");
                }
            }
        }



        public static Bitmap CombineAndResizeTwoImages(Image image1, Image image2, int width, int height)
        {
            //a holder for the result
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the images into the target bitmap
                graphics.DrawImage(image1, 0, 0, result.Width, result.Height);
                graphics.DrawImage(image2, 0, 0, result.Width, result.Height);

            }

            //return the resulting bitmap
            return result;
        }

        public bool HitTest(PictureBox control, int x, int y)
        {
            var result = false;
            if (control.Image == null)
                return result;
            var method = typeof(PictureBox).GetMethod("ImageRectangleFromSizeMode",
              System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            var r = (Rectangle)method.Invoke(control, new object[] { control.SizeMode });
            using (var bm = new Bitmap(r.Width, r.Height))
            {
                using (var g = Graphics.FromImage(bm))
                    g.DrawImage(control.Image, 0, 0, r.Width, r.Height);
                if (r.Contains(x, y) && bm.GetPixel(x - r.X, y - r.Y).A != 0)
                    result = true;
            }
            return result;
        }

        private void myCustomButton1_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 X" + -step_dist);
                host.Connection.injectManualCommand("G90");
            }
        }





        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                host.Connection.injectManualCommand("M503");
            }
            if (tabControl1.SelectedIndex == 2)
            {
                host.Connection.injectManualCommand("M513");
            }
        }

        private void btn_xOffset_plus_Click(object sender, EventArgs e)
        {
            if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
            {
                newOffset = double.Parse(text_M218_X.Text) + 0.05;
                text_M218_X.Text = newOffset.ToString();
            }
        }

        private void btn_xOffset_minus_Click(object sender, EventArgs e)
        {
            if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
            {
                newOffset = double.Parse(text_M218_X.Text) - 0.05;
                text_M218_X.Text = newOffset.ToString();
            }
        }

        private void btn_yOffset_plus_Click(object sender, EventArgs e)
        {
            if (tool_M218 != string.Empty && text_M218_Y.Text != string.Empty)
            {
                newOffset = double.Parse(text_M218_Y.Text) + 0.05;
                text_M218_Y.Text = newOffset.ToString();
            }
        }

        private void btn_yOffset_minus_Click(object sender, EventArgs e)
        {
            if (tool_M218 != string.Empty && text_M218_Y.Text != string.Empty)
            {
                newOffset = double.Parse(text_M218_Y.Text) - 0.05;
                text_M218_Y.Text = newOffset.ToString();
            }
        }

        private void btn_xOffset_send_Click(object sender, EventArgs e)
        {
            if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
            {
                host.Connection.injectManualCommand("M218 " + tool_M218 + "X " + text_M218_X.Text);
            }
        }

        private void btn_yOffset_send_Click(object sender, EventArgs e)
        {
            if (tool_M218 != string.Empty && text_M218_Y.Text != string.Empty)
            {
                host.Connection.injectManualCommand("M218 " + tool_M218 + "Y " + text_M218_Y.Text);
            }
        }

        private void btn_zOffset_plus_Click(object sender, EventArgs e)
        {
            newOffset = double.Parse(lbl_zOffset.Text) + 0.05;
            lbl_zOffset.Text = newOffset.ToString();
            host.Connection.injectManualCommand("M702 " + "D" + lbl_zOffset.Text);
        }

        private void btn_zOffset_minus_Click(object sender, EventArgs e)
        {
            newOffset = double.Parse(lbl_zOffset.Text) - 0.05;
            lbl_zOffset.Text = newOffset.ToString();
            host.Connection.injectManualCommand("M702 " + "D" + lbl_zOffset.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ms = MessageBox.Show("Warning!! The printer will now execute a home all. Make sure the Bed is clear" + Environment.NewLine +
                "Press Okay to continue", "WARNING!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ms == DialogResult.OK)
            {
                host.Connection.injectManualCommand("G222");
                host.Connection.injectManualCommand("G28");
                host.Connection.injectManualCommand("G1 Z0");
                fineAdjustment = true;
            }
        }

        private void myCustomButton1_Click_1(object sender, EventArgs e)
        {

        }



        private void myCustomButton1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXMinus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 Z" + step_dist);
                    host.Connection.injectManualCommand("G90");
                }
            }




        }
    }
}
