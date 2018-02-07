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
    public partial class FAuthors_Inform : Form
    {
        public FAuthors_Inform()
        {
            InitializeComponent();
        }

        private void FAuthors_Inform_Shown(object sender, EventArgs e)
        {

            dataGridView1.Rows.Add("№1", 1, 1, 1, 1);
            dataGridView1.Rows.Add("№2", 1, 1, 1, 1);
            dataGridView1.Rows.Add("№3", 1, 1, 1, 1);
            dataGridView1.Rows.Add("№4", 1, 1, 1, 1);
            dataGridView1.Rows.Add("№5", 1, 1, 1, 1);
            dataGridView1.Rows.Add("№6", 1, 1, 1, 1);
            dataGridView1.Rows.Add("№7", 1.6, 0.8, 0.8, 0.8);
            dataGridView1.Rows.Add("№8", 1.6, 0.8, 0.8, 0.8);
            dataGridView1.Rows.Add("№9", 1, 1, 1, 1);
        }
    }
}
