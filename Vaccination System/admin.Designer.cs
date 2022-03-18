namespace Vaccination_System
{
    partial class admin
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signout = new FontAwesome.Sharp.IconButton();
            this.close = new FontAwesome.Sharp.IconButton();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.centermanage = new FontAwesome.Sharp.IconButton();
            this.vacmanage = new FontAwesome.Sharp.IconButton();
            this.dash = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(200, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(795, 581);
            this.panel4.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.signout);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 48);
            this.panel2.TabIndex = 7;
            // 
            // signout
            // 
            this.signout.FlatAppearance.BorderSize = 0;
            this.signout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.signout.IconColor = System.Drawing.Color.IndianRed;
            this.signout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.signout.IconSize = 30;
            this.signout.Location = new System.Drawing.Point(627, 18);
            this.signout.Name = "signout";
            this.signout.Size = new System.Drawing.Size(75, 23);
            this.signout.TabIndex = 7;
            this.signout.UseVisualStyleBackColor = true;
            this.signout.Click += new System.EventHandler(this.signout_Click);
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
            this.close.Location = new System.Drawing.Point(746, 14);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 28);
            this.close.TabIndex = 4;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
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
            this.minimize.Location = new System.Drawing.Point(708, 14);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(44, 28);
            this.minimize.TabIndex = 5;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title.Location = new System.Drawing.Point(327, 12);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(87, 19);
            this.title.TabIndex = 0;
            this.title.Text = "Dashboard";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.panel3.Controls.Add(this.iconButton2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(-1, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 53);
            this.panel3.TabIndex = 2;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.Black;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Viruses;
            this.iconButton2.IconColor = System.Drawing.Color.Firebrick;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 55;
            this.iconButton2.Location = new System.Drawing.Point(0, -4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(200, 45);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "-------------------------------------------";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.centermanage);
            this.panel1.Controls.Add(this.vacmanage);
            this.panel1.Controls.Add(this.dash);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 629);
            this.panel1.TabIndex = 6;
            // 
            // centermanage
            // 
            this.centermanage.BackColor = System.Drawing.Color.Transparent;
            this.centermanage.FlatAppearance.BorderSize = 0;
            this.centermanage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.centermanage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.centermanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.centermanage.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.centermanage.ForeColor = System.Drawing.Color.Black;
            this.centermanage.IconChar = FontAwesome.Sharp.IconChar.Building;
            this.centermanage.IconColor = System.Drawing.Color.Firebrick;
            this.centermanage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.centermanage.IconSize = 30;
            this.centermanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.centermanage.Location = new System.Drawing.Point(0, 273);
            this.centermanage.Name = "centermanage";
            this.centermanage.Size = new System.Drawing.Size(200, 49);
            this.centermanage.TabIndex = 13;
            this.centermanage.Text = "    Center Management";
            this.centermanage.UseVisualStyleBackColor = false;
            this.centermanage.Click += new System.EventHandler(this.centermanage_Click);
            // 
            // vacmanage
            // 
            this.vacmanage.BackColor = System.Drawing.Color.Transparent;
            this.vacmanage.FlatAppearance.BorderSize = 0;
            this.vacmanage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.vacmanage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.vacmanage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vacmanage.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vacmanage.ForeColor = System.Drawing.Color.Black;
            this.vacmanage.IconChar = FontAwesome.Sharp.IconChar.Syringe;
            this.vacmanage.IconColor = System.Drawing.Color.Firebrick;
            this.vacmanage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.vacmanage.IconSize = 30;
            this.vacmanage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vacmanage.Location = new System.Drawing.Point(0, 365);
            this.vacmanage.Name = "vacmanage";
            this.vacmanage.Size = new System.Drawing.Size(200, 49);
            this.vacmanage.TabIndex = 11;
            this.vacmanage.Text = "      Vaccine Management";
            this.vacmanage.UseVisualStyleBackColor = false;
            this.vacmanage.Click += new System.EventHandler(this.vacmanage_Click);
            // 
            // dash
            // 
            this.dash.BackColor = System.Drawing.Color.Transparent;
            this.dash.FlatAppearance.BorderSize = 0;
            this.dash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.dash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash.ForeColor = System.Drawing.Color.Black;
            this.dash.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.dash.IconColor = System.Drawing.Color.Firebrick;
            this.dash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dash.IconSize = 30;
            this.dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash.Location = new System.Drawing.Point(0, 180);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(200, 49);
            this.dash.TabIndex = 9;
            this.dash.Text = "Dashboard";
            this.dash.UseVisualStyleBackColor = false;
            this.dash.Click += new System.EventHandler(this.dash_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(995, 629);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton signout;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton minimize;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton centermanage;
        private FontAwesome.Sharp.IconButton vacmanage;
        private FontAwesome.Sharp.IconButton dash;
    }
}