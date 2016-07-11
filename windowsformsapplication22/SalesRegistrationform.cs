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
using System.Drawing.Printing;
using System.IO.Ports;
namespace WindowsFormsApplication22
{
    public partial class SalesRegistrationform : Form
    {
       int _selectedIndex;
        public SalesRegistrationform()
        {
            InitializeComponent();
            this.SalesmancomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ProductcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.GradecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
           // this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
           
            Fillcombo2();
            Fillcombo3();
            Fillcombo4();
            Fillcombo();
            Fillcombo1();
            CheckForIllegalCrossThreadCalls = false;

            FinalvaluewithTAXtextBox.MaxLength = 5;
            button3.Enabled = false;
           
        }
        void Fillcombo4()
        {

            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString); ;
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
                    var CName = myReader.GetDecimal(myReader.GetOrdinal("Account_Number"));
                    comboBox2.Items.Add(CName);
                   
                }
            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }


        }
        void Fillcombo3()
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
                    comboBox1.Items.Add(CName);

                }
            }
            catch 
            {
              //  MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

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
                    string Nproduct = myReader.GetString(myReader.GetOrdinal("Name"));
                    SalesmancomboBox1.Items.Add(Nproduct);

                }
            }
            catch
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

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
                    string Nproduct = myReader.GetString(myReader.GetOrdinal("Name_of_the_product"));
                    ProductcomboBox.Items.Add(Nproduct);
                   

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
                    string Nproduct = myReader.GetString(myReader.GetOrdinal("Grade_of_the_product"));
                    GradecomboBox.Items.Add(Nproduct);


                }
            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SalesmancomboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            dateTimePicker1.ResetText();

            comboBox1.SelectedIndex = -1;
            QuantitytextBox.Clear();
            DamageQuantitytextBox.Clear();
            ActualQuantitytextBox.Clear();
            ValueoftheproducttextBox.Clear();
            FinalvaluewithTAXtextBox.Clear();
            ProductcomboBox.SelectedIndex = -1;
            GradecomboBox.SelectedIndex = -1;
            ResetConnection();
        }
        private void ResetConnection()
        {
            serialPort1.Dispose();
            serialPort1.Close();  
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (SalesmancomboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select Selesman name!");
                return;
            }
            else if (comboBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Select the account number");
                return;
            }
            else if (ProductcomboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select product name");
                return;
            }
            else if (GradecomboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select grade of the product");
                return;
            }
            else if (comboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select unit");
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
                command.CommandText = "INSERT into SalesRegistration(Salesman_name,Salesman_Account_Number,Product,Grade,Price_per_KG,Quantity,Damage_Quantity,Actual_Quantity,Value_of_the_product,Final_Value_WithTax,Date,Price_per)VALUES(@Salesman_name,@Salesman_Account_Number,@Product,@Grade,@Price_per_KG,@Quantity,@Damage_Quantity,@Actual_Quantity,@Value_of_the_product,@Final_Value_WithTax,@Date,@Price_per)";
                command.Parameters.AddWithValue("@Salesman_name", SalesmancomboBox1.Text);
                command.Parameters.AddWithValue("@Salesman_Account_Number", comboBox2.Text);
                command.Parameters.AddWithValue("@Product",  ProductcomboBox.Text);
                command.Parameters.AddWithValue("@Grade", GradecomboBox.Text);
                command.Parameters.AddWithValue("@Price_per_KG", comboBox1.Text);
                command.Parameters.AddWithValue("@Quantity", QuantitytextBox.Text);
                command.Parameters.AddWithValue("@Damage_Quantity", DamageQuantitytextBox.Text);
                command.Parameters.AddWithValue("@Actual_Quantity", ActualQuantitytextBox.Text);
                command.Parameters.AddWithValue("@Value_of_the_product", ValueoftheproducttextBox.Text);
                command.Parameters.AddWithValue("@Final_Value_WithTax",FinalvaluewithTAXtextBox.Text);
                command.Parameters.AddWithValue("@Date", DateTime.Parse(dateTimePicker1.Text));

                command.Parameters.AddWithValue("@Price_per", textBox2.Text);
               

                command.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");
                button3.Enabled = true;

            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void SalesRegistrationform_Load(object sender, EventArgs e)
        {
            string[] strPortNames = SerialPort.GetPortNames();
            foreach (string n in strPortNames)
            {
                comboBox3.Items.Add(n);

            }
           // comboBox3.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Filllabel();
            Form2 f2 = new Form2();
            this.Hide();
            f2.label1.Text = SalesmancomboBox1.Text.ToString();
       
            f2.label40.Text = dateTimePicker1.Text.ToString();
            f2.label8.Text = ProductcomboBox.Text.ToString();

            f2.label10.Text = GradecomboBox.Text.ToString();




            f2.label4.Text = label17.Text.ToString();
     

            f2.label14.Text = ActualQuantitytextBox.Text.ToString();

            f2.label25.Text = textBox2.Text.ToString();
           

            f2.label38.Text = FinalvaluewithTAXtextBox.Text.ToString();

            f2.Show();
         
            SqlConnection connection;
            SqlCommand cmd = new SqlCommand();


            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            try
            {

                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update SalesRegistration Receipt_Number=@Receipt_Number where (Salesman_name=@Salesman_name and Salesman_Account_Number=@Salesman_Account_Number)";

                cmd.Parameters.AddWithValue("@Salesman_name", SalesmancomboBox1.Text);
                //MessageBox.Show(PurchasedfromcomboBox.Text);
                cmd.Parameters.AddWithValue("@Salesman_Account_Number", comboBox2.Text);
                cmd.Parameters.AddWithValue("@Receipt_Number", label17.Text);
                //MessageBox.Show(label15.Text);
                cmd.ExecuteNonQuery();
            }
            catch 
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }
        void Filllabel()
        {

            SqlConnection connection;


            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();
            try
            {

                SqlCommand command = new SqlCommand("select max(Sales_ID) from SalesRegistration", conn);

                command.ExecuteScalar();
                label15.Text = (command.ExecuteScalar().ToString());
                int i = (Convert.ToInt32(label15.Text) + 1);
                //MessageBox.Show(i.ToString());
                label17.Text = "S100" + i.ToString();
                label17.Hide();
                //  MessageBox.Show(PurchasedinvoicenumbertextBox.Text );


            }
            finally
            {
                conn.Close();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            QuantitytextBox.Clear();
            QuantitytextBox.Clear();
            serialPort1.Close();
            serialPort1.PortName = comboBox3.SelectedItem + "";
            //MessageBox.Show(serialPort1.PortName);
            serialPort1.Open();

        }

        private void DamageQuantitytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ActualQuantitytextBox_Validating(object sender, CancelEventArgs e)
        {
            ActualQuantitytextBox.Text = (Convert.ToDecimal(QuantitytextBox.Text) - Convert.ToDecimal(DamageQuantitytextBox.Text)).ToString();
        
        }

        private void ValueoftheproducttextBox_Validating(object sender, CancelEventArgs e)
        {
            ValueoftheproducttextBox.Text = (Convert.ToDecimal(textBox2.Text) * Convert.ToDecimal(ActualQuantitytextBox.Text)).ToString();
        
        }

        private void FinalvaluewithTAXtextBox_Validating(object sender, CancelEventArgs e)
        {
            _selectedIndex = comboBox4.SelectedIndex;
            if (_selectedIndex == 2)
            {
                textBox1.Enabled = false;
                FinalvaluewithTAXtextBox.Text = ValueoftheproducttextBox.Text;
            }
            else
            {
                decimal temp = ((Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(ValueoftheproducttextBox.Text) * 100));
                FinalvaluewithTAXtextBox.MaxLength = 5;
                FinalvaluewithTAXtextBox.Text = temp.ToString();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string s = serialPort1.ReadLine().ToString();

            // textBox1.AppendText("\n");

            //string number = textBox1.Text;
            //MessageBox.Show(number);
            QuantitytextBox.Text = s.ToString();

            decimal temp = ((Convert.ToDecimal(QuantitytextBox.Text) / 100));
            QuantitytextBox.Text = temp.ToString();
         
            // serialPort1.Close();
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
