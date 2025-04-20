using Pharmacy.Classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace Pharmacy.Forms
{
    public partial class frmPaymentMethod : Form
    {
        private int selectedID = 0;

        public frmPaymentMethod()
        {
            InitializeComponent();
            dgvPaymentMethods.AutoGenerateColumns = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void frmPaymentMethod_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            PaymentMethod payment = new PaymentMethod(0, "", "");
            dgvPaymentMethods.DataSource = payment.SELECT();
        }

        private void ClearInputs()
        {
            txtMethodName.Clear();
            txtDescription.Clear();
            selectedID = 0;

            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMethodName.Text.Trim() == "") return;

            PaymentMethod payment = new PaymentMethod(0, txtMethodName.Text.Trim(), txtDescription.Text.Trim());
            payment.INSERT();
            LoadData();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedID == 0) return;

            PaymentMethod payment = new PaymentMethod(selectedID, "", "");
            payment.DELETE();
            LoadData();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID == 0 || txtMethodName.Text.Trim() == "") return;

            PaymentMethod payment = new PaymentMethod(selectedID, txtMethodName.Text.Trim(), txtDescription.Text.Trim());
            payment.UPDATE();
            LoadData();
            ClearInputs();
        }

        private void dgvPaymentMethods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPaymentMethods.Rows[e.RowIndex];
                selectedID = Convert.ToInt32(row.Cells["PaymentMethodID"].Value);
                txtMethodName.Text = row.Cells["MethodName"].Value.ToString();
                txtDescription.Text = row.Cells["PMDescription"].Value.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }


    }
}
