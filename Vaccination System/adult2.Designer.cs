namespace Vaccination_System
{
    partial class adult2
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
            this.toppanel = new System.Windows.Forms.Panel();
            this.close = new FontAwesome.Sharp.IconButton();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toppanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppanel.Controls.Add(this.close);
            this.toppanel.Controls.Add(this.minimize);
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1351, 57);
            this.toppanel.TabIndex = 39;
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
            this.close.Location = new System.Drawing.Point(1294, 3);
            this.close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(51, 32);
            this.close.TabIndex = 4;
            this.close.UseVisualStyleBackColor = true;
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
            this.minimize.Location = new System.Drawing.Point(1253, 2);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(51, 32);
            this.minimize.TabIndex = 5;
            this.minimize.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(377, 71);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(478, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "Registration for Adult (18 years and above)\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "Covid-19 Vaccination System";
            // 
            // adult2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.Controls.Add(this.toppanel);
            this.Controls.Add(this.label10);
            this.Name = "adult2";
            this.Size = new System.Drawing.Size(1351, 671);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private FontAwesome.Sharp.IconButton close;
        private FontAwesome.Sharp.IconButton minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
    }
}
