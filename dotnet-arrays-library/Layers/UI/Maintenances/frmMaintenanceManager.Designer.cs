namespace dotnet_arrays_library.Layers.UI.Maintenances
{
    partial class frmMaintenanceManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceManager));
            tspPrincipal = new ToolStrip();
            toolStripBtnNew = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            btnCancel = new Button();
            dgvData = new DataGridView();
            btnAccept = new Button();
            txtNameManager = new TextBox();
            txtIdentificationManager = new TextBox();
            txtIdManager = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtFirstLastname = new TextBox();
            label4 = new Label();
            txtSecondLastname = new TextBox();
            label5 = new Label();
            dtpBirthDate = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            dtpAdmissionDate = new DateTimePicker();
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
            btnCancel.Location = new Point(649, 338);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 87);
            btnCancel.TabIndex = 18;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(43, 112);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(307, 184);
            dgvData.TabIndex = 17;
            // 
            // btnAccept
            // 
            btnAccept.Image = (Image)resources.GetObject("btnAccept.Image");
            btnAccept.Location = new Point(549, 338);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(91, 87);
            btnAccept.TabIndex = 16;
            btnAccept.Text = "Accept";
            btnAccept.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtNameManager
            // 
            txtNameManager.Location = new Point(583, 143);
            txtNameManager.Name = "txtNameManager";
            txtNameManager.Size = new Size(154, 23);
            txtNameManager.TabIndex = 15;
            // 
            // txtIdentificationManager
            // 
            txtIdentificationManager.Location = new Point(583, 104);
            txtIdentificationManager.Name = "txtIdentificationManager";
            txtIdentificationManager.Size = new Size(154, 23);
            txtIdentificationManager.TabIndex = 14;
            // 
            // txtIdManager
            // 
            txtIdManager.Location = new Point(583, 67);
            txtIdManager.Name = "txtIdManager";
            txtIdManager.Size = new Size(154, 23);
            txtIdManager.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 112);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 12;
            label3.Text = "Identification Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(415, 151);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 11;
            label2.Text = "Name Manager";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(415, 75);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 10;
            label1.Text = "Id Manager";
            // 
            // txtFirstLastname
            // 
            txtFirstLastname.Location = new Point(583, 175);
            txtFirstLastname.Name = "txtFirstLastname";
            txtFirstLastname.Size = new Size(154, 23);
            txtFirstLastname.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(415, 183);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 19;
            label4.Text = "First Name Manager";
            // 
            // txtSecondLastname
            // 
            txtSecondLastname.Location = new Point(583, 212);
            txtSecondLastname.Name = "txtSecondLastname";
            txtSecondLastname.Size = new Size(154, 23);
            txtSecondLastname.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 220);
            label5.Name = "label5";
            label5.Size = new Size(147, 15);
            label5.TabIndex = 21;
            label5.Text = "Second LastnameManager";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Location = new Point(583, 256);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(154, 23);
            dtpBirthDate.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 262);
            label6.Name = "label6";
            label6.Size = new Size(106, 15);
            label6.TabIndex = 24;
            label6.Text = "Manager BirthDate";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(415, 301);
            label7.Name = "label7";
            label7.Size = new Size(140, 15);
            label7.TabIndex = 26;
            label7.Text = "Manager Admission Date";
            // 
            // dtpAdmissionDate
            // 
            dtpAdmissionDate.Location = new Point(583, 295);
            dtpAdmissionDate.Name = "dtpAdmissionDate";
            dtpAdmissionDate.Size = new Size(154, 23);
            dtpAdmissionDate.TabIndex = 25;
            // 
            // frmMaintenanceManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label7);
            Controls.Add(dtpAdmissionDate);
            Controls.Add(label6);
            Controls.Add(dtpBirthDate);
            Controls.Add(txtSecondLastname);
            Controls.Add(label5);
            Controls.Add(txtFirstLastname);
            Controls.Add(label4);
            Controls.Add(btnCancel);
            Controls.Add(dgvData);
            Controls.Add(btnAccept);
            Controls.Add(txtNameManager);
            Controls.Add(txtIdentificationManager);
            Controls.Add(txtIdManager);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tspPrincipal);
            Name = "frmMaintenanceManager";
            Text = "frmManager";
            Load += frmMaintenanceManager_Load;
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
        private DataGridView dgvData;
        private Button btnAccept;
        private TextBox txtNameManager;
        private TextBox txtIdentificationManager;
        private TextBox txtIdManager;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtFirstLastname;
        private Label label4;
        private TextBox txtSecondLastname;
        private Label label5;
        private DateTimePicker dtpBirthDate;
        private Label label6;
        private Label label7;
        private DateTimePicker dtpAdmissionDate;
    }
}