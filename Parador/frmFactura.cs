using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parador
{
    public partial class frmFactura :MetroFramework.Forms.MetroForm
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void btn_refrescar_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
