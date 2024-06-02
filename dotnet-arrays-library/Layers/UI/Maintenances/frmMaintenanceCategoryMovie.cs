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
    public partial class frmMaintenanceCategoryMovie : Form
    {
        public frmMaintenanceCategoryMovie()
        {
            InitializeComponent();
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            IBLLCategoryMovie _BLLCategoryMovie = new BLLCategoryMovie();
            try
            {
                CategoryMovie oCategoryMovie = new CategoryMovie();

                if (string.IsNullOrEmpty(txtIdCategory.Text) || string.IsNullOrEmpty(txtNameCategory.Text) || string.IsNullOrEmpty(txtDescriptionCategory.Text))
                {
                    MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtIdCategory.Focus();
                    return;
                }

                if (!int.TryParse(txtIdCategory.Text, out int idCategory))
                {
                    MessageBox.Show("Please enter a valid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txtIdCategory.Focus();
                    return;
                }

                oCategoryMovie.IdCategory = Convert.ToInt32(txtIdCategory.Text);
                oCategoryMovie.Name = txtNameCategory.Text;
                oCategoryMovie.Description = txtDescriptionCategory.Text;

                oCategoryMovie = await _BLLCategoryMovie.SaveCategoryMovie(oCategoryMovie);

                if (oCategoryMovie != null)
                    this.LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void InitializeDataGridView()
        {
            dgvData.Columns.Clear();

            dgvData.Columns.Add("IdCategory", "Id Category");
            dgvData.Columns.Add("Name", "Name Category");
            dgvData.Columns.Add("Description", "Description Category");
        }

        private async void LoadData()
        {
            IBLLCategoryMovie _BLLCategoryMovie = new BLLCategoryMovie();
            try
            {
                this.ChangeState(MaintenanceStatus.None);

                await Task.Delay(1000);

                List<CategoryMovie> categoryMovies = await _BLLCategoryMovie.GetAllCategoryMovies();

                if (dgvData.Columns.Count == 0)
                {
                    InitializeDataGridView();
                }

                dgvData.Rows.Clear();

                foreach (var categoryMovie in categoryMovies)
                {
                    dgvData.Rows.Add(categoryMovie.IdCategory, categoryMovie.Name, categoryMovie.Description);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ChangeState(MaintenanceStatus state)
        {
            this.txtIdCategory.Clear();
            this.txtNameCategory.Clear();
            this.txtDescriptionCategory.Clear();

            this.txtIdCategory.Enabled = false;
            this.txtNameCategory.Enabled = false;
            this.txtDescriptionCategory.Enabled = false;

            this.btnAccept.Enabled = false;
            this.btnCancel.Enabled = false;

            switch (state)
            {
                case MaintenanceStatus.New:
                    this.txtIdCategory.Enabled = true;
                    this.txtNameCategory.Enabled = true;
                    this.txtDescriptionCategory.Enabled = true;
                    this.btnAccept.Enabled = true;
                    this.btnCancel.Enabled = true;
                    txtIdCategory.Focus();
                    break;
                case MaintenanceStatus.None:
                    break;
            }
        }

        private void frmMaintenanceCategoryMovie_Load(object sender, EventArgs e)
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
    }
}
