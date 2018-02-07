using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;


namespace Kartoteka
{
    public partial class FReports : Form
    {
        public FReports()
        {
            InitializeComponent();
        }

        private void reports_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalTab gl = new GlobalTab();
            switch (reports_list.SelectedItem.ToString())
            {
                case "по росту":
                    {
                       
                        gl.ObjDispose_Reports();
                        gl.ObjInitial_Label1_Rise();
                        gl.ObjInitial_Num1_Rise_Min();
                        gl.ObjInitial_Label2_Rise();
                        gl.ObjInitial_Num2_Rise_Max();
                        report_info_lbl.Text = "Отчет предоставляет данные о всех бандитах \n"+"указаного роста(от min до max).\n"+"Минимальный и максимальный рост укажите ниже.";
                        GlobalTab.label1_Rise.Text = "От";
                        GlobalTab.label1_Rise.Location = new Point(250,120);

                        GlobalTab.Num1_Rise_Min.Location = new Point(280, 117);
                        GlobalTab.Num1_Rise_Min.Size = new Size(50,20);
                        GlobalTab.Num1_Rise_Min.Value = 0;
                        GlobalTab.Num1_Rise_Min.Minimum = 0;
                        GlobalTab.Num1_Rise_Min.Maximum = 2000;

                        GlobalTab.label2_Rise.Text = "До";
                        GlobalTab.label2_Rise.Location = new Point(355, 120);

                        GlobalTab.Num2_Rise_Max.Location = new Point(395, 117);
                        GlobalTab.Num2_Rise_Max.Size = new Size(50, 20);
                        GlobalTab.Num2_Rise_Max.Value = 0;
                        GlobalTab.Num2_Rise_Max.Minimum = 0;
                        GlobalTab.Num2_Rise_Max.Maximum = 2000;

                        Controls.Add(GlobalTab.Num1_Rise_Min);
                        Controls.Add(GlobalTab.Num2_Rise_Max);
                        Controls.Add(GlobalTab.label1_Rise);
                        Controls.Add(GlobalTab.label2_Rise);

                        break;
                    }
                case "по весу":
                    {
                        gl.ObjDispose_Reports();
                        gl.ObjInitial_Label1_Weight();
                        gl.ObjInitial_Num1_Weight_Min();
                        gl.ObjInitial_Label2_Weight();
                        gl.ObjInitial_Num2_Weight_Max();
                        report_info_lbl.Text = "Отчет предоставляет данные о всех бандитах \n"+"указаного веса(от min до max).\n"+"Минимальный и максимальный вес укажите ниже.";

                        GlobalTab.label1_Weight.Text = "От";
                        GlobalTab.label1_Weight.Location = new Point(250, 120);

                        GlobalTab.Num1_Weight_Min.Location = new Point(280, 117);
                        GlobalTab.Num1_Weight_Min.Size = new Size(50, 20);
                        GlobalTab.Num1_Weight_Min.Value = 0;
                        GlobalTab.Num1_Weight_Min.Minimum = 0;
                        GlobalTab.Num1_Weight_Min.Maximum = 2000;

                        GlobalTab.label2_Weight.Text = "До";
                        GlobalTab.label2_Weight.Location = new Point(355, 120);

                        GlobalTab.Num2_Weight_Max.Location = new Point(395, 117);
                        GlobalTab.Num2_Weight_Max.Size = new Size(50, 20);
                        GlobalTab.Num2_Weight_Max.Value = 0;
                        GlobalTab.Num2_Weight_Max.Minimum = 0;
                        GlobalTab.Num2_Weight_Max.Maximum = 2000;

                        Controls.Add(GlobalTab.Num1_Weight_Min);
                        Controls.Add(GlobalTab.Num2_Weight_Max);
                        Controls.Add(GlobalTab.label1_Weight);
                        Controls.Add(GlobalTab.label2_Weight);

                        break;
                    }
                case "по росту и весу":
                    {
                        gl.ObjDispose_Reports();
                        gl.ObjInitial_Label1_Rise();
                        gl.ObjInitial_Label1_Weight();
                        gl.ObjInitial_Label2_Rise();
                        gl.ObjInitial_Label2_Weight();
                        gl.ObjInitial_Num1_Rise_Min();
                        gl.ObjInitial_Num2_Rise_Max();
                        gl.ObjInitial_Num1_Weight_Min();
                        gl.ObjInitial_Num2_Weight_Max();

                        report_info_lbl.Text = "Отчет предоставляет данные о всех бандитах \n"+"указаного роста и веса(от min до max).\n"+"Минимальный, максимальный рост и вес укажите ниже.";

                        GlobalTab.label1_Rise.Text = "Рост от";
                        GlobalTab.label1_Rise.Location = new Point(250, 120);

                        GlobalTab.Num1_Rise_Min.Location = new Point(320, 117);
                        GlobalTab.Num1_Rise_Min.Size = new Size(50, 20);
                        GlobalTab.Num1_Rise_Min.Value = 0;
                        GlobalTab.Num1_Rise_Min.Minimum = 0;
                        GlobalTab.Num1_Rise_Min.Maximum = 2000;

                        GlobalTab.label2_Rise.Text = "До";
                        GlobalTab.label2_Rise.Location = new Point(395, 120);

                        GlobalTab.Num2_Rise_Max.Location = new Point(445, 117);
                        GlobalTab.Num2_Rise_Max.Size = new Size(50, 20);
                        GlobalTab.Num2_Rise_Max.Value = 0;
                        GlobalTab.Num2_Rise_Max.Minimum = 0;
                        GlobalTab.Num2_Rise_Max.Maximum = 2000;

                        GlobalTab.label1_Weight.Text = "Вес от";
                        GlobalTab.label1_Weight.Location = new Point(250, 160);

                        GlobalTab.Num1_Weight_Min.Location = new Point(320, 157);
                        GlobalTab.Num1_Weight_Min.Size = new Size(50, 20);
                        GlobalTab.Num1_Weight_Min.Value = 0;
                        GlobalTab.Num1_Weight_Min.Minimum = 0;
                        GlobalTab.Num1_Weight_Min.Maximum = 2000;

                        GlobalTab.label2_Weight.Text = "До";
                        GlobalTab.label2_Weight.Location = new Point(395, 160);

                        GlobalTab.Num2_Weight_Max.Location = new Point(445, 157);
                        GlobalTab.Num2_Weight_Max.Size = new Size(50, 20);
                        GlobalTab.Num2_Weight_Max.Value = 0;
                        GlobalTab.Num2_Weight_Max.Minimum = 0;
                        GlobalTab.Num2_Weight_Max.Maximum = 2000;

                        Controls.Add(GlobalTab.Num1_Rise_Min);
                        Controls.Add(GlobalTab.Num2_Rise_Max);
                        Controls.Add(GlobalTab.label1_Rise);
                        Controls.Add(GlobalTab.label2_Rise);
                        Controls.Add(GlobalTab.Num1_Weight_Min);
                        Controls.Add(GlobalTab.Num2_Weight_Max);
                        Controls.Add(GlobalTab.label1_Weight);
                        Controls.Add(GlobalTab.label2_Weight);

                        break;

                    }
                case "по дате рождения":
                    {
                        gl.ObjDispose_Reports();
                        gl.ObjInitial_Mask1_FirstDate();
                        gl.ObjInitial_Mask2_LastDate();
                        gl.ObjInitial_Label1_Rise();// лень создавать отдельный label под остальные репорты.
                        gl.ObjInitial_Label2_Rise();

                        report_info_lbl.Text = "Отчет предоставляет данные о всех бандитах указаной даты рождения.\n"+"Дату рождения укажите ниже.";

                        GlobalTab.label1_Rise.Text = "c";
                        GlobalTab.label1_Rise.AutoSize = true;
                        GlobalTab.label1_Rise.Location = new Point(250, 120);

                        GlobalTab.Date_First.Location = new Point(270,117);
                        GlobalTab.Date_First.Size = new Size(60,60);
                        GlobalTab.Date_First.Mask = "00/00/0000";

                        GlobalTab.label2_Rise.Text = "по";
                        GlobalTab.label2_Rise.AutoSize = true;
                        GlobalTab.label2_Rise.Location = new Point(335, 120);

                        GlobalTab.Date_Last.Location = new Point(360, 117);
                        GlobalTab.Date_Last.Size = new Size(60, 60);
                        GlobalTab.Date_Last.Mask = "00/00/0000";

                        Controls.Add(GlobalTab.label1_Rise);
                        Controls.Add(GlobalTab.label2_Rise);
                        Controls.Add(GlobalTab.Date_First);
                        Controls.Add(GlobalTab.Date_Last);
                        break;

                    }
                case "по религии":
                    {
                        gl.ObjDispose_Reports();
                        gl.ObjInitial_ComboBox_Religion();

                        report_info_lbl.Text = "Отчет предоставляет данные о всех бандитах указаной религии.\n"+"Религию укажите ниже.";

                        GlobalTab.religion_combo.Location = new Point(270,120);
                        GlobalTab.religion_combo.Size = new Size(121,21);
                        GlobalTab.religion_combo.DropDownStyle = ComboBoxStyle.DropDownList;
                        GlobalTab.religion_combo.Items.Add("Атеизм");
                        GlobalTab.religion_combo.Items.Add("Африканская");
                        GlobalTab.religion_combo.Items.Add("Бахаи");
                        GlobalTab.religion_combo.Items.Add("Буддизм");
                        GlobalTab.religion_combo.Items.Add("Джайнизм");
                        GlobalTab.religion_combo.Items.Add("Диаспорик");
                        GlobalTab.religion_combo.Items.Add("Зороастризм");
                        GlobalTab.religion_combo.Items.Add("Индуизм");
                        GlobalTab.religion_combo.Items.Add("Ислам");
                        GlobalTab.religion_combo.Items.Add("Иудаизм");
                        GlobalTab.religion_combo.Items.Add("Као даи");
                        GlobalTab.religion_combo.Items.Add("Китайская");
                        GlobalTab.religion_combo.Items.Add("Нео-язычество");
                        GlobalTab.religion_combo.Items.Add("Раставарианизм");
                        GlobalTab.religion_combo.Items.Add("Саиентология");
                        GlobalTab.religion_combo.Items.Add("Сикхизм");
                        GlobalTab.religion_combo.Items.Add("Синто");
                        GlobalTab.religion_combo.Items.Add("Спиритизм");
                        GlobalTab.religion_combo.Items.Add("Тенкуо");
                        GlobalTab.religion_combo.Items.Add("Универсализм");
                        GlobalTab.religion_combo.Items.Add("Христианство");
                        GlobalTab.religion_combo.Items.Add("Чучхе");

                        Controls.Add(GlobalTab.religion_combo);

                        break;
                    }
                case "по национальности":
                    {
                        gl.ObjDispose_Reports();
                        gl.ObjInitial_ComboBox_National();

                        report_info_lbl.Text = "Отчет предоставляет данные о всех бандитах указаной национальности.\n"+"Национальность укажите ниже.";


                        GlobalTab.national_combo.Location = new Point(270, 120);
                        GlobalTab.national_combo.Size = new Size(121, 21);
                        GlobalTab.national_combo.DropDownStyle = ComboBoxStyle.DropDownList;
                        GlobalTab.national_combo.Items.Add("Русский");
                        GlobalTab.national_combo.Items.Add("Татар");
                        GlobalTab.national_combo.Items.Add("Украинец");
                        GlobalTab.national_combo.Items.Add("Башкир");
                        GlobalTab.national_combo.Items.Add("Чуваш");
                        GlobalTab.national_combo.Items.Add("Чеченец");
                        GlobalTab.national_combo.Items.Add("Армянин");
                        GlobalTab.national_combo.Items.Add("Аварец");
                        GlobalTab.national_combo.Items.Add("Мордов");
                        GlobalTab.national_combo.Items.Add("Казах");
                        GlobalTab.national_combo.Items.Add("Азербайджанец");
                        GlobalTab.national_combo.Items.Add("Даргинец");
                        GlobalTab.national_combo.Items.Add("Удмурец");
                        GlobalTab.national_combo.Items.Add("Марий");
                        GlobalTab.national_combo.Items.Add("Осетин");
                        GlobalTab.national_combo.Items.Add("Белорус");
                        GlobalTab.national_combo.Items.Add("Кабардин");
                        GlobalTab.national_combo.Items.Add("Якут");
                        GlobalTab.national_combo.Items.Add("Лезгин");
                        GlobalTab.national_combo.Items.Add("Бурят");
                        GlobalTab.national_combo.Items.Add("Ингуш");
                        GlobalTab.national_combo.Items.Add("Норвежец");

                        Controls.Add(GlobalTab.national_combo);

                        break;
                    }

                case "по синдикату":
                    {
                        gl.ObjDispose_Reports();
                        gl.ObjInitial_ComboBox_National();

                        InterpolContext context = new InterpolContext();
                        report_info_lbl.Text = "Отчет предоставляет данные о всех бандитах указаного синдиката.\n" + "Синдикат укажите ниже.";


                        GlobalTab.national_combo.Location = new Point(270, 120);
                        GlobalTab.national_combo.Size = new Size(121, 21);
                        GlobalTab.national_combo.DropDownStyle = ComboBoxStyle.DropDownList;
                        
                        foreach(var r in context.Syndicates.ToList())
                        {
                            GlobalTab.national_combo.Items.Add(r.syn_name);
                        }

                        Controls.Add(GlobalTab.national_combo);
                        break;
                    }
            }
        }

        private void FReports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (word_radio.Checked == true)
            {
                InterpolContext context = new InterpolContext();
                switch (reports_list.SelectedItem.ToString())
                {
                    case "по росту":
                        {
                            List<int> bandits_id = context.Parameters.Where(c => c.person_rise >= GlobalTab.Num1_Rise_Min.Value &&
                                                                                 c.person_rise <= GlobalTab.Num2_Rise_Max.Value).Select(c => c.person_id).ToList();
                            object fileName = Application.StartupPath + "\\reports\\Person_Rise.dotx";
                            Word.Application WordApplication = new Word.Application();

                            Word.Document WordDocument = WordApplication.Documents.Open(fileName);
                            WordDocument.Bookmarks["person_rise_min"].Range.Text = GlobalTab.Num1_Rise_Min.Value.ToString();
                            WordDocument.Bookmarks["person_rise_max"].Range.Text = GlobalTab.Num2_Rise_Max.Value.ToString();

                            foreach (var r in bandits_id)
                            {
                                WordDocument.Bookmarks["person_name"].Range.Text += context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString()+ " Рост:" +
                                    context.Parameters.Where(c => c.person_id == r).Select(c => c.person_rise).FirstOrDefault().ToString() + "\r\n";
                            }
                            WordDocument.Fields.Update();
                            WordApplication.Visible = true;
                         //   WordDocument.SaveAs(@"C:\test.rtf");

                            break;
                        }
                    case "по весу":
                        {
                            List<int> bandits_id = context.Parameters.Where(c => c.person_weight >= GlobalTab.Num1_Weight_Min.Value &&
                                                                                 c.person_weight <= GlobalTab.Num2_Weight_Max.Value).Select(c => c.person_id).ToList();
                            object fileName = Application.StartupPath + "\\reports\\Person_Weight.dotx";
                            Word.Application WordApplication = new Word.Application();

                            Word.Document WordDocument = WordApplication.Documents.Open(fileName);
                            WordDocument.Bookmarks["person_weight_min"].Range.Text = GlobalTab.Num1_Weight_Min.Value.ToString();
                            WordDocument.Bookmarks["person_weight_max"].Range.Text = GlobalTab.Num2_Weight_Max.Value.ToString();

                            foreach (var r in bandits_id)
                            {
                                WordDocument.Bookmarks["person_name"].Range.Text += context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString() + " Вес:" +
                                    context.Parameters.Where(c => c.person_id == r).Select(c => c.person_weight).FirstOrDefault().ToString() + "\r\n";
                            }
                            WordDocument.Fields.Update();
                            WordApplication.Visible = true;
                            break;
                        }
                    case "по росту и весу":
                        {
                            List<int> bandits_id = context.Parameters.Where(c => c.person_rise >= GlobalTab.Num1_Rise_Min.Value &&
                                                                                c.person_rise <= GlobalTab.Num2_Rise_Max.Value &&
                                                                                c.person_weight >= GlobalTab.Num1_Weight_Min.Value &&
                                                                                c.person_weight <= GlobalTab.Num2_Weight_Max.Value).Select(c => c.person_id).ToList();

                            object fileName = Application.StartupPath + "\\reports\\Person_RiseAndWeight.dotx";
                            Word.Application WordApplication = new Word.Application();

                            Word.Document WordDocument = WordApplication.Documents.Open(fileName);
                            WordDocument.Bookmarks["person_rise_min"].Range.Text = GlobalTab.Num1_Rise_Min.Value.ToString();
                            WordDocument.Bookmarks["person_rise_max"].Range.Text = GlobalTab.Num2_Rise_Max.Value.ToString();
                            WordDocument.Bookmarks["person_weight_min"].Range.Text = GlobalTab.Num1_Weight_Min.Value.ToString();
                            WordDocument.Bookmarks["person_weight_max"].Range.Text = GlobalTab.Num2_Weight_Max.Value.ToString();

                            foreach (var r in bandits_id)
                            {
                                WordDocument.Bookmarks["person_name"].Range.Text += context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString() + " Вес:" +
                                    context.Parameters.Where(c => c.person_id == r).Select(c => c.person_weight).FirstOrDefault().ToString() + " Рост:" + 
                                    context.Parameters.Where(c => c.person_id == r).Select(c => c.person_rise).FirstOrDefault().ToString() + "\r\n";
                            }
                            WordDocument.Fields.Update();
                            WordApplication.Visible = true;
                            break;

                        }
                    case "по дате рождения":
                        {
                            GlobalTab gl = new GlobalTab();
                            List<int> bandits_id = gl.GetDatePersons(Convert.ToDateTime(GlobalTab.Date_First.Text), Convert.ToDateTime(GlobalTab.Date_Last.Text));

                            object fileName = Application.StartupPath + "\\reports\\Person_Birthday.dotx";
                            Word.Application WordApplication = new Word.Application();

                            Word.Document WordDocument = WordApplication.Documents.Open(fileName);
                            WordDocument.Bookmarks["person_date_first"].Range.Text = GlobalTab.Date_First.Text;
                            WordDocument.Bookmarks["person_date_last"].Range.Text = GlobalTab.Date_Last.Text;

                            foreach (var r in bandits_id)
                            {
                                WordDocument.Bookmarks["person_name"].Range.Text += context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString() + " " +
                                    context.Persons.Where(c => c.person_id == r).Select(c => c.person_birthday).FirstOrDefault().ToString() + "\r\n";
                            }
                            WordDocument.Fields.Update();
                            WordApplication.Visible = true;
                            break;

                        }
                    case "по религии":
                        {
                            List<int> bandits_id = context.Spirits.Where(c => c.person_religion == GlobalTab.religion_combo.SelectedItem.ToString()).Select(c => c.person_id).ToList();
                            object fileName = Application.StartupPath + "\\reports\\Person_Religion.dotx";
                            Word.Application WordApplication = new Word.Application();

                            Word.Document WordDocument = WordApplication.Documents.Open(fileName);
                            WordDocument.Bookmarks["person_religion"].Range.Text = GlobalTab.religion_combo.SelectedItem.ToString();

                            foreach (var r in bandits_id)
                            {
                                WordDocument.Bookmarks["person_name"].Range.Text += context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString() + " Веруют в " +
                                    context.Spirits.Where(c => c.person_id == r).Select(c => c.person_religion).FirstOrDefault().ToString() + "\r\n";
                            }
                            WordDocument.Fields.Update();
                            WordApplication.Visible = true;
                            break;
                        }
                    case "по национальности":
                        {

                            List<int> bandits_id = context.Passports.Where(c => c.person_nationality == GlobalTab.national_combo.SelectedItem.ToString()).Select(c => c.person_id).ToList();

                            object fileName = Application.StartupPath + "\\reports\\Person_National.dotx";
                            Word.Application WordApplication = new Word.Application();

                            Word.Document WordDocument = WordApplication.Documents.Open(fileName);
                            WordDocument.Bookmarks["person_national"].Range.Text = GlobalTab.national_combo.SelectedItem.ToString();

                            foreach (var r in bandits_id)
                            {
                                WordDocument.Bookmarks["person_name"].Range.Text += context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString() + " " +
                                    context.Passports.Where(c => c.person_id == r).Select(c => c.person_nationality).FirstOrDefault().ToString() + "\r\n";
                            }
                            WordDocument.Fields.Update();
                            WordApplication.Visible = true;

                            break;
                        }

                    case "по синдикату":
                        {
                            int syndicate_id = context.Syndicates.Where(c => c.syn_name == GlobalTab.national_combo.SelectedItem.ToString()).Select(c => c.syn_id).FirstOrDefault();
                            List<int> bandits_id = context.PSRelations.Where(c => c.sys_id == syndicate_id).Select(c => c.person_id).ToList();

                            object fileName = Application.StartupPath + "\\reports\\Person_Syndicate.dotx";
                            Word.Application WordApplication = new Word.Application();

                            Word.Document WordDocument = WordApplication.Documents.Open(fileName);
                            WordDocument.Bookmarks["person_syndicate"].Range.Text = GlobalTab.national_combo.SelectedItem.ToString();

                            foreach (var r in bandits_id)
                            {
                                WordDocument.Bookmarks["person_name"].Range.Text += context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString() + "\r\n";
                            }
                            WordDocument.Fields.Update();
                            WordApplication.Visible = true;

                            break;
                        }
                }

            }
            else
                if (excel_radio.Checked == true)
            {
                InterpolContext context = new InterpolContext();

                switch (reports_list.SelectedItem.ToString())
                {
                    case "по росту":
                        {
                            int i = 1;
                            List<int> bandits_id = context.Parameters.Where(c => c.person_rise >= GlobalTab.Num1_Rise_Min.Value &&
                                                                                 c.person_rise <= GlobalTab.Num2_Rise_Max.Value).Select(c => c.person_id).ToList();

                            Excel.Application ExcelApplication = new Excel.Application();
                            Excel.Workbook newWorkbook = ExcelApplication.Workbooks.Add();
                            Excel.Worksheet currentSheet = (Excel.Worksheet)ExcelApplication.Workbooks[1].Worksheets[1];

                            foreach(var r in bandits_id)
                            {
                                currentSheet.Cells[i, 1] = context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString(); i++;
                            }
                            ExcelApplication.Visible = true;
                            break;
                        }
                    case "по весу":
                        {
                            int i = 1;
                            List<int> bandits_id = context.Parameters.Where(c => c.person_weight >= GlobalTab.Num1_Weight_Min.Value &&
                                                                                 c.person_weight <= GlobalTab.Num2_Weight_Max.Value).Select(c => c.person_id).ToList();

                            Excel.Application ExcelApplication = new Excel.Application();
                            Excel.Workbook newWorkbook = ExcelApplication.Workbooks.Add();
                            Excel.Worksheet currentSheet = (Excel.Worksheet)ExcelApplication.Workbooks[1].Worksheets[1];

                            foreach (var r in bandits_id)
                            {
                                currentSheet.Cells[i, 1] = context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString(); i++;
                            }
                            ExcelApplication.Visible = true;
                            break;
                        }
                    case "по росту и весу":
                        {
                            int i = 1;
                            List<int> bandits_id = context.Parameters.Where(c => c.person_rise >= GlobalTab.Num1_Rise_Min.Value &&
                                                                                c.person_rise <= GlobalTab.Num2_Rise_Max.Value &&
                                                                                c.person_weight >= GlobalTab.Num1_Weight_Min.Value &&
                                                                                c.person_weight <= GlobalTab.Num2_Weight_Max.Value).Select(c => c.person_id).ToList();

                            Excel.Application ExcelApplication = new Excel.Application();
                            Excel.Workbook newWorkbook = ExcelApplication.Workbooks.Add();
                            Excel.Worksheet currentSheet = (Excel.Worksheet)ExcelApplication.Workbooks[1].Worksheets[1];

                            foreach (var r in bandits_id)
                            {
                                currentSheet.Cells[i, 1] = context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString(); i++;
                            }
                            ExcelApplication.Visible = true;
                            break;

                        }
                    case "по дате рождения":
                        {
                            int i = 1;
                            GlobalTab gl = new GlobalTab();
                            List<int> bandits_id = gl.GetDatePersons(Convert.ToDateTime(GlobalTab.Date_First.Text), Convert.ToDateTime(GlobalTab.Date_Last.Text));

                            Excel.Application ExcelApplication = new Excel.Application();
                            Excel.Workbook newWorkbook = ExcelApplication.Workbooks.Add();
                            Excel.Worksheet currentSheet = (Excel.Worksheet)ExcelApplication.Workbooks[1].Worksheets[1];

                            foreach (var r in bandits_id)
                            {
                                currentSheet.Cells[i, 1] = context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString(); i++;
                            }
                            ExcelApplication.Visible = true;
                            break;

                        }
                    case "по религии":
                        {
                            int i = 1;
                            List<int> bandits_id = context.Spirits.Where(c => c.person_religion == GlobalTab.religion_combo.SelectedItem.ToString()).Select(c => c.person_id).ToList();

                            Excel.Application ExcelApplication = new Excel.Application();
                            Excel.Workbook newWorkbook = ExcelApplication.Workbooks.Add();
                            Excel.Worksheet currentSheet = (Excel.Worksheet)ExcelApplication.Workbooks[1].Worksheets[1];

                            foreach (var r in bandits_id)
                            {
                                currentSheet.Cells[i, 1] = context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString(); i++;
                            }
                            ExcelApplication.Visible = true;
                            break;
                        }
                    case "по национальности":
                        {
                            int i = 1;
                            List<int> bandits_id = context.Passports.Where(c => c.person_nationality == GlobalTab.national_combo.SelectedItem.ToString()).Select(c => c.person_id).ToList();

                            Excel.Application ExcelApplication = new Excel.Application();
                            Excel.Workbook newWorkbook = ExcelApplication.Workbooks.Add();
                            Excel.Worksheet currentSheet = (Excel.Worksheet)ExcelApplication.Workbooks[1].Worksheets[1];

                            foreach (var r in bandits_id)
                            {
                                currentSheet.Cells[i, 1] = context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString(); i++;
                            }
                            ExcelApplication.Visible = true;
                            break;
                        }

                    case "по синдикату":
                        {
                            int i = 1;
                            int syndicate_id = context.Syndicates.Where(c => c.syn_name == GlobalTab.national_combo.SelectedItem.ToString()).Select(c => c.syn_id).FirstOrDefault();
                            List<int> bandits_id = context.PSRelations.Where(c => c.sys_id == syndicate_id).Select(c => c.person_id).ToList();

                            Excel.Application ExcelApplication = new Excel.Application();
                            Excel.Workbook newWorkbook = ExcelApplication.Workbooks.Add();
                            Excel.Worksheet currentSheet = (Excel.Worksheet)ExcelApplication.Workbooks[1].Worksheets[1];

                            foreach (var r in bandits_id)
                            {
                                currentSheet.Cells[i, 1] = context.Persons.Where(c => c.person_id == r).Select(c => c.person_name).FirstOrDefault().ToString();
                                i++;
                            }
                            ExcelApplication.Visible = true;
                            break;
                        }
                }

            }
        }



    }
}
