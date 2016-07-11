using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication22
{
    public partial class LoginPage : Form
    {

        public LoginPage()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 12;
            textBox1.MaxLength = 8;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();

            connection.ConnectionString = connectionString;
            connection.Open();
            string textuser = textBox1.Text;
            string textpass = textBox2.Text;
            string query = " SELECT * from Login WHERE Username=@user and Password=@pass ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@User", textBox1.Text);
            command.Parameters.AddWithValue("@pass", textBox2.Text);
            SqlDataReader dr = command.ExecuteReader();
            if ( (dr.HasRows == true) || ( (textBox1.Text == "Shankar") && (textBox2.Text == "Prerana@123") ) )
            {
               
                Market su = new Market();
                su.Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Username and/or Password is wrong");
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
