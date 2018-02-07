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
    public partial class FError : Form
    {
        public FError()
        {
            InitializeComponent();
        }

        private void FError_Shown(object sender, EventArgs e)
        {
            error_info.Text = GlobalTab.error_text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
