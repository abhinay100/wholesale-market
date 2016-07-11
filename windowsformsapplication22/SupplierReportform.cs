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
using Microsoft.Office.Interop;
using System.IO;

using System.Reflection;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html.simpleparser;





namespace WindowsFormsApplication22
{
    public partial class SupplierReport : Form
    {
        int _selectedIndex;
      
     
        public SupplierReport()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            button2.Enabled = false;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox5.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            this.dateTimePicker4.Value = DateTime.Now;
            this.dateTimePicker3.Value = DateTime.Now;

            dateTimePicker4.Enabled = false;
            dateTimePicker3.Enabled = false;
            dataGridView1.DataSource = null;
             Fillcombo();
            Fillcombo1();
            button5.Enabled = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        void Fillcombo()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();


           string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from PurchaseRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Product"));
                    comboBox4.Items.Add(CName);

                }
            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }

        }
        void Fillcombo1()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();


           string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from PurchaseRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Purchased_From"));
                    comboBox5.Items.Add(CName);

                }
            }
            catch 
            {
                //MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            textBox1Item.Clear();
            textBox2ID.Clear();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void SupplierReportform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.PurchaseRegistration' table. You can move, or remove it, as needed.
            this.purchaseRegistrationTableAdapter.Fill(this.marketDataSet.PurchaseRegistration);
            
        }

        private void SupplierReportform_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.PurchaseRegistration' table. You can move, or remove it, as needed.
            //this.purchaseRegistrationTableAdapter.Fill(this.marketDataSet.PurchaseRegistration);
            

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIndex = comboBox2.SelectedIndex;
            if (_selectedIndex == 0)
            {
                label7.Enabled = false;
                comboBox4.Enabled = false;
                label10.Enabled = false;
                comboBox5.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker3.Enabled = false;
                button2.Enabled = true;


            }
            else if (_selectedIndex == 1)
            {
                label7.Enabled = true;
                comboBox4.Enabled = true;
                label10.Enabled = false;
                comboBox5.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker3.Enabled = false;

            }
            else if (_selectedIndex == 2)
            {
                label7.Enabled = false;
                comboBox4.Enabled = false;
                label10.Enabled = true;
                comboBox5.Enabled = true;
                label8.Enabled = false;
                label9.Enabled = false;
                dateTimePicker4.Enabled = false;
                dateTimePicker3.Enabled = false;


            }
            else if (_selectedIndex == 3)
            {
                label7.Enabled = false;
                comboBox4.Enabled = false;
                label10.Enabled = false;
                comboBox5.Enabled = false;
                label8.Enabled = false;
                label9.Enabled = false;
                dateTimePicker4.Enabled = true;
                dateTimePicker3.Enabled = true;
                button2.Enabled = true;
                                 

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            //button5.Enabled = true;
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
                if (_selectedIndex == 0)
                {

                    command.CommandText = " select * from PurchaseRegistration ";
              
                }
                else if (_selectedIndex == 1)
                {
                    if (comboBox4.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please select the Item Name!");
                        return;
                    }
                    command.CommandText = " select * from PurchaseRegistration  where Product='" + comboBox4.Text + "'";
                }
                else if (_selectedIndex == 2)
                {
                    if (comboBox5.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please select the Supplier Name!");
                        return;
                    }

                    command.CommandText = " select * from PurchaseRegistration  where Purchased_From='" + comboBox5.Text + "'";
                }
                else if (_selectedIndex == 3)
                {
                    command.CommandText = " select * from PurchaseRegistration  where Date >= CONVERT (Date,'"+dateTimePicker4.Text+"',103 ) and Date <= CONVERT(Date,'"+dateTimePicker3.Text+"',103) ";

                   // command.CommandText = " select * from PurchaseRegistration  where Date >=  ('"+dateTimePicker4.Text+"' ) and Date <= ('"+dateTimePicker3.Text+"') ";
                   
                   
                    
 
 
                }




                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "PurchaseRegistration");
                dataGridView1.DataSource = ds.Tables["PurchaseRegistration"];






                SqlDataReader Reader = command.ExecuteReader();


                button5.Enabled = true;
              
            }
            catch
            {

               // MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
                    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox5.SelectedIndex=-1;
            comboBox4.SelectedIndex = -1;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            dateTimePicker4.ResetText();
            dateTimePicker3.ResetText();
            button5.Enabled = false;
            button2.Enabled = false;
            dataGridView1.DataSource = null;
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApp = null;
            try
            {
                // instantiating the excel application class
                object misValue = System.Reflection.Missing.Value;
                excelApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook currentWorkbook = excelApp.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel.Worksheet currentWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)currentWorkbook.ActiveSheet;
                currentWorksheet.Columns.ColumnWidth = 18;
                if (dataGridView1.Rows.Count > 0)
                {
                    currentWorksheet.Cells[1, 1] = DateTime.Now.ToString("s");
                    int i = 1;
                   
                    foreach (DataGridViewColumn dgviewColumn in dataGridView1.Columns)
                    {
                        // Excel work sheet indexing starts with 1
                        currentWorksheet.Cells[2, i] = dgviewColumn.HeaderText;
            
                        
                        
                        ++i;
                    }
                    Microsoft.Office.Interop.Excel.Range headerColumnRange = currentWorksheet.get_Range("A2", "G2");
                    //headerColumnRange.Font.Bold = true;
                 
                    //headerColumnRange.EntireColumn.AutoFit();
                    int rowIndex = 0;
                    for (rowIndex = 0; rowIndex < dataGridView1.Rows.Count; rowIndex++)
                    {
                        DataGridViewRow dgRow = dataGridView1.Rows[rowIndex];
                        for (int cellIndex = 0; cellIndex < dgRow.Cells.Count; cellIndex++)
                        {
                            currentWorksheet.Cells[rowIndex + 3, cellIndex + 1] = dgRow.Cells[cellIndex].Value;
                        }
                    }
                    Microsoft.Office.Interop.Excel.Range fullTextRange = currentWorksheet.get_Range("A1", "G" + (rowIndex + 1).ToString());
                    fullTextRange.WrapText = true;
                    fullTextRange.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                }
                else
                {
                    string timeStamp = DateTime.Now.ToString("s");
                    timeStamp = timeStamp.Replace(':', '-');
                    timeStamp = timeStamp.Replace("T", "__");
                    currentWorksheet.Cells[1, 1] = timeStamp;
                    currentWorksheet.Cells[1, 2] = "No error occured";
                }
                using (SaveFileDialog exportSaveFileDialog = new SaveFileDialog())
                {
                    exportSaveFileDialog.Title = "Select Excel File";
                    exportSaveFileDialog.Filter = "Microsoft Office Excel Workbook(*.xlsx)|*.xlsx";

                    if (DialogResult.OK == exportSaveFileDialog.ShowDialog())
                    {
                        string fullFileName = exportSaveFileDialog.FileName;
                        // currentWorkbook.SaveCopyAs(fullFileName);
                        // indicating that we already saved the workbook, otherwise call to Quit() will pop up
                        // the save file dialogue box

                        currentWorkbook.SaveAs(fullFileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, System.Reflection.Missing.Value, misValue, false, false, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange, Microsoft.Office.Interop.Excel.XlSaveConflictResolution.xlUserResolution, true, misValue, misValue, misValue);
                        currentWorkbook.Saved = true;
                        MessageBox.Show("Exported successfully", "Exported to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (excelApp != null)
                {
                    excelApp.Quit();
                }
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
        }
    }
