using CertSerialNumberExtractor.Library.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;

namespace CertSerialNumberExtractor.Win {

    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
            InitializeControls();
        }

        #region Private methods

        private void InitializeControls() {
            cmbxCertificateStore.DataSource = CertificateStore.GetAll();
            gridCertificates.DataSource = Certificate.GetAllFromStore( (StoreLocation)cmbxCertificateStore.SelectedValue );
        }

        #endregion

        #region cmbxCertificateStore event handlers

        private void cmbxCertificateStore_SelectedIndexChanged( object sender, EventArgs e ) {
            gridCertificates.DataSource = Certificate.GetAllFromStore( (StoreLocation)cmbxCertificateStore.SelectedValue );
        }

        #endregion

        private void gridCertificates_CellMouseDown( object sender, DataGridViewCellMouseEventArgs e ) {
            if ( e.Button != MouseButtons.Right )
                return;
            gridCertificates.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
            ctxMenuSerialNumber.Show( gridCertificates, gridCertificates.PointToClient( Cursor.Position ) );
        }

        private void ctxMenuSerialNumber_ItemClicked( object sender, ToolStripItemClickedEventArgs e ) {
            Clipboard.SetText( gridCertificates.SelectedCells[0].Value as string );
        }
        
    }
}
