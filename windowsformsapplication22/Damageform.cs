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
using System.IO;
using System.IO.Ports;


namespace WindowsFormsApplication22
{
    public partial class Damageform : Form
    {
        public Damageform()
        {
            InitializeComponent();
            Fillcombo();
            Fillcombo1();
           Fillcombo2();
           CheckForIllegalCrossThreadCalls = false;
           this.dateTimePicker1.Value = DateTime.Now;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;

           // this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        void Fillcombo1()
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
                    string CName = myReader.GetString(myReader.GetOrdinal("Grade_of_the_product"));
                    comboBox1.Items.Add(CName);

                }
            }
            catch (Exception ex)
            {

            }

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
                    comboBox2.Items.Add(CName);

                }
            }
            catch 
            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }
        void Fillcombo2()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from MeasurementRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Measurement"));
                    comboBox3.Items.Add(CName);

                }
            }
            catch 
            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            SqlConnection connection;
            SqlCommand command = new SqlCommand();


            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT into DamageForm (Product,Grade,Quantity,Price,Handling_Damage,Godown_Damage,Unit,Date,Price_Per_Unit) VALUES (@Product,@Grade,@Quantity,@Price,@Handling_Damage,@Godown_Damage,@Unit,@Date,@Price_Per_Unit)";
                command.Parameters.AddWithValue("@Product", comboBox2.Text);
                command.Parameters.AddWithValue("@Grade", comboBox1.Text);
                command.Parameters.AddWithValue("@Quantity",textBox1.Text);
                command.Parameters.AddWithValue("@Price", textBox3.Text);
                command.Parameters.AddWithValue("@Handling_Damage", QuantitytextBox.Text);
                command.Parameters.AddWithValue("@Godown_Damage", textBox5.Text);
                command.Parameters.AddWithValue("@Unit", comboBox3.Text);
                command.Parameters.AddWithValue("@Date", DateTime.Parse(dateTimePicker1.Text));
                command.Parameters.AddWithValue("@Price_Per_Unit", textBox2.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Registered Successfully");
                return;

            }
            catch
            {
               MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void Damageform_Load(object sender, EventArgs e)

        {
           
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
         
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.ResetText();
            textBox5.Clear();
            QuantitytextBox.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
                textBox3.Text = (Convert.ToDecimal(textBox2.Text) * Convert.ToDecimal(textBox1.Text)).ToString();
            
        }

        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string s = serialPort2.ReadLine().ToString();

            QuantitytextBox.Text = s.ToString();

            decimal temp = ((Convert.ToDecimal(QuantitytextBox.Text) / 100));
            QuantitytextBox.Text = temp.ToString();
            //serialPort2.Dispose();
        }
    }
}
