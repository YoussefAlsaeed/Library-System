namespace MyLibrarySystem
{
    partial class AdminInfo
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
            this.Salary = new System.Windows.Forms.TextBox();
            this.HireYear = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your salary:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the year you were hired:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Salary
            // 
            this.Salary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Salary.Location = new System.Drawing.Point(378, 71);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(138, 22);
            this.Salary.TabIndex = 2;
            // 
            // HireYear
            // 
            this.HireYear.Location = new System.Drawing.Point(378, 151);
            this.HireYear.Name = "HireYear";
            this.HireYear.Size = new System.Drawing.Size(138, 22);
            this.HireYear.TabIndex = 3;
            this.HireYear.TextChanged += new System.EventHandler(this.HireYear_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Location = new System.Drawing.Point(92, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 223);
            this.panel1.TabIndex = 5;
            // 
            // AdminInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrarySystem.Properties.Resources.Interior_view_of_Stockholm_Public_Library;
            this.ClientSize = new System.Drawing.Size(621, 322);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HireYear);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminInfo";
            this.Text = "AdminInfo";
            this.Load += new System.EventHandler(this.AdminInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Salary;
        private System.Windows.Forms.TextBox HireYear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}