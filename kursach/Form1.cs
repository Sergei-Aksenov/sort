using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public string[] ss;

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                ss = File.ReadAllLines(ofd.FileName, Encoding.Default);
            string[] lines = File.ReadAllLines(@"C:\kek\kek.txt");
            textBox2.Text = string.Join("\t\t", lines);
        }







            private void Form1_Load(object sender, EventArgs e)
            {

            }

            private void label1_Click(object sender, EventArgs e)
            {

            }




           

            private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
            {

            }

            private void textBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void button2_Click(object sender, EventArgs e)
            {
            
            for (int a = 0; a < ss.Length; a++)
                {
                    int i, lf, rg, c;

                    i = 2;
                    while (i < ss.Length)
                    {
                        lf = 1;
                        rg = i - 1;
                        c = (lf + rg) / 2;
                        while (lf != c)
                        {
                            if (Convert.ToInt32(ss[c]) < Convert.ToInt32(ss[i])) rg = c;
                            else lf = c;
                            c = (lf + rg) / 2;
                        }

                        if (Convert.ToInt32(ss[lf]) < Convert.ToInt32(ss[i]))
                        {
                            if (Convert.ToInt32(ss[i]) > Convert.ToInt32(ss[rg])) lf = rg + 1;
                            else lf = rg;
                        }
                        int k = i;
                        int p = Convert.ToInt32(ss[i]);

                        while (k > lf)
                        {
                            ss[k] = ss[k - 1];
                            k = k - 1;
                        }
                        ss[lf] = Convert.ToString(p);
                        i = i + 1;
                        
                    }

                }
            }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
