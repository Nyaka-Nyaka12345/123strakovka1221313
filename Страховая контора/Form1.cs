using System;
using System.Windows.Forms;
using System.IO;

namespace Страховая_контора
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox5.Text.Equals("")) || (textBox6.Text.Equals("")) || (textBox2.Text.Equals("")) || (textBox1.Text.Equals("")))
            {
                MessageBox.Show("Вы не ввели все необходимые данные!!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else
            {
                StreamWriter writer = new StreamWriter(@"C:\1\Страхование.txt");
                writer.WriteLine("Данные о пользователе");
                writer.WriteLine("Фамилия:" + textBox5.Text);
                writer.WriteLine("Имя:" + textBox6.Text);
                writer.WriteLine("Дата рождения" + dateTimePicker1.Text);
                writer.WriteLine("Пол:" + "Муж");
                writer.WriteLine("Адрес");
                writer.WriteLine("Город:" + textBox1.Text);
                writer.WriteLine("Адрес:" + textBox2.Text);
                writer.WriteLine("Дом:" + numericUpDown1.Text);
                writer.WriteLine("кв" + numericUpDown2.Text);
                writer.WriteLine("Вид страхования");
                writer.WriteLine("Вид страхования:" + domainUpDown1.Text);
                writer.WriteLine("Срок страхования");
                writer.WriteLine("Срок страхования:" + domainUpDown2.Text);
                writer.Close();
                MessageBox.Show("Данные сохранены");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void button2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled=true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }
        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
    }
}
