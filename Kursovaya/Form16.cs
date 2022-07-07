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
    public partial class Form16 : MetroFramework.Forms.MetroForm
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
        public Form16()
        {
            InitializeComponent();
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            FillSource();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            //string increment = "ALTER TABLE маркетинг ADD IDENTITY(Код_Товара);";
            string SqlText;

            //Сформировать SQL-Строку
            SqlText = "INSERT INTO маркетинг (Название,Тип,Цена,Длительность) VALUES(";
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
            string query = "SELECT * FROM маркетинг;";
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
            string SqlText = "DELETE FROM маркетинг WHERE маркетинг.id = ";
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
            string SqlText = "UPDATE маркетинг SET ";
            string Id_Source, name, tip, cena, srok;
            n = dataGridView1.Rows.Count;
            if (n == 1) return;
            index = dataGridView1.CurrentRow.Index;
            Id_Source = dataGridView1[0, index].Value.ToString();
            name = metroTextBox1.Text;
            tip = metroTextBox2.Text;
            cena = metroTextBox3.Text;
            srok = metroTextBox4.Text;
            SqlText += "Название = \'" + name + "\',Тип = '" + tip + "\',Цена = '" + cena + "\',Длительность = '" + srok + "\'";
            SqlText += "WHERE маркетинг.id = " + Id_Source;
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

        private void metroTextBox5_TextChanged(object sender, EventArgs e)
        {
            string textInBox;
            string searchText;
            if (metroTextBox5.Text != null)
            {
                textInBox = metroTextBox5.Text;
                searchText = "SELECT * FROM маркетинг WHERE id LIKE \"%" + textInBox + "%\"";
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

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
