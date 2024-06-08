using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.BLL;
using dotnet_arrays_library.Layers.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_arrays_library.Layers.UI.Maintenances
{
    public partial class frmMaintenanceBranch : Form
    {
        public frmMaintenanceBranch()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            this.ChangeState(MaintenanceStatus.New);
        }

        private void ChangeState(MaintenanceStatus state)
        {
            this.txtIdBranch.Clear();
            this.txtIdManager.Clear();
            this.txtNameBranch.Clear();
            this.txtAddress.Clear();
            this.txtPhone.Clear();

            this.txtIdBranch.Enabled = false;
            this.txtIdManager.Enabled = false;
            this.txtNameBranch.Enabled = false;
            this.txtAddress.Enabled = false;
            this.txtPhone.Enabled = false;
            if (cmbActive.Items.Count > 0)
                this.cmbActive.SelectedIndex = 0;

            this.btnAccept.Enabled = false;
            this.btnCancel.Enabled = false;

            switch (state)
            {
                case MaintenanceStatus.New:
                    this.txtIdBranch.Enabled = true;
                    this.txtIdManager.Enabled = true;
                    this.txtNameBranch.Enabled = true;
                    this.txtAddress.Enabled = true;
                    this.txtPhone.Enabled = true;
                    this.cmbActive.Enabled = true;

                    this.btnAccept.Enabled = true;
                    this.btnCancel.Enabled = true;

                    this.txtIdBranch.Focus();
                    break;
                case MaintenanceStatus.None:
                    break;
            }
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            IBLLBranch _BLLBranch = new BLLBranch();
            try
            {
                Branch oBranch = new Branch();

                if (string.IsNullOrEmpty(txtIdBranch.Text) || string.IsNullOrEmpty(txtIdManager.Text) || string.IsNullOrEmpty(txtNameBranch.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtPhone.Text))
                {
                    MessageBox.Show("Please fill in all the fields");
                    return;
                }

                if (!int.TryParse(txtIdBranch.Text, out int idBranch))
                {
                    MessageBox.Show("The ID must be a number");
                    return;
                }

                if (!int.TryParse(txtIdManager.Text, out int idManager))
                {
                    MessageBox.Show("The ID Manager must be a number");
                    return;
                }

                oBranch.IdBranch = Convert.ToInt32(txtIdBranch.Text);
                oBranch.Manager = new Manager { IdManager = Convert.ToInt32(txtIdManager.Text) };
                oBranch.Name = txtNameBranch.Text;
                oBranch.Address = txtAddress.Text;
                oBranch.Phone = txtPhone.Text;
                oBranch.Active = (cmbActive.Text == "Yes") ? true : false;

                oBranch = await _BLLBranch.SaveBranch(oBranch);

                if (oBranch != null)
                    this.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void LoadData()
        {
            IBLLBranch _BLLBranch = new BLLBranch();
            try
            {
                this.ChangeState(MaintenanceStatus.None);

                await Task.Delay(1000);

                List<Branch> branches = await _BLLBranch.GetBranches();

                this.cmbActive.Items.Clear();
                this.cmbActive.Items.Add("Yes");
                this.cmbActive.Items.Add("No");

                if (dgvData.Columns.Count == 0)
                {
                    InitializeDataGridView();
                }

                dgvData.Rows.Clear();

                foreach (Branch branch in branches)
                {
                    dgvData.Rows.Add(branch.IdBranch, branch.Manager.IdManager, branch.Name, branch.Address, branch.Phone, branch.Active);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            dgvData.Columns.Clear();

            dgvData.Columns.Add("IdBranch", "Id Branch");
            dgvData.Columns.Add("IdManager", "Id Manager");
            dgvData.Columns.Add("Name", "Name Branch");
            dgvData.Columns.Add("Address", "Address");
            dgvData.Columns.Add("Phone", "Phone");
            dgvData.Columns.Add("Active", "Active");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmPrincipal ofrmPrincipal;
            try
            {
                ofrmPrincipal = new frmPrincipal();
                ofrmPrincipal.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmMaintenanceBranch_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ChangeState(MaintenanceStatus.None);
        }
    }
}
