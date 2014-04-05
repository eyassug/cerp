// ReSharper disable CheckNamespace

using Apex.Common.Cryptography;

namespace System
// ReSharper restore CheckNamespace
{
    public static class StringExtensions
    {
        /// <summary>
        /// Removes single-quote (') character from string to protect against SQL-Injection attacks
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string Sanitise(this string s)
        {
            // TODO: Match string against a regex and remove all unnecessary characters
            if (s.Sanitised())
                return s;
            s = s.Replace('\'',' ');
            return s;
        }

        /// <summary>
        /// Checks whether the supplied string is safe or not
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool Sanitised(this string s)
        {
            // TODO: Match string against a regex
            return !s.Contains("'");
        }

        public static string Encrypt(this string s, HashAlgorithms hashAlgorithm)
        {
            var encryptionService = new EncryptionService(hashAlgorithm);
            return encryptionService.Encrypt(s);
        }
    }
}
