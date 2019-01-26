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
    public partial class frmTransaction : Form
    {
        classConnection connect = new classConnection();
        public string currentUserID;
        public string selectedParkingID;
        public string generatedCode;

        public VehicleType[] currentDataType;
        public VehicleBrand[] currentDataBrand;

        public frmTransaction()
        {
            InitializeComponent();
        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            if (txtCustomer.Text != "" && txtParkingBlock.Text != "" && txtParkingNo.Text != "" && txtRatePerHour.Text != "" && txtVehicleColor.Text != "" && txtVehiclePlateNo.Text != "" && txtVehicleType.Text != "" && cboVehicleBrand.Text != "")
            {
                receiptRefCreate();
                frmBarcodePrint barcodeprint = new frmBarcodePrint();
                barcodeprint.generatedCode = generatedCode;
                barcodeprint.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Please complete the required fields!");
            }
        }

        public void receiptRefCreate()
        {
            VehicleInfo info = new VehicleInfo();
            info.vehicleOwner = txtCustomer.Text;
            info.vehiclePlateNo = txtVehiclePlateNo.Text;

            foreach(var brandRef in currentDataBrand){
                if (brandRef.brandName == cboVehicleBrand.Text)
                {
                    info.vehicleBrand = brandRef.brandID;
                    break;
                }
            }

            info.vehicleColor = txtVehicleColor.Text;

            if (connect.createVehicleInfo(info))
            {
                string lastInsertedID = connect.lastInsertedVehicleInfo();

                GenerateCode();

                ReceiptReference receiptRef = new ReceiptReference();
                receiptRef.refBarcode = generatedCode;
                receiptRef.refPersonnelIn = this.currentUserID;
                receiptRef.refVehicleID = lastInsertedID;
                receiptRef.refParkingID = (Convert.ToInt32(selectedParkingID) - 100).ToString();

                ParkingSlot dataToPass = new ParkingSlot();
                dataToPass.slotIsAvailable = "0";
                dataToPass.slotID = (Convert.ToInt32(selectedParkingID) - 100).ToString();
                connect.updateParkingSpace(dataToPass);

                if (connect.createReceiptReference(receiptRef))
                {
                    clearTransactionData();
                    //MessageBox.Show("Successfully Generated!");
                }
            }
        }

        public void clearTransactionData()
        {
            txtCustomer.Clear();
            txtParkingBlock.Clear();
            txtParkingNo.Clear();
            txtRatePerHour.Clear();
            txtVehicleColor.Clear();
            txtVehiclePlateNo.Clear();
            txtVehicleType.Clear();
            cboVehicleBrand.Items.Clear();
        }

        private void btnViewParkingSpace_Click(object sender, EventArgs e)
        {
            frmParkingSpace parking = new frmParkingSpace();
            ParkingSlot dataToPass = new ParkingSlot();
            
            parking.ShowDialog();
            var id = parking.parkingID;

            if (id != "")
            {
                selectedParkingID = id;
                txtParkingNo.Text = id;
                txtParkingBlock.Text = (Convert.ToInt32(id) <= 120 ? "SECTION A" : "SECTION B");
            }
            else
            {
                txtParkingNo.Clear();
                txtParkingBlock.Clear();
            }
            
        }

        private void cboVehicleBrand_DropDown(object sender, EventArgs e)
        {
            VehicleBrand[] brands = connect.readBrands_active().ToArray();
            currentDataBrand = brands;
            cboVehicleBrand.Items.Clear();
            foreach(var brand in brands){
                cboVehicleBrand.Items.Add(brand.brandName);
            }
        }

        private void cboVehicleBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleType[] types = connect.readTypeRates_all().ToArray();
            string brandName = cboVehicleBrand.Text;
            string brandID = null;


            foreach (var brand in currentDataBrand)
            {
                //Find Same Type Name
                if (brandName == brand.brandName)
                {
                    brandID = brand.brandCategory;
                    break;
                }
            }

            foreach (var type in types)
            {
                //Find Same Type Name
                if (brandID == type.typeID)
                {
                    txtVehicleType.Text = type.typeName;
                    txtRatePerHour.Text = type.typeRatePerHour;
                    break;
                }
            }
        }

        public void GenerateCode()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            generatedCode = finalString + DateTime.Now.ToString("Mdhms");

        }
    }
}
