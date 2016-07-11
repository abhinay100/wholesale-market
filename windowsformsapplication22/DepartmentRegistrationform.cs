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
    public partial class DepartmentRegistrationform : Form
    {
        int _selectedIndex;
        public DepartmentRegistrationform()
        {
            InitializeComponent();
          Fillcombo();
          this.dataGridView1.ReadOnly = true;
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
            string Query = "select * from DepartmentRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Other_DepartmentDetails"));
                    comboBox1.Items.Add(CName);

                }
            }
            catch 
            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
               OtherDepartmenttextBox.Clear();
               comboBox1.SelectedIndex = -1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OtherDepartmenttextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter Deprtment Name!");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(OtherDepartmenttextBox.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter the Valid Department name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                OtherDepartmenttextBox.Focus();

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








                command.CommandText = "SELECT COUNT(*) FROM  DepartmentRegistration Where Other_DepartmentDetails=@Other_DepartmentDetails ";
                command.Parameters.AddWithValue("@Other_DepartmentDetails", OtherDepartmenttextBox.Text);

                Int32 count = (Int32)command.ExecuteScalar();





                if (count == 0)
                {

                    command.CommandText = "INSERT into DepartmentRegistration (Other_DepartmentDetails) VALUES (@Other_DepartmentDetails)";
                }
                else
                {

                    command.CommandText = "Update DepartmentRegistration set Other_DepartmentDetails=@Other_DepartmentDetails where Other_DepartmentDetails=@Other_DepartmentDetails";
                }
               

                    command.CommandText = "INSERT into DepartmentRegistration (Other_DepartmentDetails) VALUES (@Other_DepartmentDetails)";
                  //  command.Parameters.AddWithValue("@Other_DepartmentDetails", OtherDepartmenttextBox.Text);
 //command.CommandText = "UPDATE DepartmentRegistration SET Other_DepartmentDetails=@Other_DepartmentDetails ";
                
                                              
               command.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");

                button2_Click(sender, e);
           button4.Enabled = false;
          button3.Enabled = false;



            }
            catch
            {
                MessageBox.Show("Please Fill the Required fields");
            }
                
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void DepartmentRegistrationform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.DepartmentRegistration' table. You can move, or remove it, as needed.
            this.departmentRegistrationTableAdapter.Fill(this.marketDataSet.DepartmentRegistration);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select the Department name!");
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
                command.CommandText = "SELECT * from DepartmentRegistration Where Other_DepartmentDetails= '" + comboBox1.Text + "'  ";

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "DepartmentRegistration");
                dataGridView1.DataSource = ds.Tables["DepartmentRegistration"];
                SqlDataReader Reader = command.ExecuteReader();
                button3.Enabled = true;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
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
                command.CommandText = "Select * from   DepartmentRegistration Where Other_DepartmentDetails ='" + comboBox1.Text + "'";

                command.Parameters.AddWithValue("Other_DepartmentDetails", comboBox1.Text);





                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    OtherDepartmenttextBox.Text = dr["Other_DepartmentDetails"].ToString();

                }
            }
            catch
            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void OtherDepartmenttextBox_TextChanged(object sender, EventArgs e)
        {
            OtherDepartmenttextBox.MaxLength = 15;
            if (System.Text.RegularExpressions.Regex.IsMatch(OtherDepartmenttextBox.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter the Valid Department name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                OtherDepartmenttextBox.Focus();

            }
        }
    }
}
