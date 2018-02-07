using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Kartoteka
{
    public partial class StatusPanelUS : UserControl
    {
        public StatusPanelUS()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {

        }

        private void StatusPanelUS_Load(object sender, EventArgs e)
        {
            if (toolStripStatusLabel4.Text.Equals(GlobalTab.log_in))
            {
                toolStripStatusLabel2.Text = Console.CapsLock.ToString();
                toolStripStatusLabel3.Text = Console.NumberLock.ToString();
            }
            else
            {
                toolStripStatusLabel4.Text = GlobalTab.log_in;
                toolStripStatusLabel2.Text = Console.CapsLock.ToString();
                toolStripStatusLabel3.Text = Console.NumberLock.ToString();
            }
            
            
        }

        private void иванюкСергейToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStripStatusLabel2.Text = Console.CapsLock.ToString();
            toolStripStatusLabel3.Text = Console.NumberLock.ToString();
        }

        private void statusStrip1_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusPanelUS_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void statusStrip1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void statusStrip1_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void statusStrip1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void statusStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
    }
}
