namespace Vaccination_System
{
    partial class teenager_option
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.close = new FontAwesome.Sharp.IconButton();
            this.registration = new FontAwesome.Sharp.IconButton();
            this.update = new FontAwesome.Sharp.IconButton();
            this.back = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.minimize);
            this.panel2.Controls.Add(this.close);
            this.panel2.Location = new System.Drawing.Point(-1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 36);
            this.panel2.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(250, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Covid-19 Vaccination System";
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
            this.minimize.Location = new System.Drawing.Point(711, 3);
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
            this.registration.Location = new System.Drawing.Point(322, 90);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(182, 47);
            this.registration.TabIndex = 26;
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
            this.update.Location = new System.Drawing.Point(322, 159);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(182, 47);
            this.update.TabIndex = 27;
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
            this.back.Location = new System.Drawing.Point(322, 227);
            this.back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(182, 45);
            this.back.TabIndex = 28;
            this.back.Text = "Go Back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // teenager_option
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(783, 319);
            this.Controls.Add(this.back);
            this.Controls.Add(this.update);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teenager_option";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton minimize;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton registration;
        private FontAwesome.Sharp.IconButton update;
        private FontAwesome.Sharp.IconButton back;
    }
}