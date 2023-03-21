using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace SamplePrj_CSharp
{
    public class ChartNavCryptoProvider
    {
        private DESCryptoServiceProvider _cryptoProvider;
        private byte[] _iv = new byte[] { 0x1A, 0x2B, 0x3C, 0xD4, 0xE5, 0xF6, 0xA7, 0xB8 };
        private byte[] _key = Encoding.UTF8.GetBytes("%w@h(x7$");

        public ChartNavCryptoProvider()
        {
            _cryptoProvider = new DESCryptoServiceProvider();
        }

        public static void Main()
        {
            ChartNavCryptoProvider chartNavCryptoProvider = new ChartNavCryptoProvider();
            //chartNavCryptoProvider.Encrypt("Data Source=HRPINTDBS100;Initial Catalog=HRPClientGlobal;Integrated Security=SSPI;MultipleActiveResultSets=True");
            var decrypt = chartNavCryptoProvider.Decrypt("15l4E+Jm8YYyODqHzPj54swJZz70B+Gi/tmA0cS/SCSElix6O1xSx5oFlxQo8HKZHe++HBvWupKE/Ew2SGbZt5yYNuzV9oEStxGvHi+cRt8GMFUVJN2CyFGTvP5AxJCaVCZLnGvsm7Z3LJoptNOQmc88p1IPCfMfdSlmSn8i2pUdO5Pw0wFF4nQ4M/IEjA/z/IIW5RiI7zf0gUa1frPVKxfpY2cag/K4cZFvlS+rGuo=");
            Console.WriteLine(decrypt);

        }

        public string Encrypt(string plainText)
        {
            byte[] plainTextData = new System.Text.UTF8Encoding().GetBytes(plainText);

            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, _cryptoProvider.CreateEncryptor(_key, _iv), CryptoStreamMode.Write);
            cs.Write(plainTextData, 0, plainTextData.Length);
            cs.Close();

            byte[] encryptedData = ms.ToArray();

            var encrypted = Convert.ToBase64String(encryptedData);
            Console.WriteLine(encrypted);
            return encrypted;
        }

        public string Decrypt(string encryptedText)
        {
            byte[] encryptedData = Convert.FromBase64String(encryptedText);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, _cryptoProvider.CreateDecryptor(_key, _iv), CryptoStreamMode.Write);
            cs.Write(encryptedData, 0, encryptedData.Length);
            cs.Close();
            var decryptedText = Encoding.UTF8.GetString(ms.ToArray());
            Console.WriteLine(decryptedText);
            return decryptedText;
        }
    }
}
