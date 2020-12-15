using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimePlan
{
    public partial class Form1 : Form
    {
        FileInfo day_file = new FileInfo("temp_day.txt");
        FileInfo week_file = new FileInfo("temp_week.txt");
        FileInfo sem_file = new FileInfo("temp_sem.txt");
        FileInfo long_file = new FileInfo("temp_long.txt");

        FileInfo history_day = new FileInfo("history_day.txt");
        FileInfo history_week = new FileInfo("history_week.txt");
        FileInfo history_sem = new FileInfo("history_sem.txt");

        bool loaded = false;

        public Form1()
        {
            InitializeComponent();
            if (day_file.Exists)
            {
                StreamReader streamReader = day_file.OpenText();
                string str;
                while ((str = streamReader.ReadLine()) != null)
                {
                    if (str.Length > 2)
                    {
                        checkedListDay.Items.Add(str.Substring(0, str.Length - 2), str[str.Length - 1] == '1');
                    }                    
                }
                streamReader.Close();
            }
            
            if (week_file.Exists)
            {
                StreamReader streamReader = week_file.OpenText();
                string str;
                while ((str = streamReader.ReadLine()) != null)
                {
                    if (str.Length > 2)
                    {
                        checkedListWeek.Items.Add(str.Substring(0, str.Length - 2), str[str.Length - 1] == '1');
                    }
                }
                streamReader.Close();
            }
            
            if (sem_file.Exists)
            {
                StreamReader streamReader = sem_file.OpenText();
                string str;
                while ((str = streamReader.ReadLine()) != null)
                {
                    if (str.Length > 2)
                    {
                        checkedListSem.Items.Add(str.Substring(0, str.Length - 2), str[str.Length - 1] == '1');
                    }
                }
                streamReader.Close();
            }
            
            if (long_file.Exists)
            {
                StreamReader streamReader = long_file.OpenText();
                string str;
                while ((str = streamReader.ReadLine()) != null)
                {
                    if (str.Length > 2)
                    {
                        checkedListLong.Items.Add(str.Substring(0, str.Length - 2), str[str.Length - 1] == '1');
                    }
                }
                streamReader.Close();
            }
            loaded = true;
        }

        private void long_button_Click(object sender, EventArgs e)
        {
            long_panel.Visible = true;
            sem_panel.Visible = false;
            week_panel.Visible = false;
            day_panel.Visible = false;
        }

        private void sem_button_Click(object sender, EventArgs e)
        {
            long_panel.Visible = false;
            sem_panel.Visible = true;
            week_panel.Visible = false;
            day_panel.Visible = false;
        }

        private void week_button_Click(object sender, EventArgs e)
        {
            long_panel.Visible = false;
            sem_panel.Visible = false;
            week_panel.Visible = true;
            day_panel.Visible = false;
        }

        private void day_button_Click(object sender, EventArgs e)
        {
            long_panel.Visible = false;
            sem_panel.Visible = false;
            week_panel.Visible = false;
            day_panel.Visible = true;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (sender as Button == add_btn_long)
            {
                if (add_txt_long.Text != "")
                {
                    checkedListLong.Items.Add(add_txt_long.Text);
                    add_txt_long.Text = "";
                    save('l');
                }
            }
            else if (sender as Button == add_btn_sem)
            {
                if (add_txt_sem.Text != "")
                {
                    checkedListSem.Items.Add(add_txt_sem.Text);
                    add_txt_sem.Text = "";
                    save('s');
                }
            }
            else if (sender as Button == add_btn_week)
            {
                if (add_txt_week.Text != "")
                {
                    checkedListWeek.Items.Add(add_txt_week.Text);
                    add_txt_week.Text = "";
                    save('w');
                }
            }
            else
            {
                if (add_txt_day.Text != "")
                {
                    checkedListDay.Items.Add(add_txt_day.Text);
                    add_txt_day.Text = "";
                    save('d');
                }
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (sender as Button == remove_btn_long && checkedListLong.SelectedIndex != -1)
            {
                checkedListLong.Items.RemoveAt(checkedListLong.SelectedIndex);
                save('l');
            }
            else if (sender as Button == remove_btn_sem && checkedListSem.SelectedIndex != -1)
            {
                checkedListSem.Items.RemoveAt(checkedListSem.SelectedIndex);
                save('s');
            }
            else if (sender as Button == remove_btn_week && checkedListWeek.SelectedIndex != -1)
            {
                checkedListWeek.Items.RemoveAt(checkedListWeek.SelectedIndex);
                save('w');
            }
            else
            {
                checkedListDay.Items.RemoveAt(checkedListDay.SelectedIndex);
                save('d');
            }
        }

        private void save(char type)
        {
            if (type == 'd')
            {
                string day_data = "";
                for (int i = 0; i < checkedListDay.Items.Count; i++)
                {
                    day_data += checkedListDay.Items[i].ToString() + ':' + (checkedListDay.GetItemChecked(i) ? 1 : 0) + '\n';
                }
                StreamWriter streamWriter = day_file.CreateText();
                streamWriter.WriteLine(day_data);
                streamWriter.Close();
            }
            else if (type == 'w')
            {
                string week_data = "";
                for (int i = 0; i < checkedListWeek.Items.Count; i++)
                {
                    week_data += checkedListWeek.Items[i].ToString() + ':' + (checkedListWeek.GetItemChecked(i) ? 1 : 0) + '\n';
                }
                StreamWriter streamWriter = week_file.CreateText();
                streamWriter.WriteLine(week_data);
                streamWriter.Close();
            }
            else if (type == 's')
            {
                string sem_data = "";
                for (int i = 0; i < checkedListSem.Items.Count; i++)
                {
                    sem_data += checkedListSem.Items[i].ToString() + ':' + (checkedListSem.GetItemChecked(i) ? 1 : 0) + '\n';
                }
                StreamWriter streamWriter = sem_file.CreateText();
                streamWriter.WriteLine(sem_data);
                streamWriter.Close();
            }
            else
            {
                string long_data = "";
                for (int i = 0; i < checkedListLong.Items.Count; i++)
                {
                    long_data += checkedListLong.Items[i].ToString() + ':' + (checkedListLong.GetItemChecked(i) ? 1 : 0) + '\n';
                }
                StreamWriter streamWriter = long_file.CreateText();
                streamWriter.WriteLine(long_data);
                streamWriter.Close();
            }
        }

        private void checkedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (loaded)
            {
                if (sender as CheckedListBox == checkedListDay)
                {
                    this.BeginInvoke((MethodInvoker)delegate {
                        save('d');
                    });
                }
                else if (sender as CheckedListBox == checkedListWeek)
                {
                    this.BeginInvoke((MethodInvoker)delegate {
                        save('w');
                    });
                }
                else if (sender as CheckedListBox == checkedListSem)
                {
                    this.BeginInvoke((MethodInvoker)delegate {
                        save('s');
                    });
                }
                else
                {
                    this.BeginInvoke((MethodInvoker)delegate {
                        save('l');
                    });
                }
            }
        }

        private void end_btn_Click(object sender, EventArgs e)
        {
            if (sender as Button == end_btn_day)
            {
                StreamWriter streamWriter = history_day.AppendText();
                DateTime today = DateTime.Now;
                streamWriter.WriteLine(today.ToString());
                string day_data = "";
                for (int i = 0; i < checkedListDay.Items.Count; i++)
                {
                    day_data += checkedListDay.Items[i].ToString() + ':' + (checkedListDay.GetItemChecked(i) ? 1 : 0) + '\n';
                }
                streamWriter.WriteLine(day_data);
                streamWriter.Close();
                checkedListDay.Items.Clear();
            }
            else if (sender as Button == end_btn_week)
            {
                StreamWriter streamWriter = history_week.AppendText();
                DateTime today = DateTime.Now;
                streamWriter.WriteLine(today.ToString());
                string week_data = "";
                for (int i = 0; i < checkedListWeek.Items.Count; i++)
                {
                    week_data += checkedListWeek.Items[i].ToString() + ':' + (checkedListWeek.GetItemChecked(i) ? 1 : 0) + '\n';
                }
                streamWriter.WriteLine(week_data);
                streamWriter.Close();
                checkedListWeek.Items.Clear();
            }
            else
            {
                StreamWriter streamWriter = history_sem.AppendText();
                DateTime today = DateTime.Now;
                streamWriter.WriteLine(today.ToString());
                string sem_data = "";
                for (int i = 0; i < checkedListSem.Items.Count; i++)
                {
                    sem_data += checkedListSem.Items[i].ToString() + ':' + (checkedListSem.GetItemChecked(i) ? 1 : 0) + '\n';
                }
                streamWriter.WriteLine(sem_data);
                streamWriter.Close();
                checkedListSem.Items.Clear();
            }
        }
    }
}
