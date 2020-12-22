using System;
using System.Windows.Forms;
using System.Threading;

namespace PrimerZP
{
    public partial class Preface : Form
    {
        Excels ex = new Excels();
        
        public Preface()
        {
            InitializeComponent();
            textBox_Preface.Text = $"Твоя цель: \n{ex.goal} руб";
            
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
