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
    public partial class FData_Update : Form
    {
        public FData_Update()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            name_box.Text = bandit_name_lbl.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nickname_box.Text = bandit_nickname_lbl.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rise_numbox.Value = int.Parse(bandit_rise_lbl.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            weight_numbox.Value = int.Parse(bandit_weight_lbl.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            coloreye_box.Text = bandit_coloreye_lbl.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            colorhair_box.Text = bandit_colorhair_lbl.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            birthdate_mbox.Text = bandit_birthday_lbl.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            citizen_box.Text = bandit_citizen_lbl.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            nationality_box.Text = bandit_nationality_lbl.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            profession_box.Text = bandit_profession_lbl.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            role_box.Text = bandit_role_lbl.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            religion_box.Text = bandit_religion_lbl.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            language_box.Text = bandit_language_lbl.Text;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            status_box.Text = bandit_status_lbl.Text;
        }

        private void FData_Update_Shown(object sender, EventArgs e)
        {
            Work_Data gl = new Work_Data();
            gl.ClosePermit(GlobalTab.data_id);
            bandit_name_lbl.Text = gl.Return_banditName(GlobalTab.data_id);
            bandit_nickname_lbl.Text = gl.Return_banditNickname(GlobalTab.data_id);
            bandit_rise_lbl.Text = gl.Return_banditRise(GlobalTab.data_id).ToString();
            bandit_weight_lbl.Text = gl.Return_banditWeight(GlobalTab.data_id).ToString();
            bandit_coloreye_lbl.Text = gl.Return_banditEyecolor(GlobalTab.data_id);
            bandit_colorhair_lbl.Text = gl.Return_banditHaircolor(GlobalTab.data_id);
            bandit_birthday_lbl.Text = gl.Return_banditBirthday(GlobalTab.data_id);
            bandit_citizen_lbl.Text = gl.Return_banditCitizenship(GlobalTab.data_id);
            bandit_nationality_lbl.Text = gl.Return_banditNationality(GlobalTab.data_id);
            bandit_profession_lbl.Text = gl.Return_banditProfession(GlobalTab.data_id);
            bandit_role_lbl.Text = gl.Return_banditProfRole(GlobalTab.data_id);
            bandit_religion_lbl.Text = gl.Return_banditReligion(GlobalTab.data_id);
            bandit_language_lbl.Text = gl.Return_banditLanguage(GlobalTab.data_id);
            bandit_status_lbl.Text = gl.Return_banditStatus(GlobalTab.data_id);
            pictureBox1.Load(gl.Return_banditPhoto(GlobalTab.data_id));
            bandit_id_lbl.Text = GlobalTab.data_id.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            if(name_box.Text != bandit_name_lbl.Text) { data.UpdatePerson_Name(GlobalTab.data_id, name_box.Text);}
            if(nickname_box.Text != bandit_nickname_lbl.Text) { data.UpdatePerson_Nickname(GlobalTab.data_id, nickname_box.Text); }
            if (rise_numbox.Value != int.Parse(bandit_rise_lbl.Text)) { data.UpdatePerson_Rise(GlobalTab.data_id, Convert.ToInt32(rise_numbox.Value)); }
            if (weight_numbox.Value != int.Parse(bandit_weight_lbl.Text)) { data.UpdatePerson_Weight(GlobalTab.data_id, Convert.ToInt32(weight_numbox.Value)); }
            if (coloreye_box.Text != bandit_coloreye_lbl.Text) { data.UpdatePerson_Eyecolor(GlobalTab.data_id, coloreye_box.Text); }
            if (colorhair_box.Text != bandit_colorhair_lbl.Text) { data.UpdatePerson_Haircolor(GlobalTab.data_id, colorhair_box.Text); }
            if (birthdate_mbox.Text != bandit_birthday_lbl.Text) { data.UpdatePerson_Birthday(GlobalTab.data_id, birthdate_mbox.Text); }
            if (citizen_box.Text != bandit_citizen_lbl.Text) { data.UpdatePerson_Citizenship(GlobalTab.data_id, citizen_box.Text); }
            if (nationality_box.Text != bandit_nationality_lbl.Text) { data.UpdatePerson_Nationality(GlobalTab.data_id, nationality_box.Text); }
            if (profession_box.Text != bandit_profession_lbl.Text) { data.UpdatePerson_Profession(GlobalTab.data_id, profession_box.Text); }
            if (role_box.Text != bandit_role_lbl.Text) { data.UpdatePerson_Role(GlobalTab.data_id, role_box.Text); }
            if (religion_box.Text != bandit_religion_lbl.Text) { data.UpdatePerson_Religion(GlobalTab.data_id, religion_box.Text); }
            if (language_box.Text != bandit_language_lbl.Text) { data.UpdatePerson_Language(GlobalTab.data_id, language_box.Text); }
            if (status_box.Text != bandit_status_lbl.Text) { data.UpdatePerson_Status(GlobalTab.data_id, status_box.Text); }
            MessageBox.Show("Данные успешно измененны!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GlobalTab.count_datarows++;
            if (data.Check_nickname(nickname_box.Text))
            {

            }
        }

        private void FData_Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            Work_Data data = new Work_Data();
            data.OpenPermit(GlobalTab.data_id);
        }

        private void FData_Update_Load(object sender, EventArgs e)
        {

        }
    }
}
