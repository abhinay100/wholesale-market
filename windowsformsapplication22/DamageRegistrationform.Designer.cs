namespace WindowsFormsApplication22
{
    partial class DamageRegistrationform
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.NameoftheproductcomboBox1 = new System.Windows.Forms.ComboBox();
            this.GradeoftheproductcomboBox2 = new System.Windows.Forms.ComboBox();
            this.SalesDamagetextBox = new System.Windows.Forms.TextBox();
            this.GodowndamagetextBox = new System.Windows.Forms.TextBox();
            this.pricetextbox = new System.Windows.Forms.TextBox();
            this.HandlinDamagetextBox = new System.Windows.Forms.TextBox();
            this.TransitDamagetextBox = new System.Windows.Forms.TextBox();
            this.QuantitytextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(433, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 9;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Grade of the Product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name of the Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Handling Damage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Godown Damage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Transit Damage";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sales Damage";
            // 
            // NameoftheproductcomboBox1
            // 
            this.NameoftheproductcomboBox1.FormattingEnabled = true;
            this.NameoftheproductcomboBox1.Location = new System.Drawing.Point(204, 23);
            this.NameoftheproductcomboBox1.Name = "NameoftheproductcomboBox1";
            this.NameoftheproductcomboBox1.Size = new System.Drawing.Size(259, 23);
            this.NameoftheproductcomboBox1.TabIndex = 5;
            // 
            // GradeoftheproductcomboBox2
            // 
            this.GradeoftheproductcomboBox2.FormattingEnabled = true;
            this.GradeoftheproductcomboBox2.Location = new System.Drawing.Point(204, 75);
            this.GradeoftheproductcomboBox2.Name = "GradeoftheproductcomboBox2";
            this.GradeoftheproductcomboBox2.Size = new System.Drawing.Size(259, 23);
            this.GradeoftheproductcomboBox2.TabIndex = 6;
            // 
            // SalesDamagetextBox
            // 
            this.SalesDamagetextBox.Location = new System.Drawing.Point(204, 132);
            this.SalesDamagetextBox.Name = "SalesDamagetextBox";
            this.SalesDamagetextBox.Size = new System.Drawing.Size(259, 23);
            this.SalesDamagetextBox.TabIndex = 6;
            this.SalesDamagetextBox.TextChanged += new System.EventHandler(this.SalesDamagetextBox_TextChanged);
            this.SalesDamagetextBox.Validating += new System.ComponentModel.CancelEventHandler(this.SalesDamagetextBox_Validating);
            // 
            // GodowndamagetextBox
            // 
            this.GodowndamagetextBox.Location = new System.Drawing.Point(204, 81);
            this.GodowndamagetextBox.Name = "GodowndamagetextBox";
            this.GodowndamagetextBox.Size = new System.Drawing.Size(259, 23);
            this.GodowndamagetextBox.TabIndex = 5;
            this.GodowndamagetextBox.TextChanged += new System.EventHandler(this.GodowndamagetextBox_TextChanged);
            this.GodowndamagetextBox.Validating += new System.ComponentModel.CancelEventHandler(this.GodowndamagetextBox_Validating);
            // 
            // pricetextbox
            // 
            this.pricetextbox.Location = new System.Drawing.Point(204, 207);
            this.pricetextbox.Name = "pricetextbox";
            this.pricetextbox.Size = new System.Drawing.Size(259, 23);
            this.pricetextbox.TabIndex = 9;
            this.pricetextbox.TextChanged += new System.EventHandler(this.QuantitytextBoxtextBox_TextChanged);
            this.pricetextbox.Validating += new System.ComponentModel.CancelEventHandler(this.pricetextbox_Validating);
            // 
            // HandlinDamagetextBox
            // 
            this.HandlinDamagetextBox.Location = new System.Drawing.Point(204, 32);
            this.HandlinDamagetextBox.Name = "HandlinDamagetextBox";
            this.HandlinDamagetextBox.Size = new System.Drawing.Size(259, 23);
            this.HandlinDamagetextBox.TabIndex = 4;
            this.HandlinDamagetextBox.TextChanged += new System.EventHandler(this.HandlinDamagetextBox_TextChanged);
            this.HandlinDamagetextBox.Validating += new System.ComponentModel.CancelEventHandler(this.HandlinDamagetextBox_Validating);
            // 
            // TransitDamagetextBox
            // 
            this.TransitDamagetextBox.Location = new System.Drawing.Point(204, 175);
            this.TransitDamagetextBox.Name = "TransitDamagetextBox";
            this.TransitDamagetextBox.Size = new System.Drawing.Size(259, 23);
            this.TransitDamagetextBox.TabIndex = 7;
            this.TransitDamagetextBox.TextChanged += new System.EventHandler(this.TransitDamagetextBox_TextChanged);
            this.TransitDamagetextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TransitDamagetextBox_Validating);
            // 
            // QuantitytextBox
            // 
            this.QuantitytextBox.Location = new System.Drawing.Point(204, 160);
            this.QuantitytextBox.Name = "QuantitytextBox";
            this.QuantitytextBox.Size = new System.Drawing.Size(259, 23);
            this.QuantitytextBox.TabIndex = 8;
            this.QuantitytextBox.TextChanged += new System.EventHandler(this.QuantitytextBox_TextChanged);
            this.QuantitytextBox.Validating += new System.ComponentModel.CancelEventHandler(this.QuantitytextBox_Validating);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-mm-YYYY";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 23);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2015, 2, 5, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 15);
            this.label9.TabIndex = 2;
            this.label9.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.QuantitytextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pricetextbox);
            this.groupBox1.Controls.Add(this.NameoftheproductcomboBox1);
            this.groupBox1.Controls.Add(this.GradeoftheproductcomboBox2);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Description";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.GodowndamagetextBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.SalesDamagetextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.HandlinDamagetextBox);
            this.groupBox2.Controls.Add(this.TransitDamagetextBox);
            this.groupBox2.Location = new System.Drawing.Point(24, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Damage";
            // 
            // DamageRegistrationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1260, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DamageRegistrationform";
            this.Text = "Damage Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DamageRegistrationform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox NameoftheproductcomboBox1;
        private System.Windows.Forms.ComboBox GradeoftheproductcomboBox2;
        private System.Windows.Forms.TextBox SalesDamagetextBox;
        private System.Windows.Forms.TextBox GodowndamagetextBox;
        private System.Windows.Forms.TextBox pricetextbox;
        private System.Windows.Forms.TextBox HandlinDamagetextBox;
        private System.Windows.Forms.TextBox TransitDamagetextBox;
        private System.Windows.Forms.TextBox QuantitytextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}