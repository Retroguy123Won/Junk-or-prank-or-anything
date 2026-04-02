using System;
using System.IO; // Required for Directory
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            timer1.Start();
    try
            {
                listBox1.Items.Clear();
                string folderPath = @"C:\Windows\System32";

                // Enumerate files in System32 (top directory only)
                var files = Directory.EnumerateFiles(folderPath, "*", SearchOption.TopDirectoryOnly);

                foreach (string file in files)
                {
                    // Use Path.GetFileName to show just the name in the ListBox
                    listBox1.Items.Add(Path.GetFileName(file));
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Access to C:\\ is restricted. Try running as Admin.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            
            }
        
            


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();

                MessageBox.Show(
     "Fatal system error detected. All data will be lost. Please contact support immediately.",
     "CRITICAL_ERROR",
     MessageBoxButtons.OK,
     MessageBoxIcon.Error
 );
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}