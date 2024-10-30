namespace MobileShopManagement
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobileCode = new System.Windows.Forms.TextBox();
            this.txtMobileName = new System.Windows.Forms.TextBox();
            this.dtpLaunchDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.rbtnSmart = new System.Windows.Forms.RadioButton();
            this.rbtnButton = new System.Windows.Forms.RadioButton();
            this.pictureBoxMobile = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvVariant = new System.Windows.Forms.DataGridView();
            this.dgvMobileList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.chkAvailability = new System.Windows.Forms.CheckBox();
            this.dgvVariantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRam_Rom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReport = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMobile)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobileList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 487);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mobile Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReport);
            this.tabPage2.Controls.Add(this.dgvMobileList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mobile List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mobile Shop Management";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAvailability);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.rbtnButton);
            this.groupBox1.Controls.Add(this.rbtnSmart);
            this.groupBox1.Controls.Add(this.cmbVersion);
            this.groupBox1.Controls.Add(this.dtpLaunchDate);
            this.groupBox1.Controls.Add(this.txtMobileName);
            this.groupBox1.Controls.Add(this.txtMobileCode);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 341);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mobile Information";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnBrowse);
            this.groupBox2.Controls.Add(this.pictureBoxMobile);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(315, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 341);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Upload Image";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvVariant);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(508, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(254, 413);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mobile Variant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mobile Model:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mobile Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Launch Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mobile Version:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Mobile Type:";
            // 
            // txtMobileCode
            // 
            this.txtMobileCode.Location = new System.Drawing.Point(127, 34);
            this.txtMobileCode.Name = "txtMobileCode";
            this.txtMobileCode.Size = new System.Drawing.Size(170, 22);
            this.txtMobileCode.TabIndex = 5;
            // 
            // txtMobileName
            // 
            this.txtMobileName.Location = new System.Drawing.Point(127, 75);
            this.txtMobileName.Name = "txtMobileName";
            this.txtMobileName.Size = new System.Drawing.Size(170, 22);
            this.txtMobileName.TabIndex = 6;
            // 
            // dtpLaunchDate
            // 
            this.dtpLaunchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLaunchDate.Location = new System.Drawing.Point(127, 111);
            this.dtpLaunchDate.Name = "dtpLaunchDate";
            this.dtpLaunchDate.Size = new System.Drawing.Size(170, 22);
            this.dtpLaunchDate.TabIndex = 7;
            // 
            // cmbVersion
            // 
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Location = new System.Drawing.Point(127, 150);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(170, 24);
            this.cmbVersion.TabIndex = 8;
            // 
            // rbtnSmart
            // 
            this.rbtnSmart.AutoSize = true;
            this.rbtnSmart.Location = new System.Drawing.Point(127, 245);
            this.rbtnSmart.Name = "rbtnSmart";
            this.rbtnSmart.Size = new System.Drawing.Size(65, 20);
            this.rbtnSmart.TabIndex = 9;
            this.rbtnSmart.TabStop = true;
            this.rbtnSmart.Text = "Smart";
            this.rbtnSmart.UseVisualStyleBackColor = true;
            // 
            // rbtnButton
            // 
            this.rbtnButton.AutoSize = true;
            this.rbtnButton.Location = new System.Drawing.Point(220, 245);
            this.rbtnButton.Name = "rbtnButton";
            this.rbtnButton.Size = new System.Drawing.Size(68, 20);
            this.rbtnButton.TabIndex = 10;
            this.rbtnButton.TabStop = true;
            this.rbtnButton.Text = "Button";
            this.rbtnButton.UseVisualStyleBackColor = true;
            // 
            // pictureBoxMobile
            // 
            this.pictureBoxMobile.Location = new System.Drawing.Point(6, 34);
            this.pictureBoxMobile.Name = "pictureBoxMobile";
            this.pictureBoxMobile.Size = new System.Drawing.Size(175, 208);
            this.pictureBoxMobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMobile.TabIndex = 0;
            this.pictureBoxMobile.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(39, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(201, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(371, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 291);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(106, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Location = new System.Drawing.Point(3, 389);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(499, 66);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // dgvVariant
            // 
            this.dgvVariant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVariant.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvVariantId,
            this.dgvRam_Rom,
            this.dgvPrice});
            this.dgvVariant.Location = new System.Drawing.Point(6, 21);
            this.dgvVariant.Name = "dgvVariant";
            this.dgvVariant.Size = new System.Drawing.Size(240, 386);
            this.dgvVariant.TabIndex = 0;
            this.dgvVariant.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvVariant_UserDeletingRow);
            // 
            // dgvMobileList
            // 
            this.dgvMobileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMobileList.Location = new System.Drawing.Point(6, 6);
            this.dgvMobileList.Name = "dgvMobileList";
            this.dgvMobileList.Size = new System.Drawing.Size(756, 394);
            this.dgvMobileList.TabIndex = 0;
            this.dgvMobileList.DoubleClick += new System.EventHandler(this.dgvMobileList_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Availability:";
            // 
            // chkAvailability
            // 
            this.chkAvailability.AutoSize = true;
            this.chkAvailability.Location = new System.Drawing.Point(127, 204);
            this.chkAvailability.Name = "chkAvailability";
            this.chkAvailability.Size = new System.Drawing.Size(89, 20);
            this.chkAvailability.TabIndex = 12;
            this.chkAvailability.Text = "Is Stock?";
            this.chkAvailability.UseVisualStyleBackColor = true;
            // 
            // dgvVariantId
            // 
            this.dgvVariantId.DataPropertyName = "VariantId";
            this.dgvVariantId.HeaderText = "Variant Id";
            this.dgvVariantId.Name = "dgvVariantId";
            this.dgvVariantId.Visible = false;
            // 
            // dgvRam_Rom
            // 
            this.dgvRam_Rom.DataPropertyName = "RamRom";
            this.dgvRam_Rom.HeaderText = "Ram And Rom";
            this.dgvRam_Rom.Name = "dgvRam_Rom";
            // 
            // dgvPrice
            // 
            this.dgvPrice.DataPropertyName = "Price";
            this.dgvPrice.HeaderText = "Price";
            this.dgvPrice.Name = "dgvPrice";
            // 
            // btnReport
            // 
            this.btnReport.AutoSize = true;
            this.btnReport.BackColor = System.Drawing.Color.Gray;
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(588, 416);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(124, 24);
            this.btnReport.TabIndex = 1;
            this.btnReport.Text = "View Report";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMobile)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVariant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMobileList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBoxMobile;
        private System.Windows.Forms.RadioButton rbtnButton;
        private System.Windows.Forms.RadioButton rbtnSmart;
        private System.Windows.Forms.ComboBox cmbVersion;
        private System.Windows.Forms.DateTimePicker dtpLaunchDate;
        private System.Windows.Forms.TextBox txtMobileName;
        private System.Windows.Forms.TextBox txtMobileCode;
        private System.Windows.Forms.DataGridView dgvVariant;
        private System.Windows.Forms.DataGridView dgvMobileList;
        private System.Windows.Forms.CheckBox chkAvailability;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVariantId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRam_Rom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPrice;
        private System.Windows.Forms.Label btnReport;
    }
}

