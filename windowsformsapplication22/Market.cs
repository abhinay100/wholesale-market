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
    public partial class Market : Form
    {
        public Market()
        {
            InitializeComponent();
          
            
        }

        private void supplierRegistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SupplierRegistrationform newform = new SupplierRegistrationform();

            newform.MdiParent = this;

            newform.Show();

        }

        private void saleManRegistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanRegistrationform newform = new SalesmanRegistrationform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void employeeRolesRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void employeeRegistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeRegistrationform newform = new EmployeeRegistrationform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void productRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductRegistrationform newform = new ProductRegistrationform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void measurementRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
          MeasurementRegistrationform newform = new MeasurementRegistrationform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void educationRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void departmentRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartmentRegistrationform newform = new DepartmentRegistrationform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void damageRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DamageRegistrationform newform = new DamageRegistrationform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void purchaseRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseRegistrationform newform = new PurchaseRegistrationform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void salesRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesRegistrationform newform = new SalesRegistrationform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void paymentRegistrationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentRegistrationform newform = new PaymentRegistrationform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void purchaseModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrationModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proofRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addressProofToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Market_Load(object sender, EventArgs e)
        {
           
        }

        private void supplierReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

          SupplierReport newform = new SupplierReport();

            newform.MdiParent = this;

            newform.Show();

        }

        private void supplierPaymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SupplierPaymentform newform = new SupplierPaymentform();

            newform.MdiParent = this;

            newform.Show();

        }

        private void salesManSalesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmansalesReportform newform = new SalesmansalesReportform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void salesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReportform newform = new SalesReportform();

            newform.MdiParent = this;

            newform.Show();
        
            
        }

        private void stockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StockReportform newform = new StockReportform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void damageReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DamageReportform newform = new DamageReportform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void purchaseReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseReportform newform = new PurchaseReportform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void salesManPaymentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesmanPaymentReportform newform = new SalesmanPaymentReportform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void seachToolStripMenuItem_Click(object sender, EventArgs e)
        {
           SearchSalesmanform newform = new SearchSalesmanform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void supplierSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
      SearchSupplierform newform = new SearchSupplierform();

            newform.MdiParent = this;

            newform.Show();
        }
        

        private void stockSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStockform newform = new SearchStockform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesReturnform newform = new SalesReturnform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void damageReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Damageform newform = new Damageform();

            newform.MdiParent = this;

            newform.Show();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutWholesaleMarketToolStripMenuItem_Click(object sender, EventArgs e)
        {
             Aboutus newform = new Aboutus();

            newform.MdiParent = this;

            newform.Show();
        }
    }
}
