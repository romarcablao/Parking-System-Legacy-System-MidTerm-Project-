namespace ParkingSystem_SoftEng
{
    partial class frmManageBrandTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageBrandTypes));
            this.Label6 = new System.Windows.Forms.Label();
            this.lvwBrandData = new System.Windows.Forms.ListView();
            this.txtBrandSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvwTypeData = new System.Windows.Forms.ListView();
            this.txtTypeSearch = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtBrandID = new System.Windows.Forms.TextBox();
            this.cboBrandCategory = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTypeAdd = new System.Windows.Forms.Button();
            this.btnTypeEdit = new System.Windows.Forms.Button();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTypeRate = new System.Windows.Forms.TextBox();
            this.btnTypeSave = new System.Windows.Forms.Button();
            this.btnTypeCancel = new System.Windows.Forms.Button();
            this.cboBrandStatus = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBrandSave = new System.Windows.Forms.Button();
            this.btnBrandCancel = new System.Windows.Forms.Button();
            this.btnBrandAdd = new System.Windows.Forms.Button();
            this.btnBrandEdit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Black;
            this.Label6.Location = new System.Drawing.Point(933, 14);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(103, 28);
            this.Label6.TabIndex = 119;
            this.Label6.Text = "SEARCH";
            // 
            // lvwBrandData
            // 
            this.lvwBrandData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBrandData.Location = new System.Drawing.Point(928, 55);
            this.lvwBrandData.Name = "lvwBrandData";
            this.lvwBrandData.Size = new System.Drawing.Size(684, 317);
            this.lvwBrandData.TabIndex = 117;
            this.lvwBrandData.UseCompatibleStateImageBehavior = false;
            this.lvwBrandData.SelectedIndexChanged += new System.EventHandler(this.lvwBrandData_SelectedIndexChanged);
            this.lvwBrandData.DoubleClick += new System.EventHandler(this.lvwBrandData_DoubleClick);
            // 
            // txtBrandSearch
            // 
            this.txtBrandSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandSearch.Location = new System.Drawing.Point(1042, 10);
            this.txtBrandSearch.Name = "txtBrandSearch";
            this.txtBrandSearch.Size = new System.Drawing.Size(570, 36);
            this.txtBrandSearch.TabIndex = 118;
            this.txtBrandSearch.TextChanged += new System.EventHandler(this.txtBrandSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(933, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 122;
            this.label1.Text = "SEARCH";
            // 
            // lvwTypeData
            // 
            this.lvwTypeData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTypeData.Location = new System.Drawing.Point(928, 486);
            this.lvwTypeData.Name = "lvwTypeData";
            this.lvwTypeData.Size = new System.Drawing.Size(684, 317);
            this.lvwTypeData.TabIndex = 120;
            this.lvwTypeData.UseCompatibleStateImageBehavior = false;
            this.lvwTypeData.SelectedIndexChanged += new System.EventHandler(this.lvwTypeData_SelectedIndexChanged);
            this.lvwTypeData.DoubleClick += new System.EventHandler(this.lvwTypeData_DoubleClick);
            // 
            // txtTypeSearch
            // 
            this.txtTypeSearch.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeSearch.Location = new System.Drawing.Point(1042, 441);
            this.txtTypeSearch.Name = "txtTypeSearch";
            this.txtTypeSearch.Size = new System.Drawing.Size(570, 36);
            this.txtTypeSearch.TabIndex = 121;
            this.txtTypeSearch.TextChanged += new System.EventHandler(this.txtTypeSearch_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(186, 178);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(177, 28);
            this.Label3.TabIndex = 126;
            this.Label3.Text = "BRAND NAME:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(487, 178);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(235, 28);
            this.Label4.TabIndex = 127;
            this.Label4.Text = "BRAND CATEGORY:";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Enabled = false;
            this.txtBrandName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandName.ForeColor = System.Drawing.Color.Black;
            this.txtBrandName.Location = new System.Drawing.Point(190, 214);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(283, 36);
            this.txtBrandName.TabIndex = 125;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(45, 178);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(124, 28);
            this.Label2.TabIndex = 124;
            this.Label2.Text = "BRAND ID";
            // 
            // txtBrandID
            // 
            this.txtBrandID.Enabled = false;
            this.txtBrandID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrandID.ForeColor = System.Drawing.Color.Black;
            this.txtBrandID.Location = new System.Drawing.Point(49, 214);
            this.txtBrandID.Name = "txtBrandID";
            this.txtBrandID.Size = new System.Drawing.Size(120, 36);
            this.txtBrandID.TabIndex = 123;
            // 
            // cboBrandCategory
            // 
            this.cboBrandCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrandCategory.Enabled = false;
            this.cboBrandCategory.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBrandCategory.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBrandCategory.ForeColor = System.Drawing.Color.Black;
            this.cboBrandCategory.FormattingEnabled = true;
            this.cboBrandCategory.Items.AddRange(new object[] {
            "4 WHEELS",
            "2 WHEELS"});
            this.cboBrandCategory.Location = new System.Drawing.Point(491, 214);
            this.cboBrandCategory.Name = "cboBrandCategory";
            this.cboBrandCategory.Size = new System.Drawing.Size(243, 35);
            this.cboBrandCategory.TabIndex = 128;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(49, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 5);
            this.panel1.TabIndex = 129;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(88, 685);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 5);
            this.panel2.TabIndex = 139;
            // 
            // btnTypeAdd
            // 
            this.btnTypeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeAdd.Location = new System.Drawing.Point(398, 820);
            this.btnTypeAdd.Name = "btnTypeAdd";
            this.btnTypeAdd.Size = new System.Drawing.Size(137, 40);
            this.btnTypeAdd.TabIndex = 130;
            this.btnTypeAdd.Text = "ADD";
            this.btnTypeAdd.UseVisualStyleBackColor = true;
            this.btnTypeAdd.Visible = false;
            this.btnTypeAdd.Click += new System.EventHandler(this.btnTypeAdd_Click);
            // 
            // btnTypeEdit
            // 
            this.btnTypeEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeEdit.Location = new System.Drawing.Point(342, 708);
            this.btnTypeEdit.Name = "btnTypeEdit";
            this.btnTypeEdit.Size = new System.Drawing.Size(250, 40);
            this.btnTypeEdit.TabIndex = 131;
            this.btnTypeEdit.Text = "EDIT";
            this.btnTypeEdit.UseVisualStyleBackColor = true;
            this.btnTypeEdit.Click += new System.EventHandler(this.btnTypeEdit_Click);
            // 
            // txtTypeID
            // 
            this.txtTypeID.Enabled = false;
            this.txtTypeID.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeID.ForeColor = System.Drawing.Color.Black;
            this.txtTypeID.Location = new System.Drawing.Point(88, 638);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Size = new System.Drawing.Size(120, 36);
            this.txtTypeID.TabIndex = 133;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 28);
            this.label5.TabIndex = 134;
            this.label5.Text = "TYPE ID";
            // 
            // txtTypeName
            // 
            this.txtTypeName.Enabled = false;
            this.txtTypeName.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeName.ForeColor = System.Drawing.Color.Black;
            this.txtTypeName.Location = new System.Drawing.Point(229, 638);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(326, 36);
            this.txtTypeName.TabIndex = 135;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(575, 602);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 28);
            this.label7.TabIndex = 137;
            this.label7.Text = "RATE PER HOUR";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 602);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 28);
            this.label8.TabIndex = 136;
            this.label8.Text = "TYPE NAME:";
            // 
            // txtTypeRate
            // 
            this.txtTypeRate.Enabled = false;
            this.txtTypeRate.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeRate.ForeColor = System.Drawing.Color.Black;
            this.txtTypeRate.Location = new System.Drawing.Point(580, 638);
            this.txtTypeRate.Name = "txtTypeRate";
            this.txtTypeRate.Size = new System.Drawing.Size(315, 36);
            this.txtTypeRate.TabIndex = 136;
            // 
            // btnTypeSave
            // 
            this.btnTypeSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeSave.Location = new System.Drawing.Point(176, 764);
            this.btnTypeSave.Name = "btnTypeSave";
            this.btnTypeSave.Size = new System.Drawing.Size(250, 40);
            this.btnTypeSave.TabIndex = 140;
            this.btnTypeSave.Text = "SAVE";
            this.btnTypeSave.UseVisualStyleBackColor = true;
            this.btnTypeSave.Visible = false;
            this.btnTypeSave.Click += new System.EventHandler(this.btnTypeSave_Click);
            // 
            // btnTypeCancel
            // 
            this.btnTypeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeCancel.Location = new System.Drawing.Point(492, 764);
            this.btnTypeCancel.Name = "btnTypeCancel";
            this.btnTypeCancel.Size = new System.Drawing.Size(250, 40);
            this.btnTypeCancel.TabIndex = 141;
            this.btnTypeCancel.Text = "CANCEL";
            this.btnTypeCancel.UseVisualStyleBackColor = true;
            this.btnTypeCancel.Visible = false;
            this.btnTypeCancel.Click += new System.EventHandler(this.btnTypeCancel_Click);
            // 
            // cboBrandStatus
            // 
            this.cboBrandStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrandStatus.Enabled = false;
            this.cboBrandStatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cboBrandStatus.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBrandStatus.ForeColor = System.Drawing.Color.Black;
            this.cboBrandStatus.FormattingEnabled = true;
            this.cboBrandStatus.Items.AddRange(new object[] {
            "ACTIVE",
            "INACTIVE"});
            this.cboBrandStatus.Location = new System.Drawing.Point(754, 214);
            this.cboBrandStatus.Name = "cboBrandStatus";
            this.cboBrandStatus.Size = new System.Drawing.Size(141, 35);
            this.cboBrandStatus.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(749, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 144;
            this.label9.Text = "STATUS:";
            // 
            // btnBrandSave
            // 
            this.btnBrandSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrandSave.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrandSave.Location = new System.Drawing.Point(175, 333);
            this.btnBrandSave.Name = "btnBrandSave";
            this.btnBrandSave.Size = new System.Drawing.Size(250, 40);
            this.btnBrandSave.TabIndex = 147;
            this.btnBrandSave.Text = "SAVE";
            this.btnBrandSave.UseVisualStyleBackColor = true;
            this.btnBrandSave.Visible = false;
            this.btnBrandSave.Click += new System.EventHandler(this.btnBrandSave_Click);
            // 
            // btnBrandCancel
            // 
            this.btnBrandCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrandCancel.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrandCancel.Location = new System.Drawing.Point(491, 333);
            this.btnBrandCancel.Name = "btnBrandCancel";
            this.btnBrandCancel.Size = new System.Drawing.Size(250, 40);
            this.btnBrandCancel.TabIndex = 148;
            this.btnBrandCancel.Text = "CANCEL";
            this.btnBrandCancel.UseVisualStyleBackColor = true;
            this.btnBrandCancel.Visible = false;
            this.btnBrandCancel.Click += new System.EventHandler(this.btnBrandCancel_Click);
            // 
            // btnBrandAdd
            // 
            this.btnBrandAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrandAdd.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrandAdd.Location = new System.Drawing.Point(176, 278);
            this.btnBrandAdd.Name = "btnBrandAdd";
            this.btnBrandAdd.Size = new System.Drawing.Size(250, 40);
            this.btnBrandAdd.TabIndex = 145;
            this.btnBrandAdd.Text = "ADD";
            this.btnBrandAdd.UseVisualStyleBackColor = true;
            this.btnBrandAdd.Click += new System.EventHandler(this.btnBrandAdd_Click);
            // 
            // btnBrandEdit
            // 
            this.btnBrandEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrandEdit.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrandEdit.Location = new System.Drawing.Point(492, 278);
            this.btnBrandEdit.Name = "btnBrandEdit";
            this.btnBrandEdit.Size = new System.Drawing.Size(250, 40);
            this.btnBrandEdit.TabIndex = 146;
            this.btnBrandEdit.Text = "EDIT";
            this.btnBrandEdit.UseVisualStyleBackColor = true;
            this.btnBrandEdit.Click += new System.EventHandler(this.btnBrandEdit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(12, 404);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1800, 5);
            this.panel3.TabIndex = 130;
            // 
            // frmManageBrandTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1650, 825);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnBrandSave);
            this.Controls.Add(this.btnBrandCancel);
            this.Controls.Add(this.btnBrandAdd);
            this.Controls.Add(this.btnBrandEdit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboBrandStatus);
            this.Controls.Add(this.btnTypeSave);
            this.Controls.Add(this.btnTypeCancel);
            this.Controls.Add(this.txtTypeRate);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTypeAdd);
            this.Controls.Add(this.btnTypeEdit);
            this.Controls.Add(this.txtTypeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTypeName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboBrandCategory);
            this.Controls.Add(this.txtBrandID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwTypeData);
            this.Controls.Add(this.txtTypeSearch);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.lvwBrandData);
            this.Controls.Add(this.txtBrandSearch);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmManageBrandTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SETTINGS";
            this.Load += new System.EventHandler(this.frmManageBrandTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.ListView lvwBrandData;
        internal System.Windows.Forms.TextBox txtBrandSearch;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ListView lvwTypeData;
        internal System.Windows.Forms.TextBox txtTypeSearch;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtBrandName;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtBrandID;
        internal System.Windows.Forms.ComboBox cboBrandCategory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btnTypeAdd;
        internal System.Windows.Forms.Button btnTypeEdit;
        internal System.Windows.Forms.TextBox txtTypeID;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtTypeName;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.TextBox txtTypeRate;
        internal System.Windows.Forms.Button btnTypeSave;
        internal System.Windows.Forms.Button btnTypeCancel;
        internal System.Windows.Forms.ComboBox cboBrandStatus;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Button btnBrandSave;
        internal System.Windows.Forms.Button btnBrandCancel;
        internal System.Windows.Forms.Button btnBrandAdd;
        internal System.Windows.Forms.Button btnBrandEdit;
        private System.Windows.Forms.Panel panel3;

    }
}