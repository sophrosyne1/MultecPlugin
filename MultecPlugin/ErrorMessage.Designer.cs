namespace MultecPlugin
{
    partial class ErrorMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topBorder = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblStaticText = new System.Windows.Forms.Label();
            this.lblStatic2 = new System.Windows.Forms.Label();
            this.DynamicText = new System.Windows.Forms.TextBox();
            this.topBorder.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBorder
            // 
            this.topBorder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.topBorder.Controls.Add(this.label1);
            this.topBorder.Location = new System.Drawing.Point(-1, 0);
            this.topBorder.Name = "topBorder";
            this.topBorder.Size = new System.Drawing.Size(391, 30);
            this.topBorder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fatal Error";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(67, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(242, 34);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Problem fixed, continue";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblStaticText
            // 
            this.lblStaticText.AutoSize = true;
            this.lblStaticText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStaticText.Location = new System.Drawing.Point(23, 42);
            this.lblStaticText.Name = "lblStaticText";
            this.lblStaticText.Size = new System.Drawing.Size(324, 16);
            this.lblStaticText.TabIndex = 2;
            this.lblStaticText.Text = "A fatal error on the printer side stopped the printer until";
            // 
            // lblStatic2
            // 
            this.lblStatic2.AutoSize = true;
            this.lblStatic2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatic2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblStatic2.Location = new System.Drawing.Point(23, 58);
            this.lblStatic2.Name = "lblStatic2";
            this.lblStatic2.Size = new System.Drawing.Size(208, 16);
            this.lblStatic2.TabIndex = 4;
            this.lblStatic2.Text = "the error is fixed. Printer Message:";
            // 
            // DynamicText
            // 
            this.DynamicText.BackColor = System.Drawing.Color.Firebrick;
            this.DynamicText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DynamicText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DynamicText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DynamicText.Location = new System.Drawing.Point(26, 93);
            this.DynamicText.Multiline = true;
            this.DynamicText.Name = "DynamicText";
            this.DynamicText.ReadOnly = true;
            this.DynamicText.Size = new System.Drawing.Size(321, 69);
            this.DynamicText.TabIndex = 5;
            // 
            // ErrorMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(390, 223);
            this.Controls.Add(this.DynamicText);
            this.Controls.Add(this.lblStatic2);
            this.Controls.Add(this.lblStaticText);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.topBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ErrorMessage";
            this.Text = "ErrorMessage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ErrorMessage_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ErrorMessage_MouseDown);
            this.topBorder.ResumeLayout(false);
            this.topBorder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topBorder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblStaticText;
        private System.Windows.Forms.Label lblStatic2;
        public System.Windows.Forms.TextBox DynamicText;
    }
}