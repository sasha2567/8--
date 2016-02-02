using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sasha
{
    public partial class CodingForm : Form
    {
        public CodingForm()
        {
            InitializeComponent();
        }

        private void codeSubstitution_Click(object sender, EventArgs e)
        {
            try
            {
                string result = "";
                string alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ .,!:;?-";
                string alfres = "VWXYZ .,!:;?-KLMNOPQRSTUABCDEFGHIJ";
                foreach (char c in inStringSubstitution.Text)
                {
                    result += alfres[alf.IndexOf(c)];
                }
                outStringSubstitution.Text = result;
            }
            catch
            {
                MessageBox.Show("Используется только английский алфавит прописью6");
            }
            
        }

        private void codeRearrange_Click(object sender, EventArgs e)
        {
            int[] permutation = {2, 5, 4, 3, 1};
            string result = "";
            if (inStringRearrange.TextLength % 5 != 0)
            {
                MessageBox.Show("Ошибка. фраза не делиться нацело на блоки");
                return;
            }
            try
            {
                for (int i = 0; i < inStringRearrange.TextLength; i += 5)
                {
                    for (int k = 0; k < 5; k++)
                    {
                        result += inStringRearrange.Text[permutation[k] + i - 1];
                    }
                }
                outStringRearrange.Text = result;
            }
            catch
            {
                MessageBox.Show("Ошибка. фраза не делиться нацело на блоки");
                return;
            }
        }
    }
}
