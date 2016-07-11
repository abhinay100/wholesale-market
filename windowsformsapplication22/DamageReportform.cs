﻿using System;
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
    public partial class DamageReportform : Form
    {
        int _selectedIndex;
        public DamageReportform()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
                
            Fillcombo();
            dataGridView1.DataSource = null;
        }
        void Fillcombo()
        {
            SqlConnection connection;
            SqlCommand command = new SqlCommand();

            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            string Query = "select * from DamageRegistration";
            SqlConnection connectionDatabase = new SqlConnection(connectionString);
            SqlCommand commandDatabase = new SqlCommand(Query, connectionDatabase);
            SqlDataReader myReader;

            try
            {
                connectionDatabase.Open();
                myReader = commandDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    string CName = myReader.GetString(myReader.GetOrdinal("Name_of_the_Product"));
                    comboBox2.Items.Add(CName);

                }
            }
            catch 
            {
                MessageBox.Show("Please check the Internet connection, Network is not hitting the Sql Server");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             _selectedIndex = comboBox1.SelectedIndex;
             if (_selectedIndex == 0)
             {
                 label4.Enabled = false;
                 comboBox2.Enabled = false;
                 label2.Enabled = false;
                 label3.Enabled = false;
                 dateTimePicker1.Enabled = false;
                 dateTimePicker2.Enabled = false;
                 button1.Enabled = true;
                
             }
             else if (_selectedIndex == 1)
             {
                 label4.Enabled = true;
                 comboBox2.Enabled = true;
                 label2.Enabled = false;
                 label3.Enabled = false;
                 dateTimePicker1.Enabled = false;
                 dateTimePicker2.Enabled = false;
                
                
             }
             else if (_selectedIndex == 2)
             {
                 label4.Enabled = false;
                 comboBox2.Enabled = false;
                 label2.Enabled = false;
                 label3.Enabled = false;
                 dateTimePicker1.Enabled = true;
                 dateTimePicker2.Enabled = true;
                 button1.Enabled = true;
             }
             else if (_selectedIndex == 3)
             {
                 label4.Enabled = false;
                 comboBox2.Enabled = false;
                 label2.Enabled = false;
                 label3.Enabled = false;
                 dateTimePicker1.Enabled = false;
                 dateTimePicker2.Enabled = false;
                 button1.Enabled = true;
                 
             }
             else if (_selectedIndex == 4)
             {
                 label4.Enabled = false;
                 comboBox2.Enabled = false;
                 label2.Enabled = false;
                 label3.Enabled = false;
                 dateTimePicker1.Enabled = false;
                 dateTimePicker2.Enabled = false;
                 button1.Enabled = true;
              

                
             }
             else if (_selectedIndex == 5)
             {
                 label4.Enabled = false;
                 comboBox2.Enabled = false;
                 label2.Enabled = false;
                 label3.Enabled = false;
                 dateTimePicker1.Enabled = false;
                 dateTimePicker2.Enabled = false;
                 button1.Enabled = true;
                 
             }
             else if (_selectedIndex == 6)
             {
                 label4.Enabled = false;
                 comboBox2.Enabled = false;
                 label2.Enabled = false;
                 label3.Enabled = false;
                 dateTimePicker1.Enabled = false;
                 dateTimePicker2.Enabled = false;
                 button1.Enabled = true;
                 

             }
        }

        private void DamageReportform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'marketDataSet.DamageRegistration' table. You can move, or remove it, as needed.
            this.damageRegistrationTableAdapter.Fill(this.marketDataSet.DamageRegistration);
            // TODO: This line of code loads data into the 'marketDataSet.DamageRegistration' table. You can move, or remove it, as needed.
            this.damageRegistrationTableAdapter.Fill(this.marketDataSet.DamageRegistration);
            // TODO: This line of code loads data into the 'marketDataSet.DamageRegistration' table. You can move, or remove it, as needed.
            this.damageRegistrationTableAdapter.Fill(this.marketDataSet.DamageRegistration);
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            //button3.Enabled = true;
          
            SqlConnection connection;
            SqlCommand command = new SqlCommand();


            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MarketConnectionString"].ToString();
            connection = new SqlConnection(connectionString);
            try
            {

                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                if (_selectedIndex == 0)
                {
                    command.CommandText = " select * from DamageRegistration";
                }
                else if (_selectedIndex == 1)
                {
                    if (comboBox2.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("Please Select the Item name!");
                        return;
                    }
                    command.CommandText = " select * from DamageRegistration  where Name_of_the_Product='" + comboBox2.Text + "' ";
                }
                else if (_selectedIndex == 2)
                {
                   
                    //command.CommandText = " select * from DamageRegistration  where Date  between 'dateTimePicker2.Text ' and ' dateTimePicker1.Text' ";

                    //command.CommandText = " select * from DamageRegistration  where Date >=  ('" + dateTimePicker2.Text + "' ) and Date <= ('" + dateTimePicker1.Text + "') ";


                    command.CommandText = " select * from DamageRegistration  where Date >= CONVERT (Date,'" + dateTimePicker2.Text + "',103 ) and Date <= CONVERT(Date,'" + dateTimePicker1.Text + "',103) ";
                   
                    
                }
                else if (_selectedIndex == 3)
                {

                    command.CommandText = " SELECT * FROM DamageRegistration WHERE Transit_Damage <> ''";
                   
                }
                else if (_selectedIndex == 4)
                {
                    command.CommandText = " SELECT * FROM DamageRegistration WHERE Sales_Damage <> ''";
                }
                else if (_selectedIndex == 5)
                {
                    command.CommandText = "SELECT * FROM DamageRegistration WHERE Handling_Damage <> ''";
                }
                else if (_selectedIndex == 6)
                {
                    command.CommandText = "SELECT * FROM DamageRegistration WHERE Godown_Damage <> ''";
                }
                
            
              
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds, "DamageRegistration");
                dataGridView1.DataSource = ds.Tables["DamageRegistration"];






                SqlDataReader Reader = command.ExecuteReader();


                button3.Enabled = true;
            }
            catch 
            {

                MessageBox.Show("No Records Found");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                   // headerColumnRange.Font.Bold = true;
                    //headerColumnRange.Font.Color = 0xFF0000;
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

        private void button2_Click(object sender, EventArgs e)
        {
         
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            dataGridView1.DataSource = null;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
