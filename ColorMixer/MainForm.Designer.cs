namespace ColorMixer
{
    partial class mainForm
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
            this.myPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRows = new System.Windows.Forms.Label();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCols = new System.Windows.Forms.Label();
            this.btnAddCol = new System.Windows.Forms.Button();
            this.btnDelCol = new System.Windows.Forms.Button();
            this.pnlColor1 = new System.Windows.Forms.Panel();
            this.cbColor1 = new System.Windows.Forms.ComboBox();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlColumns = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRows = new System.Windows.Forms.TableLayoutPanel();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlPrint = new System.Windows.Forms.Panel();
            this.lblDesignBy = new System.Windows.Forms.Label();
            this.pnlAllRows = new System.Windows.Forms.TableLayoutPanel();
            this.pnlAllCols = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlPrint.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPanel
            // 
            this.myPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myPanel.BackColor = System.Drawing.SystemColors.Control;
            this.myPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.myPanel.ColumnCount = 1;
            this.myPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.myPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.myPanel.Location = new System.Drawing.Point(58, 64);
            this.myPanel.Name = "myPanel";
            this.myPanel.RowCount = 1;
            this.myPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myPanel.Size = new System.Drawing.Size(619, 123);
            this.myPanel.TabIndex = 0;
            this.myPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.myPanel_CellPaint);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(770, 44);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 23);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRows);
            this.groupBox1.Controls.Add(this.btnAddRow);
            this.groupBox1.Controls.Add(this.btnDelRow);
            this.groupBox1.Location = new System.Drawing.Point(80, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(100, 45);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rows";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(39, 18);
            this.lblRows.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(13, 13);
            this.lblRows.TabIndex = 10;
            this.lblRows.Text = "1";
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(68, 17);
            this.btnAddRow.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(20, 19);
            this.btnAddRow.TabIndex = 9;
            this.btnAddRow.Text = "+";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnDelRow
            // 
            this.btnDelRow.Location = new System.Drawing.Point(7, 17);
            this.btnDelRow.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(20, 19);
            this.btnDelRow.TabIndex = 8;
            this.btnDelRow.Text = "-";
            this.btnDelRow.UseVisualStyleBackColor = true;
            this.btnDelRow.Click += new System.EventHandler(this.btnDelRow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCols);
            this.groupBox2.Controls.Add(this.btnAddCol);
            this.groupBox2.Controls.Add(this.btnDelCol);
            this.groupBox2.Location = new System.Drawing.Point(202, 29);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(93, 45);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(38, 20);
            this.lblCols.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(13, 13);
            this.lblCols.TabIndex = 11;
            this.lblCols.Text = "1";
            // 
            // btnAddCol
            // 
            this.btnAddCol.Location = new System.Drawing.Point(64, 17);
            this.btnAddCol.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCol.Name = "btnAddCol";
            this.btnAddCol.Size = new System.Drawing.Size(20, 19);
            this.btnAddCol.TabIndex = 11;
            this.btnAddCol.Text = "+";
            this.btnAddCol.UseVisualStyleBackColor = true;
            this.btnAddCol.Click += new System.EventHandler(this.btnAddCol_Click);
            // 
            // btnDelCol
            // 
            this.btnDelCol.Location = new System.Drawing.Point(7, 17);
            this.btnDelCol.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelCol.Name = "btnDelCol";
            this.btnDelCol.Size = new System.Drawing.Size(20, 19);
            this.btnDelCol.TabIndex = 10;
            this.btnDelCol.Text = "-";
            this.btnDelCol.UseVisualStyleBackColor = true;
            this.btnDelCol.Click += new System.EventHandler(this.btnDelCol_Click);
            // 
            // pnlColor1
            // 
            this.pnlColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColor1.BackColor = System.Drawing.Color.Transparent;
            this.pnlColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor1.Location = new System.Drawing.Point(770, 176);
            this.pnlColor1.Margin = new System.Windows.Forms.Padding(2);
            this.pnlColor1.Name = "pnlColor1";
            this.pnlColor1.Size = new System.Drawing.Size(61, 57);
            this.pnlColor1.TabIndex = 8;
            // 
            // cbColor1
            // 
            this.cbColor1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbColor1.FormattingEnabled = true;
            this.cbColor1.Items.AddRange(new object[] {
            "None",
            "Red",
            "lightred",
            "Green",
            "Blue",
            "royalblue",
            "skyblue",
            "Yellow",
            "gold",
            "Black",
            "White",
            "silver"});
            this.cbColor1.Location = new System.Drawing.Point(770, 135);
            this.cbColor1.Margin = new System.Windows.Forms.Padding(2);
            this.cbColor1.Name = "cbColor1";
            this.cbColor1.Size = new System.Drawing.Size(61, 21);
            this.cbColor1.TabIndex = 9;
            this.cbColor1.SelectionChangeCommitted += new System.EventHandler(this.cbColor1_SelectedIndexChanged);
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalize.Location = new System.Drawing.Point(696, 44);
            this.btnFinalize.Margin = new System.Windows.Forms.Padding(2);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(56, 23);
            this.btnFinalize.TabIndex = 12;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(622, 44);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 23);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlColumns
            // 
            this.pnlColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColumns.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlColumns.ColumnCount = 1;
            this.pnlColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlColumns.Location = new System.Drawing.Point(58, 20);
            this.pnlColumns.Margin = new System.Windows.Forms.Padding(2);
            this.pnlColumns.Name = "pnlColumns";
            this.pnlColumns.RowCount = 1;
            this.pnlColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlColumns.Size = new System.Drawing.Size(619, 32);
            this.pnlColumns.TabIndex = 14;
            this.pnlColumns.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.pnlColumns_CellPaint);
            this.pnlColumns.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlColumns_MouseClick);
            // 
            // pnlRows
            // 
            this.pnlRows.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlRows.ColumnCount = 1;
            this.pnlRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRows.Location = new System.Drawing.Point(17, 63);
            this.pnlRows.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRows.Name = "pnlRows";
            this.pnlRows.RowCount = 1;
            this.pnlRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRows.Size = new System.Drawing.Size(30, 124);
            this.pnlRows.TabIndex = 15;
            this.pnlRows.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.pnlRows_CellPaint);
            this.pnlRows.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlRows_MouseClick);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(10, 453);
            this.lblCopyRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(50, 13);
            this.lblCopyRight.TabIndex = 16;
            this.lblCopyRight.Text = "copyright";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtName.Location = new System.Drawing.Point(98, 213);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 20);
            this.txtName.TabIndex = 17;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(552, 44);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(56, 23);
            this.btnPrint.TabIndex = 18;
            this.btnPrint.Text = "Save";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 216);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name:";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(427, 215);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "Date";
            // 
            // pnlPrint
            // 
            this.pnlPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrint.Controls.Add(this.lblDesignBy);
            this.pnlPrint.Controls.Add(this.myPanel);
            this.pnlPrint.Controls.Add(this.lblDate);
            this.pnlPrint.Controls.Add(this.pnlColumns);
            this.pnlPrint.Controls.Add(this.label1);
            this.pnlPrint.Controls.Add(this.pnlRows);
            this.pnlPrint.Controls.Add(this.txtName);
            this.pnlPrint.Location = new System.Drawing.Point(62, 113);
            this.pnlPrint.Margin = new System.Windows.Forms.Padding(2);
            this.pnlPrint.Name = "pnlPrint";
            this.pnlPrint.Size = new System.Drawing.Size(690, 295);
            this.pnlPrint.TabIndex = 21;
            // 
            // lblDesignBy
            // 
            this.lblDesignBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDesignBy.AutoSize = true;
            this.lblDesignBy.Location = new System.Drawing.Point(56, 254);
            this.lblDesignBy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDesignBy.Name = "lblDesignBy";
            this.lblDesignBy.Size = new System.Drawing.Size(70, 13);
            this.lblDesignBy.TabIndex = 21;
            this.lblDesignBy.Text = "Designed By:";
            // 
            // pnlAllRows
            // 
            this.pnlAllRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAllRows.BackColor = System.Drawing.Color.Transparent;
            this.pnlAllRows.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlAllRows.ColumnCount = 1;
            this.pnlAllRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAllRows.Location = new System.Drawing.Point(770, 299);
            this.pnlAllRows.Name = "pnlAllRows";
            this.pnlAllRows.RowCount = 3;
            this.pnlAllRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.pnlAllRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.pnlAllRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.pnlAllRows.Size = new System.Drawing.Size(29, 58);
            this.pnlAllRows.TabIndex = 22;
            this.pnlAllRows.Click += new System.EventHandler(this.pnlAllRows_Click);
            // 
            // pnlAllCols
            // 
            this.pnlAllCols.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAllCols.BackColor = System.Drawing.Color.Transparent;
            this.pnlAllCols.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlAllCols.ColumnCount = 3;
            this.pnlAllCols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.pnlAllCols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.pnlAllCols.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.pnlAllCols.Location = new System.Drawing.Point(770, 254);
            this.pnlAllCols.Name = "pnlAllCols";
            this.pnlAllCols.RowCount = 1;
            this.pnlAllCols.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlAllCols.Size = new System.Drawing.Size(60, 24);
            this.pnlAllCols.TabIndex = 23;
            this.pnlAllCols.Click += new System.EventHandler(this.pnlAllCols_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 476);
            this.Controls.Add(this.pnlAllCols);
            this.Controls.Add(this.pnlAllRows);
            this.Controls.Add(this.pnlPrint);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.cbColor1);
            this.Controls.Add(this.pnlColor1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Name = "mainForm";
            this.Text = "Handloom Designer";
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlPrint.ResumeLayout(false);
            this.pnlPrint.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel myPanel;
        private System.Windows.Forms.Button btnReset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCol;
        private System.Windows.Forms.Button btnDelCol;
        private System.Windows.Forms.Panel pnlColor1;
        private System.Windows.Forms.ComboBox cbColor1;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.TableLayoutPanel pnlColumns;
        private System.Windows.Forms.TableLayoutPanel pnlRows;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Panel pnlPrint;
        private System.Windows.Forms.Label lblDesignBy;
        private System.Windows.Forms.TableLayoutPanel pnlAllRows;
        private System.Windows.Forms.TableLayoutPanel pnlAllCols;
    }
}

