using System;
using System.Windows.Forms;

namespace MultecPlugin
{
    partial class MultecTouchpanel
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

   #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TabPage tabpage2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultecTouchpanel));
            this.lblKalParkPosition = new System.Windows.Forms.Label();
            this.lblWhen4Move_2 = new System.Windows.Forms.Label();
            this.lblParkPositionVal = new System.Windows.Forms.Label();
            this.druckPermissives = new System.Windows.Forms.GroupBox();
            this.ChckboxDruckerInitialised = new System.Windows.Forms.CheckBox();
            this.ChckboxMoveInitialised = new System.Windows.Forms.CheckBox();
            this.lblKalRotOffsetFilament = new System.Windows.Forms.Label();
            this.lblWhen4Move_1 = new System.Windows.Forms.Label();
            this.lblRotOffFillVal = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lbl_mm = new System.Windows.Forms.Label();
            this.lbl_zOffset = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.text_M218_Y = new System.Windows.Forms.TextBox();
            this.text_M218_X = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text_T0_ziel = new System.Windows.Forms.TextBox();
            this.text_T1_ziel = new System.Windows.Forms.TextBox();
            this.text_T2_ziel = new System.Windows.Forms.TextBox();
            this.text_T3_ziel = new System.Windows.Forms.TextBox();
            this.text_T0_Aktuell = new System.Windows.Forms.TextBox();
            this.text_T1_Aktuell = new System.Windows.Forms.TextBox();
            this.text_T2_Aktuell = new System.Windows.Forms.TextBox();
            this.text_T3_Aktuell = new System.Windows.Forms.TextBox();
            this.text_Bed_ziel = new System.Windows.Forms.TextBox();
            this.text_Bed_Aktuell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TouchControl = new System.Windows.Forms.TabPage();
            this.lblFlowrate = new System.Windows.Forms.Label();
            this.numericFlowrate = new System.Windows.Forms.NumericUpDown();
            this.lbFeedrate = new System.Windows.Forms.Label();
            this.numericFeedrate = new System.Windows.Forms.NumericUpDown();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblYPosition = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZPosition = new System.Windows.Forms.Label();
            this.lblXPosition = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.chckBoxDruckerende = new System.Windows.Forms.CheckBox();
            this.btnBed_OnOff = new System.Windows.Forms.PictureBox();
            this.btnT3_OnOff = new System.Windows.Forms.PictureBox();
            this.btnT2_OnOff = new System.Windows.Forms.PictureBox();
            this.btnT1_OnOff = new System.Windows.Forms.PictureBox();
            this.btnT0_OnOff = new System.Windows.Forms.PictureBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtManualGcode = new System.Windows.Forms.TextBox();
            this.Filament = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.btnActivate = new System.Windows.Forms.Button();
            this.NozzleSizeKal = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnNozzleSizeSave = new System.Windows.Forms.Button();
            this.textT0NozzleSize = new System.Windows.Forms.TextBox();
            this.textT2NozzleSize = new System.Windows.Forms.TextBox();
            this.textT1NozzleSize = new System.Windows.Forms.TextBox();
            this.textT3NozzleSize = new System.Windows.Forms.TextBox();
            this.backupT2furT3 = new System.Windows.Forms.CheckBox();
            this.backupT0furT3 = new System.Windows.Forms.CheckBox();
            this.label49 = new System.Windows.Forms.Label();
            this.backupT1furT3 = new System.Windows.Forms.CheckBox();
            this.backupT3furT2 = new System.Windows.Forms.CheckBox();
            this.backupT0furT2 = new System.Windows.Forms.CheckBox();
            this.label48 = new System.Windows.Forms.Label();
            this.backupT1furT2 = new System.Windows.Forms.CheckBox();
            this.backupT3furT1 = new System.Windows.Forms.CheckBox();
            this.backupT2furT1 = new System.Windows.Forms.CheckBox();
            this.label45 = new System.Windows.Forms.Label();
            this.backupT0furT1 = new System.Windows.Forms.CheckBox();
            this.backupT3furT0 = new System.Windows.Forms.CheckBox();
            this.backupT2furT0 = new System.Windows.Forms.CheckBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.backupT1furT0 = new System.Windows.Forms.CheckBox();
            this.FilamentWechseln = new System.Windows.Forms.GroupBox();
            this.lblFilamentChangeTemp = new System.Windows.Forms.Label();
            this.lblRetractLoadFilT3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblRetractLoadFilT2 = new System.Windows.Forms.Label();
            this.lblRetractLoadFilT0 = new System.Windows.Forms.Label();
            this.lblRetractLoadFilT1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxTemp = new System.Windows.Forms.TextBox();
            this.lblT0 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.filamentUberwachung = new System.Windows.Forms.GroupBox();
            this.lblT3_1 = new System.Windows.Forms.Label();
            this.lblT2_1 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.lblFilamentT3 = new System.Windows.Forms.Label();
            this.lblFilamentT2 = new System.Windows.Forms.Label();
            this.lblFilamentT0 = new System.Windows.Forms.Label();
            this.lblFilamentT1 = new System.Windows.Forms.Label();
            this.lblFilamentStatus = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.lblDV = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.LblMoveCoverOffset = new System.Windows.Forms.Label();
            this.lblParkPosition = new System.Windows.Forms.Label();
            this.lblReinigungsschwelle = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.lblRotOffsetFilament = new System.Windows.Forms.Label();
            this.lblWhen4Move = new System.Windows.Forms.Label();
            this.lblZKorrektur = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.lblDisatance = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.lblOptimalDistance = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.lblRotationalOffset = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.lblKgSrvcT3 = new System.Windows.Forms.Label();
            this.lblKgSrvcT2 = new System.Windows.Forms.Label();
            this.lblKgSrvcT1 = new System.Windows.Forms.Label();
            this.lblKgSrvcT0 = new System.Windows.Forms.Label();
            this.lblHeatedSrvcT3 = new System.Windows.Forms.Label();
            this.lblHeatedSrvcT2 = new System.Windows.Forms.Label();
            this.lblHeatedSrvcT1 = new System.Windows.Forms.Label();
            this.lblHeatedSrvcT0 = new System.Windows.Forms.Label();
            this.lblExtrudedSrvcT3 = new System.Windows.Forms.Label();
            this.lblExtrudedSrvcT2 = new System.Windows.Forms.Label();
            this.lblExtrudedSrvcT1 = new System.Windows.Forms.Label();
            this.lblExtrudedSrvcT0 = new System.Windows.Forms.Label();
            this.lblSrvcDistanceZ = new System.Windows.Forms.Label();
            this.lblSrvcDistanceY = new System.Windows.Forms.Label();
            this.lblSrvcDistanceX = new System.Windows.Forms.Label();
            this.lblSrvcPrntLife = new System.Windows.Forms.Label();
            this.lblSrvcPwrON = new System.Windows.Forms.Label();
            this.lblSrvcPwrCycle = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.lblKgTotalT3 = new System.Windows.Forms.Label();
            this.lblKgTotalT2 = new System.Windows.Forms.Label();
            this.lblKgTotalT1 = new System.Windows.Forms.Label();
            this.lblKgTotalT0 = new System.Windows.Forms.Label();
            this.lblT3_3 = new System.Windows.Forms.Label();
            this.lblT2_3 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.lblHeatedTotalT3 = new System.Windows.Forms.Label();
            this.lblHeatedTotalT2 = new System.Windows.Forms.Label();
            this.lblHeatedTotalT1 = new System.Windows.Forms.Label();
            this.lblHeatedTotalT0 = new System.Windows.Forms.Label();
            this.lblExtrudedTotalT3 = new System.Windows.Forms.Label();
            this.lblExtrudedTotalT2 = new System.Windows.Forms.Label();
            this.lblExtrudedTotalT1 = new System.Windows.Forms.Label();
            this.lblExtrudedTotalT0 = new System.Windows.Forms.Label();
            this.lblTotalDistanceZ = new System.Windows.Forms.Label();
            this.lblTotalDistanceY = new System.Windows.Forms.Label();
            this.lblTotalDistanceX = new System.Windows.Forms.Label();
            this.lblTotalPrntLife = new System.Windows.Forms.Label();
            this.lblTotalPwrON = new System.Windows.Forms.Label();
            this.lblTotalPwrCycle = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.lblAbstandT3 = new System.Windows.Forms.Label();
            this.lblAbstandT2 = new System.Windows.Forms.Label();
            this.lblAbstandT1 = new System.Windows.Forms.Label();
            this.lblAbstandT0 = new System.Windows.Forms.Label();
            this.lblFirmware = new System.Windows.Forms.Label();
            this.lblT3_4 = new System.Windows.Forms.Label();
            this.lblT2_4 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblT3_2 = new System.Windows.Forms.Label();
            this.lblT2_2 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblT3_5 = new System.Windows.Forms.Label();
            this.lblT2_5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer_temp = new System.Windows.Forms.Timer(this.components);
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.wrkerColdExtrusion = new System.ComponentModel.BackgroundWorker();
            this.wrkrOpenDialogBox = new System.ComponentModel.BackgroundWorker();
            this.lblBanner = new System.Windows.Forms.Label();
            this.wrkrHomeXY = new System.ComponentModel.BackgroundWorker();
            this.timerRetractLoad = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBedTempPlus = new MyCustomButton.MyCustomButton();
            this.btnBedTempMinus = new MyCustomButton.MyCustomButton();
            this.btnT3TempPlus = new MyCustomButton.MyCustomButton();
            this.btnT3TempMinus = new MyCustomButton.MyCustomButton();
            this.btnT2TempMinus = new MyCustomButton.MyCustomButton();
            this.btnT2TempPlus = new MyCustomButton.MyCustomButton();
            this.btnT1TempPlus = new MyCustomButton.MyCustomButton();
            this.btnT1TempMinus = new MyCustomButton.MyCustomButton();
            this.btnT0TempPlus = new MyCustomButton.MyCustomButton();
            this.btnT0TempMinus = new MyCustomButton.MyCustomButton();
            this.btnFeedratePlus = new MyCustomButton.MyCustomButton();
            this.btnFlowratePlus = new MyCustomButton.MyCustomButton();
            this.btnFeedrateMinus = new MyCustomButton.MyCustomButton();
            this.btnFlowrateMinus = new MyCustomButton.MyCustomButton();
            this.btnYhome = new MyCustomButton.MyCustomButton();
            this.btnXhome = new MyCustomButton.MyCustomButton();
            this.btnParkMove = new MyCustomButton.MyCustomButton();
            this.btnHome = new MyCustomButton.MyCustomButton();
            this.btnMotorOff = new MyCustomButton.MyCustomButton();
            this.btnManualGcodeSend = new MyCustomButton.MyCustomButton();
            this.btnHomeMove = new MyCustomButton.MyCustomButton();
            this.btnExtrude = new MyCustomButton.MyCustomButton();
            this.btnRetract = new MyCustomButton.MyCustomButton();
            this.btnZminus = new MyCustomButton.MyCustomButton();
            this.btnZPlus = new MyCustomButton.MyCustomButton();
            this.btnYPlus = new MyCustomButton.MyCustomButton();
            this.btnYMinus = new MyCustomButton.MyCustomButton();
            this.btnXPlus = new MyCustomButton.MyCustomButton();
            this.btnStep50 = new MyCustomButton.MyCustomButton();
            this.btnStep10 = new MyCustomButton.MyCustomButton();
            this.btnStep1 = new MyCustomButton.MyCustomButton();
            this.btnT3 = new MyCustomButton.MyCustomButton();
            this.btnT2 = new MyCustomButton.MyCustomButton();
            this.btnT1 = new MyCustomButton.MyCustomButton();
            this.btnT0 = new MyCustomButton.MyCustomButton();
            this.btnXMinus = new MyCustomButton.MyCustomButton();
            this.btnLoadT0 = new MyCustomButton.MyCustomButton();
            this.btnLoadT3 = new MyCustomButton.MyCustomButton();
            this.btnRetractT0 = new MyCustomButton.MyCustomButton();
            this.btnRetractT3 = new MyCustomButton.MyCustomButton();
            this.btnLoadT1 = new MyCustomButton.MyCustomButton();
            this.btnLoadT2 = new MyCustomButton.MyCustomButton();
            this.btnRetractT1 = new MyCustomButton.MyCustomButton();
            this.btnRetractT2 = new MyCustomButton.MyCustomButton();
            this.btnFilAktualise = new MyCustomButton.MyCustomButton();
            this.btnM218T3 = new MyCustomButton.MyCustomButton();
            this.btnM218T2 = new MyCustomButton.MyCustomButton();
            this.btnM218T1 = new MyCustomButton.MyCustomButton();
            this.btnPminus = new MyCustomButton.MyCustomButton();
            this.btnPplus = new MyCustomButton.MyCustomButton();
            this.btnParkPositionSend = new MyCustomButton.MyCustomButton();
            this.btnEminus = new MyCustomButton.MyCustomButton();
            this.btnEplus = new MyCustomButton.MyCustomButton();
            this.btnZOffsetPlus = new MyCustomButton.MyCustomButton();
            this.btnZOffsetMinus = new MyCustomButton.MyCustomButton();
            this.btnXOffsetPlus = new MyCustomButton.MyCustomButton();
            this.btnXOffsetMinus = new MyCustomButton.MyCustomButton();
            this.btnYoffsetPlus = new MyCustomButton.MyCustomButton();
            this.btnYoffsetMinus = new MyCustomButton.MyCustomButton();
            this.btnZOffsetSend = new MyCustomButton.MyCustomButton();
            this.btnXoffsetSend = new MyCustomButton.MyCustomButton();
            this.btnYoffsetSend = new MyCustomButton.MyCustomButton();
            this.btnRotOffsetSend = new MyCustomButton.MyCustomButton();
            this.btnFineAdjustment = new MyCustomButton.MyCustomButton();
            this.btnDusevermessung = new MyCustomButton.MyCustomButton();
            this.btnPositionPrufen = new MyCustomButton.MyCustomButton();
            this.btnParkMoveKal = new MyCustomButton.MyCustomButton();
            this.btnHomeMoveKal = new MyCustomButton.MyCustomButton();
            this.btnInfoAktualise = new MyCustomButton.MyCustomButton();
            tabpage2 = new System.Windows.Forms.TabPage();
            tabpage2.SuspendLayout();
            this.druckPermissives.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.TouchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlowrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFeedrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBed_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0_OnOff)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.Filament.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.NozzleSizeKal.SuspendLayout();
            this.FilamentWechseln.SuspendLayout();
            this.filamentUberwachung.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBedTempPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBedTempMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3TempPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3TempMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2TempMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2TempPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1TempPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1TempMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0TempPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0TempMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFeedratePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFlowratePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFeedrateMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFlowrateMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParkMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMotorOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManualGcodeSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomeMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtrude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadT0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadT3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetractT0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetractT3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetractT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetractT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilAktualise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPplus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParkPositionSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEplus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZOffsetPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZOffsetMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXOffsetPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXOffsetMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoffsetPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoffsetMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZOffsetSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoffsetSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoffsetSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRotOffsetSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFineAdjustment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDusevermessung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPositionPrufen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParkMoveKal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomeMoveKal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoAktualise)).BeginInit();
            this.SuspendLayout();
            // 
            // tabpage2
            // 
            tabpage2.BackColor = System.Drawing.Color.White;
            tabpage2.Controls.Add(this.lblKalParkPosition);
            tabpage2.Controls.Add(this.lblWhen4Move_2);
            tabpage2.Controls.Add(this.lblParkPositionVal);
            tabpage2.Controls.Add(this.druckPermissives);
            tabpage2.Controls.Add(this.lblKalRotOffsetFilament);
            tabpage2.Controls.Add(this.lblWhen4Move_1);
            tabpage2.Controls.Add(this.lblRotOffFillVal);
            tabpage2.Controls.Add(this.label37);
            tabpage2.Controls.Add(this.label38);
            tabpage2.Controls.Add(this.lbl_mm);
            tabpage2.Controls.Add(this.lbl_zOffset);
            tabpage2.Controls.Add(this.groupBox3);
            tabpage2.Controls.Add(this.label15);
            tabpage2.Controls.Add(this.label14);
            tabpage2.Controls.Add(this.text_M218_Y);
            tabpage2.Controls.Add(this.text_M218_X);
            tabpage2.Controls.Add(this.label13);
            tabpage2.Controls.Add(this.label12);
            tabpage2.Controls.Add(this.btnPminus);
            tabpage2.Controls.Add(this.btnPplus);
            tabpage2.Controls.Add(this.btnParkPositionSend);
            tabpage2.Controls.Add(this.btnEminus);
            tabpage2.Controls.Add(this.btnEplus);
            tabpage2.Controls.Add(this.btnZOffsetPlus);
            tabpage2.Controls.Add(this.btnZOffsetMinus);
            tabpage2.Controls.Add(this.btnXOffsetPlus);
            tabpage2.Controls.Add(this.btnXOffsetMinus);
            tabpage2.Controls.Add(this.btnYoffsetPlus);
            tabpage2.Controls.Add(this.btnYoffsetMinus);
            tabpage2.Controls.Add(this.btnZOffsetSend);
            tabpage2.Controls.Add(this.btnXoffsetSend);
            tabpage2.Controls.Add(this.btnYoffsetSend);
            tabpage2.Controls.Add(this.btnRotOffsetSend);
            tabpage2.Controls.Add(this.btnFineAdjustment);
            tabpage2.Controls.Add(this.btnDusevermessung);
            tabpage2.Controls.Add(this.btnPositionPrufen);
            tabpage2.Controls.Add(this.btnParkMoveKal);
            tabpage2.Controls.Add(this.btnHomeMoveKal);
            tabpage2.Location = new System.Drawing.Point(44, 4);
            tabpage2.Margin = new System.Windows.Forms.Padding(2);
            tabpage2.Name = "tabpage2";
            tabpage2.Padding = new System.Windows.Forms.Padding(2);
            tabpage2.Size = new System.Drawing.Size(570, 526);
            tabpage2.TabIndex = 1;
            tabpage2.Text = "Kalibrierung";
            // 
            // lblKalParkPosition
            // 
            this.lblKalParkPosition.AutoSize = true;
            this.lblKalParkPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalParkPosition.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblKalParkPosition.Location = new System.Drawing.Point(310, 309);
            this.lblKalParkPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalParkPosition.Name = "lblKalParkPosition";
            this.lblKalParkPosition.Size = new System.Drawing.Size(97, 15);
            this.lblKalParkPosition.TabIndex = 92;
            this.lblKalParkPosition.Text = "Parkposition Move";
            // 
            // lblWhen4Move_2
            // 
            this.lblWhen4Move_2.AutoSize = true;
            this.lblWhen4Move_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhen4Move_2.Location = new System.Drawing.Point(343, 344);
            this.lblWhen4Move_2.Name = "lblWhen4Move_2";
            this.lblWhen4Move_2.Size = new System.Drawing.Size(34, 18);
            this.lblWhen4Move_2.TabIndex = 91;
            this.lblWhen4Move_2.Text = "mm";
            // 
            // lblParkPositionVal
            // 
            this.lblParkPositionVal.AutoSize = true;
            this.lblParkPositionVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkPositionVal.Location = new System.Drawing.Point(343, 329);
            this.lblParkPositionVal.Name = "lblParkPositionVal";
            this.lblParkPositionVal.Size = new System.Drawing.Size(32, 16);
            this.lblParkPositionVal.TabIndex = 90;
            this.lblParkPositionVal.Text = "0.00";
            // 
            // druckPermissives
            // 
            this.druckPermissives.Controls.Add(this.ChckboxDruckerInitialised);
            this.druckPermissives.Controls.Add(this.ChckboxMoveInitialised);
            this.druckPermissives.Location = new System.Drawing.Point(5, 237);
            this.druckPermissives.Name = "druckPermissives";
            this.druckPermissives.Size = new System.Drawing.Size(133, 94);
            this.druckPermissives.TabIndex = 69;
            this.druckPermissives.TabStop = false;
            this.druckPermissives.Text = "Druckerstatus";
            // 
            // ChckboxDruckerInitialised
            // 
            this.ChckboxDruckerInitialised.AutoCheck = false;
            this.ChckboxDruckerInitialised.AutoSize = true;
            this.ChckboxDruckerInitialised.ForeColor = System.Drawing.Color.Gray;
            this.ChckboxDruckerInitialised.Location = new System.Drawing.Point(7, 61);
            this.ChckboxDruckerInitialised.Name = "ChckboxDruckerInitialised";
            this.ChckboxDruckerInitialised.Size = new System.Drawing.Size(112, 17);
            this.ChckboxDruckerInitialised.TabIndex = 1;
            this.ChckboxDruckerInitialised.Text = "Drucker Initializiert";
            this.ChckboxDruckerInitialised.UseVisualStyleBackColor = true;
            // 
            // ChckboxMoveInitialised
            // 
            this.ChckboxMoveInitialised.AutoCheck = false;
            this.ChckboxMoveInitialised.AutoSize = true;
            this.ChckboxMoveInitialised.Checked = true;
            this.ChckboxMoveInitialised.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChckboxMoveInitialised.ForeColor = System.Drawing.Color.Gray;
            this.ChckboxMoveInitialised.Location = new System.Drawing.Point(7, 30);
            this.ChckboxMoveInitialised.Name = "ChckboxMoveInitialised";
            this.ChckboxMoveInitialised.Size = new System.Drawing.Size(101, 17);
            this.ChckboxMoveInitialised.TabIndex = 0;
            this.ChckboxMoveInitialised.Text = "Move Initializiert";
            this.ChckboxMoveInitialised.UseVisualStyleBackColor = true;
            // 
            // lblKalRotOffsetFilament
            // 
            this.lblKalRotOffsetFilament.AutoSize = true;
            this.lblKalRotOffsetFilament.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalRotOffsetFilament.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblKalRotOffsetFilament.Location = new System.Drawing.Point(279, 246);
            this.lblKalRotOffsetFilament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalRotOffsetFilament.Name = "lblKalRotOffsetFilament";
            this.lblKalRotOffsetFilament.Size = new System.Drawing.Size(161, 15);
            this.lblKalRotOffsetFilament.TabIndex = 68;
            this.lblKalRotOffsetFilament.Text = "Rotationsoffset Filamentauswahl";
            // 
            // lblWhen4Move_1
            // 
            this.lblWhen4Move_1.AutoSize = true;
            this.lblWhen4Move_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhen4Move_1.Location = new System.Drawing.Point(343, 281);
            this.lblWhen4Move_1.Name = "lblWhen4Move_1";
            this.lblWhen4Move_1.Size = new System.Drawing.Size(34, 18);
            this.lblWhen4Move_1.TabIndex = 66;
            this.lblWhen4Move_1.Text = "mm";
            // 
            // lblRotOffFillVal
            // 
            this.lblRotOffFillVal.AutoSize = true;
            this.lblRotOffFillVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotOffFillVal.Location = new System.Drawing.Point(343, 266);
            this.lblRotOffFillVal.Name = "lblRotOffFillVal";
            this.lblRotOffFillVal.Size = new System.Drawing.Size(32, 16);
            this.lblRotOffFillVal.TabIndex = 65;
            this.lblRotOffFillVal.Text = "0.00";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label37.Enabled = false;
            this.label37.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label37.Location = new System.Drawing.Point(301, 183);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(115, 15);
            this.label37.TabIndex = 62;
            this.label37.Text = "M702 D Feinjustierung";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Enabled = false;
            this.label38.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label38.Location = new System.Drawing.Point(2, 144);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(20, 13);
            this.label38.TabIndex = 59;
            this.label38.Text = "#2";
            // 
            // lbl_mm
            // 
            this.lbl_mm.AutoSize = true;
            this.lbl_mm.Enabled = false;
            this.lbl_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mm.Location = new System.Drawing.Point(343, 216);
            this.lbl_mm.Name = "lbl_mm";
            this.lbl_mm.Size = new System.Drawing.Size(34, 18);
            this.lbl_mm.TabIndex = 55;
            this.lbl_mm.Text = "mm";
            // 
            // lbl_zOffset
            // 
            this.lbl_zOffset.AutoSize = true;
            this.lbl_zOffset.Enabled = false;
            this.lbl_zOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_zOffset.Location = new System.Drawing.Point(343, 201);
            this.lbl_zOffset.Name = "lbl_zOffset";
            this.lbl_zOffset.Size = new System.Drawing.Size(32, 16);
            this.lbl_zOffset.TabIndex = 54;
            this.lbl_zOffset.Text = "0.00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnM218T3);
            this.groupBox3.Controls.Add(this.btnM218T2);
            this.groupBox3.Controls.Add(this.btnM218T1);
            this.groupBox3.Location = new System.Drawing.Point(287, 4);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(241, 65);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extruder Auswahl";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(353, 131);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 46;
            this.label15.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label14.Location = new System.Drawing.Point(353, 82);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "X";
            // 
            // text_M218_Y
            // 
            this.text_M218_Y.Enabled = false;
            this.text_M218_Y.Location = new System.Drawing.Point(329, 144);
            this.text_M218_Y.Margin = new System.Windows.Forms.Padding(2);
            this.text_M218_Y.Name = "text_M218_Y";
            this.text_M218_Y.ReadOnly = true;
            this.text_M218_Y.Size = new System.Drawing.Size(61, 20);
            this.text_M218_Y.TabIndex = 41;
            // 
            // text_M218_X
            // 
            this.text_M218_X.Location = new System.Drawing.Point(329, 95);
            this.text_M218_X.Margin = new System.Windows.Forms.Padding(2);
            this.text_M218_X.Name = "text_M218_X";
            this.text_M218_X.ReadOnly = true;
            this.text_M218_X.Size = new System.Drawing.Size(61, 20);
            this.text_M218_X.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(2, 75);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 38;
            this.label13.Text = "#1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label12.Location = new System.Drawing.Point(2, 4);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "#1";
            this.label12.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStep50);
            this.groupBox1.Controls.Add(this.btnStep10);
            this.groupBox1.Controls.Add(this.btnStep1);
            this.groupBox1.Location = new System.Drawing.Point(484, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(68, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fahrweg";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnT3);
            this.groupBox2.Controls.Add(this.btnT2);
            this.groupBox2.Controls.Add(this.btnT1);
            this.groupBox2.Controls.Add(this.btnT0);
            this.groupBox2.Location = new System.Drawing.Point(120, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extruder Auswahl";
            // 
            // text_T0_ziel
            // 
            this.text_T0_ziel.Location = new System.Drawing.Point(130, 420);
            this.text_T0_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T0_ziel.Name = "text_T0_ziel";
            this.text_T0_ziel.Size = new System.Drawing.Size(60, 20);
            this.text_T0_ziel.TabIndex = 19;
            this.text_T0_ziel.Text = "205";
            this.text_T0_ziel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_T0_ziel_KeyDown);
            this.text_T0_ziel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_T0_ziel_KeyPress);
            // 
            // text_T1_ziel
            // 
            this.text_T1_ziel.Location = new System.Drawing.Point(196, 420);
            this.text_T1_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T1_ziel.Name = "text_T1_ziel";
            this.text_T1_ziel.Size = new System.Drawing.Size(59, 20);
            this.text_T1_ziel.TabIndex = 20;
            this.text_T1_ziel.Text = "205";
            this.text_T1_ziel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_T1_ziel_KeyDown);
            this.text_T1_ziel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_T0_ziel_KeyPress);
            // 
            // text_T2_ziel
            // 
            this.text_T2_ziel.Location = new System.Drawing.Point(262, 420);
            this.text_T2_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T2_ziel.Name = "text_T2_ziel";
            this.text_T2_ziel.Size = new System.Drawing.Size(60, 20);
            this.text_T2_ziel.TabIndex = 21;
            this.text_T2_ziel.Text = "205";
            this.text_T2_ziel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_T2_ziel_KeyDown);
            this.text_T2_ziel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_T0_ziel_KeyPress);
            // 
            // text_T3_ziel
            // 
            this.text_T3_ziel.Location = new System.Drawing.Point(328, 420);
            this.text_T3_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T3_ziel.Name = "text_T3_ziel";
            this.text_T3_ziel.Size = new System.Drawing.Size(60, 20);
            this.text_T3_ziel.TabIndex = 22;
            this.text_T3_ziel.Text = "205";
            this.text_T3_ziel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_T3_ziel_KeyDown);
            this.text_T3_ziel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_T0_ziel_KeyPress);
            // 
            // text_T0_Aktuell
            // 
            this.text_T0_Aktuell.Location = new System.Drawing.Point(130, 444);
            this.text_T0_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T0_Aktuell.Name = "text_T0_Aktuell";
            this.text_T0_Aktuell.ReadOnly = true;
            this.text_T0_Aktuell.Size = new System.Drawing.Size(60, 20);
            this.text_T0_Aktuell.TabIndex = 23;
            // 
            // text_T1_Aktuell
            // 
            this.text_T1_Aktuell.Location = new System.Drawing.Point(196, 444);
            this.text_T1_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T1_Aktuell.Name = "text_T1_Aktuell";
            this.text_T1_Aktuell.ReadOnly = true;
            this.text_T1_Aktuell.Size = new System.Drawing.Size(59, 20);
            this.text_T1_Aktuell.TabIndex = 24;
            // 
            // text_T2_Aktuell
            // 
            this.text_T2_Aktuell.Location = new System.Drawing.Point(262, 444);
            this.text_T2_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T2_Aktuell.Name = "text_T2_Aktuell";
            this.text_T2_Aktuell.ReadOnly = true;
            this.text_T2_Aktuell.Size = new System.Drawing.Size(60, 20);
            this.text_T2_Aktuell.TabIndex = 25;
            // 
            // text_T3_Aktuell
            // 
            this.text_T3_Aktuell.Location = new System.Drawing.Point(328, 444);
            this.text_T3_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T3_Aktuell.Name = "text_T3_Aktuell";
            this.text_T3_Aktuell.ReadOnly = true;
            this.text_T3_Aktuell.Size = new System.Drawing.Size(60, 20);
            this.text_T3_Aktuell.TabIndex = 26;
            // 
            // text_Bed_ziel
            // 
            this.text_Bed_ziel.Location = new System.Drawing.Point(394, 420);
            this.text_Bed_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_Bed_ziel.Name = "text_Bed_ziel";
            this.text_Bed_ziel.Size = new System.Drawing.Size(60, 20);
            this.text_Bed_ziel.TabIndex = 31;
            this.text_Bed_ziel.Text = "60";
            this.text_Bed_ziel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_Bed_ziel_KeyDown);
            this.text_Bed_ziel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_Bed_ziel_KeyPress);
            // 
            // text_Bed_Aktuell
            // 
            this.text_Bed_Aktuell.Location = new System.Drawing.Point(394, 444);
            this.text_Bed_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_Bed_Aktuell.Name = "text_Bed_Aktuell";
            this.text_Bed_Aktuell.ReadOnly = true;
            this.text_Bed_Aktuell.Size = new System.Drawing.Size(60, 20);
            this.text_Bed_Aktuell.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(102, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ziel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(87, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Aktuell";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(149, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "T0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(214, 324);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "T1";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblT2.Location = new System.Drawing.Point(284, 324);
            this.lblT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(19, 13);
            this.lblT2.TabIndex = 44;
            this.lblT2.Text = "T2";
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblT3.Location = new System.Drawing.Point(347, 324);
            this.lblT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(19, 13);
            this.lblT3.TabIndex = 45;
            this.lblT3.Text = "T3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(396, 323);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Heizbett";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.TouchControl);
            this.tabControl1.Controls.Add(this.Filament);
            this.tabControl1.Controls.Add(tabpage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl1.ItemSize = new System.Drawing.Size(130, 40);
            this.tabControl1.Location = new System.Drawing.Point(-1, 37);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 534);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 47;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // TouchControl
            // 
            this.TouchControl.BackColor = System.Drawing.Color.White;
            this.TouchControl.Controls.Add(this.btnBedTempPlus);
            this.TouchControl.Controls.Add(this.btnBedTempMinus);
            this.TouchControl.Controls.Add(this.btnT3TempPlus);
            this.TouchControl.Controls.Add(this.btnT3TempMinus);
            this.TouchControl.Controls.Add(this.btnT2TempMinus);
            this.TouchControl.Controls.Add(this.btnT2TempPlus);
            this.TouchControl.Controls.Add(this.btnT1TempPlus);
            this.TouchControl.Controls.Add(this.btnT1TempMinus);
            this.TouchControl.Controls.Add(this.btnT0TempPlus);
            this.TouchControl.Controls.Add(this.btnT0TempMinus);
            this.TouchControl.Controls.Add(this.btnFeedratePlus);
            this.TouchControl.Controls.Add(this.btnFlowratePlus);
            this.TouchControl.Controls.Add(this.btnFeedrateMinus);
            this.TouchControl.Controls.Add(this.btnFlowrateMinus);
            this.TouchControl.Controls.Add(this.lblFlowrate);
            this.TouchControl.Controls.Add(this.numericFlowrate);
            this.TouchControl.Controls.Add(this.lbFeedrate);
            this.TouchControl.Controls.Add(this.numericFeedrate);
            this.TouchControl.Controls.Add(this.btnYhome);
            this.TouchControl.Controls.Add(this.btnXhome);
            this.TouchControl.Controls.Add(this.lblZ);
            this.TouchControl.Controls.Add(this.lblYPosition);
            this.TouchControl.Controls.Add(this.lblY);
            this.TouchControl.Controls.Add(this.lblZPosition);
            this.TouchControl.Controls.Add(this.lblXPosition);
            this.TouchControl.Controls.Add(this.lblX);
            this.TouchControl.Controls.Add(this.chckBoxDruckerende);
            this.TouchControl.Controls.Add(this.btnBed_OnOff);
            this.TouchControl.Controls.Add(this.btnT3_OnOff);
            this.TouchControl.Controls.Add(this.btnT2_OnOff);
            this.TouchControl.Controls.Add(this.btnT1_OnOff);
            this.TouchControl.Controls.Add(this.btnT0_OnOff);
            this.TouchControl.Controls.Add(this.btnParkMove);
            this.TouchControl.Controls.Add(this.btnHome);
            this.TouchControl.Controls.Add(this.btnMotorOff);
            this.TouchControl.Controls.Add(this.groupBox5);
            this.TouchControl.Controls.Add(this.btnHomeMove);
            this.TouchControl.Controls.Add(this.btnExtrude);
            this.TouchControl.Controls.Add(this.btnRetract);
            this.TouchControl.Controls.Add(this.btnZminus);
            this.TouchControl.Controls.Add(this.btnZPlus);
            this.TouchControl.Controls.Add(this.btnYPlus);
            this.TouchControl.Controls.Add(this.btnYMinus);
            this.TouchControl.Controls.Add(this.btnXPlus);
            this.TouchControl.Controls.Add(this.groupBox1);
            this.TouchControl.Controls.Add(this.label11);
            this.TouchControl.Controls.Add(this.lblT3);
            this.TouchControl.Controls.Add(this.lblT2);
            this.TouchControl.Controls.Add(this.label8);
            this.TouchControl.Controls.Add(this.label7);
            this.TouchControl.Controls.Add(this.label2);
            this.TouchControl.Controls.Add(this.groupBox2);
            this.TouchControl.Controls.Add(this.label1);
            this.TouchControl.Controls.Add(this.text_Bed_Aktuell);
            this.TouchControl.Controls.Add(this.text_Bed_ziel);
            this.TouchControl.Controls.Add(this.text_T3_Aktuell);
            this.TouchControl.Controls.Add(this.text_T2_Aktuell);
            this.TouchControl.Controls.Add(this.text_T1_Aktuell);
            this.TouchControl.Controls.Add(this.text_T0_Aktuell);
            this.TouchControl.Controls.Add(this.text_T0_ziel);
            this.TouchControl.Controls.Add(this.text_T3_ziel);
            this.TouchControl.Controls.Add(this.text_T1_ziel);
            this.TouchControl.Controls.Add(this.text_T2_ziel);
            this.TouchControl.Controls.Add(this.btnXMinus);
            this.TouchControl.Location = new System.Drawing.Point(44, 4);
            this.TouchControl.Name = "TouchControl";
            this.TouchControl.Padding = new System.Windows.Forms.Padding(3);
            this.TouchControl.Size = new System.Drawing.Size(570, 526);
            this.TouchControl.TabIndex = 0;
            this.TouchControl.Text = "Manuelle Steuerung";
            // 
            // lblFlowrate
            // 
            this.lblFlowrate.Location = new System.Drawing.Point(469, 391);
            this.lblFlowrate.Name = "lblFlowrate";
            this.lblFlowrate.Size = new System.Drawing.Size(71, 17);
            this.lblFlowrate.TabIndex = 79;
            this.lblFlowrate.Text = "Flussrate [%]";
            // 
            // numericFlowrate
            // 
            this.numericFlowrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFlowrate.Location = new System.Drawing.Point(477, 450);
            this.numericFlowrate.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericFlowrate.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericFlowrate.Name = "numericFlowrate";
            this.numericFlowrate.Size = new System.Drawing.Size(49, 21);
            this.numericFlowrate.TabIndex = 80;
            this.numericFlowrate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericFlowrate.ValueChanged += new System.EventHandler(this.numericFlowrate_ValueChanged);
            // 
            // lbFeedrate
            // 
            this.lbFeedrate.Location = new System.Drawing.Point(451, 256);
            this.lbFeedrate.Name = "lbFeedrate";
            this.lbFeedrate.Size = new System.Drawing.Size(103, 16);
            this.lbFeedrate.TabIndex = 0;
            this.lbFeedrate.Text = "Geschwindigkeit [%]";
            // 
            // numericFeedrate
            // 
            this.numericFeedrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFeedrate.Location = new System.Drawing.Point(477, 314);
            this.numericFeedrate.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericFeedrate.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericFeedrate.Name = "numericFeedrate";
            this.numericFeedrate.Size = new System.Drawing.Size(49, 21);
            this.numericFeedrate.TabIndex = 78;
            this.numericFeedrate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericFeedrate.ValueChanged += new System.EventHandler(this.numericFeedrate_ValueChanged);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(414, 56);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(17, 13);
            this.lblZ.TabIndex = 70;
            this.lblZ.Text = "Z:";
            // 
            // lblYPosition
            // 
            this.lblYPosition.AutoSize = true;
            this.lblYPosition.Location = new System.Drawing.Point(273, 56);
            this.lblYPosition.Name = "lblYPosition";
            this.lblYPosition.Size = new System.Drawing.Size(115, 13);
            this.lblYPosition.TabIndex = 69;
            this.lblYPosition.Text = "NICHT INITIALISIERT";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(250, 56);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 68;
            this.lblY.Text = "Y:";
            // 
            // lblZPosition
            // 
            this.lblZPosition.AutoSize = true;
            this.lblZPosition.Location = new System.Drawing.Point(437, 56);
            this.lblZPosition.Name = "lblZPosition";
            this.lblZPosition.Size = new System.Drawing.Size(115, 13);
            this.lblZPosition.TabIndex = 67;
            this.lblZPosition.Text = "NICHT INITIALISIERT";
            // 
            // lblXPosition
            // 
            this.lblXPosition.AutoSize = true;
            this.lblXPosition.Location = new System.Drawing.Point(116, 56);
            this.lblXPosition.Name = "lblXPosition";
            this.lblXPosition.Size = new System.Drawing.Size(115, 13);
            this.lblXPosition.TabIndex = 66;
            this.lblXPosition.Text = "NICHT INITIALISIERT";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(93, 56);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 65;
            this.lblX.Text = "X:";
            // 
            // chckBoxDruckerende
            // 
            this.chckBoxDruckerende.AutoSize = true;
            this.chckBoxDruckerende.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chckBoxDruckerende.Location = new System.Drawing.Point(95, 73);
            this.chckBoxDruckerende.Name = "chckBoxDruckerende";
            this.chckBoxDruckerende.Size = new System.Drawing.Size(222, 17);
            this.chckBoxDruckerende.TabIndex = 64;
            this.chckBoxDruckerende.Text = "Drucker nach Druckende herunterfahren.";
            this.chckBoxDruckerende.UseVisualStyleBackColor = true;
            this.chckBoxDruckerende.CheckedChanged += new System.EventHandler(this.chckBoxDruckerende_CheckedChanged);
            // 
            // btnBed_OnOff
            // 
            this.btnBed_OnOff.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.btnBed_OnOff.Location = new System.Drawing.Point(394, 338);
            this.btnBed_OnOff.Name = "btnBed_OnOff";
            this.btnBed_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnBed_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBed_OnOff.TabIndex = 63;
            this.btnBed_OnOff.TabStop = false;
            this.btnBed_OnOff.EnabledChanged += new System.EventHandler(this.btnBed_OnOff_EnabledChanged);
            this.btnBed_OnOff.Click += new System.EventHandler(this.btnBed_OnOff_Click);
            this.btnBed_OnOff.MouseEnter += new System.EventHandler(this.btnT0_OnOff_MouseEnter);
            this.btnBed_OnOff.MouseLeave += new System.EventHandler(this.btnT0_OnOff_MouseLeave);
            // 
            // btnT3_OnOff
            // 
            this.btnT3_OnOff.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.btnT3_OnOff.Location = new System.Drawing.Point(328, 338);
            this.btnT3_OnOff.Name = "btnT3_OnOff";
            this.btnT3_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnT3_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT3_OnOff.TabIndex = 62;
            this.btnT3_OnOff.TabStop = false;
            this.btnT3_OnOff.EnabledChanged += new System.EventHandler(this.btnT3_OnOff_EnabledChanged);
            this.btnT3_OnOff.Click += new System.EventHandler(this.btnT3_OnOff_Click);
            this.btnT3_OnOff.MouseEnter += new System.EventHandler(this.btnT0_OnOff_MouseEnter);
            this.btnT3_OnOff.MouseLeave += new System.EventHandler(this.btnT0_OnOff_MouseLeave);
            // 
            // btnT2_OnOff
            // 
            this.btnT2_OnOff.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.btnT2_OnOff.Location = new System.Drawing.Point(262, 338);
            this.btnT2_OnOff.Name = "btnT2_OnOff";
            this.btnT2_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnT2_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT2_OnOff.TabIndex = 61;
            this.btnT2_OnOff.TabStop = false;
            this.btnT2_OnOff.EnabledChanged += new System.EventHandler(this.btnT2_OnOff_EnabledChanged);
            this.btnT2_OnOff.Click += new System.EventHandler(this.btnT2_OnOff_Click);
            this.btnT2_OnOff.MouseEnter += new System.EventHandler(this.btnT0_OnOff_MouseEnter);
            this.btnT2_OnOff.MouseLeave += new System.EventHandler(this.btnT0_OnOff_MouseLeave);
            // 
            // btnT1_OnOff
            // 
            this.btnT1_OnOff.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.btnT1_OnOff.Location = new System.Drawing.Point(196, 338);
            this.btnT1_OnOff.Name = "btnT1_OnOff";
            this.btnT1_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnT1_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT1_OnOff.TabIndex = 60;
            this.btnT1_OnOff.TabStop = false;
            this.btnT1_OnOff.EnabledChanged += new System.EventHandler(this.btnT1_OnOff_EnabledChanged);
            this.btnT1_OnOff.Click += new System.EventHandler(this.btnT1_OnOff_Click);
            this.btnT1_OnOff.MouseEnter += new System.EventHandler(this.btnT0_OnOff_MouseEnter);
            this.btnT1_OnOff.MouseLeave += new System.EventHandler(this.btnT0_OnOff_MouseLeave);
            // 
            // btnT0_OnOff
            // 
            this.btnT0_OnOff.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.btnT0_OnOff.Location = new System.Drawing.Point(130, 338);
            this.btnT0_OnOff.Name = "btnT0_OnOff";
            this.btnT0_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnT0_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT0_OnOff.TabIndex = 59;
            this.btnT0_OnOff.TabStop = false;
            this.btnT0_OnOff.EnabledChanged += new System.EventHandler(this.btnT0_OnOff_EnabledChanged);
            this.btnT0_OnOff.Click += new System.EventHandler(this.btnT0_OnOff_Click);
            this.btnT0_OnOff.MouseEnter += new System.EventHandler(this.btnT0_OnOff_MouseEnter);
            this.btnT0_OnOff.MouseLeave += new System.EventHandler(this.btnT0_OnOff_MouseLeave);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnManualGcodeSend);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.txtManualGcode);
            this.groupBox5.Location = new System.Drawing.Point(90, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(457, 46);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manuelle Befehle";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(16, 22);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(43, 13);
            this.label41.TabIndex = 2;
            this.label41.Text = "G-Code";
            // 
            // txtManualGcode
            // 
            this.txtManualGcode.Location = new System.Drawing.Point(65, 19);
            this.txtManualGcode.Name = "txtManualGcode";
            this.txtManualGcode.Size = new System.Drawing.Size(316, 20);
            this.txtManualGcode.TabIndex = 0;
            this.txtManualGcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtManualGcode_KeyDown);
            // 
            // Filament
            // 
            this.Filament.BackColor = System.Drawing.Color.White;
            this.Filament.Controls.Add(this.groupBox6);
            this.Filament.Controls.Add(this.FilamentWechseln);
            this.Filament.Controls.Add(this.filamentUberwachung);
            this.Filament.Location = new System.Drawing.Point(44, 4);
            this.Filament.Name = "Filament";
            this.Filament.Size = new System.Drawing.Size(570, 526);
            this.Filament.TabIndex = 3;
            this.Filament.Text = "Filament";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnActivate);
            this.groupBox6.Controls.Add(this.btnDeactivate);
            this.groupBox6.Controls.Add(this.NozzleSizeKal);
            this.groupBox6.Controls.Add(this.backupT2furT3);
            this.groupBox6.Controls.Add(this.backupT0furT3);
            this.groupBox6.Controls.Add(this.label49);
            this.groupBox6.Controls.Add(this.backupT1furT3);
            this.groupBox6.Controls.Add(this.backupT3furT2);
            this.groupBox6.Controls.Add(this.backupT0furT2);
            this.groupBox6.Controls.Add(this.label48);
            this.groupBox6.Controls.Add(this.backupT1furT2);
            this.groupBox6.Controls.Add(this.backupT3furT1);
            this.groupBox6.Controls.Add(this.backupT2furT1);
            this.groupBox6.Controls.Add(this.label45);
            this.groupBox6.Controls.Add(this.backupT0furT1);
            this.groupBox6.Controls.Add(this.backupT3furT0);
            this.groupBox6.Controls.Add(this.backupT2furT0);
            this.groupBox6.Controls.Add(this.label44);
            this.groupBox6.Controls.Add(this.label36);
            this.groupBox6.Controls.Add(this.label31);
            this.groupBox6.Controls.Add(this.label22);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.backupT1furT0);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(301, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(259, 487);
            this.groupBox6.TabIndex = 126;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Endless Druck";
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(140, 435);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(102, 31);
            this.btnDeactivate.TabIndex = 22;
            this.btnDeactivate.Text = "Deactivate";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.btnDeactivate_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(22, 435);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(102, 31);
            this.btnActivate.TabIndex = 21;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // NozzleSizeKal
            // 
            this.NozzleSizeKal.Controls.Add(this.label5);
            this.NozzleSizeKal.Controls.Add(this.label6);
            this.NozzleSizeKal.Controls.Add(this.label4);
            this.NozzleSizeKal.Controls.Add(this.label3);
            this.NozzleSizeKal.Controls.Add(this.BtnNozzleSizeSave);
            this.NozzleSizeKal.Controls.Add(this.textT0NozzleSize);
            this.NozzleSizeKal.Controls.Add(this.textT2NozzleSize);
            this.NozzleSizeKal.Controls.Add(this.textT1NozzleSize);
            this.NozzleSizeKal.Controls.Add(this.textT3NozzleSize);
            this.NozzleSizeKal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NozzleSizeKal.Location = new System.Drawing.Point(0, 32);
            this.NozzleSizeKal.Name = "NozzleSizeKal";
            this.NozzleSizeKal.Size = new System.Drawing.Size(259, 157);
            this.NozzleSizeKal.TabIndex = 124;
            this.NozzleSizeKal.TabStop = false;
            this.NozzleSizeKal.Text = "Nozze Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(165, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 128;
            this.label5.Text = "T3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 127;
            this.label6.Text = "T2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(165, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 126;
            this.label4.Text = "T1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 125;
            this.label3.Text = "T0";
            // 
            // BtnNozzleSizeSave
            // 
            this.BtnNozzleSizeSave.Location = new System.Drawing.Point(78, 120);
            this.BtnNozzleSizeSave.Name = "BtnNozzleSizeSave";
            this.BtnNozzleSizeSave.Size = new System.Drawing.Size(75, 23);
            this.BtnNozzleSizeSave.TabIndex = 124;
            this.BtnNozzleSizeSave.Text = "Save";
            this.BtnNozzleSizeSave.UseVisualStyleBackColor = true;
            this.BtnNozzleSizeSave.Click += new System.EventHandler(this.BtnNozzleSizeSave_Click);
            // 
            // textT0NozzleSize
            // 
            this.textT0NozzleSize.Location = new System.Drawing.Point(22, 38);
            this.textT0NozzleSize.Name = "textT0NozzleSize";
            this.textT0NozzleSize.Size = new System.Drawing.Size(61, 20);
            this.textT0NozzleSize.TabIndex = 120;
            this.textT0NozzleSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textT1NozzleSize_KeyPress);
            // 
            // textT2NozzleSize
            // 
            this.textT2NozzleSize.Location = new System.Drawing.Point(22, 87);
            this.textT2NozzleSize.Name = "textT2NozzleSize";
            this.textT2NozzleSize.Size = new System.Drawing.Size(61, 20);
            this.textT2NozzleSize.TabIndex = 123;
            this.textT2NozzleSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textT1NozzleSize_KeyPress);
            // 
            // textT1NozzleSize
            // 
            this.textT1NozzleSize.Location = new System.Drawing.Point(147, 38);
            this.textT1NozzleSize.Name = "textT1NozzleSize";
            this.textT1NozzleSize.Size = new System.Drawing.Size(61, 20);
            this.textT1NozzleSize.TabIndex = 121;
            this.textT1NozzleSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textT1NozzleSize_KeyPress);
            // 
            // textT3NozzleSize
            // 
            this.textT3NozzleSize.Location = new System.Drawing.Point(147, 87);
            this.textT3NozzleSize.Name = "textT3NozzleSize";
            this.textT3NozzleSize.Size = new System.Drawing.Size(61, 20);
            this.textT3NozzleSize.TabIndex = 122;
            this.textT3NozzleSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textT1NozzleSize_KeyPress);
            // 
            // backupT2furT3
            // 
            this.backupT2furT3.AutoSize = true;
            this.backupT2furT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT2furT3.Location = new System.Drawing.Point(185, 382);
            this.backupT2furT3.Name = "backupT2furT3";
            this.backupT2furT3.Size = new System.Drawing.Size(15, 14);
            this.backupT2furT3.TabIndex = 20;
            this.backupT2furT3.UseVisualStyleBackColor = true;
            this.backupT2furT3.CheckedChanged += new System.EventHandler(this.backupT2furT3_CheckedChanged);
            // 
            // backupT0furT3
            // 
            this.backupT0furT3.AutoSize = true;
            this.backupT0furT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT0furT3.Location = new System.Drawing.Point(101, 382);
            this.backupT0furT3.Name = "backupT0furT3";
            this.backupT0furT3.Size = new System.Drawing.Size(15, 14);
            this.backupT0furT3.TabIndex = 19;
            this.backupT0furT3.UseVisualStyleBackColor = true;
            this.backupT0furT3.CheckedChanged += new System.EventHandler(this.backupT0furT3_CheckedChanged);
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(6, 380);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(82, 15);
            this.label49.TabIndex = 18;
            this.label49.Text = "Backup für T3";
            // 
            // backupT1furT3
            // 
            this.backupT1furT3.AutoSize = true;
            this.backupT1furT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT1furT3.Location = new System.Drawing.Point(143, 382);
            this.backupT1furT3.Name = "backupT1furT3";
            this.backupT1furT3.Size = new System.Drawing.Size(15, 14);
            this.backupT1furT3.TabIndex = 17;
            this.backupT1furT3.UseVisualStyleBackColor = true;
            this.backupT1furT3.CheckedChanged += new System.EventHandler(this.backupT1furT3_CheckedChanged);
            // 
            // backupT3furT2
            // 
            this.backupT3furT2.AutoSize = true;
            this.backupT3furT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT3furT2.Location = new System.Drawing.Point(227, 347);
            this.backupT3furT2.Name = "backupT3furT2";
            this.backupT3furT2.Size = new System.Drawing.Size(15, 14);
            this.backupT3furT2.TabIndex = 16;
            this.backupT3furT2.UseVisualStyleBackColor = true;
            this.backupT3furT2.CheckedChanged += new System.EventHandler(this.backupT3furT2_CheckedChanged);
            // 
            // backupT0furT2
            // 
            this.backupT0furT2.AutoSize = true;
            this.backupT0furT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT0furT2.Location = new System.Drawing.Point(101, 347);
            this.backupT0furT2.Name = "backupT0furT2";
            this.backupT0furT2.Size = new System.Drawing.Size(15, 14);
            this.backupT0furT2.TabIndex = 15;
            this.backupT0furT2.UseVisualStyleBackColor = true;
            this.backupT0furT2.CheckedChanged += new System.EventHandler(this.backupT0furT2_CheckedChanged);
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(6, 345);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(82, 15);
            this.label48.TabIndex = 14;
            this.label48.Text = "Backup für T2";
            // 
            // backupT1furT2
            // 
            this.backupT1furT2.AutoSize = true;
            this.backupT1furT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT1furT2.Location = new System.Drawing.Point(143, 347);
            this.backupT1furT2.Name = "backupT1furT2";
            this.backupT1furT2.Size = new System.Drawing.Size(15, 14);
            this.backupT1furT2.TabIndex = 13;
            this.backupT1furT2.UseVisualStyleBackColor = true;
            this.backupT1furT2.CheckedChanged += new System.EventHandler(this.backupT1furT2_CheckedChanged);
            // 
            // backupT3furT1
            // 
            this.backupT3furT1.AutoSize = true;
            this.backupT3furT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT3furT1.Location = new System.Drawing.Point(227, 312);
            this.backupT3furT1.Name = "backupT3furT1";
            this.backupT3furT1.Size = new System.Drawing.Size(15, 14);
            this.backupT3furT1.TabIndex = 12;
            this.backupT3furT1.UseVisualStyleBackColor = true;
            this.backupT3furT1.CheckedChanged += new System.EventHandler(this.backupT3furT1_CheckedChanged);
            // 
            // backupT2furT1
            // 
            this.backupT2furT1.AutoSize = true;
            this.backupT2furT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT2furT1.Location = new System.Drawing.Point(185, 312);
            this.backupT2furT1.Name = "backupT2furT1";
            this.backupT2furT1.Size = new System.Drawing.Size(15, 14);
            this.backupT2furT1.TabIndex = 11;
            this.backupT2furT1.UseVisualStyleBackColor = true;
            this.backupT2furT1.CheckedChanged += new System.EventHandler(this.backupT2furT1_CheckedChanged);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(6, 310);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(82, 15);
            this.label45.TabIndex = 10;
            this.label45.Text = "Backup für T1";
            // 
            // backupT0furT1
            // 
            this.backupT0furT1.AutoSize = true;
            this.backupT0furT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT0furT1.Location = new System.Drawing.Point(101, 312);
            this.backupT0furT1.Name = "backupT0furT1";
            this.backupT0furT1.Size = new System.Drawing.Size(15, 14);
            this.backupT0furT1.TabIndex = 9;
            this.backupT0furT1.UseVisualStyleBackColor = true;
            this.backupT0furT1.CheckedChanged += new System.EventHandler(this.backupT0furT1_CheckedChanged);
            // 
            // backupT3furT0
            // 
            this.backupT3furT0.AutoSize = true;
            this.backupT3furT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT3furT0.Location = new System.Drawing.Point(227, 278);
            this.backupT3furT0.Name = "backupT3furT0";
            this.backupT3furT0.Size = new System.Drawing.Size(15, 14);
            this.backupT3furT0.TabIndex = 8;
            this.backupT3furT0.UseVisualStyleBackColor = true;
            this.backupT3furT0.CheckedChanged += new System.EventHandler(this.backupT3furT0_CheckedChanged);
            // 
            // backupT2furT0
            // 
            this.backupT2furT0.AutoSize = true;
            this.backupT2furT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT2furT0.Location = new System.Drawing.Point(185, 278);
            this.backupT2furT0.Name = "backupT2furT0";
            this.backupT2furT0.Size = new System.Drawing.Size(15, 14);
            this.backupT2furT0.TabIndex = 7;
            this.backupT2furT0.UseVisualStyleBackColor = true;
            this.backupT2furT0.CheckedChanged += new System.EventHandler(this.backupT2furT0_CheckedChanged);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(6, 276);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(82, 15);
            this.label44.TabIndex = 6;
            this.label44.Text = "Backup für T0";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(224, 250);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(21, 15);
            this.label36.TabIndex = 5;
            this.label36.Text = "T3";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(182, 250);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(21, 15);
            this.label31.TabIndex = 4;
            this.label31.Text = "T2";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(140, 250);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 15);
            this.label22.TabIndex = 3;
            this.label22.Text = "T1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(98, 250);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 15);
            this.label21.TabIndex = 2;
            this.label21.Text = "T0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 250);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(36, 15);
            this.label20.TabIndex = 1;
            this.label20.Text = "Düse";
            // 
            // backupT1furT0
            // 
            this.backupT1furT0.AutoSize = true;
            this.backupT1furT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backupT1furT0.Location = new System.Drawing.Point(143, 278);
            this.backupT1furT0.Name = "backupT1furT0";
            this.backupT1furT0.Size = new System.Drawing.Size(15, 14);
            this.backupT1furT0.TabIndex = 0;
            this.backupT1furT0.UseVisualStyleBackColor = true;
            this.backupT1furT0.CheckedChanged += new System.EventHandler(this.backupT1furT0_CheckedChanged);
            // 
            // FilamentWechseln
            // 
            this.FilamentWechseln.Controls.Add(this.lblFilamentChangeTemp);
            this.FilamentWechseln.Controls.Add(this.btnLoadT0);
            this.FilamentWechseln.Controls.Add(this.lblRetractLoadFilT3);
            this.FilamentWechseln.Controls.Add(this.label10);
            this.FilamentWechseln.Controls.Add(this.lblRetractLoadFilT2);
            this.FilamentWechseln.Controls.Add(this.lblRetractLoadFilT0);
            this.FilamentWechseln.Controls.Add(this.btnLoadT3);
            this.FilamentWechseln.Controls.Add(this.btnRetractT0);
            this.FilamentWechseln.Controls.Add(this.lblRetractLoadFilT1);
            this.FilamentWechseln.Controls.Add(this.btnRetractT3);
            this.FilamentWechseln.Controls.Add(this.btnLoadT1);
            this.FilamentWechseln.Controls.Add(this.btnLoadT2);
            this.FilamentWechseln.Controls.Add(this.label9);
            this.FilamentWechseln.Controls.Add(this.btnRetractT1);
            this.FilamentWechseln.Controls.Add(this.txtBoxTemp);
            this.FilamentWechseln.Controls.Add(this.btnRetractT2);
            this.FilamentWechseln.Controls.Add(this.lblT0);
            this.FilamentWechseln.Controls.Add(this.lblT1);
            this.FilamentWechseln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilamentWechseln.Location = new System.Drawing.Point(3, 222);
            this.FilamentWechseln.Name = "FilamentWechseln";
            this.FilamentWechseln.Size = new System.Drawing.Size(289, 275);
            this.FilamentWechseln.TabIndex = 125;
            this.FilamentWechseln.TabStop = false;
            this.FilamentWechseln.Text = "Filament Wechseln";
            // 
            // lblFilamentChangeTemp
            // 
            this.lblFilamentChangeTemp.AutoSize = true;
            this.lblFilamentChangeTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentChangeTemp.Location = new System.Drawing.Point(7, 31);
            this.lblFilamentChangeTemp.Name = "lblFilamentChangeTemp";
            this.lblFilamentChangeTemp.Size = new System.Drawing.Size(137, 18);
            this.lblFilamentChangeTemp.TabIndex = 93;
            this.lblFilamentChangeTemp.Text = "Wechseltemperatur";
            // 
            // lblRetractLoadFilT3
            // 
            this.lblRetractLoadFilT3.AutoSize = true;
            this.lblRetractLoadFilT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetractLoadFilT3.Location = new System.Drawing.Point(47, 252);
            this.lblRetractLoadFilT3.Name = "lblRetractLoadFilT3";
            this.lblRetractLoadFilT3.Size = new System.Drawing.Size(39, 15);
            this.lblRetractLoadFilT3.TabIndex = 109;
            this.lblRetractLoadFilT3.Text = "NULL";
            this.lblRetractLoadFilT3.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 25);
            this.label10.TabIndex = 104;
            this.label10.Text = "T3";
            // 
            // lblRetractLoadFilT2
            // 
            this.lblRetractLoadFilT2.AutoSize = true;
            this.lblRetractLoadFilT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetractLoadFilT2.Location = new System.Drawing.Point(47, 199);
            this.lblRetractLoadFilT2.Name = "lblRetractLoadFilT2";
            this.lblRetractLoadFilT2.Size = new System.Drawing.Size(39, 15);
            this.lblRetractLoadFilT2.TabIndex = 110;
            this.lblRetractLoadFilT2.Text = "NULL";
            this.lblRetractLoadFilT2.Visible = false;
            // 
            // lblRetractLoadFilT0
            // 
            this.lblRetractLoadFilT0.AutoSize = true;
            this.lblRetractLoadFilT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetractLoadFilT0.Location = new System.Drawing.Point(47, 93);
            this.lblRetractLoadFilT0.Name = "lblRetractLoadFilT0";
            this.lblRetractLoadFilT0.Size = new System.Drawing.Size(39, 15);
            this.lblRetractLoadFilT0.TabIndex = 111;
            this.lblRetractLoadFilT0.Text = "NULL";
            this.lblRetractLoadFilT0.Visible = false;
            // 
            // lblRetractLoadFilT1
            // 
            this.lblRetractLoadFilT1.AutoSize = true;
            this.lblRetractLoadFilT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetractLoadFilT1.Location = new System.Drawing.Point(47, 146);
            this.lblRetractLoadFilT1.Name = "lblRetractLoadFilT1";
            this.lblRetractLoadFilT1.Size = new System.Drawing.Size(39, 15);
            this.lblRetractLoadFilT1.TabIndex = 108;
            this.lblRetractLoadFilT1.Text = "NULL";
            this.lblRetractLoadFilT1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 101;
            this.label9.Text = "T2";
            // 
            // txtBoxTemp
            // 
            this.txtBoxTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTemp.Location = new System.Drawing.Point(146, 27);
            this.txtBoxTemp.Name = "txtBoxTemp";
            this.txtBoxTemp.Size = new System.Drawing.Size(84, 26);
            this.txtBoxTemp.TabIndex = 94;
            this.txtBoxTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxTemp_KeyPress);
            // 
            // lblT0
            // 
            this.lblT0.AutoSize = true;
            this.lblT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT0.Location = new System.Drawing.Point(5, 59);
            this.lblT0.Name = "lblT0";
            this.lblT0.Size = new System.Drawing.Size(37, 25);
            this.lblT0.TabIndex = 96;
            this.lblT0.Text = "T0";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT1.Location = new System.Drawing.Point(5, 112);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(37, 25);
            this.lblT1.TabIndex = 98;
            this.lblT1.Text = "T1";
            // 
            // filamentUberwachung
            // 
            this.filamentUberwachung.Controls.Add(this.btnFilAktualise);
            this.filamentUberwachung.Controls.Add(this.lblT3_1);
            this.filamentUberwachung.Controls.Add(this.lblT2_1);
            this.filamentUberwachung.Controls.Add(this.label47);
            this.filamentUberwachung.Controls.Add(this.label46);
            this.filamentUberwachung.Controls.Add(this.lblFilamentT3);
            this.filamentUberwachung.Controls.Add(this.lblFilamentT2);
            this.filamentUberwachung.Controls.Add(this.lblFilamentT0);
            this.filamentUberwachung.Controls.Add(this.lblFilamentT1);
            this.filamentUberwachung.Controls.Add(this.lblFilamentStatus);
            this.filamentUberwachung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filamentUberwachung.Location = new System.Drawing.Point(3, 10);
            this.filamentUberwachung.Name = "filamentUberwachung";
            this.filamentUberwachung.Size = new System.Drawing.Size(289, 206);
            this.filamentUberwachung.TabIndex = 92;
            this.filamentUberwachung.TabStop = false;
            this.filamentUberwachung.Text = "Filament Überwachung";
            // 
            // lblT3_1
            // 
            this.lblT3_1.AutoSize = true;
            this.lblT3_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3_1.Location = new System.Drawing.Point(4, 173);
            this.lblT3_1.Name = "lblT3_1";
            this.lblT3_1.Size = new System.Drawing.Size(24, 16);
            this.lblT3_1.TabIndex = 9;
            this.lblT3_1.Text = "T3";
            // 
            // lblT2_1
            // 
            this.lblT2_1.AutoSize = true;
            this.lblT2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2_1.Location = new System.Drawing.Point(4, 139);
            this.lblT2_1.Name = "lblT2_1";
            this.lblT2_1.Size = new System.Drawing.Size(24, 16);
            this.lblT2_1.TabIndex = 8;
            this.lblT2_1.Text = "T2";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(4, 104);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(24, 16);
            this.label47.TabIndex = 7;
            this.label47.Text = "T1";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(4, 69);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(24, 16);
            this.label46.TabIndex = 6;
            this.label46.Text = "T0";
            // 
            // lblFilamentT3
            // 
            this.lblFilamentT3.AutoSize = true;
            this.lblFilamentT3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentT3.Location = new System.Drawing.Point(31, 167);
            this.lblFilamentT3.Name = "lblFilamentT3";
            this.lblFilamentT3.Size = new System.Drawing.Size(52, 22);
            this.lblFilamentT3.TabIndex = 5;
            this.lblFilamentT3.Text = "NULL";
            // 
            // lblFilamentT2
            // 
            this.lblFilamentT2.AutoSize = true;
            this.lblFilamentT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentT2.Location = new System.Drawing.Point(31, 133);
            this.lblFilamentT2.Name = "lblFilamentT2";
            this.lblFilamentT2.Size = new System.Drawing.Size(52, 22);
            this.lblFilamentT2.TabIndex = 4;
            this.lblFilamentT2.Text = "NULL";
            // 
            // lblFilamentT0
            // 
            this.lblFilamentT0.AutoSize = true;
            this.lblFilamentT0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentT0.Location = new System.Drawing.Point(31, 63);
            this.lblFilamentT0.Name = "lblFilamentT0";
            this.lblFilamentT0.Size = new System.Drawing.Size(52, 22);
            this.lblFilamentT0.TabIndex = 3;
            this.lblFilamentT0.Text = "NULL";
            // 
            // lblFilamentT1
            // 
            this.lblFilamentT1.AutoSize = true;
            this.lblFilamentT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentT1.Location = new System.Drawing.Point(31, 98);
            this.lblFilamentT1.Name = "lblFilamentT1";
            this.lblFilamentT1.Size = new System.Drawing.Size(52, 22);
            this.lblFilamentT1.TabIndex = 2;
            this.lblFilamentT1.Text = "NULL";
            // 
            // lblFilamentStatus
            // 
            this.lblFilamentStatus.AutoSize = true;
            this.lblFilamentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentStatus.Location = new System.Drawing.Point(31, 27);
            this.lblFilamentStatus.Name = "lblFilamentStatus";
            this.lblFilamentStatus.Size = new System.Drawing.Size(52, 22);
            this.lblFilamentStatus.TabIndex = 0;
            this.lblFilamentStatus.Text = "NULL";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.VersionLabel);
            this.tabPage1.Controls.Add(this.lblDV);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.LblMoveCoverOffset);
            this.tabPage1.Controls.Add(this.lblParkPosition);
            this.tabPage1.Controls.Add(this.lblReinigungsschwelle);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.lblRotOffsetFilament);
            this.tabPage1.Controls.Add(this.lblWhen4Move);
            this.tabPage1.Controls.Add(this.lblZKorrektur);
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.lblDisatance);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.lblOptimalDistance);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.lblRotationalOffset);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.lblKgSrvcT3);
            this.tabPage1.Controls.Add(this.lblKgSrvcT2);
            this.tabPage1.Controls.Add(this.lblKgSrvcT1);
            this.tabPage1.Controls.Add(this.lblKgSrvcT0);
            this.tabPage1.Controls.Add(this.lblHeatedSrvcT3);
            this.tabPage1.Controls.Add(this.lblHeatedSrvcT2);
            this.tabPage1.Controls.Add(this.lblHeatedSrvcT1);
            this.tabPage1.Controls.Add(this.lblHeatedSrvcT0);
            this.tabPage1.Controls.Add(this.lblExtrudedSrvcT3);
            this.tabPage1.Controls.Add(this.lblExtrudedSrvcT2);
            this.tabPage1.Controls.Add(this.lblExtrudedSrvcT1);
            this.tabPage1.Controls.Add(this.lblExtrudedSrvcT0);
            this.tabPage1.Controls.Add(this.lblSrvcDistanceZ);
            this.tabPage1.Controls.Add(this.lblSrvcDistanceY);
            this.tabPage1.Controls.Add(this.lblSrvcDistanceX);
            this.tabPage1.Controls.Add(this.lblSrvcPrntLife);
            this.tabPage1.Controls.Add(this.lblSrvcPwrON);
            this.tabPage1.Controls.Add(this.lblSrvcPwrCycle);
            this.tabPage1.Controls.Add(this.label70);
            this.tabPage1.Controls.Add(this.lblKgTotalT3);
            this.tabPage1.Controls.Add(this.lblKgTotalT2);
            this.tabPage1.Controls.Add(this.lblKgTotalT1);
            this.tabPage1.Controls.Add(this.lblKgTotalT0);
            this.tabPage1.Controls.Add(this.lblT3_3);
            this.tabPage1.Controls.Add(this.lblT2_3);
            this.tabPage1.Controls.Add(this.label61);
            this.tabPage1.Controls.Add(this.label62);
            this.tabPage1.Controls.Add(this.lblHeatedTotalT3);
            this.tabPage1.Controls.Add(this.lblHeatedTotalT2);
            this.tabPage1.Controls.Add(this.lblHeatedTotalT1);
            this.tabPage1.Controls.Add(this.lblHeatedTotalT0);
            this.tabPage1.Controls.Add(this.lblExtrudedTotalT3);
            this.tabPage1.Controls.Add(this.lblExtrudedTotalT2);
            this.tabPage1.Controls.Add(this.lblExtrudedTotalT1);
            this.tabPage1.Controls.Add(this.lblExtrudedTotalT0);
            this.tabPage1.Controls.Add(this.lblTotalDistanceZ);
            this.tabPage1.Controls.Add(this.lblTotalDistanceY);
            this.tabPage1.Controls.Add(this.lblTotalDistanceX);
            this.tabPage1.Controls.Add(this.lblTotalPrntLife);
            this.tabPage1.Controls.Add(this.lblTotalPwrON);
            this.tabPage1.Controls.Add(this.lblTotalPwrCycle);
            this.tabPage1.Controls.Add(this.label54);
            this.tabPage1.Controls.Add(this.lblAbstandT3);
            this.tabPage1.Controls.Add(this.lblAbstandT2);
            this.tabPage1.Controls.Add(this.lblAbstandT1);
            this.tabPage1.Controls.Add(this.lblAbstandT0);
            this.tabPage1.Controls.Add(this.lblFirmware);
            this.tabPage1.Controls.Add(this.lblT3_4);
            this.tabPage1.Controls.Add(this.lblT2_4);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.lblT3_2);
            this.tabPage1.Controls.Add(this.lblT2_2);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.lblT3_5);
            this.tabPage1.Controls.Add(this.lblT2_5);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.btnInfoAktualise);
            this.tabPage1.Location = new System.Drawing.Point(44, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 526);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Information";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.BackColor = System.Drawing.Color.White;
            this.VersionLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VersionLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.VersionLabel.Location = new System.Drawing.Point(472, 512);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(97, 13);
            this.VersionLabel.TabIndex = 126;
            this.VersionLabel.Text = "Version: V1.0.1";
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.BackColor = System.Drawing.Color.White;
            this.lblDV.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDV.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDV.Location = new System.Drawing.Point(246, 181);
            this.lblDV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(31, 13);
            this.lblDV.TabIndex = 125;
            this.lblDV.Text = "NULL";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.White;
            this.label32.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label32.Location = new System.Drawing.Point(131, 181);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(97, 13);
            this.label32.TabIndex = 124;
            this.label32.Text = "Düsenvermessung";
            // 
            // LblMoveCoverOffset
            // 
            this.LblMoveCoverOffset.AutoSize = true;
            this.LblMoveCoverOffset.BackColor = System.Drawing.Color.White;
            this.LblMoveCoverOffset.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMoveCoverOffset.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LblMoveCoverOffset.Location = new System.Drawing.Point(246, 168);
            this.LblMoveCoverOffset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMoveCoverOffset.Name = "LblMoveCoverOffset";
            this.LblMoveCoverOffset.Size = new System.Drawing.Size(31, 13);
            this.LblMoveCoverOffset.TabIndex = 123;
            this.LblMoveCoverOffset.Text = "NULL";
            // 
            // lblParkPosition
            // 
            this.lblParkPosition.AutoSize = true;
            this.lblParkPosition.BackColor = System.Drawing.Color.White;
            this.lblParkPosition.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkPosition.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblParkPosition.Location = new System.Drawing.Point(119, 168);
            this.lblParkPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblParkPosition.Name = "lblParkPosition";
            this.lblParkPosition.Size = new System.Drawing.Size(109, 13);
            this.lblParkPosition.TabIndex = 122;
            this.lblParkPosition.Text = "Move Parkposition";
            // 
            // lblReinigungsschwelle
            // 
            this.lblReinigungsschwelle.AutoSize = true;
            this.lblReinigungsschwelle.BackColor = System.Drawing.Color.White;
            this.lblReinigungsschwelle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReinigungsschwelle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblReinigungsschwelle.Location = new System.Drawing.Point(246, 155);
            this.lblReinigungsschwelle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReinigungsschwelle.Name = "lblReinigungsschwelle";
            this.lblReinigungsschwelle.Size = new System.Drawing.Size(31, 13);
            this.lblReinigungsschwelle.TabIndex = 121;
            this.lblReinigungsschwelle.Text = "NULL";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.Color.White;
            this.label35.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label35.Location = new System.Drawing.Point(5, 155);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(223, 13);
            this.label35.TabIndex = 120;
            this.label35.Text = "Reinigungsschwelle inakt. Düse (sec)";
            // 
            // lblRotOffsetFilament
            // 
            this.lblRotOffsetFilament.AutoSize = true;
            this.lblRotOffsetFilament.BackColor = System.Drawing.Color.White;
            this.lblRotOffsetFilament.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotOffsetFilament.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRotOffsetFilament.Location = new System.Drawing.Point(461, 88);
            this.lblRotOffsetFilament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotOffsetFilament.Name = "lblRotOffsetFilament";
            this.lblRotOffsetFilament.Size = new System.Drawing.Size(31, 13);
            this.lblRotOffsetFilament.TabIndex = 118;
            this.lblRotOffsetFilament.Text = "NULL";
            // 
            // lblWhen4Move
            // 
            this.lblWhen4Move.AutoSize = true;
            this.lblWhen4Move.BackColor = System.Drawing.Color.White;
            this.lblWhen4Move.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhen4Move.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblWhen4Move.Location = new System.Drawing.Point(204, 88);
            this.lblWhen4Move.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhen4Move.Name = "lblWhen4Move";
            this.lblWhen4Move.Size = new System.Drawing.Size(229, 13);
            this.lblWhen4Move.TabIndex = 117;
            this.lblWhen4Move.Text = "Rotations-Offset Filamentauswahl (mm)";
            // 
            // lblZKorrektur
            // 
            this.lblZKorrektur.AutoSize = true;
            this.lblZKorrektur.BackColor = System.Drawing.Color.White;
            this.lblZKorrektur.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZKorrektur.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblZKorrektur.Location = new System.Drawing.Point(461, 133);
            this.lblZKorrektur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZKorrektur.Name = "lblZKorrektur";
            this.lblZKorrektur.Size = new System.Drawing.Size(31, 13);
            this.lblZKorrektur.TabIndex = 116;
            this.lblZKorrektur.Text = "NULL";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.White;
            this.label43.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label43.Location = new System.Drawing.Point(330, 133);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(103, 13);
            this.label43.TabIndex = 115;
            this.label43.Text = "Z-Korrektur (mm)";
            // 
            // lblDisatance
            // 
            this.lblDisatance.AutoSize = true;
            this.lblDisatance.BackColor = System.Drawing.Color.White;
            this.lblDisatance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisatance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDisatance.Location = new System.Drawing.Point(461, 103);
            this.lblDisatance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisatance.Name = "lblDisatance";
            this.lblDisatance.Size = new System.Drawing.Size(31, 13);
            this.lblDisatance.TabIndex = 114;
            this.lblDisatance.Text = "NULL";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.White;
            this.label40.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label40.Location = new System.Drawing.Point(246, 103);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(187, 13);
            this.label40.TabIndex = 113;
            this.label40.Text = "Distanz T0 <-> Multisense (mm)";
            // 
            // lblOptimalDistance
            // 
            this.lblOptimalDistance.AutoSize = true;
            this.lblOptimalDistance.BackColor = System.Drawing.Color.White;
            this.lblOptimalDistance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptimalDistance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOptimalDistance.Location = new System.Drawing.Point(461, 118);
            this.lblOptimalDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOptimalDistance.Name = "lblOptimalDistance";
            this.lblOptimalDistance.Size = new System.Drawing.Size(31, 13);
            this.lblOptimalDistance.TabIndex = 112;
            this.lblOptimalDistance.Text = "NULL";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.White;
            this.label42.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label42.Location = new System.Drawing.Point(192, 118);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(241, 13);
            this.label42.TabIndex = 111;
            this.label42.Text = "Optimale Distanz T0 <-> Multisense (mm)";
            // 
            // lblRotationalOffset
            // 
            this.lblRotationalOffset.AutoSize = true;
            this.lblRotationalOffset.BackColor = System.Drawing.Color.White;
            this.lblRotationalOffset.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotationalOffset.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRotationalOffset.Location = new System.Drawing.Point(461, 73);
            this.lblRotationalOffset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotationalOffset.Name = "lblRotationalOffset";
            this.lblRotationalOffset.Size = new System.Drawing.Size(31, 13);
            this.lblRotationalOffset.TabIndex = 110;
            this.lblRotationalOffset.Text = "NULL";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.White;
            this.label39.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label39.Location = new System.Drawing.Point(216, 73);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(217, 13);
            this.label39.TabIndex = 109;
            this.label39.Text = "Rotations-Offset Move Extruder (mm)";
            // 
            // lblKgSrvcT3
            // 
            this.lblKgSrvcT3.AutoSize = true;
            this.lblKgSrvcT3.BackColor = System.Drawing.Color.White;
            this.lblKgSrvcT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgSrvcT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgSrvcT3.Location = new System.Drawing.Point(372, 421);
            this.lblKgSrvcT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgSrvcT3.Name = "lblKgSrvcT3";
            this.lblKgSrvcT3.Size = new System.Drawing.Size(31, 13);
            this.lblKgSrvcT3.TabIndex = 108;
            this.lblKgSrvcT3.Text = "NULL";
            // 
            // lblKgSrvcT2
            // 
            this.lblKgSrvcT2.AutoSize = true;
            this.lblKgSrvcT2.BackColor = System.Drawing.Color.White;
            this.lblKgSrvcT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgSrvcT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgSrvcT2.Location = new System.Drawing.Point(372, 406);
            this.lblKgSrvcT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgSrvcT2.Name = "lblKgSrvcT2";
            this.lblKgSrvcT2.Size = new System.Drawing.Size(31, 13);
            this.lblKgSrvcT2.TabIndex = 107;
            this.lblKgSrvcT2.Text = "NULL";
            // 
            // lblKgSrvcT1
            // 
            this.lblKgSrvcT1.AutoSize = true;
            this.lblKgSrvcT1.BackColor = System.Drawing.Color.White;
            this.lblKgSrvcT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgSrvcT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgSrvcT1.Location = new System.Drawing.Point(372, 391);
            this.lblKgSrvcT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgSrvcT1.Name = "lblKgSrvcT1";
            this.lblKgSrvcT1.Size = new System.Drawing.Size(31, 13);
            this.lblKgSrvcT1.TabIndex = 106;
            this.lblKgSrvcT1.Text = "NULL";
            // 
            // lblKgSrvcT0
            // 
            this.lblKgSrvcT0.AutoSize = true;
            this.lblKgSrvcT0.BackColor = System.Drawing.Color.White;
            this.lblKgSrvcT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgSrvcT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgSrvcT0.Location = new System.Drawing.Point(372, 376);
            this.lblKgSrvcT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgSrvcT0.Name = "lblKgSrvcT0";
            this.lblKgSrvcT0.Size = new System.Drawing.Size(31, 13);
            this.lblKgSrvcT0.TabIndex = 105;
            this.lblKgSrvcT0.Text = "NULL";
            // 
            // lblHeatedSrvcT3
            // 
            this.lblHeatedSrvcT3.AutoSize = true;
            this.lblHeatedSrvcT3.BackColor = System.Drawing.Color.White;
            this.lblHeatedSrvcT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedSrvcT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedSrvcT3.Location = new System.Drawing.Point(372, 485);
            this.lblHeatedSrvcT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedSrvcT3.Name = "lblHeatedSrvcT3";
            this.lblHeatedSrvcT3.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedSrvcT3.TabIndex = 104;
            this.lblHeatedSrvcT3.Text = "NULL";
            // 
            // lblHeatedSrvcT2
            // 
            this.lblHeatedSrvcT2.AutoSize = true;
            this.lblHeatedSrvcT2.BackColor = System.Drawing.Color.White;
            this.lblHeatedSrvcT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedSrvcT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedSrvcT2.Location = new System.Drawing.Point(372, 470);
            this.lblHeatedSrvcT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedSrvcT2.Name = "lblHeatedSrvcT2";
            this.lblHeatedSrvcT2.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedSrvcT2.TabIndex = 103;
            this.lblHeatedSrvcT2.Text = "NULL";
            // 
            // lblHeatedSrvcT1
            // 
            this.lblHeatedSrvcT1.AutoSize = true;
            this.lblHeatedSrvcT1.BackColor = System.Drawing.Color.White;
            this.lblHeatedSrvcT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedSrvcT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedSrvcT1.Location = new System.Drawing.Point(372, 455);
            this.lblHeatedSrvcT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedSrvcT1.Name = "lblHeatedSrvcT1";
            this.lblHeatedSrvcT1.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedSrvcT1.TabIndex = 102;
            this.lblHeatedSrvcT1.Text = "NULL";
            // 
            // lblHeatedSrvcT0
            // 
            this.lblHeatedSrvcT0.AutoSize = true;
            this.lblHeatedSrvcT0.BackColor = System.Drawing.Color.White;
            this.lblHeatedSrvcT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedSrvcT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedSrvcT0.Location = new System.Drawing.Point(372, 440);
            this.lblHeatedSrvcT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedSrvcT0.Name = "lblHeatedSrvcT0";
            this.lblHeatedSrvcT0.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedSrvcT0.TabIndex = 101;
            this.lblHeatedSrvcT0.Text = "NULL";
            // 
            // lblExtrudedSrvcT3
            // 
            this.lblExtrudedSrvcT3.AutoSize = true;
            this.lblExtrudedSrvcT3.BackColor = System.Drawing.Color.White;
            this.lblExtrudedSrvcT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedSrvcT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedSrvcT3.Location = new System.Drawing.Point(372, 361);
            this.lblExtrudedSrvcT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedSrvcT3.Name = "lblExtrudedSrvcT3";
            this.lblExtrudedSrvcT3.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedSrvcT3.TabIndex = 100;
            this.lblExtrudedSrvcT3.Text = "NULL";
            // 
            // lblExtrudedSrvcT2
            // 
            this.lblExtrudedSrvcT2.AutoSize = true;
            this.lblExtrudedSrvcT2.BackColor = System.Drawing.Color.White;
            this.lblExtrudedSrvcT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedSrvcT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedSrvcT2.Location = new System.Drawing.Point(372, 346);
            this.lblExtrudedSrvcT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedSrvcT2.Name = "lblExtrudedSrvcT2";
            this.lblExtrudedSrvcT2.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedSrvcT2.TabIndex = 99;
            this.lblExtrudedSrvcT2.Text = "NULL";
            // 
            // lblExtrudedSrvcT1
            // 
            this.lblExtrudedSrvcT1.AutoSize = true;
            this.lblExtrudedSrvcT1.BackColor = System.Drawing.Color.White;
            this.lblExtrudedSrvcT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedSrvcT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedSrvcT1.Location = new System.Drawing.Point(372, 331);
            this.lblExtrudedSrvcT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedSrvcT1.Name = "lblExtrudedSrvcT1";
            this.lblExtrudedSrvcT1.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedSrvcT1.TabIndex = 98;
            this.lblExtrudedSrvcT1.Text = "NULL";
            // 
            // lblExtrudedSrvcT0
            // 
            this.lblExtrudedSrvcT0.AutoSize = true;
            this.lblExtrudedSrvcT0.BackColor = System.Drawing.Color.White;
            this.lblExtrudedSrvcT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedSrvcT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedSrvcT0.Location = new System.Drawing.Point(372, 316);
            this.lblExtrudedSrvcT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedSrvcT0.Name = "lblExtrudedSrvcT0";
            this.lblExtrudedSrvcT0.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedSrvcT0.TabIndex = 97;
            this.lblExtrudedSrvcT0.Text = "NULL";
            // 
            // lblSrvcDistanceZ
            // 
            this.lblSrvcDistanceZ.AutoSize = true;
            this.lblSrvcDistanceZ.BackColor = System.Drawing.Color.White;
            this.lblSrvcDistanceZ.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcDistanceZ.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcDistanceZ.Location = new System.Drawing.Point(372, 295);
            this.lblSrvcDistanceZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcDistanceZ.Name = "lblSrvcDistanceZ";
            this.lblSrvcDistanceZ.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcDistanceZ.TabIndex = 96;
            this.lblSrvcDistanceZ.Text = "NULL";
            // 
            // lblSrvcDistanceY
            // 
            this.lblSrvcDistanceY.AutoSize = true;
            this.lblSrvcDistanceY.BackColor = System.Drawing.Color.White;
            this.lblSrvcDistanceY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcDistanceY.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcDistanceY.Location = new System.Drawing.Point(372, 281);
            this.lblSrvcDistanceY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcDistanceY.Name = "lblSrvcDistanceY";
            this.lblSrvcDistanceY.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcDistanceY.TabIndex = 95;
            this.lblSrvcDistanceY.Text = "NULL";
            // 
            // lblSrvcDistanceX
            // 
            this.lblSrvcDistanceX.AutoSize = true;
            this.lblSrvcDistanceX.BackColor = System.Drawing.Color.White;
            this.lblSrvcDistanceX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcDistanceX.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcDistanceX.Location = new System.Drawing.Point(372, 266);
            this.lblSrvcDistanceX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcDistanceX.Name = "lblSrvcDistanceX";
            this.lblSrvcDistanceX.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcDistanceX.TabIndex = 94;
            this.lblSrvcDistanceX.Text = "NULL";
            // 
            // lblSrvcPrntLife
            // 
            this.lblSrvcPrntLife.AutoSize = true;
            this.lblSrvcPrntLife.BackColor = System.Drawing.Color.White;
            this.lblSrvcPrntLife.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcPrntLife.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcPrntLife.Location = new System.Drawing.Point(372, 244);
            this.lblSrvcPrntLife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcPrntLife.Name = "lblSrvcPrntLife";
            this.lblSrvcPrntLife.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcPrntLife.TabIndex = 93;
            this.lblSrvcPrntLife.Text = "NULL";
            // 
            // lblSrvcPwrON
            // 
            this.lblSrvcPwrON.AutoSize = true;
            this.lblSrvcPwrON.BackColor = System.Drawing.Color.White;
            this.lblSrvcPwrON.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcPwrON.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcPwrON.Location = new System.Drawing.Point(372, 229);
            this.lblSrvcPwrON.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcPwrON.Name = "lblSrvcPwrON";
            this.lblSrvcPwrON.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcPwrON.TabIndex = 92;
            this.lblSrvcPwrON.Text = "NULL";
            // 
            // lblSrvcPwrCycle
            // 
            this.lblSrvcPwrCycle.AutoSize = true;
            this.lblSrvcPwrCycle.BackColor = System.Drawing.Color.White;
            this.lblSrvcPwrCycle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcPwrCycle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcPwrCycle.Location = new System.Drawing.Point(372, 214);
            this.lblSrvcPwrCycle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcPwrCycle.Name = "lblSrvcPwrCycle";
            this.lblSrvcPwrCycle.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcPwrCycle.TabIndex = 91;
            this.lblSrvcPwrCycle.Text = "NULL";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.Color.White;
            this.label70.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label70.Location = new System.Drawing.Point(372, 199);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(175, 13);
            this.label70.TabIndex = 90;
            this.label70.Text = "Betriebsdaten (Seit Wartung)";
            // 
            // lblKgTotalT3
            // 
            this.lblKgTotalT3.AutoSize = true;
            this.lblKgTotalT3.BackColor = System.Drawing.Color.White;
            this.lblKgTotalT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgTotalT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgTotalT3.Location = new System.Drawing.Point(178, 421);
            this.lblKgTotalT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgTotalT3.Name = "lblKgTotalT3";
            this.lblKgTotalT3.Size = new System.Drawing.Size(31, 13);
            this.lblKgTotalT3.TabIndex = 89;
            this.lblKgTotalT3.Text = "NULL";
            // 
            // lblKgTotalT2
            // 
            this.lblKgTotalT2.AutoSize = true;
            this.lblKgTotalT2.BackColor = System.Drawing.Color.White;
            this.lblKgTotalT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgTotalT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgTotalT2.Location = new System.Drawing.Point(178, 406);
            this.lblKgTotalT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgTotalT2.Name = "lblKgTotalT2";
            this.lblKgTotalT2.Size = new System.Drawing.Size(31, 13);
            this.lblKgTotalT2.TabIndex = 88;
            this.lblKgTotalT2.Text = "NULL";
            // 
            // lblKgTotalT1
            // 
            this.lblKgTotalT1.AutoSize = true;
            this.lblKgTotalT1.BackColor = System.Drawing.Color.White;
            this.lblKgTotalT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgTotalT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgTotalT1.Location = new System.Drawing.Point(178, 391);
            this.lblKgTotalT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgTotalT1.Name = "lblKgTotalT1";
            this.lblKgTotalT1.Size = new System.Drawing.Size(31, 13);
            this.lblKgTotalT1.TabIndex = 87;
            this.lblKgTotalT1.Text = "NULL";
            // 
            // lblKgTotalT0
            // 
            this.lblKgTotalT0.AutoSize = true;
            this.lblKgTotalT0.BackColor = System.Drawing.Color.White;
            this.lblKgTotalT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgTotalT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgTotalT0.Location = new System.Drawing.Point(178, 376);
            this.lblKgTotalT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgTotalT0.Name = "lblKgTotalT0";
            this.lblKgTotalT0.Size = new System.Drawing.Size(31, 13);
            this.lblKgTotalT0.TabIndex = 86;
            this.lblKgTotalT0.Text = "NULL";
            // 
            // lblT3_3
            // 
            this.lblT3_3.AutoSize = true;
            this.lblT3_3.BackColor = System.Drawing.Color.White;
            this.lblT3_3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3_3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT3_3.Location = new System.Drawing.Point(5, 421);
            this.lblT3_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT3_3.Name = "lblT3_3";
            this.lblT3_3.Size = new System.Drawing.Size(157, 13);
            this.lblT3_3.TabIndex = 85;
            this.lblT3_3.Text = "T3 Extruded Filament (kg)";
            // 
            // lblT2_3
            // 
            this.lblT2_3.AutoSize = true;
            this.lblT2_3.BackColor = System.Drawing.Color.White;
            this.lblT2_3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2_3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT2_3.Location = new System.Drawing.Point(5, 406);
            this.lblT2_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2_3.Name = "lblT2_3";
            this.lblT2_3.Size = new System.Drawing.Size(157, 13);
            this.lblT2_3.TabIndex = 84;
            this.lblT2_3.Text = "T2 Extruded Filament (kg)";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.White;
            this.label61.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label61.Location = new System.Drawing.Point(5, 391);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(157, 13);
            this.label61.TabIndex = 83;
            this.label61.Text = "T1 Extruded Filament (kg)";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.Color.White;
            this.label62.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label62.Location = new System.Drawing.Point(5, 376);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(157, 13);
            this.label62.TabIndex = 82;
            this.label62.Text = "T0 Extruded Filament (kg)";
            // 
            // lblHeatedTotalT3
            // 
            this.lblHeatedTotalT3.AutoSize = true;
            this.lblHeatedTotalT3.BackColor = System.Drawing.Color.White;
            this.lblHeatedTotalT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedTotalT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedTotalT3.Location = new System.Drawing.Point(178, 485);
            this.lblHeatedTotalT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedTotalT3.Name = "lblHeatedTotalT3";
            this.lblHeatedTotalT3.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedTotalT3.TabIndex = 80;
            this.lblHeatedTotalT3.Text = "NULL";
            // 
            // lblHeatedTotalT2
            // 
            this.lblHeatedTotalT2.AutoSize = true;
            this.lblHeatedTotalT2.BackColor = System.Drawing.Color.White;
            this.lblHeatedTotalT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedTotalT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedTotalT2.Location = new System.Drawing.Point(178, 470);
            this.lblHeatedTotalT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedTotalT2.Name = "lblHeatedTotalT2";
            this.lblHeatedTotalT2.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedTotalT2.TabIndex = 79;
            this.lblHeatedTotalT2.Text = "NULL";
            // 
            // lblHeatedTotalT1
            // 
            this.lblHeatedTotalT1.AutoSize = true;
            this.lblHeatedTotalT1.BackColor = System.Drawing.Color.White;
            this.lblHeatedTotalT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedTotalT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedTotalT1.Location = new System.Drawing.Point(178, 455);
            this.lblHeatedTotalT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedTotalT1.Name = "lblHeatedTotalT1";
            this.lblHeatedTotalT1.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedTotalT1.TabIndex = 78;
            this.lblHeatedTotalT1.Text = "NULL";
            // 
            // lblHeatedTotalT0
            // 
            this.lblHeatedTotalT0.AutoSize = true;
            this.lblHeatedTotalT0.BackColor = System.Drawing.Color.White;
            this.lblHeatedTotalT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedTotalT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedTotalT0.Location = new System.Drawing.Point(178, 440);
            this.lblHeatedTotalT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedTotalT0.Name = "lblHeatedTotalT0";
            this.lblHeatedTotalT0.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedTotalT0.TabIndex = 77;
            this.lblHeatedTotalT0.Text = "NULL";
            // 
            // lblExtrudedTotalT3
            // 
            this.lblExtrudedTotalT3.AutoSize = true;
            this.lblExtrudedTotalT3.BackColor = System.Drawing.Color.White;
            this.lblExtrudedTotalT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedTotalT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedTotalT3.Location = new System.Drawing.Point(178, 361);
            this.lblExtrudedTotalT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedTotalT3.Name = "lblExtrudedTotalT3";
            this.lblExtrudedTotalT3.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedTotalT3.TabIndex = 76;
            this.lblExtrudedTotalT3.Text = "NULL";
            // 
            // lblExtrudedTotalT2
            // 
            this.lblExtrudedTotalT2.AutoSize = true;
            this.lblExtrudedTotalT2.BackColor = System.Drawing.Color.White;
            this.lblExtrudedTotalT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedTotalT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedTotalT2.Location = new System.Drawing.Point(178, 346);
            this.lblExtrudedTotalT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedTotalT2.Name = "lblExtrudedTotalT2";
            this.lblExtrudedTotalT2.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedTotalT2.TabIndex = 75;
            this.lblExtrudedTotalT2.Text = "NULL";
            // 
            // lblExtrudedTotalT1
            // 
            this.lblExtrudedTotalT1.AutoSize = true;
            this.lblExtrudedTotalT1.BackColor = System.Drawing.Color.White;
            this.lblExtrudedTotalT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedTotalT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedTotalT1.Location = new System.Drawing.Point(178, 331);
            this.lblExtrudedTotalT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedTotalT1.Name = "lblExtrudedTotalT1";
            this.lblExtrudedTotalT1.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedTotalT1.TabIndex = 74;
            this.lblExtrudedTotalT1.Text = "NULL";
            // 
            // lblExtrudedTotalT0
            // 
            this.lblExtrudedTotalT0.AutoSize = true;
            this.lblExtrudedTotalT0.BackColor = System.Drawing.Color.White;
            this.lblExtrudedTotalT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedTotalT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedTotalT0.Location = new System.Drawing.Point(178, 316);
            this.lblExtrudedTotalT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedTotalT0.Name = "lblExtrudedTotalT0";
            this.lblExtrudedTotalT0.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedTotalT0.TabIndex = 73;
            this.lblExtrudedTotalT0.Text = "NULL";
            // 
            // lblTotalDistanceZ
            // 
            this.lblTotalDistanceZ.AutoSize = true;
            this.lblTotalDistanceZ.BackColor = System.Drawing.Color.White;
            this.lblTotalDistanceZ.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDistanceZ.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalDistanceZ.Location = new System.Drawing.Point(178, 295);
            this.lblTotalDistanceZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDistanceZ.Name = "lblTotalDistanceZ";
            this.lblTotalDistanceZ.Size = new System.Drawing.Size(31, 13);
            this.lblTotalDistanceZ.TabIndex = 72;
            this.lblTotalDistanceZ.Text = "NULL";
            // 
            // lblTotalDistanceY
            // 
            this.lblTotalDistanceY.AutoSize = true;
            this.lblTotalDistanceY.BackColor = System.Drawing.Color.White;
            this.lblTotalDistanceY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDistanceY.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalDistanceY.Location = new System.Drawing.Point(178, 281);
            this.lblTotalDistanceY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDistanceY.Name = "lblTotalDistanceY";
            this.lblTotalDistanceY.Size = new System.Drawing.Size(31, 13);
            this.lblTotalDistanceY.TabIndex = 71;
            this.lblTotalDistanceY.Text = "NULL";
            // 
            // lblTotalDistanceX
            // 
            this.lblTotalDistanceX.AutoSize = true;
            this.lblTotalDistanceX.BackColor = System.Drawing.Color.White;
            this.lblTotalDistanceX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDistanceX.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalDistanceX.Location = new System.Drawing.Point(178, 266);
            this.lblTotalDistanceX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDistanceX.Name = "lblTotalDistanceX";
            this.lblTotalDistanceX.Size = new System.Drawing.Size(31, 13);
            this.lblTotalDistanceX.TabIndex = 70;
            this.lblTotalDistanceX.Text = "NULL";
            // 
            // lblTotalPrntLife
            // 
            this.lblTotalPrntLife.AutoSize = true;
            this.lblTotalPrntLife.BackColor = System.Drawing.Color.White;
            this.lblTotalPrntLife.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrntLife.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalPrntLife.Location = new System.Drawing.Point(178, 244);
            this.lblTotalPrntLife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrntLife.Name = "lblTotalPrntLife";
            this.lblTotalPrntLife.Size = new System.Drawing.Size(31, 13);
            this.lblTotalPrntLife.TabIndex = 69;
            this.lblTotalPrntLife.Text = "NULL";
            // 
            // lblTotalPwrON
            // 
            this.lblTotalPwrON.AutoSize = true;
            this.lblTotalPwrON.BackColor = System.Drawing.Color.White;
            this.lblTotalPwrON.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPwrON.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalPwrON.Location = new System.Drawing.Point(178, 229);
            this.lblTotalPwrON.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPwrON.Name = "lblTotalPwrON";
            this.lblTotalPwrON.Size = new System.Drawing.Size(31, 13);
            this.lblTotalPwrON.TabIndex = 68;
            this.lblTotalPwrON.Text = "NULL";
            // 
            // lblTotalPwrCycle
            // 
            this.lblTotalPwrCycle.AutoSize = true;
            this.lblTotalPwrCycle.BackColor = System.Drawing.Color.White;
            this.lblTotalPwrCycle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPwrCycle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalPwrCycle.Location = new System.Drawing.Point(178, 214);
            this.lblTotalPwrCycle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPwrCycle.Name = "lblTotalPwrCycle";
            this.lblTotalPwrCycle.Size = new System.Drawing.Size(31, 13);
            this.lblTotalPwrCycle.TabIndex = 67;
            this.lblTotalPwrCycle.Text = "NULL";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.White;
            this.label54.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label54.Location = new System.Drawing.Point(178, 199);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(133, 13);
            this.label54.TabIndex = 66;
            this.label54.Text = "Betriebsdaten (Total)";
            // 
            // lblAbstandT3
            // 
            this.lblAbstandT3.AutoSize = true;
            this.lblAbstandT3.BackColor = System.Drawing.Color.White;
            this.lblAbstandT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstandT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAbstandT3.Location = new System.Drawing.Point(30, 133);
            this.lblAbstandT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbstandT3.Name = "lblAbstandT3";
            this.lblAbstandT3.Size = new System.Drawing.Size(31, 13);
            this.lblAbstandT3.TabIndex = 65;
            this.lblAbstandT3.Text = "NULL";
            // 
            // lblAbstandT2
            // 
            this.lblAbstandT2.AutoSize = true;
            this.lblAbstandT2.BackColor = System.Drawing.Color.White;
            this.lblAbstandT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstandT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAbstandT2.Location = new System.Drawing.Point(30, 118);
            this.lblAbstandT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbstandT2.Name = "lblAbstandT2";
            this.lblAbstandT2.Size = new System.Drawing.Size(31, 13);
            this.lblAbstandT2.TabIndex = 64;
            this.lblAbstandT2.Text = "NULL";
            // 
            // lblAbstandT1
            // 
            this.lblAbstandT1.AutoSize = true;
            this.lblAbstandT1.BackColor = System.Drawing.Color.White;
            this.lblAbstandT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstandT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAbstandT1.Location = new System.Drawing.Point(30, 103);
            this.lblAbstandT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbstandT1.Name = "lblAbstandT1";
            this.lblAbstandT1.Size = new System.Drawing.Size(31, 13);
            this.lblAbstandT1.TabIndex = 63;
            this.lblAbstandT1.Text = "NULL";
            // 
            // lblAbstandT0
            // 
            this.lblAbstandT0.AutoSize = true;
            this.lblAbstandT0.BackColor = System.Drawing.Color.White;
            this.lblAbstandT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstandT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAbstandT0.Location = new System.Drawing.Point(30, 88);
            this.lblAbstandT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbstandT0.Name = "lblAbstandT0";
            this.lblAbstandT0.Size = new System.Drawing.Size(31, 13);
            this.lblAbstandT0.TabIndex = 62;
            this.lblAbstandT0.Text = "NULL";
            // 
            // lblFirmware
            // 
            this.lblFirmware.AutoSize = true;
            this.lblFirmware.BackColor = System.Drawing.Color.White;
            this.lblFirmware.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmware.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblFirmware.Location = new System.Drawing.Point(178, 54);
            this.lblFirmware.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirmware.Name = "lblFirmware";
            this.lblFirmware.Size = new System.Drawing.Size(31, 13);
            this.lblFirmware.TabIndex = 60;
            this.lblFirmware.Text = "Null";
            // 
            // lblT3_4
            // 
            this.lblT3_4.AutoSize = true;
            this.lblT3_4.BackColor = System.Drawing.Color.White;
            this.lblT3_4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3_4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT3_4.Location = new System.Drawing.Point(5, 485);
            this.lblT3_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT3_4.Name = "lblT3_4";
            this.lblT3_4.Size = new System.Drawing.Size(91, 13);
            this.lblT3_4.TabIndex = 57;
            this.lblT3_4.Text = "T3 Heated Time";
            // 
            // lblT2_4
            // 
            this.lblT2_4.AutoSize = true;
            this.lblT2_4.BackColor = System.Drawing.Color.White;
            this.lblT2_4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2_4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT2_4.Location = new System.Drawing.Point(5, 470);
            this.lblT2_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2_4.Name = "lblT2_4";
            this.lblT2_4.Size = new System.Drawing.Size(91, 13);
            this.lblT2_4.TabIndex = 56;
            this.lblT2_4.Text = "T2 Heated Time";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.White;
            this.label34.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label34.Location = new System.Drawing.Point(5, 455);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 13);
            this.label34.TabIndex = 55;
            this.label34.Text = "T1 Heated Time";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.White;
            this.label33.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label33.Location = new System.Drawing.Point(5, 440);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(91, 13);
            this.label33.TabIndex = 54;
            this.label33.Text = "T0 Heated Time";
            // 
            // lblT3_2
            // 
            this.lblT3_2.AutoSize = true;
            this.lblT3_2.BackColor = System.Drawing.Color.White;
            this.lblT3_2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3_2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT3_2.Location = new System.Drawing.Point(5, 361);
            this.lblT3_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT3_2.Name = "lblT3_2";
            this.lblT3_2.Size = new System.Drawing.Size(151, 13);
            this.lblT3_2.TabIndex = 53;
            this.lblT3_2.Text = "T3 Extruded Filament (m)";
            // 
            // lblT2_2
            // 
            this.lblT2_2.AutoSize = true;
            this.lblT2_2.BackColor = System.Drawing.Color.White;
            this.lblT2_2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2_2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT2_2.Location = new System.Drawing.Point(5, 346);
            this.lblT2_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2_2.Name = "lblT2_2";
            this.lblT2_2.Size = new System.Drawing.Size(151, 13);
            this.lblT2_2.TabIndex = 52;
            this.lblT2_2.Text = "T2 Extruded Filament (m)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.White;
            this.label30.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label30.Location = new System.Drawing.Point(5, 331);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(151, 13);
            this.label30.TabIndex = 51;
            this.label30.Text = "T1 Extruded Filament (m)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.White;
            this.label29.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label29.Location = new System.Drawing.Point(5, 316);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(151, 13);
            this.label29.TabIndex = 50;
            this.label29.Text = "T0 Extruded Filament (m)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.White;
            this.label28.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label28.Location = new System.Drawing.Point(5, 295);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(151, 13);
            this.label28.TabIndex = 49;
            this.label28.Text = "Zurückgelegter Weg Z (m)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.White;
            this.label27.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label27.Location = new System.Drawing.Point(5, 281);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(151, 13);
            this.label27.TabIndex = 48;
            this.label27.Text = "Zurückgelegter Weg Y (m)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.White;
            this.label26.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label26.Location = new System.Drawing.Point(5, 266);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(151, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "Zurückgelegter Weg X (m)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.White;
            this.label25.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label25.Location = new System.Drawing.Point(29, 244);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(61, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "Druckzeit";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label24.Location = new System.Drawing.Point(30, 229);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(67, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Drucker An";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label23.Location = new System.Drawing.Point(29, 214);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(121, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "Anzahl Verbindungen";
            // 
            // lblT3_5
            // 
            this.lblT3_5.AutoSize = true;
            this.lblT3_5.BackColor = System.Drawing.Color.White;
            this.lblT3_5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3_5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT3_5.Location = new System.Drawing.Point(5, 133);
            this.lblT3_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT3_5.Name = "lblT3_5";
            this.lblT3_5.Size = new System.Drawing.Size(19, 13);
            this.lblT3_5.TabIndex = 42;
            this.lblT3_5.Text = "T3";
            // 
            // lblT2_5
            // 
            this.lblT2_5.AutoSize = true;
            this.lblT2_5.BackColor = System.Drawing.Color.White;
            this.lblT2_5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2_5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT2_5.Location = new System.Drawing.Point(5, 118);
            this.lblT2_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2_5.Name = "lblT2_5";
            this.lblT2_5.Size = new System.Drawing.Size(19, 13);
            this.lblT2_5.TabIndex = 41;
            this.lblT2_5.Text = "T2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label19.Location = new System.Drawing.Point(5, 103);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "T1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label18.Location = new System.Drawing.Point(5, 88);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "T0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(5, 73);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Duesen-Offsets (mm)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(5, 54);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Firmware Version";
            // 
            // timer_temp
            // 
            this.timer_temp.Enabled = true;
            this.timer_temp.Interval = 1500;
            this.timer_temp.Tick += new System.EventHandler(this.timer_temp_Tick);
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            // 
            // wrkerColdExtrusion
            // 
            this.wrkerColdExtrusion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WrkerColdExtrusion_DoWork);
            // 
            // wrkrOpenDialogBox
            // 
            this.wrkrOpenDialogBox.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrkrOpenDialogBox_DoWork);
            // 
            // lblBanner
            // 
            this.lblBanner.AutoSize = true;
            this.lblBanner.BackColor = System.Drawing.Color.SkyBlue;
            this.lblBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanner.ForeColor = System.Drawing.Color.White;
            this.lblBanner.Location = new System.Drawing.Point(38, 4);
            this.lblBanner.Name = "lblBanner";
            this.lblBanner.Size = new System.Drawing.Size(172, 29);
            this.lblBanner.TabIndex = 49;
            this.lblBanner.Text = "Disconnected";
            // 
            // wrkrHomeXY
            // 
            this.wrkrHomeXY.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrkrHomeXY_DoWork);
            // 
            // timerRetractLoad
            // 
            this.timerRetractLoad.Interval = 5000;
            this.timerRetractLoad.Tick += new System.EventHandler(this.timerRetractLoad_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SkyBlue;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 38);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // btnBedTempPlus
            // 
            this.btnBedTempPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnBedTempPlus.Image = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnBedTempPlus.ImageClicked = global::MultecPlugin.Properties.Resources.PlusV_p;
            this.btnBedTempPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnBedTempPlus.Location = new System.Drawing.Point(394, 374);
            this.btnBedTempPlus.Name = "btnBedTempPlus";
            this.btnBedTempPlus.Size = new System.Drawing.Size(60, 41);
            this.btnBedTempPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBedTempPlus.TabIndex = 99;
            this.btnBedTempPlus.TabStop = false;
            this.btnBedTempPlus.EnabledChanged += new System.EventHandler(this.btnBedTempPlus_EnabledChanged);
            this.btnBedTempPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBedTempPlus_MouseClick);
            // 
            // btnBedTempMinus
            // 
            this.btnBedTempMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnBedTempMinus.Image = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnBedTempMinus.ImageClicked = global::MultecPlugin.Properties.Resources.MinusV_p;
            this.btnBedTempMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnBedTempMinus.Location = new System.Drawing.Point(394, 469);
            this.btnBedTempMinus.Name = "btnBedTempMinus";
            this.btnBedTempMinus.Size = new System.Drawing.Size(60, 41);
            this.btnBedTempMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBedTempMinus.TabIndex = 98;
            this.btnBedTempMinus.TabStop = false;
            this.btnBedTempMinus.EnabledChanged += new System.EventHandler(this.btnBedTempMinus_EnabledChanged);
            this.btnBedTempMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBedTempMinus_MouseClick);
            // 
            // btnT3TempPlus
            // 
            this.btnT3TempPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnT3TempPlus.Image = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnT3TempPlus.ImageClicked = global::MultecPlugin.Properties.Resources.PlusV_p;
            this.btnT3TempPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnT3TempPlus.Location = new System.Drawing.Point(328, 374);
            this.btnT3TempPlus.Name = "btnT3TempPlus";
            this.btnT3TempPlus.Size = new System.Drawing.Size(60, 41);
            this.btnT3TempPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT3TempPlus.TabIndex = 97;
            this.btnT3TempPlus.TabStop = false;
            this.btnT3TempPlus.EnabledChanged += new System.EventHandler(this.btnT3TempPlus_EnabledChanged);
            this.btnT3TempPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT3TempPlus_MouseClick);
            // 
            // btnT3TempMinus
            // 
            this.btnT3TempMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnT3TempMinus.Image = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnT3TempMinus.ImageClicked = global::MultecPlugin.Properties.Resources.MinusV_p;
            this.btnT3TempMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnT3TempMinus.Location = new System.Drawing.Point(328, 469);
            this.btnT3TempMinus.Name = "btnT3TempMinus";
            this.btnT3TempMinus.Size = new System.Drawing.Size(60, 41);
            this.btnT3TempMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT3TempMinus.TabIndex = 96;
            this.btnT3TempMinus.TabStop = false;
            this.btnT3TempMinus.EnabledChanged += new System.EventHandler(this.btnT3TempMinus_EnabledChanged);
            this.btnT3TempMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT3TempMinus_MouseClick);
            // 
            // btnT2TempMinus
            // 
            this.btnT2TempMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnT2TempMinus.Image = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnT2TempMinus.ImageClicked = global::MultecPlugin.Properties.Resources.MinusV_p;
            this.btnT2TempMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnT2TempMinus.Location = new System.Drawing.Point(262, 469);
            this.btnT2TempMinus.Name = "btnT2TempMinus";
            this.btnT2TempMinus.Size = new System.Drawing.Size(60, 41);
            this.btnT2TempMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT2TempMinus.TabIndex = 95;
            this.btnT2TempMinus.TabStop = false;
            this.btnT2TempMinus.EnabledChanged += new System.EventHandler(this.btnT2TempMinus_EnabledChanged);
            this.btnT2TempMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT2TempMinus_MouseClick);
            // 
            // btnT2TempPlus
            // 
            this.btnT2TempPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnT2TempPlus.Image = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnT2TempPlus.ImageClicked = global::MultecPlugin.Properties.Resources.PlusV_p;
            this.btnT2TempPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnT2TempPlus.Location = new System.Drawing.Point(262, 374);
            this.btnT2TempPlus.Name = "btnT2TempPlus";
            this.btnT2TempPlus.Size = new System.Drawing.Size(60, 41);
            this.btnT2TempPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT2TempPlus.TabIndex = 94;
            this.btnT2TempPlus.TabStop = false;
            this.btnT2TempPlus.EnabledChanged += new System.EventHandler(this.btnT2TempPlus_EnabledChanged);
            this.btnT2TempPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT2TempPlus_MouseClick);
            // 
            // btnT1TempPlus
            // 
            this.btnT1TempPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnT1TempPlus.Image = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnT1TempPlus.ImageClicked = global::MultecPlugin.Properties.Resources.PlusV_p;
            this.btnT1TempPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnT1TempPlus.Location = new System.Drawing.Point(196, 374);
            this.btnT1TempPlus.Name = "btnT1TempPlus";
            this.btnT1TempPlus.Size = new System.Drawing.Size(59, 41);
            this.btnT1TempPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT1TempPlus.TabIndex = 93;
            this.btnT1TempPlus.TabStop = false;
            this.btnT1TempPlus.EnabledChanged += new System.EventHandler(this.btnT1TempPlus_EnabledChanged);
            this.btnT1TempPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT1TempPlus_MouseClick);
            // 
            // btnT1TempMinus
            // 
            this.btnT1TempMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnT1TempMinus.Image = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnT1TempMinus.ImageClicked = global::MultecPlugin.Properties.Resources.MinusV_p;
            this.btnT1TempMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnT1TempMinus.Location = new System.Drawing.Point(196, 469);
            this.btnT1TempMinus.Name = "btnT1TempMinus";
            this.btnT1TempMinus.Size = new System.Drawing.Size(59, 41);
            this.btnT1TempMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT1TempMinus.TabIndex = 92;
            this.btnT1TempMinus.TabStop = false;
            this.btnT1TempMinus.EnabledChanged += new System.EventHandler(this.btnT1TempMinus_EnabledChanged);
            this.btnT1TempMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT1TempMinus_MouseClick);
            // 
            // btnT0TempPlus
            // 
            this.btnT0TempPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnT0TempPlus.Image = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnT0TempPlus.ImageClicked = global::MultecPlugin.Properties.Resources.PlusV_p;
            this.btnT0TempPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnT0TempPlus.Location = new System.Drawing.Point(131, 374);
            this.btnT0TempPlus.Name = "btnT0TempPlus";
            this.btnT0TempPlus.Size = new System.Drawing.Size(59, 41);
            this.btnT0TempPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT0TempPlus.TabIndex = 91;
            this.btnT0TempPlus.TabStop = false;
            this.btnT0TempPlus.EnabledChanged += new System.EventHandler(this.btnT0TempPlus_EnabledChanged);
            this.btnT0TempPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT0TempPlus_MouseClick);
            // 
            // btnT0TempMinus
            // 
            this.btnT0TempMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnT0TempMinus.Image = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnT0TempMinus.ImageClicked = global::MultecPlugin.Properties.Resources.MinusV_p;
            this.btnT0TempMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnT0TempMinus.Location = new System.Drawing.Point(130, 469);
            this.btnT0TempMinus.Name = "btnT0TempMinus";
            this.btnT0TempMinus.Size = new System.Drawing.Size(60, 41);
            this.btnT0TempMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT0TempMinus.TabIndex = 90;
            this.btnT0TempMinus.TabStop = false;
            this.btnT0TempMinus.EnabledChanged += new System.EventHandler(this.btnT0TempMinus_EnabledChanged);
            this.btnT0TempMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT0TempMinus_MouseClick);
            // 
            // btnFeedratePlus
            // 
            this.btnFeedratePlus.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedratePlus.Image = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnFeedratePlus.ImageClicked = global::MultecPlugin.Properties.Resources.PlusV_p;
            this.btnFeedratePlus.ImangeNormal = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnFeedratePlus.Location = new System.Drawing.Point(477, 275);
            this.btnFeedratePlus.Name = "btnFeedratePlus";
            this.btnFeedratePlus.Size = new System.Drawing.Size(49, 33);
            this.btnFeedratePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFeedratePlus.TabIndex = 89;
            this.btnFeedratePlus.TabStop = false;
            this.btnFeedratePlus.EnabledChanged += new System.EventHandler(this.btnFeedratePlus_EnabledChanged);
            this.btnFeedratePlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFeedratePlus_MouseClick);
            // 
            // btnFlowratePlus
            // 
            this.btnFlowratePlus.BackColor = System.Drawing.Color.Transparent;
            this.btnFlowratePlus.Image = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnFlowratePlus.ImageClicked = global::MultecPlugin.Properties.Resources.PlusV_p;
            this.btnFlowratePlus.ImangeNormal = global::MultecPlugin.Properties.Resources.PlusV;
            this.btnFlowratePlus.Location = new System.Drawing.Point(477, 411);
            this.btnFlowratePlus.Name = "btnFlowratePlus";
            this.btnFlowratePlus.Size = new System.Drawing.Size(49, 33);
            this.btnFlowratePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFlowratePlus.TabIndex = 88;
            this.btnFlowratePlus.TabStop = false;
            this.btnFlowratePlus.EnabledChanged += new System.EventHandler(this.btnFlowratePlus_EnabledChanged);
            this.btnFlowratePlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFlowratePlus_MouseClick);
            // 
            // btnFeedrateMinus
            // 
            this.btnFeedrateMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnFeedrateMinus.Image = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnFeedrateMinus.ImageClicked = global::MultecPlugin.Properties.Resources.MinusV_p;
            this.btnFeedrateMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnFeedrateMinus.Location = new System.Drawing.Point(477, 341);
            this.btnFeedrateMinus.Name = "btnFeedrateMinus";
            this.btnFeedrateMinus.Size = new System.Drawing.Size(49, 33);
            this.btnFeedrateMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFeedrateMinus.TabIndex = 87;
            this.btnFeedrateMinus.TabStop = false;
            this.btnFeedrateMinus.EnabledChanged += new System.EventHandler(this.btnFeedrateMinus_EnabledChanged);
            this.btnFeedrateMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFeedrateMinus_MouseClick);
            // 
            // btnFlowrateMinus
            // 
            this.btnFlowrateMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnFlowrateMinus.Image = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnFlowrateMinus.ImageClicked = global::MultecPlugin.Properties.Resources.MinusV_p;
            this.btnFlowrateMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.MinusV;
            this.btnFlowrateMinus.Location = new System.Drawing.Point(477, 477);
            this.btnFlowrateMinus.Name = "btnFlowrateMinus";
            this.btnFlowrateMinus.Size = new System.Drawing.Size(49, 33);
            this.btnFlowrateMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFlowrateMinus.TabIndex = 86;
            this.btnFlowrateMinus.TabStop = false;
            this.btnFlowrateMinus.EnabledChanged += new System.EventHandler(this.btnFlowrateMinus_EnabledChanged);
            this.btnFlowrateMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFlowrateMinus_MouseClick);
            // 
            // btnYhome
            // 
            this.btnYhome.BackColor = System.Drawing.Color.Transparent;
            this.btnYhome.Image = global::MultecPlugin.Properties.Resources.Yhome;
            this.btnYhome.ImageClicked = global::MultecPlugin.Properties.Resources.Yhome_p;
            this.btnYhome.ImangeNormal = global::MultecPlugin.Properties.Resources.Yhome;
            this.btnYhome.Location = new System.Drawing.Point(6, 174);
            this.btnYhome.Name = "btnYhome";
            this.btnYhome.Size = new System.Drawing.Size(60, 58);
            this.btnYhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYhome.TabIndex = 76;
            this.btnYhome.TabStop = false;
            this.btnYhome.EnabledChanged += new System.EventHandler(this.btnYhome_EnabledChanged);
            this.btnYhome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnYhome_MouseClick);
            // 
            // btnXhome
            // 
            this.btnXhome.BackColor = System.Drawing.Color.Transparent;
            this.btnXhome.Image = global::MultecPlugin.Properties.Resources.Xhome;
            this.btnXhome.ImageClicked = global::MultecPlugin.Properties.Resources.Xhome_p;
            this.btnXhome.ImangeNormal = global::MultecPlugin.Properties.Resources.Xhome;
            this.btnXhome.Location = new System.Drawing.Point(6, 110);
            this.btnXhome.Name = "btnXhome";
            this.btnXhome.Size = new System.Drawing.Size(60, 58);
            this.btnXhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXhome.TabIndex = 75;
            this.btnXhome.TabStop = false;
            this.btnXhome.EnabledChanged += new System.EventHandler(this.btnXhome_EnabledChanged);
            this.btnXhome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnXhome_MouseClick);
            // 
            // btnParkMove
            // 
            this.btnParkMove.BackColor = System.Drawing.Color.Transparent;
            this.btnParkMove.Image = global::MultecPlugin.Properties.Resources.Park_Move;
            this.btnParkMove.ImageClicked = global::MultecPlugin.Properties.Resources.Park_Move_p;
            this.btnParkMove.ImangeNormal = global::MultecPlugin.Properties.Resources.Park_Move;
            this.btnParkMove.Location = new System.Drawing.Point(6, 381);
            this.btnParkMove.Name = "btnParkMove";
            this.btnParkMove.Size = new System.Drawing.Size(60, 58);
            this.btnParkMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnParkMove.TabIndex = 58;
            this.btnParkMove.TabStop = false;
            this.btnParkMove.EnabledChanged += new System.EventHandler(this.btnParkMove_EnabledChanged);
            this.btnParkMove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnParkMove_MouseClick);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = global::MultecPlugin.Properties.Resources.HOME;
            this.btnHome.ImageClicked = global::MultecPlugin.Properties.Resources.HOME_p;
            this.btnHome.ImangeNormal = global::MultecPlugin.Properties.Resources.HOME;
            this.btnHome.Location = new System.Drawing.Point(6, 32);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 58);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 9;
            this.btnHome.TabStop = false;
            this.btnHome.EnabledChanged += new System.EventHandler(this.btnHome_EnabledChanged);
            this.btnHome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHome_MouseClick);
            // 
            // btnMotorOff
            // 
            this.btnMotorOff.BackColor = System.Drawing.Color.Transparent;
            this.btnMotorOff.Image = global::MultecPlugin.Properties.Resources.MOTOR_OFF;
            this.btnMotorOff.ImageClicked = global::MultecPlugin.Properties.Resources.MOTOR_OFF_p;
            this.btnMotorOff.ImangeNormal = global::MultecPlugin.Properties.Resources.MOTOR_OFF;
            this.btnMotorOff.Location = new System.Drawing.Point(6, 254);
            this.btnMotorOff.Name = "btnMotorOff";
            this.btnMotorOff.Size = new System.Drawing.Size(60, 58);
            this.btnMotorOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMotorOff.TabIndex = 57;
            this.btnMotorOff.TabStop = false;
            this.btnMotorOff.EnabledChanged += new System.EventHandler(this.btnMotorOff_EnabledChanged);
            this.btnMotorOff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMotorOff_MouseClick);
            // 
            // btnManualGcodeSend
            // 
            this.btnManualGcodeSend.BackColor = System.Drawing.Color.Transparent;
            this.btnManualGcodeSend.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnManualGcodeSend.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.btnManualGcodeSend.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnManualGcodeSend.Location = new System.Drawing.Point(387, 17);
            this.btnManualGcodeSend.Name = "btnManualGcodeSend";
            this.btnManualGcodeSend.Size = new System.Drawing.Size(64, 23);
            this.btnManualGcodeSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnManualGcodeSend.TabIndex = 3;
            this.btnManualGcodeSend.TabStop = false;
            this.btnManualGcodeSend.EnabledChanged += new System.EventHandler(this.btnManualGcodeSend_EnabledChanged);
            this.btnManualGcodeSend.Click += new System.EventHandler(this.btnManualGcodeSend_Click);
            // 
            // btnHomeMove
            // 
            this.btnHomeMove.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeMove.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeMove.Image")));
            this.btnHomeMove.ImageClicked = global::MultecPlugin.Properties.Resources.HOME_Move_p;
            this.btnHomeMove.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("btnHomeMove.ImangeNormal")));
            this.btnHomeMove.Location = new System.Drawing.Point(6, 318);
            this.btnHomeMove.Name = "btnHomeMove";
            this.btnHomeMove.Size = new System.Drawing.Size(60, 57);
            this.btnHomeMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHomeMove.TabIndex = 55;
            this.btnHomeMove.TabStop = false;
            this.btnHomeMove.EnabledChanged += new System.EventHandler(this.btnHomeMove_EnabledChanged);
            this.btnHomeMove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHomeMove_MouseClick);
            // 
            // btnExtrude
            // 
            this.btnExtrude.BackColor = System.Drawing.Color.Transparent;
            this.btnExtrude.Image = global::MultecPlugin.Properties.Resources.extract;
            this.btnExtrude.ImageClicked = global::MultecPlugin.Properties.Resources.extract_p;
            this.btnExtrude.ImangeNormal = global::MultecPlugin.Properties.Resources.extract;
            this.btnExtrude.Location = new System.Drawing.Point(398, 174);
            this.btnExtrude.Name = "btnExtrude";
            this.btnExtrude.Size = new System.Drawing.Size(70, 70);
            this.btnExtrude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExtrude.TabIndex = 54;
            this.btnExtrude.TabStop = false;
            this.btnExtrude.EnabledChanged += new System.EventHandler(this.btnExtrude_EnabledChanged);
            this.btnExtrude.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnExtrude_MouseClick);
            // 
            // btnRetract
            // 
            this.btnRetract.BackColor = System.Drawing.Color.Transparent;
            this.btnRetract.Image = global::MultecPlugin.Properties.Resources.retract;
            this.btnRetract.ImageClicked = global::MultecPlugin.Properties.Resources.retract_p;
            this.btnRetract.ImangeNormal = global::MultecPlugin.Properties.Resources.retract;
            this.btnRetract.Location = new System.Drawing.Point(398, 98);
            this.btnRetract.Name = "btnRetract";
            this.btnRetract.Size = new System.Drawing.Size(70, 70);
            this.btnRetract.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRetract.TabIndex = 53;
            this.btnRetract.TabStop = false;
            this.btnRetract.EnabledChanged += new System.EventHandler(this.btnRetract_EnabledChanged);
            this.btnRetract.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton1_MouseClick_2);
            // 
            // btnZminus
            // 
            this.btnZminus.BackColor = System.Drawing.Color.Transparent;
            this.btnZminus.Image = global::MultecPlugin.Properties.Resources.Zminus;
            this.btnZminus.ImageClicked = global::MultecPlugin.Properties.Resources.Zminus_p;
            this.btnZminus.ImangeNormal = global::MultecPlugin.Properties.Resources.Zminus;
            this.btnZminus.Location = new System.Drawing.Point(309, 174);
            this.btnZminus.Name = "btnZminus";
            this.btnZminus.Size = new System.Drawing.Size(70, 70);
            this.btnZminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZminus.TabIndex = 52;
            this.btnZminus.TabStop = false;
            this.btnZminus.EnabledChanged += new System.EventHandler(this.btnZminus_EnabledChanged);
            this.btnZminus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZminus_MouseClick);
            // 
            // btnZPlus
            // 
            this.btnZPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnZPlus.Image = global::MultecPlugin.Properties.Resources.zPlus;
            this.btnZPlus.ImageClicked = global::MultecPlugin.Properties.Resources.zplus_p;
            this.btnZPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.zPlus;
            this.btnZPlus.Location = new System.Drawing.Point(309, 98);
            this.btnZPlus.Name = "btnZPlus";
            this.btnZPlus.Size = new System.Drawing.Size(70, 70);
            this.btnZPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZPlus.TabIndex = 51;
            this.btnZPlus.TabStop = false;
            this.btnZPlus.EnabledChanged += new System.EventHandler(this.btnZPlus_EnabledChanged);
            this.btnZPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton1_MouseClick_1);
            // 
            // btnYPlus
            // 
            this.btnYPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnYPlus.Image = global::MultecPlugin.Properties.Resources.Yplus;
            this.btnYPlus.ImageClicked = global::MultecPlugin.Properties.Resources.Yplus_p;
            this.btnYPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.Yplus;
            this.btnYPlus.Location = new System.Drawing.Point(158, 98);
            this.btnYPlus.Name = "btnYPlus";
            this.btnYPlus.Size = new System.Drawing.Size(70, 70);
            this.btnYPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYPlus.TabIndex = 48;
            this.btnYPlus.TabStop = false;
            this.btnYPlus.EnabledChanged += new System.EventHandler(this.btnYPlus_EnabledChanged);
            this.btnYPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton2_Click);
            // 
            // btnYMinus
            // 
            this.btnYMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnYMinus.Image = global::MultecPlugin.Properties.Resources.Yminus;
            this.btnYMinus.ImageClicked = global::MultecPlugin.Properties.Resources.Yminus_p;
            this.btnYMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.Yminus;
            this.btnYMinus.Location = new System.Drawing.Point(158, 174);
            this.btnYMinus.Name = "btnYMinus";
            this.btnYMinus.Size = new System.Drawing.Size(70, 70);
            this.btnYMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYMinus.TabIndex = 50;
            this.btnYMinus.TabStop = false;
            this.btnYMinus.EnabledChanged += new System.EventHandler(this.btnYMinus_EnabledChanged);
            this.btnYMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton4_Click);
            // 
            // btnXPlus
            // 
            this.btnXPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnXPlus.Image = global::MultecPlugin.Properties.Resources.Xplus;
            this.btnXPlus.ImageClicked = global::MultecPlugin.Properties.Resources.Xplus_p;
            this.btnXPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.Xplus;
            this.btnXPlus.Location = new System.Drawing.Point(230, 136);
            this.btnXPlus.Name = "btnXPlus";
            this.btnXPlus.Size = new System.Drawing.Size(70, 70);
            this.btnXPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXPlus.TabIndex = 49;
            this.btnXPlus.TabStop = false;
            this.btnXPlus.EnabledChanged += new System.EventHandler(this.btnXPlus_EnabledChanged);
            this.btnXPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton3_Click);
            // 
            // btnStep50
            // 
            this.btnStep50.BackColor = System.Drawing.Color.Transparent;
            this.btnStep50.Image = global::MultecPlugin.Properties.Resources.fiftymm;
            this.btnStep50.ImageClicked = global::MultecPlugin.Properties.Resources.fiftymm_p;
            this.btnStep50.ImangeNormal = global::MultecPlugin.Properties.Resources.fiftymm;
            this.btnStep50.Location = new System.Drawing.Point(9, 13);
            this.btnStep50.Name = "btnStep50";
            this.btnStep50.Size = new System.Drawing.Size(50, 50);
            this.btnStep50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStep50.TabIndex = 5;
            this.btnStep50.TabStop = false;
            this.btnStep50.EnabledChanged += new System.EventHandler(this.btnStep50_EnabledChanged);
            this.btnStep50.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStep50_MouseClick);
            // 
            // btnStep10
            // 
            this.btnStep10.BackColor = System.Drawing.Color.Transparent;
            this.btnStep10.Image = global::MultecPlugin.Properties.Resources.tenmm;
            this.btnStep10.ImageClicked = global::MultecPlugin.Properties.Resources.tenmm_p;
            this.btnStep10.ImangeNormal = global::MultecPlugin.Properties.Resources.tenmm;
            this.btnStep10.Location = new System.Drawing.Point(9, 66);
            this.btnStep10.Name = "btnStep10";
            this.btnStep10.Size = new System.Drawing.Size(50, 50);
            this.btnStep10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStep10.TabIndex = 4;
            this.btnStep10.TabStop = false;
            this.btnStep10.EnabledChanged += new System.EventHandler(this.btnStep10_EnabledChanged);
            this.btnStep10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStep10_MouseClick);
            // 
            // btnStep1
            // 
            this.btnStep1.BackColor = System.Drawing.Color.Transparent;
            this.btnStep1.Image = global::MultecPlugin.Properties.Resources.onemm;
            this.btnStep1.ImageClicked = global::MultecPlugin.Properties.Resources.onemm_p;
            this.btnStep1.ImangeNormal = global::MultecPlugin.Properties.Resources.onemm;
            this.btnStep1.Location = new System.Drawing.Point(9, 119);
            this.btnStep1.Name = "btnStep1";
            this.btnStep1.Size = new System.Drawing.Size(50, 50);
            this.btnStep1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStep1.TabIndex = 3;
            this.btnStep1.TabStop = false;
            this.btnStep1.EnabledChanged += new System.EventHandler(this.btnStep1_EnabledChanged);
            this.btnStep1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnStep1_MouseClick);
            // 
            // btnT3
            // 
            this.btnT3.BackColor = System.Drawing.Color.Transparent;
            this.btnT3.Image = global::MultecPlugin.Properties.Resources.T3;
            this.btnT3.ImageClicked = global::MultecPlugin.Properties.Resources.T3_p;
            this.btnT3.ImangeNormal = global::MultecPlugin.Properties.Resources.T3;
            this.btnT3.Location = new System.Drawing.Point(205, 19);
            this.btnT3.Name = "btnT3";
            this.btnT3.Size = new System.Drawing.Size(60, 40);
            this.btnT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT3.TabIndex = 8;
            this.btnT3.TabStop = false;
            this.btnT3.EnabledChanged += new System.EventHandler(this.btnT3_EnabledChanged);
            this.btnT3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT3_MouseClick);
            // 
            // btnT2
            // 
            this.btnT2.BackColor = System.Drawing.Color.Transparent;
            this.btnT2.Image = global::MultecPlugin.Properties.Resources.T2;
            this.btnT2.ImageClicked = global::MultecPlugin.Properties.Resources.T2_p;
            this.btnT2.ImangeNormal = global::MultecPlugin.Properties.Resources.T2;
            this.btnT2.Location = new System.Drawing.Point(139, 19);
            this.btnT2.Name = "btnT2";
            this.btnT2.Size = new System.Drawing.Size(60, 40);
            this.btnT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT2.TabIndex = 7;
            this.btnT2.TabStop = false;
            this.btnT2.EnabledChanged += new System.EventHandler(this.btnT2_EnabledChanged);
            this.btnT2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT2_MouseClick);
            // 
            // btnT1
            // 
            this.btnT1.BackColor = System.Drawing.Color.Transparent;
            this.btnT1.Image = global::MultecPlugin.Properties.Resources.T1;
            this.btnT1.ImageClicked = global::MultecPlugin.Properties.Resources.T1_p;
            this.btnT1.ImangeNormal = global::MultecPlugin.Properties.Resources.T1;
            this.btnT1.Location = new System.Drawing.Point(75, 19);
            this.btnT1.Name = "btnT1";
            this.btnT1.Size = new System.Drawing.Size(57, 40);
            this.btnT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT1.TabIndex = 6;
            this.btnT1.TabStop = false;
            this.btnT1.EnabledChanged += new System.EventHandler(this.BtnT1_EnabledChanged);
            this.btnT1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnT1_MouseClick);
            // 
            // btnT0
            // 
            this.btnT0.BackColor = System.Drawing.Color.Transparent;
            this.btnT0.Image = global::MultecPlugin.Properties.Resources.T0;
            this.btnT0.ImageClicked = global::MultecPlugin.Properties.Resources.T0_p;
            this.btnT0.ImangeNormal = global::MultecPlugin.Properties.Resources.T0;
            this.btnT0.Location = new System.Drawing.Point(8, 19);
            this.btnT0.Name = "btnT0";
            this.btnT0.Size = new System.Drawing.Size(60, 40);
            this.btnT0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT0.TabIndex = 5;
            this.btnT0.TabStop = false;
            this.btnT0.EnabledChanged += new System.EventHandler(this.btnT0_EnabledChanged);
            this.btnT0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnT0_MouseClick);
            // 
            // btnXMinus
            // 
            this.btnXMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnXMinus.Image = global::MultecPlugin.Properties.Resources.Xminus;
            this.btnXMinus.ImageClicked = global::MultecPlugin.Properties.Resources.Xminus_p;
            this.btnXMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.Xminus;
            this.btnXMinus.Location = new System.Drawing.Point(85, 136);
            this.btnXMinus.Name = "btnXMinus";
            this.btnXMinus.Size = new System.Drawing.Size(70, 70);
            this.btnXMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXMinus.TabIndex = 47;
            this.btnXMinus.TabStop = false;
            this.btnXMinus.EnabledChanged += new System.EventHandler(this.btnXMinus_EnabledChanged);
            this.btnXMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton1_MouseClick);
            // 
            // btnLoadT0
            // 
            this.btnLoadT0.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadT0.Image = global::MultecPlugin.Properties.Resources.Laden;
            this.btnLoadT0.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnLoadT0.ImageClicked")));
            this.btnLoadT0.ImangeNormal = global::MultecPlugin.Properties.Resources.Laden;
            this.btnLoadT0.Location = new System.Drawing.Point(146, 59);
            this.btnLoadT0.Name = "btnLoadT0";
            this.btnLoadT0.Size = new System.Drawing.Size(92, 31);
            this.btnLoadT0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLoadT0.TabIndex = 112;
            this.btnLoadT0.TabStop = false;
            this.btnLoadT0.EnabledChanged += new System.EventHandler(this.btnLoadT0_EnabledChanged);
            this.btnLoadT0.Click += new System.EventHandler(this.btnLoadT0_Click);
            // 
            // btnLoadT3
            // 
            this.btnLoadT3.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadT3.Image = global::MultecPlugin.Properties.Resources.Laden;
            this.btnLoadT3.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnLoadT3.ImageClicked")));
            this.btnLoadT3.ImangeNormal = null;
            this.btnLoadT3.Location = new System.Drawing.Point(146, 218);
            this.btnLoadT3.Name = "btnLoadT3";
            this.btnLoadT3.Size = new System.Drawing.Size(92, 31);
            this.btnLoadT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLoadT3.TabIndex = 114;
            this.btnLoadT3.TabStop = false;
            this.btnLoadT3.EnabledChanged += new System.EventHandler(this.btnLoadT3_EnabledChanged);
            this.btnLoadT3.Click += new System.EventHandler(this.btnLoadT3_Click);
            // 
            // btnRetractT0
            // 
            this.btnRetractT0.BackColor = System.Drawing.Color.Transparent;
            this.btnRetractT0.Image = global::MultecPlugin.Properties.Resources.Zuruck;
            this.btnRetractT0.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnRetractT0.ImageClicked")));
            this.btnRetractT0.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("btnRetractT0.ImangeNormal")));
            this.btnRetractT0.Location = new System.Drawing.Point(48, 59);
            this.btnRetractT0.Name = "btnRetractT0";
            this.btnRetractT0.Size = new System.Drawing.Size(92, 31);
            this.btnRetractT0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRetractT0.TabIndex = 113;
            this.btnRetractT0.TabStop = false;
            this.btnRetractT0.EnabledChanged += new System.EventHandler(this.btnRetractT0_EnabledChanged);
            this.btnRetractT0.Click += new System.EventHandler(this.btnRetractT0_Click_1);
            // 
            // btnRetractT3
            // 
            this.btnRetractT3.BackColor = System.Drawing.Color.Transparent;
            this.btnRetractT3.Image = global::MultecPlugin.Properties.Resources.Zuruck;
            this.btnRetractT3.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnRetractT3.ImageClicked")));
            this.btnRetractT3.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("btnRetractT3.ImangeNormal")));
            this.btnRetractT3.Location = new System.Drawing.Point(46, 218);
            this.btnRetractT3.Name = "btnRetractT3";
            this.btnRetractT3.Size = new System.Drawing.Size(94, 31);
            this.btnRetractT3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRetractT3.TabIndex = 117;
            this.btnRetractT3.TabStop = false;
            this.btnRetractT3.EnabledChanged += new System.EventHandler(this.btnRetractT3_EnabledChanged);
            this.btnRetractT3.Click += new System.EventHandler(this.btnRetractT3_Click);
            // 
            // btnLoadT1
            // 
            this.btnLoadT1.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadT1.Image = global::MultecPlugin.Properties.Resources.Laden;
            this.btnLoadT1.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnLoadT1.ImageClicked")));
            this.btnLoadT1.ImangeNormal = null;
            this.btnLoadT1.Location = new System.Drawing.Point(146, 112);
            this.btnLoadT1.Name = "btnLoadT1";
            this.btnLoadT1.Size = new System.Drawing.Size(92, 31);
            this.btnLoadT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLoadT1.TabIndex = 116;
            this.btnLoadT1.TabStop = false;
            this.btnLoadT1.EnabledChanged += new System.EventHandler(this.btnLoadT1_EnabledChanged);
            this.btnLoadT1.Click += new System.EventHandler(this.btnLoadT1_Click);
            // 
            // btnLoadT2
            // 
            this.btnLoadT2.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadT2.Image = global::MultecPlugin.Properties.Resources.Laden;
            this.btnLoadT2.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnLoadT2.ImageClicked")));
            this.btnLoadT2.ImangeNormal = null;
            this.btnLoadT2.Location = new System.Drawing.Point(146, 165);
            this.btnLoadT2.Name = "btnLoadT2";
            this.btnLoadT2.Size = new System.Drawing.Size(92, 31);
            this.btnLoadT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLoadT2.TabIndex = 115;
            this.btnLoadT2.TabStop = false;
            this.btnLoadT2.EnabledChanged += new System.EventHandler(this.btnLoadT2_EnabledChanged);
            this.btnLoadT2.Click += new System.EventHandler(this.btnLoadT2_Click);
            // 
            // btnRetractT1
            // 
            this.btnRetractT1.BackColor = System.Drawing.Color.Transparent;
            this.btnRetractT1.Image = global::MultecPlugin.Properties.Resources.Zuruck;
            this.btnRetractT1.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnRetractT1.ImageClicked")));
            this.btnRetractT1.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("btnRetractT1.ImangeNormal")));
            this.btnRetractT1.Location = new System.Drawing.Point(48, 112);
            this.btnRetractT1.Name = "btnRetractT1";
            this.btnRetractT1.Size = new System.Drawing.Size(92, 31);
            this.btnRetractT1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRetractT1.TabIndex = 119;
            this.btnRetractT1.TabStop = false;
            this.btnRetractT1.EnabledChanged += new System.EventHandler(this.btnRetractT1_EnabledChanged);
            this.btnRetractT1.Click += new System.EventHandler(this.btnRetractT1_Click);
            // 
            // btnRetractT2
            // 
            this.btnRetractT2.BackColor = System.Drawing.Color.Transparent;
            this.btnRetractT2.Image = global::MultecPlugin.Properties.Resources.Zuruck;
            this.btnRetractT2.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnRetractT2.ImageClicked")));
            this.btnRetractT2.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("btnRetractT2.ImangeNormal")));
            this.btnRetractT2.Location = new System.Drawing.Point(48, 165);
            this.btnRetractT2.Name = "btnRetractT2";
            this.btnRetractT2.Size = new System.Drawing.Size(92, 31);
            this.btnRetractT2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRetractT2.TabIndex = 118;
            this.btnRetractT2.TabStop = false;
            this.btnRetractT2.EnabledChanged += new System.EventHandler(this.btnRetractT2_EnabledChanged);
            this.btnRetractT2.Click += new System.EventHandler(this.btnRetractT2_Click_1);
            // 
            // btnFilAktualise
            // 
            this.btnFilAktualise.BackColor = System.Drawing.Color.Transparent;
            this.btnFilAktualise.Image = ((System.Drawing.Image)(resources.GetObject("btnFilAktualise.Image")));
            this.btnFilAktualise.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnFilAktualise.ImageClicked")));
            this.btnFilAktualise.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("btnFilAktualise.ImangeNormal")));
            this.btnFilAktualise.Location = new System.Drawing.Point(186, 18);
            this.btnFilAktualise.Name = "btnFilAktualise";
            this.btnFilAktualise.Size = new System.Drawing.Size(97, 31);
            this.btnFilAktualise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFilAktualise.TabIndex = 82;
            this.btnFilAktualise.TabStop = false;
            this.btnFilAktualise.EnabledChanged += new System.EventHandler(this.btnFilAktualise_EnabledChanged_1);
            this.btnFilAktualise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFilAktualise_MouseClick);
            // 
            // btnM218T3
            // 
            this.btnM218T3.BackColor = System.Drawing.Color.Transparent;
            this.btnM218T3.Image = global::MultecPlugin.Properties.Resources.T3;
            this.btnM218T3.ImageClicked = global::MultecPlugin.Properties.Resources.T3_p;
            this.btnM218T3.ImangeNormal = global::MultecPlugin.Properties.Resources.T3;
            this.btnM218T3.Location = new System.Drawing.Point(176, 18);
            this.btnM218T3.Name = "btnM218T3";
            this.btnM218T3.Size = new System.Drawing.Size(60, 40);
            this.btnM218T3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnM218T3.TabIndex = 84;
            this.btnM218T3.TabStop = false;
            this.btnM218T3.EnabledChanged += new System.EventHandler(this.btnM218T3_EnabledChanged);
            this.btnM218T3.Click += new System.EventHandler(this.btnM218T3_Click);
            // 
            // btnM218T2
            // 
            this.btnM218T2.BackColor = System.Drawing.Color.Transparent;
            this.btnM218T2.Image = global::MultecPlugin.Properties.Resources.T2;
            this.btnM218T2.ImageClicked = global::MultecPlugin.Properties.Resources.T2_p;
            this.btnM218T2.ImangeNormal = global::MultecPlugin.Properties.Resources.T2;
            this.btnM218T2.Location = new System.Drawing.Point(86, 18);
            this.btnM218T2.Name = "btnM218T2";
            this.btnM218T2.Size = new System.Drawing.Size(60, 40);
            this.btnM218T2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnM218T2.TabIndex = 83;
            this.btnM218T2.TabStop = false;
            this.btnM218T2.EnabledChanged += new System.EventHandler(this.btnM218T2_EnabledChanged);
            this.btnM218T2.Click += new System.EventHandler(this.btnM218T2_Click);
            // 
            // btnM218T1
            // 
            this.btnM218T1.BackColor = System.Drawing.Color.Transparent;
            this.btnM218T1.Image = global::MultecPlugin.Properties.Resources.T1;
            this.btnM218T1.ImageClicked = global::MultecPlugin.Properties.Resources.T1_p;
            this.btnM218T1.ImangeNormal = global::MultecPlugin.Properties.Resources.T1;
            this.btnM218T1.Location = new System.Drawing.Point(5, 18);
            this.btnM218T1.Name = "btnM218T1";
            this.btnM218T1.Size = new System.Drawing.Size(57, 40);
            this.btnM218T1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnM218T1.TabIndex = 82;
            this.btnM218T1.TabStop = false;
            this.btnM218T1.EnabledChanged += new System.EventHandler(this.btnM218T1_EnabledChanged);
            this.btnM218T1.Click += new System.EventHandler(this.btnM218T1_Click);
            // 
            // btnPminus
            // 
            this.btnPminus.BackColor = System.Drawing.Color.Transparent;
            this.btnPminus.Image = global::MultecPlugin.Properties.Resources.minus;
            this.btnPminus.ImageClicked = global::MultecPlugin.Properties.Resources.minus_p;
            this.btnPminus.ImangeNormal = global::MultecPlugin.Properties.Resources.minus;
            this.btnPminus.Location = new System.Drawing.Point(287, 327);
            this.btnPminus.Name = "btnPminus";
            this.btnPminus.Size = new System.Drawing.Size(36, 33);
            this.btnPminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPminus.TabIndex = 95;
            this.btnPminus.TabStop = false;
            this.btnPminus.EnabledChanged += new System.EventHandler(this.btnPminus_EnabledChanged);
            this.btnPminus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPminus_MouseClick);
            // 
            // btnPplus
            // 
            this.btnPplus.BackColor = System.Drawing.Color.Transparent;
            this.btnPplus.Image = global::MultecPlugin.Properties.Resources.plus;
            this.btnPplus.ImageClicked = global::MultecPlugin.Properties.Resources.plus_p;
            this.btnPplus.ImangeNormal = global::MultecPlugin.Properties.Resources.plus;
            this.btnPplus.Location = new System.Drawing.Point(397, 327);
            this.btnPplus.Name = "btnPplus";
            this.btnPplus.Size = new System.Drawing.Size(36, 33);
            this.btnPplus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPplus.TabIndex = 94;
            this.btnPplus.TabStop = false;
            this.btnPplus.EnabledChanged += new System.EventHandler(this.btnPplus_EnabledChanged);
            this.btnPplus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPplus_MouseClick);
            // 
            // btnParkPositionSend
            // 
            this.btnParkPositionSend.BackColor = System.Drawing.Color.Transparent;
            this.btnParkPositionSend.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnParkPositionSend.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.btnParkPositionSend.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnParkPositionSend.Location = new System.Drawing.Point(439, 329);
            this.btnParkPositionSend.Name = "btnParkPositionSend";
            this.btnParkPositionSend.Size = new System.Drawing.Size(89, 31);
            this.btnParkPositionSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnParkPositionSend.TabIndex = 93;
            this.btnParkPositionSend.TabStop = false;
            this.btnParkPositionSend.EnabledChanged += new System.EventHandler(this.btnParkPositionSend_EnabledChanged);
            this.btnParkPositionSend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnParkPositionSend_MouseClick);
            // 
            // btnEminus
            // 
            this.btnEminus.BackColor = System.Drawing.Color.Transparent;
            this.btnEminus.Image = global::MultecPlugin.Properties.Resources.minus;
            this.btnEminus.ImageClicked = global::MultecPlugin.Properties.Resources.minus_p;
            this.btnEminus.ImangeNormal = global::MultecPlugin.Properties.Resources.minus;
            this.btnEminus.Location = new System.Drawing.Point(287, 264);
            this.btnEminus.Name = "btnEminus";
            this.btnEminus.Size = new System.Drawing.Size(36, 33);
            this.btnEminus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEminus.TabIndex = 89;
            this.btnEminus.TabStop = false;
            this.btnEminus.EnabledChanged += new System.EventHandler(this.btnEminus_EnabledChanged);
            this.btnEminus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEminus_MouseClick);
            // 
            // btnEplus
            // 
            this.btnEplus.BackColor = System.Drawing.Color.Transparent;
            this.btnEplus.Image = global::MultecPlugin.Properties.Resources.plus;
            this.btnEplus.ImageClicked = global::MultecPlugin.Properties.Resources.plus_p;
            this.btnEplus.ImangeNormal = global::MultecPlugin.Properties.Resources.plus;
            this.btnEplus.Location = new System.Drawing.Point(397, 264);
            this.btnEplus.Name = "btnEplus";
            this.btnEplus.Size = new System.Drawing.Size(36, 33);
            this.btnEplus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnEplus.TabIndex = 88;
            this.btnEplus.TabStop = false;
            this.btnEplus.EnabledChanged += new System.EventHandler(this.btnEplus_EnabledChanged);
            this.btnEplus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnEplus_MouseClick);
            // 
            // btnZOffsetPlus
            // 
            this.btnZOffsetPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnZOffsetPlus.Image = global::MultecPlugin.Properties.Resources.zPlusKal;
            this.btnZOffsetPlus.ImageClicked = global::MultecPlugin.Properties.Resources.zPlusKal_p;
            this.btnZOffsetPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.zPlusKal;
            this.btnZOffsetPlus.Location = new System.Drawing.Point(397, 201);
            this.btnZOffsetPlus.Name = "btnZOffsetPlus";
            this.btnZOffsetPlus.Size = new System.Drawing.Size(36, 33);
            this.btnZOffsetPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZOffsetPlus.TabIndex = 87;
            this.btnZOffsetPlus.TabStop = false;
            this.btnZOffsetPlus.EnabledChanged += new System.EventHandler(this.btnZOffsetPlus_EnabledChanged);
            this.btnZOffsetPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZOffsetPlus_MouseClick);
            // 
            // btnZOffsetMinus
            // 
            this.btnZOffsetMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnZOffsetMinus.Image = global::MultecPlugin.Properties.Resources.zMinusKal;
            this.btnZOffsetMinus.ImageClicked = global::MultecPlugin.Properties.Resources.zMinusKal_p;
            this.btnZOffsetMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.zMinusKal;
            this.btnZOffsetMinus.Location = new System.Drawing.Point(287, 201);
            this.btnZOffsetMinus.Name = "btnZOffsetMinus";
            this.btnZOffsetMinus.Size = new System.Drawing.Size(36, 33);
            this.btnZOffsetMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZOffsetMinus.TabIndex = 86;
            this.btnZOffsetMinus.TabStop = false;
            this.btnZOffsetMinus.EnabledChanged += new System.EventHandler(this.btnZOffsetMinus_EnabledChanged);
            this.btnZOffsetMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZOffsetMinus_MouseClick);
            // 
            // btnXOffsetPlus
            // 
            this.btnXOffsetPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnXOffsetPlus.Image = global::MultecPlugin.Properties.Resources.plus;
            this.btnXOffsetPlus.ImageClicked = global::MultecPlugin.Properties.Resources.plus_p;
            this.btnXOffsetPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.plus;
            this.btnXOffsetPlus.Location = new System.Drawing.Point(397, 87);
            this.btnXOffsetPlus.Name = "btnXOffsetPlus";
            this.btnXOffsetPlus.Size = new System.Drawing.Size(36, 33);
            this.btnXOffsetPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXOffsetPlus.TabIndex = 85;
            this.btnXOffsetPlus.TabStop = false;
            this.btnXOffsetPlus.EnabledChanged += new System.EventHandler(this.btnXOffsetPlus_EnabledChanged);
            this.btnXOffsetPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnXOffsetPlus_MouseClick);
            // 
            // btnXOffsetMinus
            // 
            this.btnXOffsetMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnXOffsetMinus.Image = global::MultecPlugin.Properties.Resources.minus;
            this.btnXOffsetMinus.ImageClicked = global::MultecPlugin.Properties.Resources.minus_p;
            this.btnXOffsetMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.minus;
            this.btnXOffsetMinus.Location = new System.Drawing.Point(287, 89);
            this.btnXOffsetMinus.Name = "btnXOffsetMinus";
            this.btnXOffsetMinus.Size = new System.Drawing.Size(36, 33);
            this.btnXOffsetMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXOffsetMinus.TabIndex = 84;
            this.btnXOffsetMinus.TabStop = false;
            this.btnXOffsetMinus.EnabledChanged += new System.EventHandler(this.btnXOffsetMinus_EnabledChanged);
            this.btnXOffsetMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnXOffsetMinus_MouseClick);
            // 
            // btnYoffsetPlus
            // 
            this.btnYoffsetPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnYoffsetPlus.Image = global::MultecPlugin.Properties.Resources.plus;
            this.btnYoffsetPlus.ImageClicked = global::MultecPlugin.Properties.Resources.plus_p;
            this.btnYoffsetPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.plus;
            this.btnYoffsetPlus.Location = new System.Drawing.Point(397, 135);
            this.btnYoffsetPlus.Name = "btnYoffsetPlus";
            this.btnYoffsetPlus.Size = new System.Drawing.Size(36, 33);
            this.btnYoffsetPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYoffsetPlus.TabIndex = 83;
            this.btnYoffsetPlus.TabStop = false;
            this.btnYoffsetPlus.EnabledChanged += new System.EventHandler(this.btnYoffsetPlus_EnabledChanged);
            this.btnYoffsetPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnYoffsetPlus_MouseClick);
            // 
            // btnYoffsetMinus
            // 
            this.btnYoffsetMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnYoffsetMinus.Image = global::MultecPlugin.Properties.Resources.minus;
            this.btnYoffsetMinus.ImageClicked = global::MultecPlugin.Properties.Resources.minus_p;
            this.btnYoffsetMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.minus;
            this.btnYoffsetMinus.Location = new System.Drawing.Point(287, 135);
            this.btnYoffsetMinus.Name = "btnYoffsetMinus";
            this.btnYoffsetMinus.Size = new System.Drawing.Size(36, 33);
            this.btnYoffsetMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYoffsetMinus.TabIndex = 82;
            this.btnYoffsetMinus.TabStop = false;
            this.btnYoffsetMinus.EnabledChanged += new System.EventHandler(this.btnYoffsetMinus_EnabledChanged);
            this.btnYoffsetMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnYoffsetMinus_MouseClick);
            // 
            // btnZOffsetSend
            // 
            this.btnZOffsetSend.BackColor = System.Drawing.Color.Transparent;
            this.btnZOffsetSend.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnZOffsetSend.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.btnZOffsetSend.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnZOffsetSend.Location = new System.Drawing.Point(439, 203);
            this.btnZOffsetSend.Name = "btnZOffsetSend";
            this.btnZOffsetSend.Size = new System.Drawing.Size(89, 31);
            this.btnZOffsetSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZOffsetSend.TabIndex = 81;
            this.btnZOffsetSend.TabStop = false;
            this.btnZOffsetSend.EnabledChanged += new System.EventHandler(this.btnZOffsetSend_EnabledChanged);
            this.btnZOffsetSend.Click += new System.EventHandler(this.btnZOffsetSend_Click);
            // 
            // btnXoffsetSend
            // 
            this.btnXoffsetSend.BackColor = System.Drawing.Color.Transparent;
            this.btnXoffsetSend.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnXoffsetSend.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.btnXoffsetSend.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnXoffsetSend.Location = new System.Drawing.Point(439, 88);
            this.btnXoffsetSend.Name = "btnXoffsetSend";
            this.btnXoffsetSend.Size = new System.Drawing.Size(89, 31);
            this.btnXoffsetSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXoffsetSend.TabIndex = 80;
            this.btnXoffsetSend.TabStop = false;
            this.btnXoffsetSend.EnabledChanged += new System.EventHandler(this.btnXoffsetSend_EnabledChanged);
            this.btnXoffsetSend.Click += new System.EventHandler(this.btnXoffsetSend_Click);
            // 
            // btnYoffsetSend
            // 
            this.btnYoffsetSend.BackColor = System.Drawing.Color.Transparent;
            this.btnYoffsetSend.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnYoffsetSend.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.btnYoffsetSend.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnYoffsetSend.Location = new System.Drawing.Point(439, 136);
            this.btnYoffsetSend.Name = "btnYoffsetSend";
            this.btnYoffsetSend.Size = new System.Drawing.Size(89, 31);
            this.btnYoffsetSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYoffsetSend.TabIndex = 79;
            this.btnYoffsetSend.TabStop = false;
            this.btnYoffsetSend.EnabledChanged += new System.EventHandler(this.btnYoffsetSend_EnabledChanged);
            this.btnYoffsetSend.Click += new System.EventHandler(this.btnYoffsetSend_Click);
            // 
            // btnRotOffsetSend
            // 
            this.btnRotOffsetSend.BackColor = System.Drawing.Color.Transparent;
            this.btnRotOffsetSend.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnRotOffsetSend.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.btnRotOffsetSend.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.btnRotOffsetSend.Location = new System.Drawing.Point(439, 266);
            this.btnRotOffsetSend.Name = "btnRotOffsetSend";
            this.btnRotOffsetSend.Size = new System.Drawing.Size(89, 31);
            this.btnRotOffsetSend.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRotOffsetSend.TabIndex = 78;
            this.btnRotOffsetSend.TabStop = false;
            this.btnRotOffsetSend.EnabledChanged += new System.EventHandler(this.btnRotOffsetSend_EnabledChanged);
            this.btnRotOffsetSend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRotOffsetSend_MouseClick);
            // 
            // btnFineAdjustment
            // 
            this.btnFineAdjustment.BackColor = System.Drawing.Color.Transparent;
            this.btnFineAdjustment.Image = global::MultecPlugin.Properties.Resources.ZF;
            this.btnFineAdjustment.ImageClicked = global::MultecPlugin.Properties.Resources.ZF_p;
            this.btnFineAdjustment.ImangeNormal = global::MultecPlugin.Properties.Resources.ZF;
            this.btnFineAdjustment.Location = new System.Drawing.Point(5, 157);
            this.btnFineAdjustment.Name = "btnFineAdjustment";
            this.btnFineAdjustment.Size = new System.Drawing.Size(133, 52);
            this.btnFineAdjustment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFineAdjustment.TabIndex = 74;
            this.btnFineAdjustment.TabStop = false;
            this.btnFineAdjustment.EnabledChanged += new System.EventHandler(this.btnFineAdjustment_EnabledChanged);
            this.btnFineAdjustment.Click += new System.EventHandler(this.btnFineAdjustment_Click);
            // 
            // btnDusevermessung
            // 
            this.btnDusevermessung.BackColor = System.Drawing.Color.Transparent;
            this.btnDusevermessung.Image = global::MultecPlugin.Properties.Resources.DV;
            this.btnDusevermessung.ImageClicked = global::MultecPlugin.Properties.Resources.DV_p;
            this.btnDusevermessung.ImangeNormal = global::MultecPlugin.Properties.Resources.DV;
            this.btnDusevermessung.Location = new System.Drawing.Point(5, 89);
            this.btnDusevermessung.Name = "btnDusevermessung";
            this.btnDusevermessung.Size = new System.Drawing.Size(133, 52);
            this.btnDusevermessung.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDusevermessung.TabIndex = 73;
            this.btnDusevermessung.TabStop = false;
            this.btnDusevermessung.EnabledChanged += new System.EventHandler(this.btnDusevermessung_EnabledChanged);
            this.btnDusevermessung.Click += new System.EventHandler(this.btnDusevermessung_Click);
            // 
            // btnPositionPrufen
            // 
            this.btnPositionPrufen.BackColor = System.Drawing.Color.Transparent;
            this.btnPositionPrufen.Image = global::MultecPlugin.Properties.Resources.PP;
            this.btnPositionPrufen.ImageClicked = global::MultecPlugin.Properties.Resources.PP_p;
            this.btnPositionPrufen.ImangeNormal = global::MultecPlugin.Properties.Resources.PP;
            this.btnPositionPrufen.Location = new System.Drawing.Point(5, 20);
            this.btnPositionPrufen.Name = "btnPositionPrufen";
            this.btnPositionPrufen.Size = new System.Drawing.Size(133, 52);
            this.btnPositionPrufen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPositionPrufen.TabIndex = 72;
            this.btnPositionPrufen.TabStop = false;
            this.btnPositionPrufen.Visible = false;
            this.btnPositionPrufen.EnabledChanged += new System.EventHandler(this.btnPositionPrufen_EnabledChanged);
            this.btnPositionPrufen.Click += new System.EventHandler(this.BtnPositionPrufen_Click);
            // 
            // btnParkMoveKal
            // 
            this.btnParkMoveKal.BackColor = System.Drawing.Color.Transparent;
            this.btnParkMoveKal.Image = global::MultecPlugin.Properties.Resources.Park_Move;
            this.btnParkMoveKal.ImageClicked = global::MultecPlugin.Properties.Resources.Park_Move_p;
            this.btnParkMoveKal.ImangeNormal = global::MultecPlugin.Properties.Resources.Park_Move;
            this.btnParkMoveKal.Location = new System.Drawing.Point(5, 443);
            this.btnParkMoveKal.Name = "btnParkMoveKal";
            this.btnParkMoveKal.Size = new System.Drawing.Size(60, 58);
            this.btnParkMoveKal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnParkMoveKal.TabIndex = 71;
            this.btnParkMoveKal.TabStop = false;
            this.btnParkMoveKal.EnabledChanged += new System.EventHandler(this.btnParkMoveKal_EnabledChanged);
            this.btnParkMoveKal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnParkMoveKal_MouseClick);
            // 
            // btnHomeMoveKal
            // 
            this.btnHomeMoveKal.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeMoveKal.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeMoveKal.Image")));
            this.btnHomeMoveKal.ImageClicked = global::MultecPlugin.Properties.Resources.HOME_Move_p;
            this.btnHomeMoveKal.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("btnHomeMoveKal.ImangeNormal")));
            this.btnHomeMoveKal.Location = new System.Drawing.Point(5, 372);
            this.btnHomeMoveKal.Name = "btnHomeMoveKal";
            this.btnHomeMoveKal.Size = new System.Drawing.Size(60, 57);
            this.btnHomeMoveKal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHomeMoveKal.TabIndex = 70;
            this.btnHomeMoveKal.TabStop = false;
            this.btnHomeMoveKal.EnabledChanged += new System.EventHandler(this.btnHomeMoveKal_EnabledChanged);
            this.btnHomeMoveKal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnHomeMoveKal_MouseClick);
            // 
            // btnInfoAktualise
            // 
            this.btnInfoAktualise.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoAktualise.Image = ((System.Drawing.Image)(resources.GetObject("btnInfoAktualise.Image")));
            this.btnInfoAktualise.ImageClicked = ((System.Drawing.Image)(resources.GetObject("btnInfoAktualise.ImageClicked")));
            this.btnInfoAktualise.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("btnInfoAktualise.ImangeNormal")));
            this.btnInfoAktualise.Location = new System.Drawing.Point(8, 12);
            this.btnInfoAktualise.Name = "btnInfoAktualise";
            this.btnInfoAktualise.Size = new System.Drawing.Size(107, 36);
            this.btnInfoAktualise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInfoAktualise.TabIndex = 119;
            this.btnInfoAktualise.TabStop = false;
            this.btnInfoAktualise.EnabledChanged += new System.EventHandler(this.btnInfoAktualise_EnabledChanged);
            this.btnInfoAktualise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnInfoAktualise_MouseClick);
            // 
            // MultecTouchpanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblBanner);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MultecTouchpanel";
            this.Size = new System.Drawing.Size(617, 571);
            tabpage2.ResumeLayout(false);
            tabpage2.PerformLayout();
            this.druckPermissives.ResumeLayout(false);
            this.druckPermissives.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.TouchControl.ResumeLayout(false);
            this.TouchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlowrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFeedrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBed_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0_OnOff)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Filament.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.NozzleSizeKal.ResumeLayout(false);
            this.NozzleSizeKal.PerformLayout();
            this.FilamentWechseln.ResumeLayout(false);
            this.FilamentWechseln.PerformLayout();
            this.filamentUberwachung.ResumeLayout(false);
            this.filamentUberwachung.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBedTempPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBedTempMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3TempPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3TempMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2TempMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2TempPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1TempPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1TempMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0TempPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0TempMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFeedratePlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFlowratePlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFeedrateMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFlowrateMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParkMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMotorOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnManualGcodeSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomeMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtrude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadT0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadT3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetractT0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetractT3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoadT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetractT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetractT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilAktualise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPplus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParkPositionSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEplus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZOffsetPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZOffsetMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXOffsetPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXOffsetMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoffsetPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoffsetMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZOffsetSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXoffsetSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYoffsetSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRotOffsetSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFineAdjustment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDusevermessung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPositionPrufen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParkMoveKal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomeMoveKal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoAktualise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private MouseEventHandler myCustomButton1_Click()
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox text_T0_ziel;
        private System.Windows.Forms.TextBox text_T1_ziel;
        private System.Windows.Forms.TextBox text_T2_ziel;
        private System.Windows.Forms.TextBox text_T3_ziel;
        private System.Windows.Forms.TextBox text_T0_Aktuell;
        private System.Windows.Forms.TextBox text_T1_Aktuell;
        private System.Windows.Forms.TextBox text_T2_Aktuell;
        private System.Windows.Forms.TextBox text_T3_Aktuell;
        private System.Windows.Forms.TextBox text_Bed_ziel;
        private System.Windows.Forms.TextBox text_Bed_Aktuell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TouchControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox text_M218_Y;
        private System.Windows.Forms.TextBox text_M218_X;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblT3_2;
        private System.Windows.Forms.Label lblT2_2;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblT3_5;
        private System.Windows.Forms.Label lblT2_5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblT3_4;
        private System.Windows.Forms.Label lblT2_4;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Timer timer_temp;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label lbl_mm;
        private System.Windows.Forms.Label lbl_zOffset;
        private MyCustomButton.MyCustomButton btnXMinus;
        private MyCustomButton.MyCustomButton btnYMinus;
        private MyCustomButton.MyCustomButton btnXPlus;
        private MyCustomButton.MyCustomButton btnYPlus;
        private Label label38;
        private Label lblHeatedTotalT3;
        private Label lblHeatedTotalT2;
        private Label lblHeatedTotalT1;
        private Label lblHeatedTotalT0;
        private Label lblExtrudedTotalT3;
        private Label lblExtrudedTotalT2;
        private Label lblExtrudedTotalT1;
        private Label lblExtrudedTotalT0;
        private Label lblTotalDistanceZ;
        private Label lblTotalDistanceY;
        private Label lblTotalDistanceX;
        private Label lblTotalPrntLife;
        private Label lblTotalPwrON;
        private Label lblTotalPwrCycle;
        private Label label54;
        private Label lblAbstandT3;
        private Label lblAbstandT2;
        private Label lblAbstandT1;
        private Label lblAbstandT0;
        private Label lblFirmware;
        private Label lblSrvcPrntLife;
        private Label lblSrvcPwrON;
        private Label lblSrvcPwrCycle;
        private Label label70;
        private Label lblKgTotalT3;
        private Label lblKgTotalT2;
        private Label lblKgTotalT1;
        private Label lblKgTotalT0;
        private Label lblT3_3;
        private Label lblT2_3;
        private Label label61;
        private Label label62;
        private MyCustomButton.MyCustomButton btnZPlus;
        private Label lblSrvcDistanceZ;
        private Label lblSrvcDistanceY;
        private Label lblSrvcDistanceX;
        private Label lblKgSrvcT3;
        private Label lblKgSrvcT2;
        private Label lblKgSrvcT1;
        private Label lblKgSrvcT0;
        private Label lblHeatedSrvcT3;
        private Label lblHeatedSrvcT2;
        private Label lblHeatedSrvcT1;
        private Label lblHeatedSrvcT0;
        private Label lblExtrudedSrvcT3;
        private Label lblExtrudedSrvcT2;
        private Label lblExtrudedSrvcT1;
        private Label lblExtrudedSrvcT0;
        private Label lblOptimalDistance;
        private Label label42;
        private Label lblRotationalOffset;
        private Label label39;
        private MyCustomButton.MyCustomButton btnZminus;
        private MyCustomButton.MyCustomButton btnRetract;
        private Label lblZKorrektur;
        private Label label43;
        private Label lblDisatance;
        private Label label40;
        private MyCustomButton.MyCustomButton btnExtrude;
        private MyCustomButton.MyCustomButton btnHomeMove;
        private MyCustomButton.MyCustomButton btnT0;
        private Label label37;
        private GroupBox groupBox5;
        private Label label41;
        private TextBox txtManualGcode;
        private Label lblRotOffsetFilament;
        private Label lblWhen4Move;
        private System.ComponentModel.BackgroundWorker wrkerColdExtrusion;
        private MyCustomButton.MyCustomButton btnT1;
        private MyCustomButton.MyCustomButton btnT2;
        private MyCustomButton.MyCustomButton btnT3;
        private MyCustomButton.MyCustomButton btnMotorOff;
        private MyCustomButton.MyCustomButton btnHome;
        private MyCustomButton.MyCustomButton btnParkMove;
        public PictureBox btnT0_OnOff;
        public PictureBox btnBed_OnOff;
        public PictureBox btnT3_OnOff;
        public PictureBox btnT2_OnOff;
        public PictureBox btnT1_OnOff;
        private MyCustomButton.MyCustomButton btnStep1;
        private MyCustomButton.MyCustomButton btnStep10;
        private MyCustomButton.MyCustomButton btnStep50;
        private Label lblKalRotOffsetFilament;
        private Label lblWhen4Move_1;
        private Label lblRotOffFillVal;
        private CheckBox chckBoxDruckerende;
        private Label lblZ;
        private Label lblYPosition;
        private Label lblY;
        private Label lblZPosition;
        private Label lblXPosition;
        private Label lblX;
        private GroupBox druckPermissives;
        private MyCustomButton.MyCustomButton btnManualGcodeSend;
        private MyCustomButton.MyCustomButton btnHomeMoveKal;
        private MyCustomButton.MyCustomButton btnParkMoveKal;
        private MyCustomButton.MyCustomButton btnPositionPrufen;
        private MyCustomButton.MyCustomButton btnDusevermessung;
        private MyCustomButton.MyCustomButton btnFineAdjustment;
        private MyCustomButton.MyCustomButton btnZOffsetSend;
        private MyCustomButton.MyCustomButton btnXoffsetSend;
        private MyCustomButton.MyCustomButton btnYoffsetSend;
        private MyCustomButton.MyCustomButton btnRotOffsetSend;
        private MyCustomButton.MyCustomButton btnM218T3;
        private MyCustomButton.MyCustomButton btnM218T2;
        private MyCustomButton.MyCustomButton btnM218T1;
        private MyCustomButton.MyCustomButton btnInfoAktualise;
        private MyCustomButton.MyCustomButton btnYoffsetMinus;
        private MyCustomButton.MyCustomButton btnYoffsetPlus;
        private MyCustomButton.MyCustomButton btnXOffsetPlus;
        private MyCustomButton.MyCustomButton btnXOffsetMinus;
        private MyCustomButton.MyCustomButton btnZOffsetMinus;
        private MyCustomButton.MyCustomButton btnZOffsetPlus;
        private MyCustomButton.MyCustomButton btnEminus;
        private MyCustomButton.MyCustomButton btnEplus;
        private MyCustomButton.MyCustomButton btnYhome;
        private MyCustomButton.MyCustomButton btnXhome;
        private Label lblFlowrate;
        private NumericUpDown numericFlowrate;
        private Label lbFeedrate;
        private NumericUpDown numericFeedrate;
        private TabPage Filament;
        private GroupBox filamentUberwachung;
        private MyCustomButton.MyCustomButton btnFilAktualise;
        private Label lblT3_1;
        private Label lblT2_1;
        private Label label47;
        private Label label46;
        private Label lblFilamentT3;
        private Label lblFilamentT2;
        private Label lblFilamentT0;
        private Label lblFilamentT1;
        private Label lblFilamentStatus;
        private Label lblFilamentChangeTemp;
        private TextBox txtBoxTemp;
        private Label lblT0;
        private Label lblT1;
        private Label label9;
        private Label label10;
        private MyCustomButton.MyCustomButton btnFlowrateMinus;
        private MyCustomButton.MyCustomButton btnFeedrateMinus;
        private MyCustomButton.MyCustomButton btnFeedratePlus;
        private MyCustomButton.MyCustomButton btnFlowratePlus;
        private System.ComponentModel.BackgroundWorker wrkrOpenDialogBox;
        private Label LblMoveCoverOffset;
        private Label lblParkPosition;
        private Label lblReinigungsschwelle;
        private Label label35;
        private PictureBox pictureBox1;
        private Label lblBanner;
        private Label lblDV;
        private Label label32;
        private System.ComponentModel.BackgroundWorker wrkrHomeXY;
        private Timer timerRetractLoad;
        private Label lblRetractLoadFilT1;
        private Label lblRetractLoadFilT0;
        private Label lblRetractLoadFilT2;
        private Label lblRetractLoadFilT3;
        private MyCustomButton.MyCustomButton btnLoadT0;
        private MyCustomButton.MyCustomButton btnLoadT1;
        private MyCustomButton.MyCustomButton btnLoadT2;
        private MyCustomButton.MyCustomButton btnLoadT3;
        private MyCustomButton.MyCustomButton btnRetractT0;
        private MyCustomButton.MyCustomButton btnRetractT1;
        private MyCustomButton.MyCustomButton btnRetractT2;
        private MyCustomButton.MyCustomButton btnRetractT3;
        private CheckBox ChckboxDruckerInitialised;
        private CheckBox ChckboxMoveInitialised;
        private Label lblKalParkPosition;
        private Label lblWhen4Move_2;
        private Label lblParkPositionVal;
        private MyCustomButton.MyCustomButton btnPminus;
        private MyCustomButton.MyCustomButton btnPplus;
        private MyCustomButton.MyCustomButton btnParkPositionSend;
        private MyCustomButton.MyCustomButton btnT1TempPlus;
        private MyCustomButton.MyCustomButton btnT1TempMinus;
        private MyCustomButton.MyCustomButton btnT0TempPlus;
        private MyCustomButton.MyCustomButton btnT0TempMinus;
        private MyCustomButton.MyCustomButton btnBedTempPlus;
        private MyCustomButton.MyCustomButton btnBedTempMinus;
        private MyCustomButton.MyCustomButton btnT3TempPlus;
        private MyCustomButton.MyCustomButton btnT3TempMinus;
        private MyCustomButton.MyCustomButton btnT2TempMinus;
        private MyCustomButton.MyCustomButton btnT2TempPlus;
        private Label VersionLabel;
        private GroupBox NozzleSizeKal;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Button BtnNozzleSizeSave;
        private TextBox textT0NozzleSize;
        private TextBox textT2NozzleSize;
        private TextBox textT1NozzleSize;
        private TextBox textT3NozzleSize;
        private GroupBox FilamentWechseln;
        private GroupBox groupBox6;
        private Label label44;
        private Label label36;
        private Label label31;
        private Label label22;
        private Label label21;
        private Label label20;
        private CheckBox backupT1furT0;
        private Button btnDeactivate;
        private Button btnActivate;
        private CheckBox backupT2furT3;
        private CheckBox backupT0furT3;
        private Label label49;
        private CheckBox backupT1furT3;
        private CheckBox backupT3furT2;
        private CheckBox backupT0furT2;
        private Label label48;
        private CheckBox backupT1furT2;
        private CheckBox backupT3furT1;
        private CheckBox backupT2furT1;
        private Label label45;
        private CheckBox backupT0furT1;
        private CheckBox backupT3furT0;
        private CheckBox backupT2furT0;
    }
}
