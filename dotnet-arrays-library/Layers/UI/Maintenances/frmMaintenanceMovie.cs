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
    public partial class frmMaintenanceMovie : Form
    {
        public frmMaintenanceMovie()
        {
            InitializeComponent();
        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            this.ChangeState(MaintenanceStatus.New);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeState(MaintenanceStatus state)
        {
            this.txtIdMovie.Clear();
            this.txtTitleMovie.Clear();
            this.txtCategoryMovie.Clear();
            this.txtYearMovie.Clear();
            this.txtLanguageMovie.Clear();

            this.txtIdMovie.Enabled = false;
            this.txtTitleMovie.Enabled = false;
            this.txtCategoryMovie.Enabled = false;
            this.txtYearMovie.Enabled = false;
            this.txtLanguageMovie.Enabled = false;


            this.btnAccept.Enabled = false;
            this.btnCancel.Enabled = false;

            switch (state)
            {
                case MaintenanceStatus.New:
                    this.txtIdMovie.Enabled = true;
                    this.txtTitleMovie.Enabled = true;
                    this.txtCategoryMovie.Enabled = true;
                    this.txtYearMovie.Enabled = true;
                    this.txtLanguageMovie.Enabled = true;


                    this.btnAccept.Enabled = true;
                    this.btnCancel.Enabled = true;
                    this.txtIdMovie.Focus();
                    break;
                case MaintenanceStatus.None:
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ChangeState(MaintenanceStatus.None);
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            IBLLMovie _BLLMovie = new BLLMovie();
            try
            {
                Movie oMovie = new Movie();
                if (string.IsNullOrEmpty(this.txtIdMovie.Text) || string.IsNullOrEmpty(this.txtTitleMovie.Text) || string.IsNullOrEmpty(this.txtCategoryMovie.Text) || string.IsNullOrEmpty(this.txtYearMovie.Text) || string.IsNullOrEmpty(this.txtLanguageMovie.Text))
                {
                    MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(this.txtIdMovie.Text, out int idMovie))
                {
                    MessageBox.Show("Please enter a valid Id Movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(this.txtYearMovie.Text, out int yearMovie) || yearMovie < 0)
                {
                    MessageBox.Show("Please enter a valid Year Movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                oMovie.IdMovie = Convert.ToInt32(this.txtIdMovie.Text);
                oMovie.Title = this.txtTitleMovie.Text;
                oMovie.CategoryMovie = new CategoryMovie { Name = txtCategoryMovie.Text };
                oMovie.Year = Convert.ToInt32(this.txtYearMovie.Text);
                oMovie.Language = this.txtLanguageMovie.Text;


                oMovie = await _BLLMovie.SaveMovie(oMovie);

                if (oMovie != null)
                    this.LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void LoadData()
        {
            IBLLMovie _BLLMovie = new BLLMovie();
            try
            {
                this.ChangeState(MaintenanceStatus.None);

                await Task.Delay(1000);

                List<Movie> movies = await _BLLMovie.GetAllMovies();

                if (dgvData.Columns.Count == 0)
                {
                    InitializeDataGridView();
                }

                dgvData.Rows.Clear();

                foreach (Movie movie in movies)
                {
                    dgvData.Rows.Add(movie.IdMovie, movie.Title, movie.CategoryMovie.Name, movie.Year, movie.Language);
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

            dgvData.Columns.Add("IdMovie", "Id Movie");
            dgvData.Columns.Add("Title", "Title Movie");
            dgvData.Columns.Add("CategoryMovie", "Category Movie");
            dgvData.Columns.Add("Year", "Year Movie");
            dgvData.Columns.Add("Language", "Language Movie");
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

        private void frmMaintenanceMovie_Load(object sender, EventArgs e)
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
