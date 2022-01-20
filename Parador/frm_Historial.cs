using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace Parador
{
    public partial class frm_Historial : MetroForm
    {
        public frm_Historial()
        {
            InitializeComponent();
        }

        private void frm_Historial_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parador_SanTiagoDataSet.Vista_Historial' Puede moverla o quitarla según sea necesario.
            this.vista_HistorialTableAdapter.Fill(this.parador_SanTiagoDataSet.Vista_Historial);

        }

        private void dgv_Historial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
    }
}
