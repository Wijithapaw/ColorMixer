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
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnDelRow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddCol = new System.Windows.Forms.Button();
            this.btnDelCol = new System.Windows.Forms.Button();
            this.pnlColor1 = new System.Windows.Forms.Panel();
            this.cbColor1 = new System.Windows.Forms.ComboBox();
            this.cbColor2 = new System.Windows.Forms.ComboBox();
            this.pnlColor2 = new System.Windows.Forms.Panel();
            this.btnFinalize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // myPanel
            // 
            this.myPanel.BackColor = System.Drawing.Color.Transparent;
            this.myPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.myPanel.ColumnCount = 1;
            this.myPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.myPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.myPanel.Location = new System.Drawing.Point(83, 114);
            this.myPanel.Margin = new System.Windows.Forms.Padding(4);
            this.myPanel.Name = "myPanel";
            this.myPanel.RowCount = 1;
            this.myPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.myPanel.Size = new System.Drawing.Size(870, 285);
            this.myPanel.TabIndex = 0;
            this.myPanel.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.myPanel_CellPaint);
            this.myPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.myPanel_MouseClick);
            // 
            // btnReset
            // 
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
            this.groupBox1.Controls.Add(this.btnAddRow);
            this.groupBox1.Controls.Add(this.btnDelRow);
            this.groupBox1.Location = new System.Drawing.Point(83, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 55);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rows";
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(52, 21);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(27, 23);
            this.btnAddRow.TabIndex = 9;
            this.btnAddRow.Text = "+";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
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
            this.groupBox2.Controls.Add(this.btnAddCol);
            this.groupBox2.Controls.Add(this.btnDelCol);
            this.groupBox2.Location = new System.Drawing.Point(194, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // btnAddCol
            // 
            this.btnAddCol.Location = new System.Drawing.Point(52, 21);
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
            this.pnlColor1.BackColor = System.Drawing.Color.Transparent;
            this.pnlColor1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor1.Location = new System.Drawing.Point(984, 168);
            this.pnlColor1.Name = "pnlColor1";
            this.pnlColor1.Size = new System.Drawing.Size(80, 69);
            this.pnlColor1.TabIndex = 8;
            // 
            // cbColor1
            // 
            this.cbColor1.FormattingEnabled = true;
            this.cbColor1.Items.AddRange(new object[] {
            "None",
            "Red",
            "Green",
            "Yellow",
            "Black",
            "White"});
            this.cbColor1.Location = new System.Drawing.Point(984, 114);
            this.cbColor1.Name = "cbColor1";
            this.cbColor1.Size = new System.Drawing.Size(80, 24);
            this.cbColor1.TabIndex = 9;
            this.cbColor1.SelectionChangeCommitted += new System.EventHandler(this.cbColor1_SelectedIndexChanged);
            // 
            // cbColor2
            // 
            this.cbColor2.FormattingEnabled = true;
            this.cbColor2.Items.AddRange(new object[] {
            "None",
            "Red",
            "Green",
            "Yellow",
            "Black",
            "White"});
            this.cbColor2.Location = new System.Drawing.Point(984, 267);
            this.cbColor2.Name = "cbColor2";
            this.cbColor2.Size = new System.Drawing.Size(80, 24);
            this.cbColor2.TabIndex = 11;
            this.cbColor2.SelectionChangeCommitted += new System.EventHandler(this.cbColor2_SelectionChangeCommitted);
            // 
            // pnlColor2
            // 
            this.pnlColor2.BackColor = System.Drawing.Color.Transparent;
            this.pnlColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlColor2.Location = new System.Drawing.Point(984, 321);
            this.pnlColor2.Name = "pnlColor2";
            this.pnlColor2.Size = new System.Drawing.Size(80, 69);
            this.pnlColor2.TabIndex = 10;
            // 
            // btnFinalize
            // 
            this.btnFinalize.Location = new System.Drawing.Point(877, 57);
            this.btnFinalize.Name = "btnFinalize";
            this.btnFinalize.Size = new System.Drawing.Size(75, 23);
            this.btnFinalize.TabIndex = 12;
            this.btnFinalize.Text = "Finalize";
            this.btnFinalize.UseVisualStyleBackColor = true;
            this.btnFinalize.Click += new System.EventHandler(this.btnFinalize_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 578);
            this.Controls.Add(this.btnFinalize);
            this.Controls.Add(this.cbColor2);
            this.Controls.Add(this.pnlColor2);
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
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel myPanel;
        private System.Windows.Forms.Button btnReset;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnDelRow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddCol;
        private System.Windows.Forms.Button btnDelCol;
        private System.Windows.Forms.Panel pnlColor1;
        private System.Windows.Forms.ComboBox cbColor1;
        private System.Windows.Forms.ComboBox cbColor2;
        private System.Windows.Forms.Panel pnlColor2;
        private System.Windows.Forms.Button btnFinalize;
    }
}

