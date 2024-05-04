namespace Task1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BttnAddOwner = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.BttnCreateAcc = new System.Windows.Forms.Button();
            this.BttnSortByType = new System.Windows.Forms.Button();
            this.BttnSortByDate = new System.Windows.Forms.Button();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.BttnFindByNum = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BttnFindByName = new System.Windows.Forms.Button();
            this.BttnFindByBal = new System.Windows.Forms.Button();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.BttnFindByType = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер счета";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 30);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(233, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип аккаунта";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 20);
            this.textBox1.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(255, 9);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(290, 289);
            this.listBox1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Баланс";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(16, 109);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(233, 20);
            this.numericUpDown2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата открытия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(95, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Владелец";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ФИО";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Дата рождения";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 149);
            this.dateTimePicker1.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1860, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 240);
            this.dateTimePicker2.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1850, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Паспортные данные";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(16, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(233, 20);
            this.textBox3.TabIndex = 17;
            // 
            // BttnAddOwner
            // 
            this.BttnAddOwner.Location = new System.Drawing.Point(16, 306);
            this.BttnAddOwner.Name = "BttnAddOwner";
            this.BttnAddOwner.Size = new System.Drawing.Size(233, 37);
            this.BttnAddOwner.TabIndex = 18;
            this.BttnAddOwner.Text = "Принять владельца";
            this.BttnAddOwner.UseVisualStyleBackColor = true;
            this.BttnAddOwner.Click += new System.EventHandler(this.BttnAddOwner_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 349);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 17);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.Text = "Смс оповещения";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(136, 349);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(118, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Интернет-банкинг";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // BttnCreateAcc
            // 
            this.BttnCreateAcc.Location = new System.Drawing.Point(16, 368);
            this.BttnCreateAcc.Name = "BttnCreateAcc";
            this.BttnCreateAcc.Size = new System.Drawing.Size(233, 37);
            this.BttnCreateAcc.TabIndex = 21;
            this.BttnCreateAcc.Text = "Создать счет";
            this.BttnCreateAcc.UseVisualStyleBackColor = true;
            this.BttnCreateAcc.Click += new System.EventHandler(this.BttnCreateAcc_Click);
            // 
            // BttnSortByType
            // 
            this.BttnSortByType.Location = new System.Drawing.Point(255, 305);
            this.BttnSortByType.Name = "BttnSortByType";
            this.BttnSortByType.Size = new System.Drawing.Size(143, 100);
            this.BttnSortByType.TabIndex = 22;
            this.BttnSortByType.Text = "Сортировка по типу вклада";
            this.BttnSortByType.UseVisualStyleBackColor = true;
            this.BttnSortByType.Click += new System.EventHandler(this.BttnSortByType_Click);
            // 
            // BttnSortByDate
            // 
            this.BttnSortByDate.Location = new System.Drawing.Point(402, 306);
            this.BttnSortByDate.Name = "BttnSortByDate";
            this.BttnSortByDate.Size = new System.Drawing.Size(143, 100);
            this.BttnSortByDate.TabIndex = 23;
            this.BttnSortByDate.Text = "Сортировка по дате открытия";
            this.BttnSortByDate.UseVisualStyleBackColor = true;
            this.BttnSortByDate.Click += new System.EventHandler(this.BttnSortByDate_Click);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(554, 30);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(234, 20);
            this.numericUpDown3.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(551, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Номер счета для поиска";
            // 
            // BttnFindByNum
            // 
            this.BttnFindByNum.Location = new System.Drawing.Point(554, 53);
            this.BttnFindByNum.Name = "BttnFindByNum";
            this.BttnFindByNum.Size = new System.Drawing.Size(234, 37);
            this.BttnFindByNum.TabIndex = 26;
            this.BttnFindByNum.Text = "Найти по номеру";
            this.BttnFindByNum.UseVisualStyleBackColor = true;
            this.BttnFindByNum.Click += new System.EventHandler(this.BttnFindByNum_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(555, 109);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(233, 20);
            this.textBox4.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(551, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "ФИО владельца для поиска";
            // 
            // BttnFindByName
            // 
            this.BttnFindByName.Location = new System.Drawing.Point(554, 135);
            this.BttnFindByName.Name = "BttnFindByName";
            this.BttnFindByName.Size = new System.Drawing.Size(234, 37);
            this.BttnFindByName.TabIndex = 29;
            this.BttnFindByName.Text = "Найти по ФИО";
            this.BttnFindByName.UseVisualStyleBackColor = true;
            this.BttnFindByName.Click += new System.EventHandler(this.BttnFindByName_Click);
            // 
            // BttnFindByBal
            // 
            this.BttnFindByBal.Location = new System.Drawing.Point(554, 215);
            this.BttnFindByBal.Name = "BttnFindByBal";
            this.BttnFindByBal.Size = new System.Drawing.Size(234, 37);
            this.BttnFindByBal.TabIndex = 32;
            this.BttnFindByBal.Text = "Найти по балансу";
            this.BttnFindByBal.UseVisualStyleBackColor = true;
            this.BttnFindByBal.Click += new System.EventHandler(this.BttnFindByBal_Click);
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(554, 192);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(233, 20);
            this.numericUpDown4.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(551, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Баланс для поиска";
            // 
            // BttnFindByType
            // 
            this.BttnFindByType.Location = new System.Drawing.Point(554, 297);
            this.BttnFindByType.Name = "BttnFindByType";
            this.BttnFindByType.Size = new System.Drawing.Size(234, 37);
            this.BttnFindByType.TabIndex = 35;
            this.BttnFindByType.Text = "Найти по типу";
            this.BttnFindByType.UseVisualStyleBackColor = true;
            this.BttnFindByType.Click += new System.EventHandler(this.BttnFindByType_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(555, 271);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(233, 20);
            this.textBox5.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(551, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "Тип акканта для поиска";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 417);
            this.Controls.Add(this.BttnFindByType);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BttnFindByBal);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.BttnFindByName);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BttnFindByNum);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BttnSortByDate);
            this.Controls.Add(this.BttnSortByType);
            this.Controls.Add(this.BttnCreateAcc);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BttnAddOwner);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BttnAddOwner;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button BttnCreateAcc;
        private System.Windows.Forms.Button BttnSortByType;
        private System.Windows.Forms.Button BttnSortByDate;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BttnFindByNum;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BttnFindByName;
        private System.Windows.Forms.Button BttnFindByBal;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BttnFindByType;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label12;
    }
}

