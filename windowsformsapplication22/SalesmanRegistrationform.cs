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
using System.Reflection;


namespace WindowsFormsApplication22
{
    public partial class SalesmanRegistrationform : Form
    {
        int _selectedIndex;
        string imgloc;
        string imgloc2;
        string imgloc1;


     
        public SalesmanRegistrationform()
        {
            InitializeComponent();
            this.dataGridView2.ReadOnly = true;
            this.IDProofcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AddressProofcomboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.EducationcomboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            Fillcombo();
            textBoxRefcontact.MaxLength = 10;
            button10.Enabled = false;
            button3.Enabled = false;
            filllabel();

            dataGridView2.DataSource = null;
            button8.Enabled = false;
            button6.Enabled = false;
        }
        void filllabel()
        {

           string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("select max(ID) from SalesmanRegistration", conn);
                command.ExecuteScalar();
                SalesmanIDtextBox.Text = (command.ExecuteScalar().ToString());

                int i = (Convert.ToInt32(SalesmanIDtextBox.Text) + 1);
                // MessageBox.Show(i.ToString());
                SalesmanIDtextBox.Text = i.ToString();

            }
            finally
            {
                conn.Close();
            }
        }
    

       
        void Fillcombo()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select Name from SalesmanRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Name"));
                    comboBox2.Items.Add(CName);

                }
            }
            finally
            {
                connection.Close();
            }
           

        }
        private void button2_Click(object sender, EventArgs e)
        {
           
            

            dataGridView2.DataSource = null;
            button8.Enabled = false;
            button6.Enabled = false;
            comboBox2.SelectedIndex = -1;
            dataGridView2.DataSource = null;
            dateTimePicker1.ResetText();
            pictureBox3.Image = null;
            pictureBox2.Image = null;
            AgenumericUpDown1.Value = 0;
            
            pictureBox1.Image = null;
            IDProofcomboBox1.SelectedIndex = -1;
            AddressProofcomboBox2.SelectedIndex = -1;
            EducationcomboBox3.SelectedIndex = -1;
            label12.Text = "";
            SalesmannametextBox.Clear();
            SalesmanAddressrichTextBox3.Clear();
            ReferredbynametextBox.Clear();
            textBox1Cno.Clear();
          
            textBoxRefcontact.Clear();
            ReferredbynametextBox.Clear();
          
            SalesmanbankbranchnametextBox.Clear();
                AccountNumbertextBox.Clear();
            BankIFSCcodetextBox.Clear();
            InternalSalescheckBox.Checked = false;
              ExternalSalescheckBox.Checked=false;
            WorkExperiencerichTextBox5.Clear();
            ReferrerAddressrichTextBox.Clear();


            linkLabel3.Text = "";
            linkLabel1.Text = "";


            
        }


        private void button1_Click(object sender, EventArgs e)
        {
           if (textBox1Cno.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter contact number!");
                return;
            }

            else if (SalesmannametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill the Salesman Name");
                return;
            }
              

        
        else if (linkLabel1.Text.Trim() == String.Empty)
           {
               MessageBox.Show("Please attach ID proof");
               return;
           }
           else if (linkLabel3.Text.Trim() == String.Empty)
           {
               MessageBox.Show("Please attach Addressproof");
               return;
           }
            else if (SalesmanAddressrichTextBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill the Address");
                return;
            }
            else if (AgenumericUpDown1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select Age");
                return;
            }
            else if (dateTimePicker1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select Date of birth");
                return;
            }
            else if (IDProofcomboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select IDProof");
                return;
            }
            else if (AddressProofcomboBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select AddressProof");
                return;
            }
            else if (EducationcomboBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select Education ");
                return;
            }
            else if (WorkExperiencerichTextBox5.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select AddressProof");
                return;
            }
            else if (SalesmanbankbranchnametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill Bank and branch name");
                return;
            }
            else if (AccountNumbertextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill Account number");
                return;
            }
            else if (BankIFSCcodetextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill IFSC code");
                return;
            }
            else if (ReferredbynametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill Referrer name");
                return;
            }
            else if (textBoxRefcontact.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Fill  Referrer Contact Number code");
                return;
            }
           else if (label12.Text.Trim() == string.Empty)
           {
               MessageBox.Show("Please Browse the Image");
               return;
           }

           else if (System.Text.RegularExpressions.Regex.IsMatch(SalesmannametextBox.Text, "[^a-zA-Z()[]]]"))
           {
               MessageBox.Show("Please enter the Valid Name !");
               // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
               SalesmannametextBox.Focus();
               return;
           }
           else
               if (System.Text.RegularExpressions.Regex.IsMatch(ReferredbynametextBox.Text, "[^a-zA-Z]"))
           {
               MessageBox.Show("Please enter the Valid Referrer Name !");
               // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
               ReferredbynametextBox.Focus();
               return;
           }
          

           else if (!System.Text.RegularExpressions.Regex.IsMatch(BankIFSCcodetextBox.Text, "^[0-9A-Za-z]{11}$"))
           {
               MessageBox.Show("Please enter 11 digit IFSC code!");
               //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
               BankIFSCcodetextBox.Focus();
               return;

           }
         

               else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1Cno.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter valid Mobile Number!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                textBox1Cno.Focus();
                return;
            }



            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxRefcontact.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter valid Referrer Mobile Number!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                textBoxRefcontact.Focus();
                return;
            }
               else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1Cno.Text, @"^\d{10}$"))
               {
                   MessageBox.Show("Please enter valid Referrer Mobile Number!");
                   //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                   textBoxRefcontact.Focus();
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
                
                 command.CommandText = "SELECT COUNT(*) FROM SalesmanRegistration Where Name=@Name ";
                command.Parameters.AddWithValue("@Name", SalesmannametextBox.Text);
                  Int32 count = (Int32)  command.ExecuteScalar();
                  if (count==0)
                {
                   
                    command.CommandText = "INSERT into SalesmanRegistration (Name,Address,Contact_Number,Age,Date_Of_Birth,Refered_By_Name,Referrer_Address,Referrer_Contact_Number,Bank_and_Branch_Name,Account_Number,Bank_IFSC_Code,Work_Experience,Other_Education_Details,Education,ID_Proof_Name,ID_Proof_File_Path,Address_Proof_Name,Address_Proof_File_Path,Image,ID,Internal_Sales,External_Sales,Image_File_Path,ID_Image,Address_Image) VALUES (@Name,@Address,@Contact_Number,@Age,@Date_Of_Birth,@Refered_By_Name,@Referrer_Address,@Referrer_Contact_Number,@Bank_and_Branch_Name,@Account_Number,@Bank_IFSC_Code,@Work_Experience,@Other_Education_Details,@Education,@ID_Proof_Name,@ID_Proof_File_Path,@Address_Proof_Name,@Address_Proof_File_Path,@Image,@ID,@Internal_Sales,@External_Sales,@Image_File_Path,@ID_Image,@Address_Image)";
               
                }
                else
                {

                    //update command come here;
                    command.CommandText = "UPDATE SalesmanRegistration set Address=@Address,Contact_Number=@Contact_Number,Age=@Age,Date_Of_Birth=@Date_Of_Birth,Refered_By_Name=@Refered_By_Name,Referrer_Address=@Referrer_Address,Referrer_Contact_Number=@Referrer_Contact_Number,Bank_and_Branch_Name=@Bank_and_Branch_Name,Account_Number=@Account_Number,Bank_IFSC_Code=@Bank_IFSC_Code,Work_Experience=@Work_Experience,Other_Education_Details=@Other_Education_Details,Education=@Education,ID_Proof_Name=@ID_Proof_Name,ID_Proof_File_Path=@ID_Proof_File_Path,Address_Proof_Name=@Address_Proof_Name,Address_Proof_File_Path=@Address_Proof_File_Path,Image=@Image,ID=@ID,Internal_Sales=@Internal_Sales,External_Sales=@External_Sales,Image_File_Path=@Image_File_Path,ID_Image=@ID_Image,Address_Image=@Address_Image Where Name=@Name";
               
               
        

                }
                  command.Connection = connection;
                  command.CommandType = CommandType.Text;


                  connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                  connection = new SqlConnection(connectionString);
                  string ImagesDirectory =Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),"Images");
                  string cs = label12.Text;
                 // MessageBox.Show(cs);
                  String strBLOBFilePath = cs;
                 // MessageBox.Show(strBLOBFilePath);
                  
                  //Read jpg into file stream, and from there into Byte array.
                  FileStream fsBLOBFile = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
                  Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
                  fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                  fsBLOBFile.Close();

                  //Create parameter for insert command and add to SqlCommand object.
                  SqlParameter prm = new SqlParameter("@Image", SqlDbType.VarBinary, bytBLOBData.Length, ParameterDirection.Input, false,
                              0, 0, null, DataRowVersion.Current, bytBLOBData);
                    
                  
                  command.Parameters.AddWithValue("@Address", SalesmanAddressrichTextBox3.Text);
                  command.Parameters.AddWithValue("@Contact_Number", textBox1Cno.Text);
                  command.Parameters.AddWithValue("@Age", AgenumericUpDown1.Value);
                  command.Parameters.AddWithValue("@Date_Of_Birth", dateTimePicker1.Value);
                  command.Parameters.AddWithValue("@Refered_By_Name", ReferredbynametextBox.Text);
                  command.Parameters.AddWithValue("@Referrer_Address", ReferrerAddressrichTextBox.Text);
                  command.Parameters.AddWithValue("@Referrer_Contact_Number", textBoxRefcontact.Text);
                  command.Parameters.AddWithValue("@Bank_and_Branch_Name", SalesmanbankbranchnametextBox.Text);
                  command.Parameters.AddWithValue("@Account_Number", AccountNumbertextBox.Text);
                  command.Parameters.AddWithValue("@Bank_IFSC_Code", BankIFSCcodetextBox.Text);
                  command.Parameters.AddWithValue("@Work_Experience", WorkExperiencerichTextBox5.Text);
                  command.Parameters.AddWithValue("@Other_Education_Details", SelectEducationtextBox.Text);
                  command.Parameters.AddWithValue("@Education", EducationcomboBox3.Text);
                  command.Parameters.AddWithValue("@ID_Proof_Name", IDProofcomboBox1.Text);
                  command.Parameters.AddWithValue("@ID_Proof_File_Path", linkLabel1.Text);
                  command.Parameters.AddWithValue("@Address_Proof_Name", AddressProofcomboBox2.Text);
                  command.Parameters.AddWithValue("@Address_Proof_File_Path", linkLabel3.Text);
                  command.Parameters.AddWithValue("@ID", SalesmanIDtextBox.Text);
                  command.Parameters.AddWithValue("@Image_File_Path", label12.Text); 

                if (InternalSalescheckBox.Checked)
                  {
                      command.Parameters.AddWithValue("@Internal_Sales", 1);
                  }
                  else
                  {
                      command.Parameters.AddWithValue("@Internal_Sales", 0);
                  }

                  if (ExternalSalescheckBox.Checked)
                  {
                      command.Parameters.AddWithValue("@External_Sales", 1);
                  }
                  else
                  {
                      command.Parameters.AddWithValue("@External_Sales", 0);
                  }





                  connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                  connection = new SqlConnection(connectionString);
                  string ImagesDirectory1 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
                  string ssss = linkLabel1.Text;
                 // MessageBox.Show(ssss);

                  String strBLOBFilePath1 = ssss;
                //  MessageBox.Show(strBLOBFilePath1);
                  //  String strBLOBFilePath = @"C:\images (1).jpg";

                  //Read jpg into file stream, and from there into Byte array.
                  FileStream fsBLOBFile1 = new FileStream(strBLOBFilePath1, FileMode.Open, FileAccess.Read);
                  Byte[] bytBLOBData1 = new Byte[fsBLOBFile1.Length];
                  fsBLOBFile1.Read(bytBLOBData1, 0, bytBLOBData1.Length);
                  fsBLOBFile1.Close();

                  //Create parameter for insert command and add to SqlCommand object.
                  SqlParameter prm1 = new SqlParameter("@ID_Image", SqlDbType.VarBinary, bytBLOBData1.Length, ParameterDirection.Input, false,
                              0, 0, null, DataRowVersion.Current, bytBLOBData1);






                  connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                  connection = new SqlConnection(connectionString);
                  string ImagesDirectory2 = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
                  string ssq = linkLabel3.Text;
                 // MessageBox.Show(ssq);
                  String strBLOBFilePath2 = ssq;
                 // MessageBox.Show(strBLOBFilePath2);
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
                      











































                  command.Parameters.Add(prm);

                command.ExecuteNonQuery();
          

                 MessageBox.Show("Registered Successfully!");

                 SalesmannametextBox.Enabled = true;
                 button2_Click(sender, e);



                 //SalesmanRegistrationform form = new SalesmanRegistrationform();
                // form.Refresh();
                 button10.Enabled = false;
                 button3.Enabled = false;
                 filllabel();
                 

            }
            catch

            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
                
        
                
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address Proof successfully saved");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID Proof successfully saved");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            
                
         
        }

        private void radioButton2i_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonInternalsales_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void SalesmanRegistrationform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.SalesmanRegistration' table. You can move, or remove it, as needed.
           // this.salesmanRegistrationTableAdapter.Fill(this.marketDataSet.SalesmanRegistration);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Photo saved Successfully");
        }

        private void button12_Click(object sender, EventArgs e)
        {

           
        }

        private void button11_Click(object sender, EventArgs e)
        {

          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter= "Images.|*.jpg;*.jpeg;*.png;*.gif;";
            DialogResult dr = OpenFd.ShowDialog();
           
            pictureBox1.Image = Image.FromFile(OpenFd.FileName);
           imgloc = OpenFd.FileName.ToString();
            pictureBox1.ImageLocation = imgloc;
            label12.Text = imgloc;

          
            
       

          }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
     
          
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button10_Click(object sender, EventArgs e)
        {



            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images.|*.jpg;*.jpeg;*.png;*.gif;";
            DialogResult dr = OpenFd.ShowDialog();
            pictureBox3.Image = Image.FromFile(OpenFd.FileName);
            imgloc2 = OpenFd.FileName.ToString();
            pictureBox3.ImageLocation = imgloc2;
            linkLabel1.Text = imgloc2;




          
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
             _selectedIndex = EducationcomboBox3.SelectedIndex;
             if (_selectedIndex == 0)
             {
                 SelectEducationtextBox.Enabled = false;

             }
             else if (_selectedIndex == 1)
             {
                 SelectEducationtextBox.Enabled = false;

             }
             else if (_selectedIndex == 2)
             {
                 SelectEducationtextBox.Enabled = false;

             }
             else if (_selectedIndex == 3)
             {
                 SelectEducationtextBox.Enabled = false;

             }
             else if (_selectedIndex == 4)
             {
                 SelectEducationtextBox.Enabled = true;

             }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button10.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
           



            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images.|*.jpg;*.jpeg;*.png;*.gif;";
            DialogResult dr = OpenFd.ShowDialog();
            pictureBox2.Image = Image.FromFile(OpenFd.FileName);
            imgloc2 = OpenFd.FileName.ToString();
            pictureBox2.ImageLocation = imgloc2;
            linkLabel3.Text = imgloc2;


           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SelectEducationtextBox.MaxLength = 20;
            if (System.Text.RegularExpressions.Regex.IsMatch(SelectEducationtextBox.Text, "[^a-zA-Z0-9@*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid address!");
                SelectEducationtextBox.Focus();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
                command.CommandText = "SELECT * from SalesmanRegistration Where  Name= '" + comboBox2.Text + "'  ";

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "SalesmanRegistration");
                dataGridView2.DataSource = ds.Tables["SalesmanRegistration"];
                SqlDataReader Reader = command.ExecuteReader();
            }

            catch 
            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

             
        }

        private void button5_Click_1(object sender, EventArgs e)
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
                command.CommandText = "Select * from   SalesmanRegistration Where Name='" + comboBox2 .Text+ "'";

                command.Parameters.AddWithValue("@Name", comboBox2.Text);




                
                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    SalesmannametextBox.Text = dr["Name"].ToString();

                    SalesmanAddressrichTextBox3.Text = dr["Address"].ToString();

                    AgenumericUpDown1.Text = dr["Age"].ToString();

                    textBox1Cno.Text = dr["Contact_Number"].ToString();

                    dateTimePicker1.Text = dr["Date_Of_Birth"].ToString();

                    ReferredbynametextBox.Text = dr["Refered_By_Name"].ToString();

                    textBoxRefcontact.Text = dr["Referrer_Contact_Number"].ToString();

                    ReferrerAddressrichTextBox.Text = dr["Referrer_Address"].ToString();
//InternalSalescheckBox.Text = dr["Internal_Sales"].ToString();

                   // ExternalSalescheckBox.Text = dr["External_Sales"].ToString();
                    Int32 drInternalSalesCheckBoxStatus = Convert.ToInt32(dr["Internal_Sales"].ToString());
                    if (drInternalSalesCheckBoxStatus == 1)
                    {

                        InternalSalescheckBox.CheckState = CheckState.Checked;
                        InternalSalescheckBox.Checked = true;
                    }
                    else
                    {
                        InternalSalescheckBox.CheckState = CheckState.Unchecked;
                        InternalSalescheckBox.Checked = false;
                    }

                    Int32 drExternalSalesCheckBoxStatus = Convert.ToInt32(dr["External_Sales"].ToString());
                    if (drExternalSalesCheckBoxStatus == 1)
                    {
                        ExternalSalescheckBox.CheckState = CheckState.Checked;
                        ExternalSalescheckBox.Checked = true;
                    }
                    else
                    {
                        ExternalSalescheckBox.CheckState = CheckState.Unchecked;
                        ExternalSalescheckBox.Checked = false;
                    }
                         


                    SalesmanIDtextBox.Text = dr["ID"].ToString();

                    WorkExperiencerichTextBox5.Text = dr["Work_Experience"].ToString();

                    SalesmanbankbranchnametextBox.Text = dr["Bank_and_Branch_Name"].ToString();

                    AccountNumbertextBox.Text = dr["Account_Number"].ToString();

                    BankIFSCcodetextBox.Text = dr["Bank_IFSC_Code"].ToString();

                    IDProofcomboBox1.Text = dr["ID_Proof_Name"].ToString();

                    AddressProofcomboBox2.Text = dr["Address_Proof_Name"].ToString();

                    EducationcomboBox3.Text = dr["Education"].ToString();

                    SelectEducationtextBox.Text = dr["Other_Education_Details"].ToString();
                    command.Parameters.AddWithValue("@Image_File_Path", label12.Text);
                    label12.Text = dr["Image_File_Path"].ToString();


                    dr.Close(); 
                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);
                    SqlConnection cn = new SqlConnection(connectionString);
                    cn.Open();
                 
                   SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "SalesmanRegistration");
                    int c = ds.Tables["SalesmanRegistration"].Rows.Count;

                    if (c > 0)
                    {  
                         
                         //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData = new Byte[0];
                        byteBLOBData = (Byte[])(ds.Tables["SalesmanRegistration"].Rows[c - 1]["Image"]);
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        pictureBox1.Image = Image.FromStream(stmBLOBData);
                        

                    }
                    
                }  
            }
            catch
            {

                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");

            }
                
            
        }

        private void textBox1Cno_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxRefcontact_TextChanged(object sender, EventArgs e)
        {
            textBoxRefcontact.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxRefcontact.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter Valid Referrer contact number !");
                //ContactPerson1textBox.Text.Remove(ContactPerson1textBox.Text.Length - 1);
                textBoxRefcontact.Focus();
            }
        }

        private void SalesmanRegistrationform_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxRefcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void SalesmannametextBox_Va(object sender, CancelEventArgs e)
        {

        }

        private void SalesmannametextBox_Validating(object sender, CancelEventArgs e)
        {

            
            
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            SalesmannametextBox.Enabled = false;
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
                command.CommandText = "Select * from   SalesmanRegistration Where Name='" + comboBox2.Text + "'";

                command.Parameters.AddWithValue("@Name", comboBox2.Text);





                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    SalesmannametextBox.Text = dr["Name"].ToString();

                    SalesmanAddressrichTextBox3.Text = dr["Address"].ToString();

                    AgenumericUpDown1.Text = dr["Age"].ToString();

                    textBox1Cno.Text = dr["Contact_Number"].ToString();

                    dateTimePicker1.Text = dr["Date_Of_Birth"].ToString();

                    ReferredbynametextBox.Text = dr["Refered_By_Name"].ToString();

                    textBoxRefcontact.Text = dr["Referrer_Contact_Number"].ToString();

                    ReferrerAddressrichTextBox.Text = dr["Referrer_Address"].ToString();
                    //InternalSalescheckBox.Text = dr["Internal_Sales"].ToString();

                    // ExternalSalescheckBox.Text = dr["External_Sales"].ToString();
                    Int32 drInternalSalesCheckBoxStatus = Convert.ToInt32(dr["Internal_Sales"].ToString());
                    if (drInternalSalesCheckBoxStatus == 1)
                    {

                        InternalSalescheckBox.CheckState = CheckState.Checked;
                        InternalSalescheckBox.Checked = true;
                    }
                    else
                    {
                        InternalSalescheckBox.CheckState = CheckState.Unchecked;
                        InternalSalescheckBox.Checked = false;
                    }

                    Int32 drExternalSalesCheckBoxStatus = Convert.ToInt32(dr["External_Sales"].ToString());
                    if (drExternalSalesCheckBoxStatus == 1)
                    {
                        ExternalSalescheckBox.CheckState = CheckState.Checked;
                        ExternalSalescheckBox.Checked = true;
                    }
                    else
                    {
                        ExternalSalescheckBox.CheckState = CheckState.Unchecked;
                        ExternalSalescheckBox.Checked = false;
                    }



                    SalesmanIDtextBox.Text = dr["ID"].ToString();

                    WorkExperiencerichTextBox5.Text = dr["Work_Experience"].ToString();

                    SalesmanbankbranchnametextBox.Text = dr["Bank_and_Branch_Name"].ToString();

                    AccountNumbertextBox.Text = dr["Account_Number"].ToString();

                    BankIFSCcodetextBox.Text = dr["Bank_IFSC_Code"].ToString();

                    IDProofcomboBox1.Text = dr["ID_Proof_Name"].ToString();

                    AddressProofcomboBox2.Text = dr["Address_Proof_Name"].ToString();

                    EducationcomboBox3.Text = dr["Education"].ToString();
                    SalesmanIDtextBox.Text = dr["ID"].ToString();

                    SelectEducationtextBox.Text = dr["Other_Education_Details"].ToString();
                    linkLabel1.Text = dr["ID_Proof_File_Path"].ToString();
                    linkLabel3.Text = dr["Address_Proof_File_Path"].ToString();
                   // 
                    label12.Text = dr["Image_File_Path"].ToString();



                    dr.Close();

                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);
                    SqlConnection cn = new SqlConnection(connectionString);
                    cn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "SalesmanRegistration");
                    int c = ds.Tables["SalesmanRegistration"].Rows.Count;

                    if (c > 0)
                    {

                        //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData = new Byte[0];
                        byteBLOBData = (Byte[])(ds.Tables["SalesmanRegistration"].Rows[c - 1]["Image"]);
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        pictureBox1.Image = Image.FromStream(stmBLOBData);


                    }
                    cn.Close();





                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);
                    SqlConnection connec = new SqlConnection(connectionString);
                    connec.Open();
                    SqlDataAdapter dg = new SqlDataAdapter(command);
                    DataSet dw = new DataSet();
                    dg.Fill(dw, "SalesmanRegistration");
                    int j = dw.Tables["SalesmanRegistration"].Rows.Count;

                    if (j > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData1 = new Byte[0];
                        byteBLOBData1 = (Byte[])(dw.Tables["SalesmanRegistration"].Rows[j - 1]["Address_Image"]);
                        MemoryStream stmBLOBData2 = new MemoryStream(byteBLOBData1);
                        // MessageBox.Show(stmBLOBData2.ToString());

                        pictureBox3.Image = Image.FromStream(stmBLOBData2);


                    }
                    connec.Close();
                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);





                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();



                    SqlDataAdapter dq = new SqlDataAdapter(command);
                    DataSet df = new DataSet();
                    dq.Fill(df, "SalesmanRegistration");
                    int a = df.Tables["SalesmanRegistration"].Rows.Count;

                    if (a > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.


                        Byte[] byteBLOBData2 = new Byte[0];
                        byteBLOBData2 = (Byte[])(df.Tables["SalesmanRegistration"].Rows[a - 1]["ID_Image"]);
                        MemoryStream stmBLOBData1 = new MemoryStream(byteBLOBData2);
                        pictureBox2.Image = Image.FromStream(stmBLOBData1);


                    }
                    conn.Close();


                }
            }
            catch (Exception ex)
            {

            }

        }

        private void button8_Click_1(object sender, EventArgs e)
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
                command.CommandText = "SELECT * from SalesmanRegistration Where  Name= '" + comboBox2.Text + "'  ";

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "SalesmanRegistration");
                dataGridView2.DataSource = ds.Tables["SalesmanRegistration"];
                SqlDataReader Reader = command.ExecuteReader();
                button6.Enabled = true;
            }

            catch 
            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }

        private void SalesmannametextBox_TextChanged(object sender, EventArgs e)
        {
            
            SalesmannametextBox.MaxLength = 25;
            if (System.Text.RegularExpressions.Regex.IsMatch(SalesmannametextBox.Text, "[^a-zA-Z()[]]]"))
            {
                MessageBox.Show("Please enter the Valid Name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                SalesmannametextBox.Focus();
                
            }
        }

        private void SalesmanAddressrichTextBox3_TextChanged(object sender, EventArgs e)
        {
            SalesmanAddressrichTextBox3.MaxLength = 55;
            if (System.Text.RegularExpressions.Regex.IsMatch(SalesmanAddressrichTextBox3.Text, "[^a-zA-Z0-9@*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid Address!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                SalesmanAddressrichTextBox3.Focus();
                
            }
        }

        private void textBox1Cno_TextChanged(object sender, EventArgs e)
        {
            textBox1Cno.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1Cno.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter valid  Mobile Number!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                textBox1Cno.Focus();
               
            }
        }

        private void textBox1Cno_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textBoxRefcontact_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void ReferrerAddressrichTextBox_TextChanged(object sender, EventArgs e)
        {
            ReferrerAddressrichTextBox.MaxLength = 55;
            if (System.Text.RegularExpressions.Regex.IsMatch(ReferrerAddressrichTextBox.Text, "[^a-zA-Z0-9@*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid Referrer Address!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                ReferrerAddressrichTextBox.Focus();
            }
        }

        private void SalesmanbankbranchnametextBox_TextChanged(object sender, EventArgs e)
        {
            SalesmanbankbranchnametextBox.MaxLength = 30;
            if (System.Text.RegularExpressions.Regex.IsMatch(SalesmanbankbranchnametextBox.Text, "[^a-zA-Z0-9@*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid Bank and Branch name!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                SalesmanbankbranchnametextBox.Focus();
            }
        }

        private void AccountNumbertextBox_TextChanged(object sender, EventArgs e)
        {

            AccountNumbertextBox.MaxLength = 15;

            if (System.Text.RegularExpressions.Regex.IsMatch(AccountNumbertextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter the Valid Account Number!");
                AccountNumbertextBox.Focus();
            }
        }

        private void AccountNumbertextBox_Validating(object sender, CancelEventArgs e)
        {

            AccountNumbertextBox.MaxLength = 15;

            if (System.Text.RegularExpressions.Regex.IsMatch(AccountNumbertextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter the Valid Account Number!");
                AccountNumbertextBox.Focus();
            }


        }

        private void SalesmanbankbranchnametextBox_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void BankIFSCcodetextBox_Validating(object sender, CancelEventArgs e)
        {

            BankIFSCcodetextBox.MaxLength = 11;

            if (System.Text.RegularExpressions.Regex.IsMatch(BankIFSCcodetextBox.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Please enter the Valid IFSC code!");
                BankIFSCcodetextBox.Focus();
            }
           
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

        private void ReferredbynametextBox_TextChanged(object sender, EventArgs e)
        {
            ReferredbynametextBox.MaxLength = 25;
            if (System.Text.RegularExpressions.Regex.IsMatch(ReferredbynametextBox.Text, "[^a-zA-Z ]"))
            {
                MessageBox.Show("Please enter the Valid Referrer Name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                ReferredbynametextBox.Focus();
            }
        }

        private void WorkExperiencerichTextBox5_TextChanged(object sender, EventArgs e)
        {
            WorkExperiencerichTextBox5.MaxLength = 55;
            if (System.Text.RegularExpressions.Regex.IsMatch(WorkExperiencerichTextBox5.Text, "[^a-zA-Z0-9@*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid Referrer Address!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                WorkExperiencerichTextBox5.Focus();
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            button8.Enabled = true;
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
                command.CommandText = "Select * from   SalesmanRegistration Where  Name= '" + comboBox2.Text + "' ";


                command.Parameters.AddWithValue("@Name", comboBox2.Text);


                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    dr.Close();


                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);
                    SqlConnection connec = new SqlConnection(connectionString);
                    connec.Open();
                    SqlDataAdapter dq = new SqlDataAdapter(command);
                    DataSet df = new DataSet();
                    dq.Fill(df, "SalesmanRegistration");
                    int a = df.Tables["SalesmanRegistration"].Rows.Count;

                    if (a > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.


                        Byte[] byteBLOBData2 = new Byte[0];
                        byteBLOBData2 = (Byte[])(df.Tables["SalesmanRegistration"].Rows[a - 1]["ID_Image"]);
                        MemoryStream stmBLOBData1 = new MemoryStream(byteBLOBData2);
                        pictureBox3.Image = Image.FromStream(stmBLOBData1);
                        Form Form3 = new Form3();

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.Dock = DockStyle.Fill;
                        pictureBox3.Image = Image.FromStream(stmBLOBData1);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        Form3.Controls.Add(pictureBox3);
                        pictureBox3.Dock = DockStyle.Fill;
                        pictureBox3.Visible = true;
                        this.pictureBox3.Size = new System.Drawing.Size(140, 140);

                        pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
                        Form3.ShowDialog();




                    }
                    connec.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                command.CommandText = "Select * from   SalesmanRegistration Where  Name= '" + comboBox2.Text + "' ";


                command.Parameters.AddWithValue("@Name", comboBox2.Text);

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
                    dg.Fill(dw, "SalesmanRegistration");
                    int j = dw.Tables["SalesmanRegistration"].Rows.Count;

                    if (j > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData1 = new Byte[0];
                        byteBLOBData1 = (Byte[])(dw.Tables["SalesmanRegistration"].Rows[j - 1]["Address_Image"]);
                        MemoryStream stmBLOBData2 = new MemoryStream(byteBLOBData1);
                        // MessageBox.Show(stmBLOBData2.ToString());

                        pictureBox2.Image = Image.FromStream(stmBLOBData2);
                        Form Form4 = new Form4();

                        PictureBox pictureBox = new PictureBox();

                        pictureBox.Dock = DockStyle.Fill;
                        pictureBox2.Image = Image.FromStream(stmBLOBData2);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        Form4.Controls.Add(pictureBox2);
                        pictureBox2.Dock = DockStyle.Fill;
                        pictureBox2.Visible = true;
                        this.pictureBox2.Size = new System.Drawing.Size(140, 140);

                        pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                        Form4.ShowDialog();




                    }
                    connec.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
