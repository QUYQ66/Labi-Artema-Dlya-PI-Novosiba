using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("мама мыла раму");
            listBox1.Items.Add("Привет, мир!");
            listBox1.Items.Add("Томский политехнический университет");
            listBox1.Items.Add("Visual c#");
            label1.Text = "";

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            string str = listBox1.Items[i].ToString();
            int index = 0;
            for (int j = 0; j < str.Length; j++)
                if (str[j] == ' ')
                { index++; }
            label1.Text = "Количество пробелов - " + index.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* string buf = string.Empty;


             string[] stroka = str.Split(' ');

             for (int j = 0; j < str.Count(); i++)
             {
                 buf = str[i].Substring(0, 1).ToUpper();
                 arr[i] = buf + arr[i].Substring(1, arr[i].Length - 1);
             }
            */

            int a = listBox1.SelectedIndex; //запомнить индекс выбранной строки в листбоксе
            string str = listBox1.Items[a].ToString();
            // string str = "some example";
            string buf = string.Empty;
            string[] arr = str.Split(' '); // запись выбранной строки в масив строк
            string rezultat = string.Empty;
            for (int i = 0; i < arr.Count(); i++) //перебор массива строк
            {
                buf = arr[i].Substring(0, 1).ToUpper(); // запись и поднятие буквы в слове
                arr[i] = buf + arr[i].Substring(1, arr[i].Length-1); //запись всех слов в масив строк
                
                rezultat = rezultat + arr[i] + " "; //запись строк в предложение
            }
            rezultat = rezultat.TrimEnd(); // убираем последний(лишний) пробел

            listBox1.Items.Add(rezultat); // добавляем предложение в листбокс
            //listBox1.Items[a] = rezultat;

            MessageBox.Show( rezultat, "Замена произведена");

        }
    }
}
