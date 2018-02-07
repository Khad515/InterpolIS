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
    public partial class FWelcome : Form
    {
        public FWelcome()
        {
            InitializeComponent();
        }

        private void FWelcome_Load(object sender, EventArgs e)
        {
            Main_Form form_main = new Main_Form();
            Pname.Text = form_main.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Main_Form form_main = new Main_Form();
            form_main.HelpClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
