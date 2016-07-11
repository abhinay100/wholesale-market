using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication22
{
    public partial class EmployeeRegistrationform : Form
    {
        public EmployeeRegistrationform()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox26N.Clear();
            richTextBox1.Clear();
            textBox31RefA.Clear();

             textBox1.Clear();
             richTextBox3A.Clear();
                 richTextBox2Id.Clear();
                 textBox2EDU.Clear();
                     textBox33Bank.Clear();
                     textBox34Account.Clear();
                         textBox35IFSC.Clear();
                         richTextBox5.Clear();
                             richTextBox2add.Clear();
                             radioButton8int.Checked = false;
                             radioButton7.Checked = false;
                             radioButton6.Checked = false;
                             radioButton5.Checked = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Inserted Successfully");
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
    }
}
