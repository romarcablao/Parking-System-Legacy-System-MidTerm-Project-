namespace ParkingSystem_SoftEng
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblATTEMPTS = new System.Windows.Forms.Label();
            this.tmrDATETIMECOUNTER = new System.Windows.Forms.Timer(this.components);
            this.pnlMESSAGE = new System.Windows.Forms.Panel();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.lblSECURITY = new System.Windows.Forms.Label();
            this.lblPASS = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblDATETIME = new System.Windows.Forms.Label();
            this.lblUNAME = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblSYSTEMNAME = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlFOOTER = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.pnlFOOTER.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(178, 138);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(150, 150);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 18;
            this.PictureBox1.TabStop = false;
            // 
            // lblATTEMPTS
            // 
            this.lblATTEMPTS.AutoSize = true;
            this.lblATTEMPTS.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblATTEMPTS.Location = new System.Drawing.Point(192, 536);
            this.lblATTEMPTS.Name = "lblATTEMPTS";
            this.lblATTEMPTS.Size = new System.Drawing.Size(0, 19);
            this.lblATTEMPTS.TabIndex = 17;
            // 
            // tmrDATETIMECOUNTER
            // 
            this.tmrDATETIMECOUNTER.Enabled = true;
            this.tmrDATETIMECOUNTER.Tick += new System.EventHandler(this.tmrDATETIMECOUNTER_Tick);
            // 
            // pnlMESSAGE
            // 
            this.pnlMESSAGE.BackColor = System.Drawing.Color.White;
            this.pnlMESSAGE.Location = new System.Drawing.Point(67, 473);
            this.pnlMESSAGE.Name = "pnlMESSAGE";
            this.pnlMESSAGE.Size = new System.Drawing.Size(391, 3);
            this.pnlMESSAGE.TabIndex = 16;
            // 
            // btnEXIT
            // 
            this.btnEXIT.FlatAppearance.BorderSize = 0;
            this.btnEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXIT.Location = new System.Drawing.Point(495, 6);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(43, 30);
            this.btnEXIT.TabIndex = 14;
            this.btnEXIT.Text = "x";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // lblSECURITY
            // 
            this.lblSECURITY.AutoSize = true;
            this.lblSECURITY.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSECURITY.Location = new System.Drawing.Point(13, 10);
            this.lblSECURITY.Name = "lblSECURITY";
            this.lblSECURITY.Size = new System.Drawing.Size(74, 23);
            this.lblSECURITY.TabIndex = 13;
            this.lblSECURITY.Text = "LOGIN";
            // 
            // lblPASS
            // 
            this.lblPASS.AutoSize = true;
            this.lblPASS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPASS.Location = new System.Drawing.Point(63, 406);
            this.lblPASS.Name = "lblPASS";
            this.lblPASS.Size = new System.Drawing.Size(117, 23);
            this.lblPASS.TabIndex = 15;
            this.lblPASS.Text = "PASSWORD";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(67, 431);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(391, 36);
            this.txtPass.TabIndex = 10;
            // 
            // lblDATETIME
            // 
            this.lblDATETIME.AutoSize = true;
            this.lblDATETIME.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDATETIME.Location = new System.Drawing.Point(323, 18);
            this.lblDATETIME.Name = "lblDATETIME";
            this.lblDATETIME.Size = new System.Drawing.Size(67, 19);
            this.lblDATETIME.TabIndex = 1;
            this.lblDATETIME.Text = "--/--/--";
            // 
            // lblUNAME
            // 
            this.lblUNAME.AutoSize = true;
            this.lblUNAME.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUNAME.Location = new System.Drawing.Point(63, 342);
            this.lblUNAME.Name = "lblUNAME";
            this.lblUNAME.Size = new System.Drawing.Size(113, 23);
            this.lblUNAME.TabIndex = 12;
            this.lblUNAME.Text = "USERNAME";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(67, 367);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(391, 36);
            this.txtUsername.TabIndex = 8;
            // 
            // lblSYSTEMNAME
            // 
            this.lblSYSTEMNAME.AutoSize = true;
            this.lblSYSTEMNAME.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSYSTEMNAME.Location = new System.Drawing.Point(13, 18);
            this.lblSYSTEMNAME.Name = "lblSYSTEMNAME";
            this.lblSYSTEMNAME.Size = new System.Drawing.Size(150, 19);
            this.lblSYSTEMNAME.TabIndex = 0;
            this.lblSYSTEMNAME.Text = "PARKING SYSTEM";
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(67, 487);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(391, 36);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlFOOTER
            // 
            this.pnlFOOTER.BackColor = System.Drawing.Color.White;
            this.pnlFOOTER.Controls.Add(this.lblDATETIME);
            this.pnlFOOTER.Controls.Add(this.lblSYSTEMNAME);
            this.pnlFOOTER.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFOOTER.ForeColor = System.Drawing.Color.Teal;
            this.pnlFOOTER.Location = new System.Drawing.Point(0, 687);
            this.pnlFOOTER.Name = "pnlFOOTER";
            this.pnlFOOTER.Size = new System.Drawing.Size(550, 51);
            this.pnlFOOTER.TabIndex = 9;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(550, 738);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.lblATTEMPTS);
            this.Controls.Add(this.pnlMESSAGE);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.lblSECURITY);
            this.Controls.Add(this.lblPASS);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblUNAME);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlFOOTER);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.pnlFOOTER.ResumeLayout(false);
            this.pnlFOOTER.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lblATTEMPTS;
        internal System.Windows.Forms.Timer tmrDATETIMECOUNTER;
        internal System.Windows.Forms.Panel pnlMESSAGE;
        internal System.Windows.Forms.Button btnEXIT;
        internal System.Windows.Forms.Label lblSECURITY;
        internal System.Windows.Forms.Label lblPASS;
        internal System.Windows.Forms.TextBox txtPass;
        internal System.Windows.Forms.Label lblDATETIME;
        internal System.Windows.Forms.Label lblUNAME;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.Label lblSYSTEMNAME;
        internal System.Windows.Forms.Button btnLogin;
        internal System.Windows.Forms.Panel pnlFOOTER;
    }
}