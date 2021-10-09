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
    public partial class installui : Form
    {
        public installui()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(450, 200);
        }

        private void installui_Load(object sender, EventArgs e)
        {
            if (File.Exists("C:\\ProgramData\\VS2021UI\\installed.dat"))
            {
                installbtn.Visible = false;
                secbtn.Visible = false;
                thebtn.Visible = false;
                uninstallbtn.Visible = true;
                latausbar.Visible = false;
                installlabel.Visible = false;
            }
            else
            {
                installbtn.Visible = true;
                secbtn.Visible = false;
                thebtn.Visible = false;
                uninstallbtn.Visible = false;
                installlabel.Visible = false;
                latausbar.Visible = false;
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void installbtn_Click(object sender, EventArgs e)
        {
            latausbar.Visible = true;
            installlabel.Visible = true;
            aikakello.Start();
        }

        private void aikakello_Tick(object sender, EventArgs e)
        {
            latausbar.Increment(1);
            if (latausbar.Value == 0)
            {
                installlabel.Text = "Downloading files......";
            }
            if (latausbar.Value == 15)
            {
                installlabel.Text = "Moving files...";
                string filePath = @"C:\ProgramData\VS2021UI";
                Directory.CreateDirectory(filePath);
                File.WriteAllText("C:\\ProgramData\\VS2021UI\\installed.dat", "Installed!");
            }
            if (latausbar.Value == 30)
            {
                installlabel.Text = "Installing vcredist64.exe...";
            }
            if (latausbar.Value == 60)
            {
                installlabel.Text = "Installing vcredist32.exe...";
            }
            if (latausbar.Value == 80)
            {
                installlabel.Text = "Cleaning up...";
            }
            else if (latausbar.Value == 100)
            {
                installbtn.Visible = false;
                secbtn.Visible = false;
                thebtn.Visible = false;
                installlabel.Visible = false;
                uninstallbtn.Visible = true;
                latausbar.Visible = false;
                aikakello.Stop();
                MessageBox.Show("Please restart this program to make VS2021 UI alive!");
                Environment.Exit(0);
            }
        }

        private void deletingfiles_Tick(object sender, EventArgs e)
        {
            latausbar.Increment(1);
            if (latausbar.Value == 0)
            {
                installlabel.Text = "Uninstalling files......";
            }
            if (latausbar.Value == 15)
            {
                installlabel.Text = "Uninstalling files...";
                string filePath = @"C:\ProgramData\VS2021UI";
                Directory.Delete(filePath);
            }
            if (latausbar.Value == 30)
            {
                installlabel.Text = "Uninstalling vcredist64.exe...";
            }
            if (latausbar.Value == 60)
            {
                installlabel.Text = "Uninstalling vcredist32.exe...";
            }
            if (latausbar.Value == 80)
            {
                installlabel.Text = "Cleaning up...";
            }
            else if (latausbar.Value == 100)
            {
                installbtn.Visible = true;
                secbtn.Visible = false;
                thebtn.Visible = false;
                installlabel.Visible = false;
                uninstallbtn.Visible = false;
                latausbar.Visible = false;
                File.Delete("C:\\ProgramData\\VS2021UI\\installed.dat");
                deletingfiles.Stop();
            }
        }

        private void uninstallbtn_Click(object sender, EventArgs e)
        {
            latausbar.Visible = true;
            installlabel.Visible = true;
            deletingfiles.Start();
        }
    }
}
