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
using System.Runtime.InteropServices;

namespace MultecPlugin
{
    public partial class MultecTouchpanel : UserControl, IHostComponent
    {

        private IHost host;

        //event OnResponse eventResponse;
        //ExtruderDefinition extruderdata = new ExtruderDefinition(

        private bool isFormActive = true;
        private bool fineAdjustment;
        private bool is4Move = true;
        private double xPosition = 0.0;
        private double yPosition = 0.0;
        private double zPosition = 0.0;
        private bool isPrinting = false;
        private string tempValue;




        public MultecTouchpanel()
        {

            InitializeComponent();
            Trans.host.Connection.eventResponse += AddtoListBox;
            Trans.host.Connection.eventConnectionChange += PrinterConnectionChange;

            tempValue = "205";
            txtBoxTemp.Text = tempValue;

           



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
        private string[] gCode = new string[6];
        private int gCodeIndex = 0;
        private int getPrev_gCodeUp = 5;
        private int getPrev_gCodeDown = 0;
        private bool coldextrusionActive = false;
        private bool firstG222 = true;
        private int gCodeCheck = 0;
        private bool isG222Active = false;

        #endregion  


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




        private void but_G295_Click(object sender, EventArgs e)
        {

        }

        private void but_G297_Click(object sender, EventArgs e)
        {

        }



        //////////Nozzle Selection and Heating//////////

        private void but_T0_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                if (!isPrinting)
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
                if (!isPrinting)
                {
                    host.Connection.injectManualCommand("T1");
                }
                selected_nozzle = "T1";
                btnT0.Enabled = true;
                btnT1.Enabled = false;
                btnT2.Enabled = true;
                btnT3.Enabled = true;
                //btnMove.Enabled = true;
                trackBar_NozzleTemp.Value = Convert.ToInt32(text_T1_ziel.Text);
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
        private int rotOffsetMultiplyer = 0;
        private double relativOffset = 0;
        private string filamentVal = string.Empty;
        private bool redPictureActive;
        private bool doorOpen;






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
            
            isPrinting = false;
            firstG222 = true;
            gCodeCheck = 0;
            gCodeIndex = 0;
            getPrev_gCodeDown = 0;
            getPrev_gCodeUp = 5;
           
            Array.Clear(gCode, 0, gCode.Length);
            
            if (!is4Move)
            {

                CheckIfFourMove(false);

            }
            if (is4Move)
            {
                CheckIfFourMove(true);

            }
            chckBoxDruckerende.Checked = false;
            if (msg.IndexOf("Connected", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                lblXPosition.Text = "NICH INITILISIERT";
                lblYPosition.Text = "NICH INITILISIERT";
                lblZPosition.Text = "NICH INITILISIERT";
                xPosition = 0;
                yPosition = 0;
                zPosition = 0;
                step_dist = 1;
                btnStep1.Enabled = false;
                btnStep10.Enabled = true;
                btnStep50.Enabled = true;
                btnStep1.Image = Properties.Resources.onemm_p;
                redPictureActive = false;
                doorOpen = false;
                btnT0.Enabled = true;
                btnT1.Enabled = true;
                btnT2.Enabled = true;
                btnT3.Enabled = true;
                ////btnMove.Enabled = true;
                btnM218T1.Enabled = true;
                btnM218T2.Enabled = true;
                btnM218T3.Enabled = true;
                selected_nozzle = string.Empty;
                tool_M218 = string.Empty;

               
                

            }
                

              
            

        }
        public void AddtoListBox(string response, ref RepetierHostExtender.basic.LogLevel level)
        {
            
            if (response.IndexOf("Druck gestartet", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                isPrinting = true;
            }
            if (response.IndexOf("Druck gestartet", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                isPrinting = true;
            }
            if (response.IndexOf("Druck beendet", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                isPrinting = false;
            }
            if (response.IndexOf("Move Initializiert", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                radBtnMove.Checked = true;
            }
            if (response.IndexOf("Move Nicht Initializiert", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                radBtnMove.Checked = false;
            }
            if (response.IndexOf("Drucker Initializiert", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                radioBtnDrucker.Checked = true;
            }
            if (response.IndexOf("Drucker Nicht Initializiert", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                radioBtnDrucker.Checked = false;
            }
            if (response.IndexOf("Call G222", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    
                    if (!firstG222)
                    {

                        if (wrkrCallG222.IsBusy != true)
                        {
                            if (!isG222Active)
                            {

                                isG222Active = true;
                                wrkrCallG222.RunWorkerAsync();
                            }
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten! " + ex + " Call G222 first wird nicht aktualisiert!");
                }
                btnT0.Enabled = true;
                btnT1.Enabled = true;
                btnT2.Enabled = true;
                btnT3.Enabled = true;
                //btnMove.Enabled = true;
                selected_nozzle = string.Empty;
                firstG222 = false;
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
                       "\t\tT3: " + zOffset_T3 + " mm" + Environment.NewLine + Environment.NewLine + "Abstand T0 <-> Multisense: " + abstand + " mm" +
                       Environment.NewLine + "Optimaler Abstand T0 <-> Multisense: " + optimal_Abstand + " mm" + Environment.NewLine +
                       "Z-Korrektur: " + zKorrektur + " mm", "Düsenvermessung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (response.IndexOf("Active Extruder", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                if (response.IndexOf("0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    selected_nozzle = "T0";
                    btnT0.Enabled = false;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    //btnMove.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T0_ziel.Text);
                }
                if (response.IndexOf("1", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    selected_nozzle = "T1";
                    btnT0.Enabled = true;
                    btnT1.Enabled = false;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    //btnMove.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T1_ziel.Text);
                }
                if (response.IndexOf("2", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    selected_nozzle = "T2";
                    btnT0.Enabled = true;
                    btnT1.Enabled = true;
                    btnT2.Enabled = false;
                    btnT3.Enabled = true;
                    //btnMove.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T2_ziel.Text);
                }
                if (response.IndexOf("3", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    selected_nozzle = "T3";
                    btnT0.Enabled = true;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = false;
                    //btnMove.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T3_ziel.Text);
                }
                if (response.IndexOf("4", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    selected_nozzle = "T4";
                    btnT0.Enabled = true;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    //btnMove.Enabled = false;
                    trackBar_NozzleTemp.Value = trackBar_NozzleTemp.Minimum;
                }
            }

            if (response.IndexOf("Druckerposition", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                startindex = response.IndexOf("=", startindex);
                endindex = response.IndexOf(" ", startindex);
                lblXPosition.Text = response.Substring(startindex + 1, endindex - (startindex + 1));
                xPosition = double.Parse(lblXPosition.Text);

                startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                startindex = response.IndexOf("=", startindex);
                endindex = response.IndexOf(" ", startindex);
                lblYPosition.Text = response.Substring(startindex + 1, endindex - (startindex + 1));
                yPosition = double.Parse(lblYPosition.Text);
                startindex = response.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase);
                startindex = response.IndexOf("=", startindex);

                lblZPosition.Text = response.Substring(startindex + 1);
                zPosition = double.Parse(lblZPosition.Text);
            }

            if (response.IndexOf("RunOutMonitoringActive", StringComparison.CurrentCultureIgnoreCase) != -1)
            {

                startindex = response.IndexOf("=", StringComparison.CurrentCultureIgnoreCase);
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
            if (response.IndexOf("Sicherheitskreis offen", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                doorOpen = true;

            }
            else if (response.IndexOf("Sicherheitskreis geschlossen", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                doorOpen = false;
            }

            if (response.IndexOf("FIRMWARE", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
            
                startindex = response.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                lblFirmware.Text = response.Substring(startindex + 1);
                if (response.IndexOf("4Move", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    is4Move = true;
                }
                else if (response.IndexOf("2Move", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    is4Move = false;
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

                        xOffset = response.Substring(startindex + 1, endindex - (startindex + 1));
                        text_M218_X.Text = xOffset;

                        startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);
                        yOffset = response.Substring(startindex + 1, endindex - (startindex + 1));
                        text_M218_Y.Text = yOffset;
                    }
                }
                else if (tool_M218 == "T2")
                {
                    if (response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);

                        xOffset = response.Substring(startindex + 1, endindex - (startindex + 1));
                        text_M218_X.Text = xOffset;
                        startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);
                        yOffset = response.Substring(startindex + 1, endindex - (startindex + 1));
                        text_M218_Y.Text = yOffset;
                    }
                }
                else if (tool_M218 == "T3")
                {
                    if (response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);

                        xOffset = response.Substring(startindex + 1, endindex - (startindex + 1));
                        text_M218_X.Text = xOffset;
                        startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                        endindex = response.IndexOf(" ", startindex);
                        yOffset = response.Substring(startindex + 1, endindex - (startindex + 1));
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
                    lblRotOffFillVal.Text = rotationOffsetFilament;

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

                    if (response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblExtrudedTotalT0.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblExtrudedTotalT0.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T1=", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblExtrudedTotalT1.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblExtrudedTotalT1.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T2=", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T2=", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblExtrudedTotalT2.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblExtrudedTotalT2.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T3=", StringComparison.CurrentCultureIgnoreCase);
                        lblExtrudedTotalT3.Text = response.Substring(startindex + 3);
                    }
                }
                else if (response.IndexOf("Extruded Material [kg]", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    if (response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblKgTotalT0.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblKgTotalT0.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblKgTotalT1.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblKgTotalT1.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblKgTotalT2.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblKgTotalT2.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase);
                        lblKgTotalT3.Text = response.Substring(startindex + 3);
                    }
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
                    if (response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblExtrudedSrvcT0.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblExtrudedSrvcT0.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblExtrudedSrvcT1.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblExtrudedSrvcT1.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblExtrudedSrvcT2.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblExtrudedSrvcT2.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase);
                        lblExtrudedSrvcT3.Text = response.Substring(startindex + 3);
                    }
                }
                else if (response.IndexOf("Extruded Material [kg]", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    if (response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblKgSrvcT0.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblKgSrvcT0.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblKgSrvcT1.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblKgSrvcT1.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase);
                        if (response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            endindex = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                            lblKgSrvcT2.Text = response.Substring(startindex + 3, endindex - (startindex + 3));
                        }
                        else
                        {
                            lblKgSrvcT2.Text = response.Substring(startindex + 3);
                        }
                    }
                    if (response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase);
                        lblKgSrvcT3.Text = response.Substring(startindex + 3);
                    }
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
            if (!doorOpen)
            {
                if (PictrBoxDoorOpen.Visible)
                {
                    enablDisablWhenDoorOpen(true);
                }
            }
            
            if (!isPrinting)
            {
                enablDisablWhenPrinting(true);
            }
            if (isPrinting)
            {
                enablDisablWhenPrinting(false);
                xPosition = 0;
                yPosition = 0;
                zPosition = 0;
                lblXPosition.Text = "Printing";
                lblYPosition.Text = "Printing";
                lblZPosition.Text = "Printing";
            }
            if (doorOpen)
            {
                if (!PictrBoxDoorOpen.Visible)
                {
                    enablDisablWhenDoorOpen(false);
                }
                else
                {
                    if (this.redPictureActive)
                    {
                        this.PictrBoxDoorOpen.Image = Properties.Resources.Warnung;
                        this.redPictureActive = false;
                    }
                    else
                    {

                        this.PictrBoxDoorOpen.Image = Properties.Resources.WarnungGrey;
                        this.redPictureActive = true;
                    }
                }
            }

            if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
            {
                btnXoffsetSend.Enabled = true;
                btnYoffsetSend.Enabled = true;
            }
            else
            {
                btnXoffsetSend.Enabled = false;
                btnYoffsetSend.Enabled = false;
            }

            if (fineAdjustment)
            {
                btnZOffsetPlus.Enabled = true;
                btnZOffsetMinus.Enabled = true;
                btnZOffsetSend.Enabled = true;
            }
            else
            {
                btnZOffsetPlus.Enabled = false;
                btnZOffsetMinus.Enabled = false;
                btnZOffsetSend.Enabled = false;
            }



        }
        private void CheckIfFourMove(bool val)
        {

            btnT2.Visible = val;
            btnT2_OnOff.Visible = val;
            text_T2_Aktuell.Visible = val;
            text_T2_ziel.Visible = val;
            btnM218T2.Visible = val;
            lblT2.Visible = val;
            lblT2_1.Visible = val;
            lblT2_2.Visible = val;
            lblT2_3.Visible = val;
            lblT2_4.Visible = val;
            lblT2_5.Visible = val;
            lblFilamentT2.Visible = val;
            lblAbstandT2.Visible = val;
            lblExtrudedTotalT2.Visible = val;
            lblExtrudedSrvcT2.Visible = val;
            lblKgTotalT2.Visible = val;
            lblKgSrvcT2.Visible = val;
            lblHeatedTotalT2.Visible = val;
            lblHeatedSrvcT2.Visible = val;
            btnT3.Visible = val;
            btnT3_OnOff.Visible = val;
            text_T3_Aktuell.Visible = val;
            text_T3_ziel.Visible = val;
            btnM218T3.Visible = val;
            lblT3.Visible = val;
            lblT3_1.Visible = val;
            lblT3_2.Visible = val;
            lblT3_3.Visible = val;
            lblT3_4.Visible = val;
            lblT3_5.Visible = val;
            lblFilamentT3.Visible = val;
            lblAbstandT3.Visible = val;
            lblExtrudedTotalT3.Visible = val;
            lblExtrudedSrvcT3.Visible = val;
            lblKgTotalT3.Visible = val;
            lblKgSrvcT3.Visible = val;
            lblHeatedTotalT3.Visible = val;
            lblHeatedSrvcT2.Visible = val;
            lblWhen4Move.Visible = val;
            lblRotOffsetFilament.Visible = val;
            lblKalRotOffsetFilament.Visible = val;
            lblRotOffFillVal.Visible = val;
            lblWhen4Move_1.Visible = val;
            btnEminus.Visible = val;
            btnEplus.Visible = val;
            btnRotOffsetSend.Visible = val;


        }
        private void enablDisablWhenDoorOpen(bool val)
        {
            
            btnMotorOff.Enabled = val;
            btnHome.Enabled = val;
            btnXhome.Enabled = val;
            btnYhome.Enabled = val;
            btnZhome.Enabled = val;
            btnXMinus.Enabled = val;
            btnXPlus.Enabled = val;
            btnYMinus.Enabled = val;
            btnYPlus.Enabled = val;
            btnZminus.Enabled = val;
            btnZPlus.Enabled = val;
            btnXMinus.Visible = val;
            btnXPlus.Visible = val;
            btnYMinus.Visible = val;
            btnYPlus.Visible = val;
            btnZminus.Visible = val;
            btnZPlus.Visible = val;
            
            btnDusevermessung.Enabled = val;
            btnPositionPrufen.Enabled = val;
            btnFineAdjustment.Enabled = val;
            PictrBoxDoorOpen.Visible = !val;
            
            btnZOffsetMinus.Enabled = val;
            btnZOffsetPlus.Enabled = val;
            btnZOffsetSend.Enabled = val;
            //btnM218T1.Enabled = val;                              //Not Sure if should be disabled
            //btnM218T2.Enabled = val;                              //Not Sure if should be disabled
            //btnM218T3.Enabled = val;                              //Not Sure if should be disabled
            //btnMove.Visible = val;
           
           
        }
        private void enablDisablWhenPrinting(bool val)
        {
            btnParkMove.Enabled = val;
            btnHomeMove.Enabled = val;
            btnMotorOff.Enabled = val;
            btnHome.Enabled = val;
            btnXhome.Enabled = val;
            btnYhome.Enabled = val;
            btnZhome.Enabled = val;
            btnXMinus.Enabled = val;
            btnXPlus.Enabled = val;
            btnYMinus.Enabled = val;
            btnYPlus.Enabled = val;
            btnZminus.Enabled = val;
            btnZPlus.Enabled = val;
            btnExtrude.Enabled = val;
            btnRetract.Enabled = val;
            btnDusevermessung.Enabled = val;
            btnPositionPrufen.Enabled = val;
            btnFineAdjustment.Enabled = val;
            btnHomeMoveKal.Enabled = val;
            btnParkMoveKal.Enabled = val;
            btnXOffsetMinus.Enabled = val;
            btnXOffsetPlus.Enabled = val;
            btnXoffsetSend.Enabled = val;
            btnYoffsetMinus.Enabled = val;
            btnYoffsetPlus.Enabled = val;
            btnYoffsetSend.Enabled = val;
            btnZOffsetMinus.Enabled = val;
            btnZOffsetPlus.Enabled = val;
            btnZOffsetSend.Enabled = val;
            //btnM218T1.Enabled = val;                              //Not Sure if should be disabled
            //btnM218T2.Enabled = val;                              //Not Sure if should be disabled
            //btnM218T3.Enabled = val;                              //Not Sure if should be disabled
            //btnMove.Visible = val;
            btnEminus.Enabled = val;
            btnEplus.Enabled = val;
            btnRotOffsetSend.Enabled = val;
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
                    host.Connection.injectManualCommand("G1 X" + -step_dist + " F6000");
                    host.Connection.injectManualCommand("G90");
                    xPosition = xPosition - step_dist;
                    if (xPosition < 0)
                    {
                        xPosition = 0;
                    }
                    lblXPosition.Text = xPosition.ToString();
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
                    host.Connection.injectManualCommand("G1 X" + step_dist + " F6000");
                    host.Connection.injectManualCommand("G90");
                    xPosition = xPosition + step_dist;
                    lblXPosition.Text = xPosition.ToString();
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
                    host.Connection.injectManualCommand("G1 Y" + step_dist + " F6000");
                    host.Connection.injectManualCommand("G90");
                    yPosition = yPosition + step_dist;
                    lblYPosition.Text = yPosition.ToString();
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
                    host.Connection.injectManualCommand("G1 Y" + -step_dist + " F6000");
                    host.Connection.injectManualCommand("G90");
                    yPosition = yPosition - step_dist;
                    if (yPosition < 0)
                    {
                        yPosition = 0;
                    }
                    lblYPosition.Text = yPosition.ToString();
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
                host.Connection.injectManualCommand("M603");
                host.Connection.injectManualCommand("M503");
            }
            if (tabControl1.SelectedIndex == 3)
            {
                host.Connection.injectManualCommand("M503");
                host.Connection.injectManualCommand("M513");
                host.Connection.injectManualCommand("M514");

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

        }

        private void btn_zOffset_plus_Click(object sender, EventArgs e)
        {

        }









        private void myCustomButton1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (HitTest(btnZPlus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 Z" + step_dist + " F300");
                    host.Connection.injectManualCommand("G90");
                    zPosition = zPosition + step_dist;
                    lblZPosition.Text = zPosition.ToString();
                }
            }




        }

        private void btnAktualise_Click(object sender, EventArgs e)
        {

        }

        private void btnZminus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnZminus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 Z" + -step_dist + " F300");
                    host.Connection.injectManualCommand("G90");
                    zPosition = zPosition - step_dist;
                    if (zPosition < 0)
                    {
                        zPosition = 0;
                    }
                    lblZPosition.Text = zPosition.ToString();

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
                    host.Connection.injectManualCommand("G1 E" + -step_dist + " F1800");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G90");
                }
            }
        }

        private void btn_zOffset_send_Click(object sender, EventArgs e)
        {


        }

        private void btnExtrude_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnExtrude, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G91");
                    host.Connection.injectManualCommand("G1 E" + step_dist + " F300");
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
                    if (!isPrinting)
                    {
                        host.Connection.injectManualCommand("T0");
                    }
                    selected_nozzle = "T0";
                    btnT0.Enabled = false;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    //btnMove.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T0_ziel.Text);
                }
            }
        }



        private void txtManualGcode_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnManualGcodeSend_Click(this, new EventArgs());
                getPrev_gCodeDown = 0;
                getPrev_gCodeUp = 5;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                txtManualGcode.Clear();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }

            if (e.KeyCode == Keys.Up)
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

                if (txtManualGcode.Text != String.Empty)
                {
                    txtManualGcode.Select(0, 0);
                }
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

                if (txtManualGcode.Text != String.Empty)
                {
                    txtManualGcode.Select(txtManualGcode.Text.Length, 0);
                }
            }


        }
        private void G1G0Check(string val)
        {
            if (val.IndexOf("X", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                startindex = val.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                if (val.IndexOf(" ", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    endindex = val.IndexOf(" ", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblXPosition.Text = val.Substring(startindex + 1, endindex - (startindex + 1));
                    xPosition = double.Parse(lblXPosition.Text);

                }
                else
                {
                    lblXPosition.Text = val.Substring(startindex + 1);
                    xPosition = double.Parse(lblXPosition.Text);
                }
            }
            if (val.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                startindex = val.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                if (val.IndexOf(" ", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    endindex = val.IndexOf(" ", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblYPosition.Text = val.Substring(startindex + 1, endindex - (startindex + 1));
                    yPosition = double.Parse(lblYPosition.Text);
                }
                else
                {
                    lblYPosition.Text = val.Substring(startindex + 1);
                    yPosition = double.Parse(lblYPosition.Text);
                }
            }
            if (val.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                startindex = val.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase);
                if (val.IndexOf(" ", startindex, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    endindex = val.IndexOf(" ", startindex, StringComparison.CurrentCultureIgnoreCase);
                    lblZPosition.Text = val.Substring(startindex + 1, endindex - (startindex + 1));
                    zPosition = double.Parse(lblZPosition.Text);
                }
                else
                {
                    lblZPosition.Text = val.Substring(startindex + 1);
                    zPosition = double.Parse(lblZPosition.Text);
                }
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
                btnT0.Image = Properties.Resources.T0_p_2;
            else
                btnT0.Image = Properties.Resources.T0_2;
        }

        private void BtnT1_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT1, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    if (!isPrinting)
                    {
                        host.Connection.injectManualCommand("T1");
                    }
                    selected_nozzle = "T1";
                    btnT0.Enabled = true;
                    btnT1.Enabled = false;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    //btnMove.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T1_ziel.Text);
                }
            }
        }

        private void BtnT1_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT1.Enabled)
                btnT1.Image = Properties.Resources.T1_p_2;
            else
                btnT1.Image = Properties.Resources.T1_2;
        }

        private void btnT2_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT2, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    if (!isPrinting)
                    {
                        host.Connection.injectManualCommand("T2");
                    }
                    selected_nozzle = "T2";
                    btnT0.Enabled = true;
                    btnT1.Enabled = true;
                    btnT2.Enabled = false;
                    btnT3.Enabled = true;
                    //btnMove.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T2_ziel.Text);
                }
            }
        }

        private void btnT2_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT2.Enabled)
                btnT2.Image = Properties.Resources.T2_p_2;
            else
                btnT2.Image = Properties.Resources.T2_2;
        }

        private void btnT3_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT3, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    if (!isPrinting)
                    {
                        host.Connection.injectManualCommand("T3");
                    }
                    selected_nozzle = "T3";
                    btnT0.Enabled = true;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = false;
                    //btnMove.Enabled = true;
                    trackBar_NozzleTemp.Value = Convert.ToInt32(text_T3_ziel.Text);
                }
            }
        }

        private void btnT3_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT3.Enabled)
                btnT3.Image = Properties.Resources.T3_p_2;
            else
                btnT3.Image = Properties.Resources.T3_2;
        }

        private void wrkrCallG222_DoWork(object sender, DoWorkEventArgs e)
        {
            var newMsg = MessageBox.Show("Move-Extruder ist nicht initialisiert. Bitte initialisieren („Home Move“).", "Warnung!",
                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (newMsg == DialogResult.OK)
            {
                isG222Active = false;
            }


        }

        private void btnMotorOff_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnMotorOff, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("M18");
                }
            }
        }

        private void btnHome_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnHome, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G28");
                }
            }
        }

        private void btnParkMove_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnParkMove, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G224");
                }
            }
        }

        /* private void btnMove_MouseClick(object sender, MouseEventArgs e)
         {
             if (HitTest(btnMove, e.X, e.Y))
             {
                 if (host.Connection.connector.IsConnected())
                 {
                     if (!isPrinting)
                     {
                         host.Connection.injectManualCommand("T4");
                     }
                     selected_nozzle = "T4";
                     btnT0.Enabled = true;
                     btnT1.Enabled = true;
                     btnT2.Enabled = true;
                     btnT3.Enabled = true;
                     //btnMove.Enabled = false;
                     trackBar_NozzleTemp.Value = trackBar_NozzleTemp.Minimum;
                 }
             }
         }*/

        //private void btnmove_enabledchanged(object sender, eventargs e)
        //{
        //    if (!isprinting)
        //    {
        //        if (!btnmove.enabled)
        //            btnmove.image = properties.resources.move_p_2;
        //        else
        //            btnmove.image = properties.resources.move_2;
        //    }
        //}

        private void btnT0_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                T0_On = !T0_On;
                if (T0_On == true)
                {
                    host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T0");
                    btnT0_OnOff.Image = Properties.Resources.ein;
                }
                else
                {
                    host.Connection.injectManualCommand("M104 S0 T0");
                    btnT0_OnOff.Image = Properties.Resources.AUS_2;
                }
            }
        }

        private void btnT0_OnOff_MouseMove(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT0_OnOff, e.X, e.Y))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }

        private void btnT1_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                T1_On = !T1_On;

                if (T1_On == true)
                {
                    host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T1");
                    btnT1_OnOff.Image = Properties.Resources.ein;
                }
                else
                {

                    host.Connection.injectManualCommand("M104 S0 T1");
                    btnT1_OnOff.Image = Properties.Resources.AUS_2;
                }
            }
        }

        private void btnT2_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                T2_On = !T2_On;

                if (T2_On == true)
                {

                    host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T2");
                    btnT2_OnOff.Image = Properties.Resources.ein;
                }
                else
                {

                    host.Connection.injectManualCommand("M104 S0 T2");
                    btnT2_OnOff.Image = Properties.Resources.AUS_2;
                }
            }
        }

        private void btnT3_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                T3_On = !T3_On;

                if (T3_On == true)
                {

                    host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T3");
                    btnT3_OnOff.Image = Properties.Resources.ein;
                }
                else
                {

                    host.Connection.injectManualCommand("M104 S0 T3");
                    btnT3_OnOff.Image = Properties.Resources.AUS_2;
                }
            }
        }

        private void btnBed_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {

                Bed_On = !Bed_On;

                if (Bed_On == true)
                {
                    host.Connection.injectManualCommand("M140 S" + temp_Zeil_bed + " T5");
                    btnBed_OnOff.Image = Properties.Resources.ein;
                }
                else
                {
                    host.Connection.injectManualCommand("M140 S0 T5");
                    btnBed_OnOff.Image = Properties.Resources.AUS_2;
                }
            }
        }

        private void btnT1_OnOff_MouseMove(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT1_OnOff, e.X, e.Y))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }

        private void btnT2_OnOff_MouseMove(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT2_OnOff, e.X, e.Y))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }

        private void btnT3_OnOff_MouseMove(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT3_OnOff, e.X, e.Y))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }

        private void btnBed_OnOff_MouseMove(object sender, MouseEventArgs e)
        {
            if (HitTest(btnBed_OnOff, e.X, e.Y))
                this.Cursor = Cursors.Hand;
            else
                this.Cursor = Cursors.Default;
        }

        private void btnStep1_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnStep1, e.X, e.Y))
            {
                btnStep1.Enabled = false;
                btnStep10.Enabled = true;
                btnStep50.Enabled = true;
                step_dist = 1;
            }
        }

        private void btnStep1_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnStep1.Enabled)
                btnStep1.Image = Properties.Resources.onemm_p_2;
            else
                btnStep1.Image = Properties.Resources.onemm_2;
        }

        private void btnStep10_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnStep10, e.X, e.Y))
            {
                btnStep1.Enabled = true;
                btnStep10.Enabled = false;
                btnStep50.Enabled = true;
                step_dist = 10;
            }
        }

        private void btnStep10_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnStep10.Enabled)
                btnStep10.Image = Properties.Resources.tenmm_p_2;
            else
                btnStep10.Image = Properties.Resources.tenmm_2;
        }

        private void btnStep50_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnStep50, e.X, e.Y))
            {
                btnStep1.Enabled = true;
                btnStep10.Enabled = true;
                btnStep50.Enabled = false;
                step_dist = 50;
            }
        }

        private void btnStep50_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnStep50.Enabled)
                btnStep50.Image = Properties.Resources.fiftymm_p_2;
            else
                btnStep50.Image = Properties.Resources.fiftymm_2;
        }









        private void chckBoxDruckerende_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBoxDruckerende.Checked)
            {
                host.Connection.injectManualCommand("M611");

            }
            if (!chckBoxDruckerende.Checked)
            {
                host.Connection.injectManualCommand("M612");

            }
        }

        private void btnNozzlePlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnNozzlePlus, e.X, e.Y))
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
        }

        private void btnNozzlePlus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnNozzlePlus.Enabled)
                btnNozzlePlus.Image = Properties.Resources.plus5_g;
            else
                btnNozzlePlus.Image = Properties.Resources.plus5;
        }

        private void btnBedPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnBedPlus, e.X, e.Y))
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
        }

        private void btnNozzleMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnNozzleMinus, e.X, e.Y))
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
        }

        private void btnBedMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnBedMinus, e.X, e.Y))
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
        }

        private void btnBedPlus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnBedPlus.Enabled)
                btnBedPlus.Image = Properties.Resources.plus5_g;
            else
                btnBedPlus.Image = Properties.Resources.plus5;
        }

        private void btnNozzleMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnNozzleMinus.Enabled)
                btnNozzleMinus.Image = Properties.Resources.minus5_g;
            else
                btnNozzleMinus.Image = Properties.Resources.minus51;
        }

        private void btnBedMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnBedMinus.Enabled)
                btnBedMinus.Image = Properties.Resources.minus5_g;
            else
                btnBedMinus.Image = Properties.Resources.minus51;
        }

        private void btnManualGcodeSend_Click(object sender, EventArgs e)
        {
            if (txtManualGcode.Text != string.Empty)
            {
                host.Connection.injectManualCommand(txtManualGcode.Text);
                if (gCodeIndex > 5)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        gCode[i] = gCode[i + 1];
                    }
                    gCodeIndex = 5;
                }

                gCode[gCodeIndex] = txtManualGcode.Text;
                if (gCode[gCodeIndex].IndexOf("G0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    G1G0Check(gCode[gCodeIndex]);
                }
                if (gCode[gCodeIndex].IndexOf("G1", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    G1G0Check(gCode[gCodeIndex]);
                }
                gCodeIndex++;
                gCodeCheck = gCode.Count(s => s != null);
                txtManualGcode.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Kein G-Code wurde eingegeben. Bitte geben Sie den G-Code ein, bevor Sie auf Senden klicken",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHomeMoveKal_MouseClick(object sender, MouseEventArgs e)
        {
            btnHomeMove_MouseClick(this, e);
        }

        private void btnParkMoveKal_MouseClick(object sender, MouseEventArgs e)
        {
            btnParkMove_MouseClick(this, e);
        }

        private void btnInfoAktualise_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnInfoAktualise, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("M503");
                    host.Connection.injectManualCommand("M513");
                    host.Connection.injectManualCommand("M514");
                }
            }
        }

        private void btnInfoAktualise_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnInfoAktualise.Enabled)
                btnInfoAktualise.Image = Properties.Resources.Aktualizieren_g;
            else
                btnInfoAktualise.Image = Properties.Resources.Aktualizieren;
        }

        private void btnFilAktualise_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnFilAktualise, e.X, e.Y))
            {
                host.Connection.injectManualCommand("M603");
            }
        }

        private void btnFilAktualise_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnFilAktualise.Enabled)
                btnFilAktualise.Image = Properties.Resources.Aktualizieren_g;
            else
                btnFilAktualise.Image = Properties.Resources.Aktualizieren;
        }

        private void btnParkMoveKal_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnParkMoveKal.Enabled)
                btnParkMoveKal.Image = Properties.Resources.Park_Move_g;
            else
                btnParkMoveKal.Image = Properties.Resources.Park_Move;
        }

        private void btnHomeMoveKal_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnHomeMoveKal.Enabled)
                btnHomeMoveKal.Image = Properties.Resources.HOME_Move_g;
            else
                btnHomeMoveKal.Image = Properties.Resources.HOME_Move;
        }

        private void btnHomeMove_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnHomeMove.Enabled)
                btnHomeMove.Image = Properties.Resources.HOME_Move_g;
            else
                btnHomeMove.Image = Properties.Resources.HOME_Move;
        }

        private void btnParkMove_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnParkMove.Enabled)
                btnParkMove.Image = Properties.Resources.Park_Move_g;
            else
                btnParkMove.Image = Properties.Resources.Park_Move;
        }

        private void btnHome_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnHome.Enabled)
                btnHome.Image = Properties.Resources.HOME_g;
            else
                btnHome.Image = Properties.Resources.HOME;
        }

        private void btnMotorOff_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnMotorOff.Enabled)
                btnMotorOff.Image = Properties.Resources.MOTOR_OFF_g;
            else
                btnMotorOff.Image = Properties.Resources.MOTOR_OFF;
        }

        private void btnRotOffsetSend_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnRotOffsetSend, e.X, e.Y))
            {
                relativOffset = rotOffsetMultiplyer * 0.5;


                host.Connection.injectManualCommand("M701 " + "E" + relativOffset.ToString());
                host.Connection.injectManualCommand("G222");
                rotOffsetMultiplyer = 0;
            }
        }

        private void btnRotOffsetSend_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnRotOffsetSend.Enabled)
                btnRotOffsetSend.Image = Properties.Resources.Schicken_g;
            else
                btnRotOffsetSend.Image = Properties.Resources.Schicken;
        }

        private void btnYoffsetSend_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnYoffsetSend.Enabled)
                btnYoffsetSend.Image = Properties.Resources.Schicken_g;
            else
                btnYoffsetSend.Image = Properties.Resources.Schicken;
        }

        private void btnXoffsetSend_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnXoffsetSend.Enabled)
                btnXoffsetSend.Image = Properties.Resources.Schicken_g;
            else
                btnXoffsetSend.Image = Properties.Resources.Schicken;
        }

        private void btnZOffsetSend_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnZOffsetSend.Enabled)
                btnZOffsetSend.Image = Properties.Resources.Schicken_g;
            else
                btnZOffsetSend.Image = Properties.Resources.Schicken;
        }

        private void btnManualGcodeSend_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnManualGcodeSend.Enabled)
                btnManualGcodeSend.Image = Properties.Resources.Schicken_g;
            else
                btnManualGcodeSend.Image = Properties.Resources.Schicken;
        }

        private void btnYoffsetSend_Click(object sender, EventArgs e)
        {
            if (tool_M218 != string.Empty && text_M218_Y.Text != string.Empty)
            {
                host.Connection.injectManualCommand("M218 " + tool_M218 + "Y " + text_M218_Y.Text);
            }
        }

        private void btnXoffsetSend_Click(object sender, EventArgs e)
        {
            if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
            {
                host.Connection.injectManualCommand("M218 " + tool_M218 + "X " + text_M218_X.Text);
            }
        }

        private void btnZOffsetSend_Click(object sender, EventArgs e)
        {
            relativOffset = zOffsetMultiplyer * 0.05;

            host.Connection.injectManualCommand("M702 " + "D" + relativOffset.ToString());
            zOffsetMultiplyer = 0;
        }

        private void btnFineAdjustment_Click(object sender, EventArgs e)
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

        private void btnDusevermessung_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("G295");
                host.Connection.injectManualCommand("G296");
                host.Connection.injectManualCommand("M503");
            }
        }

        private void btnPositionPrufen_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
                host.Connection.injectManualCommand("G297");
        }

        private void btnFineAdjustment_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnFineAdjustment.Enabled)
                btnFineAdjustment.Image = Properties.Resources.ZF_g;
            else
                btnFineAdjustment.Image = Properties.Resources.ZF;
        }

        private void btnDusevermessung_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnDusevermessung.Enabled)
                btnDusevermessung.Image = Properties.Resources.DV_g;
            else
                btnDusevermessung.Image = Properties.Resources.DV;
        }

        private void btnPositionPrufen_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnPositionPrufen.Enabled)
                btnPositionPrufen.Image = Properties.Resources.PP_g;
            else
                btnPositionPrufen.Image = Properties.Resources.PP;
        }

        private void btnM218T1_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                tool_M218 = "T1";
                host.Connection.injectManualCommand("M503");
                btnM218T1.Enabled = false;
                btnM218T2.Enabled = true;
                btnM218T3.Enabled = true;
            }
        }

        private void btnM218T2_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                tool_M218 = "T2";
                host.Connection.injectManualCommand("M503");
                btnM218T1.Enabled = true;
                btnM218T2.Enabled = false;
                btnM218T3.Enabled = true;
            }
        }

        private void btnM218T3_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                tool_M218 = "T3";
                host.Connection.injectManualCommand("M503");
                btnM218T1.Enabled = true;
                btnM218T2.Enabled = true;
                btnM218T3.Enabled = false;
            }
        }

        private void btnM218T1_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnM218T1.Enabled)
                btnM218T1.Image = Properties.Resources.T1_p_2;
            else
                btnM218T1.Image = Properties.Resources.T1_2;
        }

        private void btnM218T2_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnM218T2.Enabled)
                btnM218T2.Image = Properties.Resources.T2_p_2;
            else
                btnM218T2.Image = Properties.Resources.T2_2;
        }

        private void btnM218T3_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnM218T3.Enabled)
                btnM218T3.Image = Properties.Resources.T3_p_2;
            else
                btnM218T3.Image = Properties.Resources.T3_2;
        }

        private void btnYoffsetPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnYoffsetPlus, e.X, e.Y))
            {
                if (tool_M218 != string.Empty && text_M218_Y.Text != string.Empty)
                {
                    newOffset = double.Parse(text_M218_Y.Text) + 0.05;
                    text_M218_Y.Text = newOffset.ToString();
                }
            }
        }

        private void btnXOffsetPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXOffsetPlus, e.X, e.Y))
            {
                if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
                {
                    newOffset = double.Parse(text_M218_X.Text) + 0.05;
                    text_M218_X.Text = newOffset.ToString();
                }
            }
        }

        private void btnXOffsetMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXOffsetMinus, e.X, e.Y))
            {
                if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
                {
                    newOffset = double.Parse(text_M218_X.Text) - 0.05;
                    text_M218_X.Text = newOffset.ToString();
                }
            }
        }

        private void btnYoffsetMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnYoffsetMinus, e.X, e.Y))
            {
                if (tool_M218 != string.Empty && text_M218_Y.Text != string.Empty)
                {
                    newOffset = double.Parse(text_M218_Y.Text) - 0.05;
                    text_M218_Y.Text = newOffset.ToString();
                }
            }
        }

        private void btnZOffsetPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnZOffsetPlus, e.X, e.Y))
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
        }

        private void btnZOffsetMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnZOffsetMinus, e.X, e.Y))
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
        }

        private void btnEplus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnEplus, e.X, e.Y))
            {
                rotOffsetMultiplyer = rotOffsetMultiplyer + 1;

                newOffset = double.Parse(lblRotOffFillVal.Text) + 0.5;
                if (newOffset <= 12)
                {
                    lblRotOffFillVal.Text = newOffset.ToString();
                }
                else
                {
                    MessageBox.Show("Die Rotational Offset Filamentauswahl kann nicht größer als 12 mm sein.", "WARNUNG!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEminus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnEminus, e.X, e.Y))
            {
                rotOffsetMultiplyer = rotOffsetMultiplyer - 1;
                newOffset = double.Parse(lblRotOffFillVal.Text) - 0.5;
                if (newOffset >= 2)
                {
                    lblRotOffFillVal.Text = newOffset.ToString();
                }
                else
                {
                    MessageBox.Show("Die Rotational Offset Filamentauswahl kann nicht kleiner als 2 mm sein.", "WARNUNG!!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }



        private void btnZPlus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnZPlus.Enabled)
                btnZPlus.Image = Properties.Resources.zPlus_g;
            else
                btnZPlus.Image = Properties.Resources.zPlus;
        }

        private void btnZminus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnZminus.Enabled)
                btnZminus.Image = Properties.Resources.zMinus_g;
            else
                btnZminus.Image = Properties.Resources.Zminus;
        }



        private void btnXOffsetPlus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnXOffsetPlus.Enabled)
                btnXOffsetPlus.Image = Properties.Resources.plus_g;
            else
                btnXOffsetPlus.Image = Properties.Resources.plus;
        }

        private void btnYoffsetPlus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnYoffsetPlus.Enabled)
                btnYoffsetPlus.Image = Properties.Resources.plus_g;
            else
                btnYoffsetPlus.Image = Properties.Resources.plus;
        }

        private void btnXOffsetMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnXOffsetMinus.Enabled)
                btnXOffsetMinus.Image = Properties.Resources.minus_g;
            else
                btnXOffsetMinus.Image = Properties.Resources.minus;
        }

        private void btnYoffsetMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnYoffsetMinus.Enabled)
                btnYoffsetMinus.Image = Properties.Resources.minus_g;
            else
                btnYoffsetMinus.Image = Properties.Resources.minus;
        }

        private void btnZOffsetPlus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnZOffsetPlus.Enabled)
                btnZOffsetPlus.Image = Properties.Resources.zPlusKal_g;
            else
                btnZOffsetPlus.Image = Properties.Resources.zPlusKal;
        }

        private void btnZOffsetMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnZOffsetMinus.Enabled)
                btnZOffsetMinus.Image = Properties.Resources.zMinusKal_g;
            else
                btnZOffsetMinus.Image = Properties.Resources.zMinusKal;
        }

        private void btnEplus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnEplus.Enabled)
                btnEplus.Image = Properties.Resources.plus_g;
            else
                btnEplus.Image = Properties.Resources.plus;
        }

        private void btnT0_OnOff_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT0_OnOff.Enabled)
                btnT0_OnOff.Image = Properties.Resources.aus_g;
            else
                btnT0_OnOff.Image = Properties.Resources.AUS_2;
        }

        private void btnT1_OnOff_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT1_OnOff.Enabled)
                btnT1_OnOff.Image = Properties.Resources.aus_g;
            else
                btnT1_OnOff.Image = Properties.Resources.AUS_2;
        }

        private void btnT2_OnOff_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT2_OnOff.Enabled)
                btnT2_OnOff.Image = Properties.Resources.aus_g;
            else
                btnT2_OnOff.Image = Properties.Resources.AUS_2;
        }

        private void btnT3_OnOff_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT3_OnOff.Enabled)
                btnT3_OnOff.Image = Properties.Resources.aus_g;
            else
                btnT3_OnOff.Image = Properties.Resources.AUS_2;
        }

        private void btnBed_OnOff_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnBed_OnOff.Enabled)
                btnBed_OnOff.Image = Properties.Resources.aus_g;
            else
                btnBed_OnOff.Image = Properties.Resources.AUS_2;
        }



        private void btnRetract_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnRetract.Enabled)
                btnRetract.Image = Properties.Resources.retract_g;
            else
                btnRetract.Image = Properties.Resources.retract;
        }


        private void btnExtrude_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnExtrude.Enabled)
                btnExtrude.Image = Properties.Resources.extrude_g;
            else
                btnExtrude.Image = Properties.Resources.extract;
        }

        private void btnXPlus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnXPlus.Enabled)
                btnXPlus.Image = Properties.Resources.Xplus_g;
            else
                btnXPlus.Image = Properties.Resources.Xplus;
        }

        private void btnYPlus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnYPlus.Enabled)
                btnYPlus.Image = Properties.Resources.Yplus_g;
            else
                btnYPlus.Image = Properties.Resources.Yplus;
        }

        private void btnXMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnXMinus.Enabled)
                btnXMinus.Image = Properties.Resources.Xminus_g;
            else
                btnXMinus.Image = Properties.Resources.Xminus;
        }

        private void btnYMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnYMinus.Enabled)
                btnYMinus.Image = Properties.Resources.YMinus_g;
            else
                btnYMinus.Image = Properties.Resources.Yminus;
        }

        private void btnEminus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnEminus.Enabled)
                btnEminus.Image = Properties.Resources.minus_g;
            else
                btnEminus.Image = Properties.Resources.minus;
        }
        private void btnXhome_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXhome, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G28 X0");
                }
            }
        }


        private void btnYhome_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnYhome, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G28 Y0");
                }
            }
        }

        private void btnZhome_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnZhome, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("G28 Z0");
                }
            }
        }

        private void btnXhome_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnXhome.Enabled)
                btnXhome.Image = Properties.Resources.Xhome_g;
            else
                btnXhome.Image = Properties.Resources.Xhome;
        }

        private void btnYhome_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnYhome.Enabled)
                btnYhome.Image = Properties.Resources.Yhome_g;
            else
                btnYhome.Image = Properties.Resources.Yhome;
        }

        private void btnZhome_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnZhome.Enabled)
                btnZhome.Image = Properties.Resources.Zhome_g;
            else
                btnZhome.Image = Properties.Resources.Zhome;
        }

        ///FILAMENT/////////

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
                host.Connection.injectManualCommand("M109 S" + tempValue + " T0");
                T0_On = true;
                btnT0_OnOff.Image = Properties.Resources.ein;
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-50.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnLoadT0_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M109 S" + tempValue + " T0");
                T0_On = true;
                btnT0_OnOff.Image = Properties.Resources.ein;
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E700.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E700.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E200.0 F200");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnRetractT1_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M109 S" + tempValue + " T1");
                T1_On = true;
                btnT1_OnOff.Image = Properties.Resources.ein;
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-50.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnLoadT1_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M109 S" + tempValue + " T1");
                T1_On = true;
                btnT1_OnOff.Image = Properties.Resources.ein;
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E700.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E700.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E200.0 F200");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnRetractT2_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M109 S" + tempValue + " T2");
                T2_On = true;
                btnT2_OnOff.Image = Properties.Resources.ein;
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-50.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnLoadT2_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M109 S" + tempValue + " T2");
                T2_On = true;
                btnT2_OnOff.Image = Properties.Resources.ein;
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E700.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E700.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E200.0 F200");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnRetractT3_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M109 S" + tempValue + " T3");
                T3_On = true;
                btnT3_OnOff.Image = Properties.Resources.ein;
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-50.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void btnLoadT3_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                tempValue = txtBoxTemp.Text;
                host.Connection.injectManualCommand("M109 S" + tempValue + " T3");
                T3_On = true;
                btnT3_OnOff.Image = Properties.Resources.ein;
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E700.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E700.0 F2000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E200.0 F200");
                host.Connection.injectManualCommand("G92 E0");
            }
        }

        private void numericFeedrate_ValueChanged(object sender, EventArgs e)
        {
            if (numericFeedrate.Value < 300 && numericFeedrate.Value > 25)
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("M220 S" + numericFeedrate.Value.ToString());
                }
            }
        }

        private void numericFlowrate_ValueChanged(object sender, EventArgs e)
        {

            if (numericFeedrate.Value < 300 && numericFeedrate.Value > 25)
            {
                if (host.Connection.connector.IsConnected())
                {
                    host.Connection.injectManualCommand("M221 S" + numericFeedrate.Value.ToString());
                }
            }
        }

        
       

       

        
    }

    
}



