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
    public partial class frmManageUsers : Form
    {
        public string selectedID;
        public string AddEdit_Identifier;
        classConnection connect = new classConnection();

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        public void LoadUsers()
        {
            Record_LoadHeader();
            
            try
            {
                UserData[] users = connect.readUser_all().ToArray();
                foreach (var person in users)
                {
                    ListViewItem lv = new ListViewItem(person.userID);
                    lv.SubItems.Add(person.userLname);
                    lv.SubItems.Add(person.userFname);
                    lv.SubItems.Add(person.userUsername);
                    lv.SubItems.Add(person.userPassword);
                    lv.SubItems.Add(person.userAccLevel);
                    person.userStatus = (person.userStatus == "1" ? "ACTIVE" : "INACTIVE");
                    lv.SubItems.Add(person.userStatus);
                    lvwUSERS.Items.Add(lv);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ooop! Something went wrong. Please try again.");
            }

        }

        public void Record_LoadHeader()
        {
            lvwUSERS.FullRowSelect = true;
            lvwUSERS.MultiSelect = false;
            lvwUSERS.View = View.Details;
            lvwUSERS.Columns.Clear();
            lvwUSERS.Items.Clear();
            lvwUSERS.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lvwUSERS.Columns.Add("LASTNAME", 250, HorizontalAlignment.Left);
            lvwUSERS.Columns.Add("FIRSTNAME", 250, HorizontalAlignment.Left);
            lvwUSERS.Columns.Add("USERNAME", 250, HorizontalAlignment.Left);
            lvwUSERS.Columns.Add("PASSWORD", 0, HorizontalAlignment.Left);
            lvwUSERS.Columns.Add("ACCOUNT LEVEL", 150, HorizontalAlignment.Left);
            lvwUSERS.Columns.Add("ACCOUNT STATUS", 150, HorizontalAlignment.Left);

        }

        private void txtSEARCH_TextChanged(object sender, EventArgs e)
        {
            SearchUsers();
        }

        public void SearchUsers()
        {
            Record_LoadHeader();
            try
            {
                UserData[] users = connect.searchUser_all(txtSEARCH.Text).ToArray();
                foreach (var person in users)
                {
                    ListViewItem lv = new ListViewItem(person.userID);
                    lv.SubItems.Add(person.userLname);
                    lv.SubItems.Add(person.userFname);
                    lv.SubItems.Add(person.userUsername);
                    lv.SubItems.Add(person.userPassword);
                    lv.SubItems.Add(person.userAccLevel);
                    person.userStatus = (person.userStatus == "1" ? "ACTIVE" : "INACTIVE");
                    lv.SubItems.Add(person.userStatus);
                    lvwUSERS.Items.Add(lv);
                }
            }
            catch
            {
                MessageBox.Show("Ooop! No Data Found.");
            }   
        }

        private void lvwUSERS_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(this.lvwUSERS.SelectedItems.Count == 1){
                selectedID = this.lvwUSERS.SelectedItems[0].SubItems[0].Text;
                txtUID.Text = this.lvwUSERS.SelectedItems[0].SubItems[0].Text;

                txtFNAME.Text = this.lvwUSERS.SelectedItems[0].SubItems[2].Text;
                txtLNAME.Text = this.lvwUSERS.SelectedItems[0].SubItems[1].Text;
                txtUNAME.Text = this.lvwUSERS.SelectedItems[0].SubItems[3].Text;
                txtPASS.Text = this.lvwUSERS.SelectedItems[0].SubItems[4].Text;
                cboLEVEL.Text = this.lvwUSERS.SelectedItems[0].SubItems[5].Text;
                cboSTATUS.Text = this.lvwUSERS.SelectedItems[0].SubItems[6].Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearData();
            lvwUSERS.Enabled = false;

            pnlDATAHOLDER.Enabled = true;

            pnlADDEDITDEL.Visible = false;
            pnlADDEDITDEL.Enabled = false;

            pnlSAVECLEARCANCEL.Visible = true;
            pnlSAVECLEARCANCEL.Enabled = true;

            this.AddEdit_Identifier = "ADD";
            txtUID.Text = "AUTO GENERATED";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if(selectedID == ""){
                MessageBox.Show("PLEASE SELECT A DATA TO EDIT!");
            }else{
                pnlDATAHOLDER.Enabled = true;

                pnlADDEDITDEL.Visible = false;
                pnlADDEDITDEL.Enabled = false;

                pnlSAVECLEARCANCEL.Visible = true;
                pnlSAVECLEARCANCEL.Enabled = true;

                this.AddEdit_Identifier = "EDIT";
            }

        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

        }

        public void clearField()
        {
            //txtUID.Clear();
            txtFNAME.Clear();
            txtLNAME.Clear();
            txtPASS.Clear();

            cboLEVEL.Items.Clear();
            cboLEVEL.Items.Add("GUEST");
            cboLEVEL.Items.Add("ADMIN");

            cboSTATUS.Items.Clear();
            cboSTATUS.Items.Add("ACTIVE");
            cboSTATUS.Items.Add("INACTIVE");

            txtUNAME.Clear();
        }

        public void ClearData()
        {
            lvwUSERS.Enabled = true;

            selectedID = "";
            txtUID.Clear();
            txtFNAME.Clear();
            txtLNAME.Clear();
            txtPASS.Clear();
            txtUID.Clear();

            cboLEVEL.Items.Clear();
            cboLEVEL.Items.Add("GUEST");
            cboLEVEL.Items.Add("ADMIN");

            cboSTATUS.Items.Clear();
            cboSTATUS.Items.Add("ACTIVE");
            cboSTATUS.Items.Add("INACTIVE");

            txtUNAME.Clear();

            pnlDATAHOLDER.Enabled = false;

            pnlADDEDITDEL.Visible = true;
            pnlADDEDITDEL.Enabled = true;

            pnlSAVECLEARCANCEL.Visible = false;
            pnlSAVECLEARCANCEL.Enabled = false;
        }

        private void btnSAVE_Click_1(object sender, EventArgs e)
        {
            if (this.AddEdit_Identifier == "ADD")
            {
                if (this.txtFNAME.Text == "" || this.txtLNAME.Text == "" || this.txtPASS.Text == "" || this.txtUNAME.Text == "" || this.cboLEVEL.Text == "" || this.cboSTATUS.Text == "")
                {
                    MessageBox.Show("Complete all the required fields!");
                }
                else
                {
                    //ADD
                    UserData dataToSave = new UserData();
                    dataToSave.userLname = txtLNAME.Text;
                    dataToSave.userFname = txtFNAME.Text;
                    dataToSave.userUsername = txtUNAME.Text;
                    dataToSave.userPassword = txtPASS.Text;
                    dataToSave.userAccLevel = cboLEVEL.Text;
                    dataToSave.userStatus = (cboSTATUS.Text == "ACTIVE" ? "1" : "0");

                    if (connect.createUser(dataToSave))
                    {
                        MessageBox.Show("Saved Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                    }

                    LoadUsers();
                    ClearData();

                    pnlDATAHOLDER.Enabled = false;

                    pnlADDEDITDEL.Visible = true;
                    pnlADDEDITDEL.Enabled = true;

                    pnlSAVECLEARCANCEL.Visible = false;
                    pnlSAVECLEARCANCEL.Enabled = false;

                }

            }
            else if (this.AddEdit_Identifier == "EDIT")
            {
                if (this.txtFNAME.Text == "" || this.txtLNAME.Text == "" || this.txtPASS.Text == "" || this.txtUNAME.Text == "" || this.cboLEVEL.Text == "" || this.cboSTATUS.Text == "")
                {
                    MessageBox.Show("Complete all the required fields!");
                }
                else
                {
                    //EDIT
                    UserData dataToSave = new UserData();
                    dataToSave.userID = txtUID.Text;
                    dataToSave.userLname = txtLNAME.Text;
                    dataToSave.userFname = txtFNAME.Text;
                    dataToSave.userUsername = txtUNAME.Text;
                    dataToSave.userPassword = txtPASS.Text;
                    dataToSave.userAccLevel = cboLEVEL.Text;
                    dataToSave.userStatus = (cboSTATUS.Text == "ACTIVE" ? "1" : "0");

                    if (connect.updateUser(dataToSave))
                    {
                        MessageBox.Show("Saved Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed!");
                    }

                    LoadUsers();
                    ClearData();

                    pnlDATAHOLDER.Enabled = false;

                    pnlADDEDITDEL.Visible = true;
                    pnlADDEDITDEL.Enabled = true;

                    pnlSAVECLEARCANCEL.Visible = false;
                    pnlSAVECLEARCANCEL.Enabled = false;

                }
            }

        }

        private void btnCLEAR_Click_1(object sender, EventArgs e)
        {
            if (this.AddEdit_Identifier == "ADD")
            {
                clearField();
                txtUID.Text = "AUTO GENERATED";
            }
            else
            {
                clearField();
            }
        }

        private void btnCANCEL_Click_1(object sender, EventArgs e)
        {
           
            ClearData();
            this.AddEdit_Identifier = "";

            pnlDATAHOLDER.Enabled = false;

            pnlADDEDITDEL.Visible = true;
            pnlADDEDITDEL.Enabled = true;

            pnlSAVECLEARCANCEL.Visible = false;
            pnlSAVECLEARCANCEL.Enabled = false;

        }

        private void txtUNAME_Leave(object sender, EventArgs e)
        {

            if (!connect.countUser_byUsername(txtUNAME.Text, txtUID.Text))
            {
                MessageBox.Show("This username is already used!");
                txtUNAME.Clear();
            }
        }

    }
}
