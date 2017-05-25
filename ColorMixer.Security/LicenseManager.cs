using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace ColorMixer.Security
{
    public class LicenseManager
    {
        const string PassPhrase = "m@zda";

        readonly char[] numaricChars = { 'H', 'J', 'K', 'M', 'N', 'P', 'R', 'S', 'T', 'Z' };

        readonly char[] seperationChars = { 'v', 'W', 'X', 'Y', 'U' };


        public LicenseManager()
        {

        }

        public int GetMachineUniqueId()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }

            string drive = "C";
            ManagementObject dsk = new ManagementObject(
                @"win32_logicaldisk.deviceid=""" + drive + @":""");
            dsk.Get();
            string volumeSerial = dsk["VolumeSerialNumber"].ToString();

            string uniqueId = cpuInfo + volumeSerial;

            int hashedUniqueId = Math.Abs(uniqueId.GetHashCode());

            return hashedUniqueId;
        }


        public string GenerateKey(int machineUniqueId, DateTime expiryDate)
        {
            string expiryDateStr = expiryDate.ToString("yyyy-MM-dd");

            string hexMachineId = machineUniqueId.ToString("X");

            string rawKey = hexMachineId + "|" + expiryDateStr;

            string encryptedKey = Encrypt(rawKey); // StringCipher.Encrypt(rawKey, PassPhrase);

            return encryptedKey;
        }

        private string Encrypt(string key)
        {
            Random rand = new Random(DateTime.Now.Millisecond);

            StringBuilder encryptedKey = new StringBuilder();

            foreach (char c in key)
            {
                if (c == '|' || c == '-')
                {
                    encryptedKey.Append(seperationChars[rand.Next(0, 4)]);
                }
                else
                {
                    encryptedKey.Append(numaricChars[int.Parse( c.ToString()]);
                }
            }
            return encryptedKey.ToString();
        }

    }
}
