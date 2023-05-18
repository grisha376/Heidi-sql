using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace KartaBeremenosti
{
    public partial class Form1 : Form
    {
        string log_sotr = "", centr = "";
        int id_log_sotr=0, id_centr=0, id_kl=0, id_priem=0;
        string _conn = "";

        public Form1(string sotr, int idsotr, string klinica, int idklinica, int idkl, int idpriem, string _connection)
        {
            InitializeComponent();
            log_sotr = sotr;
            id_log_sotr = idsotr;
            centr = klinica;
            id_centr = idklinica;
            id_kl = idkl;
            _conn = _connection;
            id_priem = idpriem;
            
            

            //string b = "";
            //if (log_sotr == "Админ_АА")
            //    b = "Привет Админ_АА";
            //else
            //    b = "Ты не Админ_аа";

            //a = b;

            if (id_priem != 0)
            {
                //загрузка из истории
                LoadLast();
            }
        }

        private void LoadLast()
        {
            using (var conn = new MySqlConnection(_conn))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                using (var comm = new MySqlCommand("Select * from ambkarti1.`KartaBeremennoy1` where id=@a1", conn))
                {
                    comm.Parameters.AddWithValue("@a1", id_priem);
                    using (var md = comm.ExecuteReader())
                    {
                        if (md.Read())
                        {
                            KB_1.Text = md.GetString("KB_1");
                            KB_2.Text = md.GetString("KB_2");
                            KB_3.Text = md.GetString("KB_3");
                            KB_4.Text = md.GetString("KB_4");
                            KB_5.Text = md.GetString("KB_5");
                            KB_6.Text = md.GetString("KB_6");
                            KB_7.Text = md.GetString("KB_7");
                            KB_8.Text = md.GetString("KB_8");
                            KB_9.Text = md.GetString("KB_9");
                            KB_10.Text = md.GetString("KB_10");
                            KB_11.Text = md.GetString("KB_11");
                            KB_12.Text = md.GetString("KB_12");
                            KB_13.Text = md.GetString("KB_13");
                            KB_14.Text = md.GetString("KB_14");
                            //KB_15.Text = md.GetString("KB_15"); // parse
                            if(md.GetString("KB_15") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "";
                                for (int i=0; i<md.GetString("KB_15").Length; i++)
                                {
                                    if(md.GetString("KB_15")[i].ToString() == "#")
                                        a1 = a2;
                                    else if (md.GetString("KB_15")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("KB_15").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        KB_15.Rows.Add(aboba);
                                    }
                                }
                            }




                            //if (md.GetString("KB_16") != "")
                            //{
                            //    string stroka = "";
                            //    string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "";
                            //    for (int i = 0; i < md.GetString("KB_16").Length; i++)
                            //    {
                            //        if (md.GetString("KB_16")[i].ToString() == "#")
                            //            a1 = a2 = a3 = a4 = a5;

                            //        else if (md.GetString("KB_16")[i].ToString() == "&")
                            //        {
                            //            string[] aboba = md.GetString("KB_16").ToString().Split(new string[] { "#", "&" }, StringSplitOptions.None);
                            //            foreach (var parse in aboba)
                            //                stroka = parse;
                            //            KB_16.Rows.Add(aboba);

                            //            //List<string> KB_16Risk = new List<string>
                            //            //{
                            //            //    KB_16.Rows.Add(new Object[] { 1,})
                            //            //};
                            //            //KB_16.DataSource = KB_16Risk;
                            //        }   
                            //    }
                               

                            //}

                            KB_17.Text = md.GetString("KB_17");
                            KB_18.Text = md.GetString("KB_18");
                            KB_19.Text = md.GetString("KB_19");
                            KB_20.Text = md.GetString("KB_20");



                            SP1_1.Text = md.GetString("SP1_1");
                            SP1_2.Text = md.GetString("SP1_2");
                            SP1_3.Text = md.GetString("SP1_3");
                            SP1_4.Text = md.GetString("SP1_4");
                            SP1_5.Text = md.GetString("SP1_5");
                            SP1_6.Text = md.GetString("SP1_6");
                            SP1_7.Text = md.GetString("SP1_7");
                            SP1_8.Text = md.GetString("SP1_8");
                            SP1_9.Text = md.GetString("SP1_9");
                            SP1_10.Text = md.GetString("SP1_10");
                            SP1_11.Text = md.GetString("SP1_11");
                            SP1_12.Text = md.GetString("SP1_12");
                            SP1_13.Text = md.GetString("SP1_13");
                            SP1_14.Text = md.GetString("SP1_14");
                            SP1_15.Text = md.GetString("SP1_15");
                            SP1_16.Text = md.GetString("SP1_16");
                            SP1_17.Text = md.GetString("SP1_17");
                            SP1_18.Text = md.GetString("SP1_18");
                            SP1_19.Text = md.GetString("SP1_19");
                            SP1_20.Text = md.GetString("SP1_20");
                            SP1_21.Text = md.GetString("SP1_21");
                            SP1_22.Text = md.GetString("SP1_22");
                            SP1_23.Text = md.GetString("SP1_23");
                            SP1_24.Text = md.GetString("SP1_24");
                            SP1_25.Text = md.GetString("SP1_25");
                            SP1_26.Text = md.GetString("SP1_26");

                            // SP2_1.Text = md.GetString("SP2_1"); //parse
                            if (md.GetString("SP2_1") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "", a6 = "";
                                for (int i = 0; i < md.GetString("SP2_1").Length; i++)
                                {
                                    if (md.GetString("SP2_1")[i].ToString() == "#")
                                        a1 = a2 = a3=a4= a5= a6;
                                    else if (md.GetString("SP2_1")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("SP2_1").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        SP2_1.Rows.Add(aboba);
                                    }
                                }
                            }


                            //SP2_2.Text = md.GetString("SP2_2"); //parse
                            if (md.GetString("SP2_2") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "", a6 = "";
                                for (int i = 0; i < md.GetString("SP2_2").Length; i++)
                                {
                                    if (md.GetString("SP2_2")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4 = a5 = a6;
                                    else if (md.GetString("SP2_2")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("SP2_2").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        SP2_2.Rows.Add(aboba);
                                    }
                                }
                            }
                            SP2_3.Text = md.GetString("SP2_3");
                            SP2_4.Text = md.GetString("SP2_4");
                            SP2_5.Text = md.GetString("SP2_5");
                            SP2_6.Text = md.GetString("SP2_6");
                            SP2_7.Text = md.GetString("SP2_7");
                            SP2_8.Text = md.GetString("SP2_8");
                            SP2_9.Text = md.GetString("SP2_9");
                            SP2_10.Text = md.GetString("SP2_10");
                            SP2_11.Text = md.GetString("SP2_11");
                            SP2_12.Text = md.GetString("SP2_12");

                            SB1_1.Text = md.GetString("SB1_1");
                            SB1_2.Text = md.GetString("SB1_2");
                            SB1_3.Text = md.GetString("SB1_3");
                            SB1_4.Text = md.GetString("SB1_4");
                            SB1_5.Text = md.GetString("SB1_5");
                            SB1_6.Text = md.GetString("SB1_6");
                            SB1_7.Text = md.GetString("SB1_7");
                            SB1_8.Text = md.GetString("SB1_8");
                            SB1_9.Text = md.GetString("SB1_9");
                            SB1_10.Text = md.GetString("SB1_10");
                            SB1_11.Text = md.GetString("SB1_11");
                            SB1_12.Text = md.GetString("SB1_12");
                            SB1_13.Text = md.GetString("SB1_13");
                            SB1_14.Text = md.GetString("SB1_14");
                            SB1_15.Text = md.GetString("SB1_15");
                            SB1_16.Text = md.GetString("SB1_16");
                            SB1_17.Text = md.GetString("SB1_17");
                            SB1_18.Text = md.GetString("SB1_18");
                            SB1_19.Text = md.GetString("SB1_19");
                            SB1_20.Text = md.GetString("SB1_20");
                            SB1_21.Text = md.GetString("SB1_21");
                            SB1_22.Text = md.GetString("SB1_22");

                            SB2_1.Text = md.GetString("SB2_1");
                            SB2_2.Text = md.GetString("SB2_2");
                            SB2_3.Text = md.GetString("SB2_3");
                            SB2_4.Text = md.GetString("SB2_4");

                            NB1_1.Text = md.GetString("NB1_1");
                            NB1_2.Text = md.GetString("NB1_2");
                            NB1_3.Text = md.GetString("NB1_3");
                            NB1_4.Text = md.GetString("NB1_4");
                            NB1_5.Text = md.GetString("NB1_5");
                            NB1_6.Text = md.GetString("NB1_6");
                            NB1_7.Text = md.GetString("NB1_7");
                            NB1_8.Text = md.GetString("NB1_8");
                            NB1_9.Text = md.GetString("NB1_9");
                            //NB1_10.Text = md.GetString("NB1_10"); //parse
                            if (md.GetString("NB1_10") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "",a3 = "",a4 = "",a5 = "", a6 = "", a7 = "", a8 = "";
                                for (int i = 0; i < md.GetString("NB1_10").Length; i++)
                                {
                                    if (md.GetString("NB1_10")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8;
                                    else if (md.GetString("NB1_10")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB1_10").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB1_10.Rows.Add(aboba);
                                    }
                                }
                            }

                            // NB2_1.Text = md.GetString("NB2_1"); //parse
                            if (md.GetString("NB2_1") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "", a6 = "", a7 = "";
                                for (int i = 0; i < md.GetString("NB2_1").Length; i++)
                                {
                                    if (md.GetString("NB2_1")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4 = a5 = a6 = a7;
                                    else if (md.GetString("NB2_1")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB2_1").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB2_1.Rows.Add(aboba);
                                    }
                                }
                            }
                            //   NB2_2.Text = md.GetString("NB2_2"); //parse
                            if (md.GetString("NB2_2") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "";
                                for (int i = 0; i < md.GetString("NB2_2").Length; i++)
                                {
                                    if (md.GetString("NB2_2")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4 = a5;
                                    else if (md.GetString("NB2_2")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB2_2").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB2_2.Rows.Add(aboba);
                                    }
                                }
                            }

                            //NB2_3.Text = md.GetString("NB2_3"); //parse
                            if (md.GetString("NB2_3") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "",a3 = "", a4 = "";
                                for (int i = 0; i < md.GetString("NB2_3").Length; i++)
                                {
                                    if (md.GetString("NB2_3")[i].ToString() == "#")
                                        a1 = a2= a3 = a4;
                                    else if (md.GetString("NB2_3")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB2_3").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB2_3.Rows.Add(aboba);
                                    }
                                }
                            }

                            //NB3_1.Text = md.GetString("NB3_1"); //parse
                            if (md.GetString("NB3_1") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "";
                                for (int i = 0; i < md.GetString("NB3_1").Length; i++)
                                {
                                    if (md.GetString("NB3_1")[i].ToString() == "#")
                                        a1 = a2 =a3 =a4 =a5;
                                    else if (md.GetString("NB3_1")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB3_1").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB3_1.Rows.Add(aboba);
                                    }
                                }
                            }
                            // NB3_2.Text = md.GetString("NB3_2"); //parse
                            if (md.GetString("NB3_2") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "";
                                for (int i = 0; i < md.GetString("NB3_2").Length; i++)
                                {
                                    if (md.GetString("NB3_2")[i].ToString() == "#")
                                        a1 = a2 = a3;
                                    else if (md.GetString("NB3_2")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB3_2").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB3_2.Rows.Add(aboba);
                                    }
                                }
                            }
                            // NB3_3.Text = md.GetString("NB3_3"); //parse
                            if (md.GetString("NB3_3") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "";
                                for (int i = 0; i < md.GetString("NB3_3").Length; i++)
                                {
                                    if (md.GetString("NB3_3")[i].ToString() == "#")
                                        a1 = a2;
                                    else if (md.GetString("NB3_3")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB3_3").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB3_3.Rows.Add(aboba);
                                    }
                                }
                            }
                            //  NB3_4.Text = md.GetString("NB3_4"); //parse
                            if (md.GetString("NB3_4") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "";
                                for (int i = 0; i < md.GetString("NB3_4").Length; i++)
                                {
                                    if (md.GetString("NB3_4")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4 = a5;
                                    else if (md.GetString("NB3_4")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB3_4").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        KB_15.Rows.Add(aboba);
                                    }
                                }
                            }

                            //NB4_1.Text = md.GetString("NB4_1"); //parse
                            if (md.GetString("NB4_1") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "", a6="", a7="" ;
                                for (int i = 0; i < md.GetString("NB4_1").Length; i++)
                                {
                                    if (md.GetString("NB4_1")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4 = a5 = a6 = a7;
                                    else if (md.GetString("NB4_1")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB4_1").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB4_1.Rows.Add(aboba);
                                    }
                                }
                            }
                            // NB4_2.Text = md.GetString("NB4_2"); //parse
                            if (md.GetString("NB4_2") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "";
                                for (int i = 0; i < md.GetString("NB4_2").Length; i++)
                                {
                                    if (md.GetString("NB4_2")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4 = a5;
                                    else if (md.GetString("NB4_2")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB4_2").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB4_2.Rows.Add(aboba);
                                    }
                                }
                            }
                            // NB4_3.Text = md.GetString("NB4_3"); //parse
                            if (md.GetString("NB4_3") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3= "";
                                for (int i = 0; i < md.GetString("NB4_3").Length; i++)
                                {
                                    if (md.GetString("NB4_3")[i].ToString() == "#")
                                        a1 = a2 = a3;
                                    else if (md.GetString("NB4_3")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB4_3").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB4_3.Rows.Add(aboba); 
                                    }
                                }
                            }
                            //NB4_4.Text = md.GetString("NB4_4"); //parse
                            if (md.GetString("NB4_4") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "";
                                for (int i = 0; i < md.GetString("NB4_4").Length; i++)
                                {
                                    if (md.GetString("NB4_4")[i].ToString() == "#")
                                        a1 = a2 = a3;
                                    else if (md.GetString("NB4_4")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB4_4").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB4_4.Rows.Add(aboba);
                                    }
                                }
                            }
                            NB4_5.Text = md.GetString("NB4_5");
                            NB4_6.Text = md.GetString("NB4_6");
                            NB4_7.Text = md.GetString("NB4_7");
                            NB4_8.Text = md.GetString("NB4_8");

                            //NB5_1.Text = md.GetString("NB5_1"); //parse
                            if (md.GetString("NB5_1") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "" ,a6 = "", a7 = "", a8 = "", a9 = "", a10 = "";
                                for (int i = 0; i < md.GetString("NB5_1").Length; i++)
                                {
                                    if (md.GetString("NB5_1")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4 = a5 = a6 = a7 = a8 = a9 = a10;
                                    else if (md.GetString("NB5_1")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB5_1").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB5_1.Rows.Add(aboba);
                                    }
                                }
                            }
                            NB5_2.Text = md.GetString("NB5_2");
                            NB5_3.Text = md.GetString("NB5_3");
                            NB5_4.Text = md.GetString("NB5_4");
                            NB5_5.Text = md.GetString("NB5_5");
                            NB5_6.Text = md.GetString("NB5_6");

                            NB6_1.Text = md.GetString("NB6_1");
                            NB6_2.Text = md.GetString("NB6_2");

                            // NB7_1.Text = md.GetString("NB7_1"); //parse
                            if (md.GetString("NB7_1") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 ="", a4 = "";
                                for (int i = 0; i < md.GetString("NB7_1").Length; i++)
                                {
                                    if (md.GetString("NB7_1")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4;
                                    else if (md.GetString("NB7_1")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB7_1").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB7_1.Rows.Add(aboba);
                                    }
                                }
                            }
                            NB7_2.Text = md.GetString("NB7_2");
                            NB7_3.Text = md.GetString("NB7_3");
                            // NB7_4.Text = md.GetString("NB7_4"); //parse
                            if (md.GetString("NB7_4") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "";
                                for (int i = 0; i < md.GetString("NB7_4").Length; i++)
                                {
                                    if (md.GetString("NB7_4")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4;
                                    else if (md.GetString("NB7_4")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB7_4").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB7_4.Rows.Add(aboba);
                                    }
                                }
                            }
                            //NB7_5.Text = md.GetString("NB7_5"); //parse
                            if (md.GetString("NB7_5") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "";
                                for (int i = 0; i < md.GetString("NB7_5").Length; i++)
                                {
                                    if (md.GetString("NB7_5")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4;
                                    else if (md.GetString("NB7_5")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB7_5").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB7_5.Rows.Add(aboba);
                                    }
                                }
                            }
                            //NB7_6.Text = md.GetString("NB7_6"); //parse
                            if (md.GetString("NB7_6") != "")
                            {
                                string stroka = "";
                                string a1 = "", a2 = "", a3 = "", a4 = "", a5 = "";
                                for (int i = 0; i < md.GetString("NB7_6").Length; i++)
                                {
                                    if (md.GetString("NB7_6")[i].ToString() == "#")
                                        a1 = a2 = a3 = a4 = a5;
                                    else if (md.GetString("NB7_6")[i].ToString() == "&")
                                    {
                                        string[] aboba = md.GetString("NB7_6").ToString().Split(new string[] { "", "&" }, StringSplitOptions.None);
                                        foreach (var parse in aboba)
                                            stroka = parse;
                                        NB7_6.Rows.Add(aboba);
                                    }
                                }
                            }

                        }
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //
            List<string> NabludenieZaBeremennoy = new List<string>
            {
                "Дата",
                "Срок беременности (недель)",
                "Жалобы (да/нет)",
                "Отёки (-,1+,2+,2+)",
                "Прибавка массы тела (+г)",
                "АД систол. (мм рт.ст.)",
                "АД диастол. (мм рт.ст.)",
                "Пульс (уд/мин)",
                "СБ плода (уд/мин) (>12нед.)",
                "Шевеление плода: 1-ощущает, 2-не ощущает",
                "ВДМ (см) (>20 нед.)",
                "ОЖ (см) (>20 нед.)",
                "Положение плода 1-продольное, 2-косое, 3-поперечное (>34 нед.)",
                "Над входом в малый таз 1-головка, 2-тазовый конец, 3-другое (>34 нед.)",
                "Предлежащая часть 1-прижата, 2-подвижна (>34 нед.)",
                "Белок в моче (-,1+,2+,3+)",
                "Гемоглобин (г/л)",
                "Глюкоза ммоль/л",
                "ТТг, мкМЕ/л",
                "S.agalactiae в мазке",
                "Бактериоскопическое исследование мазков",
                "Цитологическое исследование микропрепарата шейки матки",
                "Посев мочи на бессимптомную бактерию",
                "Комплексная оценка антенатального развития плода в 11-14 недель",
                "Оценка антенатального развития плода в 19-21 неделю",
                "УЗИ-цервикометрия",
                "УЗИ плода/плодов по показаниям",
                "Инвазивная диагностика при высоком риске ХА",
                "КТГ плода/плодов"
            };
            NB1_10.DataSource = NabludenieZaBeremennoy.Select(x => new { FirstColumn = x }).ToList();
            NB1_10.CurrentCell = null;

            List<string> AnalizCrovi = new List<string>
            {
                "Дата",
                "Гемоглобин, г/л",
                "Эритроциты, 10^12/л",
                "Цветовой показатель, %",
                "Ретикулоциты, %",
                "Тромбоциты, 10^9/л",
                "Лейкоциты, 10^9/л",
                "Лейкоциты: Миелоциты",
                "Лейкоциты: Палочкоядерные",
                "Лейкоциты: Сегментоядерные",
                "Лейкоциты: Эозинофилы",
                "Лейкоциты: Базофилы",
                "Лейкоциты: Лимфоциты",
                "Лейкоциты: Моноциты",
                "СОЭ, мм/ч"
            };

            NB3_4.DataSource = AnalizCrovi.Select(x => new { AnalizCroviColumn = x }).ToList();
            NB3_4.CurrentCell = null;

            NB4_6.Rows.Add("Дата", "", "", "", "", "", "");
            NB4_6.Rows.Add("Локусы", "C", "V", "U", "C", "V", "U");
            NB4_6.Rows.Add("Лейкоциты", "", "", "", "", "", "");
            NB4_6.Rows.Add("Эпителий", "", "", "", "", "", "");
            NB4_6.Rows.Add("Ключевые клетки", "", "", "", "", "", "");
            NB4_6.Rows.Add("Кандины", "", "", "", "", "", "");
            NB4_6.Rows.Add("Трихомонады", "", "", "", "", "", "");
            NB4_6.Rows.Add("Гонококки", "", "", "", "", "", "");
            NB4_6.Rows.Add("pH", "", "", "", "", "", "");
            NB4_6.CurrentCell = null;
        }



        private void SchetBeremennosti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void SchetRodov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }
    
        private void RostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) 
            {
                e.Handled = true;
            }
        }

        private void MassatextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44)
            {
                e.Handled = true;
            }
        }

        private void AutoWidthTextBox(object sender, EventArgs e)
        {
            ((TextBox)sender).Width = TextRenderer.MeasureText(((TextBox)sender).Text, ((TextBox)sender).Font).Width + 20;
        }

        private void AutoWidthCombo(object sender, EventArgs e)
        {
            ((ComboBox)sender).Width = TextRenderer.MeasureText(((ComboBox)sender).Text, ((ComboBox)sender).Font).Width + 20;
        }

        private void DropDown(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (string s in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width + 20;
        }

        private void GrupaKroviPapa_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 53) && number != 45 && number != 43 && number != 8)
            {
                e.Handled = true;
            }
        }

        private void GrupaKroviMama_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 53) && number != 45 && number != 43 && number != 8)
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVRT.Checked == true)
                SB1_4.Enabled = true;
            else
                SB1_4.Enabled = false;
        }

        private void textBoxMassa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SP1_4.Text = (Convert.ToDouble(SP1_3.Text) / ((Convert.ToDouble(SP1_2.Text) / 100) * (Convert.ToDouble(SP1_2.Text)) / 100)).ToString("N1");
            }
            catch
            { }
        }

        private void checkBoxRybec_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRybec.Checked == true)
                SP2_2.Enabled = true;
            else
                SP2_2.Enabled = false;
        }

        private void textBoxMassaOtca_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SP2_6.Text = (Convert.ToDouble(SP2_5.Text) / ((Convert.ToDouble(SP2_4.Text)/100) * (Convert.ToDouble(SP2_4.Text))/100)).ToString("N1");
            }
            catch { }
        }

        private void checkBoxIsxodProshlixBeremennostey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIsxodProshlixBeremennostey.Checked == true)
                SP2_1.Enabled = true;
            else
                SP2_1.Enabled = false;
        }

        private void checkBoxMazok_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMazok.Checked == true)
                NB4_5.Enabled = false;
            else
                NB4_5.Enabled = true;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = new MySqlConnection(_conn))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                using (var comm = new MySqlCommand("insert into ambkarti1.`KartaBeremennoy1` values(NULL, @a1, @a2, @a3, @a4, @a5, @KB_1, @KB_2, @KB_3 , @KB_4, @KB_5, @KB_6, @KB_7, @KB_8, @KB_9, @KB_10, @KB_11, @KB_12, @KB_13, @KB_14, @KB_15, @KB_16, @KB_17, @KB_18, @KB_19, @KB_20, @SP1_1, @SP1_2, @SP1_3, @SP1_4, @SP1_5, @SP1_6, @SP1_7, @SP1_8, @SP1_9, @SP1_10, @SP1_11, @SP1_12, @SP1_13, @SP1_14, @SP1_15, @SP1_16, @SP1_17, @SP1_18, @SP1_19, @SP1_20, @SP1_21, @SP1_22, @SP1_23, @SP1_24, @SP1_25, @SP1_26, @SP2_1, @SP2_2, @SP2_3, @SP2_4, @SP2_5, @SP2_6, @SP2_7, @SP2_8, @SP2_9, @SP2_10, @SP2_11, @SP2_12, @SB1_1, @SB1_2, @SB1_3, @SB1_4, @SB1_5, @SB1_6, @SB1_7, @SB1_8, @SB1_9, @SB1_10, @SB1_11, @SB1_12, @SB1_13, @SB1_14, @SB1_15, @SB1_16, @SB1_17, @SB1_18, @SB1_19, @SB1_20, @SB1_21, @SB1_22, @SB2_1, @SB2_2, @SB2_3, @SB2_4, @NB1_1, @NB1_2, @NB1_3, @NB1_4, @NB1_5, @NB1_6, @NB1_7, @NB1_8, @NB1_9, @NB1_10, @NB2_1, @NB2_2, @NB2_3, @NB3_1, @NB3_2, @NB3_3, @NB3_4, @NB4_1, @NB4_2, @NB4_3, @NB4_4, @NB4_5, @NB4_6, @NB4_7, @NB4_8, @NB5_1, @NB5_2, @NB5_3, @NB5_4, @NB5_5, @NB5_6, @NB6_1, @NB6_2, @NB7_1, @NB7_2, @NB7_3, @NB7_4, @NB7_5, @NB7_6 )", conn))
                {
                    comm.Parameters.AddWithValue("@a1", DateTime.Today);
                    comm.Parameters.AddWithValue("@a2", id_kl);
                    comm.Parameters.AddWithValue("@a3", id_centr);
                    comm.Parameters.AddWithValue("@a4", id_log_sotr);
                    comm.Parameters.AddWithValue("@a5", "wait");

                    string kb15 = "";
                    for (int i = 0; i < KB_15.Rows.Count - 1; i++)
                    {
                        if (kb15 == "")
                            kb15 = "#" + KB_15.Rows[i].Cells[0].Value.ToString() + "&" + KB_15.Rows[i].Cells[1].Value.ToString() + "&";
                        else
                            kb15 = kb15 + Environment.NewLine + "#" + KB_15.Rows[i].Cells[0].Value.ToString() + "&" + KB_15.Rows[i].Cells[1].Value.ToString() + "&";
                    }

                    string kb16 = "";
                    for (int i = 0; i < KB_16.Rows.Count - 1; i++)
                    {
                        string cell1 = KB_16.Rows[i].Cells[0].Value == null ? "" : KB_16.Rows[i].Cells[0].Value.ToString();
                        string cell2 = KB_16.Rows[i].Cells[1].Value == null ? "" : KB_16.Rows[i].Cells[1].Value.ToString();
                        string cell3 = KB_16.Rows[i].Cells[2].Value == null ? "" : KB_16.Rows[i].Cells[2].Value.ToString();
                        string cell4 = KB_16.Rows[i].Cells[3].Value == null ? "" : KB_16.Rows[i].Cells[3].Value.ToString();
                        string cell5 = KB_16.Rows[i].Cells[4].Value == null ? "" : KB_16.Rows[i].Cells[4].Value.ToString();

                        if (kb16 == "")
                            kb16 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5;
                        else
                            kb16 = kb16 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5;
                    }

                    string sp2_1 = "";
                    for (int i = 0; i < SP2_1.Rows.Count - 1; i++)
                    {

                        string cell1 = SP2_1.Rows[i].Cells[0].Value == null ? "" : SP2_1.Rows[i].Cells[0].Value.ToString();
                        string cell2 = SP2_1.Rows[i].Cells[1].Value == null ? "" : SP2_1.Rows[i].Cells[1].Value.ToString();
                        string cell3 = SP2_1.Rows[i].Cells[2].Value == null ? "" : SP2_1.Rows[i].Cells[2].Value.ToString();
                        string cell4 = SP2_1.Rows[i].Cells[3].Value == null ? "" : SP2_1.Rows[i].Cells[3].Value.ToString();
                        string cell5 = SP2_1.Rows[i].Cells[4].Value == null ? "" : SP2_1.Rows[i].Cells[4].Value.ToString();


                        if (sp2_1 == "")
                            sp2_1 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&";
                        else
                            sp2_1 = sp2_1 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&";
                    }


                    string sp2_2 = "";
                    for (int i = 0; i < SP2_2.Rows.Count - 1; i++)
                    {

                        string cell1 = SP2_2.Rows[i].Cells[0].Value == null ? "" : SP2_2.Rows[i].Cells[0].Value.ToString();
                        string cell2 = SP2_2.Rows[i].Cells[1].Value == null ? "" : SP2_2.Rows[i].Cells[1].Value.ToString();
                        string cell3 = SP2_2.Rows[i].Cells[2].Value == null ? "" : SP2_2.Rows[i].Cells[2].Value.ToString();
                        string cell4 = SP2_2.Rows[i].Cells[3].Value == null ? "" : SP2_2.Rows[i].Cells[3].Value.ToString();
                        string cell5 = SP2_2.Rows[i].Cells[4].Value == null ? "" : SP2_2.Rows[i].Cells[4].Value.ToString();
                        string cell6 = SP2_2.Rows[i].Cells[5].Value == null ? "" : SP2_2.Rows[i].Cells[5].Value.ToString();

                        if (sp2_2 == "")
                            sp2_2 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6;
                        else
                            sp2_2 = sp2_2 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6;
                    }

                    string nb1_10 = "";
                    for (int i = 0; i < NB1_10.Rows.Count - 1; i++)
                    {

                        string cell1 = NB1_10.Rows[i].Cells[0].Value == null ? "" : NB1_10.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB1_10.Rows[i].Cells[1].Value == null ? "" : NB1_10.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB1_10.Rows[i].Cells[2].Value == null ? "" : NB1_10.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB1_10.Rows[i].Cells[3].Value == null ? "" : NB1_10.Rows[i].Cells[3].Value.ToString();
                        string cell5 = NB1_10.Rows[i].Cells[4].Value == null ? "" : NB1_10.Rows[i].Cells[4].Value.ToString();
                        string cell6 = NB1_10.Rows[i].Cells[5].Value == null ? "" : NB1_10.Rows[i].Cells[5].Value.ToString();

                        if (nb1_10 == "")
                            nb1_10 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6;
                        else
                            nb1_10 = nb1_10 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6;
                    }

                    string nb2_1 = "";
                    for (int i = 0; i < NB2_1.Rows.Count - 1; i++)
                    {

                        string cell1 = NB2_1.Rows[i].Cells[0].Value == null ? "" : NB2_1.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB2_1.Rows[i].Cells[1].Value == null ? "" : NB2_1.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB2_1.Rows[i].Cells[2].Value == null ? "" : NB2_1.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB2_1.Rows[i].Cells[3].Value == null ? "" : NB2_1.Rows[i].Cells[3].Value.ToString();
                        string cell5 = NB2_1.Rows[i].Cells[4].Value == null ? "" : NB2_1.Rows[i].Cells[4].Value.ToString();
                        string cell6 = NB2_1.Rows[i].Cells[5].Value == null ? "" : NB2_1.Rows[i].Cells[5].Value.ToString();
                        string cell7 = NB2_1.Rows[i].Cells[6].Value == null ? "" : NB2_1.Rows[i].Cells[6].Value.ToString();

                        if (nb2_1 == "")
                            nb2_1 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6 + "&" + cell7;
                        else
                            nb2_1 = nb2_1 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6 + "&" + cell7;
                    }

                    string nb2_2 = "";
                    for (int i = 0; i < NB2_2.Rows.Count - 1; i++)
                    {

                        string cell1 = NB2_2.Rows[i].Cells[0].Value == null ? "" : NB2_2.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB2_2.Rows[i].Cells[1].Value == null ? "" : NB2_2.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB2_2.Rows[i].Cells[2].Value == null ? "" : NB2_2.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB2_2.Rows[i].Cells[3].Value == null ? "" : NB2_2.Rows[i].Cells[3].Value.ToString();
                        string cell5 = NB2_2.Rows[i].Cells[4].Value == null ? "" : NB2_2.Rows[i].Cells[4].Value.ToString();

                        if (nb2_2 == "")
                            nb2_2 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&";
                        else
                            nb2_2 = nb2_2 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&";
                    }

                    string nb2_3 = "";
                    for (int i = 0; i < NB2_3.Rows.Count - 1; i++)
                    {

                        string cell1 = NB2_3.Rows[i].Cells[0].Value == null ? "" : NB2_3.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB2_3.Rows[i].Cells[1].Value == null ? "" : NB2_3.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB2_3.Rows[i].Cells[2].Value == null ? "" : NB2_3.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB2_3.Rows[i].Cells[3].Value == null ? "" : NB2_3.Rows[i].Cells[3].Value.ToString();
                        

                        if (nb2_3 == "")
                            nb2_3 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                        else
                            nb2_3 = nb2_3 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                    }


                    string nb3_1 = "";
                    for (int i = 0; i < NB3_1.Rows.Count - 1; i++)
                    {

                        string cell1 = NB3_1.Rows[i].Cells[0].Value == null ? "" : NB3_1.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB3_1.Rows[i].Cells[1].Value == null ? "" : NB3_1.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB3_1.Rows[i].Cells[2].Value == null ? "" : NB3_1.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB3_1.Rows[i].Cells[3].Value == null ? "" : NB3_1.Rows[i].Cells[3].Value.ToString();
                        string cell5 = NB3_1.Rows[i].Cells[4].Value == null ? "" : NB3_1.Rows[i].Cells[4].Value.ToString();


                        if (nb3_1 == "")
                            nb3_1 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" +cell5 + "&";
                        else
                            nb3_1 = nb3_1 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&";
                    }

                    string nb3_2 = "";
                    for (int i = 0; i < NB3_2.Rows.Count - 1; i++)
                    {

                        string cell1 = NB3_2.Rows[i].Cells[0].Value == null ? "" : NB3_2.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB3_2.Rows[i].Cells[1].Value == null ? "" : NB3_2.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB3_2.Rows[i].Cells[2].Value == null ? "" : NB3_2.Rows[i].Cells[2].Value.ToString();
                        


                        if (nb3_2 == "")
                            nb3_2 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&";
                        else
                            nb3_2 = nb3_2 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&";
                    }


                    string nb3_3 = "";
                    for (int i = 0; i < NB3_3.Rows.Count - 1; i++)
                    {

                        string cell1 = NB3_3.Rows[i].Cells[0].Value == null ? "" : NB3_3.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB3_3.Rows[i].Cells[1].Value == null ? "" : NB3_3.Rows[i].Cells[1].Value.ToString();

                        if (nb3_3 == "")
                            nb3_3 = "#" + cell1 + "&" + cell2 + "&";
                        else
                            nb3_3 = nb3_3 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&";
                    }


                    string nb3_4 = "";
                    for (int i = 0; i < NB3_4.Rows.Count - 1; i++)
                    {

                        string cell1 = NB3_4.Rows[i].Cells[0].Value == null ? "" : NB3_4.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB3_4.Rows[i].Cells[1].Value == null ? "" : NB3_4.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB3_4.Rows[i].Cells[2].Value == null ? "" : NB3_4.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB3_4.Rows[i].Cells[3].Value == null ? "" : NB3_4.Rows[i].Cells[3].Value.ToString();
                        string cell5 = NB3_4.Rows[i].Cells[4].Value == null ? "" : NB3_4.Rows[i].Cells[4].Value.ToString();

                        if (nb3_4 == "")
                            nb3_4 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&";
                        else
                            nb3_4 = nb3_4 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&";
                    }

                    string nb4_1 = "";
                    for (int i = 0; i < NB4_1.Rows.Count - 1; i++)
                    {

                        string cell1 = NB4_1.Rows[i].Cells[0].Value == null ? "" : NB4_1.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB4_1.Rows[i].Cells[1].Value == null ? "" : NB4_1.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB4_1.Rows[i].Cells[2].Value == null ? "" : NB4_1.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB4_1.Rows[i].Cells[3].Value == null ? "" : NB4_1.Rows[i].Cells[3].Value.ToString();
                        string cell5 = NB4_1.Rows[i].Cells[4].Value == null ? "" : NB4_1.Rows[i].Cells[4].Value.ToString();
                        string cell6 = NB4_1.Rows[i].Cells[5].Value == null ? "" : NB4_1.Rows[i].Cells[5].Value.ToString();
                        string cell7 = NB4_1.Rows[i].Cells[6].Value == null ? "" : NB4_1.Rows[i].Cells[6].Value.ToString();

                        if (nb4_1 == "")
                            nb4_1 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6 + "&" + cell7 + "&";
                        else
                            nb4_1 = nb4_1 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6 + "&" + cell7 + "&";
                    }

                    string nb4_2 = "";
                    for (int i = 0; i < NB4_2.Rows.Count - 1; i++)
                    {

                        string cell1 = NB4_2.Rows[i].Cells[0].Value == null ? "" : NB4_2.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB4_2.Rows[i].Cells[1].Value == null ? "" : NB4_2.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB4_2.Rows[i].Cells[2].Value == null ? "" : NB4_2.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB4_2.Rows[i].Cells[3].Value == null ? "" : NB4_2.Rows[i].Cells[3].Value.ToString();
                        string cell5 = NB4_2.Rows[i].Cells[4].Value == null ? "" : NB4_2.Rows[i].Cells[4].Value.ToString();

                        if (nb4_2 == "")
                            nb4_2 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&";
                        else
                            nb4_2 = nb4_2 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&";
                    }

                    string nb4_3 = "";
                    for (int i = 0; i < NB4_3.Rows.Count - 1; i++)
                    {

                        string cell1 = NB4_3.Rows[i].Cells[0].Value == null ? "" : NB4_3.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB4_3.Rows[i].Cells[1].Value == null ? "" : NB4_3.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB4_3.Rows[i].Cells[2].Value == null ? "" : NB4_3.Rows[i].Cells[2].Value.ToString();
                        

                        if (nb4_3 == "")
                            nb4_3 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&";
                        else
                            nb4_3 = nb4_3 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&";
                    }

                    string nb4_4 = "";
                    for (int i = 0; i < NB4_4.Rows.Count - 1; i++)
                    {

                        string cell1 = NB4_4.Rows[i].Cells[0].Value == null ? "" : NB4_4.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB4_4.Rows[i].Cells[1].Value == null ? "" : NB4_4.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB4_4.Rows[i].Cells[2].Value == null ? "" : NB4_4.Rows[i].Cells[2].Value.ToString();


                        if (nb4_4 == "")
                            nb4_4 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&";
                        else
                            nb4_4 = nb4_4 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&";
                    }

                    string nb5_1 = "";
                    for (int i = 0; i < NB5_1.Rows.Count - 1; i++)
                    {

                        string cell1 = NB5_1.Rows[i].Cells[0].Value == null ? "" : NB5_1.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB5_1.Rows[i].Cells[1].Value == null ? "" : NB5_1.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB5_1.Rows[i].Cells[2].Value == null ? "" : NB5_1.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB5_1.Rows[i].Cells[3].Value == null ? "" : NB5_1.Rows[i].Cells[3].Value.ToString();
                        string cell5 = NB5_1.Rows[i].Cells[4].Value == null ? "" : NB5_1.Rows[i].Cells[4].Value.ToString();
                        string cell6 = NB5_1.Rows[i].Cells[5].Value == null ? "" : NB5_1.Rows[i].Cells[5].Value.ToString();
                        string cell7 = NB5_1.Rows[i].Cells[6].Value == null ? "" : NB5_1.Rows[i].Cells[6].Value.ToString();
                        string cell8 = NB5_1.Rows[i].Cells[7].Value == null ? "" : NB5_1.Rows[i].Cells[7].Value.ToString();
                        string cell9 = NB5_1.Rows[i].Cells[8].Value == null ? "" : NB5_1.Rows[i].Cells[8].Value.ToString();
                        string cell10 = NB5_1.Rows[i].Cells[9].Value == null ? "" : NB5_1.Rows[i].Cells[9].Value.ToString();


                        if (nb5_1 == "")
                            nb5_1 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6 + "&" + cell7 + "&" + cell8 + "&" + cell9 + "&" + cell10 + "&";
                        else
                            nb5_1 = nb5_1 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&" + cell5 + "&" + cell6 + "&" + cell7 + "&" + cell8 + "&" + cell9 + "&" + cell10 + "&";
                    }

                    string nb7_1 = "";
                    for (int i = 0; i < NB7_1.Rows.Count - 1; i++)
                    {

                        string cell1 = NB7_1.Rows[i].Cells[0].Value == null ? "" : NB7_1.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB7_1.Rows[i].Cells[1].Value == null ? "" : NB7_1.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB7_1.Rows[i].Cells[2].Value == null ? "" : NB7_1.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB7_1.Rows[i].Cells[3].Value == null ? "" : NB7_1.Rows[i].Cells[3].Value.ToString();

                        if (nb7_1 == "")
                            nb7_1 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                        else
                            nb7_1 = nb7_1 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                    }

                    string nb7_4 = "";
                    for (int i = 0; i < NB7_4.Rows.Count - 1; i++)
                    {

                        string cell1 = NB7_4.Rows[i].Cells[0].Value == null ? "" : NB7_4.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB7_4.Rows[i].Cells[1].Value == null ? "" : NB7_4.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB7_4.Rows[i].Cells[2].Value == null ? "" : NB7_4.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB7_4.Rows[i].Cells[3].Value == null ? "" : NB7_4.Rows[i].Cells[3].Value.ToString();
                        

                        if (nb7_4 == "")
                            nb7_4 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                        else
                            nb7_4 = nb7_4 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                    }

                    string nb7_5 = "";
                    for (int i = 0; i < NB7_4.Rows.Count - 1; i++)
                    {

                        string cell1 = NB7_4.Rows[i].Cells[0].Value == null ? "" : NB7_4.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB7_4.Rows[i].Cells[1].Value == null ? "" : NB7_4.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB7_4.Rows[i].Cells[2].Value == null ? "" : NB7_4.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB7_4.Rows[i].Cells[3].Value == null ? "" : NB7_4.Rows[i].Cells[3].Value.ToString();


                        if (nb7_5 == "")
                            nb7_5 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                        else
                            nb7_5 = nb7_5 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                    }

                    string nb7_6 = "";
                    for (int i = 0; i < NB7_4.Rows.Count - 1; i++)
                    {

                        string cell1 = NB7_6.Rows[i].Cells[0].Value == null ? "" : NB7_6.Rows[i].Cells[0].Value.ToString();
                        string cell2 = NB7_6.Rows[i].Cells[1].Value == null ? "" : NB7_6.Rows[i].Cells[1].Value.ToString();
                        string cell3 = NB7_6.Rows[i].Cells[2].Value == null ? "" : NB7_6.Rows[i].Cells[2].Value.ToString();
                        string cell4 = NB7_6.Rows[i].Cells[3].Value == null ? "" : NB7_6.Rows[i].Cells[3].Value.ToString();


                        if (nb7_6 == "")
                            nb7_6 = "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                        else
                            nb7_6 = nb7_6 + Environment.NewLine + "#" + cell1 + "&" + cell2 + "&" + cell3 + "&" + cell4 + "&";
                    }


                    #region Kartaberemennoy
                    comm.Parameters.AddWithValue("@KB_1", KB_1.Text);
                    comm.Parameters.AddWithValue("@KB_2", KB_2.Text);
                    comm.Parameters.AddWithValue("@KB_3", Convert.ToDateTime(KB_3.Text));
                    comm.Parameters.AddWithValue("@KB_4", KB_4.Text);
                    comm.Parameters.AddWithValue("@KB_5", KB_5.Text);
                    comm.Parameters.AddWithValue("@KB_6", Convert.ToDateTime(KB_6.Text));
                    comm.Parameters.AddWithValue("@KB_7", Convert.ToDateTime(KB_7.Text));
                    comm.Parameters.AddWithValue("@KB_8", Convert.ToDateTime(KB_8.Text));
                    comm.Parameters.AddWithValue("@KB_9", Convert.ToDateTime(KB_9.Text));
                    comm.Parameters.AddWithValue("@KB_10", Convert.ToDateTime(KB_10.Text));
                    comm.Parameters.AddWithValue("@KB_11", KB_11.Text);
                    comm.Parameters.AddWithValue("@KB_12", KB_12.Text);
                    comm.Parameters.AddWithValue("@KB_13", KB_13.Text);
                    comm.Parameters.AddWithValue("@KB_14", KB_14.Text);
                    comm.Parameters.AddWithValue("@KB_15", kb15);
                    comm.Parameters.AddWithValue("@KB_16", kb16);
                    comm.Parameters.AddWithValue("@KB_17", KB_17.Text);
                    comm.Parameters.AddWithValue("@KB_18", KB_18.Text);
                    comm.Parameters.AddWithValue("@KB_19", KB_19.Text);
                    comm.Parameters.AddWithValue("@KB_20", KB_20.Text);
                    #endregion

                    #region SvedenieoPacientke
                    comm.Parameters.AddWithValue("SP1_1", SP1_1.Text);
                    comm.Parameters.AddWithValue("SP1_2", SP1_2.Text);
                    comm.Parameters.AddWithValue("SP1_3", SP1_3.Text);
                    comm.Parameters.AddWithValue("SP1_4", SP1_4.Text);
                    comm.Parameters.AddWithValue("SP1_5", SP1_5.Text);
                    comm.Parameters.AddWithValue("SP1_6", SP1_6.Text);
                    comm.Parameters.AddWithValue("SP1_7", SP1_7.Text);
                    comm.Parameters.AddWithValue("SP1_8", SP1_8.Text);
                    comm.Parameters.AddWithValue("SP1_9", SP1_9.Text);
                    comm.Parameters.AddWithValue("SP1_10", SP1_10.Text);
                    comm.Parameters.AddWithValue("SP1_11", SP1_11.Text);
                    comm.Parameters.AddWithValue("SP1_12", SP1_12.Text);
                    comm.Parameters.AddWithValue("SP1_13", SP1_13.Text);
                    comm.Parameters.AddWithValue("SP1_14", SP1_14.Text);
                    comm.Parameters.AddWithValue("SP1_15", SP1_15.Text);
                    comm.Parameters.AddWithValue("SP1_16", SP1_16.Text);
                    comm.Parameters.AddWithValue("SP1_17", SP1_17.Text);
                    comm.Parameters.AddWithValue("SP1_18", SP1_18.Text);
                    comm.Parameters.AddWithValue("SP1_19", SP1_19.Text);
                    comm.Parameters.AddWithValue("SP1_20", SP1_20.Text);
                    comm.Parameters.AddWithValue("SP1_21", SP1_21.Text);
                    comm.Parameters.AddWithValue("SP1_22", SP1_22.Text);
                    comm.Parameters.AddWithValue("SP1_23", SP1_23.Text);
                    comm.Parameters.AddWithValue("SP1_24", SP1_24.Text);
                    comm.Parameters.AddWithValue("SP1_25", SP1_25.Text);
                    comm.Parameters.AddWithValue("SP1_26", SP1_26.Text);
                    #endregion

                    #region SvedenieoPacientke2
                    comm.Parameters.AddWithValue("SP2_1", sp2_1);
                    comm.Parameters.AddWithValue("SP2_2", sp2_2);
                    comm.Parameters.AddWithValue("SP2_3", SP2_3.Text);
                    comm.Parameters.AddWithValue("SP2_4", SP2_4.Text);
                    comm.Parameters.AddWithValue("SP2_5", SP2_5.Text);
                    comm.Parameters.AddWithValue("SP2_6", SP2_6.Text);
                    comm.Parameters.AddWithValue("SP2_7", SP2_7.Text);
                    comm.Parameters.AddWithValue("SP2_8", SP2_8.Text);
                    comm.Parameters.AddWithValue("SP2_9", SP2_9.Text);
                    comm.Parameters.AddWithValue("SP2_10", SP2_10.Text);
                    comm.Parameters.AddWithValue("SP2_11", SP2_11.Text);
                    comm.Parameters.AddWithValue("SP2_12", SP2_12.Text);
                    #endregion

                    #region NastoyashayaBeremennost1
                    comm.Parameters.AddWithValue("SB1_1", SB1_1.Text);
                    comm.Parameters.AddWithValue("SB1_2", SB1_2.Text);
                    comm.Parameters.AddWithValue("SB1_3", SB1_3.Text);
                    comm.Parameters.AddWithValue("SB1_4", SB1_4.Text);
                    comm.Parameters.AddWithValue("SB1_5", SB1_5.Text);
                    comm.Parameters.AddWithValue("SB1_6", SB1_6.Text);
                    comm.Parameters.AddWithValue("SB1_7", SB1_7.Text);
                    comm.Parameters.AddWithValue("SB1_8", SB1_8.Text);
                    comm.Parameters.AddWithValue("SB1_9", SB1_9.Text);
                    comm.Parameters.AddWithValue("SB1_10", SB1_10.Text);
                    comm.Parameters.AddWithValue("SB1_11", SB1_11.Text);
                    comm.Parameters.AddWithValue("SB1_12", SB1_12.Text);
                    comm.Parameters.AddWithValue("SB1_13", SB1_13.MaxDate);
                    comm.Parameters.AddWithValue("SB1_14", SB1_14.Text);
                    comm.Parameters.AddWithValue("SB1_15", SB1_15.Text);
                    comm.Parameters.AddWithValue("SB1_16", SB1_16.Text);
                    comm.Parameters.AddWithValue("SB1_17", SB1_17.Text);
                    comm.Parameters.AddWithValue("SB1_18", SB1_18.Text);
                    comm.Parameters.AddWithValue("SB1_19", SB1_19.Text);
                    comm.Parameters.AddWithValue("SB1_20", SB1_20.Text);
                    comm.Parameters.AddWithValue("SB1_21", SB1_21.Text);
                    comm.Parameters.AddWithValue("SB1_22", SB1_22.Text);
                    #endregion

                    #region NastoyashayaBeremennost2
                    comm.Parameters.AddWithValue("SB2_1", SB2_1.Text);
                    comm.Parameters.AddWithValue("SB2_2", SB2_2.Text);
                    comm.Parameters.AddWithValue("SB2_3", SB2_3.Text);
                    comm.Parameters.AddWithValue("SB2_4", SB2_4.Text);
                    #endregion

                    #region NabludenieZaBeremennosty
                    comm.Parameters.AddWithValue("NB1_1", NB1_1.Text);
                    comm.Parameters.AddWithValue("NB1_2", NB1_2.Text);
                    comm.Parameters.AddWithValue("NB1_3", NB1_3.Text);
                    comm.Parameters.AddWithValue("NB1_4", NB1_4.Text);
                    comm.Parameters.AddWithValue("NB1_5", NB1_5.Text);
                    comm.Parameters.AddWithValue("NB1_6", NB1_6.Text);
                    comm.Parameters.AddWithValue("NB1_7", NB1_7.Text);
                    comm.Parameters.AddWithValue("NB1_8", NB1_8.Text);
                    comm.Parameters.AddWithValue("NB1_9", NB1_9.Text);
                    comm.Parameters.AddWithValue("NB1_10", nb1_10);
                    #endregion

                    #region NabludenieZaBeremennosty2
                    comm.Parameters.AddWithValue("NB2_1", nb2_1);
                    comm.Parameters.AddWithValue("NB2_2", nb2_2);
                    comm.Parameters.AddWithValue("NB2_3", nb2_3);
                    #endregion

                    #region NabludenieZaBeremennosty3
                    comm.Parameters.AddWithValue("NB3_1", nb3_1);
                    comm.Parameters.AddWithValue("NB3_2", nb3_2);
                    comm.Parameters.AddWithValue("NB3_3", nb3_3);
                    comm.Parameters.AddWithValue("NB3_4", nb3_4);
                    #endregion

                    #region NabludenieZaBeremennosty4
                    comm.Parameters.AddWithValue("NB4_1", nb4_1);
                    comm.Parameters.AddWithValue("NB4_2", nb4_2);
                    comm.Parameters.AddWithValue("NB4_3", nb4_3);
                    comm.Parameters.AddWithValue("NB4_4", nb4_4);
                    comm.Parameters.AddWithValue("NB4_5", NB4_5.Text);
                    comm.Parameters.AddWithValue("NB4_6", NB4_6.Text);
                    comm.Parameters.AddWithValue("NB4_7", NB4_7.Text);
                    comm.Parameters.AddWithValue("NB4_8", NB4_8.Text);
                    #endregion

                    #region NabludenieZaBeremennosty5
                    comm.Parameters.AddWithValue("NB5_1", nb5_1);
                    comm.Parameters.AddWithValue("NB5_2", NB5_2.Text);
                    comm.Parameters.AddWithValue("NB5_3", NB5_3.Text);
                    comm.Parameters.AddWithValue("NB5_4", NB5_4.Text);
                    comm.Parameters.AddWithValue("NB5_5", NB5_5.Text);
                    comm.Parameters.AddWithValue("NB5_6", NB5_6.Text);
                    #endregion

                    #region NabludenieZaBeremennosty6
                    comm.Parameters.AddWithValue("NB6_1", NB6_1.Text);
                    comm.Parameters.AddWithValue("NB6_2", NB6_2.Text);
                    #endregion

                    #region NabludenieZaBeremennosty7
                    comm.Parameters.AddWithValue("NB7_1", nb7_1);
                    comm.Parameters.AddWithValue("NB7_2", NB7_2.Text);
                    comm.Parameters.AddWithValue("NB7_3", NB7_3.Text);
                    comm.Parameters.AddWithValue("NB7_4", nb7_4);
                    comm.Parameters.AddWithValue("NB7_5", nb7_5);
                    comm.Parameters.AddWithValue("NB7_6", nb7_6);
                    #endregion

                    comm.ExecuteNonQuery();
                }

                

            }

            MessageBox.Show("Информация добавлена!");

        }





        private void checkBoxOpredelenieAntitel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOpredelenieAntitel.Checked == true)
                NB3_1.Enabled = false;
            else
                NB3_1.Enabled = true;
        }

        private void checkBoxKrasnuha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKrasnuha.Checked == true)
                NB3_2.Enabled = false;
            else
                NB3_2.Enabled = true;
        }

        private void checkBoxAntirezurs_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAntirezurs.Checked == true)
                NB3_3.Enabled = false;
            else
                NB3_3.Enabled = true;
        }
    }
}
