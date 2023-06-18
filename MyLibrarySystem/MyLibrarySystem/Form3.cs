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
    public partial class StudentInfo : Form
    {
        private string username;
        public StudentInfo()
        {
            InitializeComponent();
        }
        public StudentInfo(int ID,string username)
        {
            InitializeComponent();
            this.username = username;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SQLconnection = new SqlConnection("Data Source=LEGION-5;Initial Catalog=MyLibrary;Integrated Security=True");
            SQLconnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SQLconnection;
            sqlCommand.CommandText = "Update student set faculty = '" + BoxList.Text + "'  where student.studentID = (select max(studentID)from student )";
            sqlCommand.ExecuteNonQuery();

            sqlCommand.CommandText = "select max(studentID)from student";
            sqlCommand.ExecuteScalar();

            object obj = new object();
            obj = sqlCommand.ExecuteScalar();
            int ID = Convert.ToInt32(obj);


            SQLconnection.Close();
            MessageBox.Show("Registered!");

            this.Hide();

            new Student(ID,username).Show();
        }
    }
}
