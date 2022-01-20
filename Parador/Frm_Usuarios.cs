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
    public partial class Frm_Usuarios : MetroForm 
    {
       
        public Frm_Usuarios()
        {
            
            InitializeComponent();
        }


        DatasqlDataContext data = new DatasqlDataContext();
        private void FrmCaja_Load(object sender, EventArgs e)
        {

            var H = ( from x in data.tblUsuarios select x).ToList();
            metroComboBox1.DisplayMember = "Nombre";
            metroComboBox1.ValueMember = "id";
            metroComboBox1.DataSource = H;


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmPrincipal prin = new FrmPrincipal();
            prin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         var userid = (from x in data.tblUsuarios where x.Id==int.Parse(metroComboBox1.SelectedValue.ToString()) select x).ToList();

            txtNombre.Text = (from x in userid select x.Nombre).FirstOrDefault().ToString();
            cbUsuarios.Text = (from x in userid select x.Usuario).FirstOrDefault().ToString();
            txtContra.Text = (from x in userid select x.Clave).FirstOrDefault().ToString();
        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           tblUsuarios Udetails = new tblUsuarios
            {

                Nombre= txtNombre.Text.Trim(),
                Usuario =cbUsuarios.Text.Trim(),
               Clave = txtContra.Text.Trim(),
               

            };

            data.tblUsuarios.InsertOnSubmit(Udetails);
            data.SubmitChanges();

            MessageBox.Show("Se ha agregado con exito", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tblUsuarios book = data.tblUsuarios.Where(x => x.Id == int.Parse(metroComboBox1.SelectedValue.ToString())).Single();
            book.Nombre = txtNombre.Text.Trim();
            book.Usuario = cbUsuarios.Text.Trim();
            book.Clave = txtContra.Text.Trim();
           data.SubmitChanges();
            MessageBox.Show("se ha editado corextamente", "muy bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
          tblUsuarios shut = data.tblUsuarios.Where(x => x.Id == int.Parse(metroComboBox1.SelectedValue.ToString())).Single();
            data.tblUsuarios.DeleteOnSubmit(shut);
           data.SubmitChanges();
            MessageBox.Show("Se ha eliminado correctamente", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
