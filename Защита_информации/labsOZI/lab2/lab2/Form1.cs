using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] gamma;
        private int[] gamma2;

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            gamma = new int[WordTextBox.TextLength];
            string temp = "";
            gamma[0] = (A_TrackBar.Value * rand.Next() + C_TrackBar.Value) % (int)Math.Pow(2, B_TrackBar.Value);
            temp += (char)((int)WordTextBox.Text[0] ^ gamma[0]);
            for (int i = 1; i < gamma.Length; i++)
            {
                gamma[i] = (ATrackBar.Value * gamma[i - 1] + CTrackBar.Value) % (int)Math.Pow(2, BTrackBar.Value);
                temp += (char)((int)WordTextBox.Text[i] ^ gamma[i]);
            }
            EncryptTextBox.Text = temp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ALabel.Text = "Коэффициент A = " + ATrackBar.Value;
            CLabel.Text = "Коэффициент C = " + CTrackBar.Value;
            BLabel.Text = "Коэффициент B = " + BTrackBar.Value;
            A_Label.Text = "Коэффициент A = " + A_TrackBar.Value;
            C_Label.Text = "Коэффициент C = " + C_TrackBar.Value;
            B_Label.Text = "Коэффициент B = " + B_TrackBar.Value;
        }

        private void Decryptbutton_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (int i = 0; i < gamma.Length; i++)
            {
                temp += (char)((int)EncryptTextBox.Text[i] ^ gamma[i]);
            }
            DecryptTextBox.Text = temp;
        }

        private void Encrypt_Button_Click(object sender, EventArgs e)
        {
            gamma2 = new int[Word_TextBox.TextLength];
            string temp = "";
            try
            {
                Convert.ToInt32(T_TextBox.Text);
            }
            catch
            {
                MessageBox.Show("Начальные условия\n введены не верно");
                return;
            }
            int ch = Convert.ToInt32(T_TextBox.Text);
            gamma2[0] = (A_TrackBar.Value * ch + C_TrackBar.Value) % (int)Math.Pow(2, B_TrackBar.Value);
            temp += (char)((int)Word_TextBox.Text[0] ^ gamma2[0]);
            for (int i = 1; i < gamma2.Length; i++)
            {

                int tmp = (int)Word_TextBox.Text[i - 1];
                ch = 0;
                for (int k = 1; k <= 8; k++)
                {
                    if (tmp % (int)Math.Pow(2, k) >= 0)
                    {
                        ch++;
                    }
                }
                gamma2[i] = (A_TrackBar.Value * ch + C_TrackBar.Value) % (int)Math.Pow(2, B_TrackBar.Value);
                temp += (char)((int)Word_TextBox.Text[i] ^ gamma2[i]);
            }
            Encrypt_TextBox.Text = temp;
        }

        private void Decrypt_Button_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (int i = 0; i < gamma2.Length; i++)
            {
                temp += (char)((int)Encrypt_TextBox.Text[i] ^ gamma2[i]);
            }
            Decrypt_TextBox.Text = temp;
        }
    }
}
