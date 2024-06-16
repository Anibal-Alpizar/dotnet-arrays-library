namespace dotnet_arrays_library.Layers.UI.Maintenances
{
    partial class frmMaintenanceMovieBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceMovieBranch));
            btnCancel = new Button();
            btnAccept = new Button();
            txtQuantity = new TextBox();
            label4 = new Label();
            label6 = new Label();
            tspPrincipal = new ToolStrip();
            toolStripBtnNew = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            cmbBranches = new ComboBox();
            dgvAvailableMovies = new DataGridView();
            label1 = new Label();
            dvgRegisteredMovies = new DataGridView();
            label2 = new Label();
            tspPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableMovies).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dvgRegisteredMovies).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(667, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 87);
            btnCancel.TabIndex = 35;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.Image = (Image)resources.GetObject("btnAccept.Image");
            btnAccept.Location = new Point(570, 203);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(91, 87);
            btnAccept.TabIndex = 34;
            btnAccept.Text = "Accept";
            btnAccept.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(593, 114);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(195, 23);
            txtQuantity.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 122);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 27;
            label4.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 77);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 36;
            label6.Text = "Branch";
            // 
            // tspPrincipal
            // 
            tspPrincipal.Items.AddRange(new ToolStripItem[] { toolStripBtnNew, toolStripButton2, toolStripButton1 });
            tspPrincipal.Location = new Point(0, 0);
            tspPrincipal.Name = "tspPrincipal";
            tspPrincipal.Size = new Size(922, 25);
            tspPrincipal.TabIndex = 37;
            // 
            // toolStripBtnNew
            // 
            toolStripBtnNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripBtnNew.Image = (Image)resources.GetObject("toolStripBtnNew.Image");
            toolStripBtnNew.ImageTransparentColor = Color.Magenta;
            toolStripBtnNew.Name = "toolStripBtnNew";
            toolStripBtnNew.Size = new Size(23, 22);
            toolStripBtnNew.Text = "&New";
            toolStripBtnNew.Click += toolStripBtnNew_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(23, 22);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripBtnBack";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // cmbBranches
            // 
            cmbBranches.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBranches.FormattingEnabled = true;
            cmbBranches.Location = new Point(593, 74);
            cmbBranches.Name = "cmbBranches";
            cmbBranches.Size = new Size(195, 23);
            cmbBranches.TabIndex = 38;
            // 
            // dgvAvailableMovies
            // 
            dgvAvailableMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableMovies.Location = new Point(15, 84);
            dgvAvailableMovies.Name = "dgvAvailableMovies";
            dgvAvailableMovies.Size = new Size(307, 159);
            dgvAvailableMovies.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 44);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 24;
            label1.Text = "Movies Available";
            // 
            // dvgRegisteredMovies
            // 
            dvgRegisteredMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgRegisteredMovies.Location = new Point(15, 290);
            dvgRegisteredMovies.Name = "dvgRegisteredMovies";
            dvgRegisteredMovies.Size = new Size(307, 159);
            dvgRegisteredMovies.TabIndex = 41;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 250);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 40;
            label2.Text = "Registered movies";
            // 
            // frmMaintenanceMovieBranch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(dvgRegisteredMovies);
            Controls.Add(label2);
            Controls.Add(dgvAvailableMovies);
            Controls.Add(cmbBranches);
            Controls.Add(tspPrincipal);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtQuantity);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "frmMaintenanceMovieBranch";
            Text = "frmMaintenanceMovieBranch";
            Load += frmMaintenanceMovieBranch_Load;
            tspPrincipal.ResumeLayout(false);
            tspPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableMovies).EndInit();
            ((System.ComponentModel.ISupportInitialize)dvgRegisteredMovies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnAccept;
        private TextBox txtQuantity;
        private Label label4;
        private Label label6;
        private ToolStrip tspPrincipal;
        private ToolStripButton toolStripBtnNew;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton1;
        private ComboBox cmbBranches;
        private DataGridView dgvAvailableMovies;
        private Label label1;
        private DataGridView dvgRegisteredMovies;
        private Label label2;
    }
}