using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VS2019
{
    public partial class Form1 : Form
    {
        public static string theme = "https://github.com/mazk5145/imgs/blob/main/vs.png?raw=true"; // VSLOADING
        public Form1()
        {
            InitializeComponent();
            // Create a new Form1 and set its Visible property to true.
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(700, 330);
        }

        private void WaitNSeconds(int segundos)
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                System.Windows.Forms.Application.DoEvents();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.loadingform.ImageLocation = theme;
            WaitNSeconds(4);
            checkupdatesbeforeload();

            /*
            MessageBox.Show("App not found");
            Environment.Exit(0);
            */
        }

        private void checkupdatesbeforeload()
        {
            if (File.Exists("C:\\ProgramData\\VS2021UI\\installed.dat"))
            {
                this.Hide();
                updateform F2 = new updateform();
                F2.ShowDialog();
            }
            else
            {
                this.Hide();
                installui F3 = new installui();
                F3.ShowDialog();
            }
        }

        private void loadingform_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
