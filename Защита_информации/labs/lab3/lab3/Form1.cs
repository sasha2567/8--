using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int ToBite(string s)
        {
            byte[] Key = Encoding.UTF8.GetBytes(s);
            int res = Key[0] + Key[1] * 256 + Key[2] * 256 * 256 + Key[3] * 256 * 256 * 256;
            return res;
        }

        private string sum(string s1, string s2)
        {
            string res = "";
            for (int i = 0; i < s1.Length;i++ )
                res += (char)((int)s1[i] ^ (int)s2[i]);
            return res;
        }

        private string ByteToString(int i, string s)
        {
            string res = "";
            byte[] Key = Encoding.UTF8.GetBytes(s);
            res += (char)((i % 256) + Key[0]);
            res += (char)(((i >> 8) % 256) + Key[1]);
            res += (char)(((i >> 16) % 256) + Key[2]);
            res += (char)(((i >> 24) % 256) + Key[3]);
            return res;
        }

        private UInt32 RotateLeft(UInt32 x, Byte n)
        {
            return (UInt32)((x << n) | (x >> (32 - n)));
        }

        private UInt32 RotateRight(UInt32 x, Byte n)
        {
            return (UInt32)((x >> n) | (x << (32 - n)));
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (inTextBox.TextLength % 16 != 0)
            {
                MessageBox.Show("Строка должна быть кратной 16 символам");
                return;
            }
            if (keyTextBox.TextLength % 8 != 0)
            {
                MessageBox.Show("Ключ должен быть кратен 8 символам");
                return;
            }
            string key = keyTextBox.Text;
            string lkey = key.Substring(0, 4);
            string rkey = key.Substring(4, 4);
            string[] Xcurrent = new string[4];
            string[] Xprevious = new string[4];
            int left_temp = ToBite(lkey);
            int right_temp = ToBite(rkey);
            string res = "";
            for (int j = 0; j < inTextBox.TextLength; j += 16)
            {
                string[] temp = new string[4];
                temp[0] = inTextBox.Text.Substring(j, 4);
                temp[1] = inTextBox.Text.Substring(j + 4, 4);
                temp[2] = inTextBox.Text.Substring(j + 8, 4);
                temp[3] = inTextBox.Text.Substring(j + 12, 4);
                if (radioButton1.Checked)
                {
                    for (byte i = 1; i <= loopNumeric.Value; i++)
                    {
                        if (i == 0)
                        {
                            int temp_mod_key = (int)RotateLeft((UInt32)left_temp, i) ^ (int)RotateRight((UInt32)right_temp, i);
                            Xcurrent[0] = sum(temp[1], ByteToString(temp_mod_key, temp[0]));
                            Xcurrent[1] = temp[2];
                            Xcurrent[2] = temp[3];
                            Xcurrent[3] = temp[0];
                            Xprevious[0] = Xcurrent[0];
                            Xprevious[1] = Xcurrent[1];
                            Xprevious[2] = Xcurrent[2];
                            Xprevious[3] = Xcurrent[3];
                        }
                        else
                        {
                            int temp_mod_key = (int)RotateLeft((UInt32)left_temp, i) ^ (int)RotateRight((UInt32)right_temp, i);
                            Xcurrent[0] = sum(Xprevious[1], ByteToString(temp_mod_key, Xprevious[0]));
                            Xcurrent[1] = Xprevious[2];
                            Xcurrent[2] = Xprevious[3];
                            Xcurrent[3] = Xprevious[0];
                            Xprevious[0] = Xcurrent[0];
                            Xprevious[1] = Xcurrent[1];
                            Xprevious[2] = Xcurrent[2];
                            Xprevious[3] = Xcurrent[3];
                        }
                    }
                    Xcurrent[0] = Xprevious[1];
                    Xcurrent[1] = Xprevious[2];
                    Xcurrent[2] = Xprevious[3];
                    Xcurrent[3] = Xprevious[0];
                }
                else
                {
                    for (byte i = (byte)loopNumeric.Value; i > 0; i--)
                    {
                        if (i == 0)
                        {
                            int temp_mod_key = (int)RotateLeft((UInt32)left_temp, i) ^ (int)RotateRight((UInt32)right_temp, i);
                            Xcurrent[3] = sum(temp[0], ByteToString(temp_mod_key, temp[3]));
                            Xcurrent[2] = temp[3];
                            Xcurrent[1] = temp[2];
                            Xcurrent[0] = temp[1];
                            Xprevious[0] = Xcurrent[0];
                            Xprevious[1] = Xcurrent[1];
                            Xprevious[2] = Xcurrent[2];
                            Xprevious[3] = Xcurrent[3];
                        }
                        else
                        {
                            int temp_mod_key = (int)RotateLeft((UInt32)left_temp, i) ^ (int)RotateRight((UInt32)right_temp, i);
                            Xcurrent[3] = sum(Xprevious[0], ByteToString(temp_mod_key, Xprevious[3]));
                            Xcurrent[2] = Xprevious[3];
                            Xcurrent[1] = Xprevious[2];
                            Xcurrent[0] = Xprevious[1];
                            Xprevious[0] = Xcurrent[0];
                            Xprevious[1] = Xcurrent[1];
                            Xprevious[2] = Xcurrent[2];
                            Xprevious[3] = Xcurrent[3];
                        }
                    }
                    Xcurrent[0] = Xprevious[1];
                    Xcurrent[1] = Xprevious[2];
                    Xcurrent[2] = Xprevious[3];
                    Xcurrent[3] = Xprevious[0];
                }
                res += Xcurrent[0] + Xcurrent[1] + Xcurrent[2] + Xcurrent[3];
            }
            outTextBox.Text = res;
        }
    }
}
