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
    public partial class Delete_Student : Form
    {
        private string username;
        public Delete_Student(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public Delete_Student()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Admin admin = new Admin(username);
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SQLconnection;
            sqlCommand.CommandText = "  DELETE FROM Borrows where  Student_ID in( select Student_ID from Student where Student.Username='" + Username.Text + "')";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "  Delete from Student where Username = '"+ Username.Text + "' ";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "  Delete from LibraryUser where Username = '"+ Username.Text + "' ";
            sqlCommand.ExecuteNonQuery();

            SqlCommand cmd = new SqlCommand("Select * from Student", SQLconnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SQLconnection.Close();

            MessageBox.Show("User deleted successfully! ");


        }

        private void button3_Click(object sender, EventArgs e)
        {

           
        }

        private void Delete_Student_Load(object sender, EventArgs e)
        {
            label9.Text = username;
        }
    }
}
