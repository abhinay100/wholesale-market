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
    public partial class SupplierPaymentform : Form
    {
        int _selectedIndex;

        public SupplierPaymentform()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            button3.Enabled = false;

            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            button1.Enabled = false;
            button4.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            this.dateTimePicker1.Value = DateTime.Now;
            this.dateTimePicker2.Value = DateTime.Now;
     
            Fillcombo();
            Fillcombo1();
            Fillcombo2();
        }
        void Fillcombo2()
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
                    string CName = myReader.GetString(myReader.GetOrdinal("Receipt_Number"));
                    comboBox3.Items.Add(CName);

                }
            }
            catch (Exception ex)
            {

            }
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
                    comboBox2.Items.Add(CName);

                }
            }
            catch (Exception ex)
            {

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
                    comboBox4.Items.Add(CName);

                }
            }
            catch (Exception ex)
            {

            }
        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIndex = comboBox1.SelectedIndex;
            if (_selectedIndex == 0)
            {
                label6.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Enabled = false;
                comboBox4.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                button1.Enabled = true;

            }
            else if (_selectedIndex == 1)
            {

                label6.Enabled = true;
                label2.Enabled = false;
                label3.Enabled = false;
                comboBox3.Enabled = true;
                comboBox2.Enabled = false;
                comboBox4.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = true;
                comboBox4.Enabled = false;
      
              

            }
            else if (_selectedIndex == 2)
            {
                label6.Enabled = false;
                label2.Enabled = true;
                label3.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Enabled = true;
                comboBox4.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                comboBox2.Enabled = true;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
              
            }
            else if (_selectedIndex == 3)
            {
                label6.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = true;
                comboBox3.Enabled = false;
                comboBox2.Enabled = false;
                comboBox4.Enabled = true;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                label4.Enabled = false;
                label5.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = true;



            }
            else if (_selectedIndex == 4)
            {
                label6.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Enabled = false;
                comboBox4.Enabled = false;
                dateTimePicker1.Enabled =true;
                dateTimePicker2.Enabled =true;
                label4.Enabled = true;
                label5.Enabled = true;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                button1.Enabled = true;
             
            }
            else if (_selectedIndex == 5)
            {
                label6.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                comboBox3.Enabled = false;
                comboBox2.Enabled = false;
                comboBox4.Enabled = false;
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
                comboBox2.Enabled = false;
                comboBox3.Enabled = false;
                comboBox4.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            button1.Enabled = false;
            button3.Enabled = false;
            dataGridView1.DataSource = null;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            dataGridView2.DataSource = null;
            button3.Enabled = false;
            button4.Enabled = false;

        }

        private void SupplierPaymentform_Load(object sender, EventArgs e)
        {
            
            
            // TODO: This line of code loads data into the 'marketDataSet.PurchaseRegistration' table. You can move, or remove it, as needed.
           // this.purchaseRegistrationTableAdapter.Fill(this.marketDataSet.PurchaseRegistration);

        }

        private void button1_Click(object sender, EventArgs e)
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
                if (_selectedIndex == 0)
                {
                    command.CommandText = " select * from PurchaseRegistration ";

                }
                else if (_selectedIndex == 1)
                {
                    if (comboBox3.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Select the Receipt Number!");
                        return;
                    }

                    command.CommandText = " select * from PurchaseRegistration  where Receipt_Number='" + comboBox3.Text + "'";

                }
                else if (_selectedIndex == 2)
                {
                    if (comboBox2.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Select the Item Name!");
                        return;
                    }

                    command.CommandText = " select * from PurchaseRegistration  where  Product='" + comboBox2.Text + "'";
                }
                else if (_selectedIndex == 3)
                {
                    if (comboBox4.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Select the Supplier Number!");
                        return;
                    }
                    command.CommandText = " select * from PurchaseRegistration  where Purchased_From='" + comboBox4.Text + "'"; 
                }
                else if(_selectedIndex==4)
                {
                    command.CommandText = " select * from PurchaseRegistration  where Date >= CONVERT (Date,'" + dateTimePicker1.Text + "',103 ) and Date <= CONVERT(Date,'" + dateTimePicker2.Text + "',103) ";

                  //  command.CommandText = " select * from PurchaseRegistration  where Date >=  ('" + dateTimePicker1.Text + "') and Date <= ('" + dateTimePicker2.Text + "') ";
                   
                }





                else if (_selectedIndex == 5)
                {
                    command.CommandText = " select * from PurchaseRegistration";
                    SqlDataAdapter dq = new SqlDataAdapter(command);
                    DataSet df= new DataSet();
                    dq.Fill(df, "PurchaseRegistration");
                    dataGridView2.DataSource = df.Tables["PurchaseRegistration"];
                    SqlDataReader ra = command.ExecuteReader();
                    button3.Enabled = false;
                    button4.Enabled = true;
                    return;
                
                }



              
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "PurchaseRegistration");
                dataGridView1.DataSource = ds.Tables["PurchaseRegistration"];
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
                    headerColumnRange.Font.Bold = true;
                    headerColumnRange.Font.Color = 0xFF0000;
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
            button1.Enabled = true;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
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
                if (dataGridView2.Rows.Count > 0)
                {
                    currentWorksheet.Cells[1, 1] = DateTime.Now.ToString("s");
                    int i = 1;
                    foreach (DataGridViewColumn dgviewColumn in dataGridView2.Columns)
                    {
                        // Excel work sheet indexing starts with 1
                        currentWorksheet.Cells[2, i] = dgviewColumn.HeaderText;
                        ++i;
                    }
                    Microsoft.Office.Interop.Excel.Range headerColumnRange = currentWorksheet.get_Range("A2", "G2");
                    headerColumnRange.Font.Bold = true;
                    headerColumnRange.Font.Color = 0xFF0000;
                    //headerColumnRange.EntireColumn.AutoFit();
                    int rowIndex = 0;
                    for (rowIndex = 0; rowIndex < dataGridView2.Rows.Count; rowIndex++)
                    {
                        DataGridViewRow dgRow = dataGridView2.Rows[rowIndex];
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
        }
        }
    
