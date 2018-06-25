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
using RepetierServerConnector;
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
using System.Drawing.Drawing2D;

namespace MultecPlugin
{
    public partial class MultecTouchpanel : UserControl, IHostComponent
    {
        #region Variables
        private IHost host;

        //private RSStatus statusServer = new RSStatus();
        //private PrinterConnectorBase. connectorBase =;

        private bool isFormActive = true;   //bool checking if form active when connected
        //private bool isServerActive;
        private bool fineAdjustment;        //
        private bool is4Move = true;
        private double xPosition = 0.0;
        private double yPosition = 0.0;
        private double zPosition = 0.0;
        private bool isPrinting = false;
        private string tempValue = string.Empty;

        private string nozzleSizeT0 = string.Empty;
        private string nozzleSizeT1 = string.Empty;
        private string nozzleSizeT2 = string.Empty;
        private string nozzleSizeT3 = string.Empty;


        private string Version = string.Empty;

        private bool doorOpenCalled;
        private bool printEnableCalled;
        private bool isInitialised = false;




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
        private bool homeXYActive = false;

        private int gCodeCheck = 0;

        private bool T0LoadRetractClicked = false;
        private bool T1LoadRetractClicked = false;
        private bool T2LoadRetractClicked = false;
        private bool T3LoadRetractClicked = false;
        private float GlobalTempVal = 0.00f;
        private int timerRetractCount = 0;
        private bool retractT0 = false;
        private bool loadT0 = false;
        private bool retractT1 = false;
        private bool loadT1 = false;
        private bool retractT2 = false;
        private bool loadT2 = false;
        private bool retractT3 = false;
        private bool loadT3 = false;
        private int resetTimer = 0;

        private bool TempReached = false;

        private int TempTemp = 0;
        private string tool_M218 = string.Empty;
        private int startindex;
        private int endindex1;
        private string xOffset = string.Empty;
        private string yOffset = string.Empty;
        private double newOffset = 0;

        private int zOffsetMultiplyer = 0;
        private int rotOffsetMultiplyer = 0;
        private double relativOffset = 0;
        private string filamentVal = string.Empty;
        private bool T0T1equal;
        private bool T0T2equal;
        private bool T0T3equal;
        private bool T1T2equal;
        private bool T1T3equal;
        private bool T2T3equal;
        private bool doorOpen;
        private int setTempT0 = 0;
        private int setTempT1 = 0;
        private int setTempT2 = 0;
        private int setTempT3 = 0;
        private int setTempBed = 0;
        private int extruderNumber;

        private int parkPositionMultiplyer = 0;
        private double parkPositionOffset = 0;
        private string parkPositionMove;
        private string filePath;
        #endregion


        public MultecTouchpanel()
        {

            InitializeComponent();
            Trans.host.Connection.eventResponse += AddtoListBox;
            Trans.host.Connection.eventConnectionChange += PrinterConnectionChange;
            //ServerConnector server = 
            Version = "Version: v1.0.3";
            VersionLabel.Text = Version;
            tempValue = "205";
            txtBoxTemp.Text = tempValue;
            filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            filePath = Path.Combine(filePath, "NozzleList.tx");


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
                host.Connection.injectManualCommand("G1 E" + -step_dist + " F120");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G90");
            }
        }

        private void but_Extrude_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("G91");
                host.Connection.injectManualCommand("G1 E" + step_dist + " F120");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G90");
            }
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
                TempTemp = Convert.ToInt32(text_T1_ziel.Text.Replace(".0", " ").Trim());

            }
        }













        //////////Heated Bed//////////








        private void Connection_eventResponse(string response, ref RepetierHostExtender.basic.LogLevel level)
        {
            // update position from analyzer
            try
            {
                text_T0_Aktuell.Text = host.Connection.ExtruderTemp.ToString();
                text_T1_Aktuell.Text = host.Connection.Analyzer.GetTemperature(1).ToString(CultureInfo.InvariantCulture);
                text_T2_Aktuell.Text = host.Connection.Analyzer.GetTemperature(2).ToString(CultureInfo.InvariantCulture);
                text_T3_Aktuell.Text = host.Connection.Analyzer.GetTemperature(3).ToString(CultureInfo.InvariantCulture);
                text_Bed_Aktuell.Text = host.Connection.Analyzer.GetTemperature(5).ToString(CultureInfo.InvariantCulture);
                /*
                if (!host.Connection.connector.IsConnected())
                {
                    but_BedMinus.Enabled = false;

                }

                    else but_BedMinus.Enabled = true; */
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection_eventresponse: " + ex);
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

            try
            {


                if (host.Connection.connector.IsConnected())
                {
                    DoTheLoop();

                    //{
                    //    lblBanner.Text = "Connect Through Server";
                    //    isServerActive = true;

                    //}
                    //else if (!connectorBase.ServerConnection)
                    //{
                    //    isServerActive = false;
                    //    lblBanner.Text = "Server Disconnected";
                    //    reset_parameters();
                    //}


                }
                else
                {
                    reset_parameters();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("worker timer fail: " + ex);
            }
        }
        public void PrinterConnectionChange(string msg)
        {

            T0_On = false;
            T1_On = false;
            T2_On = false;
            T3_On = false;
            Bed_On = false;
            //dontUpdateTemp = false;
            isPrinting = false;
            enablDisablWhenDoorOpen(true);
            enablDisablWhenPrinting(true);
            gCodeCheck = 0;
            gCodeIndex = 0;
            getPrev_gCodeDown = 0;
            getPrev_gCodeUp = 5;
            //G222count = 0;
            relativOffset = 0;
            zOffsetMultiplyer = 0;
            rotOffsetMultiplyer = 0;
            parkPositionOffset = 0;
            parkPositionMove = string.Empty;
            parkPositionMultiplyer = 0;

            newOffset = 0;
            isInitialised = true;
            setTempT0 = 0;
            setTempT1 = 0;
            setTempT2 = 0;
            setTempT3 = 0;
            setTempBed = 0;
            T0LoadRetractClicked = false;
            T1LoadRetractClicked = false;
            T2LoadRetractClicked = false;
            T3LoadRetractClicked = false;
            GlobalTempVal = 0.00f;
            timerRetractCount = 0;
            retractT0 = false;
            loadT0 = false;
            retractT1 = false;
            loadT1 = false;
            retractT2 = false;
            loadT2 = false;
            retractT3 = false;
            loadT3 = false;
            TempReached = false;
            resetTimer = 0;
            lblRetractLoadFilT0.Visible = false;
            lblRetractLoadFilT1.Visible = false;
            lblRetractLoadFilT2.Visible = false;
            lblRetractLoadFilT3.Visible = false;
            Array.Clear(gCode, 0, gCode.Length);
            ChckboxDruckerInitialised.Checked = false;
            ChckboxMoveInitialised.Checked = true;    // this is set to true because on connection, if we get Call G222, the move is set to not 
                                                      //initialised, or esle it is always shown as initialised. For connection through server
            lblXPosition.Text = "NICHT INITIALISIERT";
            lblYPosition.Text = "NICHT INITIALISIERT";
            lblZPosition.Text = "NICHT INITIALISIERT";
            xPosition = 0;
            yPosition = 0;
            zPosition = 0;
            step_dist = 1;
            btnStep1.Enabled = false;
            btnStep10.Enabled = true;
            btnStep50.Enabled = true;
            btnStep1.Image = Properties.Resources.onemm_p;
            //redPictureActive = false;
            //doorOpen = false;
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
            btnLoadT0.Enabled = !loadT0;
            btnRetractT0.Enabled = !retractT0;
            btnLoadT1.Enabled = !loadT1;
            btnRetractT1.Enabled = !retractT1;
            btnLoadT2.Enabled = !loadT2;
            btnRetractT2.Enabled = !retractT2;
            btnRetractT3.Enabled = !retractT3;
            btnLoadT3.Enabled = !loadT3;
            text_M218_X.Text = string.Empty;
            text_M218_Y.Text = string.Empty;
            printEnableCalled = false;
            fineAdjustment = false;
            if (!is4Move)
            {

                CheckIfFourMove(false);

            }
            if (is4Move)
            {
                CheckIfFourMove(true);

            }



            chckBoxDruckerende.Checked = false;
            if (msg.IndexOf("Disconnected", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                lblBanner.Text = "Disconnected";
            }

            if (msg.IndexOf("Connected", StringComparison.CurrentCultureIgnoreCase) != -1)
            {

                lblBanner.Text = "Connected";





            }




        }

        public void changeTempButtonsToOn(PictureBox val)
        {
            try
            {
                if (val.Image != Properties.Resources.ein)
                {
                    val.Image = Properties.Resources.ein;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Change temp button on fail: " + ex);
            }
        }
        public void changeTempButtonsToOff(PictureBox val)
        {
            try
            {
                if (val.Image != Properties.Resources.AUS_2)
                {
                    val.Image = Properties.Resources.AUS_2;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Change temp button off fail: " + ex);
            }
        }
        public void AddtoListBox(string response, ref RepetierHostExtender.basic.LogLevel level)
        {

            //if (response.IndexOf("successfully connected", StringComparison.CurrentCultureIgnoreCase) != -1)
            //{

            //    connectedViaServer = true;
            //}

            if (response.IndexOf("Printer halted. Firmware kill called!", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                string message = response.Remove(0, 5);
                ErrorMessage errorMessage = new ErrorMessage(message);


                errorMessage.ShowDialog();
            }
            if (response.IndexOf("Filament geladen", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    btnLoadT0.Enabled = !loadT0;
                    btnRetractT0.Enabled = !retractT0;
                    btnLoadT1.Enabled = !loadT1;
                    btnRetractT1.Enabled = !retractT1;
                    btnLoadT2.Enabled = !loadT2;
                    btnRetractT2.Enabled = !retractT2;
                    btnRetractT3.Enabled = !retractT3;
                    btnLoadT3.Enabled = !loadT3;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in Filament Geladen: " + ex);
                }
            }
            if (response.IndexOf("Filament zurueckgezogen", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    btnLoadT0.Enabled = !loadT0;
                    btnRetractT0.Enabled = !retractT0;
                    btnLoadT1.Enabled = !loadT1;
                    btnRetractT1.Enabled = !retractT1;
                    btnLoadT2.Enabled = !loadT2;
                    btnRetractT2.Enabled = !retractT2;
                    btnRetractT3.Enabled = !retractT3;
                    btnLoadT3.Enabled = !loadT3;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in Filament zurückgezogen: " + ex);
                }
            }
            //if (connectedViaServer)
            //{
            //    if (response.IndexOf("Druckerposition", StringComparison.CurrentCultureIgnoreCase) != -1)
            //    {
            //        lblBanner.Text = "Connected with the Server";
            //        connectedViaServer = false;
            //    }
            //    else
            //    {
            //        lblBanner.Text = "Not Connected with the Server";
            //        connectedViaServer = false;
            //    }

            //}

            if (response.IndexOf("T:", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    if (response.IndexOf("E:", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("E:", StringComparison.CurrentCultureIgnoreCase);
                        extruderNumber = Convert.ToInt32(response.Substring(startindex + 2, 1).Trim());
                        if (response.IndexOf("W:", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {

                            switch (extruderNumber)
                            {
                                case 0:
                                    changeTempButtonsToOn(btnT0_OnOff);
                                    T0_On = true;
                                    break;
                                case 1:
                                    changeTempButtonsToOn(btnT1_OnOff);
                                    T1_On = true;
                                    break;
                                case 2:
                                    changeTempButtonsToOn(btnT2_OnOff);
                                    T2_On = true;
                                    break;
                                case 3:
                                    changeTempButtonsToOn(btnT3_OnOff);
                                    T3_On = true;
                                    break;
                                default:
                                    break;

                            }
                        }
                        if (response.IndexOf("B:", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            changeTempButtonsToOn(btnBed_OnOff);
                            Bed_On = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an Error!! T: " + Environment.NewLine + ex);
                }
            }

            if (response.IndexOf("ok T:", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                int startindex1 = 0;
                int endindex1 = 0;
                int heaterOnTemp = 0;
                string isHeaterOn = string.Empty;

                if (response.IndexOf("T0:", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    try
                    {
                        startindex1 = response.IndexOf("B:", StringComparison.CurrentCultureIgnoreCase);
                        endindex1 = response.IndexOf("/", startindex1, StringComparison.CurrentCultureIgnoreCase);


                        startindex1 = response.IndexOf("T0:", endindex1, StringComparison.CurrentCultureIgnoreCase);
                        if (startindex1 > endindex1)
                        {
                            isHeaterOn = response.Substring(endindex1 + 1, startindex1 - (endindex1 + 1));
                        }
                        else
                        {
                            MessageBox.Show("Startindex is smaller than in T-B endindex: " + Environment.NewLine +
                                "Startindex: " + startindex1 + Environment.NewLine + "Endindex: " + endindex1 +
                                Environment.NewLine + "Difference: " + (startindex1 - (endindex1 + 1)));
                        }
                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show("there was an error in T0: " + ex1);
                    }

                    try
                    {

                        heaterOnTemp = Convert.ToInt32(isHeaterOn.Replace(".0", " ").Trim());
                    }
                    catch (Exception ex6)
                    {
                        MessageBox.Show("Could not convert Bed: " + ex6);
                    }

                    if (heaterOnTemp > 0)
                    {
                        if (heaterOnTemp != setTempBed)
                        {
                            changeTempButtonsToOn(btnBed_OnOff);
                            Bed_On = true;

                            text_Bed_ziel.Text = isHeaterOn.Trim();
                            setTempBed = heaterOnTemp;
                        }
                    }
                    else
                    {
                        changeTempButtonsToOff(btnBed_OnOff);
                        Bed_On = false;
                    }
                }
                if (response.IndexOf("T1:", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    try
                    {
                        endindex1 = response.IndexOf("/", startindex1, StringComparison.CurrentCultureIgnoreCase);
                        startindex1 = response.IndexOf("T1:", endindex1, StringComparison.CurrentCultureIgnoreCase);
                        if (startindex1 > endindex1)
                        {
                            isHeaterOn = response.Substring(endindex1 + 1, startindex1 - (endindex1 + 1));
                        }
                        else
                        {
                            MessageBox.Show("Startindex is smaller than in T0-T1 end index: " + Environment.NewLine +
                                "Startindex: " + startindex1 + Environment.NewLine + "Endindex: " + endindex1 +
                                Environment.NewLine + "Difference: " + (startindex1 - (endindex1 + 1)));
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("there was an error in T1: " + ex2);
                    }
                    try
                    {

                        heaterOnTemp = Convert.ToInt32(isHeaterOn.Replace(".0", " ").Trim());
                    }
                    catch (Exception ex6)
                    {
                        MessageBox.Show("Could not convert T0: " + ex6);
                    }
                    if (heaterOnTemp > 0)
                    {
                        if (heaterOnTemp != setTempT0)
                        {
                            changeTempButtonsToOn(btnT0_OnOff);
                            T0_On = true;

                            text_T0_ziel.Text = isHeaterOn.Trim();
                            setTempT0 = heaterOnTemp;
                            TempTemp = Convert.ToInt32(text_T0_ziel.Text.Replace(".0", " ").Trim());



                        }
                    }
                    else
                    {
                        changeTempButtonsToOff(btnT0_OnOff);
                        T0_On = false;
                    }
                }
                if (response.IndexOf("T2:", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    try
                    {
                        endindex1 = response.IndexOf("/", startindex1, StringComparison.CurrentCultureIgnoreCase);
                        startindex1 = response.IndexOf("T2:", endindex1, StringComparison.CurrentCultureIgnoreCase);
                        if (startindex1 > endindex1)
                        {
                            isHeaterOn = response.Substring(endindex1 + 1, startindex1 - (endindex1 + 1));
                        }
                        else
                        {
                            MessageBox.Show("Startindex is smaller than in T1-T2 end index: " + Environment.NewLine +
                                "Startindex: " + startindex1 + Environment.NewLine + "Endindex: " + endindex1 +
                                Environment.NewLine + "Difference: " + (startindex1 - (endindex1 + 1)));
                        }
                    }
                    catch (Exception ex3)
                    {
                        MessageBox.Show("there was an error in T2: " + ex3);
                    }
                    try
                    {

                        heaterOnTemp = Convert.ToInt32(isHeaterOn.Replace(".0", " ").Trim());
                    }
                    catch (Exception ex6)
                    {
                        MessageBox.Show("Could not convert T1: " + ex6);
                    }
                    if (heaterOnTemp > 0)
                    {
                        if (heaterOnTemp != setTempT1)
                        {
                            changeTempButtonsToOn(btnT1_OnOff);
                            T1_On = true;

                            text_T1_ziel.Text = isHeaterOn.Trim();
                            setTempT1 = heaterOnTemp;
                            TempTemp = Convert.ToInt32(text_T1_ziel.Text.Replace(".0", " ").Trim());

                        }
                    }
                    else
                    {
                        changeTempButtonsToOff(btnT1_OnOff);
                        T1_On = false;
                    }
                }
                if (response.IndexOf("T3:", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    try
                    {
                        endindex1 = response.IndexOf("/", startindex1, StringComparison.CurrentCultureIgnoreCase);

                        startindex1 = response.IndexOf("T3:", endindex1, StringComparison.CurrentCultureIgnoreCase);
                        if (startindex1 > endindex1)
                        {
                            isHeaterOn = response.Substring(endindex1 + 1, startindex1 - (endindex1 + 1));
                        }
                        else
                        {
                            MessageBox.Show("Startindex is smaller than in T2-T3 end index: " + Environment.NewLine +
                                "Startindex: " + startindex1 + Environment.NewLine + "Endindex: " + endindex1 +
                                Environment.NewLine + "Difference: " + (startindex1 - (endindex1 + 1)));
                        }
                    }
                    catch (Exception ex4)
                    {
                        MessageBox.Show("there was an error in T3: " + ex4);
                    }
                    try
                    {

                        heaterOnTemp = Convert.ToInt32(isHeaterOn.Replace(".0", " ").Trim());
                    }
                    catch (Exception ex6)
                    {
                        MessageBox.Show("Could not convert T2: " + ex6);
                    }
                    if (heaterOnTemp > 0)
                    {
                        if (heaterOnTemp != setTempT2)
                        {
                            changeTempButtonsToOn(btnT2_OnOff);
                            T2_On = true;

                            text_T2_ziel.Text = isHeaterOn.Trim();
                            setTempT2 = heaterOnTemp;
                            TempTemp = Convert.ToInt32(text_T2_ziel.Text.Replace(".0", " ").Trim());

                        }
                    }
                    else
                    {
                        changeTempButtonsToOff(btnT2_OnOff);
                        T2_On = false;
                    }
                }
                if (response.IndexOf("T4:", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    try
                    {
                        endindex1 = response.IndexOf("/", startindex1 + 1, StringComparison.CurrentCultureIgnoreCase);
                        startindex1 = response.IndexOf("T4:", endindex1, StringComparison.CurrentCultureIgnoreCase);
                        if (startindex1 > endindex1)
                        {
                            isHeaterOn = response.Substring(endindex1 + 1, startindex1 - (endindex1 + 1));
                        }
                        else
                        {
                            MessageBox.Show("Startindex is smaller than in T3-T4 end index: " + Environment.NewLine +
                                "Startindex: " + startindex1 + Environment.NewLine + "Endindex: " + endindex1 +
                                Environment.NewLine + "Difference: " + (startindex1 - (endindex1 + 1)));
                        }
                    }
                    catch (Exception ex5)
                    {
                        MessageBox.Show("there was an error in T4: " + ex5);
                    }


                    try
                    {

                        heaterOnTemp = Convert.ToInt32(isHeaterOn.Replace(".0", " ").Trim());
                    }
                    catch (Exception ex6)
                    {
                        MessageBox.Show("Could not convert T0: " + ex6);
                    }
                    if (heaterOnTemp > 0)
                    {
                        if (heaterOnTemp != setTempT3)
                        {
                            changeTempButtonsToOn(btnT3_OnOff);
                            T3_On = true;

                            text_T3_ziel.Text = isHeaterOn.Trim();
                            setTempT3 = heaterOnTemp;
                            TempTemp = Convert.ToInt32(text_T3_ziel.Text.Replace(".0", " ").Trim());

                        }
                    }
                    else
                    {
                        changeTempButtonsToOff(btnT3_OnOff);
                        T3_On = false;
                    }


                }

            }

            if (response.IndexOf("X_Position DV", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    startindex = response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase);
                    lblDV.Text = "X:" + response.Substring(startindex + 4);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in X_Position DV: " + ex);
                }
            }

            if (response.IndexOf("Y_Position DV", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    startindex = response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase);
                    lblDV.Text = lblDV.Text + " Y:" + response.Substring(startindex + 4);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in Y_Position DV: " + ex);
                }
            }
            if (response.IndexOf("M51 T", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    startindex = response.IndexOf("T", StringComparison.CurrentCultureIgnoreCase);
                    lblReinigungsschwelle.Text = response.Substring(startindex + 1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in M51 T: " + ex);
                }
            }


            if (response.IndexOf("Druck gestartet", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                isPrinting = true;
                printEnableCalled = false;
                lblBanner.Text = "Is Printing";

            }

            if (response.IndexOf("Druck beendet", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                isPrinting = false;
                printEnableCalled = true;
                lblBanner.Text = "Print Finished";

            }
            if (response.IndexOf("Move Initializiert", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                IsMoveInitialised(true);
                //wasNozSelected = false;
                //btnMove.Enabled = true;

            }
            if (response.IndexOf("Move Nicht Initializiert", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                IsMoveInitialised(false);
            }
            if (response.IndexOf("Drucker Initializiert", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                ChckboxDruckerInitialised.Checked = true;
            }
            if (response.IndexOf("Drucker Nicht Initializiert", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                ChckboxDruckerInitialised.Checked = false;
            }
            if (response.IndexOf("Call G222", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                IsMoveInitialised(false);

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
            if (response.IndexOf("Home X/Y before Z", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    if (wrkrHomeXY.IsBusy != true)
                    {
                        if (!homeXYActive)
                        {
                            homeXYActive = true;
                            wrkrHomeXY.RunWorkerAsync();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ein Fehler ist aufgetreten! " + ex + " Home X/Y before Z wird nicht aktualisiert!");
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
                try
                {

                    if (response.IndexOf("0", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        selected_nozzle = "T0";
                        btnT0.Enabled = false;
                        btnT1.Enabled = true;
                        btnT2.Enabled = true;
                        btnT3.Enabled = true;


                        //btnMove.Enabled = true;

                    }

                    if (response.IndexOf("1", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        selected_nozzle = "T1";
                        btnT0.Enabled = true;
                        btnT1.Enabled = false;
                        btnT2.Enabled = true;
                        btnT3.Enabled = true;

                        //btnMove.Enabled = true;

                    }
                    if (response.IndexOf("2", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        selected_nozzle = "T2";
                        btnT0.Enabled = true;
                        btnT1.Enabled = true;
                        btnT2.Enabled = false;
                        btnT3.Enabled = true;

                        //btnMove.Enabled = true;


                    }
                    if (response.IndexOf("3", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        selected_nozzle = "T3";
                        btnT0.Enabled = true;
                        btnT1.Enabled = true;
                        btnT2.Enabled = true;
                        btnT3.Enabled = false;
                        try
                        {
                            TempTemp = Convert.ToInt32(text_T3_ziel.Text.Replace(".0", " ").Trim());

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There was an error in conversion!! " + ex);
                        }
                    }
                    if (response.IndexOf("4", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        selected_nozzle = "T4";
                        btnT0.Enabled = true;
                        btnT1.Enabled = true;
                        btnT2.Enabled = true;
                        btnT3.Enabled = true;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in ActiveExtruder: " + ex);
                }
            }

            if (response.IndexOf("Druckerposition", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                    startindex = response.IndexOf("=", startindex);
                    endindex1 = response.IndexOf(" ", startindex);
                    lblXPosition.Text = response.Substring(startindex + 1, endindex1 - (startindex + 1));
                    xPosition = Convert.ToDouble(lblXPosition.Text, CultureInfo.InvariantCulture);

                    startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                    startindex = response.IndexOf("=", startindex);
                    endindex1 = response.IndexOf(" ", startindex);
                    lblYPosition.Text = response.Substring(startindex + 1, endindex1 - (startindex + 1));
                    yPosition = Convert.ToDouble(lblYPosition.Text, CultureInfo.InvariantCulture);
                    startindex = response.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase);
                    startindex = response.IndexOf("=", startindex);

                    lblZPosition.Text = response.Substring(startindex + 1);
                    zPosition = Convert.ToDouble(lblZPosition.Text, CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in Druckerposition: " + ex);
                }
            }

            if (response.IndexOf("RunOutMonitoringActive", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in RunOutMonitoringActive: " + ex);
                }
            }

            if (response.IndexOf("Sicherheitskreis offen", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                if (!wrkrOpenDialogBox.IsBusy)
                {
                    wrkrOpenDialogBox.RunWorkerAsync();
                    doorOpen = true;
                    doorOpenCalled = false;

                }
            }
            else if (response.IndexOf("Sicherheitskreis geschlossen", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    if (dialogBox != null)
                    {
                        dialogBox.PreventClosing = false;
                        dialogBox.Close();
                    }

                    doorOpen = false;
                    doorOpenCalled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in Sicherheitskreis geschlossen: " + ex);
                }
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

                if (!is4Move)
                {

                    CheckIfFourMove(false);

                }
                if (is4Move)
                {
                    CheckIfFourMove(true);

                }
            }

            if (response.IndexOf("M218", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    if (response.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                        zOffset_T0 = response.Substring(startindex);
                        lblAbstandT0.Text = zOffset_T0;

                    }
                    if (response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                        zOffset_T1 = response.Substring(startindex);
                        lblAbstandT1.Text = zOffset_T1;
                    }
                    if (response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                        zOffset_T2 = response.Substring(startindex);
                        lblAbstandT2.Text = zOffset_T2;
                    }
                    if (response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                        zOffset_T3 = response.Substring(startindex);
                        lblAbstandT3.Text = zOffset_T3;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in M218 (without tool): " + ex);
                }
                try
                {
                    if (tool_M218 == "T1")
                    {
                        if (response.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                            endindex1 = response.IndexOf(" ", startindex);

                            xOffset = response.Substring(startindex + 1, endindex1 - (startindex + 1));
                            text_M218_X.Text = xOffset;

                            startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                            endindex1 = response.IndexOf(" ", startindex);
                            yOffset = response.Substring(startindex + 1, endindex1 - (startindex + 1));
                            text_M218_Y.Text = yOffset;
                        }
                    }
                    else if (tool_M218 == "T2")
                    {
                        if (response.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                            endindex1 = response.IndexOf(" ", startindex);

                            xOffset = response.Substring(startindex + 1, endindex1 - (startindex + 1));
                            text_M218_X.Text = xOffset;
                            startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                            endindex1 = response.IndexOf(" ", startindex);
                            yOffset = response.Substring(startindex + 1, endindex1 - (startindex + 1));
                            text_M218_Y.Text = yOffset;
                        }
                    }
                    else if (tool_M218 == "T3")
                    {
                        if (response.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            startindex = response.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                            endindex1 = response.IndexOf(" ", startindex);

                            xOffset = response.Substring(startindex + 1, endindex1 - (startindex + 1));
                            text_M218_X.Text = xOffset;
                            startindex = response.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                            endindex1 = response.IndexOf(" ", startindex);
                            yOffset = response.Substring(startindex + 1, endindex1 - (startindex + 1));
                            text_M218_Y.Text = yOffset;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in M218_tool: " + ex);
                }
            }
            if (response.IndexOf("dz_T0_MS_opt", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in dz_T0_MS_opt: " + ex);
                }
            }
            if (response.IndexOf("dz_T0_MS", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in dz_T0_MS(without opt): " + ex);
                }
            }
            if (response.IndexOf("Z-Probe Offset", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
                {
                    if (response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        startindex = response.IndexOf("(mm)", StringComparison.CurrentCultureIgnoreCase);
                        zKorrektur = response.Substring(startindex + 5);
                        lblZKorrektur.Text = zKorrektur;


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in Z-Probe Offset: " + ex);
                }
            }
            if (response.IndexOf("M701", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
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
                    else if (response.IndexOf("P", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        try
                        {
                            startindex = response.IndexOf("P", StringComparison.CurrentCultureIgnoreCase);

                            //\\ Change
                            parkPositionMove = response.Substring(startindex + 1);
                            LblMoveCoverOffset.Text = parkPositionMove;
                            lblParkPositionVal.Text = parkPositionMove;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("There was an error in X_Position DV: " + ex);
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in M701: " + ex);
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
                try
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
                        endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                        lblTotalDistanceX.Text = response.Substring(startindex + 2, endindex1 - (startindex + 2));
                        startindex = response.IndexOf("Y=", StringComparison.CurrentCultureIgnoreCase);
                        endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                        lblTotalDistanceY.Text = response.Substring(startindex + 2, endindex1 - (startindex + 2));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblExtrudedTotalT0.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblExtrudedTotalT1.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblExtrudedTotalT2.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblKgTotalT0.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblKgTotalT1.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblKgTotalT2.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in lifetimecheck = 1: " + ex);
                }
            }
            if (lifetimeCheck == 2)
            {
                try
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
                        endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                        lblSrvcDistanceX.Text = response.Substring(startindex + 2, endindex1 - (startindex + 2));

                        startindex = response.IndexOf("Y=", StringComparison.CurrentCultureIgnoreCase);
                        endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                        lblSrvcDistanceY.Text = response.Substring(startindex + 2, endindex1 - (startindex + 2));

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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblExtrudedSrvcT0.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblExtrudedSrvcT1.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblExtrudedSrvcT2.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblKgSrvcT0.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblKgSrvcT1.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                                endindex1 = response.IndexOf(";", startindex, StringComparison.CurrentCultureIgnoreCase);
                                lblKgSrvcT2.Text = response.Substring(startindex + 3, endindex1 - (startindex + 3));
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in lifetimecheck = 2: " + ex);
                }
            }

            if (response.IndexOf("FilamentAvailable_T0", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in FilamentAvailabe_T0: " + ex);
                }
            }
            if (response.IndexOf("FilamentAvailable_T1", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in FilamentAvailabe_T1: " + ex);
                }
            }
            if (response.IndexOf("FilamentAvailable_T2", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in FilamentAvailabe_T0: " + ex);
                }
            }
            if (response.IndexOf("FilamentAvailable_T3", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                try
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
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error in FilamentAvailabe_T0: " + ex);
                }

            }
        }
        //function to remove temperature readings from textboxes

        //function to add temperature readings to the textboxes
        public void DoTheLoop()
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
                if (!isInitialised)
                {
                    lblBanner.Text = "Connected- Move Nicht Initialisiert";
                }
                if (isInitialised)
                {
                    lblBanner.Text = "Connected";
                }
            }
            if (!doorOpen)
            {
                if (doorOpenCalled)
                {


                    enablDisablWhenDoorOpen(true);
                    doorOpenCalled = false;

                }
            }

            if (!isPrinting)
            {
                if (printEnableCalled)
                {
                    enablDisablWhenPrinting(true);
                    printEnableCalled = false;
                }
            }
            if (isPrinting)
            {
                if (!printEnableCalled)
                {
                    enablDisablWhenPrinting(false);
                    xPosition = 0;
                    yPosition = 0;
                    zPosition = 0;
                    lblXPosition.Text = "Printing";
                    lblYPosition.Text = "Printing";
                    lblZPosition.Text = "Printing";
                    printEnableCalled = true;
                }
            }
            if (doorOpen)
            {
                if (!doorOpenCalled)
                {
                    enablDisablWhenDoorOpen(false);

                    doorOpenCalled = true;
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
            ComboNozzleSizeT2.Visible = val;
            ComboNozzleSizeT3.Visible = val;
            btnT2TempPlus.Visible = val;
            btnT3TempPlus.Visible = val;
            btnT2TempMinus.Visible = val;
            btnT3TempMinus.Visible = val;
            label5.Visible = val;
            label6.Visible = val;
            label9.Visible = val;
            label10.Visible = val;
            btnRetractT2.Visible = val;
            btnLoadT2.Visible = val;
            btnLoadT3.Visible = val;
            btnRetractT3.Visible = val;
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
            lblHeatedSrvcT3.Visible = val;
            lblWhen4Move.Visible = val;
            lblRotOffsetFilament.Visible = val;
            lblKalRotOffsetFilament.Visible = val;
            lblRotOffFillVal.Visible = val;
            lblWhen4Move_1.Visible = val;
            btnEminus.Visible = val;
            btnEplus.Visible = val;
            btnRotOffsetSend.Visible = val;
            LblMoveCoverOffset.Visible = val;
            lblParkPosition.Visible = val;
            //\\ Change this
            lblKalParkPosition.Visible = val;
            lblParkPositionVal.Visible = val;
            lblWhen4Move_2.Visible = val;
            btnPminus.Visible = val;
            btnPplus.Visible = val;
            btnParkPositionSend.Visible = val;

        }
        public void enablDisablWhenDoorOpen(bool val)
        {

            btnMotorOff.Enabled = val;
            btnHome.Enabled = val;
            btnXhome.Enabled = val;
            btnYhome.Enabled = val;
            //btnZhome.Enabled = val;
            btnXMinus.Enabled = val;
            btnXPlus.Enabled = val;
            btnYMinus.Enabled = val;
            btnYPlus.Enabled = val;
            btnZminus.Enabled = val;
            btnZPlus.Enabled = val;
            btnXMinus.Enabled = val;
            btnXPlus.Enabled = val;
            btnYMinus.Enabled = val;
            btnYPlus.Enabled = val;
            btnZminus.Enabled = val;
            btnZPlus.Enabled = val;

            btnDusevermessung.Enabled = val;
            btnPositionPrufen.Enabled = val;
            btnFineAdjustment.Enabled = val;
            //PictrBoxDoorOpen.Visible = !val;

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
            btnLoadT0.Enabled = val;
            btnLoadT1.Enabled = val;
            btnLoadT2.Enabled = val;
            btnLoadT3.Enabled = val;
            btnRetractT0.Enabled = val;
            btnRetractT1.Enabled = val;
            btnRetractT2.Enabled = val;
            btnRetractT3.Enabled = val;
            btnParkMove.Enabled = val;
            btnHomeMove.Enabled = val;
            btnMotorOff.Enabled = val;
            btnHome.Enabled = val;
            btnXhome.Enabled = val;
            btnYhome.Enabled = val;
            //btnZhome.Enabled = val;
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

            //\\ ///Change the following
            btnPminus.Enabled = val;
            btnPplus.Enabled = val;
            btnParkPositionSend.Enabled = val;
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

            temp_Zeil = "205";
            temp_Zeil_bed = "60";
            text_T0_ziel.Text = "205";
            text_T1_ziel.Text = "205";
            text_T2_ziel.Text = "205";
            text_T3_ziel.Text = "205";
            text_Bed_ziel.Text = "60";
            if (isFormActive)
            {
                enableDisableControls(false, this);
                isFormActive = false;
                lblBanner.Text = "Disconnected";
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
                    lblXPosition.Text = xPosition.ToString(CultureInfo.InvariantCulture);
                    lblXPosition.Text = lblXPosition.Text.Replace(",", ".");
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
                    lblXPosition.Text = xPosition.ToString(CultureInfo.InvariantCulture);
                    lblXPosition.Text = lblXPosition.Text.Replace(",", ".");
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
                    lblYPosition.Text = yPosition.ToString(CultureInfo.InvariantCulture);
                    lblYPosition.Text = lblYPosition.Text.Replace(",", ".");
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
                    lblYPosition.Text = yPosition.ToString(CultureInfo.InvariantCulture);
                    lblYPosition.Text = lblYPosition.Text.Replace(",", ".");
                }
            }
        }



        //public static Bitmap CombineAndResizeTwoImages(Image image1, Image image2, int width, int height)
        //{

        //    //a holder for the result
        //    Bitmap result = new Bitmap(width, height);

        //    //use a graphics object to draw the resized image into the bitmap
        //    using (Graphics graphics = Graphics.FromImage(result))
        //    {
        //        //set the resize quality modes to high quality
        //        graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
        //        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        //        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        //        //draw the images into the target bitmap
        //        graphics.DrawImage(image1, 0, 0, result.Width, result.Height);
        //        graphics.DrawImage(image2, 0, 0, result.Width, result.Height);

        //    }

        //    //return the resulting bitmap
        //    return result;
        //}


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
                UpdateNozzleSize(filePath);
                GetNozzleSizeString();
                EndlessNozzleCheck();

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
                    lblZPosition.Text = zPosition.ToString(CultureInfo.InvariantCulture);
                    lblZPosition.Text = lblZPosition.Text.Replace(",", ".");
                }
            }




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
                    lblZPosition.Text = zPosition.ToString(CultureInfo.InvariantCulture);
                    lblZPosition.Text = lblZPosition.Text.Replace(",", ".");

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
                    lblBanner.Text = "Connected";

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
                    selected_nozzle = "T0";
                    btnT0.Enabled = false;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    //btnMove.Enabled = true;


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
                if (getPrev_gCodeUp > gCodeCheck && gCodeCheck != 0)
                {
                    getPrev_gCodeUp = gCodeCheck - 1;
                }
                //MessageBox.Show("the value of index is" + getPrev_gCodeUp.ToString(CultureInfo.InvariantCulture));
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
                if (getPrev_gCodeDown > gCodeCheck && gCodeCheck != 0)
                {
                    getPrev_gCodeDown = gCodeCheck - 1;
                }
                txtManualGcode.Text = gCode[getPrev_gCodeDown];
                getPrev_gCodeDown++;

                if (txtManualGcode.Text != String.Empty)
                {
                    txtManualGcode.Select(txtManualGcode.Text.Length, 0);
                }
            }


        }
        private void M109M190Check(string val)
        {
            int regionalStartIndex = 0;
            int regionalendindex1 = 0;

            if (val.IndexOf("M109", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                if (val.IndexOf("S", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    if (val.IndexOf("T", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        regionalStartIndex = val.IndexOf("T", StringComparison.CurrentCultureIgnoreCase);
                        extruderNumber = Convert.ToInt32(val.Substring(regionalStartIndex + 1, 1).Trim());
                    }
                    else
                    {
                        extruderNumber = 0;
                    }
                    regionalStartIndex = val.IndexOf("S", StringComparison.CurrentCultureIgnoreCase);
                    if (val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        regionalendindex1 = val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase);
                        if (regionalendindex1 != regionalStartIndex + 1)
                        {

                            tempValue = val.Substring(regionalStartIndex + 1, regionalendindex1 - (regionalStartIndex + 1)).Trim();

                        }
                        else
                        {
                            if (val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase) != -1)
                            {
                                regionalendindex1 = val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase);
                                tempValue = val.Substring(regionalStartIndex + 2, regionalendindex1 - (regionalStartIndex + 2)).Trim();

                            }
                            else
                            {
                                tempValue = val.Substring(regionalStartIndex + 2).Trim();

                            }
                        }
                    }
                    else
                    {
                        tempValue = val.Substring(regionalStartIndex + 1).Trim();

                    }
                    switch (extruderNumber)
                    {
                        case 0:
                            text_T0_ziel.Text = tempValue;
                            break;
                        case 1:
                            text_T1_ziel.Text = tempValue;
                            break;
                        case 2:
                            text_T2_ziel.Text = tempValue;
                            break;
                        case 3:
                            text_T3_ziel.Text = tempValue;
                            break;
                        default:
                            break;

                    }
                }
            }
            if (val.IndexOf("M190", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                if (val.IndexOf("S", StringComparison.CurrentCultureIgnoreCase) != -1)
                {

                    regionalStartIndex = val.IndexOf("S", StringComparison.CurrentCultureIgnoreCase);
                    if (val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        regionalendindex1 = val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase);
                        if (regionalendindex1 != regionalStartIndex + 1)
                        {

                            tempValue = val.Substring(regionalStartIndex + 1, regionalendindex1 - (regionalStartIndex + 1)).Trim();

                        }
                        else
                        {
                            if (val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase) != -1)
                            {
                                regionalendindex1 = val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase);
                                tempValue = val.Substring(regionalStartIndex + 2, regionalendindex1 - (regionalStartIndex + 2)).Trim();

                            }
                            else
                            {
                                tempValue = val.Substring(regionalStartIndex + 2).Trim();

                            }
                        }
                    }
                    else
                    {
                        tempValue = val.Substring(regionalStartIndex + 1).Trim();

                    }
                    text_Bed_ziel.Text = tempValue;

                }
            }
        }
        private void G1G0Check(string val)
        {
            int regionalStartIndex = 0;
            int regionalendindex1 = 0;

            if (val.IndexOf("X", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                regionalStartIndex = val.IndexOf("X", StringComparison.CurrentCultureIgnoreCase);
                if (val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    regionalendindex1 = val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase);
                    if (regionalendindex1 != regionalStartIndex + 1)
                    {

                        lblXPosition.Text = val.Substring(regionalStartIndex + 1, regionalendindex1 - (regionalStartIndex + 1)).Trim();
                        xPosition = Convert.ToDouble(lblXPosition.Text, CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        if (val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            regionalendindex1 = val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase);
                            lblXPosition.Text = val.Substring(regionalStartIndex + 2, regionalendindex1 - (regionalStartIndex + 2)).Trim();
                            xPosition = Convert.ToDouble(lblXPosition.Text, CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            lblXPosition.Text = val.Substring(regionalStartIndex + 2).Trim();
                            xPosition = Convert.ToDouble(lblXPosition.Text, CultureInfo.InvariantCulture);
                        }
                    }
                }
                else
                {
                    lblXPosition.Text = val.Substring(regionalStartIndex + 1).Trim();
                    xPosition = Convert.ToDouble(lblXPosition.Text, CultureInfo.InvariantCulture);
                }
            }
            if (val.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                regionalStartIndex = val.IndexOf("Y", StringComparison.CurrentCultureIgnoreCase);
                if (val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    regionalendindex1 = val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase);
                    if (regionalendindex1 != regionalStartIndex + 1)
                    {

                        lblYPosition.Text = val.Substring(regionalStartIndex + 1, regionalendindex1 - (regionalStartIndex + 1)).Trim();
                        yPosition = Convert.ToDouble(lblYPosition.Text, CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        if (val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            regionalendindex1 = val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase);
                            lblYPosition.Text = val.Substring(regionalStartIndex + 2, regionalendindex1 - (regionalStartIndex + 2)).Trim();
                            yPosition = Convert.ToDouble(lblYPosition.Text, CultureInfo.InvariantCulture);
                        }
                        else
                        {
                            lblYPosition.Text = val.Substring(regionalStartIndex + 2).Trim();
                            yPosition = Convert.ToDouble(lblYPosition.Text, CultureInfo.InvariantCulture);
                        }
                    }
                }
                else
                {
                    lblYPosition.Text = val.Substring(regionalStartIndex + 1).Trim();
                    yPosition = Convert.ToDouble(lblYPosition.Text, CultureInfo.InvariantCulture);
                }
            }
            if (val.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                regionalStartIndex = val.IndexOf("Z", StringComparison.CurrentCultureIgnoreCase);

                if (val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase) != -1)
                {


                    regionalendindex1 = val.IndexOf(" ", regionalStartIndex, StringComparison.CurrentCultureIgnoreCase);
                    if (regionalendindex1 != regionalStartIndex + 1)
                    {

                        lblZPosition.Text = val.Substring(regionalStartIndex + 1, regionalendindex1 - (regionalStartIndex + 1)).Trim();
                        zPosition = Convert.ToDouble(lblZPosition.Text.Trim(), CultureInfo.InvariantCulture);
                    }
                    else
                    {
                        if (val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase) != -1)
                        {

                            regionalendindex1 = val.IndexOf(" ", regionalendindex1 + 1, StringComparison.CurrentCultureIgnoreCase);
                            lblZPosition.Text = val.Substring(regionalStartIndex + 2, regionalendindex1 - (regionalStartIndex + 2)).Trim();
                            zPosition = Convert.ToDouble(lblZPosition.Text.Trim(), CultureInfo.InvariantCulture);
                        }
                        else
                        {

                            lblZPosition.Text = val.Substring(regionalStartIndex + 2).Trim();
                            zPosition = Convert.ToDouble(lblZPosition.Text, CultureInfo.InvariantCulture);
                        }
                    }
                }
                else
                {
                    lblZPosition.Text = val.Substring(regionalStartIndex + 1).Trim();
                    zPosition = Convert.ToDouble(lblZPosition.Text, CultureInfo.InvariantCulture);
                }
            }
        }
        private void WrkerColdExtrusion_DoWork(object sender, DoWorkEventArgs e)
        {


            var newMsg = MessageBox.Show(this, "Düsentemperatur zu gering. Extrusion nicht verfügbar. Bitte Düse aufheizen.", "Warnung!",
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
        public void IsMoveInitialised(bool status)
        {
            isInitialised = status;
            if (!isInitialised)
            {

                lblBanner.Text = "Connected- Move Nicht Initialisiert";
                btnT0.Enabled = false;
                btnT1.Enabled = false;
                btnT2.Enabled = false;
                btnT3.Enabled = false;

                btnT0.Image = Properties.Resources.T0_g;
                btnT1.Image = Properties.Resources.T1_g;
                btnT2.Image = Properties.Resources.T2_g;
                btnT3.Image = Properties.Resources.T3_g;
                ChckboxMoveInitialised.Checked = false;
                //wasNozSelected = false;
                //btnMove.Enabled = true;
                selected_nozzle = string.Empty;
            }
            else
            {
                ChckboxMoveInitialised.Checked = true;
                isInitialised = true;
                lblBanner.Text = "Connected";
                btnT0.Enabled = true;
                btnT1.Enabled = true;
                btnT2.Enabled = true;
                btnT3.Enabled = true;
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
                    if (text_T0_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        temp_Zeil = text_T0_ziel.Text.Replace(",", ".").Trim();
                    }
                    else
                    {
                        temp_Zeil = text_T0_ziel.Text.Trim();
                    }
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



        private void btnT1_OnOff_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                T1_On = !T1_On;

                if (T1_On == true)
                {
                    if (text_T1_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        temp_Zeil = text_T1_ziel.Text.Replace(",", ".").Trim();
                    }
                    else
                    {
                        temp_Zeil = text_T1_ziel.Text.Trim();
                    }
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
                    if (text_T2_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        temp_Zeil = text_T2_ziel.Text.Replace(",", ".").Trim();
                    }
                    else
                    {
                        temp_Zeil = text_T2_ziel.Text.Trim();
                    }
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
                    if (text_T3_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        temp_Zeil = text_T3_ziel.Text.Replace(",", ".").Trim();
                    }
                    else
                    {
                        temp_Zeil = text_T3_ziel.Text.Trim();
                    }
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
                    if (text_Bed_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        temp_Zeil_bed = text_Bed_ziel.Text.Replace(",", ".").Trim();
                    }
                    else
                    {
                        temp_Zeil_bed = text_Bed_ziel.Text.Trim();
                    }
                    host.Connection.injectManualCommand("M140 S" + temp_Zeil_bed);
                    btnBed_OnOff.Image = Properties.Resources.ein;
                }
                else
                {
                    host.Connection.injectManualCommand("M140 S0");
                    btnBed_OnOff.Image = Properties.Resources.AUS_2;
                }
            }
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
                if (gCode[gCodeIndex].IndexOf("M109", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    M109M190Check(gCode[gCodeIndex]);

                }
                if (gCode[gCodeIndex].IndexOf("M190", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    M109M190Check(gCode[gCodeIndex]);

                }
                gCodeIndex++;
                gCodeCheck = gCode.Count(s => s != null);
                txtManualGcode.Text = string.Empty;

            }
            else
            {
                MessageBox.Show("Kein G-Code eingegeben. Bitte geben Sie den G-Code ein, bevor Sie auf Senden klicken",
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
                    //host.Connection.injectManualCommand("M990");
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


                host.Connection.injectManualCommand("M701 " + "E" + relativOffset.ToString(CultureInfo.InvariantCulture));
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



            host.Connection.injectManualCommand("M702 " + "D" + relativOffset.ToString(CultureInfo.InvariantCulture));
            zOffsetMultiplyer = 0;
        }

        private void btnFineAdjustment_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Warnung! Der Drucker führt nun HOME ALL aus. Stellen Sie sicher, dass das Bett frei ist." + Environment.NewLine +
                 "Drücken Sie OK, um fortzufahren", "WARNUNG!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ms == DialogResult.OK)
            {
                //host.Connection.injectManualCommand("G991");
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
                //host.Connection.injectManualCommand("G990");
                host.Connection.injectManualCommand("G295");
                host.Connection.injectManualCommand("G296");
                host.Connection.injectManualCommand("M503");
            }
        }

        private void BtnPositionPrufen_Click(object sender, EventArgs e)
        {
            if (host.Connection.connector.IsConnected())
            {
                host.Connection.injectManualCommand("G297");
            }
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
                    text_M218_Y.Text.Replace(",", ".");
                    newOffset = Convert.ToDouble(text_M218_Y.Text, CultureInfo.InvariantCulture) + 0.05;
                    text_M218_Y.Text = newOffset.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        private void btnXOffsetPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXOffsetPlus, e.X, e.Y))
            {
                if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
                {
                    text_M218_X.Text.Replace(",", ".");
                    newOffset = Convert.ToDouble(text_M218_X.Text, CultureInfo.InvariantCulture) + 0.05;
                    text_M218_X.Text = newOffset.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        private void btnXOffsetMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnXOffsetMinus, e.X, e.Y))
            {
                if (tool_M218 != string.Empty && text_M218_X.Text != string.Empty)
                {
                    text_M218_X.Text.Replace(",", ".");
                    newOffset = Convert.ToDouble(text_M218_X.Text, CultureInfo.InvariantCulture) - 0.05;
                    text_M218_X.Text = newOffset.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        private void btnYoffsetMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnYoffsetMinus, e.X, e.Y))
            {
                if (tool_M218 != string.Empty && text_M218_Y.Text != string.Empty)
                {
                    text_M218_Y.Text.Replace(",", ".");
                    newOffset = Convert.ToDouble(text_M218_Y.Text, CultureInfo.InvariantCulture) - 0.05;
                    text_M218_Y.Text = newOffset.ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        private void btnZOffsetPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnZOffsetPlus, e.X, e.Y))
            {
                zOffsetMultiplyer = zOffsetMultiplyer + 1;
                lbl_zOffset.Text.Replace(",", ".");
                newOffset = Convert.ToDouble(lbl_zOffset.Text, CultureInfo.InvariantCulture) + 0.05;
                if (newOffset < 7)
                {
                    lbl_zOffset.Text = newOffset.ToString(CultureInfo.InvariantCulture);

                }
                else
                {
                    MessageBox.Show("Der Z-Wert kann nicht größer als 7 mm sein.", "WARNUNG!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnZOffsetMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnZOffsetMinus, e.X, e.Y))
            {
                zOffsetMultiplyer = zOffsetMultiplyer - 1;
                lbl_zOffset.Text.Replace(",", ".");
                newOffset = Convert.ToDouble(lbl_zOffset.Text, CultureInfo.InvariantCulture) - 0.05;
                if (newOffset > -7)
                {
                    lbl_zOffset.Text = newOffset.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    MessageBox.Show("Der Z-Wert kann nicht kleiner als -7 mm sein.", "WARNUNG!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEplus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnEplus, e.X, e.Y))
            {
                rotOffsetMultiplyer = rotOffsetMultiplyer + 1;
                lblRotOffFillVal.Text.Replace(",", ".");
                newOffset = Convert.ToDouble(lblRotOffFillVal.Text, CultureInfo.InvariantCulture) + 0.5;
                if (newOffset <= 20)
                {
                    lblRotOffFillVal.Text = newOffset.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    MessageBox.Show("Der Rotations-Offset Filamentauswahl kann nicht größer als 20 mm sein.", "WARNUNG!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnEminus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnEminus, e.X, e.Y))
            {
                rotOffsetMultiplyer = rotOffsetMultiplyer - 1;
                lblRotOffFillVal.Text.Replace(",", ".");
                newOffset = Convert.ToDouble(lblRotOffFillVal.Text, CultureInfo.InvariantCulture) - 0.5;
                if (newOffset >= 2)
                {
                    lblRotOffFillVal.Text = newOffset.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    MessageBox.Show("Der Rotations-Offset Filamentauswahl kann nicht kleiner als 2 mm sein.", "WARNUNG!",
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

        //private void btnZhome_EnabledChanged(object sender, EventArgs e)
        //{
        //    if (!btnZhome.Enabled)
        //        btnZhome.Image = Properties.Resources.Zhome_g;
        //    else
        //        btnZhome.Image = Properties.Resources.Zhome;
        //}

        ///FILAMENT/////////

        private void txtBoxTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
















        private void numericFeedrate_ValueChanged(object sender, EventArgs e)
        {
            if (numericFeedrate.Value < 300 && numericFeedrate.Value > 25)
            {
                if (host.Connection.connector.IsConnected())
                {

                    host.Connection.injectManualCommand("M220 S" + numericFeedrate.Value.ToString(CultureInfo.InvariantCulture));
                }
            }
        }

        private void numericFlowrate_ValueChanged(object sender, EventArgs e)
        {

            if (numericFlowrate.Value < 300 && numericFlowrate.Value > 25)
            {
                if (host.Connection.connector.IsConnected())
                {

                    host.Connection.injectManualCommand("M221 S" + numericFlowrate.Value.ToString(CultureInfo.InvariantCulture));
                }
            }
        }



        private void btnFlowratePlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnFlowratePlus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    numericFlowrate.Value = numericFlowrate.Value + 5;
                }
            }
        }

        private void btnFlowrateMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnFlowrateMinus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    numericFlowrate.Value = numericFlowrate.Value - 5;
                }
            }
        }

        private void btnFeedratePlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnFeedratePlus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    numericFeedrate.Value = numericFeedrate.Value + 5;
                }
            }
        }

        private void btnFeedrateMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnFeedrateMinus, e.X, e.Y))
            {
                if (host.Connection.connector.IsConnected())
                {
                    numericFeedrate.Value = numericFeedrate.Value - 5;
                }
            }
        }
        public DoorOpenDialogBox dialogBox;



        private void wrkrOpenDialogBox_DoWork(object sender, DoWorkEventArgs e)
        {

            dialogBox = new DoorOpenDialogBox()
            {
                StartPosition = FormStartPosition.Manual
            };
            dialogBox.Location = new Point(48, 150);
            dialogBox.ShowDialog();


        }

        private void text_T0_ziel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (text_T0_ziel.Text != string.Empty)
                {
                    if (IsValidNozzleTemp(text_T0_ziel.Text.Replace(",", ".")))
                    {
                        if (text_T0_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            temp_Zeil = text_T0_ziel.Text.Replace(",", ".").Trim();
                        }
                        else
                        {
                            temp_Zeil = text_T0_ziel.Text.Trim();
                        }
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T0");
                        T0_On = true;
                        btnT0_OnOff.Image = Properties.Resources.ein;
                    }
                    else
                    {
                        MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                        text_T0_ziel.Text = "205";
                    }
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                text_T0_ziel.Text = string.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_T1_ziel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (text_T1_ziel.Text != string.Empty)
                {
                    if (IsValidNozzleTemp(text_T1_ziel.Text.Replace(",", ".")))
                    {
                        if (text_T1_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            temp_Zeil = text_T1_ziel.Text.Replace(",", ".").Trim();
                        }
                        else
                        {
                            temp_Zeil = text_T1_ziel.Text.Trim();
                        }
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T1");
                        T1_On = true;
                        btnT1_OnOff.Image = Properties.Resources.ein;

                    }
                    else
                    {
                        MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");

                        text_T1_ziel.Text = "205";
                    }
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                text_T1_ziel.Text = string.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_T2_ziel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (text_T2_ziel.Text != string.Empty)
                {
                    if (IsValidNozzleTemp(text_T2_ziel.Text.Replace(",", ".")))
                    {
                        if (text_T2_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            temp_Zeil = text_T2_ziel.Text.Replace(",", ".").Trim();
                        }
                        else
                        {
                            temp_Zeil = text_T2_ziel.Text.Trim();
                        }
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T2");
                        T2_On = true;
                        btnT2_OnOff.Image = Properties.Resources.ein;


                    }
                    else
                    {
                        MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                        text_T2_ziel.Text = "205";
                    }
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                text_T2_ziel.Text = string.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_T3_ziel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (text_T3_ziel.Text != string.Empty)
                {
                    if (IsValidNozzleTemp(text_T3_ziel.Text.Replace(",", ".")))
                    {

                        if (text_T3_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            temp_Zeil = text_T3_ziel.Text.Replace(",", ".").Trim();
                        }
                        else
                        {
                            temp_Zeil = text_T3_ziel.Text.Trim();
                        }
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T3");
                        T3_On = true;
                        btnT3_OnOff.Image = Properties.Resources.ein;

                    }
                    else
                    {
                        MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                        text_T3_ziel.Text = "205";
                    }
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                text_T3_ziel.Text = string.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void text_Bed_ziel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (text_Bed_ziel.Text != string.Empty)
                {
                    if (IsValidBedTemp(text_Bed_ziel.Text.Replace(",", ".")))
                    {
                        if (text_Bed_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                        {
                            temp_Zeil_bed = text_Bed_ziel.Text.Replace(",", ".").Trim();
                        }
                        else
                        {
                            temp_Zeil_bed = text_Bed_ziel.Text.Trim();
                        }
                        host.Connection.injectManualCommand("M140 S" + temp_Zeil_bed);
                        Bed_On = true;
                        btnBed_OnOff.Image = Properties.Resources.ein;
                    }
                    else
                    {
                        MessageBox.Show("Temperatur muss zwischen 0 und 100 sein!!");
                        text_Bed_ziel.Text = "60";
                    }
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                text_Bed_ziel.Text = string.Empty;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void wrkrHomeXY_DoWork(object sender, DoWorkEventArgs e)
        {

            var newMsg = MessageBox.Show(this, "Home X/Y before Z", "Warnung!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

            if (newMsg == DialogResult.OK)
            {
                homeXYActive = false;
            }

        }

        private void timerRetractLoad_Tick(object sender, EventArgs e)
        {
            try
            {
                if (txtBoxTemp.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    tempValue = txtBoxTemp.Text.Replace(",", ".");
                }
                else
                {
                    tempValue = txtBoxTemp.Text.Replace(".0", ".00");
                }
                if (tempValue.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) == -1)
                {
                    tempValue = tempValue.Insert(tempValue.Length, ".00");
                }


                float.TryParse(tempValue, out float f);
                f = (float)(Math.Round(f, 2));
                ++resetTimer;
                if (resetTimer == 10)
                {
                    timerRetractLoad.Stop();
                    timerRetractLoad.Start();
                }
                if (T0LoadRetractClicked)
                {
                    float.TryParse(text_T0_Aktuell.Text.Replace(",", "."), out GlobalTempVal);
                    GlobalTempVal = (float)(Math.Round(GlobalTempVal, 2));
                    if (GlobalTempVal >= f)
                    {
                        TempReached = true;
                    }
                    if (TempReached)
                    {
                        ++timerRetractCount;
                        if (retractT0)
                        {
                            lblRetractLoadFilT0.Text = "Heizung abgeschlossen. Jetzt zurückziehen";
                            if (timerRetractCount == 14)
                            {
                                lblRetractLoadFilT0.Text = "Zurückziehen abgeschlossen ist, Düse T0";

                                btnLoadT0.Enabled = !loadT0;
                                btnRetractT0.Enabled = !retractT0;
                                btnLoadT1.Enabled = !loadT1;
                                btnRetractT1.Enabled = !retractT1;
                                btnLoadT2.Enabled = !loadT2;
                                btnRetractT2.Enabled = !retractT2;
                                btnRetractT3.Enabled = !retractT3;
                                btnLoadT3.Enabled = !loadT3;




                                TempReached = false;
                                host.Connection.injectManualCommand("M104 S0 T0");
                                host.Connection.injectManualCommand("T1");
                                timerRetractLoad.Stop();

                            }
                        }
                        if (loadT0)
                        {
                            lblRetractLoadFilT0.Text = "Aufheizen abgeschlossen. Lädt";
                            if (timerRetractCount == 30)
                            {
                                lblRetractLoadFilT0.Text = "Laden abgeschlossen, Düse T0";

                                btnLoadT0.Enabled = !loadT0;
                                btnRetractT0.Enabled = !retractT0;
                                btnLoadT1.Enabled = !loadT1;
                                btnRetractT1.Enabled = !retractT1;
                                btnLoadT2.Enabled = !loadT2;
                                btnRetractT2.Enabled = !retractT2;
                                btnRetractT3.Enabled = !retractT3;
                                btnLoadT3.Enabled = !loadT3;
                                TempReached = false;
                                host.Connection.injectManualCommand("M104 S0 T0");
                                timerRetractLoad.Stop();
                            }
                        }
                    }
                }
                else if (T1LoadRetractClicked)
                {
                    float.TryParse(text_T1_Aktuell.Text.Replace(",", "."), out GlobalTempVal);
                    GlobalTempVal = (float)(Math.Round(GlobalTempVal, 2));
                    if (GlobalTempVal >= f)
                    {
                        TempReached = true;
                    }
                    if (TempReached)
                    {

                        ++timerRetractCount;
                        if (retractT1)
                        {
                            lblRetractLoadFilT1.Text = "Heizung abgeschlossen. Jetzt zurückziehen";
                            if (timerRetractCount == 14)
                            {
                                lblRetractLoadFilT1.Text = "Zurückziehen abgeschlossen ist, Düse T1";

                                btnLoadT0.Enabled = !loadT0;
                                btnRetractT0.Enabled = !retractT0;
                                btnLoadT1.Enabled = !loadT1;
                                btnRetractT1.Enabled = !retractT1;
                                btnLoadT2.Enabled = !loadT2;
                                btnRetractT2.Enabled = !retractT2;
                                btnRetractT3.Enabled = !retractT3;
                                btnLoadT3.Enabled = !loadT3;
                                TempReached = false;
                                host.Connection.injectManualCommand("M104 S0 T1");
                                host.Connection.injectManualCommand("T0");
                                timerRetractLoad.Stop();
                            }
                        }
                        if (loadT1)
                        {
                            lblRetractLoadFilT1.Text = "Aufheizen abgeschlossen. Lädt";
                            if (timerRetractCount == 30)
                            {
                                lblRetractLoadFilT1.Text = "Laden abgeschlossen, Düse T1";

                                btnLoadT0.Enabled = !loadT0;
                                btnRetractT0.Enabled = !retractT0;
                                btnLoadT1.Enabled = !loadT1;
                                btnRetractT1.Enabled = !retractT1;
                                btnLoadT2.Enabled = !loadT2;
                                btnRetractT2.Enabled = !retractT2;
                                btnRetractT3.Enabled = !retractT3;
                                btnLoadT3.Enabled = !loadT3;
                                TempReached = false;
                                host.Connection.injectManualCommand("M104 S0 T1");

                                timerRetractLoad.Stop();
                            }
                        }
                    }
                }
                else if (T2LoadRetractClicked)
                {
                    float.TryParse(text_T2_Aktuell.Text.Replace(",", "."), out GlobalTempVal);
                    GlobalTempVal = (float)(Math.Round(GlobalTempVal, 2));
                    if (GlobalTempVal >= f)
                    {
                        TempReached = true;
                    }
                    if (TempReached)
                    {

                        ++timerRetractCount;
                        if (retractT2)
                        {
                            lblRetractLoadFilT2.Text = "Heizung abgeschlossen. Jetzt zurückziehen";
                            if (timerRetractCount == 14)
                            {
                                lblRetractLoadFilT2.Text = "Zurückziehen abgeschlossen ist, Düse T2";

                                btnLoadT0.Enabled = !loadT0;
                                btnRetractT0.Enabled = !retractT0;
                                btnLoadT1.Enabled = !loadT1;
                                btnRetractT1.Enabled = !retractT1;
                                btnLoadT2.Enabled = !loadT2;
                                btnRetractT2.Enabled = !retractT2;
                                btnRetractT3.Enabled = !retractT3;
                                btnLoadT3.Enabled = !loadT3;
                                TempReached = false;
                                host.Connection.injectManualCommand("M104 S0 T2");
                                host.Connection.injectManualCommand("T0");
                                timerRetractLoad.Stop();
                            }
                        }
                        if (loadT2)
                        {
                            lblRetractLoadFilT2.Text = "Aufheizen abgeschlossen. Lädt";
                            if (timerRetractCount == 30)
                            {
                                lblRetractLoadFilT2.Text = "Laden abgeschlossen, Düse T2";

                                btnLoadT0.Enabled = !loadT0;
                                btnRetractT0.Enabled = !retractT0;
                                btnLoadT1.Enabled = !loadT1;
                                btnRetractT1.Enabled = !retractT1;
                                btnLoadT2.Enabled = !loadT2;
                                btnRetractT2.Enabled = !retractT2;
                                btnRetractT3.Enabled = !retractT3;
                                btnLoadT3.Enabled = !loadT3;
                                TempReached = false;
                                host.Connection.injectManualCommand("M104 S0 T2");
                                timerRetractLoad.Stop();
                            }
                        }
                    }
                }
                else if (T3LoadRetractClicked)
                {

                    float.TryParse(text_T3_Aktuell.Text.Replace(",", "."), out GlobalTempVal);
                    GlobalTempVal = (float)(Math.Round(GlobalTempVal, 2));
                    if (GlobalTempVal >= f)
                    {
                        TempReached = true;
                    }
                    if (TempReached)
                    {

                        ++timerRetractCount;
                        if (retractT3)
                        {
                            lblRetractLoadFilT3.Text = "Heizung abgeschlossen. Jetzt zurückziehen";
                            if (timerRetractCount == 14)
                            {
                                lblRetractLoadFilT3.Text = "Zurückziehen abgeschlossen ist, Düse T3";

                                btnLoadT0.Enabled = !loadT0;
                                btnRetractT0.Enabled = !retractT0;
                                btnLoadT1.Enabled = !loadT1;
                                btnRetractT1.Enabled = !retractT1;
                                btnLoadT2.Enabled = !loadT2;
                                btnRetractT2.Enabled = !retractT2;
                                btnRetractT3.Enabled = !retractT3;
                                btnLoadT3.Enabled = !loadT3;
                                TempReached = false;
                                host.Connection.injectManualCommand("M104 S0 T3");
                                host.Connection.injectManualCommand("T0");
                                timerRetractLoad.Stop();
                            }
                        }
                        if (loadT3)
                        {
                            lblRetractLoadFilT3.Text = "Aufheizen abgeschlossen. Lädt";
                            if (timerRetractCount == 30)
                            {
                                lblRetractLoadFilT3.Text = "Laden abgeschlossen, Düse T3";

                                btnLoadT0.Enabled = !loadT0;
                                btnRetractT0.Enabled = !retractT0;
                                btnLoadT1.Enabled = !loadT1;
                                btnRetractT1.Enabled = !retractT1;
                                btnLoadT2.Enabled = !loadT2;
                                btnRetractT2.Enabled = !retractT2;
                                btnRetractT3.Enabled = !retractT3;
                                btnLoadT3.Enabled = !loadT3;
                                TempReached = false;
                                host.Connection.injectManualCommand("M104 S0 T3");
                                timerRetractLoad.Stop();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error in Retracting or Loading" + ex);
            }
        }

        private void btnRetractT0_Click_1(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                timerRetractCount = 0;
                tempValue = txtBoxTemp.Text;
                btnLoadT0.Enabled = false;
                btnLoadT1.Enabled = false;
                btnLoadT2.Enabled = false;
                btnLoadT3.Enabled = false;
                btnRetractT0.Enabled = false;
                btnRetractT1.Enabled = false;
                btnRetractT2.Enabled = false;
                btnRetractT3.Enabled = false;
                T0LoadRetractClicked = true;
                retractT0 = true;
                loadT0 = false;
                if (ChckboxDruckerInitialised.Checked == true)
                {
                    host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                }
                else
                {
                    host.Connection.injectManualCommand("G28");
                    host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                }
                //host.Connection.injectManualCommand("G993 T0 S" + tempValue);
                host.Connection.injectManualCommand("M109 S" + tempValue + " T0");

                lblRetractLoadFilT0.Visible = true;
                lblRetractLoadFilT0.Text = "Düse wird aufgeheizt";
                text_T0_ziel.Text = tempValue;
                changeTempButtonsToOn(btnT0_OnOff);
                btnT0.Enabled = false;
                btnT1.Enabled = true;
                btnT2.Enabled = true;
                btnT3.Enabled = true;
                host.Connection.injectManualCommand("G222");
                T0_On = true;

                host.Connection.injectManualCommand("T0");
                host.Connection.injectManualCommand("G1 X645 Y10 F8000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E20.0 F120");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-70.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F1800");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F1800");
                host.Connection.injectManualCommand("G92 E0");

                timerRetractLoad.Start();

            }
        }

        private void btnRetractT1_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                timerRetractCount = 0;
                tempValue = txtBoxTemp.Text;
                btnLoadT0.Enabled = false;
                btnLoadT1.Enabled = false;
                btnLoadT2.Enabled = false;
                btnLoadT3.Enabled = false;
                btnRetractT0.Enabled = false;
                btnRetractT1.Enabled = false;
                btnRetractT2.Enabled = false;
                btnRetractT3.Enabled = false;
                T1LoadRetractClicked = true;
                retractT1 = true;
                loadT1 = false;
                if (ChckboxDruckerInitialised.Checked == true)
                {
                    host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                }
                else
                {
                    host.Connection.injectManualCommand("G28");
                    host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                }
                //host.Connection.injectManualCommand("G993 T1 S" + tempValue);
                host.Connection.injectManualCommand("M109 S" + tempValue + " T1");

                lblRetractLoadFilT1.Visible = true;
                lblRetractLoadFilT1.Text = "Düse wird aufgeheizt";
                text_T1_ziel.Text = tempValue;
                host.Connection.injectManualCommand("G222");
                T1_On = true;
                changeTempButtonsToOn(btnT1_OnOff);
                btnT0.Enabled = true;
                btnT1.Enabled = false;
                btnT2.Enabled = true;
                btnT3.Enabled = true;
                host.Connection.injectManualCommand("T1");
                host.Connection.injectManualCommand("G0 X665 Y10 F8000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E20.0 F120");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-70.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F1800");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F1800");
                host.Connection.injectManualCommand("G92 E0");

                timerRetractLoad.Start();
            }
        }

        private void btnRetractT2_Click_1(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                timerRetractCount = 0;
                tempValue = txtBoxTemp.Text;
                btnLoadT0.Enabled = false;
                btnLoadT1.Enabled = false;
                btnLoadT2.Enabled = false;
                btnLoadT3.Enabled = false;
                btnRetractT0.Enabled = false;
                btnRetractT1.Enabled = false;
                btnRetractT2.Enabled = false;
                btnRetractT3.Enabled = false;
                T2LoadRetractClicked = true;
                retractT2 = true;
                loadT2 = false;
                if (ChckboxDruckerInitialised.Checked == true)
                {
                    host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                }
                else
                {
                    host.Connection.injectManualCommand("G28");
                    host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                }
                //host.Connection.injectManualCommand("G993 T2 S" + tempValue);
                host.Connection.injectManualCommand("M109 S" + tempValue + " T2");
                lblRetractLoadFilT2.Visible = true;
                lblRetractLoadFilT2.Text = "Düse wird aufgeheizt";
                text_T2_ziel.Text = tempValue;
                host.Connection.injectManualCommand("G222");
                T2_On = true;
                changeTempButtonsToOn(btnT2_OnOff);
                btnT0.Enabled = true;
                btnT1.Enabled = true;
                btnT2.Enabled = false;
                btnT3.Enabled = true;
                host.Connection.injectManualCommand("T2");
                host.Connection.injectManualCommand("G0 X665 Y20 F8000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E20.0 F120");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-70.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F1800");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F1800");
                host.Connection.injectManualCommand("G92 E0");

                timerRetractLoad.Start();
            }
        }

        private void btnRetractT3_Click(object sender, EventArgs e)
        {
            if (txtBoxTemp.Text != string.Empty)
            {
                timerRetractCount = 0;
                tempValue = txtBoxTemp.Text;
                btnLoadT0.Enabled = false;
                btnLoadT1.Enabled = false;
                btnLoadT2.Enabled = false;
                btnLoadT3.Enabled = false;
                btnRetractT0.Enabled = false;
                btnRetractT1.Enabled = false;
                btnRetractT2.Enabled = false;
                btnRetractT3.Enabled = false;
                T3LoadRetractClicked = true;
                retractT3 = true;
                loadT3 = false;
                if (ChckboxDruckerInitialised.Checked == true)
                {
                    host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                }
                else
                {
                    host.Connection.injectManualCommand("G28");
                    host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                }
                //host.Connection.injectManualCommand("G993 T3 S" + tempValue);
                host.Connection.injectManualCommand("M109 S" + tempValue + " T3");
                lblRetractLoadFilT3.Visible = true;
                lblRetractLoadFilT3.Text = "Düse wird aufgeheizt";
                text_T3_ziel.Text = tempValue;
                host.Connection.injectManualCommand("G222");
                T3_On = true;
                changeTempButtonsToOn(btnT3_OnOff);
                btnT0.Enabled = true;
                btnT1.Enabled = true;
                btnT2.Enabled = true;
                btnT3.Enabled = false;
                host.Connection.injectManualCommand("T3");
                host.Connection.injectManualCommand("G0 X645 Y20 F8000");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E20.0 F120");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-70.0 F600");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F1800");
                host.Connection.injectManualCommand("G92 E0");
                host.Connection.injectManualCommand("G1 E-800.0 F1800");
                host.Connection.injectManualCommand("G92 E0");

                timerRetractLoad.Start();
            }
        }

        private void btnLoadT0_Click(object sender, EventArgs e)
        {

            DialogResult ms = MessageBox.Show("Filament Laden: Stellen Sie sicher, dass das Filament korrekt eingeführt ist " +
                "und noch nicht bis an den Extruder gefördert wurde." + Environment.NewLine +
                "Durch Bestätigung mit „OK“ wird die selektierte Düse erhitzt und das Filament an den Druckkopf gefördert",
                "Filament Laden!!", MessageBoxButtons.OKCancel);
            if (ms == DialogResult.OK)
            {
                if (txtBoxTemp.Text != string.Empty)
                {
                    timerRetractCount = 0;
                    tempValue = txtBoxTemp.Text;
                    btnLoadT0.Enabled = false;
                    btnLoadT1.Enabled = false;
                    btnLoadT2.Enabled = false;
                    btnLoadT3.Enabled = false;
                    btnRetractT0.Enabled = false;
                    btnRetractT1.Enabled = false;
                    btnRetractT2.Enabled = false;
                    btnRetractT3.Enabled = false;
                    T0LoadRetractClicked = true;
                    retractT0 = false;
                    loadT0 = true;
                    if (ChckboxDruckerInitialised.Checked == true)
                    {
                        host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                    }
                    else
                    {
                        host.Connection.injectManualCommand("G28");
                        host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                    }
                    //host.Connection.injectManualCommand("G992 T0 S" + tempValue);
                    host.Connection.injectManualCommand("M109 S" + tempValue + " T0");
                    lblRetractLoadFilT0.Visible = true;
                    lblRetractLoadFilT0.Text = "Düse wird aufgeheizt";
                    text_T0_ziel.Text = tempValue;
                    changeTempButtonsToOn(btnT0_OnOff);
                    btnT0.Enabled = false;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    host.Connection.injectManualCommand("G222");
                    T0_On = true;

                    host.Connection.injectManualCommand("T0");
                    host.Connection.injectManualCommand("G1 X645 Y10 F8000");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E700.0 F1800");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E700.0 F1800");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E200.0 F120");
                    host.Connection.injectManualCommand("G92 E0");

                    timerRetractLoad.Start();
                }
            }
        }

        private void btnLoadT1_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Filament Laden: Stellen Sie sicher, dass das Filament korrekt eingeführt ist " +
                "und noch nicht bis an den Extruder gefördert wurde." + Environment.NewLine +
                "Durch Bestätigung mit „OK“ wird die selektierte Düse erhitzt und das Filament an den Druckkopf gefördert",
                "Filament Laden!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ms == DialogResult.OK)
            {
                if (txtBoxTemp.Text != string.Empty)
                {
                    timerRetractCount = 0;
                    tempValue = txtBoxTemp.Text;
                    btnLoadT0.Enabled = false;
                    btnLoadT1.Enabled = false;
                    btnLoadT2.Enabled = false;
                    btnLoadT3.Enabled = false;
                    btnRetractT0.Enabled = false;
                    btnRetractT1.Enabled = false;
                    btnRetractT2.Enabled = false;
                    btnRetractT3.Enabled = false;
                    T1LoadRetractClicked = true;
                    retractT1 = false;
                    loadT1 = true;
                    if (ChckboxDruckerInitialised.Checked == true)
                    {
                        host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                    }
                    else
                    {
                        host.Connection.injectManualCommand("G28");
                        host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                    }
                    //host.Connection.injectManualCommand("G992 T1 S" + tempValue);
                    host.Connection.injectManualCommand("M109 S" + tempValue + " T1");
                    lblRetractLoadFilT1.Visible = true;
                    lblRetractLoadFilT1.Text = "Düse wird aufgeheizt";
                    text_T1_ziel.Text = tempValue;
                    host.Connection.injectManualCommand("G222");
                    T1_On = true;
                    changeTempButtonsToOn(btnT1_OnOff);
                    btnT0.Enabled = true;
                    btnT1.Enabled = false;
                    btnT2.Enabled = true;
                    btnT3.Enabled = true;
                    host.Connection.injectManualCommand("T1");
                    host.Connection.injectManualCommand("G0 X665 Y10 F8000");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E700.0 F1800");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E700.0 F1800");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E200.0 F120");
                    host.Connection.injectManualCommand("G92 E0");

                    timerRetractLoad.Start();
                }
            }
        }

        private void btnLoadT2_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Filament Laden: Stellen Sie sicher, dass das Filament korrekt eingeführt ist " +
                "und noch nicht bis an den Extruder gefördert wurde." + Environment.NewLine +
                "Durch Bestätigung mit „OK“ wird die selektierte Düse erhitzt und das Filament an den Druckkopf gefördert",
                "Filament Laden!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ms == DialogResult.OK)
            {
                if (txtBoxTemp.Text != string.Empty)
                {
                    timerRetractCount = 0;
                    tempValue = txtBoxTemp.Text;
                    btnLoadT0.Enabled = false;
                    btnLoadT1.Enabled = false;
                    btnLoadT2.Enabled = false;
                    btnLoadT3.Enabled = false;
                    btnRetractT0.Enabled = false;
                    btnRetractT1.Enabled = false;
                    btnRetractT2.Enabled = false;
                    btnRetractT3.Enabled = false;
                    T2LoadRetractClicked = true;
                    retractT2 = false;
                    loadT2 = true;
                    if (ChckboxDruckerInitialised.Checked == true)
                    {
                        host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                    }
                    else
                    {
                        host.Connection.injectManualCommand("G28");
                        host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                    }
                    //host.Connection.injectManualCommand("G992 T2 S" + tempValue);
                    host.Connection.injectManualCommand("M109 S" + tempValue + " T2");
                    lblRetractLoadFilT2.Visible = true;
                    lblRetractLoadFilT2.Text = "Düse wird aufgeheizt";
                    text_T2_ziel.Text = tempValue;
                    host.Connection.injectManualCommand("G222");
                    T2_On = true;
                    changeTempButtonsToOn(btnT2_OnOff);
                    btnT0.Enabled = true;
                    btnT1.Enabled = true;
                    btnT2.Enabled = false;
                    btnT3.Enabled = true;
                    host.Connection.injectManualCommand("T2");
                    host.Connection.injectManualCommand("G0 X665 Y20 F8000");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E700.0 F1800");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E700.0 F1800");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E200.0 F120");
                    host.Connection.injectManualCommand("G92 E0");

                    timerRetractLoad.Start();
                }
            }
        }

        private void btnLoadT3_Click(object sender, EventArgs e)
        {
            DialogResult ms = MessageBox.Show("Filament Laden: Stellen Sie sicher, dass das Filament korrekt eingeführt ist " +
                "und noch nicht bis an den Extruder gefördert wurde." + Environment.NewLine +
                "Durch Bestätigung mit „OK“ wird die selektierte Düse erhitzt und das Filament an den Druckkopf gefördert",
                "Filament Laden!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (ms == DialogResult.OK)
            {
                if (txtBoxTemp.Text != string.Empty)
                {
                    timerRetractCount = 0;
                    tempValue = txtBoxTemp.Text;
                    btnLoadT0.Enabled = false;
                    btnLoadT1.Enabled = false;
                    btnLoadT2.Enabled = false;
                    btnLoadT3.Enabled = false;
                    btnRetractT0.Enabled = false;
                    btnRetractT1.Enabled = false;
                    btnRetractT2.Enabled = false;
                    btnRetractT3.Enabled = false;
                    T3LoadRetractClicked = true;
                    retractT3 = false;
                    loadT3 = true;
                    if (ChckboxDruckerInitialised.Checked == true)
                    {
                        host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                    }
                    else
                    {
                        host.Connection.injectManualCommand("G28");
                        host.Connection.injectManualCommand("G1 X645 Y10 Z3 F8000");
                    }
                    //host.Connection.injectManualCommand("G992 T3 S" + tempValue);
                    host.Connection.injectManualCommand("M109 S" + tempValue + " T3");
                    lblRetractLoadFilT3.Visible = true;
                    lblRetractLoadFilT3.Text = "Düse wird aufgeheizt";
                    text_T3_ziel.Text = tempValue;
                    host.Connection.injectManualCommand("G222");
                    T3_On = true;
                    changeTempButtonsToOn(btnT3_OnOff);
                    btnT0.Enabled = true;
                    btnT1.Enabled = true;
                    btnT2.Enabled = true;
                    btnT3.Enabled = false;
                    host.Connection.injectManualCommand("T3");
                    host.Connection.injectManualCommand("G0 X645 Y20 F8000");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E700.0 F1800");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E700.0 F1800");
                    host.Connection.injectManualCommand("G92 E0");
                    host.Connection.injectManualCommand("G1 E200.0 F120");
                    host.Connection.injectManualCommand("G92 E0");

                    timerRetractLoad.Start();
                }
            }
        }

        private void btnRetractT0_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnRetractT0.Enabled)
                btnRetractT0.Image = Properties.Resources.Zuruck_g;
            else
                btnRetractT0.Image = Properties.Resources.Zuruck;
        }

        private void btnRetractT1_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnRetractT1.Enabled)
                btnRetractT1.Image = Properties.Resources.Zuruck_g;
            else
                btnRetractT1.Image = Properties.Resources.Zuruck;
        }

        private void btnRetractT2_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnRetractT2.Enabled)
                btnRetractT2.Image = Properties.Resources.Zuruck_g;
            else
                btnRetractT2.Image = Properties.Resources.Zuruck;
        }

        private void btnRetractT3_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnRetractT3.Enabled)
                btnRetractT3.Image = Properties.Resources.Zuruck_g;
            else
                btnRetractT3.Image = Properties.Resources.Zuruck;
        }

        private void btnLoadT0_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnLoadT0.Enabled)
                btnLoadT0.Image = Properties.Resources.Laden_g;
            else
                btnLoadT0.Image = Properties.Resources.Laden;
        }

        private void btnLoadT1_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnLoadT1.Enabled)
                btnLoadT1.Image = Properties.Resources.Laden_g;
            else
                btnLoadT1.Image = Properties.Resources.Laden;
        }

        private void btnLoadT2_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnLoadT2.Enabled)
                btnLoadT2.Image = Properties.Resources.Laden_g;
            else
                btnLoadT2.Image = Properties.Resources.Laden;
        }

        private void btnLoadT3_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnLoadT3.Enabled)
                btnLoadT3.Image = Properties.Resources.Laden_g;
            else
                btnLoadT3.Image = Properties.Resources.Laden;
        }


        public static bool IsValidNozzleTemp(string str)
        {
            return int.TryParse(str, out int i) && i >= 0 && i <= 270;
        }

        private void text_T0_ziel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        public static bool IsValidBedTemp(string str)
        {
            return int.TryParse(str, out int i) && i >= 0 && i <= 100;
        }

        private void text_Bed_ziel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void btnT0_OnOff_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void btnT0_OnOff_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void btnFilAktualise_EnabledChanged_1(object sender, EventArgs e)
        {
            if (!btnFilAktualise.Enabled)
                btnFilAktualise.Image = Properties.Resources.Aktualizieren_g;
            else
                btnFilAktualise.Image = Properties.Resources.Aktualizieren;
        }

        private void btnPplus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnPplus, e.X, e.Y))
            {
                parkPositionMultiplyer = parkPositionMultiplyer + 1;
                lblParkPositionVal.Text.Replace(",", ".");
                newOffset = Convert.ToDouble(lblParkPositionVal.Text, CultureInfo.InvariantCulture) + 0.1;
                if (newOffset <= 6)
                {
                    lblParkPositionVal.Text = newOffset.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    MessageBox.Show("Der Parkposition Move kann nicht größer als 6 mm sein.", "WARNUNG!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnPminus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnPminus, e.X, e.Y))
            {
                parkPositionMultiplyer = parkPositionMultiplyer - 1;
                lblParkPositionVal.Text.Replace(",", ".");
                newOffset = Convert.ToDouble(lblParkPositionVal.Text, CultureInfo.InvariantCulture) - 0.1;
                if (newOffset >= 2)
                {
                    lblParkPositionVal.Text = newOffset.ToString(CultureInfo.InvariantCulture);
                }
                else
                {
                    MessageBox.Show("Der Parkposition Move kann nicht kleiner als 2 mm sein.", "WARNUNG!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnParkPositionSend_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnParkPositionSend, e.X, e.Y))
            {
                parkPositionOffset = parkPositionMultiplyer * 0.1;


                host.Connection.injectManualCommand("M701 " + "P" + parkPositionOffset.ToString(CultureInfo.InvariantCulture));
                host.Connection.injectManualCommand("G222");
                parkPositionMultiplyer = 0;
            }
        }

        private void btnParkPositionSend_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnParkPositionSend.Enabled)
                btnParkPositionSend.Image = Properties.Resources.Schicken_g;
            else
                btnParkPositionSend.Image = Properties.Resources.Schicken;
        }

        private void btnPplus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnPplus.Enabled)
                btnPplus.Image = Properties.Resources.plus_g;
            else
                btnPplus.Image = Properties.Resources.plus;
        }

        private void btnPminus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnPminus.Enabled)
                btnPminus.Image = Properties.Resources.minus_g;
            else
                btnPminus.Image = Properties.Resources.minus;
        }

        private void trackBar_NozzleTemp_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnBedTempPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnBedTempPlus, e.X, e.Y))
            {

                if (text_Bed_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil_bed = text_Bed_ziel.Text.Replace(",", ".").Trim();
                }
                else
                {
                    temp_Zeil_bed = text_Bed_ziel.Text.Trim();
                }
                if (temp_Zeil_bed.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil_bed = temp_Zeil_bed.Replace(".0", " ").Trim();
                }
                temp_Zeil_bed = (double.Parse(temp_Zeil_bed) + 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidBedTemp(temp_Zeil_bed))
                {
                    text_Bed_ziel.Text = temp_Zeil_bed;
                    if (Bed_On)
                    {
                        host.Connection.injectManualCommand("M140 S" + temp_Zeil_bed);
                    }
                }
                else
                {
                    MessageBox.Show("Temperatur muss zwischen 0 und 100 sein!!");
                    text_Bed_ziel.Text = "60";
                }
            }

        }

        private void btnBedTempMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnBedTempMinus, e.X, e.Y))
            {
                if (text_Bed_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil_bed = text_Bed_ziel.Text.Replace(",", ".").Trim();
                }
                else
                {
                    temp_Zeil_bed = text_Bed_ziel.Text.Trim();
                }
                if (temp_Zeil_bed.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil_bed = temp_Zeil_bed.Replace(".0", " ").Trim();
                }
                temp_Zeil_bed = (double.Parse(temp_Zeil_bed) - 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidBedTemp(temp_Zeil_bed))
                {

                    text_Bed_ziel.Text = temp_Zeil_bed;

                    if (Bed_On)
                    {
                        host.Connection.injectManualCommand("M140 S" + temp_Zeil_bed);
                    }
                }
                else
                {
                    MessageBox.Show("Temperatur muss zwischen 0 und 100 sein!!");
                    text_Bed_ziel.Text = "60";
                }
            }
        }

        private void btnT3TempPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT3TempPlus, e.X, e.Y))
            {
                if (text_T3_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = text_T3_ziel.Text.Replace(",", ".").Trim();
                }
                else
                {
                    temp_Zeil = text_T3_ziel.Text.Trim();
                }
                if (temp_Zeil.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = temp_Zeil.Replace(".0", " ").Trim();
                }
                temp_Zeil = (double.Parse(temp_Zeil) + 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidNozzleTemp(temp_Zeil))
                {

                    text_T3_ziel.Text = temp_Zeil;

                    if (T3_On)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T3");
                    }
                }
                else
                {
                    MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                    text_T3_ziel.Text = "205";
                }
            }
        }

        private void btnT3TempMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT3TempMinus, e.X, e.Y))
            {
                if (text_T3_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = text_T3_ziel.Text.Replace(",", ".").Trim();
                }
                else
                {
                    temp_Zeil = text_T3_ziel.Text.Trim();
                }
                if (temp_Zeil.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = temp_Zeil.Replace(".0", " ").Trim();
                }
                temp_Zeil = (double.Parse(temp_Zeil) - 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidNozzleTemp(temp_Zeil))
                {

                    text_T3_ziel.Text = temp_Zeil;



                    if (T3_On)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T3");
                    }
                }
                else
                {
                    MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                    text_T3_ziel.Text = "205";
                }
            }
        }

        private void btnT2TempPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT2TempPlus, e.X, e.Y))
            {
                if (text_T2_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = text_T2_ziel.Text.Replace(",", ".").Trim();
                }
                else
                {
                    temp_Zeil = text_T2_ziel.Text.Trim();
                }
                if (temp_Zeil.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = temp_Zeil.Replace(".0", " ").Trim();
                }
                temp_Zeil = (double.Parse(temp_Zeil) + 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidNozzleTemp(temp_Zeil))
                {

                    text_T2_ziel.Text = temp_Zeil;


                    if (T2_On)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T2");
                    }
                }
                else
                {
                    MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                    text_T2_ziel.Text = "205";
                }
            }
        }

        private void btnT1TempPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT1TempPlus, e.X, e.Y))
            {
                if (text_T1_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = text_T1_ziel.Text.Replace(",", ".").Trim();
                }
                else
                {
                    temp_Zeil = text_T1_ziel.Text.Trim();
                }
                if (temp_Zeil.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = temp_Zeil.Replace(".0", " ").Trim();
                }
                temp_Zeil = (double.Parse(temp_Zeil) + 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidNozzleTemp(temp_Zeil))
                {

                    text_T1_ziel.Text = temp_Zeil;


                    if (T1_On)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T1");
                    }
                }
            }
            else
            {
                MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                text_T1_ziel.Text = "205";
            }
        }

        private void btnT0TempPlus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT0TempPlus, e.X, e.Y))
            {
                if (text_T0_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = text_T0_ziel.Text.Replace(",", ".").Trim();
                }
                else
                {
                    temp_Zeil = text_T0_ziel.Text.Trim();
                }

                if (temp_Zeil.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = temp_Zeil.Replace(".0", " ").Trim();
                }
                temp_Zeil = (double.Parse(temp_Zeil) + 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidNozzleTemp(temp_Zeil))
                {

                    text_T0_ziel.Text = temp_Zeil;

                    if (T0_On)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T0");
                    }
                }
                else
                {
                    MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                    text_T0_ziel.Text = "205";
                }
            }
        }

        private void btnT0TempMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT0TempMinus, e.X, e.Y))
            {
                if (text_T0_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = text_T0_ziel.Text.Replace(",", ".").Trim();
                }
                else
                {
                    temp_Zeil = text_T0_ziel.Text.Trim();
                }
                if (temp_Zeil.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = temp_Zeil.Replace(".0", " ").Trim();
                }
                temp_Zeil = (double.Parse(temp_Zeil) - 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidNozzleTemp(temp_Zeil))
                {

                    text_T0_ziel.Text = temp_Zeil;


                    if (T0_On)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T0");
                    }
                }
                else
                {
                    MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                    text_T0_ziel.Text = "205";
                }
            }
        }

        private void btnT1TempMinus_MouseClick(object sender, MouseEventArgs e)
        {
            if (HitTest(btnT1TempMinus, e.X, e.Y))
            {
                if (text_T1_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = text_T1_ziel.Text.Replace(",", ".").Trim();
                }
                else
                {
                    temp_Zeil = text_T1_ziel.Text.Trim();
                }
                if (temp_Zeil.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = temp_Zeil.Replace(".0", " ").Trim();
                }
                temp_Zeil = (double.Parse(temp_Zeil) - 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidNozzleTemp(temp_Zeil))
                {

                    text_T1_ziel.Text = temp_Zeil;


                    if (T1_On)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T1");
                    }
                }
                else
                {
                    MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                    text_T1_ziel.Text = "205";
                }
            }
        }

        private void btnT2TempMinus_MouseClick(object sender, MouseEventArgs e)
        {

            if (HitTest(btnT2TempMinus, e.X, e.Y))
            {
                if (text_T2_ziel.Text.IndexOf(",", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = text_T2_ziel.Text.Replace(",", ".").Trim();

                }
                else
                {
                    temp_Zeil = text_T2_ziel.Text.Trim();
                }
                if (temp_Zeil.IndexOf(".0", StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    temp_Zeil = temp_Zeil.Replace(".0", " ").Trim();
                }
                temp_Zeil = (double.Parse(temp_Zeil) - 5).ToString(CultureInfo.InvariantCulture);
                if (IsValidNozzleTemp(temp_Zeil))
                {

                    text_T2_ziel.Text = temp_Zeil;


                    if (T2_On)
                    {
                        host.Connection.injectManualCommand("M104 S" + temp_Zeil + " T2");
                    }
                }
                else
                {
                    MessageBox.Show("Temperatur muss zwischen 0 und 270 sein!!");
                    text_T2_ziel.Text = "205";
                }
            }
        }

        private void btnFeedratePlus_EnabledChanged(object sender, EventArgs e)
        {

            if (!btnFeedratePlus.Enabled)
                btnFeedratePlus.Image = Properties.Resources.PlusV_g;
            else
                btnFeedratePlus.Image = Properties.Resources.PlusV1;
        }

        private void btnFeedrateMinus_EnabledChanged(object sender, EventArgs e)
        {

            if (!btnFeedrateMinus.Enabled)
                btnFeedrateMinus.Image = Properties.Resources.MinusV_g;
            else
                btnFeedrateMinus.Image = Properties.Resources.MinusV1;
        }

        private void btnFlowratePlus_EnabledChanged(object sender, EventArgs e)
        {

            if (!btnFlowratePlus.Enabled)
                btnFlowratePlus.Image = Properties.Resources.PlusV_g;
            else
                btnFlowratePlus.Image = Properties.Resources.PlusV1;
        }

        private void btnBedTempPlus_EnabledChanged(object sender, EventArgs e)
        {

            if (!btnBedTempPlus.Enabled)
                btnBedTempPlus.Image = Properties.Resources.PlusV_g;
            else
                btnBedTempPlus.Image = Properties.Resources.PlusV1;
        }

        private void btnT3TempPlus_EnabledChanged(object sender, EventArgs e)
        {

            if (!btnT3TempPlus.Enabled)
                btnT3TempPlus.Image = Properties.Resources.PlusV_g;
            else
                btnT3TempPlus.Image = Properties.Resources.PlusV1;
        }

        private void btnT2TempPlus_EnabledChanged(object sender, EventArgs e)
        {

            if (!btnT2TempPlus.Enabled)
                btnT2TempPlus.Image = Properties.Resources.PlusV_g;
            else
                btnT2TempPlus.Image = Properties.Resources.PlusV1;
        }

        private void btnT1TempPlus_EnabledChanged(object sender, EventArgs e)
        {

            if (!btnT1TempPlus.Enabled)
                btnT1TempPlus.Image = Properties.Resources.PlusV_g;
            else
                btnT1TempPlus.Image = Properties.Resources.PlusV1;
        }

        private void btnT0TempPlus_EnabledChanged(object sender, EventArgs e)
        {

            if (!btnT0TempPlus.Enabled)
                btnT0TempPlus.Image = Properties.Resources.PlusV_g;
            else
                btnT0TempPlus.Image = Properties.Resources.PlusV1;
        }

        private void btnT0TempMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT0TempMinus.Enabled)
                btnT0TempMinus.Image = Properties.Resources.MinusV_g;
            else
                btnT0TempMinus.Image = Properties.Resources.MinusV1;
        }

        private void btnT1TempMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT1TempMinus.Enabled)
                btnT1TempMinus.Image = Properties.Resources.MinusV_g;
            else
                btnT1TempMinus.Image = Properties.Resources.MinusV1;
        }

        private void btnT2TempMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT2TempMinus.Enabled)
                btnT2TempMinus.Image = Properties.Resources.MinusV_g;
            else
                btnT2TempMinus.Image = Properties.Resources.MinusV1;
        }

        private void btnT3TempMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnT3TempMinus.Enabled)
                btnT3TempMinus.Image = Properties.Resources.MinusV_g;
            else
                btnT3TempMinus.Image = Properties.Resources.MinusV1;

        }

        private void btnBedTempMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnBedTempMinus.Enabled)
                btnBedTempMinus.Image = Properties.Resources.MinusV_g;
            else
                btnBedTempMinus.Image = Properties.Resources.MinusV1;
        }

        private void btnFlowrateMinus_EnabledChanged(object sender, EventArgs e)
        {
            if (!btnFlowrateMinus.Enabled)
                btnFlowrateMinus.Image = Properties.Resources.MinusV_g;
            else
                btnFlowrateMinus.Image = Properties.Resources.MinusV1;
        }

        private void UpdateNozzleSizeFile()
        {
            StreamWriter writer = new StreamWriter(filePath);

            if (nozzleSizeT0 != string.Empty)
            {
                writer.WriteLine("T0:" + nozzleSizeT0);
            }
            if (nozzleSizeT1 != string.Empty)
            {
                writer.WriteLine("T1:" + nozzleSizeT1);
            }
            if (nozzleSizeT2 != string.Empty)
            {
                writer.WriteLine("T2:" + nozzleSizeT2);
            }
            if (nozzleSizeT3 != string.Empty)
            {
                writer.WriteLine("T3:" + nozzleSizeT3);
            }
            writer.WriteLine();
            writer.Close();
        }
        private void UpdateNozzleSize(string path)
        {
            if (!File.Exists(path))
            {

                File.Create(path);

            }
            else
            {

                string[] Lines = File.ReadAllLines(path);
                int metaindex;
                foreach (string line in Lines)
                {
                    if (line.IndexOf("T0", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        metaindex = line.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                        nozzleSizeT0 = line.Substring(metaindex + 1);
                        switch (nozzleSizeT0)
                        {
                            case "0.35 mm":
                                ComboNozzleSizeT0.SelectedIndex = 0;
                                break;
                            case "0.5 mm":
                                ComboNozzleSizeT0.SelectedIndex = 1;
                                break;
                            case "0.8 mm":
                                ComboNozzleSizeT0.SelectedIndex = 2;
                                break;
                            default:
                                ComboNozzleSizeT0.SelectedIndex = -1;
                                break;
                        }
                    }
                    if (line.IndexOf("T1", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        metaindex = line.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);

                        nozzleSizeT1 = line.Substring(metaindex + 1);
                        switch (nozzleSizeT1)
                        {
                            case "0.35 mm":
                                ComboNozzleSizeT1.SelectedIndex = 0;
                                break;
                            case "0.5 mm":
                                ComboNozzleSizeT1.SelectedIndex = 1;
                                break;
                            case "0.8 mm":
                                ComboNozzleSizeT1.SelectedIndex = 2;
                                break;
                            default:
                                ComboNozzleSizeT1.SelectedIndex = -1;
                                break;
                        }
                    }
                    if (line.IndexOf("T2", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        metaindex = line.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                        nozzleSizeT2 = line.Substring(metaindex + 1);
                        switch (nozzleSizeT2)
                        {
                            case "0.35 mm":
                                ComboNozzleSizeT2.SelectedIndex = 0;
                                break;
                            case "0.5 mm":
                                ComboNozzleSizeT2.SelectedIndex = 1;
                                break;
                            case "0.8 mm":
                                ComboNozzleSizeT2.SelectedIndex = 2;
                                break;
                            default:
                                ComboNozzleSizeT2.SelectedIndex = -1;
                                break;
                        }
                    }
                    if (line.IndexOf("T3", StringComparison.CurrentCultureIgnoreCase) != -1)
                    {
                        metaindex = line.IndexOf(":", StringComparison.CurrentCultureIgnoreCase);
                        nozzleSizeT3 = line.Substring(metaindex + 1);
                        switch (nozzleSizeT3)
                        {
                            case "0.35 mm":
                                ComboNozzleSizeT3.SelectedIndex = 0;
                                break;
                            case "0.5 mm":
                                ComboNozzleSizeT3.SelectedIndex = 1;
                                break;
                            case "0.8 mm":
                                ComboNozzleSizeT3.SelectedIndex = 2;
                                break;
                            default:
                                ComboNozzleSizeT3.SelectedIndex = -1;
                                break;
                        }
                    }
                }
            }
        }

        private void textT1NozzleSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            btnActivate.Text = "Activated";
            btnActivate.Enabled = false;
            btnDeactivate.Enabled = true;
            btnDeactivate.Text = "Deactivate";
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            btnDeactivate.Text = "Deactivated";
            btnDeactivate.Enabled = false;
            btnActivate.Enabled = true;
            btnActivate.Text = "Activate";
        }
        private bool columnT0 = true;
        private bool columnT1 = true;
        private bool columnT2 = true;
        private bool columnT3 = true;
        private bool RowT0= true;
        private bool RowT1 = true;
        private bool RowT2 = true;
        private bool RowT3 = true;
        private void BackupT0Column(bool val)
        {
            if (val == false)
            {
                columnT0 = false;
            }
            else
            {
                columnT0 = true;
            }
            backupT0furT1.Enabled = val && T0T1equal && RowT1&& !T2T0 && !T3T0;
            backupT0furT2.Enabled = val && T0T2equal && RowT2 && !T1T0 && !T3T0;
            backupT0furT3.Enabled = val && T0T3equal && RowT3 && !T1T0 && !T2T0;


        }
        private void BackupT0Row(bool val)
        {
            if (val == false)
            {
                RowT0 = false;
            }
            else
            {
                RowT0 = true;
            }
            backupT1furT0.Enabled = val && T0T1equal && columnT1 && !T2T1 && !T3T1;
            backupT2furT0.Enabled = val && T0T2equal && columnT2 && !T1T2 && !T3T2;
            backupT3furT0.Enabled = val && T0T3equal && columnT3 && !T1T3 && !T2T3; 
        }
        private void BackupT1Column(bool val)
        {
            if (val == false)
            {
                columnT1 = false;
            }
            else
            {
                columnT1 = true;
            }
          backupT1furT0.Enabled = val && T0T1equal && RowT0 && !T2T1 && !T3T1; 
            backupT1furT2.Enabled = val && T1T2equal && RowT2 && !T0T1 && !T3T1; 
            backupT1furT3.Enabled = val && T1T3equal && RowT3 && !T0T1 && !T2T1; 
        }
        private void BackupT1Row(bool val)
        {
            if (val == false)
            {
                RowT1 = false;
            }
            else
            {
                RowT1 = true;
            }
            backupT0furT1.Enabled = val && T0T1equal && columnT0 && !T2T0 && !T3T0;
            backupT2furT1.Enabled = val && T1T2equal  && columnT2 && !T0T2 && !T3T2;
            backupT3furT1.Enabled = val && T1T3equal  && columnT3 && !T0T3 && !T2T3;

        }
        private void BackupT2Column(bool val)
        {
            if (val == false)
            {
                columnT2 = false;
            }
            else
            {
                columnT2 = true;
            }
            backupT2furT0.Enabled = val && T0T2equal && RowT0 && !T1T2 && !T3T2;
            backupT2furT1.Enabled = val && T1T2equal && RowT1 && !T0T2 && !T3T2;
            backupT2furT3.Enabled = val && T2T3equal && RowT3 && !T0T2 && !T1T2;
        }
        private void BackupT2Row(bool val)
        {
            if (val == false)
            {
                RowT2 = false;
            }
            else
            {
                RowT2 = true;
            }
            backupT0furT2.Enabled = val && T0T2equal && columnT0 && !T1T0 && !T3T0;
            backupT1furT2.Enabled = val && T1T2equal  && columnT1 && !T0T1 && !T3T1;
            backupT3furT2.Enabled = val && T2T3equal  && columnT3 && !T0T3 && !T1T3;
        }
        private void BackupT3Column(bool val)
        {
            if (val == false)
            {
                columnT3 = false;
            }
            else
            {
                columnT3 = true;
            }
            backupT3furT0.Enabled = val && T0T3equal && RowT0 && !T1T3 && !T2T3;
            backupT3furT1.Enabled = val && T1T3equal && RowT1 && !T0T3 && !T2T3;
            backupT3furT2.Enabled = val && T2T3equal && RowT2 && !T0T3 && !T1T3;

        }
        private void BackupT3Row(bool val)
        {
            if (val == false)
            {
                RowT3 = false;
            }
            else
            {
                RowT3 = true;
            }
            backupT0furT3.Enabled = val && T0T3equal  && columnT0 && !T1T0 && !T2T0;
            backupT1furT3.Enabled = val && T1T3equal  && columnT1 && !T0T1 && !T2T1;
            backupT2furT3.Enabled = val && T2T3equal  && columnT2 && !T0T2 && !T1T2;
        }
        private bool T1T0;
        private bool T1T2;
        private bool T1T3;
        private bool T0T1;
        private bool T0T2;
        private bool T0T3;
        private bool T2T0;
        private bool T2T1;
        private bool T2T3;
        private bool T3T0;
        private bool T3T1;
        private bool T3T2;

        private void backupT0furT1_CheckedChanged(object sender, EventArgs e)
        {
            T1T0 = !T1T0;
            
            backupT0furT2.Enabled = !backupT0furT1.Checked && T0T2equal && RowT2 && columnT0;
            backupT0furT3.Enabled = !backupT0furT1.Checked && T0T3equal && RowT3 && columnT0;
            BackupT1Column(!backupT0furT1.Checked);
            BackupT0Row(!backupT0furT1.Checked);

        }

        private void backupT0furT2_CheckedChanged(object sender, EventArgs e)
        {
            T2T0 = !T2T0;
            backupT0furT1.Enabled = !backupT0furT2.Checked && T0T1equal && RowT1 && columnT0;
            backupT0furT3.Enabled = !backupT0furT2.Checked && T0T3equal && RowT3 && columnT0;
            BackupT2Column(!backupT0furT2.Checked);
            BackupT0Row(!backupT0furT2.Checked);

        }

        private void backupT0furT3_CheckedChanged(object sender, EventArgs e)
        {
            T3T0 = !T3T0;
            backupT0furT2.Enabled = !backupT0furT3.Checked && T0T2equal && RowT2 && columnT0;
            backupT0furT1.Enabled = !backupT0furT3.Checked && T0T1equal && RowT1 && columnT0;
            BackupT3Column(!backupT0furT3.Checked);
            BackupT0Row(!backupT0furT3.Checked);

        }

        private void backupT1furT0_CheckedChanged(object sender, EventArgs e)
        {
            T0T1 = !T0T1;
            backupT1furT2.Enabled = !backupT1furT0.Checked && T1T2equal && RowT2 && columnT1;
            backupT1furT3.Enabled = !backupT1furT0.Checked && T1T3equal && RowT3 && columnT1;
            BackupT0Column(!backupT1furT0.Checked);
            BackupT1Row(!backupT1furT0.Checked);

        }

        private void backupT1furT2_CheckedChanged(object sender, EventArgs e)
        {
            T2T1 = !T2T1;
           
            backupT1furT0.Enabled = !backupT1furT2.Checked && T0T1equal && RowT0 && columnT1;
            backupT1furT3.Enabled = !backupT1furT2.Checked && T1T3equal && RowT3 && columnT1;
            BackupT2Column(!backupT1furT2.Checked);
            BackupT1Row(!backupT1furT2.Checked);

        }

        private void backupT1furT3_CheckedChanged(object sender, EventArgs e)
        {
            T3T1 = !T3T1;
            backupT1furT2.Enabled = !backupT1furT3.Checked && T1T2equal && RowT2 && columnT1;
            backupT1furT0.Enabled = !backupT1furT3.Checked && T0T1equal && RowT0 && columnT1;
            BackupT3Column(!backupT1furT3.Checked);
            BackupT1Row(!backupT1furT3.Checked);

        }

        private void backupT2furT0_CheckedChanged(object sender, EventArgs e)
        {
            T0T2 = !T0T2;
            backupT2furT1.Enabled = !backupT2furT0.Checked && T1T2equal && RowT1 && columnT2;
            backupT2furT3.Enabled = !backupT2furT0.Checked && T2T3equal && RowT3 && columnT2;
            BackupT0Column(!backupT2furT0.Checked);
            BackupT2Row(!backupT2furT0.Checked);

        }

        private void backupT2furT1_CheckedChanged(object sender, EventArgs e)
        {
            T1T2 = !T1T2;
            backupT2furT0.Enabled = !backupT2furT1.Checked && T0T2equal && RowT0 && columnT2;
            backupT2furT3.Enabled = !backupT2furT1.Checked && T2T3equal && RowT3 && columnT2;
            BackupT1Column(!backupT2furT1.Checked);
            BackupT2Row(!backupT2furT1.Checked);

        }

        private void backupT2furT3_CheckedChanged(object sender, EventArgs e)
        {
            T3T2 = !T3T2;
            backupT2furT0.Enabled = !backupT2furT3.Checked && T0T2equal && RowT0 && columnT2;
            backupT2furT1.Enabled = !backupT2furT3.Checked && T1T2equal && RowT1 && columnT2;
            BackupT3Column(!backupT2furT3.Checked);
            BackupT2Row(!backupT2furT3.Checked);

        }

        private void backupT3furT0_CheckedChanged(object sender, EventArgs e)
        {
            T0T3 = !T0T3;
            
            backupT3furT1.Enabled = !backupT3furT0.Checked && T1T3equal && RowT1 && columnT3;
            backupT3furT2.Enabled = !backupT3furT0.Checked && T2T3equal && RowT2 && columnT3;
            BackupT0Column(!backupT3furT0.Checked);
            BackupT3Row(!backupT3furT0.Checked);


        }

        private void backupT3furT1_CheckedChanged(object sender, EventArgs e)
        {

            T1T3 = !T1T3;
            backupT3furT0.Enabled = !backupT3furT1.Checked && T0T3equal && RowT0 && columnT3;
            backupT3furT2.Enabled = !backupT3furT1.Checked && T2T3equal && RowT2 && columnT3;
            BackupT1Column(!backupT3furT1.Checked);
            BackupT3Row(!backupT3furT1.Checked);



        }

        private void backupT3furT2_CheckedChanged(object sender, EventArgs e)
        {
            T2T3 = !T2T3;

            
            backupT3furT1.Enabled = !backupT3furT2.Checked && T1T3equal && RowT1 && columnT3;
            backupT3furT0.Enabled = !backupT3furT2.Checked && T0T3equal && RowT0 && columnT3;
            BackupT2Column(!backupT3furT2.Checked);
            BackupT3Row(!backupT3furT2.Checked);


        }

        private void ComboNozzleSizeT0_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboNozzleSizeT0.SelectedIndex != -1)
            {
                nozzleSizeT0 = this.ComboNozzleSizeT0.GetItemText(this.ComboNozzleSizeT0.SelectedItem);
            }
            else
            {
                nozzleSizeT0 = string.Empty;
            }

            if (nozzleSizeT0 != nozzleSizeT2)
            UpdateNozzleSizeFile();
            EndlessNozzleCheck();
        }

        private void ComboNozzleSizeT1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboNozzleSizeT1.SelectedIndex != -1)
            {
                nozzleSizeT1 = this.ComboNozzleSizeT1.GetItemText(this.ComboNozzleSizeT1.SelectedItem);
            }
            else
            {
                nozzleSizeT1 = string.Empty;
            }
            UpdateNozzleSizeFile();
            EndlessNozzleCheck();
        }

        private void ComboNozzleSizeT2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboNozzleSizeT2.SelectedIndex != -1)
            {
                nozzleSizeT2 = this.ComboNozzleSizeT2.GetItemText(this.ComboNozzleSizeT2.SelectedItem);
            }
            else
            {
                nozzleSizeT2 = string.Empty;
            }
            UpdateNozzleSizeFile();
            EndlessNozzleCheck();
        }

        private void ComboNozzleSizeT3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboNozzleSizeT3.SelectedIndex != -1)
            {
                nozzleSizeT3 = this.ComboNozzleSizeT3.GetItemText(this.ComboNozzleSizeT3.SelectedItem);
            }
            else
            {
                nozzleSizeT3 = string.Empty;
            }
            UpdateNozzleSizeFile();
            EndlessNozzleCheck();
        }


        private void EndlessNozzleCheck()
        {

            foreach (Control c in Filament.Controls)
            {
                foreach (Control ctrl in c.Controls)
                {
                    if (ctrl is CheckBox)
                    {
                        ((CheckBox)ctrl).Enabled = true;
                        ((CheckBox)ctrl).CheckState = CheckState.Unchecked;
                    }
                }
            }
            T0T1equal = (nozzleSizeT0 == nozzleSizeT1);
            backupT0furT1.Enabled = T0T1equal;
            backupT1furT0.Enabled = T0T1equal;
            T0T2equal = (nozzleSizeT0 == nozzleSizeT2);
            backupT0furT2.Enabled = T0T2equal;
            backupT2furT0.Enabled = T0T2equal;
            T0T3equal = (nozzleSizeT0 == nozzleSizeT3);
            backupT0furT3.Enabled = T0T3equal;
            backupT3furT0.Enabled = T0T3equal;
            T1T2equal = (nozzleSizeT1 == nozzleSizeT2);
            backupT1furT2.Enabled = T1T2equal;
            backupT2furT1.Enabled = T1T2equal;
            T1T3equal = (nozzleSizeT1 == nozzleSizeT3);
            backupT1furT3.Enabled = T1T3equal;
            backupT3furT1.Enabled = T1T3equal;
            T2T3equal = (nozzleSizeT2 == nozzleSizeT3);
            backupT2furT3.Enabled = T2T3equal;
            backupT3furT2.Enabled = T2T3equal;
        }
        private void GetNozzleSizeString()
        {
            nozzleSizeT0 = this.ComboNozzleSizeT0.GetItemText(this.ComboNozzleSizeT0.SelectedItem);
            nozzleSizeT1 = this.ComboNozzleSizeT1.GetItemText(this.ComboNozzleSizeT1.SelectedItem);
            nozzleSizeT2 = this.ComboNozzleSizeT2.GetItemText(this.ComboNozzleSizeT2.SelectedItem);
            nozzleSizeT3 = this.ComboNozzleSizeT3.GetItemText(this.ComboNozzleSizeT3.SelectedItem);
        }
    }


    public class AnalyseLogFatalError
    {


    }


    public class TemperatureControl
    {

    }
}



