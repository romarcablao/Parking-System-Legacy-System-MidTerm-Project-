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
    public partial class frmParkingSpace : Form
    {
        classConnection connect = new classConnection();
        public string parkingID;
        
        public frmParkingSpace()
        {
            InitializeComponent();
        }

        private void frmParkingSpace_Load(object sender, EventArgs e)
        {
            
        }

        private void btn106_Click(object sender, EventArgs e)
        {
            parkingID = "106";
            this.Close();
        }

        private void btn105_Click(object sender, EventArgs e)
        {
            parkingID = "105";
            this.Close();
        }

        private void btn104_Click(object sender, EventArgs e)
        {
            parkingID = "104";
            this.Close();
        }

        private void btn103_Click(object sender, EventArgs e)
        {
            parkingID = "103";
            this.Close();
        }

        private void btn102_Click(object sender, EventArgs e)
        {
            parkingID = "102";
            this.Close();
        }

        private void btn101_Click(object sender, EventArgs e)
        {
            parkingID = "101";
            this.Close();
        }

        private void btn115_Click(object sender, EventArgs e)
        {
            parkingID = "115";
            this.Close();
        }

        private void btn114_Click(object sender, EventArgs e)
        {
            parkingID = "114";
            this.Close();
        }

        private void btn113_Click(object sender, EventArgs e)
        {
            parkingID = "113";
            this.Close();
        }

        private void btn112_Click(object sender, EventArgs e)
        {
            parkingID = "112";
            this.Close();
        }

        private void btn111_Click(object sender, EventArgs e)
        {
            parkingID = "111";
            this.Close();
        }

        private void btn110_Click(object sender, EventArgs e)
        {
            parkingID = "110";
            this.Close();
        }

        private void btn109_Click(object sender, EventArgs e)
        {
            parkingID = "109";
            this.Close();
        }

        private void btn108_Click(object sender, EventArgs e)
        {
            parkingID = "108";
            this.Close();
        }

        private void btn107_Click(object sender, EventArgs e)
        {
            parkingID = "107";
            this.Close();
        }

        private void btn116_Click(object sender, EventArgs e)
        {
            parkingID = "116";
            this.Close();
        }

        private void btn117_Click(object sender, EventArgs e)
        {
            parkingID = "117";
            this.Close();
        }

        private void btn118_Click(object sender, EventArgs e)
        {
            parkingID = "118";
            this.Close();
        }

        private void btn119_Click(object sender, EventArgs e)
        {
            parkingID = "119";
            this.Close();
        }

        private void btn120_Click(object sender, EventArgs e)
        {
            parkingID = "120";
            this.Close();
        }

        private void btn121_Click(object sender, EventArgs e)
        {
            parkingID = "121";
            this.Close();
        }

        private void btn122_Click(object sender, EventArgs e)
        {
            parkingID = "122";
            this.Close();
        }

        private void btn123_Click(object sender, EventArgs e)
        {
            parkingID = "123";
            this.Close();
        }

        private void btn124_Click(object sender, EventArgs e)
        {
            parkingID = "124";
            this.Close();
        }

        private void btn125_Click(object sender, EventArgs e)
        {
            parkingID = "125";
            this.Close();
        }

        private void btn126_Click(object sender, EventArgs e)
        {
            parkingID = "126";
            this.Close();
        }

        private void btn127_Click(object sender, EventArgs e)
        {
            parkingID = "127";
            this.Close();
        }

        private void btn128_Click(object sender, EventArgs e)
        {
            parkingID = "128";
            this.Close();
        }

        private void btn129_Click(object sender, EventArgs e)
        {
            parkingID = "129";
            this.Close();
        }

        private void btn130_Click(object sender, EventArgs e)
        {
            parkingID = "130";
            this.Close();
        }

        private void tmrReloadParkingSpace_Tick(object sender, EventArgs e)
        {
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
                            btn101.Enabled = false;
                            btn101.BackColor = Color.Red;
                            break;
                        case "102":
                            btn102.Enabled = false;
                            btn102.BackColor = Color.Red;
                            break;
                        case "103":
                            btn103.Enabled = false;
                            btn103.BackColor = Color.Red;
                            break;
                        case "104":
                            btn104.Enabled = false;
                            btn104.BackColor = Color.Red;
                            break;
                        case "105":
                            btn105.Enabled = false;
                            btn105.BackColor = Color.Red;
                            break;
                        case "106":
                            btn106.Enabled = false;
                            btn106.BackColor = Color.Red;
                            break;
                        case "107":
                            btn107.Enabled = false;
                            btn107.BackColor = Color.Red;
                            break;
                        case "108":
                            btn108.Enabled = false;
                            btn108.BackColor = Color.Red;
                            break;
                        case "109":
                            btn109.Enabled = false;
                            btn109.BackColor = Color.Red;
                            break;
                        case "110":
                            btn110.Enabled = false;
                            btn110.BackColor = Color.Red;
                            break;
                        case "111":
                            btn111.Enabled = false;
                            btn111.BackColor = Color.Red;
                            break;
                        case "112":
                            btn112.Enabled = false;
                            btn112.BackColor = Color.Red;
                            break;
                        case "113":
                            btn113.Enabled = false;
                            btn113.BackColor = Color.Red;
                            break;
                        case "114":
                            btn114.Enabled = false;
                            btn114.BackColor = Color.Red;
                            break;
                        case "115":
                            btn115.Enabled = false;
                            btn115.BackColor = Color.Red;
                            break;
                        case "116":
                            btn116.Enabled = false;
                            btn116.BackColor = Color.Red;
                            break;
                        case "117":
                            btn117.Enabled = false;
                            btn117.BackColor = Color.Red;
                            break;
                        case "118":
                            btn118.Enabled = false;
                            btn118.BackColor = Color.Red;
                            break;
                        case "119":
                            btn119.Enabled = false;
                            btn119.BackColor = Color.Red;
                            break;
                        case "120":
                            btn120.Enabled = false;
                            btn120.BackColor = Color.Red;
                            break;
                        case "121":
                            btn121.Enabled = false;
                            btn121.BackColor = Color.Red;
                            break;
                        case "122":
                            btn122.Enabled = false;
                            btn122.BackColor = Color.Red;
                            break;
                        case "123":
                            btn123.Enabled = false;
                            btn123.BackColor = Color.Red;
                            break;
                        case "124":
                            btn124.Enabled = false;
                            btn124.BackColor = Color.Red;
                            break;
                        case "125":
                            btn125.Enabled = false;
                            btn125.BackColor = Color.Red;
                            break;
                        case "126":
                            btn126.Enabled = false;
                            btn126.BackColor = Color.Red;
                            break;
                        case "127":
                            btn127.Enabled = false;
                            btn127.BackColor = Color.Red;
                            break;
                        case "128":
                            btn128.Enabled = false;
                            btn128.BackColor = Color.Red;
                            break;
                        case "129":
                            btn129.Enabled = false;
                            btn129.BackColor = Color.Red;
                            break;
                        case "130":
                            btn130.Enabled = false;
                            btn130.BackColor = Color.Red;
                            break;
                        case "131":
                            btn131.Enabled = false;
                            btn131.BackColor = Color.Red;
                            break;
                        case "132":
                            btn132.Enabled = false;
                            btn132.BackColor = Color.Red;
                            break;
                        case "133":
                            btn133.Enabled = false;
                            btn133.BackColor = Color.Red;
                            break;
                        case "134":
                            btn134.Enabled = false;
                            btn134.BackColor = Color.Red;
                            break;
                        case "135":
                            btn135.Enabled = false;
                            btn135.BackColor = Color.Red;
                            break;
                        case "136":
                            btn136.Enabled = false;
                            btn136.BackColor = Color.Red;
                            break;
                        case "137":
                            btn137.Enabled = false;
                            btn137.BackColor = Color.Red;
                            break;
                        case "138":
                            btn138.Enabled = false;
                            btn138.BackColor = Color.Red;
                            break;
                        case "139":
                            btn139.Enabled = false;
                            btn139.BackColor = Color.Red;
                            break;
                        case "140":
                            btn140.Enabled = false;
                            btn140.BackColor = Color.Red;
                            break;
                    }
                }
            }
        }

        private void btnViewParkingSpace_Click(object sender, EventArgs e)
        {
            parkingID = "";
            this.Close();
        }

        private void btn131_Click(object sender, EventArgs e)
        {
            parkingID = "131";
            this.Close();
        }

        private void btn132_Click(object sender, EventArgs e)
        {
            parkingID = "132";
            this.Close();
        }

        private void btn133_Click(object sender, EventArgs e)
        {
            parkingID = "133";
            this.Close();
        }

        private void btn134_Click(object sender, EventArgs e)
        {
            parkingID = "134";
            this.Close();
        }

        private void btn135_Click(object sender, EventArgs e)
        {
            parkingID = "135";
            this.Close();
        }

        private void btn136_Click(object sender, EventArgs e)
        {
            parkingID = "136";
            this.Close();
        }

        private void btn137_Click(object sender, EventArgs e)
        {
            parkingID = "137";
            this.Close();
        }

        private void btn138_Click(object sender, EventArgs e)
        {
            parkingID = "138";
            this.Close();
        }

        private void btn139_Click(object sender, EventArgs e)
        {
            parkingID = "139";
            this.Close();
        }

        private void btn140_Click(object sender, EventArgs e)
        {
            parkingID = "140";
            this.Close();
        }

        
    }
}
