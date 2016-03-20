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
            //Random rd = new Random();
            P = 11;
            Q = 13;
            N = P * Q;
            M = (P - 1) * (Q - 1);
            //int temp = (int)(P < Q ? P : Q);
            E = 7;
            D = 103;
        }

        private int textlength = 0;
        double[] key;

        private int P, Q;
        private long N, D, E, M;

        private void encode_Click(object sender, EventArgs e)
        {
            encodeTextBox.Text = "";
            textlength = inTextBox.TextLength;
            key = new double[textlength];
            for (int i = 0; i < textlength; i++)
            {
                double t = Math.Pow((double)inTextBox.Text[i], (double)E);
                double m = (t % N);
                key[i] = m;
                encodeTextBox.Text += m + "(" + (char)m + ")/";
            }
        }

        private void decode_Click(object sender, EventArgs e)
        {
            decodeTextBox.Text = "";
            for (int i = 0; i < textlength; i++)
            {
                double t = Math.Pow(key[i], (double)D);
                double m = (t % N);
                decodeTextBox.Text += m + "(" + (char)m + ")/";
            }
        }
    }
}