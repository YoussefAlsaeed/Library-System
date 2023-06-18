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
    public partial class StartScreen : Form
    {
        private string str;
        private int len = 0;

        public StartScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 599)
            {
                timer1.Stop();
                new Form1().Show();
                this.Hide();
            }
        }

        private void StartScreen_Load(object sender, EventArgs e)
        {
            str = label1.Text;
            label1.Text = "";
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (len < str.Length)
            {
                label1.Text += str.ElementAt(len);
                len++;
            }
            else
            {
                timer2.Stop();
            }
        }
    }
}
