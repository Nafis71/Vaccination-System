namespace Vaccination_System
{
    partial class vac_center_adminlogin
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
            this.back = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.login = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.close = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Snow;
            this.back.Cursor = System.Windows.Forms.Cursors.Default;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.DarkOrange;
            this.back.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.back.IconColor = System.Drawing.Color.Orange;
            this.back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.back.IconSize = 23;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(30, 262);
            this.back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(136, 35);
            this.back.TabIndex = 39;
            this.back.Text = "Go Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 38;
            this.label2.Text = "Vaccine Center Admin Login Panel";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Snow;
            this.login.Cursor = System.Windows.Forms.Cursors.Default;
            this.login.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.Color.DarkOrange;
            this.login.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.login.IconColor = System.Drawing.Color.Orange;
            this.login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.login.IconSize = 23;
            this.login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.login.Location = new System.Drawing.Point(542, 161);
            this.login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(136, 35);
            this.login.TabIndex = 37;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(270, 114);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 36;
            this.label10.Text = "Center ID :";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.Color.Snow;
            this.id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(274, 137);
            this.id.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.id.Multiline = true;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(249, 23);
            this.id.TabIndex = 35;
            this.id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intcheck);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 36);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Covid-19 Vaccination System";
            // 
            // minimize
            // 
            this.minimize.FlatAppearance.BorderSize = 0;
            this.minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.ForeColor = System.Drawing.Color.IndianRed;
            this.minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize.IconColor = System.Drawing.Color.IndianRed;
            this.minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize.IconSize = 25;
            this.minimize.Location = new System.Drawing.Point(689, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(44, 28);
            this.minimize.TabIndex = 4;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
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
            this.close.Location = new System.Drawing.Point(726, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 28);
            this.close.TabIndex = 3;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Password :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pass
            // 
            this.pass.BackColor = System.Drawing.Color.Snow;
            this.pass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pass.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(274, 191);
            this.pass.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(249, 23);
            this.pass.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "Show Password";
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(411, 217);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(15, 14);
            this.showpass.TabIndex = 43;
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // vac_center_adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(768, 319);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.id);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vac_center_adminlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vac_center_admin_login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton back;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton login;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton minimize;
        private FontAwesome.Sharp.IconButton close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox showpass;
    }
}