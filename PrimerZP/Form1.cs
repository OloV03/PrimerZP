using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerZP
{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();
            DateTime date = DateTime.Now; 
            double a = (int)date.DayOfWeek;

            Excels ex = new Excels();
            string res = ex.Result();
            
            //Устанавливаем значение поля label1
            this.label1.Text = "\tТекущая неделя\n" + date.AddDays(-a).ToString("M") + 
                                " - " + date.AddDays(6 - a).ToString("M");

            this.label2.Text = $"Ожидаемая зарплата  \n~{res} руб~";


        }

        // кнопка "Показать зарплату"
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true; label2.Visible = true;
            button3.Visible = true;
        }

        // кнопка "Внести новый монтаж"
        private void button2_Click(object sender, EventArgs e)
        {
            close2.Visible = true;
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

        // закрыть под "показать зарплату"
        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = false; label2.Visible = false;
            button3.Visible = false;
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
        private void close2_Click(object sender, EventArgs e)
        {
            close2.Visible = false;
        }
    }
}
