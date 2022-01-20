using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using MetroFramework.Forms;
namespace Parador
{
    public partial class Frm_login : MetroForm
    {
        //string cnn = Conexion.cnn;
        public Frm_login()
        {
            InitializeComponent();
        }

        public void Logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                
                using (SqlConnection conexion = new SqlConnection(cnn))
                
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT Usuario, Clave FROM tblUsuarios WHERE Usuario='" + txtUsuario.Text + "'AND Clave='" + txtContra.Text + "'",conexion))
                      
                    {
                        
                        SqlDataReader dr = cmd.ExecuteReader();
                        
                        if (dr.Read())
                        {
                            MessageBox.Show("Se ha ingresado correctamente");
                            FrmPrincipal prin = new FrmPrincipal();
                            prin.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos");
                        }

                       
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Logins();
        }

        private void Frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();

            res = MessageBox.Show("¿Desea realmente salir de la aplicacion?", "La aplicacion se cerrara.",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
