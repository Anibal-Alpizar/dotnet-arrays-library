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
    public partial class frmMaintenanceClient : Form
    {
        public frmMaintenanceClient()
        {
            InitializeComponent();
        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            this.ChangeState(MaintenanceStatus.New);
        }

        private void ChangeState(MaintenanceStatus state)
        {
            this.txtIdClient.Clear();
            this.txtIdentificationClient.Clear();
            this.txtNameManager.Clear();
            this.txtFirstLastname.Clear();
            this.txtSecondLastname.Clear();
            this.dtpBirthDate.Value = DateTime.Now;
            this.dtpAdmissionDate.Value = DateTime.Now;

            if (cmbActive.Items.Count > 0)
                cmbActive.SelectedIndex = 0;


            this.txtIdClient.Enabled = false;
            this.txtIdentificationClient.Enabled = false;
            this.txtNameManager.Enabled = false;
            this.txtFirstLastname.Enabled = false;
            this.txtSecondLastname.Enabled = false;
            this.dtpBirthDate.Enabled = false;
            this.dtpAdmissionDate.Enabled = false;


            this.btnAccept.Enabled = false;
            this.btnCancel.Enabled = false;

            switch (state)
            {
                case MaintenanceStatus.New:
                    this.txtIdClient.Enabled = true;
                    this.txtIdentificationClient.Enabled = true;
                    this.txtNameManager.Enabled = true;
                    this.txtFirstLastname.Enabled = true;
                    this.txtSecondLastname.Enabled = true;
                    this.dtpBirthDate.Enabled = true;
                    this.dtpAdmissionDate.Enabled = true;
                    this.cmbActive.Enabled = true;

                    this.btnAccept.Enabled = true;
                    this.btnCancel.Enabled = true;
                    this.txtIdClient.Focus();
                    break;
                case MaintenanceStatus.None:
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            IBLLClient _BLLClient = new BLLClient();
            try
            {
                Client oClient = new Client();

                if (string.IsNullOrEmpty(txtIdClient.Text) || string.IsNullOrEmpty(txtIdentificationClient.Text) || string.IsNullOrEmpty(txtNameManager.Text) || string.IsNullOrEmpty(txtFirstLastname.Text) || string.IsNullOrEmpty(txtSecondLastname.Text) || string.IsNullOrEmpty(cmbActive.Text))
                {
                    MessageBox.Show("All fields are required");
                    return;
                }

                if (!int.TryParse(txtIdClient.Text, out int idClient))
                {
                    MessageBox.Show("Id must be a number");
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

                oClient.IdClient = Convert.ToInt32(txtIdClient.Text);
                oClient.Identification = txtIdentificationClient.Text;
                oClient.Name = txtNameManager.Text;
                oClient.FirstLastname = txtFirstLastname.Text;
                oClient.SecondLastname = txtSecondLastname.Text;
                oClient.BirthDate = dtpBirthDate.Value;
                oClient.AdmissionDate = dtpAdmissionDate.Value;
                oClient.Active = (cmbActive.Text == "Yes") ? true : false;

                oClient = await _BLLClient.SaveClient(oClient);

                if (oClient != null)
                    this.LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void LoadData()
        {
            IBLLClient _BLLClient = new BLLClient();
            try
            {
                this.ChangeState(MaintenanceStatus.None);

                await Task.Delay(1000);

                List<Client> clients = await _BLLClient.GetClients();

                this.cmbActive.Items.Clear();
                this.cmbActive.Items.Add("Yes");
                this.cmbActive.Items.Add("No");

                if (dgvData.Columns.Count == 0)
                {
                    InitializeDataGridView();
                }

                dgvData.Rows.Clear();

                foreach (Client client in clients)
                {
                    dgvData.Rows.Add(client.IdClient, client.Identification, client.Name, client.FirstLastname, client.SecondLastname, client.BirthDate, client.AdmissionDate, client.Active);
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

            dgvData.Columns.Add("IdClient", "Id Client");
            dgvData.Columns.Add("Identification", "Identification");
            dgvData.Columns.Add("Name", "Name");
            dgvData.Columns.Add("FirstLastname", "First Lastname");
            dgvData.Columns.Add("SecondLastname", "Second Lastname");
            dgvData.Columns.Add("BirthDate", "Birth Date");
            dgvData.Columns.Add("AdmissionDate", "Admission Date");
            dgvData.Columns.Add("Active", "Active");
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

        private void frmMaintenanceClient_Load(object sender, EventArgs e)
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