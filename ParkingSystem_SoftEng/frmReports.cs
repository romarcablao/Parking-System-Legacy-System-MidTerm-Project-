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
    public partial class frmReports : Form
    {
        classConnection connect = new classConnection();
        public int NoOfTransactions = 0;
        public double AmountReceived;

        public frmReports()
        {
            InitializeComponent();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            LoadReport(dtpFrom.Text, dtpTo.Text);
        }

        public void Record_LoadHeader_Report()
        {
            lvwTransactions.FullRowSelect = true;
            lvwTransactions.MultiSelect = false;
            lvwTransactions.View = View.Details;
            lvwTransactions.Columns.Clear();
            lvwTransactions.Items.Clear();
            lvwTransactions.Columns.Add("ID", 0, HorizontalAlignment.Left);
            lvwTransactions.Columns.Add("BARCODE", 350, HorizontalAlignment.Left);
            lvwTransactions.Columns.Add("PARKING ID", 250, HorizontalAlignment.Left);
            lvwTransactions.Columns.Add("TIME IN", 450, HorizontalAlignment.Left);
            lvwTransactions.Columns.Add("TIME OUT", 250, HorizontalAlignment.Left);
            lvwTransactions.Columns.Add("TIME COUNT", 250, HorizontalAlignment.Left);
            lvwTransactions.Columns.Add("AMOUNT", 250, HorizontalAlignment.Left);
        }

        public void LoadReport(string from, string to)
        {
            Record_LoadHeader_Report();

            NoOfTransactions = 0;
            AmountReceived = 0.00;

            try
            {
                JoinAccountInfo[] receipts = connect.searchReceiptRefence_transactions(from, to).ToArray();
                foreach (var receipt in receipts)
                {
                    ListViewItem lv = new ListViewItem(receipt.refID);
                    lv.SubItems.Add(receipt.refBarcode);
                    lv.SubItems.Add(receipt.refParkingID);
                    lv.SubItems.Add(receipt.refTimeIn);
                    lv.SubItems.Add(receipt.refTimeOut);
                    lv.SubItems.Add(receipt.refTimeCount);
                    lv.SubItems.Add(receipt.refPrice);
                    lvwTransactions.Items.Add(lv);

                    NoOfTransactions++;
                    AmountReceived += Double.Parse(receipt.refPrice);

                    lblAmountReceived.Text = "Php " + AmountReceived.ToString();
                    lblNoOfTransactions.Text = NoOfTransactions.ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                //MessageBox.Show("Ooop! Something went wrong. Please try again.");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadReport(dtpFrom.Text, dtpTo.Text);
        }
    }
}
