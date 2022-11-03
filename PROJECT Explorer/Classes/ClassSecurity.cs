using HAKROS.Forms;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace HAKROS.Classes
{
    static class ClassSecurity
    {

        static public bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        static public bool ExecuteAsAdmin()
        {
            try
            {
                var proc = new Process();
                proc.StartInfo.FileName = Application.ExecutablePath;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Verb = "runas";
                proc.Start();

                return true;

            }
            catch
            {
                //Error
            }

            return false;

        }

        static public bool InExecution()
        {
            var k = 0;
            try
            {
                var currentname = Assembly.GetExecutingAssembly().GetName().Name.ToLowerInvariant();
                var ps = Process.GetProcesses();
                foreach (var p in ps)
                {
                    var pname = p.ProcessName.ToLowerInvariant();
                    if (pname == currentname)
                    {
                        k += 1;
                    }
                }
            }
            catch
            {
                //Error!!
            }
            return (k >= 2);
        }

        static public bool CheckEula()
        {
            FrmLicense goLicense = new FrmLicense();
            if (goLicense.ShowDialog() == DialogResult.OK)
            {
                return true;
            }
            return false;
        }

        static public string GetMD5FromFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                using (var md5 = MD5.Create())
                {
                    using (var stream = File.OpenRead(filepath))
                    {
                        var hash = md5.ComputeHash(stream);
                        return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
                    }
                }
            }
            return "";
        }

        static public string GetHashNameForString(string input, int maxlon = 20)
        {
            var res = GetSHA256FromString(input);
            if (res != "" && res.Length > maxlon)
            {
                res = res.Substring(0, maxlon);
            }
            return res;
        }

        static private string GetSHA256FromString(string input)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }


        static public string GetSafePass(string input)
        {

            var res = "";
            try
            {
                var pass = GetSHA256FromString(input);

                res = AESEncryption.Encrypt(input, pass);

                if (res != "" && res.Length > 12)
                {
                    res = res.Substring(0, 12);
                }

                var w2 = res.Substring(1, 1);
                var w6 = res.Substring(5, 1);
                var w9 = res.Substring(8, 1);

                res = res.Replace(w2, "@");
                res = res.Replace(w6, "!");
                res = res.Replace(w9, "#");
            }
            catch (Exception)
            {
                //Error !!
            }
            return res;
        }

    }

    public static class AESEncryption
    {
        #region Static Functions

        /// <summary>
        /// Encrypts a string
        /// </summary>
        /// <param name="PlainText">Text to be encrypted</param>
        /// <param name="Password">Password to encrypt with</param>
        /// <param name="Salt">Salt to encrypt with</param>
        /// <param name="HashAlgorithm">Can be either SHA1 or MD5</param>
        /// <param name="PasswordIterations">Number of iterations to do</param>
        /// <param name="InitialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="KeySize">Can be 128, 192, or 256</param>
        /// <returns>An encrypted string</returns>
        public static string Encrypt(string PlainText, string Password, string Salt = "Kosher", string HashAlgorithm = "SHA1", int PasswordIterations = 2, string InitialVector = "OFRna73m*aze01xY", int KeySize = 256)
        {
            try
            {
                if (!string.IsNullOrEmpty(PlainText))
                {
                    byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
                    byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);
                    byte[] PlainTextBytes = Encoding.UTF8.GetBytes(PlainText);
                    PasswordDeriveBytes DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations);
                    byte[] KeyBytes = DerivedPassword.GetBytes(KeySize / 8);
                    RijndaelManaged SymmetricKey = new RijndaelManaged();
                    SymmetricKey.Mode = CipherMode.CBC;
                    byte[] CipherTextBytes = null;
                    using (ICryptoTransform Encryptor = SymmetricKey.CreateEncryptor(KeyBytes, InitialVectorBytes))
                    {
                        using (MemoryStream MemStream = new MemoryStream())
                        {
                            using (CryptoStream CryptoStream = new CryptoStream(MemStream, Encryptor, CryptoStreamMode.Write))
                            {
                                CryptoStream.Write(PlainTextBytes, 0, PlainTextBytes.Length);
                                CryptoStream.FlushFinalBlock();
                                CipherTextBytes = MemStream.ToArray();
                                MemStream.Close();
                                CryptoStream.Close();
                            }
                        }
                    }
                    SymmetricKey.Clear();
                    return Convert.ToBase64String(CipherTextBytes);
                }
            }
            catch
            {
                //Error !!
            }
            return "";
        }

        /// <summary>
        /// Decrypts a string
        /// </summary>
        /// <param name="CipherText">Text to be decrypted</param>
        /// <param name="Password">Password to decrypt with</param>
        /// <param name="Salt">Salt to decrypt with</param>
        /// <param name="HashAlgorithm">Can be either SHA1 or MD5</param>
        /// <param name="PasswordIterations">Number of iterations to do</param>
        /// <param name="InitialVector">Needs to be 16 ASCII characters long</param>
        /// <param name="KeySize">Can be 128, 192, or 256</param>
        /// <returns>A decrypted string</returns>
        public static string Decrypt(string CipherText, string Password, string Salt = "Kosher", string HashAlgorithm = "SHA1", int PasswordIterations = 2, string InitialVector = "OFRna73m*aze01xY", int KeySize = 256)
        {
            try
            {
                if (!string.IsNullOrEmpty(CipherText))
                {
                    byte[] InitialVectorBytes = Encoding.ASCII.GetBytes(InitialVector);
                    byte[] SaltValueBytes = Encoding.ASCII.GetBytes(Salt);
                    byte[] CipherTextBytes = Convert.FromBase64String(CipherText);
                    PasswordDeriveBytes DerivedPassword = new PasswordDeriveBytes(Password, SaltValueBytes, HashAlgorithm, PasswordIterations);
                    byte[] KeyBytes = DerivedPassword.GetBytes(KeySize / 8);
                    RijndaelManaged SymmetricKey = new RijndaelManaged();
                    SymmetricKey.Mode = CipherMode.CBC;
                    byte[] PlainTextBytes = new byte[CipherTextBytes.Length];
                    int ByteCount = 0;
                    using (ICryptoTransform Decryptor = SymmetricKey.CreateDecryptor(KeyBytes, InitialVectorBytes))
                    {
                        using (MemoryStream MemStream = new MemoryStream(CipherTextBytes))
                        {
                            using (CryptoStream CryptoStream = new CryptoStream(MemStream, Decryptor, CryptoStreamMode.Read))
                            {

                                ByteCount = CryptoStream.Read(PlainTextBytes, 0, PlainTextBytes.Length);
                                MemStream.Close();
                                CryptoStream.Close();
                            }
                        }
                    }
                    SymmetricKey.Clear();
                    return Encoding.UTF8.GetString(PlainTextBytes, 0, ByteCount);
                }
            }
            catch
            {
                //Error !!
            }
            return "";
        }

        #endregion
    }

}
