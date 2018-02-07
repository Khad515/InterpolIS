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
    public partial class FPreson_Syndicate : Form
    {
        public FPreson_Syndicate()
        {
            InitializeComponent();
        }

        private void FPreson_Syndicate_Shown(object sender, EventArgs e)
        {
            Work_Data gl = new Work_Data();
            InterpolContext context = new InterpolContext();
            gl.ClosePermit(GlobalTab.data_id);
            bandit_id_lbl.Text = GlobalTab.data_id.ToString();
            bandit_name_lbl.Text = gl.Return_banditName(GlobalTab.data_id);
            
            foreach(var r in context.Syndicates.ToList())
            {
                comboBox1.Items.Add(r.syn_name);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work_Data gl = new Work_Data();
            InterpolContext context = new InterpolContext();

            if (Add_radio.Checked == true)
            {
                if (context.PSRelations.Any(c => c.person_id == GlobalTab.data_id))
                {
                    MessageBox.Show("Этот бандит уже прендалежит к синдикату!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    gl.Add_To_Syndicate(GlobalTab.data_id, context.Syndicates.Where(c => c.syn_name == comboBox1.SelectedItem.ToString()).Select(c => c.syn_id).FirstOrDefault(), maskedTextBox1.Text);
                    MessageBox.Show("Запись успешно создана!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                   

            }
            else
            {
                if(Delete_radio.Checked == true)
                {
                    if (context.PSRelations.Any(c => c.person_id == GlobalTab.data_id))
                    {
                        gl.Delete_From_Syndicate(GlobalTab.data_id);
                        MessageBox.Show("Запись успешно удаленна!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else { MessageBox.Show("Этот бандит не прендалежит к выбраному синдикату!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void FPreson_Syndicate_FormClosing(object sender, FormClosingEventArgs e)
        {
            Work_Data gl = new Work_Data();
            gl.OpenPermit(GlobalTab.data_id);
        }

        private void FPreson_Syndicate_Load(object sender, EventArgs e)
        {

        }
    }
}
