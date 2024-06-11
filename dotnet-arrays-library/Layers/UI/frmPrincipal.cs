using dotnet_arrays_library.Layers.UI.Maintenances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotnet_arrays_library.Layers.UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItemCategories_Click(object sender, EventArgs e)
        {
            frmMaintenanceCategoryMovie ofrmMaintenanceCategoryMovie;
            try
            {
                ofrmMaintenanceCategoryMovie = new frmMaintenanceCategoryMovie();
                ofrmMaintenanceCategoryMovie.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMaintenanceMovie ofrmMaintenanceMovie;
            try
            {
                ofrmMaintenanceMovie = new frmMaintenanceMovie();
                ofrmMaintenanceMovie.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMaintenanceManager ofrmMaintenanceManager;
            try
            {
                ofrmMaintenanceManager = new frmMaintenanceManager();
                ofrmMaintenanceManager.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmMaintenanceBranch ofrmMaintenanceBranch;
            try
            {
                ofrmMaintenanceBranch = new frmMaintenanceBranch();
                ofrmMaintenanceBranch.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaintenanceClient ofrmMaintenanceClient;
            try
            {
                ofrmMaintenanceClient = new frmMaintenanceClient();
                ofrmMaintenanceClient.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
