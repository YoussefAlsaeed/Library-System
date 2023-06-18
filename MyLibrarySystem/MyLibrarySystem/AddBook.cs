using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MyLibrarySystem
{
    public partial class AddBook : Form
    {
        private string username;
        public AddBook()
        {
            InitializeComponent();
        }
        public AddBook(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin admin = new Admin(username);
            admin.Show();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {
            label9.Text = username;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();
            SqlCommand sda = new SqlCommand("SELECT count(*) from Publisher WHERE P_Name = '" + Publisher.Text + "' ", SQLconnection);

            object obj = sda.ExecuteScalar();

            if (Convert.ToInt32(obj) != 1)
            {
                MessageBox.Show(" No Publisher with this name exits ");
                new Publisher().Show();
            }

            else
            {  


                SqlCommand sda2 = new SqlCommand("SELECT count(*) from Author WHERE Author_Name = '" + AuthorName.Text + "' ", SQLconnection);

                object obj2 = sda2.ExecuteScalar();

                if (Convert.ToInt32(obj2) != 1)
                {
                    MessageBox.Show(" No Author with this name exits, He/She will be added to the database ");
                    SqlCommand sqlCommand = new SqlCommand();
                    sqlCommand.Connection = SQLconnection;
                    sqlCommand.CommandText = "INSERT INTO Author Values('" + AuthorName.Text + "')";
                    sqlCommand.ExecuteNonQuery();
                }

                SqlCommand sqlCommand2 = new SqlCommand();
                sqlCommand2.Connection = SQLconnection;
                SqlCommand sda3 = new SqlCommand("Select Author_ID from Author where Author_name= '" + AuthorName.Text + "'", SQLconnection);
                object obj3 = sda3.ExecuteScalar();

                sqlCommand2.CommandText = "INSERT INTO Book Values('" + Language.Text + "' , '" + Price.Text + "' , '" + Title.Text + "' , '" + Convert.ToInt32(obj3) + "' )";
                sqlCommand2.ExecuteNonQuery();

                SqlCommand sda4 = new SqlCommand("Select MAX(Book_ID) from Book where Title= '" + Title.Text + "'", SQLconnection);
                object obj4 = sda4.ExecuteScalar();

                sqlCommand2.CommandText = " INSERT INTO Book_Categories Values('" + Convert.ToInt32(obj4) + "' , '" + listBox1.Text + "') ";
                sqlCommand2.ExecuteNonQuery();

                sqlCommand2.CommandText = " INSERT INTO Book_Categories Values('" + Convert.ToInt32(obj4) + "' , '" + listBox2.Text + "') ";
                sqlCommand2.ExecuteNonQuery();

                SqlCommand sda5 = new SqlCommand("Select P_ID from Publisher where P_Name= '" + Publisher.Text + "'", SQLconnection);
                object obj5 = sda5.ExecuteScalar();

                sqlCommand2.CommandText = " INSERT INTO Publishes Values('" + Convert.ToInt32(obj5) + "' , '" + Convert.ToInt32(obj4) + "' , '" + Year.Text + "') ";
                sqlCommand2.ExecuteNonQuery();

                MessageBox.Show("Book added successfully!");


            } 









        }
    }
}
