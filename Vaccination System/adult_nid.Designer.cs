namespace Vaccination_System
{
    partial class adult_nid
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
            this.label10 = new System.Windows.Forms.Label();
            this.close = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.center = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radiobuttonmale = new System.Windows.Forms.RadioButton();
            this.radiobuttonfemale = new System.Windows.Forms.RadioButton();
            this.register = new FontAwesome.Sharp.IconButton();
            this.phone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new FontAwesome.Sharp.IconButton();
            this.goback = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 52);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 23);
            this.label10.TabIndex = 58;
            this.label10.Text = "Registration for Adult";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            this.close.Location = new System.Drawing.Point(762, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 28);
            this.close.TabIndex = 7;
            this.close.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 9);
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
            this.minimize.Location = new System.Drawing.Point(712, 9);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(44, 28);
            this.minimize.TabIndex = 6;
            this.minimize.UseVisualStyleBackColor = true;
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
            this.panel1.Size = new System.Drawing.Size(809, 49);
            this.panel1.TabIndex = 47;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.phone);
            this.groupBox1.Controls.Add(this.register);
            this.groupBox1.Controls.Add(this.radiobuttonfemale);
            this.groupBox1.Controls.Add(this.radiobuttonmale);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.center);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nid);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(168, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 380);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.AntiqueWhite;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(178, 43);
            this.name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(255, 27);
            this.name.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 18);
            this.label4.TabIndex = 61;
            this.label4.Text = "Name :\r\n";
            // 
            // nid
            // 
            this.nid.BackColor = System.Drawing.Color.AntiqueWhite;
            this.nid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nid.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nid.Location = new System.Drawing.Point(178, 91);
            this.nid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nid.Multiline = true;
            this.nid.Name = "nid";
            this.nid.Size = new System.Drawing.Size(255, 27);
            this.nid.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 63;
            this.label5.Text = "NID :\r\n";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 18);
            this.label6.TabIndex = 64;
            this.label6.Text = "Choose a center :";
            // 
            // center
            // 
            this.center.BackColor = System.Drawing.Color.AntiqueWhite;
            this.center.FormattingEnabled = true;
            this.center.Location = new System.Drawing.Point(178, 194);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(255, 27);
            this.center.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 66;
            this.label7.Text = "Gender :";
            // 
            // radiobuttonmale
            // 
            this.radiobuttonmale.AutoSize = true;
            this.radiobuttonmale.BackColor = System.Drawing.Color.Transparent;
            this.radiobuttonmale.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonmale.Location = new System.Drawing.Point(178, 255);
            this.radiobuttonmale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiobuttonmale.Name = "radiobuttonmale";
            this.radiobuttonmale.Size = new System.Drawing.Size(62, 23);
            this.radiobuttonmale.TabIndex = 67;
            this.radiobuttonmale.TabStop = true;
            this.radiobuttonmale.Text = "Male";
            this.radiobuttonmale.UseVisualStyleBackColor = false;
            // 
            // radiobuttonfemale
            // 
            this.radiobuttonfemale.AutoSize = true;
            this.radiobuttonfemale.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonfemale.Location = new System.Drawing.Point(261, 255);
            this.radiobuttonfemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiobuttonfemale.Name = "radiobuttonfemale";
            this.radiobuttonfemale.Size = new System.Drawing.Size(79, 23);
            this.radiobuttonfemale.TabIndex = 68;
            this.radiobuttonfemale.TabStop = true;
            this.radiobuttonfemale.Text = "Female";
            this.radiobuttonfemale.UseVisualStyleBackColor = true;
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
            this.register.Location = new System.Drawing.Point(178, 311);
            this.register.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(152, 45);
            this.register.TabIndex = 60;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.AntiqueWhite;
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phone.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.Location = new System.Drawing.Point(178, 144);
            this.phone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.phone.Multiline = true;
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(255, 27);
            this.phone.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Phone Number:\r\n";
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Cursor = System.Windows.Forms.Cursors.Default;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Crimson;
            this.back.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.back.IconColor = System.Drawing.Color.Crimson;
            this.back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.back.IconSize = 23;
            this.back.Location = new System.Drawing.Point(700, 88);
            this.back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 45);
            this.back.TabIndex = 60;
            this.back.UseVisualStyleBackColor = false;
            // 
            // goback
            // 
            this.goback.BackColor = System.Drawing.Color.Transparent;
            this.goback.Cursor = System.Windows.Forms.Cursors.Default;
            this.goback.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.goback.FlatAppearance.BorderSize = 0;
            this.goback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goback.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goback.ForeColor = System.Drawing.Color.Crimson;
            this.goback.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.goback.IconColor = System.Drawing.Color.Crimson;
            this.goback.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.goback.IconSize = 31;
            this.goback.Location = new System.Drawing.Point(700, 88);
            this.goback.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.goback.Name = "goback";
            this.goback.Size = new System.Drawing.Size(57, 45);
            this.goback.TabIndex = 60;
            this.goback.UseVisualStyleBackColor = false;
            // 
            // adult_nid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(809, 480);
            this.Controls.Add(this.goback);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "adult_nid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adult";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton close;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton minimize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobuttonfemale;
        private System.Windows.Forms.RadioButton radiobuttonmale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox center;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone;
        private FontAwesome.Sharp.IconButton register;
        private FontAwesome.Sharp.IconButton back;
        private FontAwesome.Sharp.IconButton goback;
    }
}