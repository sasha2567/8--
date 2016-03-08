using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DigitalSignatureHelper ds = new DigitalSignatureHelper();
	    byte[] hash1;
	    byte[] hash2;
	    byte[] signedhash;

        private void button3_Click(object sender, EventArgs e)
        {
            try //создание подписи
            {
                MD5HashHelper md5 = new MD5HashHelper();
                hash1 = md5.GetHash(textBox3.Text);
                signedhash = ds.CreateSignature(hash1);
                MessageBox.Show("Подпись успешно создана!");
            }
	        catch(Exception ex){MessageBox.Show(ex.Message);}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try//проверка подписи
            {
                MD5HashHelper md5 = new MD5HashHelper();
                hash2 = md5.GetHash(textBox2.Text);
                if (ds.VerifySignature(hash2, signedhash))
                {
                    MessageBox.Show("Ура! Подпись правильная!");
                }
                else
                {
                    MessageBox.Show("Ой! Подпись неверная!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
