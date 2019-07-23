using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Net.Security;
using System.IO;
using core.Services.CYSTP.Libs.Security.dotnet;

namespace core.CYSTP.Libs.Security.dotnet
{
    public class PasswordEncrypt: IPasswordEncrypt
    {
        private const int PasswordSaltSize = 8;
        private const int PasswordSaltLength = 12;      // Accounts for base64 overhead

        /// <summary>
        /// Hashes the specified password using a random password salt generated within the method.
        /// </summary>
        /// <param name="password">The password to hash.</param>
        /// <returns>The hash value of the password.</returns>
        public string HashPassword(string password)
        {
            if (String.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }

            // First generate a password salt using a cryptographic random number
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

            byte[] buffer = new byte[PasswordSaltSize];
            rng.GetBytes(buffer);

            string passwordSalt = Convert.ToBase64String(buffer);
            Debug.Assert(passwordSalt.Length == PasswordSaltLength);

            // Perform the hash of the password along with the generated salt
            return HashPassword(password, passwordSalt);
        }

        private static string HashPassword(string password, string passwordSalt)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(password + passwordSalt));
                StringBuilder sBuilder = new StringBuilder();
                foreach (byte b in hash)
                {
                    sBuilder.Append(b.ToString("X2"));


                }
                    string hash1 = sBuilder.ToString();
                    return hash1.ToUpper() + passwordSalt;
            }
        }

        /// <summary>
        /// Validates the specified password by comparing with to a previously computed hash value.
        /// </summary>
        /// <param name="password">The password to validate.</param>
        /// <param name="storedPasswordHash">The previously computed password hash to compare against.</param>
        /// <returns>true if the password is valid; false otherwise.</returns>
        public  bool ValidatePassword(string password, string storedPasswordHash)
        {
            if (String.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("password");
            }
            if (String.IsNullOrEmpty(storedPasswordHash))
            {
                throw new ArgumentNullException("storedPasswordHash");
            }

            try
            {
                // Extract the random password salt that was generated.
                string passwordSalt = storedPasswordHash.Substring(storedPasswordHash.Length - PasswordSaltLength);

                // Now take the password that is to be validated and hash it with the same salt,
                // and compare the two hashes.
                string passwordHash = HashPassword(password, passwordSalt);

                return (String.CompareOrdinal(passwordHash, storedPasswordHash) == 0);
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }

        /// <summary>
        /// 使用 AES 加密字串
        /// </summary>
        /// <param name="encryptString">要加密的字串</param>
        /// <param name="encryptKey">加密的Key</param>
        /// <param name="salt">間諜字串</param>
        /// <returns></returns>
        public string EncryptAES(string encryptString, string encryptKey, string salt)
        {
            AesManaged aes = null;
            MemoryStream ms = null;
            CryptoStream cs = null;

            try
            {
                Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(encryptKey, Encoding.UTF8.GetBytes(salt));

                aes = new AesManaged();
                aes.Key = rfc2898.GetBytes(aes.KeySize / 8);
                aes.IV = rfc2898.GetBytes(aes.BlockSize / 8);

                ms = new MemoryStream();
                cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write);

                byte[] data = Encoding.UTF8.GetBytes(encryptString);
                cs.Write(data, 0, data.Length);
                cs.FlushFinalBlock();

                return Convert.ToBase64String(ms.ToArray());
            }
            catch
            {
                return encryptString;
            }
            finally
            {
                if (cs != null)
                    cs.Close();

                if (ms != null)
                    ms.Close();

                if (aes != null)
                    aes.Clear();
            }
        }

        /// <summary>
        /// 使用 AES 解密字串
        /// </summary>
        /// <param name="decryptString">要解密的字串</param>
        /// <param name="decryptKey">解密的Key</param>
        /// <param name="salt">間諜字串</param>
        /// <returns></returns>
        public string DecryptAES(string decryptString, string decryptKey, string salt)
        {
            AesManaged aes = null;
            MemoryStream ms = null;
            CryptoStream cs = null;

            try
            {
                Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(decryptKey, Encoding.UTF8.GetBytes(salt));

                aes = new AesManaged();
                aes.Key = rfc2898.GetBytes(aes.KeySize / 8);
                aes.IV = rfc2898.GetBytes(aes.BlockSize / 8);

                ms = new MemoryStream();
                cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write);

                byte[] data = Convert.FromBase64String(decryptString);
                cs.Write(data, 0, data.Length);
                cs.FlushFinalBlock();
                if (cs != null)
                    cs.Close();

                if (ms != null)
                    ms.Close();

                if (aes != null)
                    aes.Clear();

                return Encoding.UTF8.GetString(ms.ToArray(), 0, ms.ToArray().Length);
            }
            catch
            {
                return null;
            }
        }

    }
}
