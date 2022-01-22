namespace Vaccination_System
{
    partial class Registration2
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
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.close = new FontAwesome.Sharp.IconButton();
            this.registration = new FontAwesome.Sharp.IconButton();
            this.Teenager = new FontAwesome.Sharp.IconButton();
            this.adult = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.back = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 36);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registration2_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(251, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Covid-19 Vaccination System";
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
            this.iconButton1.Location = new System.Drawing.Point(711, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(44, 28);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.close.Location = new System.Drawing.Point(741, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(44, 28);
            this.close.TabIndex = 3;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.MistyRose;
            this.registration.Cursor = System.Windows.Forms.Cursors.Default;
            this.registration.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.registration.FlatAppearance.BorderSize = 0;
            this.registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.registration.IconChar = FontAwesome.Sharp.IconChar.Child;
            this.registration.IconColor = System.Drawing.Color.Black;
            this.registration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registration.IconSize = 25;
            this.registration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registration.Location = new System.Drawing.Point(327, 105);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(151, 35);
            this.registration.TabIndex = 7;
            this.registration.Text = "Child";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // Teenager
            // 
            this.Teenager.BackColor = System.Drawing.Color.MistyRose;
            this.Teenager.Cursor = System.Windows.Forms.Cursors.Default;
            this.Teenager.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.Teenager.FlatAppearance.BorderSize = 0;
            this.Teenager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teenager.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teenager.ForeColor = System.Drawing.Color.DarkCyan;
            this.Teenager.IconChar = FontAwesome.Sharp.IconChar.Child;
            this.Teenager.IconColor = System.Drawing.Color.Black;
            this.Teenager.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Teenager.IconSize = 25;
            this.Teenager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Teenager.Location = new System.Drawing.Point(327, 161);
            this.Teenager.Name = "Teenager";
            this.Teenager.Size = new System.Drawing.Size(151, 35);
            this.Teenager.TabIndex = 8;
            this.Teenager.Text = "Teenager";
            this.Teenager.UseVisualStyleBackColor = false;
            // 
            // adult
            // 
            this.adult.BackColor = System.Drawing.Color.MistyRose;
            this.adult.Cursor = System.Windows.Forms.Cursors.Default;
            this.adult.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.adult.FlatAppearance.BorderSize = 0;
            this.adult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adult.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adult.ForeColor = System.Drawing.Color.Crimson;
            this.adult.IconChar = FontAwesome.Sharp.IconChar.User;
            this.adult.IconColor = System.Drawing.Color.Black;
            this.adult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adult.IconSize = 25;
            this.adult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adult.Location = new System.Drawing.Point(327, 218);
            this.adult.Name = "adult";
            this.adult.Size = new System.Drawing.Size(151, 35);
            this.adult.TabIndex = 9;
            this.adult.Text = "Adult";
            this.adult.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(181, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registration :\r\n";
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.MistyRose;
            this.back.Cursor = System.Windows.Forms.Cursors.Default;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.back.IconColor = System.Drawing.Color.Black;
            this.back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.back.IconSize = 25;
            this.back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back.Location = new System.Drawing.Point(554, 159);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 37);
            this.back.TabIndex = 11;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Registration2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(783, 319);
            this.Controls.Add(this.back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.adult);
            this.Controls.Add(this.Teenager);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registration2_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton registration;
        private FontAwesome.Sharp.IconButton Teenager;
        private FontAwesome.Sharp.IconButton adult;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton back;
    }
}