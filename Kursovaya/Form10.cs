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
    public partial class Form10 : MetroFramework.Forms.MetroForm
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
        public Form10()
        {
            InitializeComponent();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            //string increment = "ALTER TABLE сотрудники ADD IDENTITY(Код_Товара);";
            string SqlText;

            //Сформировать SQL-Строку
            SqlText = "INSERT INTO сотрудники (Имя,Фамилия,Отчество,Телефон,Дата_рождения,Номер_карты) VALUES(";
            SqlText = SqlText + "\'" + metroTextBox1.Text + "\', ";
            SqlText = SqlText + "\'" + metroTextBox2.Text + "\', ";
            SqlText = SqlText + "\'" + metroTextBox3.Text + "\', ";
            SqlText = SqlText + "\'" + metroTextBox4.Text + "\', ";
            SqlText = SqlText + "\'" + metroTextBox5.Text + "\', ";
            SqlText = SqlText + "\'" + metroTextBox6.Text + "\') ";


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
            string query = "SELECT * FROM сотрудники;";
            MySqlCommand command = new MySqlCommand(query, mycon);
            command.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(query, mycon);
            SD.DataTable table = new SD.DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            mycon.Close();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            FillSource();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //кнопка удаления
            int index, n;
            string Id_Source;
            string SqlText = "DELETE FROM сотрудники WHERE сотрудники.id = ";
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
            string SqlText = "UPDATE сотрудники SET ";
            string Id_Source, name, firstname, otchestvo, number, bday, karts;
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            index = dataGridView1.CurrentRow.Index;
            Id_Source = dataGridView1[0, index].Value.ToString();
            name = metroTextBox1.Text;
            firstname = metroTextBox2.Text;
            otchestvo = metroTextBox3.Text;
            number = metroTextBox4.Text;
            bday = metroTextBox5.Text;
            karts = metroTextBox6.Text;
            SqlText += "Имя = \'" + name + "\',Фамилия = '" + firstname + "\',Отчество = '" + otchestvo + "\',Телефон = '" + number + "\',Дата_рождения = '" + bday + "\',Номер_карты = '" + karts + "\'";
            SqlText += "WHERE сотрудники.id = " + Id_Source;
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
