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
            System.Windows.Forms.TabPage tabPage4;
            this.btnFilamentChange = new System.Windows.Forms.Button();
            this.druckPermissives = new System.Windows.Forms.GroupBox();
            this.radioBtnDrucker = new System.Windows.Forms.RadioButton();
            this.radBtnMove = new System.Windows.Forms.RadioButton();
            this.lblKalRotOffsetFilament = new System.Windows.Forms.Label();
            this.lblWhen4Move_1 = new System.Windows.Forms.Label();
            this.lblRotOffFillVal = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.filamentUberwachung = new System.Windows.Forms.GroupBox();
            this.btnFilAktualise = new MyCustomButton.MyCustomButton();
            this.lblT3_1 = new System.Windows.Forms.Label();
            this.lblT2_1 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.lblFilamentT3 = new System.Windows.Forms.Label();
            this.lblFilamentT2 = new System.Windows.Forms.Label();
            this.lblFilamentT0 = new System.Windows.Forms.Label();
            this.lblFilamentT1 = new System.Windows.Forms.Label();
            this.lblFilamentStatus = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.lbl_mm = new System.Windows.Forms.Label();
            this.lbl_zOffset = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnM218T3 = new MyCustomButton.MyCustomButton();
            this.btnM218T2 = new MyCustomButton.MyCustomButton();
            this.btnM218T1 = new MyCustomButton.MyCustomButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.text_M218_Y = new System.Windows.Forms.TextBox();
            this.text_M218_X = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStep50 = new MyCustomButton.MyCustomButton();
            this.btnStep10 = new MyCustomButton.MyCustomButton();
            this.btnStep1 = new MyCustomButton.MyCustomButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMove = new MyCustomButton.MyCustomButton();
            this.btnT3 = new MyCustomButton.MyCustomButton();
            this.btnT2 = new MyCustomButton.MyCustomButton();
            this.btnT1 = new MyCustomButton.MyCustomButton();
            this.btnT0 = new MyCustomButton.MyCustomButton();
            this.trackBar_NozzleTemp = new System.Windows.Forms.TrackBar();
            this.text_T0_ziel = new System.Windows.Forms.TextBox();
            this.text_T1_ziel = new System.Windows.Forms.TextBox();
            this.text_T2_ziel = new System.Windows.Forms.TextBox();
            this.text_T3_ziel = new System.Windows.Forms.TextBox();
            this.text_T0_Aktuell = new System.Windows.Forms.TextBox();
            this.text_T1_Aktuell = new System.Windows.Forms.TextBox();
            this.text_T2_Aktuell = new System.Windows.Forms.TextBox();
            this.text_T3_Aktuell = new System.Windows.Forms.TextBox();
            this.trackBar_BedTemp = new System.Windows.Forms.TrackBar();
            this.text_Bed_ziel = new System.Windows.Forms.TextBox();
            this.text_Bed_Aktuell = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.btnZhome = new MyCustomButton.MyCustomButton();
            this.btnYhome = new MyCustomButton.MyCustomButton();
            this.btnXhome = new MyCustomButton.MyCustomButton();
            this.btnBedMinus = new MyCustomButton.MyCustomButton();
            this.btnBedPlus = new MyCustomButton.MyCustomButton();
            this.btnNozzleMinus = new MyCustomButton.MyCustomButton();
            this.btnNozzlePlus = new MyCustomButton.MyCustomButton();
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
            this.btnParkMove = new MyCustomButton.MyCustomButton();
            this.btnHome = new MyCustomButton.MyCustomButton();
            this.btnMotorOff = new MyCustomButton.MyCustomButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnManualGcodeSend = new MyCustomButton.MyCustomButton();
            this.label41 = new System.Windows.Forms.Label();
            this.txtManualGcode = new System.Windows.Forms.TextBox();
            this.btnHomeMove = new MyCustomButton.MyCustomButton();
            this.btnExtrude = new MyCustomButton.MyCustomButton();
            this.btnRetract = new MyCustomButton.MyCustomButton();
            this.btnZminus = new MyCustomButton.MyCustomButton();
            this.btnZPlus = new MyCustomButton.MyCustomButton();
            this.btnYPlus = new MyCustomButton.MyCustomButton();
            this.btnYMinus = new MyCustomButton.MyCustomButton();
            this.btnXPlus = new MyCustomButton.MyCustomButton();
            this.btnXMinus = new MyCustomButton.MyCustomButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInfoAktualise = new MyCustomButton.MyCustomButton();
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
            this.label22 = new System.Windows.Forms.Label();
            this.lblT3_5 = new System.Windows.Forms.Label();
            this.lblT2_5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer_temp = new System.Windows.Forms.Timer(this.components);
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.wrkerColdExtrusion = new System.ComponentModel.BackgroundWorker();
            this.wrkrCallG222 = new System.ComponentModel.BackgroundWorker();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.myCustomButton1 = new MyCustomButton.MyCustomButton();
            this.myCustomButton2 = new MyCustomButton.MyCustomButton();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.myCustomButton3 = new MyCustomButton.MyCustomButton();
            this.myCustomButton4 = new MyCustomButton.MyCustomButton();
            this.myCustomButton5 = new MyCustomButton.MyCustomButton();
            this.myCustomButton6 = new MyCustomButton.MyCustomButton();
            this.myCustomButton7 = new MyCustomButton.MyCustomButton();
            this.myCustomButton8 = new MyCustomButton.MyCustomButton();
            this.myCustomButton9 = new MyCustomButton.MyCustomButton();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.myCustomButton10 = new MyCustomButton.MyCustomButton();
            this.myCustomButton11 = new MyCustomButton.MyCustomButton();
            this.myCustomButton12 = new MyCustomButton.MyCustomButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.myCustomButton13 = new MyCustomButton.MyCustomButton();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myCustomButton14 = new MyCustomButton.MyCustomButton();
            this.myCustomButton15 = new MyCustomButton.MyCustomButton();
            this.myCustomButton16 = new MyCustomButton.MyCustomButton();
            this.myCustomButton17 = new MyCustomButton.MyCustomButton();
            this.myCustomButton18 = new MyCustomButton.MyCustomButton();
            this.myCustomButton19 = new MyCustomButton.MyCustomButton();
            this.myCustomButton20 = new MyCustomButton.MyCustomButton();
            this.myCustomButton21 = new MyCustomButton.MyCustomButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.myCustomButton22 = new MyCustomButton.MyCustomButton();
            this.myCustomButton23 = new MyCustomButton.MyCustomButton();
            this.myCustomButton24 = new MyCustomButton.MyCustomButton();
            this.label45 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.myCustomButton25 = new MyCustomButton.MyCustomButton();
            this.myCustomButton26 = new MyCustomButton.MyCustomButton();
            this.myCustomButton27 = new MyCustomButton.MyCustomButton();
            this.myCustomButton28 = new MyCustomButton.MyCustomButton();
            this.myCustomButton29 = new MyCustomButton.MyCustomButton();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.myCustomButton30 = new MyCustomButton.MyCustomButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.myCustomButton31 = new MyCustomButton.MyCustomButton();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.myCustomButton32 = new MyCustomButton.MyCustomButton();
            this.myCustomButton33 = new MyCustomButton.MyCustomButton();
            this.myCustomButton34 = new MyCustomButton.MyCustomButton();
            this.label78 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label80 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.myCustomButton35 = new MyCustomButton.MyCustomButton();
            this.myCustomButton36 = new MyCustomButton.MyCustomButton();
            this.myCustomButton37 = new MyCustomButton.MyCustomButton();
            this.myCustomButton38 = new MyCustomButton.MyCustomButton();
            this.myCustomButton39 = new MyCustomButton.MyCustomButton();
            this.myCustomButton40 = new MyCustomButton.MyCustomButton();
            this.myCustomButton41 = new MyCustomButton.MyCustomButton();
            this.myCustomButton42 = new MyCustomButton.MyCustomButton();
            this.myCustomButton43 = new MyCustomButton.MyCustomButton();
            this.myCustomButton44 = new MyCustomButton.MyCustomButton();
            this.myCustomButton45 = new MyCustomButton.MyCustomButton();
            this.myCustomButton46 = new MyCustomButton.MyCustomButton();
            this.myCustomButton47 = new MyCustomButton.MyCustomButton();
            this.myCustomButton48 = new MyCustomButton.MyCustomButton();
            this.myCustomButton49 = new MyCustomButton.MyCustomButton();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.myCustomButton50 = new MyCustomButton.MyCustomButton();
            this.label82 = new System.Windows.Forms.Label();
            this.label83 = new System.Windows.Forms.Label();
            this.label84 = new System.Windows.Forms.Label();
            this.label85 = new System.Windows.Forms.Label();
            this.label86 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label92 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label94 = new System.Windows.Forms.Label();
            this.label95 = new System.Windows.Forms.Label();
            this.label96 = new System.Windows.Forms.Label();
            this.label97 = new System.Windows.Forms.Label();
            this.label98 = new System.Windows.Forms.Label();
            this.label99 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
            this.label101 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label103 = new System.Windows.Forms.Label();
            this.label104 = new System.Windows.Forms.Label();
            this.label105 = new System.Windows.Forms.Label();
            this.label106 = new System.Windows.Forms.Label();
            this.label107 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label109 = new System.Windows.Forms.Label();
            this.label110 = new System.Windows.Forms.Label();
            this.label111 = new System.Windows.Forms.Label();
            this.label112 = new System.Windows.Forms.Label();
            this.label113 = new System.Windows.Forms.Label();
            this.label114 = new System.Windows.Forms.Label();
            this.label115 = new System.Windows.Forms.Label();
            this.label116 = new System.Windows.Forms.Label();
            this.label117 = new System.Windows.Forms.Label();
            this.label118 = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.label121 = new System.Windows.Forms.Label();
            this.label122 = new System.Windows.Forms.Label();
            this.label123 = new System.Windows.Forms.Label();
            this.label124 = new System.Windows.Forms.Label();
            this.label125 = new System.Windows.Forms.Label();
            this.label126 = new System.Windows.Forms.Label();
            this.label127 = new System.Windows.Forms.Label();
            this.label128 = new System.Windows.Forms.Label();
            this.label129 = new System.Windows.Forms.Label();
            this.label130 = new System.Windows.Forms.Label();
            this.label131 = new System.Windows.Forms.Label();
            this.label132 = new System.Windows.Forms.Label();
            this.label133 = new System.Windows.Forms.Label();
            this.label134 = new System.Windows.Forms.Label();
            this.label135 = new System.Windows.Forms.Label();
            this.label136 = new System.Windows.Forms.Label();
            this.label137 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label139 = new System.Windows.Forms.Label();
            this.label140 = new System.Windows.Forms.Label();
            this.label141 = new System.Windows.Forms.Label();
            this.label142 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label145 = new System.Windows.Forms.Label();
            this.label146 = new System.Windows.Forms.Label();
            this.label147 = new System.Windows.Forms.Label();
            this.label148 = new System.Windows.Forms.Label();
            this.label149 = new System.Windows.Forms.Label();
            this.label150 = new System.Windows.Forms.Label();
            this.label151 = new System.Windows.Forms.Label();
            this.label152 = new System.Windows.Forms.Label();
            this.label153 = new System.Windows.Forms.Label();
            this.label154 = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label156 = new System.Windows.Forms.Label();
            this.label157 = new System.Windows.Forms.Label();
            this.label158 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            tabpage2 = new System.Windows.Forms.TabPage();
            tabPage4 = new System.Windows.Forms.TabPage();
            tabpage2.SuspendLayout();
            this.druckPermissives.SuspendLayout();
            this.filamentUberwachung.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilAktualise)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T1)).BeginInit();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep50)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_NozzleTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BedTemp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TouchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlowrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFeedrate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXhome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBedMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBedPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNozzleMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNozzlePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBed_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0_OnOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParkMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMotorOff)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnManualGcodeSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomeMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtrude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetract)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZminus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXMinus)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoAktualise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton2)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton12)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton21)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton24)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton30)).BeginInit();
            tabPage4.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton31)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton49)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton50)).BeginInit();
            this.SuspendLayout();
            // 
            // tabpage2
            // 
            tabpage2.BackColor = System.Drawing.SystemColors.Control;
            tabpage2.Controls.Add(this.btnFilamentChange);
            tabpage2.Controls.Add(this.druckPermissives);
            tabpage2.Controls.Add(this.lblKalRotOffsetFilament);
            tabpage2.Controls.Add(this.lblWhen4Move_1);
            tabpage2.Controls.Add(this.lblRotOffFillVal);
            tabpage2.Controls.Add(this.label37);
            tabpage2.Controls.Add(this.filamentUberwachung);
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
            tabpage2.Location = new System.Drawing.Point(4, 4);
            tabpage2.Margin = new System.Windows.Forms.Padding(2);
            tabpage2.Name = "tabpage2";
            tabpage2.Padding = new System.Windows.Forms.Padding(2);
            tabpage2.Size = new System.Drawing.Size(581, 548);
            tabpage2.TabIndex = 1;
            tabpage2.Text = "Kalibrierung";
            // 
            // btnFilamentChange
            // 
            this.btnFilamentChange.Location = new System.Drawing.Point(80, 422);
            this.btnFilamentChange.Name = "btnFilamentChange";
            this.btnFilamentChange.Size = new System.Drawing.Size(100, 23);
            this.btnFilamentChange.TabIndex = 90;
            this.btnFilamentChange.Text = "Filament Change";
            this.btnFilamentChange.UseVisualStyleBackColor = true;
            this.btnFilamentChange.Click += new System.EventHandler(this.btnFilamentChange_Click);
            // 
            // druckPermissives
            // 
            this.druckPermissives.Controls.Add(this.radioBtnDrucker);
            this.druckPermissives.Controls.Add(this.radBtnMove);
            this.druckPermissives.Location = new System.Drawing.Point(5, 237);
            this.druckPermissives.Name = "druckPermissives";
            this.druckPermissives.Size = new System.Drawing.Size(133, 94);
            this.druckPermissives.TabIndex = 69;
            this.druckPermissives.TabStop = false;
            this.druckPermissives.Text = "Druck Permissives";
            // 
            // radioBtnDrucker
            // 
            this.radioBtnDrucker.AutoSize = true;
            this.radioBtnDrucker.Enabled = false;
            this.radioBtnDrucker.Location = new System.Drawing.Point(7, 58);
            this.radioBtnDrucker.Name = "radioBtnDrucker";
            this.radioBtnDrucker.Size = new System.Drawing.Size(111, 17);
            this.radioBtnDrucker.TabIndex = 1;
            this.radioBtnDrucker.TabStop = true;
            this.radioBtnDrucker.Text = "Drucker Initializiert";
            this.radioBtnDrucker.UseVisualStyleBackColor = true;
            // 
            // radBtnMove
            // 
            this.radBtnMove.AutoSize = true;
            this.radBtnMove.Enabled = false;
            this.radBtnMove.Location = new System.Drawing.Point(7, 29);
            this.radBtnMove.Name = "radBtnMove";
            this.radBtnMove.Size = new System.Drawing.Size(100, 17);
            this.radBtnMove.TabIndex = 0;
            this.radBtnMove.TabStop = true;
            this.radBtnMove.Text = "Move Initializiert";
            this.radBtnMove.UseVisualStyleBackColor = true;
            // 
            // lblKalRotOffsetFilament
            // 
            this.lblKalRotOffsetFilament.AutoSize = true;
            this.lblKalRotOffsetFilament.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKalRotOffsetFilament.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblKalRotOffsetFilament.Location = new System.Drawing.Point(294, 245);
            this.lblKalRotOffsetFilament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKalRotOffsetFilament.Name = "lblKalRotOffsetFilament";
            this.lblKalRotOffsetFilament.Size = new System.Drawing.Size(130, 15);
            this.lblKalRotOffsetFilament.TabIndex = 68;
            this.lblKalRotOffsetFilament.Text = "Rotational Offset Filament";
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
            this.label37.Location = new System.Drawing.Point(328, 183);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(64, 15);
            this.label37.TabIndex = 62;
            this.label37.Text = "T0 Abstand";
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
            this.filamentUberwachung.Location = new System.Drawing.Point(200, 305);
            this.filamentUberwachung.Name = "filamentUberwachung";
            this.filamentUberwachung.Size = new System.Drawing.Size(342, 206);
            this.filamentUberwachung.TabIndex = 60;
            this.filamentUberwachung.TabStop = false;
            this.filamentUberwachung.Text = "Filament Überwachung";
            // 
            // btnFilAktualise
            // 
            this.btnFilAktualise.BackColor = System.Drawing.Color.Transparent;
            this.btnFilAktualise.Image = global::MultecPlugin.Properties.Resources.Aktualizieren;
            this.btnFilAktualise.ImageClicked = global::MultecPlugin.Properties.Resources.Aktualizieren_p;
            this.btnFilAktualise.ImangeNormal = global::MultecPlugin.Properties.Resources.Aktualizieren;
            this.btnFilAktualise.Location = new System.Drawing.Point(239, 19);
            this.btnFilAktualise.Name = "btnFilAktualise";
            this.btnFilAktualise.Size = new System.Drawing.Size(97, 31);
            this.btnFilAktualise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFilAktualise.TabIndex = 82;
            this.btnFilAktualise.TabStop = false;
            this.btnFilAktualise.EnabledChanged += new System.EventHandler(this.btnFilAktualise_EnabledChanged);
            this.btnFilAktualise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnFilAktualise_MouseClick);
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
            this.lblT2_1.Location = new System.Drawing.Point(4, 138);
            this.lblT2_1.Name = "lblT2_1";
            this.lblT2_1.Size = new System.Drawing.Size(24, 16);
            this.lblT2_1.TabIndex = 8;
            this.lblT2_1.Text = "T2";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(4, 103);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(24, 16);
            this.label47.TabIndex = 7;
            this.label47.Text = "T1";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(4, 68);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(24, 16);
            this.label46.TabIndex = 6;
            this.label46.Text = "T0";
            // 
            // lblFilamentT3
            // 
            this.lblFilamentT3.AutoSize = true;
            this.lblFilamentT3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentT3.Location = new System.Drawing.Point(31, 167);
            this.lblFilamentT3.Name = "lblFilamentT3";
            this.lblFilamentT3.Size = new System.Drawing.Size(59, 26);
            this.lblFilamentT3.TabIndex = 5;
            this.lblFilamentT3.Text = "NULL";
            // 
            // lblFilamentT2
            // 
            this.lblFilamentT2.AutoSize = true;
            this.lblFilamentT2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentT2.Location = new System.Drawing.Point(31, 133);
            this.lblFilamentT2.Name = "lblFilamentT2";
            this.lblFilamentT2.Size = new System.Drawing.Size(59, 26);
            this.lblFilamentT2.TabIndex = 4;
            this.lblFilamentT2.Text = "NULL";
            // 
            // lblFilamentT0
            // 
            this.lblFilamentT0.AutoSize = true;
            this.lblFilamentT0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentT0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentT0.Location = new System.Drawing.Point(31, 63);
            this.lblFilamentT0.Name = "lblFilamentT0";
            this.lblFilamentT0.Size = new System.Drawing.Size(59, 26);
            this.lblFilamentT0.TabIndex = 3;
            this.lblFilamentT0.Text = "NULL";
            // 
            // lblFilamentT1
            // 
            this.lblFilamentT1.AutoSize = true;
            this.lblFilamentT1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentT1.Location = new System.Drawing.Point(31, 98);
            this.lblFilamentT1.Name = "lblFilamentT1";
            this.lblFilamentT1.Size = new System.Drawing.Size(59, 26);
            this.lblFilamentT1.TabIndex = 2;
            this.lblFilamentT1.Text = "NULL";
            // 
            // lblFilamentStatus
            // 
            this.lblFilamentStatus.AutoSize = true;
            this.lblFilamentStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFilamentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilamentStatus.Location = new System.Drawing.Point(31, 27);
            this.lblFilamentStatus.Name = "lblFilamentStatus";
            this.lblFilamentStatus.Size = new System.Drawing.Size(59, 26);
            this.lblFilamentStatus.TabIndex = 0;
            this.lblFilamentStatus.Text = "NULL";
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
            this.label38.Text = "#3";
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
            this.groupBox3.Text = "Werkzeug Auswahl";
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
            this.label13.Text = "#2";
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
            this.btnPositionPrufen.EnabledChanged += new System.EventHandler(this.btnPositionPrufen_EnabledChanged);
            this.btnPositionPrufen.Click += new System.EventHandler(this.btnPositionPrufen_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStep50);
            this.groupBox1.Controls.Add(this.btnStep10);
            this.groupBox1.Controls.Add(this.btnStep1);
            this.groupBox1.Location = new System.Drawing.Point(494, 89);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(68, 173);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance";
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMove);
            this.groupBox2.Controls.Add(this.btnT3);
            this.groupBox2.Controls.Add(this.btnT2);
            this.groupBox2.Controls.Add(this.btnT1);
            this.groupBox2.Controls.Add(this.btnT0);
            this.groupBox2.Location = new System.Drawing.Point(124, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Werkzeug Auswahl";
            // 
            // btnMove
            // 
            this.btnMove.BackColor = System.Drawing.Color.Transparent;
            this.btnMove.Image = global::MultecPlugin.Properties.Resources.MOVE;
            this.btnMove.ImageClicked = global::MultecPlugin.Properties.Resources.MOVE_p;
            this.btnMove.ImangeNormal = global::MultecPlugin.Properties.Resources.MOVE;
            this.btnMove.Location = new System.Drawing.Point(269, 19);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(60, 40);
            this.btnMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMove.TabIndex = 9;
            this.btnMove.TabStop = false;
            this.btnMove.EnabledChanged += new System.EventHandler(this.btnMove_EnabledChanged);
            this.btnMove.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMove_MouseClick);
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
            // trackBar_NozzleTemp
            // 
            this.trackBar_NozzleTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_NozzleTemp.Location = new System.Drawing.Point(195, 417);
            this.trackBar_NozzleTemp.Maximum = 270;
            this.trackBar_NozzleTemp.Minimum = 170;
            this.trackBar_NozzleTemp.Name = "trackBar_NozzleTemp";
            this.trackBar_NozzleTemp.Size = new System.Drawing.Size(197, 45);
            this.trackBar_NozzleTemp.SmallChange = 5;
            this.trackBar_NozzleTemp.TabIndex = 16;
            this.trackBar_NozzleTemp.TickFrequency = 5;
            this.trackBar_NozzleTemp.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_NozzleTemp.Value = 170;
            this.trackBar_NozzleTemp.ValueChanged += new System.EventHandler(this.trackBar_NozzleTemp_ValueChanged);
            // 
            // text_T0_ziel
            // 
            this.text_T0_ziel.Location = new System.Drawing.Point(131, 375);
            this.text_T0_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T0_ziel.Name = "text_T0_ziel";
            this.text_T0_ziel.ReadOnly = true;
            this.text_T0_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_T0_ziel.TabIndex = 19;
            this.text_T0_ziel.Text = "205";
            // 
            // text_T1_ziel
            // 
            this.text_T1_ziel.Location = new System.Drawing.Point(196, 375);
            this.text_T1_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T1_ziel.Name = "text_T1_ziel";
            this.text_T1_ziel.ReadOnly = true;
            this.text_T1_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_T1_ziel.TabIndex = 20;
            this.text_T1_ziel.Text = "205";
            // 
            // text_T2_ziel
            // 
            this.text_T2_ziel.Location = new System.Drawing.Point(262, 375);
            this.text_T2_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T2_ziel.Name = "text_T2_ziel";
            this.text_T2_ziel.ReadOnly = true;
            this.text_T2_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_T2_ziel.TabIndex = 21;
            this.text_T2_ziel.Text = "205";
            // 
            // text_T3_ziel
            // 
            this.text_T3_ziel.Location = new System.Drawing.Point(327, 375);
            this.text_T3_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T3_ziel.Name = "text_T3_ziel";
            this.text_T3_ziel.ReadOnly = true;
            this.text_T3_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_T3_ziel.TabIndex = 22;
            this.text_T3_ziel.Text = "205";
            // 
            // text_T0_Aktuell
            // 
            this.text_T0_Aktuell.Location = new System.Drawing.Point(131, 395);
            this.text_T0_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T0_Aktuell.Name = "text_T0_Aktuell";
            this.text_T0_Aktuell.ReadOnly = true;
            this.text_T0_Aktuell.Size = new System.Drawing.Size(61, 20);
            this.text_T0_Aktuell.TabIndex = 23;
            // 
            // text_T1_Aktuell
            // 
            this.text_T1_Aktuell.Location = new System.Drawing.Point(195, 396);
            this.text_T1_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T1_Aktuell.Name = "text_T1_Aktuell";
            this.text_T1_Aktuell.ReadOnly = true;
            this.text_T1_Aktuell.Size = new System.Drawing.Size(61, 20);
            this.text_T1_Aktuell.TabIndex = 24;
            // 
            // text_T2_Aktuell
            // 
            this.text_T2_Aktuell.Location = new System.Drawing.Point(262, 395);
            this.text_T2_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T2_Aktuell.Name = "text_T2_Aktuell";
            this.text_T2_Aktuell.ReadOnly = true;
            this.text_T2_Aktuell.Size = new System.Drawing.Size(61, 20);
            this.text_T2_Aktuell.TabIndex = 25;
            // 
            // text_T3_Aktuell
            // 
            this.text_T3_Aktuell.Location = new System.Drawing.Point(327, 396);
            this.text_T3_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T3_Aktuell.Name = "text_T3_Aktuell";
            this.text_T3_Aktuell.ReadOnly = true;
            this.text_T3_Aktuell.Size = new System.Drawing.Size(61, 20);
            this.text_T3_Aktuell.TabIndex = 26;
            // 
            // trackBar_BedTemp
            // 
            this.trackBar_BedTemp.AllowDrop = true;
            this.trackBar_BedTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_BedTemp.Enabled = false;
            this.trackBar_BedTemp.Location = new System.Drawing.Point(195, 475);
            this.trackBar_BedTemp.Maximum = 100;
            this.trackBar_BedTemp.Name = "trackBar_BedTemp";
            this.trackBar_BedTemp.Size = new System.Drawing.Size(197, 45);
            this.trackBar_BedTemp.SmallChange = 5;
            this.trackBar_BedTemp.TabIndex = 27;
            this.trackBar_BedTemp.TickFrequency = 5;
            this.trackBar_BedTemp.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar_BedTemp.Value = 50;
            this.trackBar_BedTemp.ValueChanged += new System.EventHandler(this.trackBar_BedTemp_ValueChanged);
            // 
            // text_Bed_ziel
            // 
            this.text_Bed_ziel.Location = new System.Drawing.Point(394, 375);
            this.text_Bed_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_Bed_ziel.Name = "text_Bed_ziel";
            this.text_Bed_ziel.ReadOnly = true;
            this.text_Bed_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_Bed_ziel.TabIndex = 31;
            this.text_Bed_ziel.Text = "60";
            // 
            // text_Bed_Aktuell
            // 
            this.text_Bed_Aktuell.Location = new System.Drawing.Point(394, 395);
            this.text_Bed_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_Bed_Aktuell.Name = "text_Bed_Aktuell";
            this.text_Bed_Aktuell.ReadOnly = true;
            this.text_Bed_Aktuell.Size = new System.Drawing.Size(61, 20);
            this.text_Bed_Aktuell.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(105, 380);
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
            this.label2.Location = new System.Drawing.Point(90, 398);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Aktuell";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(90, 426);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Duese";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(67, 439);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Temperatur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(68, 491);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Temperatur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(82, 478);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Heizbett";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(149, 325);
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
            this.label8.Location = new System.Drawing.Point(214, 326);
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
            this.lblT2.Location = new System.Drawing.Point(284, 326);
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
            this.lblT3.Location = new System.Drawing.Point(347, 326);
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
            this.label11.Location = new System.Drawing.Point(396, 325);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "Heizbett";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.AllowDrop = true;
            this.tabControl1.Controls.Add(this.TouchControl);
            this.tabControl1.Controls.Add(tabpage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl1.ItemSize = new System.Drawing.Size(183, 40);
            this.tabControl1.Location = new System.Drawing.Point(-1, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 596);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 47;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // TouchControl
            // 
            this.TouchControl.BackColor = System.Drawing.SystemColors.Control;
            this.TouchControl.Controls.Add(this.tabControl2);
            this.TouchControl.Controls.Add(this.trackBar2);
            this.TouchControl.Controls.Add(this.trackBar1);
            this.TouchControl.Controls.Add(this.lblFlowrate);
            this.TouchControl.Controls.Add(this.numericFlowrate);
            this.TouchControl.Controls.Add(this.lbFeedrate);
            this.TouchControl.Controls.Add(this.numericFeedrate);
            this.TouchControl.Controls.Add(this.btnZhome);
            this.TouchControl.Controls.Add(this.btnYhome);
            this.TouchControl.Controls.Add(this.btnXhome);
            this.TouchControl.Controls.Add(this.btnBedMinus);
            this.TouchControl.Controls.Add(this.btnBedPlus);
            this.TouchControl.Controls.Add(this.btnNozzleMinus);
            this.TouchControl.Controls.Add(this.btnNozzlePlus);
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
            this.TouchControl.Controls.Add(this.label5);
            this.TouchControl.Controls.Add(this.label6);
            this.TouchControl.Controls.Add(this.label4);
            this.TouchControl.Controls.Add(this.label3);
            this.TouchControl.Controls.Add(this.label2);
            this.TouchControl.Controls.Add(this.groupBox2);
            this.TouchControl.Controls.Add(this.label1);
            this.TouchControl.Controls.Add(this.text_Bed_Aktuell);
            this.TouchControl.Controls.Add(this.text_Bed_ziel);
            this.TouchControl.Controls.Add(this.trackBar_BedTemp);
            this.TouchControl.Controls.Add(this.text_T3_Aktuell);
            this.TouchControl.Controls.Add(this.trackBar_NozzleTemp);
            this.TouchControl.Controls.Add(this.text_T2_Aktuell);
            this.TouchControl.Controls.Add(this.text_T1_Aktuell);
            this.TouchControl.Controls.Add(this.text_T0_Aktuell);
            this.TouchControl.Controls.Add(this.text_T0_ziel);
            this.TouchControl.Controls.Add(this.text_T3_ziel);
            this.TouchControl.Controls.Add(this.text_T1_ziel);
            this.TouchControl.Controls.Add(this.text_T2_ziel);
            this.TouchControl.Controls.Add(this.btnXMinus);
            this.TouchControl.Location = new System.Drawing.Point(4, 4);
            this.TouchControl.Name = "TouchControl";
            this.TouchControl.Padding = new System.Windows.Forms.Padding(3);
            this.TouchControl.Size = new System.Drawing.Size(581, 548);
            this.TouchControl.TabIndex = 0;
            this.TouchControl.Text = "Touch Controls";
            // 
            // lblFlowrate
            // 
            this.lblFlowrate.Location = new System.Drawing.Point(494, 43);
            this.lblFlowrate.Name = "lblFlowrate";
            this.lblFlowrate.Size = new System.Drawing.Size(91, 28);
            this.lblFlowrate.TabIndex = 79;
            this.lblFlowrate.Text = "Flowrate Percentage";
            // 
            // numericFlowrate
            // 
            this.numericFlowrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFlowrate.Location = new System.Drawing.Point(494, 23);
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
            this.numericFlowrate.Size = new System.Drawing.Size(57, 24);
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
            this.lbFeedrate.Location = new System.Drawing.Point(77, 249);
            this.lbFeedrate.Name = "lbFeedrate";
            this.lbFeedrate.Size = new System.Drawing.Size(91, 28);
            this.lbFeedrate.TabIndex = 0;
            this.lbFeedrate.Text = "Feedrate Percentage";
            // 
            // numericFeedrate
            // 
            this.numericFeedrate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericFeedrate.Location = new System.Drawing.Point(72, 222);
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
            this.numericFeedrate.Size = new System.Drawing.Size(57, 24);
            this.numericFeedrate.TabIndex = 78;
            this.numericFeedrate.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericFeedrate.ValueChanged += new System.EventHandler(this.numericFeedrate_ValueChanged);
            // 
            // btnZhome
            // 
            this.btnZhome.BackColor = System.Drawing.Color.Transparent;
            this.btnZhome.Image = global::MultecPlugin.Properties.Resources.Zhome;
            this.btnZhome.ImageClicked = global::MultecPlugin.Properties.Resources.Zhome_p;
            this.btnZhome.ImangeNormal = global::MultecPlugin.Properties.Resources.Zhome;
            this.btnZhome.Location = new System.Drawing.Point(6, 229);
            this.btnZhome.Name = "btnZhome";
            this.btnZhome.Size = new System.Drawing.Size(60, 58);
            this.btnZhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZhome.TabIndex = 77;
            this.btnZhome.TabStop = false;
            this.btnZhome.EnabledChanged += new System.EventHandler(this.btnZhome_EnabledChanged);
            this.btnZhome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnZhome_MouseClick);
            // 
            // btnYhome
            // 
            this.btnYhome.BackColor = System.Drawing.Color.Transparent;
            this.btnYhome.Image = global::MultecPlugin.Properties.Resources.Yhome;
            this.btnYhome.ImageClicked = global::MultecPlugin.Properties.Resources.Yhome_p;
            this.btnYhome.ImangeNormal = global::MultecPlugin.Properties.Resources.Yhome;
            this.btnYhome.Location = new System.Drawing.Point(6, 165);
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
            this.btnXhome.Location = new System.Drawing.Point(6, 101);
            this.btnXhome.Name = "btnXhome";
            this.btnXhome.Size = new System.Drawing.Size(60, 58);
            this.btnXhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXhome.TabIndex = 75;
            this.btnXhome.TabStop = false;
            this.btnXhome.EnabledChanged += new System.EventHandler(this.btnXhome_EnabledChanged);
            this.btnXhome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnXhome_MouseClick);
            // 
            // btnBedMinus
            // 
            this.btnBedMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnBedMinus.Image = global::MultecPlugin.Properties.Resources.minus51;
            this.btnBedMinus.ImageClicked = global::MultecPlugin.Properties.Resources.minus5_p1;
            this.btnBedMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.minus51;
            this.btnBedMinus.Location = new System.Drawing.Point(132, 468);
            this.btnBedMinus.Name = "btnBedMinus";
            this.btnBedMinus.Size = new System.Drawing.Size(60, 45);
            this.btnBedMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBedMinus.TabIndex = 74;
            this.btnBedMinus.TabStop = false;
            this.btnBedMinus.EnabledChanged += new System.EventHandler(this.btnBedMinus_EnabledChanged);
            this.btnBedMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBedMinus_MouseClick);
            // 
            // btnBedPlus
            // 
            this.btnBedPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnBedPlus.Image = global::MultecPlugin.Properties.Resources.plus5;
            this.btnBedPlus.ImageClicked = global::MultecPlugin.Properties.Resources.plus5_p;
            this.btnBedPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.plus5;
            this.btnBedPlus.Location = new System.Drawing.Point(394, 468);
            this.btnBedPlus.Name = "btnBedPlus";
            this.btnBedPlus.Size = new System.Drawing.Size(60, 45);
            this.btnBedPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBedPlus.TabIndex = 73;
            this.btnBedPlus.TabStop = false;
            this.btnBedPlus.EnabledChanged += new System.EventHandler(this.btnBedPlus_EnabledChanged);
            this.btnBedPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnBedPlus_MouseClick);
            // 
            // btnNozzleMinus
            // 
            this.btnNozzleMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnNozzleMinus.Image = ((System.Drawing.Image)(resources.GetObject("btnNozzleMinus.Image")));
            this.btnNozzleMinus.ImageClicked = global::MultecPlugin.Properties.Resources.minus5_p1;
            this.btnNozzleMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.minus51;
            this.btnNozzleMinus.Location = new System.Drawing.Point(131, 417);
            this.btnNozzleMinus.Name = "btnNozzleMinus";
            this.btnNozzleMinus.Size = new System.Drawing.Size(60, 45);
            this.btnNozzleMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNozzleMinus.TabIndex = 72;
            this.btnNozzleMinus.TabStop = false;
            this.btnNozzleMinus.EnabledChanged += new System.EventHandler(this.btnNozzleMinus_EnabledChanged);
            this.btnNozzleMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNozzleMinus_MouseClick);
            // 
            // btnNozzlePlus
            // 
            this.btnNozzlePlus.BackColor = System.Drawing.Color.Transparent;
            this.btnNozzlePlus.Image = global::MultecPlugin.Properties.Resources.plus5;
            this.btnNozzlePlus.ImageClicked = global::MultecPlugin.Properties.Resources.plus5_p;
            this.btnNozzlePlus.ImangeNormal = global::MultecPlugin.Properties.Resources.plus5;
            this.btnNozzlePlus.Location = new System.Drawing.Point(394, 417);
            this.btnNozzlePlus.Name = "btnNozzlePlus";
            this.btnNozzlePlus.Size = new System.Drawing.Size(60, 45);
            this.btnNozzlePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnNozzlePlus.TabIndex = 71;
            this.btnNozzlePlus.TabStop = false;
            this.btnNozzlePlus.EnabledChanged += new System.EventHandler(this.btnNozzlePlus_EnabledChanged);
            this.btnNozzlePlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnNozzlePlus_MouseClick);
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(346, 58);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(17, 13);
            this.lblZ.TabIndex = 70;
            this.lblZ.Text = "Z:";
            // 
            // lblYPosition
            // 
            this.lblYPosition.AutoSize = true;
            this.lblYPosition.Location = new System.Drawing.Point(205, 58);
            this.lblYPosition.Name = "lblYPosition";
            this.lblYPosition.Size = new System.Drawing.Size(108, 13);
            this.lblYPosition.TabIndex = 69;
            this.lblYPosition.Text = "NICHT INITILISIERT";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(182, 58);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(17, 13);
            this.lblY.TabIndex = 68;
            this.lblY.Text = "Y:";
            // 
            // lblZPosition
            // 
            this.lblZPosition.AutoSize = true;
            this.lblZPosition.Location = new System.Drawing.Point(369, 58);
            this.lblZPosition.Name = "lblZPosition";
            this.lblZPosition.Size = new System.Drawing.Size(108, 13);
            this.lblZPosition.TabIndex = 67;
            this.lblZPosition.Text = "NICHT INITILISIERT";
            // 
            // lblXPosition
            // 
            this.lblXPosition.AutoSize = true;
            this.lblXPosition.Location = new System.Drawing.Point(48, 58);
            this.lblXPosition.Name = "lblXPosition";
            this.lblXPosition.Size = new System.Drawing.Size(115, 13);
            this.lblXPosition.TabIndex = 66;
            this.lblXPosition.Text = "NICHT INITIALISIERT";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(25, 58);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(17, 13);
            this.lblX.TabIndex = 65;
            this.lblX.Text = "X:";
            // 
            // chckBoxDruckerende
            // 
            this.chckBoxDruckerende.AutoSize = true;
            this.chckBoxDruckerende.Location = new System.Drawing.Point(23, 75);
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
            this.btnBed_OnOff.Location = new System.Drawing.Point(394, 340);
            this.btnBed_OnOff.Name = "btnBed_OnOff";
            this.btnBed_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnBed_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBed_OnOff.TabIndex = 63;
            this.btnBed_OnOff.TabStop = false;
            this.btnBed_OnOff.EnabledChanged += new System.EventHandler(this.btnBed_OnOff_EnabledChanged);
            this.btnBed_OnOff.Click += new System.EventHandler(this.btnBed_OnOff_Click);
            this.btnBed_OnOff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnBed_OnOff_MouseMove);
            // 
            // btnT3_OnOff
            // 
            this.btnT3_OnOff.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.btnT3_OnOff.Location = new System.Drawing.Point(328, 340);
            this.btnT3_OnOff.Name = "btnT3_OnOff";
            this.btnT3_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnT3_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT3_OnOff.TabIndex = 62;
            this.btnT3_OnOff.TabStop = false;
            this.btnT3_OnOff.EnabledChanged += new System.EventHandler(this.btnT3_OnOff_EnabledChanged);
            this.btnT3_OnOff.Click += new System.EventHandler(this.btnT3_OnOff_Click);
            this.btnT3_OnOff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnT3_OnOff_MouseMove);
            // 
            // btnT2_OnOff
            // 
            this.btnT2_OnOff.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.btnT2_OnOff.Location = new System.Drawing.Point(262, 340);
            this.btnT2_OnOff.Name = "btnT2_OnOff";
            this.btnT2_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnT2_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT2_OnOff.TabIndex = 61;
            this.btnT2_OnOff.TabStop = false;
            this.btnT2_OnOff.EnabledChanged += new System.EventHandler(this.btnT2_OnOff_EnabledChanged);
            this.btnT2_OnOff.Click += new System.EventHandler(this.btnT2_OnOff_Click);
            this.btnT2_OnOff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnT2_OnOff_MouseMove);
            // 
            // btnT1_OnOff
            // 
            this.btnT1_OnOff.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.btnT1_OnOff.Location = new System.Drawing.Point(196, 340);
            this.btnT1_OnOff.Name = "btnT1_OnOff";
            this.btnT1_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnT1_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT1_OnOff.TabIndex = 60;
            this.btnT1_OnOff.TabStop = false;
            this.btnT1_OnOff.EnabledChanged += new System.EventHandler(this.btnT1_OnOff_EnabledChanged);
            this.btnT1_OnOff.Click += new System.EventHandler(this.btnT1_OnOff_Click);
            this.btnT1_OnOff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnT1_OnOff_MouseMove);
            // 
            // btnT0_OnOff
            // 
            this.btnT0_OnOff.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.btnT0_OnOff.Location = new System.Drawing.Point(130, 340);
            this.btnT0_OnOff.Name = "btnT0_OnOff";
            this.btnT0_OnOff.Size = new System.Drawing.Size(60, 30);
            this.btnT0_OnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnT0_OnOff.TabIndex = 59;
            this.btnT0_OnOff.TabStop = false;
            this.btnT0_OnOff.EnabledChanged += new System.EventHandler(this.btnT0_OnOff_EnabledChanged);
            this.btnT0_OnOff.Click += new System.EventHandler(this.btnT0_OnOff_Click);
            this.btnT0_OnOff.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnT0_OnOff_MouseMove);
            // 
            // btnParkMove
            // 
            this.btnParkMove.BackColor = System.Drawing.Color.Transparent;
            this.btnParkMove.Image = global::MultecPlugin.Properties.Resources.Park_Move;
            this.btnParkMove.ImageClicked = global::MultecPlugin.Properties.Resources.Park_Move_p;
            this.btnParkMove.ImangeNormal = global::MultecPlugin.Properties.Resources.Park_Move;
            this.btnParkMove.Location = new System.Drawing.Point(6, 484);
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
            this.btnHome.Location = new System.Drawing.Point(6, 293);
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
            this.btnMotorOff.Location = new System.Drawing.Point(6, 357);
            this.btnMotorOff.Name = "btnMotorOff";
            this.btnMotorOff.Size = new System.Drawing.Size(60, 58);
            this.btnMotorOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMotorOff.TabIndex = 57;
            this.btnMotorOff.TabStop = false;
            this.btnMotorOff.EnabledChanged += new System.EventHandler(this.btnMotorOff_EnabledChanged);
            this.btnMotorOff.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnMotorOff_MouseClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnManualGcodeSend);
            this.groupBox5.Controls.Add(this.label41);
            this.groupBox5.Controls.Add(this.txtManualGcode);
            this.groupBox5.Location = new System.Drawing.Point(23, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(457, 46);
            this.groupBox5.TabIndex = 56;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Manual Command";
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
            // btnHomeMove
            // 
            this.btnHomeMove.BackColor = System.Drawing.Color.Transparent;
            this.btnHomeMove.Image = ((System.Drawing.Image)(resources.GetObject("btnHomeMove.Image")));
            this.btnHomeMove.ImageClicked = global::MultecPlugin.Properties.Resources.HOME_Move_p;
            this.btnHomeMove.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("btnHomeMove.ImangeNormal")));
            this.btnHomeMove.Location = new System.Drawing.Point(6, 421);
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
            this.btnExtrude.Location = new System.Drawing.Point(398, 176);
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
            this.btnRetract.Location = new System.Drawing.Point(398, 100);
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
            this.btnZminus.Location = new System.Drawing.Point(309, 176);
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
            this.btnZPlus.Location = new System.Drawing.Point(309, 100);
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
            this.btnYPlus.Location = new System.Drawing.Point(158, 100);
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
            this.btnYMinus.Location = new System.Drawing.Point(158, 176);
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
            this.btnXPlus.Location = new System.Drawing.Point(230, 138);
            this.btnXPlus.Name = "btnXPlus";
            this.btnXPlus.Size = new System.Drawing.Size(70, 70);
            this.btnXPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXPlus.TabIndex = 49;
            this.btnXPlus.TabStop = false;
            this.btnXPlus.EnabledChanged += new System.EventHandler(this.btnXPlus_EnabledChanged);
            this.btnXPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton3_Click);
            // 
            // btnXMinus
            // 
            this.btnXMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnXMinus.Image = global::MultecPlugin.Properties.Resources.Xminus;
            this.btnXMinus.ImageClicked = global::MultecPlugin.Properties.Resources.Xminus_p;
            this.btnXMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.Xminus;
            this.btnXMinus.Location = new System.Drawing.Point(85, 138);
            this.btnXMinus.Name = "btnXMinus";
            this.btnXMinus.Size = new System.Drawing.Size(70, 70);
            this.btnXMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXMinus.TabIndex = 47;
            this.btnXMinus.TabStop = false;
            this.btnXMinus.EnabledChanged += new System.EventHandler(this.btnXMinus_EnabledChanged);
            this.btnXMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.btnInfoAktualise);
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
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.lblT3_5);
            this.tabPage1.Controls.Add(this.lblT2_5);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 548);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Information";
            // 
            // btnInfoAktualise
            // 
            this.btnInfoAktualise.BackColor = System.Drawing.Color.Transparent;
            this.btnInfoAktualise.Image = global::MultecPlugin.Properties.Resources.Aktualizieren;
            this.btnInfoAktualise.ImageClicked = global::MultecPlugin.Properties.Resources.Aktualizieren_p;
            this.btnInfoAktualise.ImangeNormal = global::MultecPlugin.Properties.Resources.Aktualizieren;
            this.btnInfoAktualise.Location = new System.Drawing.Point(6, 16);
            this.btnInfoAktualise.Name = "btnInfoAktualise";
            this.btnInfoAktualise.Size = new System.Drawing.Size(107, 36);
            this.btnInfoAktualise.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInfoAktualise.TabIndex = 119;
            this.btnInfoAktualise.TabStop = false;
            this.btnInfoAktualise.EnabledChanged += new System.EventHandler(this.btnInfoAktualise_EnabledChanged);
            this.btnInfoAktualise.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnInfoAktualise_MouseClick);
            // 
            // lblRotOffsetFilament
            // 
            this.lblRotOffsetFilament.AutoSize = true;
            this.lblRotOffsetFilament.BackColor = System.Drawing.SystemColors.Control;
            this.lblRotOffsetFilament.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotOffsetFilament.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRotOffsetFilament.Location = new System.Drawing.Point(461, 89);
            this.lblRotOffsetFilament.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotOffsetFilament.Name = "lblRotOffsetFilament";
            this.lblRotOffsetFilament.Size = new System.Drawing.Size(31, 13);
            this.lblRotOffsetFilament.TabIndex = 118;
            this.lblRotOffsetFilament.Text = "NULL";
            // 
            // lblWhen4Move
            // 
            this.lblWhen4Move.AutoSize = true;
            this.lblWhen4Move.BackColor = System.Drawing.SystemColors.Control;
            this.lblWhen4Move.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhen4Move.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblWhen4Move.Location = new System.Drawing.Point(204, 89);
            this.lblWhen4Move.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhen4Move.Name = "lblWhen4Move";
            this.lblWhen4Move.Size = new System.Drawing.Size(235, 13);
            this.lblWhen4Move.TabIndex = 117;
            this.lblWhen4Move.Text = "Rotational Offset Filamentauswahl (mm)";
            // 
            // lblZKorrektur
            // 
            this.lblZKorrektur.AutoSize = true;
            this.lblZKorrektur.BackColor = System.Drawing.SystemColors.Control;
            this.lblZKorrektur.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZKorrektur.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblZKorrektur.Location = new System.Drawing.Point(461, 134);
            this.lblZKorrektur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZKorrektur.Name = "lblZKorrektur";
            this.lblZKorrektur.Size = new System.Drawing.Size(31, 13);
            this.lblZKorrektur.TabIndex = 116;
            this.lblZKorrektur.Text = "NULL";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.SystemColors.Control;
            this.label43.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label43.Location = new System.Drawing.Point(330, 134);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(109, 13);
            this.label43.TabIndex = 115;
            this.label43.Text = "Z-Correction (mm)";
            // 
            // lblDisatance
            // 
            this.lblDisatance.AutoSize = true;
            this.lblDisatance.BackColor = System.Drawing.SystemColors.Control;
            this.lblDisatance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisatance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDisatance.Location = new System.Drawing.Point(461, 104);
            this.lblDisatance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisatance.Name = "lblDisatance";
            this.lblDisatance.Size = new System.Drawing.Size(31, 13);
            this.lblDisatance.TabIndex = 114;
            this.lblDisatance.Text = "NULL";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.SystemColors.Control;
            this.label40.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label40.Location = new System.Drawing.Point(246, 104);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(193, 13);
            this.label40.TabIndex = 113;
            this.label40.Text = "Distance T0 <-> Multisense (mm)";
            // 
            // lblOptimalDistance
            // 
            this.lblOptimalDistance.AutoSize = true;
            this.lblOptimalDistance.BackColor = System.Drawing.SystemColors.Control;
            this.lblOptimalDistance.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptimalDistance.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblOptimalDistance.Location = new System.Drawing.Point(461, 119);
            this.lblOptimalDistance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOptimalDistance.Name = "lblOptimalDistance";
            this.lblOptimalDistance.Size = new System.Drawing.Size(31, 13);
            this.lblOptimalDistance.TabIndex = 112;
            this.lblOptimalDistance.Text = "NULL";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.SystemColors.Control;
            this.label42.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label42.Location = new System.Drawing.Point(198, 119);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(241, 13);
            this.label42.TabIndex = 111;
            this.label42.Text = "Optimal Distance T0 <-> Multisense (mm)";
            // 
            // lblRotationalOffset
            // 
            this.lblRotationalOffset.AutoSize = true;
            this.lblRotationalOffset.BackColor = System.Drawing.SystemColors.Control;
            this.lblRotationalOffset.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRotationalOffset.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblRotationalOffset.Location = new System.Drawing.Point(461, 74);
            this.lblRotationalOffset.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRotationalOffset.Name = "lblRotationalOffset";
            this.lblRotationalOffset.Size = new System.Drawing.Size(31, 13);
            this.lblRotationalOffset.TabIndex = 110;
            this.lblRotationalOffset.Text = "NULL";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.SystemColors.Control;
            this.label39.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label39.Location = new System.Drawing.Point(216, 74);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(223, 13);
            this.label39.TabIndex = 109;
            this.label39.Text = "Rotational Offset Move Extruder (mm)";
            // 
            // lblKgSrvcT3
            // 
            this.lblKgSrvcT3.AutoSize = true;
            this.lblKgSrvcT3.BackColor = System.Drawing.SystemColors.Control;
            this.lblKgSrvcT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgSrvcT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgSrvcT3.Location = new System.Drawing.Point(372, 379);
            this.lblKgSrvcT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgSrvcT3.Name = "lblKgSrvcT3";
            this.lblKgSrvcT3.Size = new System.Drawing.Size(31, 13);
            this.lblKgSrvcT3.TabIndex = 108;
            this.lblKgSrvcT3.Text = "NULL";
            // 
            // lblKgSrvcT2
            // 
            this.lblKgSrvcT2.AutoSize = true;
            this.lblKgSrvcT2.BackColor = System.Drawing.SystemColors.Control;
            this.lblKgSrvcT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgSrvcT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgSrvcT2.Location = new System.Drawing.Point(372, 364);
            this.lblKgSrvcT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgSrvcT2.Name = "lblKgSrvcT2";
            this.lblKgSrvcT2.Size = new System.Drawing.Size(31, 13);
            this.lblKgSrvcT2.TabIndex = 107;
            this.lblKgSrvcT2.Text = "NULL";
            // 
            // lblKgSrvcT1
            // 
            this.lblKgSrvcT1.AutoSize = true;
            this.lblKgSrvcT1.BackColor = System.Drawing.SystemColors.Control;
            this.lblKgSrvcT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgSrvcT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgSrvcT1.Location = new System.Drawing.Point(372, 349);
            this.lblKgSrvcT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgSrvcT1.Name = "lblKgSrvcT1";
            this.lblKgSrvcT1.Size = new System.Drawing.Size(31, 13);
            this.lblKgSrvcT1.TabIndex = 106;
            this.lblKgSrvcT1.Text = "NULL";
            // 
            // lblKgSrvcT0
            // 
            this.lblKgSrvcT0.AutoSize = true;
            this.lblKgSrvcT0.BackColor = System.Drawing.SystemColors.Control;
            this.lblKgSrvcT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgSrvcT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgSrvcT0.Location = new System.Drawing.Point(372, 334);
            this.lblKgSrvcT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgSrvcT0.Name = "lblKgSrvcT0";
            this.lblKgSrvcT0.Size = new System.Drawing.Size(31, 13);
            this.lblKgSrvcT0.TabIndex = 105;
            this.lblKgSrvcT0.Text = "NULL";
            // 
            // lblHeatedSrvcT3
            // 
            this.lblHeatedSrvcT3.AutoSize = true;
            this.lblHeatedSrvcT3.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeatedSrvcT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedSrvcT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedSrvcT3.Location = new System.Drawing.Point(372, 443);
            this.lblHeatedSrvcT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedSrvcT3.Name = "lblHeatedSrvcT3";
            this.lblHeatedSrvcT3.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedSrvcT3.TabIndex = 104;
            this.lblHeatedSrvcT3.Text = "NULL";
            // 
            // lblHeatedSrvcT2
            // 
            this.lblHeatedSrvcT2.AutoSize = true;
            this.lblHeatedSrvcT2.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeatedSrvcT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedSrvcT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedSrvcT2.Location = new System.Drawing.Point(372, 428);
            this.lblHeatedSrvcT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedSrvcT2.Name = "lblHeatedSrvcT2";
            this.lblHeatedSrvcT2.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedSrvcT2.TabIndex = 103;
            this.lblHeatedSrvcT2.Text = "NULL";
            // 
            // lblHeatedSrvcT1
            // 
            this.lblHeatedSrvcT1.AutoSize = true;
            this.lblHeatedSrvcT1.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeatedSrvcT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedSrvcT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedSrvcT1.Location = new System.Drawing.Point(372, 413);
            this.lblHeatedSrvcT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedSrvcT1.Name = "lblHeatedSrvcT1";
            this.lblHeatedSrvcT1.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedSrvcT1.TabIndex = 102;
            this.lblHeatedSrvcT1.Text = "NULL";
            // 
            // lblHeatedSrvcT0
            // 
            this.lblHeatedSrvcT0.AutoSize = true;
            this.lblHeatedSrvcT0.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeatedSrvcT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedSrvcT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedSrvcT0.Location = new System.Drawing.Point(372, 398);
            this.lblHeatedSrvcT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedSrvcT0.Name = "lblHeatedSrvcT0";
            this.lblHeatedSrvcT0.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedSrvcT0.TabIndex = 101;
            this.lblHeatedSrvcT0.Text = "NULL";
            // 
            // lblExtrudedSrvcT3
            // 
            this.lblExtrudedSrvcT3.AutoSize = true;
            this.lblExtrudedSrvcT3.BackColor = System.Drawing.SystemColors.Control;
            this.lblExtrudedSrvcT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedSrvcT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedSrvcT3.Location = new System.Drawing.Point(372, 319);
            this.lblExtrudedSrvcT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedSrvcT3.Name = "lblExtrudedSrvcT3";
            this.lblExtrudedSrvcT3.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedSrvcT3.TabIndex = 100;
            this.lblExtrudedSrvcT3.Text = "NULL";
            // 
            // lblExtrudedSrvcT2
            // 
            this.lblExtrudedSrvcT2.AutoSize = true;
            this.lblExtrudedSrvcT2.BackColor = System.Drawing.SystemColors.Control;
            this.lblExtrudedSrvcT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedSrvcT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedSrvcT2.Location = new System.Drawing.Point(372, 304);
            this.lblExtrudedSrvcT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedSrvcT2.Name = "lblExtrudedSrvcT2";
            this.lblExtrudedSrvcT2.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedSrvcT2.TabIndex = 99;
            this.lblExtrudedSrvcT2.Text = "NULL";
            // 
            // lblExtrudedSrvcT1
            // 
            this.lblExtrudedSrvcT1.AutoSize = true;
            this.lblExtrudedSrvcT1.BackColor = System.Drawing.SystemColors.Control;
            this.lblExtrudedSrvcT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedSrvcT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedSrvcT1.Location = new System.Drawing.Point(372, 289);
            this.lblExtrudedSrvcT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedSrvcT1.Name = "lblExtrudedSrvcT1";
            this.lblExtrudedSrvcT1.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedSrvcT1.TabIndex = 98;
            this.lblExtrudedSrvcT1.Text = "NULL";
            // 
            // lblExtrudedSrvcT0
            // 
            this.lblExtrudedSrvcT0.AutoSize = true;
            this.lblExtrudedSrvcT0.BackColor = System.Drawing.SystemColors.Control;
            this.lblExtrudedSrvcT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedSrvcT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedSrvcT0.Location = new System.Drawing.Point(372, 274);
            this.lblExtrudedSrvcT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedSrvcT0.Name = "lblExtrudedSrvcT0";
            this.lblExtrudedSrvcT0.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedSrvcT0.TabIndex = 97;
            this.lblExtrudedSrvcT0.Text = "NULL";
            // 
            // lblSrvcDistanceZ
            // 
            this.lblSrvcDistanceZ.AutoSize = true;
            this.lblSrvcDistanceZ.BackColor = System.Drawing.SystemColors.Control;
            this.lblSrvcDistanceZ.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcDistanceZ.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcDistanceZ.Location = new System.Drawing.Point(372, 253);
            this.lblSrvcDistanceZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcDistanceZ.Name = "lblSrvcDistanceZ";
            this.lblSrvcDistanceZ.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcDistanceZ.TabIndex = 96;
            this.lblSrvcDistanceZ.Text = "NULL";
            // 
            // lblSrvcDistanceY
            // 
            this.lblSrvcDistanceY.AutoSize = true;
            this.lblSrvcDistanceY.BackColor = System.Drawing.SystemColors.Control;
            this.lblSrvcDistanceY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcDistanceY.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcDistanceY.Location = new System.Drawing.Point(372, 239);
            this.lblSrvcDistanceY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcDistanceY.Name = "lblSrvcDistanceY";
            this.lblSrvcDistanceY.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcDistanceY.TabIndex = 95;
            this.lblSrvcDistanceY.Text = "NULL";
            // 
            // lblSrvcDistanceX
            // 
            this.lblSrvcDistanceX.AutoSize = true;
            this.lblSrvcDistanceX.BackColor = System.Drawing.SystemColors.Control;
            this.lblSrvcDistanceX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcDistanceX.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcDistanceX.Location = new System.Drawing.Point(372, 224);
            this.lblSrvcDistanceX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcDistanceX.Name = "lblSrvcDistanceX";
            this.lblSrvcDistanceX.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcDistanceX.TabIndex = 94;
            this.lblSrvcDistanceX.Text = "NULL";
            // 
            // lblSrvcPrntLife
            // 
            this.lblSrvcPrntLife.AutoSize = true;
            this.lblSrvcPrntLife.BackColor = System.Drawing.SystemColors.Control;
            this.lblSrvcPrntLife.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcPrntLife.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcPrntLife.Location = new System.Drawing.Point(372, 202);
            this.lblSrvcPrntLife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcPrntLife.Name = "lblSrvcPrntLife";
            this.lblSrvcPrntLife.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcPrntLife.TabIndex = 93;
            this.lblSrvcPrntLife.Text = "NULL";
            // 
            // lblSrvcPwrON
            // 
            this.lblSrvcPwrON.AutoSize = true;
            this.lblSrvcPwrON.BackColor = System.Drawing.SystemColors.Control;
            this.lblSrvcPwrON.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcPwrON.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcPwrON.Location = new System.Drawing.Point(372, 187);
            this.lblSrvcPwrON.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcPwrON.Name = "lblSrvcPwrON";
            this.lblSrvcPwrON.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcPwrON.TabIndex = 92;
            this.lblSrvcPwrON.Text = "NULL";
            // 
            // lblSrvcPwrCycle
            // 
            this.lblSrvcPwrCycle.AutoSize = true;
            this.lblSrvcPwrCycle.BackColor = System.Drawing.SystemColors.Control;
            this.lblSrvcPwrCycle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSrvcPwrCycle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSrvcPwrCycle.Location = new System.Drawing.Point(372, 172);
            this.lblSrvcPwrCycle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcPwrCycle.Name = "lblSrvcPwrCycle";
            this.lblSrvcPwrCycle.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcPwrCycle.TabIndex = 91;
            this.lblSrvcPwrCycle.Text = "NULL";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.SystemColors.Control;
            this.label70.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label70.Location = new System.Drawing.Point(302, 157);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(181, 13);
            this.label70.TabIndex = 90;
            this.label70.Text = "Lifetime (Since Last Service)";
            // 
            // lblKgTotalT3
            // 
            this.lblKgTotalT3.AutoSize = true;
            this.lblKgTotalT3.BackColor = System.Drawing.SystemColors.Control;
            this.lblKgTotalT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgTotalT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgTotalT3.Location = new System.Drawing.Point(178, 379);
            this.lblKgTotalT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgTotalT3.Name = "lblKgTotalT3";
            this.lblKgTotalT3.Size = new System.Drawing.Size(31, 13);
            this.lblKgTotalT3.TabIndex = 89;
            this.lblKgTotalT3.Text = "NULL";
            // 
            // lblKgTotalT2
            // 
            this.lblKgTotalT2.AutoSize = true;
            this.lblKgTotalT2.BackColor = System.Drawing.SystemColors.Control;
            this.lblKgTotalT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgTotalT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgTotalT2.Location = new System.Drawing.Point(178, 364);
            this.lblKgTotalT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgTotalT2.Name = "lblKgTotalT2";
            this.lblKgTotalT2.Size = new System.Drawing.Size(31, 13);
            this.lblKgTotalT2.TabIndex = 88;
            this.lblKgTotalT2.Text = "NULL";
            // 
            // lblKgTotalT1
            // 
            this.lblKgTotalT1.AutoSize = true;
            this.lblKgTotalT1.BackColor = System.Drawing.SystemColors.Control;
            this.lblKgTotalT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgTotalT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgTotalT1.Location = new System.Drawing.Point(178, 349);
            this.lblKgTotalT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgTotalT1.Name = "lblKgTotalT1";
            this.lblKgTotalT1.Size = new System.Drawing.Size(31, 13);
            this.lblKgTotalT1.TabIndex = 87;
            this.lblKgTotalT1.Text = "NULL";
            // 
            // lblKgTotalT0
            // 
            this.lblKgTotalT0.AutoSize = true;
            this.lblKgTotalT0.BackColor = System.Drawing.SystemColors.Control;
            this.lblKgTotalT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgTotalT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgTotalT0.Location = new System.Drawing.Point(178, 334);
            this.lblKgTotalT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgTotalT0.Name = "lblKgTotalT0";
            this.lblKgTotalT0.Size = new System.Drawing.Size(31, 13);
            this.lblKgTotalT0.TabIndex = 86;
            this.lblKgTotalT0.Text = "NULL";
            // 
            // lblT3_3
            // 
            this.lblT3_3.AutoSize = true;
            this.lblT3_3.BackColor = System.Drawing.SystemColors.Control;
            this.lblT3_3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3_3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT3_3.Location = new System.Drawing.Point(5, 379);
            this.lblT3_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT3_3.Name = "lblT3_3";
            this.lblT3_3.Size = new System.Drawing.Size(157, 13);
            this.lblT3_3.TabIndex = 85;
            this.lblT3_3.Text = "T3 Extruded Filament (kg)";
            // 
            // lblT2_3
            // 
            this.lblT2_3.AutoSize = true;
            this.lblT2_3.BackColor = System.Drawing.SystemColors.Control;
            this.lblT2_3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2_3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT2_3.Location = new System.Drawing.Point(5, 364);
            this.lblT2_3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2_3.Name = "lblT2_3";
            this.lblT2_3.Size = new System.Drawing.Size(157, 13);
            this.lblT2_3.TabIndex = 84;
            this.lblT2_3.Text = "T2 Extruded Filament (kg)";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.SystemColors.Control;
            this.label61.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label61.Location = new System.Drawing.Point(5, 349);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(157, 13);
            this.label61.TabIndex = 83;
            this.label61.Text = "T1 Extruded Filament (kg)";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.SystemColors.Control;
            this.label62.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label62.Location = new System.Drawing.Point(5, 334);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(157, 13);
            this.label62.TabIndex = 82;
            this.label62.Text = "T0 Extruded Filament (kg)";
            // 
            // lblHeatedTotalT3
            // 
            this.lblHeatedTotalT3.AutoSize = true;
            this.lblHeatedTotalT3.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeatedTotalT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedTotalT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedTotalT3.Location = new System.Drawing.Point(178, 443);
            this.lblHeatedTotalT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedTotalT3.Name = "lblHeatedTotalT3";
            this.lblHeatedTotalT3.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedTotalT3.TabIndex = 80;
            this.lblHeatedTotalT3.Text = "NULL";
            // 
            // lblHeatedTotalT2
            // 
            this.lblHeatedTotalT2.AutoSize = true;
            this.lblHeatedTotalT2.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeatedTotalT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedTotalT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedTotalT2.Location = new System.Drawing.Point(178, 428);
            this.lblHeatedTotalT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedTotalT2.Name = "lblHeatedTotalT2";
            this.lblHeatedTotalT2.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedTotalT2.TabIndex = 79;
            this.lblHeatedTotalT2.Text = "NULL";
            // 
            // lblHeatedTotalT1
            // 
            this.lblHeatedTotalT1.AutoSize = true;
            this.lblHeatedTotalT1.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeatedTotalT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedTotalT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedTotalT1.Location = new System.Drawing.Point(178, 413);
            this.lblHeatedTotalT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedTotalT1.Name = "lblHeatedTotalT1";
            this.lblHeatedTotalT1.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedTotalT1.TabIndex = 78;
            this.lblHeatedTotalT1.Text = "NULL";
            // 
            // lblHeatedTotalT0
            // 
            this.lblHeatedTotalT0.AutoSize = true;
            this.lblHeatedTotalT0.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeatedTotalT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedTotalT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedTotalT0.Location = new System.Drawing.Point(178, 398);
            this.lblHeatedTotalT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeatedTotalT0.Name = "lblHeatedTotalT0";
            this.lblHeatedTotalT0.Size = new System.Drawing.Size(31, 13);
            this.lblHeatedTotalT0.TabIndex = 77;
            this.lblHeatedTotalT0.Text = "NULL";
            // 
            // lblExtrudedTotalT3
            // 
            this.lblExtrudedTotalT3.AutoSize = true;
            this.lblExtrudedTotalT3.BackColor = System.Drawing.SystemColors.Control;
            this.lblExtrudedTotalT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedTotalT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedTotalT3.Location = new System.Drawing.Point(178, 319);
            this.lblExtrudedTotalT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedTotalT3.Name = "lblExtrudedTotalT3";
            this.lblExtrudedTotalT3.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedTotalT3.TabIndex = 76;
            this.lblExtrudedTotalT3.Text = "NULL";
            // 
            // lblExtrudedTotalT2
            // 
            this.lblExtrudedTotalT2.AutoSize = true;
            this.lblExtrudedTotalT2.BackColor = System.Drawing.SystemColors.Control;
            this.lblExtrudedTotalT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedTotalT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedTotalT2.Location = new System.Drawing.Point(178, 304);
            this.lblExtrudedTotalT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedTotalT2.Name = "lblExtrudedTotalT2";
            this.lblExtrudedTotalT2.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedTotalT2.TabIndex = 75;
            this.lblExtrudedTotalT2.Text = "NULL";
            // 
            // lblExtrudedTotalT1
            // 
            this.lblExtrudedTotalT1.AutoSize = true;
            this.lblExtrudedTotalT1.BackColor = System.Drawing.SystemColors.Control;
            this.lblExtrudedTotalT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedTotalT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedTotalT1.Location = new System.Drawing.Point(178, 289);
            this.lblExtrudedTotalT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedTotalT1.Name = "lblExtrudedTotalT1";
            this.lblExtrudedTotalT1.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedTotalT1.TabIndex = 74;
            this.lblExtrudedTotalT1.Text = "NULL";
            // 
            // lblExtrudedTotalT0
            // 
            this.lblExtrudedTotalT0.AutoSize = true;
            this.lblExtrudedTotalT0.BackColor = System.Drawing.SystemColors.Control;
            this.lblExtrudedTotalT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtrudedTotalT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblExtrudedTotalT0.Location = new System.Drawing.Point(178, 274);
            this.lblExtrudedTotalT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExtrudedTotalT0.Name = "lblExtrudedTotalT0";
            this.lblExtrudedTotalT0.Size = new System.Drawing.Size(31, 13);
            this.lblExtrudedTotalT0.TabIndex = 73;
            this.lblExtrudedTotalT0.Text = "NULL";
            // 
            // lblTotalDistanceZ
            // 
            this.lblTotalDistanceZ.AutoSize = true;
            this.lblTotalDistanceZ.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalDistanceZ.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDistanceZ.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalDistanceZ.Location = new System.Drawing.Point(178, 253);
            this.lblTotalDistanceZ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDistanceZ.Name = "lblTotalDistanceZ";
            this.lblTotalDistanceZ.Size = new System.Drawing.Size(31, 13);
            this.lblTotalDistanceZ.TabIndex = 72;
            this.lblTotalDistanceZ.Text = "NULL";
            // 
            // lblTotalDistanceY
            // 
            this.lblTotalDistanceY.AutoSize = true;
            this.lblTotalDistanceY.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalDistanceY.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDistanceY.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalDistanceY.Location = new System.Drawing.Point(178, 239);
            this.lblTotalDistanceY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDistanceY.Name = "lblTotalDistanceY";
            this.lblTotalDistanceY.Size = new System.Drawing.Size(31, 13);
            this.lblTotalDistanceY.TabIndex = 71;
            this.lblTotalDistanceY.Text = "NULL";
            // 
            // lblTotalDistanceX
            // 
            this.lblTotalDistanceX.AutoSize = true;
            this.lblTotalDistanceX.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalDistanceX.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDistanceX.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalDistanceX.Location = new System.Drawing.Point(178, 224);
            this.lblTotalDistanceX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalDistanceX.Name = "lblTotalDistanceX";
            this.lblTotalDistanceX.Size = new System.Drawing.Size(31, 13);
            this.lblTotalDistanceX.TabIndex = 70;
            this.lblTotalDistanceX.Text = "NULL";
            // 
            // lblTotalPrntLife
            // 
            this.lblTotalPrntLife.AutoSize = true;
            this.lblTotalPrntLife.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPrntLife.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrntLife.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalPrntLife.Location = new System.Drawing.Point(178, 202);
            this.lblTotalPrntLife.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrntLife.Name = "lblTotalPrntLife";
            this.lblTotalPrntLife.Size = new System.Drawing.Size(31, 13);
            this.lblTotalPrntLife.TabIndex = 69;
            this.lblTotalPrntLife.Text = "NULL";
            // 
            // lblTotalPwrON
            // 
            this.lblTotalPwrON.AutoSize = true;
            this.lblTotalPwrON.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPwrON.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPwrON.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalPwrON.Location = new System.Drawing.Point(178, 187);
            this.lblTotalPwrON.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPwrON.Name = "lblTotalPwrON";
            this.lblTotalPwrON.Size = new System.Drawing.Size(31, 13);
            this.lblTotalPwrON.TabIndex = 68;
            this.lblTotalPwrON.Text = "NULL";
            // 
            // lblTotalPwrCycle
            // 
            this.lblTotalPwrCycle.AutoSize = true;
            this.lblTotalPwrCycle.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotalPwrCycle.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPwrCycle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblTotalPwrCycle.Location = new System.Drawing.Point(178, 172);
            this.lblTotalPwrCycle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPwrCycle.Name = "lblTotalPwrCycle";
            this.lblTotalPwrCycle.Size = new System.Drawing.Size(31, 13);
            this.lblTotalPwrCycle.TabIndex = 67;
            this.lblTotalPwrCycle.Text = "NULL";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.SystemColors.Control;
            this.label54.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label54.Location = new System.Drawing.Point(146, 157);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(103, 13);
            this.label54.TabIndex = 66;
            this.label54.Text = "Lifetime (TOTAL)";
            // 
            // lblAbstandT3
            // 
            this.lblAbstandT3.AutoSize = true;
            this.lblAbstandT3.BackColor = System.Drawing.SystemColors.Control;
            this.lblAbstandT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstandT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAbstandT3.Location = new System.Drawing.Point(54, 134);
            this.lblAbstandT3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbstandT3.Name = "lblAbstandT3";
            this.lblAbstandT3.Size = new System.Drawing.Size(31, 13);
            this.lblAbstandT3.TabIndex = 65;
            this.lblAbstandT3.Text = "NULL";
            // 
            // lblAbstandT2
            // 
            this.lblAbstandT2.AutoSize = true;
            this.lblAbstandT2.BackColor = System.Drawing.SystemColors.Control;
            this.lblAbstandT2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstandT2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAbstandT2.Location = new System.Drawing.Point(54, 119);
            this.lblAbstandT2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbstandT2.Name = "lblAbstandT2";
            this.lblAbstandT2.Size = new System.Drawing.Size(31, 13);
            this.lblAbstandT2.TabIndex = 64;
            this.lblAbstandT2.Text = "NULL";
            // 
            // lblAbstandT1
            // 
            this.lblAbstandT1.AutoSize = true;
            this.lblAbstandT1.BackColor = System.Drawing.SystemColors.Control;
            this.lblAbstandT1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstandT1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAbstandT1.Location = new System.Drawing.Point(54, 104);
            this.lblAbstandT1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbstandT1.Name = "lblAbstandT1";
            this.lblAbstandT1.Size = new System.Drawing.Size(31, 13);
            this.lblAbstandT1.TabIndex = 63;
            this.lblAbstandT1.Text = "NULL";
            // 
            // lblAbstandT0
            // 
            this.lblAbstandT0.AutoSize = true;
            this.lblAbstandT0.BackColor = System.Drawing.SystemColors.Control;
            this.lblAbstandT0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbstandT0.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblAbstandT0.Location = new System.Drawing.Point(54, 89);
            this.lblAbstandT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbstandT0.Name = "lblAbstandT0";
            this.lblAbstandT0.Size = new System.Drawing.Size(31, 13);
            this.lblAbstandT0.TabIndex = 62;
            this.lblAbstandT0.Text = "NULL";
            // 
            // lblFirmware
            // 
            this.lblFirmware.AutoSize = true;
            this.lblFirmware.BackColor = System.Drawing.SystemColors.Control;
            this.lblFirmware.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmware.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblFirmware.Location = new System.Drawing.Point(178, 55);
            this.lblFirmware.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirmware.Name = "lblFirmware";
            this.lblFirmware.Size = new System.Drawing.Size(31, 13);
            this.lblFirmware.TabIndex = 60;
            this.lblFirmware.Text = "Null";
            // 
            // lblT3_4
            // 
            this.lblT3_4.AutoSize = true;
            this.lblT3_4.BackColor = System.Drawing.SystemColors.Control;
            this.lblT3_4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3_4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT3_4.Location = new System.Drawing.Point(5, 443);
            this.lblT3_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT3_4.Name = "lblT3_4";
            this.lblT3_4.Size = new System.Drawing.Size(91, 13);
            this.lblT3_4.TabIndex = 57;
            this.lblT3_4.Text = "T3 Heated Time";
            // 
            // lblT2_4
            // 
            this.lblT2_4.AutoSize = true;
            this.lblT2_4.BackColor = System.Drawing.SystemColors.Control;
            this.lblT2_4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2_4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT2_4.Location = new System.Drawing.Point(5, 428);
            this.lblT2_4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2_4.Name = "lblT2_4";
            this.lblT2_4.Size = new System.Drawing.Size(91, 13);
            this.lblT2_4.TabIndex = 56;
            this.lblT2_4.Text = "T2 Heated Time";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.Control;
            this.label34.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label34.Location = new System.Drawing.Point(5, 413);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 13);
            this.label34.TabIndex = 55;
            this.label34.Text = "T1 Heated Time";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.SystemColors.Control;
            this.label33.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label33.Location = new System.Drawing.Point(5, 398);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(91, 13);
            this.label33.TabIndex = 54;
            this.label33.Text = "T0 Heated Time";
            // 
            // lblT3_2
            // 
            this.lblT3_2.AutoSize = true;
            this.lblT3_2.BackColor = System.Drawing.SystemColors.Control;
            this.lblT3_2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3_2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT3_2.Location = new System.Drawing.Point(5, 319);
            this.lblT3_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT3_2.Name = "lblT3_2";
            this.lblT3_2.Size = new System.Drawing.Size(151, 13);
            this.lblT3_2.TabIndex = 53;
            this.lblT3_2.Text = "T3 Extruded Filament (m)";
            // 
            // lblT2_2
            // 
            this.lblT2_2.AutoSize = true;
            this.lblT2_2.BackColor = System.Drawing.SystemColors.Control;
            this.lblT2_2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2_2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT2_2.Location = new System.Drawing.Point(5, 304);
            this.lblT2_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2_2.Name = "lblT2_2";
            this.lblT2_2.Size = new System.Drawing.Size(151, 13);
            this.lblT2_2.TabIndex = 52;
            this.lblT2_2.Text = "T2 Extruded Filament (m)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.Control;
            this.label30.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label30.Location = new System.Drawing.Point(5, 289);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(151, 13);
            this.label30.TabIndex = 51;
            this.label30.Text = "T1 Extruded Filament (m)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.Control;
            this.label29.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label29.Location = new System.Drawing.Point(5, 274);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(151, 13);
            this.label29.TabIndex = 50;
            this.label29.Text = "T0 Extruded Filament (m)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.Control;
            this.label28.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label28.Location = new System.Drawing.Point(5, 253);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(133, 13);
            this.label28.TabIndex = 49;
            this.label28.Text = "Z Travel distance (m)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.Control;
            this.label27.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label27.Location = new System.Drawing.Point(5, 239);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(133, 13);
            this.label27.TabIndex = 48;
            this.label27.Text = "Y Travel distance (m)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.Control;
            this.label26.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label26.Location = new System.Drawing.Point(5, 224);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(133, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "X Travel distance (m)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.Control;
            this.label25.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label25.Location = new System.Drawing.Point(29, 202);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "Print Life";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label24.Location = new System.Drawing.Point(29, 187);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Power On Time";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Control;
            this.label23.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label23.Location = new System.Drawing.Point(29, 172);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "Power Cycles";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Control;
            this.label22.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label22.Location = new System.Drawing.Point(5, 157);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Lifetime Statistics";
            // 
            // lblT3_5
            // 
            this.lblT3_5.AutoSize = true;
            this.lblT3_5.BackColor = System.Drawing.SystemColors.Control;
            this.lblT3_5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT3_5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT3_5.Location = new System.Drawing.Point(29, 134);
            this.lblT3_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT3_5.Name = "lblT3_5";
            this.lblT3_5.Size = new System.Drawing.Size(19, 13);
            this.lblT3_5.TabIndex = 42;
            this.lblT3_5.Text = "T3";
            // 
            // lblT2_5
            // 
            this.lblT2_5.AutoSize = true;
            this.lblT2_5.BackColor = System.Drawing.SystemColors.Control;
            this.lblT2_5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT2_5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblT2_5.Location = new System.Drawing.Point(29, 119);
            this.lblT2_5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblT2_5.Name = "lblT2_5";
            this.lblT2_5.Size = new System.Drawing.Size(19, 13);
            this.lblT2_5.TabIndex = 41;
            this.lblT2_5.Text = "T2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label19.Location = new System.Drawing.Point(29, 104);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "T1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label18.Location = new System.Drawing.Point(29, 89);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "T0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label17.Location = new System.Drawing.Point(5, 74);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Duese Abstand";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label16.Location = new System.Drawing.Point(5, 55);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 37;
            this.label16.Text = "Firmware Version";
            // 
            // timer_temp
            // 
            this.timer_temp.Enabled = true;
            this.timer_temp.Interval = 3000;
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
            // wrkrCallG222
            // 
            this.wrkrCallG222.DoWork += new System.ComponentModel.DoWorkEventHandler(this.wrkrCallG222_DoWork);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(470, 327);
            this.trackBar1.Maximum = 300;
            this.trackBar1.Minimum = 25;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(45, 151);
            this.trackBar1.TabIndex = 81;
            this.trackBar1.Value = 25;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(530, 327);
            this.trackBar2.Maximum = 300;
            this.trackBar2.Minimum = 25;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar2.Size = new System.Drawing.Size(45, 151);
            this.trackBar2.TabIndex = 82;
            this.trackBar2.Value = 25;
            // 
            // myCustomButton1
            // 
            this.myCustomButton1.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton1.Image = global::MultecPlugin.Properties.Resources.plus;
            this.myCustomButton1.ImageClicked = global::MultecPlugin.Properties.Resources.plus_p;
            this.myCustomButton1.ImangeNormal = global::MultecPlugin.Properties.Resources.plus;
            this.myCustomButton1.Location = new System.Drawing.Point(397, 87);
            this.myCustomButton1.Name = "myCustomButton1";
            this.myCustomButton1.Size = new System.Drawing.Size(36, 33);
            this.myCustomButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton1.TabIndex = 85;
            this.myCustomButton1.TabStop = false;
            // 
            // myCustomButton2
            // 
            this.myCustomButton2.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton2.Image = global::MultecPlugin.Properties.Resources.minus;
            this.myCustomButton2.ImageClicked = global::MultecPlugin.Properties.Resources.minus_p;
            this.myCustomButton2.ImangeNormal = global::MultecPlugin.Properties.Resources.minus;
            this.myCustomButton2.Location = new System.Drawing.Point(287, 89);
            this.myCustomButton2.Name = "myCustomButton2";
            this.myCustomButton2.Size = new System.Drawing.Size(36, 33);
            this.myCustomButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton2.TabIndex = 84;
            this.myCustomButton2.TabStop = false;
            // 
            // tabControl2
            // 
            this.tabControl2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl2.AllowDrop = true;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabControl2.ItemSize = new System.Drawing.Size(183, 40);
            this.tabControl2.Location = new System.Drawing.Point(-4, -24);
            this.tabControl2.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.Padding = new System.Drawing.Point(10, 3);
            this.tabControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(589, 596);
            this.tabControl2.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl2.TabIndex = 83;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.trackBar3);
            this.tabPage3.Controls.Add(this.trackBar4);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Controls.Add(this.myCustomButton3);
            this.tabPage3.Controls.Add(this.myCustomButton4);
            this.tabPage3.Controls.Add(this.myCustomButton5);
            this.tabPage3.Controls.Add(this.myCustomButton6);
            this.tabPage3.Controls.Add(this.myCustomButton7);
            this.tabPage3.Controls.Add(this.myCustomButton8);
            this.tabPage3.Controls.Add(this.myCustomButton9);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.label31);
            this.tabPage3.Controls.Add(this.label32);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.checkBox1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.pictureBox5);
            this.tabPage3.Controls.Add(this.myCustomButton10);
            this.tabPage3.Controls.Add(this.myCustomButton11);
            this.tabPage3.Controls.Add(this.myCustomButton12);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.myCustomButton14);
            this.tabPage3.Controls.Add(this.myCustomButton15);
            this.tabPage3.Controls.Add(this.myCustomButton16);
            this.tabPage3.Controls.Add(this.myCustomButton17);
            this.tabPage3.Controls.Add(this.myCustomButton18);
            this.tabPage3.Controls.Add(this.myCustomButton19);
            this.tabPage3.Controls.Add(this.myCustomButton20);
            this.tabPage3.Controls.Add(this.myCustomButton21);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Controls.Add(this.label45);
            this.tabPage3.Controls.Add(this.label48);
            this.tabPage3.Controls.Add(this.label49);
            this.tabPage3.Controls.Add(this.label50);
            this.tabPage3.Controls.Add(this.label51);
            this.tabPage3.Controls.Add(this.label52);
            this.tabPage3.Controls.Add(this.label53);
            this.tabPage3.Controls.Add(this.label55);
            this.tabPage3.Controls.Add(this.label56);
            this.tabPage3.Controls.Add(this.label57);
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.label58);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.trackBar5);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.trackBar6);
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox6);
            this.tabPage3.Controls.Add(this.textBox7);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Controls.Add(this.myCustomButton30);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(581, 548);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Touch Controls";
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(530, 327);
            this.trackBar3.Maximum = 300;
            this.trackBar3.Minimum = 25;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar3.Size = new System.Drawing.Size(45, 151);
            this.trackBar3.TabIndex = 82;
            this.trackBar3.Value = 25;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(470, 327);
            this.trackBar4.Maximum = 300;
            this.trackBar4.Minimum = 25;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar4.Size = new System.Drawing.Size(45, 151);
            this.trackBar4.TabIndex = 81;
            this.trackBar4.Value = 25;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(494, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 28);
            this.label9.TabIndex = 79;
            this.label9.Text = "Flowrate Percentage";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(494, 23);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 24);
            this.numericUpDown1.TabIndex = 80;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(77, 249);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 28);
            this.label10.TabIndex = 0;
            this.label10.Text = "Feedrate Percentage";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown2.Location = new System.Drawing.Point(72, 222);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(57, 24);
            this.numericUpDown2.TabIndex = 78;
            this.numericUpDown2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // myCustomButton3
            // 
            this.myCustomButton3.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton3.Image = global::MultecPlugin.Properties.Resources.Zhome;
            this.myCustomButton3.ImageClicked = global::MultecPlugin.Properties.Resources.Zhome_p;
            this.myCustomButton3.ImangeNormal = global::MultecPlugin.Properties.Resources.Zhome;
            this.myCustomButton3.Location = new System.Drawing.Point(6, 229);
            this.myCustomButton3.Name = "myCustomButton3";
            this.myCustomButton3.Size = new System.Drawing.Size(60, 58);
            this.myCustomButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton3.TabIndex = 77;
            this.myCustomButton3.TabStop = false;
            // 
            // myCustomButton4
            // 
            this.myCustomButton4.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton4.Image = global::MultecPlugin.Properties.Resources.Yhome;
            this.myCustomButton4.ImageClicked = global::MultecPlugin.Properties.Resources.Yhome_p;
            this.myCustomButton4.ImangeNormal = global::MultecPlugin.Properties.Resources.Yhome;
            this.myCustomButton4.Location = new System.Drawing.Point(6, 165);
            this.myCustomButton4.Name = "myCustomButton4";
            this.myCustomButton4.Size = new System.Drawing.Size(60, 58);
            this.myCustomButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton4.TabIndex = 76;
            this.myCustomButton4.TabStop = false;
            // 
            // myCustomButton5
            // 
            this.myCustomButton5.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton5.Image = global::MultecPlugin.Properties.Resources.Xhome;
            this.myCustomButton5.ImageClicked = global::MultecPlugin.Properties.Resources.Xhome_p;
            this.myCustomButton5.ImangeNormal = global::MultecPlugin.Properties.Resources.Xhome;
            this.myCustomButton5.Location = new System.Drawing.Point(6, 101);
            this.myCustomButton5.Name = "myCustomButton5";
            this.myCustomButton5.Size = new System.Drawing.Size(60, 58);
            this.myCustomButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton5.TabIndex = 75;
            this.myCustomButton5.TabStop = false;
            // 
            // myCustomButton6
            // 
            this.myCustomButton6.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton6.Image = global::MultecPlugin.Properties.Resources.minus51;
            this.myCustomButton6.ImageClicked = global::MultecPlugin.Properties.Resources.minus5_p1;
            this.myCustomButton6.ImangeNormal = global::MultecPlugin.Properties.Resources.minus51;
            this.myCustomButton6.Location = new System.Drawing.Point(132, 468);
            this.myCustomButton6.Name = "myCustomButton6";
            this.myCustomButton6.Size = new System.Drawing.Size(60, 45);
            this.myCustomButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton6.TabIndex = 74;
            this.myCustomButton6.TabStop = false;
            // 
            // myCustomButton7
            // 
            this.myCustomButton7.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton7.Image = global::MultecPlugin.Properties.Resources.plus5;
            this.myCustomButton7.ImageClicked = global::MultecPlugin.Properties.Resources.plus5_p;
            this.myCustomButton7.ImangeNormal = global::MultecPlugin.Properties.Resources.plus5;
            this.myCustomButton7.Location = new System.Drawing.Point(394, 468);
            this.myCustomButton7.Name = "myCustomButton7";
            this.myCustomButton7.Size = new System.Drawing.Size(60, 45);
            this.myCustomButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton7.TabIndex = 73;
            this.myCustomButton7.TabStop = false;
            // 
            // myCustomButton8
            // 
            this.myCustomButton8.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton8.Image = ((System.Drawing.Image)(resources.GetObject("myCustomButton8.Image")));
            this.myCustomButton8.ImageClicked = global::MultecPlugin.Properties.Resources.minus5_p1;
            this.myCustomButton8.ImangeNormal = global::MultecPlugin.Properties.Resources.minus51;
            this.myCustomButton8.Location = new System.Drawing.Point(131, 417);
            this.myCustomButton8.Name = "myCustomButton8";
            this.myCustomButton8.Size = new System.Drawing.Size(60, 45);
            this.myCustomButton8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton8.TabIndex = 72;
            this.myCustomButton8.TabStop = false;
            // 
            // myCustomButton9
            // 
            this.myCustomButton9.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton9.Image = global::MultecPlugin.Properties.Resources.plus5;
            this.myCustomButton9.ImageClicked = global::MultecPlugin.Properties.Resources.plus5_p;
            this.myCustomButton9.ImangeNormal = global::MultecPlugin.Properties.Resources.plus5;
            this.myCustomButton9.Location = new System.Drawing.Point(394, 417);
            this.myCustomButton9.Name = "myCustomButton9";
            this.myCustomButton9.Size = new System.Drawing.Size(60, 45);
            this.myCustomButton9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton9.TabIndex = 71;
            this.myCustomButton9.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(346, 58);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 70;
            this.label20.Text = "Z:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(205, 58);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 13);
            this.label21.TabIndex = 69;
            this.label21.Text = "NICHT INITILISIERT";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(182, 58);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(17, 13);
            this.label31.TabIndex = 68;
            this.label31.Text = "Y:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(369, 58);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(108, 13);
            this.label32.TabIndex = 67;
            this.label32.Text = "NICHT INITILISIERT";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(48, 58);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(115, 13);
            this.label35.TabIndex = 66;
            this.label35.Text = "NICHT INITIALISIERT";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(25, 58);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(17, 13);
            this.label36.TabIndex = 65;
            this.label36.Text = "X:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 75);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(222, 17);
            this.checkBox1.TabIndex = 64;
            this.checkBox1.Text = "Drucker nach Druckende herunterfahren.";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.pictureBox1.Location = new System.Drawing.Point(394, 340);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 63;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.pictureBox2.Location = new System.Drawing.Point(328, 340);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.pictureBox3.Location = new System.Drawing.Point(262, 340);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 61;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.pictureBox4.Location = new System.Drawing.Point(196, 340);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::MultecPlugin.Properties.Resources.AUS_2;
            this.pictureBox5.Location = new System.Drawing.Point(130, 340);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(60, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 59;
            this.pictureBox5.TabStop = false;
            // 
            // myCustomButton10
            // 
            this.myCustomButton10.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton10.Image = global::MultecPlugin.Properties.Resources.Park_Move;
            this.myCustomButton10.ImageClicked = global::MultecPlugin.Properties.Resources.Park_Move_p;
            this.myCustomButton10.ImangeNormal = global::MultecPlugin.Properties.Resources.Park_Move;
            this.myCustomButton10.Location = new System.Drawing.Point(6, 484);
            this.myCustomButton10.Name = "myCustomButton10";
            this.myCustomButton10.Size = new System.Drawing.Size(60, 58);
            this.myCustomButton10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton10.TabIndex = 58;
            this.myCustomButton10.TabStop = false;
            // 
            // myCustomButton11
            // 
            this.myCustomButton11.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton11.Image = global::MultecPlugin.Properties.Resources.HOME;
            this.myCustomButton11.ImageClicked = global::MultecPlugin.Properties.Resources.HOME_p;
            this.myCustomButton11.ImangeNormal = global::MultecPlugin.Properties.Resources.HOME;
            this.myCustomButton11.Location = new System.Drawing.Point(6, 293);
            this.myCustomButton11.Name = "myCustomButton11";
            this.myCustomButton11.Size = new System.Drawing.Size(60, 58);
            this.myCustomButton11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton11.TabIndex = 9;
            this.myCustomButton11.TabStop = false;
            // 
            // myCustomButton12
            // 
            this.myCustomButton12.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton12.Image = global::MultecPlugin.Properties.Resources.MOTOR_OFF;
            this.myCustomButton12.ImageClicked = global::MultecPlugin.Properties.Resources.MOTOR_OFF_p;
            this.myCustomButton12.ImangeNormal = global::MultecPlugin.Properties.Resources.MOTOR_OFF;
            this.myCustomButton12.Location = new System.Drawing.Point(6, 357);
            this.myCustomButton12.Name = "myCustomButton12";
            this.myCustomButton12.Size = new System.Drawing.Size(60, 58);
            this.myCustomButton12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton12.TabIndex = 57;
            this.myCustomButton12.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.myCustomButton13);
            this.groupBox4.Controls.Add(this.label44);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(23, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(457, 46);
            this.groupBox4.TabIndex = 56;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Manual Command";
            // 
            // myCustomButton13
            // 
            this.myCustomButton13.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton13.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton13.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.myCustomButton13.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton13.Location = new System.Drawing.Point(387, 17);
            this.myCustomButton13.Name = "myCustomButton13";
            this.myCustomButton13.Size = new System.Drawing.Size(64, 23);
            this.myCustomButton13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton13.TabIndex = 3;
            this.myCustomButton13.TabStop = false;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(16, 22);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(43, 13);
            this.label44.TabIndex = 2;
            this.label44.Text = "G-Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 20);
            this.textBox1.TabIndex = 0;
            // 
            // myCustomButton14
            // 
            this.myCustomButton14.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton14.Image = ((System.Drawing.Image)(resources.GetObject("myCustomButton14.Image")));
            this.myCustomButton14.ImageClicked = global::MultecPlugin.Properties.Resources.HOME_Move_p;
            this.myCustomButton14.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("myCustomButton14.ImangeNormal")));
            this.myCustomButton14.Location = new System.Drawing.Point(6, 421);
            this.myCustomButton14.Name = "myCustomButton14";
            this.myCustomButton14.Size = new System.Drawing.Size(60, 57);
            this.myCustomButton14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton14.TabIndex = 55;
            this.myCustomButton14.TabStop = false;
            // 
            // myCustomButton15
            // 
            this.myCustomButton15.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton15.Image = global::MultecPlugin.Properties.Resources.extract;
            this.myCustomButton15.ImageClicked = global::MultecPlugin.Properties.Resources.extract_p;
            this.myCustomButton15.ImangeNormal = global::MultecPlugin.Properties.Resources.extract;
            this.myCustomButton15.Location = new System.Drawing.Point(398, 176);
            this.myCustomButton15.Name = "myCustomButton15";
            this.myCustomButton15.Size = new System.Drawing.Size(70, 70);
            this.myCustomButton15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton15.TabIndex = 54;
            this.myCustomButton15.TabStop = false;
            // 
            // myCustomButton16
            // 
            this.myCustomButton16.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton16.Image = global::MultecPlugin.Properties.Resources.retract;
            this.myCustomButton16.ImageClicked = global::MultecPlugin.Properties.Resources.retract_p;
            this.myCustomButton16.ImangeNormal = global::MultecPlugin.Properties.Resources.retract;
            this.myCustomButton16.Location = new System.Drawing.Point(398, 100);
            this.myCustomButton16.Name = "myCustomButton16";
            this.myCustomButton16.Size = new System.Drawing.Size(70, 70);
            this.myCustomButton16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton16.TabIndex = 53;
            this.myCustomButton16.TabStop = false;
            // 
            // myCustomButton17
            // 
            this.myCustomButton17.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton17.Image = global::MultecPlugin.Properties.Resources.Zminus;
            this.myCustomButton17.ImageClicked = global::MultecPlugin.Properties.Resources.Zminus_p;
            this.myCustomButton17.ImangeNormal = global::MultecPlugin.Properties.Resources.Zminus;
            this.myCustomButton17.Location = new System.Drawing.Point(309, 176);
            this.myCustomButton17.Name = "myCustomButton17";
            this.myCustomButton17.Size = new System.Drawing.Size(70, 70);
            this.myCustomButton17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton17.TabIndex = 52;
            this.myCustomButton17.TabStop = false;
            // 
            // myCustomButton18
            // 
            this.myCustomButton18.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton18.Image = global::MultecPlugin.Properties.Resources.zPlus;
            this.myCustomButton18.ImageClicked = global::MultecPlugin.Properties.Resources.zplus_p;
            this.myCustomButton18.ImangeNormal = global::MultecPlugin.Properties.Resources.zPlus;
            this.myCustomButton18.Location = new System.Drawing.Point(309, 100);
            this.myCustomButton18.Name = "myCustomButton18";
            this.myCustomButton18.Size = new System.Drawing.Size(70, 70);
            this.myCustomButton18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton18.TabIndex = 51;
            this.myCustomButton18.TabStop = false;
            // 
            // myCustomButton19
            // 
            this.myCustomButton19.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton19.Image = global::MultecPlugin.Properties.Resources.Yplus;
            this.myCustomButton19.ImageClicked = global::MultecPlugin.Properties.Resources.Yplus_p;
            this.myCustomButton19.ImangeNormal = global::MultecPlugin.Properties.Resources.Yplus;
            this.myCustomButton19.Location = new System.Drawing.Point(158, 100);
            this.myCustomButton19.Name = "myCustomButton19";
            this.myCustomButton19.Size = new System.Drawing.Size(70, 70);
            this.myCustomButton19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton19.TabIndex = 48;
            this.myCustomButton19.TabStop = false;
            // 
            // myCustomButton20
            // 
            this.myCustomButton20.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton20.Image = global::MultecPlugin.Properties.Resources.Yminus;
            this.myCustomButton20.ImageClicked = global::MultecPlugin.Properties.Resources.Yminus_p;
            this.myCustomButton20.ImangeNormal = global::MultecPlugin.Properties.Resources.Yminus;
            this.myCustomButton20.Location = new System.Drawing.Point(158, 176);
            this.myCustomButton20.Name = "myCustomButton20";
            this.myCustomButton20.Size = new System.Drawing.Size(70, 70);
            this.myCustomButton20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton20.TabIndex = 50;
            this.myCustomButton20.TabStop = false;
            // 
            // myCustomButton21
            // 
            this.myCustomButton21.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton21.Image = global::MultecPlugin.Properties.Resources.Xplus;
            this.myCustomButton21.ImageClicked = global::MultecPlugin.Properties.Resources.Xplus_p;
            this.myCustomButton21.ImangeNormal = global::MultecPlugin.Properties.Resources.Xplus;
            this.myCustomButton21.Location = new System.Drawing.Point(230, 138);
            this.myCustomButton21.Name = "myCustomButton21";
            this.myCustomButton21.Size = new System.Drawing.Size(70, 70);
            this.myCustomButton21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton21.TabIndex = 49;
            this.myCustomButton21.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.myCustomButton22);
            this.groupBox6.Controls.Add(this.myCustomButton23);
            this.groupBox6.Controls.Add(this.myCustomButton24);
            this.groupBox6.Location = new System.Drawing.Point(494, 89);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox6.Size = new System.Drawing.Size(68, 173);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Distance";
            // 
            // myCustomButton22
            // 
            this.myCustomButton22.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton22.Image = global::MultecPlugin.Properties.Resources.fiftymm;
            this.myCustomButton22.ImageClicked = global::MultecPlugin.Properties.Resources.fiftymm_p;
            this.myCustomButton22.ImangeNormal = global::MultecPlugin.Properties.Resources.fiftymm;
            this.myCustomButton22.Location = new System.Drawing.Point(9, 13);
            this.myCustomButton22.Name = "myCustomButton22";
            this.myCustomButton22.Size = new System.Drawing.Size(50, 50);
            this.myCustomButton22.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton22.TabIndex = 5;
            this.myCustomButton22.TabStop = false;
            // 
            // myCustomButton23
            // 
            this.myCustomButton23.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton23.Image = global::MultecPlugin.Properties.Resources.tenmm;
            this.myCustomButton23.ImageClicked = global::MultecPlugin.Properties.Resources.tenmm_p;
            this.myCustomButton23.ImangeNormal = global::MultecPlugin.Properties.Resources.tenmm;
            this.myCustomButton23.Location = new System.Drawing.Point(9, 66);
            this.myCustomButton23.Name = "myCustomButton23";
            this.myCustomButton23.Size = new System.Drawing.Size(50, 50);
            this.myCustomButton23.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton23.TabIndex = 4;
            this.myCustomButton23.TabStop = false;
            // 
            // myCustomButton24
            // 
            this.myCustomButton24.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton24.Image = global::MultecPlugin.Properties.Resources.onemm;
            this.myCustomButton24.ImageClicked = global::MultecPlugin.Properties.Resources.onemm_p;
            this.myCustomButton24.ImangeNormal = global::MultecPlugin.Properties.Resources.onemm;
            this.myCustomButton24.Location = new System.Drawing.Point(9, 119);
            this.myCustomButton24.Name = "myCustomButton24";
            this.myCustomButton24.Size = new System.Drawing.Size(50, 50);
            this.myCustomButton24.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton24.TabIndex = 3;
            this.myCustomButton24.TabStop = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label45.Location = new System.Drawing.Point(396, 325);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(55, 13);
            this.label45.TabIndex = 46;
            this.label45.Text = "Heizbett";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label48.Location = new System.Drawing.Point(347, 326);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(19, 13);
            this.label48.TabIndex = 45;
            this.label48.Text = "T3";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label49.Location = new System.Drawing.Point(284, 326);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(19, 13);
            this.label49.TabIndex = 44;
            this.label49.Text = "T2";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label50.Location = new System.Drawing.Point(214, 326);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(19, 13);
            this.label50.TabIndex = 43;
            this.label50.Text = "T1";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label51.Location = new System.Drawing.Point(149, 325);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(19, 13);
            this.label51.TabIndex = 42;
            this.label51.Text = "T0";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label52.Location = new System.Drawing.Point(68, 491);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(61, 13);
            this.label52.TabIndex = 41;
            this.label52.Text = "Temperatur";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label53.Location = new System.Drawing.Point(82, 478);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(46, 13);
            this.label53.TabIndex = 40;
            this.label53.Text = "Heizbett";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label55.Location = new System.Drawing.Point(67, 439);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(61, 13);
            this.label55.TabIndex = 39;
            this.label55.Text = "Temperatur";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label56.Location = new System.Drawing.Point(90, 426);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(38, 13);
            this.label56.TabIndex = 38;
            this.label56.Text = "Duese";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label57.Location = new System.Drawing.Point(90, 398);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(39, 13);
            this.label57.TabIndex = 37;
            this.label57.Text = "Aktuell";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.myCustomButton25);
            this.groupBox7.Controls.Add(this.myCustomButton26);
            this.groupBox7.Controls.Add(this.myCustomButton27);
            this.groupBox7.Controls.Add(this.myCustomButton28);
            this.groupBox7.Controls.Add(this.myCustomButton29);
            this.groupBox7.Location = new System.Drawing.Point(124, 258);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(334, 66);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Werkzeug Auswahl";
            // 
            // myCustomButton25
            // 
            this.myCustomButton25.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton25.Image = global::MultecPlugin.Properties.Resources.MOVE;
            this.myCustomButton25.ImageClicked = global::MultecPlugin.Properties.Resources.MOVE_p;
            this.myCustomButton25.ImangeNormal = global::MultecPlugin.Properties.Resources.MOVE;
            this.myCustomButton25.Location = new System.Drawing.Point(269, 19);
            this.myCustomButton25.Name = "myCustomButton25";
            this.myCustomButton25.Size = new System.Drawing.Size(60, 40);
            this.myCustomButton25.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton25.TabIndex = 9;
            this.myCustomButton25.TabStop = false;
            // 
            // myCustomButton26
            // 
            this.myCustomButton26.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton26.Image = global::MultecPlugin.Properties.Resources.T3;
            this.myCustomButton26.ImageClicked = global::MultecPlugin.Properties.Resources.T3_p;
            this.myCustomButton26.ImangeNormal = global::MultecPlugin.Properties.Resources.T3;
            this.myCustomButton26.Location = new System.Drawing.Point(205, 19);
            this.myCustomButton26.Name = "myCustomButton26";
            this.myCustomButton26.Size = new System.Drawing.Size(60, 40);
            this.myCustomButton26.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton26.TabIndex = 8;
            this.myCustomButton26.TabStop = false;
            // 
            // myCustomButton27
            // 
            this.myCustomButton27.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton27.Image = global::MultecPlugin.Properties.Resources.T2;
            this.myCustomButton27.ImageClicked = global::MultecPlugin.Properties.Resources.T2_p;
            this.myCustomButton27.ImangeNormal = global::MultecPlugin.Properties.Resources.T2;
            this.myCustomButton27.Location = new System.Drawing.Point(139, 19);
            this.myCustomButton27.Name = "myCustomButton27";
            this.myCustomButton27.Size = new System.Drawing.Size(60, 40);
            this.myCustomButton27.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton27.TabIndex = 7;
            this.myCustomButton27.TabStop = false;
            // 
            // myCustomButton28
            // 
            this.myCustomButton28.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton28.Image = global::MultecPlugin.Properties.Resources.T1;
            this.myCustomButton28.ImageClicked = global::MultecPlugin.Properties.Resources.T1_p;
            this.myCustomButton28.ImangeNormal = global::MultecPlugin.Properties.Resources.T1;
            this.myCustomButton28.Location = new System.Drawing.Point(75, 19);
            this.myCustomButton28.Name = "myCustomButton28";
            this.myCustomButton28.Size = new System.Drawing.Size(57, 40);
            this.myCustomButton28.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton28.TabIndex = 6;
            this.myCustomButton28.TabStop = false;
            // 
            // myCustomButton29
            // 
            this.myCustomButton29.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton29.Image = global::MultecPlugin.Properties.Resources.T0;
            this.myCustomButton29.ImageClicked = global::MultecPlugin.Properties.Resources.T0_p;
            this.myCustomButton29.ImangeNormal = global::MultecPlugin.Properties.Resources.T0;
            this.myCustomButton29.Location = new System.Drawing.Point(8, 19);
            this.myCustomButton29.Name = "myCustomButton29";
            this.myCustomButton29.Size = new System.Drawing.Size(60, 40);
            this.myCustomButton29.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton29.TabIndex = 5;
            this.myCustomButton29.TabStop = false;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label58.Location = new System.Drawing.Point(105, 380);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(24, 13);
            this.label58.TabIndex = 36;
            this.label58.Text = "Ziel";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(394, 395);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(61, 20);
            this.textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(394, 375);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(61, 20);
            this.textBox3.TabIndex = 31;
            this.textBox3.Text = "60";
            // 
            // trackBar5
            // 
            this.trackBar5.AllowDrop = true;
            this.trackBar5.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar5.Enabled = false;
            this.trackBar5.Location = new System.Drawing.Point(195, 475);
            this.trackBar5.Maximum = 100;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(197, 45);
            this.trackBar5.SmallChange = 5;
            this.trackBar5.TabIndex = 27;
            this.trackBar5.TickFrequency = 5;
            this.trackBar5.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar5.Value = 50;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(327, 396);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(61, 20);
            this.textBox4.TabIndex = 26;
            // 
            // trackBar6
            // 
            this.trackBar6.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar6.Location = new System.Drawing.Point(195, 417);
            this.trackBar6.Maximum = 270;
            this.trackBar6.Minimum = 170;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(197, 45);
            this.trackBar6.SmallChange = 5;
            this.trackBar6.TabIndex = 16;
            this.trackBar6.TickFrequency = 5;
            this.trackBar6.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar6.Value = 170;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(262, 395);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(61, 20);
            this.textBox5.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(195, 396);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(61, 20);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(131, 395);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(61, 20);
            this.textBox7.TabIndex = 23;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(131, 375);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(61, 20);
            this.textBox8.TabIndex = 19;
            this.textBox8.Text = "205";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(327, 375);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(61, 20);
            this.textBox9.TabIndex = 22;
            this.textBox9.Text = "205";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(196, 375);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(61, 20);
            this.textBox10.TabIndex = 20;
            this.textBox10.Text = "205";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(262, 375);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(61, 20);
            this.textBox11.TabIndex = 21;
            this.textBox11.Text = "205";
            // 
            // myCustomButton30
            // 
            this.myCustomButton30.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton30.Image = global::MultecPlugin.Properties.Resources.Xminus;
            this.myCustomButton30.ImageClicked = global::MultecPlugin.Properties.Resources.Xminus_p;
            this.myCustomButton30.ImangeNormal = global::MultecPlugin.Properties.Resources.Xminus;
            this.myCustomButton30.Location = new System.Drawing.Point(85, 138);
            this.myCustomButton30.Name = "myCustomButton30";
            this.myCustomButton30.Size = new System.Drawing.Size(70, 70);
            this.myCustomButton30.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton30.TabIndex = 47;
            this.myCustomButton30.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = System.Drawing.SystemColors.Control;
            tabPage4.Controls.Add(this.button1);
            tabPage4.Controls.Add(this.groupBox8);
            tabPage4.Controls.Add(this.label59);
            tabPage4.Controls.Add(this.label60);
            tabPage4.Controls.Add(this.label63);
            tabPage4.Controls.Add(this.label64);
            tabPage4.Controls.Add(this.groupBox9);
            tabPage4.Controls.Add(this.label75);
            tabPage4.Controls.Add(this.label76);
            tabPage4.Controls.Add(this.label77);
            tabPage4.Controls.Add(this.groupBox10);
            tabPage4.Controls.Add(this.label78);
            tabPage4.Controls.Add(this.label79);
            tabPage4.Controls.Add(this.textBox12);
            tabPage4.Controls.Add(this.textBox13);
            tabPage4.Controls.Add(this.label80);
            tabPage4.Controls.Add(this.label81);
            tabPage4.Controls.Add(this.myCustomButton35);
            tabPage4.Controls.Add(this.myCustomButton36);
            tabPage4.Controls.Add(this.myCustomButton37);
            tabPage4.Controls.Add(this.myCustomButton38);
            tabPage4.Controls.Add(this.myCustomButton1);
            tabPage4.Controls.Add(this.myCustomButton2);
            tabPage4.Controls.Add(this.myCustomButton39);
            tabPage4.Controls.Add(this.myCustomButton40);
            tabPage4.Controls.Add(this.myCustomButton41);
            tabPage4.Controls.Add(this.myCustomButton42);
            tabPage4.Controls.Add(this.myCustomButton43);
            tabPage4.Controls.Add(this.myCustomButton44);
            tabPage4.Controls.Add(this.myCustomButton45);
            tabPage4.Controls.Add(this.myCustomButton46);
            tabPage4.Controls.Add(this.myCustomButton47);
            tabPage4.Controls.Add(this.myCustomButton48);
            tabPage4.Controls.Add(this.myCustomButton49);
            tabPage4.Location = new System.Drawing.Point(4, 4);
            tabPage4.Margin = new System.Windows.Forms.Padding(2);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(2);
            tabPage4.Size = new System.Drawing.Size(581, 548);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Kalibrierung";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(80, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "Filament Change";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.radioButton1);
            this.groupBox8.Controls.Add(this.radioButton2);
            this.groupBox8.Location = new System.Drawing.Point(5, 237);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(133, 94);
            this.groupBox8.TabIndex = 69;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Druck Permissives";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(7, 58);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(111, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Drucker Initializiert";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(7, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(100, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Move Initializiert";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label59.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label59.Location = new System.Drawing.Point(294, 245);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(130, 15);
            this.label59.TabIndex = 68;
            this.label59.Text = "Rotational Offset Filament";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.Location = new System.Drawing.Point(343, 281);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(34, 18);
            this.label60.TabIndex = 66;
            this.label60.Text = "mm";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(343, 266);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(32, 16);
            this.label63.TabIndex = 65;
            this.label63.Text = "0.00";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label64.Enabled = false;
            this.label64.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label64.Location = new System.Drawing.Point(328, 183);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(64, 15);
            this.label64.TabIndex = 62;
            this.label64.Text = "T0 Abstand";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.myCustomButton31);
            this.groupBox9.Controls.Add(this.label65);
            this.groupBox9.Controls.Add(this.label66);
            this.groupBox9.Controls.Add(this.label67);
            this.groupBox9.Controls.Add(this.label68);
            this.groupBox9.Controls.Add(this.label69);
            this.groupBox9.Controls.Add(this.label71);
            this.groupBox9.Controls.Add(this.label72);
            this.groupBox9.Controls.Add(this.label73);
            this.groupBox9.Controls.Add(this.label74);
            this.groupBox9.Location = new System.Drawing.Point(200, 305);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(342, 206);
            this.groupBox9.TabIndex = 60;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Filament Überwachung";
            // 
            // myCustomButton31
            // 
            this.myCustomButton31.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton31.Image = global::MultecPlugin.Properties.Resources.Aktualizieren;
            this.myCustomButton31.ImageClicked = global::MultecPlugin.Properties.Resources.Aktualizieren_p;
            this.myCustomButton31.ImangeNormal = global::MultecPlugin.Properties.Resources.Aktualizieren;
            this.myCustomButton31.Location = new System.Drawing.Point(239, 19);
            this.myCustomButton31.Name = "myCustomButton31";
            this.myCustomButton31.Size = new System.Drawing.Size(97, 31);
            this.myCustomButton31.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton31.TabIndex = 82;
            this.myCustomButton31.TabStop = false;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(4, 173);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(24, 16);
            this.label65.TabIndex = 9;
            this.label65.Text = "T3";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(4, 138);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(24, 16);
            this.label66.TabIndex = 8;
            this.label66.Text = "T2";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(4, 103);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(24, 16);
            this.label67.TabIndex = 7;
            this.label67.Text = "T1";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(4, 68);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(24, 16);
            this.label68.TabIndex = 6;
            this.label68.Text = "T0";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(31, 167);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(59, 26);
            this.label69.TabIndex = 5;
            this.label69.Text = "NULL";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label71.Location = new System.Drawing.Point(31, 133);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(59, 26);
            this.label71.TabIndex = 4;
            this.label71.Text = "NULL";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(31, 63);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(59, 26);
            this.label72.TabIndex = 3;
            this.label72.Text = "NULL";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.Location = new System.Drawing.Point(31, 98);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(59, 26);
            this.label73.TabIndex = 2;
            this.label73.Text = "NULL";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label74.Location = new System.Drawing.Point(31, 27);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(59, 26);
            this.label74.TabIndex = 0;
            this.label74.Text = "NULL";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Enabled = false;
            this.label75.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label75.Location = new System.Drawing.Point(2, 144);
            this.label75.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(20, 13);
            this.label75.TabIndex = 59;
            this.label75.Text = "#3";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Enabled = false;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label76.Location = new System.Drawing.Point(343, 216);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(34, 18);
            this.label76.TabIndex = 55;
            this.label76.Text = "mm";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Enabled = false;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label77.Location = new System.Drawing.Point(343, 201);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(32, 16);
            this.label77.TabIndex = 54;
            this.label77.Text = "0.00";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.myCustomButton32);
            this.groupBox10.Controls.Add(this.myCustomButton33);
            this.groupBox10.Controls.Add(this.myCustomButton34);
            this.groupBox10.Location = new System.Drawing.Point(287, 4);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox10.Size = new System.Drawing.Size(241, 65);
            this.groupBox10.TabIndex = 47;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Werkzeug Auswahl";
            // 
            // myCustomButton32
            // 
            this.myCustomButton32.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton32.Image = global::MultecPlugin.Properties.Resources.T3;
            this.myCustomButton32.ImageClicked = global::MultecPlugin.Properties.Resources.T3_p;
            this.myCustomButton32.ImangeNormal = global::MultecPlugin.Properties.Resources.T3;
            this.myCustomButton32.Location = new System.Drawing.Point(176, 18);
            this.myCustomButton32.Name = "myCustomButton32";
            this.myCustomButton32.Size = new System.Drawing.Size(60, 40);
            this.myCustomButton32.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton32.TabIndex = 84;
            this.myCustomButton32.TabStop = false;
            // 
            // myCustomButton33
            // 
            this.myCustomButton33.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton33.Image = global::MultecPlugin.Properties.Resources.T2;
            this.myCustomButton33.ImageClicked = global::MultecPlugin.Properties.Resources.T2_p;
            this.myCustomButton33.ImangeNormal = global::MultecPlugin.Properties.Resources.T2;
            this.myCustomButton33.Location = new System.Drawing.Point(86, 18);
            this.myCustomButton33.Name = "myCustomButton33";
            this.myCustomButton33.Size = new System.Drawing.Size(60, 40);
            this.myCustomButton33.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton33.TabIndex = 83;
            this.myCustomButton33.TabStop = false;
            // 
            // myCustomButton34
            // 
            this.myCustomButton34.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton34.Image = global::MultecPlugin.Properties.Resources.T1;
            this.myCustomButton34.ImageClicked = global::MultecPlugin.Properties.Resources.T1_p;
            this.myCustomButton34.ImangeNormal = global::MultecPlugin.Properties.Resources.T1;
            this.myCustomButton34.Location = new System.Drawing.Point(5, 18);
            this.myCustomButton34.Name = "myCustomButton34";
            this.myCustomButton34.Size = new System.Drawing.Size(57, 40);
            this.myCustomButton34.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton34.TabIndex = 82;
            this.myCustomButton34.TabStop = false;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label78.Location = new System.Drawing.Point(353, 131);
            this.label78.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(14, 13);
            this.label78.TabIndex = 46;
            this.label78.Text = "Y";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label79.Location = new System.Drawing.Point(353, 82);
            this.label79.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(14, 13);
            this.label79.TabIndex = 45;
            this.label79.Text = "X";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(329, 144);
            this.textBox12.Margin = new System.Windows.Forms.Padding(2);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(61, 20);
            this.textBox12.TabIndex = 41;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(329, 95);
            this.textBox13.Margin = new System.Windows.Forms.Padding(2);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(61, 20);
            this.textBox13.TabIndex = 39;
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Enabled = false;
            this.label80.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label80.Location = new System.Drawing.Point(2, 75);
            this.label80.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(20, 13);
            this.label80.TabIndex = 38;
            this.label80.Text = "#2";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label81.Location = new System.Drawing.Point(2, 4);
            this.label81.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(20, 13);
            this.label81.TabIndex = 37;
            this.label81.Text = "#1";
            // 
            // myCustomButton35
            // 
            this.myCustomButton35.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton35.Image = global::MultecPlugin.Properties.Resources.minus;
            this.myCustomButton35.ImageClicked = global::MultecPlugin.Properties.Resources.minus_p;
            this.myCustomButton35.ImangeNormal = global::MultecPlugin.Properties.Resources.minus;
            this.myCustomButton35.Location = new System.Drawing.Point(287, 264);
            this.myCustomButton35.Name = "myCustomButton35";
            this.myCustomButton35.Size = new System.Drawing.Size(36, 33);
            this.myCustomButton35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton35.TabIndex = 89;
            this.myCustomButton35.TabStop = false;
            // 
            // myCustomButton36
            // 
            this.myCustomButton36.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton36.Image = global::MultecPlugin.Properties.Resources.plus;
            this.myCustomButton36.ImageClicked = global::MultecPlugin.Properties.Resources.plus_p;
            this.myCustomButton36.ImangeNormal = global::MultecPlugin.Properties.Resources.plus;
            this.myCustomButton36.Location = new System.Drawing.Point(397, 264);
            this.myCustomButton36.Name = "myCustomButton36";
            this.myCustomButton36.Size = new System.Drawing.Size(36, 33);
            this.myCustomButton36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton36.TabIndex = 88;
            this.myCustomButton36.TabStop = false;
            // 
            // myCustomButton37
            // 
            this.myCustomButton37.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton37.Image = global::MultecPlugin.Properties.Resources.zPlusKal;
            this.myCustomButton37.ImageClicked = global::MultecPlugin.Properties.Resources.zPlusKal_p;
            this.myCustomButton37.ImangeNormal = global::MultecPlugin.Properties.Resources.zPlusKal;
            this.myCustomButton37.Location = new System.Drawing.Point(397, 201);
            this.myCustomButton37.Name = "myCustomButton37";
            this.myCustomButton37.Size = new System.Drawing.Size(36, 33);
            this.myCustomButton37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton37.TabIndex = 87;
            this.myCustomButton37.TabStop = false;
            // 
            // myCustomButton38
            // 
            this.myCustomButton38.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton38.Image = global::MultecPlugin.Properties.Resources.zMinusKal;
            this.myCustomButton38.ImageClicked = global::MultecPlugin.Properties.Resources.zMinusKal_p;
            this.myCustomButton38.ImangeNormal = global::MultecPlugin.Properties.Resources.zMinusKal;
            this.myCustomButton38.Location = new System.Drawing.Point(287, 201);
            this.myCustomButton38.Name = "myCustomButton38";
            this.myCustomButton38.Size = new System.Drawing.Size(36, 33);
            this.myCustomButton38.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton38.TabIndex = 86;
            this.myCustomButton38.TabStop = false;
            // 
            // myCustomButton39
            // 
            this.myCustomButton39.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton39.Image = global::MultecPlugin.Properties.Resources.plus;
            this.myCustomButton39.ImageClicked = global::MultecPlugin.Properties.Resources.plus_p;
            this.myCustomButton39.ImangeNormal = global::MultecPlugin.Properties.Resources.plus;
            this.myCustomButton39.Location = new System.Drawing.Point(397, 135);
            this.myCustomButton39.Name = "myCustomButton39";
            this.myCustomButton39.Size = new System.Drawing.Size(36, 33);
            this.myCustomButton39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton39.TabIndex = 83;
            this.myCustomButton39.TabStop = false;
            // 
            // myCustomButton40
            // 
            this.myCustomButton40.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton40.Image = global::MultecPlugin.Properties.Resources.minus;
            this.myCustomButton40.ImageClicked = global::MultecPlugin.Properties.Resources.minus_p;
            this.myCustomButton40.ImangeNormal = global::MultecPlugin.Properties.Resources.minus;
            this.myCustomButton40.Location = new System.Drawing.Point(287, 135);
            this.myCustomButton40.Name = "myCustomButton40";
            this.myCustomButton40.Size = new System.Drawing.Size(36, 33);
            this.myCustomButton40.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton40.TabIndex = 82;
            this.myCustomButton40.TabStop = false;
            // 
            // myCustomButton41
            // 
            this.myCustomButton41.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton41.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton41.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.myCustomButton41.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton41.Location = new System.Drawing.Point(439, 203);
            this.myCustomButton41.Name = "myCustomButton41";
            this.myCustomButton41.Size = new System.Drawing.Size(89, 31);
            this.myCustomButton41.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton41.TabIndex = 81;
            this.myCustomButton41.TabStop = false;
            // 
            // myCustomButton42
            // 
            this.myCustomButton42.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton42.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton42.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.myCustomButton42.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton42.Location = new System.Drawing.Point(439, 88);
            this.myCustomButton42.Name = "myCustomButton42";
            this.myCustomButton42.Size = new System.Drawing.Size(89, 31);
            this.myCustomButton42.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton42.TabIndex = 80;
            this.myCustomButton42.TabStop = false;
            // 
            // myCustomButton43
            // 
            this.myCustomButton43.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton43.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton43.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.myCustomButton43.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton43.Location = new System.Drawing.Point(439, 136);
            this.myCustomButton43.Name = "myCustomButton43";
            this.myCustomButton43.Size = new System.Drawing.Size(89, 31);
            this.myCustomButton43.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton43.TabIndex = 79;
            this.myCustomButton43.TabStop = false;
            // 
            // myCustomButton44
            // 
            this.myCustomButton44.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton44.Image = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton44.ImageClicked = global::MultecPlugin.Properties.Resources.Schicken_p;
            this.myCustomButton44.ImangeNormal = global::MultecPlugin.Properties.Resources.Schicken;
            this.myCustomButton44.Location = new System.Drawing.Point(439, 266);
            this.myCustomButton44.Name = "myCustomButton44";
            this.myCustomButton44.Size = new System.Drawing.Size(89, 31);
            this.myCustomButton44.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton44.TabIndex = 78;
            this.myCustomButton44.TabStop = false;
            // 
            // myCustomButton45
            // 
            this.myCustomButton45.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton45.Image = global::MultecPlugin.Properties.Resources.ZF;
            this.myCustomButton45.ImageClicked = global::MultecPlugin.Properties.Resources.ZF_p;
            this.myCustomButton45.ImangeNormal = global::MultecPlugin.Properties.Resources.ZF;
            this.myCustomButton45.Location = new System.Drawing.Point(5, 157);
            this.myCustomButton45.Name = "myCustomButton45";
            this.myCustomButton45.Size = new System.Drawing.Size(133, 52);
            this.myCustomButton45.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton45.TabIndex = 74;
            this.myCustomButton45.TabStop = false;
            // 
            // myCustomButton46
            // 
            this.myCustomButton46.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton46.Image = global::MultecPlugin.Properties.Resources.DV;
            this.myCustomButton46.ImageClicked = global::MultecPlugin.Properties.Resources.DV_p;
            this.myCustomButton46.ImangeNormal = global::MultecPlugin.Properties.Resources.DV;
            this.myCustomButton46.Location = new System.Drawing.Point(5, 89);
            this.myCustomButton46.Name = "myCustomButton46";
            this.myCustomButton46.Size = new System.Drawing.Size(133, 52);
            this.myCustomButton46.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton46.TabIndex = 73;
            this.myCustomButton46.TabStop = false;
            // 
            // myCustomButton47
            // 
            this.myCustomButton47.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton47.Image = global::MultecPlugin.Properties.Resources.PP;
            this.myCustomButton47.ImageClicked = global::MultecPlugin.Properties.Resources.PP_p;
            this.myCustomButton47.ImangeNormal = global::MultecPlugin.Properties.Resources.PP;
            this.myCustomButton47.Location = new System.Drawing.Point(5, 20);
            this.myCustomButton47.Name = "myCustomButton47";
            this.myCustomButton47.Size = new System.Drawing.Size(133, 52);
            this.myCustomButton47.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton47.TabIndex = 72;
            this.myCustomButton47.TabStop = false;
            // 
            // myCustomButton48
            // 
            this.myCustomButton48.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton48.Image = global::MultecPlugin.Properties.Resources.Park_Move;
            this.myCustomButton48.ImageClicked = global::MultecPlugin.Properties.Resources.Park_Move_p;
            this.myCustomButton48.ImangeNormal = global::MultecPlugin.Properties.Resources.Park_Move;
            this.myCustomButton48.Location = new System.Drawing.Point(5, 443);
            this.myCustomButton48.Name = "myCustomButton48";
            this.myCustomButton48.Size = new System.Drawing.Size(60, 58);
            this.myCustomButton48.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton48.TabIndex = 71;
            this.myCustomButton48.TabStop = false;
            // 
            // myCustomButton49
            // 
            this.myCustomButton49.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton49.Image = ((System.Drawing.Image)(resources.GetObject("myCustomButton49.Image")));
            this.myCustomButton49.ImageClicked = global::MultecPlugin.Properties.Resources.HOME_Move_p;
            this.myCustomButton49.ImangeNormal = ((System.Drawing.Image)(resources.GetObject("myCustomButton49.ImangeNormal")));
            this.myCustomButton49.Location = new System.Drawing.Point(5, 372);
            this.myCustomButton49.Name = "myCustomButton49";
            this.myCustomButton49.Size = new System.Drawing.Size(60, 57);
            this.myCustomButton49.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton49.TabIndex = 70;
            this.myCustomButton49.TabStop = false;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage5.Controls.Add(this.myCustomButton50);
            this.tabPage5.Controls.Add(this.label82);
            this.tabPage5.Controls.Add(this.label83);
            this.tabPage5.Controls.Add(this.label84);
            this.tabPage5.Controls.Add(this.label85);
            this.tabPage5.Controls.Add(this.label86);
            this.tabPage5.Controls.Add(this.label87);
            this.tabPage5.Controls.Add(this.label88);
            this.tabPage5.Controls.Add(this.label89);
            this.tabPage5.Controls.Add(this.label90);
            this.tabPage5.Controls.Add(this.label91);
            this.tabPage5.Controls.Add(this.label92);
            this.tabPage5.Controls.Add(this.label93);
            this.tabPage5.Controls.Add(this.label94);
            this.tabPage5.Controls.Add(this.label95);
            this.tabPage5.Controls.Add(this.label96);
            this.tabPage5.Controls.Add(this.label97);
            this.tabPage5.Controls.Add(this.label98);
            this.tabPage5.Controls.Add(this.label99);
            this.tabPage5.Controls.Add(this.label100);
            this.tabPage5.Controls.Add(this.label101);
            this.tabPage5.Controls.Add(this.label102);
            this.tabPage5.Controls.Add(this.label103);
            this.tabPage5.Controls.Add(this.label104);
            this.tabPage5.Controls.Add(this.label105);
            this.tabPage5.Controls.Add(this.label106);
            this.tabPage5.Controls.Add(this.label107);
            this.tabPage5.Controls.Add(this.label108);
            this.tabPage5.Controls.Add(this.label109);
            this.tabPage5.Controls.Add(this.label110);
            this.tabPage5.Controls.Add(this.label111);
            this.tabPage5.Controls.Add(this.label112);
            this.tabPage5.Controls.Add(this.label113);
            this.tabPage5.Controls.Add(this.label114);
            this.tabPage5.Controls.Add(this.label115);
            this.tabPage5.Controls.Add(this.label116);
            this.tabPage5.Controls.Add(this.label117);
            this.tabPage5.Controls.Add(this.label118);
            this.tabPage5.Controls.Add(this.label119);
            this.tabPage5.Controls.Add(this.label120);
            this.tabPage5.Controls.Add(this.label121);
            this.tabPage5.Controls.Add(this.label122);
            this.tabPage5.Controls.Add(this.label123);
            this.tabPage5.Controls.Add(this.label124);
            this.tabPage5.Controls.Add(this.label125);
            this.tabPage5.Controls.Add(this.label126);
            this.tabPage5.Controls.Add(this.label127);
            this.tabPage5.Controls.Add(this.label128);
            this.tabPage5.Controls.Add(this.label129);
            this.tabPage5.Controls.Add(this.label130);
            this.tabPage5.Controls.Add(this.label131);
            this.tabPage5.Controls.Add(this.label132);
            this.tabPage5.Controls.Add(this.label133);
            this.tabPage5.Controls.Add(this.label134);
            this.tabPage5.Controls.Add(this.label135);
            this.tabPage5.Controls.Add(this.label136);
            this.tabPage5.Controls.Add(this.label137);
            this.tabPage5.Controls.Add(this.label138);
            this.tabPage5.Controls.Add(this.label139);
            this.tabPage5.Controls.Add(this.label140);
            this.tabPage5.Controls.Add(this.label141);
            this.tabPage5.Controls.Add(this.label142);
            this.tabPage5.Controls.Add(this.label143);
            this.tabPage5.Controls.Add(this.label144);
            this.tabPage5.Controls.Add(this.label145);
            this.tabPage5.Controls.Add(this.label146);
            this.tabPage5.Controls.Add(this.label147);
            this.tabPage5.Controls.Add(this.label148);
            this.tabPage5.Controls.Add(this.label149);
            this.tabPage5.Controls.Add(this.label150);
            this.tabPage5.Controls.Add(this.label151);
            this.tabPage5.Controls.Add(this.label152);
            this.tabPage5.Controls.Add(this.label153);
            this.tabPage5.Controls.Add(this.label154);
            this.tabPage5.Controls.Add(this.label155);
            this.tabPage5.Controls.Add(this.label156);
            this.tabPage5.Controls.Add(this.label157);
            this.tabPage5.Controls.Add(this.label158);
            this.tabPage5.Controls.Add(this.label159);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(581, 548);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Information";
            // 
            // myCustomButton50
            // 
            this.myCustomButton50.BackColor = System.Drawing.Color.Transparent;
            this.myCustomButton50.Image = global::MultecPlugin.Properties.Resources.Aktualizieren;
            this.myCustomButton50.ImageClicked = global::MultecPlugin.Properties.Resources.Aktualizieren_p;
            this.myCustomButton50.ImangeNormal = global::MultecPlugin.Properties.Resources.Aktualizieren;
            this.myCustomButton50.Location = new System.Drawing.Point(6, 16);
            this.myCustomButton50.Name = "myCustomButton50";
            this.myCustomButton50.Size = new System.Drawing.Size(107, 36);
            this.myCustomButton50.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myCustomButton50.TabIndex = 119;
            this.myCustomButton50.TabStop = false;
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.BackColor = System.Drawing.SystemColors.Control;
            this.label82.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label82.Location = new System.Drawing.Point(461, 89);
            this.label82.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(31, 13);
            this.label82.TabIndex = 118;
            this.label82.Text = "NULL";
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.BackColor = System.Drawing.SystemColors.Control;
            this.label83.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label83.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label83.Location = new System.Drawing.Point(204, 89);
            this.label83.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(235, 13);
            this.label83.TabIndex = 117;
            this.label83.Text = "Rotational Offset Filamentauswahl (mm)";
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.BackColor = System.Drawing.SystemColors.Control;
            this.label84.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label84.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label84.Location = new System.Drawing.Point(461, 134);
            this.label84.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(31, 13);
            this.label84.TabIndex = 116;
            this.label84.Text = "NULL";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.BackColor = System.Drawing.SystemColors.Control;
            this.label85.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label85.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label85.Location = new System.Drawing.Point(330, 134);
            this.label85.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(109, 13);
            this.label85.TabIndex = 115;
            this.label85.Text = "Z-Correction (mm)";
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.BackColor = System.Drawing.SystemColors.Control;
            this.label86.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label86.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label86.Location = new System.Drawing.Point(461, 104);
            this.label86.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(31, 13);
            this.label86.TabIndex = 114;
            this.label86.Text = "NULL";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.BackColor = System.Drawing.SystemColors.Control;
            this.label87.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label87.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label87.Location = new System.Drawing.Point(246, 104);
            this.label87.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(193, 13);
            this.label87.TabIndex = 113;
            this.label87.Text = "Distance T0 <-> Multisense (mm)";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.BackColor = System.Drawing.SystemColors.Control;
            this.label88.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label88.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label88.Location = new System.Drawing.Point(461, 119);
            this.label88.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(31, 13);
            this.label88.TabIndex = 112;
            this.label88.Text = "NULL";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.BackColor = System.Drawing.SystemColors.Control;
            this.label89.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label89.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label89.Location = new System.Drawing.Point(198, 119);
            this.label89.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(241, 13);
            this.label89.TabIndex = 111;
            this.label89.Text = "Optimal Distance T0 <-> Multisense (mm)";
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.BackColor = System.Drawing.SystemColors.Control;
            this.label90.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label90.Location = new System.Drawing.Point(461, 74);
            this.label90.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(31, 13);
            this.label90.TabIndex = 110;
            this.label90.Text = "NULL";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.BackColor = System.Drawing.SystemColors.Control;
            this.label91.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label91.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label91.Location = new System.Drawing.Point(216, 74);
            this.label91.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(223, 13);
            this.label91.TabIndex = 109;
            this.label91.Text = "Rotational Offset Move Extruder (mm)";
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.BackColor = System.Drawing.SystemColors.Control;
            this.label92.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label92.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label92.Location = new System.Drawing.Point(372, 379);
            this.label92.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(31, 13);
            this.label92.TabIndex = 108;
            this.label92.Text = "NULL";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.BackColor = System.Drawing.SystemColors.Control;
            this.label93.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label93.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label93.Location = new System.Drawing.Point(372, 364);
            this.label93.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(31, 13);
            this.label93.TabIndex = 107;
            this.label93.Text = "NULL";
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.BackColor = System.Drawing.SystemColors.Control;
            this.label94.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label94.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label94.Location = new System.Drawing.Point(372, 349);
            this.label94.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(31, 13);
            this.label94.TabIndex = 106;
            this.label94.Text = "NULL";
            // 
            // label95
            // 
            this.label95.AutoSize = true;
            this.label95.BackColor = System.Drawing.SystemColors.Control;
            this.label95.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label95.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label95.Location = new System.Drawing.Point(372, 334);
            this.label95.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label95.Name = "label95";
            this.label95.Size = new System.Drawing.Size(31, 13);
            this.label95.TabIndex = 105;
            this.label95.Text = "NULL";
            // 
            // label96
            // 
            this.label96.AutoSize = true;
            this.label96.BackColor = System.Drawing.SystemColors.Control;
            this.label96.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label96.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label96.Location = new System.Drawing.Point(372, 443);
            this.label96.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label96.Name = "label96";
            this.label96.Size = new System.Drawing.Size(31, 13);
            this.label96.TabIndex = 104;
            this.label96.Text = "NULL";
            // 
            // label97
            // 
            this.label97.AutoSize = true;
            this.label97.BackColor = System.Drawing.SystemColors.Control;
            this.label97.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label97.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label97.Location = new System.Drawing.Point(372, 428);
            this.label97.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label97.Name = "label97";
            this.label97.Size = new System.Drawing.Size(31, 13);
            this.label97.TabIndex = 103;
            this.label97.Text = "NULL";
            // 
            // label98
            // 
            this.label98.AutoSize = true;
            this.label98.BackColor = System.Drawing.SystemColors.Control;
            this.label98.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label98.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label98.Location = new System.Drawing.Point(372, 413);
            this.label98.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label98.Name = "label98";
            this.label98.Size = new System.Drawing.Size(31, 13);
            this.label98.TabIndex = 102;
            this.label98.Text = "NULL";
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.BackColor = System.Drawing.SystemColors.Control;
            this.label99.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label99.Location = new System.Drawing.Point(372, 398);
            this.label99.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(31, 13);
            this.label99.TabIndex = 101;
            this.label99.Text = "NULL";
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.BackColor = System.Drawing.SystemColors.Control;
            this.label100.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label100.Location = new System.Drawing.Point(372, 319);
            this.label100.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(31, 13);
            this.label100.TabIndex = 100;
            this.label100.Text = "NULL";
            // 
            // label101
            // 
            this.label101.AutoSize = true;
            this.label101.BackColor = System.Drawing.SystemColors.Control;
            this.label101.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label101.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label101.Location = new System.Drawing.Point(372, 304);
            this.label101.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label101.Name = "label101";
            this.label101.Size = new System.Drawing.Size(31, 13);
            this.label101.TabIndex = 99;
            this.label101.Text = "NULL";
            // 
            // label102
            // 
            this.label102.AutoSize = true;
            this.label102.BackColor = System.Drawing.SystemColors.Control;
            this.label102.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label102.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label102.Location = new System.Drawing.Point(372, 289);
            this.label102.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(31, 13);
            this.label102.TabIndex = 98;
            this.label102.Text = "NULL";
            // 
            // label103
            // 
            this.label103.AutoSize = true;
            this.label103.BackColor = System.Drawing.SystemColors.Control;
            this.label103.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label103.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label103.Location = new System.Drawing.Point(372, 274);
            this.label103.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label103.Name = "label103";
            this.label103.Size = new System.Drawing.Size(31, 13);
            this.label103.TabIndex = 97;
            this.label103.Text = "NULL";
            // 
            // label104
            // 
            this.label104.AutoSize = true;
            this.label104.BackColor = System.Drawing.SystemColors.Control;
            this.label104.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label104.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label104.Location = new System.Drawing.Point(372, 253);
            this.label104.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label104.Name = "label104";
            this.label104.Size = new System.Drawing.Size(31, 13);
            this.label104.TabIndex = 96;
            this.label104.Text = "NULL";
            // 
            // label105
            // 
            this.label105.AutoSize = true;
            this.label105.BackColor = System.Drawing.SystemColors.Control;
            this.label105.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label105.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label105.Location = new System.Drawing.Point(372, 239);
            this.label105.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label105.Name = "label105";
            this.label105.Size = new System.Drawing.Size(31, 13);
            this.label105.TabIndex = 95;
            this.label105.Text = "NULL";
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.BackColor = System.Drawing.SystemColors.Control;
            this.label106.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label106.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label106.Location = new System.Drawing.Point(372, 224);
            this.label106.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(31, 13);
            this.label106.TabIndex = 94;
            this.label106.Text = "NULL";
            // 
            // label107
            // 
            this.label107.AutoSize = true;
            this.label107.BackColor = System.Drawing.SystemColors.Control;
            this.label107.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label107.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label107.Location = new System.Drawing.Point(372, 202);
            this.label107.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label107.Name = "label107";
            this.label107.Size = new System.Drawing.Size(31, 13);
            this.label107.TabIndex = 93;
            this.label107.Text = "NULL";
            // 
            // label108
            // 
            this.label108.AutoSize = true;
            this.label108.BackColor = System.Drawing.SystemColors.Control;
            this.label108.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label108.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label108.Location = new System.Drawing.Point(372, 187);
            this.label108.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(31, 13);
            this.label108.TabIndex = 92;
            this.label108.Text = "NULL";
            // 
            // label109
            // 
            this.label109.AutoSize = true;
            this.label109.BackColor = System.Drawing.SystemColors.Control;
            this.label109.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label109.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label109.Location = new System.Drawing.Point(372, 172);
            this.label109.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label109.Name = "label109";
            this.label109.Size = new System.Drawing.Size(31, 13);
            this.label109.TabIndex = 91;
            this.label109.Text = "NULL";
            // 
            // label110
            // 
            this.label110.AutoSize = true;
            this.label110.BackColor = System.Drawing.SystemColors.Control;
            this.label110.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label110.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label110.Location = new System.Drawing.Point(302, 157);
            this.label110.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label110.Name = "label110";
            this.label110.Size = new System.Drawing.Size(181, 13);
            this.label110.TabIndex = 90;
            this.label110.Text = "Lifetime (Since Last Service)";
            // 
            // label111
            // 
            this.label111.AutoSize = true;
            this.label111.BackColor = System.Drawing.SystemColors.Control;
            this.label111.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label111.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label111.Location = new System.Drawing.Point(178, 379);
            this.label111.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label111.Name = "label111";
            this.label111.Size = new System.Drawing.Size(31, 13);
            this.label111.TabIndex = 89;
            this.label111.Text = "NULL";
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.BackColor = System.Drawing.SystemColors.Control;
            this.label112.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label112.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label112.Location = new System.Drawing.Point(178, 364);
            this.label112.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(31, 13);
            this.label112.TabIndex = 88;
            this.label112.Text = "NULL";
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.BackColor = System.Drawing.SystemColors.Control;
            this.label113.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label113.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label113.Location = new System.Drawing.Point(178, 349);
            this.label113.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(31, 13);
            this.label113.TabIndex = 87;
            this.label113.Text = "NULL";
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.BackColor = System.Drawing.SystemColors.Control;
            this.label114.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label114.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label114.Location = new System.Drawing.Point(178, 334);
            this.label114.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(31, 13);
            this.label114.TabIndex = 86;
            this.label114.Text = "NULL";
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.BackColor = System.Drawing.SystemColors.Control;
            this.label115.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label115.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label115.Location = new System.Drawing.Point(5, 379);
            this.label115.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(157, 13);
            this.label115.TabIndex = 85;
            this.label115.Text = "T3 Extruded Filament (kg)";
            // 
            // label116
            // 
            this.label116.AutoSize = true;
            this.label116.BackColor = System.Drawing.SystemColors.Control;
            this.label116.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label116.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label116.Location = new System.Drawing.Point(5, 364);
            this.label116.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label116.Name = "label116";
            this.label116.Size = new System.Drawing.Size(157, 13);
            this.label116.TabIndex = 84;
            this.label116.Text = "T2 Extruded Filament (kg)";
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.BackColor = System.Drawing.SystemColors.Control;
            this.label117.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label117.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label117.Location = new System.Drawing.Point(5, 349);
            this.label117.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(157, 13);
            this.label117.TabIndex = 83;
            this.label117.Text = "T1 Extruded Filament (kg)";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.BackColor = System.Drawing.SystemColors.Control;
            this.label118.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label118.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label118.Location = new System.Drawing.Point(5, 334);
            this.label118.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(157, 13);
            this.label118.TabIndex = 82;
            this.label118.Text = "T0 Extruded Filament (kg)";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.BackColor = System.Drawing.SystemColors.Control;
            this.label119.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label119.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label119.Location = new System.Drawing.Point(178, 443);
            this.label119.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(31, 13);
            this.label119.TabIndex = 80;
            this.label119.Text = "NULL";
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.BackColor = System.Drawing.SystemColors.Control;
            this.label120.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label120.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label120.Location = new System.Drawing.Point(178, 428);
            this.label120.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(31, 13);
            this.label120.TabIndex = 79;
            this.label120.Text = "NULL";
            // 
            // label121
            // 
            this.label121.AutoSize = true;
            this.label121.BackColor = System.Drawing.SystemColors.Control;
            this.label121.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label121.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label121.Location = new System.Drawing.Point(178, 413);
            this.label121.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label121.Name = "label121";
            this.label121.Size = new System.Drawing.Size(31, 13);
            this.label121.TabIndex = 78;
            this.label121.Text = "NULL";
            // 
            // label122
            // 
            this.label122.AutoSize = true;
            this.label122.BackColor = System.Drawing.SystemColors.Control;
            this.label122.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label122.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label122.Location = new System.Drawing.Point(178, 398);
            this.label122.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label122.Name = "label122";
            this.label122.Size = new System.Drawing.Size(31, 13);
            this.label122.TabIndex = 77;
            this.label122.Text = "NULL";
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.BackColor = System.Drawing.SystemColors.Control;
            this.label123.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label123.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label123.Location = new System.Drawing.Point(178, 319);
            this.label123.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(31, 13);
            this.label123.TabIndex = 76;
            this.label123.Text = "NULL";
            // 
            // label124
            // 
            this.label124.AutoSize = true;
            this.label124.BackColor = System.Drawing.SystemColors.Control;
            this.label124.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label124.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label124.Location = new System.Drawing.Point(178, 304);
            this.label124.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label124.Name = "label124";
            this.label124.Size = new System.Drawing.Size(31, 13);
            this.label124.TabIndex = 75;
            this.label124.Text = "NULL";
            // 
            // label125
            // 
            this.label125.AutoSize = true;
            this.label125.BackColor = System.Drawing.SystemColors.Control;
            this.label125.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label125.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label125.Location = new System.Drawing.Point(178, 289);
            this.label125.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label125.Name = "label125";
            this.label125.Size = new System.Drawing.Size(31, 13);
            this.label125.TabIndex = 74;
            this.label125.Text = "NULL";
            // 
            // label126
            // 
            this.label126.AutoSize = true;
            this.label126.BackColor = System.Drawing.SystemColors.Control;
            this.label126.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label126.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label126.Location = new System.Drawing.Point(178, 274);
            this.label126.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label126.Name = "label126";
            this.label126.Size = new System.Drawing.Size(31, 13);
            this.label126.TabIndex = 73;
            this.label126.Text = "NULL";
            // 
            // label127
            // 
            this.label127.AutoSize = true;
            this.label127.BackColor = System.Drawing.SystemColors.Control;
            this.label127.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label127.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label127.Location = new System.Drawing.Point(178, 253);
            this.label127.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label127.Name = "label127";
            this.label127.Size = new System.Drawing.Size(31, 13);
            this.label127.TabIndex = 72;
            this.label127.Text = "NULL";
            // 
            // label128
            // 
            this.label128.AutoSize = true;
            this.label128.BackColor = System.Drawing.SystemColors.Control;
            this.label128.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label128.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label128.Location = new System.Drawing.Point(178, 239);
            this.label128.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label128.Name = "label128";
            this.label128.Size = new System.Drawing.Size(31, 13);
            this.label128.TabIndex = 71;
            this.label128.Text = "NULL";
            // 
            // label129
            // 
            this.label129.AutoSize = true;
            this.label129.BackColor = System.Drawing.SystemColors.Control;
            this.label129.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label129.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label129.Location = new System.Drawing.Point(178, 224);
            this.label129.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label129.Name = "label129";
            this.label129.Size = new System.Drawing.Size(31, 13);
            this.label129.TabIndex = 70;
            this.label129.Text = "NULL";
            // 
            // label130
            // 
            this.label130.AutoSize = true;
            this.label130.BackColor = System.Drawing.SystemColors.Control;
            this.label130.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label130.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label130.Location = new System.Drawing.Point(178, 202);
            this.label130.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label130.Name = "label130";
            this.label130.Size = new System.Drawing.Size(31, 13);
            this.label130.TabIndex = 69;
            this.label130.Text = "NULL";
            // 
            // label131
            // 
            this.label131.AutoSize = true;
            this.label131.BackColor = System.Drawing.SystemColors.Control;
            this.label131.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label131.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label131.Location = new System.Drawing.Point(178, 187);
            this.label131.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label131.Name = "label131";
            this.label131.Size = new System.Drawing.Size(31, 13);
            this.label131.TabIndex = 68;
            this.label131.Text = "NULL";
            // 
            // label132
            // 
            this.label132.AutoSize = true;
            this.label132.BackColor = System.Drawing.SystemColors.Control;
            this.label132.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label132.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label132.Location = new System.Drawing.Point(178, 172);
            this.label132.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label132.Name = "label132";
            this.label132.Size = new System.Drawing.Size(31, 13);
            this.label132.TabIndex = 67;
            this.label132.Text = "NULL";
            // 
            // label133
            // 
            this.label133.AutoSize = true;
            this.label133.BackColor = System.Drawing.SystemColors.Control;
            this.label133.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label133.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label133.Location = new System.Drawing.Point(146, 157);
            this.label133.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label133.Name = "label133";
            this.label133.Size = new System.Drawing.Size(103, 13);
            this.label133.TabIndex = 66;
            this.label133.Text = "Lifetime (TOTAL)";
            // 
            // label134
            // 
            this.label134.AutoSize = true;
            this.label134.BackColor = System.Drawing.SystemColors.Control;
            this.label134.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label134.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label134.Location = new System.Drawing.Point(54, 134);
            this.label134.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label134.Name = "label134";
            this.label134.Size = new System.Drawing.Size(31, 13);
            this.label134.TabIndex = 65;
            this.label134.Text = "NULL";
            // 
            // label135
            // 
            this.label135.AutoSize = true;
            this.label135.BackColor = System.Drawing.SystemColors.Control;
            this.label135.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label135.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label135.Location = new System.Drawing.Point(54, 119);
            this.label135.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label135.Name = "label135";
            this.label135.Size = new System.Drawing.Size(31, 13);
            this.label135.TabIndex = 64;
            this.label135.Text = "NULL";
            // 
            // label136
            // 
            this.label136.AutoSize = true;
            this.label136.BackColor = System.Drawing.SystemColors.Control;
            this.label136.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label136.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label136.Location = new System.Drawing.Point(54, 104);
            this.label136.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label136.Name = "label136";
            this.label136.Size = new System.Drawing.Size(31, 13);
            this.label136.TabIndex = 63;
            this.label136.Text = "NULL";
            // 
            // label137
            // 
            this.label137.AutoSize = true;
            this.label137.BackColor = System.Drawing.SystemColors.Control;
            this.label137.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label137.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label137.Location = new System.Drawing.Point(54, 89);
            this.label137.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label137.Name = "label137";
            this.label137.Size = new System.Drawing.Size(31, 13);
            this.label137.TabIndex = 62;
            this.label137.Text = "NULL";
            // 
            // label138
            // 
            this.label138.AutoSize = true;
            this.label138.BackColor = System.Drawing.SystemColors.Control;
            this.label138.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label138.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label138.Location = new System.Drawing.Point(178, 55);
            this.label138.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(31, 13);
            this.label138.TabIndex = 60;
            this.label138.Text = "Null";
            // 
            // label139
            // 
            this.label139.AutoSize = true;
            this.label139.BackColor = System.Drawing.SystemColors.Control;
            this.label139.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label139.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label139.Location = new System.Drawing.Point(5, 443);
            this.label139.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label139.Name = "label139";
            this.label139.Size = new System.Drawing.Size(91, 13);
            this.label139.TabIndex = 57;
            this.label139.Text = "T3 Heated Time";
            // 
            // label140
            // 
            this.label140.AutoSize = true;
            this.label140.BackColor = System.Drawing.SystemColors.Control;
            this.label140.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label140.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label140.Location = new System.Drawing.Point(5, 428);
            this.label140.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label140.Name = "label140";
            this.label140.Size = new System.Drawing.Size(91, 13);
            this.label140.TabIndex = 56;
            this.label140.Text = "T2 Heated Time";
            // 
            // label141
            // 
            this.label141.AutoSize = true;
            this.label141.BackColor = System.Drawing.SystemColors.Control;
            this.label141.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label141.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label141.Location = new System.Drawing.Point(5, 413);
            this.label141.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label141.Name = "label141";
            this.label141.Size = new System.Drawing.Size(91, 13);
            this.label141.TabIndex = 55;
            this.label141.Text = "T1 Heated Time";
            // 
            // label142
            // 
            this.label142.AutoSize = true;
            this.label142.BackColor = System.Drawing.SystemColors.Control;
            this.label142.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label142.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label142.Location = new System.Drawing.Point(5, 398);
            this.label142.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label142.Name = "label142";
            this.label142.Size = new System.Drawing.Size(91, 13);
            this.label142.TabIndex = 54;
            this.label142.Text = "T0 Heated Time";
            // 
            // label143
            // 
            this.label143.AutoSize = true;
            this.label143.BackColor = System.Drawing.SystemColors.Control;
            this.label143.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label143.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label143.Location = new System.Drawing.Point(5, 319);
            this.label143.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(151, 13);
            this.label143.TabIndex = 53;
            this.label143.Text = "T3 Extruded Filament (m)";
            // 
            // label144
            // 
            this.label144.AutoSize = true;
            this.label144.BackColor = System.Drawing.SystemColors.Control;
            this.label144.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label144.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label144.Location = new System.Drawing.Point(5, 304);
            this.label144.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(151, 13);
            this.label144.TabIndex = 52;
            this.label144.Text = "T2 Extruded Filament (m)";
            // 
            // label145
            // 
            this.label145.AutoSize = true;
            this.label145.BackColor = System.Drawing.SystemColors.Control;
            this.label145.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label145.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label145.Location = new System.Drawing.Point(5, 289);
            this.label145.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label145.Name = "label145";
            this.label145.Size = new System.Drawing.Size(151, 13);
            this.label145.TabIndex = 51;
            this.label145.Text = "T1 Extruded Filament (m)";
            // 
            // label146
            // 
            this.label146.AutoSize = true;
            this.label146.BackColor = System.Drawing.SystemColors.Control;
            this.label146.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label146.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label146.Location = new System.Drawing.Point(5, 274);
            this.label146.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label146.Name = "label146";
            this.label146.Size = new System.Drawing.Size(151, 13);
            this.label146.TabIndex = 50;
            this.label146.Text = "T0 Extruded Filament (m)";
            // 
            // label147
            // 
            this.label147.AutoSize = true;
            this.label147.BackColor = System.Drawing.SystemColors.Control;
            this.label147.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label147.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label147.Location = new System.Drawing.Point(5, 253);
            this.label147.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label147.Name = "label147";
            this.label147.Size = new System.Drawing.Size(133, 13);
            this.label147.TabIndex = 49;
            this.label147.Text = "Z Travel distance (m)";
            // 
            // label148
            // 
            this.label148.AutoSize = true;
            this.label148.BackColor = System.Drawing.SystemColors.Control;
            this.label148.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label148.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label148.Location = new System.Drawing.Point(5, 239);
            this.label148.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label148.Name = "label148";
            this.label148.Size = new System.Drawing.Size(133, 13);
            this.label148.TabIndex = 48;
            this.label148.Text = "Y Travel distance (m)";
            // 
            // label149
            // 
            this.label149.AutoSize = true;
            this.label149.BackColor = System.Drawing.SystemColors.Control;
            this.label149.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label149.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label149.Location = new System.Drawing.Point(5, 224);
            this.label149.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label149.Name = "label149";
            this.label149.Size = new System.Drawing.Size(133, 13);
            this.label149.TabIndex = 47;
            this.label149.Text = "X Travel distance (m)";
            // 
            // label150
            // 
            this.label150.AutoSize = true;
            this.label150.BackColor = System.Drawing.SystemColors.Control;
            this.label150.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label150.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label150.Location = new System.Drawing.Point(29, 202);
            this.label150.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label150.Name = "label150";
            this.label150.Size = new System.Drawing.Size(67, 13);
            this.label150.TabIndex = 46;
            this.label150.Text = "Print Life";
            // 
            // label151
            // 
            this.label151.AutoSize = true;
            this.label151.BackColor = System.Drawing.SystemColors.Control;
            this.label151.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label151.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label151.Location = new System.Drawing.Point(29, 187);
            this.label151.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label151.Name = "label151";
            this.label151.Size = new System.Drawing.Size(85, 13);
            this.label151.TabIndex = 45;
            this.label151.Text = "Power On Time";
            // 
            // label152
            // 
            this.label152.AutoSize = true;
            this.label152.BackColor = System.Drawing.SystemColors.Control;
            this.label152.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label152.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label152.Location = new System.Drawing.Point(29, 172);
            this.label152.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label152.Name = "label152";
            this.label152.Size = new System.Drawing.Size(79, 13);
            this.label152.TabIndex = 44;
            this.label152.Text = "Power Cycles";
            // 
            // label153
            // 
            this.label153.AutoSize = true;
            this.label153.BackColor = System.Drawing.SystemColors.Control;
            this.label153.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label153.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label153.Location = new System.Drawing.Point(5, 157);
            this.label153.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label153.Name = "label153";
            this.label153.Size = new System.Drawing.Size(121, 13);
            this.label153.TabIndex = 43;
            this.label153.Text = "Lifetime Statistics";
            // 
            // label154
            // 
            this.label154.AutoSize = true;
            this.label154.BackColor = System.Drawing.SystemColors.Control;
            this.label154.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label154.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label154.Location = new System.Drawing.Point(29, 134);
            this.label154.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label154.Name = "label154";
            this.label154.Size = new System.Drawing.Size(19, 13);
            this.label154.TabIndex = 42;
            this.label154.Text = "T3";
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.BackColor = System.Drawing.SystemColors.Control;
            this.label155.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label155.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label155.Location = new System.Drawing.Point(29, 119);
            this.label155.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(19, 13);
            this.label155.TabIndex = 41;
            this.label155.Text = "T2";
            // 
            // label156
            // 
            this.label156.AutoSize = true;
            this.label156.BackColor = System.Drawing.SystemColors.Control;
            this.label156.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label156.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label156.Location = new System.Drawing.Point(29, 104);
            this.label156.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label156.Name = "label156";
            this.label156.Size = new System.Drawing.Size(19, 13);
            this.label156.TabIndex = 40;
            this.label156.Text = "T1";
            // 
            // label157
            // 
            this.label157.AutoSize = true;
            this.label157.BackColor = System.Drawing.SystemColors.Control;
            this.label157.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label157.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label157.Location = new System.Drawing.Point(29, 89);
            this.label157.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label157.Name = "label157";
            this.label157.Size = new System.Drawing.Size(19, 13);
            this.label157.TabIndex = 39;
            this.label157.Text = "T0";
            // 
            // label158
            // 
            this.label158.AutoSize = true;
            this.label158.BackColor = System.Drawing.SystemColors.Control;
            this.label158.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label158.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label158.Location = new System.Drawing.Point(5, 74);
            this.label158.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label158.Name = "label158";
            this.label158.Size = new System.Drawing.Size(85, 13);
            this.label158.TabIndex = 38;
            this.label158.Text = "Duese Abstand";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.BackColor = System.Drawing.SystemColors.Control;
            this.label159.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label159.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label159.Location = new System.Drawing.Point(5, 55);
            this.label159.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(103, 13);
            this.label159.TabIndex = 37;
            this.label159.Text = "Firmware Version";
            // 
            // MultecTouchpanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Name = "MultecTouchpanel";
            this.Size = new System.Drawing.Size(590, 595);
            tabpage2.ResumeLayout(false);
            tabpage2.PerformLayout();
            this.druckPermissives.ResumeLayout(false);
            this.druckPermissives.PerformLayout();
            this.filamentUberwachung.ResumeLayout(false);
            this.filamentUberwachung.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFilAktualise)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnM218T1)).EndInit();
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
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStep50)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStep1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_NozzleTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BedTemp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TouchControl.ResumeLayout(false);
            this.TouchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericFlowrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFeedrate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXhome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBedMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBedPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNozzleMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnNozzlePlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBed_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT3_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT2_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT1_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnT0_OnOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnParkMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMotorOff)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnManualGcodeSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHomeMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExtrude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetract)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZminus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnZPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXMinus)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInfoAktualise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton2)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton12)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton21)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton24)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton30)).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton31)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton49)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myCustomButton50)).EndInit();
            this.ResumeLayout(false);

        }

        private MouseEventHandler myCustomButton1_Click()
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar trackBar_NozzleTemp;
        private System.Windows.Forms.TextBox text_T0_ziel;
        private System.Windows.Forms.TextBox text_T1_ziel;
        private System.Windows.Forms.TextBox text_T2_ziel;
        private System.Windows.Forms.TextBox text_T3_ziel;
        private System.Windows.Forms.TextBox text_T0_Aktuell;
        private System.Windows.Forms.TextBox text_T1_Aktuell;
        private System.Windows.Forms.TextBox text_T2_Aktuell;
        private System.Windows.Forms.TextBox text_T3_Aktuell;
        private System.Windows.Forms.TrackBar trackBar_BedTemp;
        private System.Windows.Forms.TextBox text_Bed_ziel;
        private System.Windows.Forms.TextBox text_Bed_Aktuell;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Label label22;
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
        private GroupBox filamentUberwachung;
        private Label lblFilamentT3;
        private Label lblFilamentT2;
        private Label lblFilamentT0;
        private Label lblFilamentT1;
        private Label lblFilamentStatus;
        private Label label46;
        private Label lblT3_1;
        private Label lblT2_1;
        private Label label47;
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
        private System.ComponentModel.BackgroundWorker wrkrCallG222;
        private MyCustomButton.MyCustomButton btnMotorOff;
        private MyCustomButton.MyCustomButton btnHome;
        private MyCustomButton.MyCustomButton btnParkMove;
        
        private MyCustomButton.MyCustomButton btnMove;
        private PictureBox btnT0_OnOff;
        private PictureBox btnBed_OnOff;
        private PictureBox btnT3_OnOff;
        private PictureBox btnT2_OnOff;
        private PictureBox btnT1_OnOff;
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
        private RadioButton radBtnMove;
        private RadioButton radioBtnDrucker;
        private MyCustomButton.MyCustomButton btnNozzlePlus;
        private MyCustomButton.MyCustomButton btnNozzleMinus;
        private MyCustomButton.MyCustomButton btnBedMinus;
        private MyCustomButton.MyCustomButton btnBedPlus;
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
        private MyCustomButton.MyCustomButton btnFilAktualise;
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
        private MyCustomButton.MyCustomButton btnZhome;
        private MyCustomButton.MyCustomButton btnYhome;
        private MyCustomButton.MyCustomButton btnXhome;
        private Button btnFilamentChange;
        private Label lblFlowrate;
        private NumericUpDown numericFlowrate;
        private Label lbFeedrate;
        private NumericUpDown numericFeedrate;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TrackBar trackBar3;
        private TrackBar trackBar4;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private Label label10;
        private NumericUpDown numericUpDown2;
        private MyCustomButton.MyCustomButton myCustomButton3;
        private MyCustomButton.MyCustomButton myCustomButton4;
        private MyCustomButton.MyCustomButton myCustomButton5;
        private MyCustomButton.MyCustomButton myCustomButton6;
        private MyCustomButton.MyCustomButton myCustomButton7;
        private MyCustomButton.MyCustomButton myCustomButton8;
        private MyCustomButton.MyCustomButton myCustomButton9;
        private Label label20;
        private Label label21;
        private Label label31;
        private Label label32;
        private Label label35;
        private Label label36;
        private CheckBox checkBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private MyCustomButton.MyCustomButton myCustomButton10;
        private MyCustomButton.MyCustomButton myCustomButton11;
        private MyCustomButton.MyCustomButton myCustomButton12;
        private GroupBox groupBox4;
        private MyCustomButton.MyCustomButton myCustomButton13;
        private Label label44;
        private TextBox textBox1;
        private MyCustomButton.MyCustomButton myCustomButton14;
        private MyCustomButton.MyCustomButton myCustomButton15;
        private MyCustomButton.MyCustomButton myCustomButton16;
        private MyCustomButton.MyCustomButton myCustomButton17;
        private MyCustomButton.MyCustomButton myCustomButton18;
        private MyCustomButton.MyCustomButton myCustomButton19;
        private MyCustomButton.MyCustomButton myCustomButton20;
        private MyCustomButton.MyCustomButton myCustomButton21;
        private GroupBox groupBox6;
        private MyCustomButton.MyCustomButton myCustomButton22;
        private MyCustomButton.MyCustomButton myCustomButton23;
        private MyCustomButton.MyCustomButton myCustomButton24;
        private Label label45;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label55;
        private Label label56;
        private Label label57;
        private GroupBox groupBox7;
        private MyCustomButton.MyCustomButton myCustomButton25;
        private MyCustomButton.MyCustomButton myCustomButton26;
        private MyCustomButton.MyCustomButton myCustomButton27;
        private MyCustomButton.MyCustomButton myCustomButton28;
        private MyCustomButton.MyCustomButton myCustomButton29;
        private Label label58;
        private TextBox textBox2;
        private TextBox textBox3;
        private TrackBar trackBar5;
        private TextBox textBox4;
        private TrackBar trackBar6;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private MyCustomButton.MyCustomButton myCustomButton30;
        private Button button1;
        private GroupBox groupBox8;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label59;
        private Label label60;
        private Label label63;
        private Label label64;
        private GroupBox groupBox9;
        private MyCustomButton.MyCustomButton myCustomButton31;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label69;
        private Label label71;
        private Label label72;
        private Label label73;
        private Label label74;
        private Label label75;
        private Label label76;
        private Label label77;
        private GroupBox groupBox10;
        private MyCustomButton.MyCustomButton myCustomButton32;
        private MyCustomButton.MyCustomButton myCustomButton33;
        private MyCustomButton.MyCustomButton myCustomButton34;
        private Label label78;
        private Label label79;
        private TextBox textBox12;
        private TextBox textBox13;
        private Label label80;
        private Label label81;
        private MyCustomButton.MyCustomButton myCustomButton35;
        private MyCustomButton.MyCustomButton myCustomButton36;
        private MyCustomButton.MyCustomButton myCustomButton37;
        private MyCustomButton.MyCustomButton myCustomButton38;
        private MyCustomButton.MyCustomButton myCustomButton1;
        private MyCustomButton.MyCustomButton myCustomButton2;
        private MyCustomButton.MyCustomButton myCustomButton39;
        private MyCustomButton.MyCustomButton myCustomButton40;
        private MyCustomButton.MyCustomButton myCustomButton41;
        private MyCustomButton.MyCustomButton myCustomButton42;
        private MyCustomButton.MyCustomButton myCustomButton43;
        private MyCustomButton.MyCustomButton myCustomButton44;
        private MyCustomButton.MyCustomButton myCustomButton45;
        private MyCustomButton.MyCustomButton myCustomButton46;
        private MyCustomButton.MyCustomButton myCustomButton47;
        private MyCustomButton.MyCustomButton myCustomButton48;
        private MyCustomButton.MyCustomButton myCustomButton49;
        private TabPage tabPage5;
        private MyCustomButton.MyCustomButton myCustomButton50;
        private Label label82;
        private Label label83;
        private Label label84;
        private Label label85;
        private Label label86;
        private Label label87;
        private Label label88;
        private Label label89;
        private Label label90;
        private Label label91;
        private Label label92;
        private Label label93;
        private Label label94;
        private Label label95;
        private Label label96;
        private Label label97;
        private Label label98;
        private Label label99;
        private Label label100;
        private Label label101;
        private Label label102;
        private Label label103;
        private Label label104;
        private Label label105;
        private Label label106;
        private Label label107;
        private Label label108;
        private Label label109;
        private Label label110;
        private Label label111;
        private Label label112;
        private Label label113;
        private Label label114;
        private Label label115;
        private Label label116;
        private Label label117;
        private Label label118;
        private Label label119;
        private Label label120;
        private Label label121;
        private Label label122;
        private Label label123;
        private Label label124;
        private Label label125;
        private Label label126;
        private Label label127;
        private Label label128;
        private Label label129;
        private Label label130;
        private Label label131;
        private Label label132;
        private Label label133;
        private Label label134;
        private Label label135;
        private Label label136;
        private Label label137;
        private Label label138;
        private Label label139;
        private Label label140;
        private Label label141;
        private Label label142;
        private Label label143;
        private Label label144;
        private Label label145;
        private Label label146;
        private Label label147;
        private Label label148;
        private Label label149;
        private Label label150;
        private Label label151;
        private Label label152;
        private Label label153;
        private Label label154;
        private Label label155;
        private Label label156;
        private Label label157;
        private Label label158;
        private Label label159;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
    }
}
