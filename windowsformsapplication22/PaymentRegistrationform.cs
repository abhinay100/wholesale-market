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

    public partial class PaymentRegistrationform : Form
    {
        int _selectedIndex;
        int _selectedSubIndex;
        String selectedCategory;
        String selectedSubCategory;
       
        public PaymentRegistrationform()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            this.dataGridView2.ReadOnly = true;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            button4.Enabled = false;
            button3.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            button1.Enabled = false;
            Fillcombo();
            Fillcombo1();
            Fillcombo2();
            Fillcombo3();
        }
        void Fillcombo()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from PurchaseRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    //string CName = myReader.GetString(myReader.GetOrdinal("ID"));
                   // comboBox5.Items.Add(CName);
                    var CName = myReader.GetDecimal(myReader.GetOrdinal("Supplier_Account_Number"));
                    comboBox5.Items.Add(CName);
                   // MessageBox.Show(CName.ToString());

                }
            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }
        void Fillcombo1()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from SalesRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Salesman_name"));
                    comboBox2.Items.Add(CName);

                }
            }
            catch
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");

            }

        }

        void Fillcombo2()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from SalesRegistration";
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
                    var CName = myReader.GetDecimal(myReader.GetOrdinal("Salesman_Account_Number"));
                    comboBox3.Items.Add(CName);

                }
            }
            catch 
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }
        void Fillcombo3()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            
            string Query = "select * from PurchaseRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Purchased_From"));
                    comboBox4.Items.Add(CName);

                }
            }
            catch 
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            _selectedIndex = comboBox1.SelectedIndex;
            if (_selectedIndex == 0)
            {
                label3.Enabled = true;
                comboBox2.Enabled = true;
                label4.Enabled = false;
                comboBox3.Enabled = false;
                label5.Enabled = false;
                comboBox4.Enabled = false;
                label6.Enabled = false;
                comboBox5.Enabled = false;
                dataGridView2.Enabled = false;


            }
            else if (_selectedIndex == 1)
            {


                label3.Enabled = false;
                comboBox2.Enabled = false;
                label4.Enabled = true;
                comboBox3.Enabled = true;
                label5.Enabled = false;
                comboBox4.Enabled = false;
                label6.Enabled = false;
                comboBox5.Enabled = false;
                dataGridView2.Enabled = false;
            }
            else if (_selectedIndex == 2)
            {
                label3.Enabled = false;
                comboBox2.Enabled = false;
                label4.Enabled = false;
                comboBox3.Enabled = false;
                label5.Enabled = true;
                comboBox4.Enabled = true;
                label6.Enabled = false;
                comboBox5.Enabled = false;
                dataGridView1.Enabled = false;

            }
            else if (_selectedIndex == 3)
            {
                label3.Enabled = false;
                comboBox2.Enabled = false;
                label4.Enabled = false;
                comboBox3.Enabled = false;
                label5.Enabled = false;
                comboBox4.Enabled = false;
                label6.Enabled = true;
                comboBox5.Enabled = true;
                dataGridView1.Enabled = false;

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
             _selectedIndex = comboBox1.SelectedIndex;
            if (_selectedIndex == 0)
            {
                if (comboBox2.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Select Salesman Name!");
                    return;
                }



                _selectedSubIndex = comboBox2.SelectedIndex;
                selectedCategory = comboBox1.Text;
                selectedSubCategory = comboBox2.Text;
            
                //SQL query
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

                    command.CommandText = "SELECT * FROM SalesRegistration Where Salesman_name=@Salesman_name";
                    command.Parameters.AddWithValue("@Salesman_name",comboBox2.Text );
                   
               
              
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "SalesRegistration");
                dataGridView1.DataSource = ds.Tables["SalesRegistration"];

               
             



                SqlDataReader Reader = command.ExecuteReader();
                button3.Enabled = true;
                  


            }
            catch
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

            

                }
            else if (_selectedIndex == 1)
            {

                
                    if (comboBox3.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Select Salesman Account Number!");
                        return;
                    }
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

                        command.CommandText = "SELECT * FROM SalesRegistration Where Salesman_Account_Number=@Salesman_Account_Number";
                        command.Parameters.AddWithValue("@Salesman_Account_Number", comboBox3.Text);



                        SqlDataAdapter da = new SqlDataAdapter(command);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "SalesRegistration");
                        dataGridView1.DataSource = ds.Tables["SalesRegistration"];
                    SqlDataReader Reader = command.ExecuteReader();
                    button3.Enabled = true;

                    }
                    catch 
                    {
                       // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
                    }
                
            }
            else if (_selectedIndex == 2)
            {
                if (comboBox4.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Select Supplier Name !");
                    return;
                }



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
                    command.CommandText = "SELECT * FROM PurchaseRegistration Where Purchased_From=@Purchased_From";
                    command.Parameters.AddWithValue("@Purchased_From", comboBox4.Text);
                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PurchaseRegistration");
                    dataGridView2.DataSource = ds.Tables["PurchaseRegistration"];
                    SqlDataReader Reader = command.ExecuteReader();
                    button4.Enabled = true;
                }
                catch 
                {
                    //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
                }

            }
            else if (_selectedIndex == 3)
            {


                if (comboBox5.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Please Select Supplier Account Number!");
                    return;
                }
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

                    command.CommandText = "SELECT * FROM PurchaseRegistration Where Supplier_Account_Number=@Supplier_Account_Number";
                    command.Parameters.AddWithValue("@Supplier_Account_Number", comboBox5.Text);



                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "PurchaseRegistration");
                    dataGridView2.DataSource = ds.Tables["PurchaseRegistration"];






                    SqlDataReader Reader = command.ExecuteReader();
                    button4.Enabled = true;


                }
                catch 
                {
                  //  MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
                }
            }
            
            }

        private void PaymentRegistrationform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.PurchaseRegistration' table. You can move, or remove it, as needed.
            //this.purchaseRegistrationTableAdapter.Fill(this.marketDataSet.PurchaseRegistration);
// TODO: This line of code loads data into the 'marketDataSet.SalesmanRegistration' table. You can move, or remove it, as needed.
this.salesmanRegistrationTableAdapter.Fill(this.marketDataSet.SalesmanRegistration);
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            comboBox1.SelectedIndex = -1;
            button3.Enabled = false;
            button4.Enabled = false;
            button1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
                
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SalesRegistrationform su = new SalesRegistrationform();
            su.Show();
           // this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PurchaseRegistrationform su = new PurchaseRegistrationform();
            su.Show();
           // this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        }

    }
