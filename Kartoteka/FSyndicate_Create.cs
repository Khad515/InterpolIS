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
    public partial class FSyndicate_Create : Form
    {
        public FSyndicate_Create()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work_Data wdata = new Work_Data();

            if (!wdata.Check_SyndicateName(syndicate_name_box.Text))
            {
                wdata.CreateSyndicate(syndicate_name_box.Text, syndicate_date_box.Text);
                MessageBox.Show("Запись успешно создана!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Такой синдикат уже существует, задайте другое!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error);

            InterpolContext context = new InterpolContext();

                dataGridView1.Rows.Clear();
                foreach (var r in context.Syndicates.ToList())
                {
                    dataGridView1.Rows.Add(r.syn_id, r.syn_name, r.syn_date);
                }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            InterpolContext context = new InterpolContext();
            if(context.Syndicates.Count() != 0)
            {
                dataGridView1.Rows.Clear();
                foreach (var r in context.Syndicates.ToList())
                {
                    dataGridView1.Rows.Add(r.syn_id,r.syn_name,r.syn_date);
                }
            }
        }

        private void FSyndicate_Create_Shown(object sender, EventArgs e)
        {
            InterpolContext context = new InterpolContext();
            
            if (context.Syndicates.Count() != 0)
            {
                dataGridView1.Rows.Clear();
                foreach (var r in context.Syndicates.ToList())
                {
                    dataGridView1.Rows.Add(r.syn_id, r.syn_name, r.syn_date);
                    
                }

                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work_Data work = new Work_Data();
            InterpolContext context = new InterpolContext();

            if(context.Syndicates.Any(c => c.syn_id == id_num.Value))
            { 

            work.Syndicate_Delete(Convert.ToInt32(id_num.Value));
            if (context.Syndicates.Count() != 0)
            {
                dataGridView1.Rows.Clear();
                foreach (var r in context.Syndicates.ToList())
                {
                    dataGridView1.Rows.Add(r.syn_id, r.syn_name, r.syn_date);
                }
            }
            MessageBox.Show("Запись успешно удаленна!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }else { MessageBox.Show("Не существует записи с таким id!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
