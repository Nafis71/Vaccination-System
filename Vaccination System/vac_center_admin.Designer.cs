namespace Vaccination_System
{
    partial class vac_center_admin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.hid = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new FontAwesome.Sharp.IconButton();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.teenagervac = new FontAwesome.Sharp.IconButton();
            this.adultvac = new FontAwesome.Sharp.IconButton();
            this.dash = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.childvac1 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.childvac1);
            this.panel1.Controls.Add(this.teenagervac);
            this.panel1.Controls.Add(this.adultvac);
            this.panel1.Controls.Add(this.dash);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 629);
            this.panel1.TabIndex = 0;
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
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(219)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.hid);
            this.panel2.Controls.Add(this.close);
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 48);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // hid
            // 
            this.hid.AutoSize = true;
            this.hid.Location = new System.Drawing.Point(7, 18);
            this.hid.Name = "hid";
            this.hid.Size = new System.Drawing.Size(35, 13);
            this.hid.TabIndex = 6;
            this.hid.Text = "label1";
            this.hid.Visible = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.Desktop;
            this.title.Location = new System.Drawing.Point(349, 14);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(87, 19);
            this.title.TabIndex = 0;
            this.title.Text = "Dashboard";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(795, 581);
            this.panel4.TabIndex = 2;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // timer1
            // 
            this.timer1.Interval = 45;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(241, 233);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(313, 26);
            this.progressBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Creating Session...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(466, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "i";
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
            // teenagervac
            // 
            this.teenagervac.BackColor = System.Drawing.Color.Transparent;
            this.teenagervac.FlatAppearance.BorderSize = 0;
            this.teenagervac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.teenagervac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.teenagervac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teenagervac.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teenagervac.ForeColor = System.Drawing.Color.Black;
            this.teenagervac.IconChar = FontAwesome.Sharp.IconChar.Crutch;
            this.teenagervac.IconColor = System.Drawing.SystemColors.Highlight;
            this.teenagervac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.teenagervac.IconSize = 30;
            this.teenagervac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.teenagervac.Location = new System.Drawing.Point(-1, 379);
            this.teenagervac.Name = "teenagervac";
            this.teenagervac.Size = new System.Drawing.Size(200, 49);
            this.teenagervac.TabIndex = 12;
            this.teenagervac.Text = "       Teenager Vaccination";
            this.teenagervac.UseVisualStyleBackColor = false;
            // 
            // adultvac
            // 
            this.adultvac.BackColor = System.Drawing.Color.Transparent;
            this.adultvac.FlatAppearance.BorderSize = 0;
            this.adultvac.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.adultvac.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.adultvac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adultvac.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultvac.ForeColor = System.Drawing.Color.Black;
            this.adultvac.IconChar = FontAwesome.Sharp.IconChar.Crutch;
            this.adultvac.IconColor = System.Drawing.SystemColors.Highlight;
            this.adultvac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adultvac.IconSize = 30;
            this.adultvac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adultvac.Location = new System.Drawing.Point(0, 303);
            this.adultvac.Name = "adultvac";
            this.adultvac.Size = new System.Drawing.Size(200, 49);
            this.adultvac.TabIndex = 11;
            this.adultvac.Text = "    Adult Vaccination";
            this.adultvac.UseVisualStyleBackColor = false;
            // 
            // dash
            // 
            this.dash.BackColor = System.Drawing.Color.Transparent;
            this.dash.FlatAppearance.BorderSize = 0;
            this.dash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.dash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.dash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dash.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dash.ForeColor = System.Drawing.Color.Black;
            this.dash.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            this.dash.IconColor = System.Drawing.SystemColors.Highlight;
            this.dash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.dash.IconSize = 30;
            this.dash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dash.Location = new System.Drawing.Point(-1, 154);
            this.dash.Name = "dash";
            this.dash.Size = new System.Drawing.Size(200, 49);
            this.dash.TabIndex = 9;
            this.dash.Text = "Dashboard";
            this.dash.UseVisualStyleBackColor = false;
            this.dash.Click += new System.EventHandler(this.dash_Click);
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
            this.iconButton2.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 55;
            this.iconButton2.Location = new System.Drawing.Point(0, -4);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(200, 45);
            this.iconButton2.TabIndex = 11;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // childvac1
            // 
            this.childvac1.BackColor = System.Drawing.Color.Transparent;
            this.childvac1.FlatAppearance.BorderSize = 0;
            this.childvac1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.childvac1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(173)))), ((int)(((byte)(226)))));
            this.childvac1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.childvac1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childvac1.ForeColor = System.Drawing.Color.Black;
            this.childvac1.IconChar = FontAwesome.Sharp.IconChar.Crutch;
            this.childvac1.IconColor = System.Drawing.SystemColors.Highlight;
            this.childvac1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.childvac1.IconSize = 30;
            this.childvac1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.childvac1.Location = new System.Drawing.Point(0, 229);
            this.childvac1.Name = "childvac1";
            this.childvac1.Size = new System.Drawing.Size(200, 49);
            this.childvac1.TabIndex = 13;
            this.childvac1.Text = "    Child Vaccination";
            this.childvac1.UseVisualStyleBackColor = false;
            this.childvac1.Click += new System.EventHandler(this.childvac1_Click);
            // 
            // vac_center_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(995, 629);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vac_center_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vac_center_admin";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton minimize;
        private FontAwesome.Sharp.IconButton close;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label hid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton dash;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton teenagervac;
        private FontAwesome.Sharp.IconButton adultvac;
        private FontAwesome.Sharp.IconButton childvac1;
    }
}