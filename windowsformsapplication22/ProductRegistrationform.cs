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
    public partial class ProductRegistrationform : Form
    {
        public ProductRegistrationform()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            Fillcombo();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            button4.Enabled = false;
            button3.Enabled = false;
            dataGridView1.DataSource = null;
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
            catch (Exception ex)
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            SizeoftheproducttextBox.Clear();
            comboBox1.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Name of the product!");
                return;
            }
            else if (textBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the Grade of the product!");
                return;

            }
            else if (SizeoftheproducttextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Size of the product!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^a-zA-Z0-9 $#]"))
            {
                MessageBox.Show("Please enter the Valid Product Name!");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                textBox1.Focus();
                return;
            }
        

     
           
        else
        if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^a-zA-Z0-9 +]"))
            {
                MessageBox.Show("Please enter the Valid Grade!");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                textBox2.Focus();
      return;
   
            }
        

         else   if (System.Text.RegularExpressions.Regex.IsMatch(SizeoftheproducttextBox.Text, "[^0-9 .+]"))
            {
                MessageBox.Show("Please enter the Valid Size!");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                SizeoftheproducttextBox.Focus();
             
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
                command.CommandText = "SELECT COUNT(*) FROM  ProductRegistration Where Name_of_the_product= @Name_of_the_product and Grade_of_the_product =@Grade_of_the_product ";
               command.Parameters.AddWithValue("@Name_of_the_product", textBox1.Text);
               command.Parameters.AddWithValue("@Grade_of_the_product", textBox2.Text);
                  Int32 count = (Int32)  command.ExecuteScalar();





                  if (count == 0)
                  {
                      command.CommandText = "INSERT into ProductRegistration(Name_of_the_product,Grade_of_the_product,Size_of_the_product) VALUES (@Name_of_the_product,@Grade_of_the_product,@Size_of_the_product)";
                  }
                  else
                  {

                      command.CommandText = "Update ProductRegistration set Size_of_the_product=@Size_of_the_product where Name_of_the_product= @Name_of_the_product and Grade_of_the_product =@Grade_of_the_product ";
                  }
               // command.Parameters.AddWithValue("@Name_of_the_product", textBox1.Text);
               
                command.Parameters.AddWithValue("@Size_of_the_product", SizeoftheproducttextBox.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Product Saved Successfully!");
                button2_Click(sender, e);
                
                ProductRegistrationform form = new ProductRegistrationform();
                form.Refresh();

                



               

            }
            catch
            {
                MessageBox.Show("Please Fill the Required fields");
            }

        }

        private void ProductRegistrationform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.ProductRegistration' table. You can move, or remove it, as needed.
            this.productRegistrationTableAdapter.Fill(this.marketDataSet.ProductRegistration);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            textBox1.MaxLength = 20;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "[^a-zA-Z0-9 $#]"))
            {
                MessageBox.Show("Please enter the Valid Product Name!");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                textBox1.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 20;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox2.Text, "[^a-zA-Z0-9 +]"))
            {
                MessageBox.Show("Please enter the Valid Grade!");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                textBox2.Focus();
            }
        }

        private void SizeoftheproducttextBox_TextChanged(object sender, EventArgs e)
        {
            textBox2.MaxLength = 8;
            if (System.Text.RegularExpressions.Regex.IsMatch(SizeoftheproducttextBox.Text, "[^0-9 .+]"))
            {
                MessageBox.Show("Please enter the Valid Size!");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                SizeoftheproducttextBox.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select the Product name!");
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
                command.CommandText = "SELECT * from ProductRegistration Where  Name_of_the_product= '" + comboBox1.Text + "'  ";

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "ProductRegistration");
                dataGridView1.DataSource = ds.Tables["ProductRegistration"];
                SqlDataReader Reader = command.ExecuteReader();
                button3.Enabled = true;
            }

            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }

        private void button3_Click(object sender, EventArgs e)
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
                command.CommandText = "Select * from   ProductRegistration Where Name_of_the_product ='" + comboBox1.Text + "'";

                command.Parameters.AddWithValue("@Name_of_the_product", comboBox1.Text);





                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    textBox1.Text = dr["Name_of_the_product"].ToString();
                    textBox2.Text = dr["Grade_of_the_product"].ToString();
                    SizeoftheproducttextBox.Text = dr["Size_of_the_product"].ToString();

                }
            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;



        }
    }
}