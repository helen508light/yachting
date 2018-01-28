namespace yachting_firm
{
    partial class AddOrder
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
            this.label2 = new System.Windows.Forms.Label();
            this.label_clients_id = new System.Windows.Forms.Label();
            this.textBox_clients_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_number_of_people = new System.Windows.Forms.TextBox();
            this.checkBox_legal_entity = new System.Windows.Forms.CheckBox();
            this.checkBox_services = new System.Windows.Forms.CheckBox();
            this.TextBox_presents = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_number = new System.Windows.Forms.Label();
            this.date_begin = new System.Windows.Forms.DateTimePicker();
            this.date_end = new System.Windows.Forms.DateTimePicker();
            this.motorboat = new System.Windows.Forms.RadioButton();
            this.yacht = new System.Windows.Forms.RadioButton();
            this.sails_yacht = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hours_begin = new System.Windows.Forms.NumericUpDown();
            this.minutes_begin = new System.Windows.Forms.NumericUpDown();
            this.minutes_end = new System.Windows.Forms.NumericUpDown();
            this.hours_end = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.TextBox();
            this.phone_number = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_begin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_begin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "number of people";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label_clients_id
            // 
            this.label_clients_id.AutoSize = true;
            this.label_clients_id.Location = new System.Drawing.Point(231, 19);
            this.label_clients_id.Name = "label_clients_id";
            this.label_clients_id.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_clients_id.Size = new System.Drawing.Size(68, 13);
            this.label_clients_id.TabIndex = 2;
            this.label_clients_id.Text = "client\'s name";
            // 
            // textBox_clients_name
            // 
            this.textBox_clients_name.Location = new System.Drawing.Point(310, 19);
            this.textBox_clients_name.Name = "textBox_clients_name";
            this.textBox_clients_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_clients_name.TabIndex = 4;
            this.textBox_clients_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(310, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 22);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_number_of_people
            // 
            this.textBox_number_of_people.Location = new System.Drawing.Point(89, 15);
            this.textBox_number_of_people.Name = "textBox_number_of_people";
            this.textBox_number_of_people.Size = new System.Drawing.Size(100, 20);
            this.textBox_number_of_people.TabIndex = 8;
            // 
            // checkBox_legal_entity
            // 
            this.checkBox_legal_entity.AutoSize = true;
            this.checkBox_legal_entity.Location = new System.Drawing.Point(231, 50);
            this.checkBox_legal_entity.Name = "checkBox_legal_entity";
            this.checkBox_legal_entity.Size = new System.Drawing.Size(79, 17);
            this.checkBox_legal_entity.TabIndex = 9;
            this.checkBox_legal_entity.Text = "legal_entity";
            this.checkBox_legal_entity.UseVisualStyleBackColor = true;
            // 
            // checkBox_services
            // 
            this.checkBox_services.AutoSize = true;
            this.checkBox_services.Location = new System.Drawing.Point(38, 98);
            this.checkBox_services.Name = "checkBox_services";
            this.checkBox_services.Size = new System.Drawing.Size(65, 17);
            this.checkBox_services.TabIndex = 10;
            this.checkBox_services.Text = "services";
            this.checkBox_services.UseVisualStyleBackColor = true;
            this.checkBox_services.CheckedChanged += new System.EventHandler(this.checkBox_services_CheckedChanged);
            // 
            // TextBox_presents
            // 
            this.TextBox_presents.Location = new System.Drawing.Point(89, 47);
            this.TextBox_presents.Name = "TextBox_presents";
            this.TextBox_presents.Size = new System.Drawing.Size(100, 20);
            this.TextBox_presents.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "presents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(524, 85);
            this.dataGridView1.TabIndex = 13;
            // 
            // label_number
            // 
            this.label_number.AutoSize = true;
            this.label_number.Location = new System.Drawing.Point(228, 0);
            this.label_number.Name = "label_number";
            this.label_number.Size = new System.Drawing.Size(35, 13);
            this.label_number.TabIndex = 14;
            this.label_number.Text = "label4";
            // 
            // date_begin
            // 
            this.date_begin.Location = new System.Drawing.Point(170, 129);
            this.date_begin.MinDate = new System.DateTime(2014, 11, 24, 0, 0, 0, 0);
            this.date_begin.Name = "date_begin";
            this.date_begin.Size = new System.Drawing.Size(149, 20);
            this.date_begin.TabIndex = 16;
            // 
            // date_end
            // 
            this.date_end.Location = new System.Drawing.Point(170, 191);
            this.date_end.MinDate = new System.DateTime(2014, 11, 24, 0, 0, 0, 0);
            this.date_end.Name = "date_end";
            this.date_end.Size = new System.Drawing.Size(149, 20);
            this.date_end.TabIndex = 17;
            // 
            // motorboat
            // 
            this.motorboat.AutoSize = true;
            this.motorboat.CheckAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.motorboat.Location = new System.Drawing.Point(445, 129);
            this.motorboat.Name = "motorboat";
            this.motorboat.Size = new System.Drawing.Size(72, 17);
            this.motorboat.TabIndex = 18;
            this.motorboat.TabStop = true;
            this.motorboat.Text = "motorboat";
            this.motorboat.UseVisualStyleBackColor = true;
            // 
            // yacht
            // 
            this.yacht.AutoSize = true;
            this.yacht.Location = new System.Drawing.Point(445, 152);
            this.yacht.Name = "yacht";
            this.yacht.Size = new System.Drawing.Size(51, 17);
            this.yacht.TabIndex = 19;
            this.yacht.TabStop = true;
            this.yacht.Text = "yacht";
            this.yacht.UseVisualStyleBackColor = true;
            // 
            // sails_yacht
            // 
            this.sails_yacht.AutoSize = true;
            this.sails_yacht.Location = new System.Drawing.Point(445, 175);
            this.sails_yacht.Name = "sails_yacht";
            this.sails_yacht.Size = new System.Drawing.Size(77, 17);
            this.sails_yacht.TabIndex = 20;
            this.sails_yacht.TabStop = true;
            this.sails_yacht.Text = "sails_yacht";
            this.sails_yacht.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "walk",
            "foto",
            "disco",
            "restaurant"});
            this.checkedListBox1.Location = new System.Drawing.Point(38, 130);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 15;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "datetime of begin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "datetime_of_end";
            // 
            // hours_begin
            // 
            this.hours_begin.Location = new System.Drawing.Point(325, 129);
            this.hours_begin.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_begin.Name = "hours_begin";
            this.hours_begin.Size = new System.Drawing.Size(46, 20);
            this.hours_begin.TabIndex = 24;
            // 
            // minutes_begin
            // 
            this.minutes_begin.Location = new System.Drawing.Point(369, 129);
            this.minutes_begin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minutes_begin.Name = "minutes_begin";
            this.minutes_begin.Size = new System.Drawing.Size(41, 20);
            this.minutes_begin.TabIndex = 27;
            // 
            // minutes_end
            // 
            this.minutes_end.Location = new System.Drawing.Point(369, 191);
            this.minutes_end.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.minutes_end.Name = "minutes_end";
            this.minutes_end.Size = new System.Drawing.Size(41, 20);
            this.minutes_end.TabIndex = 30;
            // 
            // hours_end
            // 
            this.hours_end.Location = new System.Drawing.Point(325, 191);
            this.hours_end.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hours_end.Name = "hours_end";
            this.hours_end.Size = new System.Drawing.Size(46, 20);
            this.hours_end.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(442, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Ships type";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "NO",
            "square",
            "oblique"});
            this.listBox2.Location = new System.Drawing.Point(528, 136);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(101, 56);
            this.listBox2.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(525, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Sails type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(481, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "email";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(447, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "phone number";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(465, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "discount";
            this.label10.Visible = false;
            // 
            // discount
            // 
            this.discount.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.discount.Location = new System.Drawing.Point(522, 68);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(100, 20);
            this.discount.TabIndex = 38;
            this.discount.Visible = false;
            // 
            // phone_number
            // 
            this.phone_number.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.phone_number.Location = new System.Drawing.Point(522, 42);
            this.phone_number.Name = "phone_number";
            this.phone_number.Size = new System.Drawing.Size(100, 20);
            this.phone_number.TabIndex = 39;
            this.phone_number.Visible = false;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.Highlight;
            this.email.Location = new System.Drawing.Point(522, 16);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 20);
            this.email.TabIndex = 40;
            this.email.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "label1";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.BackColor = System.Drawing.SystemColors.Highlight;
            this.label_total.Location = new System.Drawing.Point(444, 203);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(0, 13);
            this.label_total.TabIndex = 42;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 22);
            this.button2.TabIndex = 43;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 400);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.phone_number);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hours_end);
            this.Controls.Add(this.minutes_end);
            this.Controls.Add(this.minutes_begin);
            this.Controls.Add(this.hours_begin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sails_yacht);
            this.Controls.Add(this.yacht);
            this.Controls.Add(this.motorboat);
            this.Controls.Add(this.date_end);
            this.Controls.Add(this.date_begin);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label_number);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBox_presents);
            this.Controls.Add(this.checkBox_services);
            this.Controls.Add(this.checkBox_legal_entity);
            this.Controls.Add(this.textBox_number_of_people);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_clients_name);
            this.Controls.Add(this.label_clients_id);
            this.Controls.Add(this.label2);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_begin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_begin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours_end)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_clients_id;
        private System.Windows.Forms.TextBox textBox_clients_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_number_of_people;
        private System.Windows.Forms.CheckBox checkBox_legal_entity;
        private System.Windows.Forms.CheckBox checkBox_services;
        private System.Windows.Forms.TextBox TextBox_presents;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_number;
        private System.Windows.Forms.DateTimePicker date_begin;
        private System.Windows.Forms.DateTimePicker date_end;
        private System.Windows.Forms.RadioButton motorboat;
        private System.Windows.Forms.RadioButton yacht;
        private System.Windows.Forms.RadioButton sails_yacht;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown hours_begin;
        private System.Windows.Forms.NumericUpDown minutes_begin;
        private System.Windows.Forms.NumericUpDown minutes_end;
        private System.Windows.Forms.NumericUpDown hours_end;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.TextBox phone_number;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button2;
    }
}