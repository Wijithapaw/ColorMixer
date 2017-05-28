using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer.KeyGen
{
    public partial class formKeyGen : Form
    {
        ColorMixer.Security.LicenseManager licenseManager = new ColorMixer.Security.LicenseManager();

        public formKeyGen()
        {
            InitializeComponent();
            dtExpiryDate.Value = DateTime.Today.AddYears(10);
        }

        private void formKeyGen_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int uniqueId = 0;
            if (int.TryParse(txtUniqueId.Text, out uniqueId))
            {
                txtLicenseKey.Text = licenseManager.GenerateKey(uniqueId, dtExpiryDate.Value);
            }
            else
            {
                MessageBox.Show("Enter unique ID", "Error");
            }
        }
    }
}
