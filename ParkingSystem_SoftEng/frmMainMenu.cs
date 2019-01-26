using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParkingSystem_SoftEng
{
    public partial class frmMainMenu : Form
    {
        public string currentUserID;

        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void tmrDATETIMECOUNTER_Tick(object sender, EventArgs e)
        {
            lblDATETIME.Text = DateTime.Now.ToString();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmTransaction transaction = new frmTransaction();
            transaction.currentUserID = this.currentUserID;
            transaction.TopLevel = false;
            transaction.Dock = DockStyle.Fill;
            transaction.Visible = true;
            pnlCONTROL.Controls.Add(transaction);
        }

        //ADMIN
        private void btnTransaction_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmTransaction transaction = new frmTransaction();
            transaction.currentUserID = this.currentUserID;
            transaction.TopLevel = false;
            transaction.Dock = DockStyle.Fill;
            transaction.Visible = true;
            pnlCONTROL.Controls.Add(transaction);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmPaymentMain paymentmain = new frmPaymentMain();
            paymentmain.currentUserID = this.currentUserID;
            paymentmain.TopLevel = false;
            paymentmain.Dock = DockStyle.Fill;
            paymentmain.Visible = true;
            pnlCONTROL.Controls.Add(paymentmain);
        }

        private void btnParkingMap_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmParkingSpaceMain parkingspace = new frmParkingSpaceMain();
            parkingspace.TopLevel = false;
            parkingspace.Dock = DockStyle.Fill;
            parkingspace.Visible = true;
            pnlCONTROL.Controls.Add(parkingspace);
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmManageUsers manageuser = new frmManageUsers();
            manageuser.TopLevel = false;
            manageuser.Dock = DockStyle.Fill;
            manageuser.Visible = true;
            pnlCONTROL.Controls.Add(manageuser);
        }

        private void btnOtherSettings_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmManageBrandTypes brandtypes = new frmManageBrandTypes();
            brandtypes.TopLevel = false;
            brandtypes.Dock = DockStyle.Fill;
            brandtypes.Visible = true;
            pnlCONTROL.Controls.Add(brandtypes);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmReports reports = new frmReports();
            reports.TopLevel = false;
            reports.Dock = DockStyle.Fill;
            reports.Visible = true;
            pnlCONTROL.Controls.Add(reports);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmAbout about = new frmAbout();
            about.TopLevel = false;
            about.Dock = DockStyle.Fill;
            about.Visible = true;
            pnlCONTROL.Controls.Add(about);
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }


        //GUEST
        private void btnTransactionGuest_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmTransaction transaction = new frmTransaction();
            transaction.currentUserID = this.currentUserID;
            transaction.TopLevel = false;
            transaction.Dock = DockStyle.Fill;
            transaction.Visible = true;
            pnlCONTROL.Controls.Add(transaction);
        }

        private void btnPaymentGuest_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmPaymentMain paymentmain = new frmPaymentMain();
            paymentmain.currentUserID = this.currentUserID;
            paymentmain.TopLevel = false;
            paymentmain.Dock = DockStyle.Fill;
            paymentmain.Visible = true;
            pnlCONTROL.Controls.Add(paymentmain);
        }

        private void btnParkingMapGuest_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmParkingSpaceMain parkingspace = new frmParkingSpaceMain();
            parkingspace.TopLevel = false;
            parkingspace.Dock = DockStyle.Fill;
            parkingspace.Visible = true;
            pnlCONTROL.Controls.Add(parkingspace);
        }

        private void btnAboutGuest_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmAbout about = new frmAbout();
            about.TopLevel = false;
            about.Dock = DockStyle.Fill;
            about.Visible = true;
            pnlCONTROL.Controls.Add(about);
        }

        private void btnMyAccountGuest_Click(object sender, EventArgs e)
        {
            pnlCONTROL.Controls.Clear();
            frmMyAccount myAccount = new frmMyAccount();
            myAccount.currentUserID = this.currentUserID;
            myAccount.TopLevel = false;
            myAccount.Dock = DockStyle.Fill;
            myAccount.Visible = true;
            pnlCONTROL.Controls.Add(myAccount);
        }

        private void btnSignOutGuest_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }

        

    }
}
