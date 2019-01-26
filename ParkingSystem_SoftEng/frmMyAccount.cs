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
    public partial class frmMyAccount : Form
    {
        public string currentUserID;

        public frmMyAccount()
        {
            InitializeComponent();
        }

        private void frmMyAccount_Load(object sender, EventArgs e)
        {
            DisableTextBox();
            Users_Load_UserDefine();
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {

            if (txtPassword.PasswordChar == '*' || txtRetypePass.PasswordChar == '*')
            {
                txtPassword.PasswordChar = '\0';
                txtRetypePass.PasswordChar = '\0';
                btnViewPass.Text = "HIDE";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtRetypePass.PasswordChar = '*';
                btnViewPass.Text = "VIEW";
            }
        }

        public void Users_Load_UserDefine()
        {
            classConnection loginCredential = new classConnection();
            try
            {
                UserData[] myCredential = loginCredential.readUser_byID(currentUserID).ToArray();
                txtUsername.Text = myCredential[0].userUsername;
                txtPassword.Text = myCredential[0].userPassword;
                txtRetypePass.Text = myCredential[0].userPassword;
                txtFirstname.Text = myCredential[0].userFname;
                txtLastname.Text = myCredential[0].userLname;
            }
            catch
            {

            }
        }

        public void EnableTextBox()
        {
            txtFirstname.Enabled = true;
            txtLastname.Enabled = true;
            txtPassword.Enabled = true;
            txtRetypePass.Enabled = true;
            txtUsername.Enabled = true;
        }

        public void DisableTextBox()
        {
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;
            txtPassword.Enabled = false;
            txtRetypePass.Enabled = false;
            txtUsername.Enabled = false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (btnChange.Text == "CHANGE")
            {
                btnChange.Text = "SAVE";
                btnCancel.Visible = true;
                EnableTextBox();
            }
            else if (btnChange.Text == "SAVE")
            {

                if (txtPassword.Text == txtRetypePass.Text)
                {
                    if (txtFirstname.Text == "" || txtLastname.Text == "" || txtPassword.Text == "" || txtRetypePass.Text == "" || txtUsername.Text == "")
                    {
                        MessageBox.Show("Complete all the required fields!");
                    }
                    else
                    {
                        classConnection connect = new classConnection();

                        UserData myCredential = new UserData();
                        myCredential.userID = this.currentUserID;
                        myCredential.userFname = txtFirstname.Text;
                        myCredential.userLname = txtLastname.Text;
                        myCredential.userPassword = txtPassword.Text;
                        myCredential.userUsername = txtUsername.Text;
                        if (connect.updateUser(myCredential))
                        {
                            MessageBox.Show("Successfully Saved!");
                            DisableTextBox();
                            btnCancel.Visible = false;
                            btnChange.Text = "CHANGE";
                        }
                        else
                        {
                            MessageBox.Show("Failed!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Password Mismatch!");
                }

                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DisableTextBox();
            Users_Load_UserDefine();
            btnCancel.Visible = false;
            btnChange.Text = "CHANGE";
        }
    }
}
