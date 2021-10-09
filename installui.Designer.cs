
namespace VS2019
{
    partial class installui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.installbtn = new Guna.UI2.WinForms.Guna2Button();
            this.secbtn = new Guna.UI2.WinForms.Guna2Button();
            this.thebtn = new Guna.UI2.WinForms.Guna2Button();
            this.uninstallbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TIEDOTEPANEL = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.exitbtn = new Guna.UI2.WinForms.Guna2Button();
            this.minimizebtn = new Guna.UI2.WinForms.Guna2Button();
            this.aikakello = new System.Windows.Forms.Timer(this.components);
            this.latausbar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.installlabel = new System.Windows.Forms.Label();
            this.deletingfiles = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Visual Studio UI Installer";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.installlabel);
            this.guna2Panel1.Controls.Add(this.latausbar);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.uninstallbtn);
            this.guna2Panel1.Controls.Add(this.thebtn);
            this.guna2Panel1.Controls.Add(this.secbtn);
            this.guna2Panel1.Controls.Add(this.installbtn);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.guna2Panel1.Location = new System.Drawing.Point(42, 126);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(599, 154);
            this.guna2Panel1.TabIndex = 6;
            // 
            // installbtn
            // 
            this.installbtn.BorderThickness = 2;
            this.installbtn.CheckedState.Parent = this.installbtn;
            this.installbtn.CustomImages.Parent = this.installbtn;
            this.installbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.installbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.installbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.installbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.installbtn.DisabledState.Parent = this.installbtn;
            this.installbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.installbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.installbtn.ForeColor = System.Drawing.Color.White;
            this.installbtn.HoverState.Parent = this.installbtn;
            this.installbtn.Location = new System.Drawing.Point(487, 12);
            this.installbtn.Name = "installbtn";
            this.installbtn.ShadowDecoration.Parent = this.installbtn;
            this.installbtn.Size = new System.Drawing.Size(99, 29);
            this.installbtn.TabIndex = 0;
            this.installbtn.Text = "Install";
            this.installbtn.Click += new System.EventHandler(this.installbtn_Click);
            // 
            // secbtn
            // 
            this.secbtn.BorderThickness = 2;
            this.secbtn.CheckedState.Parent = this.secbtn;
            this.secbtn.CustomImages.Parent = this.secbtn;
            this.secbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.secbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.secbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.secbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.secbtn.DisabledState.Parent = this.secbtn;
            this.secbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.secbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.secbtn.ForeColor = System.Drawing.Color.White;
            this.secbtn.HoverState.Parent = this.secbtn;
            this.secbtn.Location = new System.Drawing.Point(487, 47);
            this.secbtn.Name = "secbtn";
            this.secbtn.ShadowDecoration.Parent = this.secbtn;
            this.secbtn.Size = new System.Drawing.Size(99, 29);
            this.secbtn.TabIndex = 1;
            this.secbtn.Text = "soon";
            // 
            // thebtn
            // 
            this.thebtn.BorderThickness = 2;
            this.thebtn.CheckedState.Parent = this.thebtn;
            this.thebtn.CustomImages.Parent = this.thebtn;
            this.thebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thebtn.DisabledState.Parent = this.thebtn;
            this.thebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.thebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thebtn.ForeColor = System.Drawing.Color.White;
            this.thebtn.HoverState.Parent = this.thebtn;
            this.thebtn.Location = new System.Drawing.Point(487, 82);
            this.thebtn.Name = "thebtn";
            this.thebtn.ShadowDecoration.Parent = this.thebtn;
            this.thebtn.Size = new System.Drawing.Size(99, 29);
            this.thebtn.TabIndex = 2;
            this.thebtn.Text = "soon";
            // 
            // uninstallbtn
            // 
            this.uninstallbtn.BorderThickness = 2;
            this.uninstallbtn.CheckedState.Parent = this.uninstallbtn;
            this.uninstallbtn.CustomImages.Parent = this.uninstallbtn;
            this.uninstallbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.uninstallbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.uninstallbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.uninstallbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.uninstallbtn.DisabledState.Parent = this.uninstallbtn;
            this.uninstallbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.uninstallbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.uninstallbtn.ForeColor = System.Drawing.Color.White;
            this.uninstallbtn.HoverState.Parent = this.uninstallbtn;
            this.uninstallbtn.Location = new System.Drawing.Point(487, 117);
            this.uninstallbtn.Name = "uninstallbtn";
            this.uninstallbtn.ShadowDecoration.Parent = this.uninstallbtn;
            this.uninstallbtn.Size = new System.Drawing.Size(99, 29);
            this.uninstallbtn.TabIndex = 3;
            this.uninstallbtn.Text = "Uninstall";
            this.uninstallbtn.Click += new System.EventHandler(this.uninstallbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Visual Studio 2021";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(192, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "1.0";
            // 
            // TIEDOTEPANEL
            // 
            this.TIEDOTEPANEL.BorderColor = System.Drawing.Color.Black;
            this.TIEDOTEPANEL.BorderThickness = 2;
            this.TIEDOTEPANEL.Location = new System.Drawing.Point(647, 126);
            this.TIEDOTEPANEL.Name = "TIEDOTEPANEL";
            this.TIEDOTEPANEL.ShadowDecoration.Parent = this.TIEDOTEPANEL;
            this.TIEDOTEPANEL.Size = new System.Drawing.Size(360, 429);
            this.TIEDOTEPANEL.TabIndex = 7;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Location = new System.Drawing.Point(647, 560);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(360, 100);
            this.guna2Panel2.TabIndex = 8;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.Transparent;
            this.exitbtn.CheckedState.Parent = this.exitbtn;
            this.exitbtn.CustomImages.Parent = this.exitbtn;
            this.exitbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitbtn.DisabledState.Parent = this.exitbtn;
            this.exitbtn.FillColor = System.Drawing.Color.Transparent;
            this.exitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exitbtn.ForeColor = System.Drawing.Color.White;
            this.exitbtn.HoverState.Parent = this.exitbtn;
            this.exitbtn.Location = new System.Drawing.Point(956, 12);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.ShadowDecoration.Parent = this.exitbtn;
            this.exitbtn.Size = new System.Drawing.Size(51, 45);
            this.exitbtn.TabIndex = 9;
            this.exitbtn.Text = "X";
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // minimizebtn
            // 
            this.minimizebtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizebtn.CheckedState.Parent = this.minimizebtn;
            this.minimizebtn.CustomImages.Parent = this.minimizebtn;
            this.minimizebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.minimizebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.minimizebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.minimizebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.minimizebtn.DisabledState.Parent = this.minimizebtn;
            this.minimizebtn.FillColor = System.Drawing.Color.Transparent;
            this.minimizebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizebtn.ForeColor = System.Drawing.Color.White;
            this.minimizebtn.HoverState.Parent = this.minimizebtn;
            this.minimizebtn.Location = new System.Drawing.Point(899, 12);
            this.minimizebtn.Name = "minimizebtn";
            this.minimizebtn.ShadowDecoration.Parent = this.minimizebtn;
            this.minimizebtn.Size = new System.Drawing.Size(51, 45);
            this.minimizebtn.TabIndex = 10;
            this.minimizebtn.Text = "-";
            this.minimizebtn.Click += new System.EventHandler(this.minimizebtn_Click);
            // 
            // aikakello
            // 
            this.aikakello.Interval = 50;
            this.aikakello.Tick += new System.EventHandler(this.aikakello_Tick);
            // 
            // latausbar
            // 
            this.latausbar.BorderThickness = 2;
            this.latausbar.Location = new System.Drawing.Point(14, 116);
            this.latausbar.Name = "latausbar";
            this.latausbar.ProgressColor = System.Drawing.Color.Red;
            this.latausbar.ProgressColor2 = System.Drawing.Color.Blue;
            this.latausbar.ShadowDecoration.Parent = this.latausbar;
            this.latausbar.Size = new System.Drawing.Size(467, 30);
            this.latausbar.TabIndex = 9;
            this.latausbar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // installlabel
            // 
            this.installlabel.AutoSize = true;
            this.installlabel.BackColor = System.Drawing.Color.Transparent;
            this.installlabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.installlabel.ForeColor = System.Drawing.Color.White;
            this.installlabel.Location = new System.Drawing.Point(227, 100);
            this.installlabel.Name = "installlabel";
            this.installlabel.Size = new System.Drawing.Size(70, 13);
            this.installlabel.TabIndex = 10;
            this.installlabel.Text = "INSTALLING";
            // 
            // deletingfiles
            // 
            this.deletingfiles.Interval = 50;
            this.deletingfiles.Tick += new System.EventHandler(this.deletingfiles_Tick);
            // 
            // installui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1019, 672);
            this.Controls.Add(this.minimizebtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.TIEDOTEPANEL);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "installui";
            this.Text = "installui";
            this.Load += new System.EventHandler(this.installui_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button uninstallbtn;
        private Guna.UI2.WinForms.Guna2Button thebtn;
        private Guna.UI2.WinForms.Guna2Button secbtn;
        private Guna.UI2.WinForms.Guna2Button installbtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel TIEDOTEPANEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button exitbtn;
        private Guna.UI2.WinForms.Guna2Button minimizebtn;
        private System.Windows.Forms.Timer aikakello;
        private Guna.UI2.WinForms.Guna2ProgressBar latausbar;
        private System.Windows.Forms.Label installlabel;
        private System.Windows.Forms.Timer deletingfiles;
    }
}