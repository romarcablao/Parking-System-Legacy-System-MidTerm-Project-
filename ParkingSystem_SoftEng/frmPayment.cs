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
    public partial class frmPayment : Form
    {

        classConnection connect = new classConnection();
        public string currentUserID;
        public string selectedBarcode;
        public string selectedID;

        public frmPayment()
        {
            InitializeComponent();
        }

        private void frmPayment_Load(object sender, EventArgs e)
        {
            JoinAccountInfo[] receipt = connect.searchReceiptRefence_pending_specific(selectedBarcode).ToArray();
            selectedID = receipt[0].refID;
            txtTimeIn.Text = receipt[0].refTimeIn;
            txtCustomer.Text = receipt[0].vehicleOwner;
            txtParkingBlock.Text = receipt[0].slotBlock;
            txtParkingNo.Text = receipt[0].slotNumber;
            txtRatePerHour.Text = receipt[0].typeRatePerHour;
            txtVehicleColor.Text = receipt[0].vehicleColor;
            txtVehiclePlateNo.Text = receipt[0].vehiclePlateNo;
            txtVehicleType.Text = receipt[0].typeName;
            cboVehicleBrand.Text = receipt[0].brandName;
            txtTimeOut.Text = DateTime.Now.ToString();

            DateTime timeIn = DateTime.Parse(txtTimeIn.Text);
            DateTime timeOut = DateTime.Parse(txtTimeOut.Text);

            Double timeCount = Math.Round(timeOut.Subtract(timeIn).TotalHours, 2);

            lblTimeCount.Text = timeCount.ToString();
            lblAmount.Text = (Double.Parse(txtRatePerHour.Text) * timeCount).ToString();


        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAmountPaid.Text.All(char.IsDigit) && txtChange.Text != "" && Double.Parse(txtChange.Text) >= 0)
            {
                //Save
                ReceiptReference receipt = new ReceiptReference();
                receipt.refID = selectedID;
                receipt.refStatus = "PAID";
                receipt.refPersonnelOut = currentUserID;
                receipt.refTimeCount = lblTimeCount.Text;
                receipt.refPrice = lblAmount.Text;
                receipt.refAmountPaid = txtAmountPaid.Text;
                receipt.refAmountChange = txtChange.Text;
                receipt.refTimeOut = txtTimeOut.Text;

                if (connect.updateReceiptReference(receipt))
                {
                    ParkingSlot dataToPass = new ParkingSlot();
                    dataToPass.slotIsAvailable = "1";
                    dataToPass.slotID = (Convert.ToInt32(txtParkingNo.Text) - 100).ToString();
                    connect.updateParkingSpace(dataToPass);

                    MessageBox.Show("Saved Successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ooops Something went wrong!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Amount! Please check your inputs.");
            }
        }

        private void txtAmountPaid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAmountPaid.Text.All(char.IsDigit))
                {
                    Double change = Double.Parse(txtAmountPaid.Text) - Double.Parse(lblAmount.Text);
                    txtChange.Text = change.ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Amount!");
                    txtChange.Clear();
                }
            }
            catch
            {
                MessageBox.Show("Invalid Amount!");
            }
        }
    }
}
