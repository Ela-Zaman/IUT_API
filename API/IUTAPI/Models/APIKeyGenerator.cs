using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace IUTAPI.Models
{
    public class APIKeyGenerator
    {
        public String genAPikey()
        {
            var cryptoProvider = new RNGCryptoServiceProvider();

            byte[] SecretKeybyteArray = new byte[32];
            cryptoProvider.GetBytes(SecretKeybyteArray);
            var ApiKy = Convert.ToBase64String(SecretKeybyteArray);
            return ApiKy.ToString();
        }
    }
}
