namespace Vaccination_System
{
    partial class child
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
            this.toppanel = new System.Windows.Forms.Panel();
            this.close = new FontAwesome.Sharp.IconButton();
            this.minimize = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.fnid = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboboxdivision = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.center = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.birthnum = new System.Windows.Forms.TextBox();
            this.radiobuttonfemale = new System.Windows.Forms.RadioButton();
            this.radiobuttonmale = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnum = new System.Windows.Forms.TextBox();
            this.mnid = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.register = new FontAwesome.Sharp.IconButton();
            this.back = new FontAwesome.Sharp.IconButton();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toppanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.toppanel.Size = new System.Drawing.Size(1008, 47);
            this.toppanel.TabIndex = 0;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.child_MouseDown);
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
            this.close.Location = new System.Drawing.Point(956, 5);
            this.close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(51, 32);
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
            this.minimize.Location = new System.Drawing.Point(921, 5);
            this.minimize.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(51, 32);
            this.minimize.TabIndex = 5;
            this.minimize.UseVisualStyleBackColor = true;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Covid-19 Vaccination System";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(384, 61);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(221, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "Registration for Children\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.fnid);
            this.groupBox1.Controls.Add(this.mname);
            this.groupBox1.Controls.Add(this.fname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 254);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Father\'s NID :\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Mother\'s Name :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Father\'s Name :\r\n";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.AntiqueWhite;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(190, 38);
            this.name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(255, 27);
            this.name.TabIndex = 50;
            // 
            // fnid
            // 
            this.fnid.BackColor = System.Drawing.Color.AntiqueWhite;
            this.fnid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fnid.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnid.Location = new System.Drawing.Point(190, 191);
            this.fnid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fnid.Multiline = true;
            this.fnid.Name = "fnid";
            this.fnid.Size = new System.Drawing.Size(255, 27);
            this.fnid.TabIndex = 49;
            this.fnid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intcheck);
            // 
            // mname
            // 
            this.mname.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mname.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mname.Location = new System.Drawing.Point(190, 140);
            this.mname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mname.Multiline = true;
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(255, 27);
            this.mname.TabIndex = 48;
            // 
            // fname
            // 
            this.fname.BackColor = System.Drawing.Color.AntiqueWhite;
            this.fname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fname.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fname.Location = new System.Drawing.Point(190, 90);
            this.fname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fname.Multiline = true;
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(255, 27);
            this.fname.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Child\'s Name :\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboboxdivision);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.center);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.birthnum);
            this.groupBox2.Controls.Add(this.radiobuttonfemale);
            this.groupBox2.Controls.Add(this.radiobuttonmale);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.pnum);
            this.groupBox2.Controls.Add(this.mnid);
            this.groupBox2.Location = new System.Drawing.Point(505, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 317);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // comboboxdivision
            // 
            this.comboboxdivision.BackColor = System.Drawing.Color.AntiqueWhite;
            this.comboboxdivision.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxdivision.FormattingEnabled = true;
            this.comboboxdivision.Items.AddRange(new object[] {
            "Barishal",
            "Chattogram",
            "Dhaka",
            "Khulna",
            "Rajshahi",
            "Rangpur",
            "Mymensingh",
            "Sylhet"});
            this.comboboxdivision.Location = new System.Drawing.Point(213, 193);
            this.comboboxdivision.Name = "comboboxdivision";
            this.comboboxdivision.Size = new System.Drawing.Size(255, 26);
            this.comboboxdivision.TabIndex = 90;
            this.comboboxdivision.SelectedIndexChanged += new System.EventHandler(this.comboboxdivision_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(16, 199);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 17);
            this.label14.TabIndex = 89;
            this.label14.Text = "Choose Division:";
            // 
            // center
            // 
            this.center.BackColor = System.Drawing.Color.AntiqueWhite;
            this.center.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center.FormattingEnabled = true;
            this.center.Location = new System.Drawing.Point(213, 239);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(255, 26);
            this.center.TabIndex = 88;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(16, 245);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 17);
            this.label13.TabIndex = 87;
            this.label13.Text = "Choose a center :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(61, 161);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(324, 18);
            this.label12.TabIndex = 86;
            this.label12.Text = "You must enter birth certificate number later on\r\n";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 143);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(461, 18);
            this.label11.TabIndex = 85;
            this.label11.Text = "Note : If the child has no birthcertificate please leave this field blank";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(16, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 17);
            this.label9.TabIndex = 84;
            this.label9.Text = "Birth Certificate Number : \r\n";
            // 
            // birthnum
            // 
            this.birthnum.BackColor = System.Drawing.Color.AntiqueWhite;
            this.birthnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthnum.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthnum.Location = new System.Drawing.Point(213, 113);
            this.birthnum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.birthnum.Multiline = true;
            this.birthnum.Name = "birthnum";
            this.birthnum.Size = new System.Drawing.Size(255, 27);
            this.birthnum.TabIndex = 83;
            this.birthnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intcheck);
            // 
            // radiobuttonfemale
            // 
            this.radiobuttonfemale.AutoSize = true;
            this.radiobuttonfemale.Location = new System.Drawing.Point(274, 283);
            this.radiobuttonfemale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiobuttonfemale.Name = "radiobuttonfemale";
            this.radiobuttonfemale.Size = new System.Drawing.Size(67, 19);
            this.radiobuttonfemale.TabIndex = 82;
            this.radiobuttonfemale.TabStop = true;
            this.radiobuttonfemale.Text = "Female";
            this.radiobuttonfemale.UseVisualStyleBackColor = true;
            // 
            // radiobuttonmale
            // 
            this.radiobuttonmale.AutoSize = true;
            this.radiobuttonmale.Location = new System.Drawing.Point(213, 283);
            this.radiobuttonmale.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radiobuttonmale.Name = "radiobuttonmale";
            this.radiobuttonmale.Size = new System.Drawing.Size(53, 19);
            this.radiobuttonmale.TabIndex = 81;
            this.radiobuttonmale.TabStop = true;
            this.radiobuttonmale.Text = "Male";
            this.radiobuttonmale.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 285);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 80;
            this.label8.Text = "Gender :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 79;
            this.label7.Text = "Parent\'s Number : \r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 78;
            this.label6.Text = "Mother\'s NID :\r\n";
            // 
            // pnum
            // 
            this.pnum.BackColor = System.Drawing.Color.AntiqueWhite;
            this.pnum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnum.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnum.Location = new System.Drawing.Point(213, 63);
            this.pnum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnum.Multiline = true;
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(255, 27);
            this.pnum.TabIndex = 77;
            this.pnum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intcheck);
            // 
            // mnid
            // 
            this.mnid.BackColor = System.Drawing.Color.AntiqueWhite;
            this.mnid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mnid.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnid.Location = new System.Drawing.Point(213, 15);
            this.mnid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mnid.Multiline = true;
            this.mnid.Name = "mnid";
            this.mnid.Size = new System.Drawing.Size(255, 27);
            this.mnid.TabIndex = 76;
            this.mnid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intcheck);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.register);
            this.groupBox3.Location = new System.Drawing.Point(388, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 100);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
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
            this.register.Location = new System.Drawing.Point(40, 31);
            this.register.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(146, 45);
            this.register.TabIndex = 61;
            this.register.Text = "Register";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click_1);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Cursor = System.Windows.Forms.Cursors.Default;
            this.back.FlatAppearance.BorderColor = System.Drawing.Color.Crimson;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.Crimson;
            this.back.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.back.IconColor = System.Drawing.Color.Crimson;
            this.back.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.back.IconSize = 31;
            this.back.Location = new System.Drawing.Point(916, 53);
            this.back.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(57, 40);
            this.back.TabIndex = 61;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click_1);
            // 
            // progressbar
            // 
            this.progressbar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressbar.Location = new System.Drawing.Point(388, 410);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(231, 23);
            this.progressbar.TabIndex = 62;
            this.progressbar.Click += new System.EventHandler(this.progressbar_Click);
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1008, 536);
            this.Controls.Add(this.progressbar);
            this.Controls.Add(this.back);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.toppanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "child";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "child";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.child_MouseDown);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton minimize;
        private FontAwesome.Sharp.IconButton close;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox fnid;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox center;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox birthnum;
        private System.Windows.Forms.RadioButton radiobuttonfemale;
        private System.Windows.Forms.RadioButton radiobuttonmale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pnum;
        private System.Windows.Forms.TextBox mnid;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton register;
        private FontAwesome.Sharp.IconButton back;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox comboboxdivision;
        private System.Windows.Forms.Label label14;
    }
}