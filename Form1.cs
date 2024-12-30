using System;
using System.Windows.Forms;

namespace SimpleCounterApp
{
    public partial class Form1 : Form
    {
        private int counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "SimpleCounterApp";

            labelCounter.Text = counter.ToString("D2");
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            if (counter < 99)
            {
                counter++;
                labelCounter.Text = counter.ToString("D2");
            }
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            if (counter > 0)
            {
                counter--;
                labelCounter.Text = counter.ToString("D2");
            }
        }
    }
}
