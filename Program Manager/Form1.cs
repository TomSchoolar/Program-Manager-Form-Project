using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program_Manager
{
    public partial class Program_Manager_Form : Form
    {
        public Program_Manager_Form()
        {
            InitializeComponent();

            Set_Deafult_Color();

            Version_label.Visible = true;

            if (Program_Manager.Properties.Settings.Default.Programs.Length < 1)
            {
                Program_Manager.Properties.Settings.Default.Programs = "Deafult Program: Netflix - Monday, 12:00";
            }

            Program_Manager.Properties.Settings.Default.Save();
           
            WatchList_Update();

            DateTime v = DateTime.Now;
            Program_Manager.Properties.Settings.Default.Last_Log_On_Date_And_Time = v.ToString();
            Program_Manager.Properties.Settings.Default.Save();

            Title.Text = "Program Manager";
            Edit_Programs_Button.Text = "Edit Programs";
            Edit_Services_Button.Text = "Edit Services";
            label1.Text = "WatchList";

            Back_Button.Text = "Back";

            Add_Program_Button.Text = "Add Program";
            Add_Program_Button.BackColor = Color.LimeGreen;
            Remove_Program_Button.Text = "Remove Program";
            Remove_Program_Button.BackColor = Color.Tomato;

            Add_Button.BackColor = Color.LimeGreen;

            Add_Service_Button.BackColor = Color.LimeGreen;
            Remove_Service_Button.BackColor = Color.Tomato;

            Arrange_Program_List();

            Monday_RB.Select();

            Change_Page(Page);
        }

        string Page = "Title";
        int x = 0;
        DateTime current_day = DateTime.Now;

        private void WatchList_Update()
        {
            DayOfWeek Day = current_day.DayOfWeek;

            string WatchList = Program_Manager.Properties.Settings.Default.Programs;
            Char delimiter = '/';
            string[] substrings = WatchList.Split(delimiter);

            for (int a = substrings.Length; a != 0; a = a - 1)
            {
                string show = substrings[a - 1];
                if (show != "")
                {
                    string[] parachal_show_strings = show.Split('-');
                    string show_time_date = parachal_show_strings[1];

                    string[] day_l = show_time_date.Split(' ');
                    string air_day = day_l[1];
                    air_day = air_day.Remove(air_day.Length - 1);
                    DateTime air_day_dt = (current_day);

                    while (air_day_dt.DayOfWeek.ToString() != air_day)
                    {
                        air_day_dt = air_day_dt.AddDays(-1);
                    }

                    string[] lastlogondaylist = Program_Manager.Properties.Settings.Default.Last_Log_On_Date_And_Time.Split(' ');
                    DateTime lastlogondayday;
                    if (lastlogondaylist.Length < 2)
                    {
                        lastlogondayday = DateTime.Now;
                    }
                    else
                    {
                        lastlogondayday = Convert.ToDateTime(lastlogondaylist[0]);
                    }
                    if ((lastlogondayday - air_day_dt).TotalDays < -1)
                    {
                        string w = Program_Manager.Properties.Settings.Default.WatchList.ToString();
                        if (w != null)
                        {
                            Program_Manager.Properties.Settings.Default.WatchList = w + '/' + show;
                            Program_Manager.Properties.Settings.Default.Save();
                        }
                        else
                        {
                            Program_Manager.Properties.Settings.Default.WatchList = show;
                            Program_Manager.Properties.Settings.Default.Save();
                        }

                    }
                }
            }
            Arrange_Program_List();
        }

        private void Save()
        {
            Program_Manager.Properties.Settings.Default.Save();

            if (Page == "Title")
            {
                string WatchList = Program_Manager.Properties.Settings.Default.WatchList;
                Char delimiter = '/';
                string[] substrings = WatchList.Split(delimiter);

                string text = "";

                for (int a = substrings.Length; a != 0; a = a - 1)
                {
                    text = text + "/";
                    text = text + substrings[a-1];
                }
            }

            if (Page == "Edit Programs")
            {
                string Programs = Program_Manager.Properties.Settings.Default.Programs;
                Char delimiter = '/';
                string[] substrings = Programs.Split(delimiter);

                string text = "";

                for (int a = substrings.Length; a != 0; a = a - 1)
                {
                    text = text + '/';
                    text = text + substrings[a - 1];
                }
            }
        }

        private void Arrange_Program_List()
        {
            Save();

            if (Page == "Title")
            {
                Program_List.Items.Clear();

                string WatchList = Program_Manager.Properties.Settings.Default.WatchList;
                Char delimiter = '/';
                string[] substrings = WatchList.Split(delimiter);

                string FirstItem = "";
                int x = 0;
                for (int a = substrings.Length; a != 0; a = a - 1)
                {
                    if (x == substrings.Length)
                        FirstItem = substrings[a - 1];
                    Program_List.Items.Add(substrings[a - 1]);
                    x = x + 1;
                }

                // sort? //
            }

            if (Page == "Edit Programs")
            {
                Program_List.Items.Clear();

                string WatchList = Program_Manager.Properties.Settings.Default.Programs;
                Char delimiter = '/';
                string[] substrings = WatchList.Split(delimiter);

                string FirstItem = "";
                int x = 0;
                for (int a = substrings.Length; a != 0; a = a - 1)
                {
                    if (x == substrings.Length)
                        FirstItem = substrings[a - 1];
                    Program_List.Items.Add(substrings[a - 1]);
                    x = x + 1;
                }

                // sort? //
            }


            if (true)
            {
                if (Page == "Edit Services")
                {
                    Services_List_Box.Items.Clear();

                    string Services = Program_Manager.Properties.Settings.Default.Services;
                    Char delimiter = '/';
                    string[] substrings = Services.Split(delimiter);

                    string FirstItem = "";
                    int x = 0;
                    for (int a = substrings.Length; a != 0; a = a - 1)
                    {
                        if (x == substrings.Length)
                            FirstItem = substrings[a - 1];
                        Services_List_Box.Items.Add(substrings[a - 1]);
                        x = x + 1;
                    }

                    // sort? //
                }

                if (Page == "Add")
                {
                    Services_List_Box.Items.Clear();

                    string Services = Program_Manager.Properties.Settings.Default.Services;
                    Char delimiter = '/';
                    string[] substrings = Services.Split(delimiter);

                    string FirstItem = "";
                    int x = 0;
                    for (int a = substrings.Length; a != 0; a = a - 1)
                    {
                        if (x == substrings.Length)
                            FirstItem = substrings[a - 1];
                        Services_List_Box.Items.Add(substrings[a - 1]);
                        x = x + 1;
                    }

                    // sort? //
                }
            }
        }


        Color text_deafult = Color.WhiteSmoke;

        Color back_deafult = Color.FromArgb(36,36,36);
        Color deafult = Color.FromArgb(36, 36, 36);

        Color btn_deafult = Color.FromArgb(36, 36, 36);
        Color btn_edge_deafult = Color.WhiteSmoke;

        private void Smooth_Btns(Button btn_name)
        {
            btn_name.FlatStyle = FlatStyle.Flat;
            btn_name.FlatAppearance.BorderColor = btn_edge_deafult;
            btn_name.BackColor = btn_deafult;
            btn_name.FlatAppearance.BorderSize = 1;
            btn_name.ForeColor = text_deafult;
        }

        private void Set_text_deafult_Color_Font()
        {
            Title.ForeColor = text_deafult;
            label1.ForeColor = text_deafult;

            label2.ForeColor = text_deafult;
            Show_Name_Text_Box.ForeColor = text_deafult;
            Monday_RB.ForeColor = text_deafult;
            Tuesday_RB.ForeColor = text_deafult;
            Wednesday_RB.ForeColor = text_deafult;
            Thursday_RB.ForeColor = text_deafult;
            Friday_RB.ForeColor = text_deafult;
            Saturday_RB.ForeColor = text_deafult;
            Sunday_RB.ForeColor = text_deafult;
            label3.ForeColor = text_deafult;

            Info_on_Services.ForeColor = text_deafult;
            Service_Text_Box.ForeColor = text_deafult;

            Everyday_RB.ForeColor = text_deafult;

            label4.ForeColor = text_deafult;
            label5.ForeColor = text_deafult;

            Help_Text_Box.ForeColor = text_deafult;

            Version_label.ForeColor = text_deafult;

            Help_Button.ForeColor = text_deafult;
        }

        private void Set_Deafult_Color()
        {
            Set_text_deafult_Color_Font();

            this.BackColor = back_deafult;

            Button[] btn_list = { Edit_Programs_Button, Edit_Services_Button, Seen_Button, Add_Program_Button, Remove_Program_Button, Add_Button, Add_Service_Button, Remove_Service_Button, Back_Button , Help_Button};
            foreach (Button btn in btn_list)
                Smooth_Btns(btn);

            Title.BackColor = deafult;
            Program_List.BackColor = Color.WhiteSmoke;
            label1.BackColor = deafult;

            label2.BackColor = deafult;
            Show_Name_Text_Box.BackColor = deafult;
            Monday_RB.BackColor = deafult;
            Tuesday_RB.BackColor = deafult;
            Wednesday_RB.BackColor = deafult;
            Thursday_RB.BackColor = deafult;
            Friday_RB.BackColor = deafult;
            Saturday_RB.BackColor = deafult;
            Sunday_RB.BackColor = deafult;
            Services_List_Box.BackColor = deafult;
            Hour_NUD.BackColor = Color.White;
            Min_NUD.BackColor = Color.White;
            label3.BackColor = deafult;

            Info_on_Services.BackColor = deafult;
            Services_List_Box.BackColor = Color.WhiteSmoke;
            Service_Text_Box.BackColor = deafult;

            Everyday_RB.BackColor = deafult;

            label4.BackColor = deafult;
            label5.BackColor = deafult;

            Help_Text_Box.BackColor = deafult;
        }

        private void Clean_Slate()
        {
            Title.Text = "Program Manager";
            Title.Visible = true;
            Program_List.Visible = false;
            Edit_Programs_Button.Visible = false;
            Edit_Services_Button.Visible = false;
            Back_Button.Visible = true;
            label1.Visible = false;
            Seen_Button.Visible = false;

            Add_Program_Button.Visible = false;
            Remove_Program_Button.Visible = false;

            Add_Button.Visible = false;
            label2.Visible = false;
            Show_Name_Text_Box.Visible = false;
            Monday_RB.Visible = false;
            Tuesday_RB.Visible = false;
            Wednesday_RB.Visible = false;
            Thursday_RB.Visible = false;
            Friday_RB.Visible = false;
            Saturday_RB.Visible = false;
            Sunday_RB.Visible = false;
            Services_List_Box.Visible = false;
            Hour_NUD.Visible = false;
            Min_NUD.Visible = false;
            label3.Visible = false;

            Info_on_Services.Visible = false;
            Add_Service_Button.Visible = false;
            Remove_Service_Button.Visible = false;
            Services_List_Box.Visible = false;
            Service_Text_Box.Visible = false;

            Everyday_RB.Visible = false;

            label4.Visible = false;
            label5.Visible = false;

            Help_Text_Box.Visible = false;

            Help_Button.Visible = true;
        }

        private void Change_Page(string Page)
        {
            if (Page == "Title")
            {
                Clean_Slate();

                Back_Button.Visible = false;

                Program_List.Visible = true;
                Edit_Programs_Button.Visible = true;
                Edit_Services_Button.Visible = true;
                label1.Visible = true;
                Seen_Button.Visible = true;

                label1.Visible = true;

                label1.Text = "WatchList";

                x = x + 1;

                if (x > 1)
                {
                    Arrange_Program_List();
                }
            }

            if(Page == "Help")
            {
                Clean_Slate();
                Help_Button.Visible = false;
                Help_Text_Box.Visible = true;
                Title.Text = "   | Help + FAQ |";
            }

            if (Page == "Edit Programs")
            {
                Clean_Slate();

                Program_List.Visible = true;
                label1.Visible = true;

                Add_Program_Button.Visible = true;
                Remove_Program_Button.Visible = true;

                label1.Text = "Programs";
                Arrange_Program_List();
            }

            if (Page=="Edit Services")
            {
                Clean_Slate();

                Info_on_Services.Visible = true;
                Add_Service_Button.Visible = true;
                Remove_Service_Button.Visible = true;
                Services_List_Box.Visible = true;
                Service_Text_Box.Visible = true;

                label4.Visible = true;
                label5.Visible = true;
            }

            if (Page == "Add")
            {
                Clean_Slate();

                Add_Button.Visible = true;
                label2.Visible = true;
                Show_Name_Text_Box.Visible = true;
                Show_Name_Text_Box.Text = "";
                Monday_RB.Visible = true;
                Monday_RB.Checked = true;
                Tuesday_RB.Visible = true;
                Wednesday_RB.Visible = true;
                Thursday_RB.Visible = true;
                Friday_RB.Visible = true;
                Saturday_RB.Visible = true;
                Sunday_RB.Visible = true;
                Services_List_Box.Visible = true;
                Hour_NUD.Visible = true;
                Hour_NUD.Value = 0;
                Min_NUD.Visible = true;
                Min_NUD.Value = 0;
                label3.Visible = true;

                Everyday_RB.Visible = true;
            }
            
            if (Page == "Title")
                Back_Button.BackColor = SystemColors.Control;
            else
                Back_Button.BackColor = Color.OrangeRed;
        }

        private void Edit_Programs_Button_Click(object sender, EventArgs e)
        {
            Page = "Edit Programs";
            Change_Page(Page);
        }

        private void Edit_Services_Button_Click(object sender, EventArgs e)
        {
            Page = "Edit Services";
            Change_Page(Page);
            Arrange_Program_List();
        }

        private void Back_Button_Click(object sender, EventArgs e)
        {
            Page = "Title";
            Change_Page("Title");
        }

        private void Add_Program_Button_Click(object sender, EventArgs e)
        {
            Page = "Add";
            Change_Page(Page);
            Arrange_Program_List();
        }

        private void Remove_Program_Button_Click(object sender, EventArgs e)
        {
            string w = Program_List.Items.Count.ToString();
            int x = Convert.ToInt32(w);
            if (x > 1)
            {
                if (MessageBox.Show("Are you sure you want to delete " + Program_List.Text + " ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string program = Program_List.Text;

                    string text = Program_Manager.Properties.Settings.Default.Programs.ToString();
                    string text2 = "";

                    Char delimiter = '/';
                    string[] substrings = text.Split(delimiter);

                    int c = 0;
                    int b = 0;
                    for (int a = substrings.Length; a != 0; a = a - 1)
                    {
                        if (substrings[b] != program)
                        {
                            text2 = text2 + "/" + substrings[b];
                        }
                        else
                        {
                            if (c == 1)
                                text2 = text2 + "/" + substrings[b];
                            c = 1;
                        }
                        b = b + 1;
                    }

                    Program_Manager.Properties.Settings.Default.Programs = text2;

                    Arrange_Program_List();

                }
            }
            else
            {
                MessageBox.Show("You need to have at least 1 show!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Add_Show(string air_day)
        {
            string show = "";
            string min = Min_NUD.Value.ToString();
            if (min == "0")
                min = "00";
            if (min == "5")
                min = "05";
            show = Show_Name_Text_Box.Text + ": " + Services_List_Box.SelectedItem + " - " + air_day + ", " + Hour_NUD.Value.ToString() + ":" + min;
            string t = Program_Manager.Properties.Settings.Default.Programs;
            t = t + '/' + show;
            Program_Manager.Properties.Settings.Default.Programs = t;
            Program_Manager.Properties.Settings.Default.Save();

            Page = "Title";
            Change_Page(Page);
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            if (Show_Name_Text_Box.Text != "")
            {
                if (Services_List_Box.SelectedIndex != -1)
                {
                    string day = "";

                    if (Monday_RB.Checked)
                        day = "Monday";
                    if (Tuesday_RB.Checked)
                        day = "Tuesday";
                    if (Wednesday_RB.Checked)
                        day = "Wednesday";
                    if (Thursday_RB.Checked)
                        day = "Thursday";
                    if (Friday_RB.Checked)
                        day = "Friday";
                    if (Saturday_RB.Checked)
                        day = "Saturday";
                    if (Sunday_RB.Checked)
                        day = "Sunday";
                    if (Everyday_RB.Checked)
                        day = "Everyday";

                    if (day != "Everyday")
                        Add_Show(day);
                    else
                    {
                        Add_Show("Monday");
                        Add_Show("Tuesday");
                        Add_Show("Wednesday");
                        Add_Show("Thursday");
                        Add_Show("Friday");
                        Add_Show("Saturday");
                        Add_Show("Sunday");
                    }
                }
                else
                    MessageBox.Show("You need to select a\nservice to create a show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("You need to select a\nname to create a show.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Seen_Button_Click(object sender, EventArgs e)
        {
            if (Program_List.SelectedIndex == -1)
                MessageBox.Show("Please select which show you have seen then press this button again.","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Are you sure you want to delete " + Program_List.Text + " ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string program = Program_List.Text;

                    string text = Program_Manager.Properties.Settings.Default.Programs.ToString();
                    string text2 = "";

                    Char delimiter = '/';
                    string[] substrings = text.Split(delimiter);

                    int c = 0;
                    int b = 0;
                    for (int a = substrings.Length; a != 0; a = a - 1)
                    {
                        if (substrings[b] != program)
                        {
                            if (c == 0)
                                text2 = text2 + "/" + substrings[b];
                        }
                        else
                        {
                            if (c == 1)
                                text2 = text2 + "/" + substrings[b];
                            c = 1;
                        }
                        b = b + 1;
                    }

                    Program_Manager.Properties.Settings.Default.WatchList = text2;

                    Arrange_Program_List();
                }
            }
        }

        private void Program_Manager_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program_Manager.Properties.Settings.Default.Save();
        }

        private void Add_Service_Button_Click(object sender, EventArgs e)
        {
            string text = Program_Manager.Properties.Settings.Default.Services;
            if (Service_Text_Box.Text.Length > 0)
            {
                if (text.Length < 1)
                    text = Service_Text_Box.Text.ToString();
                else
                    text = text + '/' + Service_Text_Box.Text.ToString();
                Program_Manager.Properties.Settings.Default.Services = text;
            }
            else
                MessageBox.Show("You must enter a name for your service.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            Program_Manager.Properties.Settings.Default.Save();

            Arrange_Program_List();

            Service_Text_Box.Text = "";
        }

        private void Remove_Service_Button_Click(object sender, EventArgs e)
        {
            if (Services_List_Box.SelectedIndex == -1)
                MessageBox.Show("Please select which service you want to delete\nthen press this button again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (MessageBox.Show("Are you sure you want to delete " + Services_List_Box.Text + " ?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string program = Services_List_Box.Text;

                    string text = Program_Manager.Properties.Settings.Default.Services.ToString();
                    string text2 = "";

                    Char delimiter = '/';
                    string[] substrings = text.Split(delimiter);

                    int c = 0;
                    int b = 0;
                    for (int a = substrings.Length; a != 0; a = a - 1)
                    {
                        if (substrings[b] != program)
                        {
                            if (c == 0)
                                text2 = text2 + "/" + substrings[b];
                        }
                        else
                        {
                            if (c == 1)
                                text2 = text2 + "/" + substrings[b];
                            c = 1;
                        }
                        b = b + 1;
                    }

                    Program_Manager.Properties.Settings.Default.Services = text2;

                    Arrange_Program_List();
                }
            }
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            Page = "Help";
            Change_Page(Page);
        }

        private void Program_Manager_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
