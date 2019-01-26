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

    public partial class frmManageBrandTypes : Form
    {

        classConnection connect = new classConnection();
        public string brandActionIdentifier;
        public string typeActionIdentifier;
        public VehicleType[] currentDataType;

        public frmManageBrandTypes()
        {
            InitializeComponent();
        }

        private void frmManageBrandTypes_Load(object sender, EventArgs e)
        {
            LoadTypesRates();
            LoadBrands();
        }

        private void btnTypeAdd_Click(object sender, EventArgs e)
        {
            this.typeActionIdentifier = "ADD";
            txtTypeID.Text = "AUTO-GENERATED";
            txtTypeName.Clear();
            txtTypeRate.Clear();

            txtTypeName.Enabled = true;
            txtTypeRate.Enabled = true;

            btnTypeAdd.Enabled = false;
            btnTypeEdit.Enabled = false;

            btnTypeSave.Visible = true;
            btnTypeCancel.Visible = true;
        }

        private void btnTypeEdit_Click(object sender, EventArgs e)
        {
            if (txtTypeID.Text == "" || txtTypeName.Text == "" || txtTypeRate.Text == "")
            {
                MessageBox.Show("Please select data to edit!");
            }
            else
            {
                this.typeActionIdentifier = "EDIT";

                txtTypeName.Enabled = true;
                txtTypeRate.Enabled = true;

                btnTypeAdd.Enabled = false;
                btnTypeEdit.Enabled = false;

                btnTypeSave.Visible = true;
                btnTypeCancel.Visible = true;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Direct Delete
        }

        private void btnTypeSave_Click(object sender, EventArgs e)
        {

            if (this.typeActionIdentifier == "ADD")
            {
                if (txtTypeName.Text != "" && txtTypeRate.Text != "" && Convert.ToDouble(txtTypeRate.Text) > 0)
                {
                    VehicleType data = new VehicleType();
                    data.typeName = txtTypeName.Text;
                    data.typeRatePerHour = txtTypeRate.Text;
                    if (connect.createTypeRates(data))
                    {
                        MessageBox.Show("Saved Successfully!");
                        clearTypeFields();
                        LoadTypesRates();
                    }
                    else
                    {
                        MessageBox.Show("Error Saving!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Complete All Required Fields!");
                }
            }
            else if (this.typeActionIdentifier == "EDIT")
            {
                if (txtTypeName.Text != "" && txtTypeRate.Text != "" && Convert.ToDouble(txtTypeRate.Text) > 0)
                {
                    VehicleType data = new VehicleType();
                    data.typeID = txtTypeID.Text;
                    data.typeName = txtTypeName.Text;
                    data.typeRatePerHour = txtTypeRate.Text;
                    if (connect.updateTypeRates(data))
                    {
                        MessageBox.Show("Updated Successfully!");
                        clearTypeFields();
                        LoadTypesRates();
                    }
                    else
                    {
                        MessageBox.Show("Error Saving!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Complete All Required Fields!");
                }
            }

            
        }

        private void btnTypeCancel_Click(object sender, EventArgs e)
        {
            clearTypeFields();
        }

        public void clearTypeFields()
        {
            txtTypeID.Clear();
            txtTypeName.Clear();
            txtTypeRate.Clear();

            txtTypeName.Enabled = false;
            txtTypeRate.Enabled = false;

            btnTypeAdd.Enabled = true;
            btnTypeEdit.Enabled = true;

            btnTypeSave.Visible = false;
            btnTypeCancel.Visible = false;
        }

        public void Record_LoadHeader_TypeRates()
        {
            lvwTypeData.FullRowSelect = true;
            lvwTypeData.MultiSelect = false;
            lvwTypeData.View = View.Details;
            lvwTypeData.Columns.Clear();
            lvwTypeData.Items.Clear();
            lvwTypeData.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lvwTypeData.Columns.Add("TYPE NAME", 250, HorizontalAlignment.Left);
            lvwTypeData.Columns.Add("RATE PER HOUR", 250, HorizontalAlignment.Left);
        }

        public void LoadTypesRates()
        {
            Record_LoadHeader_TypeRates();

            try
            {
                VehicleType[] types = connect.readTypeRates_all().ToArray();
                currentDataType = types;
                foreach (var type in types)
                {
                    ListViewItem lv = new ListViewItem(type.typeID);
                    lv.SubItems.Add(type.typeName);
                    lv.SubItems.Add(type.typeRatePerHour);
                    lvwTypeData.Items.Add(lv);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ooop! Something went wrong. Please try again.");
            }

        }

        private void txtTypeSearch_TextChanged(object sender, EventArgs e)
        {
            SearchTypeRates();
        }

        public void SearchTypeRates()
        {
            Record_LoadHeader_TypeRates();
            try
            {
                VehicleType[] types = connect.searchTypeRates_all(txtTypeSearch.Text).ToArray();
                foreach (var type in types)
                {
                    ListViewItem lv = new ListViewItem(type.typeID);
                    lv.SubItems.Add(type.typeName);
                    lv.SubItems.Add(type.typeRatePerHour);
                    lvwTypeData.Items.Add(lv);
                }
            }
            catch
            {
                MessageBox.Show("Ooop! No Data Found.");
            }
        }

        private void lvwTypeData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvwTypeData.SelectedItems.Count == 1)
            {
                txtTypeID.Text = this.lvwTypeData.SelectedItems[0].SubItems[0].Text;
                txtTypeName.Text = this.lvwTypeData.SelectedItems[0].SubItems[1].Text;
                txtTypeRate.Text = this.lvwTypeData.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void lvwTypeData_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvwTypeData.SelectedItems.Count == 1)
            {
                txtTypeID.Text = this.lvwTypeData.SelectedItems[0].SubItems[0].Text;
                txtTypeName.Text = this.lvwTypeData.SelectedItems[0].SubItems[1].Text;
                txtTypeRate.Text = this.lvwTypeData.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnBrandAdd_Click(object sender, EventArgs e)
        {
            this.brandActionIdentifier = "ADD";
            txtBrandID.Text = "AUTO-GENERATED";

            txtBrandName.Clear();
            cboBrandCategory.Items.Clear();
            cboBrandStatus.Items.Clear();

            cboBrandStatus.Items.Add("ACTIVE");
            cboBrandStatus.Items.Add("INACTIVE");

            PopulateCategories();

            txtBrandName.Enabled = true;
            cboBrandCategory.Enabled = true;
            cboBrandStatus.Enabled = true;

            btnBrandAdd.Enabled = false;
            btnBrandEdit.Enabled = false;

            btnBrandSave.Visible = true;
            btnBrandCancel.Visible = true;

        }

        private void btnBrandEdit_Click(object sender, EventArgs e)
        {

            if (txtBrandID.Text == "" || txtBrandName.Text == "" || cboBrandStatus.Text == "")
            {
                MessageBox.Show("Please select data to edit!");
            }
            else
            {
                this.brandActionIdentifier = "EDIT";

                PopulateCategories();

                txtBrandName.Enabled = true;
                cboBrandCategory.Enabled = true;
                cboBrandStatus.Enabled = true;

                btnBrandAdd.Enabled = false;
                btnBrandEdit.Enabled = false;

                btnBrandSave.Visible = true;
                btnBrandCancel.Visible = true;
            }
        }

        private void btnBrandDelete_Click(object sender, EventArgs e)
        {
            //Direct Delete
        }

        private void btnBrandSave_Click(object sender, EventArgs e)
        {
            if (this.brandActionIdentifier == "ADD")
            {
                if (txtBrandID.Text != "" && txtBrandName.Text != "" && cboBrandCategory.Text != "" && cboBrandStatus.Text != "")
                {
                    VehicleBrand data = new VehicleBrand();
                    data.brandName = txtBrandName.Text;
                    data.brandStatus = cboBrandStatus.Text;

                    foreach (var type in currentDataType)
                    {
                        //Find Same Type Name
                        if (cboBrandCategory.Text == type.typeName)
                        {
                            data.brandCategory = type.typeID;
                            break;
                        }
                    }

                    
                    if (connect.createBrands(data))
                    {
                        MessageBox.Show("Saved Successfully!");
                        clearBrandFields();
                        LoadBrands();
                    }
                    else
                    {
                        MessageBox.Show("Error Saving!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Complete All Required Fields!");
                }
            }
            else if (this.brandActionIdentifier == "EDIT")
            {
                if (txtBrandID.Text != "" && txtBrandName.Text != "" && cboBrandCategory.Text != "" && cboBrandStatus.Text != "")
                {
                     VehicleBrand data = new VehicleBrand();
                    data.brandID = txtBrandID.Text;
                    data.brandName = txtBrandName.Text;
                    data.brandStatus = cboBrandStatus.Text;

                    foreach (var type in currentDataType)
                    {
                        //Find Same Type Name
                        if (cboBrandCategory.Text == type.typeName)
                        {
                            data.brandCategory = type.typeID;
                            break;
                        }
                    }

                    if (connect.updateBrands(data))
                    {
                        MessageBox.Show("Updated Successfully!");
                        clearBrandFields();
                        LoadBrands();
                    }
                    else
                    {
                        MessageBox.Show("Error Saving!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Complete All Required Fields!");
                }
            }
        }

        private void btnBrandCancel_Click(object sender, EventArgs e)
        {
            clearBrandFields();
        }

        public void clearBrandFields()
        {
            
            txtBrandID.Clear();
            txtBrandName.Clear();
            cboBrandCategory.Items.Clear();
            cboBrandStatus.Items.Clear();

            cboBrandStatus.Items.Add("ACTIVE");
            cboBrandStatus.Items.Add("INACTIVE");

            cboBrandCategory.Items.Add("4 WHEELS");

            txtBrandName.Enabled = false;
            cboBrandCategory.Enabled = false;
            cboBrandStatus.Enabled = false;

            btnBrandAdd.Enabled = true;
            btnBrandEdit.Enabled = true;

            btnBrandSave.Visible = false;
            btnBrandCancel.Visible = false;
        }

        public void Record_LoadHeader_Brands()
        {

            lvwBrandData.FullRowSelect = true;
            lvwBrandData.MultiSelect = false;
            lvwBrandData.View = View.Details;
            lvwBrandData.Columns.Clear();
            lvwBrandData.Items.Clear();
            lvwBrandData.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lvwBrandData.Columns.Add("BRAND", 250, HorizontalAlignment.Left);
            lvwBrandData.Columns.Add("CATEGORY", 250, HorizontalAlignment.Left);
            lvwBrandData.Columns.Add("STATUS", 250, HorizontalAlignment.Left);
        }

        public void LoadBrands()
        {
            Record_LoadHeader_Brands();

            try
            {
                VehicleBrand[] brands = connect.readBrands_all().ToArray();
                foreach (var brand in brands)
                {
                    ListViewItem lv = new ListViewItem(brand.brandID);
                    lv.SubItems.Add(brand.brandName);

                    foreach (var type in currentDataType)
                    {
                        //Find Same Type Name
                        if (brand.brandCategory == type.typeID)
                        {
                            brand.brandCategory = type.typeName;
                            break;
                        }
                    }

                    lv.SubItems.Add(brand.brandCategory);
                    lv.SubItems.Add(brand.brandStatus);
                    lvwBrandData.Items.Add(lv);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ooop! Something went wrong. Please try again.");
            }

        }

        private void lvwBrandData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvwBrandData.SelectedItems.Count == 1)
            {
                
                txtBrandID.Text = this.lvwBrandData.SelectedItems[0].SubItems[0].Text;
                txtBrandName.Text = this.lvwBrandData.SelectedItems[0].SubItems[1].Text;
                cboBrandCategory.Text = this.lvwBrandData.SelectedItems[0].SubItems[2].Text;
                cboBrandStatus.Text = this.lvwBrandData.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void lvwBrandData_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvwBrandData.SelectedItems.Count == 1)
            {

                txtBrandID.Text = this.lvwBrandData.SelectedItems[0].SubItems[0].Text;
                txtBrandName.Text = this.lvwBrandData.SelectedItems[0].SubItems[1].Text;
                cboBrandCategory.Text = this.lvwBrandData.SelectedItems[0].SubItems[2].Text;
                cboBrandStatus.Text = this.lvwBrandData.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void txtBrandSearch_TextChanged(object sender, EventArgs e)
        {
            SearchBrands();
        }

        public void SearchBrands()
        {
            Record_LoadHeader_Brands();
            try
            {
                VehicleBrand[] brands = connect.searchBrands_all(txtBrandSearch.Text).ToArray();
                foreach (var brand in brands)
                {
                    ListViewItem lv = new ListViewItem(brand.brandID);
                    lv.SubItems.Add(brand.brandName);
                    lv.SubItems.Add(brand.brandCategory);
                    lv.SubItems.Add(brand.brandStatus);
                    lvwBrandData.Items.Add(lv);
                }
            }
            catch
            {
                MessageBox.Show("Ooop! No Data Found.");
            }
        }

        public void PopulateCategories()
        {

             try
            {
                cboBrandCategory.Items.Clear();
                VehicleType[] types = connect.readTypeRates_all().ToArray();
                currentDataType = types;
                foreach (var type in types)
                {
                    
                    cboBrandCategory.Items.Add(type.typeName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ooop! Something went wrong. Please try again.");
            }

        }

       
    }
}
