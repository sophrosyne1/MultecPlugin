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
            Trans.host.Connection.eventConnectionChange += PrinterConnectionChange;

        }
        /// <summary>
        /// Store reference to host for later use
        /// </summary>
        /// <param name="_host">Host instance</param>
        /// 
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

        private double step_dist= 1;
        private string temp_Zeil;
        private string temp_Zeil_bed;
        private bool T0_On;
        private bool T1_On;
        private bool T2_On;
        private bool T3_On;
        private bool Bed_On;
        private string selected_nozzle;
        private int count = 0;
        private string zOffset_T0;
        private string zOffset_T1;
        private string zOffset_T2;
        private string zOffset_T3;
        private string rotationOffset;
        private string rotationOffsetFilament;
        private string abstand;
        private string optimal_Abstand;
        private string zKorrektur;
        private int lifetimeCheck = 0;
        private string[] gCode = new string[5];
        private int gCodeIndex = 0;
        private int getPrev_gCodeUp = 5;
        private int getPrev_gCodeDown = 0;
        private bool coldextrusionActive = false;
        private bool firstG222 = false;
        private int gCodeCheck = 0;
        private string maxGCodeValue;



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
            but_step_1.Enabled = true;
            but_step_10.Enabled = true;
            but_step_50.Enabled = false;
            step_dist = 50;
        }

        private void but_step_10_Click(object sender, EventArgs e)
        {
            but_step_1.Enabled = true;
            but_step_10.Enabled = false;
            but_step_50.Enabled = true;
            step_dist = 10;
        }

        private void but_step_1_Click(object sender, EventArgs e)
        {
            but_step_1.Enabled = false;
            but_step_10.Enabled = true;
            but_step_50.Enabled = true;
            step_dist = 1;
        }

        private void but_G222_Click(object sender, EventArgs e)
        {
           
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
                host.Connection.injectManualCommand("M503");      
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
                btnT0.Enabled = true;
                btnT1.Enabled = false;
                btnT2.Enabled = true;
                btnT3.Enabled = true;
                trackBar_NozzleTemp.Value = Convert.ToInt32(text_T1_ziel.Text);
            }
        }

        private void but_T2_Click(object sender, EventArgs e)
        {
            
        }

        private void but_T3_Click(object sender, EventArgs e)
        {
            
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
                    MessageBox.Show("Minimale Temperaturgrenze erreicht !! Temperatureinstellung unter 170 nicht möglich.", "WARNUNG!!", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Maximales Temperaturlimit erreicht!! Temperatureinstellung größer als 270 nicht möglich.", "WARNUNG!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Minimale Temperaturgrenze erreicht !! Temperatureinstellung unter 0 nicht möglich", "WARNUNG!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Maximales Temperaturlimit erreicht !! Temperatureinstellung größer als 100 nicht möglich.", "WARNUNG!!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private double newOffset = 0;
        
        private int zOffsetMultiplyer = 0;
        private double relativOffset = 0;
        private string filamentVal = string.Empty;


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
                MessageBox.Show("Ein Fehler ist aufgetreten! " + ex + " Temperatur wird nicht aktualisiert!");
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
        public void PrinterConnectionChange(string msg)
        {
            
            if (msg.IndexOf("Connected", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                firstG222 = false;
            }
            
        }
        public void AddtoListBox(string response, ref RepetierHostExtender.basic.LogLevel level)
        {
            if (response.IndexOf("Call G222 first", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                if (firstG222)
                {
                    MessageBox.Show("Move-Extruder ist nicht initialisiert. Bitte initialisieren („Home Move“).", "Warnung!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                firstG222 = true;
            }
            if (response.IndexOf("Cold extrusion prevented", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    if (wrkerColdExtrusion.IsBusy != true)
                    {
                        if (!coldextrusionActive)
                        {
                            coldextrusionActive = true;
                            wrkerColdExtrusion.RunWorkerAsync();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten! " + ex + " Cold Extrusion Prevented wird nicht aktualisiert!");
                }
            }
            if (response.IndexOf("G296 abgeschlossen", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                MessageBox.Show("Move Rotationsoffset: " + rotationOffset + " mm" + Environment.NewLine + Environment.NewLine + "Z-Offsets:" + "\t\tT0: " + zOffset_T0 + 
                       " mm" + Environment.NewLine + "\t\tT1: " + zOffset_T1 + " mm" + Environment.NewLine + "\t\tT2: " + zOffset_T2 + " mm" + Environment.NewLine + 
                       "\t\tT3: "+ zOffset_T3 + " mm" + Environment.NewLine + Environment.NewLine + "Abstand T0 <-> Multisense: " + abstand + " mm" +
                       Environment.NewLine + "Optimaler Abstand T0 <-> Multisense: " + optimal_Abstand + " mm" + Environment.NewLine +
                       "Z-Korrektur: " + zKorrektur + " mm", "Düsenvermessung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (response.IndexOf("FIRMWARE", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                startindex = response.IndexOf("FIRMWARE", StringComparison.CurrentCultureIgnoreCase);
                startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                lblFirmware.Text = response.Substring(startindex + 1);
            }
            if (response.IndexOf("RunOutMonitoringActive", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                
                startindex = response.IndexOf("=",  StringComparison.CurrentCultureIgnoreCase);
                filamentVal = response.Substring(startindex + 2);

                if (filamentVal == "true")
                {
                    lblFilamentStatus.Text = "AKTIV";
                    lblFilamentStatus.BackColor = SystemColors.Control;
                }
                else
                {
                    lblFilamentStatus.Text = "NICHT AKTIV";
                    lblFilamentStatus.BackColor = Color.Yellow;
                }
            }

            

            if (response.IndexOf("M218", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                if (response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase);
                    zOffset_T0 = response.Substring(startindex + 1);
                    lblAbstandT0.Text = zOffset_T0;

                }
                if (response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase);
                    zOffset_T1 = response.Substring(startindex + 1);
                    lblAbstandT1.Text = zOffset_T1;
                }
                if (response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase);
                    zOffset_T2 = response.Substring(startindex + 1);
                    lblAbstandT2.Text = zOffset_T2;
                }
                if (response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase);
                    zOffset_T3 = response.Substring(startindex + 1);
                    lblAbstandT3.Text = zOffset_T3;
                }

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
                    optimal_Abstand = response.Substring(startindex + 4);
                    lbl_zOffset.Text = optimal_Abstand;
                    lblOptimalDistance.Text = optimal_Abstand;
                }
                else if (response.IndexOf("=", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("=", StringComparison.CurrentCultureIgnoreCase);
                    lbl_zOffset.Text = response.Substring(startindex + 1);
                    lblOptimalDistance.Text = response.Substring(startindex + 1);
                }
                else
                {
                    startindex = 0;
                    lbl_zOffset.Text = response.Substring(startindex + 1);
                }
            }
            if (response.IndexOf("dz_T0_MS", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                if (response.IndexOf("opt", StringComparison.CurrentCultureIgnoreCase) == -1)
                {
                    if (response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase);
                        abstand = response.Substring(startindex + 4);
                        lblDisatance.Text = abstand;
                    }
                }

            }
            if (response.IndexOf("Z-Probe Offset", StringComparison.CurrentCultureIgnoreCase) != -1)
            {

                if (response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase);
                    zKorrektur = response.Substring(startindex + 5);
                    lblZKorrektur.Text = zKorrektur;

                }

            }
            if (response.IndexOf("M701", StringComparison.CurrentCultureIgnoreCase) != -1)
            {

                if (response.IndexOf("A", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("A", StringComparison.CurrentCultureIgnoreCase);
                    rotationOffset = response.Substring(startindex + 1);
                    lblRotationalOffset.Text = rotationOffset;

                }
                else if (response.IndexOf("E", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("E", StringComparison.CurrentCultureIgnoreCase);
                    rotationOffsetFilament = response.Substring(startindex + 1);
                    lblRotOffsetFilament.Text = rotationOffsetFilament;

                }

            }

            if (response.IndexOf("Lifetime statisctics (Total)", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                lifetimeCheck = 1;
            }
            if (response.IndexOf("Lifetime statisctics (Since last Service)", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                lifetimeCheck = 2;
            }
            if (lifetimeCheck == 1)
            {
                if (response.IndexOf("powercycle count", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblTotalPwrCycle.Text = response.Substring(startindex + 2);
                }
                else if (response.IndexOf("PowerON Life", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblTotalPwrON.Text = response.Substring(startindex + 2);
                }
                else if (response.IndexOf("Print Life", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblTotalPrntLife.Text = response.Substring(startindex + 2);
                }
                else if (response.IndexOf("Travelled Distance", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("X=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblTotalDistanceX.Text = response.Substring(startindex + 2, endindex - (startindex + 2));
                    startindex = response.IndexOf("Y=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblTotalDistanceY.Text = response.Substring(startindex + 2, endindex - (startindex + 2));
                    startindex = response.IndexOf("Z=", StringComparison.CurrentCultureIgnoreCase);
                    lblTotalDistanceZ.Text = response.Substring(startindex + 2);
                }
                else if (response.IndexOf("Extruded Material [m]", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("T0=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblExtrudedTotalT0.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                    startindex = response.IndexOf("T1=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblExtrudedTotalT1.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                    startindex = response.IndexOf("T2=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblExtrudedTotalT2.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                    startindex = response.IndexOf("T3=", StringComparison.CurrentCultureIgnoreCase);
                    lblExtrudedTotalT3.Text = response.Substring(startindex + 3);
                }
                else if (response.IndexOf("Extruded Material [kg]", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("T0=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblKgTotalT0.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                    startindex = response.IndexOf("T1=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblKgTotalT1.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                    startindex = response.IndexOf("T2=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblKgTotalT2.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                    startindex = response.IndexOf("T3=", StringComparison.CurrentCultureIgnoreCase);
                    lblKgTotalT3.Text = response.Substring(startindex + 3);
                }
                else if (response.IndexOf("T0 heated", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblHeatedTotalT0.Text = response.Substring(startindex + 1);
                }
                else if (response.IndexOf("T1 heated", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblHeatedTotalT1.Text = response.Substring(startindex + 1);
                }
                else if (response.IndexOf("T2 heated", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblHeatedTotalT2.Text = response.Substring(startindex + 1);
                }
                else if (response.IndexOf("T3 heated", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblHeatedTotalT3.Text = response.Substring(startindex + 1);
                }
            }
            if (lifetimeCheck == 2)
            {
                if (response.IndexOf("powercycle count", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblSrvcPwrCycle.Text = response.Substring(startindex + 2);
                }
                else if (response.IndexOf("PowerON Life", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblSrvcPwrON.Text = response.Substring(startindex + 2);
                }
                else if (response.IndexOf("Print Life", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblSrvcPrntLife.Text = response.Substring(startindex + 2);
                }
                else if (response.IndexOf("Travelled Distance", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("X=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblSrvcDistanceX.Text = response.Substring(startindex + 2, endindex - (startindex + 2));

                    startindex = response.IndexOf("Y=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblSrvcDistanceY.Text = response.Substring(startindex + 2, endindex - (startindex + 2));

                    startindex = response.IndexOf("Z=", StringComparison.CurrentCultureIgnoreCase);
                    lblSrvcDistanceZ.Text = response.Substring(startindex + 2);
                }
                else if (response.IndexOf("Extruded Material [m]", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("T0=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblExtrudedSrvcT0.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                    startindex = response.IndexOf("T1=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblExtrudedSrvcT1.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                    startindex = response.IndexOf("T2=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblExtrudedSrvcT2.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                    startindex = response.IndexOf("T3=", StringComparison.CurrentCultureIgnoreCase);
                    lblExtrudedSrvcT3.Text = response.Substring(startindex + 3);
                }
                else if (response.IndexOf("Extruded Material [kg]", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf("T0=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblKgSrvcT0.Text = response.Substring(startindex + 3, endindex - (startindex + 3));

                    startindex = response.IndexOf("T1=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblKgSrvcT1.Text = response.Substring(startindex + 3, endindex - (startindex + 3));

                    startindex = response.IndexOf("T2=", StringComparison.CurrentCultureIgnoreCase);
                    endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblKgSrvcT2.Text = response.Substring(startindex + 3, endindex - (startindex + 3));

                    startindex = response.IndexOf("T3=", StringComparison.CurrentCultureIgnoreCase);
                    lblKgSrvcT3.Text = response.Substring(startindex + 3);
                }
                else if (response.IndexOf("T0 heated", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblHeatedSrvcT0.Text = response.Substring(startindex + 1);
                }
                else if (response.IndexOf("T1 heated", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblHeatedSrvcT1.Text = response.Substring(startindex + 1);
                }
                else if (response.IndexOf("T2 heated", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblHeatedSrvcT2.Text = response.Substring(startindex + 1);
                }
                else if (response.IndexOf("T3 heated", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                    lblHeatedSrvcT3.Text = response.Substring(startindex + 1);
                }
            }
            
            if (response.IndexOf("FilamentAvailable_T0", StringComparison.CurrentCultureIgnoreCase) != -1)
            {

                startindex = response.IndexOf("=", StringComparison.CurrentCultureIgnoreCase);
                filamentVal = response.Substring(startindex + 2);

                if (filamentVal == "true")
                {
                    lblFilamentT0.Text = "FILAMENT VORHANDEN";
                    lblFilamentT0.BackColor = SystemColors.Control;
                }
                else
                {
                    lblFilamentT0.Text = "FILAMENT LEER";
                    lblFilamentT0.BackColor = Color.Yellow;
                }
            }
            if (response.IndexOf("FilamentAvailable_T1", StringComparison.CurrentCultureIgnoreCase) != -1)
            {

                startindex = response.IndexOf("=", StringComparison.CurrentCultureIgnoreCase);
                filamentVal = response.Substring(startindex + 2);

                if (filamentVal == "true")
                {
                    lblFilamentT1.Text = "FILAMENT VORHANDEN";
                    lblFilamentT1.BackColor = SystemColors.Control;
                }
                else
                {
                    lblFilamentT1.Text = "FILAMENT LEER";
                    lblFilamentT1.BackColor = Color.Yellow;
                }
            }
            if (response.IndexOf("FilamentAvailable_T2", StringComparison.CurrentCultureIgnoreCase) != -1)
            {

                startindex = response.IndexOf("=", StringComparison.CurrentCultureIgnoreCase);
                filamentVal = response.Substring(startindex + 2);

                if (filamentVal == "true")
                {
                    lblFilamentT2.Text = "FILAMENT VORHANDEN";
                    lblFilamentT2.BackColor = SystemColors.Control;
                }
                else
                {
                    lblFilamentT2.Text = "FILAMENT LEER";
                    lblFilamentT2.BackColor = Color.Yellow;
                }
            }
            if (response.IndexOf("FilamentAvailable_T3", StringComparison.CurrentCultureIgnoreCase) != -1)
            {

                startindex = response.IndexOf("=", StringComparison.CurrentCultureIgnoreCase);
                filamentVal = response.Substring(startindex + 2);

                if (filamentVal == "true")
                {
                    lblFilamentT3.Text = "FILAMENT VORHANDEN";
                    lblFilamentT3.BackColor = SystemColors.Control;
                }
                else
                {
                    lblFilamentT3.Text = "FILAMENT LEER";
                    lblFilamentT3.BackColor = Color.Yellow;
                }
               
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

            

            if (!host.IsJobRunning)
            {

                enablDisablWhenPrinting(true);
                
            }
            if (host.IsJobRunning)
            {
                enablDisablWhenPrinting(false);
                
            }
            if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
            {
                btn_xOffset_send.Enabled = true;
                btn_yOffset_send.Enabled = true;
            }
            else
            {
                btn_xOffset_send.Enabled = false;
                btn_yOffset_send.Enabled = false;
            }

            if (fineAdjustment)
            {
                btn_zOffset_plus.Enabled = true;
                btn_zOffset_minus.Enabled = true;
                btn_zOffset_send.Enabled = true;
            }
            else
            {
                btn_zOffset_plus.Enabled = false;
                btn_zOffset_minus.Enabled = false;
                btn_zOffset_send.Enabled = false;
            }



        }
        private void enablDisablWhenPrinting(bool val)
        {
            but_G224.Enabled = val;
            btnHomeMove.Enabled = val;
            but_MotorAus.Enabled = val;
            but_MOVE.Enabled = val;
            buttonHome.Enabled = val;
            btnXMinus.Enabled = val;
            btnXPlus.Enabled = val;
            btnYMinus.Enabled = val;
            btnYPlus.Enabled = val;
            btnZminus.Enabled = val;
            btnZPlus.Enabled = val;
            btnExtrude.Enabled = val;
            btnRetract.Enabled = val;
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
            if (HitTest(btnXPlus, e.X, e.Y))
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
            if (HitTest(btnYPlus, e.X, e.Y))
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
            if (HitTest(btnYMinus, e.X, e.Y))
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

        





        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                host.Connection.injectManualCommand("M603");
                host.Connection.injectManualCommand("M503");
            }
            if (tabControl1.SelectedIndex == 2)
            {
                host.Connection.injectManualCommand("M503");
                host.Connection.injectManualCommand("M513");
                host.Connection.injectManualCommand("M514");

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
            zOffsetMultiplyer = zOffsetMultiplyer + 1;

            newOffset = double.Parse(lbl_zOffset.Text) + 0.05;
            if (newOffset < 7)
            {
                lbl_zOffset.Text = newOffset.ToString();
            }
            else
            {
                MessageBox.Show("Der Z-Wert kann nicht größer als 7 mm sein.", "WARNUNG!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_zOffset_minus_Click(object sender, EventArgs e)
        {
            zOffsetMultiplyer = zOffsetMultiplyer - 1;
            newOffset = double.Parse(lbl_zOffset.Text) - 0.05;
            if (newOffset > -7)
            {
                lbl_zOffset.Text = newOffset.ToString();
            }
            else
            { 
                MessageBox.Show("Der Z-Wert kann nicht kleiner als -7 mm sein.", "WARNUNG!!",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var ms = MessageBox.Show("Warnung!! Der Drucker führt nun HOME ALL aus. Stellen Sie sicher, dass das Bett frei ist." + Environment.NewLine +
                "Drücken Sie OK, um fortzufahren", "WARNUNG!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ms == DialogResult.OK)
            {
                host.Connection.injectManualCommand("G222");
                host.Connection.injectManualCommand("G28");
                host.Connection.injectManualCommand("G1 Z0");
                fineAdjustment = true;
            }
        }

        



        private void myCustomButton1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (HitTest(btnZPlus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 Z" + step_dist);
                    host.Connection.injectManualCommand("G90");
                }
            }




        }

        private void btnAktualise_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("M503");
                host.Connection.injectManualCommand("M513");
                host.Connection.injectManualCommand("M514");
            }
        }

        private void btnZminus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnZminus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 Z" + -step_dist);
                    host.Connection.injectManualCommand("G90");

                }
            }
        }
     

        

        private void filamentAktualize_Click(object sender, EventArgs e)
        {
            host.Connection.injectManualCommand("M603");
        }

        private void myCustomButton1_MouseClick_2(object sender, MouseEventArgs e)
        {
            if (HitTest(btnRetract, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 E" + -step_dist + " F500");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G90");
                }
            }
        }

        private void btn_zOffset_send_Click(object sender, EventArgs e)
        {

            relativOffset = zOffsetMultiplyer * 0.05;
            
            var mbox = MessageBox.Show("Going to send " + relativOffset + " in M702." + Environment.NewLine +
                "Press Okay to CONTINUE!! If this is the right value","Warning!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (mbox == DialogResult.OK)
            {
                host.Connection.injectManualCommand("M702 " + "D" + relativOffset.ToString());
                zOffsetMultiplyer = 0;
            }
        }

        private void btnExtrude_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnExtrude, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 E" + step_dist + " F500");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G90");
                }
            }
        }

        private void btnHomeMove_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnHomeMove, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G222");
                }
            }
        }

        private void btnT0_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT0, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    if (!host.IsJobRunning)
                    {
                        host.Connection.injectManualCommand("T0");
                    }
                    selected_nozzle = "T0";
                    btnT0.Enabled = false;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T0_ziel.Text);
                }
            }
        }

        private void btnManualGcode_Click(object sender, EventArgs e)
        {
            if (txtManualGcode.Text != string.Empty)
            {   
                host.Connection.injectManualCommand(txtManualGcode.Text);
                if(gCodeIndex > 5)
                {
                    gCodeIndex = 0;
                }
                gCode[gCodeIndex] = txtManualGcode.Text;
                gCodeIndex++;
                maxGCodeValue = gCode.Max();
                gCodeCheck = gCode.ToList().IndexOf(maxGCodeValue);

                txtManualGcode.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Kein G-Code wurde eingegeben. Bitte geben Sie den G-Code ein, bevor Sie auf Senden klicken", 
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtManualGcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                    btnManualGcode_Click(this, new EventArgs());
            }
            else if (e.KeyCode == Keys.Up)
            {
                if (getPrev_gCodeUp < 0)
                {
                    getPrev_gCodeUp = 5;
                }
                if (getPrev_gCodeUp > gCodeCheck)
                {
                    getPrev_gCodeUp = gCodeCheck;
                }
                //MessageBox.Show("the value of index is" + getPrev_gCodeUp.ToString());
                txtManualGcode.Text = gCode[getPrev_gCodeUp];
                getPrev_gCodeUp--;
            }
            else if (e.KeyCode == Keys.Down)
            {
                if (getPrev_gCodeDown > 5)
                {
                    getPrev_gCodeDown = 0;
                }
                if (getPrev_gCodeDown > gCodeCheck)
                {
                    getPrev_gCodeDown = gCodeCheck;
                }
                txtManualGcode.Text = gCode[getPrev_gCodeDown];
                getPrev_gCodeDown++;
            }
        }

        private void WrkerColdExtrusion_DoWork(object sender, DoWorkEventArgs e)
        {
            
            var newMsg = MessageBox.Show("Düsentemperatur zu gering. Extrusion nicht verfügbar. Bitte Düse aufheizen.", "Warnung!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (newMsg == DialogResult.OK)
            {
                coldextrusionActive = false;
            }
        }

        private void btnT0_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT0.Enabled)
                btnT0.Image = Properties.Resources.T0_p;
            else
                btnT0.Image = Properties.Resources.T01;
        }

        private void BtnT1_MouseClick(object sender, MouseEventArgs e)
        {   if (HitTest(btnT1, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    if (!host.IsJobRunning)
                    {
                        host.Connection.injectManualCommand("T1");
                    }
                    selected_nozzle = "T1";
                    btnT0.Enabled = true;
                    btnT1.Enabled = false;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T1_ziel.Text);
                }
            }
        }

        private void BtnT1_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT1.Enabled)
                btnT1.Image = Properties.Resources.T1_p;
            else
                btnT1.Image = Properties.Resources.T1;
        }

        private void btnT2_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT2, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    if (!host.IsJobRunning)
                    {
                        host.Connection.injectManualCommand("T2");
                    }
                    selected_nozzle = "T2";
                    btnT0.Enabled = true;
                    btnT1.Enabled = true;
                    btnT2.Enabled = false;
                    btnT3.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T2_ziel.Text);
                }
            }
        }

        private void btnT2_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT2.Enabled)
                btnT2.Image = Properties.Resources.T2_p;
            else
                btnT2.Image = Properties.Resources.T2;
        }

        private void btnT3_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT3, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    if (!host.IsJobRunning)
                    {
                        host.Connection.injectManualCommand("T3");
                    }
                    selected_nozzle = "T3";
                    btnT0.Enabled = true;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = false;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T3_ziel.Text);
                }
            }
        }

        private void btnT3_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT3.Enabled)
                btnT3.Image = Properties.Resources.T3_p;
            else
                btnT3.Image = Properties.Resources.T3;
        }
    }
}
