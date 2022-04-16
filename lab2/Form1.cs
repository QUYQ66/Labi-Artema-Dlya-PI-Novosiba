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

        private void button1_Click(object sender, EventArgs e)
        {
            double f = 0;

            double x = double.Parse(textBox1.Text.Replace(".", ","));
            double y = double.Parse(textBox2.Text.Replace(".", ","));
            double z = double.Parse(textBox3.Text.Replace(".", ","));
            double xyabs = Math.Abs(x - y); 

            double chislitel = Math.Pow(Math.E, xyabs) * Math.Pow(xyabs,x+y);

            double znamenatel = Math.Atan(x) + Math.Atan(z);

            double pervayachast = chislitel / znamenatel;

            double vtorayachast = Math.Pow( Math.Pow(x, 6) + Math.Pow(Math.Log(y), 2),1/3);

            f = pervayachast + vtorayachast;

            label1.Text = Convert.ToString(f);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
