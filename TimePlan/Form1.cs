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
        FileInfo[] save_files = { new FileInfo("temp_week.txt"), new FileInfo("temp_sem.txt"), new FileInfo("temp_long.txt") };
        FileInfo[] history_files = { new FileInfo("history_week.txt"), new FileInfo("history_sem.txt") };

        bool loaded = false;

        string[] days_short = { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su", "None" };
        string[] days_long = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
        Dictionary<string, int> str_to_int = new Dictionary<string, int>
        {
            ["Mo"] = 0,
            ["Tu"] = 1,
            ["We"] = 2,
            ["Th"] = 3,
            ["Fr"] = 4,
            ["Sa"] = 5,
            ["Su"] = 6
        };

        // day, week, sem, long, week_board
        Panel[] panels = new Panel[4];
        Label[] labels = new Label[3];
        CheckedListBox[] checkBoxes = new CheckedListBox[3];
        TextBox[] add_txts = new TextBox[3];
        Button[] add_btns = new Button[3];
        Button[] remove_btns = new Button[3];
        Button[] end_btns = new Button[3];
        RadioButton[] week_rb = new RadioButton[8];

        // week board
        CheckedListBox[] wb_clbs = new CheckedListBox[7];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create the panels
            for (int i = 0; i < 3; i++) create_tab_panel(i);
            create_week_board();

            // Load data from save files
            for (int i = 0; i < 3; i++)
            {
                if (save_files[i].Exists)
                {
                    StreamReader streamReader = save_files[i].OpenText();
                    string str;
                    while ((str = streamReader.ReadLine()) != null)
                    {
                        if (str.Length > 2)
                        {
                            checkBoxes[i].Items.Add(str.Substring(0, str.Length - 2), str[str.Length - 1] == '1');

                            // Fill week board
                            if (i == 0 && str.Length > 3)
                            {
                                if (str_to_int.ContainsKey(str.Substring(0, 2)) && str[2] == ':')
                                {
                                    wb_clbs[str_to_int[str.Substring(0, 2)]].Items.Add(str.Substring(3, str.Length - 5), str[str.Length - 1] == '1');
                                }
                            }
                        }
                    }
                    streamReader.Close();
                }
            }
            loaded = true;
        }

        private void create_tab_panel(int index)
        {
            string[] name = { "Weekly", "Semester", "Long Term" };
            panels[index] = new Panel
            {
                BackColor = Color.FromArgb(46, 51, 70),
                Location = new Point(116, 0),
                Margin = new Padding(4),
                Size = new Size(1200, 700),
                Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)
            };

            labels[index] = new Label
            {
                Text = name[index] + " Plan",
                Font = new Font("Courier New", 16),
                ForeColor = Color.FromArgb(0, 255, 204),
                Location = new Point(49, 52),
                Margin = new Padding(4),
                Size = new Size(200, 27),
                Anchor = (AnchorStyles.Top | AnchorStyles.Left)
            };

            checkBoxes[index] = new CheckedListBox
            {
                BackColor = Color.FromArgb(46, 51, 60),
                Font = new Font("Courier New", 8),
                ForeColor = Color.FromArgb(0, 255, 204),
                Location = new Point(50, 120),
                Margin = new Padding(4),
                Size = new Size(450, 300),
                FormattingEnabled = true,
                HorizontalScrollbar = true,
                BorderStyle = BorderStyle.None,
                CheckOnClick = true,
                Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)
            };
            checkBoxes[index].ItemCheck += new ItemCheckEventHandler(checkedList_ItemCheck);

            add_txts[index] = new TextBox
            {
                BackColor = Color.FromArgb(189, 255, 242),
                BorderStyle = BorderStyle.None,
                Font = new Font("Courier New", 10),
                Location = new Point(530, 165),
                Margin = new Padding(4),
                Size = new Size(150, 22),
                Anchor = (AnchorStyles.Top | AnchorStyles.Right)
            };

            add_btns[index] = new Button
            {
                Text = "Add",
                UseVisualStyleBackColor = true,
                Location = new Point(570, 194),
                Margin = new Padding(4),
                Size = new Size(75, 28),
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
            };
            add_btns[index].Click += new EventHandler(add_btn_Click);

            remove_btns[index] = new Button
            {
                Text = "Remove",
                UseVisualStyleBackColor = true,
                Location = new Point(570, 230),
                Margin = new Padding(4),
                Size = new Size(75, 28),
                Anchor = (AnchorStyles.Top | AnchorStyles.Right)
            };
            remove_btns[index].Click += new EventHandler(remove_btn_Click);

            end_btns[index] = new Button
            {
                Text = "End ",
                UseVisualStyleBackColor = true,
                Location = new Point(570, 266),
                Margin = new Padding(4),
                Size = new Size(75, 28),
                Anchor = (AnchorStyles.Top | AnchorStyles.Right)
            };
            end_btns[index].Click += new EventHandler(end_btn_Click);

            if (index == 0)
            {
                for (short i = 0; i < 8; i++)
                {
                    week_rb[i] = new RadioButton
                    {
                        Location = new Point(463 + (i % 4) * 40 + (i == 7 ? 1 : 0) * 14, 120 + (i > 3 ? 1 : 0) * 20),
                        ForeColor = Color.FromArgb(0, 255, 204),
                        Font = new Font("Courier New", 8),
                        Text = days_short[i],
                        AutoSize = true,
                        Anchor = (AnchorStyles.Top | AnchorStyles.Right)
                    };
                    panels[0].Controls.Add(week_rb[i]);
                }
            }

            panels[index].Controls.Add(labels[index]);
            panels[index].Controls.Add(checkBoxes[index]);
            panels[index].Controls.Add(add_txts[index]);
            panels[index].Controls.Add(add_btns[index]);
            panels[index].Controls.Add(remove_btns[index]);
            panels[index].Controls.Add(end_btns[index]);

            Controls.Add(panels[index]);
            Controls.SetChildIndex(panels[index], index);
        }

        private void create_week_board()
        {
            panels[3] = new Panel
            {
                BackColor = Color.FromArgb(46, 51, 70),
                Location = new Point(116, 0),
                Margin = new Padding(4),
                Size = new Size(1200, 700),
                AutoScroll = true,
                Anchor = (AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right)
            };

            Label[] day_labels = new Label[7];

            Label wb_title = new Label
            {
                Text = "Week\nBoard",
                Font = new Font("Courier New", 40),
                ForeColor = Color.FromArgb(0, 255, 204),
                Location = new Point(50, 100),
                Margin = new Padding(4),
                Size = new Size(200, 27),
                BackColor = Color.Transparent,
                AutoSize = true,
                Anchor = (AnchorStyles.Top | AnchorStyles.Left)
            };

            for (int i = 0; i < 7; i++)
            {
                int j = i + 1, k = 60;
                if (i >= 3)
                {
                    j = i - 3;
                    k = 290;
                }
                wb_clbs[i] = new CheckedListBox
                {
                    BackColor = Color.FromArgb(46, 51, 60),
                    Font = new Font("Courier New", 8),
                    ForeColor = Color.FromArgb(0, 255, 204),
                    Location = new Point(50 + 200 * j, k),
                    Margin = new Padding(4),
                    Size = new Size(200, 200),
                    FormattingEnabled = true,
                    HorizontalScrollbar = true,
                    //BorderStyle = BorderStyle.None,
                    CheckOnClick = true,
                    Anchor = (AnchorStyles.Top | AnchorStyles.Left)
                };
                wb_clbs[i].ItemCheck += new ItemCheckEventHandler(checkedList_wb_ItemCheck);

                day_labels[i] = new Label
                {
                    Text = days_long[i],
                    Font = new Font("Courier New", 12),
                    ForeColor = Color.FromArgb(0, 255, 204),
                    Location = new Point(130 + 200 * j, k - 20),
                    Margin = new Padding(4),
                    Size = new Size(200, 27),
                    BackColor = Color.Transparent,
                    AutoSize = true,
                    Anchor = (AnchorStyles.Top | AnchorStyles.Left)
                };
            }

            panels[3].Controls.Add(wb_title);
            for (int i = 0; i < 7; i++)
            {
                panels[3].Controls.Add(wb_clbs[i]);
                panels[3].Controls.Add(day_labels[i]);
            }
            
            Controls.Add(panels[3]);
            Controls.SetChildIndex(panels[3], 0);
        }

        private void set_visible_panel(short index)
        {
            for (int i = 0; i < 4; i++)
                panels[i].Visible = (i == index);
        }

        private void panel_button_Click(object sender, EventArgs e)
        {
            short index = 3;
            if (sender as Button == long_button) index = 2;
            else if (sender as Button == sem_button) index = 1;
            else if (sender as Button == week_button) index = 0;
            set_visible_panel(index);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            short index = 0;
            if (sender as Button == add_btns[2]) index = 2;
            else if (sender as Button == add_btns[1]) index = 1;

            
            if (index == 0)
            {
                string txt = add_txts[0].Text;
                for (short i = 0; i < 7; i++)
                {
                    if (week_rb[i].Checked)
                    {
                        week_rb[i].Checked = false;
                        wb_clbs[i].Items.Add(txt);
                        txt = days_short[i] + ':' + txt;
                        break;
                    }
                }
                checkBoxes[0].Items.Add(txt);
            }
            else if (add_txts[index].Text != "")
            {
                checkBoxes[index].Items.Add(add_txts[index].Text);
            }
            add_txts[index].Text = "";
            save(index);
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            short index = 0;
            if (sender as Button == remove_btns[2]) index = 2;
            else if (sender as Button == remove_btns[1]) index = 1;
            

            if (checkBoxes[index].SelectedIndex != -1)
            {
                if (index == 0)
                {
                    string item = (string)checkBoxes[0].SelectedItem;
                    if (str_to_int.ContainsKey(item.Substring(0, 2)) && item[2] == ':')
                    {
                        int day_num = str_to_int[item.Substring(0, 2)];
                        int i = get_clb_index(item.Substring(3, item.Length - 3), wb_clbs[day_num]);
                        wb_clbs[day_num].Items.RemoveAt(i);
                    }
                }
                checkBoxes[index].Items.RemoveAt(checkBoxes[index].SelectedIndex);
                save(index);
            }
        }

        private void save(short type)
        {
            string data = "";
            for (int i = 0; i < checkBoxes[type].Items.Count; i++)
            {
                data += checkBoxes[type].Items[i].ToString() + ':' + (checkBoxes[type].GetItemChecked(i) ? 1 : 0) + '\n';
            }
            StreamWriter streamWriter = save_files[type].CreateText();
            streamWriter.WriteLine(data);
            streamWriter.Close();
        }

        private void checkedList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (loaded)
            {
                short index = 0;
                if (sender as CheckedListBox == checkBoxes[2]) index = 2;
                else if (sender as CheckedListBox == checkBoxes[1]) index = 1;

                BeginInvoke((MethodInvoker)delegate {
                    save(index);
                    if (index == 0) update_week_board();
                });
            }
        }

        private void checkedList_wb_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (loaded)
            {
                short index = 0;
                for (short i = 1; i < 7; i++)
                {
                    if (sender as CheckedListBox == wb_clbs[i]) {
                        index = i;
                        break;
                    }
                }

                BeginInvoke((MethodInvoker)delegate {
                    for (int i = 0; i < checkBoxes[0].Items.Count; i++)
                    {
                        string item = (string)checkBoxes[0].Items[i];
                        if (item.Substring(0, 2) == days_short[index] && item[2] == ':')
                        {
                            int j = get_clb_index(item.Substring(3), wb_clbs[index]);
                            checkBoxes[0].SetItemChecked(i, wb_clbs[index].GetItemChecked(j));
                        }
                    }
                    save(1);
                });
            }
        }

        private void update_week_board()
        {
            int i = 0;
            foreach (string item in checkBoxes[0].Items)
            {
                if (str_to_int.ContainsKey(item.Substring(0, 2)) && item[2] == 'i')
                {
                    int day_num = str_to_int[item.Substring(0, 2)];
                    int j = get_clb_index(item.Substring(3, item.Length - 3), wb_clbs[day_num]);
                    wb_clbs[day_num].SetItemChecked(j, checkBoxes[0].GetItemChecked(i));
                }
                i++;
            }
        }

        private int get_clb_index(string s, CheckedListBox clb)
        {
            int j = 0;
            foreach (string item in clb.Items)
            {
                if (item == s) return j;
                j++;
            }
            return -1;
        }

        private void end_btn_Click(object sender, EventArgs e)
        {
            short index = 0;
            if (sender as Button == end_btns[2]) index = 2;
            else if (sender as Button == end_btns[1]) index = 1;

            // Empty week board
            for (int i = 0; i < 7; i++) wb_clbs[i].Items.Clear();

            StreamWriter streamWriter = history_files[index].AppendText();
            DateTime today = DateTime.Now;
            streamWriter.WriteLine(today.ToString());
            string data = "";
            for (int i = 0; i < checkBoxes[index].Items.Count; i++)
            {
                data += checkBoxes[index].Items[i].ToString() + ':' + (checkBoxes[index].GetItemChecked(i) ? 1 : 0) + '\n';
            }
            streamWriter.WriteLine(data);
            streamWriter.Close();
            checkBoxes[index].Items.Clear();
            save(index);
        }
    }
}
