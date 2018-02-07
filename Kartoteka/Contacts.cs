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
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            data.FormTerminate(this);
        }

        private void Contacts_Shown(object sender, EventArgs e)
        {
            label1.Font = GlobalTab.Gl_font.Font;
            label2.Font = GlobalTab.Gl_font.Font;
            label3.Font = GlobalTab.Gl_font.Font;
            label4.Font = GlobalTab.Gl_font.Font;
            label5.Font = GlobalTab.Gl_font.Font;
            label6.Font = GlobalTab.Gl_font.Font;
            label7.Font = GlobalTab.Gl_font.Font;
            label8.Font = GlobalTab.Gl_font.Font;
            label9.Font = GlobalTab.Gl_font.Font;
            BackColor = GlobalTab.Gl_color.Color;

        }

        private void fonAllTextButton1_Load(object sender, EventArgs e)
        {

        }
    }
}
