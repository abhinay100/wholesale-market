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
using Microsoft.Office.Interop;
using System.IO;

using System.Reflection;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;


namespace WindowsFormsApplication22
{
    public partial class SearchStockform : Form
    {
        int _selectedIndex;
        public SearchStockform()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            Fillcombo();
            button3.Enabled = false;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            dataGridView1.DataSource = null;
           // int i = 1; foreach (DataGridViewRow row in dataGridView1.Rows) { row.Cells["SNO"].Value = i; i++; }

        }
        void Fillcombo()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from ProductRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Name_of_the_product"));
                    comboBox1.Items.Add(CName);

                }
            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }
        private void SearchStockform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.ProductRegistration' table. You can move, or remove it, as needed.
            this.productRegistrationTableAdapter.Fill(this.marketDataSet.ProductRegistration);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Select the Product Name!");
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
              

                command.CommandText = "SELECT * from ProductRegistration Where Name_of_the_product='" + comboBox1.Text + "'  ";


                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "ProductRegistration");
                dataGridView1.DataSource = ds.Tables["ProductRegistration"];

                //int i = 1; foreach (DataGridViewRow row in dataGridView1.Rows) { row.Cells["SNO"].Value = i; i++; }

                SqlDataReader Reader = command.ExecuteReader();



            }
            catch
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");

            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
          
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
                command.CommandText = "UPDATE ProductRegistration set Name_of_the_product='"+comboBox1.Text+"'";


                command.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");


            }
            catch
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           button3.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button3.Enabled = false;
            dataGridView1.DataSource = null;
            comboBox1.SelectedIndex = -1;
        }
        
       
        }
        }

        

       
    

           

