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
    public partial class MeasurementRegistrationform : Form
    {
        public MeasurementRegistrationform()
        {
          
            InitializeComponent();
            Fillcombo();
            this.dataGridView1.ReadOnly = true;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            button4.Enabled = false;
            dataGridView1.DataSource = null;
            button3.Enabled = false;

        }
        void Fillcombo()
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
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            MeasurementtextBox1.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MeasurementtextBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Measurement name!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(MeasurementtextBox1.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter the Valid Measurement name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                MeasurementtextBox1.Focus();

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


                command.CommandText = "SELECT COUNT(*) FROM  MeasurementRegistration Where Measurement=@Measurement";
             command.Parameters.AddWithValue("@Measurement", MeasurementtextBox1.Text);

                Int32 count = (Int32)command.ExecuteScalar();





                if (count == 0)
                {
                    command.CommandText = "INSERT into MeasurementRegistration  (Measurement) VALUES (@Measurement)";
                }
                else
                {

                    command.CommandText = "Update MeasurementRegistration set Measurement=@Measurement where  Measurement=@Measurement";
                }
               
                   

               
                command.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");
                button2_Click(sender, e);
                button4.Enabled = false;
                button3.Enabled = false;

               
              
            }
            catch
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MeasurementtextBox1.MaxLength = 8;
            if (System.Text.RegularExpressions.Regex.IsMatch(MeasurementtextBox1.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter the Valid Measurement name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                MeasurementtextBox1.Focus();

            }
        }

        private void MeasurementRegistrationform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.MeasurementRegistration' table. You can move, or remove it, as needed.
           // this.measurementRegistrationTableAdapter.Fill(this.marketDataSet.MeasurementRegistration);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select the Measurement name!");
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
                command.CommandText = "SELECT * from MeasurementRegistration Where  Measurement= '" + comboBox1.Text + "'  ";

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "MeasurementRegistration");
                dataGridView1.DataSource = ds.Tables["MeasurementRegistration"];
                SqlDataReader Reader = command.ExecuteReader();
                button3.Enabled = true;

            }

            catch 
            {
              //  MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
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
                command.CommandText = "Select * from   MeasurementRegistration Where Measurement ='" + comboBox1.Text + "'";

                command.Parameters.AddWithValue("@Measurement", comboBox1.Text);





                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    MeasurementtextBox1.Text = dr["Measurement"].ToString();

                }
            }
            catch
            {
              //  MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
