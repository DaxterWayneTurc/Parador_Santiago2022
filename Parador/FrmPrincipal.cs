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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_mesas_Click(object sender, EventArgs e)
        {
            Frm_Mesas mesas = new Frm_Mesas();
            mesas.Show();
            this.Hide();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();

            res = MessageBox.Show("¿Desea realmente cerrar sesion?", "La aplicacion se cerrara.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                Frm_login log = new Frm_login();
                log.Show();
                this.Hide();
            }
         
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Frm_Usuarios user = new Frm_Usuarios();
            user.Show();
            this.Hide();
        }

        private void btn_cierrecaja_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            Frm_AdminMenu user = new Frm_AdminMenu();
            user.Show();
            this.Hide();
        }
    }
}
