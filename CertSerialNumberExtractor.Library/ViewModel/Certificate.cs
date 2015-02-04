using CertSerialNumberExtractor.Library.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CertSerialNumberExtractor.Library.ViewModel {
    
    public class Certificate {

        #region Properties

        public string ExpirationDate { get; set; }
        public string IssuedTo { get; set; }
        public string IssuedBy { get; set; }
        public string SerialNumber { get; set; }

        #endregion

        #region Static methods

        public static List<Certificate> GetAllFromStore(StoreLocation location) {
            var certificates = new List<Certificate>();
            var store = new X509Store( location );
            store.Open( OpenFlags.ReadOnly );
            foreach ( var cert in store.Certificates ) {
                certificates.Add( Certificate.CreateFromX509Certificate( cert ) );
            }
            return certificates;
        }

        private static Certificate CreateFromX509Certificate( X509Certificate2 cert ) {
            var certVM = new Certificate();
            certVM.ExpirationDate = cert.GetExpirationDateString();
            certVM.IssuedBy = CommonNameParser.GetSimpleName( cert.IssuerName.Name );
            certVM.IssuedTo = CommonNameParser.GetSimpleName( cert.SubjectName.Name );
            certVM.SerialNumber = cert.SerialNumber;
            return certVM;
        }

        #endregion

    }

}
