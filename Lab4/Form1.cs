using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        double[] mas = new double[18];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add(Convert.ToString(mas[i]));
                mas[i] = Math.Pow(0.13 * mas[i], 3) - 2.5 * mas[i] + 8;
                listBox2.Items.Add(Convert.ToString(mas[i]));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rand.Next(-50, 50);
                listBox1.Items.Add(Convert.ToString(mas[i]));
                mas[i] = Math.Pow(0.13 * mas[i], 3) - 2.5 * mas[i] + 8;
                listBox2.Items.Add(Convert.ToString(mas[i]));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            for(int i = 0; i < mas.Length; i++)
            {
               listBox2.SelectedItems.Add(mas[i]);
                if(mas[i] < 0)
                    label1.Text = label1.Text + mas[i] + "\n";
                
            }
        }
    }
}

