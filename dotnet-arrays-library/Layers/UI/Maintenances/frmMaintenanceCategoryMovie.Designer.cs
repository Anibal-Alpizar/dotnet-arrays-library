namespace dotnet_arrays_library.Layers.UI.Maintenances
{
    partial class frmMaintenanceCategoryMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceCategoryMovie));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIdCategory = new TextBox();
            txtDescriptionCategory = new TextBox();
            txtNameCategory = new TextBox();
            btnAccept = new Button();
            dgvData = new DataGridView();
            tspPrincipal = new ToolStrip();
            toolStripBtnNew = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            btnCancel = new Button();
            toolStripButton1 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            tspPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(376, 116);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Id Category Movie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 149);
            label2.Name = "label2";
            label2.Size = new Size(126, 15);
            label2.TabIndex = 1;
            label2.Text = "Name Category Movie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(376, 178);
            label3.Name = "label3";
            label3.Size = new Size(154, 15);
            label3.TabIndex = 2;
            label3.Text = "Description Category Movie";
            // 
            // txtIdCategory
            // 
            txtIdCategory.Location = new Point(544, 108);
            txtIdCategory.Name = "txtIdCategory";
            txtIdCategory.Size = new Size(154, 23);
            txtIdCategory.TabIndex = 3;
            // 
            // txtDescriptionCategory
            // 
            txtDescriptionCategory.Location = new Point(544, 170);
            txtDescriptionCategory.Name = "txtDescriptionCategory";
            txtDescriptionCategory.Size = new Size(154, 23);
            txtDescriptionCategory.TabIndex = 4;
            // 
            // txtNameCategory
            // 
            txtNameCategory.Location = new Point(544, 141);
            txtNameCategory.Name = "txtNameCategory";
            txtNameCategory.Size = new Size(154, 23);
            txtNameCategory.TabIndex = 5;
            // 
            // btnAccept
            // 
            btnAccept.Image = (Image)resources.GetObject("btnAccept.Image");
            btnAccept.Location = new Point(513, 209);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(91, 87);
            btnAccept.TabIndex = 6;
            btnAccept.Text = "Accept";
            btnAccept.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(30, 112);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(307, 184);
            dgvData.TabIndex = 7;
            // 
            // tspPrincipal
            // 
            tspPrincipal.Items.AddRange(new ToolStripItem[] { toolStripBtnNew, toolStripButton2, toolStripButton1 });
            tspPrincipal.Location = new Point(0, 0);
            tspPrincipal.Name = "tspPrincipal";
            tspPrincipal.Size = new Size(800, 25);
            tspPrincipal.TabIndex = 8;
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
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(610, 209);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 87);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
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
            // frmMaintenanceCategoryMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(tspPrincipal);
            Controls.Add(dgvData);
            Controls.Add(btnAccept);
            Controls.Add(txtNameCategory);
            Controls.Add(txtDescriptionCategory);
            Controls.Add(txtIdCategory);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMaintenanceCategoryMovie";
            Text = "frmMaintenanceCategoryMovie";
            Load += frmMaintenanceCategoryMovie_Load;
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            tspPrincipal.ResumeLayout(false);
            tspPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIdCategory;
        private TextBox txtDescriptionCategory;
        private TextBox txtNameCategory;
        private Button btnAccept;
        private DataGridView dgvData;
        private ToolStrip tspPrincipal;
        private ToolStripButton toolStripBtnNew;
        private ToolStripButton toolStripButton2;
        private Button btnCancel;
        private ToolStripButton toolStripButton1;
    }
}