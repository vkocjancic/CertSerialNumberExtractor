using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CertSerialNumberExtractor.Library.ViewModel {
    
    public class CertificateStore {

        #region Constructors

        public CertificateStore( StoreLocation storeLocation, string storeName ) {
            this.Id = storeLocation;
            this.Name = storeName;
        }

        #endregion

        #region Properties

        public StoreLocation Id { get; set; }
        public string Name { get; set; }

        #endregion

        #region Static methods

        public static List<CertificateStore> GetAll() {
            var collection = new List<CertificateStore>();
            collection.Add( new CertificateStore( StoreLocation.CurrentUser, "Current user" ) );
            collection.Add( new CertificateStore( StoreLocation.LocalMachine, "Local machine" ) );
            return collection;
        }

        #endregion

    }

}
