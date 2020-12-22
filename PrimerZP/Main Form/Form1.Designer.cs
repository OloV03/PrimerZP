namespace PrimerZP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.zarplata = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateMon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numZak = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelHint3 = new System.Windows.Forms.Label();
            this.labelHint2 = new System.Windows.Forms.Label();
            this.labelHint1 = new System.Windows.Forms.Label();
            this.label3WeekEnd = new System.Windows.Forms.Label();
            this.label3WeekStart = new System.Windows.Forms.Label();
            this.label2WeekEnd = new System.Windows.Forms.Label();
            this.label2WeekStart = new System.Windows.Forms.Label();
            this.labelMotivation = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.settings = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 170);
            this.button1.TabIndex = 0;
            this.button1.Text = "Показать зарплату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(41, 356);
            this.button2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 177);
            this.button2.TabIndex = 1;
            this.button2.Text = "Внести новый монтаж";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(165, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Закрыть";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.MinimumSize = new System.Drawing.Size(300, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(17, 87);
            this.label2.MinimumSize = new System.Drawing.Size(300, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // close2
            // 
            this.close2.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold);
            this.close2.Location = new System.Drawing.Point(165, 542);
            this.close2.Name = "close2";
            this.close2.Size = new System.Drawing.Size(109, 34);
            this.close2.TabIndex = 5;
            this.close2.Text = "Закрыть";
            this.close2.UseVisualStyleBackColor = true;
            this.close2.Visible = false;
            this.close2.Click += new System.EventHandler(this.close2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.zarplata);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dateMon);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.numZak);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(358, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 339);
            this.panel1.TabIndex = 6;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.saveButton.Location = new System.Drawing.Point(42, 251);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 45);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // zarplata
            // 
            this.zarplata.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.zarplata.Location = new System.Drawing.Point(42, 203);
            this.zarplata.Name = "zarplata";
            this.zarplata.Size = new System.Drawing.Size(146, 31);
            this.zarplata.TabIndex = 5;
            this.zarplata.TextChanged += new System.EventHandler(this.zarplata_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(38, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Зарплата";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateMon
            // 
            this.dateMon.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.dateMon.Location = new System.Drawing.Point(42, 126);
            this.dateMon.Name = "dateMon";
            this.dateMon.Size = new System.Drawing.Size(146, 31);
            this.dateMon.TabIndex = 3;
            this.dateMon.TextChanged += new System.EventHandler(this.dateMon_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(37, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата монтажа";
            // 
            // numZak
            // 
            this.numZak.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.numZak.Location = new System.Drawing.Point(42, 39);
            this.numZak.Name = "numZak";
            this.numZak.Size = new System.Drawing.Size(146, 31);
            this.numZak.TabIndex = 1;
            this.numZak.TextChanged += new System.EventHandler(this.numZak_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(37, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "№ заказа";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelHint3);
            this.panel2.Controls.Add(this.labelHint2);
            this.panel2.Controls.Add(this.labelHint1);
            this.panel2.Controls.Add(this.label3WeekEnd);
            this.panel2.Controls.Add(this.label3WeekStart);
            this.panel2.Controls.Add(this.label2WeekEnd);
            this.panel2.Controls.Add(this.label2WeekStart);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(314, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(341, 606);
            this.panel2.TabIndex = 7;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // labelHint3
            // 
            this.labelHint3.AutoSize = true;
            this.labelHint3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHint3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labelHint3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHint3.Location = new System.Drawing.Point(21, 544);
            this.labelHint3.Margin = new System.Windows.Forms.Padding(3);
            this.labelHint3.MinimumSize = new System.Drawing.Size(300, 50);
            this.labelHint3.Name = "labelHint3";
            this.labelHint3.Size = new System.Drawing.Size(300, 50);
            this.labelHint3.TabIndex = 11;
            this.labelHint3.Text = "1";
            this.labelHint3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelHint3.Click += new System.EventHandler(this.labelHint3_Click);
            // 
            // labelHint2
            // 
            this.labelHint2.AutoSize = true;
            this.labelHint2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHint2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labelHint2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHint2.Location = new System.Drawing.Point(21, 337);
            this.labelHint2.Margin = new System.Windows.Forms.Padding(3);
            this.labelHint2.MinimumSize = new System.Drawing.Size(300, 50);
            this.labelHint2.Name = "labelHint2";
            this.labelHint2.Size = new System.Drawing.Size(300, 50);
            this.labelHint2.TabIndex = 10;
            this.labelHint2.Text = "1";
            this.labelHint2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelHint2.Click += new System.EventHandler(this.labelHint2_Click);
            // 
            // labelHint1
            // 
            this.labelHint1.AutoSize = true;
            this.labelHint1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHint1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHint1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labelHint1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelHint1.Location = new System.Drawing.Point(18, 140);
            this.labelHint1.Margin = new System.Windows.Forms.Padding(3);
            this.labelHint1.MinimumSize = new System.Drawing.Size(300, 50);
            this.labelHint1.Name = "labelHint1";
            this.labelHint1.Size = new System.Drawing.Size(300, 50);
            this.labelHint1.TabIndex = 9;
            this.labelHint1.Text = "1";
            this.labelHint1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3WeekEnd
            // 
            this.label3WeekEnd.AutoSize = true;
            this.label3WeekEnd.ForeColor = System.Drawing.Color.Olive;
            this.label3WeekEnd.Location = new System.Drawing.Point(20, 491);
            this.label3WeekEnd.MinimumSize = new System.Drawing.Size(300, 50);
            this.label3WeekEnd.Name = "label3WeekEnd";
            this.label3WeekEnd.Size = new System.Drawing.Size(300, 50);
            this.label3WeekEnd.TabIndex = 8;
            this.label3WeekEnd.Text = "2";
            this.label3WeekEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3WeekEnd.Click += new System.EventHandler(this.label3WeekEnd_Click);
            // 
            // label3WeekStart
            // 
            this.label3WeekStart.AutoSize = true;
            this.label3WeekStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3WeekStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3WeekStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3WeekStart.Location = new System.Drawing.Point(20, 425);
            this.label3WeekStart.Margin = new System.Windows.Forms.Padding(3);
            this.label3WeekStart.MinimumSize = new System.Drawing.Size(300, 50);
            this.label3WeekStart.Name = "label3WeekStart";
            this.label3WeekStart.Size = new System.Drawing.Size(300, 50);
            this.label3WeekStart.TabIndex = 7;
            this.label3WeekStart.Text = "1";
            this.label3WeekStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2WeekEnd
            // 
            this.label2WeekEnd.AutoSize = true;
            this.label2WeekEnd.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2WeekEnd.Location = new System.Drawing.Point(20, 284);
            this.label2WeekEnd.MinimumSize = new System.Drawing.Size(300, 50);
            this.label2WeekEnd.Name = "label2WeekEnd";
            this.label2WeekEnd.Size = new System.Drawing.Size(300, 50);
            this.label2WeekEnd.TabIndex = 6;
            this.label2WeekEnd.Text = "2";
            this.label2WeekEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2WeekStart
            // 
            this.label2WeekStart.AutoSize = true;
            this.label2WeekStart.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2WeekStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2WeekStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2WeekStart.Location = new System.Drawing.Point(20, 218);
            this.label2WeekStart.Margin = new System.Windows.Forms.Padding(3);
            this.label2WeekStart.MinimumSize = new System.Drawing.Size(300, 50);
            this.label2WeekStart.Name = "label2WeekStart";
            this.label2WeekStart.Size = new System.Drawing.Size(300, 50);
            this.label2WeekStart.TabIndex = 5;
            this.label2WeekStart.Text = "1";
            this.label2WeekStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2WeekStart.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelMotivation
            // 
            this.labelMotivation.AutoSize = true;
            this.labelMotivation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotivation.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelMotivation.Location = new System.Drawing.Point(12, 23);
            this.labelMotivation.Name = "labelMotivation";
            this.labelMotivation.Size = new System.Drawing.Size(0, 23);
            this.labelMotivation.TabIndex = 8;
            this.labelMotivation.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.settings);
            this.panel3.Location = new System.Drawing.Point(4, 647);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(722, 30);
            this.panel3.TabIndex = 9;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // settings
            // 
            this.settings.BackColor = System.Drawing.SystemColors.HighlightText;
            this.settings.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.settings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settings.Location = new System.Drawing.Point(36, -1);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(95, 30);
            this.settings.TabIndex = 0;
            this.settings.Text = "Настройки";
            this.settings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.settings_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button4.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold);
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(582, -1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 30);
            this.button4.TabIndex = 1;
            this.button4.Text = "Фигнюшка";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(732, 680);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelMotivation);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.close2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Примерная зарплата ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox zarplata;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dateMon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numZak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3WeekEnd;
        private System.Windows.Forms.Label label3WeekStart;
        private System.Windows.Forms.Label label2WeekEnd;
        private System.Windows.Forms.Label label2WeekStart;
        private System.Windows.Forms.Label labelHint3;
        private System.Windows.Forms.Label labelHint2;
        private System.Windows.Forms.Label labelHint1;
        private System.Windows.Forms.Label labelMotivation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button settings;
        private System.Windows.Forms.Button button4;
    }
}

