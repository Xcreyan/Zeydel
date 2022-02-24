using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeydel
{
    public partial class Form1 : Form
    {
        public double x1_1;
        public double x1_2;
        public double x1_3;
        public double x2_1;
        public double x2_2;
        public double x2_3;
        public double x3_1;
        public double x3_2;
        public double x3_3;
        public double x1_0;
        public double x2_0;
        public double x3_0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            x1_1 = Convert.ToDouble(textBox1.Text);
            x1_2 = Convert.ToDouble(textBox2.Text);
            x1_3 = Convert.ToDouble(textBox3.Text);
            x2_1 = Convert.ToDouble(textBox5.Text);
            x2_2 = Convert.ToDouble(textBox6.Text);
            x2_3 = Convert.ToDouble(textBox7.Text);
            x3_1 = Convert.ToDouble(textBox9.Text);
            x3_2 = Convert.ToDouble(textBox10.Text);
            x3_3 = Convert.ToDouble(textBox11.Text);
            x1_0 = Convert.ToDouble(textBox4.Text);
            x2_0 = Convert.ToDouble(textBox8.Text);
            x3_0 = Convert.ToDouble(textBox12.Text);
            for (int i = 0; i<10; i++)
            {
                x1_0 = (1 / x1_1) * (x1_0 - x1_2 * x2_0 - x1_3 * x3_0);
                x2_0 = (1 / x2_2) * (x2_0 - x2_3 * x3_0 - x2_1 * x1_0);
                x3_0 = (1 / x3_3) * (x3_0 - x3_1 * x1_0 - x3_2 * x2_0);
            }
            listBox1.Items.Clear();
            listBox1.Items.Add($"x1 = {x1_0}");
            listBox1.Items.Add($"x2 = {x2_0}");
            listBox1.Items.Add($"x3 = {x3_0}");
        }
    }
}
