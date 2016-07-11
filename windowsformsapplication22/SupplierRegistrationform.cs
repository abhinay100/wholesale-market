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
using System.Reflection;
using System.IO;


namespace WindowsFormsApplication22
{
    public partial class SupplierRegistrationform : Form
    {
        string imgloc;
        string imgloc2;
        int _selectedIndex;
        public SupplierRegistrationform()
        {
           // MessageBox.Show("Entered in supplier registration form");
            InitializeComponent();
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
             this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox6.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox7.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.IDproofcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AddressProofcomboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.dataGridView1.ReadOnly = true;
            button6.Enabled = false;

            dataGridView1.DataSource = null;
            button4.Enabled = false;
           
            button7.Enabled = false;
            button5.Enabled = false;
          //  MessageBox.Show("going to fill the labels and combo box");
            filllabel();
            Fillcombo();
            Fillcombo1();
          //  MessageBox.Show("filling combo boxes finished");
        }
        void filllabel()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
           // MessageBox.Show("in fill label 1");
            SqlConnection conn = new SqlConnection(connectionString);
            
            try
            {
                
             conn.Open();
              SqlCommand command = new SqlCommand("select max(ID) from SupplierRegistration", conn);
                                                             
               command.ExecuteScalar();
                SupplierIDtextBox.Text = (command.ExecuteScalar().ToString());
              
                   
              


             int i =(Convert.ToInt32(SupplierIDtextBox.Text)+ 1);
               // MessageBox.Show(i.ToString());
                SupplierIDtextBox.Text = i.ToString();
               
               conn.Close();
               //MessageBox.Show("in fill label 2");

           }
            catch(SqlException exc)
            {
                
               MessageBox.Show("line number 78 Network related issues please check internet connection"+exc);
            }
        }
        void Fillcombo()
        {
            SqlConnection connection;
            //MessageBox.Show("in fill combo 1");
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select Name_Of_The_Company from SupplierRegistration";
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
                    comboBox1.Items.Add(CName);

                }
              //  MessageBox.Show("in fill combo 2");
            }
            catch(SqlException exc)
            {
        //      MessageBox.Show("line numer 108: Network related issues please check internet connection"+exc);
            }

        }
        void Fillcombo1()
        {
            SqlConnection connection;
          //  MessageBox.Show("in fill combo1 1");
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select Name_of_the_product from ProductRegistration";
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
                    comboBox6.Items.Add(CName);
                    comboBox7.Items.Add(CName);
                    comboBox5.Items.Add(CName);
                    comboBox4.Items.Add(CName);
                    comboBox3.Items.Add(CName);


                }
              //  MessageBox.Show("in fill combo1 2");
            }
            catch
            {
                //MessageBox.Show("Network related issues please check internet connection");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NameofthecompanytextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Name of the Company!");
                return;
            }
            else if (linkLabel1.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please attach ID proof");
                return;
            }
            else if (linkLabel2.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Please attach Addressproof");
                return;
            }
            else if (RegisteredofficeaddressrichTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill the Registered Office Address");
                return;

            }
            else if (OfficeNumbertextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter office Number");
                return;
            
            }
            else if (ContactPerson1textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Contact Person1 name");
                return;
            }
            else if (PhoneNumber1textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Phonenumber1 of contact person1 name");
                return;
            }

            else if (comboBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select the major product1 from dropdown");
                return;
            }

            else if (comboBox7.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the major product2 from dropdown");
                return;
            }
            else if (comboBox6.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the major product3 from dropdown");
                return;
            }
            else if (comboBox5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the major product4 from dropdown");
                return;
            }
            else if (comboBox4.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the major product5 from dropdown");
                return;
            }
            else if (comboBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the major product6 from dropdown");
                return;
            }
            else if (CompanyTINnumbertextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill  Company TIN number");
                return;
            }

            else if (CompanyTAXnumbertextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Company TAX number");
                return;
            }

            else if (CompanyBankBranchnametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Company bank and branch name");
                return;
            }

            else if (CompanyPANcardNumbertextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Company PAN card number");
                return;
            }
            else if (CompanyAccountNumbertextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Company Account Number");
                return;
            }

            else if (BankIFSCcodetextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Bank IFSC code");
                return;
            }
            
            else if (IDproofcomboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Select IDProof");
                return;
            }
            else if (AddressProofcomboBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Select AddressProof");
                return;
            }
            else if (ContactPerson2textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Contact Person2 name");
                return;
            }
            else if (PhoneNumber2textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Phonenumber2 of contact person2 name");
                return;
            }
            else if (ContactPerson3textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Contact Person3 name");
                return;
            }
            else if (PhoneNumber3textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Phonenumber3 of contact person3 name");
                return;
            }
            else if (ContactPerson4textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Contact Person4 name");
                return;
            }
            else if (PhoneNumber4textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Phonenumber4 of contact person4 name");
                return;
            }
            else if (ContactPerson5textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Contact Person5 name");
                return;
            }
            else if (PhoneNumber5textBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill the Phonenumber5 of contact person5 name");
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber2textBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber2textBox.Focus();
                PhoneNumber2textBox.MaxLength = 10;
                return;
            }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber1textBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber1textBox.Focus();
                return;
            }



            else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber3textBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber3textBox.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber4textBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber4textBox.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber5textBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber5textBox.Focus();
                return;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(OfficeNumbertextBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                OfficeNumbertextBox.Focus();
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(BankIFSCcodetextBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter Valid 11digit IFSC code!");
                BankIFSCcodetextBox.Focus();
                return;
            }

      


                else if (!System.Text.RegularExpressions.Regex.IsMatch(CompanyPANcardNumbertextBox.Text, "^[A-Za-z0-9]{10}$"))
                {
                MessageBox.Show("Please enter the Valid Company PAN Card!");
                CompanyPANcardNumbertextBox.Focus();
                return;
                }


                else if (!System.Text.RegularExpressions.Regex.IsMatch(CompanyTAXnumbertextBox.Text, "^[A-Za-z0-9]{15}$"))
            {
                MessageBox.Show("Please enter the Valid TAX Number!");
                CompanyTAXnumbertextBox.Focus();
                return;
            }


                else if (!System.Text.RegularExpressions.Regex.IsMatch(CompanyTINnumbertextBox.Text, "^[A-Za-z0-9]{11}$"))
            {
                MessageBox.Show("Please enter the Valid TIN Number!");
                // CompanyTINnumbertextBox.Text.Remove(CompanyTINnumbertextBox.Text.Length - 1);
                CompanyTINnumbertextBox.Focus();
                return;
            }

                else if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson1textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid  ContactPerson1 Name!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                ContactPerson1textBox.Focus();
                return;
            }
                else  if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson2textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid ContactPerson2 Name!");
                // ContactPerson2textBox.Text.Remove(ContactPerson2textBox.Text.Length - 1);
                ContactPerson2textBox.Focus();
                return;
                    
            }

                else  if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson3textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid ContactPerson3 Name!");
                //ContactPerson3textBox.Text.Remove(ContactPerson3textBox.Text.Length - 1);
                ContactPerson3textBox.Focus();
                return;
            }
                else  if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson4textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid ContactPerson4 Name!");
                // ContactPerson4textBox.Text.Remove(ContactPerson4textBox.Text.Length - 1);
                ContactPerson4textBox.Focus();
                return;
            }

                else if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson5textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid ContactPerson5 Name!");
                // ContactPerson5textBox.Text.Remove(ContactPerson5textBox.Text.Length - 1);
                ContactPerson5textBox.Focus();
                return;

            }

               
            
            

            string connectionString = null;
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

       connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
          //command.CommandTimeout = 10000;
         
            try
            {
                    
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;

                command.CommandText = "SELECT COUNT(*) FROM SupplierRegistration Where Name_Of_The_Company= @Name_Of_The_Company";
                command.Parameters.AddWithValue("@Name_Of_The_Company", NameofthecompanytextBox.Text);

                  Int32 count = (Int32)  command.ExecuteScalar();





                  if (count == 0)
                  {
                      command.CommandText = "INSERT into SupplierRegistration(Name_Of_The_company,Registered_Office_Address,Office_Number,Contact_Person_1,Phone_Number_1,Contact_Person_2,Phone_Number_2,Contact_Person_3,Phone_Number_3,Contact_Person_4,Phone_Number_4,Contact_Person_5,Phone_Number_5,ID,Company_TIN_Number,Company_Service_TAX_Number,Bank_and_Branch_Name,Company_PAN_Card_Number,Company_Account_Number,Bank_IFSC_Code,ID_Proof_Name,ID_Proof_File_Path,Address_Proof_Name,Address_Proof_File_Path,Major_Product1,Major_Product2,Major_Product3,Major_Product4,Major_Product5,Major_Product6,ID_Image,Address_Image) VALUES (@Name_Of_The_Company,@Registered_Office_Address,@Office_Number,@Contact_Person_1,@Phone_Number_1,@Contact_Person_2,@Phone_Number_2,@Contact_Person_3,@Phone_Number_3,@Contact_Person_4,@Phone_Number_4,@Contact_Person_5,@Phone_Number_5,@ID,@Company_TIN_Number,@Company_Service_TAX_Number,@Bank_and_Branch_Name,@Company_PAN_Card_Number,@Company_Account_Number,@Bank_IFSC_Code,@ID_Proof_Name,@ID_Proof_File_Path,@Address_Proof_Name,@Address_Proof_File_Path,@Major_Product1,@Major_Product2,@Major_Product3,@Major_Product4,@Major_Product5,@Major_Product6,@ID_Image,@Address_Image)";
                      //command.Parameters.AddWithValue("@Name_Of_The_Company", NameofthecompanytextBox.Text);
                  }

                  else
                  {
                      command.CommandText = "UPDATE SupplierRegistration set Registered_Office_Address=@Registered_Office_Address,Office_Number=@Office_Number,Contact_Person_1=@Contact_Person_1,Phone_Number_1=@Phone_Number_1,Contact_Person_2=@Contact_Person_2,Phone_Number_2=@Phone_Number_2,Contact_Person_3=@Contact_Person_3,Phone_Number_3=@Phone_Number_3,Contact_Person_4=@Contact_Person_4,Phone_Number_4=@Phone_Number_4,Contact_Person_5=@Contact_Person_5,Phone_Number_5=@Phone_Number_5,ID=@ID,Company_TIN_Number=@Company_TIN_Number,Company_Service_TAX_Number=@Company_Service_TAX_Number,Bank_and_Branch_Name=@Bank_and_Branch_Name,Company_PAN_Card_Number=@Company_PAN_Card_Number,Company_Account_Number=@Company_Account_Number,Bank_IFSC_Code=@Bank_IFSC_Code,ID_Proof_Name=@ID_Proof_Name,ID_Proof_File_Path=@ID_Proof_File_Path,Address_Proof_Name=@Address_Proof_Name,Address_Proof_File_Path=@Address_Proof_File_Path,Major_Product1=@Major_Product1,Major_Product2=@Major_Product2,Major_Product3=@Major_Product3,Major_Product4=@Major_Product4,Major_Product5=@Major_Product5,Major_Product6=@Major_Product6,ID_Image=@ID_Image,Address_Image=@Address_Image Where Name_Of_The_Company=@Name_Of_The_Company";

                     // command.Parameters.AddWithValue("@Name_Of_The_Company", NameofthecompanytextBox.Text);
                  }
                  
                  command.Parameters.AddWithValue("@Registered_Office_Address", RegisteredofficeaddressrichTextBox.Text);
                      command.Parameters.AddWithValue("@Office_Number", OfficeNumbertextBox.Text);
                      command.Parameters.AddWithValue("@Contact_Person_1", ContactPerson1textBox.Text);
                      command.Parameters.AddWithValue("@Phone_Number_1", PhoneNumber1textBox.Text);
                      command.Parameters.AddWithValue("@Contact_Person_2", ContactPerson2textBox.Text);
                      command.Parameters.AddWithValue("@Phone_Number_2", PhoneNumber2textBox.Text);
                      command.Parameters.AddWithValue("@Contact_Person_3", ContactPerson3textBox.Text);
                      command.Parameters.AddWithValue("@Phone_Number_3", PhoneNumber3textBox.Text);
                      command.Parameters.AddWithValue("@Contact_Person_4", ContactPerson4textBox.Text);
                      command.Parameters.AddWithValue("@Phone_Number_4", PhoneNumber4textBox.Text);
                      command.Parameters.AddWithValue("@Contact_Person_5", ContactPerson5textBox.Text);
                      command.Parameters.AddWithValue("@Phone_Number_5", PhoneNumber5textBox.Text);
                   

                      command.Parameters.AddWithValue("@ID", SupplierIDtextBox.Text);
                      
                      command.Parameters.AddWithValue("@Company_TIN_Number", CompanyTINnumbertextBox.Text);
                      command.Parameters.AddWithValue("@Company_Service_TAX_Number", CompanyTAXnumbertextBox.Text);
                      command.Parameters.AddWithValue("@Bank_and_Branch_Name", CompanyBankBranchnametextBox.Text);
                      command.Parameters.AddWithValue("@Company_PAN_Card_Number", CompanyPANcardNumbertextBox.Text);
                      command.Parameters.AddWithValue("@Company_Account_Number", CompanyAccountNumbertextBox.Text);
                      command.Parameters.AddWithValue("@Bank_IFSC_Code", BankIFSCcodetextBox.Text);
                      command.Parameters.AddWithValue("@ID_Proof_Name", IDproofcomboBox1.Text);
                      command.Parameters.AddWithValue("@ID_Proof_File_Path", linkLabel1.Text);
                      command.Parameters.AddWithValue("@Address_Proof_Name", AddressProofcomboBox2.Text);
                      command.Parameters.AddWithValue("@Address_Proof_File_Path", linkLabel2.Text);
                      command.Parameters.AddWithValue("@Major_Product1", comboBox2.Text);
                      command.Parameters.AddWithValue("@Major_Product2", comboBox6.Text);
                      command.Parameters.AddWithValue("@Major_Product3", comboBox7.Text);
                      command.Parameters.AddWithValue("@Major_Product4", comboBox5.Text);
                      command.Parameters.AddWithValue("@Major_Product5", comboBox4.Text);
                      command.Parameters.AddWithValue("@Major_Product6", comboBox3.Text);


                     /* connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                      connection = new SqlConnection(connectionString);*/
                      string ImagesDirectory1 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
                      string ssss = linkLabel1.Text;
                      // MessageBox.Show(ssss);
                
                String strBLOBFilePath1 = ssss;
                      // MessageBox.Show(strBLOBFilePath1);
                      //  String strBLOBFilePath = @"C:\images (1).jpg";

                      //Read jpg into file stream, and from there into Byte array.
                      FileStream fsBLOBFile1 = new FileStream(strBLOBFilePath1, FileMode.Open, FileAccess.Read);
                      Byte[] bytBLOBData1 = new Byte[fsBLOBFile1.Length];
                      fsBLOBFile1.Read(bytBLOBData1, 0, bytBLOBData1.Length);
                      fsBLOBFile1.Close();

                      //Create parameter for insert command and add to SqlCommand object.
                      SqlParameter prm1 = new SqlParameter("@ID_Image", SqlDbType.VarBinary, bytBLOBData1.Length, ParameterDirection.Input, false,
                                  0, 0, null, DataRowVersion.Current, bytBLOBData1);







                     /* connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                      connection = new SqlConnection(connectionString);*/
                      string ImagesDirectory2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
                      string ssq = linkLabel2.Text;
                     // MessageBox.Show(ssq);
                      String strBLOBFilePath2 = ssq;
                      //MessageBox.Show(strBLOBFilePath2);
                      //  String strBLOBFilePath = @"C:\images (1).jpg";

                      //Read jpg into file stream, and from there into Byte array.
                      FileStream fsBLOBFile2 = new FileStream(strBLOBFilePath2, FileMode.Open, FileAccess.Read);
                      Byte[] bytBLOBData2 = new Byte[fsBLOBFile2.Length];
                      fsBLOBFile2.Read(bytBLOBData2, 0, bytBLOBData2.Length);
                      fsBLOBFile2.Close();

                      //Create parameter for insert command and add to SqlCommand object.
                      SqlParameter prm2 = new SqlParameter("@Address_Image", SqlDbType.VarBinary, bytBLOBData2.Length, ParameterDirection.Input, false,
                                  0, 0, null, DataRowVersion.Current, bytBLOBData2);

                      command.Parameters.Add(prm1);


                      command.Parameters.Add(prm2);

                     // command.CommandTimeout = 10000;
                      command.ExecuteNonQuery();
                      
                MessageBox.Show("Registered Successfully!");
                NameofthecompanytextBox.Enabled = true;
                button2_Click(sender, e);
                      //SupplierRegistrationform form = new SupplierRegistrationform();
                     // this.Refresh();
                     // Application.DoEvents();
                      button6.Enabled = false;

                      button7.Enabled = false;
                      filllabel();
                      Fillcombo();
            }
            catch
            {
               // MessageBox.Show("Network related issues please check internet connection");
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {



            pictureBox2.Image = null;
            pictureBox1.Image = null;
            BankIFSCcodetextBox.Clear();
            RegisteredofficeaddressrichTextBox.Clear();
            ContactPerson1textBox.Clear();
            ContactPerson2textBox.Clear();
            ContactPerson3textBox.Clear();
            ContactPerson4textBox.Clear();
            ContactPerson5textBox.Clear();
            OfficeNumbertextBox.Clear();
            PhoneNumber1textBox.Clear();
            PhoneNumber2textBox.Clear();
            PhoneNumber3textBox.Clear();
            PhoneNumber4textBox.Clear();
            PhoneNumber5textBox.Clear();
            comboBox2.SelectedIndex = -1;
            comboBox6.SelectedIndex = -1;
            comboBox7.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            comboBox1.SelectedIndex = -1;
            CompanyTINnumbertextBox.Clear();
            CompanyTAXnumbertextBox.Clear();
            CompanyBankBranchnametextBox.Clear();
            CompanyPANcardNumbertextBox.Clear();
            CompanyAccountNumbertextBox.Clear();
            NameofthecompanytextBox.Clear();
            IDproofcomboBox1.SelectedIndex = -1;
            AddressProofcomboBox2.SelectedIndex = -1;
       
            linkLabel1.Text = "";
            linkLabel2.Text = "";
          

            dataGridView1.DataSource = null;
                    
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3offno_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {


        }

        private void SupplierRegistrationform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.SupplierRegistration' table. You can move, or remove it, as needed.
           // this.supplierRegistrationTableAdapter.Fill(this.marketDataSet.SupplierRegistration);
           
        }

        private void textBox3offno_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button10_Click(object sender, EventArgs e)
        {

            OpenFileDialog OpenFd = new OpenFileDialog();

            DialogResult dr = OpenFd.ShowDialog();
            linkLabel1.Text = OpenFd.FileName;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            OpenFileDialog OpenFd = new OpenFileDialog();

            DialogResult dr = OpenFd.ShowDialog();
            linkLabel2.Text = OpenFd.FileName;

        }

        private void button4_Click(object sender, EventArgs e)
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
                command.CommandText = "SELECT * from SupplierRegistration Where  Name_Of_The_Company= '" + comboBox1.Text + "'  ";

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "SupplierRegistration");
                dataGridView1.DataSource = ds.Tables["SupplierRegistration"];






                SqlDataReader Reader = command.ExecuteReader();
                button5.Enabled = true;


            }
            catch 
            {
               // MessageBox.Show("Network related issues please check internet connection");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            NameofthecompanytextBox.Enabled = false;
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
                command.CommandText = "Select * from   SupplierRegistration Where Name_Of_The_Company ='" + comboBox1.Text + "'";

                command.Parameters.AddWithValue("@Name_Of_The_Company", comboBox1.Text);

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    NameofthecompanytextBox.Text = dr["Name_Of_The_Company"].ToString();

                    RegisteredofficeaddressrichTextBox.Text = dr["Registered_Office_Address"].ToString();

                    OfficeNumbertextBox.Text = dr["Office_Number"].ToString();

                    ContactPerson1textBox.Text = dr["Contact_Person_1"].ToString();

                    ContactPerson2textBox.Text = dr["Contact_Person_2"].ToString();

                    ContactPerson3textBox.Text = dr["Contact_Person_3"].ToString();

                    ContactPerson4textBox.Text = dr["Contact_Person_4"].ToString();

                    ContactPerson5textBox.Text = dr["Contact_Person_5"].ToString();

                    PhoneNumber1textBox.Text = dr["Phone_Number_1"].ToString();

                    PhoneNumber2textBox.Text = dr["Phone_Number_2"].ToString();

                    PhoneNumber3textBox.Text = dr["Phone_Number_3"].ToString();

                    PhoneNumber4textBox.Text = dr["Phone_Number_4"].ToString();

                    PhoneNumber5textBox.Text = dr["Phone_Number_5"].ToString();


                    comboBox2.Text = dr["Major_Product1"].ToString();

                    comboBox6.Text = dr["Major_Product2"].ToString();
                    comboBox7.Text = dr["Major_Product3"].ToString();

                    comboBox5.Text = dr["Major_Product4"].ToString();

                    comboBox4.Text = dr["Major_Product5"].ToString();

                    comboBox3.Text = dr["Major_Product6"].ToString();

                    CompanyTINnumbertextBox.Text = dr["Company_TIN_Number"].ToString();

                    CompanyTAXnumbertextBox.Text = dr["Company_Service_TAX_Number"].ToString();

                    CompanyBankBranchnametextBox.Text = dr["Bank_and_Branch_Name"].ToString();

                    CompanyPANcardNumbertextBox.Text = dr["Company_PAN_Card_Number"].ToString();

                    CompanyAccountNumbertextBox.Text = dr["Company_Account_Number"].ToString();

                    BankIFSCcodetextBox.Text = dr["Bank_IFSC_Code"].ToString();

                    IDproofcomboBox1.Text = dr["ID_Proof_Name"].ToString();

                    AddressProofcomboBox2.Text = dr["Address_Proof_Name"].ToString();

                   
                    linkLabel1.Text = dr["ID_Proof_File_Path"].ToString();
                    linkLabel2.Text = dr["Address_Proof_File_Path"].ToString();

                    SupplierIDtextBox.Text = dr["ID"].ToString();


                  dr.Close();




                   connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);
                    SqlConnection connec = new SqlConnection(connectionString);
                    connec.Open();
                    SqlDataAdapter dg = new SqlDataAdapter(command);
                    DataSet dw = new DataSet();
                    dg.Fill(dw, "SupplierRegistration");
                    int j = dw.Tables["SupplierRegistration"].Rows.Count;

                    if (j > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData1 = new Byte[0];
                        byteBLOBData1 = (Byte[])(dw.Tables["SupplierRegistration"].Rows[j - 1]["Address_Image"]);
                        MemoryStream stmBLOBData2 = new MemoryStream(byteBLOBData1);
                        // MessageBox.Show(stmBLOBData2.ToString());
                        
                        pictureBox1.Image = Image.FromStream(stmBLOBData2);
                       


                    }
                    connec.Close();



                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);





                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();



                    SqlDataAdapter dq = new SqlDataAdapter(command);
                    DataSet df = new DataSet();
                    dq.Fill(df, "SupplierRegistration");
                    int a = df.Tables["SupplierRegistration"].Rows.Count;

                    if (a > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.


                        Byte[] byteBLOBData2 = new Byte[0];
                        byteBLOBData2 = (Byte[])(df.Tables["SupplierRegistration"].Rows[a - 1]["ID_Image"]);
                        MemoryStream stmBLOBData1 = new MemoryStream(byteBLOBData2);
                    
                        pictureBox2.Image = Image.FromStream(stmBLOBData1);

                       

                    }
                    conn.Close();


                }







            }
            catch
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
                
            

        }

        private void ContactPerson1textBox_Vlidating(object sender, KeyPressEventArgs e)
        {
            
        }

        private void PhoneNumber1textBox_Validating(object sender, KeyPressEventArgs e)
        {
            PhoneNumber1textBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber1textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber1textBox.Focus();
            }
        }

        private void PhoneNumber2textBox_Validating(object sender, KeyPressEventArgs e)
        {
            PhoneNumber2textBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber2textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber2textBox.Focus();
            }
        }

        private void PhoneNumber3textBox_Validating(object sender, KeyPressEventArgs e)
        {
            PhoneNumber3textBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber3textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber3textBox.Focus();
            }
        }

        private void PhoneNumber4textBox_Validating(object sender, KeyPressEventArgs e)
        {
            PhoneNumber4textBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber4textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber4textBox.Focus();
            }
        }

        private void PhoneNumber5textBox_Validating(object sender, KeyPressEventArgs e)
        {
            PhoneNumber5textBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber5textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber5textBox.Focus();
            }

           
        }

        private void OfficeNumbertextBox_Validating(object sender, KeyPressEventArgs e)
        {
            OfficeNumbertextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(OfficeNumbertextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                OfficeNumbertextBox.Focus();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images.|*.jpg;*.jpeg;*.png;*.gif;";
            DialogResult dr = OpenFd.ShowDialog();
            pictureBox2.Image = Image.FromFile(OpenFd.FileName);
            imgloc2 = OpenFd.FileName.ToString();
            pictureBox2.ImageLocation = imgloc2;
            linkLabel1.Text = imgloc2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images.|*.jpg;*.jpeg;*.png;*.gif;";
            DialogResult dr = OpenFd.ShowDialog();
            pictureBox1.Image = Image.FromFile(OpenFd.FileName);
            imgloc = OpenFd.FileName.ToString();
            pictureBox1.ImageLocation = imgloc;
            linkLabel2.Text = imgloc;

        }

        private void PhoneNumber1textBox_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void BankIFSCcodetextBox_TextChanged(object sender, EventArgs e)
        {
          BankIFSCcodetextBox.MaxLength = 11;
          
           if (System.Text.RegularExpressions.Regex.IsMatch(BankIFSCcodetextBox.Text, "[^a-zA-Z0-9]"))
           {
               MessageBox.Show("Please enter the Valid IFSC code!");
               BankIFSCcodetextBox.Focus();
           }
           
        }

        private void CompanyAccountNumbertextBox_TextChanged(object sender, EventArgs e)
        {
            CompanyAccountNumbertextBox.MaxLength = 15;
           
            if (System.Text.RegularExpressions.Regex.IsMatch(CompanyAccountNumbertextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter the Valid Account Number!");
                CompanyAccountNumbertextBox.Focus();
            }
          
        }

        private void CompanyPANcardNumbertextBox_TextChanged(object sender, EventArgs e)
        {
            CompanyPANcardNumbertextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(CompanyPANcardNumbertextBox.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Please enter the Valid Company PAN Card!");
                CompanyPANcardNumbertextBox.Focus();
            }
        }

        private void CompanyTAXnumbertextBox_TextChanged(object sender, EventArgs e)
        {
            CompanyTAXnumbertextBox.MaxLength = 15;
            if (System.Text.RegularExpressions.Regex.IsMatch(CompanyTAXnumbertextBox.Text, "[^a-zA-Z0-9]{15}$"))
            {
                MessageBox.Show("Please enter the Valid TAX Number!");
                CompanyTAXnumbertextBox.Focus();
            }

        }

        private void CompanyTINnumbertextBox_TextChanged(object sender, EventArgs e)
        {
            CompanyTINnumbertextBox.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(CompanyTINnumbertextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter the Valid TAX Identification Number!");
               // CompanyTINnumbertextBox.Text.Remove(CompanyTINnumbertextBox.Text.Length - 1);
                CompanyTINnumbertextBox.Focus();
            }
        }

        private void NameofthecompanytextBox_TextChanged(object sender, EventArgs e)
        {
            NameofthecompanytextBox.MaxLength = 25;
            if (System.Text.RegularExpressions.Regex.IsMatch(NameofthecompanytextBox.Text, "[^a-zA-Z0-9@*&#$()[]]"))
            {
                MessageBox.Show("Please enter the Valid Name of the company!");
               // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                NameofthecompanytextBox.Focus();
            }
        }

        private void ContactPerson1textBox_TextChanged(object sender, EventArgs e)
        {
            ContactPerson1textBox.MaxLength = 20;
            if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson1textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid  ContactPerson1 Name!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                ContactPerson1textBox.Focus();
            }
        }

        private void RegisteredofficeaddressrichTextBox_TextChanged(object sender, EventArgs e)
        {
            RegisteredofficeaddressrichTextBox.MaxLength = 55;
            if (System.Text.RegularExpressions.Regex.IsMatch(RegisteredofficeaddressrichTextBox.Text, "[^a-zA-Z0-9@*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid Office Address!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                RegisteredofficeaddressrichTextBox.Focus();
            }
        }

        private void ContactPerson2textBox_TextChanged(object sender, EventArgs e)
        {
            ContactPerson2textBox.MaxLength = 20;
            if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson2textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid ContactPerson2 Name!");
               // ContactPerson2textBox.Text.Remove(ContactPerson2textBox.Text.Length - 1);
                ContactPerson2textBox.Focus();
            }
        }

        private void ContactPerson3textBox_TextChanged(object sender, EventArgs e)
        {
            ContactPerson3textBox.MaxLength = 20;
            if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson3textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid ContactPerson3 Name!");
                //ContactPerson3textBox.Text.Remove(ContactPerson3textBox.Text.Length - 1);
                ContactPerson3textBox.Focus();
            }
        }

        private void ContactPerson4textBox_TextChanged(object sender, EventArgs e)
        {
            ContactPerson4textBox.MaxLength = 20;
            if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson4textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid ContactPerson4 Name!");
               // ContactPerson4textBox.Text.Remove(ContactPerson4textBox.Text.Length - 1);
                ContactPerson4textBox.Focus();
            }
        }

        private void ContactPerson5textBox_TextChanged(object sender, EventArgs e)
        {
            ContactPerson5textBox.MaxLength = 20;
            if (System.Text.RegularExpressions.Regex.IsMatch(ContactPerson5textBox.Text, "[^a-zA-Z]"))
            {
                MessageBox.Show("Please enter Valid ContactPerson5 Name!");
               // ContactPerson5textBox.Text.Remove(ContactPerson5textBox.Text.Length - 1);
                ContactPerson5textBox.Focus();
               
            }
        }

        private void IDproofcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button6.Enabled = true;
        }

        private void AddressProofcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button7.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void EducationOtherstextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PhoneNumber1textBox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void PhoneNumber2textBox_Validating(object sender, CancelEventArgs e)
        {
            PhoneNumber2textBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber2textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber2textBox.Focus();
            }
        }

        private void PhoneNumber3textBox_Validating(object sender, CancelEventArgs e)
        {
            PhoneNumber3textBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber3textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber3textBox.Focus();
            }
        }

        private void PhoneNumber4textBox_Validating(object sender, CancelEventArgs e)
        {
            PhoneNumber4textBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber4textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber4textBox.Focus();
            }
        }

        private void PhoneNumber5textBox_Validating(object sender, CancelEventArgs e)
        {

            PhoneNumber5textBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(PhoneNumber5textBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                PhoneNumber5textBox.Focus();
            }
        }

        private void OfficeNumbertextBox_Validating(object sender, CancelEventArgs e)
        {
            OfficeNumbertextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(OfficeNumbertextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter correct 10 digit Mobile Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                OfficeNumbertextBox.Focus();
            }
        }

        private void CompanyPANcardNumbertextBox_Validating(object sender, CancelEventArgs e)
        {
            CompanyPANcardNumbertextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(CompanyPANcardNumbertextBox.Text, "[^A-Za-z0-9]"))
            {
                MessageBox.Show("Please enter correct 10 digit Pan Card Number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                CompanyPANcardNumbertextBox.Focus();
            }
        }

        private void CompanyAccountNumbertextBox_Validating(object sender, CancelEventArgs e)
        {
            CompanyAccountNumbertextBox.MaxLength = 15;
            if (System.Text.RegularExpressions.Regex.IsMatch(CompanyAccountNumbertextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter valid Account Number !");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                CompanyAccountNumbertextBox.Focus();
            }
        }

        private void BankIFSCcodetextBox_Validating(object sender, CancelEventArgs e)
        {
            BankIFSCcodetextBox.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(BankIFSCcodetextBox.Text, "[^0-9A-Za-z]"))
            {
                MessageBox.Show("Please enter 11 digit IFSC code!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                BankIFSCcodetextBox.Focus();
            }
        }

        private void CompanyTINnumbertextBox_Validating(object sender, CancelEventArgs e)
        {
            CompanyTINnumbertextBox.MaxLength = 11;
            if (System.Text.RegularExpressions.Regex.IsMatch(CompanyTINnumbertextBox.Text, "[^0-9A-Za-z]"))
            {
                MessageBox.Show("Please enter 11 digit TIN number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                CompanyTINnumbertextBox.Focus();
            }
        }

        private void CompanyTAXnumbertextBox_Validating(object sender, CancelEventArgs e)
        {
            CompanyTAXnumbertextBox.MaxLength = 15;
            if (System.Text.RegularExpressions.Regex.IsMatch(CompanyTAXnumbertextBox.Text, "[^0-9A-Za-z]"))
            {
                MessageBox.Show("Please enter 11 digit TIN number!");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                CompanyTAXnumbertextBox.Focus();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = 1; foreach (DataGridViewRow row in dataGridView1.Rows) { row.Cells["SNO"].Value = i; i++; }
        }

        private void CompanyBankBranchnametextBox_TextChanged(object sender, EventArgs e)
        {
            CompanyBankBranchnametextBox.MaxLength = 30;
            if (System.Text.RegularExpressions.Regex.IsMatch(CompanyBankBranchnametextBox.Text, "[^a-zA-Z0-9 @*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid Bank and Branch name!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                CompanyBankBranchnametextBox.Focus();
            }
        }

        private void CompanyBankBranchnametextBox_Validating(object sender, CancelEventArgs e)
        {
            


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                command.CommandText = "Select * from   SupplierRegistration Where Name_Of_The_Company ='" + comboBox1.Text + "'";

                command.Parameters.AddWithValue("@Name_Of_The_Company", comboBox1.Text);

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    dr.Close();

                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);
                    SqlConnection connec = new SqlConnection(connectionString);
                    connec.Open();
                    SqlDataAdapter dg = new SqlDataAdapter(command);
                    DataSet dw = new DataSet();
                    dg.Fill(dw, "SupplierRegistration");
                    int j = dw.Tables["SupplierRegistration"].Rows.Count;

                    if (j > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData1 = new Byte[0];
                        byteBLOBData1 = (Byte[])(dw.Tables["SupplierRegistration"].Rows[j - 1]["ID_Image"]);
                        MemoryStream stmBLOBData2 = new MemoryStream(byteBLOBData1);
                        // MessageBox.Show(stmBLOBData2.ToString());

                        pictureBox2.Image = Image.FromStream(stmBLOBData2);
                      

                        Form Form3 = new Form3();

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.Dock = DockStyle.Fill;
                        pictureBox2.Image = Image.FromStream(stmBLOBData2);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        Form3.Controls.Add(pictureBox2);
                        pictureBox2.Dock = DockStyle.Fill;
                        pictureBox2.Visible = true;
                        this.pictureBox2.Size = new System.Drawing.Size(140, 140);

                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        Form3.ShowDialog();




                    }
                    connec.Close();
                }
            }
            catch 
            {
              // MessageBox.Show("Network related issues please check internet connection");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                command.CommandText = "Select * from   SupplierRegistration Where Name_Of_The_Company ='" + comboBox1.Text + "'";

                command.Parameters.AddWithValue("@Name_Of_The_Company", comboBox1.Text);

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    dr.Close();
                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);
                    SqlConnection connec = new SqlConnection(connectionString);
                    connec.Open();
                    SqlDataAdapter dg = new SqlDataAdapter(command);
                    DataSet dw = new DataSet();
                    dg.Fill(dw, "SupplierRegistration");
                    int j = dw.Tables["SupplierRegistration"].Rows.Count;

                    if (j > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData1 = new Byte[0];
                        byteBLOBData1 = (Byte[])(dw.Tables["SupplierRegistration"].Rows[j - 1]["Address_Image"]);
                        MemoryStream stmBLOBData2 = new MemoryStream(byteBLOBData1);
                        // MessageBox.Show(stmBLOBData2.ToString());

                        pictureBox1.Image = Image.FromStream(stmBLOBData2);
                        Form Form4 = new Form4();

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.Dock = DockStyle.Fill;
                        pictureBox1.Image = Image.FromStream(stmBLOBData2);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        Form4.Controls.Add(pictureBox1);
                        pictureBox1.Dock = DockStyle.Fill;
                        pictureBox1.Visible = true;
                        this.pictureBox1.Size = new System.Drawing.Size(140, 140);

                        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                        Form4.ShowDialog();

                    }
                    connec.Close();
                }
            }
            catch 
            {
                //MessageBox.Show("Network related issues please check internet connection");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        /*private void groupBox3_Enter(object sender, EventArgs e)
        {

        }*/

        }
        }
        
    

