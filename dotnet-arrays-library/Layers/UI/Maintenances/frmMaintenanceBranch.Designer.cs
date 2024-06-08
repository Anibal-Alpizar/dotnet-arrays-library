namespace dotnet_arrays_library.Layers.UI.Maintenances
{
    partial class frmMaintenanceBranch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceBranch));
            tspPrincipal = new ToolStrip();
            toolStripBtnNew = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            btnCancel = new Button();
            btnAccept = new Button();
            dgvData = new DataGridView();
            txtNameBranch = new TextBox();
            txtIdManager = new TextBox();
            txtIdBranch = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            cmbActive = new ComboBox();
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
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(589, 292);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 87);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.Image = (Image)resources.GetObject("btnAccept.Image");
            btnAccept.Location = new Point(470, 292);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(91, 87);
            btnAccept.TabIndex = 10;
            btnAccept.Text = "Accept";
            btnAccept.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 81);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(307, 184);
            dgvData.TabIndex = 12;
            // 
            // txtNameBranch
            // 
            txtNameBranch.Location = new Point(523, 106);
            txtNameBranch.Name = "txtNameBranch";
            txtNameBranch.Size = new Size(154, 23);
            txtNameBranch.TabIndex = 18;
            // 
            // txtIdManager
            // 
            txtIdManager.Location = new Point(523, 135);
            txtIdManager.Name = "txtIdManager";
            txtIdManager.Size = new Size(154, 23);
            txtIdManager.TabIndex = 17;
            // 
            // txtIdBranch
            // 
            txtIdBranch.Location = new Point(523, 73);
            txtIdBranch.Name = "txtIdBranch";
            txtIdBranch.Size = new Size(154, 23);
            txtIdBranch.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 143);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 15;
            label3.Text = "Id Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 114);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 14;
            label2.Text = "Name Branch";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 81);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 13;
            label1.Text = "Id Branch";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(523, 204);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(154, 23);
            txtPhone.TabIndex = 24;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(523, 171);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(154, 23);
            txtAddress.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 212);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 20;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 179);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 19;
            label6.Text = "Address";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 241);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 21;
            label4.Text = "Active";
            // 
            // cmbActive
            // 
            cmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActive.FormattingEnabled = true;
            cmbActive.Location = new Point(523, 241);
            cmbActive.Name = "cmbActive";
            cmbActive.Size = new Size(154, 23);
            cmbActive.TabIndex = 25;
            // 
            // frmMaintenanceBranch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbActive);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtNameBranch);
            Controls.Add(txtIdManager);
            Controls.Add(txtIdBranch);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(tspPrincipal);
            Name = "frmMaintenanceBranch";
            Text = "frmMaintenanceBranch";
            Load += frmMaintenanceBranch_Load;
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
        private ToolStripButton toolStripButton1;
        private Button btnCancel;
        private Button btnAccept;
        private DataGridView dgvData;
        private TextBox txtNameBranch;
        private TextBox txtIdManager;
        private TextBox txtIdBranch;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label label5;
        private Label label6;
        private Label label4;
        private ComboBox cmbActive;
    }
}