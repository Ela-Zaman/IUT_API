using System;
using System.Security.Cryptography;

namespace IUTAPI.Services
{
    public class APIKeyGenerator
    {
        public string GenerateAPikey()
        {
            using (var cryptoProvider = new RNGCryptoServiceProvider())
            {
                byte[] SecretKeybyteArray = new byte[32];
                cryptoProvider.GetBytes(SecretKeybyteArray);
                var ApiKy = Convert.ToBase64String(SecretKeybyteArray);
                return ApiKy.ToString();
            }
        }
    }
}
