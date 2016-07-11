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
    public partial class SearchSalesmanform : Form
    {
        int _selectedIndex;
        public SearchSalesmanform()
        {
            InitializeComponent();
            this.dataGridView2.ReadOnly = true;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            button2.Enabled = false;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            Fillcombo();
            Fillcombo2();
      
            dataGridView2.DataSource = null;
        }
      
        void Fillcombo()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from SalesmanRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Name"));
                    comboBox3.Items.Add(CName);

                }
            }
            catch
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }
        void Fillcombo2()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from SalesmanRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    // string CName = myReader.GetString(myReader.GetOrdinal("ID"));
                    // comboBox3.Items.Add(CName);
                    var CName = myReader.GetDecimal(myReader.GetOrdinal("ID"));
                    comboBox2.Items.Add(CName);

                }
            }
            catch 
            {
              //  MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
        connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);


            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                if (_selectedIndex == 0)
                {
                    command.CommandText = "SELECT * from SalesmanRegistration";
                }
                else if (_selectedIndex == 1)
                {
                    command.CommandText = "SELECT * from SalesmanRegistration Where  Name=@Name ";

                }
                else if (_selectedIndex == 2)
                {
                    command.CommandText = "SELECT * from SalesmanRegistration where Id=@ID  ";
                }
               
                //command.Parameters.AddWithValue("@Account_Number", comboBox4.Text);
              command.Parameters.AddWithValue("@Name", comboBox3.Text);
               command.Parameters.AddWithValue("@ID", comboBox2.Text);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                //da.Fill(ds, "SalesmanRegistration");
                //dataGridView1.DataSource = ds.Tables["SalesmanRegistration"];

                DataTable dt = new DataTable();
                da.Fill(dt);
               
                SqlDataReader dr = command.ExecuteReader();
               // MessageBox.Show("details");    
            

            }
            catch
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

             


        }

        private void SearchSalesmanform_Load(object sender, EventArgs e)
        {
            
        }

        private void SearchSalesmanform_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.SalesmanRegistration' table. You can move, or remove it, as needed.
            this.salesmanRegistrationTableAdapter.Fill(this.marketDataSet.SalesmanRegistration);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = null;
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);


            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                _selectedIndex = comboBox1.SelectedIndex;
                if (_selectedIndex == 0)
                {

                    command.CommandText = " select * from SalesmanRegistration ";

                }
                else if (_selectedIndex == 1)
                {
                    if (comboBox3.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Select Salesman Name!");
                        return;
                    }
                    command.CommandText = " select * from SalesmanRegistration  where Name='" + comboBox3.Text + "'";
                }
                else if (_selectedIndex == 2)
                {
                    if (comboBox2.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Select Salesman ID Name!");
                        return;
                    }
                    command.CommandText = " select * from SalesmanRegistration  where ID='" + comboBox2.Text + "'";
                }


                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "SalesmanRegistration");
                dataGridView2.DataSource = ds.Tables["SalesmanRegistration"];






                SqlDataReader Reader = command.ExecuteReader();



            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }



        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
            _selectedIndex = comboBox1.SelectedIndex;
            if (_selectedIndex == 0)
            {
                comboBox3.Enabled = false;
                comboBox2.Enabled = false;
                button2.Enabled = true;


            }
            else if (_selectedIndex == 1)
            {
                comboBox3.Enabled = true;
                comboBox2.Enabled = false;
        

            }
            else if (_selectedIndex == 2)
            {
                comboBox3.Enabled = false;
                comboBox2.Enabled = true;
               

            }
            else if (_selectedIndex == 3)
            {
                comboBox3.Enabled = false;
                comboBox2.Enabled = true;
              

            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            dataGridView2.DataSource = null;

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            dataGridView2.DataSource = null;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
