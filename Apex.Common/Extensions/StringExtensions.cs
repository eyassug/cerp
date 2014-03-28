using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System
{
    public static class StringExtensions
    {
        
        public static string Sanitise(this string unsanitisedString)
        {
            if (unsanitisedString.Sanitised())
                return unsanitisedString;
            unsanitisedString = unsanitisedString.Replace('\'',' ');
            return unsanitisedString;
        }

        public static bool Sanitised(this string unsanitisedString)
        {
            // TODO: Match string against a regex
            return !unsanitisedString.Contains("'");
        }
    }
}
