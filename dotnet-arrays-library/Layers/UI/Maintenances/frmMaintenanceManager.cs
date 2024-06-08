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
    public partial class frmMaintenanceManager : Form
    {
        public frmMaintenanceManager()
        {
            InitializeComponent();
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            IBLLManager _BLLManager = new BLLManager();
            try
            {
                Manager oManager = new Manager();

                if (string.IsNullOrEmpty(txtIdManager.Text) || string.IsNullOrEmpty(txtIdentificationManager.Text) || string.IsNullOrEmpty(txtNameManager.Text) || string.IsNullOrEmpty(txtFirstLastname.Text) || string.IsNullOrEmpty(txtSecondLastname.Text))
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtIdManager.Text, out int idManager))
                {
                    MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtIdentificationManager.Text, out int identification))
                {
                    MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtpAdmissionDate.Value < dtpBirthDate.Value)
                {
                    MessageBox.Show("Admission date can't be greater than birth date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtpBirthDate.Value > DateTime.Now)
                {
                    MessageBox.Show("Birth date can't be greater than current date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dtpAdmissionDate.Value > DateTime.Now)
                {
                    MessageBox.Show("Admission date can't be greater than current date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                oManager.IdManager = Convert.ToInt32(txtIdManager.Text);
                oManager.Identification = txtIdentificationManager.Text;
                oManager.Name = txtNameManager.Text;
                oManager.FirstLastName = txtFirstLastname.Text;
                oManager.SecondLastName = txtSecondLastname.Text;
                oManager.BirthDate = dtpBirthDate.Value;
                oManager.AdmissionDate = dtpAdmissionDate.Value;

                oManager = await _BLLManager.SaveManager(oManager);

                if (oManager != null)
                    this.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void LoadData()
        {
            IBLLManager _BLLManager = new BLLManager();
            try
            {
                this.ChangeState(MaintenanceStatus.None);

                await Task.Delay(1000);

                List<Manager> managers = await _BLLManager.GetManagers();

                if (dgvData.Columns.Count == 0)
                {
                    InitializeDataGridView();
                }

                dgvData.Rows.Clear();

                foreach (Manager manager in managers)
                {
                    dgvData.Rows.Add(manager.IdManager, manager.Identification, manager.Name, manager.FirstLastName, manager.SecondLastName, manager.BirthDate, manager.AdmissionDate);
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

            dgvData.Columns.Add("IdManager", "Id Manager");
            dgvData.Columns.Add("Identification", "Identification");
            dgvData.Columns.Add("Name", "Name");
            dgvData.Columns.Add("FirstLastName", "First Last Name");
            dgvData.Columns.Add("SecondLastName", "Second Last Name");
            dgvData.Columns.Add("BirthDate", "Birth Date");
            dgvData.Columns.Add("AdmissionDate", "Admission Date");
        }

        private void ChangeState(MaintenanceStatus state)
        {
            this.txtIdManager.Clear();
            this.txtIdentificationManager.Clear();
            this.txtNameManager.Clear();
            this.txtFirstLastname.Clear();
            this.txtSecondLastname.Clear();
            this.dtpBirthDate.Value = DateTime.Now;
            this.dtpAdmissionDate.Value = DateTime.Now;


            this.txtIdManager.Enabled = false;
            this.txtIdentificationManager.Enabled = false;
            this.txtNameManager.Enabled = false;
            this.txtFirstLastname.Enabled = false;
            this.txtSecondLastname.Enabled = false;
            this.dtpBirthDate.Enabled = false;
            this.dtpAdmissionDate.Enabled = false;
            this.txtIdManager.Enabled = false;


            this.btnAccept.Enabled = false;
            this.btnCancel.Enabled = false;

            switch (state)
            {
                case MaintenanceStatus.New:
                    this.txtIdManager.Enabled = true;
                    this.txtIdentificationManager.Enabled = true;
                    this.txtNameManager.Enabled = true;
                    this.txtFirstLastname.Enabled = true;
                    this.txtSecondLastname.Enabled = true;
                    this.dtpBirthDate.Enabled = true;
                    this.dtpAdmissionDate.Enabled = true;


                    this.btnAccept.Enabled = true;
                    this.btnCancel.Enabled = true;
                    this.txtIdManager.Focus();
                    break;
                case MaintenanceStatus.None:
                    break;
            }
        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            this.ChangeState(MaintenanceStatus.New);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ChangeState(MaintenanceStatus.None);
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

        private void frmMaintenanceManager_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
