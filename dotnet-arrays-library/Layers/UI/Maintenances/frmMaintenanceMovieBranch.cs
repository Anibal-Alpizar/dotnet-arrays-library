using dotnet_arrays_library.Interfaces;
using dotnet_arrays_library.Layers.BLL;
using dotnet_arrays_library.Layers.DAL;
using dotnet_arrays_library.Layers.Entities;
using dotnet_arrays_library.Layers.Entities.dto;
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
    public partial class frmMaintenanceMovieBranch : Form
    {
        public frmMaintenanceMovieBranch()
        {
            InitializeComponent();
        }

        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            this.ChangeState(MaintenanceStatus.New);
        }

        private void ChangeState(MaintenanceStatus state)
        {
            this.txtQuantity.Clear();

            if (cmbBranches.Items.Count > 0)
                cmbBranches.SelectedIndex = 0;

            this.txtQuantity.Enabled = false;
            this.cmbBranches.Enabled = false;
            this.dgvAvailableMovies.Enabled = false;

            this.btnAccept.Enabled = false;
            this.btnCancel.Enabled = false;

            switch (state)
            {
                case MaintenanceStatus.New:
                    this.txtQuantity.Enabled = true;
                    this.cmbBranches.Enabled = true;
                    this.dgvAvailableMovies.Enabled = true;

                    this.btnAccept.Enabled = true;
                    this.btnCancel.Enabled = true;
                    break;
                case MaintenanceStatus.None:
                    break;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ChangeState(MaintenanceStatus.None);
        }

        private async void btnAccept_Click(object sender, EventArgs e)
        {
            IBLLMovieBranch _BLLMovieBranch = new BLLMovieBranch();
            try
            {
                MovieBranch oMovieBranch = new MovieBranch();

                if (dgvAvailableMovies.CurrentRow == null)
                {
                    MessageBox.Show("You must select a movie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtQuantity.Text, out int quantity))
                {
                    MessageBox.Show("Quantity must be a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity must be greater than 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                oMovieBranch.Movie = new Movie { IdMovie = Convert.ToInt32(dgvAvailableMovies.CurrentRow.Cells[0].Value) };
                oMovieBranch.Branch = new Branch { Name = cmbBranches.SelectedItem.ToString() };
                oMovieBranch.Quantity = Convert.ToInt32(txtQuantity.Text);

                oMovieBranch = await _BLLMovieBranch.SaveMovieBranch(oMovieBranch);

                if (oMovieBranch != null)
                    this.LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void LoadData()
        {
            IBLLMovieBranch _BLLMovieBranch = new BLLMovieBranch();
            IBLLBranch _BLLBranch = new BLLBranch();

            List<Branch> listBranches = new List<Branch>();
            List<Movie> listMoviesAvailable = new List<Movie>();
            List<MovieBranchDTO> listMovieBranches = new List<MovieBranchDTO>();
            try
            {
                this.ChangeState(MaintenanceStatus.None);

                await Task.Delay(1000);

                List<MovieBranch> movieBranches = await _BLLMovieBranch.GetMovieBranches();
                List<MovieBranchDTO> movieBranchesDTO = await _BLLMovieBranch.GetFullMovieBranchInfo();

                this.dvgRegisteredMovies.Columns.Clear();

                if (dvgRegisteredMovies.Columns.Count == 0)
                {
                    InitializeDataGridViewRegisteredMovies();
                }

                dvgRegisteredMovies.Rows.Clear();

                foreach (MovieBranchDTO movieBranch in movieBranchesDTO)
                {
                    dvgRegisteredMovies.Rows.Add(movieBranch.BranchId, movieBranch.BranchName, movieBranch.BranchAddress, movieBranch.BranchPhone, movieBranch.BranchActive, movieBranch.MovieId, movieBranch.MovieTitle,
                       movieBranch.MovieYear, movieBranch.MovieLanguage, movieBranch.Quantity);
                }

                listBranches = await _BLLBranch.GetAvailableBranches();

                this.dgvAvailableMovies.Rows.Clear();

                listMoviesAvailable = await _BLLMovieBranch.GetAvailableMovies();

                this.cmbBranches.Items.Clear();

                foreach (Branch item in listBranches)
                {
                    this.cmbBranches.Items.Add(item.Name);
                }

                if (dgvAvailableMovies.Columns.Count == 0)
                {
                    InitializeDataGridViewAvailableMovies();
                }

                dgvAvailableMovies.Rows.Clear();

                foreach (Movie movie in listMoviesAvailable)
                {
                    dgvAvailableMovies.Rows.Add(movie.IdMovie, movie.Title, movie.CategoryMovie.Name, movie.Year, movie.Language);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void InitializeDataGridViewAvailableMovies()
        {
            dgvAvailableMovies.Columns.Clear();

            dgvAvailableMovies.Columns.Add("IdMovie", "Id Movie");
            dgvAvailableMovies.Columns.Add("Title", "Title");
            dgvAvailableMovies.Columns.Add("CategoryMovie", "Category Movie");
            dgvAvailableMovies.Columns.Add("Year", "Year");
            dgvAvailableMovies.Columns.Add("Language", "Language");
        }

        private void InitializeDataGridViewRegisteredMovies()
        {
            dvgRegisteredMovies.Columns.Clear();

            dvgRegisteredMovies.Columns.Add("BranchId", "Branch Id");
            dvgRegisteredMovies.Columns.Add("BranchName", "Branch Name");
            dvgRegisteredMovies.Columns.Add("BranchAddress", "Branch Address");
            dvgRegisteredMovies.Columns.Add("BranchPhone", "Branch Phone");
            dvgRegisteredMovies.Columns.Add("BranchActive", "Branch Active");
            dvgRegisteredMovies.Columns.Add("MovieId", "Movie Id");
            dvgRegisteredMovies.Columns.Add("MovieTitle", "Movie Title");
            dvgRegisteredMovies.Columns.Add("MovieYear", "Movie Year");
            dvgRegisteredMovies.Columns.Add("MovieLanguage", "Movie Language");
            dvgRegisteredMovies.Columns.Add("Quantity", "Quantity");
        }

        private void frmMaintenanceMovieBranch_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }
    }
}
