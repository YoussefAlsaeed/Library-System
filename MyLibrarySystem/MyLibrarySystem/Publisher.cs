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
    public partial class Publisher : Form
    {
        public Publisher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SQLconnection;
            sqlCommand.CommandText = "INSERT INTO Publisher Values('" + textBox1.Text + "','" + textBox2.Text + "')";
            sqlCommand.ExecuteNonQuery();
            SQLconnection.Close();
            MessageBox.Show("Publisher added successfully! ");
            this.Hide();
        }
    }
}
