namespace ParkingSystem_SoftEng
{
    partial class frmTransaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransaction));
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtVehiclePlateNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboVehicleBrand = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtVehicleColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnViewParkingSpace = new System.Windows.Forms.Button();
            this.txtParkingNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtParkingBlock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.txtRatePerHour = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCustomer
            // 
            this.txtCustomer.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomer.ForeColor = System.Drawing.Color.Black;
            this.txtCustomer.Location = new System.Drawing.Point(362, 171);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(362, 36);
            this.txtCustomer.TabIndex = 75;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(357, 140);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(213, 28);
            this.Label1.TabIndex = 76;
            this.Label1.Text = "CUSTOMER NAME";
            // 
            // txtVehiclePlateNo
            // 
            this.txtVehiclePlateNo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehiclePlateNo.ForeColor = System.Drawing.Color.Black;
            this.txtVehiclePlateNo.Location = new System.Drawing.Point(776, 171);
            this.txtVehiclePlateNo.Name = "txtVehiclePlateNo";
            this.txtVehiclePlateNo.Size = new System.Drawing.Size(362, 36);
            this.txtVehiclePlateNo.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(771, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 28);
            this.label2.TabIndex = 82;
            this.label2.Text = "PLATE NO.";
            // 
            // cboVehicleBrand
            // 
            this.cboVehicleBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicleBrand.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboVehicleBrand.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVehicleBrand.ForeColor = System.Drawing.Color.Black;
            this.cboVehicleBrand.FormattingEnabled = true;
            this.cboVehicleBrand.Items.AddRange(new object[] {
            "GUEST",
            "ADMIN"});
            this.cboVehicleBrand.Location = new System.Drawing.Point(362, 262);
            this.cboVehicleBrand.Name = "cboVehicleBrand";
            this.cboVehicleBrand.Size = new System.Drawing.Size(362, 35);
            this.cboVehicleBrand.TabIndex = 84;
            this.cboVehicleBrand.DropDown += new System.EventHandler(this.cboVehicleBrand_DropDown);
            this.cboVehicleBrand.SelectedIndexChanged += new System.EventHandler(this.cboVehicleBrand_SelectedIndexChanged);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(357, 231);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(194, 28);
            this.Label4.TabIndex = 83;
            this.Label4.Text = "VEHICLE BRAND";
            // 
            // txtVehicleColor
            // 
            this.txtVehicleColor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleColor.ForeColor = System.Drawing.Color.Black;
            this.txtVehicleColor.Location = new System.Drawing.Point(776, 262);
            this.txtVehicleColor.Name = "txtVehicleColor";
            this.txtVehicleColor.Size = new System.Drawing.Size(362, 36);
            this.txtVehicleColor.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(771, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 28);
            this.label3.TabIndex = 86;
            this.label3.Text = "VEHICLE COLOR";
            // 
            // btnViewParkingSpace
            // 
            this.btnViewParkingSpace.FlatAppearance.BorderSize = 2;
            this.btnViewParkingSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewParkingSpace.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewParkingSpace.Location = new System.Drawing.Point(10, 115);
            this.btnViewParkingSpace.Name = "btnViewParkingSpace";
            this.btnViewParkingSpace.Size = new System.Drawing.Size(753, 40);
            this.btnViewParkingSpace.TabIndex = 87;
            this.btnViewParkingSpace.Text = "VIEW PARKING SPACE";
            this.btnViewParkingSpace.UseVisualStyleBackColor = true;
            this.btnViewParkingSpace.Click += new System.EventHandler(this.btnViewParkingSpace_Click);
            // 
            // txtParkingNo
            // 
            this.txtParkingNo.Enabled = false;
            this.txtParkingNo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParkingNo.ForeColor = System.Drawing.Color.Black;
            this.txtParkingNo.Location = new System.Drawing.Point(415, 63);
            this.txtParkingNo.Name = "txtParkingNo";
            this.txtParkingNo.Size = new System.Drawing.Size(348, 36);
            this.txtParkingNo.TabIndex = 90;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 28);
            this.label5.TabIndex = 91;
            this.label5.Text = "PARKING SECTION";
            // 
            // txtParkingBlock
            // 
            this.txtParkingBlock.Enabled = false;
            this.txtParkingBlock.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParkingBlock.ForeColor = System.Drawing.Color.Black;
            this.txtParkingBlock.Location = new System.Drawing.Point(10, 63);
            this.txtParkingBlock.Name = "txtParkingBlock";
            this.txtParkingBlock.Size = new System.Drawing.Size(352, 36);
            this.txtParkingBlock.TabIndex = 88;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 28);
            this.label6.TabIndex = 89;
            this.label6.Text = "PARKING NO.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btnViewParkingSpace);
            this.panel1.Controls.Add(this.txtParkingNo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtParkingBlock);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(362, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 182);
            this.panel1.TabIndex = 92;
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.FlatAppearance.BorderSize = 2;
            this.btnGenerateCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateCode.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateCode.Location = new System.Drawing.Point(362, 603);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(776, 63);
            this.btnGenerateCode.TabIndex = 92;
            this.btnGenerateCode.Text = "GENERATE CODE";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // txtRatePerHour
            // 
            this.txtRatePerHour.Enabled = false;
            this.txtRatePerHour.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRatePerHour.ForeColor = System.Drawing.Color.Black;
            this.txtRatePerHour.Location = new System.Drawing.Point(776, 349);
            this.txtRatePerHour.Name = "txtRatePerHour";
            this.txtRatePerHour.Size = new System.Drawing.Size(362, 36);
            this.txtRatePerHour.TabIndex = 97;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(771, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 28);
            this.label7.TabIndex = 98;
            this.label7.Text = "RATE PER HOUR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(357, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 28);
            this.label8.TabIndex = 95;
            this.label8.Text = "VEHICLE TYPE";
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.Enabled = false;
            this.txtVehicleType.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleType.ForeColor = System.Drawing.Color.Black;
            this.txtVehicleType.Location = new System.Drawing.Point(362, 352);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(362, 36);
            this.txtVehicleType.TabIndex = 99;
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1650, 825);
            this.Controls.Add(this.txtVehicleType);
            this.Controls.Add(this.txtRatePerHour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtVehicleColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboVehicleBrand);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtVehiclePlateNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRANSACTION";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtCustomer;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtVehiclePlateNo;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ComboBox cboVehicleBrand;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtVehicleColor;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button btnViewParkingSpace;
        internal System.Windows.Forms.TextBox txtParkingNo;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtParkingBlock;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnGenerateCode;
        internal System.Windows.Forms.TextBox txtRatePerHour;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtVehicleType;
    }
}