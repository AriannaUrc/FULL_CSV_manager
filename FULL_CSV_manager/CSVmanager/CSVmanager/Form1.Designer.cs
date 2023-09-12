namespace CSVmanager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listView = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            OpenButton = new Button();
            Add = new Button();
            Modify_button = new Button();
            modify_draw_date_textbox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            delete_target = new ComboBox();
            label8 = new Label();
            delete_value_textbox = new TextBox();
            delete_button = new Button();
            label9 = new Label();
            find_target = new ComboBox();
            label16 = new Label();
            add_multiplier_textbox = new TextBox();
            find_value_textbox = new TextBox();
            find_button = new Button();
            label7 = new Label();
            label15 = new Label();
            add_win_numbers_textbox = new TextBox();
            add_mega_ball_textbox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            add_draw_date_textbox = new TextBox();
            add_button = new Button();
            label6 = new Label();
            modify_new_value_textbox = new TextBox();
            label3 = new Label();
            modify_target = new ComboBox();
            label2 = new Label();
            fields_num_button = new Button();
            max_field_button = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // listView
            // 
            listView.BackColor = SystemColors.InactiveBorder;
            listView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4 });
            listView.GridLines = true;
            listView.Location = new Point(434, 12);
            listView.Name = "listView";
            listView.Size = new Size(364, 387);
            listView.TabIndex = 0;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "DrawDate";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "WinNumbers";
            columnHeader2.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Multiplier";
            columnHeader4.Width = 120;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(713, 415);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(75, 23);
            OpenButton.TabIndex = 1;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += OpenButton_Click;
            // 
            // Add
            // 
            Add.Location = new Point(605, 415);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 2;
            Add.Text = "Load";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // Modify_button
            // 
            Modify_button.Location = new Point(7, 101);
            Modify_button.Name = "Modify_button";
            Modify_button.Size = new Size(75, 23);
            Modify_button.TabIndex = 3;
            Modify_button.Text = "Modify";
            Modify_button.UseVisualStyleBackColor = true;
            Modify_button.Click += Modify_button_Click;
            // 
            // modify_draw_date_textbox
            // 
            modify_draw_date_textbox.Location = new Point(97, 102);
            modify_draw_date_textbox.Name = "modify_draw_date_textbox";
            modify_draw_date_textbox.Size = new Size(90, 23);
            modify_draw_date_textbox.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 84);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 5;
            label1.Text = "Draw date";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delete_target);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(delete_value_textbox);
            groupBox1.Controls.Add(delete_button);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(find_target);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(add_multiplier_textbox);
            groupBox1.Controls.Add(find_value_textbox);
            groupBox1.Controls.Add(find_button);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(add_win_numbers_textbox);
            groupBox1.Controls.Add(add_mega_ball_textbox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(add_draw_date_textbox);
            groupBox1.Controls.Add(add_button);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(modify_new_value_textbox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(modify_target);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(modify_draw_date_textbox);
            groupBox1.Controls.Add(Modify_button);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 394);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "functions";
            // 
            // delete_target
            // 
            delete_target.FormattingEnabled = true;
            delete_target.Items.AddRange(new object[] { "DrawDate", "WinNumbers", "MegaBall", "Multiplier", "MioValore" });
            delete_target.Location = new Point(95, 199);
            delete_target.Name = "delete_target";
            delete_target.Size = new Size(106, 23);
            delete_target.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(124, 182);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 28;
            label8.Text = "Target";
            // 
            // delete_value_textbox
            // 
            delete_value_textbox.Location = new Point(216, 200);
            delete_value_textbox.Name = "delete_value_textbox";
            delete_value_textbox.Size = new Size(101, 23);
            delete_value_textbox.TabIndex = 26;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(7, 199);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(75, 23);
            delete_button.TabIndex = 25;
            delete_button.Text = "Delete";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(249, 182);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 27;
            label9.Text = "Value";
            // 
            // find_target
            // 
            find_target.FormattingEnabled = true;
            find_target.Items.AddRange(new object[] { "DrawDate", "WinNumbers", "MegaBall", "Multiplier" });
            find_target.Location = new Point(97, 152);
            find_target.Name = "find_target";
            find_target.Size = new Size(106, 23);
            find_target.TabIndex = 24;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(126, 135);
            label16.Name = "label16";
            label16.Size = new Size(39, 15);
            label16.TabIndex = 23;
            label16.Text = "Target";
            // 
            // add_multiplier_textbox
            // 
            add_multiplier_textbox.Location = new Point(333, 46);
            add_multiplier_textbox.Name = "add_multiplier_textbox";
            add_multiplier_textbox.Size = new Size(62, 23);
            add_multiplier_textbox.TabIndex = 18;
            // 
            // find_value_textbox
            // 
            find_value_textbox.Location = new Point(218, 153);
            find_value_textbox.Name = "find_value_textbox";
            find_value_textbox.Size = new Size(101, 23);
            find_value_textbox.TabIndex = 21;
            // 
            // find_button
            // 
            find_button.Location = new Point(9, 152);
            find_button.Name = "find_button";
            find_button.Size = new Size(75, 23);
            find_button.TabIndex = 20;
            find_button.Text = "Find";
            find_button.UseVisualStyleBackColor = true;
            find_button.Click += find_button_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 28);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 19;
            label7.Text = "Multiplier";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(251, 135);
            label15.Name = "label15";
            label15.Size = new Size(35, 15);
            label15.TabIndex = 22;
            label15.Text = "Value";
            // 
            // add_win_numbers_textbox
            // 
            add_win_numbers_textbox.Location = new Point(171, 46);
            add_win_numbers_textbox.Name = "add_win_numbers_textbox";
            add_win_numbers_textbox.Size = new Size(80, 23);
            add_win_numbers_textbox.TabIndex = 17;
            // 
            // add_mega_ball_textbox
            // 
            add_mega_ball_textbox.Location = new Point(257, 46);
            add_mega_ball_textbox.Name = "add_mega_ball_textbox";
            add_mega_ball_textbox.Size = new Size(70, 23);
            add_mega_ball_textbox.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 28);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 16;
            label4.Text = "  MegaBall";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(171, 29);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 13;
            label5.Text = " WinNumbers";
            // 
            // add_draw_date_textbox
            // 
            add_draw_date_textbox.Location = new Point(95, 46);
            add_draw_date_textbox.Name = "add_draw_date_textbox";
            add_draw_date_textbox.Size = new Size(71, 23);
            add_draw_date_textbox.TabIndex = 11;
            // 
            // add_button
            // 
            add_button.Location = new Point(5, 46);
            add_button.Name = "add_button";
            add_button.Size = new Size(75, 23);
            add_button.TabIndex = 10;
            add_button.Text = "Add";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(95, 28);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 12;
            label6.Text = " Draw date";
            // 
            // modify_new_value_textbox
            // 
            modify_new_value_textbox.Location = new Point(307, 102);
            modify_new_value_textbox.Name = "modify_new_value_textbox";
            modify_new_value_textbox.Size = new Size(90, 23);
            modify_new_value_textbox.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 84);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 9;
            label3.Text = "New Value";
            // 
            // modify_target
            // 
            modify_target.FormattingEnabled = true;
            modify_target.Items.AddRange(new object[] { "WinNumbers", "MegaBall", "Multiplier" });
            modify_target.Location = new Point(195, 101);
            modify_target.Name = "modify_target";
            modify_target.Size = new Size(106, 23);
            modify_target.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(224, 84);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Target";
            // 
            // fields_num_button
            // 
            fields_num_button.Location = new Point(18, 415);
            fields_num_button.Name = "fields_num_button";
            fields_num_button.Size = new Size(106, 23);
            fields_num_button.TabIndex = 10;
            fields_num_button.Text = "Fields Number";
            fields_num_button.UseVisualStyleBackColor = true;
            fields_num_button.Click += fields_num_button_Click;
            // 
            // max_field_button
            // 
            max_field_button.Location = new Point(145, 415);
            max_field_button.Name = "max_field_button";
            max_field_button.Size = new Size(109, 23);
            max_field_button.TabIndex = 11;
            max_field_button.Text = "Max field lenght";
            max_field_button.UseVisualStyleBackColor = true;
            max_field_button.Click += max_field_button_Click;
            // 
            // timer1
            // 
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 457);
            Controls.Add(max_field_button);
            Controls.Add(fields_num_button);
            Controls.Add(groupBox1);
            Controls.Add(Add);
            Controls.Add(OpenButton);
            Controls.Add(listView);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "CSVmanager";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private Button OpenButton;
        private Button Add;
        private Button Modify_button;
        private TextBox modify_draw_date_textbox;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox modify_target;
        private TextBox modify_new_value_textbox;
        private Label label3;
        private Button fields_num_button;
        private Button max_field_button;
        private TextBox add_win_numbers_textbox;
        private TextBox add_mega_ball_textbox;
        private Label label4;
        private Label label5;
        private TextBox add_draw_date_textbox;
        private Button add_button;
        private Label label6;
        private TextBox add_multiplier_textbox;
        private Label label7;
        private ComboBox find_target;
        private Label label16;
        private TextBox find_value_textbox;
        private Button find_button;
        private Label label15;
        private ComboBox delete_target;
        private Label label8;
        private TextBox delete_value_textbox;
        private Button delete_button;
        private Label label9;
        private System.Windows.Forms.Timer timer1;
    }
}