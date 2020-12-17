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
        FileInfo[] save_files = { new FileInfo("temp_day.txt"), new FileInfo("temp_week.txt"),
            new FileInfo("temp_sem.txt"), new FileInfo("temp_long.txt") };

        FileInfo[] history_files = { new FileInfo("history_day.txt"), new FileInfo("history_week.txt"),
            new FileInfo("history_sem.txt") };

        bool loaded = false;

        Panel p_day = new Panel();

        // day, week, sem, long
        Panel[] panels = new Panel[4];
        Label[] labels = new Label[4];
        CheckedListBox[] checkBoxes = new CheckedListBox[4];
        TextBox[] add_txts = new TextBox[4];
        Button[] add_btns = new Button[4];
        Button[] remove_btns = new Button[4];
        Button[] end_btns = new Button[4];


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //p_day = create_tab_panel("day");
            //plans[0] = create_tab_panel("day");

            for (int i = 0; i < 4; i++) create_tab_panel(i);

            for (int i = 0; i < 4; i++)
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
                        }
                    }
                    streamReader.Close();
                }
            }
            loaded = true;
        }

        private void create_tab_panel(int index)
        {
            string[] name = { "Daily", "Weekly", "Semester", "Long Term" };
            panels[index] = new Panel
            {
                BackColor = Color.FromArgb(46, 51, 70),
                Location = new Point(116, 0),
                Margin = new Padding(4),
                Size = new Size(772, 548),
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
                Location = new Point(530, 135),
                Margin = new Padding(4),
                Size = new Size(150, 22),
                Anchor = (AnchorStyles.Top | AnchorStyles.Right)
            };

            add_btns[index] = new Button
            {
                Text = "Add",
                UseVisualStyleBackColor = true,
                Location = new Point(570, 164),
                Margin = new Padding(4),
                Size = new Size(75, 28),
                Anchor = (AnchorStyles.Top | AnchorStyles.Right),
            };
            add_btns[index].Click += new EventHandler(add_btn_Click);

            remove_btns[index] = new Button
            {
                Text = "Remove",
                UseVisualStyleBackColor = true,
                Location = new Point(570, 200),
                Margin = new Padding(4),
                Size = new Size(75, 28),
                Anchor = (AnchorStyles.Top | AnchorStyles.Right)
            };
            remove_btns[index].Click += new EventHandler(remove_btn_Click);

            end_btns[index] = new Button
            {
                Text = "End ",
                UseVisualStyleBackColor = true,
                Location = new Point(570, 236),
                Margin = new Padding(4),
                Size = new Size(75, 28),
                Anchor = (AnchorStyles.Top | AnchorStyles.Right)
            };
            end_btns[index].Click += new EventHandler(end_btn_Click);

            panels[index].Controls.Add(labels[index]);
            panels[index].Controls.Add(checkBoxes[index]);
            panels[index].Controls.Add(add_txts[index]);
            panels[index].Controls.Add(add_btns[index]);
            panels[index].Controls.Add(remove_btns[index]);
            panels[index].Controls.Add(end_btns[index]);

            Controls.Add(panels[index]);
            Controls.SetChildIndex(panels[index], index);
        }

        private void long_button_Click(object sender, EventArgs e)
        {
            panels[3].Visible = true;
            panels[2].Visible = false;
            panels[1].Visible = false;
            panels[0].Visible = false;
        }

        private void sem_button_Click(object sender, EventArgs e)
        {
            panels[3].Visible = false;
            panels[2].Visible = true;
            panels[1].Visible = false;
            panels[0].Visible = false;
        }

        private void week_button_Click(object sender, EventArgs e)
        {
            panels[3].Visible = false;
            panels[2].Visible = false;
            panels[1].Visible = true;
            panels[0].Visible = false;
        }

        private void day_button_Click(object sender, EventArgs e)
        {
            panels[3].Visible = false;
            panels[2].Visible = false;
            panels[1].Visible = false;
            panels[0].Visible = true;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            short index = 0;
            if (sender as Button == add_btns[3]) index = 3;
            else if (sender as Button == add_btns[2]) index = 2;
            else if (sender as Button == add_btns[1]) index = 1;

            if (add_txts[index].Text != "")
            {
                checkBoxes[index].Items.Add(add_txts[index].Text);
                Console.WriteLine(add_txts[index].Text);
                add_txts[index].Text = "";
                save(index);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            short index = 0;
            if (sender as Button == add_btns[3]) index = 3;
            else if (sender as Button == add_btns[2]) index = 2;
            else if (sender as Button == add_btns[1]) index = 1;
            if (checkBoxes[index].SelectedIndex != -1)
            {
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
                if (sender as CheckedListBox == checkBoxes[0])
                {
                    this.BeginInvoke((MethodInvoker)delegate {
                        save(0);
                    });
                }
                else if (sender as CheckedListBox == checkBoxes[1])
                {
                    this.BeginInvoke((MethodInvoker)delegate {
                        save(1);
                    });
                }
                else if (sender as CheckedListBox == checkBoxes[2])
                {
                    this.BeginInvoke((MethodInvoker)delegate {
                        save(2);
                    });
                }
                else
                {
                    this.BeginInvoke((MethodInvoker)delegate {
                        save(3);
                    });
                }
            }
        }

        private void end_btn_Click(object sender, EventArgs e)
        {
            short index = 0;
            if (sender as Button == add_btns[3]) index = 3;
            else if (sender as Button == add_btns[2]) index = 2;
            else if (sender as Button == add_btns[1]) index = 1;

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
