namespace dotnet_arrays_library.Layers.UI.Maintenances
{
    partial class frmMaintenanceClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceClient));
            tspPrincipal = new ToolStrip();
            toolStripBtnNew = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            dgvData = new DataGridView();
            label7 = new Label();
            dtpAdmissionDate = new DateTimePicker();
            label6 = new Label();
            dtpBirthDate = new DateTimePicker();
            txtSecondLastname = new TextBox();
            label5 = new Label();
            txtFirstLastname = new TextBox();
            label4 = new Label();
            btnCancel = new Button();
            btnAccept = new Button();
            txtNameManager = new TextBox();
            txtIdentificationClient = new TextBox();
            txtIdClient = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
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
            tspPrincipal.TabIndex = 10;
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
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(24, 63);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(307, 184);
            dgvData.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 289);
            label7.Name = "label7";
            label7.Size = new Size(124, 15);
            label7.TabIndex = 42;
            label7.Text = "Client Admission Date";
            // 
            // dtpAdmissionDate
            // 
            dtpAdmissionDate.Location = new Point(560, 283);
            dtpAdmissionDate.Name = "dtpAdmissionDate";
            dtpAdmissionDate.Size = new Size(154, 23);
            dtpAdmissionDate.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 250);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 40;
            label6.Text = "Client BirthDate";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(560, 244);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(154, 23);
            dtpBirthDate.TabIndex = 39;
            // 
            // txtSecondLastname
            // 
            txtSecondLastname.Location = new Point(560, 200);
            txtSecondLastname.Name = "txtSecondLastname";
            txtSecondLastname.Size = new Size(154, 23);
            txtSecondLastname.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(392, 208);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 37;
            label5.Text = "Second Lastname Client";
            // 
            // txtFirstLastname
            // 
            txtFirstLastname.Location = new Point(560, 163);
            txtFirstLastname.Name = "txtFirstLastname";
            txtFirstLastname.Size = new Size(154, 23);
            txtFirstLastname.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(392, 171);
            label4.Name = "label4";
            label4.Size = new Size(98, 15);
            label4.TabIndex = 35;
            label4.Text = "First Name Client";
            // 
            // btnCancel
            // 
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(628, 397);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 87);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAccept
            // 
            btnAccept.Image = (Image)resources.GetObject("btnAccept.Image");
            btnAccept.Location = new Point(528, 397);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(91, 87);
            btnAccept.TabIndex = 33;
            btnAccept.Text = "Accept";
            btnAccept.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtNameManager
            // 
            txtNameManager.Location = new Point(560, 131);
            txtNameManager.Name = "txtNameManager";
            txtNameManager.Size = new Size(154, 23);
            txtNameManager.TabIndex = 32;
            // 
            // txtIdentificationClient
            // 
            txtIdentificationClient.Location = new Point(560, 92);
            txtIdentificationClient.Name = "txtIdentificationClient";
            txtIdentificationClient.Size = new Size(154, 23);
            txtIdentificationClient.TabIndex = 31;
            // 
            // txtIdClient
            // 
            txtIdClient.Location = new Point(560, 55);
            txtIdClient.Name = "txtIdClient";
            txtIdClient.Size = new Size(154, 23);
            txtIdClient.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 100);
            label3.Name = "label3";
            label3.Size = new Size(111, 15);
            label3.TabIndex = 29;
            label3.Text = "Identification Client";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 139);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 28;
            label2.Text = "Name Client";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 63);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 27;
            label1.Text = "Id Client";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(392, 329);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 43;
            label8.Text = "Active";
            // 
            // cmbActive
            // 
            cmbActive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActive.FormattingEnabled = true;
            cmbActive.Location = new Point(560, 326);
            cmbActive.Name = "cmbActive";
            cmbActive.Size = new Size(154, 23);
            cmbActive.TabIndex = 44;
            // 
            // frmMaintenanceClient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 522);
            Controls.Add(cmbActive);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpAdmissionDate);
            Controls.Add(label6);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtSecondLastname);
            Controls.Add(label5);
            Controls.Add(txtFirstLastname);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(btnAccept);
            Controls.Add(txtNameManager);
            Controls.Add(txtIdentificationClient);
            Controls.Add(txtIdClient);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvData);
            Controls.Add(tspPrincipal);
            Name = "frmMaintenanceClient";
            Text = "frmMaintenanceClient";
            Load += frmMaintenanceClient_Load;
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
        private DataGridView dgvData;
        private Label label7;
        private DateTimePicker dtpAdmissionDate;
        private Label label6;
        private DateTimePicker dtpBirthDate;
        private TextBox txtSecondLastname;
        private Label label5;
        private TextBox txtFirstLastname;
        private Label label4;
        private Button btnCancel;
        private Button btnAccept;
        private TextBox txtNameManager;
        private TextBox txtIdentificationClient;
        private TextBox txtIdClient;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private ComboBox cmbActive;
    }
}