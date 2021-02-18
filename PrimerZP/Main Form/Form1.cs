using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Globalization;

namespace PrimerZP
{
    public partial class Main : Form
    {
        bool check = false;
        Excels ex = new Excels();
        public Main()
        {
            var culture = new CultureInfo("ru-RU")
            {
                NumberFormat = { NumberGroupSeparator = ".", },
            };
            // загрузка "цели"
            Preface load = new Preface();
            load.ShowDialog();
            int x = Int32.Parse(ex.goal.Replace(".", "")) / 4;

            InitializeComponent();
            // мотивация
            labelMotivation.Text = $"Для достижения цели необходимо\n\t{x.ToString("#,#",culture)} руб в неделю";

            panelShowMont.Location = new System.Drawing.Point(360,100);
            panelShowMont.Height = 1129;
            panelShowMont.Width = 500;
        }

        // кнопка "Показать зарплату"
        protected internal void button1_Click(object sender, EventArgs e)
        {
            // проверка, не открыто ли другое окно
            CheckOpen();
            panel2.Visible = true; button3.Visible = true; check = true;

            DateTime date = DateTime.Now;          // дата для получения текущей недели
            double a = (int)date.DayOfWeek; a--;
            DateTime date1 = date.AddDays(7);      // дата для получения недели +1
            DateTime date2 = date.AddDays(14);     // дата для получения недели +2


            // Устанавливаем значение полей "текущей недели"
            label1.Text = "\tТекущая неделя\n" + date.AddDays(-a).ToString("M") +
                                " - " + date.AddDays(6 - a).ToString("M");
            
            label2.Text = $"Ожидаемая зарплата  \n~{ex.Result(date)} руб~";
            labelHint1.Text = ex.Hint(Int32.Parse(ex.Result(date)));


            // Устанавливаем значение полей "следующая неделя"
            label2WeekStart.Text = "\tСледующая неделя\n" + date.AddDays(7-a).ToString("M") +
                                " - " + date.AddDays(13 - a).ToString("M");

            label2WeekEnd.Text = $"Ожидаемая зарплата  \n~{ex.Result(date1)} руб~";
            labelHint2.Text = ex.Hint(Int32.Parse(ex.Result(date1)));


            // Устанавливаем значение полей "черер 2 недели"
            label3WeekStart.Text = "\tЧерез неделю\n" + date.AddDays(14 - a).ToString("M") +
                                " - " + date.AddDays(20 - a).ToString("M");

            label3WeekEnd.Text = $"Ожидаемая зарплата  \n~{ex.Result(date2)} руб~";
            labelHint3.Text = ex.Hint(Int32.Parse(ex.Result(date2)));
        }

        // кнопка "Внести новый монтаж"
        private void button2_Click(object sender, EventArgs e)
        {
            // проверка, не открыто ли другое окно
            CheckOpen(); 
            close2.Visible = true; panel1.Visible = true; check = true;
        }

        // !закрыть! под "показать зарплату"
        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            button3.Visible = false;
            check = false;
        }

        // !закрыть! под "Внести новый монтаж"
        private void close2_Click(object sender, EventArgs e)
        {
            close2.Visible = false; 
            panel1.Visible = false;
            check = false;
        }

        // кнопка "Сохранить" при внесении монтажа
        private void saveButton_Click(object sender, EventArgs e)
        {
            string num = numZak.Text; numZak.Clear();
            string date = dateMon.Text; dateMon.Clear();
            string price = zarplata.Text; zarplata.Clear();
            string line = "\n" + date + " " + num + " " + price; // итоговая строка 
            Excels ex = new Excels();
            ex.EnterData(line);
        }

        // кнопка настроек
        private void settings_Click(object sender, EventArgs e)
        {
            Settings set = new Settings();
            set.ShowDialog();
        }

        // кнопка "Показать монтажи"
        private void buttonMontages_Click(object sender, EventArgs e)
        {
            CheckOpen();
            panelShowMont.Visible = true; buttonEscMontages.Visible = true; check = true;


            DateTime date = DateTime.Now;          // дата для получения текущей недели
            date = date.AddDays(-7);
            double a = (int)date.DayOfWeek; a--; a = -a;

            // Устанавливаем значение полей "прошлой недели"
            label6.Text = "\t\tПрошлая неделя\n" + date.AddDays(a).ToString("M") +
                                " - " + date.AddDays(6 + a).ToString("M");

            for (int i = 0; i < 7; i++)
            {
                DateMontages.Text += ex.FindMontage(date.AddDays(a + i));
            }
        }

        // кнопка !Закрыть! при показе монтажей
        private void buttonEscMontages_Click(object sender, EventArgs e)
        {
            panelShowMont.Visible = false; 
            buttonEscMontages.Visible = false; 
            check = false;
            DateMontages.Text = "";
        }

        // проверка открытых окон
        private void CheckOpen()
        {
            if (check == true)
            {
                panel1.Visible = false;
                panel2.Visible = false;
                button3.Visible = false;
                close2.Visible = false;
                buttonEscMontages.Visible = false;
                panelShowMont.Visible = false; DateMontages.Text = "";
                buttonEscMontages.Visible = false;

                check = false;
            }
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;          
            double a = (int)date.DayOfWeek; a--; a =  -a;
            string text = "";
            for (int i = 0; i < 7; i++)
            {
                text += ex.FindMontage(date.AddDays(a + i)); 
            }
            if (text == "")
            {
                text = "Нет монтажей";
            }
            toolTip1.SetToolTip(label2, text);
        }

        private void label2WeekEnd_MouseHover(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            double a = (int)date.DayOfWeek; a--; a = -a;
            string text = "";
            for (int i = 0; i < 7; i++)
            {
                text += ex.FindMontage(date.AddDays(7 + a + i));
            }
            if (text == "")
            {
                text = "Нет монтажей";
            }
            toolTip1.SetToolTip(label2WeekEnd, text);
        }

        private void label3WeekEnd_MouseHover(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            double a = (int)date.DayOfWeek; a--; a = -a;
            string text = "";
            for (int i = 0; i < 7; i++)
            {
                text += ex.FindMontage(date.AddDays(14 + a + i));
            }
            if (text == "")
            {
                text = "Нет монтажей";
            }
            toolTip1.SetToolTip(label3WeekEnd, text);
        }



        private void Main_Load(object sender, EventArgs e)
        {

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }      
        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void numZak_TextChanged(object sender, EventArgs e)
        {

        }
        private void dateMon_TextChanged(object sender, EventArgs e)
        {

        }
        private void zarplata_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void label3WeekEnd_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void labelHint2_Click(object sender, EventArgs e)
        {

        }
        private void labelHint3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelHint1_Click(object sender, EventArgs e)
        {

        }
    }
}
