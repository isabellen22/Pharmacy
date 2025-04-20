using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Form bgForm = new frmBackground();
            bgForm.MdiParent = this;  // Set this form as the MDI parent
            bgForm.Dock = DockStyle.Fill;  // Dock it to fill the client area
            bgForm.SendToBack();  // Keep it behind other forms
            bgForm.Show();

        }


        private void btnClients_Click(object sender, EventArgs e)
        {

            foreach (Form child in this.MdiChildren)
            {
                if (child is frmClients)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            try
            {
                frmClients clientsForm = new frmClients();
                clientsForm.MdiParent = this;
                clientsForm.Dock = DockStyle.Fill;
                clientsForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open Clients form: " + ex.Message);
            }
        }

       

        private void btnUsers_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmUsers)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmUsers usersForm = new Forms.frmUsers();
            usersForm.MdiParent = this;
            usersForm.Dock = DockStyle.Fill;
            usersForm.Show();
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmRole)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmRole mainForm = new Forms.frmRole();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void btnCountry_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmCountry)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmCountry mainForm = new Forms.frmCountry();
            mainForm.MdiParent = this;
            mainForm.Show();
        }


        private void doctorSpecializationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmDoctorSpecialization)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmDoctorSpecialization mainForm = new Forms.frmDoctorSpecialization();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmDoctor)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmDoctor mainForm = new Forms.frmDoctor();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void laboratoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmLaboratory)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmLaboratory mainForm = new Forms.frmLaboratory();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void payementMethodsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmPaymentMethod)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmPaymentMethod mainForm = new Forms.frmPaymentMethod();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void payementStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmPaymentStatus)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmPaymentStatus mainForm = new Forms.frmPaymentStatus();
            mainForm.MdiParent = this;
            mainForm.Show();
        }


        private void currenciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmCurrency)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmCurrency mainForm = new Forms.frmCurrency();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is Forms.frmWarehouse)
                {
                    child.BringToFront();
                    child.Focus();
                    child.Refresh();
                    return;
                }
            }

            Forms.frmWarehouse mainForm = new Forms.frmWarehouse();
            mainForm.MdiParent = this;
            mainForm.Dock = DockStyle.Fill;
            mainForm.Show();
        }















        //private void btnProducts_Click(object sender, EventArgs e)
        //{

        //    foreach (Form child in this.MdiChildren)
        //    {
        //        if (child is ProductForm)
        //        {
        //            child.BringToFront();
        //            child.Focus();
        //            child.Refresh();
        //            return;
        //        }
        //    }

        //    ProductForm productForm = new ProductForm();
        //    productForm.MdiParent = this;
        //    productForm.Dock = DockStyle.Fill;
        //    productForm.Show();

        //}


        //private void btnInsurance_Click(object sender, EventArgs e)
        //{
        //    foreach (Form child in this.MdiChildren)
        //    {
        //        if (child is frmInsurance)
        //        {
        //            child.BringToFront();
        //            child.Focus();
        //            child.Refresh();
        //            return;
        //        }
        //    }

        //    frmInsurance insuranceForm = new frmInsurance();
        //    insuranceForm.MdiParent = this;
        //    insuranceForm.Show();
        //}


        //private void btnClientsTests_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("No error", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    foreach (Form child in this.MdiChildren)
        //    {
        //        if (child is frmClientTests)
        //        {
        //            child.BringToFront();
        //            child.Focus();
        //            child.Refresh();
        //            return;
        //        }
        //    }

        //    frmClientTests clientTestForm = new frmClientTests();
        //    clientTestForm.MdiParent = this;
        //    this.TopLevel = false;
        //    this.FormBorderStyle = FormBorderStyle.None;
        //    this.Dock = DockStyle.Fill;
        //    // clientTestForm.Dock = DockStyle.Fill;
        //    clientTestForm.Show();
        //}


        //private void btnSales_Click(object sender, EventArgs e)
        //{
        //    foreach (Form child in this.MdiChildren)
        //    {
        //        if (child is Forms.Sales.Sales)
        //        {
        //            child.BringToFront();
        //            child.Focus();
        //            child.Refresh();
        //            return;
        //        }
        //    }

        //    Forms.Sales.Sales salesForm = new Forms.Sales.Sales();
        //    salesForm.MdiParent = this;
        //    salesForm.Dock = DockStyle.Fill;
        //    salesForm.Show();

        //}




























        //private void button5_Click(object sender, EventArgs e)
        //{
        //    //Forms.frmUsers mainForm = new Forms.frmUsers();
        //    //mainForm.MdiParent = this;
        //    //mainForm.Dock = DockStyle.Fill;
        //    //mainForm.Show();
        //}

        //private void button5_Click(object sender, EventArgs e)
        //{
        //    Forms.frmUsers mainForm = new Forms.frmUsers();
        //    mainForm.MdiParent = this;
        //    mainForm.Dock = DockStyle.Fill;
        //    mainForm.Show();
        //}


        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void windowsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Forms.frmRole mainForm = new Forms.frmRole();
        //    mainForm.MdiParent = this;
        //    mainForm.Show();
        //}

        private void listEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //EmployeeMenuForm employeeForm = new EmployeeMenuForm();
            //employeeForm.WindowState = FormWindowState.Maximized; // Maximize the form
            //employeeForm.MdiParent = this;
            //employeeForm.Show();

        }

        private void addAnEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EmployeeForm employeeForm = new EmployeeForm();
            //employeeForm.WindowState = FormWindowState.Maximized; // Maximize the form
            //employeeForm.MdiParent = this;
            //employeeForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            //ProductForm productForm = new ProductForm();
            //productForm.WindowState = FormWindowState.Maximized; // Maximize the form
            //productForm.MdiParent = this;
            //productForm.Show();
        }

        private void screensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmScreens mainForm = new Forms.frmScreens();
            mainForm.MdiParent = this;
            mainForm.Show();
        }

        private void permissionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.frmPermissions mainForm = new Forms.frmPermissions();
            mainForm.MdiParent = this;
            mainForm.Show();

        }

        

        private void windowsStripMenuItem_Click(object sender, EventArgs e)
        {

            windowsStripMenuItem.DropDownItems.Clear();

            // Loop through all open MDI child forms
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm is frmBackground)
                    continue;
                // Create a new menu item for each child form
                ToolStripMenuItem windowItem = new ToolStripMenuItem(childForm.Text);
                windowItem.Tag = childForm; // Store reference to the form

                // Click event to bring the selected form to the front
                windowItem.Click += (s, ev) =>
                {
                    Form selectedForm = (Form)((ToolStripMenuItem)s).Tag;
                    selectedForm.Activate(); // Bring it to the front
                };

                // Add to the Windows menu
                windowsStripMenuItem.DropDownItems.Add(windowItem);
            }

            // Add a separator and a "Close All" option if there are open windows
            if (this.MdiChildren.Length > 0)
            {
                windowsStripMenuItem.DropDownItems.Add(new ToolStripSeparator());

                ToolStripMenuItem closeAllItem = new ToolStripMenuItem("Close All");
                closeAllItem.Click += (s, ev) =>
                {
                    foreach (Form child in this.MdiChildren)
                    {
                        if (child is frmBackground)
                            continue;
                        child.Close();
                    }
                };

                windowsStripMenuItem.DropDownItems.Add(closeAllItem);
            }
        }

        //private void btnClients_Click(object sender, EventArgs e)
        //{
        //    //Forms.frmClients mainForm = new Forms.frmClients();
        //    //mainForm.MdiParent = this;
        //    //mainForm.Dock = DockStyle.Fill;
        //    //mainForm.Show();
        //}

        private void frmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        //private void btnSales_Click(object sender, EventArgs e)
        //{
        //    //Forms.Sales.Sales mainForm = new Forms.Sales.Sales();
        //    //mainForm.MdiParent = this;
        //    //mainForm.Dock = DockStyle.Fill;
        //    //mainForm.Show();
        //}

        private void payementMethodsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //// MessageBox.Show("Payment methods clicked");
           // PaymentMethodForm pmForm = new PaymentMethodForm();
           // // Do not assign MdiParent if you want a popup
           // pmForm.ShowDialog();
           // pmForm.Show();//extra
        }

       















        //private void btnSales_Click(object sender, EventArgs e)
        //{
        //    Forms.Sales.Sales mainForm = new Forms.Sales.Sales();
        //    mainForm.MdiParent = this;
        //    mainForm.Dock = DockStyle.Fill;
        //    mainForm.Show();
        //}

        //private void btnPurchase_Click(object sender, EventArgs e)
        //{
        //    PurchaseListForm purchaselistForm = new PurchaseListForm();
        //    purchaselistForm.WindowState = FormWindowState.Maximized;
        //    purchaselistForm.MdiParent = this;
        //    purchaselistForm.Show();
        //}

        //private void btnPurchaseReturn_Click(object sender, EventArgs e)
        //{
        //    PurchaseReturnForm purchasereturnForm = new PurchaseReturnForm();
        //    purchasereturnForm.WindowState = FormWindowState.Maximized;
        //    purchasereturnForm.MdiParent = this;
        //    purchasereturnForm.Show();
        //}







    }

}
