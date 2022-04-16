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

        private void button1_Click(object sender, EventArgs e)
        {



            if (radioButton1.Checked)
            {
                double m = Convert.ToDouble(textBox2.Text);

                double x = Convert.ToDouble(textBox1.Text);
                if (m < -1)
                { MessageBox.Show("Введены неверные данные(ищите сами)"); }
                if (m > x)
                { MessageBox.Show("Введены неверные данные(ищите сами)"); }
                if (x < m)
                { MessageBox.Show("Введены неверные данные(ищите сами)"); }


                double fx = (Math.Pow(Math.E, x) - Math.Pow(Math.E, -x)) / 2; //sh(x)
                double absfx = Math.Abs(fx); // модуль от sh(x)

                double rezultat = Math.Sin((5 * fx) + 3 * m * absfx); // итоговое значение

                label3.Text = Convert.ToString(rezultat); // вывод итог. знач.
            }


            if (radioButton2.Checked)
            {
                double m = Convert.ToDouble(textBox2.Text);

                double x = Convert.ToDouble(textBox1.Text);
                if (x <= m)
                { MessageBox.Show("Введены неверные данные(ищите сами)"); }



                double fx = Math.Pow(x, 2);
                double absfx = Math.Abs(fx);

                double rezultat = Math.Cos((3 * fx) + 5 * m * absfx);

                label3.Text = Convert.ToString(rezultat);
            }

            if (radioButton3.Checked)
            {
                double m = Convert.ToDouble(textBox2.Text);

                double x = Convert.ToDouble(textBox1.Text);
                if (x != m)
                { MessageBox.Show("Введены неверные данные(ищите сами)"); }



                double fx = x;
                double absfx = Math.Abs(fx);

                double rezultat = Math.Pow(fx+m,2);

                label3.Text = Convert.ToString(rezultat);
            }




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
