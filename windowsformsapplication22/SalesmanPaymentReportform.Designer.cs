namespace WindowsFormsApplication22
{
    partial class SalesmanPaymentReportform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanAccountNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantitySoldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueoftheSoldProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockinHandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesReturnBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.marketDataSet = new WindowsFormsApplication22.MarketDataSet();
            this.salesRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesRegistrationTableAdapter = new WindowsFormsApplication22.MarketDataSetTableAdapters.SalesRegistrationTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmanAccountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesReturnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesReturnTableAdapter = new WindowsFormsApplication22.MarketDataSetTableAdapters.SalesReturnTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReturnBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegistrationBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReturnBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Report";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Salesman Account Number",
            "Datewise",
            "Receipt Number",
            "Paid and balance"});
            this.comboBox1.Location = new System.Drawing.Point(108, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(869, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "To";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(925, 36);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(130, 23);
            this.dateTimePicker2.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(697, 36);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(631, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salesman name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(685, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(915, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 12;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.salesmanAccountNumberDataGridViewTextBoxColumn1,
            this.totalQuantityDataGridViewTextBoxColumn,
            this.quantitySoldDataGridViewTextBoxColumn,
            this.valueoftheSoldProductDataGridViewTextBoxColumn,
            this.damagedQuantityDataGridViewTextBoxColumn,
            this.stockinHandDataGridViewTextBoxColumn,
            this.finalValueDataGridViewTextBoxColumn,
            this.paymentMadeDataGridViewTextBoxColumn1,
            this.balanceDataGridViewTextBoxColumn1,
            this.receiptValueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salesReturnBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(7, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1035, 203);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Receipt_Number";
            this.Column5.HeaderText = "Receipt Number";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Date";
            this.Column6.HeaderText = "Receipt Date";
            this.Column6.Name = "Column6";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sales Damage Value";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Paid";
            this.Column2.HeaderText = "Amount Paid";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Balance";
            this.Column4.HeaderText = "Balance";
            this.Column4.Name = "Column4";
            // 
            // salesmanAccountNumberDataGridViewTextBoxColumn1
            // 
            this.salesmanAccountNumberDataGridViewTextBoxColumn1.DataPropertyName = "Salesman_Account_Number";
            this.salesmanAccountNumberDataGridViewTextBoxColumn1.HeaderText = "Salesman Account Number";
            this.salesmanAccountNumberDataGridViewTextBoxColumn1.Name = "salesmanAccountNumberDataGridViewTextBoxColumn1";
            // 
            // totalQuantityDataGridViewTextBoxColumn
            // 
            this.totalQuantityDataGridViewTextBoxColumn.DataPropertyName = "Total_Quantity";
            this.totalQuantityDataGridViewTextBoxColumn.HeaderText = "Total Quantity";
            this.totalQuantityDataGridViewTextBoxColumn.Name = "totalQuantityDataGridViewTextBoxColumn";
            // 
            // quantitySoldDataGridViewTextBoxColumn
            // 
            this.quantitySoldDataGridViewTextBoxColumn.DataPropertyName = "Quantity_Sold";
            this.quantitySoldDataGridViewTextBoxColumn.HeaderText = "Quantity Sold";
            this.quantitySoldDataGridViewTextBoxColumn.Name = "quantitySoldDataGridViewTextBoxColumn";
            // 
            // valueoftheSoldProductDataGridViewTextBoxColumn
            // 
            this.valueoftheSoldProductDataGridViewTextBoxColumn.DataPropertyName = "Value_of_the_Sold_Product";
            this.valueoftheSoldProductDataGridViewTextBoxColumn.HeaderText = "Value of the Sold Product";
            this.valueoftheSoldProductDataGridViewTextBoxColumn.Name = "valueoftheSoldProductDataGridViewTextBoxColumn";
            // 
            // damagedQuantityDataGridViewTextBoxColumn
            // 
            this.damagedQuantityDataGridViewTextBoxColumn.DataPropertyName = "Damaged_Quantity";
            this.damagedQuantityDataGridViewTextBoxColumn.HeaderText = "Damaged Quantity";
            this.damagedQuantityDataGridViewTextBoxColumn.Name = "damagedQuantityDataGridViewTextBoxColumn";
            // 
            // stockinHandDataGridViewTextBoxColumn
            // 
            this.stockinHandDataGridViewTextBoxColumn.DataPropertyName = "Stock_in_Hand";
            this.stockinHandDataGridViewTextBoxColumn.HeaderText = "Stock in Hand";
            this.stockinHandDataGridViewTextBoxColumn.Name = "stockinHandDataGridViewTextBoxColumn";
            // 
            // finalValueDataGridViewTextBoxColumn
            // 
            this.finalValueDataGridViewTextBoxColumn.DataPropertyName = "Final_Value";
            this.finalValueDataGridViewTextBoxColumn.HeaderText = "Final Value";
            this.finalValueDataGridViewTextBoxColumn.Name = "finalValueDataGridViewTextBoxColumn";
            // 
            // paymentMadeDataGridViewTextBoxColumn1
            // 
            this.paymentMadeDataGridViewTextBoxColumn1.DataPropertyName = "Payment_Made";
            this.paymentMadeDataGridViewTextBoxColumn1.HeaderText = "Payment Made";
            this.paymentMadeDataGridViewTextBoxColumn1.Name = "paymentMadeDataGridViewTextBoxColumn1";
            // 
            // balanceDataGridViewTextBoxColumn1
            // 
            this.balanceDataGridViewTextBoxColumn1.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn1.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn1.Name = "balanceDataGridViewTextBoxColumn1";
            // 
            // receiptValueDataGridViewTextBoxColumn
            // 
            this.receiptValueDataGridViewTextBoxColumn.DataPropertyName = "Receipt_Value";
            this.receiptValueDataGridViewTextBoxColumn.HeaderText = "Receipt Value";
            this.receiptValueDataGridViewTextBoxColumn.Name = "receiptValueDataGridViewTextBoxColumn";
            // 
            // salesReturnBindingSource1
            // 
            this.salesReturnBindingSource1.DataMember = "SalesReturn";
            this.salesReturnBindingSource1.DataSource = this.marketDataSet;
            // 
            // marketDataSet
            // 
            this.marketDataSet.DataSetName = "MarketDataSet";
            this.marketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salesRegistrationBindingSource
            // 
            this.salesRegistrationBindingSource.DataMember = "SalesRegistration";
            this.salesRegistrationBindingSource.DataSource = this.marketDataSet;
            // 
            // salesRegistrationTableAdapter
            // 
            this.salesRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(393, 32);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(820, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 27);
            this.button3.TabIndex = 11;
            this.button3.Text = "ExportExcel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1198, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salesman Payment Report Details";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(393, 73);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(141, 23);
            this.comboBox4.TabIndex = 9;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Receipt Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(14, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1296, 433);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(663, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Export Excel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.receiptNumberDataGridViewTextBoxColumn,
            this.salesmanAccountNumberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.paymentMadeDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.salesReturnBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(7, 254);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(637, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn1.HeaderText = "Receipt Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // receiptNumberDataGridViewTextBoxColumn
            // 
            this.receiptNumberDataGridViewTextBoxColumn.DataPropertyName = "Receipt_Number";
            this.receiptNumberDataGridViewTextBoxColumn.HeaderText = "Receipt Number";
            this.receiptNumberDataGridViewTextBoxColumn.Name = "receiptNumberDataGridViewTextBoxColumn";
            this.receiptNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesmanAccountNumberDataGridViewTextBoxColumn
            // 
            this.salesmanAccountNumberDataGridViewTextBoxColumn.DataPropertyName = "Salesman_Account_Number";
            this.salesmanAccountNumberDataGridViewTextBoxColumn.HeaderText = "Salesman Account Number";
            this.salesmanAccountNumberDataGridViewTextBoxColumn.Name = "salesmanAccountNumberDataGridViewTextBoxColumn";
            this.salesmanAccountNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Final_Value";
            this.dataGridViewTextBoxColumn2.HeaderText = "Amount";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // paymentMadeDataGridViewTextBoxColumn
            // 
            this.paymentMadeDataGridViewTextBoxColumn.DataPropertyName = "Payment_Made";
            this.paymentMadeDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.paymentMadeDataGridViewTextBoxColumn.Name = "paymentMadeDataGridViewTextBoxColumn";
            this.paymentMadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // salesReturnBindingSource
            // 
            this.salesReturnBindingSource.DataMember = "SalesReturn";
            this.salesReturnBindingSource.DataSource = this.marketDataSet;
            // 
            // salesReturnTableAdapter
            // 
            this.salesReturnTableAdapter.ClearBeforeFill = true;
            // 
            // SalesmanPaymentReportform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1276, 654);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SalesmanPaymentReportform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Salesman Payment Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SalesmanPaymentReportform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReturnBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegistrationBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReturnBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MarketDataSet marketDataSet;
        private System.Windows.Forms.BindingSource salesRegistrationBindingSource;
        private MarketDataSetTableAdapters.SalesRegistrationTableAdapter salesRegistrationTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource salesReturnBindingSource;
        private MarketDataSetTableAdapters.SalesReturnTableAdapter salesReturnTableAdapter;
        private System.Windows.Forms.BindingSource salesReturnBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmanAccountNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantitySoldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueoftheSoldProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagedQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockinHandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiptNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmanAccountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
    }
}