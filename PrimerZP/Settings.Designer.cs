namespace PrimerZP
{
    partial class Settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.changeGoalButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.montages = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.radioMoney = new System.Windows.Forms.RadioButton();
            this.radioWord = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.panelChanche = new System.Windows.Forms.Panel();
            this.buttonSaveDate = new System.Windows.Forms.Button();
            this.textOldDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNewDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelChanche.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Изменить цель:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(286, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 150);
            this.panel1.TabIndex = 1;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSave.Location = new System.Drawing.Point(16, 88);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(138, 42);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // changeGoalButton
            // 
            this.changeGoalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.changeGoalButton.Location = new System.Drawing.Point(23, 57);
            this.changeGoalButton.Name = "changeGoalButton";
            this.changeGoalButton.Size = new System.Drawing.Size(184, 67);
            this.changeGoalButton.TabIndex = 2;
            this.changeGoalButton.Text = "Изменить цель";
            this.changeGoalButton.UseVisualStyleBackColor = true;
            this.changeGoalButton.Click += new System.EventHandler(this.changeGoalButton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(23, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 62);
            this.button1.TabIndex = 3;
            this.button1.TabStop = false;
            this.button1.Text = "Смотреть все монтажи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.montages);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(231, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 389);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // montages
            // 
            this.montages.Location = new System.Drawing.Point(17, 13);
            this.montages.Name = "montages";
            this.montages.Size = new System.Drawing.Size(371, 304);
            this.montages.TabIndex = 0;
            this.montages.Text = "";
            this.montages.ZoomFactor = 1.5F;
            this.montages.TextChanged += new System.EventHandler(this.montages_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.radioMoney);
            this.panel3.Controls.Add(this.radioWord);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.panel3.Location = new System.Drawing.Point(23, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 177);
            this.panel3.TabIndex = 5;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выбор подсказки";
            // 
            // radioMoney
            // 
            this.radioMoney.AutoSize = true;
            this.radioMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioMoney.ForeColor = System.Drawing.Color.Green;
            this.radioMoney.Location = new System.Drawing.Point(14, 114);
            this.radioMoney.Name = "radioMoney";
            this.radioMoney.Size = new System.Drawing.Size(137, 28);
            this.radioMoney.TabIndex = 7;
            this.radioMoney.Text = "С деньгами";
            this.radioMoney.UseVisualStyleBackColor = true;
            this.radioMoney.CheckedChanged += new System.EventHandler(this.radioMoney_CheckedChanged);
            // 
            // radioWord
            // 
            this.radioWord.AutoSize = true;
            this.radioWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.radioWord.ForeColor = System.Drawing.Color.Green;
            this.radioWord.Location = new System.Drawing.Point(14, 66);
            this.radioWord.Name = "radioWord";
            this.radioWord.Size = new System.Drawing.Size(123, 28);
            this.radioWord.TabIndex = 6;
            this.radioWord.Text = "С текстом";
            this.radioWord.UseVisualStyleBackColor = false;
            this.radioWord.CheckedChanged += new System.EventHandler(this.radioWord_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button3.Location = new System.Drawing.Point(23, 231);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 62);
            this.button3.TabIndex = 6;
            this.button3.Text = "Изменить дату монтажа";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelChanche
            // 
            this.panelChanche.CausesValidation = false;
            this.panelChanche.Controls.Add(this.buttonSaveDate);
            this.panelChanche.Controls.Add(this.textOldDate);
            this.panelChanche.Controls.Add(this.label5);
            this.panelChanche.Controls.Add(this.textNumber);
            this.panelChanche.Controls.Add(this.label4);
            this.panelChanche.Controls.Add(this.textNewDate);
            this.panelChanche.Controls.Add(this.label3);
            this.panelChanche.Location = new System.Drawing.Point(234, 464);
            this.panelChanche.Name = "panelChanche";
            this.panelChanche.Size = new System.Drawing.Size(357, 247);
            this.panelChanche.TabIndex = 2;
            this.panelChanche.Visible = false;
            this.panelChanche.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChanche_Paint);
            // 
            // buttonSaveDate
            // 
            this.buttonSaveDate.Location = new System.Drawing.Point(14, 187);
            this.buttonSaveDate.Name = "buttonSaveDate";
            this.buttonSaveDate.Size = new System.Drawing.Size(123, 40);
            this.buttonSaveDate.TabIndex = 8;
            this.buttonSaveDate.Text = "Сохранить";
            this.buttonSaveDate.UseVisualStyleBackColor = true;
            this.buttonSaveDate.Click += new System.EventHandler(this.buttonSaveDate_Click);
            // 
            // textOldDate
            // 
            this.textOldDate.AutoSize = true;
            this.textOldDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textOldDate.Location = new System.Drawing.Point(152, 90);
            this.textOldDate.Name = "textOldDate";
            this.textOldDate.Size = new System.Drawing.Size(0, 20);
            this.textOldDate.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label5.Location = new System.Drawing.Point(10, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Старая дата :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textNumber
            // 
            this.textNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textNumber.Location = new System.Drawing.Point(156, 42);
            this.textNumber.MinimumSize = new System.Drawing.Size(4, 10);
            this.textNumber.Name = "textNumber";
            this.textNumber.Size = new System.Drawing.Size(121, 26);
            this.textNumber.TabIndex = 4;
            this.textNumber.TextChanged += new System.EventHandler(this.textNumber_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.Location = new System.Drawing.Point(10, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Новая дата:";
            // 
            // textNewDate
            // 
            this.textNewDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textNewDate.Location = new System.Drawing.Point(156, 140);
            this.textNewDate.MinimumSize = new System.Drawing.Size(4, 10);
            this.textNewDate.Name = "textNewDate";
            this.textNewDate.Size = new System.Drawing.Size(121, 26);
            this.textNewDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 74);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер договора:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 723);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelChanche);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeGoalButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelChanche.ResumeLayout(false);
            this.panelChanche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button changeGoalButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox montages;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.RadioButton radioWord;
        protected internal System.Windows.Forms.RadioButton radioMoney;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelChanche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNewDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label textOldDate;
        private System.Windows.Forms.Button buttonSaveDate;
    }
}