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
using System.IO;

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

        private void btnZgjedh_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Zgjedh Fajllin";
            fd.Filter = "Text File|*.txt|Word Document|*.docx";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                txtFajlli.Text = fd.FileName;
            }
        }

        private void btnEnkript_Click(object sender, EventArgs e)
        {
            UTF8Encoding utf8 = new UTF8Encoding();
            TripleDESCryptoServiceProvider tDES = new TripleDESCryptoServiceProvider();
            tDES.Key = utf8.GetBytes(txtkey.Text);  //me utf8 merr edhe disa karaktere tveqanta
            tDES.Mode = CipherMode.CBC;
            tDES.IV = utf8.GetBytes("06041995");
            tDES.Padding = PaddingMode.Zeros;

            StreamReader sr = new StreamReader(txtFajlli.Text);
            string permbajtja = sr.ReadToEnd();
            sr.Close();
            FileStream fs1 = new FileStream(txtFajlli.Text, FileMode.Create, FileAccess.Write);
            CryptoStream cs = new CryptoStream(fs1, tDES.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);
            sw.Write(permbajtja);
            sw.Flush();
            sw.Close();
            //Ruajtja e qelsit ne fajll
            string permbajtjaQelsit = txtkey.Text;
            SaveFileDialog saveFD = new SaveFileDialog();
            saveFD.InitialDirectory = Convert.ToString(Environment.SpecialFolder.Desktop);
            saveFD.Filter = "Text File|*.txt|Word Document|*.docx";
            saveFD.FilterIndex = 1;
            if (saveFD.ShowDialog() == DialogResult.OK && saveFD.FileName.Length > 0)
            {
                FileStream fs2 = new FileStream(saveFD.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw2 = new StreamWriter(fs2);
                sw2.Write(permbajtjaQelsit);
                sw2.Flush();
                sw2.Close();
            }
        }
    }
}
