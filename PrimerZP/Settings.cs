using System;
using System.Windows.Forms;
using System.IO;

namespace PrimerZP
{
    public partial class Settings : Form
    {
        bool check = false;
        public Settings()
        {
            InitializeComponent();
            radioWord.Checked = !Properties.Settings.Default.govno;
            radioMoney.Checked = Properties.Settings.Default.govno;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // кнопка "Сохранить" в изменить цель
        private void buttonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.goal = textBox1.Text;
            Properties.Settings.Default.Save();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // кнопка "Изменить цель"
        private void changeGoalButton_Click(object sender, EventArgs e)
        {
            CheckOpen(); check = true;
            panel1.Enabled = true;
            panel1.Visible = true; 
        }

        // кнопка "Смотреть все монтажи"
        private void button1_Click(object sender, EventArgs e)
        {
            CheckOpen(); check = true;
            // активация окна взаимодействия
            panel2.Enabled = true;
            panel2.Visible = true;

            using (StreamReader sr = new StreamReader(@"Jukov.txt", System.Text.Encoding.Default))
            {
                montages.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        // проверка открытых окон
        private void CheckOpen()
        {
            if (check)
            {
                panel1.Enabled = false; panel2.Enabled = false;
                panel1.Visible = false; panel2.Visible = false;
                panelChanche.Visible = false;

                check = false;
            }
        }

        // кнопка "Изменить дату монтажа"
        private void button3_Click(object sender, EventArgs e)
        {
            Excels ex = new Excels();
            CheckOpen(); check = true;
            panelChanche.Visible = true;
            panelChanche.Location = new System.Drawing.Point(187, 132);
        }

        // кнопка "Сохранить" для монтажей
        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(@"Jukov.txt", false, System.Text.Encoding.Default))
            {
                sw.Write(montages.Text);
                sw.Close();
            }
        }

        // кнопка "Сохранить", изменить дату монтажа
        private void buttonSaveDate_Click(object sender, EventArgs e)
        {
            Excels ex = new Excels();
            if (textNewDate.TextLength == 5 && textNumber.TextLength == 5)
            {
                ex.ChangeDateMontage(textOldDate.Text, textNewDate.Text);
            }
            else if (textNumber.Text == "") { }
            else
            {
                MessageBox.Show("Некорректный ввод данных");
            }
            textNumber.Clear();
            textNewDate.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void montages_TextChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        private void radioWord_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.govno = !radioWord.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioMoney_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNumber_TextChanged(object sender, EventArgs e)
        {
            Excels ex = new Excels();
            if (textNumber.TextLength == 5)
            {
                textOldDate.Text = ex.FindMontage(textNumber.Text);
            }
            else
            {
                textOldDate.Text = "";
            }
        }

        private void panelChanche_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
