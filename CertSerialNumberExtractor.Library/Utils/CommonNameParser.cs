using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CertSerialNumberExtractor.Library.Utils {
    
    internal class CommonNameParser {

        #region Static methods

        public static string GetSimpleName( string fqdn ) {
            var name = GetPart( fqdn, "CN=", "," );
            if ( null != name )
                return name;
            name = GetPart( fqdn, "O=", "," );
            if ( null != name )
                return name;
            return fqdn;
        }

        private static string GetPart( string src, string part, string separator ) {
            var startLocation = src.IndexOf( part );
            if ( startLocation == -1 )
                return null;
            startLocation += part.Length;
            var separatorLocation = src.IndexOf( separator, startLocation );
            if ( separatorLocation == -1 )
                return src.Substring( startLocation );
            return src.Substring( startLocation, separatorLocation - startLocation );
        }

        #endregion

    }

}
