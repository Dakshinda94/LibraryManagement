using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace LibraryManagement
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-NC5KGPOF;Initial Catalog=LibraryManagement;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {

                String bName = textBox2.Text;
                String bCatagory = textBox3.Text;
                String bAuthor = textBox4.Text;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                conn.Open();
                cmd.CommandText = "Insert into NewBook (bName,bCatagory,bAuthor) values('" + bName + "','" + bCatagory + "','" + bAuthor + "')";
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Saved Successful");

                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
            else
            {
                MessageBox.Show("Please fill all the feilds !!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
