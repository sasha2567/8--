using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rd = new Random();
            P = 19;
            Q = 23;
            N = P * Q;
            M = (P - 1) * (Q - 1);
            int temp = (int)(P < Q ? P : Q);
            E = 13;
            D = 61;
        }

        private int P, Q;
        private long N, D, E, M;

        private void encode_Click(object sender, EventArgs e)
        {
            encodeTextBox.Text = "";
            for (int i = 0; i < inTextBox.TextLength; i++)
            {
                int t = (int)Math.Pow((int)inTextBox.Text[i], E);
                encodeTextBox.Text += (char)(t % N);
                MessageBox.Show("значение" + (t % N) + " для " + i + "-ого символа");
            }
        }

        private void decode_Click(object sender, EventArgs e)
        {
            decodeTextBox.Text = "";
            for (int i = 0; i < encodeTextBox.TextLength; i++)
            {
                int t = (int)Math.Pow((int)encodeTextBox.Text[i], D);
                decodeTextBox.Text += (char)(t % N);
            }
        }
    }
}
