using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Kursovaya
{
    public partial class Form20 : MetroFramework.Forms.MetroForm
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MailAddress from = new MailAddress(metroTextBox1.Text);
                MailAddress to = new MailAddress(metroTextBox5.Text);
                MailMessage message = new MailMessage(from, to);
                message.Subject = metroTextBox3.Text;
                message.Body = metroTextBox4.Text;
                message.IsBodyHtml = metroCheckBox1.Checked;
                SmtpClient smtp = new SmtpClient("smtp.mail.ru", 25);
                smtp.Credentials = new NetworkCredential(metroTextBox1.Text, metroTextBox2.Text);
                smtp.EnableSsl = metroCheckBox2.Checked;
                smtp.Send(message);
                Console.ReadLine();
                Console.WriteLine("Письмо отправлено");
            }
            catch (Exception)
            {
                MessageBox.Show("По указанному адресу письмо отправить не удалось!");
            }
        }

        private void Form20_Load(object sender, EventArgs e)
        {

        }
    }
}
