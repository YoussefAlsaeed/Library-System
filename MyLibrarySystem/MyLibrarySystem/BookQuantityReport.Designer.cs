namespace MyLibrarySystem
{
    partial class BookQuantityReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.myLibraryDataSet7 = new MyLibrarySystem.MyLibraryDataSet7();
            this.myLibraryDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new MyLibrarySystem.MyLibraryDataSet7TableAdapters.BookTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bookBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "MyLibrarySystem.QuantityReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(31, 57);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(839, 359);
            this.reportViewer1.TabIndex = 0;
            // 
            // myLibraryDataSet7
            // 
            this.myLibraryDataSet7.DataSetName = "MyLibraryDataSet7";
            this.myLibraryDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // myLibraryDataSet7BindingSource
            // 
            this.myLibraryDataSet7BindingSource.DataSource = this.myLibraryDataSet7;
            this.myLibraryDataSet7BindingSource.Position = 0;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.myLibraryDataSet7BindingSource;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // BookQuantityReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MyLibrarySystem.Properties.Resources._1_SliOt7e8_OPCErcwAYy9AQ2;
            this.ClientSize = new System.Drawing.Size(934, 489);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BookQuantityReport";
            this.Text = "BookQuantityReport";
            this.Load += new System.EventHandler(this.BookQuantityReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myLibraryDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MyLibraryDataSet7 myLibraryDataSet7;
        private System.Windows.Forms.BindingSource myLibraryDataSet7BindingSource;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private MyLibraryDataSet7TableAdapters.BookTableAdapter bookTableAdapter;
    }
}