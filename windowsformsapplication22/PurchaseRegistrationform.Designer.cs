namespace WindowsFormsApplication22
{
    partial class PurchaseRegistrationform
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.PurchasedinvoicenumbertextBox = new System.Windows.Forms.TextBox();
            this.DamagequantitytextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ActualQuantitytextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ValueoftheproducttextBox = new System.Windows.Forms.TextBox();
            this.FinalvaluewithTAXtextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ProductcomboBox = new System.Windows.Forms.ComboBox();
            this.PurchasedfromcomboBox = new System.Windows.Forms.ComboBox();
            this.GradecomboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Purchased from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchased invoice number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Grade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "Unit";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Quantity";
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(439, 352);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(74, 23);
            this.QuantitytextBox.TabIndex = 25;
            this.QuantitytextBox.TextChanged += new System.EventHandler(this.QuantitytextBox_TextChanged);
            // 
            // PurchasedinvoicenumbertextBox
            // 
            this.PurchasedinvoicenumbertextBox.Location = new System.Drawing.Point(251, 108);
            this.PurchasedinvoicenumbertextBox.Name = "PurchasedinvoicenumbertextBox";
            this.PurchasedinvoicenumbertextBox.ReadOnly = true;
            this.PurchasedinvoicenumbertextBox.Size = new System.Drawing.Size(262, 23);
            this.PurchasedinvoicenumbertextBox.TabIndex = 17;
            // 
            // DamagequantitytextBox
            // 
            this.DamagequantitytextBox.Location = new System.Drawing.Point(251, 389);
            this.DamagequantitytextBox.Name = "DamagequantitytextBox";
            this.DamagequantitytextBox.Size = new System.Drawing.Size(262, 23);
            this.DamagequantitytextBox.TabIndex = 26;
            this.DamagequantitytextBox.TextChanged += new System.EventHandler(this.DamagequantitytextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Damage quantity";
            // 
            // ActualQuantitytextBox
            // 
            this.ActualQuantitytextBox.Location = new System.Drawing.Point(251, 429);
            this.ActualQuantitytextBox.Name = "ActualQuantitytextBox";
            this.ActualQuantitytextBox.ReadOnly = true;
            this.ActualQuantitytextBox.Size = new System.Drawing.Size(262, 23);
            this.ActualQuantitytextBox.TabIndex = 27;
            this.ActualQuantitytextBox.TextChanged += new System.EventHandler(this.ActualQuantitytextBox_TextChanged);
            this.ActualQuantitytextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ActualQuantitytextBox_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 433);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Actual quantity ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 467);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Value of the product";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 502);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "If TAX applicable, ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 603);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(201, 15);
            this.label13.TabIndex = 14;
            this.label13.Text = "Final Value of product Including TAX";
            // 
            // ValueoftheproducttextBox
            // 
            this.ValueoftheproducttextBox.Location = new System.Drawing.Point(251, 464);
            this.ValueoftheproducttextBox.Name = "ValueoftheproducttextBox";
            this.ValueoftheproducttextBox.ReadOnly = true;
            this.ValueoftheproducttextBox.Size = new System.Drawing.Size(262, 23);
            this.ValueoftheproducttextBox.TabIndex = 28;
            this.ValueoftheproducttextBox.TextChanged += new System.EventHandler(this.ValueoftheproducttextBox_TextChanged);
            this.ValueoftheproducttextBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValueoftheproducttextBox_Validating);
            // 
            // FinalvaluewithTAXtextBox
            // 
            this.FinalvaluewithTAXtextBox.Location = new System.Drawing.Point(248, 595);
            this.FinalvaluewithTAXtextBox.Name = "FinalvaluewithTAXtextBox";
            this.FinalvaluewithTAXtextBox.ReadOnly = true;
            this.FinalvaluewithTAXtextBox.Size = new System.Drawing.Size(262, 23);
            this.FinalvaluewithTAXtextBox.TabIndex = 32;
            this.FinalvaluewithTAXtextBox.TextChanged += new System.EventHandler(this.FinalvaluewithTAXtextBox_TextChanged);
            this.FinalvaluewithTAXtextBox.Validating += new System.ComponentModel.CancelEventHandler(this.FinalvaluewithTAXtextBox_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 636);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 37;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(800, 636);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 39;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 636);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 27);
            this.button3.TabIndex = 38;
            this.button3.Text = "Print Receipt";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProductcomboBox
            // 
            this.ProductcomboBox.FormattingEnabled = true;
            this.ProductcomboBox.Location = new System.Drawing.Point(251, 196);
            this.ProductcomboBox.Name = "ProductcomboBox";
            this.ProductcomboBox.Size = new System.Drawing.Size(262, 23);
            this.ProductcomboBox.TabIndex = 19;
            this.ProductcomboBox.SelectedIndexChanged += new System.EventHandler(this.ProductcomboBox_SelectedIndexChanged);
            // 
            // PurchasedfromcomboBox
            // 
            this.PurchasedfromcomboBox.FormattingEnabled = true;
            this.PurchasedfromcomboBox.Location = new System.Drawing.Point(248, 35);
            this.PurchasedfromcomboBox.Name = "PurchasedfromcomboBox";
            this.PurchasedfromcomboBox.Size = new System.Drawing.Size(262, 23);
            this.PurchasedfromcomboBox.TabIndex = 15;
            this.PurchasedfromcomboBox.SelectedIndexChanged += new System.EventHandler(this.PurchasedfromcomboBox_SelectedIndexChanged);
            // 
            // GradecomboBox
            // 
            this.GradecomboBox.FormattingEnabled = true;
            this.GradecomboBox.Location = new System.Drawing.Point(251, 238);
            this.GradecomboBox.Name = "GradecomboBox";
            this.GradecomboBox.Size = new System.Drawing.Size(262, 23);
            this.GradecomboBox.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-mm-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 152);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 23);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Value = new System.DateTime(2015, 1, 15, 0, 0, 0, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 3;
            this.label12.Text = "Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(251, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(262, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.DamagequantitytextBox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.GradecomboBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PurchasedfromcomboBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ProductcomboBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.QuantitytextBox);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PurchasedinvoicenumbertextBox);
            this.groupBox1.Controls.Add(this.FinalvaluewithTAXtextBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ValueoftheproducttextBox);
            this.groupBox1.Controls.Add(this.ActualQuantitytextBox);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(38, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(903, 759);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inward of the Purchase";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(310, 645);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(148, 23);
            this.textBox4.TabIndex = 36;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 645);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(136, 23);
            this.textBox3.TabIndex = 34;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(245, 648);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 15);
            this.label20.TabIndex = 35;
            this.label20.Text = "Balance";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 648);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(30, 15);
            this.label19.TabIndex = 33;
            this.label19.Text = "Paid";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(251, 72);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(259, 23);
            this.comboBox4.TabIndex = 16;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(144, 15);
            this.label17.TabIndex = 1;
            this.label17.Text = "Supplier account  number";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(344, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 27);
            this.button4.TabIndex = 24;
            this.button4.Text = "Measure";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(251, 308);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 23);
            this.textBox2.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 316);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 15);
            this.label15.TabIndex = 7;
            this.label15.Text = "Price Per Unit";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(375, 546);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 30;
            this.label14.Tag = "";
            this.label14.Text = "% of TAX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 551);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mode of TAX";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(437, 543);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 23);
            this.textBox1.TabIndex = 31;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "VAT",
            "Service TAX",
            "No TAX"});
            this.comboBox2.Location = new System.Drawing.Point(251, 543);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 23);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(251, 351);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(86, 23);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1021, 557);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 15);
            this.label16.TabIndex = 73;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(1038, 292);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 15);
            this.label18.TabIndex = 80;
            // 
            // PurchaseRegistrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 733);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PurchaseRegistrationform";
            this.Text = "Purchase Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PurchaseRegistrationform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.TextBox PurchasedinvoicenumbertextBox;
        private System.Windows.Forms.TextBox DamagequantitytextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ActualQuantitytextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ValueoftheproducttextBox;
        private System.Windows.Forms.TextBox FinalvaluewithTAXtextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ProductcomboBox;
        private System.Windows.Forms.ComboBox PurchasedfromcomboBox;
        private System.Windows.Forms.ComboBox GradecomboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
    }
}