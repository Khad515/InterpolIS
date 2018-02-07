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
    public partial class FData_View : Form
    {
        public FData_View()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            data.OpenPermit(GlobalTab.data_id);
            Close();
        }

        private void FData_View_Shown(object sender, EventArgs e)
        {
            Work_Data gl = new Work_Data();
            gl.ClosePermit(GlobalTab.data_id);
            name_lbl.Text = gl.Return_banditName(GlobalTab.data_id);
            nickname_lbl.Text = gl.Return_banditNickname(GlobalTab.data_id);
            rise_lbl.Text = gl.Return_banditRise(GlobalTab.data_id).ToString();
            weight_lbl.Text = gl.Return_banditWeight(GlobalTab.data_id).ToString();
            eyecolor_lbl.Text = gl.Return_banditEyecolor(GlobalTab.data_id);
            haircolor_lbl.Text = gl.Return_banditHaircolor(GlobalTab.data_id);
            birthday_lbl.Text = gl.Return_banditBirthday(GlobalTab.data_id);
            citizenship_lbl.Text = gl.Return_banditCitizenship(GlobalTab.data_id);
            nationality_lbl.Text = gl.Return_banditNationality(GlobalTab.data_id);
            profession_lbl.Text = gl.Return_banditProfession(GlobalTab.data_id);
            role_lbl.Text = gl.Return_banditProfRole(GlobalTab.data_id);
            religion_lbl.Text = gl.Return_banditReligion(GlobalTab.data_id);
            language_lbl.Text = gl.Return_banditLanguage(GlobalTab.data_id);
            status_lbl.Text = gl.Return_banditStatus(GlobalTab.data_id);
            pictureBox1.Load(gl.Return_banditPhoto(GlobalTab.data_id));
            Id_lbl.Text = GlobalTab.data_id.ToString();

        }

        private void FData_View_FormClosing(object sender, FormClosingEventArgs e)
        {
            Work_Data data = new Work_Data();
            data.OpenPermit(GlobalTab.data_id);
        }
    }
}
