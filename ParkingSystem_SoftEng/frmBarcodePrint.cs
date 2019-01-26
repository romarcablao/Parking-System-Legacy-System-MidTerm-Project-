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
    public partial class frmBarcodePrint : Form
    {
        public string generatedCode;

        public frmBarcodePrint()
        {
            InitializeComponent();
        }

        private void frmBarcodePrint_Load(object sender, EventArgs e)
        {
            Font f = new Font("IDAutomationHC39M Free Version", 25);
            txtBarcode.Font = f;
            txtBarcode.Text = "*" + generatedCode + "*";
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
