using System;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace PrimerZP
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // кнопка "Сохранить" в изменить цель
        private void buttonSave_Click(object sender, EventArgs e)
        {
            var culture = new CultureInfo("ru-RU")
            {
                NumberFormat = { NumberGroupSeparator = ".", },
            };
            int goal = Int32.Parse(textBox1.Text);
            Properties.Settings.Default.goal = goal.ToString("#.#", culture);
            Properties.Settings.Default.Save();
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // кнопка "Изменить цель"
        private void changeGoalButton_Click(object sender, EventArgs e)
        {
            CheckOpen();
            panel1.Enabled = true;
            panel1.Visible = true; 
        }

        // кнопка "Смотреть все монтажи"
        private void button1_Click(object sender, EventArgs e)
        {
            CheckOpen();
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
            if (panel1.Visible == true || panel2.Visible == true)
            {
                panel1.Enabled = false; panel2.Enabled = false;
                panel1.Visible = false; panel2.Visible = false;
            }
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


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void montages_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
