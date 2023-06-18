using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLibrarySystem
{
    public partial class BookQuantityReport : Form
    {
        public BookQuantityReport()
        {
            InitializeComponent();
        }

        private void BookQuantityReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myLibraryDataSet7.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.myLibraryDataSet7.Book);

            this.reportViewer1.RefreshReport();
        }
    }
}
