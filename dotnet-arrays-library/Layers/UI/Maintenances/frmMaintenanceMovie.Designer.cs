namespace dotnet_arrays_library.Layers.UI.Maintenances
{
    partial class frmMaintenanceMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceMovie));
            tspPrincipal = new ToolStrip();
            toolStripBtnNew = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtIdMovie = new TextBox();
            txtTitleMovie = new TextBox();
            txtCategoryMovie = new TextBox();
            txtYearMovie = new TextBox();
            txtLanguageMovie = new TextBox();
            btnCancel = new Button();
            btnAccept = new Button();
            dgvData = new DataGridView();
            tspPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // tspPrincipal
            // 
            tspPrincipal.Items.AddRange(new ToolStripItem[] { toolStripBtnNew, toolStripButton2, toolStripButton1 });
            tspPrincipal.Location = new Point(0, 0);
            tspPrincipal.Name = "tspPrincipal";
            tspPrincipal.Size = new Size(800, 25);
            tspPrincipal.TabIndex = 9;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(423, 87);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 10;
            label1.Text = "Id Movie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 120);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 11;
            label2.Text = "Title Movie";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(423, 158);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 12;
            label3.Text = "Category Movie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(423, 194);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 13;
            label4.Text = "Year Movie";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 228);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 14;
            label5.Text = "Language Movie";
            // 
            // txtIdMovie
            // 
            txtIdMovie.Location = new Point(555, 84);
            txtIdMovie.Name = "txtIdMovie";
            txtIdMovie.Size = new Size(100, 23);
            txtIdMovie.TabIndex = 15;
            // 
            // txtTitleMovie
            // 
            txtTitleMovie.Location = new Point(555, 120);
            txtTitleMovie.Name = "txtTitleMovie";
            txtTitleMovie.Size = new Size(100, 23);
            txtTitleMovie.TabIndex = 16;
            // 
            // txtCategoryMovie
            // 
            txtCategoryMovie.Location = new Point(555, 158);
            txtCategoryMovie.Name = "txtCategoryMovie";
            txtCategoryMovie.Size = new Size(100, 23);
            txtCategoryMovie.TabIndex = 17;
            // 
            // txtYearMovie
            // 
            txtYearMovie.Location = new Point(555, 191);
            txtYearMovie.Name = "txtYearMovie";
            txtYearMovie.Size = new Size(100, 23);
            txtYearMovie.TabIndex = 18;
            // 
            // txtLanguageMovie
            // 
            txtLanguageMovie.Location = new Point(555, 220);
            txtLanguageMovie.Name = "txtLanguageMovie";
            txtLanguageMovie.Size = new Size(100, 23);
            txtLanguageMovie.TabIndex = 19;
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(554, 263);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 87);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.Image = (Image)resources.GetObject("btnAccept.Image");
            btnAccept.Location = new Point(457, 263);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(91, 87);
            btnAccept.TabIndex = 20;
            btnAccept.Text = "Accept";
            btnAccept.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 87);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(307, 184);
            dgvData.TabIndex = 22;
            // 
            // frmMaintenanceMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvData);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtLanguageMovie);
            Controls.Add(txtYearMovie);
            Controls.Add(txtCategoryMovie);
            Controls.Add(txtTitleMovie);
            Controls.Add(txtIdMovie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tspPrincipal);
            Name = "frmMaintenanceMovie";
            Text = "frmMaintenanceMovie";
            Load += frmMaintenanceMovie_Load;
            tspPrincipal.ResumeLayout(false);
            tspPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip tspPrincipal;
        private ToolStripButton toolStripBtnNew;
        private ToolStripButton toolStripButton2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtIdMovie;
        private TextBox txtTitleMovie;
        private TextBox txtCategoryMovie;
        private TextBox txtYearMovie;
        private TextBox txtLanguageMovie;
        private Button btnCancel;
        private Button btnAccept;
        private DataGridView dgvData;
        private ToolStripButton toolStripButton1;
    }
}