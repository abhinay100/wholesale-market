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
    public partial class ProofRegistrationform : Form
    {
        public ProofRegistrationform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            radioButton6.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            radioButton6.Enabled = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File Uploaded Successfully");
        }
    }
}
