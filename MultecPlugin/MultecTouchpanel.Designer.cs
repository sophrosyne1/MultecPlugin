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
            this.but_Xplus = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.but_step_1 = new System.Windows.Forms.Button();
            this.but_step_10 = new System.Windows.Forms.Button();
            this.but_step_50 = new System.Windows.Forms.Button();
            this.but_Yplus = new System.Windows.Forms.Button();
            this.but_Yminus = new System.Windows.Forms.Button();
            this.but_Xminus = new System.Windows.Forms.Button();
            this.but_Zplus = new System.Windows.Forms.Button();
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_NozzleTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // but_Xplus
            // 
            this.but_Xplus.Location = new System.Drawing.Point(229, 60);
            this.but_Xplus.Name = "but_Xplus";
            this.but_Xplus.Size = new System.Drawing.Size(70, 70);
            this.but_Xplus.TabIndex = 0;
            this.but_Xplus.Text = "X+";
            this.but_Xplus.UseVisualStyleBackColor = true;
            this.but_Xplus.Click += new System.EventHandler(this.but_Xplus_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(6, 157);
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
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
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
            this.but_step_50.Location = new System.Drawing.Point(4, 16);
            this.but_step_50.Margin = new System.Windows.Forms.Padding(2);
            this.but_step_50.Name = "but_step_50";
            this.but_step_50.Size = new System.Drawing.Size(60, 40);
            this.but_step_50.TabIndex = 0;
            this.but_step_50.Text = "50 mm";
            this.but_step_50.UseVisualStyleBackColor = true;
            this.but_step_50.Click += new System.EventHandler(this.but_step_50_Click);
            // 
            // but_Yplus
            // 
            this.but_Yplus.Location = new System.Drawing.Point(155, 14);
            this.but_Yplus.Name = "but_Yplus";
            this.but_Yplus.Size = new System.Drawing.Size(70, 70);
            this.but_Yplus.TabIndex = 2;
            this.but_Yplus.Text = "Y+";
            this.but_Yplus.UseVisualStyleBackColor = true;
            this.but_Yplus.Click += new System.EventHandler(this.but_Yplus_Click);
            // 
            // but_Yminus
            // 
            this.but_Yminus.Location = new System.Drawing.Point(155, 106);
            this.but_Yminus.Name = "but_Yminus";
            this.but_Yminus.Size = new System.Drawing.Size(70, 70);
            this.but_Yminus.TabIndex = 3;
            this.but_Yminus.Text = "Y-";
            this.but_Yminus.UseVisualStyleBackColor = true;
            this.but_Yminus.Click += new System.EventHandler(this.but_Yminus_Click);
            // 
            // but_Xminus
            // 
            this.but_Xminus.Location = new System.Drawing.Point(83, 60);
            this.but_Xminus.Name = "but_Xminus";
            this.but_Xminus.Size = new System.Drawing.Size(70, 70);
            this.but_Xminus.TabIndex = 4;
            this.but_Xminus.Text = "X-";
            this.but_Xminus.UseVisualStyleBackColor = true;
            this.but_Xminus.Click += new System.EventHandler(this.but_Xminus_Click);
            // 
            // but_Zplus
            // 
            this.but_Zplus.Location = new System.Drawing.Point(315, 14);
            this.but_Zplus.Name = "but_Zplus";
            this.but_Zplus.Size = new System.Drawing.Size(70, 70);
            this.but_Zplus.TabIndex = 5;
            this.but_Zplus.Text = "Z+";
            this.but_Zplus.UseVisualStyleBackColor = true;
            this.but_Zplus.Click += new System.EventHandler(this.but_Zplus_Click);
            // 
            // but_Zminus
            // 
            this.but_Zminus.Location = new System.Drawing.Point(315, 106);
            this.but_Zminus.Name = "but_Zminus";
            this.but_Zminus.Size = new System.Drawing.Size(70, 70);
            this.but_Zminus.TabIndex = 6;
            this.but_Zminus.Text = "Z-";
            this.but_Zminus.UseVisualStyleBackColor = true;
            this.but_Zminus.Click += new System.EventHandler(this.but_Zminus_Click);
            // 
            // but_Extrude
            // 
            this.but_Extrude.Location = new System.Drawing.Point(391, 106);
            this.but_Extrude.Name = "but_Extrude";
            this.but_Extrude.Size = new System.Drawing.Size(70, 70);
            this.but_Extrude.TabIndex = 8;
            this.but_Extrude.Text = "Extrude";
            this.but_Extrude.UseVisualStyleBackColor = true;
            this.but_Extrude.Click += new System.EventHandler(this.but_Extrude_Click);
            // 
            // but_Retract
            // 
            this.but_Retract.Location = new System.Drawing.Point(391, 14);
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
            this.groupBox2.Location = new System.Drawing.Point(87, 190);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 70);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Werkzeug Auswahl";
            // 
            // but_MOVE
            // 
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
            this.but_G222.Location = new System.Drawing.Point(6, 249);
            this.but_G222.Name = "but_G222";
            this.but_G222.Size = new System.Drawing.Size(60, 40);
            this.but_G222.TabIndex = 5;
            this.but_G222.Text = "Home MOVE";
            this.but_G222.UseVisualStyleBackColor = true;
            this.but_G222.Click += new System.EventHandler(this.but_G222_Click);
            // 
            // but_G224
            // 
            this.but_G224.Location = new System.Drawing.Point(6, 295);
            this.but_G224.Name = "but_G224";
            this.but_G224.Size = new System.Drawing.Size(60, 40);
            this.but_G224.TabIndex = 10;
            this.but_G224.Text = "Park MOVE";
            this.but_G224.UseVisualStyleBackColor = true;
            this.but_G224.Click += new System.EventHandler(this.but_G224_Click);
            // 
            // but_MotorAus
            // 
            this.but_MotorAus.Location = new System.Drawing.Point(6, 203);
            this.but_MotorAus.Name = "but_MotorAus";
            this.but_MotorAus.Size = new System.Drawing.Size(60, 40);
            this.but_MotorAus.TabIndex = 11;
            this.but_MotorAus.Text = "Motoren Aus";
            this.but_MotorAus.UseVisualStyleBackColor = true;
            this.but_MotorAus.Click += new System.EventHandler(this.but_MotorAus_Click);
            // 
            // but_T0_OnOff
            // 
            this.but_T0_OnOff.Location = new System.Drawing.Point(93, 265);
            this.but_T0_OnOff.Name = "but_T0_OnOff";
            this.but_T0_OnOff.Size = new System.Drawing.Size(60, 30);
            this.but_T0_OnOff.TabIndex = 12;
            this.but_T0_OnOff.Text = "Ein/Aus";
            this.but_T0_OnOff.UseVisualStyleBackColor = true;
            this.but_T0_OnOff.Click += new System.EventHandler(this.but_T0_OnOff_Click);
            // 
            // but_T1_OnOff
            // 
            this.but_T1_OnOff.Location = new System.Drawing.Point(159, 266);
            this.but_T1_OnOff.Name = "but_T1_OnOff";
            this.but_T1_OnOff.Size = new System.Drawing.Size(60, 30);
            this.but_T1_OnOff.TabIndex = 13;
            this.but_T1_OnOff.Text = "Ein/Aus";
            this.but_T1_OnOff.UseVisualStyleBackColor = true;
            this.but_T1_OnOff.Click += new System.EventHandler(this.but_T1_OnOff_Click);
            // 
            // but_T2_OnOff
            // 
            this.but_T2_OnOff.Location = new System.Drawing.Point(225, 266);
            this.but_T2_OnOff.Name = "but_T2_OnOff";
            this.but_T2_OnOff.Size = new System.Drawing.Size(60, 30);
            this.but_T2_OnOff.TabIndex = 14;
            this.but_T2_OnOff.Text = "Ein/Aus";
            this.but_T2_OnOff.UseVisualStyleBackColor = true;
            this.but_T2_OnOff.Click += new System.EventHandler(this.but_T2_OnOff_Click);
            // 
            // but_T3_OnOff
            // 
            this.but_T3_OnOff.Location = new System.Drawing.Point(291, 266);
            this.but_T3_OnOff.Name = "but_T3_OnOff";
            this.but_T3_OnOff.Size = new System.Drawing.Size(60, 30);
            this.but_T3_OnOff.TabIndex = 15;
            this.but_T3_OnOff.Text = "Ein/Aus";
            this.but_T3_OnOff.UseVisualStyleBackColor = true;
            this.but_T3_OnOff.Click += new System.EventHandler(this.but_T3_OnOff_Click);
            // 
            // trackBar_NozzleTemp
            // 
            this.trackBar_NozzleTemp.LargeChange = 10;
            this.trackBar_NozzleTemp.Location = new System.Drawing.Point(159, 312);
            this.trackBar_NozzleTemp.Maximum = 270;
            this.trackBar_NozzleTemp.Minimum = 170;
            this.trackBar_NozzleTemp.Name = "trackBar_NozzleTemp";
            this.trackBar_NozzleTemp.Size = new System.Drawing.Size(236, 45);
            this.trackBar_NozzleTemp.SmallChange = 5;
            this.trackBar_NozzleTemp.TabIndex = 16;
            this.trackBar_NozzleTemp.Value = 170;
            this.trackBar_NozzleTemp.Scroll += new System.EventHandler(this.trackBar_NozzleTemp_Scroll);
            // 
            // but_NozzleMinus
            // 
            this.but_NozzleMinus.Location = new System.Drawing.Point(93, 312);
            this.but_NozzleMinus.Name = "but_NozzleMinus";
            this.but_NozzleMinus.Size = new System.Drawing.Size(60, 45);
            this.but_NozzleMinus.TabIndex = 17;
            this.but_NozzleMinus.Text = "-5";
            this.but_NozzleMinus.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 45);
            this.button1.TabIndex = 18;
            this.button1.Text = "+5";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.but_NozzlePlus_Click);
            // 
            // MultecTouchpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_NozzleMinus);
            this.Controls.Add(this.trackBar_NozzleTemp);
            this.Controls.Add(this.but_T3_OnOff);
            this.Controls.Add(this.but_T2_OnOff);
            this.Controls.Add(this.but_T1_OnOff);
            this.Controls.Add(this.but_T0_OnOff);
            this.Controls.Add(this.but_MotorAus);
            this.Controls.Add(this.but_G224);
            this.Controls.Add(this.but_G222);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.but_Extrude);
            this.Controls.Add(this.but_Retract);
            this.Controls.Add(this.but_Zminus);
            this.Controls.Add(this.but_Zplus);
            this.Controls.Add(this.but_Xminus);
            this.Controls.Add(this.but_Yminus);
            this.Controls.Add(this.but_Yplus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.but_Xplus);
            this.Name = "MultecTouchpanel";
            this.Size = new System.Drawing.Size(469, 453);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_NozzleTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_Xplus;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button but_step_1;
        private System.Windows.Forms.Button but_step_10;
        private System.Windows.Forms.Button but_step_50;
        private System.Windows.Forms.Button but_Yplus;
        private System.Windows.Forms.Button but_Yminus;
        private System.Windows.Forms.Button but_Xminus;
        private System.Windows.Forms.Button but_Zplus;
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
        private System.Windows.Forms.Button button1;
    }
}
