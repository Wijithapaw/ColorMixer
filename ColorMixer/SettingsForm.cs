using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ColorMixer.Security.LicenseManager;

namespace ColorMixer
{
    public partial class settingsForm : Form
    {
        #region Prperties

        ColorMixer.Security.LicenseManager licenseManager = new Security.LicenseManager();

        #endregion

        #region Constructor

        public settingsForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Page Events

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Blue);
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void gvColors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                 "Confirm Delete!!",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    var listColors = (BindingList<BasicColor>)gvColors.DataSource;
                    listColors.RemoveAt(e.RowIndex);
                    Utility.UpdateColors(listColors.ToList());
                }
            }
        }

        #endregion

        #region General Tab

        private void btnUpdateComDetails_Click(object sender, EventArgs e)
        {
            Utility.SaveAppSetting("CompanyName", txtCompanyName.Text);
            Utility.SaveAppSetting("Telephone", txtTelephone.Text);
            Utility.SaveAppSetting("Address", txtAddress.Text);
        }

        private void tabGeneral_Enter(object sender, EventArgs e)
        {
            txtCompanyName.Text = Utility.GetAppSetting("CompanyName");
            txtTelephone.Text = Utility.GetAppSetting("Telephone");
            txtAddress.Text = Utility.GetAppSetting("Address");
        }

        #endregion

        #region Colors Tab

        private void tabColors_Enter(object sender, EventArgs e)
        {
            txtColorCode.Text = string.Empty;
            ResetAddColor();

            var listBinding = new BindingList<BasicColor>(Utility.GetColors());
            gvColors.DataSource = listBinding;
        }

        private void btnAddColor_Click(object sender, EventArgs e)
        {
            var listColors = (BindingList<BasicColor>)gvColors.DataSource;

            if (string.IsNullOrWhiteSpace(txtColorCode.Text))
            {
                MessageBox.Show("Name is mandatory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (listColors.Where(c => c.name == txtColorCode.Text.Trim()).Any())
            {
                MessageBox.Show("Name already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var newColor = new BasicColor
            {
                name = txtColorCode.Text.ToString(),
                r = (int)numR.Value,
                g = (int)numG.Value,
                b = (int)numB.Value
            };

            listColors.Add(newColor);
            Utility.UpdateColors(listColors.ToList());
            ResetAddColor();
        }

        private void ResetAddColor()
        {
            txtColorCode.Text = string.Empty;
            numR.Value = 0;
            numG.Value = 0;
            numB.Value = 0;
        }
                
        #endregion

        #region License Tab

        private void tabLicense_Enter(object sender, EventArgs e)
        {
            txtUniqueId.Text = licenseManager.GetMachineUniqueId().ToString();
            txtKey.Text = Utility.GetAppSetting("LicenseKey");
            LicenseStatus keyStatus = licenseManager.GetKeyStatus(txtKey.Text);
            FormatLicenseStatus(keyStatus);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            LicenseStatus status = LicenseStatus.NotAvailable;
            string key = txtKey.Text;
            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Please enter the license key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                status = licenseManager.GetKeyStatus(key);

                if (status == LicenseStatus.Valid)
                {
                    Utility.SaveAppSetting("LicenseKey", key);
                }
            }

            FormatLicenseStatus(status);
        }

        private void FormatLicenseStatus(LicenseStatus keyStatus)
        {
            lblLicenseStatus.Text = keyStatus.ToString("g");

            if (keyStatus == LicenseStatus.Valid)
                lblLicenseStatus.ForeColor = Color.Green;
            else
                lblLicenseStatus.ForeColor = Color.Red;

        }
        
        #endregion
    }
}
