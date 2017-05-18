using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class mainForm : Form
    {
        Dictionary<int, Color> rowColors = new Dictionary<int, Color>();
        Dictionary<int, Color> colColors = new Dictionary<int, Color>();

        public mainForm()
        {
            InitializeComponent();
            lblCopyRight.Text = Convert.ToChar(169) + " " + DateTime.Today.Year + " Wijitha Wijenayake All Rights Reserved";
        }

        private void SelectColor(Color color)
        {
            this.pnlColor1.BackColor = color;
        }

        private void AddColor(Color newColor)
        {
            Color existingColor = myPanel.BackColor;

            double ratio = 0.5;

            if (existingColor.Name.ToLower() == "transparent")
                ratio = 1;

            this.myPanel.BackColor = Utility.Blend(newColor, existingColor, ratio);
        }
               
        private void btnReset_Click(object sender, EventArgs e)
        {
            rowColors.Clear();
            colColors.Clear();
            myPanel.RowCount = 1;
            myPanel.ColumnCount = 1;
            myPanel.BackColor = Color.Transparent;
            cbColor1.SelectedIndex = 0;
            rbRow.Checked = true;
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

        private void myPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point? clickedCell = GetRowColIndex(myPanel, e.Location);

            if (clickedCell != null)
            {
                if (rbRow.Checked)
                {
                    if (rowColors.ContainsKey(clickedCell.Value.X))
                    {
                        rowColors[clickedCell.Value.X] = pnlColor1.BackColor;
                    }
                    else
                    {
                        rowColors.Add(clickedCell.Value.X, pnlColor1.BackColor);
                    }

                    pnlRows.Refresh();
                }
                else if (rbCol.Checked)
                {
                    if (colColors.ContainsKey(clickedCell.Value.Y))
                    {
                        colColors[clickedCell.Value.Y] = pnlColor1.BackColor;
                    }
                    else
                    {
                        colColors.Add(clickedCell.Value.Y, pnlColor1.BackColor);
                    }
                    pnlColumns.Refresh();
                }

                myPanel.Refresh();
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

        Point? GetRowColIndex(TableLayoutPanel tlp, Point point)
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

        private void cbColor1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlColor1.BackColor = GetColor(cbColor1.SelectedItem.ToString());
        }

        private Color GetColor(string color)
        {
            switch (color.ToLower())
            {
                case "red": return Color.Red;
                case "green": return Color.Green;
                case "yellow": return Color.Yellow;
                case "black": return Color.Black;
                case "white": return Color.White;
                case "blue": return Color.Blue;
                case "royalblue": return Color.FromArgb(65, 105, 225);
                case "skyblue": return Color.FromArgb(135, 206, 250);
                case "gold": return Color.FromArgb(255, 215, 0);
                case "lightred": return Color.FromArgb(255, 69, 0);
                case "silver": return Color.FromArgb(192, 192, 192);
            }
            return Color.Transparent;
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            myPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            myPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
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
    }
}
