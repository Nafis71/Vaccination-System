namespace Vaccination_System
{
    partial class home
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
            this.label1 = new System.Windows.Forms.Label();
            this.close = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.titlebar = new System.Windows.Forms.Panel();
            this.animate = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.registration = new FontAwesome.Sharp.IconButton();
            this.regcard = new FontAwesome.Sharp.IconButton();
            this.login1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.certificate = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.titlebar.SuspendLayout();
            this.animate.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Covid-19 Vaccination System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.IndianRed;
            this.close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.close.IconColor = System.Drawing.Color.IndianRed;
            this.close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close.IconSize = 25;
            this.close.Location = new System.Drawing.Point(755, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 28);
            this.close.TabIndex = 2;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.IndianRed;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconButton1.IconColor = System.Drawing.Color.IndianRed;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(723, 6);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 28);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // titlebar
            // 
            this.titlebar.AutoSize = true;
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.titlebar.Controls.Add(this.label1);
            this.titlebar.Controls.Add(this.animate);
            this.titlebar.Controls.Add(this.iconButton1);
            this.titlebar.Controls.Add(this.close);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(799, 340);
            this.titlebar.TabIndex = 5;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            // 
            // animate
            // 
            this.animate.BackColor = System.Drawing.Color.LightGray;
            this.animate.Controls.Add(this.label2);
            this.animate.Location = new System.Drawing.Point(3, 38);
            this.animate.Name = "animate";
            this.animate.Size = new System.Drawing.Size(11, 44);
            this.animate.TabIndex = 11;
            this.animate.Paint += new System.Windows.Forms.PaintEventHandler(this.animate_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(135, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label2.Size = new System.Drawing.Size(541, 34);
            this.label2.TabIndex = 10;
            this.label2.Text = "Please wear mask and maintain physical distance\r\n";
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.Gainsboro;
            this.registration.Cursor = System.Windows.Forms.Cursors.Default;
            this.registration.FlatAppearance.BorderColor = System.Drawing.Color.DarkSalmon;
            this.registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.registration.IconColor = System.Drawing.Color.Black;
            this.registration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registration.IconSize = 25;
            this.registration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registration.Location = new System.Drawing.Point(324, 35);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(174, 35);
            this.registration.TabIndex = 6;
            this.registration.Text = "  Registration";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // regcard
            // 
            this.regcard.AutoSize = true;
            this.regcard.BackColor = System.Drawing.Color.Gainsboro;
            this.regcard.Cursor = System.Windows.Forms.Cursors.Default;
            this.regcard.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.regcard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regcard.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regcard.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.regcard.IconColor = System.Drawing.Color.Black;
            this.regcard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.regcard.IconSize = 25;
            this.regcard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.regcard.Location = new System.Drawing.Point(324, 85);
            this.regcard.Name = "regcard";
            this.regcard.Size = new System.Drawing.Size(174, 37);
            this.regcard.TabIndex = 7;
            this.regcard.Text = "REG CARD";
            this.regcard.UseVisualStyleBackColor = false;
            // 
            // login1
            // 
            this.login1.AutoSize = true;
            this.login1.BackColor = System.Drawing.Color.Gainsboro;
            this.login1.Cursor = System.Windows.Forms.Cursors.Default;
            this.login1.FlatAppearance.BorderColor = System.Drawing.Color.SkyBlue;
            this.login1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login1.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.login1.IconColor = System.Drawing.Color.Black;
            this.login1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.login1.IconSize = 25;
            this.login1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login1.Location = new System.Drawing.Point(324, 189);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(174, 37);
            this.login1.TabIndex = 9;
            this.login1.Text = "Login";
            this.login1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.panel1.Controls.Add(this.certificate);
            this.panel1.Controls.Add(this.registration);
            this.panel1.Controls.Add(this.login1);
            this.panel1.Controls.Add(this.regcard);
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 259);
            this.panel1.TabIndex = 10;
            // 
            // certificate
            // 
            this.certificate.AutoSize = true;
            this.certificate.BackColor = System.Drawing.Color.Gainsboro;
            this.certificate.Cursor = System.Windows.Forms.Cursors.Default;
            this.certificate.FlatAppearance.BorderColor = System.Drawing.Color.MediumAquamarine;
            this.certificate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.certificate.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.certificate.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.certificate.IconColor = System.Drawing.Color.Black;
            this.certificate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.certificate.IconSize = 25;
            this.certificate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.certificate.Location = new System.Drawing.Point(324, 137);
            this.certificate.Name = "certificate";
            this.certificate.Size = new System.Drawing.Size(174, 37);
            this.certificate.TabIndex = 10;
            this.certificate.Text = "Certificate";
            this.certificate.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 19;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(799, 340);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titlebar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.login_MouseDown);
            this.titlebar.ResumeLayout(false);
            this.titlebar.PerformLayout();
            this.animate.ResumeLayout(false);
            this.animate.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel titlebar;
        private FontAwesome.Sharp.IconButton registration;
        private FontAwesome.Sharp.IconButton regcard;
        private FontAwesome.Sharp.IconButton login1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel animate;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton certificate;
        private System.Windows.Forms.Timer timer1;
    }
}