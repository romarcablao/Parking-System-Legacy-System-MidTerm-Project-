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
    public partial class frmParkingSpaceMain : Form
    {

        classConnection connect = new classConnection();
        public string parkingID;
        ReceiptReference[] receiptRef;

        public frmParkingSpaceMain()
        {
            InitializeComponent();
        }

        private void frmParkingSpaceMain_Load(object sender, EventArgs e)
        {

        }

        private void tmrReloadParkingSpace_Tick_1(object sender, EventArgs e)
        {

            try
            {
                receiptRef = connect.searchReceiptRefence_pending("").ToArray();
                ParkingSlot[] slots = connect.readParkingSlot_all().ToArray();

                foreach (var slot in slots)
                {
                    if (slot.slotIsAvailable == "1")
                    {
                        switch (slot.slotNumber)
                        {
                            case "101":
                                btn101.Enabled = true;
                                btn101.BackColor = Color.Green;
                                break;
                            case "102":
                                btn102.Enabled = true;
                                btn102.BackColor = Color.Green;
                                break;
                            case "103":
                                btn103.Enabled = true;
                                btn103.BackColor = Color.Green;
                                break;
                            case "104":
                                btn104.Enabled = true;
                                btn104.BackColor = Color.Green;
                                break;
                            case "105":
                                btn105.Enabled = true;
                                btn105.BackColor = Color.Green;
                                break;
                            case "106":
                                btn106.Enabled = true;
                                btn106.BackColor = Color.Green;
                                break;
                            case "107":
                                btn107.Enabled = true;
                                btn107.BackColor = Color.Green;
                                break;
                            case "108":
                                btn108.Enabled = true;
                                btn108.BackColor = Color.Green;
                                break;
                            case "109":
                                btn109.Enabled = true;
                                btn109.BackColor = Color.Green;
                                break;
                            case "110":
                                btn110.Enabled = true;
                                btn110.BackColor = Color.Green;
                                break;
                            case "111":
                                btn111.Enabled = true;
                                btn111.BackColor = Color.Green;
                                break;
                            case "112":
                                btn112.Enabled = true;
                                btn112.BackColor = Color.Green;
                                break;
                            case "113":
                                btn113.Enabled = true;
                                btn113.BackColor = Color.Green;
                                break;
                            case "114":
                                btn114.Enabled = true;
                                btn114.BackColor = Color.Green;
                                break;
                            case "115":
                                btn115.Enabled = true;
                                btn115.BackColor = Color.Green;
                                break;
                            case "116":
                                btn116.Enabled = true;
                                btn116.BackColor = Color.Green;
                                break;
                            case "117":
                                btn117.Enabled = true;
                                btn117.BackColor = Color.Green;
                                break;
                            case "118":
                                btn118.Enabled = true;
                                btn118.BackColor = Color.Green;
                                break;
                            case "119":
                                btn119.Enabled = true;
                                btn119.BackColor = Color.Green;
                                break;
                            case "120":
                                btn120.Enabled = true;
                                btn120.BackColor = Color.Green;
                                break;
                            case "121":
                                btn121.Enabled = true;
                                btn121.BackColor = Color.Green;
                                break;
                            case "122":
                                btn122.Enabled = true;
                                btn122.BackColor = Color.Green;
                                break;
                            case "123":
                                btn123.Enabled = true;
                                btn123.BackColor = Color.Green;
                                break;
                            case "124":
                                btn124.Enabled = true;
                                btn124.BackColor = Color.Green;
                                break;
                            case "125":
                                btn125.Enabled = true;
                                btn125.BackColor = Color.Green;
                                break;
                            case "126":
                                btn126.Enabled = true;
                                btn126.BackColor = Color.Green;
                                break;
                            case "127":
                                btn127.Enabled = true;
                                btn127.BackColor = Color.Green;
                                break;
                            case "128":
                                btn128.Enabled = true;
                                btn128.BackColor = Color.Green;
                                break;
                            case "129":
                                btn129.Enabled = true;
                                btn129.BackColor = Color.Green;
                                break;
                            case "130":
                                btn130.Enabled = true;
                                btn130.BackColor = Color.Green;
                                break;
                            case "131":
                                btn131.Enabled = true;
                                btn131.BackColor = Color.Green;
                                break;
                            case "132":
                                btn132.Enabled = true;
                                btn132.BackColor = Color.Green;
                                break;
                            case "133":
                                btn133.Enabled = true;
                                btn133.BackColor = Color.Green;
                                break;
                            case "134":
                                btn134.Enabled = true;
                                btn134.BackColor = Color.Green;
                                break;
                            case "135":
                                btn135.Enabled = true;
                                btn135.BackColor = Color.Green;
                                break;
                            case "136":
                                btn136.Enabled = true;
                                btn136.BackColor = Color.Green;
                                break;
                            case "137":
                                btn137.Enabled = true;
                                btn137.BackColor = Color.Green;
                                break;
                            case "138":
                                btn138.Enabled = true;
                                btn138.BackColor = Color.Green;
                                break;
                            case "139":
                                btn139.Enabled = true;
                                btn139.BackColor = Color.Green;
                                break;
                            case "140":
                                btn140.Enabled = true;
                                btn140.BackColor = Color.Green;
                                break;
                        }
                    }
                    else
                    {
                        switch (slot.slotNumber)
                        {
                            case "101":
                                btn101.Enabled = true;
                                btn101.BackColor = Color.Red;
                                break;
                            case "102":
                                btn102.Enabled = true;
                                btn102.BackColor = Color.Red;
                                break;
                            case "103":
                                btn103.Enabled = true;
                                btn103.BackColor = Color.Red;
                                break;
                            case "104":
                                btn104.Enabled = true;
                                btn104.BackColor = Color.Red;
                                break;
                            case "105":
                                btn105.Enabled = true;
                                btn105.BackColor = Color.Red;
                                break;
                            case "106":
                                btn106.Enabled = true;
                                btn106.BackColor = Color.Red;
                                break;
                            case "107":
                                btn107.Enabled = true;
                                btn107.BackColor = Color.Red;
                                break;
                            case "108":
                                btn108.Enabled = true;
                                btn108.BackColor = Color.Red;
                                break;
                            case "109":
                                btn109.Enabled = true;
                                btn109.BackColor = Color.Red;
                                break;
                            case "110":
                                btn110.Enabled = true;
                                btn110.BackColor = Color.Red;
                                break;
                            case "111":
                                btn111.Enabled = true;
                                btn111.BackColor = Color.Red;
                                break;
                            case "112":
                                btn112.Enabled = true;
                                btn112.BackColor = Color.Red;
                                break;
                            case "113":
                                btn113.Enabled = true;
                                btn113.BackColor = Color.Red;
                                break;
                            case "114":
                                btn114.Enabled = true;
                                btn114.BackColor = Color.Red;
                                break;
                            case "115":
                                btn115.Enabled = true;
                                btn115.BackColor = Color.Red;
                                break;
                            case "116":
                                btn116.Enabled = true;
                                btn116.BackColor = Color.Red;
                                break;
                            case "117":
                                btn117.Enabled = true;
                                btn117.BackColor = Color.Red;
                                break;
                            case "118":
                                btn118.Enabled = true;
                                btn118.BackColor = Color.Red;
                                break;
                            case "119":
                                btn119.Enabled = true;
                                btn119.BackColor = Color.Red;
                                break;
                            case "120":
                                btn120.Enabled = true;
                                btn120.BackColor = Color.Red;
                                break;
                            case "121":
                                btn121.Enabled = true;
                                btn121.BackColor = Color.Red;
                                break;
                            case "122":
                                btn122.Enabled = true;
                                btn122.BackColor = Color.Red;
                                break;
                            case "123":
                                btn123.Enabled = true;
                                btn123.BackColor = Color.Red;
                                break;
                            case "124":
                                btn124.Enabled = true;
                                btn124.BackColor = Color.Red;
                                break;
                            case "125":
                                btn125.Enabled = true;
                                btn125.BackColor = Color.Red;
                                break;
                            case "126":
                                btn126.Enabled = true;
                                btn126.BackColor = Color.Red;
                                break;
                            case "127":
                                btn127.Enabled = true;
                                btn127.BackColor = Color.Red;
                                break;
                            case "128":
                                btn128.Enabled = true;
                                btn128.BackColor = Color.Red;
                                break;
                            case "129":
                                btn129.Enabled = true;
                                btn129.BackColor = Color.Red;
                                break;
                            case "130":
                                btn130.Enabled = true;
                                btn130.BackColor = Color.Red;
                                break;
                            case "131":
                                btn131.Enabled = true;
                                btn131.BackColor = Color.Red;
                                break;
                            case "132":
                                btn132.Enabled = true;
                                btn132.BackColor = Color.Red;
                                break;
                            case "133":
                                btn133.Enabled = true;
                                btn133.BackColor = Color.Red;
                                break;
                            case "134":
                                btn134.Enabled = true;
                                btn134.BackColor = Color.Red;
                                break;
                            case "135":
                                btn135.Enabled = true;
                                btn135.BackColor = Color.Red;
                                break;
                            case "136":
                                btn136.Enabled = true;
                                btn136.BackColor = Color.Red;
                                break;
                            case "137":
                                btn137.Enabled = true;
                                btn137.BackColor = Color.Red;
                                break;
                            case "138":
                                btn138.Enabled = true;
                                btn138.BackColor = Color.Red;
                                break;
                            case "139":
                                btn139.Enabled = true;
                                btn139.BackColor = Color.Red;
                                break;
                            case "140":
                                btn140.Enabled = true;
                                btn140.BackColor = Color.Red;
                                break;
                        }
                    }
                }
            }
            catch { }
        }

        public void whatToDo(string buttonID)
        {

            try
            {
                foreach (var receipt in receiptRef)
                {
                    if (receipt.refParkingID == buttonID)
                    {
                        frmParkingUsedSlot usedslot = new frmParkingUsedSlot();
                        usedslot.parkingID = buttonID;
                        usedslot.barcode = receipt.refBarcode;
                        usedslot.ShowDialog();
                        break;
                    }
                }
            }
            catch { }
            



        }

        private void btn101_Click(object sender, EventArgs e)
        {
            whatToDo("1");
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            whatToDo("2");
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            whatToDo("3");
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            whatToDo("4");
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            whatToDo("5");
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            whatToDo("6");
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            whatToDo("7");
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            whatToDo("8");
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            whatToDo("9");
        }

        private void btn110_Click(object sender, EventArgs e)
        {
            whatToDo("10");
        }

        private void btn111_Click(object sender, EventArgs e)
        {
            whatToDo("11");
        }

        private void btn112_Click(object sender, EventArgs e)
        {
            whatToDo("12");
        }

        private void btn113_Click(object sender, EventArgs e)
        {
            whatToDo("13");
        }

        private void btn114_Click(object sender, EventArgs e)
        {
            whatToDo("14");
        }

        private void btn115_Click(object sender, EventArgs e)
        {
            whatToDo("15");
        }

        private void btn116_Click(object sender, EventArgs e)
        {
            whatToDo("16");
        }

        private void btn117_Click(object sender, EventArgs e)
        {
            whatToDo("17");
        }

        private void btn118_Click(object sender, EventArgs e)
        {
            whatToDo("18");
        }

        private void btn119_Click(object sender, EventArgs e)
        {
            whatToDo("19");
        }

        private void btn120_Click(object sender, EventArgs e)
        {
            whatToDo("20");
        }

        private void btn121_Click(object sender, EventArgs e)
        {
            whatToDo("21");
        }

        private void btn122_Click(object sender, EventArgs e)
        {
            whatToDo("22");
        }

        private void btn123_Click(object sender, EventArgs e)
        {
            whatToDo("23");
        }

        private void btn124_Click(object sender, EventArgs e)
        {
            whatToDo("24");
        }

        private void btn125_Click(object sender, EventArgs e)
        {
            whatToDo("25");
        }

        private void btn126_Click(object sender, EventArgs e)
        {
            whatToDo("26");
        }

        private void btn127_Click(object sender, EventArgs e)
        {
            whatToDo("27");
        }

        private void btn128_Click(object sender, EventArgs e)
        {
            whatToDo("28");
        }

        private void btn129_Click(object sender, EventArgs e)
        {
            whatToDo("29");
        }

        private void btn130_Click(object sender, EventArgs e)
        {
            whatToDo("30");
        }

        private void btn131_Click(object sender, EventArgs e)
        {
            whatToDo("31");
        }

        private void btn132_Click(object sender, EventArgs e)
        {
            whatToDo("32");
        }

        private void btn133_Click(object sender, EventArgs e)
        {
            whatToDo("33");
        }

        private void btn134_Click(object sender, EventArgs e)
        {
            whatToDo("34");
        }

        private void btn135_Click(object sender, EventArgs e)
        {
            whatToDo("35");
        }

        private void btn136_Click(object sender, EventArgs e)
        {
            whatToDo("36");
        }

        private void btn137_Click(object sender, EventArgs e)
        {
            whatToDo("37");
        }

        private void btn138_Click(object sender, EventArgs e)
        {
            whatToDo("38");
        }

        private void btn139_Click(object sender, EventArgs e)
        {
            whatToDo("39");
        }

        private void btn140_Click(object sender, EventArgs e)
        {
            whatToDo("40");
        }
    }
}
