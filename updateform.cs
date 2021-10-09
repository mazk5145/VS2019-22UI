using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2019
{
    public partial class updateform : Form
    {
        public updateform()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(450, 200);
        }

        private void updateform_Load(object sender, EventArgs e)
        {
            ifprojectfound();

        }

        private void ifprojectfound()
        {

            if (File.Exists("C:\\ProgramData\\VS2021UI\\projects.dat"))
            {
                recentslog.Items.Clear();
                PopulateListBox(recentslog, "./projects", "*.vss");
                PopulateListBox(recentslog, "./projects", "*.projectvss");
            }
            else
            {
                return;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maximize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not in this build");
        }

        public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

        private void newprojectbtn_Click(object sender, EventArgs e)
        {
            string filePath = @".\projects";

            if (File.Exists(filePath))
            {
                newprojectwindow();
            }
            else
            {
                Directory.CreateDirectory(filePath);
                newprojectwindow();
            }
        }

        private void newprojectwindow()
        {
            newproject F3 = new newproject();
            this.Hide();
            F3.ShowDialog();
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not in this build");
        }

        private void clonerepobtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not in this build");
        }

        private void openprojectbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not in this build");
        }

        private void openfolderbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not in this build");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not in this build");
        }
    }
}
