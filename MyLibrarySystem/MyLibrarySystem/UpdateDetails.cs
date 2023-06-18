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
    public partial class UpdateDetails : Form
    {
        private string username;
        public UpdateDetails(string username)
        {
            InitializeComponent();
            this.username = username;
        }
        public UpdateDetails()
        {
            InitializeComponent();
        }

        private void UpdateDetails_Load(object sender, EventArgs e)
        {
            label9.Text= username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin(username).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();

            SqlCommand sda = new SqlCommand("SELECT count(*) from LibraryUser WHERE Username = '" + textBox1.Text + "' ", SQLconnection);

            object obj = sda.ExecuteScalar();

            if (Convert.ToInt32(obj) == 0)
            {
                MessageBox.Show(" This User doesn't exist! ");

            }

            else
            {
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = SQLconnection;
                sqlCommand.CommandText = "Update LibraryUser set password = '" + textBox2.Text + "' where username = '" + textBox1.Text + "'";
                sqlCommand.ExecuteNonQuery();
                SQLconnection.Close();
                MessageBox.Show("Password of '" + textBox1.Text + "' updated  successfully! ");
                this.Hide();
                new Admin(username).Show();
            }
        }
    }
}
