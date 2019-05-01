using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripleDES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnkripto_Click(object sender, EventArgs e)
        {
            string key = "Projekti Ne Siguri";
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] keyArr = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
            md5.Clear();

            byte[] TekstiTxt = Encoding.UTF8.GetBytes(textBox1.Text);

            TripleDESCryptoServiceProvider des3 = new TripleDESCryptoServiceProvider();
            des3.Key = keyArr;
            des3.Mode = CipherMode.ECB;
            des3.Padding = PaddingMode.PKCS7;

            ICryptoTransform iTransform = des3.CreateEncryptor();
            byte[] rezultati = iTransform.TransformFinalBlock(TekstiTxt, 0, TekstiTxt.Length);
            textBox2.Text = Convert.ToBase64String(rezultati);

        }

        private void btnDekripto_Click(object sender, EventArgs e)
        {
            string key = "Projekti Ne Siguri";
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] keyArr = md5.ComputeHash(Encoding.UTF8.GetBytes(key));
            md5.Clear();

            byte[] EnkriptimiTxt = Convert.FromBase64String(textBox2.Text);

            TripleDESCryptoServiceProvider des3 = new TripleDESCryptoServiceProvider();
            des3.Key = keyArr;
            des3.Mode = CipherMode.ECB;
            des3.Padding = PaddingMode.PKCS7;

            ICryptoTransform iTransform = des3.CreateDecryptor();
            byte[] rezultati = iTransform.TransformFinalBlock(EnkriptimiTxt, 0, EnkriptimiTxt.Length);
            textBox3.Text = Encoding.UTF8.GetString(rezultati);
        }
    }
}
