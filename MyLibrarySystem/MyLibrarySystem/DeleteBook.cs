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

namespace MyLibrarySystem
{
    public partial class DeleteBook : Form
    {
        private string username;
        public DeleteBook(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public DeleteBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin admin = new Admin(username);
            admin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SQLconnection;
            sqlCommand.CommandText = "Delete from Book_Categories where Book_ID ='" + ID.Text+"'  ";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "delete from Publishes where Book_ID='" + ID.Text + "'  ";
            sqlCommand.ExecuteNonQuery();


            sqlCommand.CommandText = "delete from book where Book_ID='" + ID.Text + "'  ";
            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Book deleted successfully! ");

          //  SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SQLconnection;
            SqlCommand cmd = new SqlCommand("Select * from Book", SQLconnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;




            SQLconnection.Close();
        }

        private void DeleteBook_Load(object sender, EventArgs e)
        {
            label9.Text = username;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();
            SqlCommand cmd = new SqlCommand("Select book.title as Title, book.book_ID,book.price,book.language,Author.Author_name from book,Author where title LIKE '%" + textBox1.Text + "%' AND book.author_ID = author.author_ID;", SQLconnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
