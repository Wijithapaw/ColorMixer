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
            this.btnDelRow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCol = new System.Windows.Forms.Button();
            this.btnDelCol = new System.Windows.Forms.Button();
            this.pnlColor1 = new System.Windows.Forms.Panel();
            this.cbColor1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCol = new System.Windows.Forms.RadioButton();
            this.rbRow = new System.Windows.Forms.RadioButton();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblCols = new System.Windows.Forms.Label();
            this.pnlColumns = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRows = new System.Windows.Forms.TableLayoutPanel();
            this.lblCopyRight = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPanel
            // 
            this.myPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.myPanel.BackColor = System.Drawing.SystemColors.Control;
            this.myPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.myPanel.ColumnCount = 1;
            this.myPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.myPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.myPanel.Location = new System.Drawing.Point(138, 158);
            this.myPanel.Margin = new System.Windows.Forms.Padding(4);
            this.myPanel.Name = "myPanel";
            this.myPanel.RowCount = 1;
            this.myPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myPanel.Size = new System.Drawing.Size(815, 285);
            this.myPanel.TabIndex = 0;
            this.myPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.myPanel_CellPaint);
            this.myPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseClick);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(984, 54);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 28);
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
            this.groupBox1.Location = new System.Drawing.Point(83, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rows";
            // 
            // btnDelRow
            // 
            this.btnDelRow.Location = new System.Drawing.Point(9, 21);
            this.btnDelRow.Name = "btnDelRow";
            this.btnDelRow.Size = new System.Drawing.Size(27, 23);
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
            this.groupBox2.Location = new System.Drawing.Point(245, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // btnAddCol
            // 
            this.btnAddCol.Location = new System.Drawing.Point(85, 21);
            this.btnAddCol.Name = "btnAddCol";
            this.btnAddCol.Size = new System.Drawing.Size(27, 23);
            this.btnAddCol.TabIndex = 11;
            this.btnAddCol.Text = "+";
            this.btnAddCol.UseVisualStyleBackColor = true;
            this.btnAddCol.Click += new System.EventHandler(this.btnAddCol_Click);
            // 
            // btnDelCol
            // 
            this.btnDelCol.Location = new System.Drawing.Point(9, 21);
            this.btnDelCol.Name = "btnDelCol";
            this.btnDelCol.Size = new System.Drawing.Size(27, 23);
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
            this.pnlColor1.Location = new System.Drawing.Point(984, 312);
            this.pnlColor1.Name = "pnlColor1";
            this.pnlColor1.Size = new System.Drawing.Size(80, 69);
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
            this.cbColor1.Location = new System.Drawing.Point(984, 261);
            this.cbColor1.Name = "cbColor1";
            this.cbColor1.Size = new System.Drawing.Size(80, 24);
            this.cbColor1.TabIndex = 9;
            this.cbColor1.SelectionChangeCommitted += new System.EventHandler(this.cbColor1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.rbCol);
            this.panel1.Controls.Add(this.rbRow);
            this.panel1.Location = new System.Drawing.Point(984, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 72);
            this.panel1.TabIndex = 11;
            // 
            // rbCol
            // 
            this.rbCol.AutoSize = true;
            this.rbCol.Location = new System.Drawing.Point(7, 42);
            this.rbCol.Name = "rbCol";
            this.rbCol.Size = new System.Drawing.Size(56, 21);
            this.rbCol.TabIndex = 12;
            this.rbCol.TabStop = true;
            this.rbCol.Text = "Cols";
            this.rbCol.UseVisualStyleBackColor = true;
            // 
            // rbRow
            // 
            this.rbRow.AutoSize = true;
            this.rbRow.Checked = true;
            this.rbRow.Location = new System.Drawing.Point(7, 15);
            this.rbRow.Name = "rbRow";
            this.rbRow.Size = new System.Drawing.Size(63, 21);
            this.rbRow.TabIndex = 11;
            this.rbRow.TabStop = true;
            this.rbRow.Text = "Rows";
            this.rbRow.UseVisualStyleBackColor = true;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinalize.Location = new System.Drawing.Point(878, 54);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(75, 28);
            this.btnFinalize.TabIndex = 12;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(782, 54);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 28);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(91, 21);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(27, 23);
            this.btnAddRow.TabIndex = 9;
            this.btnAddRow.Text = "+";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(52, 22);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(16, 17);
            this.lblRows.TabIndex = 10;
            this.lblRows.Text = "1";
            // 
            // lblCols
            // 
            this.lblCols.AutoSize = true;
            this.lblCols.Location = new System.Drawing.Point(51, 24);
            this.lblCols.Name = "lblCols";
            this.lblCols.Size = new System.Drawing.Size(16, 17);
            this.lblCols.TabIndex = 11;
            this.lblCols.Text = "1";
            // 
            // pnlColumns
            // 
            this.pnlColumns.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlColumns.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlColumns.ColumnCount = 1;
            this.pnlColumns.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlColumns.Location = new System.Drawing.Point(138, 103);
            this.pnlColumns.Name = "pnlColumns";
            this.pnlColumns.RowCount = 1;
            this.pnlColumns.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlColumns.Size = new System.Drawing.Size(815, 40);
            this.pnlColumns.TabIndex = 14;
            this.pnlColumns.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.pnlColumns_CellPaint);
            // 
            // pnlRows
            // 
            this.pnlRows.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlRows.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.pnlRows.ColumnCount = 1;
            this.pnlRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRows.Location = new System.Drawing.Point(83, 157);
            this.pnlRows.Name = "pnlRows";
            this.pnlRows.RowCount = 1;
            this.pnlRows.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlRows.Size = new System.Drawing.Size(40, 285);
            this.pnlRows.TabIndex = 15;
            this.pnlRows.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.pnlRows_CellPaint);
            // 
            // lblCopyRight
            // 
            this.lblCopyRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCopyRight.AutoSize = true;
            this.lblCopyRight.Location = new System.Drawing.Point(13, 549);
            this.lblCopyRight.Name = "lblCopyRight";
            this.lblCopyRight.Size = new System.Drawing.Size(66, 17);
            this.lblCopyRight.TabIndex = 16;
            this.lblCopyRight.Text = "copyright";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(138, 466);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(553, 22);
            this.textBox1.TabIndex = 17;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 578);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCopyRight);
            this.Controls.Add(this.pnlRows);
            this.Controls.Add(this.pnlColumns);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbColor1);
            this.Controls.Add(this.pnlColor1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.myPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainForm";
            this.Text = "Saree Designer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbCol;
        private System.Windows.Forms.RadioButton rbRow;
        private System.Windows.Forms.Button btnFinalize;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblCols;
        private System.Windows.Forms.TableLayoutPanel pnlColumns;
        private System.Windows.Forms.TableLayoutPanel pnlRows;
        private System.Windows.Forms.Label lblCopyRight;
        private System.Windows.Forms.TextBox textBox1;
    }
}

