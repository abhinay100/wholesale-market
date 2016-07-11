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
using System.IO;
using System.IO.Ports;




namespace WindowsFormsApplication22
{
    public partial class PurchaseRegistrationform : Form
    {
       
       int _selectedIndex;
        public PurchaseRegistrationform()
        {
            InitializeComponent();
         //   MessageBox.Show("Please select product name");
            this.PurchasedfromcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.GradecomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ProductcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        //    MessageBox.Show("Please select product name");
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
         //   MessageBox.Show("Please select product name");
            Fillcombo2();
            Fillcombo();
            Fillcombo1();
            Fillcombo3();
            Filltextbox();
            Fillcombo4();
        //    MessageBox.Show("Please select product name");
            // String.Format("{0:n}", 1000);
            button3.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;

            FinalvaluewithTAXtextBox.MaxLength = 5;
        //    MessageBox.Show("Please select product name1111");
        }
                     
        

        void Filltextbox()
        {
            SqlConnection connection;

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString); ;


            connection.Open();
            try
            {

                SqlCommand command = new SqlCommand("select max(Purchase_ID) from PurchaseRegistration", connection);

                command.ExecuteScalar();
                PurchasedinvoicenumbertextBox.Text = (command.ExecuteScalar().ToString());
                // MessageBox.Show(PurchasedinvoicenumbertextBox.Text);
                int i = (Convert.ToInt32(PurchasedinvoicenumbertextBox.Text) + 1);
                // MessageBox.Show(i.ToString());
                PurchasedinvoicenumbertextBox.Text = "PRC" + i.ToString();
                //  MessageBox.Show(PurchasedinvoicenumbertextBox.Text );

            }
            catch (SqlException exc)
            {

      //          MessageBox.Show("line number 78 Network related issues please check internet connection1" + exc);
            }
       //     MessageBox.Show("Please select product name");
        }
        void Fillcombo4()
        {

            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select Company_Account_Number from SupplierRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    var CName = myReader.GetDecimal(myReader.GetOrdinal("Company_Account_Number"));
                    comboBox4.Items.Add(CName);

                }
            }
            catch (SqlException exc)
            {

    //            MessageBox.Show("line number 78 Network related issues please check internet connection2" + exc);
            }

     //       MessageBox.Show("Please select product name");

        }
        void Fillcombo3()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);

            string Query = "select Grade_of_the_product from ProductRegistration";
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
                    GradecomboBox.Items.Add(CName);

                }
            }
            catch (SqlException exc)
            {

  //              MessageBox.Show("line number 78 Network related issues please check internet connection3" + exc);
            }
 //           MessageBox.Show("Please select product name");

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
                    comboBox1.Items.Add(CName);

                }
            }
            catch (SqlException exc)
            {

   //             MessageBox.Show("line number 78 Network related issues please check internet connection4" + exc);
            }
  //          MessageBox.Show("Please select product name");


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
                    PurchasedfromcomboBox.Items.Add(CName);

                }
            }
            catch (SqlException exc)
            {

  //              MessageBox.Show("line number 78 Network related issues please check internet connection5" + exc);
            }




 //           MessageBox.Show("Please select product name");



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
                    string CName = myReader.GetString(myReader.GetOrdinal("Name_of_the_product"));
                    ProductcomboBox.Items.Add(CName);

                }
            }
            catch (SqlException exc)
            {

   //             MessageBox.Show("line number 78 Network related issues please check internet connection6" + exc);
            }

    //        MessageBox.Show("Please select product name666");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PurchasedfromcomboBox.SelectedIndex = -1;
            PurchasedinvoicenumbertextBox.Clear();
            ProductcomboBox.SelectedIndex = -1;
            GradecomboBox.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            QuantitytextBox.Clear();
            DamagequantitytextBox.Clear();
            ActualQuantitytextBox.Clear();
            ValueoftheproducttextBox.Clear();
            FinalvaluewithTAXtextBox.Clear();
            dateTimePicker1.ResetText();
            ResetConnection();
        }
        private void ResetConnection()
        {

            serialPort1.Dispose();
            serialPort1.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (PurchasedfromcomboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select purchased from or supplier name!");
                return;
            }
            else if (PurchasedinvoicenumbertextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Purchased invoice number");
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
                command.CommandText = "INSERT into PurchaseRegistration(Purchased_From,Purchased_Invoice_Number,Product,Grade,Unit,Quantity,Damage_Quantity,Actual_Quantity,Value_of_the_product,Final_Value_WithTax,Date,Price_per_Unit,Supplier_Account_Number,Paid,Balance)VALUES(@Purchased_From,@Purchased_Invoice_Number,@Product,@Grade,@Unit,@Quantity,@Damage_Quantity,@Actual_Quantity,@Value_of_the_product,@Final_Value_WithTax,@Date,@Price_per_Unit,@Supplier_Account_Number,@Paid,@Balance)";
                command.Parameters.AddWithValue("@Purchased_From", PurchasedfromcomboBox.Text);
                command.Parameters.AddWithValue("@Purchased_Invoice_Number", PurchasedinvoicenumbertextBox.Text);
                command.Parameters.AddWithValue("@Product", ProductcomboBox.Text);
                command.Parameters.AddWithValue("@Grade", GradecomboBox.Text);
                command.Parameters.AddWithValue("@Unit", comboBox1.Text);
                command.Parameters.AddWithValue("@Quantity", QuantitytextBox.Text);
                command.Parameters.AddWithValue("@Damage_Quantity", DamagequantitytextBox.Text);
                command.Parameters.AddWithValue("@Actual_Quantity", ActualQuantitytextBox.Text);
                command.Parameters.AddWithValue("@Value_of_the_product", ValueoftheproducttextBox.Text);
                command.Parameters.AddWithValue("@Final_Value_WithTax", FinalvaluewithTAXtextBox.Text);
                command.Parameters.AddWithValue("@Date", DateTime.Parse(dateTimePicker1.Text));
                command.Parameters.AddWithValue("@Price_per_Unit", textBox2.Text);
                command.Parameters.AddWithValue("@Supplier_Account_Number", comboBox4.Text);
                command.Parameters.AddWithValue("@Paid", textBox3.Text);
                command.Parameters.AddWithValue("@Balance", textBox4.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");
                button3.Enabled = true;






            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        private void button3_Click(object sender, EventArgs e)
        {
            Filllabel();

            Form1 f1 = new Form1();
            this.Hide();
            f1.label15.Text = ProductcomboBox.Text.ToString();
            f1.label16.Text = GradecomboBox.Text.ToString();
            f1.label12.Text = textBox2.Text.ToString();
            f1.label18.Text = QuantitytextBox.Text.ToString();
            f1.label19.Text = DamagequantitytextBox.Text.ToString();
            f1.label20.Text = ActualQuantitytextBox.Text.ToString();
            f1.label2.Text = PurchasedfromcomboBox.Text.ToString();
            f1.label22.Text = FinalvaluewithTAXtextBox.Text.ToString();
            f1.label17.Text = dateTimePicker1.Text.ToString();
            f1.label21.Text = FinalvaluewithTAXtextBox.Text.ToString();
            f1.label24.Text = label15.Text.ToString();
            f1.Show();


            SqlConnection connection;
            SqlCommand cmd = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);

            try
            {

                connection.Open();
                cmd.Connection = connection;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "update PurchaseRegistration set Receipt_Number=@Receipt_Number where Purchased_From=@Purchased_From and Product=@Product and Grade=@Grade";

                cmd.Parameters.AddWithValue("@Purchased_From", PurchasedfromcomboBox.Text);
                cmd.Parameters.AddWithValue("@Product", ProductcomboBox.Text);
                cmd.Parameters.AddWithValue("@Grade", GradecomboBox.Text);
                //MessageBox.Show(PurchasedfromcomboBox.Text);

                cmd.Parameters.AddWithValue("@Receipt_Number", label15.Text);
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

                SqlCommand command = new SqlCommand("select max(Purchase_ID) from PurchaseRegistration", conn);

                command.ExecuteScalar();
                label15.Text = (command.ExecuteScalar().ToString());
                int i = (Convert.ToInt32(label15.Text) + 1);
                //MessageBox.Show(i.ToString());
                label15.Text = "P100" + i.ToString();
                label15.Hide();
                //  MessageBox.Show(PurchasedinvoicenumbertextBox.Text );


            }
            finally
            {
                conn.Close();
            }
        }
        private void PurchasedfromcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

        }

        private void FinalvaluewithTAXtextBox_TextChanged(object sender, EventArgs e)
        {
            FinalvaluewithTAXtextBox.MaxLength = 5;
        }

        private void PurchaseRegistrationform_Load(object sender, EventArgs e)
        {
            string[] strPortNames = SerialPort.GetPortNames();
            foreach (string n in strPortNames)
            {
                comboBox3.Items.Add(n);

            }
            //comboBox3.SelectedIndex = 0;

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

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            _selectedIndex = comboBox2.SelectedIndex;

            if (_selectedIndex == 2)
            {
                textBox1.Enabled = false;
            }
        }

        private void ActualQuantitytextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == null)
            {
                MessageBox.Show("Please enter Price Per unit Value");
            }
            else
            {
                ValueoftheproducttextBox.Text = (Convert.ToDecimal(textBox2.Text) * Convert.ToDecimal(ActualQuantitytextBox.Text)).ToString();
            }
        }

        private void FinalvaluewithTAXtextBox_Validating(object sender, CancelEventArgs e)
        {

            _selectedIndex = comboBox2.SelectedIndex;
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

        private void ActualQuantitytextBox_Validating(object sender, CancelEventArgs e)
        {

            // ActualQuantitytextBox.Text = (Convert.ToDecimal(QuantitytextBox.Text) - Convert.ToDecimal(DamagequantitytextBox.Text)).ToString();

        }

        private void ValueoftheproducttextBox_Validating(object sender, CancelEventArgs e)
        {

            // if (textBox2.Text == null)
            // {
            //  MessageBox.Show("Please enter Price Per unit Value");
            //}
            //else
            // {
            //    ValueoftheproducttextBox.Text = (Convert.ToDecimal(textBox2.Text) * Convert.ToDecimal(ActualQuantitytextBox.Text)).ToString();
            // }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // decimal decimalVal = 0;
            string s = serialPort1.ReadLine().ToString();



            QuantitytextBox.Text = s.ToString();

            decimal temp = ((Convert.ToDecimal(QuantitytextBox.Text) / 100));
            QuantitytextBox.Text = temp.ToString();



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            QuantitytextBox.Clear();
            QuantitytextBox.Clear();
            serialPort1.Close();
            serialPort1.PortName = comboBox3.SelectedItem + "";
            //MessageBox.Show(serialPort1.PortName);
            serialPort1.Open();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            // QuantitytextBox.Clear();

            QuantitytextBox.Text = (Convert.ToDecimal(label18.Text) - Convert.ToDecimal(QuantitytextBox.Text)).ToString();


        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            // textBox4.Text = (Convert.ToDecimal(FinalvaluewithTAXtextBox.Text) - Convert.ToDecimal(textBox3.Text)).ToString();
        }

        private void DamagequantitytextBox_TextChanged(object sender, EventArgs e)
        {
            if (QuantitytextBox.Text == null && DamagequantitytextBox.Text == null)
            {
                MessageBox.Show("Please enter Quantity and Damage Quantity  of Product");
            }
            else
            {
                ActualQuantitytextBox.Text = (Convert.ToDecimal(QuantitytextBox.Text) - Convert.ToDecimal(DamagequantitytextBox.Text)).ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            _selectedIndex = comboBox2.SelectedIndex;
            if (_selectedIndex == 0)
            {
                decimal temp = (((Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(ValueoftheproducttextBox.Text)) * 100));
                FinalvaluewithTAXtextBox.MaxLength = 5;
                FinalvaluewithTAXtextBox.Text = temp.ToString();

            }
            else if (_selectedIndex == 1)
            {
                decimal temp = (((Convert.ToDecimal(textBox1.Text) / Convert.ToDecimal(ValueoftheproducttextBox.Text)) * 100));
                FinalvaluewithTAXtextBox.MaxLength = 5;
                FinalvaluewithTAXtextBox.Text = temp.ToString();


            }
            else if (_selectedIndex == 2)
            {
                textBox1.Enabled = false;
                FinalvaluewithTAXtextBox.Text = ValueoftheproducttextBox.Text;

            }

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == null)
            {
                MessageBox.Show("Please enter the Paid Amount");
            }
            textBox4.Text = (Convert.ToDecimal(FinalvaluewithTAXtextBox.Text) - Convert.ToDecimal(textBox3.Text)).ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValueoftheproducttextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void QuantitytextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}