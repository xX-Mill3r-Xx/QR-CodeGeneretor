using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_CodeGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_CodeGenerator_Click(object sender, EventArgs e)
        {
            GerarCodigoQR();
            txt_Code.Text = "";
            txt_Code.Focus();
        }

        private void GerarCodigoQR()
        {
            string codigicar = txt_Code.Text;
            string generator = new string(codigicar);

            string payload = generator.ToString();

            QRCodeGenerator qR_CodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qR_CodeGenerator.CreateQrCode(payload, QRCodeGenerator.ECCLevel.Q);
            QRCode qR = new QRCode(qRCodeData);
            box_Code.Image = qR.GetGraphic(13);
        }
    }
}
