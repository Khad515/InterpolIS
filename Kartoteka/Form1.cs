using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kartoteka;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Diagnostics;


namespace Kartoteka
{
    public partial class Main_Form : Form
    {
        
        public Main_Form()
        {
            
            InitializeComponent();
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (GlobalTab.exit == true) { Close(); }
            toolTip1.SetToolTip(panel1,"Хранилище записей базы данных");
            toolTip1.SetToolTip(chekbutton, "Показать фильтры");
            toolTip1.SetToolTip(button1, "Создать запись");



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }   
          

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void HelpMenu_Click(object sender, EventArgs e)
        {

            Process SysInfo = new Process();
            SysInfo.StartInfo.ErrorDialog = true;
            SysInfo.StartInfo.FileName = Application.StartupPath + @"\InterpolHelp.chm";
            SysInfo.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FError err = new FError();
            GlobalTab.error_text = "Нажал на button5";
            err.ShowDialog();
        }
        
        public void HelpClick()
        {
            HelpMenu.PerformClick();
            
        }

        private void Main_Form_Shown(object sender, EventArgs e)
        {

            if (GlobalTab.exit == true) { Close(); }
            ClearObjects();
            InterpolContext context = new InterpolContext();

            GlobalTab gl = new GlobalTab();
            GlobalTab.pages_count = gl.PageCount(context.Persons.Count());
            

            var personList = context.Persons.OrderBy(c => c.person_id).Take(12).ToList();
            for (int i = 0; i < personList.Count(); i++)
            {
                GlobalTab.dic1.Add(i, new Panel());
                GlobalTab.dic1[i].Name = "panelC" + i;
                Controls.Add(GlobalTab.dic1[i]);
                panel1.Controls.Add(GlobalTab.dic1[i]);
                GlobalTab.dic1[i].Size = new Size(200, 100);
                GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                GlobalTab.dic1[i].Cursor = Cursors.Hand;
                GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                GlobalTab.dic2.Add(i, new Label());
                GlobalTab.dic2[i].Name = "labeldicOne" + i;
                GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                GlobalTab.dic2[i].Location = new Point(1, 10);
                GlobalTab.dic2[i].AutoSize = false;
                GlobalTab.dic2[i].Size = new Size(180, 14);
                GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                GlobalTab.dic3.Add(i, new Label());
                GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                GlobalTab.dic3[i].Location = new Point(100, 50);
                GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                if (GlobalTab.width >= 660)
                {
                    GlobalTab.width = 0;
                    GlobalTab.heaight += 130;
                }
                else { GlobalTab.width += 220; }
            }



            FWelcome wform = new FWelcome();
            wform.ShowDialog();
           
            GlobalTab.pages_count = gl.PageCount(context.Persons.Count());
            GlobalTab.count_datarows = context.Persons.Count();
            Count_row_lbl.Text = GlobalTab.count_datarows.ToString();

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            People_Book book = new People_Book();
            book.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           
        }

        private void открытьФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            
            notifyIcon1.Visible = false;
        }

        private void закрытьФормуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            FData_Create fdata = new FData_Create();
            fdata.ShowDialog();
        }

        private void next_btn_Click(object sender, EventArgs e)
        {
            InterpolContext context = new InterpolContext();
            ClearObjects();
            GlobalTab gl = new GlobalTab();
            GlobalTab.pages_count = gl.PageCount(context.Persons.Count());

            if(Convert.ToUInt32(page_label.Text) == GlobalTab.pages_count )
            {
                next_btn.Enabled = false;
                back_btn.Enabled = true;
            }else
            {
                next_btn.Enabled = true;
                page_label.Text = (int.Parse(page_label.Text) + 1).ToString();
            }

            

        }

        public void ClearObjects()
        {
            for (int i = 0; i < GlobalTab.dic1.Count; i++)
            {
                GlobalTab.dic1[i].Dispose();
                GlobalTab.dic2[i].Dispose();
                GlobalTab.dic3[i].Dispose();

            }
            GlobalTab.dic1.Clear();
            GlobalTab.dic2.Clear();
            GlobalTab.dic3.Clear();
            GlobalTab.width = 0;
            GlobalTab.heaight = 0;
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            InterpolContext context = new InterpolContext();
            ClearObjects();
            GlobalTab gl = new GlobalTab();
            GlobalTab.pages_count = gl.PageCount(context.Persons.Count());
            if (int.Parse(page_label.Text) == 1)
            {
                back_btn.Enabled = false;
                next_btn.Enabled = true;
            }
            else
            {
                page_label.Text = (int.Parse(page_label.Text) - 1).ToString();
                next_btn.Enabled = true;
                if (int.Parse(page_label.Text) == 1) { back_btn.Enabled = false; }
            }
        }

        private void panel_click(object sender, EventArgs e)
        {
            GlobalTab.data_id = int.Parse((sender as Panel).Tag.ToString());
            FData_View data_view = new FData_View();
            data_view.Show();
        }

        private void page_label_TextChanged(object sender, EventArgs e)
        {
            InterpolContext context = new InterpolContext();

            if (int.Parse(page_label.Text) == 1)
            {
                var personList = context.Persons.OrderBy(c => c.person_id).Take(12).ToList();
                for (int i = 0; i < personList.Count(); i++)
                {
                    GlobalTab.dic1.Add(i, new Panel());
                    GlobalTab.dic1[i].Name = "panelC" + i;
                    Controls.Add(GlobalTab.dic1[i]);
                    panel1.Controls.Add(GlobalTab.dic1[i]);
                    GlobalTab.dic1[i].Size = new Size(200, 100);
                    GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                    GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                    GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                    GlobalTab.dic1[i].Cursor = Cursors.Hand;
                    GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                    GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                    GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                    GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                    // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                    GlobalTab.dic2.Add(i, new Label());
                    GlobalTab.dic2[i].Name = "labeldicOne" + i;
                    GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                    GlobalTab.dic2[i].Location = new Point(1, 10);
                    GlobalTab.dic2[i].AutoSize = false;
                    GlobalTab.dic2[i].Size = new Size(180, 14);
                    GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                    // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                    GlobalTab.dic3.Add(i, new Label());
                    GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                    GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                    GlobalTab.dic3[i].Location = new Point(160, 50);
                    GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                    if (GlobalTab.width >= 660)
                    {
                        GlobalTab.width = 0;
                        GlobalTab.heaight += 130;
                    }
                    else { GlobalTab.width += 220; }
                }
            }
            else
            {
                var personList = context.Persons.OrderBy(c => c.person_id).Skip(12 * int.Parse(page_label.Text) - 12).Take(12).ToList();
                for (int i = 0; i < personList.Count(); i++)
                {
                    GlobalTab.dic1.Add(i, new Panel());
                    GlobalTab.dic1[i].Name = "panelC" + i;
                    Controls.Add(GlobalTab.dic1[i]);
                    panel1.Controls.Add(GlobalTab.dic1[i]);
                    GlobalTab.dic1[i].Size = new Size(200, 100);
                    GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                    GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                    GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                    GlobalTab.dic1[i].Cursor = Cursors.Hand;
                    GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                    GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                    GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                    GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                    // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                    GlobalTab.dic2.Add(i, new Label());
                    GlobalTab.dic2[i].Name = "labeldicOne" + i;
                    GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                    GlobalTab.dic2[i].Location = new Point(10, 10);
                    GlobalTab.dic2[i].AutoSize = false;
                    GlobalTab.dic2[i].Size = new Size(180, 14);
                    GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                    // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                    GlobalTab.dic3.Add(i, new Label());
                    GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                    GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                    GlobalTab.dic3[i].Location = new Point(160, 50);
                    GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                    if (GlobalTab.width >= 660)
                    {
                        GlobalTab.width = 0;
                        GlobalTab.heaight += 130;
                    }
                    else { GlobalTab.width += 220; }
                }
            }
        }

        public void panel_mouseUp(object sender, MouseEventArgs e)
        {
            GlobalTab.data_id = int.Parse((sender as Panel).Tag.ToString());
            (sender as Panel).BorderStyle = BorderStyle.Fixed3D;
        }

        public void panel_mouseDown(object sender, MouseEventArgs e)
        {
            GlobalTab.data_id = int.Parse((sender as Panel).Tag.ToString());
            (sender as Panel).BorderStyle = BorderStyle.FixedSingle;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GlobalTab gl = new GlobalTab();
            InterpolContext context = new InterpolContext();
            GlobalTab.pages_count = gl.PageCount(context.Persons.Count());

            if (Convert.ToUInt32(page_label.Text) == GlobalTab.pages_count)
            {
                next_btn.Enabled = false;
                if (GlobalTab.pages_count == 1) { back_btn.Enabled = false; }else { back_btn.Enabled = true; }
                
            }
            else
            {
                next_btn.Enabled = true;
            }


            if (GlobalTab.filter == false)
            {
                if (int.Parse(Count_row_lbl.Text) != GlobalTab.count_datarows)
                {
                    
                    
                    GlobalTab.pages_count = gl.PageCount(context.Persons.Count());
                    GlobalTab.count_datarows = context.Persons.Count();
                    Count_row_lbl.Text = GlobalTab.count_datarows.ToString();
                    ClearObjects();
                    if (int.Parse(page_label.Text) == 1)
                    {

                        var personList = context.Persons.OrderBy(c => c.person_id).Take(12).ToList();
                        for (int i = 0; i < personList.Count(); i++)
                        {
                            GlobalTab.dic1.Add(i, new Panel());
                            GlobalTab.dic1[i].Name = "panelC" + i;
                            Controls.Add(GlobalTab.dic1[i]);
                            panel1.Controls.Add(GlobalTab.dic1[i]);
                            GlobalTab.dic1[i].Size = new Size(200, 100);
                            GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                            GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                            GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                            GlobalTab.dic1[i].Cursor = Cursors.Hand;
                            GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                            GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                            GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                            GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                            // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                            GlobalTab.dic2.Add(i, new Label());
                            GlobalTab.dic2[i].Name = "labeldicOne" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                            GlobalTab.dic2[i].Location = new Point(1, 10);
                            GlobalTab.dic2[i].AutoSize = false;
                            GlobalTab.dic2[i].Size = new Size(180, 14);
                            GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                            // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                            GlobalTab.dic3.Add(i, new Label());
                            GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                            GlobalTab.dic3[i].Location = new Point(160, 50);
                            GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                            if (GlobalTab.width >= 660)
                            {
                                GlobalTab.width = 0;
                                GlobalTab.heaight += 130;
                            }
                            else { GlobalTab.width += 220; }
                        }
                    }
                    else
                    {
                        var personList = context.Persons.OrderBy(c => c.person_id).Skip(12 * int.Parse(page_label.Text) - 12).Take(12).ToList();
                        for (int i = 0; i < personList.Count(); i++)
                        {
                            GlobalTab.dic1.Add(i, new Panel());
                            GlobalTab.dic1[i].Name = "panelC" + i;
                            Controls.Add(GlobalTab.dic1[i]);
                            panel1.Controls.Add(GlobalTab.dic1[i]);
                            GlobalTab.dic1[i].Size = new Size(200, 100);
                            GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                            GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                            GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                            GlobalTab.dic1[i].Cursor = Cursors.Hand;
                            GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                            GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                            GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                            GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                            // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                            GlobalTab.dic2.Add(i, new Label());
                            GlobalTab.dic2[i].Name = "labeldicOne" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                            GlobalTab.dic2[i].Location = new Point(10, 10);
                            GlobalTab.dic2[i].AutoSize = false;
                            GlobalTab.dic2[i].Size = new Size(180, 14);
                            GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                            // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                            GlobalTab.dic3.Add(i, new Label());
                            GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                            GlobalTab.dic3[i].Location = new Point(160, 50);
                            GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                            if (GlobalTab.width >= 660)
                            {
                                GlobalTab.width = 0;
                                GlobalTab.heaight += 130;
                            }
                            else { GlobalTab.width += 220; }
                        }
                    }
                    Count_row_lbl.Text = GlobalTab.count_datarows.ToString();
                }
            }
        }

        private void Main_Form_Activated(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Main_Form_Deactivate(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void chekbutton_CheckStateChanged(object sender, EventArgs e)
        {
            
                     timer2.Enabled = true;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (chekbutton.CheckState == CheckState.Checked)
            {
                if (this.Height != 680)
                { this.Height = this.Height + 5; chekbutton.Enabled = false;groupBox1.Enabled = true; }
                else { chekbutton.Enabled = true; }
            }else if(chekbutton.CheckState == CheckState.Unchecked)
            {
                if (this.Height != 550)
                { this.Height = this.Height - 5; chekbutton.Enabled = false; groupBox1.Enabled = false; }
                else { chekbutton.Enabled = true;timer2.Enabled = false; }
            }
        }

        private void chekbutton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void delete_menustrip_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            if (data.CheckPermit(GlobalTab.data_id) == true) { data.Data_Delete(GlobalTab.data_id); }
            else { MessageBox.Show("Эта запись занята!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            GlobalTab.filter = true;
            if(radioButton1.Checked == true)
            {
                ClearObjects();
                InterpolContext context = new InterpolContext();
                var banditsList = context.Parameters.Where(c => c.person_rise >= numericUpDown1.Value && c.person_rise <= numericUpDown2.Value
                                                                && c.person_weight >= numericUpDown3.Value && c.person_weight <= numericUpDown4.Value).ToList();
                foreach (var r in banditsList)
                {
                    GlobalTab.list_dataid.Add(r.person_id);
                }

                    GlobalTab gl = new GlobalTab();
                    GlobalTab.pages_count = gl.PageCount(banditsList.Count());
                    Count_row_lbl.Text = banditsList.Count().ToString();
                    ClearObjects();
                    if (int.Parse(page_label.Text) == 1)
                    {

                        var personList = context.Persons.Where(c => GlobalTab.list_dataid.Contains(c.person_id)).OrderBy(c => c.person_id).Take(12).ToList();
                        for (int i = 0; i < personList.Count(); i++)
                        {
                            GlobalTab.dic1.Add(i, new Panel());
                            GlobalTab.dic1[i].Name = "panelC" + i;
                            Controls.Add(GlobalTab.dic1[i]);
                            panel1.Controls.Add(GlobalTab.dic1[i]);
                            GlobalTab.dic1[i].Size = new Size(200, 100);
                            GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                            GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                            GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                            GlobalTab.dic1[i].Cursor = Cursors.Hand;
                            GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                            GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                            GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                            GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                            // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                            GlobalTab.dic2.Add(i, new Label());
                            GlobalTab.dic2[i].Name = "labeldicOne" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                            GlobalTab.dic2[i].Location = new Point(1, 10);
                            GlobalTab.dic2[i].AutoSize = false;
                            GlobalTab.dic2[i].Size = new Size(180, 14);
                            GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                            // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                            GlobalTab.dic3.Add(i, new Label());
                            GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                            GlobalTab.dic3[i].Location = new Point(160, 50);
                            GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                            if (GlobalTab.width >= 660)
                            {
                                GlobalTab.width = 0;
                                GlobalTab.heaight += 130;
                            }
                            else { GlobalTab.width += 220; }
                        }
                    }
                    else
                    {
                        var personList = context.Persons.Where(c => GlobalTab.list_dataid.Contains(c.person_id)).OrderBy(c => c.person_id).Skip(12 * int.Parse(page_label.Text) - 12).Take(12).ToList();
                        for (int i = 0; i < personList.Count(); i++)
                        {
                            GlobalTab.dic1.Add(i, new Panel());
                            GlobalTab.dic1[i].Name = "panelC" + i;
                            Controls.Add(GlobalTab.dic1[i]);
                            panel1.Controls.Add(GlobalTab.dic1[i]);
                            GlobalTab.dic1[i].Size = new Size(200, 100);
                            GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                            GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                            GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                            GlobalTab.dic1[i].Cursor = Cursors.Hand;
                            GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                            GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                            GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                            GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                            // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                            GlobalTab.dic2.Add(i, new Label());
                            GlobalTab.dic2[i].Name = "labeldicOne" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                            GlobalTab.dic2[i].Location = new Point(10, 10);
                            GlobalTab.dic2[i].AutoSize = false;
                            GlobalTab.dic2[i].Size = new Size(180, 14);
                            GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                            // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                            GlobalTab.dic3.Add(i, new Label());
                            GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                            GlobalTab.dic3[i].Location = new Point(160, 50);
                            GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                            if (GlobalTab.width >= 660)
                            {
                                GlobalTab.width = 0;
                                GlobalTab.heaight += 130;
                            }
                            else { GlobalTab.width += 220; }
                    }
                    Count_row_lbl.Text = GlobalTab.count_datarows.ToString();
                }
                GlobalTab.list_dataid.Clear();
            }
            else
            {
                if(radioButton2.Checked == true)
                {
                    ClearObjects();
                    InterpolContext context = new InterpolContext();
                    var banditsList = context.Persons.Where(c => c.person_name == filtername_box.Text).ToList();
                    foreach (var r in banditsList)
                    {
                        GlobalTab.list_dataid.Add(r.person_id);
                    }

                    GlobalTab gl = new GlobalTab();
                    GlobalTab.pages_count = gl.PageCount(banditsList.Count());
                    Count_row_lbl.Text = banditsList.Count().ToString();
                    ClearObjects();
                    if (int.Parse(page_label.Text) == 1)
                    {

                        var personList = context.Persons.Where(c => GlobalTab.list_dataid.Contains(c.person_id)).OrderBy(c => c.person_id).Take(12).ToList();
                        for (int i = 0; i < personList.Count(); i++)
                        {
                            GlobalTab.dic1.Add(i, new Panel());
                            GlobalTab.dic1[i].Name = "panelC" + i;
                            Controls.Add(GlobalTab.dic1[i]);
                            panel1.Controls.Add(GlobalTab.dic1[i]);
                            GlobalTab.dic1[i].Size = new Size(200, 100);
                            GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                            GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                            GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                            GlobalTab.dic1[i].Cursor = Cursors.Hand;
                            GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                            GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                            GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                            GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                            // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                            GlobalTab.dic2.Add(i, new Label());
                            GlobalTab.dic2[i].Name = "labeldicOne" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                            GlobalTab.dic2[i].Location = new Point(1, 10);
                            GlobalTab.dic2[i].AutoSize = false;
                            GlobalTab.dic2[i].Size = new Size(180, 14);
                            GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                            // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                            GlobalTab.dic3.Add(i, new Label());
                            GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                            GlobalTab.dic3[i].Location = new Point(160, 50);
                            GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                            if (GlobalTab.width >= 660)
                            {
                                GlobalTab.width = 0;
                                GlobalTab.heaight += 130;
                            }
                            else { GlobalTab.width += 220; }
                        }
                    }
                    else
                    {
                        var personList = context.Persons.Where(c => GlobalTab.list_dataid.Contains(c.person_id)).OrderBy(c => c.person_id).Skip(12 * int.Parse(page_label.Text) - 12).Take(12).ToList();
                        for (int i = 0; i < personList.Count(); i++)
                        {
                            GlobalTab.dic1.Add(i, new Panel());
                            GlobalTab.dic1[i].Name = "panelC" + i;
                            Controls.Add(GlobalTab.dic1[i]);
                            panel1.Controls.Add(GlobalTab.dic1[i]);
                            GlobalTab.dic1[i].Size = new Size(200, 100);
                            GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                            GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                            GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                            GlobalTab.dic1[i].Cursor = Cursors.Hand;
                            GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                            GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                            GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                            GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                            // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                            GlobalTab.dic2.Add(i, new Label());
                            GlobalTab.dic2[i].Name = "labeldicOne" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                            GlobalTab.dic2[i].Location = new Point(10, 10);
                            GlobalTab.dic2[i].AutoSize = false;
                            GlobalTab.dic2[i].Size = new Size(180, 14);
                            GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                            // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                            GlobalTab.dic3.Add(i, new Label());
                            GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                            GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                            GlobalTab.dic3[i].Location = new Point(160, 50);
                            GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                            if (GlobalTab.width >= 660)
                            {
                                GlobalTab.width = 0;
                                GlobalTab.heaight += 130;
                            }
                            else { GlobalTab.width += 220; }
                        }
                        Count_row_lbl.Text = GlobalTab.count_datarows.ToString();
                    }
                    GlobalTab.list_dataid.Clear();
                }
                else
                {
                    if(radioButton3.Checked == true)
                    {
                        ClearObjects();
                        InterpolContext context = new InterpolContext();
                        int syndicate_id = context.Syndicates.Where(c => c.syn_name == syndicate_name_box.Text).Select(c => c.syn_id).FirstOrDefault();
                        var banditsList = context.PSRelations.Where(c => c.sys_id == syndicate_id).ToList();
                        foreach (var r in banditsList)
                        {
                            GlobalTab.list_dataid.Add(r.person_id);
                        }

                        GlobalTab gl = new GlobalTab();
                        GlobalTab.pages_count = gl.PageCount(banditsList.Count());
                        page_label.Text = "1";
                        back_btn.Enabled = false;
                        Count_row_lbl.Text = banditsList.Count().ToString();
                        ClearObjects();
                        if (int.Parse(page_label.Text) == 1)
                        {

                            var personList = context.Persons.Where(c => GlobalTab.list_dataid.Contains(c.person_id)).OrderBy(c => c.person_id).Take(12).ToList();
                            for (int i = 0; i < personList.Count(); i++)
                            {
                                GlobalTab.dic1.Add(i, new Panel());
                                GlobalTab.dic1[i].Name = "panelC" + i;
                                Controls.Add(GlobalTab.dic1[i]);
                                panel1.Controls.Add(GlobalTab.dic1[i]);
                                GlobalTab.dic1[i].Size = new Size(200, 100);
                                GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                                GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                                GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                                GlobalTab.dic1[i].Cursor = Cursors.Hand;
                                GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                                GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                                GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                                GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                                // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                                GlobalTab.dic2.Add(i, new Label());
                                GlobalTab.dic2[i].Name = "labeldicOne" + i;
                                GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                                GlobalTab.dic2[i].Location = new Point(1, 10);
                                GlobalTab.dic2[i].AutoSize = false;
                                GlobalTab.dic2[i].Size = new Size(180, 14);
                                GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                                // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                                GlobalTab.dic3.Add(i, new Label());
                                GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                                GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                                GlobalTab.dic3[i].Location = new Point(160, 50);
                                GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                                if (GlobalTab.width >= 660)
                                {
                                    GlobalTab.width = 0;
                                    GlobalTab.heaight += 130;
                                }
                                else { GlobalTab.width += 220; }
                            }
                        }
                        else
                        {
                            var personList = context.Persons.Where(c => GlobalTab.list_dataid.Contains(c.person_id)).OrderBy(c => c.person_id).Skip(12 * int.Parse(page_label.Text) - 12).Take(12).ToList();
                            for (int i = 0; i < personList.Count(); i++)
                            {
                                GlobalTab.dic1.Add(i, new Panel());
                                GlobalTab.dic1[i].Name = "panelC" + i;
                                Controls.Add(GlobalTab.dic1[i]);
                                panel1.Controls.Add(GlobalTab.dic1[i]);
                                GlobalTab.dic1[i].Size = new Size(200, 100);
                                GlobalTab.dic1[i].BorderStyle = BorderStyle.Fixed3D;
                                GlobalTab.dic1[i].Location = new Point(10 + GlobalTab.width, 10 + GlobalTab.heaight);
                                GlobalTab.dic1[i].Click += new EventHandler(panel_click);
                                GlobalTab.dic1[i].Cursor = Cursors.Hand;
                                GlobalTab.dic1[i].MouseDown += new MouseEventHandler(panel_mouseDown);
                                GlobalTab.dic1[i].MouseUp += new MouseEventHandler(panel_mouseUp);
                                GlobalTab.dic1[i].ContextMenuStrip = data_menu;
                                GlobalTab.dic1[i].Tag = personList.ElementAt(i).person_id.ToString();
                                // Создание Label с словаря dic2 внутри созданного рание Panel(dic1)
                                GlobalTab.dic2.Add(i, new Label());
                                GlobalTab.dic2[i].Name = "labeldicOne" + i;
                                GlobalTab.dic1[i].Controls.Add(GlobalTab.dic2[i]);
                                GlobalTab.dic2[i].Location = new Point(10, 10);
                                GlobalTab.dic2[i].AutoSize = false;
                                GlobalTab.dic2[i].Size = new Size(180, 14);
                                GlobalTab.dic2[i].Text = personList.ElementAt(i).person_name.ToString();
                                // Создание Label с словаря dic3 внутри созданного рание Panel(dic1)
                                GlobalTab.dic3.Add(i, new Label());
                                GlobalTab.dic3[i].Name = "labeldicTwo" + i;
                                GlobalTab.dic1[i].Controls.Add(GlobalTab.dic3[i]);
                                GlobalTab.dic3[i].Location = new Point(160, 50);
                                GlobalTab.dic3[i].Text = personList.ElementAt(i).person_id.ToString();
                                if (GlobalTab.width >= 660)
                                {
                                    GlobalTab.width = 0;
                                    GlobalTab.heaight += 130;
                                }
                                else { GlobalTab.width += 220; }
                            }
                            Count_row_lbl.Text = GlobalTab.count_datarows.ToString();
                        }
                        GlobalTab.list_dataid.Clear();
                    }
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            GlobalTab.filter = false;
        }

        private void update_menustrip_Click(object sender, EventArgs e)
        {
            Work_Data data = new Work_Data();
            if (data.CheckPermit(GlobalTab.data_id) == true)
            {
                FData_Update form_update = new FData_Update();
                form_update.Show();
            }
            else { MessageBox.Show("Эта строка в данный момент занята!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
  
        }

        private void reports_stripMenu_Click(object sender, EventArgs e)
        {
            FReports report = new FReports();
            report.ShowDialog();
        }

        private void вРазработкеToolStripMenuItem14_Click(object sender, EventArgs e)
        {
            FProgram_Info inf = new FProgram_Info();
            inf.Show();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            info_lbl.Text = "Хранилище записей базы данных";
        }

        private void Main_Form_MouseMove(object sender, MouseEventArgs e)
        {
            info_lbl.Text = "Главная среда работы";
        }

        private void next_btn_MouseMove(object sender, MouseEventArgs e)
        {
            info_lbl.Text = "Выбрать следущие 12 записей";
        }

        private void back_btn_MouseMove(object sender, MouseEventArgs e)
        {
            info_lbl.Text = "Выбрать предыдущие 12 записей";
        }

        private void chekbutton_MouseMove(object sender, MouseEventArgs e)
        {
            info_lbl.Text = "Показать фильтры";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            info_lbl.Text = "Создать запись";
        }

        private void вРазработкеToolStripMenuItem15_Click(object sender, EventArgs e)
        {
            FAuthors_Inform inf = new FAuthors_Inform();
            inf.Show();
        }

        private void toolStrip_syndicate_Click(object sender, EventArgs e)
        {
            FSyndicate_Create syn = new FSyndicate_Create();
            syn.ShowDialog();
        }

        private void AddDelete_menustrip_Click(object sender, EventArgs e)
        {

            Work_Data data = new Work_Data();
            if (data.CheckPermit(GlobalTab.data_id) == true)
            {
                FPreson_Syndicate ps = new FPreson_Syndicate();
                ps.ShowDialog();
            }
            else { MessageBox.Show("Эта строка в данный момент занята!", "База данных", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
        }

        private void minFormButton1_Load(object sender, EventArgs e)
        {

        }

        private void свернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            notifyIcon1.Visible = true;
            this.Hide();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

  

}
