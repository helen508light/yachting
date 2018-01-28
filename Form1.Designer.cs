namespace yachting_firm
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_today = new System.Windows.Forms.Label();
            this.print = new System.Windows.Forms.Button();
            this.serialize = new System.Windows.Forms.Button();
            this.gen = new System.Windows.Forms.Button();
            this.verify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(48, 266);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 0;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(252, 266);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(466, 266);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(75, 23);
            this.details.TabIndex = 2;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(48, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(493, 217);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label_today
            // 
            this.label_today.AutoSize = true;
            this.label_today.Location = new System.Drawing.Point(249, 9);
            this.label_today.Name = "label_today";
            this.label_today.Size = new System.Drawing.Size(35, 13);
            this.label_today.TabIndex = 4;
            this.label_today.Text = "label1";
            this.label_today.Click += new System.EventHandler(this.label_today_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(48, 5);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 5;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialize
            // 
            this.serialize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.serialize.Location = new System.Drawing.Point(129, 5);
            this.serialize.Name = "serialize";
            this.serialize.Size = new System.Drawing.Size(75, 23);
            this.serialize.TabIndex = 6;
            this.serialize.Text = "Serialize";
            this.serialize.UseVisualStyleBackColor = true;
            this.serialize.Click += new System.EventHandler(this.serialize_Click);
            // 
            // gen
            // 
            this.gen.Location = new System.Drawing.Point(388, 5);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(75, 23);
            this.gen.TabIndex = 7;
            this.gen.Text = "gen EDS";
            this.gen.UseVisualStyleBackColor = true;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // verify
            // 
            this.verify.Location = new System.Drawing.Point(466, 5);
            this.verify.Name = "verify";
            this.verify.Size = new System.Drawing.Size(75, 23);
            this.verify.TabIndex = 8;
            this.verify.Text = "verify";
            this.verify.UseVisualStyleBackColor = true;
            this.verify.Click += new System.EventHandler(this.verify_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 310);
            this.Controls.Add(this.verify);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.serialize);
            this.Controls.Add(this.print);
            this.Controls.Add(this.label_today);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.details);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Name = "Form1";
            this.Text = "Orders";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_today;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Button serialize;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.Button verify;
    }
}

