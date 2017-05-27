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
        public enum LicenseStatus
        {
            Valid,
            Expired,
            Invalid,
            Corrupted,
            NotAvailable,
            Unknown
        }

        const string numaricChars = "HJKMNPRSTZ";

        const string seperationChars = "VWXYUL"; 

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
            string rawKey = GetRawKey(machineUniqueId, expiryDate);

            string encryptedKey = Encrypt(rawKey);

            return encryptedKey;
        }

        public LicenseStatus GetKeyStatus(string key)
        {
            LicenseStatus keyStatus = LicenseStatus.Valid;


            if (string.IsNullOrWhiteSpace(key))
            {
                keyStatus = LicenseStatus.NotAvailable;
            }
            else
            {
                try
                {
                    string rawKey = Decrypt(key);

                    string[] keyData = rawKey.Split('|');

                    string keyMachineUniqueId = keyData[0];

                    string machineUniqueId = GetMachineUniqueId().ToString("X");

                    DateTime expiryDate = new DateTime(int.Parse(keyData[1]), int.Parse(keyData[2]), int.Parse(keyData[3]));

                    if (keyMachineUniqueId != machineUniqueId)
                        keyStatus = LicenseStatus.Invalid;
                    else if (expiryDate < DateTime.Today)
                        keyStatus = LicenseStatus.Expired;
                    else
                        keyStatus = LicenseStatus.Valid;
                }
                catch
                {
                    keyStatus = LicenseStatus.Corrupted;
                }
            }
            return keyStatus;
        }

        public string GetRawKey(int machineUniqueId, DateTime expiryDate)
        {
            string expiryDateStr = expiryDate.ToString("yyyy|MM|dd");

            string hexMachineId = machineUniqueId.ToString("X");

            string rawKey = hexMachineId + "|" + expiryDateStr;

            return rawKey;
        }

        private string Encrypt(string key)
        {
            Random rand = new Random(DateTime.Now.Millisecond);

            StringBuilder encryptedKey = new StringBuilder();

            int num;

            foreach (char c in key)
            {
                if (int.TryParse(c.ToString(), out num))
                {
                    encryptedKey.Append(numaricChars[num]);
                }
                else if (c == '|')
                {
                    encryptedKey.Append(seperationChars[rand.Next(0, 5)]);
                }
                else
                {
                    encryptedKey.Append(c);
                }
            }

            encryptedKey.Append(GetCheckSum(encryptedKey.ToString()));

            InsertSeperationChars(encryptedKey);

            string finalKey = encryptedKey.ToString();

            return finalKey;
        }

        public string Decrypt(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ApplicationException("Key is empty");

            key = key.ToUpper();

            key = key.Replace("-", "");

            Char checkSum = key.Last();

            key = key.Remove(key.Length - 1);

            if (checkSum != GetCheckSum(key))
                throw new ApplicationException("Key is corrupted");

            StringBuilder decryptedKey = new StringBuilder();

            foreach (char c in key)
            {
                if (numaricChars.Contains(c))
                {
                    decryptedKey.Append(numaricChars.IndexOf(c));
                }
                else if (seperationChars.Contains(c))
                {
                    decryptedKey.Append('|');
                }
                else
                {
                    decryptedKey.Append(c);
                }
            }

            return decryptedKey.ToString();
        }

        private char GetCheckSum(string key)
        {
            int charSum = 0;

            foreach (char c in key)
            {
                charSum += (int)c;
            }

            char keyChar = numaricChars[(charSum / key.Length) % 10];

            return keyChar;
        }

        private void InsertSeperationChars(StringBuilder key)
        {
            key.Insert(16, "-");
            key.Insert(12, "-");
            key.Insert(8, "-");
            key.Insert(4, "-");
        }

    }
}
