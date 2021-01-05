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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.plan_list = new System.Windows.Forms.Panel();
            this.board_button = new System.Windows.Forms.Button();
            this.long_button = new System.Windows.Forms.Button();
            this.week_button = new System.Windows.Forms.Button();
            this.sem_button = new System.Windows.Forms.Button();
            this.checkedListLong = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remove_btn_long = new System.Windows.Forms.Button();
            this.add_btn_long = new System.Windows.Forms.Button();
            this.add_txt_long = new System.Windows.Forms.TextBox();
            this.long_panel = new System.Windows.Forms.Panel();
            this.plan_list.SuspendLayout();
            this.long_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // plan_list
            // 
            this.plan_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.plan_list.Controls.Add(this.board_button);
            this.plan_list.Controls.Add(this.long_button);
            this.plan_list.Controls.Add(this.week_button);
            this.plan_list.Controls.Add(this.sem_button);
            this.plan_list.Dock = System.Windows.Forms.DockStyle.Left;
            this.plan_list.Location = new System.Drawing.Point(0, 0);
            this.plan_list.Margin = new System.Windows.Forms.Padding(4);
            this.plan_list.Name = "plan_list";
            this.plan_list.Size = new System.Drawing.Size(145, 673);
            this.plan_list.TabIndex = 0;
            // 
            // board_button
            // 
            this.board_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.board_button.FlatAppearance.BorderSize = 0;
            this.board_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.board_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.board_button.Location = new System.Drawing.Point(0, 189);
            this.board_button.Margin = new System.Windows.Forms.Padding(4);
            this.board_button.Name = "board_button";
            this.board_button.Size = new System.Drawing.Size(145, 29);
            this.board_button.TabIndex = 4;
            this.board_button.Text = "Week Board";
            this.board_button.UseVisualStyleBackColor = false;
            this.board_button.Click += new System.EventHandler(this.panel_button_Click);
            // 
            // long_button
            // 
            this.long_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.long_button.FlatAppearance.BorderSize = 0;
            this.long_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.long_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.long_button.Location = new System.Drawing.Point(0, 80);
            this.long_button.Margin = new System.Windows.Forms.Padding(4);
            this.long_button.Name = "long_button";
            this.long_button.Size = new System.Drawing.Size(145, 29);
            this.long_button.TabIndex = 0;
            this.long_button.Text = "Long Term Plan";
            this.long_button.UseVisualStyleBackColor = false;
            this.long_button.Click += new System.EventHandler(this.panel_button_Click);
            // 
            // week_button
            // 
            this.week_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.week_button.FlatAppearance.BorderSize = 0;
            this.week_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.week_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.week_button.Location = new System.Drawing.Point(-4, 152);
            this.week_button.Margin = new System.Windows.Forms.Padding(4);
            this.week_button.Name = "week_button";
            this.week_button.Size = new System.Drawing.Size(149, 29);
            this.week_button.TabIndex = 2;
            this.week_button.Text = "Weekly Plan";
            this.week_button.UseVisualStyleBackColor = false;
            this.week_button.Click += new System.EventHandler(this.panel_button_Click);
            // 
            // sem_button
            // 
            this.sem_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.sem_button.FlatAppearance.BorderSize = 0;
            this.sem_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sem_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.sem_button.Location = new System.Drawing.Point(0, 116);
            this.sem_button.Margin = new System.Windows.Forms.Padding(4);
            this.sem_button.Name = "sem_button";
            this.sem_button.Size = new System.Drawing.Size(145, 29);
            this.sem_button.TabIndex = 1;
            this.sem_button.Text = "Semester Plan";
            this.sem_button.UseVisualStyleBackColor = false;
            this.sem_button.Click += new System.EventHandler(this.panel_button_Click);
            // 
            // checkedListLong
            // 
            this.checkedListLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(60)))));
            this.checkedListLong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListLong.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkedListLong.FormattingEnabled = true;
            this.checkedListLong.Location = new System.Drawing.Point(68, 138);
            this.checkedListLong.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListLong.Name = "checkedListLong";
            this.checkedListLong.Size = new System.Drawing.Size(412, 306);
            this.checkedListLong.TabIndex = 0;
            this.checkedListLong.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedList_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(61, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Long Term Plan";
            // 
            // remove_btn_long
            // 
            this.remove_btn_long.Location = new System.Drawing.Point(565, 207);
            this.remove_btn_long.Margin = new System.Windows.Forms.Padding(4);
            this.remove_btn_long.Name = "remove_btn_long";
            this.remove_btn_long.Size = new System.Drawing.Size(94, 29);
            this.remove_btn_long.TabIndex = 3;
            this.remove_btn_long.Text = "Remove";
            this.remove_btn_long.UseVisualStyleBackColor = true;
            this.remove_btn_long.Click += new System.EventHandler(this.remove_btn_Click);
            // 
            // add_btn_long
            // 
            this.add_btn_long.Location = new System.Drawing.Point(565, 170);
            this.add_btn_long.Margin = new System.Windows.Forms.Padding(4);
            this.add_btn_long.Name = "add_btn_long";
            this.add_btn_long.Size = new System.Drawing.Size(94, 29);
            this.add_btn_long.TabIndex = 2;
            this.add_btn_long.Text = "Add";
            this.add_btn_long.UseVisualStyleBackColor = true;
            this.add_btn_long.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // add_txt_long
            // 
            this.add_txt_long.Location = new System.Drawing.Point(512, 138);
            this.add_txt_long.Margin = new System.Windows.Forms.Padding(4);
            this.add_txt_long.Name = "add_txt_long";
            this.add_txt_long.Size = new System.Drawing.Size(206, 22);
            this.add_txt_long.TabIndex = 4;
            // 
            // long_panel
            // 
            this.long_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.long_panel.Controls.Add(this.add_txt_long);
            this.long_panel.Controls.Add(this.add_btn_long);
            this.long_panel.Controls.Add(this.remove_btn_long);
            this.long_panel.Controls.Add(this.label1);
            this.long_panel.Controls.Add(this.checkedListLong);
            this.long_panel.Location = new System.Drawing.Point(152, 15);
            this.long_panel.Margin = new System.Windows.Forms.Padding(4);
            this.long_panel.Name = "long_panel";
            this.long_panel.Size = new System.Drawing.Size(724, 556);
            this.long_panel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.long_panel);
            this.Controls.Add(this.plan_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Planner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plan_list.ResumeLayout(false);
            this.long_panel.ResumeLayout(false);
            this.long_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plan_list;
        private System.Windows.Forms.Button long_button;
        private System.Windows.Forms.Button week_button;
        private System.Windows.Forms.Button sem_button;
        private System.Windows.Forms.CheckedListBox checkedListLong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button remove_btn_long;
        private System.Windows.Forms.Button add_btn_long;
        private System.Windows.Forms.TextBox add_txt_long;
        private System.Windows.Forms.Panel long_panel;
        private System.Windows.Forms.Button board_button;
    }
}

