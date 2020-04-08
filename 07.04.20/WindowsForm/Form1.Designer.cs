namespace WindowsForm
{
    partial class Statement
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
            this.Group = new System.Windows.Forms.ComboBox();
            this.Format = new System.Windows.Forms.ComboBox();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.FIO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // Group
            // 
            this.Group.BackColor = System.Drawing.SystemColors.Window;
            this.Group.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Group.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Group.FormattingEnabled = true;
            this.Group.Items.AddRange(new object[] {
            "ПКС - 18.02",
            "ПКС - 17.02",
            "ОД - 16.01",
            "ИС - 19.04",
            "ИС - 19.01",
            "ИС - 18.02"});
            this.Group.Location = new System.Drawing.Point(134, 213);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(164, 21);
            this.Group.TabIndex = 2;
            // 
            // Format
            // 
            this.Format.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Format.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Format.FormattingEnabled = true;
            this.Format.Items.AddRange(new object[] {
            "Заявление"});
            this.Format.Location = new System.Drawing.Point(134, 416);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(164, 21);
            this.Format.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Date.Location = new System.Drawing.Point(134, 344);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(164, 20);
            this.Date.TabIndex = 5;
            // 
            // FIO
            // 
            this.FIO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FIO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FIO.FormattingEnabled = true;
            this.FIO.Items.AddRange(new object[] {
            "Коновалова Любава Филипповна",
            "Кудрин Гаврила Валериевич",
            "Мурзакова Стела Борисовна",
            "Каржаубаев Кирилл Гордеевич",
            "Паршиков Арсений Ипатович"});
            this.FIO.Location = new System.Drawing.Point(134, 278);
            this.FIO.Name = "FIO";
            this.FIO.Size = new System.Drawing.Size(164, 21);
            this.FIO.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "Заполнение документа";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsForm.Properties.Resources.group;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(60, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsForm.Properties.Resources.calendar;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(60, 331);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::WindowsForm.Properties.Resources.student;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(60, 264);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 50);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::WindowsForm.Properties.Resources.paper;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox4.Location = new System.Drawing.Point(60, 398);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(55, 50);
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = global::WindowsForm.Properties.Resources.word;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox6.Location = new System.Drawing.Point(326, 251);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(116, 130);
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.Color.Transparent;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close.Location = new System.Drawing.Point(441, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(17, 17);
            this.Close.TabIndex = 15;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // Confirm
            // 
            this.Confirm.AutoSize = true;
            this.Confirm.BackColor = System.Drawing.Color.Transparent;
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Confirm.Location = new System.Drawing.Point(156, 482);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(120, 25);
            this.Confirm.TabIndex = 16;
            this.Confirm.Text = "Подтвердить";
            this.Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click_1);
            this.Confirm.MouseEnter += new System.EventHandler(this.Confirm_MouseEnter);
            this.Confirm.MouseLeave += new System.EventHandler(this.Confirm_MouseLeave);
            // 
            // Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsForm.Properties.Resources._66fb311486e2e749c43b7dc1b9942946__beautiful_sites_lak;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 579);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FIO);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.Group);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Statement_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Statement_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Group;
        private System.Windows.Forms.ComboBox Format;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.ComboBox FIO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Close;
        private System.Windows.Forms.Label Confirm;
    }
}

