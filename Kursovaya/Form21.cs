using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovaya
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
            listBox2.SelectedIndex = 1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string from, to;
            if (metroTextBox2.Text == "")
            {
                from = listBox1.SelectedItem.ToString();
            }
            else
            {
                from = metroTextBox2.Text;
            }
            if (metroTextBox3.Text == "")
            {
                to = listBox2.SelectedItem.ToString();
            }
            else
            {
                to = metroTextBox3.Text;
            }
            if (from == to)
            {
                MessageBox.Show("Это одна и та же валюта. Перевод невозможен!", "Внимание!");
            }
            else if (metroTextBox1.Text == "")
            {
                MessageBox.Show("Введите количество валюты для перевода!", "Внимание!");
            }
            else
            {
                webBrowser1.Navigate("https://www.google.ru/search?q=" + metroTextBox1.Text + " " + from + " %D0%B2 " + to);
            }
        }
    }
}
