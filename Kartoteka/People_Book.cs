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
    public partial class People_Book : Form
    {
        public People_Book()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            data.FormTerminate(this);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            data.FormTerminate(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            data.TextClear(textBox1);
            data.TextClear(textBox2);
            data.TextClear(maskedTextBox1);
            data.TextClear(maskedTextBox2);
        }
    }
}
