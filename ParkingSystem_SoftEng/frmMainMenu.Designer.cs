namespace ParkingSystem_SoftEng
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.tmrDATETIMECOUNTER = new System.Windows.Forms.Timer(this.components);
            this.btnParkingMap = new System.Windows.Forms.Button();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.tlpGUEST = new System.Windows.Forms.TableLayoutPanel();
            this.btnSignOutGuest = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.btnAboutGuest = new System.Windows.Forms.Button();
            this.btnMyAccountGuest = new System.Windows.Forms.Button();
            this.btnPaymentGuest = new System.Windows.Forms.Button();
            this.btnParkingMapGuest = new System.Windows.Forms.Button();
            this.btnTransactionGuest = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPayment = new System.Windows.Forms.Button();
            this.tlpADMIN = new System.Windows.Forms.TableLayoutPanel();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnOtherSettings = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.pnlCONTROL = new System.Windows.Forms.Panel();
            this.lblUSERLEVEL = new System.Windows.Forms.Label();
            this.tlpBODY2COL = new System.Windows.Forms.TableLayoutPanel();
            this.pnlNAVIGATOR = new System.Windows.Forms.Panel();
            this.tlpCONTROL = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFOOTER = new System.Windows.Forms.Panel();
            this.tlpFOOTER = new System.Windows.Forms.TableLayoutPanel();
            this.lblDATETIME = new System.Windows.Forms.Label();
            this.lblFOOTER = new System.Windows.Forms.Label();
            this.pnlHEADER = new System.Windows.Forms.Panel();
            this.tlpHEADER = new System.Windows.Forms.TableLayoutPanel();
            this.tlpMAIN2ROWS = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.tlpGUEST.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.tlpADMIN.SuspendLayout();
            this.pnlCONTROL.SuspendLayout();
            this.tlpBODY2COL.SuspendLayout();
            this.tlpCONTROL.SuspendLayout();
            this.pnlFOOTER.SuspendLayout();
            this.tlpFOOTER.SuspendLayout();
            this.pnlHEADER.SuspendLayout();
            this.tlpHEADER.SuspendLayout();
            this.tlpMAIN2ROWS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDATETIMECOUNTER
            // 
            this.tmrDATETIMECOUNTER.Enabled = true;
            this.tmrDATETIMECOUNTER.Tick += new System.EventHandler(this.tmrDATETIMECOUNTER_Tick);
            // 
            // btnParkingMap
            // 
            this.btnParkingMap.FlatAppearance.BorderSize = 0;
            this.btnParkingMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkingMap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkingMap.ForeColor = System.Drawing.Color.White;
            this.btnParkingMap.Location = new System.Drawing.Point(13, 403);
            this.btnParkingMap.Name = "btnParkingMap";
            this.btnParkingMap.Size = new System.Drawing.Size(188, 38);
            this.btnParkingMap.TabIndex = 2;
            this.btnParkingMap.Text = "PARKING MAP";
            this.btnParkingMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParkingMap.UseVisualStyleBackColor = true;
            this.btnParkingMap.Click += new System.EventHandler(this.btnParkingMap_Click);
            // 
            // PictureBox2
            // 
            this.PictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(13, 3);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(188, 218);
            this.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox2.TabIndex = 0;
            this.PictureBox2.TabStop = false;
            // 
            // tlpGUEST
            // 
            this.tlpGUEST.BackColor = System.Drawing.Color.Teal;
            this.tlpGUEST.ColumnCount = 3;
            this.tlpGUEST.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGUEST.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpGUEST.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGUEST.Controls.Add(this.PictureBox2, 1, 0);
            this.tlpGUEST.Controls.Add(this.btnSignOutGuest, 1, 9);
            this.tlpGUEST.Controls.Add(this.Panel2, 1, 8);
            this.tlpGUEST.Controls.Add(this.btnAboutGuest, 1, 6);
            this.tlpGUEST.Controls.Add(this.btnMyAccountGuest, 1, 5);
            this.tlpGUEST.Controls.Add(this.btnPaymentGuest, 1, 3);
            this.tlpGUEST.Controls.Add(this.btnParkingMapGuest, 1, 4);
            this.tlpGUEST.Controls.Add(this.btnTransactionGuest, 1, 2);
            this.tlpGUEST.ForeColor = System.Drawing.Color.White;
            this.tlpGUEST.Location = new System.Drawing.Point(366, 29);
            this.tlpGUEST.Name = "tlpGUEST";
            this.tlpGUEST.RowCount = 11;
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.821428F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.022321F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpGUEST.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tlpGUEST.Size = new System.Drawing.Size(216, 896);
            this.tlpGUEST.TabIndex = 1;
            // 
            // btnSignOutGuest
            // 
            this.btnSignOutGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignOutGuest.FlatAppearance.BorderSize = 0;
            this.btnSignOutGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOutGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOutGuest.ForeColor = System.Drawing.Color.White;
            this.btnSignOutGuest.Location = new System.Drawing.Point(13, 561);
            this.btnSignOutGuest.Name = "btnSignOutGuest";
            this.btnSignOutGuest.Size = new System.Drawing.Size(188, 38);
            this.btnSignOutGuest.TabIndex = 4;
            this.btnSignOutGuest.Text = "SIGN OUT";
            this.btnSignOutGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOutGuest.UseVisualStyleBackColor = true;
            this.btnSignOutGuest.Click += new System.EventHandler(this.btnSignOutGuest_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.White;
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel2.Location = new System.Drawing.Point(13, 553);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(188, 2);
            this.Panel2.TabIndex = 0;
            // 
            // btnAboutGuest
            // 
            this.btnAboutGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAboutGuest.FlatAppearance.BorderSize = 0;
            this.btnAboutGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutGuest.ForeColor = System.Drawing.Color.White;
            this.btnAboutGuest.Location = new System.Drawing.Point(13, 492);
            this.btnAboutGuest.Name = "btnAboutGuest";
            this.btnAboutGuest.Size = new System.Drawing.Size(188, 38);
            this.btnAboutGuest.TabIndex = 3;
            this.btnAboutGuest.Text = "ABOUT";
            this.btnAboutGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutGuest.UseVisualStyleBackColor = true;
            this.btnAboutGuest.Click += new System.EventHandler(this.btnAboutGuest_Click);
            // 
            // btnMyAccountGuest
            // 
            this.btnMyAccountGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMyAccountGuest.FlatAppearance.BorderSize = 0;
            this.btnMyAccountGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccountGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyAccountGuest.ForeColor = System.Drawing.Color.White;
            this.btnMyAccountGuest.Location = new System.Drawing.Point(13, 448);
            this.btnMyAccountGuest.Name = "btnMyAccountGuest";
            this.btnMyAccountGuest.Size = new System.Drawing.Size(188, 38);
            this.btnMyAccountGuest.TabIndex = 5;
            this.btnMyAccountGuest.Text = "MY ACCOUNT";
            this.btnMyAccountGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyAccountGuest.UseVisualStyleBackColor = true;
            this.btnMyAccountGuest.Click += new System.EventHandler(this.btnMyAccountGuest_Click);
            // 
            // btnPaymentGuest
            // 
            this.btnPaymentGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPaymentGuest.FlatAppearance.BorderSize = 0;
            this.btnPaymentGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaymentGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaymentGuest.ForeColor = System.Drawing.Color.White;
            this.btnPaymentGuest.Location = new System.Drawing.Point(13, 360);
            this.btnPaymentGuest.Name = "btnPaymentGuest";
            this.btnPaymentGuest.Size = new System.Drawing.Size(188, 38);
            this.btnPaymentGuest.TabIndex = 0;
            this.btnPaymentGuest.Text = "PAYMENT";
            this.btnPaymentGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaymentGuest.UseVisualStyleBackColor = true;
            this.btnPaymentGuest.Click += new System.EventHandler(this.btnPaymentGuest_Click);
            // 
            // btnParkingMapGuest
            // 
            this.btnParkingMapGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnParkingMapGuest.FlatAppearance.BorderSize = 0;
            this.btnParkingMapGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParkingMapGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkingMapGuest.ForeColor = System.Drawing.Color.White;
            this.btnParkingMapGuest.Location = new System.Drawing.Point(13, 404);
            this.btnParkingMapGuest.Name = "btnParkingMapGuest";
            this.btnParkingMapGuest.Size = new System.Drawing.Size(188, 38);
            this.btnParkingMapGuest.TabIndex = 2;
            this.btnParkingMapGuest.Text = "PARKING MAP";
            this.btnParkingMapGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnParkingMapGuest.UseVisualStyleBackColor = true;
            this.btnParkingMapGuest.Click += new System.EventHandler(this.btnParkingMapGuest_Click);
            // 
            // btnTransactionGuest
            // 
            this.btnTransactionGuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTransactionGuest.FlatAppearance.BorderSize = 0;
            this.btnTransactionGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransactionGuest.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransactionGuest.ForeColor = System.Drawing.Color.White;
            this.btnTransactionGuest.Location = new System.Drawing.Point(13, 315);
            this.btnTransactionGuest.Name = "btnTransactionGuest";
            this.btnTransactionGuest.Size = new System.Drawing.Size(188, 39);
            this.btnTransactionGuest.TabIndex = 6;
            this.btnTransactionGuest.Text = "TRANSACTION";
            this.btnTransactionGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransactionGuest.UseVisualStyleBackColor = true;
            this.btnTransactionGuest.Click += new System.EventHandler(this.btnTransactionGuest_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(13, 3);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(188, 218);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 0;
            this.PictureBox1.TabStop = false;
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.ForeColor = System.Drawing.Color.White;
            this.btnPayment.Location = new System.Drawing.Point(13, 359);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(188, 38);
            this.btnPayment.TabIndex = 1;
            this.btnPayment.Text = "PAYMENT";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // tlpADMIN
            // 
            this.tlpADMIN.BackColor = System.Drawing.Color.Teal;
            this.tlpADMIN.ColumnCount = 3;
            this.tlpADMIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpADMIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.Controls.Add(this.PictureBox1, 1, 0);
            this.tlpADMIN.Controls.Add(this.Panel1, 1, 11);
            this.tlpADMIN.Controls.Add(this.btnSignOut, 1, 12);
            this.tlpADMIN.Controls.Add(this.btnAbout, 1, 9);
            this.tlpADMIN.Controls.Add(this.btnReports, 1, 8);
            this.tlpADMIN.Controls.Add(this.btnOtherSettings, 1, 7);
            this.tlpADMIN.Controls.Add(this.btnUserSettings, 1, 6);
            this.tlpADMIN.Controls.Add(this.btnParkingMap, 1, 5);
            this.tlpADMIN.Controls.Add(this.btnPayment, 1, 4);
            this.tlpADMIN.Controls.Add(this.btnTransaction, 1, 3);
            this.tlpADMIN.ForeColor = System.Drawing.Color.White;
            this.tlpADMIN.Location = new System.Drawing.Point(101, 29);
            this.tlpADMIN.Name = "tlpADMIN";
            this.tlpADMIN.RowCount = 14;
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpADMIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tlpADMIN.Size = new System.Drawing.Size(216, 896);
            this.tlpADMIN.TabIndex = 0;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.White;
            this.Panel1.Location = new System.Drawing.Point(13, 640);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(188, 2);
            this.Panel1.TabIndex = 0;
            // 
            // btnSignOut
            // 
            this.btnSignOut.FlatAppearance.BorderSize = 0;
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignOut.ForeColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(13, 648);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(188, 38);
            this.btnSignOut.TabIndex = 4;
            this.btnSignOut.Text = "SIGN OUT";
            this.btnSignOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignOut.UseVisualStyleBackColor = true;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(13, 579);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(188, 38);
            this.btnAbout.TabIndex = 3;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(13, 535);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(188, 38);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "REPORTS";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnOtherSettings
            // 
            this.btnOtherSettings.FlatAppearance.BorderSize = 0;
            this.btnOtherSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOtherSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtherSettings.ForeColor = System.Drawing.Color.White;
            this.btnOtherSettings.Location = new System.Drawing.Point(13, 491);
            this.btnOtherSettings.Name = "btnOtherSettings";
            this.btnOtherSettings.Size = new System.Drawing.Size(188, 38);
            this.btnOtherSettings.TabIndex = 7;
            this.btnOtherSettings.Text = "OTHER SETTINGS";
            this.btnOtherSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOtherSettings.UseVisualStyleBackColor = true;
            this.btnOtherSettings.Click += new System.EventHandler(this.btnOtherSettings_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.FlatAppearance.BorderSize = 0;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserSettings.ForeColor = System.Drawing.Color.White;
            this.btnUserSettings.Location = new System.Drawing.Point(13, 447);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(188, 38);
            this.btnUserSettings.TabIndex = 5;
            this.btnUserSettings.Text = "USER SETTINGS";
            this.btnUserSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.UseVisualStyleBackColor = true;
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
            // 
            // btnTransaction
            // 
            this.btnTransaction.FlatAppearance.BorderSize = 0;
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Location = new System.Drawing.Point(13, 315);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(188, 38);
            this.btnTransaction.TabIndex = 0;
            this.btnTransaction.Text = "TRANSACTION";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.UseVisualStyleBackColor = true;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // pnlCONTROL
            // 
            this.pnlCONTROL.BackColor = System.Drawing.Color.White;
            this.pnlCONTROL.Controls.Add(this.tlpADMIN);
            this.pnlCONTROL.Controls.Add(this.tlpGUEST);
            this.pnlCONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCONTROL.ForeColor = System.Drawing.Color.White;
            this.pnlCONTROL.Location = new System.Drawing.Point(3, 3);
            this.pnlCONTROL.Name = "pnlCONTROL";
            this.pnlCONTROL.Size = new System.Drawing.Size(1636, 938);
            this.pnlCONTROL.TabIndex = 1;
            // 
            // lblUSERLEVEL
            // 
            this.lblUSERLEVEL.AutoSize = true;
            this.lblUSERLEVEL.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUSERLEVEL.ForeColor = System.Drawing.Color.White;
            this.lblUSERLEVEL.Location = new System.Drawing.Point(3, 13);
            this.lblUSERLEVEL.Name = "lblUSERLEVEL";
            this.lblUSERLEVEL.Size = new System.Drawing.Size(213, 26);
            this.lblUSERLEVEL.TabIndex = 0;
            this.lblUSERLEVEL.Text = "ADMINISTRATOR: ";
            this.lblUSERLEVEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlpBODY2COL
            // 
            this.tlpBODY2COL.BackColor = System.Drawing.Color.Teal;
            this.tlpBODY2COL.ColumnCount = 2;
            this.tlpBODY2COL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.09661F));
            this.tlpBODY2COL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.90339F));
            this.tlpBODY2COL.Controls.Add(this.pnlNAVIGATOR, 0, 0);
            this.tlpBODY2COL.Controls.Add(this.tlpCONTROL, 1, 0);
            this.tlpBODY2COL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBODY2COL.Location = new System.Drawing.Point(3, 52);
            this.tlpBODY2COL.Name = "tlpBODY2COL";
            this.tlpBODY2COL.RowCount = 1;
            this.tlpBODY2COL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBODY2COL.Size = new System.Drawing.Size(1918, 1000);
            this.tlpBODY2COL.TabIndex = 0;
            // 
            // pnlNAVIGATOR
            // 
            this.pnlNAVIGATOR.BackColor = System.Drawing.Color.White;
            this.pnlNAVIGATOR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNAVIGATOR.Location = new System.Drawing.Point(3, 3);
            this.pnlNAVIGATOR.Name = "pnlNAVIGATOR";
            this.pnlNAVIGATOR.Size = new System.Drawing.Size(264, 994);
            this.pnlNAVIGATOR.TabIndex = 0;
            // 
            // tlpCONTROL
            // 
            this.tlpCONTROL.BackColor = System.Drawing.Color.Azure;
            this.tlpCONTROL.ColumnCount = 1;
            this.tlpCONTROL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpCONTROL.Controls.Add(this.pnlFOOTER, 0, 1);
            this.tlpCONTROL.Controls.Add(this.pnlCONTROL, 0, 0);
            this.tlpCONTROL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCONTROL.Location = new System.Drawing.Point(273, 3);
            this.tlpCONTROL.Name = "tlpCONTROL";
            this.tlpCONTROL.RowCount = 2;
            this.tlpCONTROL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tlpCONTROL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpCONTROL.Size = new System.Drawing.Size(1642, 994);
            this.tlpCONTROL.TabIndex = 1;
            // 
            // pnlFOOTER
            // 
            this.pnlFOOTER.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlFOOTER.Controls.Add(this.tlpFOOTER);
            this.pnlFOOTER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFOOTER.Location = new System.Drawing.Point(3, 947);
            this.pnlFOOTER.Name = "pnlFOOTER";
            this.pnlFOOTER.Size = new System.Drawing.Size(1636, 44);
            this.pnlFOOTER.TabIndex = 0;
            // 
            // tlpFOOTER
            // 
            this.tlpFOOTER.BackColor = System.Drawing.Color.DimGray;
            this.tlpFOOTER.ColumnCount = 3;
            this.tlpFOOTER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpFOOTER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tlpFOOTER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tlpFOOTER.Controls.Add(this.lblDATETIME, 1, 1);
            this.tlpFOOTER.Controls.Add(this.lblFOOTER, 0, 1);
            this.tlpFOOTER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFOOTER.ForeColor = System.Drawing.Color.White;
            this.tlpFOOTER.Location = new System.Drawing.Point(0, 0);
            this.tlpFOOTER.Name = "tlpFOOTER";
            this.tlpFOOTER.RowCount = 3;
            this.tlpFOOTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFOOTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFOOTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFOOTER.Size = new System.Drawing.Size(1636, 44);
            this.tlpFOOTER.TabIndex = 0;
            // 
            // lblDATETIME
            // 
            this.lblDATETIME.AutoSize = true;
            this.lblDATETIME.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDATETIME.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDATETIME.Location = new System.Drawing.Point(1475, 11);
            this.lblDATETIME.Name = "lblDATETIME";
            this.lblDATETIME.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDATETIME.Size = new System.Drawing.Size(92, 22);
            this.lblDATETIME.TabIndex = 1;
            this.lblDATETIME.Text = "--/--/----";
            // 
            // lblFOOTER
            // 
            this.lblFOOTER.AutoSize = true;
            this.lblFOOTER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFOOTER.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFOOTER.Location = new System.Drawing.Point(3, 11);
            this.lblFOOTER.Name = "lblFOOTER";
            this.lblFOOTER.Size = new System.Drawing.Size(1139, 22);
            this.lblFOOTER.TabIndex = 1;
            this.lblFOOTER.Text = "PARKING SYSTEM © 2019 | CGC DEVELOPERS";
            // 
            // pnlHEADER
            // 
            this.pnlHEADER.BackColor = System.Drawing.Color.DarkGreen;
            this.pnlHEADER.Controls.Add(this.tlpHEADER);
            this.pnlHEADER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHEADER.ForeColor = System.Drawing.Color.White;
            this.pnlHEADER.Location = new System.Drawing.Point(3, 3);
            this.pnlHEADER.Name = "pnlHEADER";
            this.pnlHEADER.Size = new System.Drawing.Size(1918, 43);
            this.pnlHEADER.TabIndex = 1;
            // 
            // tlpHEADER
            // 
            this.tlpHEADER.BackColor = System.Drawing.Color.Teal;
            this.tlpHEADER.ColumnCount = 2;
            this.tlpHEADER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.58175F));
            this.tlpHEADER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.41825F));
            this.tlpHEADER.Controls.Add(this.lblUSERLEVEL, 0, 1);
            this.tlpHEADER.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpHEADER.Location = new System.Drawing.Point(0, 0);
            this.tlpHEADER.Name = "tlpHEADER";
            this.tlpHEADER.RowCount = 3;
            this.tlpHEADER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.tlpHEADER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tlpHEADER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpHEADER.Size = new System.Drawing.Size(1918, 43);
            this.tlpHEADER.TabIndex = 0;
            // 
            // tlpMAIN2ROWS
            // 
            this.tlpMAIN2ROWS.BackColor = System.Drawing.Color.Teal;
            this.tlpMAIN2ROWS.ColumnCount = 1;
            this.tlpMAIN2ROWS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMAIN2ROWS.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMAIN2ROWS.Controls.Add(this.tlpBODY2COL, 0, 1);
            this.tlpMAIN2ROWS.Controls.Add(this.pnlHEADER, 0, 0);
            this.tlpMAIN2ROWS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMAIN2ROWS.Location = new System.Drawing.Point(0, 0);
            this.tlpMAIN2ROWS.Name = "tlpMAIN2ROWS";
            this.tlpMAIN2ROWS.RowCount = 2;
            this.tlpMAIN2ROWS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.721931F));
            this.tlpMAIN2ROWS.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95.27807F));
            this.tlpMAIN2ROWS.Size = new System.Drawing.Size(1924, 1055);
            this.tlpMAIN2ROWS.TabIndex = 1;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.tlpMAIN2ROWS);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PARKING SYSTEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.tlpGUEST.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.tlpADMIN.ResumeLayout(false);
            this.pnlCONTROL.ResumeLayout(false);
            this.tlpBODY2COL.ResumeLayout(false);
            this.tlpCONTROL.ResumeLayout(false);
            this.pnlFOOTER.ResumeLayout(false);
            this.tlpFOOTER.ResumeLayout(false);
            this.tlpFOOTER.PerformLayout();
            this.pnlHEADER.ResumeLayout(false);
            this.tlpHEADER.ResumeLayout(false);
            this.tlpHEADER.PerformLayout();
            this.tlpMAIN2ROWS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Timer tmrDATETIMECOUNTER;
        internal System.Windows.Forms.Button btnParkingMap;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.TableLayoutPanel tlpGUEST;
        internal System.Windows.Forms.Button btnSignOutGuest;
        internal System.Windows.Forms.Panel Panel2;
        internal System.Windows.Forms.Button btnAboutGuest;
        internal System.Windows.Forms.Button btnMyAccountGuest;
        internal System.Windows.Forms.Button btnParkingMapGuest;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Button btnPayment;
        internal System.Windows.Forms.TableLayoutPanel tlpADMIN;
        internal System.Windows.Forms.Button btnTransaction;
        internal System.Windows.Forms.Button btnUserSettings;
        internal System.Windows.Forms.Button btnSignOut;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Button btnAbout;
        internal System.Windows.Forms.Button btnReports;
        internal System.Windows.Forms.Panel pnlCONTROL;
        internal System.Windows.Forms.Label lblUSERLEVEL;
        internal System.Windows.Forms.TableLayoutPanel tlpBODY2COL;
        internal System.Windows.Forms.Panel pnlNAVIGATOR;
        internal System.Windows.Forms.TableLayoutPanel tlpCONTROL;
        internal System.Windows.Forms.Panel pnlFOOTER;
        internal System.Windows.Forms.TableLayoutPanel tlpFOOTER;
        internal System.Windows.Forms.Label lblDATETIME;
        internal System.Windows.Forms.Label lblFOOTER;
        internal System.Windows.Forms.Panel pnlHEADER;
        internal System.Windows.Forms.TableLayoutPanel tlpHEADER;
        internal System.Windows.Forms.TableLayoutPanel tlpMAIN2ROWS;
        internal System.Windows.Forms.Button btnPaymentGuest;
        internal System.Windows.Forms.Button btnTransactionGuest;
        internal System.Windows.Forms.Button btnOtherSettings;
    }
}