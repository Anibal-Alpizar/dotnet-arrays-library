namespace dotnet_arrays_library.Layers.UI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            menuStrip1 = new MenuStrip();
            toolStripMenuItemMaintenance = new ToolStripMenuItem();
            toolStripMenuItemCategories = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            clientsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItemAbout = new ToolStripMenuItem();
            movieXBranchesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItemMaintenance, toolStripMenuItemAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 56);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemMaintenance
            // 
            toolStripMenuItemMaintenance.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemCategories, toolStripMenuItem2, toolStripMenuItem1, toolStripMenuItem3, clientsToolStripMenuItem, movieXBranchesToolStripMenuItem });
            toolStripMenuItemMaintenance.Image = (Image)resources.GetObject("toolStripMenuItemMaintenance.Image");
            toolStripMenuItemMaintenance.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemMaintenance.Name = "toolStripMenuItemMaintenance";
            toolStripMenuItemMaintenance.Size = new Size(141, 52);
            toolStripMenuItemMaintenance.Text = "Maintenances";
            // 
            // toolStripMenuItemCategories
            // 
            toolStripMenuItemCategories.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemCategories.Name = "toolStripMenuItemCategories";
            toolStripMenuItemCategories.Size = new Size(180, 22);
            toolStripMenuItemCategories.Text = "Categories";
            toolStripMenuItemCategories.Click += toolStripMenuItemCategories_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "Movies";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "Managers";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Branches";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // clientsToolStripMenuItem
            // 
            clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            clientsToolStripMenuItem.Size = new Size(180, 22);
            clientsToolStripMenuItem.Text = "Clients";
            clientsToolStripMenuItem.Click += clientsToolStripMenuItem_Click;
            // 
            // toolStripMenuItemAbout
            // 
            toolStripMenuItemAbout.Image = (Image)resources.GetObject("toolStripMenuItemAbout.Image");
            toolStripMenuItemAbout.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            toolStripMenuItemAbout.Size = new Size(100, 52);
            toolStripMenuItemAbout.Text = "About";
            // 
            // movieXBranchesToolStripMenuItem
            // 
            movieXBranchesToolStripMenuItem.Name = "movieXBranchesToolStripMenuItem";
            movieXBranchesToolStripMenuItem.Size = new Size(180, 22);
            movieXBranchesToolStripMenuItem.Text = "Movie x Branches";
            movieXBranchesToolStripMenuItem.Click += movieXBranchesToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItemMaintenance;
        private ToolStripMenuItem toolStripMenuItemCategories;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItemAbout;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem clientsToolStripMenuItem;
        private ToolStripMenuItem movieXBranchesToolStripMenuItem;
    }
}