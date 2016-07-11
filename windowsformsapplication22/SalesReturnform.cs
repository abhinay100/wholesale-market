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
    public partial class SalesReturnform : Form
    {
        public SalesReturnform()
        {
            InitializeComponent();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
      
            Fillcombo();
            Fillcombo1();

        }
        void Fillcombo1()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();    
         string  connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
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
                    var CName = myReader.GetDecimal(myReader.GetOrdinal("Salesman_Account_Number"));
                    comboBox1.Items.Add(CName);

                }
            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");

            }


        }

        void Fillcombo()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            
         string  connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
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
                    string CName = myReader.GetString(myReader.GetOrdinal("Receipt_Number"));
                    comboBox2.Items.Add(CName);
                    
                }
            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select Account Number!");
                return;
            }
           
            else if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Total Quantity!");
                return;
            }
            else if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Receipt value");
                return;
            }
            else if (textBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Quantity sold!");
                return;
            }
            else if (textBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill the value of sold product");
                return;
            }
            else if (textBox5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Damage Quantity!");
                return;
            }
            else if (textBox6.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter stock in hand!");
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
                command.CommandText = "INSERT into SalesReturn (Salesman_Account_Number,Receipt_Number,Receipt_Value,Total_Quantity,Quantity_Sold,Value_of_the_Sold_Product,Damaged_Quantity,Stock_in_Hand,Final_Value,Payment_Made,Balance,Price_Per_Unit,Unit,Damaged_Quantity_value,Date)VALUES(@Salesman_Account_Number,@Receipt_Number,@Total_Quantity,@Quantity_Sold,@Value_of_the_Sold_Product,@Damaged_Quantity,@Stock_in_Hand,@Final_Value,@Payment_Made,@Balance,@Receipt_Value,@Price_Per_Unit,@Unit,@Damaged_Quantity_value,@Date)";
                command.Parameters.AddWithValue("@Salesman_Account_Number", comboBox1.Text);
                command.Parameters.AddWithValue("@Receipt_Number", comboBox2.Text);
                command.Parameters.AddWithValue("@Total_Quantity", textBox1.Text);
                command.Parameters.AddWithValue("@Quantity_Sold",textBox3.Text);
                command.Parameters.AddWithValue("@Value_of_the_Sold_Product", textBox4.Text);
                command.Parameters.AddWithValue("@Damaged_Quantity", textBox5.Text);
                command.Parameters.AddWithValue("@Stock_in_Hand", textBox6.Text);
                command.Parameters.AddWithValue("@Final_Value", textBox7.Text);
                command.Parameters.AddWithValue("@Payment_Made", textBox8.Text);
                command.Parameters.AddWithValue("@Balance", textBox9.Text);
                command.Parameters.AddWithValue("@Receipt_Value", textBox2.Text);
                command.Parameters.AddWithValue("@Price_Per_Unit", textBox10.Text);
                command.Parameters.AddWithValue("@Unit", textBox11.Text);
                command.Parameters.AddWithValue("@Damaged_Quantity_value", textBox12.Text);
                command.Parameters.AddWithValue("@Date", DateTime.Parse(dateTimePicker1.Text));
             




                command.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
      
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            dateTimePicker1.ResetText();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
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
                command.CommandText = "Select * from SalesRegistration where Salesman_Account_Number=@Salesman_Account_Number and Receipt_Number=@Receipt_Number";

                command.Parameters.AddWithValue("@Salesman_Account_Number", comboBox1.Text);
                command.Parameters.AddWithValue("@Receipt_Number", comboBox2.Text);
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    textBox1.Text = dr["Actual_Quantity"].ToString();

                    textBox2.Text = dr["Final_Value_WithTAX"].ToString();

                    textBox11.Text = dr["Price_per_KG"].ToString();

                    textBox10.Text = dr["Price_per"].ToString();

                    dateTimePicker1.Text = dr["Date"].ToString();




                }
            }
            catch
            {
             //   MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = (Convert.ToDecimal(textBox10.Text) * Convert.ToDecimal(textBox3.Text)).ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox12.Text = (Convert.ToDecimal(textBox10.Text) * Convert.ToDecimal(textBox5.Text)).ToString();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = (Convert.ToDecimal(textBox3.Text) * Convert.ToDecimal(textBox5.Text)).ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox9.Text = (Convert.ToDecimal(textBox6.Text) * Convert.ToDecimal(textBox10.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
