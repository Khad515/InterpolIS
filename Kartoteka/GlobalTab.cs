using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.Entity;

namespace Kartoteka
{
    class GlobalTab
    {

        public static EventArgs e1;
        public static string log_in;
        public static FontDialog Gl_font = new FontDialog();
        public static ColorDialog Gl_color = new ColorDialog();
        public static bool caps_state = Console.CapsLock;
        public static bool num_state = Console.NumberLock;
        public static TextBox edit_sel = null;
        public static string edit_info = null;
        public static int left = 0;
        public static int top = 0;
        public static int width = 0;
        public static int heaight = 0;
        public static int but_count = 0;
        public static Dictionary<int, Panel> dic1 = new Dictionary<int, Panel>();
        public static Dictionary<int, Label> dic2 = new Dictionary<int, Label>();
        public static Dictionary<int, Label> dic3 = new Dictionary<int, Label>();
        public static int data_id;
        public static int pages_count;
        public static string path_photo;
        public static int count_datarows;
        public static bool filter = false;
        public static List<int> list_dataid = new List<int>();

        public static Label label1_Rise = new Label();
        public static Label label2_Rise = new Label();
        public static Label label1_Weight = new Label();
        public static Label label2_Weight = new Label();
        public static NumericUpDown Num1_Rise_Min = new NumericUpDown();
        public static NumericUpDown Num2_Rise_Max = new NumericUpDown();
        public static NumericUpDown Num1_Weight_Min = new NumericUpDown();
        public static NumericUpDown Num2_Weight_Max = new NumericUpDown();
        public static MaskedTextBox Date_First = new MaskedTextBox();
        public static MaskedTextBox Date_Last = new MaskedTextBox();
        public static ComboBox religion_combo = new ComboBox();
        public static ComboBox national_combo = new ComboBox();
        public static string error_text;
        public static bool exit = false;

        //----------------------------------
        //Фильтр по дате рождения(перебор и проверка всех дат бандитов на вхождения в спектр дат).
        public List<int> GetDatePersons(DateTime d1,DateTime d2)
        {
            DateTime d3;
            InterpolContext context = new InterpolContext();
            var datelist = context.Persons.ToList();
            List<int> idlist = new List<int>();
            foreach(var r in datelist)
            {
                d3 = Convert.ToDateTime(r.person_birthday.ToString());
                if (d1.CompareTo(d3) <= 0 && d2.CompareTo(d3) >= 0) { idlist.Add(r.person_id); }
            }
            return idlist;
        }

        //-----------------------------------------------
        //-----------------------------------------------
        //Работа с инициализацией обьектов для отчетов---
        //-----------------------------------------------
        //-----------------------------------------------

        public void ObjInitial_Label1_Rise()
        {
            GlobalTab.label1_Rise = new Label();
        }

        public void ObjInitial_Label2_Rise()
        {
            GlobalTab.label2_Rise = new Label();
        }

        public void ObjInitial_Label1_Weight()
        {
            GlobalTab.label1_Weight = new Label();
        }

        public void ObjInitial_Label2_Weight()
        {
            GlobalTab.label2_Weight = new Label();
        }

        public void ObjInitial_Num1_Rise_Min()
        {
            GlobalTab.Num1_Rise_Min = new NumericUpDown();
        }

        public void ObjInitial_Num2_Rise_Max()
        {
            GlobalTab.Num2_Rise_Max = new NumericUpDown();
        }

        public void ObjInitial_Num1_Weight_Min()
        {
            GlobalTab.Num1_Weight_Min = new NumericUpDown();
        }

        public void ObjInitial_Num2_Weight_Max()
        {
            GlobalTab.Num2_Weight_Max = new NumericUpDown();
        }

        public void ObjInitial_Mask1_FirstDate()
        {
            GlobalTab.Date_First = new MaskedTextBox();
        }

        public void ObjInitial_Mask2_LastDate()
        {
            GlobalTab.Date_Last = new MaskedTextBox();
        }

        public void ObjInitial_ComboBox_Religion()
        {
            GlobalTab.religion_combo = new ComboBox();
        }

        public void ObjInitial_ComboBox_National()
        {
            GlobalTab.national_combo = new ComboBox();
        }

        public void ObjDispose_Reports()
        {
            GlobalTab.label1_Rise.Dispose();
            GlobalTab.label2_Rise.Dispose();
            GlobalTab.label1_Weight.Dispose();
            GlobalTab.label2_Weight.Dispose();
            GlobalTab.Num1_Rise_Min.Dispose();
            GlobalTab.Num1_Weight_Min.Dispose();
            GlobalTab.Num2_Rise_Max.Dispose();
            GlobalTab.Num2_Weight_Max.Dispose();
            GlobalTab.Date_First.Dispose();
            GlobalTab.Date_Last.Dispose();
            GlobalTab.religion_combo.Dispose();
            GlobalTab.national_combo.Dispose();
        }

        public int PageCount(int rows)
        {
            int pages = rows / 12;
            if (rows % 12 != 0 || pages == 0)
            {
                return pages + 1;
            }
            else
            {
                return pages;
            }
        }
    }


    //-----------------------------------------------
    //Работа с бд------------------------------------
    //-----------------------------------------------


    class Work_Data : GlobalTab
    {
        //---------------------------------
        // Person table--------------------
        //---------------------------------
        public void UpdatePerson_Name(int bandit_id, string new_bandit_name)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Persons.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_name = new_bandit_name;
            context.SaveChanges();
        }

        public void UpdatePerson_Nickname(int bandit_id, string new_bandit_nickname)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Persons.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_nickname = new_bandit_nickname;
            context.SaveChanges();
        }

        public void UpdatePerson_Birthday(int bandit_id, string new_bandit_birthday)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Persons.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_birthday = new_bandit_birthday;
            context.SaveChanges();
        }

        public void UpdatePerson_Status(int bandit_id, string new_bandit_status)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Persons.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_status = new_bandit_status;
            context.SaveChanges();
        }

        public void UpdatePerson_Photo(int bandit_id, string new_bandit_photo)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Persons.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.photo_path = new_bandit_photo;
            context.SaveChanges();
        }

        //---------------------------------
        // Parameters table                   -
        //---------------------------------

        public void UpdatePerson_Rise(int bandit_id, int new_bandit_rise)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Parameters.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_rise = new_bandit_rise;
            context.SaveChanges();
        }

        public void UpdatePerson_Weight(int bandit_id, int new_bandit_Weight)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Parameters.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_weight = new_bandit_Weight;
            context.SaveChanges();
        }

        public void UpdatePerson_Eyecolor(int bandit_id, string new_bandit_eyecolor)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Parameters.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_eyecolor = new_bandit_eyecolor;
            context.SaveChanges();
        }

        public void UpdatePerson_Haircolor(int bandit_id, string new_bandit_haircolor)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Parameters.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_haircolor = new_bandit_haircolor;
            context.SaveChanges();
        }


        //---------------------------------
        // Criminals table                -
        //---------------------------------

        public void UpdatePerson_Profession(int bandit_id, string new_bandit_profession)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Criminals.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_profession = new_bandit_profession;
            context.SaveChanges();
        }

        public void UpdatePerson_Role(int bandit_id, string new_bandit_role)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Criminals.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_role = new_bandit_role;
            context.SaveChanges();
        }

        //---------------------------------
        // Passports table                -
        //---------------------------------

        public void UpdatePerson_Citizenship(int bandit_id, string new_bandit_citizen)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Passports.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_citizenship = new_bandit_citizen;
            context.SaveChanges();
        }

        public void UpdatePerson_Nationality(int bandit_id, string new_bandit_nationality)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Passports.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_nationality = new_bandit_nationality;
            context.SaveChanges();
        }

        //---------------------------------
        // Spirits table                -
        //---------------------------------

        public void UpdatePerson_Religion(int bandit_id, string new_bandit_religion)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Spirits.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_religion = new_bandit_religion;
            context.SaveChanges();
        }

        public void UpdatePerson_Language(int bandit_id, string new_bandit_language)
        {
            InterpolContext context = new InterpolContext();
            var person = context.Spirits.Where(c => c.person_id == bandit_id).FirstOrDefault();
            person.person_language = new_bandit_language;
            context.SaveChanges();
        }


        //-------------------------------------------
        //-------------------------------------------
        //-------------------------------------------
        //-------------------------------------------



        public bool Check_SyndicateName(string synd_name)
        {
            InterpolContext context = new InterpolContext();
            List<string> nick_list = new List<string>();
            foreach (var r in context.Syndicates.ToList())
            {
                nick_list.Add(r.syn_name);
            }
            if (nick_list.Contains(synd_name))
            {
                return true;
            }
            else return false;
        }

        public bool Check_nickname(string bandit_nickname)
        {
            InterpolContext context = new InterpolContext();
            List<string> nick_list = new List<string>();
            foreach (var r in context.Persons.ToList())
            {
                nick_list.Add(r.person_nickname);
            }
            if (nick_list.Contains(bandit_nickname))
            {
                return true;
            }
            else return false;
        }

        public void Data_Delete(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            Spirit spirit_remove = context.Spirits.Where(c => c.person_id == bandit_id).FirstOrDefault();
            Parameter par_remove = context.Parameters.Where(c => c.person_id == bandit_id).FirstOrDefault();
            Passport pass_remove = context.Passports.Where(c => c.person_id == bandit_id).FirstOrDefault();
            Criminal criminal_remove = context.Criminals.Where(c => c.person_id == bandit_id).FirstOrDefault();
            Permit permit_remove = context.Permits.Where(c => c.person_id == bandit_id).FirstOrDefault();
            context.Permits.Remove(permit_remove);
            context.Spirits.Remove(spirit_remove);
            context.Parameters.Remove(par_remove);
            context.Passports.Remove(pass_remove);
            context.Criminals.Remove(criminal_remove);
            context.SaveChanges();

            if (context.PSRelations.Any(c => c.person_id == bandit_id))
            {
                PSRelation rel = context.PSRelations.Where(c => c.person_id == bandit_id).FirstOrDefault();
                context.PSRelations.Remove(rel);
                context.SaveChanges();
            }
            context.SaveChanges();

            Person person_remove = context.Persons.Where(c => c.person_id == bandit_id).FirstOrDefault();
            context.Persons.Remove(person_remove);
            context.SaveChanges();

            

            GlobalTab.count_datarows--;


        }
        
        public void Syndicate_Delete(int synd_id)
        {
            InterpolContext context = new InterpolContext();
            if(context.PSRelations.Any(c => c.sys_id == synd_id))
            { 
               var relation_list = context.PSRelations.Where(c => c.sys_id == synd_id).ToList();
               context.PSRelations.RemoveRange(relation_list);
               context.SaveChanges();
            }
            context.SaveChanges();
            Syndicate syndicate = context.Syndicates.Where(c => c.syn_id == synd_id).FirstOrDefault();
            context.Syndicates.Remove(syndicate);
            context.SaveChanges();
        }

        public void Add_To_Syndicate(int bandit_id,int syndicate_id, string bandit_date)
        {
            InterpolContext context = new InterpolContext();

            PSRelation rel = new PSRelation
            {
                person_id = bandit_id,
                sys_id = syndicate_id,
                dateFrom = bandit_date
            };
            context.PSRelations.Add(rel);
            context.SaveChanges();
        }

        public void Delete_From_Syndicate(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            PSRelation syndicate_person = context.PSRelations.Where(c => c.person_id == bandit_id).FirstOrDefault();
            context.PSRelations.Remove(syndicate_person);
            context.SaveChanges();
        }

        public string Return_banditName(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Persons.Where(c => c.person_id == bandit_id).Select(c => c.person_name).FirstOrDefault().ToString();
        }

        public string Return_banditNickname(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Persons.Where(c => c.person_id == bandit_id).Select(c => c.person_nickname).FirstOrDefault().ToString();
        }

        public int Return_banditRise(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return Convert.ToInt32(context.Parameters.Where(c => c.person_id == bandit_id).Select(c => c.person_rise).FirstOrDefault());
        }

        public int Return_banditWeight(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return Convert.ToInt32(context.Parameters.Where(c => c.person_id == bandit_id).Select(c => c.person_weight).FirstOrDefault());
        }

        public string Return_banditEyecolor(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Parameters.Where(c => c.person_id == bandit_id).Select(c => c.person_eyecolor).FirstOrDefault().ToString();
        }

        public string Return_banditHaircolor(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Parameters.Where(c => c.person_id == bandit_id).Select(c => c.person_haircolor).FirstOrDefault().ToString();
        }

        public string Return_banditBirthday(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Persons.Where(c => c.person_id == bandit_id).Select(c => c.person_birthday).FirstOrDefault().ToString();
        }

        public string Return_banditCitizenship(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Passports.Where(c => c.person_id == bandit_id).Select(c => c.person_citizenship).FirstOrDefault().ToString();
        }

        public string Return_banditNationality(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Passports.Where(c => c.person_id == bandit_id).Select(c => c.person_nationality).FirstOrDefault().ToString();
        }

        public string Return_banditProfession(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Criminals.Where(c => c.person_id == bandit_id).Select(c => c.person_profession).FirstOrDefault().ToString();
        }

        public string Return_banditProfRole(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Criminals.Where(c => c.person_id == bandit_id).Select(c => c.person_role).FirstOrDefault().ToString();
        }

        public string Return_banditReligion(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Spirits.Where(c => c.person_id == bandit_id).Select(c => c.person_religion).FirstOrDefault().ToString();
        }

        public string Return_banditLanguage(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Spirits.Where(c => c.person_id == bandit_id).Select(c => c.person_language).FirstOrDefault().ToString();
        }

        public string Return_banditStatus(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Persons.Where(c => c.person_id == bandit_id).Select(c => c.person_status).FirstOrDefault().ToString();
        }

        public string Return_banditPhoto(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            return context.Persons.Where(c => c.person_id == bandit_id).Select(c => c.photo_path).FirstOrDefault().ToString();
        }

        // ---------------------------------------------
        // .............................................
        // ---------------------------------------------



        //---------------------------------
        // Permits table                  -
        //---------------------------------

        public void ClosePermit(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            var permit = context.Permits.Where(c => c.person_id == bandit_id).FirstOrDefault();
            permit.permit_value = "Занята";
            context.SaveChanges();
        }

        public void OpenPermit(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            var permit = context.Permits.Where(c => c.person_id == bandit_id).FirstOrDefault();
            permit.permit_value = "Свободна";
            context.SaveChanges();
        }

        public bool CheckPermit(int bandit_id)
        {
            InterpolContext context = new InterpolContext();
            string permit = context.Permits.Where(c => c.person_id == bandit_id).Select(c => c.permit_value).FirstOrDefault();
            if (permit == "Свободна") { return true; }
            else { return false; }
        }



        // ---------------------------------------------
        // .............................................
        // ---------------------------------------------


        // очищение переданного текст бокса
        public void TextClear(TextBox box)
        {
            box.Clear();
            
        }


        // очищение переданного маск бокса
        public void TextClear(MaskedTextBox box)
        {
            box.Clear();
        }


        // очищение переданного выпадающего списка
        public void TextClear(ComboBox box)
        {
            box.Items.Clear();
        }


        // закрытие переданной формы
        public void FormTerminate(Form form)
        {
            form.Close();
        }

        public void CreateSyndicate(string synd_name, string synd_date)
        {
            InterpolContext context = new InterpolContext();
            Syndicate syn = new Syndicate
            {
                syn_name = synd_name,
                syn_date = synd_date
            };
            context.Syndicates.Add(syn);
            context.SaveChanges();
        }

        public void CreateDataRow(string bandit_name,string bandit_nickname,string bandit_birthday,string photo,string bandit_status,
            string bandit_religion,string bandit_language, string bandit_profession,string bandit_role,int bandit_rise, int bandit_weight,
            string bandit_eyecolor,string bandit_haircolor,string bandit_citizen,string bandit_nationality)
        {
            InterpolContext context = new InterpolContext();

            Person person = new Person
            {
                person_name = bandit_name,
                person_nickname = bandit_nickname,
                person_birthday = bandit_birthday,
                person_status = bandit_status,
                photo_path = photo
            };
            context.Persons.Add(person);
            context.SaveChanges();

            int bandit_id = context.Persons.Where(c => c.person_nickname == bandit_nickname).Select(c => c.person_id).FirstOrDefault();

            Criminal crim = new Criminal
            {
                person_profession = bandit_profession,
                person_role = bandit_role,
                person_id = bandit_id
            };
            context.Criminals.Add(crim);
            context.SaveChanges();

            Passport pass = new Passport
            {
                person_citizenship = bandit_citizen,
                person_nationality = bandit_nationality,
                person_id = bandit_id
            };
            context.Passports.Add(pass);
            context.SaveChanges();

            Spirit sp = new Spirit
            {
                person_language = bandit_language,
                person_religion = bandit_religion,
                person_id = bandit_id
            };
            context.Spirits.Add(sp);
            context.SaveChanges();

            Parameter par = new Parameter
            {
                person_rise = bandit_rise,
                person_weight = bandit_weight,
                person_eyecolor = bandit_eyecolor,
                person_haircolor = bandit_haircolor,
                person_id = bandit_id
            };
            context.Parameters.Add(par);
            context.SaveChanges();

            Permit permit = new Permit
            {
                permit_value = "Свободна",
                person_id = bandit_id
            };
            context.Permits.Add(permit);
            context.SaveChanges();

        }


        // Добавление в бд данных о пользователе
        public void Set_Data(string log, string pass)
        {
            UsersContext context = new UsersContext();
            Password passw = new Password
            {
                login = log,
                password1 = pass
            };
            context.Passwords.Add(passw);
            context.SaveChanges(); 
        }


        // проверка на уникальность логина пользователя
           public bool Check_Data(string log)
           {
               UsersContext context = new UsersContext();
               List<string> log_list = new List<string>();
               foreach(var r in context.Passwords.ToList())
               {
                   log_list.Add(r.login.ToString());
               }
               if(log_list.Contains(log))
               {
                   return true;
               }else { return false; }
           }


           // аутентификация 
           public bool Sign_Check(string log, string pass)
           {
               UsersContext context = new UsersContext();
               bool check = false;
               foreach(var r in context.Passwords.ToList())
               {
                   if(log.Equals(r.login.ToString()) && pass.Equals(r.password1.ToString()))
                   {
                       check = true;
                   }else { check = false; }
               }
               return check;
           }


          // удаление данных по логину
          public void Delete_Data(string log)
          {
              UsersContext context = new UsersContext();
              Password log_remove = context.Passwords.Where(o => o.login == log).FirstOrDefault();
              context.Passwords.Remove(log_remove);
              context.SaveChanges();
          }
          

    }
}
