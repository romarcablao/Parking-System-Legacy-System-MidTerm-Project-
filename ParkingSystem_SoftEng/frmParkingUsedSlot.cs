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
    public partial class frmParkingUsedSlot : Form
    {

        classConnection connect = new classConnection();
        public string parkingID;
        public string barcode;

        public frmParkingUsedSlot()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParkingUsedSlot_Load(object sender, EventArgs e)
        {
            JoinAccountInfo[] receipt = connect.searchReceiptRefence_pending_specific(barcode).ToArray();
            txtTimeIn.Text = receipt[0].refTimeIn;
            txtCustomer.Text = receipt[0].vehicleOwner;
            txtParkingBlock.Text = receipt[0].slotBlock;
            txtParkingNo.Text = receipt[0].slotNumber;
            txtRatePerHour.Text = receipt[0].typeRatePerHour;
            txtVehicleColor.Text = receipt[0].vehicleColor;
            txtVehiclePlateNo.Text = receipt[0].vehiclePlateNo;
            txtVehicleType.Text = receipt[0].typeName;
            cboVehicleBrand.Text = receipt[0].brandName;
        }
    }
}
