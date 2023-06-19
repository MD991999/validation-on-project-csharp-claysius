namespace validationform_task4
{
    partial class loginform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelusername = new System.Windows.Forms.Label();
            this.labelpassword = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.buttonsignin = new System.Windows.Forms.Button();
            this.buttonsignup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.labelpswd = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(58, 108);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(293, 48);
            this.txtusername.TabIndex = 0;
            this.txtusername.Validating += new System.ComponentModel.CancelEventHandler(this.txtusername_Validating);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelpswd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.buttonsignup);
            this.panel1.Controls.Add(this.buttonsignin);
            this.panel1.Controls.Add(this.labelpassword);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.labelusername);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Location = new System.Drawing.Point(183, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 393);
            this.panel1.TabIndex = 1;
            // 
            // labelusername
            // 
            this.labelusername.AutoSize = true;
            this.labelusername.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusername.ForeColor = System.Drawing.Color.Purple;
            this.labelusername.Location = new System.Drawing.Point(54, 82);
            this.labelusername.Name = "labelusername";
            this.labelusername.Size = new System.Drawing.Size(102, 23);
            this.labelusername.TabIndex = 1;
            this.labelusername.Text = "Username";
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.ForeColor = System.Drawing.Color.Purple;
            this.labelpassword.Location = new System.Drawing.Point(54, 187);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(99, 23);
            this.labelpassword.TabIndex = 3;
            this.labelpassword.Text = "Password";
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(58, 213);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(293, 48);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            this.txtpassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtpassword_Validating);
            // 
            // buttonsignin
            // 
            this.buttonsignin.BackColor = System.Drawing.Color.Maroon;
            this.buttonsignin.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonsignin.Location = new System.Drawing.Point(17, 328);
            this.buttonsignin.Name = "buttonsignin";
            this.buttonsignin.Size = new System.Drawing.Size(139, 45);
            this.buttonsignin.TabIndex = 4;
            this.buttonsignin.Text = "Sign in";
            this.buttonsignin.UseVisualStyleBackColor = false;
            this.buttonsignin.Click += new System.EventHandler(this.buttonsignin_Click);
            // 
            // buttonsignup
            // 
            this.buttonsignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonsignup.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsignup.ForeColor = System.Drawing.Color.Silver;
            this.buttonsignup.Location = new System.Drawing.Point(263, 328);
            this.buttonsignup.Name = "buttonsignup";
            this.buttonsignup.Size = new System.Drawing.Size(110, 39);
            this.buttonsignup.TabIndex = 6;
            this.buttonsignup.Text = "Sign up";
            this.buttonsignup.UseVisualStyleBackColor = false;
            this.buttonsignup.Click += new System.EventHandler(this.buttonsignup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.Location = new System.Drawing.Point(272, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Not a member?";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(55, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 8;
            // 
            // labelpswd
            // 
            this.labelpswd.AutoSize = true;
            this.labelpswd.Font = new System.Drawing.Font("Perpetua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpswd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelpswd.Location = new System.Drawing.Point(55, 264);
            this.labelpswd.Name = "labelpswd";
            this.labelpswd.Size = new System.Drawing.Size(0, 18);
            this.labelpswd.TabIndex = 9;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "loginform";
            this.Text = "loginform";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label labelusername;
        private System.Windows.Forms.Button buttonsignin;
        private System.Windows.Forms.Button buttonsignup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelpswd;
    }
}