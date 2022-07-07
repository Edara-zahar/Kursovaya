using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SD = System.Data;
using MySql.Data.MySqlClient;

namespace Kursovaya
{
    public partial class Form15 : MetroFramework.Forms.MetroForm
    {
        private MySqlConnection mycon;

        public void MyExecuteNonQuery(string SqlText)
        {
            MySqlConnection mycon;
            MySqlCommand mycom;

            // выделение памяти с инициализацией строки соединения с базой данных
            mycon = new MySqlConnection(Form1.Connstr);
            mycon.Open();// открыть источник данных
            mycom = mycon.CreateCommand(); //Задать SQL-команду
            mycom.CommandText = SqlText; // Задать командную строку
            mycom.ExecuteNonQuery(); // Выполнить SQL-команду
            mycon.Close(); // Закрыть источник данных
        }
        public Form15()
        {
            InitializeComponent();
        }

        private void Form15_Load(object sender, EventArgs e)
        {
            FillSource();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //string increment = "ALTER TABLE отчёт ADD IDENTITY(Код_Товара);";
            string SqlText;

            //Сформировать SQL-Строку
            SqlText = "INSERT INTO отчёт (Пациентов,Расходы,Прибыль,Дата) VALUES(";
            SqlText = SqlText + "\'" + metroTextBox1.Text + "\', ";
            SqlText = SqlText + "\'" + metroTextBox2.Text + "\', ";
            SqlText = SqlText + "\'" + metroTextBox3.Text + "\', ";
            SqlText = SqlText + "\'" + metroTextBox4.Text + "\') ";


            // выполнить SQL-команду
            //MyExecuteNonQuery(increment);
            try
            {
                MyExecuteNonQuery(SqlText);
            }
            catch
            {
                MessageBox.Show("Ошибка, введены некорректные данные! Проверьте поле с телефоном сотрудника и введите число без пробела и других знаков. Проверьте остальные поля.");
            }

            //отобразить таблицу Source
            FillSource();
        }
        private void FillSource()
        {
            mycon = new MySqlConnection(Form1.Connstr);
            mycon.Open();
            string query = "SELECT * FROM отчёт;";
            MySqlCommand command = new MySqlCommand(query, mycon);
            command.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(query, mycon);
            SD.DataTable table = new SD.DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            mycon.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //кнопка удаления
            int index, n;
            string Id_Source;
            string SqlText = "DELETE FROM отчёт WHERE отчёт.id = ";
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            index = dataGridView1.CurrentRow.Index;
            Id_Source = Convert.ToString(dataGridView1[0, index].Value);
            SqlText = SqlText + Id_Source;
            try
            {
                MyExecuteNonQuery(SqlText);
            }
            catch
            {
                MessageBox.Show("Ошибка удаления");
            }
            FillSource();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            //кнопка редактирования
            int index, n;
            string SqlText = "UPDATE отчёт SET ";
            string Id_Source, pacientov, rashodi, pribyl, data;
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            index = dataGridView1.CurrentRow.Index;
            Id_Source = dataGridView1[0, index].Value.ToString();
            pacientov = metroTextBox1.Text;
            rashodi = metroTextBox2.Text;
            pribyl = metroTextBox3.Text;
            data = metroTextBox4.Text;
            SqlText += "Пациентов = \'" + pacientov + "\',Расходы = '" + rashodi + "\',Прибыль = '" + pribyl + "\',Дата = '" + data + "\'";
            SqlText += "WHERE отчёт.id = " + Id_Source;
            try
            {
                MyExecuteNonQuery(SqlText);
            }
            catch
            {
                MessageBox.Show("ошибка, введены некорректные данные!");
            }
            FillSource();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
