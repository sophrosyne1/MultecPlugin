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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Xplus
            // 
            this.but_Xplus.Location = new System.Drawing.Point(344, 93);
            this.but_Xplus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_Xplus.Name = "but_Xplus";
            this.but_Xplus.Size = new System.Drawing.Size(112, 82);
            this.but_Xplus.TabIndex = 0;
            this.but_Xplus.Text = "X+";
            this.but_Xplus.UseVisualStyleBackColor = true;
            this.but_Xplus.Click += new System.EventHandler(this.but_Xplus_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.Location = new System.Drawing.Point(9, 208);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(112, 35);
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
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 156);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Distance";
            // 
            // but_step_1
            // 
            this.but_step_1.Location = new System.Drawing.Point(6, 107);
            this.but_step_1.Name = "but_step_1";
            this.but_step_1.Size = new System.Drawing.Size(95, 35);
            this.but_step_1.TabIndex = 2;
            this.but_step_1.Text = "1 mm";
            this.but_step_1.UseVisualStyleBackColor = true;
            this.but_step_1.Click += new System.EventHandler(this.but_step_1_Click);
            // 
            // but_step_10
            // 
            this.but_step_10.Location = new System.Drawing.Point(6, 66);
            this.but_step_10.Name = "but_step_10";
            this.but_step_10.Size = new System.Drawing.Size(95, 35);
            this.but_step_10.TabIndex = 1;
            this.but_step_10.Text = "10 mm";
            this.but_step_10.UseVisualStyleBackColor = true;
            this.but_step_10.Click += new System.EventHandler(this.but_step_10_Click);
            // 
            // but_step_50
            // 
            this.but_step_50.Location = new System.Drawing.Point(6, 25);
            this.but_step_50.Name = "but_step_50";
            this.but_step_50.Size = new System.Drawing.Size(95, 35);
            this.but_step_50.TabIndex = 0;
            this.but_step_50.Text = "50 mm";
            this.but_step_50.UseVisualStyleBackColor = true;
            this.but_step_50.Click += new System.EventHandler(this.but_step_50_Click);
            // 
            // but_Yplus
            // 
            this.but_Yplus.Location = new System.Drawing.Point(233, 5);
            this.but_Yplus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_Yplus.Name = "but_Yplus";
            this.but_Yplus.Size = new System.Drawing.Size(112, 80);
            this.but_Yplus.TabIndex = 2;
            this.but_Yplus.Text = "Y+";
            this.but_Yplus.UseVisualStyleBackColor = true;
            this.but_Yplus.Click += new System.EventHandler(this.but_Yplus_Click);
            // 
            // but_Yminus
            // 
            this.but_Yminus.Location = new System.Drawing.Point(233, 185);
            this.but_Yminus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_Yminus.Name = "but_Yminus";
            this.but_Yminus.Size = new System.Drawing.Size(112, 80);
            this.but_Yminus.TabIndex = 3;
            this.but_Yminus.Text = "Y-";
            this.but_Yminus.UseVisualStyleBackColor = true;
            this.but_Yminus.Click += new System.EventHandler(this.but_Yminus_Click);
            // 
            // but_Xminus
            // 
            this.but_Xminus.Location = new System.Drawing.Point(124, 93);
            this.but_Xminus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.but_Xminus.Name = "but_Xminus";
            this.but_Xminus.Size = new System.Drawing.Size(112, 82);
            this.but_Xminus.TabIndex = 4;
            this.but_Xminus.Text = "Y-";
            this.but_Xminus.UseVisualStyleBackColor = true;
            // 
            // MultecTouchpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.but_Xminus);
            this.Controls.Add(this.but_Yminus);
            this.Controls.Add(this.but_Yplus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.but_Xplus);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MultecTouchpanel";
            this.Size = new System.Drawing.Size(676, 697);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

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
    }
}
