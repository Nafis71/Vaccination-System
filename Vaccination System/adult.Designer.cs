namespace Vaccination_System
{
    partial class adult
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radiobuttonmale = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.toppanel = new System.Windows.Forms.Panel();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.close = new FontAwesome.Sharp.IconButton();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Covid-19 Vaccination System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(390, 67);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(478, 29);
            this.label10.TabIndex = 31;
            this.label10.Text = "Registration for Adult (18 years and above)\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(503, 73);
            this.label2.TabIndex = 32;
            this.label2.Text = "Select one of the following options :\r\n\r\n";
            // 
            // radiobuttonmale
            // 
            this.radiobuttonmale.AutoSize = true;
            this.radiobuttonmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonmale.Location = new System.Drawing.Point(76, 194);
            this.radiobuttonmale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiobuttonmale.Name = "radiobuttonmale";
            this.radiobuttonmale.Size = new System.Drawing.Size(546, 29);
            this.radiobuttonmale.TabIndex = 33;
            this.radiobuttonmale.TabStop = true;
            this.radiobuttonmale.Text = "I will register with either NID or Birth certificate or both";
            this.radiobuttonmale.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(76, 237);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(379, 29);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "I do not have NID or Birth Certificate";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 294);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1070, 109);
            this.label3.TabIndex = 35;
            this.label3.Text = "If you register with the second option, make sure you enter your NID and birth \r\n" +
    "certificate number later on when you will get them. This is a crucial step.\r\n\r\n";
            // 
            // toppanel
            // 
            this.toppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppanel.Controls.Add(this.close);
            this.toppanel.Controls.Add(this.minimize);
            this.toppanel.Controls.Add(this.label4);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1270, 57);
            this.toppanel.TabIndex = 36;
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
            this.minimize.Location = new System.Drawing.Point(1177, -1);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(51, 32);
            this.minimize.TabIndex = 5;
            this.minimize.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(414, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Covid-19 Vaccination System";
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
            this.close.Location = new System.Drawing.Point(1214, 3);
            this.close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(51, 32);
            this.close.TabIndex = 4;
            this.close.UseVisualStyleBackColor = true;
            // 
            // adult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.radiobuttonmale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Name = "adult";
            this.Size = new System.Drawing.Size(1270, 571);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radiobuttonmale;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel toppanel;
        private FontAwesome.Sharp.IconButton minimize;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton close;
    }
}
