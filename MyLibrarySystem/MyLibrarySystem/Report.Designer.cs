namespace MyLibrarySystem
{
    partial class Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.myLibraryDataSet3 = new MyLibrarySystem.MyLibraryDataSet3();
            this.myLibraryDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.myLibraryDataSet1 = new MyLibrarySystem.MyLibraryDataSet1();
            this.myLibraryDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.myLibraryDataSet6 = new MyLibrarySystem.MyLibraryDataSet6();
            this.bookBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new MyLibrarySystem.MyLibraryDataSet6TableAdapters.BookTableAdapter();
            this.bookBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.myLibraryDataSet7 = new MyLibrarySystem.MyLibraryDataSet7();
            this.bookBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter1 = new MyLibrarySystem.MyLibraryDataSet7TableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // myLibraryDataSet3
            // 
            this.myLibraryDataSet3.DataSetName = "MyLibraryDataSet3";
            this.myLibraryDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myLibraryDataSet3BindingSource
            // 
            this.myLibraryDataSet3BindingSource.DataSource = this.myLibraryDataSet3;
            this.myLibraryDataSet3BindingSource.Position = 0;
            // 
            // myLibraryDataSet1
            // 
            this.myLibraryDataSet1.DataSetName = "MyLibraryDataSet1";
            this.myLibraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myLibraryDataSet1BindingSource
            // 
            this.myLibraryDataSet1BindingSource.DataSource = this.myLibraryDataSet1;
            this.myLibraryDataSet1BindingSource.Position = 0;
            // 
            // BookBindingSource
            // 
            this.BookBindingSource.DataMember = "Book";
            this.BookBindingSource.DataSource = this.myLibraryDataSet3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet5";
            reportDataSource1.Value = this.bookBindingSource3;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyLibrarySystem.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 24);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1148, 377);
            this.reportViewer1.TabIndex = 0;
            // 
            // myLibraryDataSet6
            // 
            this.myLibraryDataSet6.DataSetName = "MyLibraryDataSet6";
            this.myLibraryDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource1
            // 
            this.bookBindingSource1.DataMember = "Book";
            this.bookBindingSource1.DataSource = this.myLibraryDataSet6;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // bookBindingSource2
            // 
            this.bookBindingSource2.DataMember = "Book";
            this.bookBindingSource2.DataSource = this.myLibraryDataSet6;
            // 
            // myLibraryDataSet7
            // 
            this.myLibraryDataSet7.DataSetName = "MyLibraryDataSet7";
            this.myLibraryDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookBindingSource3
            // 
            this.bookBindingSource3.DataMember = "Book";
            this.bookBindingSource3.DataSource = this.myLibraryDataSet7;
            // 
            // bookTableAdapter1
            // 
            this.bookTableAdapter1.ClearBeforeFill = true;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrarySystem.Properties.Resources._1_SliOt7e8_OPCErcwAYy9AQ;
            this.ClientSize = new System.Drawing.Size(1203, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Report";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource myLibraryDataSet1BindingSource;
        private MyLibraryDataSet1 myLibraryDataSet1;
        private MyLibraryDataSet3 myLibraryDataSet3;
        private System.Windows.Forms.BindingSource myLibraryDataSet3BindingSource;
        private System.Windows.Forms.BindingSource BookBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MyLibraryDataSet6 myLibraryDataSet6;
        private System.Windows.Forms.BindingSource bookBindingSource1;
        private MyLibraryDataSet6TableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.BindingSource bookBindingSource2;
        private MyLibraryDataSet7 myLibraryDataSet7;
        private System.Windows.Forms.BindingSource bookBindingSource3;
        private MyLibraryDataSet7TableAdapters.BookTableAdapter bookTableAdapter1;
    }
}