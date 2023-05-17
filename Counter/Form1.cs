using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class Form1 : Form
    {

        int counter = 0;
        int remainingTime = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            timer.Enabled = true;

            counter++;

            lbl_label.Text = counter.ToString();

            if (timer.Enabled == false)
            {
                MessageBox.Show("teste");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {            

            this.BackColor = Color.White;

            dark_mode.BackColor = Color.Black;

            light_mode.BackColor = Color.White;
            light_mode.ForeColor = Color.Black;

            labelTitle.ForeColor = Color.Black;
            lbl_label.ForeColor = Color.Black;
            button.ForeColor = Color.Black;
            button1.ForeColor = Color.Black;
            labelTime.ForeColor = Color.Black;
            buttonRestart.ForeColor = Color.Black;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.BackColor = Color.Black;

            light_mode.BackColor = Color.Black;
            light_mode.ForeColor = Color.Yellow;

            labelTitle.ForeColor = Color.Yellow;
            lbl_label.ForeColor = Color.Yellow;
            button.ForeColor = Color.Yellow;
            button1.ForeColor = Color.Yellow;
            labelTime.ForeColor = Color.Yellow;
            buttonRestart.ForeColor = Color.Yellow;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            if (remainingTime >= 0)
            {
                labelTime.Text = "Tempo restante: " + remainingTime.ToString() + " segundos.";
            } 
            else
            {
                lbl_label.Text = "0";
                timer.Enabled = false;
                labelTime.Text = $"Tempo Esgotado! \nTotal de cliques: " + counter.ToString();
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            counter = 0;
            remainingTime = 10;

            lbl_label.Text = "0";
            labelTime.Text = "";
            timer.Enabled = false;
        }
    }
}
