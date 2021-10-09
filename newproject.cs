using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS2019
{
    public partial class newproject : Form
    {
        public newproject()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(450, 200);
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void maximizebtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not in this build");
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            updateform F2 = new updateform();
            this.Hide();
            F2.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("not in this build");
        }

        private void newproject_Load(object sender, EventArgs e)
        {

        }
    }
}
