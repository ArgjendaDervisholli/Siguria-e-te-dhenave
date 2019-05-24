using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security;
using System.Security.Cryptography;
using System.IO;

namespace GR15_Detyra2
{
    public partial class Form1 : Form
    {
        byte[] plain;
        byte[] cipher;
        byte[] hashi;
        byte[] nenshkrimi;
        string file = " C:\\Users\\Techcom\\Desktop\\Detyra_2_Siguri_Grupi_15\\qelsat.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnkriptimi_Click(object sender, EventArgs e)
        {
            RSA_ND objrsa = new RSA_ND();
            plain = Encoding.UTF8.GetBytes(rtbPlain.Text);
            objrsa.TeDhenatPublikeXML(file);
            cipher = objrsa.Enkriptimi(plain);

            rtbCipher.Text = Convert.ToBase64String(cipher);

        }

        private void btnGjeneroCelesat_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
            string rsaParametrat = RSA.ToXmlString(true);
            StreamWriter sw=new StreamWriter(file);
            sw.Write(rsaParametrat);
            sw.Close();

        }

        private void btnDekriptimi_Click(object sender, EventArgs e)
        {
            RSA_ND RSA = new RSA_ND();
            RSA.TeDhenatPrivateXML(file);
            byte[] tekstiDekriptuar = RSA.Dekriptimi(cipher);
            rtbTextDekriptuar.Text = Encoding.UTF8.GetString(tekstiDekriptuar);

        }

        private void btnNDigital_Click(object sender, EventArgs e)
        {
            RSA_ND RSA = new RSA_ND();
            RSA.TeDhenatPrivateXML(file);
            SHA1CryptoServiceProvider sha1=new SHA1CryptoServiceProvider();
            hashi = sha1.ComputeHash(plain);
            rtbHGjeneruar.Text = BitConverter.ToString(hashi);

            nenshkrimi = RSA.NenshkrimiDigjital(plain);

        }

        private void btnVDigital_Click(object sender, EventArgs e)
        {
            RSA_ND RSA = new RSA_ND();
            RSA.TeDhenatPublikeXML(file);
            byte[] HashiNgaNenshkrimi = RSA.VerifikimiNenshkrimit(nenshkrimi, plain);
            rtbHngaNenshkrimi.Text = BitConverter.ToString(HashiNgaNenshkrimi);
            
        }
    }
}
