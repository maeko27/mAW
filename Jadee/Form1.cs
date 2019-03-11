using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jadee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "jadee" && textBox2.Text == "twin")
            {
                MessageBox.Show("Welcome to my Mind");
                Form3 w = new Form3();
                this.Hide();
                w.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
