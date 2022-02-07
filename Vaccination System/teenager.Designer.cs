namespace Vaccination_System
{
    partial class teenager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.radiobuttonmale = new System.Windows.Forms.RadioButton();
            this.radiobuttonfemale = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.fnid = new System.Windows.Forms.TextBox();
            this.mnid = new System.Windows.Forms.TextBox();
            this.pnum = new System.Windows.Forms.TextBox();
            this.birthnum = new System.Windows.Forms.TextBox();
            this.register = new FontAwesome.Sharp.IconButton();
            this.back = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 60);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.teenager_MouseDown);
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
            this.close.Location = new System.Drawing.Point(901, 19);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 28);
            this.close.TabIndex = 7;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 4;
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
            this.minimize.Location = new System.Drawing.Point(865, 20);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(44, 28);
            this.minimize.TabIndex = 6;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // radiobuttonmale
            // 
            this.radiobuttonmale.AutoSize = true;
            this.radiobuttonmale.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonmale.Location = new System.Drawing.Point(638, 278);
            this.radiobuttonmale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiobuttonmale.Name = "radiobuttonmale";
            this.radiobuttonmale.Size = new System.Drawing.Size(53, 19);
            this.radiobuttonmale.TabIndex = 19;
            this.radiobuttonmale.TabStop = true;
            this.radiobuttonmale.Text = "Male";
            this.radiobuttonmale.UseVisualStyleBackColor = true;
            // 
            // radiobuttonfemale
            // 
            this.radiobuttonfemale.AutoSize = true;
            this.radiobuttonfemale.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonfemale.Location = new System.Drawing.Point(699, 278);
            this.radiobuttonfemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiobuttonfemale.Name = "radiobuttonfemale";
            this.radiobuttonfemale.Size = new System.Drawing.Size(67, 19);
            this.radiobuttonfemale.TabIndex = 20;
            this.radiobuttonfemale.TabStop = true;
            this.radiobuttonfemale.Text = "Female";
            this.radiobuttonfemale.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Name :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Father\'s Name :\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Mother\'s Name :\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 249);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Father\'s NID :\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(453, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Mother\'s NID :\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(453, 171);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Parent\'s Number : \r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(453, 210);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Birth Certificate Number : \r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(453, 278);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 29;
            this.label8.Text = "Gender :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(329, 72);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(298, 23);
            this.label10.TabIndex = 30;
            this.label10.Text = "Registration for Teenager (12-18)\r\n";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.SeaShell;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(155, 119);
            this.name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(255, 27);
            this.name.TabIndex = 31;
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.SeaShell;
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fname.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(155, 161);
            this.fname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fname.Multiline = true;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(255, 27);
            this.fname.TabIndex = 32;
            // 
            // mname
            // 
            this.mname.BackColor = System.Drawing.Color.SeaShell;
            this.mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mname.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname.Location = new System.Drawing.Point(155, 202);
            this.mname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mname.Multiline = true;
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(255, 27);
            this.mname.TabIndex = 33;
            // 
            // fnid
            // 
            this.fnid.BackColor = System.Drawing.Color.SeaShell;
            this.fnid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnid.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnid.Location = new System.Drawing.Point(155, 245);
            this.fnid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fnid.Multiline = true;
            this.fnid.Name = "fnid";
            this.fnid.Size = new System.Drawing.Size(255, 27);
            this.fnid.TabIndex = 34;
            this.fnid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intcheck);
            // 
            // mnid
            // 
            this.mnid.BackColor = System.Drawing.Color.SeaShell;
            this.mnid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mnid.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnid.Location = new System.Drawing.Point(638, 123);
            this.mnid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mnid.Multiline = true;
            this.mnid.Name = "mnid";
            this.mnid.Size = new System.Drawing.Size(255, 27);
            this.mnid.TabIndex = 35;
            this.mnid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intcheck);
            // 
            // pnum
            // 
            this.pnum.BackColor = System.Drawing.Color.SeaShell;
            this.pnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnum.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnum.Location = new System.Drawing.Point(638, 165);
            this.pnum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnum.Multiline = true;
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(255, 27);
            this.pnum.TabIndex = 36;
            this.pnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intcheck);
            // 
            // birthnum
            // 
            this.birthnum.BackColor = System.Drawing.Color.SeaShell;
            this.birthnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthnum.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthnum.Location = new System.Drawing.Point(638, 206);
            this.birthnum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.birthnum.Multiline = true;
            this.birthnum.Name = "birthnum";
            this.birthnum.Size = new System.Drawing.Size(255, 27);
            this.birthnum.TabIndex = 37;
            this.birthnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intcheck);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.Snow;
            this.register.Cursor = System.Windows.Forms.Cursors.Default;
            this.register.FlatAppearance.BorderColor = System.Drawing.Color.YellowGreen;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.Color.ForestGreen;
            this.register.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.register.IconColor = System.Drawing.Color.ForestGreen;
            this.register.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.register.IconSize = 23;
            this.register.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.register.Location = new System.Drawing.Point(491, 374);
            this.register.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(152, 45);
            this.register.TabIndex = 38;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Snow;
            this.back.Cursor = System.Windows.Forms.Cursors.Default;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Crimson;
            this.back.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.back.IconColor = System.Drawing.Color.Crimson;
            this.back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.back.IconSize = 23;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(316, 374);
            this.back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(152, 45);
            this.back.TabIndex = 39;
            this.back.Text = "Go Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(453, 236);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(465, 18);
            this.label11.TabIndex = 40;
            this.label11.Text = "Note : If you do not have birth certificate please leave this field blank";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(498, 257);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(324, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "You must enter birth certificate number later on\r\n";
            // 
            // teenager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(947, 468);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.back);
            this.Controls.Add(this.register);
            this.Controls.Add(this.birthnum);
            this.Controls.Add(this.pnum);
            this.Controls.Add(this.mnid);
            this.Controls.Add(this.fnid);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.radiobuttonfemale);
            this.Controls.Add(this.radiobuttonmale);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teenager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teenager";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.teenager_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton minimize;
        private FontAwesome.Sharp.IconButton close;
        private System.Windows.Forms.RadioButton radiobuttonmale;
        private System.Windows.Forms.RadioButton radiobuttonfemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox fnid;
        private System.Windows.Forms.TextBox mnid;
        private System.Windows.Forms.TextBox pnum;
        private System.Windows.Forms.TextBox birthnum;
        private FontAwesome.Sharp.IconButton register;
        private FontAwesome.Sharp.IconButton back;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}