namespace validationform_task4
{
    partial class Form1
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
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelstate = new System.Windows.Forms.Label();
            this.labelusername = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.labelemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.labelphone = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.labelgender = new System.Windows.Forms.Label();
            this.labelage = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.Labeldob = new System.Windows.Forms.Label();
            this.labellastname = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.labellocation = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.labelconfirmpassword = new System.Windows.Forms.Label();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.labeladdress = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.labeldistrict = new System.Windows.Forms.Label();
            this.btnsignup = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radiobuttonmale = new System.Windows.Forms.RadioButton();
            this.radiobuttonfemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.comboboxstate = new System.Windows.Forms.ComboBox();
            this.comboboxdistrict = new System.Windows.Forms.ComboBox();
            this.buttonsignin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFirstname.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Plum;
            this.txtFirstname.Location = new System.Drawing.Point(201, 108);
            this.txtFirstname.Multiline = true;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(265, 37);
            this.txtFirstname.TabIndex = 0;
            this.txtFirstname.Leave += new System.EventHandler(this.txtFirstname_Leave);
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstname.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelFirstname.Location = new System.Drawing.Point(197, 85);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(83, 20);
            this.labelFirstname.TabIndex = 1;
            this.labelFirstname.Text = "Firstname";
            // 
            // labelstate
            // 
            this.labelstate.AutoSize = true;
            this.labelstate.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelstate.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelstate.Location = new System.Drawing.Point(197, 412);
            this.labelstate.Name = "labelstate";
            this.labelstate.Size = new System.Drawing.Size(47, 20);
            this.labelstate.TabIndex = 3;
            this.labelstate.Text = "State";
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelusername.Location = new System.Drawing.Point(529, 331);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(83, 20);
            this.labelusername.TabIndex = 5;
            this.labelusername.Text = "Username";
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtusername.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtusername.Location = new System.Drawing.Point(533, 354);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(265, 37);
            this.txtusername.TabIndex = 4;
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelemail.Location = new System.Drawing.Point(197, 331);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(52, 20);
            this.labelemail.TabIndex = 7;
            this.labelemail.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtemail.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtemail.Location = new System.Drawing.Point(201, 354);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(265, 37);
            this.txtemail.TabIndex = 6;
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // labelphone
            // 
            this.labelphone.AutoSize = true;
            this.labelphone.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelphone.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelphone.Location = new System.Drawing.Point(529, 246);
            this.labelphone.Name = "labelphone";
            this.labelphone.Size = new System.Drawing.Size(57, 20);
            this.labelphone.TabIndex = 9;
            this.labelphone.Text = "Phone";
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtphone.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtphone.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtphone.Location = new System.Drawing.Point(533, 269);
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(265, 37);
            this.txtphone.TabIndex = 8;
            this.txtphone.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // labelgender
            // 
            this.labelgender.AutoSize = true;
            this.labelgender.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgender.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelgender.Location = new System.Drawing.Point(197, 252);
            this.labelgender.Name = "labelgender";
            this.labelgender.Size = new System.Drawing.Size(62, 20);
            this.labelgender.TabIndex = 11;
            this.labelgender.Text = "Gender";
            // 
            // labelage
            // 
            this.labelage.AutoSize = true;
            this.labelage.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelage.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelage.Location = new System.Drawing.Point(529, 168);
            this.labelage.Name = "labelage";
            this.labelage.Size = new System.Drawing.Size(39, 20);
            this.labelage.TabIndex = 13;
            this.labelage.Text = "Age";
            // 
            // txtage
            // 
            this.txtage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtage.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtage.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtage.Location = new System.Drawing.Point(533, 191);
            this.txtage.Multiline = true;
            this.txtage.Name = "txtage";
            this.txtage.ReadOnly = true;
            this.txtage.Size = new System.Drawing.Size(265, 37);
            this.txtage.TabIndex = 12;
            this.txtage.Leave += new System.EventHandler(this.txtage_Leave);
            // 
            // Labeldob
            // 
            this.Labeldob.AutoSize = true;
            this.Labeldob.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Labeldob.ForeColor = System.Drawing.Color.DarkGreen;
            this.Labeldob.Location = new System.Drawing.Point(197, 168);
            this.Labeldob.Name = "Labeldob";
            this.Labeldob.Size = new System.Drawing.Size(107, 20);
            this.Labeldob.TabIndex = 15;
            this.Labeldob.Text = "Date of birth";
            // 
            // labellastname
            // 
            this.labellastname.AutoSize = true;
            this.labellastname.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellastname.ForeColor = System.Drawing.Color.DarkGreen;
            this.labellastname.Location = new System.Drawing.Point(529, 85);
            this.labellastname.Name = "labellastname";
            this.labellastname.Size = new System.Drawing.Size(80, 20);
            this.labellastname.TabIndex = 17;
            this.labellastname.Text = "Lastname";
            // 
            // txtlastname
            // 
            this.txtlastname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtlastname.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlastname.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtlastname.Location = new System.Drawing.Point(533, 108);
            this.txtlastname.Multiline = true;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(265, 37);
            this.txtlastname.TabIndex = 16;
            this.txtlastname.Leave += new System.EventHandler(this.txtlastname_Leave);
            // 
            // labellocation
            // 
            this.labellocation.AutoSize = true;
            this.labellocation.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellocation.ForeColor = System.Drawing.Color.DarkGreen;
            this.labellocation.Location = new System.Drawing.Point(202, 570);
            this.labellocation.Name = "labellocation";
            this.labellocation.Size = new System.Drawing.Size(66, 20);
            this.labellocation.TabIndex = 19;
            this.labellocation.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtaddress.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtaddress.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtaddress.Location = new System.Drawing.Point(206, 593);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(265, 37);
            this.txtaddress.TabIndex = 18;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            this.txtaddress.Leave += new System.EventHandler(this.txtaddress_Leave);
            // 
            // labelconfirmpassword
            // 
            this.labelconfirmpassword.AutoSize = true;
            this.labelconfirmpassword.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelconfirmpassword.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelconfirmpassword.Location = new System.Drawing.Point(529, 490);
            this.labelconfirmpassword.Name = "labelconfirmpassword";
            this.labelconfirmpassword.Size = new System.Drawing.Size(143, 20);
            this.labelconfirmpassword.TabIndex = 21;
            this.labelconfirmpassword.Text = "Confirm password";
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtconfirmpassword.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconfirmpassword.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtconfirmpassword.Location = new System.Drawing.Point(533, 513);
            this.txtconfirmpassword.Multiline = true;
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.Size = new System.Drawing.Size(265, 37);
            this.txtconfirmpassword.TabIndex = 20;
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.ForeColor = System.Drawing.Color.DarkGreen;
            this.labeladdress.Location = new System.Drawing.Point(202, 490);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(76, 20);
            this.labeladdress.TabIndex = 23;
            this.labeladdress.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtpassword.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.txtpassword.Location = new System.Drawing.Point(201, 513);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(265, 37);
            this.txtpassword.TabIndex = 22;
            this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // labeldistrict
            // 
            this.labeldistrict.AutoSize = true;
            this.labeldistrict.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldistrict.ForeColor = System.Drawing.Color.DarkGreen;
            this.labeldistrict.Location = new System.Drawing.Point(529, 412);
            this.labeldistrict.Name = "labeldistrict";
            this.labeldistrict.Size = new System.Drawing.Size(65, 20);
            this.labeldistrict.TabIndex = 25;
            this.labeldistrict.Text = "District";
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.Green;
            this.btnsignup.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.White;
            this.btnsignup.Location = new System.Drawing.Point(396, 675);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(104, 42);
            this.btnsignup.TabIndex = 26;
            this.btnsignup.Text = "Sign up";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Enabled = false;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(548, 675);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 42);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
        //    this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // radiobuttonmale
            // 
            this.radiobuttonmale.AutoSize = true;
            this.radiobuttonmale.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonmale.ForeColor = System.Drawing.Color.DodgerBlue;
            this.radiobuttonmale.Location = new System.Drawing.Point(206, 275);
            this.radiobuttonmale.Name = "radiobuttonmale";
            this.radiobuttonmale.Size = new System.Drawing.Size(63, 25);
            this.radiobuttonmale.TabIndex = 28;
            this.radiobuttonmale.TabStop = true;
            this.radiobuttonmale.Text = "Male";
            this.radiobuttonmale.UseVisualStyleBackColor = true;
            this.radiobuttonmale.CheckedChanged += new System.EventHandler(this.radiobuttonmale_CheckedChanged);
            // 
            // radiobuttonfemale
            // 
            this.radiobuttonfemale.AutoSize = true;
            this.radiobuttonfemale.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonfemale.ForeColor = System.Drawing.Color.DeepPink;
            this.radiobuttonfemale.Location = new System.Drawing.Point(308, 275);
            this.radiobuttonfemale.Name = "radiobuttonfemale";
            this.radiobuttonfemale.Size = new System.Drawing.Size(77, 25);
            this.radiobuttonfemale.TabIndex = 29;
            this.radiobuttonfemale.TabStop = true;
            this.radiobuttonfemale.Text = "Female";
            this.radiobuttonfemale.UseVisualStyleBackColor = true;
            this.radiobuttonfemale.CheckedChanged += new System.EventHandler(this.radiobuttonfemale_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Maroon;
            this.dateTimePicker.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(201, 191);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(260, 28);
            this.dateTimePicker.TabIndex = 30;
            this.dateTimePicker.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            this.dateTimePicker.Leave += new System.EventHandler(this.dateTimePicker_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // comboboxstate
            // 
            this.comboboxstate.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxstate.FormattingEnabled = true;
            this.comboboxstate.Items.AddRange(new object[] {
            "Kerala",
            "Karnataka",
            "Tamilnadu",
            ""});
            this.comboboxstate.Location = new System.Drawing.Point(201, 451);
            this.comboboxstate.Name = "comboboxstate";
            this.comboboxstate.Size = new System.Drawing.Size(265, 24);
            this.comboboxstate.TabIndex = 31;
            this.comboboxstate.Text = "Select from the dropdown";
            this.comboboxstate.SelectedIndexChanged += new System.EventHandler(this.comboboxstate_SelectedIndexChanged);
            this.comboboxstate.Leave += new System.EventHandler(this.comboboxstate_Leave);
            // 
            // comboboxdistrict
            // 
            this.comboboxdistrict.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboboxdistrict.FormattingEnabled = true;
            this.comboboxdistrict.Location = new System.Drawing.Point(533, 451);
            this.comboboxdistrict.Name = "comboboxdistrict";
            this.comboboxdistrict.Size = new System.Drawing.Size(265, 24);
            this.comboboxdistrict.TabIndex = 32;
            this.comboboxdistrict.Text = "Select from the dropdown";
            this.comboboxdistrict.Leave += new System.EventHandler(this.comboboxdistrict_Leave);
            // 
            // buttonsignin
            // 
            this.buttonsignin.BackColor = System.Drawing.Color.Green;
            this.buttonsignin.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsignin.ForeColor = System.Drawing.Color.White;
            this.buttonsignin.Location = new System.Drawing.Point(705, 675);
            this.buttonsignin.Name = "buttonsignin";
            this.buttonsignin.Size = new System.Drawing.Size(104, 42);
            this.buttonsignin.TabIndex = 33;
            this.buttonsignin.Text = "Sign in";
            this.buttonsignin.UseVisualStyleBackColor = false;
            this.buttonsignin.Click += new System.EventHandler(this.buttonsignin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1212, 747);
            this.Controls.Add(this.buttonsignin);
            this.Controls.Add(this.comboboxdistrict);
            this.Controls.Add(this.comboboxstate);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.radiobuttonfemale);
            this.Controls.Add(this.radiobuttonmale);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.labeldistrict);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.labelconfirmpassword);
            this.Controls.Add(this.txtconfirmpassword);
            this.Controls.Add(this.labellocation);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.labellastname);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.Labeldob);
            this.Controls.Add(this.labelage);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.labelgender);
            this.Controls.Add(this.labelphone);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.labelemail);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.labelusername);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.labelstate);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.txtFirstname);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelstate;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label labelphone;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label labelgender;
        private System.Windows.Forms.Label labelage;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.Label Labeldob;
        private System.Windows.Forms.Label labellastname;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label labellocation;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label labelconfirmpassword;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label labeldistrict;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radiobuttonmale;
        private System.Windows.Forms.RadioButton radiobuttonfemale;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboboxstate;
        private System.Windows.Forms.ComboBox comboboxdistrict;
        private System.Windows.Forms.Button buttonsignin;
    }
}

