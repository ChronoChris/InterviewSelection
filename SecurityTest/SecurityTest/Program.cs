using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.Security.Authentication;
using System.IO;
using System.Diagnostics;

namespace SecurityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ///declaring data to be protected followed by getting the Bytes
            const string dataToProtect=  "This is the data I'm trying to protect";
            var dataToProtectAsArray = Encoding.Unicode.GetBytes(dataToProtect);

            #region File. Encrypt

            var fileName = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments), "MyDataFile.txt");
            //encryption
            File.WriteAllText(fileName, dataToProtect);
            //encryption just like windows does it!!!!!
            File.Encrypt(fileName);

            #endregion

            #region Windows Data Protection

            var wdpEncryptedData = ProtectedData.Protect(dataToProtectAsArray, null, DataProtectionScope.CurrentUser);
            var wdpUnEncrypted = ProtectedData.Unprotect(wdpEncryptedData, null, DataProtectionScope.CurrentUser);
            var wdpUnencryptedString = Encoding.Unicode.GetString(wdpUnEncrypted);

            Debug.Assert(dataToProtect.Equals(wdpUnencryptedString));

            #endregion

            #region Keys

            var privatekey = new byte[] { 24, 2, 89, 7, 1, 54, 12, 7, 24, 117, 9, 8, 17, 31, 51, 103 };

            var publickey = new byte[] { 9, 3, 1, 5, 72, 71, 5, 54, 112, 111, 14, 17, 28, 14, 15, 16 };

            byte[] symEncryptedData;
            var algorithm = Aes.Create();
            using (var encryptor = algorithm.CreateEncryptor(privatekey, publickey)) 
            using(var memoryStream = new MemoryStream())
            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        cryptoStream.Write(dataToProtectAsArray, 0, dataToProtectAsArray.Length);
                        cryptoStream.FlushFinalBlock();
                        symEncryptedData = memoryStream.ToArray();
                    }
            #endregion 
            
            #region Hashing
            var storedPasswordHash = new byte[]
                {
                    148, 152, 235, 251, 242, 51, 18, 100, 176, 51, 147, 37, 128, 175, 
                    164, 106, 204, 48, 47, 154, 75, 81, 83, 170, 110, 8, 107, 51, 13, 83, 2, 215
                };
            var password = Encoding.Unicode.GetBytes(dataToProtect);
            var passwordHash = SHA256.Create().ComputeHash(password);
            if (passwordHash.SequenceEqual(storedPasswordHash))
            {
                Console.WriteLine("success");
            }
            #endregion


        }
    }
}
