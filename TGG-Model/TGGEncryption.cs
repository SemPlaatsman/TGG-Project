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
        //hash password with salt
        public string HashWithSalt(string password)
        {
            //get hashing algorithm
            HashAlgorithm hashAlgo = SHA512.Create();
            //get salt bytes and password bytes
            byte[] saltBytes = this.GetSaltBytes();
            byte[] passwordAsBytes = Encoding.UTF8.GetBytes(password);
            //add password bytes and salt bytes together
            List<byte> passwordWithSaltBytes = new List<byte>();
            passwordWithSaltBytes.AddRange(passwordAsBytes);
            passwordWithSaltBytes.AddRange(saltBytes);
            //compute hash with hashing algorithm to bytes and return as string
            byte[] digestBytes = hashAlgo.ComputeHash(passwordWithSaltBytes.ToArray());
            return Convert.ToBase64String(digestBytes);
        }

        //generate salt with rng crypto service provider
        private byte[] GenerateSalt(int saltLength)
        {
            RNGCryptoServiceProvider rngCryptoServiceProvider = new RNGCryptoServiceProvider();
            byte[] saltBytes = new byte[saltLength];
            rngCryptoServiceProvider.GetBytes(saltBytes);
            return saltBytes;
        }

        //get salt bytes from app.config
        private byte[] GetSaltBytes()
        {
            byte[] saltBytes;
            //if no salt is present, generate a new salt and add it to app.config
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
