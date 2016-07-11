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
    public partial class SearchSupplierform : Form
    {
        int _selectedIndex;
        public SearchSupplierform()
        {
            
            InitializeComponent();
            this.dataGridView2.ReadOnly = true;

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            Fillcombo2();
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            button1.Enabled = false;
            Fillcombo1();
            Fillcombo();
            button1.Enabled = false;


            dataGridView2.DataSource = null;
        }
        void Fillcombo2()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from SupplierRegistration";
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
                    var CName = myReader.GetDecimal(myReader.GetOrdinal("ID"));
                    comboBox2.Items.Add(CName);
                   // MessageBox.Show(CName.ToString());

                }
            }
            catch 
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }
         void Fillcombo()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from SupplierRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Name_Of_The_Company"));
                    comboBox3.Items.Add(CName);

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
             string Query = "select * from SupplierRegistration";
             SqlConnection connectionDatabase = new SqlConnection(connectionString);
             SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
             SqlDataReader myReader;

             try
             {
                 connectionDatabase.Open();
                 myReader = commandDatabase.ExecuteReader();

                 while (myReader.Read())
                 {
                     string CName = myReader.GetString(myReader.GetOrdinal("ID"));
                     comboBox2.Items.Add(CName);

                 }
             }
             catch 
             {
                // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
             }

         }

        

        private void SearchSupplierform_Load(object sender, EventArgs e)
        {
            

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
                _selectedIndex = comboBox1.SelectedIndex;
                if (_selectedIndex == 0)
                {

                    command.CommandText = " select * from SupplierRegistration ";

                }
                else if (_selectedIndex == 1)
                {
                    if (comboBox3.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Select Supplier Name!");
                        return;
                    }
                    command.CommandText = " select * from SupplierRegistration  where  Name_Of_The_Company='" + comboBox3.Text + "'";
                }
                else if (_selectedIndex == 2)
                {
                    if (comboBox2.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Select Supplier Name!");
                        return;
                    }
                    command.CommandText = " select * from SupplierRegistration  where ID='" + comboBox2.Text + "'";
                }
                
               
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "SupplierRegistration");
                dataGridView2.DataSource = ds.Tables["SupplierRegistration"];






                SqlDataReader Reader = command.ExecuteReader();



            }
            catch 
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }


        }

        private void SearchSupplierform_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.SupplierRegistration' table. You can move, or remove it, as needed.
            this.supplierRegistrationTableAdapter.Fill(this.marketDataSet.SupplierRegistration);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIndex = comboBox1.SelectedIndex;
            if (_selectedIndex == 0)
            {
                comboBox3.Enabled = false;
                comboBox2.Enabled = false;
                button1.Enabled = true;

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
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            button1.Enabled = false;
            comboBox3.Enabled = false;
            comboBox2.Enabled = false;
            dataGridView2.DataSource = null;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
