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
    public partial class FData_Create : Form
    {
        public FData_Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main_Form form = new Main_Form();
            form.HelpClick();
        }

        private void fonAllTextButton1_Load(object sender, EventArgs e)
        {

        }

        private void statusPanelUS1_Load(object sender, EventArgs e)
        {

        }

        private void F_Inform_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void F_Inform_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void F_Inform_Shown(object sender, EventArgs e)
        {
      
          
       
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        
           
       
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void F_Inform_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
          
        
          
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            
         
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
          
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Console.CapsLock.ToString();
            toolStripStatusLabel2.Text = Console.NumberLock.ToString();
            toolStripStatusLabel3.Text = GlobalTab.edit_info;
        }

        private void text_pass_KeyPress(object sender, KeyPressEventArgs e)
        {

            
          
            
        }

        private void text_pass_TextChanged(object sender, EventArgs e)
        {

            
         
            
        }

        private void text_pass_Enter(object sender, EventArgs e)
        {

           
        
        
        }

        private void F_Inform_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Click_1(object sender, EventArgs e)
        {
            GlobalTab.edit_sel = name_box;
            GlobalTab.edit_info = "ФИО преступника";
        }

        private void numericUpDown1_Click(object sender, EventArgs e)
        {
            
            GlobalTab.edit_info = "Рост преступника";
        }

        private void numericUpDown2_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_info = "Вес преступника";
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_info = "Дата рождения преступника";
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_sel = citizen_box;
            GlobalTab.edit_info = "Гражданство преступника";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_sel = bname_box;
            GlobalTab.edit_info = "Бандитский псевдоним преступника";
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_sel = profession_box;
            GlobalTab.edit_info = "Род деятельности преступника";
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            data.TextClear(name_box);
            data.TextClear(bname_box);
            data.TextClear(coloreye_box);
            data.TextClear(haircolor_box);
            data.TextClear(birth_mbox);
            data.TextClear(citizen_box);
            data.TextClear(profession_box);
            data.TextClear(role_box);



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Work_Data wdata = new Work_Data();
            if (!wdata.Check_nickname(bname_box.Text))
            {
                wdata.CreateDataRow(name_box.Text, bname_box.Text, birth_mbox.Text, GlobalTab.path_photo, status_combobox.SelectedItem.ToString(), religion_combobox.SelectedItem.ToString(), language_combobox.SelectedItem.ToString(),
                    profession_box.Text, role_box.Text, Convert.ToInt32(rise_numbox.Value), Convert.ToInt32(weight_numbox.Value),
                    coloreye_box.Text, haircolor_box.Text, citizen_box.Text, national_combobox.SelectedItem.ToString());
                MessageBox.Show("Запись успешно создана!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GlobalTab.count_datarows++;
            }
            else MessageBox.Show("Такое прозвище уже существует, задайте другое!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void sname_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void sname_lbl_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                GlobalTab.path_photo = openFileDialog1.FileName.ToString();
                pictureBox1.Load(openFileDialog1.FileName);
            }
                    
        }

        private void color_btn_Click(object sender, EventArgs e)
        {
        }

        private void language_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void coloreye_box_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_info = "Цвет глаз преступника";
        }

        private void haircolor_box_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_info = "Цвет волос преступника";
        }

        private void status_box_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_info = "Статус преступника";
        }

        private void national_box_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_info = "Национальность преступника";
        }

        private void role_box_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_info = "Роль преступника в профессии";
        }

        private void religion_box_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_info = "Религия преступника";
        }

        private void language_box_Click(object sender, EventArgs e)
        {
            GlobalTab.edit_info = "Основной язык общения преступника";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
