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
    public partial class DamageRegistrationform : Form
    {
        public DamageRegistrationform()
        {
            InitializeComponent();
            this.NameoftheproductcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.GradeoftheproductcomboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            Fillcombo();
            Fillcombo1();


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
                    NameoftheproductcomboBox1.Items.Add(CName);

                }
            }
            catch 
            {
                MessageBox.Show("Network related issues please check internet connection");
            }
        }
        void Fillcombo1()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand(); string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
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
                    GradeoftheproductcomboBox2.Items.Add(CName);

                }
            }
            catch
            {
                MessageBox.Show("Network related issues please check internet connection");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameoftheproductcomboBox1.SelectedIndex = -1;
            GradeoftheproductcomboBox2.SelectedIndex = -1;
            dateTimePicker1.ResetText();
            QuantitytextBox.Clear();
            pricetextbox.Clear();
            HandlinDamagetextBox.Clear();
            GodowndamagetextBox.Clear();
            SalesDamagetextBox.Clear();
            TransitDamagetextBox.Clear();



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
               if (NameoftheproductcomboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select name of the product!");
                return;
            }

               else if (GradeoftheproductcomboBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select grade of product");
                return;
            }

               else if (QuantitytextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter the Quantity");
                return;
            }
               else if (HandlinDamagetextBox.Text.Trim() == string.Empty)
               {
                   MessageBox.Show("Please Enter the Quantity");
                   return;
               }
               else if (pricetextbox.Text.Trim() == string.Empty)
               {
                   MessageBox.Show("Please Enter the Quantity");
                   return;
               }
               else if (GodowndamagetextBox.Text.Trim() == string.Empty)
               {
                   MessageBox.Show("Please Enter the Quantity");
                   return;
               }
               else if (SalesDamagetextBox.Text.Trim() == string.Empty)
               {
                   MessageBox.Show("Please Enter the Quantity");
                   return;
               }
               else if (TransitDamagetextBox.Text.Trim() == string.Empty)
               {
                   MessageBox.Show("Please Enter the Quantity");
                   return;
               }
               else if (System.Text.RegularExpressions.Regex.IsMatch(QuantitytextBox.Text, "[^0-9.]"))
               {
                   MessageBox.Show("Please enter correct Quantity of product!");
                   //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                   QuantitytextBox.Focus();
                   return;
               }
               else if (System.Text.RegularExpressions.Regex.IsMatch(pricetextbox.Text, "[^0-9.]"))
               {
                   MessageBox.Show("Please enter correct Price!");
                   //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                   pricetextbox.Focus();
                   return;
               }
               else if (System.Text.RegularExpressions.Regex.IsMatch(HandlinDamagetextBox.Text, "[^0-9.]"))
               {
                   MessageBox.Show("Please enter correct Handling Damage Quantity of product!");
                   //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                   HandlinDamagetextBox.Focus();
                   return;


               }
               else if (System.Text.RegularExpressions.Regex.IsMatch(TransitDamagetextBox.Text, "[^0-9.]"))
               {
                   MessageBox.Show("Please enter correct TransitDamage Quantity of product!");
                   //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                   TransitDamagetextBox.Focus();
                   return;
               }
               else  if (System.Text.RegularExpressions.Regex.IsMatch(SalesDamagetextBox.Text, "[^0-9.]"))
               {
                   MessageBox.Show("Please enter correct SalesDamage Quantity of product!");
                   //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                   SalesDamagetextBox.Focus();
                   return;
               }
               else if (System.Text.RegularExpressions.Regex.IsMatch(GodowndamagetextBox.Text, "[^0-9.]"))
               {
                   MessageBox.Show("Please enter correct Godowndamage Quantity of product!");
                   //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                   GodowndamagetextBox.Focus();
                   return;
               }
            SqlConnection connection;
            SqlCommand command = new SqlCommand();


            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "INSERT into DamageRegistration (Name_of_the_Product,Grade_of_the_Product,Quantity,Price,Handling_Damage,Godown_Damage,Sales_Damage,Transit_Damage,Date) VALUES (@Name_of_the_Product,@Grade_of_the_Product,@Quantity,@Price,@Handling_Damage,@Godown_Damage,@Sales_Damage,@Transit_Damage,@Date)";
                command.Parameters.AddWithValue("@Name_of_the_Product",NameoftheproductcomboBox1.Text);
                command.Parameters.AddWithValue("@Grade_of_the_Product",GradeoftheproductcomboBox2.Text);
                command.Parameters.AddWithValue("@Quantity",QuantitytextBox.Text);
                command.Parameters.AddWithValue("@Price",pricetextbox.Text);
                command.Parameters.AddWithValue("@Handling_Damage",HandlinDamagetextBox.Text);
                command.Parameters.AddWithValue("@Godown_Damage",GodowndamagetextBox.Text);
                command.Parameters.AddWithValue("@Sales_Damage",SalesDamagetextBox.Text);
                command.Parameters.AddWithValue("@Transit_Damage", TransitDamagetextBox.Text);
                command.Parameters.AddWithValue("@Date", dateTimePicker1.Text);




                command.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");
                button2_Click(sender,e);
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DamageRegistrationform_Load(object sender, EventArgs e)
        {

        }

        private void QuantitytextBox_TextChanged(object sender, EventArgs e)
        {
            QuantitytextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(QuantitytextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                QuantitytextBox.Focus();
            }
        }

        private void QuantitytextBox_Validating(object sender, CancelEventArgs e)
        {
            QuantitytextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(QuantitytextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                QuantitytextBox.Focus();
            }
        }

        private void QuantitytextBoxtextBox_TextChanged(object sender, EventArgs e)
        {
            pricetextbox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(pricetextbox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                pricetextbox.Focus();
            }
        }

        private void pricetextbox_Validating(object sender, CancelEventArgs e)
        {
            pricetextbox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(pricetextbox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                pricetextbox.Focus();
            }
        }

        private void HandlinDamagetextBox_TextChanged(object sender, EventArgs e)
        {
            HandlinDamagetextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(HandlinDamagetextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct Handling Damage Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                pricetextbox.Focus();
            }
        }

        private void HandlinDamagetextBox_Validating(object sender, CancelEventArgs e)
        {
            HandlinDamagetextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(HandlinDamagetextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct Handling Damage Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                HandlinDamagetextBox.Focus();
            }
        }

        private void GodowndamagetextBox_TextChanged(object sender, EventArgs e)
        {
            GodowndamagetextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(GodowndamagetextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct Godowndamage Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                GodowndamagetextBox.Focus();
            }
        }

        private void GodowndamagetextBox_Validating(object sender, CancelEventArgs e)
        {
            GodowndamagetextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(GodowndamagetextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct Godowndamage Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                GodowndamagetextBox.Focus();
            }
        }

        private void SalesDamagetextBox_TextChanged(object sender, EventArgs e)
        {
            SalesDamagetextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(SalesDamagetextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct SalesDamage Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                SalesDamagetextBox.Focus();
            }
        }

        private void SalesDamagetextBox_Validating(object sender, CancelEventArgs e)
        {
            SalesDamagetextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(SalesDamagetextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct SalesDamage Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                SalesDamagetextBox.Focus();
            }
        }

        private void TransitDamagetextBox_TextChanged(object sender, EventArgs e)
        {
            TransitDamagetextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(TransitDamagetextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                TransitDamagetextBox.Focus();
            }
        }

        private void TransitDamagetextBox_Validating(object sender, CancelEventArgs e)
        {
            TransitDamagetextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(TransitDamagetextBox.Text, "[^0-9.]"))
            {
                MessageBox.Show("Please enter correct TransitDamage Quantity of product!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                TransitDamagetextBox.Focus();
            }
        }
    }
}
