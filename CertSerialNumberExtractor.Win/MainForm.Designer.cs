namespace CertSerialNumberExtractor.Win {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbxCertificateStore = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCertificates = new System.Windows.Forms.DataGridView();
            this.clmnIssuedTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chIssuedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxMenuSerialNumber = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miCopy = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridCertificates)).BeginInit();
            this.ctxMenuSerialNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbxCertificateStore
            // 
            this.cmbxCertificateStore.DisplayMember = "Name";
            this.cmbxCertificateStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCertificateStore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxCertificateStore.FormattingEnabled = true;
            this.cmbxCertificateStore.Location = new System.Drawing.Point(118, 9);
            this.cmbxCertificateStore.Name = "cmbxCertificateStore";
            this.cmbxCertificateStore.Size = new System.Drawing.Size(246, 25);
            this.cmbxCertificateStore.TabIndex = 0;
            this.cmbxCertificateStore.ValueMember = "Id";
            this.cmbxCertificateStore.SelectedIndexChanged += new System.EventHandler(this.cmbxCertificateStore_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Certificate store";
            // 
            // gridCertificates
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridCertificates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridCertificates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCertificates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnIssuedTo,
            this.chIssuedBy,
            this.clmnExpirationDate,
            this.clmnSerialNumber});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCertificates.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridCertificates.Location = new System.Drawing.Point(12, 44);
            this.gridCertificates.MultiSelect = false;
            this.gridCertificates.Name = "gridCertificates";
            this.gridCertificates.Size = new System.Drawing.Size(714, 376);
            this.gridCertificates.TabIndex = 2;
            this.gridCertificates.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridCertificates_CellMouseDown);
            // 
            // clmnIssuedTo
            // 
            this.clmnIssuedTo.DataPropertyName = "IssuedTo";
            this.clmnIssuedTo.HeaderText = "Issued To";
            this.clmnIssuedTo.Name = "clmnIssuedTo";
            this.clmnIssuedTo.ReadOnly = true;
            this.clmnIssuedTo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clmnIssuedTo.Width = 150;
            // 
            // chIssuedBy
            // 
            this.chIssuedBy.DataPropertyName = "IssuedBy";
            this.chIssuedBy.HeaderText = "Issued By";
            this.chIssuedBy.Name = "chIssuedBy";
            this.chIssuedBy.ReadOnly = true;
            this.chIssuedBy.Width = 150;
            // 
            // clmnExpirationDate
            // 
            this.clmnExpirationDate.DataPropertyName = "ExpirationDate";
            this.clmnExpirationDate.HeaderText = "Expiration Date";
            this.clmnExpirationDate.Name = "clmnExpirationDate";
            this.clmnExpirationDate.ReadOnly = true;
            this.clmnExpirationDate.Width = 120;
            // 
            // clmnSerialNumber
            // 
            this.clmnSerialNumber.DataPropertyName = "SerialNumber";
            this.clmnSerialNumber.HeaderText = "Serial Number";
            this.clmnSerialNumber.Name = "clmnSerialNumber";
            this.clmnSerialNumber.ReadOnly = true;
            this.clmnSerialNumber.Width = 250;
            // 
            // ctxMenuSerialNumber
            // 
            this.ctxMenuSerialNumber.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCopy});
            this.ctxMenuSerialNumber.Name = "ctxMenuSerialNumber";
            this.ctxMenuSerialNumber.Size = new System.Drawing.Size(145, 26);
            this.ctxMenuSerialNumber.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ctxMenuSerialNumber_ItemClicked);
            // 
            // miCopy
            // 
            this.miCopy.Name = "miCopy";
            this.miCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.miCopy.Size = new System.Drawing.Size(144, 22);
            this.miCopy.Text = "&Copy";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 432);
            this.Controls.Add(this.gridCertificates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxCertificateStore);
            this.Name = "MainForm";
            this.Text = "Certificate Serial Number Extractor";
            ((System.ComponentModel.ISupportInitialize)(this.gridCertificates)).EndInit();
            this.ctxMenuSerialNumber.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxCertificateStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridCertificates;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIssuedTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn chIssuedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSerialNumber;
        private System.Windows.Forms.ContextMenuStrip ctxMenuSerialNumber;
        private System.Windows.Forms.ToolStripMenuItem miCopy;
    }
}

