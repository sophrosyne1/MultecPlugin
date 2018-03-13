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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
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
            this.btnZPlus = new MyCustomButton.MyCustomButton();
            this.btnYPlus = new MyCustomButton.MyCustomButton();
            this.btnYMinus = new MyCustomButton.MyCustomButton();
            this.btnXPlus = new MyCustomButton.MyCustomButton();
            this.btnXMinus = new MyCustomButton.MyCustomButton();
            tabpage2 = new System.Windows.Forms.TabPage();
            tabpage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_NozzleTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_BedTemp)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TouchControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXMinus)).BeginInit();
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
            tabpage2.Size = new System.Drawing.Size(554, 499);
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
            this.text_T0_Aktuell.TextChanged += new System.EventHandler(this.text_T0_Aktuell_TextChanged);
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
            this.tabControl1.Size = new System.Drawing.Size(562, 557);
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
            this.TouchControl.Size = new System.Drawing.Size(554, 499);
            this.TouchControl.TabIndex = 0;
            this.TouchControl.Text = "Touch Controls";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.label67);
            this.tabPage1.Controls.Add(this.label68);
            this.tabPage1.Controls.Add(this.label69);
            this.tabPage1.Controls.Add(this.label70);
            this.tabPage1.Controls.Add(this.label63);
            this.tabPage1.Controls.Add(this.label64);
            this.tabPage1.Controls.Add(this.label65);
            this.tabPage1.Controls.Add(this.label66);
            this.tabPage1.Controls.Add(this.label59);
            this.tabPage1.Controls.Add(this.label60);
            this.tabPage1.Controls.Add(this.label61);
            this.tabPage1.Controls.Add(this.label62);
            this.tabPage1.Controls.Add(this.label39);
            this.tabPage1.Controls.Add(this.label40);
            this.tabPage1.Controls.Add(this.label41);
            this.tabPage1.Controls.Add(this.label42);
            this.tabPage1.Controls.Add(this.label43);
            this.tabPage1.Controls.Add(this.label44);
            this.tabPage1.Controls.Add(this.label45);
            this.tabPage1.Controls.Add(this.label46);
            this.tabPage1.Controls.Add(this.label47);
            this.tabPage1.Controls.Add(this.label48);
            this.tabPage1.Controls.Add(this.label49);
            this.tabPage1.Controls.Add(this.label50);
            this.tabPage1.Controls.Add(this.label51);
            this.tabPage1.Controls.Add(this.label52);
            this.tabPage1.Controls.Add(this.label53);
            this.tabPage1.Controls.Add(this.label54);
            this.tabPage1.Controls.Add(this.label55);
            this.tabPage1.Controls.Add(this.label56);
            this.tabPage1.Controls.Add(this.label57);
            this.tabPage1.Controls.Add(this.label58);
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
            this.tabPage1.Size = new System.Drawing.Size(554, 499);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Information";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.SystemColors.Control;
            this.label67.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label67.Location = new System.Drawing.Point(383, 162);
            this.label67.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(133, 15);
            this.label67.TabIndex = 93;
            this.label67.Text = "Print Life Minutes";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.SystemColors.Control;
            this.label68.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label68.Location = new System.Drawing.Point(383, 147);
            this.label68.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(98, 15);
            this.label68.TabIndex = 92;
            this.label68.Text = "Power On Time";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.SystemColors.Control;
            this.label69.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label69.Location = new System.Drawing.Point(383, 132);
            this.label69.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(91, 15);
            this.label69.TabIndex = 91;
            this.label69.Text = "Power Cycles";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.BackColor = System.Drawing.SystemColors.Control;
            this.label70.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label70.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label70.Location = new System.Drawing.Point(383, 117);
            this.label70.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(77, 15);
            this.label70.TabIndex = 90;
            this.label70.Text = "Lifetime (";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.SystemColors.Control;
            this.label63.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label63.Location = new System.Drawing.Point(206, 339);
            this.label63.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(182, 15);
            this.label63.TabIndex = 89;
            this.label63.Text = "T3 Extruded Filament (cm)";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.SystemColors.Control;
            this.label64.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label64.Location = new System.Drawing.Point(206, 324);
            this.label64.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(182, 15);
            this.label64.TabIndex = 88;
            this.label64.Text = "T2 Extruded Filament (cm)";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.SystemColors.Control;
            this.label65.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label65.Location = new System.Drawing.Point(206, 309);
            this.label65.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(182, 15);
            this.label65.TabIndex = 87;
            this.label65.Text = "T1 Extruded Filament (cm)";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.SystemColors.Control;
            this.label66.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label66.Location = new System.Drawing.Point(206, 294);
            this.label66.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(182, 15);
            this.label66.TabIndex = 86;
            this.label66.Text = "T0 Extruded Filament (cm)";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label59.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label59.Location = new System.Drawing.Point(20, 339);
            this.label59.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(182, 15);
            this.label59.TabIndex = 85;
            this.label59.Text = "T3 Extruded Filament (kg)";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label60.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label60.Location = new System.Drawing.Point(20, 324);
            this.label60.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(182, 15);
            this.label60.TabIndex = 84;
            this.label60.Text = "T2 Extruded Filament (kg)";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label61.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label61.Location = new System.Drawing.Point(20, 309);
            this.label61.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(182, 15);
            this.label61.TabIndex = 83;
            this.label61.Text = "T1 Extruded Filament (kg)";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label62.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label62.Location = new System.Drawing.Point(20, 294);
            this.label62.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(182, 15);
            this.label62.TabIndex = 82;
            this.label62.Text = "T0 Extruded Filament (kg)";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.SystemColors.Control;
            this.label39.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label39.Location = new System.Drawing.Point(206, 425);
            this.label39.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(161, 15);
            this.label39.TabIndex = 81;
            this.label39.Text = "MOVE Rotation Failures";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.SystemColors.Control;
            this.label40.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label40.Location = new System.Drawing.Point(206, 403);
            this.label40.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(105, 15);
            this.label40.TabIndex = 80;
            this.label40.Text = "T3 Heated Time";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.SystemColors.Control;
            this.label41.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label41.Location = new System.Drawing.Point(206, 388);
            this.label41.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(105, 15);
            this.label41.TabIndex = 79;
            this.label41.Text = "T2 Heated Time";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.SystemColors.Control;
            this.label42.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label42.Location = new System.Drawing.Point(206, 373);
            this.label42.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(105, 15);
            this.label42.TabIndex = 78;
            this.label42.Text = "T1 Heated Time";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.SystemColors.Control;
            this.label43.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label43.Location = new System.Drawing.Point(206, 358);
            this.label43.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(105, 15);
            this.label43.TabIndex = 77;
            this.label43.Text = "T0 Heated Time";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.SystemColors.Control;
            this.label44.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label44.Location = new System.Drawing.Point(206, 279);
            this.label44.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(182, 15);
            this.label44.TabIndex = 76;
            this.label44.Text = "T3 Extruded Filament (cm)";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.SystemColors.Control;
            this.label45.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label45.Location = new System.Drawing.Point(206, 264);
            this.label45.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(182, 15);
            this.label45.TabIndex = 75;
            this.label45.Text = "T2 Extruded Filament (cm)";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.SystemColors.Control;
            this.label46.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label46.Location = new System.Drawing.Point(206, 249);
            this.label46.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(182, 15);
            this.label46.TabIndex = 74;
            this.label46.Text = "T1 Extruded Filament (cm)";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.SystemColors.Control;
            this.label47.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label47.Location = new System.Drawing.Point(206, 234);
            this.label47.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(182, 15);
            this.label47.TabIndex = 73;
            this.label47.Text = "T0 Extruded Filament (cm)";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.SystemColors.Control;
            this.label48.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label48.Location = new System.Drawing.Point(206, 213);
            this.label48.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(161, 15);
            this.label48.TabIndex = 72;
            this.label48.Text = "Z Travel distance (cm)";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.SystemColors.Control;
            this.label49.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label49.Location = new System.Drawing.Point(206, 199);
            this.label49.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(161, 15);
            this.label49.TabIndex = 71;
            this.label49.Text = "Y Travel distance (cm)";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.SystemColors.Control;
            this.label50.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label50.Location = new System.Drawing.Point(206, 184);
            this.label50.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(161, 15);
            this.label50.TabIndex = 70;
            this.label50.Text = "X Travel distance (cm)";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.SystemColors.Control;
            this.label51.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label51.Location = new System.Drawing.Point(206, 162);
            this.label51.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(133, 15);
            this.label51.TabIndex = 69;
            this.label51.Text = "Print Life Minutes";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.SystemColors.Control;
            this.label52.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label52.Location = new System.Drawing.Point(206, 147);
            this.label52.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(98, 15);
            this.label52.TabIndex = 68;
            this.label52.Text = "Power On Time";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.SystemColors.Control;
            this.label53.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label53.Location = new System.Drawing.Point(206, 132);
            this.label53.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(91, 15);
            this.label53.TabIndex = 67;
            this.label53.Text = "Power Cycles";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.SystemColors.Control;
            this.label54.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label54.Location = new System.Drawing.Point(206, 117);
            this.label54.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(119, 15);
            this.label54.TabIndex = 66;
            this.label54.Text = "Lifetime (TOTAL)";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.SystemColors.Control;
            this.label55.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label55.Location = new System.Drawing.Point(69, 94);
            this.label55.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(21, 15);
            this.label55.TabIndex = 65;
            this.label55.Text = "T3";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.SystemColors.Control;
            this.label56.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label56.Location = new System.Drawing.Point(69, 79);
            this.label56.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(21, 15);
            this.label56.TabIndex = 64;
            this.label56.Text = "T2";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.SystemColors.Control;
            this.label57.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label57.Location = new System.Drawing.Point(69, 64);
            this.label57.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(21, 15);
            this.label57.TabIndex = 63;
            this.label57.Text = "T1";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.SystemColors.Control;
            this.label58.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label58.Location = new System.Drawing.Point(69, 49);
            this.label58.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(21, 15);
            this.label58.TabIndex = 62;
            this.label58.Text = "T0";
            // 
            // lblFirmware
            // 
            this.lblFirmware.AutoSize = true;
            this.lblFirmware.BackColor = System.Drawing.SystemColors.Control;
            this.lblFirmware.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirmware.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblFirmware.Location = new System.Drawing.Point(206, 15);
            this.lblFirmware.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirmware.Name = "lblFirmware";
            this.lblFirmware.Size = new System.Drawing.Size(119, 15);
            this.lblFirmware.TabIndex = 60;
            this.lblFirmware.Text = "Firmware Version";
            // 
            // btnAktualise
            // 
            this.btnAktualise.Location = new System.Drawing.Point(28, 448);
            this.btnAktualise.Name = "btnAktualise";
            this.btnAktualise.Size = new System.Drawing.Size(107, 36);
            this.btnAktualise.TabIndex = 59;
            this.btnAktualise.Text = "Aktualise";
            this.btnAktualise.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label37.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label37.Location = new System.Drawing.Point(20, 425);
            this.label37.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(161, 15);
            this.label37.TabIndex = 58;
            this.label37.Text = "MOVE Rotation Failures";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label36.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label36.Location = new System.Drawing.Point(20, 403);
            this.label36.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(105, 15);
            this.label36.TabIndex = 57;
            this.label36.Text = "T3 Heated Time";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label35.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label35.Location = new System.Drawing.Point(20, 388);
            this.label35.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(105, 15);
            this.label35.TabIndex = 56;
            this.label35.Text = "T2 Heated Time";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label34.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label34.Location = new System.Drawing.Point(20, 373);
            this.label34.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(105, 15);
            this.label34.TabIndex = 55;
            this.label34.Text = "T1 Heated Time";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label33.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label33.Location = new System.Drawing.Point(20, 358);
            this.label33.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(105, 15);
            this.label33.TabIndex = 54;
            this.label33.Text = "T0 Heated Time";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label32.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label32.Location = new System.Drawing.Point(20, 279);
            this.label32.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(182, 15);
            this.label32.TabIndex = 53;
            this.label32.Text = "T3 Extruded Filament (cm)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label31.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label31.Location = new System.Drawing.Point(20, 264);
            this.label31.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(182, 15);
            this.label31.TabIndex = 52;
            this.label31.Text = "T2 Extruded Filament (cm)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label30.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label30.Location = new System.Drawing.Point(20, 249);
            this.label30.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(182, 15);
            this.label30.TabIndex = 51;
            this.label30.Text = "T1 Extruded Filament (cm)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label29.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label29.Location = new System.Drawing.Point(20, 234);
            this.label29.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(182, 15);
            this.label29.TabIndex = 50;
            this.label29.Text = "T0 Extruded Filament (cm)";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label28.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label28.Location = new System.Drawing.Point(20, 213);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(161, 15);
            this.label28.TabIndex = 49;
            this.label28.Text = "Z Travel distance (cm)";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label27.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label27.Location = new System.Drawing.Point(20, 199);
            this.label27.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(161, 15);
            this.label27.TabIndex = 48;
            this.label27.Text = "Y Travel distance (cm)";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label26.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label26.Location = new System.Drawing.Point(20, 184);
            this.label26.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(161, 15);
            this.label26.TabIndex = 47;
            this.label26.Text = "X Travel distance (cm)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label25.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label25.Location = new System.Drawing.Point(44, 162);
            this.label25.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(77, 15);
            this.label25.TabIndex = 46;
            this.label25.Text = "Print Life";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label24.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label24.Location = new System.Drawing.Point(44, 147);
            this.label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(98, 15);
            this.label24.TabIndex = 45;
            this.label24.Text = "Power On Time";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label23.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label23.Location = new System.Drawing.Point(44, 132);
            this.label23.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 15);
            this.label23.TabIndex = 44;
            this.label23.Text = "Power Cycles";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label22.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label22.Location = new System.Drawing.Point(20, 117);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 15);
            this.label22.TabIndex = 43;
            this.label22.Text = "Lifetime Statistics";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label21.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label21.Location = new System.Drawing.Point(44, 94);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 15);
            this.label21.TabIndex = 42;
            this.label21.Text = "T3";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label20.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label20.Location = new System.Drawing.Point(44, 79);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 15);
            this.label20.TabIndex = 41;
            this.label20.Text = "T2";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label19.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label19.Location = new System.Drawing.Point(44, 64);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 15);
            this.label19.TabIndex = 40;
            this.label19.Text = "T1";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label18.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label18.Location = new System.Drawing.Point(44, 49);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "T0";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label17.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label17.Location = new System.Drawing.Point(20, 34);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 15);
            this.label17.TabIndex = 38;
            this.label17.Text = "Duese Abstand";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label16.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label16.Location = new System.Drawing.Point(20, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 15);
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
            // MultecTouchpanel
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tabControl1);
            this.Name = "MultecTouchpanel";
            this.Size = new System.Drawing.Size(563, 554);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnZPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnYMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnXMinus)).EndInit();
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
        private Label label39;
        private Label label40;
        private Label label41;
        private Label label42;
        private Label label43;
        private Label label44;
        private Label label45;
        private Label label46;
        private Label label47;
        private Label label48;
        private Label label49;
        private Label label50;
        private Label label51;
        private Label label52;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private Label lblFirmware;
        private Label label67;
        private Label label68;
        private Label label69;
        private Label label70;
        private Label label63;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label59;
        private Label label60;
        private Label label61;
        private Label label62;
        private MyCustomButton.MyCustomButton btnZPlus;
    }
}
