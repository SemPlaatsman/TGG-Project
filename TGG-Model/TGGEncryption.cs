using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Security.Cryptography;

namespace TGG_Model
{
    public class TGGEncryption
    {
        public string HashWithSalt(string password)
        {
            HashAlgorithm hashAlgo = SHA512.Create();
            byte[] saltBytes = this.GetSaltBytes();
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return Convert.ToBase64String(digestBytes);
        }

        private byte[] GenerateSalt(int saltLength)
        {
            RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[saltLength];
            rngCryptoServiceProvider.GetBytes(saltBytes);
            return saltBytes;
        }

        private byte[] GetSaltBytes()
        {
            byte[] saltBytes;
            // als er geen Salt aanwezig is, genereer een Salt. 
            if (ConfigurationManager.AppSettings["Salt"] == null)
            {
                saltBytes = this.GenerateSalt(64);
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Add("Salt", Convert.ToBase64String(saltBytes));
                config.Save(ConfigurationSaveMode.Modified);
            }
            else
            {
                saltBytes = Convert.FromBase64String(ConfigurationManager.AppSettings["Salt"]);
            }
            return saltBytes;
        }
    }
}
