namespace WindowsFormsApplication22
{
    partial class PaymentRegistrationform
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.marketDataSet = new WindowsFormsApplication22.MarketDataSet();
            this.salesRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesRegistrationTableAdapter = new WindowsFormsApplication22.MarketDataSetTableAdapters.SalesRegistrationTableAdapter();
            this.salesmanRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesmanRegistrationTableAdapter = new WindowsFormsApplication22.MarketDataSetTableAdapters.SalesmanRegistrationTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.salesmanAccountNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesmannameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceperKGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueoftheproductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalValueWithTAXDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salesRegistrationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.purchasedFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchasedInvoiceNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageQuantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualQuantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueoftheproductDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalValueWithTaxDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseRegistrationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseRegistrationTableAdapter = new WindowsFormsApplication22.MarketDataSetTableAdapters.PurchaseRegistrationTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanRegistrationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegistrationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRegistrationBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Search ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Salesman Name",
            "Salesman Account Number",
            "Supplier Name",
            "Supplier Account Number"});
            this.comboBox1.Location = new System.Drawing.Point(106, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 23);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(303, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Salesman Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salesman Acc No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(633, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Supplier Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(633, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Supplier Acc No";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(461, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(140, 23);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(461, 52);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(140, 23);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(791, 22);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(140, 23);
            this.comboBox4.TabIndex = 5;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(791, 60);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(140, 23);
            this.comboBox5.TabIndex = 9;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
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
            // salesmanRegistrationBindingSource
            // 
            this.salesmanRegistrationBindingSource.DataMember = "SalesmanRegistration";
            this.salesmanRegistrationBindingSource.DataSource = this.marketDataSet;
            // 
            // salesmanRegistrationTableAdapter
            // 
            this.salesmanRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.salesmanAccountNumberDataGridViewTextBoxColumn,
            this.salesmannameDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.gradeDataGridViewTextBoxColumn,
            this.priceperKGDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.damageQuantityDataGridViewTextBoxColumn,
            this.actualQuantityDataGridViewTextBoxColumn,
            this.valueoftheproductDataGridViewTextBoxColumn,
            this.finalValueWithTAXDataGridViewTextBoxColumn,
            this.Paid,
            this.Column1});
            this.dataGridView1.DataSource = this.salesRegistrationBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 240);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // salesmanAccountNumberDataGridViewTextBoxColumn
            // 
            this.salesmanAccountNumberDataGridViewTextBoxColumn.DataPropertyName = "Salesman_Account_Number";
            this.salesmanAccountNumberDataGridViewTextBoxColumn.HeaderText = "Salesman_Account_Number";
            this.salesmanAccountNumberDataGridViewTextBoxColumn.Name = "salesmanAccountNumberDataGridViewTextBoxColumn";
            // 
            // salesmannameDataGridViewTextBoxColumn
            // 
            this.salesmannameDataGridViewTextBoxColumn.DataPropertyName = "Salesman_name";
            this.salesmannameDataGridViewTextBoxColumn.HeaderText = "Salesman name";
            this.salesmannameDataGridViewTextBoxColumn.Name = "salesmannameDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            // 
            // gradeDataGridViewTextBoxColumn
            // 
            this.gradeDataGridViewTextBoxColumn.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn.Name = "gradeDataGridViewTextBoxColumn";
            // 
            // priceperKGDataGridViewTextBoxColumn
            // 
            this.priceperKGDataGridViewTextBoxColumn.DataPropertyName = "Price_per_KG";
            this.priceperKGDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.priceperKGDataGridViewTextBoxColumn.Name = "priceperKGDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // damageQuantityDataGridViewTextBoxColumn
            // 
            this.damageQuantityDataGridViewTextBoxColumn.DataPropertyName = "Damage_Quantity";
            this.damageQuantityDataGridViewTextBoxColumn.HeaderText = "Damage Quantity";
            this.damageQuantityDataGridViewTextBoxColumn.Name = "damageQuantityDataGridViewTextBoxColumn";
            // 
            // actualQuantityDataGridViewTextBoxColumn
            // 
            this.actualQuantityDataGridViewTextBoxColumn.DataPropertyName = "Actual_Quantity";
            this.actualQuantityDataGridViewTextBoxColumn.HeaderText = "Actual Quantity";
            this.actualQuantityDataGridViewTextBoxColumn.Name = "actualQuantityDataGridViewTextBoxColumn";
            // 
            // valueoftheproductDataGridViewTextBoxColumn
            // 
            this.valueoftheproductDataGridViewTextBoxColumn.DataPropertyName = "Value_of_the_product";
            this.valueoftheproductDataGridViewTextBoxColumn.HeaderText = "Value of product";
            this.valueoftheproductDataGridViewTextBoxColumn.Name = "valueoftheproductDataGridViewTextBoxColumn";
            // 
            // finalValueWithTAXDataGridViewTextBoxColumn
            // 
            this.finalValueWithTAXDataGridViewTextBoxColumn.DataPropertyName = "Final_Value_WithTAX";
            this.finalValueWithTAXDataGridViewTextBoxColumn.HeaderText = "Final Value With TAX";
            this.finalValueWithTAXDataGridViewTextBoxColumn.Name = "finalValueWithTAXDataGridViewTextBoxColumn";
            // 
            // Paid
            // 
            this.Paid.DataPropertyName = "Paid";
            this.Paid.HeaderText = "Paid";
            this.Paid.Name = "Paid";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Balance";
            this.Column1.HeaderText = "Balance";
            this.Column1.Name = "Column1";
            // 
            // salesRegistrationBindingSource1
            // 
            this.salesRegistrationBindingSource1.DataMember = "SalesRegistration";
            this.salesRegistrationBindingSource1.DataSource = this.marketDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchasedFromDataGridViewTextBoxColumn,
            this.purchasedInvoiceNumberDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn1,
            this.gradeDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn1,
            this.damageQuantityDataGridViewTextBoxColumn1,
            this.actualQuantityDataGridViewTextBoxColumn1,
            this.valueoftheproductDataGridViewTextBoxColumn1,
            this.finalValueWithTaxDataGridViewTextBoxColumn1,
            this.Column2,
            this.Column3});
            this.dataGridView2.DataSource = this.purchaseRegistrationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(21, 269);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1042, 242);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // purchasedFromDataGridViewTextBoxColumn
            // 
            this.purchasedFromDataGridViewTextBoxColumn.DataPropertyName = "Purchased_From";
            this.purchasedFromDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.purchasedFromDataGridViewTextBoxColumn.Name = "purchasedFromDataGridViewTextBoxColumn";
            // 
            // purchasedInvoiceNumberDataGridViewTextBoxColumn
            // 
            this.purchasedInvoiceNumberDataGridViewTextBoxColumn.DataPropertyName = "Purchased_Invoice_Number";
            this.purchasedInvoiceNumberDataGridViewTextBoxColumn.HeaderText = "Purchased_Invoice_Number";
            this.purchasedInvoiceNumberDataGridViewTextBoxColumn.Name = "purchasedInvoiceNumberDataGridViewTextBoxColumn";
            // 
            // productDataGridViewTextBoxColumn1
            // 
            this.productDataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn1.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn1.Name = "productDataGridViewTextBoxColumn1";
            // 
            // gradeDataGridViewTextBoxColumn1
            // 
            this.gradeDataGridViewTextBoxColumn1.DataPropertyName = "Grade";
            this.gradeDataGridViewTextBoxColumn1.HeaderText = "Grade";
            this.gradeDataGridViewTextBoxColumn1.Name = "gradeDataGridViewTextBoxColumn1";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            // 
            // damageQuantityDataGridViewTextBoxColumn1
            // 
            this.damageQuantityDataGridViewTextBoxColumn1.DataPropertyName = "Damage_Quantity";
            this.damageQuantityDataGridViewTextBoxColumn1.HeaderText = "Damage Quantity";
            this.damageQuantityDataGridViewTextBoxColumn1.Name = "damageQuantityDataGridViewTextBoxColumn1";
            // 
            // actualQuantityDataGridViewTextBoxColumn1
            // 
            this.actualQuantityDataGridViewTextBoxColumn1.DataPropertyName = "Actual_Quantity";
            this.actualQuantityDataGridViewTextBoxColumn1.HeaderText = "Actual Quantity";
            this.actualQuantityDataGridViewTextBoxColumn1.Name = "actualQuantityDataGridViewTextBoxColumn1";
            // 
            // valueoftheproductDataGridViewTextBoxColumn1
            // 
            this.valueoftheproductDataGridViewTextBoxColumn1.DataPropertyName = "Value_of_the_product";
            this.valueoftheproductDataGridViewTextBoxColumn1.HeaderText = "Value of Product";
            this.valueoftheproductDataGridViewTextBoxColumn1.Name = "valueoftheproductDataGridViewTextBoxColumn1";
            // 
            // finalValueWithTaxDataGridViewTextBoxColumn1
            // 
            this.finalValueWithTaxDataGridViewTextBoxColumn1.DataPropertyName = "Final_Value_WithTax";
            this.finalValueWithTaxDataGridViewTextBoxColumn1.HeaderText = "Final Value With Tax";
            this.finalValueWithTaxDataGridViewTextBoxColumn1.Name = "finalValueWithTaxDataGridViewTextBoxColumn1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Paid";
            this.Column2.HeaderText = "Paid";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Balance";
            this.Column3.HeaderText = "Balance";
            this.Column3.Name = "Column3";
            // 
            // purchaseRegistrationBindingSource
            // 
            this.purchaseRegistrationBindingSource.DataMember = "PurchaseRegistration";
            this.purchaseRegistrationBindingSource.DataSource = this.marketDataSet;
            // 
            // purchaseRegistrationTableAdapter
            // 
            this.purchaseRegistrationTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox5);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(24, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(894, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(24, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1291, 518);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payment Report";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Location = new System.Drawing.Point(1069, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(152, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment Option for Supplier";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 36);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Make Payment";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(1069, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(152, 100);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Payment Option for Salesman";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Make Payment";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PaymentRegistrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 684);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PaymentRegistrationform";
            this.Text = "Payment Registration ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PaymentRegistrationform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.marketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesmanRegistrationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesRegistrationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseRegistrationBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private MarketDataSet marketDataSet;
        private System.Windows.Forms.BindingSource salesRegistrationBindingSource;
        private MarketDataSetTableAdapters.SalesRegistrationTableAdapter salesRegistrationTableAdapter;
        private System.Windows.Forms.BindingSource salesmanRegistrationBindingSource;
        private MarketDataSetTableAdapters.SalesmanRegistrationTableAdapter salesmanRegistrationTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource salesRegistrationBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource purchaseRegistrationBindingSource;
        private MarketDataSetTableAdapters.PurchaseRegistrationTableAdapter purchaseRegistrationTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperKGDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmanAccountNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salesmannameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceperKGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueoftheproductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalValueWithTAXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchasedInvoiceNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageQuantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualQuantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueoftheproductDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalValueWithTaxDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}