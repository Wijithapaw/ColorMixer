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
        Dictionary<Point, Color> cellColors = new Dictionary<Point, Color>();

        public mainForm()
        {
            InitializeComponent();
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
            cellColors.Clear();
            myPanel.RowCount = 1;
            myPanel.ColumnCount = 1;
            myPanel.BackColor = Color.Transparent;
            cbColor1.SelectedIndex = 0;
            cbColor2.SelectedIndex = 0;
            myPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            pnlColor1.BackColor = Color.Transparent;
            pnlColor2.BackColor = Color.Transparent;
        }

        private void btnDelCol_Click(object sender, EventArgs e)
        {
            if (myPanel.ColumnCount > 1)
            {
                ColumnStyle colStyle = myPanel.ColumnStyles[myPanel.ColumnCount - 1];

                myPanel.ColumnCount--;

                myPanel.ColumnStyles.RemoveAt(myPanel.ColumnCount - 1);
            }
        }

        private void btnAddCol_Click(object sender, EventArgs e)
        {
            ColumnStyle colStyle = myPanel.ColumnStyles[myPanel.ColumnCount - 1];

            myPanel.ColumnCount++;

            myPanel.ColumnStyles.Add(new ColumnStyle(colStyle.SizeType, colStyle.Width));
           
        }

        private void btnDelRow_Click(object sender, EventArgs e)
        {
            if (myPanel.RowCount > 1)
            {
                RowStyle rowStyle = myPanel.RowStyles[myPanel.RowCount - 1];

                myPanel.RowCount--;

                myPanel.RowStyles.RemoveAt(myPanel.RowCount - 1);
            }
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            RowStyle rowStyle = myPanel.RowStyles[myPanel.RowCount - 1];

            myPanel.RowCount++;

            myPanel.RowStyles.Add(new RowStyle(rowStyle.SizeType, rowStyle.Height));
        }

        private void myPanel_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
        {
            Point p = new Point(e.Row, e.Column);


            if (cellColors.ContainsKey(p))
            {
                e.Graphics.FillRectangle(new SolidBrush(cellColors[p]), e.CellBounds);
            }
        }        

        private void myPanel_MouseClick(object sender, MouseEventArgs e)
        {
            Point? clickedCell = GetRowColIndex(myPanel, e.Location);

            if (clickedCell != null)
            {
                if (cellColors.ContainsKey(clickedCell.Value))
                {
                    cellColors[clickedCell.Value] = GetBlendedColor();
                }
                else
                {
                    cellColors.Add(clickedCell.Value, GetBlendedColor());
                }
                myPanel.Refresh();
            }
        }

        private Color GetBlendedColor()
        {
            Color color1 = pnlColor1.BackColor;
            Color color2 = pnlColor2.BackColor;

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
              
        private void cbColor2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            pnlColor2.BackColor = GetColor(cbColor2.SelectedItem.ToString());
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
            }
            return Color.Transparent;
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            myPanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.None;
        }
    }
}
