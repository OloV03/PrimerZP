﻿namespace PrimerZP
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.button1.Text = "Смотреть все монтажи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.montages);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(252, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 442);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 38);
            this.button2.TabIndex = 1;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // montages
            // 
            this.montages.Location = new System.Drawing.Point(14, 29);
            this.montages.Name = "montages";
            this.montages.Size = new System.Drawing.Size(348, 344);
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
            this.panel3.Location = new System.Drawing.Point(23, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(191, 177);
            this.panel3.TabIndex = 5;
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
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 504);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeGoalButton);
            this.Controls.Add(this.panel1);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
    }
}