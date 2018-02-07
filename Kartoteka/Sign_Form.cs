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
    public partial class Sign_Form : Form
    {
        public Sign_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            if (data.Sign_Check(login.Text,password.Text))
            {
                GlobalTab.log_in = login.Text;
                Close();
                
            }
            else { MessageBox.Show("Неверный логин или пароль!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click(object sender, EventArgs e)
        {  
            FReg reg = new FReg();
            reg.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GlobalTab.exit = true;
            Close();
        }

        private void login_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_sel = login;
            GlobalTab.edit_info = "Ввод логина";
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Console.CapsLock.ToString();
            toolStripStatusLabel2.Text = Console.NumberLock.ToString();
            toolStripStatusLabel3.Text = GlobalTab.edit_info;
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalTab.edit_sel = password;
            GlobalTab.edit_info = "Ввод логина";
        }

        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            GlobalTab.edit_sel = password;
            GlobalTab.edit_info = "Ввод пароля";
        }

        private void password_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_sel = password;
            GlobalTab.edit_info = "Ввод пароля";
        }

        private void Sign_Form_Shown(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Console.CapsLock.ToString();
            toolStripStatusLabel2.Text = Console.NumberLock.ToString();
        }
    }
}
