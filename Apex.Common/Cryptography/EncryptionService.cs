using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Apex.Common.Cryptography
{
    public class EncryptionService
    {
        private readonly HashAlgorithms _hashAlgorithm;

        public EncryptionService(HashAlgorithms hashAlgorithm)
        {
            _hashAlgorithm = hashAlgorithm;
        }

        public string Encrypt(string rawString)
        {
            switch (_hashAlgorithm)
            {
                case HashAlgorithms.SHA1:
                    return Sha1Hash(rawString);
                case HashAlgorithms.SHA256:
                    return Sha256Hash(rawString);
                case HashAlgorithms.SHA384:
                    return Sha384Hash(rawString);
                case HashAlgorithms.SHA512:
                    return Sha512Hash(rawString);
            }
            return null;
        }

        #region Hash Helper Methods

        private string Sha1Hash(string rawString)
        {
            var rawStringBytes = Encoding.Unicode.GetBytes(rawString);
            var hashProvider = new SHA1Managed();
            hashProvider.Initialize();
            rawStringBytes = hashProvider.ComputeHash(rawStringBytes);
            hashProvider.Clear();
            return Convert.ToBase64String(rawStringBytes);
        }

        private string Sha256Hash(string rawString)
        {
            var rawStringBytes = Encoding.Unicode.GetBytes(rawString);
            var hashProvider = new SHA256Managed();
            hashProvider.Initialize();
            rawStringBytes = hashProvider.ComputeHash(rawStringBytes);
            hashProvider.Clear();
            return Convert.ToBase64String(rawStringBytes);
        }

        private string Sha384Hash(string rawString)
        {
            var rawStringBytes = Encoding.Unicode.GetBytes(rawString);
            var hashProvider = new SHA384Managed();
            hashProvider.Initialize();
            rawStringBytes = hashProvider.ComputeHash(rawStringBytes);
            hashProvider.Clear();
            return Convert.ToBase64String(rawStringBytes);
        }

        private string Sha512Hash(string rawString)
        {
            var rawStringBytes = Encoding.Unicode.GetBytes(rawString);
            var hashProvider = new SHA512Managed();
            hashProvider.Initialize();
            rawStringBytes = hashProvider.ComputeHash(rawStringBytes);
            hashProvider.Clear();
            return Convert.ToBase64String(rawStringBytes);
        }
        #endregion
    }
}
