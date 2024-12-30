using System;
using System.Windows.Forms;

namespace SimpleCounterApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Text = "SimpleCounterApp";

            labelCounter.Text = "00";
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {

        }
    }
}
