namespace Vaccination_System
{
    partial class child_option
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
            this.update = new FontAwesome.Sharp.IconButton();
            this.back = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.close);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 36);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 3);
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
            this.registration.BackColor = System.Drawing.Color.Gainsboro;
            this.registration.Cursor = System.Windows.Forms.Cursors.Default;
            this.registration.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.registration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registration.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.registration.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.registration.IconColor = System.Drawing.Color.Black;
            this.registration.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.registration.IconSize = 29;
            this.registration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registration.Location = new System.Drawing.Point(323, 92);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(182, 47);
            this.registration.TabIndex = 8;
            this.registration.Text = "Registration";
            this.registration.UseVisualStyleBackColor = false;
            this.registration.Click += new System.EventHandler(this.registration_Click);
            // 
            // update
            // 
            this.update.BackColor = System.Drawing.Color.Gainsboro;
            this.update.Cursor = System.Windows.Forms.Cursors.Default;
            this.update.FlatAppearance.BorderColor = System.Drawing.Color.MediumVioletRed;
            this.update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LavenderBlush;
            this.update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.update.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.update.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.update.IconColor = System.Drawing.Color.Black;
            this.update.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.update.IconSize = 29;
            this.update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update.Location = new System.Drawing.Point(323, 161);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(182, 47);
            this.update.TabIndex = 9;
            this.update.Text = "   Update Birth No";
            this.update.UseVisualStyleBackColor = false;
            this.update.Click += new System.EventHandler(this.update_Click);
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
            this.back.Location = new System.Drawing.Point(323, 229);
            this.back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(182, 45);
            this.back.TabIndex = 24;
            this.back.Text = "Go Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // child_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(783, 319);
            this.Controls.Add(this.back);
            this.Controls.Add(this.update);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "child_option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton registration;
        private FontAwesome.Sharp.IconButton update;
        private FontAwesome.Sharp.IconButton back;
    }
}