namespace validationform_task4
{
    partial class Contactform
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
            this.txtusername = new System.Windows.Forms.TextBox();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelmobile = new System.Windows.Forms.Label();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.labelmessage = new System.Windows.Forms.Label();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.buttoncancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelmessageerror = new System.Windows.Forms.Label();
            this.labelheading = new System.Windows.Forms.Label();
            this.labemail = new System.Windows.Forms.Label();
            this.labelemail = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.labelmobileerror = new System.Windows.Forms.Label();
            this.labelusernamerror = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(33, 139);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(269, 31);
            this.txtusername.TabIndex = 0;
            this.txtusername.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelusername.Location = new System.Drawing.Point(29, 115);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(89, 21);
            this.labelusername.TabIndex = 1;
            this.labelusername.Text = "Username";
            // 
            // labelmobile
            // 
            this.labelmobile.AutoSize = true;
            this.labelmobile.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelmobile.Location = new System.Drawing.Point(27, 212);
            this.labelmobile.Name = "labelmobile";
            this.labelmobile.Size = new System.Drawing.Size(63, 21);
            this.labelmobile.TabIndex = 5;
            this.labelmobile.Text = "Mobile";
            // 
            // txtmobile
            // 
            this.txtmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.Location = new System.Drawing.Point(32, 236);
            this.txtmobile.Multiline = true;
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(270, 37);
            this.txtmobile.TabIndex = 4;
            this.txtmobile.Validating += new System.ComponentModel.CancelEventHandler(this.txtmobile_Validating);
            // 
            // labelmessage
            // 
            this.labelmessage.AutoSize = true;
            this.labelmessage.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelmessage.Location = new System.Drawing.Point(29, 320);
            this.labelmessage.Name = "labelmessage";
            this.labelmessage.Size = new System.Drawing.Size(79, 21);
            this.labelmessage.TabIndex = 7;
            this.labelmessage.Text = "Message";
            // 
            // txtmessage
            // 
            this.txtmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmessage.Location = new System.Drawing.Point(32, 344);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(270, 76);
            this.txtmessage.TabIndex = 6;
            this.txtmessage.Validating += new System.ComponentModel.CancelEventHandler(this.txtmessage_Validating);
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonsubmit.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubmit.Location = new System.Drawing.Point(180, 475);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(86, 33);
            this.buttonsubmit.TabIndex = 8;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = false;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // buttoncancel
            // 
            this.buttoncancel.BackColor = System.Drawing.Color.Maroon;
            this.buttoncancel.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncancel.Location = new System.Drawing.Point(340, 475);
            this.buttoncancel.Name = "buttoncancel";
            this.buttoncancel.Size = new System.Drawing.Size(86, 33);
            this.buttoncancel.TabIndex = 9;
            this.buttoncancel.Text = "Cancel";
            this.buttoncancel.UseVisualStyleBackColor = false;
            this.buttoncancel.Click += new System.EventHandler(this.buttoncancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelmessageerror);
            this.panel1.Controls.Add(this.labelheading);
            this.panel1.Controls.Add(this.labemail);
            this.panel1.Controls.Add(this.labelemail);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.labelmobileerror);
            this.panel1.Controls.Add(this.labelusernamerror);
            this.panel1.Controls.Add(this.labelusername);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.txtmobile);
            this.panel1.Controls.Add(this.buttoncancel);
            this.panel1.Controls.Add(this.labelmobile);
            this.panel1.Controls.Add(this.buttonsubmit);
            this.panel1.Controls.Add(this.txtmessage);
            this.panel1.Controls.Add(this.labelmessage);
            this.panel1.Location = new System.Drawing.Point(152, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 545);
            this.panel1.TabIndex = 10;
            // 
            // labelmessageerror
            // 
            this.labelmessageerror.AutoSize = true;
            this.labelmessageerror.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelmessageerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelmessageerror.Location = new System.Drawing.Point(28, 423);
            this.labelmessageerror.Name = "labelmessageerror";
            this.labelmessageerror.Size = new System.Drawing.Size(0, 16);
            this.labelmessageerror.TabIndex = 19;
            // 
            // labelheading
            // 
            this.labelheading.AutoSize = true;
            this.labelheading.Font = new System.Drawing.Font("Palatino Linotype", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelheading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelheading.Location = new System.Drawing.Point(211, 29);
            this.labelheading.Name = "labelheading";
            this.labelheading.Size = new System.Drawing.Size(178, 50);
            this.labelheading.TabIndex = 18;
            this.labelheading.Text = "About us";
            // 
            // labemail
            // 
            this.labemail.AutoSize = true;
            this.labemail.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold);
            this.labemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labemail.Location = new System.Drawing.Point(351, 173);
            this.labemail.Name = "labemail";
            this.labemail.Size = new System.Drawing.Size(0, 16);
            this.labemail.TabIndex = 17;
            // 
            // labelemail
            // 
            this.labelemail.AutoSize = true;
            this.labelemail.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.labelemail.Location = new System.Drawing.Point(350, 115);
            this.labelemail.Name = "labelemail";
            this.labelemail.Size = new System.Drawing.Size(54, 21);
            this.labelemail.TabIndex = 16;
            this.labelemail.Text = "Email";
            // 
            // txtemail
            // 
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Location = new System.Drawing.Point(354, 139);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(268, 31);
            this.txtemail.TabIndex = 15;
            this.txtemail.Validating += new System.ComponentModel.CancelEventHandler(this.txtemail_Validating);
            // 
            // labelmobileerror
            // 
            this.labelmobileerror.AutoSize = true;
            this.labelmobileerror.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold);
            this.labelmobileerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelmobileerror.Location = new System.Drawing.Point(30, 276);
            this.labelmobileerror.Name = "labelmobileerror";
            this.labelmobileerror.Size = new System.Drawing.Size(0, 16);
            this.labelmobileerror.TabIndex = 14;
            // 
            // labelusernamerror
            // 
            this.labelusernamerror.AutoSize = true;
            this.labelusernamerror.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusernamerror.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelusernamerror.Location = new System.Drawing.Point(30, 173);
            this.labelusernamerror.Name = "labelusernamerror";
            this.labelusernamerror.Size = new System.Drawing.Size(0, 16);
            this.labelusernamerror.TabIndex = 10;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Contactform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 553);
            this.Controls.Add(this.panel1);
            this.Name = "Contactform";
            this.Text = "Contactform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Label labelmobile;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Label labelmessage;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.Button buttoncancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelusernamerror;
        private System.Windows.Forms.Label labemail;
        private System.Windows.Forms.Label labelemail;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label labelmobileerror;
        private System.Windows.Forms.Label labelheading;
        private System.Windows.Forms.Label labelmessageerror;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}