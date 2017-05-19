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

        DateTime dtDesigneTime = DateTime.Now;

        #endregion
        
        #region Contructor

        public mainForm()
        {
            InitializeComponent();
            lblCopyRight.Text = Convert.ToChar(169) + " " + DateTime.Today.Year + " Wijitha Wijenayake All Rights Reserved";
            MyColors = Utility.GetColors();
                        
            cbColor1.ValueMember = null;
            cbColor1.DisplayMember = "name";
            cbColor1.DataSource = MyColors;

            lblDate.Text = "Designed On: " + dtDesigneTime.ToString("dd/MM/yyyy hh:mm tt");

            StandardHeight = int.Parse(Utility.GetSetting("StandardHeight", "44"));
            StandardWidth = int.Parse(Utility.GetSetting("StandardWidth", "240"));
            CompanyNameStr = Utility.GetSetting("CompanyName");

            lblDesignBy.Text = "Designed By: " + CompanyNameStr; 
        }

        #endregion

        #region Click Events

        private void btnReset_Click(object sender, EventArgs e)
        {
            rowColors.Clear();
            colColors.Clear();
            myPanel.RowCount = 1;
            myPanel.ColumnCount = 1;
            myPanel.BackColor = Color.Transparent;
            cbColor1.SelectedIndex = 0;
            myPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            pnlColor1.BackColor = Color.Transparent;

            lblRows.Text = myPanel.RowCount.ToString();
            lblCols.Text = myPanel.ColumnCount.ToString();

            pnlRows.RowCount = 1;
            pnlColumns.ColumnCount = 1;    
        }

        private void btnDelCol_Click(object sender, EventArgs e)
        {
            if (myPanel.ColumnCount > 1)
            {
                ColumnStyle colStyle = myPanel.ColumnStyles[myPanel.ColumnCount - 1];

                myPanel.ColumnCount--;
                pnlColumns.ColumnCount--;

                myPanel.ColumnStyles.RemoveAt(myPanel.ColumnCount - 1);
                pnlColumns.ColumnStyles.RemoveAt(pnlColumns.ColumnCount - 1);
            }

            lblCols.Text = myPanel.ColumnCount.ToString();
        }

        private void btnAddCol_Click(object sender, EventArgs e)
        {
            ColumnStyle colStyle = myPanel.ColumnStyles[myPanel.ColumnCount - 1];

            myPanel.ColumnCount++;
            pnlColumns.ColumnCount++;

            myPanel.ColumnStyles.Add(new ColumnStyle(colStyle.SizeType, colStyle.Width));
            pnlColumns.ColumnStyles.Add(new ColumnStyle(colStyle.SizeType, colStyle.Width));

            lblCols.Text = myPanel.ColumnCount.ToString();
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (myPanel.RowCount > 1)
            {
                RowStyle rowStyle = myPanel.RowStyles[myPanel.RowCount - 1];

                myPanel.RowCount--;
                pnlRows.RowCount--;

                myPanel.RowStyles.RemoveAt(myPanel.RowCount - 1);
                pnlRows.RowStyles.RemoveAt(myPanel.RowCount - 1);
            }

            lblRows.Text = myPanel.RowCount.ToString();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            RowStyle rowStyle = myPanel.RowStyles[myPanel.RowCount - 1];

            myPanel.RowCount++;
            pnlRows.RowCount++;

            myPanel.RowStyles.Add(new RowStyle(rowStyle.SizeType, rowStyle.Height));
            pnlRows.RowStyles.Add(new RowStyle(rowStyle.SizeType, rowStyle.Height));

            lblRows.Text = myPanel.RowCount.ToString();
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
                if (colColors.ContainsKey(clickedCell.Value.Y))                
                    colColors[clickedCell.Value.Y] = pnlColor1.BackColor;
                else
                    colColors.Add(clickedCell.Value.Y, pnlColor1.BackColor);
                
                pnlColumns.Refresh();
                myPanel.Refresh();
            }
        }

        private void pnlRows_MouseClick(object sender, MouseEventArgs e)
        {
            Point? clickedCell = GetRowColIndex(pnlRows, e.Location);

            if (clickedCell != null)
            {
                if (rowColors.ContainsKey(clickedCell.Value.X))                
                    rowColors[clickedCell.Value.X] = pnlColor1.BackColor;                
                else                
                    rowColors.Add(clickedCell.Value.X, pnlColor1.BackColor);

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
                if (rgb.name != "none")
                    color = Color.FromArgb(rgb.r, rgb.g, rgb.b);

                pnlColor1.BackColor = color;
            }           
        }

        private void mainForm_Resize(object sender, EventArgs e)
        {
            pnlRows.Height = myPanel.Height = (myPanel.Width * StandardHeight) / StandardWidth;
            pnlPrint.Height = myPanel.Height + 180;      
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

        #endregion
    }
}
