using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using SD = System.Data;

namespace Kursovaya
{
    public partial class Form17 : MetroFramework.Forms.MetroForm
    {
        public MySqlConnection mycon;
        public MySqlCommand mycom;
        public SD.DataSet ds;

        public string Data()
        {
            return metroTextBox1.Text;
        }

        public Form17()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(metroTextBox1.Text, out int value))
            {
                mycon = new MySqlConnection(Form1.Connstr);
                mycon.Open();
                string SqlText;
                Data();
                SqlText = "SELECT * FROM Пациенты WHERE Зубная_карта = " + Data();
                MySqlDataAdapter da = new MySqlDataAdapter(SqlText, mycon);
                SD.DataTable table = new SD.DataTable();
                da.Fill(table);

                Form18 f = new Form18();
                f.dataGridView1.DataSource = table;

                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Вы указали не числовое значение:");
                Form17 f = new Form17();
                f.ShowDialog();
            }
        }

        private void Form17_Load(object sender, EventArgs e)
        {

        }

        private void Form17_Load_1(object sender, EventArgs e)
        {

        }
    }
}
