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
    public partial class Form9 : MetroFramework.Forms.MetroForm
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
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string increment = "ALTER TABLE Клиент ADD IDENTITY(Код_Товара);";
            string SqlText;

            //Сформировать SQL-Строку
            SqlText = "INSERT INTO Пациенты (Имя,Фамилия,Отчество,Телефон,Дата_рождения,Счёт_клиента,Зубная_карта) VALUES(";
            SqlText = SqlText + "\'" + textBox1.Text + "\', ";
            SqlText = SqlText + "\'" + textBox2.Text + "\', ";
            SqlText = SqlText + "\'" + textBox3.Text + "\', ";
            SqlText = SqlText + "\'" + textBox4.Text + "\', ";
            SqlText = SqlText + "\'" + textBox5.Text + "\', ";
            SqlText = SqlText + "\'" + textBox6.Text + "\', ";
            SqlText = SqlText + "\'" + textBox7.Text + "\') ";


            // выполнить SQL-команду
            //MyExecuteNonQuery(increment);
            try
            {
                MyExecuteNonQuery(SqlText);
            }
            catch
            {
                MessageBox.Show("Ошибка, введены некорректные данные! Проверьте поле с телефоном пациента и введите число без пробела и других знаков. Проверьте остальные поля.");
            }

            //отобразить таблицу Source
            FillSource();
        }

        private void FillSource()
        {
            mycon = new MySqlConnection(Form1.Connstr);
            mycon.Open();
            string query = "SELECT * FROM Пациенты;";
            MySqlCommand command = new MySqlCommand(query, mycon);
            command.ExecuteNonQuery();
            MySqlDataAdapter da = new MySqlDataAdapter(query, mycon);
            SD.DataTable table = new SD.DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
            mycon.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            FillSource();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //кнопка редактирования
                int index, n;
                string SqlText = "UPDATE Пациенты SET ";
                string Id_Source, name, firstname, otchestvo, number, bday, shet, karta;
                n = dataGridView1.Rows.Count;
                if (n == 1) return;
                index = dataGridView1.CurrentRow.Index;
                Id_Source = dataGridView1[0, index].Value.ToString();
                name = textBox1.Text;
                firstname = textBox2.Text;
                otchestvo = textBox3.Text;
                number = textBox4.Text;
                bday = textBox5.Text;
                shet = textBox6.Text;
                karta = textBox7.Text;
                SqlText += "Имя = \'" + name + "\',Фамилия = '" + firstname + "\',Отчество = '" + otchestvo + "\',Телефон = '" + number + "\',Дата_рождения = '" + bday + "\',Счёт_клиента = '" + shet + "\',Зубная_карта = '" + karta + "\'";
                SqlText += "WHERE Пациенты.id = " + Id_Source;
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            //кнопка удаления
            int index, n;
            string Id_Source;
            string SqlText = "DELETE FROM пациенты WHERE пациенты.id = ";
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
            Close();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            string textInBox;
            string searchText;
            if (metroTextBox1.Text != null)
            {
                textInBox = metroTextBox1.Text;
                searchText = "SELECT * FROM пациенты WHERE id LIKE \"%" + textInBox + "%\"";
                for (int i = 1; i < (dataGridView1.Columns.Count - 1); i++)
                {
                    searchText = searchText + " OR " + dataGridView1.Columns[i].Name + " LIKE \"%" + textInBox + "%\"";
                }
                searchText = searchText + ";";
                mycon = new MySqlConnection(Form1.Connstr);
                mycon.Open();
                MySqlCommand command = new MySqlCommand(searchText, mycon);
                command.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(searchText, mycon);
                SD.DataTable table = new SD.DataTable();
                da.Fill(table);
                dataGridView1.DataSource = table;
                mycon.Close();
            }
        }
    }
}
