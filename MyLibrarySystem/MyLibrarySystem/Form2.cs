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
    public partial class Admin : Form
    {
        private string username;
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string username)
        {
            InitializeComponent();
            this.username= username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelbutton.Height = button1.Height;
            panelbutton.Top = button1.Top;
            AddBook addBook = new AddBook(username);
            addBook.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelbutton.Height = button2.Height;
            panelbutton.Top = button2.Top;
            updatePrice update = new updatePrice(username);
            update.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelbutton.Height = button3.Height;
            panelbutton.Top = button3.Top;
            UpdateDetails update = new UpdateDetails(username);
            update.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panelbutton.Height = button6.Height;
            panelbutton.Top = button6.Top;
            DeleteBook deleteBook = new DeleteBook(username);
            deleteBook.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelbutton.Height = button5.Height;
            panelbutton.Top = button5.Top;
            Delete_Student delete_Student = new Delete_Student(username);
            delete_Student.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panelbutton.Height = button8.Height;
            panelbutton.Top = button8.Top;
            new ReportMenu(username).Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            label3.Text = username;
        }
    }
}
