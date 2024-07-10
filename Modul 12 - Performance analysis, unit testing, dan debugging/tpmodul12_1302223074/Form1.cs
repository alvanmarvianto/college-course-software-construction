using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul12_1302223074
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int input))
            {
                label1.Text = CariTandaBilangan(Convert.ToInt32(textBox1.Text));
            }
            else
            {
                label1.Text = "Input harus angka!";
            }
        }

        public string CariTandaBilangan(int a)
        {
            if (a == 0)
            {
                return "Nol";
            } else if (a > 0)
            {
                return "Positif";
            } else
            {
                return "Negatif";

            }
        }
    }
}
