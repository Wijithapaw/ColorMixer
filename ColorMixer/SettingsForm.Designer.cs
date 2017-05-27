namespace ColorMixer
{
    partial class settingsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnUpdateComDetails = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.tabColors = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtColorCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddColor = new System.Windows.Forms.Button();
            this.gvColors = new System.Windows.Forms.DataGridView();
            this.tabLicense = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUniqueId = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblKey = new System.Windows.Forms.Label();
            this.txtUniqueId = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblLicenseStatus = new System.Windows.Forms.Label();
            this.colColorCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabColors.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvColors)).BeginInit();
            this.tabLicense.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.tabGeneral);
            this.tabControl.Controls.Add(this.tabColors);
            this.tabControl.Controls.Add(this.tabLicense);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ItemSize = new System.Drawing.Size(25, 100);
            this.tabControl.Location = new System.Drawing.Point(15, 19);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(724, 511);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 1;
            this.tabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            // 
            // tabGeneral
            // 
            this.tabGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tabGeneral.Controls.Add(this.groupBox2);
            this.tabGeneral.Location = new System.Drawing.Point(104, 4);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(616, 503);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.Enter += new System.EventHandler(this.tabGeneral_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.btnUpdateComDetails);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtTelephone);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCompanyName);
            this.groupBox2.Location = new System.Drawing.Point(29, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 211);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Company Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Business Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(141, 122);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(307, 44);
            this.txtAddress.TabIndex = 11;
            // 
            // btnUpdateComDetails
            // 
            this.btnUpdateComDetails.Location = new System.Drawing.Point(141, 181);
            this.btnUpdateComDetails.Name = "btnUpdateComDetails";
            this.btnUpdateComDetails.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateComDetails.TabIndex = 6;
            this.btnUpdateComDetails.Text = "Save";
            this.btnUpdateComDetails.UseVisualStyleBackColor = true;
            this.btnUpdateComDetails.Click += new System.EventHandler(this.btnUpdateComDetails_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Telephone No:";
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(141, 87);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(307, 20);
            this.txtTelephone.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(141, 49);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(307, 20);
            this.txtCompanyName.TabIndex = 7;
            // 
            // tabColors
            // 
            this.tabColors.BackColor = System.Drawing.SystemColors.Control;
            this.tabColors.Controls.Add(this.panel1);
            this.tabColors.Controls.Add(this.gvColors);
            this.tabColors.Location = new System.Drawing.Point(104, 4);
            this.tabColors.Name = "tabColors";
            this.tabColors.Size = new System.Drawing.Size(616, 503);
            this.tabColors.TabIndex = 2;
            this.tabColors.Text = "Color Settings";
            this.tabColors.Enter += new System.EventHandler(this.tabColors_Enter);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.numB);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtColorCode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.numR);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numG);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnAddColor);
            this.panel1.Location = new System.Drawing.Point(89, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 48);
            this.panel1.TabIndex = 10;
            // 
            // numB
            // 
            this.numB.Location = new System.Drawing.Point(331, 14);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(51, 20);
            this.numB.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "G";
            // 
            // txtColorCode
            // 
            this.txtColorCode.Location = new System.Drawing.Point(50, 14);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Size = new System.Drawing.Size(97, 20);
            this.txtColorCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "B";
            // 
            // numR
            // 
            this.numR.Location = new System.Drawing.Point(169, 14);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(51, 20);
            this.numR.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "R";
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(256, 14);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(51, 20);
            this.numG.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // btnAddColor
            // 
            this.btnAddColor.Location = new System.Drawing.Point(395, 13);
            this.btnAddColor.Name = "btnAddColor";
            this.btnAddColor.Size = new System.Drawing.Size(50, 23);
            this.btnAddColor.TabIndex = 5;
            this.btnAddColor.Text = "Add";
            this.btnAddColor.UseVisualStyleBackColor = true;
            this.btnAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // gvColors
            // 
            this.gvColors.AllowUserToAddRows = false;
            this.gvColors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvColors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colColorCode,
            this.R,
            this.G,
            this.B,
            this.Delete});
            this.gvColors.Location = new System.Drawing.Point(89, 101);
            this.gvColors.Name = "gvColors";
            this.gvColors.ReadOnly = true;
            this.gvColors.RowHeadersVisible = false;
            this.gvColors.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvColors.Size = new System.Drawing.Size(454, 387);
            this.gvColors.TabIndex = 0;
            this.gvColors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvColors_CellClick);
            // 
            // tabLicense
            // 
            this.tabLicense.BackColor = System.Drawing.SystemColors.Control;
            this.tabLicense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabLicense.Controls.Add(this.panel2);
            this.tabLicense.Controls.Add(this.groupBox1);
            this.tabLicense.Location = new System.Drawing.Point(104, 4);
            this.tabLicense.Name = "tabLicense";
            this.tabLicense.Padding = new System.Windows.Forms.Padding(3);
            this.tabLicense.Size = new System.Drawing.Size(616, 503);
            this.tabLicense.TabIndex = 1;
            this.tabLicense.Text = "License";
            this.tabLicense.Enter += new System.EventHandler(this.tabLicense_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUniqueId);
            this.groupBox1.Controls.Add(this.btnRegister);
            this.groupBox1.Controls.Add(this.lblKey);
            this.groupBox1.Controls.Add(this.txtUniqueId);
            this.groupBox1.Controls.Add(this.txtKey);
            this.groupBox1.Controls.Add(this.lblLicenseStatus);
            this.groupBox1.Location = new System.Drawing.Point(37, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 182);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "License";
            // 
            // lblUniqueId
            // 
            this.lblUniqueId.AutoSize = true;
            this.lblUniqueId.Location = new System.Drawing.Point(33, 52);
            this.lblUniqueId.Name = "lblUniqueId";
            this.lblUniqueId.Size = new System.Drawing.Size(102, 13);
            this.lblUniqueId.TabIndex = 0;
            this.lblUniqueId.Text = "Machine Unique ID:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(466, 86);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 5;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(33, 88);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(68, 13);
            this.lblKey.TabIndex = 1;
            this.lblKey.Text = "License Key:";
            // 
            // txtUniqueId
            // 
            this.txtUniqueId.Location = new System.Drawing.Point(141, 49);
            this.txtUniqueId.Name = "txtUniqueId";
            this.txtUniqueId.ReadOnly = true;
            this.txtUniqueId.Size = new System.Drawing.Size(307, 20);
            this.txtUniqueId.TabIndex = 4;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(141, 88);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(307, 20);
            this.txtKey.TabIndex = 2;
            // 
            // lblLicenseStatus
            // 
            this.lblLicenseStatus.AutoSize = true;
            this.lblLicenseStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseStatus.Location = new System.Drawing.Point(138, 131);
            this.lblLicenseStatus.Name = "lblLicenseStatus";
            this.lblLicenseStatus.Size = new System.Drawing.Size(86, 20);
            this.lblLicenseStatus.TabIndex = 3;
            this.lblLicenseStatus.Text = "Key Status";
            // 
            // colColorCode
            // 
            this.colColorCode.DataPropertyName = "name";
            this.colColorCode.HeaderText = "Name";
            this.colColorCode.Name = "colColorCode";
            this.colColorCode.ReadOnly = true;
            // 
            // R
            // 
            this.R.DataPropertyName = "r";
            this.R.HeaderText = "R";
            this.R.Name = "R";
            this.R.ReadOnly = true;
            // 
            // G
            // 
            this.G.DataPropertyName = "g";
            this.G.HeaderText = "G";
            this.G.Name = "G";
            this.G.ReadOnly = true;
            // 
            // B
            // 
            this.B.DataPropertyName = "b";
            this.B.HeaderText = "B";
            this.B.Name = "B";
            this.B.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle5;
            this.Delete.HeaderText = "Detete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(37, 380);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 104);
            this.panel2.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(433, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "This is a product by Elegance (pvt) Ltd. Using This product without a valid licen" +
    "se is illegal.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(341, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Elegance (pvt) Ltd | Tel: +94 77 2941 796 | Email: wijitha@outlook.com";
            // 
            // settingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 551);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "settingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.tabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabColors.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvColors)).EndInit();
            this.tabLicense.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabLicense;
        private System.Windows.Forms.TabPage tabColors;
        private System.Windows.Forms.Label lblLicenseStatus;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblUniqueId;
        private System.Windows.Forms.TextBox txtUniqueId;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnUpdateComDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.DataGridView gvColors;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtColorCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colColorCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn R;
        private System.Windows.Forms.DataGridViewTextBoxColumn G;
        private System.Windows.Forms.DataGridViewTextBoxColumn B;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}