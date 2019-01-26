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
    public partial class frmPaymentMain : Form
    {
        classConnection connect = new classConnection();
        public string currentUserID;
        public string selectedPendingAccountID;

        public frmPaymentMain()
        {
            InitializeComponent();
        }

        private void frmPaymentMain_Load(object sender, EventArgs e)
        {
            txtSearch.Focus();
            LoadReceiptPending();
        }

        public void Record_LoadHeader_ReceiptPending()
        {
            lvwPendingCustomer.FullRowSelect = true;
            lvwPendingCustomer.MultiSelect = false;
            lvwPendingCustomer.View = View.Details;
            lvwPendingCustomer.Columns.Clear();
            lvwPendingCustomer.Items.Clear();
            lvwPendingCustomer.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lvwPendingCustomer.Columns.Add("BARCODE", 350, HorizontalAlignment.Left);
            lvwPendingCustomer.Columns.Add("PARKING ID", 250, HorizontalAlignment.Left);
            lvwPendingCustomer.Columns.Add("TIME IN", 450, HorizontalAlignment.Left);
            lvwPendingCustomer.Columns.Add("STATUS", 250, HorizontalAlignment.Left);
        }

        public void LoadReceiptPending()
        {
            Record_LoadHeader_ReceiptPending();

            try
            {
                ReceiptReference[] receipts = connect.readReceiptRefence_pending().ToArray();
                foreach (var receipt in receipts)
                {
                    ListViewItem lv = new ListViewItem(receipt.refID);
                    lv.SubItems.Add(receipt.refBarcode);
                    lv.SubItems.Add(receipt.refParkingID);
                    lv.SubItems.Add(receipt.refTimeIn);
                    lv.SubItems.Add(receipt.refStatus);
                    lvwPendingCustomer.Items.Add(lv);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //MessageBox.Show("Ooop! Something went wrong. Please try again.");
            }

        }

        public void SearchReceiptPending()
        {
            Record_LoadHeader_ReceiptPending();

            try
            {
                ReceiptReference[] receipts = connect.searchReceiptRefence_pending(txtSearch.Text).ToArray();
                foreach (var receipt in receipts)
                {
                    ListViewItem lv = new ListViewItem(receipt.refID);
                    lv.SubItems.Add(receipt.refBarcode);
                    lv.SubItems.Add(receipt.refParkingID);
                    lv.SubItems.Add(receipt.refTimeIn);
                    lv.SubItems.Add(receipt.refStatus);
                    lvwPendingCustomer.Items.Add(lv);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Ooop! Something went wrong. Please try again.");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchReceiptPending();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            SearchReceiptPending();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchReceiptPending();
        }

        private void lvwPendingCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lvwPendingCustomer.SelectedItems.Count == 1)
            {
                selectedPendingAccountID = this.lvwPendingCustomer.SelectedItems[0].SubItems[0].Text;
                //Call View
                frmPayment paymentInfo = new frmPayment();
                paymentInfo.currentUserID = currentUserID;
                paymentInfo.selectedBarcode = this.lvwPendingCustomer.SelectedItems[0].SubItems[1].Text;
                paymentInfo.ShowDialog();
                LoadReceiptPending();
            }
        }

        private void lvwPendingCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (this.lvwPendingCustomer.SelectedItems.Count == 1)
            {
                selectedPendingAccountID = this.lvwPendingCustomer.SelectedItems[0].SubItems[0].Text;
                //Call View
                frmPayment paymentInfo = new frmPayment();
                paymentInfo.currentUserID = currentUserID;
                paymentInfo.selectedBarcode = this.lvwPendingCustomer.SelectedItems[0].SubItems[1].Text;
                paymentInfo.ShowDialog();
                LoadReceiptPending();
            }
        }
    }
}
