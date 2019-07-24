using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core.Services.CYSTP.Libs.Security.dotnet
{
    public interface IPasswordEncrypt
    {
        bool ValidatePassword(string password, string storedPasswordHash);
        string EncryptAES(string encryptString, string encryptKey, string salt);
        string DecryptAES(string decryptString, string decryptKey, string salt);
        string HashPassword(string password);

    }
}
