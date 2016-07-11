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
    public partial class EmployeeRegistrationform : Form
    {
        int _selectedIndex;
        string imgloc;
        string imgloc2;
        string imgloc1;
        string imgloc3;
        public EmployeeRegistrationform()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            this.EducationcomboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.DesignationcomboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.IDProofcomboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.AddressProofcomboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            Fillcombo();
            Fillcombo1();
     
            Filllabel();
            button4.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
         }
      

        void Filllabel()
        {

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
       

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            try
            {
                SqlCommand command = new SqlCommand("select max(ID) from EmployeeRegistration", conn);
                command.ExecuteScalar();
                 EmployeeIDtextBox.Text = (command.ExecuteScalar().ToString());

                int i = (Convert.ToInt32(EmployeeIDtextBox.Text) + 1);
                // MessageBox.Show(i.ToString());
                EmployeeIDtextBox.Text = i.ToString();

            }
            finally
            {
                conn.Close();
            }
        }
        void Fillcombo1()
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
               var Departments = new Dictionary<string, int>();
           
                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Other_DepartmentDetails"));
                   

                DesignationcomboBox3.Items.Add(CName);


                var departmentId = myReader.GetInt32(myReader.GetOrdinal("Department_ID"));

                Departments[CName] = departmentId;
               // MessageBox.Show(departmentId.ToString());


               // DesignationcomboBox3.Items.Insert(myReader.GetInt32(0), myReader.GetInt32(1) + myReader.GetInt32(2));
                 
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
            comboBox1.SelectedIndex = -1;
            dateTimePicker.ResetText();
            AgenumericUpDown.Value = 0;
            EmployeeNametextBox.Clear();
            EmployeeaddressrichTextBox.Clear();
            ReferredbynametextBox.Clear();
            ReferrerContactNumbertextBox.Clear();
            SalesmanbankbranchnametextBox.Clear();
            AccountNumbertextBox.Clear();
            BankIFSCcodetextBox.Clear();
            Work_ExperiencerichTextBox.Clear();
            ReferrerAddressrichTextBox.Clear();
            textBox1Cno.Clear();
            InternalSalescheckBox.Checked = false;
            ExternalSalescheckBox.Checked = false;
            pictureBox1.Image = null;
            pictureBox3.Image = null;
            EducationcomboBox3.SelectedIndex=-1;
            DesignationcomboBox3.SelectedIndex=-1;
            IDProofcomboBox1.SelectedIndex=-1;
            AddressProofcomboBox2.SelectedIndex = -1;
            linkLabel2.Text = null;
            linkLabel1.Text = null;
            label12.Text = null;
            pictureBox2.Image = null;
            
        }

        void Fillcombo()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from EmployeeRegistration";
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
                    comboBox1.Items.Add(CName);

                }
            }
            catch
            {
              //  MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (EmployeeNametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter Employee name!");
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
            else if (EmployeeaddressrichTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill the Employee Address");
                return;
            }
            else if (ReferredbynametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter the Referrer name!");
                return;
            }
            else if (ReferrerContactNumbertextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill the Contact Number");
                return;
            }
            else if (Work_ExperiencerichTextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill Work Expierence");
                return;
            }
            else if (SalesmanbankbranchnametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill the Salesman bank and branch name");
                return;
            }
            else if (AccountNumbertextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill Account number");
                return;
            }
            else if (BankIFSCcodetextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please enter IFSC code");
                return;
            }
            else if (EducationcomboBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select the education  ");
                return;
            }
            else if (DesignationcomboBox3.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select the Designation");
                return;
            }
            else if (IDProofcomboBox1.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select  IDProof ");
                return;
            }
            else if (AddressProofcomboBox2.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please select Address Proof ");
                return;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(EmployeeNametextBox.Text, "[^a-zA-Z()[]]]"))
            {
                MessageBox.Show("Please enter the Valid Employee Name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                EmployeeNametextBox.Focus();
                return;
            }
            else
                if (System.Text.RegularExpressions.Regex.IsMatch(ReferredbynametextBox.Text, "[^a-zA-Z()[]]]"))
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
        //    else if (!System.Text.RegularExpressions.Regex.IsMatch(EmployeeNametextBox.Text, "[^a-zA-Z]"))
       //     {
      //          MessageBox.Show("Please enter the Valid Employee Name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
       //         EmployeeNametextBox.Focus();
      //          return;
      //      }

            else if (!System.Text.RegularExpressions.Regex.IsMatch(textBox1Cno.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter valid Mobile Number!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                textBox1Cno.Focus();
                return;
            }



                else if (!System.Text.RegularExpressions.Regex.IsMatch(ReferrerContactNumbertextBox.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Please enter valid Referrer Mobile Number!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                ReferrerContactNumbertextBox.Focus();
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


                command.CommandText = "SELECT COUNT(*) FROM EmployeeRegistration Where Name=@Name ";
                command.Parameters.AddWithValue("@Name", EmployeeNametextBox.Text);

                Int32 count = (Int32)command.ExecuteScalar();





                if (count == 0)
                {

                    command.CommandText = "INSERT into EmployeeRegistration (Name,Address,Age,Date_Of_Birth,Referred_By_Name,Referrer_Contact_Number,Referrer_Address,Work_Experience,ID,Bank_and_Branch_Name,Account_Number,Bank_IFSC_Code,Education,Other_Education_Details,Employee_Designation,ID_Proof_Name,ID_Proof_File_Path,Address_Proof_Name,Address_Proof_File_path,Image,Internal_Sales,External_Sales,Image_File_Path,ID_Image,Address_Image,contact_number) VALUES (@Name,@Address,@Age,@Date_Of_Birth,@Referred_By_Name,@Referrer_Contact_Number,@Referrer_Address,@Work_Experience,@ID,@Bank_and_Branch_Name,@Account_Number,@Bank_IFSC_Code,@Education,@Other_Education_Details,@Employee_Designation,@ID_Proof_Name,@ID_Proof_File_Path,@Address_Proof_Name,@Address_Proof_File_path,@Image,@Internal_Sales,@External_Sales,@Image_File_Path,@ID_Image,@Address_Image,@contact_number)";
                }

                else
                {
                   // command.CommandText = "delete * from EmployeeRegistration where @Name=EmployeeNametextBox.Text ";
                    command.CommandText = "UPDATE  EmployeeRegistration set Address=@Address,Age=@Age,Date_Of_Birth=@Date_Of_Birth,Referred_By_Name=@Referred_By_Name,Referrer_Contact_Number=@Referrer_Contact_Number,Referrer_Address=@Referrer_Address,Work_Experience=@Work_Experience,ID=@ID,Bank_and_Branch_Name=@Bank_and_Branch_Name,Account_Number=@Account_Number,Bank_IFSC_Code=@Bank_IFSC_Code,Education=@Education,Other_Education_Details=@Other_Education_Details,Employee_Designation=@Employee_Designation,ID_Proof_Name=@ID_Proof_Name,ID_Proof_File_Path=@ID_Proof_File_Path,Address_Proof_Name=@Address_Proof_Name,Address_Proof_File_path=@Address_Proof_File_path,Image=@Image,Internal_Sales=@Internal_Sales,External_Sales=@External_Sales,Image_File_Path=@Image_File_Path,ID_Image=@ID_Image, Address_Image = @Address_Image,contact_number=@contact_number Where Name=@Name";
                }

                command.Connection = connection;
                command.CommandType = CommandType.Text;


                connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                connection = new SqlConnection(connectionString);
                string ImagesDirectory = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");
                string sa = label12.Text;
                // MessageBox.Show(cs);
                String strBLOBFilePath = sa;
                // MessageBox.Show(strBLOBFilePath);
                //  String strBLOBFilePath = @"C:\images (1).jpg";

                //Read jpg into file stream, and from there into Byte array.
                FileStream fsBLOBFile = new FileStream(strBLOBFilePath, FileMode.Open, FileAccess.Read);
                Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
                fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                fsBLOBFile.Close();

                //Create parameter for insert command and add to SqlCommand object.
                SqlParameter prm = new SqlParameter("@Image", SqlDbType.VarBinary, bytBLOBData.Length, ParameterDirection.Input, false,
                            0, 0, null, DataRowVersion.Current, bytBLOBData);

                command.Parameters.AddWithValue("@Address", EmployeeaddressrichTextBox.Text);
                command.Parameters.AddWithValue("@Age", AgenumericUpDown.Value);
                command.Parameters.AddWithValue("@Date_Of_Birth", dateTimePicker.Value);
                command.Parameters.AddWithValue("@Referred_By_Name", ReferredbynametextBox.Text);
                command.Parameters.AddWithValue("@Referrer_Contact_Number", ReferrerContactNumbertextBox.Text);
                command.Parameters.AddWithValue("@Referrer_Address", ReferrerAddressrichTextBox.Text);

                command.Parameters.AddWithValue("@Work_Experience", Work_ExperiencerichTextBox.Text);
                command.Parameters.AddWithValue("@ID", EmployeeIDtextBox.Text);
                command.Parameters.AddWithValue("@Bank_and_Branch_Name", SalesmanbankbranchnametextBox.Text);
                command.Parameters.AddWithValue("@Account_Number", AccountNumbertextBox.Text);
                command.Parameters.AddWithValue("@Bank_IFSC_Code", BankIFSCcodetextBox.Text);
                command.Parameters.AddWithValue("@Education", EducationcomboBox3.Text);
                command.Parameters.AddWithValue("@Other_Education_Details", EducationOtherstextBox.Text);

                command.Parameters.AddWithValue("@ID_Proof_Name", IDProofcomboBox1.Text);
                command.Parameters.AddWithValue("@ID_Proof_File_Path", linkLabel1.Text);
                command.Parameters.AddWithValue("@Address_Proof_Name", AddressProofcomboBox2.Text);
                command.Parameters.AddWithValue("@Address_Proof_File_Path", linkLabel2.Text);
                command.Parameters.AddWithValue("@Image_File_Path", label12.Text);
                command.Parameters.AddWithValue("@contact_number", textBox1Cno.Text);
                {

                    string connectionString1 = null;
                    SqlConnection con;
                    SqlCommand cmd = new SqlCommand();


                    connectionString1 = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    con = new SqlConnection(connectionString1);
                    try
                    {

                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;


                        cmd.CommandText = "select Department_ID from DepartmentRegistration where Other_DepartmentDetails=@Other_DepartmentDetails";
                        cmd.Parameters.AddWithValue("@Other_DepartmentDetails", DesignationcomboBox3.Text);

                        SqlDataReader Reader = cmd.ExecuteReader();

                        while (Reader.Read())
                        {

                          string DeptID = Reader["Department_ID"].ToString();
                           // MessageBox.Show(DeptID);

                            command.Parameters.AddWithValue("@Employee_Designation", DeptID);
                            
                        }
                        
                        con.Close();

                        Reader.Close();
                    }
                    catch 
                    {
                        //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
                    }

                }


         



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






                connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                connection = new SqlConnection(connectionString);
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

                command.Parameters.Add(prm);
                command.ExecuteNonQuery();
                MessageBox.Show("Registered Successfully!");
                button2_Click(sender, e);
                EmployeeNametextBox.Enabled = true;
               // this.Refresh();
               // EmployeeRegistrationform form = new EmployeeRegistrationform();
               // form.Refresh();
                button4.Enabled = false;
                button3.Enabled = false;
                Filllabel();
                  
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

            }
      

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Photo Inserted Successfully");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Address Proof successfully saved");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ID Proof successfully saved");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {

           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Photo saved successfully");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void EducationcomboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            _selectedIndex = EducationcomboBox3.SelectedIndex;
            if (_selectedIndex == 0)
            {
                EducationOtherstextBox.Enabled = false;

            }
            else if (_selectedIndex == 1)
            {
                EducationOtherstextBox.Enabled = false;

            }
            else if (_selectedIndex == 2)
            {
                EducationOtherstextBox.Enabled = false;

            }
            else if (_selectedIndex == 3)
            {
                EducationOtherstextBox.Enabled = false;

            }
            else if (_selectedIndex == 4)
            {
                EducationOtherstextBox.Enabled = true;

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {


            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images.|*.jpg;*.jpeg;*.png;*.gif;";
            DialogResult dr = OpenFd.ShowDialog();
            pictureBox3.Image = Image.FromFile(OpenFd.FileName);
          //  MessageBox.Show(OpenFd.FileName);
            imgloc3 = OpenFd.FileName.ToString();
            pictureBox2.ImageLocation = imgloc3;
            linkLabel1.Text = imgloc3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            


            OpenFileDialog OpenFd = new OpenFileDialog();
            OpenFd.Filter = "Images.|*.jpg;*.jpeg;*.png;*.gif;";
            DialogResult dr = OpenFd.ShowDialog();
            pictureBox2.Image = Image.FromFile(OpenFd.FileName);
          //  MessageBox.Show(OpenFd.FileName);
            imgloc3 = OpenFd.FileName.ToString();
            pictureBox2.ImageLocation = imgloc3;
            linkLabel2.Text = imgloc3;
                  
        }

        private void button7_Click(object sender, EventArgs e)
        {

                OpenFileDialog OpenFd = new OpenFileDialog();
                OpenFd.Filter = "Images.|*.jpg;*.jpeg;*.png;*.gif;";
                DialogResult dr = OpenFd.ShowDialog();
               pictureBox1.Image = Image.FromFile(OpenFd.FileName);
                imgloc = OpenFd.FileName.ToString();
                pictureBox1.ImageLocation = imgloc;
                label12.Text = imgloc;
                  
            
        }

        private void EmployeeRegistrationform_Load(object sender, EventArgs e)
        {

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
                command.CommandText = "SELECT * from EmployeeRegistration Where  Name= '" + comboBox1.Text + "'  ";

                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "EmployeeRegistration");
                dataGridView1.DataSource = ds.Tables["EmployeeRegistration"];






                SqlDataReader Reader = command.ExecuteReader();
                button6.Enabled = true;



            }
            catch
            {
              //  MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            EmployeeNametextBox.Enabled = false;
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
                command.CommandText = "Select * from   EmployeeRegistration Where Name='" + comboBox1.Text + "'";

                command.Parameters.AddWithValue("@Name", comboBox1.Text);

                SqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    EmployeeNametextBox.Text = dr["Name"].ToString();

                    EmployeeaddressrichTextBox.Text = dr["Address"].ToString();

                    AgenumericUpDown.Text = dr["Age"].ToString();

                    dateTimePicker.Text = dr["Date_Of_Birth"].ToString();

                    ReferredbynametextBox.Text = dr["Referred_By_Name"].ToString();

                    ReferrerContactNumbertextBox.Text = dr["Referrer_Contact_Number"].ToString();

                    ReferrerAddressrichTextBox.Text = dr["Referrer_Address"].ToString();
                    EmployeeIDtextBox.Text = dr["ID"].ToString();

                    //InternalSalescheckBox.Text = dr["Internal_Sales"].ToString();
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

                    Work_ExperiencerichTextBox.Text = dr["Work_Experience"].ToString();








                    EmployeeIDtextBox.Text = dr["ID"].ToString();

                    SalesmanbankbranchnametextBox.Text = dr["Bank_and_Branch_Name"].ToString();

                    AccountNumbertextBox.Text = dr["Account_Number"].ToString();

                    BankIFSCcodetextBox.Text = dr["Bank_IFSC_Code"].ToString();

                    EducationcomboBox3.Text = dr["Education"].ToString();

                    EducationOtherstextBox.Text = dr["Other_Education_Details"].ToString();

                    DesignationcomboBox3.Text = dr["Employee_Designation"].ToString();


                    IDProofcomboBox1.Text = dr["ID_Proof_Name"].ToString();


                    AddressProofcomboBox2.Text = dr["Address_Proof_Name"].ToString();



                    linkLabel1.Text = dr["ID_Proof_File_Path"].ToString();


                    linkLabel2.Text = dr["Address_Proof_File_Path"].ToString();

                    label12.Text = dr["Image_File_Path"].ToString();



                    dr.Close();


                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();

                    connection = new SqlConnection(connectionString);
                    SqlConnection cn = new SqlConnection(connectionString);
                    cn.Open();



                    SqlDataAdapter da = new SqlDataAdapter(command);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "EmployeeRegistration");
                    int c = ds.Tables["EmployeeRegistration"].Rows.Count;

                    if (c > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData = new Byte[0];
                        byteBLOBData = (Byte[])(ds.Tables["EmployeeRegistration"].Rows[c - 1]["Image"]);
                        MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                        pictureBox1.Image = Image.FromStream(stmBLOBData);

                    }
                    cn.Close();








                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();

                    connection = new SqlConnection(connectionString);

                    SqlConnection conn = new SqlConnection(connectionString);
                    conn.Open();



                    SqlDataAdapter dq = new SqlDataAdapter(command);
                    DataSet df = new DataSet();
                    dq.Fill(df, "EmployeeRegistration");
                    int a = df.Tables["EmployeeRegistration"].Rows.Count;

                    if (a > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.


                        Byte[] byteBLOBData2 = new Byte[0];
                        byteBLOBData2 = (Byte[])(df.Tables["EmployeeRegistration"].Rows[a - 1]["ID_Image"]);
                        MemoryStream stmBLOBData1 = new MemoryStream(byteBLOBData2);
                        pictureBox3.Image = Image.FromStream(stmBLOBData1);


                    }
                    conn.Close();



                    connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
                    connection = new SqlConnection(connectionString);
                    SqlConnection con = new SqlConnection(connectionString);
                    con.Open();
                    SqlDataAdapter dg = new SqlDataAdapter(command);
                    DataSet dw = new DataSet();
                    dg.Fill(dw, "EmployeeRegistration");
                    int j = dw.Tables["EmployeeRegistration"].Rows.Count;

                    if (j > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData1 = new Byte[0];
                        byteBLOBData1 = (Byte[])(dw.Tables["EmployeeRegistration"].Rows[j - 1]["Address_Image"]);
                        MemoryStream stmBLOBData2 = new MemoryStream(byteBLOBData1);
                        // MessageBox.Show(stmBLOBData2.ToString());

                        pictureBox2.Image = Image.FromStream(stmBLOBData2);


                    }
                    con.Close();


                }

            
              }
        
            catch 
            {
               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReferrerContactNumbertextBox_Validating(object sender, KeyPressEventArgs e)
        {
            ReferrerContactNumbertextBox.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(ReferrerContactNumbertextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter the Valid Mobile number !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                ReferrerContactNumbertextBox.Focus();
            }
        }

        private void IDProofcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
        }

        private void AddressProofcomboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = true;
        }

        private void EmployeeNametextBox_TextChanged(object sender, EventArgs e)
        {
            EmployeeNametextBox.MaxLength = 25;
            if (System.Text.RegularExpressions.Regex.IsMatch(EmployeeNametextBox.Text, "[^a-zA-Z()[]]]"))
            {
                MessageBox.Show("Please enter the Valid Name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                EmployeeNametextBox.Focus();
            }
        }

        private void EmployeeaddressrichTextBox_TextChanged(object sender, EventArgs e)
        {
            EmployeeaddressrichTextBox.MaxLength = 55;
            if (System.Text.RegularExpressions.Regex.IsMatch(EmployeeaddressrichTextBox.Text, "[^a-zA-Z0-9@*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid Address!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                EmployeeaddressrichTextBox.Focus();
            }
        }

        private void ReferredbynametextBox_TextChanged(object sender, EventArgs e)
        {
            ReferredbynametextBox.MaxLength = 25;
            if (System.Text.RegularExpressions.Regex.IsMatch(ReferredbynametextBox.Text, "[^a-zA-Z()[]]]"))
            {
                MessageBox.Show("Please enter the Valid Referrer Name !");
                // NameofthecompanytextBox.Text.Remove(NameofthecompanytextBox.Text.Length - 1);
                ReferredbynametextBox.Focus();
            }
        }

        private void ReferrerContactNumbertextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReferrerContactNumbertextBox_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void ReferrerAddressrichTextBox_TextChanged(object sender, EventArgs e)
        {

            ReferrerAddressrichTextBox.MaxLength = 55;
            if (System.Text.RegularExpressions.Regex.IsMatch(ReferrerAddressrichTextBox.Text, "[^a-zA-Z0-9 @*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid Referrer Address!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                ReferrerAddressrichTextBox.Focus();
            }
        }

        private void Work_ExperiencerichTextBox_TextChanged(object sender, EventArgs e)
        {
            Work_ExperiencerichTextBox.MaxLength = 55;
            if (System.Text.RegularExpressions.Regex.IsMatch(Work_ExperiencerichTextBox.Text, "[^a-zA-Z0-9 @*&#$()[]]"))
            {
                MessageBox.Show("Please enter valid Work Experience!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                Work_ExperiencerichTextBox.Focus();
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
            AccountNumbertextBox.MaxLength = 11;

            if (System.Text.RegularExpressions.Regex.IsMatch(AccountNumbertextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter the Valid Account Number!");
                AccountNumbertextBox.Focus();
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

        private void BankIFSCcodetextBox_Validating(object sender, CancelEventArgs e)
        {
            BankIFSCcodetextBox.MaxLength = 11;

            if (System.Text.RegularExpressions.Regex.IsMatch(BankIFSCcodetextBox.Text, "[^a-zA-Z0-9]"))
            {
                MessageBox.Show("Please enter the Valid IFSC code!");
                BankIFSCcodetextBox.Focus();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button5.Enabled = true;
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
                command.CommandText = "Select * from   EmployeeRegistration Where Name='" + comboBox1.Text + "'";

                command.Parameters.AddWithValue("@Name", comboBox1.Text);

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
                    dq.Fill(df, "EmployeeRegistration");
                    int a = df.Tables["EmployeeRegistration"].Rows.Count;

                    if (a > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.


                        Byte[] byteBLOBData2 = new Byte[0];
                        byteBLOBData2 = (Byte[])(df.Tables["EmployeeRegistration"].Rows[a - 1]["ID_Image"]);
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
            catch (Exception ex)
            {
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
                command.CommandText = "Select * from   EmployeeRegistration Where Name='" + comboBox1.Text + "'";

                command.Parameters.AddWithValue("@Name", comboBox1.Text);

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
                    dg.Fill(dw, "EmployeeRegistration");
                    int j = dw.Tables["EmployeeRegistration"].Rows.Count;

                    if (j > 0)
                    {   //BLOB is read into Byte array, then used to construct MemoryStream,
                        //then passed to PictureBox.
                        Byte[] byteBLOBData1 = new Byte[0];
                        byteBLOBData1 = (Byte[])(dw.Tables["EmployeeRegistration"].Rows[j - 1]["Address_Image"]);
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
              //  MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            textBox1Cno.MaxLength = 10;
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1Cno.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter valid  Mobile Number!");
                //RegisteredofficeaddressrichTextBox.Text.Remove(RegisteredofficeaddressrichTextBox.Text.Length - 1);
                textBox1Cno.Focus();

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
 