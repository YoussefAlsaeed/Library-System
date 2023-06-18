namespace MyLibrarySystem
{
    partial class StudentInfo
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
            this.BoxList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your faculty:";
            // 
            // BoxList
            // 
            this.BoxList.FormattingEnabled = true;
            this.BoxList.Items.AddRange(new object[] {
            "Computer Science",
            "Engineering",
            "Law",
            "Arts",
            "Fine Arts",
            "Business"});
            this.BoxList.Location = new System.Drawing.Point(430, 212);
            this.BoxList.Name = "BoxList";
            this.BoxList.Size = new System.Drawing.Size(149, 24);
            this.BoxList.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(328, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.Location = new System.Drawing.Point(149, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 289);
            this.panel1.TabIndex = 3;
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrarySystem.Properties.Resources._1_SliOt7e8_OPCErcwAYy9AQ;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BoxList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "StudentInfo";
            this.Text = "Student Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}