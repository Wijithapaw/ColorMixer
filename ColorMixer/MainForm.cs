using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ColorMixer.Security.LicenseManager;

namespace ColorMixer
{
    public partial class mainForm : Form
    {
        #region Variables

        Dictionary<int, Color> rowColors = new Dictionary<int, Color>();
        Dictionary<int, Color> colColors = new Dictionary<int, Color>();

        List<BasicColor> MyColors;

        int StandardWidth;
        int StandardHeight;
        string CompanyNameStr = string.Empty;
        string CompanyTel = string.Empty;
        string CompanyAddress = string.Empty;

        DateTime dtDesigneTime = DateTime.Now;

        #endregion
        
        #region Contructor

        public mainForm()
        {
            InitializeComponent();
            SetCompanySettings();
            Reset();

            lblCopyRight.Text = Convert.ToChar(169) + " " + DateTime.Today.Year + " Elegance (pvt) Ltd All Rights Reserved";
        }

        #endregion

        #region Click Events

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnDelCol_Click(object sender, EventArgs e)
        {
            DeleteColoum();
            SetCellSizes();
            txtColCount.Text = colColors.Count.ToString();
        }

        private void btnAddCol_Click(object sender, EventArgs e)
        {
            AddColumn();
            txtColCount.Text = colColors.Count.ToString();
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            DeleteRow();
            SetCellSizes();
            txtRowCount.Text = rowColors.Count.ToString();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            AddRow();
            SetCellSizes();
            txtRowCount.Text = rowColors.Count.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveDesign();
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            dtDesigneTime = DateTime.Now;
            lblDate.Text = "Designed On: " + dtDesigneTime.ToString("dd/MM/yyyy hh:mm tt");
            myPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            myPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsForm settings = new settingsForm();
            settings.FormClosed += Settings_FormClosed;
            settings.ShowDialog();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            SetCompanySettings();
        }

        #endregion

        #region Panel Events

        private void myPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Color rowColor = Color.Transparent;
            Color colColor = Color.Transparent;

            if (rowColors.ContainsKey(e.Row))
                rowColor = rowColors[e.Row];

            if (colColors.ContainsKey(e.Column))
                colColor = colColors[e.Column];

            Color blendedColor = GetBlendedColor(rowColor, colColor);
            e.Graphics.FillRectangle(new SolidBrush(blendedColor), e.CellBounds);
        }        

        private void pnlColumns_MouseClick(object sender, MouseEventArgs e)
        {
            Point? clickedCell = GetRowColIndex(myPanel, e.Location);

            if (clickedCell != null)
            {
                colColors[clickedCell.Value.Y] = pnlColor1.BackColor;

                pnlColumns.Refresh();
                myPanel.Refresh();
            }
        }

        private void pnlRows_MouseClick(object sender, MouseEventArgs e)
        {
            Point? clickedCell = GetRowColIndex(pnlRows, e.Location);

            if (clickedCell != null)
            {
                rowColors[clickedCell.Value.X] = pnlColor1.BackColor;

                pnlRows.Refresh();
                myPanel.Refresh();
            }
        }

        private void pnlColumns_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Color colColor = Color.Transparent;

            if (colColors.ContainsKey(e.Column))
                colColor = colColors[e.Column];

            e.Graphics.FillRectangle(new SolidBrush(colColor), e.CellBounds);
        }

        private void pnlRows_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Color rowColor = Color.Transparent;

            if (rowColors.ContainsKey(e.Row))
                rowColor = rowColors[e.Row];

            e.Graphics.FillRectangle(new SolidBrush(rowColor), e.CellBounds);
        }

        #endregion

        #region Form Events

        private void cbColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColor1.SelectedValue != null)
            {
                BasicColor rgb = (BasicColor)cbColor1.SelectedValue;
                Color color = Color.Transparent;
                if (rgb.name.ToLower() != "none")
                    color = Color.FromArgb(rgb.r, rgb.g, rgb.b);

                pnlColor1.BackColor = color;
            }           
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            pnlRows.Height = myPanel.Height = (myPanel.Width * StandardHeight) / StandardWidth;
            pnlPrint.Height = myPanel.Height + 180;      
        }

        private void pnlAllCols_Click(object sender, EventArgs e)
        {
            pnlAllCols.BackColor = pnlColor1.BackColor;

            for (int i = 0; i < colColors.Count; i++)
                colColors[i] = pnlColor1.BackColor;

            pnlColumns.Refresh();
            myPanel.Refresh();
        }

        private void pnlAllRows_Click(object sender, EventArgs e)
        {
            pnlAllRows.BackColor = pnlColor1.BackColor;

            for (int i = 0; i < rowColors.Count; i++)
                rowColors[i] = pnlColor1.BackColor;

            pnlRows.Refresh();
            myPanel.Refresh();
        }
        
        private void txtRowCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnSetRows_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRowCount.Text) || int.Parse(txtRowCount.Text) == 0)
            {
                txtRowCount.Text = "1";
            }

            int currentRowCount = rowColors.Count;
            int newRowCount = int.Parse(txtRowCount.Text);

            if (currentRowCount < newRowCount)
            {
                for (int i = currentRowCount; i < newRowCount; i++)
                {
                    AddRow();
                }
            }
            else
            {
                for (int i = currentRowCount; i > newRowCount; i--)
                {
                    DeleteRow();
                }
            }

            SetCellSizes();
        }

        private void btnColCount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColCount.Text) || int.Parse(txtColCount.Text) == 0)
            {
                txtColCount.Text = "1";
            }

            int currentColCount = colColors.Count;
            int newColCount = int.Parse(txtColCount.Text);

            if (currentColCount < newColCount)
            {
                for (int i = currentColCount; i < newColCount; i++)
                {
                    AddColumn();
                }
            }
            else
            {
                for (int i = currentColCount; i > newColCount; i--)
                {
                    DeleteColoum();
                }
            }

            SetCellSizes();
        }

        #endregion

        #region Private Methods

        private void SaveDesign()
        {
            Bitmap memoryImage;

            int canvesWidth = pnlPrint.Width;
            int canvesHeight = pnlPrint.Height;

            Rectangle screenRectangle = RectangleToScreen(this.ClientRectangle);
            int titleBarHeight = screenRectangle.Top - this.Top;
            int borderWidth = screenRectangle.Left - this.Left;

            int locationX = this.Location.X + pnlPrint.Location.X + borderWidth;
            int locationY = this.Location.Y + pnlPrint.Location.Y + titleBarHeight;

            memoryImage = new Bitmap(canvesWidth, canvesHeight);
            Size s = new Size(memoryImage.Width, memoryImage.Height);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(locationX, locationY, 0, 0, s);

            using (MemoryStream memory = new MemoryStream())
            {
                memoryImage.Save(memory, ImageFormat.Jpeg);

                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();

                saveFileDialog1.Filter = "JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
                saveFileDialog1.FilterIndex = 1;
                saveFileDialog1.RestoreDirectory = true;
                saveFileDialog1.FileName = Utility.ConstructFileName(txtName.Text, dtDesigneTime);

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        byte[] bytes = memory.ToArray();
                        myStream.Write(bytes, 0, bytes.Length);
                        myStream.Close();
                    }
                }
            }
        }

        private Color GetBlendedColor(Color color1, Color color2)
        {
            double ratio = 0.5;

            if (color1.Name.ToLower() == "transparent")
                ratio = 1;
            else if (color2.Name.ToLower() == "transparent")
                ratio = 0;

            return Utility.Blend(color2, color1, ratio);
        }

        private Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
        {
            if (point.X > tlp.Width || point.Y > tlp.Height)
                return null;

            int w = tlp.Width;
            int h = tlp.Height;
            int[] widths = tlp.GetColumnWidths();

            int i;
            for (i = widths.Length - 1; i >= 0 && point.X < w; i--)
                w -= widths[i];
            int col = i + 1;

            int[] heights = tlp.GetRowHeights();
            for (i = heights.Length - 1; i >= 0 && point.Y < h; i--)
                h -= heights[i];

            int row = i + 1;

            return new Point(row, col);
        }

        private void Reset()
        {
            rowColors.Clear();
            colColors.Clear();
            myPanel.RowCount = 1;
            myPanel.ColumnCount = 1;

            rowColors.Add(0, Color.Transparent);
            colColors.Add(0, Color.Transparent);

            myPanel.BackColor = Color.Transparent;
            cbColor1.SelectedIndex = 0;
            myPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            pnlColor1.BackColor = Color.Transparent;

            txtRowCount.Text = "1";
            txtColCount.Text = "1";
            pnlRows.RowCount = 1;
            pnlColumns.ColumnCount = 1;

            pnlAllCols.BackColor = Color.Transparent;
            pnlAllRows.BackColor = Color.Transparent;

            lblDate.Text = "Designed On: " + dtDesigneTime.ToString("dd/MM/yyyy hh:mm tt");

            lblSize.Text = string.Format("Size: {0} x {1} inches", StandardWidth, StandardHeight);
            SetCellSizes();
        }

        private void SetCompanySettings()
        {
            if (Utility.GetLicenseStatus() == LicenseStatus.Valid)
            {
                MyColors = Utility.GetColors();
                btnPrint.Enabled = true;
                lblTrial.Visible = false;
            }
            else
            {
                MyColors = Utility.GetTrialColors();
                btnPrint.Enabled = false;
                lblTrial.Visible = true;
            }

            cbColor1.ValueMember = null;
            cbColor1.DisplayMember = "name";
            cbColor1.DataSource = MyColors;

            StandardHeight = int.Parse(Utility.GetAppSetting("StandardHeight", "44"));
            StandardWidth = int.Parse(Utility.GetAppSetting("StandardWidth", "240"));
            CompanyNameStr = Utility.GetAppSetting("CompanyName");
            CompanyTel = Utility.GetAppSetting("Telephone");
            CompanyAddress = Utility.GetAppSetting("Address");

            lblDesignBy.Text = string.Format("Designed By: {0} | {1} | Tel: {2}", CompanyNameStr, CompanyAddress, CompanyTel);
        }

        private void SetCellSizes()
        {
            lblRowCell.Text = string.Format("Row Cells [{0}]: {1} inches", rowColors.Count, Math.Round((double)StandardHeight/ (double)rowColors.Count, 2));
            lblColumnCell.Text = string.Format("Column Cells [{0}]: {1} inches", colColors.Count, Math.Round((double)StandardWidth / (double)colColors.Count, 2));
        }

        private void DeleteRow()
        {
            if (myPanel.RowCount > 1)
            {
                RowStyle rowStyle = myPanel.RowStyles[myPanel.RowCount - 1];

                rowColors.Remove(rowColors.Count - 1);

                myPanel.RowCount--;
                pnlRows.RowCount--;

                myPanel.RowStyles.RemoveAt(myPanel.RowCount - 1);
                pnlRows.RowStyles.RemoveAt(myPanel.RowCount - 1);
            }
        }

        private void AddRow()
        {
            RowStyle rowStyle = myPanel.RowStyles[myPanel.RowCount - 1];

            rowColors.Add(rowColors.Count, pnlAllRows.BackColor);

            myPanel.RowCount++;
            pnlRows.RowCount++;

            myPanel.RowStyles.Add(new RowStyle(rowStyle.SizeType, rowStyle.Height));
            pnlRows.RowStyles.Add(new RowStyle(rowStyle.SizeType, rowStyle.Height));
        }

        private void DeleteColoum()
        {
            if (myPanel.ColumnCount > 1)
            {
                ColumnStyle colStyle = myPanel.ColumnStyles[myPanel.ColumnCount - 1];

                colColors.Remove(colColors.Count - 1);

                myPanel.ColumnCount--;
                pnlColumns.ColumnCount--;

                myPanel.ColumnStyles.RemoveAt(myPanel.ColumnCount - 1);
                pnlColumns.ColumnStyles.RemoveAt(pnlColumns.ColumnCount - 1);
            }
        }

        private void AddColumn()
        {
            ColumnStyle colStyle = myPanel.ColumnStyles[myPanel.ColumnCount - 1];

            colColors.Add(colColors.Count, pnlAllCols.BackColor);

            myPanel.ColumnCount++;
            pnlColumns.ColumnCount++;

            myPanel.ColumnStyles.Add(new ColumnStyle(colStyle.SizeType, colStyle.Width));
            pnlColumns.ColumnStyles.Add(new ColumnStyle(colStyle.SizeType, colStyle.Width));
        }

        #endregion

    }
}
