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
            this.label38 = new System.Windows.Forms.Label();
            this.btnFeinadjustment = new System.Windows.Forms.Button();
            this.btn_yOffset_send = new System.Windows.Forms.Button();
            this.btn_xOffset_send = new System.Windows.Forms.Button();
            this.lbl_mm = new System.Windows.Forms.Label();
            this.lbl_zOffset = new System.Windows.Forms.Label();
            this.btn_yOffset_plus = new System.Windows.Forms.Button();
            this.btn_zOffset_plus = new System.Windows.Forms.Button();
            this.btn_zOffset_minus = new System.Windows.Forms.Button();
            this.btn_yOffset_minus = new System.Windows.Forms.Button();
            this.btn_xOffset_minus = new System.Windows.Forms.Button();
            this.btn_xOffset_plus = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.but_M218_T1 = new System.Windows.Forms.Button();
            this.but_M218_T2 = new System.Windows.Forms.Button();
            this.but_M218_T3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.text_M218_Y = new System.Windows.Forms.TextBox();
            this.text_M218_X = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.but_G297 = new System.Windows.Forms.Button();
            this.but_G295 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_step_1 = new System.Windows.Forms.Button();
            this.but_step_10 = new System.Windows.Forms.Button();
            this.but_step_50 = new System.Windows.Forms.Button();
            this.but_Zminus = new System.Windows.Forms.Button();
            this.but_Extrude = new System.Windows.Forms.Button();
            this.but_Retract = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.but_MOVE = new System.Windows.Forms.Button();
            this.but_T3 = new System.Windows.Forms.Button();
            this.but_T2 = new System.Windows.Forms.Button();
            this.but_T1 = new System.Windows.Forms.Button();
            this.but_T0 = new System.Windows.Forms.Button();
            this.but_G222 = new System.Windows.Forms.Button();
            this.but_G224 = new System.Windows.Forms.Button();
            this.but_MotorAus = new System.Windows.Forms.Button();
            this.but_T0_OnOff = new System.Windows.Forms.Button();
            this.but_T1_OnOff = new System.Windows.Forms.Button();
            this.but_T2_OnOff = new System.Windows.Forms.Button();
            this.but_T3_OnOff = new System.Windows.Forms.Button();
            this.trackBar_NozzleTemp = new System.Windows.Forms.TrackBar();
            this.but_NozzleMinus = new System.Windows.Forms.Button();
            this.but_NozzlePlus = new System.Windows.Forms.Button();
            this.text_T0_ziel = new System.Windows.Forms.TextBox();
            this.text_T1_ziel = new System.Windows.Forms.TextBox();
            this.text_T2_ziel = new System.Windows.Forms.TextBox();
            this.text_T3_ziel = new System.Windows.Forms.TextBox();
            this.text_T0_Aktuell = new System.Windows.Forms.TextBox();
            this.text_T1_Aktuell = new System.Windows.Forms.TextBox();
            this.text_T2_Aktuell = new System.Windows.Forms.TextBox();
            this.text_T3_Aktuell = new System.Windows.Forms.TextBox();
            this.trackBar_BedTemp = new System.Windows.Forms.TrackBar();
            this.but_bed_OnOff = new System.Windows.Forms.Button();
            this.but_BedMinus = new System.Windows.Forms.Button();
            this.but_BedPlus = new System.Windows.Forms.Button();
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TouchControl = new System.Windows.Forms.TabPage();
            this.btnZPlus = new MyCustomButton.MyCustomButton();
            this.btnYPlus = new MyCustomButton.MyCustomButton();
            this.btnYMinus = new MyCustomButton.MyCustomButton();
            this.btnXPlus = new MyCustomButton.MyCustomButton();
            this.btnXMinus = new MyCustomButton.MyCustomButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
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
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.lblMoveFailure = new System.Windows.Forms.Label();
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
            this.btnAktualise = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timer_temp = new System.Windows.Forms.Timer(this.components);
            this.worker = new System.ComponentModel.BackgroundWorker();
            tabpage2 = new System.Windows.Forms.TabPage();
            tabpage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_NozzleTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BedTemp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TouchControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXMinus)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpage2
            // 
            tabpage2.BackColor = System.Drawing.SystemColors.Control;
            tabpage2.Controls.Add(this.label38);
            tabpage2.Controls.Add(this.btnFeinadjustment);
            tabpage2.Controls.Add(this.btn_yOffset_send);
            tabpage2.Controls.Add(this.btn_xOffset_send);
            tabpage2.Controls.Add(this.lbl_mm);
            tabpage2.Controls.Add(this.lbl_zOffset);
            tabpage2.Controls.Add(this.btn_yOffset_plus);
            tabpage2.Controls.Add(this.btn_zOffset_plus);
            tabpage2.Controls.Add(this.btn_zOffset_minus);
            tabpage2.Controls.Add(this.btn_yOffset_minus);
            tabpage2.Controls.Add(this.btn_xOffset_minus);
            tabpage2.Controls.Add(this.btn_xOffset_plus);
            tabpage2.Controls.Add(this.groupBox3);
            tabpage2.Controls.Add(this.label15);
            tabpage2.Controls.Add(this.label14);
            tabpage2.Controls.Add(this.text_M218_Y);
            tabpage2.Controls.Add(this.text_M218_X);
            tabpage2.Controls.Add(this.label13);
            tabpage2.Controls.Add(this.label12);
            tabpage2.Controls.Add(this.but_G297);
            tabpage2.Controls.Add(this.but_G295);
            tabpage2.Controls.Add(this.button1);
            tabpage2.Controls.Add(this.button2);
            tabpage2.Location = new System.Drawing.Point(4, 4);
            tabpage2.Margin = new System.Windows.Forms.Padding(2);
            tabpage2.Name = "tabpage2";
            tabpage2.Padding = new System.Windows.Forms.Padding(2);
            tabpage2.Size = new System.Drawing.Size(555, 499);
            tabpage2.TabIndex = 1;
            tabpage2.Text = "Kalibrierung";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Enabled = false;
            this.label38.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label38.Location = new System.Drawing.Point(4, 144);
            this.label38.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(20, 13);
            this.label38.TabIndex = 59;
            this.label38.Text = "#3";
            // 
            // btnFeinadjustment
            // 
            this.btnFeinadjustment.Enabled = false;
            this.btnFeinadjustment.Location = new System.Drawing.Point(5, 158);
            this.btnFeinadjustment.Name = "btnFeinadjustment";
            this.btnFeinadjustment.Size = new System.Drawing.Size(133, 52);
            this.btnFeinadjustment.TabIndex = 58;
            this.btnFeinadjustment.Text = "Z-Höhe Feinadjustierung";
            this.btnFeinadjustment.UseVisualStyleBackColor = true;
            this.btnFeinadjustment.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_yOffset_send
            // 
            this.btn_yOffset_send.Enabled = false;
            this.btn_yOffset_send.Location = new System.Drawing.Point(364, 147);
            this.btn_yOffset_send.Name = "btn_yOffset_send";
            this.btn_yOffset_send.Size = new System.Drawing.Size(88, 33);
            this.btn_yOffset_send.TabIndex = 57;
            this.btn_yOffset_send.Text = "Schicken";
            this.btn_yOffset_send.UseVisualStyleBackColor = true;
            this.btn_yOffset_send.Click += new System.EventHandler(this.btn_yOffset_send_Click);
            // 
            // btn_xOffset_send
            // 
            this.btn_xOffset_send.Enabled = false;
            this.btn_xOffset_send.Location = new System.Drawing.Point(364, 98);
            this.btn_xOffset_send.Name = "btn_xOffset_send";
            this.btn_xOffset_send.Size = new System.Drawing.Size(88, 33);
            this.btn_xOffset_send.TabIndex = 56;
            this.btn_xOffset_send.Text = "Schicken";
            this.btn_xOffset_send.UseVisualStyleBackColor = true;
            this.btn_xOffset_send.Click += new System.EventHandler(this.btn_xOffset_send_Click);
            // 
            // lbl_mm
            // 
            this.lbl_mm.AutoSize = true;
            this.lbl_mm.Enabled = false;
            this.lbl_mm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mm.Location = new System.Drawing.Point(49, 231);
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
            this.lbl_zOffset.Location = new System.Drawing.Point(49, 216);
            this.lbl_zOffset.Name = "lbl_zOffset";
            this.lbl_zOffset.Size = new System.Drawing.Size(32, 16);
            this.lbl_zOffset.TabIndex = 54;
            this.lbl_zOffset.Text = "0.00";
            // 
            // btn_yOffset_plus
            // 
            this.btn_yOffset_plus.Enabled = false;
            this.btn_yOffset_plus.Location = new System.Drawing.Point(311, 147);
            this.btn_yOffset_plus.Name = "btn_yOffset_plus";
            this.btn_yOffset_plus.Size = new System.Drawing.Size(37, 33);
            this.btn_yOffset_plus.TabIndex = 53;
            this.btn_yOffset_plus.Text = "+";
            this.btn_yOffset_plus.UseVisualStyleBackColor = true;
            this.btn_yOffset_plus.Click += new System.EventHandler(this.btn_yOffset_plus_Click);
            // 
            // btn_zOffset_plus
            // 
            this.btn_zOffset_plus.Enabled = false;
            this.btn_zOffset_plus.Location = new System.Drawing.Point(118, 213);
            this.btn_zOffset_plus.Name = "btn_zOffset_plus";
            this.btn_zOffset_plus.Size = new System.Drawing.Size(37, 36);
            this.btn_zOffset_plus.TabIndex = 52;
            this.btn_zOffset_plus.Text = "Z+";
            this.btn_zOffset_plus.UseVisualStyleBackColor = true;
            this.btn_zOffset_plus.Click += new System.EventHandler(this.btn_zOffset_plus_Click);
            // 
            // btn_zOffset_minus
            // 
            this.btn_zOffset_minus.Enabled = false;
            this.btn_zOffset_minus.Location = new System.Drawing.Point(7, 213);
            this.btn_zOffset_minus.Name = "btn_zOffset_minus";
            this.btn_zOffset_minus.Size = new System.Drawing.Size(37, 36);
            this.btn_zOffset_minus.TabIndex = 51;
            this.btn_zOffset_minus.Text = "Z-";
            this.btn_zOffset_minus.UseVisualStyleBackColor = true;
            this.btn_zOffset_minus.Click += new System.EventHandler(this.btn_zOffset_minus_Click);
            // 
            // btn_yOffset_minus
            // 
            this.btn_yOffset_minus.Enabled = false;
            this.btn_yOffset_minus.Location = new System.Drawing.Point(203, 147);
            this.btn_yOffset_minus.Name = "btn_yOffset_minus";
            this.btn_yOffset_minus.Size = new System.Drawing.Size(37, 33);
            this.btn_yOffset_minus.TabIndex = 50;
            this.btn_yOffset_minus.Text = "-";
            this.btn_yOffset_minus.UseVisualStyleBackColor = true;
            this.btn_yOffset_minus.Click += new System.EventHandler(this.btn_yOffset_minus_Click);
            // 
            // btn_xOffset_minus
            // 
            this.btn_xOffset_minus.Enabled = false;
            this.btn_xOffset_minus.Location = new System.Drawing.Point(204, 98);
            this.btn_xOffset_minus.Name = "btn_xOffset_minus";
            this.btn_xOffset_minus.Size = new System.Drawing.Size(36, 33);
            this.btn_xOffset_minus.TabIndex = 49;
            this.btn_xOffset_minus.Text = "-";
            this.btn_xOffset_minus.UseVisualStyleBackColor = true;
            this.btn_xOffset_minus.Click += new System.EventHandler(this.btn_xOffset_minus_Click);
            // 
            // btn_xOffset_plus
            // 
            this.btn_xOffset_plus.Enabled = false;
            this.btn_xOffset_plus.Location = new System.Drawing.Point(311, 98);
            this.btn_xOffset_plus.Name = "btn_xOffset_plus";
            this.btn_xOffset_plus.Size = new System.Drawing.Size(37, 33);
            this.btn_xOffset_plus.TabIndex = 48;
            this.btn_xOffset_plus.Text = "+";
            this.btn_xOffset_plus.UseVisualStyleBackColor = true;
            this.btn_xOffset_plus.Click += new System.EventHandler(this.btn_xOffset_plus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.but_M218_T1);
            this.groupBox3.Controls.Add(this.but_M218_T2);
            this.groupBox3.Controls.Add(this.but_M218_T3);
            this.groupBox3.Location = new System.Drawing.Point(175, 18);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(201, 65);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Werkzeug Auswahl";
            // 
            // but_M218_T1
            // 
            this.but_M218_T1.Enabled = false;
            this.but_M218_T1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_M218_T1.Location = new System.Drawing.Point(5, 18);
            this.but_M218_T1.Name = "but_M218_T1";
            this.but_M218_T1.Size = new System.Drawing.Size(60, 40);
            this.but_M218_T1.TabIndex = 42;
            this.but_M218_T1.Text = "T1";
            this.but_M218_T1.UseVisualStyleBackColor = true;
            this.but_M218_T1.Click += new System.EventHandler(this.but_M218_T1_Click);
            // 
            // but_M218_T2
            // 
            this.but_M218_T2.Enabled = false;
            this.but_M218_T2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_M218_T2.Location = new System.Drawing.Point(70, 18);
            this.but_M218_T2.Name = "but_M218_T2";
            this.but_M218_T2.Size = new System.Drawing.Size(60, 40);
            this.but_M218_T2.TabIndex = 43;
            this.but_M218_T2.Text = "T2";
            this.but_M218_T2.UseVisualStyleBackColor = true;
            this.but_M218_T2.Click += new System.EventHandler(this.but_M218_T2_Click);
            // 
            // but_M218_T3
            // 
            this.but_M218_T3.Enabled = false;
            this.but_M218_T3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_M218_T3.Location = new System.Drawing.Point(135, 18);
            this.but_M218_T3.Name = "but_M218_T3";
            this.but_M218_T3.Size = new System.Drawing.Size(60, 40);
            this.but_M218_T3.TabIndex = 44;
            this.but_M218_T3.Text = "T3";
            this.but_M218_T3.UseVisualStyleBackColor = true;
            this.but_M218_T3.Click += new System.EventHandler(this.but_M218_T3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(269, 141);
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
            this.label14.Location = new System.Drawing.Point(269, 92);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "X";
            // 
            // text_M218_Y
            // 
            this.text_M218_Y.Enabled = false;
            this.text_M218_Y.Location = new System.Drawing.Point(245, 154);
            this.text_M218_Y.Margin = new System.Windows.Forms.Padding(2);
            this.text_M218_Y.Name = "text_M218_Y";
            this.text_M218_Y.ReadOnly = true;
            this.text_M218_Y.Size = new System.Drawing.Size(61, 20);
            this.text_M218_Y.TabIndex = 41;
            // 
            // text_M218_X
            // 
            this.text_M218_X.Location = new System.Drawing.Point(245, 105);
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
            this.label13.Location = new System.Drawing.Point(4, 73);
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
            this.label12.Location = new System.Drawing.Point(4, 2);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 13);
            this.label12.TabIndex = 37;
            this.label12.Text = "#1";
            // 
            // but_G297
            // 
            this.but_G297.Enabled = false;
            this.but_G297.Location = new System.Drawing.Point(7, 18);
            this.but_G297.Name = "but_G297";
            this.but_G297.Size = new System.Drawing.Size(133, 52);
            this.but_G297.TabIndex = 14;
            this.but_G297.Text = "Position Pruefen";
            this.but_G297.UseVisualStyleBackColor = true;
            this.but_G297.Click += new System.EventHandler(this.but_G297_Click);
            // 
            // but_G295
            // 
            this.but_G295.Enabled = false;
            this.but_G295.Location = new System.Drawing.Point(7, 88);
            this.but_G295.Name = "but_G295";
            this.but_G295.Size = new System.Drawing.Size(133, 52);
            this.but_G295.TabIndex = 13;
            this.but_G295.Text = "Duesenvermessung";
            this.but_G295.UseVisualStyleBackColor = true;
            this.but_G295.Click += new System.EventHandler(this.but_G295_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(5, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "Home MOVE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.but_G222_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(5, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "Park MOVE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.but_G224_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Enabled = false;
            this.buttonHome.Location = new System.Drawing.Point(9, 157);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(60, 40);
            this.buttonHome.TabIndex = 0;
            this.buttonHome.Text = "Home";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.but_step_1);
            this.groupBox1.Controls.Add(this.but_step_10);
            this.groupBox1.Controls.Add(this.but_step_50);
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(70, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance";
            // 
            // but_step_1
            // 
            this.but_step_1.Enabled = false;
            this.but_step_1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_step_1.Location = new System.Drawing.Point(4, 104);
            this.but_step_1.Margin = new System.Windows.Forms.Padding(2);
            this.but_step_1.Name = "but_step_1";
            this.but_step_1.Size = new System.Drawing.Size(60, 40);
            this.but_step_1.TabIndex = 2;
            this.but_step_1.Text = "1 mm";
            this.but_step_1.UseVisualStyleBackColor = true;
            this.but_step_1.Click += new System.EventHandler(this.but_step_1_Click);
            // 
            // but_step_10
            // 
            this.but_step_10.Enabled = false;
            this.but_step_10.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_step_10.Location = new System.Drawing.Point(4, 60);
            this.but_step_10.Margin = new System.Windows.Forms.Padding(2);
            this.but_step_10.Name = "but_step_10";
            this.but_step_10.Size = new System.Drawing.Size(60, 40);
            this.but_step_10.TabIndex = 1;
            this.but_step_10.Text = "10 mm";
            this.but_step_10.UseVisualStyleBackColor = true;
            this.but_step_10.Click += new System.EventHandler(this.but_step_10_Click);
            // 
            // but_step_50
            // 
            this.but_step_50.Enabled = false;
            this.but_step_50.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_step_50.Location = new System.Drawing.Point(4, 16);
            this.but_step_50.Margin = new System.Windows.Forms.Padding(2);
            this.but_step_50.Name = "but_step_50";
            this.but_step_50.Size = new System.Drawing.Size(60, 40);
            this.but_step_50.TabIndex = 0;
            this.but_step_50.Text = "50 mm";
            this.but_step_50.UseVisualStyleBackColor = true;
            this.but_step_50.Click += new System.EventHandler(this.but_step_50_Click);
            // 
            // but_Zminus
            // 
            this.but_Zminus.Enabled = false;
            this.but_Zminus.Location = new System.Drawing.Point(318, 106);
            this.but_Zminus.Name = "but_Zminus";
            this.but_Zminus.Size = new System.Drawing.Size(70, 70);
            this.but_Zminus.TabIndex = 6;
            this.but_Zminus.Text = "Z-";
            this.but_Zminus.UseVisualStyleBackColor = true;
            this.but_Zminus.Click += new System.EventHandler(this.but_Zminus_Click);
            // 
            // but_Extrude
            // 
            this.but_Extrude.Enabled = false;
            this.but_Extrude.Location = new System.Drawing.Point(394, 106);
            this.but_Extrude.Name = "but_Extrude";
            this.but_Extrude.Size = new System.Drawing.Size(70, 70);
            this.but_Extrude.TabIndex = 8;
            this.but_Extrude.Text = "Extrude";
            this.but_Extrude.UseVisualStyleBackColor = true;
            this.but_Extrude.Click += new System.EventHandler(this.but_Extrude_Click);
            // 
            // but_Retract
            // 
            this.but_Retract.Enabled = false;
            this.but_Retract.Location = new System.Drawing.Point(394, 14);
            this.but_Retract.Name = "but_Retract";
            this.but_Retract.Size = new System.Drawing.Size(70, 70);
            this.but_Retract.TabIndex = 7;
            this.but_Retract.Text = "Retract";
            this.but_Retract.UseVisualStyleBackColor = true;
            this.but_Retract.Click += new System.EventHandler(this.but_Retract_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_MOVE);
            this.groupBox2.Controls.Add(this.but_T3);
            this.groupBox2.Controls.Add(this.but_T2);
            this.groupBox2.Controls.Add(this.but_T1);
            this.groupBox2.Controls.Add(this.but_T0);
            this.groupBox2.Location = new System.Drawing.Point(130, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Werkzeug Auswahl";
            // 
            // but_MOVE
            // 
            this.but_MOVE.Enabled = false;
            this.but_MOVE.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_MOVE.Location = new System.Drawing.Point(270, 19);
            this.but_MOVE.Name = "but_MOVE";
            this.but_MOVE.Size = new System.Drawing.Size(60, 40);
            this.but_MOVE.TabIndex = 4;
            this.but_MOVE.Text = "MOVE";
            this.but_MOVE.UseVisualStyleBackColor = true;
            this.but_MOVE.Click += new System.EventHandler(this.but_MOVE_Click);
            // 
            // but_T3
            // 
            this.but_T3.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_T3.Location = new System.Drawing.Point(204, 19);
            this.but_T3.Name = "but_T3";
            this.but_T3.Size = new System.Drawing.Size(60, 40);
            this.but_T3.TabIndex = 3;
            this.but_T3.Text = "T3";
            this.but_T3.UseVisualStyleBackColor = true;
            this.but_T3.Click += new System.EventHandler(this.but_T3_Click);
            // 
            // but_T2
            // 
            this.but_T2.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_T2.Location = new System.Drawing.Point(138, 19);
            this.but_T2.Name = "but_T2";
            this.but_T2.Size = new System.Drawing.Size(60, 40);
            this.but_T2.TabIndex = 2;
            this.but_T2.Text = "T2";
            this.but_T2.UseVisualStyleBackColor = true;
            this.but_T2.Click += new System.EventHandler(this.but_T2_Click);
            // 
            // but_T1
            // 
            this.but_T1.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_T1.Location = new System.Drawing.Point(72, 19);
            this.but_T1.Name = "but_T1";
            this.but_T1.Size = new System.Drawing.Size(60, 40);
            this.but_T1.TabIndex = 1;
            this.but_T1.Text = "T1";
            this.but_T1.UseVisualStyleBackColor = true;
            this.but_T1.Click += new System.EventHandler(this.but_T1_Click);
            // 
            // but_T0
            // 
            this.but_T0.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_T0.Location = new System.Drawing.Point(6, 19);
            this.but_T0.Name = "but_T0";
            this.but_T0.Size = new System.Drawing.Size(60, 40);
            this.but_T0.TabIndex = 0;
            this.but_T0.Text = "T0";
            this.but_T0.UseVisualStyleBackColor = true;
            this.but_T0.Click += new System.EventHandler(this.but_T0_Click);
            // 
            // but_G222
            // 
            this.but_G222.Enabled = false;
            this.but_G222.Location = new System.Drawing.Point(9, 249);
            this.but_G222.Name = "but_G222";
            this.but_G222.Size = new System.Drawing.Size(60, 40);
            this.but_G222.TabIndex = 5;
            this.but_G222.Text = "Home MOVE";
            this.but_G222.UseVisualStyleBackColor = true;
            this.but_G222.Click += new System.EventHandler(this.but_G222_Click);
            // 
            // but_G224
            // 
            this.but_G224.Enabled = false;
            this.but_G224.Location = new System.Drawing.Point(9, 295);
            this.but_G224.Name = "but_G224";
            this.but_G224.Size = new System.Drawing.Size(60, 40);
            this.but_G224.TabIndex = 10;
            this.but_G224.Text = "Park MOVE";
            this.but_G224.UseVisualStyleBackColor = true;
            this.but_G224.Click += new System.EventHandler(this.but_G224_Click);
            // 
            // but_MotorAus
            // 
            this.but_MotorAus.Enabled = false;
            this.but_MotorAus.Location = new System.Drawing.Point(9, 203);
            this.but_MotorAus.Name = "but_MotorAus";
            this.but_MotorAus.Size = new System.Drawing.Size(60, 40);
            this.but_MotorAus.TabIndex = 11;
            this.but_MotorAus.Text = "Motoren Aus";
            this.but_MotorAus.UseVisualStyleBackColor = true;
            this.but_MotorAus.Click += new System.EventHandler(this.but_MotorAus_Click);
            // 
            // but_T0_OnOff
            // 
            this.but_T0_OnOff.Location = new System.Drawing.Point(137, 266);
            this.but_T0_OnOff.Name = "but_T0_OnOff";
            this.but_T0_OnOff.Size = new System.Drawing.Size(60, 30);
            this.but_T0_OnOff.TabIndex = 12;
            this.but_T0_OnOff.Text = "Aus";
            this.but_T0_OnOff.UseVisualStyleBackColor = true;
            this.but_T0_OnOff.Click += new System.EventHandler(this.but_T0_OnOff_Click);
            // 
            // but_T1_OnOff
            // 
            this.but_T1_OnOff.Location = new System.Drawing.Point(201, 267);
            this.but_T1_OnOff.Name = "but_T1_OnOff";
            this.but_T1_OnOff.Size = new System.Drawing.Size(60, 30);
            this.but_T1_OnOff.TabIndex = 13;
            this.but_T1_OnOff.Text = "Aus";
            this.but_T1_OnOff.UseVisualStyleBackColor = true;
            this.but_T1_OnOff.Click += new System.EventHandler(this.but_T1_OnOff_Click);
            // 
            // but_T2_OnOff
            // 
            this.but_T2_OnOff.Location = new System.Drawing.Point(268, 267);
            this.but_T2_OnOff.Name = "but_T2_OnOff";
            this.but_T2_OnOff.Size = new System.Drawing.Size(60, 30);
            this.but_T2_OnOff.TabIndex = 14;
            this.but_T2_OnOff.Text = "Aus";
            this.but_T2_OnOff.UseVisualStyleBackColor = true;
            this.but_T2_OnOff.Click += new System.EventHandler(this.but_T2_OnOff_Click);
            // 
            // but_T3_OnOff
            // 
            this.but_T3_OnOff.Location = new System.Drawing.Point(333, 267);
            this.but_T3_OnOff.Name = "but_T3_OnOff";
            this.but_T3_OnOff.Size = new System.Drawing.Size(60, 30);
            this.but_T3_OnOff.TabIndex = 15;
            this.but_T3_OnOff.Text = "Aus";
            this.but_T3_OnOff.UseVisualStyleBackColor = true;
            this.but_T3_OnOff.Click += new System.EventHandler(this.but_T3_OnOff_Click);
            // 
            // trackBar_NozzleTemp
            // 
            this.trackBar_NozzleTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.trackBar_NozzleTemp.Location = new System.Drawing.Point(201, 344);
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
            // but_NozzleMinus
            // 
            this.but_NozzleMinus.Location = new System.Drawing.Point(137, 344);
            this.but_NozzleMinus.Name = "but_NozzleMinus";
            this.but_NozzleMinus.Size = new System.Drawing.Size(60, 45);
            this.but_NozzleMinus.TabIndex = 17;
            this.but_NozzleMinus.Text = "-5";
            this.but_NozzleMinus.UseVisualStyleBackColor = true;
            this.but_NozzleMinus.Click += new System.EventHandler(this.but_NozzleMinus_Click);
            // 
            // but_NozzlePlus
            // 
            this.but_NozzlePlus.Location = new System.Drawing.Point(400, 344);
            this.but_NozzlePlus.Name = "but_NozzlePlus";
            this.but_NozzlePlus.Size = new System.Drawing.Size(60, 45);
            this.but_NozzlePlus.TabIndex = 18;
            this.but_NozzlePlus.Text = "+5";
            this.but_NozzlePlus.UseVisualStyleBackColor = true;
            this.but_NozzlePlus.Click += new System.EventHandler(this.but_NozzlePlus_Click);
            // 
            // text_T0_ziel
            // 
            this.text_T0_ziel.Location = new System.Drawing.Point(137, 302);
            this.text_T0_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T0_ziel.Name = "text_T0_ziel";
            this.text_T0_ziel.ReadOnly = true;
            this.text_T0_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_T0_ziel.TabIndex = 19;
            this.text_T0_ziel.Text = "205";
            // 
            // text_T1_ziel
            // 
            this.text_T1_ziel.Location = new System.Drawing.Point(202, 302);
            this.text_T1_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T1_ziel.Name = "text_T1_ziel";
            this.text_T1_ziel.ReadOnly = true;
            this.text_T1_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_T1_ziel.TabIndex = 20;
            this.text_T1_ziel.Text = "205";
            // 
            // text_T2_ziel
            // 
            this.text_T2_ziel.Location = new System.Drawing.Point(268, 302);
            this.text_T2_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T2_ziel.Name = "text_T2_ziel";
            this.text_T2_ziel.ReadOnly = true;
            this.text_T2_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_T2_ziel.TabIndex = 21;
            this.text_T2_ziel.Text = "205";
            // 
            // text_T3_ziel
            // 
            this.text_T3_ziel.Location = new System.Drawing.Point(333, 302);
            this.text_T3_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_T3_ziel.Name = "text_T3_ziel";
            this.text_T3_ziel.ReadOnly = true;
            this.text_T3_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_T3_ziel.TabIndex = 22;
            this.text_T3_ziel.Text = "205";
            // 
            // text_T0_Aktuell
            // 
            this.text_T0_Aktuell.Location = new System.Drawing.Point(137, 322);
            this.text_T0_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T0_Aktuell.Name = "text_T0_Aktuell";
            this.text_T0_Aktuell.ReadOnly = true;
            this.text_T0_Aktuell.Size = new System.Drawing.Size(61, 20);
            this.text_T0_Aktuell.TabIndex = 23;
            // 
            // text_T1_Aktuell
            // 
            this.text_T1_Aktuell.Location = new System.Drawing.Point(201, 323);
            this.text_T1_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T1_Aktuell.Name = "text_T1_Aktuell";
            this.text_T1_Aktuell.ReadOnly = true;
            this.text_T1_Aktuell.Size = new System.Drawing.Size(61, 20);
            this.text_T1_Aktuell.TabIndex = 24;
            // 
            // text_T2_Aktuell
            // 
            this.text_T2_Aktuell.Location = new System.Drawing.Point(268, 322);
            this.text_T2_Aktuell.Margin = new System.Windows.Forms.Padding(2);
            this.text_T2_Aktuell.Name = "text_T2_Aktuell";
            this.text_T2_Aktuell.ReadOnly = true;
            this.text_T2_Aktuell.Size = new System.Drawing.Size(61, 20);
            this.text_T2_Aktuell.TabIndex = 25;
            // 
            // text_T3_Aktuell
            // 
            this.text_T3_Aktuell.Location = new System.Drawing.Point(333, 323);
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
            this.trackBar_BedTemp.Location = new System.Drawing.Point(201, 402);
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
            // but_bed_OnOff
            // 
            this.but_bed_OnOff.Location = new System.Drawing.Point(399, 267);
            this.but_bed_OnOff.Name = "but_bed_OnOff";
            this.but_bed_OnOff.Size = new System.Drawing.Size(60, 30);
            this.but_bed_OnOff.TabIndex = 28;
            this.but_bed_OnOff.Text = "Aus";
            this.but_bed_OnOff.UseVisualStyleBackColor = true;
            this.but_bed_OnOff.Click += new System.EventHandler(this.but_bed_OnOff_Click);
            // 
            // but_BedMinus
            // 
            this.but_BedMinus.Location = new System.Drawing.Point(137, 396);
            this.but_BedMinus.Name = "but_BedMinus";
            this.but_BedMinus.Size = new System.Drawing.Size(60, 45);
            this.but_BedMinus.TabIndex = 29;
            this.but_BedMinus.Text = "-5";
            this.but_BedMinus.UseVisualStyleBackColor = true;
            this.but_BedMinus.Click += new System.EventHandler(this.but_BedMinus_Click);
            // 
            // but_BedPlus
            // 
            this.but_BedPlus.Location = new System.Drawing.Point(400, 396);
            this.but_BedPlus.Name = "but_BedPlus";
            this.but_BedPlus.Size = new System.Drawing.Size(60, 45);
            this.but_BedPlus.TabIndex = 30;
            this.but_BedPlus.Text = "+5";
            this.but_BedPlus.UseVisualStyleBackColor = true;
            this.but_BedPlus.Click += new System.EventHandler(this.but_BedPlus_Click);
            // 
            // text_Bed_ziel
            // 
            this.text_Bed_ziel.Location = new System.Drawing.Point(400, 302);
            this.text_Bed_ziel.Margin = new System.Windows.Forms.Padding(2);
            this.text_Bed_ziel.Name = "text_Bed_ziel";
            this.text_Bed_ziel.ReadOnly = true;
            this.text_Bed_ziel.Size = new System.Drawing.Size(61, 20);
            this.text_Bed_ziel.TabIndex = 31;
            this.text_Bed_ziel.Text = "60";
            // 
            // text_Bed_Aktuell
            // 
            this.text_Bed_Aktuell.Location = new System.Drawing.Point(400, 322);
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
            this.label1.Location = new System.Drawing.Point(99, 304);
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
            this.label2.Location = new System.Drawing.Point(84, 322);
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
            this.label3.Location = new System.Drawing.Point(84, 350);
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
            this.label4.Location = new System.Drawing.Point(61, 363);
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
            this.label5.Location = new System.Drawing.Point(62, 415);
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
            this.label6.Location = new System.Drawing.Point(76, 402);
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
            this.label7.Location = new System.Drawing.Point(155, 252);
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
            this.label8.Location = new System.Drawing.Point(220, 253);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 43;
            this.label8.Text = "T1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(290, 253);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "T2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label10.Location = new System.Drawing.Point(353, 253);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "T3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(402, 252);
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
            this.tabControl1.ItemSize = new System.Drawing.Size(185, 50);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 3);
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(563, 557);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 47;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // TouchControl
            // 
            this.TouchControl.BackColor = System.Drawing.SystemColors.Control;
            this.TouchControl.Controls.Add(this.btnZPlus);
            this.TouchControl.Controls.Add(this.btnYPlus);
            this.TouchControl.Controls.Add(this.btnYMinus);
            this.TouchControl.Controls.Add(this.btnXPlus);
            this.TouchControl.Controls.Add(this.groupBox1);
            this.TouchControl.Controls.Add(this.label11);
            this.TouchControl.Controls.Add(this.label10);
            this.TouchControl.Controls.Add(this.buttonHome);
            this.TouchControl.Controls.Add(this.label9);
            this.TouchControl.Controls.Add(this.label8);
            this.TouchControl.Controls.Add(this.label7);
            this.TouchControl.Controls.Add(this.label5);
            this.TouchControl.Controls.Add(this.label6);
            this.TouchControl.Controls.Add(this.but_Zminus);
            this.TouchControl.Controls.Add(this.label4);
            this.TouchControl.Controls.Add(this.but_Retract);
            this.TouchControl.Controls.Add(this.label3);
            this.TouchControl.Controls.Add(this.but_Extrude);
            this.TouchControl.Controls.Add(this.label2);
            this.TouchControl.Controls.Add(this.groupBox2);
            this.TouchControl.Controls.Add(this.label1);
            this.TouchControl.Controls.Add(this.but_G222);
            this.TouchControl.Controls.Add(this.text_Bed_Aktuell);
            this.TouchControl.Controls.Add(this.but_G224);
            this.TouchControl.Controls.Add(this.text_Bed_ziel);
            this.TouchControl.Controls.Add(this.but_MotorAus);
            this.TouchControl.Controls.Add(this.but_BedPlus);
            this.TouchControl.Controls.Add(this.but_T0_OnOff);
            this.TouchControl.Controls.Add(this.but_BedMinus);
            this.TouchControl.Controls.Add(this.but_T1_OnOff);
            this.TouchControl.Controls.Add(this.but_bed_OnOff);
            this.TouchControl.Controls.Add(this.but_T2_OnOff);
            this.TouchControl.Controls.Add(this.trackBar_BedTemp);
            this.TouchControl.Controls.Add(this.but_T3_OnOff);
            this.TouchControl.Controls.Add(this.text_T3_Aktuell);
            this.TouchControl.Controls.Add(this.trackBar_NozzleTemp);
            this.TouchControl.Controls.Add(this.text_T2_Aktuell);
            this.TouchControl.Controls.Add(this.but_NozzleMinus);
            this.TouchControl.Controls.Add(this.text_T1_Aktuell);
            this.TouchControl.Controls.Add(this.but_NozzlePlus);
            this.TouchControl.Controls.Add(this.text_T0_Aktuell);
            this.TouchControl.Controls.Add(this.text_T0_ziel);
            this.TouchControl.Controls.Add(this.text_T3_ziel);
            this.TouchControl.Controls.Add(this.text_T1_ziel);
            this.TouchControl.Controls.Add(this.text_T2_ziel);
            this.TouchControl.Controls.Add(this.btnXMinus);
            this.TouchControl.Location = new System.Drawing.Point(4, 4);
            this.TouchControl.Name = "TouchControl";
            this.TouchControl.Padding = new System.Windows.Forms.Padding(3);
            this.TouchControl.Size = new System.Drawing.Size(555, 499);
            this.TouchControl.TabIndex = 0;
            this.TouchControl.Text = "Touch Controls";
            // 
            // btnZPlus
            // 
            this.btnZPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnZPlus.Image = global::MultecPlugin.Properties.Resources.zPlus;
            this.btnZPlus.ImageClicked = global::MultecPlugin.Properties.Resources.zplus_p;
            this.btnZPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.zPlus;
            this.btnZPlus.Location = new System.Drawing.Point(318, 14);
            this.btnZPlus.Name = "btnZPlus";
            this.btnZPlus.Size = new System.Drawing.Size(70, 70);
            this.btnZPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnZPlus.TabIndex = 51;
            this.btnZPlus.TabStop = false;
            this.btnZPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton1_MouseClick_1);
            // 
            // btnYPlus
            // 
            this.btnYPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnYPlus.Enabled = false;
            this.btnYPlus.Image = global::MultecPlugin.Properties.Resources.up_normal;
            this.btnYPlus.ImageClicked = global::MultecPlugin.Properties.Resources.up_pressed;
            this.btnYPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.up_normal;
            this.btnYPlus.Location = new System.Drawing.Point(134, 14);
            this.btnYPlus.Name = "btnYPlus";
            this.btnYPlus.Size = new System.Drawing.Size(85, 50);
            this.btnYPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYPlus.TabIndex = 48;
            this.btnYPlus.TabStop = false;
            this.btnYPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton2_Click);
            // 
            // btnYMinus
            // 
            this.btnYMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnYMinus.Enabled = false;
            this.btnYMinus.Image = global::MultecPlugin.Properties.Resources.bottom_normal;
            this.btnYMinus.ImageClicked = global::MultecPlugin.Properties.Resources.bottom_pressed;
            this.btnYMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.bottom_normal;
            this.btnYMinus.Location = new System.Drawing.Point(135, 134);
            this.btnYMinus.Name = "btnYMinus";
            this.btnYMinus.Size = new System.Drawing.Size(83, 47);
            this.btnYMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnYMinus.TabIndex = 50;
            this.btnYMinus.TabStop = false;
            this.btnYMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton4_Click);
            // 
            // btnXPlus
            // 
            this.btnXPlus.BackColor = System.Drawing.Color.Transparent;
            this.btnXPlus.Enabled = false;
            this.btnXPlus.Image = global::MultecPlugin.Properties.Resources.right_normal;
            this.btnXPlus.ImageClicked = global::MultecPlugin.Properties.Resources.right_pressed;
            this.btnXPlus.ImangeNormal = global::MultecPlugin.Properties.Resources.right_normal;
            this.btnXPlus.Location = new System.Drawing.Point(202, 62);
            this.btnXPlus.Name = "btnXPlus";
            this.btnXPlus.Size = new System.Drawing.Size(73, 73);
            this.btnXPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXPlus.TabIndex = 49;
            this.btnXPlus.TabStop = false;
            this.btnXPlus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton3_Click);
            // 
            // btnXMinus
            // 
            this.btnXMinus.BackColor = System.Drawing.Color.Transparent;
            this.btnXMinus.Enabled = false;
            this.btnXMinus.Image = global::MultecPlugin.Properties.Resources.left_normal;
            this.btnXMinus.ImageClicked = global::MultecPlugin.Properties.Resources.left_pressed;
            this.btnXMinus.ImangeNormal = global::MultecPlugin.Properties.Resources.left_normal;
            this.btnXMinus.Location = new System.Drawing.Point(79, 61);
            this.btnXMinus.Name = "btnXMinus";
            this.btnXMinus.Size = new System.Drawing.Size(65, 74);
            this.btnXMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnXMinus.TabIndex = 47;
            this.btnXMinus.TabStop = false;
            this.btnXMinus.Click += new System.EventHandler(this.myCustomButton1_Click);
            this.btnXMinus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myCustomButton1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
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
            this.tabPage1.Controls.Add(this.label59);
            this.tabPage1.Controls.Add(this.label60);
            this.tabPage1.Controls.Add(this.label61);
            this.tabPage1.Controls.Add(this.label62);
            this.tabPage1.Controls.Add(this.lblMoveFailure);
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
            this.tabPage1.Controls.Add(this.btnAktualise);
            this.tabPage1.Controls.Add(this.label37);
            this.tabPage1.Controls.Add(this.label36);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label28);
            this.tabPage1.Controls.Add(this.label27);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.label23);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(555, 499);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Information";
            // 
            // lblKgSrvcT3
            // 
            this.lblKgSrvcT3.AutoSize = true;
            this.lblKgSrvcT3.BackColor = System.Drawing.SystemColors.Control;
            this.lblKgSrvcT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKgSrvcT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblKgSrvcT3.Location = new System.Drawing.Point(379, 336);
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
            this.lblKgSrvcT2.Location = new System.Drawing.Point(379, 321);
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
            this.lblKgSrvcT1.Location = new System.Drawing.Point(379, 306);
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
            this.lblKgSrvcT0.Location = new System.Drawing.Point(379, 291);
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
            this.lblHeatedSrvcT3.Location = new System.Drawing.Point(379, 400);
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
            this.lblHeatedSrvcT2.Location = new System.Drawing.Point(379, 385);
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
            this.lblHeatedSrvcT1.Location = new System.Drawing.Point(379, 370);
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
            this.lblHeatedSrvcT0.Location = new System.Drawing.Point(379, 355);
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
            this.lblExtrudedSrvcT3.Location = new System.Drawing.Point(379, 276);
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
            this.lblExtrudedSrvcT2.Location = new System.Drawing.Point(379, 261);
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
            this.lblExtrudedSrvcT1.Location = new System.Drawing.Point(379, 246);
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
            this.lblExtrudedSrvcT0.Location = new System.Drawing.Point(379, 231);
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
            this.lblSrvcDistanceZ.Location = new System.Drawing.Point(379, 210);
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
            this.lblSrvcDistanceY.Location = new System.Drawing.Point(379, 196);
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
            this.lblSrvcDistanceX.Location = new System.Drawing.Point(379, 181);
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
            this.lblSrvcPrntLife.Location = new System.Drawing.Point(379, 159);
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
            this.lblSrvcPwrON.Location = new System.Drawing.Point(379, 144);
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
            this.lblSrvcPwrCycle.Location = new System.Drawing.Point(379, 129);
            this.lblSrvcPwrCycle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSrvcPwrCycle.Name = "lblSrvcPwrCycle";
            this.lblSrvcPwrCycle.Size = new System.Drawing.Size(31, 13);
            this.lblSrvcPwrCycle.TabIndex = 91;
            this.lblSrvcPwrCycle.Text = "NULL";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label70.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.Maroon;
            this.label70.Location = new System.Drawing.Point(338, 114);
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
            this.lblKgTotalT3.Location = new System.Drawing.Point(182, 336);
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
            this.lblKgTotalT2.Location = new System.Drawing.Point(182, 321);
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
            this.lblKgTotalT1.Location = new System.Drawing.Point(182, 306);
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
            this.lblKgTotalT0.Location = new System.Drawing.Point(182, 291);
            this.lblKgTotalT0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKgTotalT0.Name = "lblKgTotalT0";
            this.lblKgTotalT0.Size = new System.Drawing.Size(31, 13);
            this.lblKgTotalT0.TabIndex = 86;
            this.lblKgTotalT0.Text = "NULL";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label59.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label59.Location = new System.Drawing.Point(9, 336);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(157, 13);
            this.label59.TabIndex = 85;
            this.label59.Text = "T3 Extruded Filament (kg)";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label60.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label60.Location = new System.Drawing.Point(9, 321);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(157, 13);
            this.label60.TabIndex = 84;
            this.label60.Text = "T2 Extruded Filament (kg)";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label61.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label61.Location = new System.Drawing.Point(9, 306);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(157, 13);
            this.label61.TabIndex = 83;
            this.label61.Text = "T1 Extruded Filament (kg)";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label62.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label62.Location = new System.Drawing.Point(9, 291);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(157, 13);
            this.label62.TabIndex = 82;
            this.label62.Text = "T0 Extruded Filament (kg)";
            // 
            // lblMoveFailure
            // 
            this.lblMoveFailure.AutoSize = true;
            this.lblMoveFailure.BackColor = System.Drawing.SystemColors.Control;
            this.lblMoveFailure.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveFailure.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblMoveFailure.Location = new System.Drawing.Point(182, 422);
            this.lblMoveFailure.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMoveFailure.Name = "lblMoveFailure";
            this.lblMoveFailure.Size = new System.Drawing.Size(31, 13);
            this.lblMoveFailure.TabIndex = 81;
            this.lblMoveFailure.Text = "NULL";
            // 
            // lblHeatedTotalT3
            // 
            this.lblHeatedTotalT3.AutoSize = true;
            this.lblHeatedTotalT3.BackColor = System.Drawing.SystemColors.Control;
            this.lblHeatedTotalT3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeatedTotalT3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblHeatedTotalT3.Location = new System.Drawing.Point(182, 400);
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
            this.lblHeatedTotalT2.Location = new System.Drawing.Point(182, 385);
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
            this.lblHeatedTotalT1.Location = new System.Drawing.Point(182, 370);
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
            this.lblHeatedTotalT0.Location = new System.Drawing.Point(182, 355);
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
            this.lblExtrudedTotalT3.Location = new System.Drawing.Point(182, 276);
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
            this.lblExtrudedTotalT2.Location = new System.Drawing.Point(182, 261);
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
            this.lblExtrudedTotalT1.Location = new System.Drawing.Point(182, 246);
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
            this.lblExtrudedTotalT0.Location = new System.Drawing.Point(182, 231);
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
            this.lblTotalDistanceZ.Location = new System.Drawing.Point(182, 210);
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
            this.lblTotalDistanceY.Location = new System.Drawing.Point(182, 196);
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
            this.lblTotalDistanceX.Location = new System.Drawing.Point(182, 181);
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
            this.lblTotalPrntLife.Location = new System.Drawing.Point(182, 159);
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
            this.lblTotalPwrON.Location = new System.Drawing.Point(182, 144);
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
            this.lblTotalPwrCycle.Location = new System.Drawing.Point(182, 129);
            this.lblTotalPwrCycle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPwrCycle.Name = "lblTotalPwrCycle";
            this.lblTotalPwrCycle.Size = new System.Drawing.Size(31, 13);
            this.lblTotalPwrCycle.TabIndex = 67;
            this.lblTotalPwrCycle.Text = "NULL";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label54.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.Maroon;
            this.label54.Location = new System.Drawing.Point(170, 114);
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
            this.lblAbstandT3.Location = new System.Drawing.Point(58, 91);
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
            this.lblAbstandT2.Location = new System.Drawing.Point(58, 76);
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
            this.lblAbstandT1.Location = new System.Drawing.Point(58, 61);
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
            this.lblAbstandT0.Location = new System.Drawing.Point(58, 46);
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
            this.lblFirmware.Location = new System.Drawing.Point(182, 12);
            this.lblFirmware.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirmware.Name = "lblFirmware";
            this.lblFirmware.Size = new System.Drawing.Size(31, 13);
            this.lblFirmware.TabIndex = 60;
            this.lblFirmware.Text = "Null";
            // 
            // btnAktualise
            // 
            this.btnAktualise.Location = new System.Drawing.Point(28, 448);
            this.btnAktualise.Name = "btnAktualise";
            this.btnAktualise.Size = new System.Drawing.Size(107, 36);
            this.btnAktualise.TabIndex = 59;
            this.btnAktualise.Text = "Aktualise";
            this.btnAktualise.UseVisualStyleBackColor = true;
            this.btnAktualise.Click += new System.EventHandler(this.btnAktualise_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label37.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label37.Location = new System.Drawing.Point(9, 422);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(139, 13);
            this.label37.TabIndex = 58;
            this.label37.Text = "MOVE Rotation Failures";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label36.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label36.Location = new System.Drawing.Point(9, 400);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(91, 13);
            this.label36.TabIndex = 57;
            this.label36.Text = "T3 Heated Time";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label35.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label35.Location = new System.Drawing.Point(9, 385);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(91, 13);
            this.label35.TabIndex = 56;
            this.label35.Text = "T2 Heated Time";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label34.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label34.Location = new System.Drawing.Point(9, 370);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(91, 13);
            this.label34.TabIndex = 55;
            this.label34.Text = "T1 Heated Time";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label33.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label33.Location = new System.Drawing.Point(9, 355);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(91, 13);
            this.label33.TabIndex = 54;
            this.label33.Text = "T0 Heated Time";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label32.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label32.Location = new System.Drawing.Point(9, 276);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(151, 13);
            this.label32.TabIndex = 53;
            this.label32.Text = "T3 Extruded Filament (m)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label31.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label31.Location = new System.Drawing.Point(9, 261);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(151, 13);
            this.label31.TabIndex = 52;
            this.label31.Text = "T2 Extruded Filament (m)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label30.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label30.Location = new System.Drawing.Point(9, 246);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(151, 13);
            this.label30.TabIndex = 51;
            this.label30.Text = "T1 Extruded Filament (m)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label29.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label29.Location = new System.Drawing.Point(9, 231);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(151, 13);
            this.label29.TabIndex = 50;
            this.label29.Text = "T0 Extruded Filament (m)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label28.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label28.Location = new System.Drawing.Point(9, 210);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(133, 13);
            this.label28.TabIndex = 49;
            this.label28.Text = "Z Travel distance (m)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label27.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label27.Location = new System.Drawing.Point(9, 196);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(133, 13);
            this.label27.TabIndex = 48;
            this.label27.Text = "Y Travel distance (m)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label26.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label26.Location = new System.Drawing.Point(9, 181);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(133, 13);
            this.label26.TabIndex = 47;
            this.label26.Text = "X Travel distance (m)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label25.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label25.Location = new System.Drawing.Point(33, 159);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(67, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "Print Life";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label24.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label24.Location = new System.Drawing.Point(33, 144);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 45;
            this.label24.Text = "Power On Time";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label23.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label23.Location = new System.Drawing.Point(33, 129);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 13);
            this.label23.TabIndex = 44;
            this.label23.Text = "Power Cycles";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label22.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label22.Location = new System.Drawing.Point(9, 114);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Lifetime Statistics";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label21.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label21.Location = new System.Drawing.Point(33, 91);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 42;
            this.label21.Text = "T3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label20.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label20.Location = new System.Drawing.Point(33, 76);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(19, 13);
            this.label20.TabIndex = 41;
            this.label20.Text = "T2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label19.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label19.Location = new System.Drawing.Point(33, 61);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(19, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "T1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label18.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label18.Location = new System.Drawing.Point(33, 46);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 39;
            this.label18.Text = "T0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label17.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label17.Location = new System.Drawing.Point(9, 31);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Duese Abstand";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(9, 12);
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
            // MultecTouchpanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Name = "MultecTouchpanel";
            this.Size = new System.Drawing.Size(562, 554);
            tabpage2.ResumeLayout(false);
            tabpage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_NozzleTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BedTemp)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TouchControl.ResumeLayout(false);
            this.TouchControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXMinus)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        private MouseEventHandler myCustomButton1_Click()
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_step_1;
        private System.Windows.Forms.Button but_step_10;
        private System.Windows.Forms.Button but_step_50;
        private System.Windows.Forms.Button but_Zminus;
        private System.Windows.Forms.Button but_Extrude;
        private System.Windows.Forms.Button but_Retract;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button but_T0;
        private System.Windows.Forms.Button but_T1;
        private System.Windows.Forms.Button but_T2;
        private System.Windows.Forms.Button but_T3;
        private System.Windows.Forms.Button but_MOVE;
        private System.Windows.Forms.Button but_G222;
        private System.Windows.Forms.Button but_G224;
        private System.Windows.Forms.Button but_MotorAus;
        private System.Windows.Forms.Button but_T0_OnOff;
        private System.Windows.Forms.Button but_T1_OnOff;
        private System.Windows.Forms.Button but_T2_OnOff;
        private System.Windows.Forms.Button but_T3_OnOff;
        private System.Windows.Forms.TrackBar trackBar_NozzleTemp;
        private System.Windows.Forms.Button but_NozzleMinus;
        private System.Windows.Forms.Button but_NozzlePlus;
        private System.Windows.Forms.TextBox text_T0_ziel;
        private System.Windows.Forms.TextBox text_T1_ziel;
        private System.Windows.Forms.TextBox text_T2_ziel;
        private System.Windows.Forms.TextBox text_T3_ziel;
        private System.Windows.Forms.TextBox text_T0_Aktuell;
        private System.Windows.Forms.TextBox text_T1_Aktuell;
        private System.Windows.Forms.TextBox text_T2_Aktuell;
        private System.Windows.Forms.TextBox text_T3_Aktuell;
        private System.Windows.Forms.TrackBar trackBar_BedTemp;
        private System.Windows.Forms.Button but_bed_OnOff;
        private System.Windows.Forms.Button but_BedMinus;
        private System.Windows.Forms.Button but_BedPlus;
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TouchControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button but_G297;
        private System.Windows.Forms.Button but_G295;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button but_M218_T3;
        private System.Windows.Forms.Button but_M218_T2;
        private System.Windows.Forms.Button but_M218_T1;
        private System.Windows.Forms.TextBox text_M218_Y;
        private System.Windows.Forms.TextBox text_M218_X;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Timer timer_temp;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Label lbl_mm;
        private System.Windows.Forms.Label lbl_zOffset;
        private System.Windows.Forms.Button btn_yOffset_plus;
        private System.Windows.Forms.Button btn_zOffset_plus;
        private System.Windows.Forms.Button btn_zOffset_minus;
        private System.Windows.Forms.Button btn_yOffset_minus;
        private System.Windows.Forms.Button btn_xOffset_minus;
        private System.Windows.Forms.Button btn_xOffset_plus;
        private System.Windows.Forms.Button btn_yOffset_send;
        private System.Windows.Forms.Button btn_xOffset_send;
        private MyCustomButton.MyCustomButton btnXMinus;
        private MyCustomButton.MyCustomButton btnYMinus;
        private MyCustomButton.MyCustomButton btnXPlus;
        private MyCustomButton.MyCustomButton btnYPlus;
        private Button btnAktualise;
        private Button btnFeinadjustment;
        private Label label38;
        private Label lblMoveFailure;
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
        private Label label59;
        private Label label60;
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
    }
}
