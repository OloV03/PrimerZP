using System;
using System.Windows.Forms;
using System.Globalization;

namespace PrimerZP
{
    public partial class Preface : Form
    {        
        public Preface()
        {
            InitializeComponent();

            textBox_Preface.Text = $"Моя цель: \n{Properties.Settings.Default.goal} руб";
        }

        private void Preface_Load(object sender, EventArgs e)
        {

        }

        private void Preafce_Click(object sender, EventArgs e)
        {
        }

        private void textBox_Preface_Click(object sender, EventArgs e)
        {

        }
    }
}
