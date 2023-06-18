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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();
            SqlCommand sda = new SqlCommand("SELECT count(*) from LibraryUser WHERE Username = '" + Username.Text + "' AND Password = '"+Password.Text+"' ", SQLconnection);

            object obj = sda.ExecuteScalar();

            if (Convert.ToInt32(obj) != 1)
            {
                MessageBox.Show(" Wrong username or password ! ");
            }

            else
            {

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = SQLconnection;
                sqlCommand.CommandText = "Select count(*) from LibraryUser , Admin where LibraryUser.Username = Admin.Username AND Admin.Username = '" + Username.Text+"' ";
                sqlCommand.ExecuteNonQuery();

                obj = sqlCommand.ExecuteScalar();


                if (Convert.ToInt32(obj) == 1)
                {
                    this.Hide();
                    new Admin(Username.Text).Show();
                }
                else
                {
                    sqlCommand.CommandText = "Select StudentID from Student where Username =  '" + Username.Text + "' ";
                    sqlCommand.ExecuteNonQuery();
                    obj=sqlCommand.ExecuteScalar();
                    int ID = Convert.ToInt32(obj);

                    this.Hide();
                    new Student(ID, Username.Text).Show();
                }

                SQLconnection.Close();


            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
