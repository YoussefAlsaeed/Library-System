namespace MyLibrarySystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Birth = new System.Windows.Forms.TextBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(295, 22);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(147, 22);
            this.Username.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(295, 83);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(147, 22);
            this.Password.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SeaShell;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(197, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Already have an account?";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Crimson;
            this.LoginButton.ForeColor = System.Drawing.Color.Cornsilk;
            this.LoginButton.Location = new System.Drawing.Point(57, 62);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(83, 32);
            this.LoginButton.TabIndex = 8;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Type
            // 
            this.Type.FormattingEnabled = true;
            this.Type.Items.AddRange(new object[] {
            "student",
            "admin"});
            this.Type.Location = new System.Drawing.Point(295, 148);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(147, 24);
            this.Type.TabIndex = 19;
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(295, 492);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(147, 22);
            this.Address.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.SeaShell;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(197, 609);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 39);
            this.label10.TabIndex = 17;
            this.label10.Text = "Address";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(295, 442);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(147, 22);
            this.Phone.TabIndex = 16;
            // 
            // Birth
            // 
            this.Birth.Location = new System.Drawing.Point(295, 385);
            this.Birth.Name = "Birth";
            this.Birth.Size = new System.Drawing.Size(147, 22);
            this.Birth.TabIndex = 15;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(295, 274);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(147, 22);
            this.LastName.TabIndex = 13;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(295, 221);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(147, 22);
            this.FirstName.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.SeaShell;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(197, 559);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(202, 39);
            this.label9.TabIndex = 11;
            this.label9.Text = "Phone Number";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.SeaShell;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(197, 502);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 39);
            this.label8.TabIndex = 10;
            this.label8.Text = "Birthdate";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.SeaShell;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 39);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 39);
            this.label6.TabIndex = 8;
            this.label6.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "First Name";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.ForeColor = System.Drawing.Color.Cornsilk;
            this.button1.Location = new System.Drawing.Point(295, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 45);
            this.button1.TabIndex = 2;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox2.Controls.Add(this.LoginButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(327, 755);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.Address);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Type);
            this.panel1.Controls.Add(this.Username);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.Phone);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.Birth);
            this.panel1.Location = new System.Drawing.Point(164, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 595);
            this.panel1.TabIndex = 20;
            // 
            // Gender
            // 
            this.Gender.AccessibleName = "";
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(295, 326);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(147, 24);
            this.Gender.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.SeaShell;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(342, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 45);
            this.label11.TabIndex = 21;
            this.label11.Text = "Welcome !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::MyLibrarySystem.Properties.Resources._1_SliOt7e8_OPCErcwAYy9AQ1;
            this.ClientSize = new System.Drawing.Size(855, 867);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Birth;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.Label label11;
    }
}

