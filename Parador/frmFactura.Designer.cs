namespace Parador
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_refrescar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Parador.Factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 107);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(715, 345);
            this.reportViewer1.TabIndex = 0;
            // 
            // btn_refrescar
            // 
            this.btn_refrescar.Highlight = true;
            this.btn_refrescar.Location = new System.Drawing.Point(257, 63);
            this.btn_refrescar.Name = "btn_refrescar";
            this.btn_refrescar.Size = new System.Drawing.Size(212, 23);
            this.btn_refrescar.Style = MetroFramework.MetroColorStyle.Green;
            this.btn_refrescar.TabIndex = 1;
            this.btn_refrescar.Text = "Refrescar";
            this.btn_refrescar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn_refrescar.Click += new System.EventHandler(this.btn_refrescar_Click);
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.btn_refrescar);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmFactura";
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "frmFactura";
            this.Load += new System.EventHandler(this.frmFactura_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroButton btn_refrescar;
    }
}