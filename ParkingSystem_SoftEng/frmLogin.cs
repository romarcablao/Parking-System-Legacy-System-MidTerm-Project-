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
    public partial class frmLogin : Form
    {

        int logErrorCount = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void tmrDATETIMECOUNTER_Tick(object sender, EventArgs e)
        {
            lblDATETIME.Text = DateTime.Now.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Focus();
                logErrorCount += 1;
                MessageBox.Show("Please enter valid username!\n" + (3 - logErrorCount).ToString() + " attempts left.", "Invalid Credential");
            }else if(txtPass.Text == "")
            {
                txtPass.Focus();
                logErrorCount += 1;
                MessageBox.Show("Please enter valid password!\n" + (3 - logErrorCount).ToString() + " attempts left.", "Invalid Credential");
            }
            else if (txtUsername.Text != "" && txtPass.Text != "")
            {
                login_user();
            }

            if (logErrorCount >= 3) { Application.Exit(); }

        }

        public void login_user()
        {
            classConnection dbaseConnect = new classConnection();

            try
            {
                UserData[] loginCredential = dbaseConnect.login(txtUsername.Text, txtPass.Text).ToArray();

                
                if (loginCredential[0].userAccLevel.ToString() == "ADMIN")
                {
                    frmMainMenu mainmenu = new frmMainMenu();

                    mainmenu.tlpGUEST.Enabled = false;
                    mainmenu.tlpGUEST.Visible = false;

                    mainmenu.tlpADMIN.Enabled = true;
                    mainmenu.tlpADMIN.Visible = true;

                    mainmenu.tlpADMIN.Dock = DockStyle.Fill;
                    mainmenu.pnlNAVIGATOR.Controls.Add(mainmenu.tlpADMIN);

                    mainmenu.lblUSERLEVEL.Text = "ADMINISTRATOR: " + loginCredential[0].userFname.ToString().ToUpper() + " " + loginCredential[0].userLname.ToString().ToUpper();
                    mainmenu.currentUserID = loginCredential[0].userID.ToString();
                    mainmenu.Show();

                    this.Hide();
                }
                else
                {
                    frmMainMenu mainmenu = new frmMainMenu();

                    mainmenu.tlpGUEST.Enabled = true;
                    mainmenu.tlpGUEST.Visible = true;

                    mainmenu.tlpADMIN.Enabled = false;
                    mainmenu.tlpADMIN.Visible = false;

                    mainmenu.tlpGUEST.Dock = DockStyle.Fill;
                    mainmenu.pnlNAVIGATOR.Controls.Add(mainmenu.tlpGUEST);

                    mainmenu.lblUSERLEVEL.Text = "GUEST: " + loginCredential[0].userFname.ToString().ToUpper() + " " + loginCredential[0].userLname.ToString().ToUpper();
                    mainmenu.currentUserID = loginCredential[0].userID.ToString();
                    mainmenu.Show();

                    this.Hide();
                }

            }
            catch
            {
                logErrorCount += 1;
                MessageBox.Show("No data found!\n" + (3 - logErrorCount).ToString() + " attempts left.", "Invalid Credential");
            }

            if (logErrorCount >= 3) { Application.Exit(); }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
