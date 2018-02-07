using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kartoteka
{
    public partial class FReg : Form
    {
        public FReg()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (login.Text != "" && password.Text != "" && password_check.Text != "")
            {
                if (password.Text == password_check.Text)
                {
                    Work_Data data = new Work_Data();

                    if (!data.Check_Data(login.Text))
                    {
                        data.Set_Data(login.Text, password.Text);
                        Close();
                    }else { MessageBox.Show("Такой логин уже зарегистрирован!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Поля для паролей должны быть одинаковыми!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else {  MessageBox.Show("Одно из полей пустое!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error); } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FReg_Shown(object sender, EventArgs e)
        {
            UsersContext context = new UsersContext();
            foreach(var r in context.Passwords.ToList())
            {
                comboBox1.Items.Add(r.login);
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Work_Data data = new Work_Data();
            data.Delete_Data(comboBox1.SelectedItem.ToString());
            comboBox1.Items.Clear();
            UsersContext context = new UsersContext();
            foreach (var r in context.Passwords.ToList())
            {
                comboBox1.Items.Add(r.login);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            data.TextClear(login);
            data.TextClear(password);
            data.TextClear(password_check);
        }
    }
}
