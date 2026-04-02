using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Set timer to tick every 1 second (1000 milliseconds)
            timer1.Interval = 1000;
            timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10; // 5 minutes * 60 seconds = 300 seconds
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                this.Hide(); // Hide loading form
                Form1 main = new Form1(); // Replace with your main form
                main.Show();
            }
        }
    }
}