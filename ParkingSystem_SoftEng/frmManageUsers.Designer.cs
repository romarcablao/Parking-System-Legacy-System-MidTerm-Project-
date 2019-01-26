namespace ParkingSystem_SoftEng
{
    partial class frmManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            this.Label6 = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.pnlADDEDITDEL = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnArchive = new System.Windows.Forms.Button();
            this.btnCLEAR = new System.Windows.Forms.Button();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.Label8 = new System.Windows.Forms.Label();
            this.pnlHEADING = new System.Windows.Forms.Panel();
            this.Label7 = new System.Windows.Forms.Label();
            this.cboLEVEL = new System.Windows.Forms.ComboBox();
            this.pnlDATAHOLDER = new System.Windows.Forms.Panel();
            this.cboSTATUS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLNAME = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUNAME = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.txtFNAME = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.pnlSAVECLEARCANCEL = new System.Windows.Forms.Panel();
            this.lvwUSERS = new System.Windows.Forms.ListView();
            this.txtSEARCH = new System.Windows.Forms.TextBox();
            this.pnlADDEDITDEL.SuspendLayout();
            this.pnlHEADING.SuspendLayout();
            this.pnlDATAHOLDER.SuspendLayout();
            this.pnlSAVECLEARCANCEL.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(538, 18);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(103, 28);
            this.Label6.TabIndex = 116;
            this.Label6.Text = "SEARCH";
            // 
            // btnSAVE
            // 
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSAVE.Location = new System.Drawing.Point(6, 15);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(463, 40);
            this.btnSAVE.TabIndex = 0;
            this.btnSAVE.Text = "SAVE";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click_1);
            // 
            // pnlADDEDITDEL
            // 
            this.pnlADDEDITDEL.BackColor = System.Drawing.Color.White;
            this.pnlADDEDITDEL.Controls.Add(this.btnAdd);
            this.pnlADDEDITDEL.Controls.Add(this.btnEdit);
            this.pnlADDEDITDEL.Controls.Add(this.btnArchive);
            this.pnlADDEDITDEL.ForeColor = System.Drawing.Color.Black;
            this.pnlADDEDITDEL.Location = new System.Drawing.Point(39, 660);
            this.pnlADDEDITDEL.Name = "pnlADDEDITDEL";
            this.pnlADDEDITDEL.Size = new System.Drawing.Size(472, 164);
            this.pnlADDEDITDEL.TabIndex = 117;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(5, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(463, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(5, 60);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(463, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnArchive
            // 
            this.btnArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArchive.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArchive.Location = new System.Drawing.Point(5, 108);
            this.btnArchive.Name = "btnArchive";
            this.btnArchive.Size = new System.Drawing.Size(463, 40);
            this.btnArchive.TabIndex = 2;
            this.btnArchive.Text = "ARCHIVE";
            this.btnArchive.UseVisualStyleBackColor = true;
            this.btnArchive.Visible = false;
            this.btnArchive.Click += new System.EventHandler(this.btnArchive_Click);
            // 
            // btnCLEAR
            // 
            this.btnCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLEAR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCLEAR.Location = new System.Drawing.Point(6, 63);
            this.btnCLEAR.Name = "btnCLEAR";
            this.btnCLEAR.Size = new System.Drawing.Size(463, 40);
            this.btnCLEAR.TabIndex = 1;
            this.btnCLEAR.Text = "CLEAR";
            this.btnCLEAR.UseVisualStyleBackColor = true;
            this.btnCLEAR.Click += new System.EventHandler(this.btnCLEAR_Click_1);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCANCEL.Location = new System.Drawing.Point(6, 111);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(463, 40);
            this.btnCANCEL.TabIndex = 2;
            this.btnCANCEL.Text = "CANCEL";
            this.btnCANCEL.UseVisualStyleBackColor = true;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click_1);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.White;
            this.Label8.Location = new System.Drawing.Point(113, 68);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(201, 47);
            this.Label8.TabIndex = 115;
            this.Label8.Text = "MANAGE";
            // 
            // pnlHEADING
            // 
            this.pnlHEADING.BackColor = System.Drawing.Color.DimGray;
            this.pnlHEADING.Controls.Add(this.Label8);
            this.pnlHEADING.Controls.Add(this.Label7);
            this.pnlHEADING.ForeColor = System.Drawing.Color.White;
            this.pnlHEADING.Location = new System.Drawing.Point(39, 0);
            this.pnlHEADING.Name = "pnlHEADING";
            this.pnlHEADING.Size = new System.Drawing.Size(472, 224);
            this.pnlHEADING.TabIndex = 120;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.White;
            this.Label7.Location = new System.Drawing.Point(61, 115);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(321, 47);
            this.Label7.TabIndex = 114;
            this.Label7.Text = "USER ACCOUNT";
            // 
            // cboLEVEL
            // 
            this.cboLEVEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLEVEL.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboLEVEL.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLEVEL.ForeColor = System.Drawing.Color.Black;
            this.cboLEVEL.FormattingEnabled = true;
            this.cboLEVEL.Items.AddRange(new object[] {
            "GUEST",
            "ADMIN"});
            this.cboLEVEL.Location = new System.Drawing.Point(6, 360);
            this.cboLEVEL.Name = "cboLEVEL";
            this.cboLEVEL.Size = new System.Drawing.Size(220, 35);
            this.cboLEVEL.TabIndex = 5;
            // 
            // pnlDATAHOLDER
            // 
            this.pnlDATAHOLDER.BackColor = System.Drawing.Color.White;
            this.pnlDATAHOLDER.Controls.Add(this.cboSTATUS);
            this.pnlDATAHOLDER.Controls.Add(this.label10);
            this.pnlDATAHOLDER.Controls.Add(this.txtLNAME);
            this.pnlDATAHOLDER.Controls.Add(this.label9);
            this.pnlDATAHOLDER.Controls.Add(this.cboLEVEL);
            this.pnlDATAHOLDER.Controls.Add(this.txtUNAME);
            this.pnlDATAHOLDER.Controls.Add(this.Label1);
            this.pnlDATAHOLDER.Controls.Add(this.txtPASS);
            this.pnlDATAHOLDER.Controls.Add(this.Label5);
            this.pnlDATAHOLDER.Controls.Add(this.Label2);
            this.pnlDATAHOLDER.Controls.Add(this.txtUID);
            this.pnlDATAHOLDER.Controls.Add(this.txtFNAME);
            this.pnlDATAHOLDER.Controls.Add(this.Label4);
            this.pnlDATAHOLDER.Controls.Add(this.Label3);
            this.pnlDATAHOLDER.Enabled = false;
            this.pnlDATAHOLDER.ForeColor = System.Drawing.Color.Black;
            this.pnlDATAHOLDER.Location = new System.Drawing.Point(39, 243);
            this.pnlDATAHOLDER.Name = "pnlDATAHOLDER";
            this.pnlDATAHOLDER.Size = new System.Drawing.Size(472, 411);
            this.pnlDATAHOLDER.TabIndex = 118;
            // 
            // cboSTATUS
            // 
            this.cboSTATUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSTATUS.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboSTATUS.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSTATUS.ForeColor = System.Drawing.Color.Black;
            this.cboSTATUS.FormattingEnabled = true;
            this.cboSTATUS.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.cboSTATUS.Location = new System.Drawing.Point(238, 360);
            this.cboSTATUS.Name = "cboSTATUS";
            this.cboSTATUS.Size = new System.Drawing.Size(220, 35);
            this.cboSTATUS.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(234, 324);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 28);
            this.label10.TabIndex = 78;
            this.label10.Text = "USER STATUS:";
            // 
            // txtLNAME
            // 
            this.txtLNAME.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLNAME.ForeColor = System.Drawing.Color.Black;
            this.txtLNAME.Location = new System.Drawing.Point(238, 280);
            this.txtLNAME.Name = "txtLNAME";
            this.txtLNAME.Size = new System.Drawing.Size(220, 36);
            this.txtLNAME.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(233, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 28);
            this.label9.TabIndex = 77;
            this.label9.Text = "LASTNAME:";
            // 
            // txtUNAME
            // 
            this.txtUNAME.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUNAME.ForeColor = System.Drawing.Color.Black;
            this.txtUNAME.Location = new System.Drawing.Point(6, 120);
            this.txtUNAME.Name = "txtUNAME";
            this.txtUNAME.Size = new System.Drawing.Size(462, 36);
            this.txtUNAME.TabIndex = 1;
            this.txtUNAME.Leave += new System.EventHandler(this.txtUNAME_Leave);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(2, 84);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(142, 28);
            this.Label1.TabIndex = 67;
            this.Label1.Text = "USERNAME:";
            // 
            // txtPASS
            // 
            this.txtPASS.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASS.ForeColor = System.Drawing.Color.Black;
            this.txtPASS.Location = new System.Drawing.Point(6, 200);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(462, 36);
            this.txtPASS.TabIndex = 2;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(2, 4);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(96, 28);
            this.Label5.TabIndex = 74;
            this.Label5.Text = "USERID:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(2, 164);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(147, 28);
            this.Label2.TabIndex = 69;
            this.Label2.Text = "PASSWORD:";
            // 
            // txtUID
            // 
            this.txtUID.Enabled = false;
            this.txtUID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUID.ForeColor = System.Drawing.Color.Black;
            this.txtUID.Location = new System.Drawing.Point(6, 40);
            this.txtUID.Name = "txtUID";
            this.txtUID.Size = new System.Drawing.Size(462, 36);
            this.txtUID.TabIndex = 0;
            // 
            // txtFNAME
            // 
            this.txtFNAME.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFNAME.ForeColor = System.Drawing.Color.Black;
            this.txtFNAME.Location = new System.Drawing.Point(6, 280);
            this.txtFNAME.Name = "txtFNAME";
            this.txtFNAME.Size = new System.Drawing.Size(220, 36);
            this.txtFNAME.TabIndex = 3;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(2, 324);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(142, 28);
            this.Label4.TabIndex = 72;
            this.Label4.Text = "USER LEVEL:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(2, 244);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(144, 28);
            this.Label3.TabIndex = 71;
            this.Label3.Text = "FIRSTNAME:";
            // 
            // pnlSAVECLEARCANCEL
            // 
            this.pnlSAVECLEARCANCEL.BackColor = System.Drawing.Color.White;
            this.pnlSAVECLEARCANCEL.Controls.Add(this.btnSAVE);
            this.pnlSAVECLEARCANCEL.Controls.Add(this.btnCLEAR);
            this.pnlSAVECLEARCANCEL.Controls.Add(this.btnCANCEL);
            this.pnlSAVECLEARCANCEL.Enabled = false;
            this.pnlSAVECLEARCANCEL.ForeColor = System.Drawing.Color.Black;
            this.pnlSAVECLEARCANCEL.Location = new System.Drawing.Point(39, 660);
            this.pnlSAVECLEARCANCEL.Name = "pnlSAVECLEARCANCEL";
            this.pnlSAVECLEARCANCEL.Size = new System.Drawing.Size(472, 164);
            this.pnlSAVECLEARCANCEL.TabIndex = 119;
            this.pnlSAVECLEARCANCEL.Visible = false;
            // 
            // lvwUSERS
            // 
            this.lvwUSERS.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwUSERS.Location = new System.Drawing.Point(530, 60);
            this.lvwUSERS.Name = "lvwUSERS";
            this.lvwUSERS.Size = new System.Drawing.Size(1082, 752);
            this.lvwUSERS.TabIndex = 114;
            this.lvwUSERS.UseCompatibleStateImageBehavior = false;
            this.lvwUSERS.SelectedIndexChanged += new System.EventHandler(this.lvwUSERS_SelectedIndexChanged);
            // 
            // txtSEARCH
            // 
            this.txtSEARCH.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEARCH.Location = new System.Drawing.Point(647, 10);
            this.txtSEARCH.Name = "txtSEARCH";
            this.txtSEARCH.Size = new System.Drawing.Size(965, 36);
            this.txtSEARCH.TabIndex = 115;
            this.txtSEARCH.TextChanged += new System.EventHandler(this.txtSEARCH_TextChanged);
            // 
            // frmManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1650, 825);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.pnlADDEDITDEL);
            this.Controls.Add(this.pnlHEADING);
            this.Controls.Add(this.pnlDATAHOLDER);
            this.Controls.Add(this.pnlSAVECLEARCANCEL);
            this.Controls.Add(this.lvwUSERS);
            this.Controls.Add(this.txtSEARCH);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANAGE USER";
            this.Load += new System.EventHandler(this.frmManageUsers_Load);
            this.pnlADDEDITDEL.ResumeLayout(false);
            this.pnlHEADING.ResumeLayout(false);
            this.pnlHEADING.PerformLayout();
            this.pnlDATAHOLDER.ResumeLayout(false);
            this.pnlDATAHOLDER.PerformLayout();
            this.pnlSAVECLEARCANCEL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnSAVE;
        internal System.Windows.Forms.Panel pnlADDEDITDEL;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnEdit;
        internal System.Windows.Forms.Button btnArchive;
        internal System.Windows.Forms.Button btnCLEAR;
        internal System.Windows.Forms.Button btnCANCEL;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Panel pnlHEADING;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cboLEVEL;
        internal System.Windows.Forms.Panel pnlDATAHOLDER;
        internal System.Windows.Forms.TextBox txtLNAME;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtUNAME;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtPASS;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtUID;
        internal System.Windows.Forms.TextBox txtFNAME;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Panel pnlSAVECLEARCANCEL;
        internal System.Windows.Forms.ListView lvwUSERS;
        internal System.Windows.Forms.TextBox txtSEARCH;
        internal System.Windows.Forms.ComboBox cboSTATUS;
        internal System.Windows.Forms.Label label10;
    }
}