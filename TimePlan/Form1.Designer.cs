namespace TimePlan
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plan_list = new System.Windows.Forms.Panel();
            this.long_button = new System.Windows.Forms.Button();
            this.day_button = new System.Windows.Forms.Button();
            this.week_button = new System.Windows.Forms.Button();
            this.sem_button = new System.Windows.Forms.Button();
            this.long_panel = new System.Windows.Forms.Panel();
            this.add_txt_long = new System.Windows.Forms.TextBox();
            this.add_btn_long = new System.Windows.Forms.Button();
            this.remove_btn_long = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListLong = new System.Windows.Forms.CheckedListBox();
            this.sem_panel = new System.Windows.Forms.Panel();
            this.end_btn_sem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListSem = new System.Windows.Forms.CheckedListBox();
            this.remove_btn_sem = new System.Windows.Forms.Button();
            this.add_btn_sem = new System.Windows.Forms.Button();
            this.add_txt_sem = new System.Windows.Forms.TextBox();
            this.week_panel = new System.Windows.Forms.Panel();
            this.end_btn_week = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListWeek = new System.Windows.Forms.CheckedListBox();
            this.remove_btn_week = new System.Windows.Forms.Button();
            this.add_btn_week = new System.Windows.Forms.Button();
            this.add_txt_week = new System.Windows.Forms.TextBox();
            this.day_panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkedListDay = new System.Windows.Forms.CheckedListBox();
            this.remove_btn_day = new System.Windows.Forms.Button();
            this.add_btn_day = new System.Windows.Forms.Button();
            this.add_txt_day = new System.Windows.Forms.TextBox();
            this.end_btn_day = new System.Windows.Forms.Button();
            this.hist_btn_day = new System.Windows.Forms.Button();
            this.plan_list.SuspendLayout();
            this.long_panel.SuspendLayout();
            this.sem_panel.SuspendLayout();
            this.week_panel.SuspendLayout();
            this.day_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // plan_list
            // 
            this.plan_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.plan_list.Controls.Add(this.long_button);
            this.plan_list.Controls.Add(this.day_button);
            this.plan_list.Controls.Add(this.week_button);
            this.plan_list.Controls.Add(this.sem_button);
            this.plan_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.plan_list.Location = new System.Drawing.Point(0, 0);
            this.plan_list.Name = "plan_list";
            this.plan_list.Size = new System.Drawing.Size(116, 469);
            this.plan_list.TabIndex = 0;
            // 
            // long_button
            // 
            this.long_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.long_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.long_button.FlatAppearance.BorderSize = 0;
            this.long_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.long_button.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.long_button.Location = new System.Drawing.Point(0, 64);
            this.long_button.Name = "long_button";
            this.long_button.Size = new System.Drawing.Size(116, 23);
            this.long_button.TabIndex = 0;
            this.long_button.Text = "Long Term Plan";
            this.long_button.UseVisualStyleBackColor = false;
            this.long_button.Click += new System.EventHandler(this.long_button_Click);
            // 
            // day_button
            // 
            this.day_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.day_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.day_button.FlatAppearance.BorderSize = 0;
            this.day_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.day_button.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.day_button.Location = new System.Drawing.Point(0, 151);
            this.day_button.Name = "day_button";
            this.day_button.Size = new System.Drawing.Size(116, 23);
            this.day_button.TabIndex = 3;
            this.day_button.Text = "Daily Plan";
            this.day_button.UseVisualStyleBackColor = false;
            this.day_button.Click += new System.EventHandler(this.day_button_Click);
            // 
            // week_button
            // 
            this.week_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.week_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.week_button.FlatAppearance.BorderSize = 0;
            this.week_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.week_button.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.week_button.Location = new System.Drawing.Point(-3, 122);
            this.week_button.Name = "week_button";
            this.week_button.Size = new System.Drawing.Size(119, 23);
            this.week_button.TabIndex = 2;
            this.week_button.Text = "Weekly Plan";
            this.week_button.UseVisualStyleBackColor = false;
            this.week_button.Click += new System.EventHandler(this.week_button_Click);
            // 
            // sem_button
            // 
            this.sem_button.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sem_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.sem_button.FlatAppearance.BorderSize = 0;
            this.sem_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sem_button.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.sem_button.Location = new System.Drawing.Point(0, 93);
            this.sem_button.Name = "sem_button";
            this.sem_button.Size = new System.Drawing.Size(116, 23);
            this.sem_button.TabIndex = 1;
            this.sem_button.Text = "Semester Plan";
            this.sem_button.UseVisualStyleBackColor = false;
            this.sem_button.Click += new System.EventHandler(this.sem_button_Click);
            // 
            // long_panel
            // 
            this.long_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.long_panel.Controls.Add(this.add_txt_long);
            this.long_panel.Controls.Add(this.add_btn_long);
            this.long_panel.Controls.Add(this.remove_btn_long);
            this.long_panel.Controls.Add(this.label1);
            this.long_panel.Controls.Add(this.checkedListLong);
            this.long_panel.Location = new System.Drawing.Point(122, 12);
            this.long_panel.Name = "long_panel";
            this.long_panel.Size = new System.Drawing.Size(579, 445);
            this.long_panel.TabIndex = 1;
            // 
            // add_txt_long
            // 
            this.add_txt_long.Location = new System.Drawing.Point(410, 110);
            this.add_txt_long.Name = "add_txt_long";
            this.add_txt_long.Size = new System.Drawing.Size(166, 20);
            this.add_txt_long.TabIndex = 4;
            // 
            // add_btn_long
            // 
            this.add_btn_long.Location = new System.Drawing.Point(452, 136);
            this.add_btn_long.Name = "add_btn_long";
            this.add_btn_long.Size = new System.Drawing.Size(75, 23);
            this.add_btn_long.TabIndex = 2;
            this.add_btn_long.Text = "Add";
            this.add_btn_long.UseVisualStyleBackColor = true;
            this.add_btn_long.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // remove_btn_long
            // 
            this.remove_btn_long.Location = new System.Drawing.Point(452, 193);
            this.remove_btn_long.Name = "remove_btn_long";
            this.remove_btn_long.Size = new System.Drawing.Size(75, 23);
            this.remove_btn_long.TabIndex = 3;
            this.remove_btn_long.Text = "Remove";
            this.remove_btn_long.UseVisualStyleBackColor = true;
            this.remove_btn_long.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(49, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Long Term Plan";
            // 
            // checkedListLong
            // 
            this.checkedListLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.checkedListLong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListLong.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListLong.FormattingEnabled = true;
            this.checkedListLong.Location = new System.Drawing.Point(49, 111);
            this.checkedListLong.Name = "checkedListLong";
            this.checkedListLong.Size = new System.Drawing.Size(330, 270);
            this.checkedListLong.TabIndex = 0;
            this.checkedListLong.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedList_ItemCheck);
            // 
            // sem_panel
            // 
            this.sem_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.sem_panel.Controls.Add(this.end_btn_sem);
            this.sem_panel.Controls.Add(this.label2);
            this.sem_panel.Controls.Add(this.checkedListSem);
            this.sem_panel.Controls.Add(this.remove_btn_sem);
            this.sem_panel.Controls.Add(this.add_btn_sem);
            this.sem_panel.Controls.Add(this.add_txt_sem);
            this.sem_panel.Location = new System.Drawing.Point(122, 12);
            this.sem_panel.Name = "sem_panel";
            this.sem_panel.Size = new System.Drawing.Size(579, 445);
            this.sem_panel.TabIndex = 2;
            // 
            // end_btn_sem
            // 
            this.end_btn_sem.Location = new System.Drawing.Point(452, 252);
            this.end_btn_sem.Name = "end_btn_sem";
            this.end_btn_sem.Size = new System.Drawing.Size(75, 23);
            this.end_btn_sem.TabIndex = 12;
            this.end_btn_sem.Text = "End Sem";
            this.end_btn_sem.UseVisualStyleBackColor = true;
            this.end_btn_sem.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(49, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 27);
            this.label2.TabIndex = 9;
            this.label2.Text = "Semester Plan";
            // 
            // checkedListSem
            // 
            this.checkedListSem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.checkedListSem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListSem.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListSem.FormattingEnabled = true;
            this.checkedListSem.Location = new System.Drawing.Point(54, 110);
            this.checkedListSem.Name = "checkedListSem";
            this.checkedListSem.Size = new System.Drawing.Size(330, 270);
            this.checkedListSem.TabIndex = 8;
            this.checkedListSem.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedList_ItemCheck);
            // 
            // remove_btn_sem
            // 
            this.remove_btn_sem.Location = new System.Drawing.Point(452, 193);
            this.remove_btn_sem.Name = "remove_btn_sem";
            this.remove_btn_sem.Size = new System.Drawing.Size(75, 23);
            this.remove_btn_sem.TabIndex = 7;
            this.remove_btn_sem.Text = "Remove";
            this.remove_btn_sem.UseVisualStyleBackColor = true;
            this.remove_btn_sem.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // add_btn_sem
            // 
            this.add_btn_sem.Location = new System.Drawing.Point(452, 136);
            this.add_btn_sem.Name = "add_btn_sem";
            this.add_btn_sem.Size = new System.Drawing.Size(75, 23);
            this.add_btn_sem.TabIndex = 6;
            this.add_btn_sem.Text = "Add";
            this.add_btn_sem.UseVisualStyleBackColor = true;
            this.add_btn_sem.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // add_txt_sem
            // 
            this.add_txt_sem.Location = new System.Drawing.Point(410, 110);
            this.add_txt_sem.Name = "add_txt_sem";
            this.add_txt_sem.Size = new System.Drawing.Size(166, 20);
            this.add_txt_sem.TabIndex = 5;
            // 
            // week_panel
            // 
            this.week_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.week_panel.Controls.Add(this.end_btn_week);
            this.week_panel.Controls.Add(this.label3);
            this.week_panel.Controls.Add(this.checkedListWeek);
            this.week_panel.Controls.Add(this.remove_btn_week);
            this.week_panel.Controls.Add(this.add_btn_week);
            this.week_panel.Controls.Add(this.add_txt_week);
            this.week_panel.Location = new System.Drawing.Point(122, 12);
            this.week_panel.Name = "week_panel";
            this.week_panel.Size = new System.Drawing.Size(579, 445);
            this.week_panel.TabIndex = 10;
            // 
            // end_btn_week
            // 
            this.end_btn_week.Location = new System.Drawing.Point(452, 252);
            this.end_btn_week.Name = "end_btn_week";
            this.end_btn_week.Size = new System.Drawing.Size(75, 23);
            this.end_btn_week.TabIndex = 11;
            this.end_btn_week.Text = "End Week";
            this.end_btn_week.UseVisualStyleBackColor = true;
            this.end_btn_week.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(49, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Week Plan";
            // 
            // checkedListWeek
            // 
            this.checkedListWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.checkedListWeek.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListWeek.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListWeek.FormattingEnabled = true;
            this.checkedListWeek.Location = new System.Drawing.Point(54, 110);
            this.checkedListWeek.Name = "checkedListWeek";
            this.checkedListWeek.Size = new System.Drawing.Size(330, 270);
            this.checkedListWeek.TabIndex = 8;
            this.checkedListWeek.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedList_ItemCheck);
            // 
            // remove_btn_week
            // 
            this.remove_btn_week.Location = new System.Drawing.Point(452, 193);
            this.remove_btn_week.Name = "remove_btn_week";
            this.remove_btn_week.Size = new System.Drawing.Size(75, 23);
            this.remove_btn_week.TabIndex = 7;
            this.remove_btn_week.Text = "Remove";
            this.remove_btn_week.UseVisualStyleBackColor = true;
            this.remove_btn_week.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // add_btn_week
            // 
            this.add_btn_week.Location = new System.Drawing.Point(452, 136);
            this.add_btn_week.Name = "add_btn_week";
            this.add_btn_week.Size = new System.Drawing.Size(75, 23);
            this.add_btn_week.TabIndex = 6;
            this.add_btn_week.Text = "Add";
            this.add_btn_week.UseVisualStyleBackColor = true;
            this.add_btn_week.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // add_txt_week
            // 
            this.add_txt_week.Location = new System.Drawing.Point(410, 110);
            this.add_txt_week.Name = "add_txt_week";
            this.add_txt_week.Size = new System.Drawing.Size(166, 20);
            this.add_txt_week.TabIndex = 5;
            // 
            // day_panel
            // 
            this.day_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.day_panel.Controls.Add(this.label4);
            this.day_panel.Controls.Add(this.checkedListDay);
            this.day_panel.Controls.Add(this.remove_btn_day);
            this.day_panel.Controls.Add(this.add_btn_day);
            this.day_panel.Controls.Add(this.add_txt_day);
            this.day_panel.Controls.Add(this.end_btn_day);
            this.day_panel.Controls.Add(this.hist_btn_day);
            this.day_panel.Location = new System.Drawing.Point(122, 12);
            this.day_panel.Name = "day_panel";
            this.day_panel.Size = new System.Drawing.Size(579, 445);
            this.day_panel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(49, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Daily Plan";
            // 
            // checkedListDay
            // 
            this.checkedListDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.checkedListDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListDay.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListDay.FormattingEnabled = true;
            this.checkedListDay.Location = new System.Drawing.Point(54, 110);
            this.checkedListDay.Name = "checkedListDay";
            this.checkedListDay.Size = new System.Drawing.Size(330, 270);
            this.checkedListDay.TabIndex = 8;
            this.checkedListDay.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedList_ItemCheck);
            // 
            // remove_btn_day
            // 
            this.remove_btn_day.Location = new System.Drawing.Point(452, 193);
            this.remove_btn_day.Name = "remove_btn_day";
            this.remove_btn_day.Size = new System.Drawing.Size(75, 23);
            this.remove_btn_day.TabIndex = 7;
            this.remove_btn_day.Text = "Remove";
            this.remove_btn_day.UseVisualStyleBackColor = true;
            this.remove_btn_day.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // add_btn_day
            // 
            this.add_btn_day.Location = new System.Drawing.Point(452, 136);
            this.add_btn_day.Name = "add_btn_day";
            this.add_btn_day.Size = new System.Drawing.Size(75, 23);
            this.add_btn_day.TabIndex = 6;
            this.add_btn_day.Text = "Add";
            this.add_btn_day.UseVisualStyleBackColor = true;
            this.add_btn_day.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // add_txt_day
            // 
            this.add_txt_day.Location = new System.Drawing.Point(410, 110);
            this.add_txt_day.Name = "add_txt_day";
            this.add_txt_day.Size = new System.Drawing.Size(166, 20);
            this.add_txt_day.TabIndex = 5;
            // 
            // end_btn_day
            // 
            this.end_btn_day.Location = new System.Drawing.Point(452, 252);
            this.end_btn_day.Name = "end_btn_day";
            this.end_btn_day.Size = new System.Drawing.Size(75, 23);
            this.end_btn_day.TabIndex = 10;
            this.end_btn_day.Text = "End Day";
            this.end_btn_day.UseVisualStyleBackColor = true;
            this.end_btn_day.Click += new System.EventHandler(this.end_btn_Click);
            // 
            // hist_btn_day
            // 
            this.hist_btn_day.Location = new System.Drawing.Point(452, 310);
            this.hist_btn_day.Name = "hist_btn_day";
            this.hist_btn_day.Size = new System.Drawing.Size(75, 23);
            this.hist_btn_day.TabIndex = 11;
            this.hist_btn_day.Text = "History";
            this.hist_btn_day.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(713, 469);
            this.Controls.Add(this.day_panel);
            this.Controls.Add(this.week_panel);
            this.Controls.Add(this.sem_panel);
            this.Controls.Add(this.long_panel);
            this.Controls.Add(this.plan_list);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.plan_list.ResumeLayout(false);
            this.long_panel.ResumeLayout(false);
            this.long_panel.PerformLayout();
            this.sem_panel.ResumeLayout(false);
            this.sem_panel.PerformLayout();
            this.week_panel.ResumeLayout(false);
            this.week_panel.PerformLayout();
            this.day_panel.ResumeLayout(false);
            this.day_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plan_list;
        private System.Windows.Forms.Button long_button;
        private System.Windows.Forms.Button day_button;
        private System.Windows.Forms.Button week_button;
        private System.Windows.Forms.Button sem_button;
        private System.Windows.Forms.Panel long_panel;
        private System.Windows.Forms.Panel sem_panel;
        private System.Windows.Forms.CheckedListBox checkedListLong;
        private System.Windows.Forms.Button add_btn_long;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_btn_long;
        private System.Windows.Forms.TextBox add_txt_long;
        private System.Windows.Forms.CheckedListBox checkedListSem;
        private System.Windows.Forms.Button remove_btn_sem;
        private System.Windows.Forms.Button add_btn_sem;
        private System.Windows.Forms.TextBox add_txt_sem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel week_panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListWeek;
        private System.Windows.Forms.Button remove_btn_week;
        private System.Windows.Forms.Button add_btn_week;
        private System.Windows.Forms.TextBox add_txt_week;
        private System.Windows.Forms.Panel day_panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkedListDay;
        private System.Windows.Forms.Button remove_btn_day;
        private System.Windows.Forms.Button add_btn_day;
        private System.Windows.Forms.TextBox add_txt_day;
        private System.Windows.Forms.Button end_btn_day;
        private System.Windows.Forms.Button hist_btn_day;
        private System.Windows.Forms.Button end_btn_sem;
        private System.Windows.Forms.Button end_btn_week;
    }
}

