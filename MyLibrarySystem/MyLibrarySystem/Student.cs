using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace MyLibrarySystem
{
    public partial class Student : Form
    {
        private int ID;
        private string username;
        public Student()
        {
            InitializeComponent();
        }
        public Student(int ID , string username)
        {
            InitializeComponent();
            this.ID = ID;
            this.username = username;
        }
        public Student(string username)
        {
            InitializeComponent();
            this.username = username;
        }



        private void Student_Load(object sender, EventArgs e)
        {
            /*
            // TODO: This line of code loads data into the 'myLibraryDataSet3.Book' table. You can move, or remove it, as needed.
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            string query = "select Book.title, author.author_name from book , author where book.book_id = author.author_ID"; //haaa
            this.authorTableAdapter.Fill(this.myLibraryDataSet.Author);

            */

            this.authorTableAdapter.Fill(this.myLibraryDataSet.Author);
            label4.Text = username;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();

            SqlCommand sda = new SqlCommand("SELECT count(*) from Book WHERE title LIKE '%" + title.Text + "%';", SQLconnection);

            object obj = sda.ExecuteScalar();
            if (Convert.ToInt32(obj) >= 1)
            {

                SqlCommand cmd = new SqlCommand("Select book.title as Title, book.book_ID,book.price,book.language,Author.Author_name from book,Author where title LIKE '%" + title.Text + "%' AND book.author_ID = author.author_ID;", SQLconnection);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
         
            }
            else MessageBox.Show("This book doesn't exist in our library!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bookTableAdapter.FillBy2(this.myLibraryDataSet.Book);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();
            SqlCommand cmd2 = new SqlCommand("select title,price,Author_Name from Book,Book_Categories,Author where Author.Author_ID=book.Author_ID and book.Book_ID=Book_Categories.Book_ID and categories LIKE '%" + Category.Text + "%'", SQLconnection);
            SqlDataAdapter db = new SqlDataAdapter(cmd2);
            DataTable dt2 = new DataTable();
            db.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();
            SqlCommand sqlCommand= new SqlCommand();
            sqlCommand.Connection = SQLconnection;
            DateTime dateTimeNow = DateTime.Now;
            sqlCommand.CommandText = "Insert into Borrows (Student_ID , Book_ID, Borrow_date)  Values('"+ID+ "' , '" + textBox1.Text + "' , '" + dateTimeNow + "' )";
            sqlCommand.ExecuteNonQuery();
            SQLconnection.Close();
            MessageBox.Show("Borrowed successfully!");


        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
