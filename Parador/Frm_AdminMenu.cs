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
    public partial class Frm_AdminMenu : MetroForm
    {
        public Frm_AdminMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Administrar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'parador_SanTiagoDataSet.tblMenu' Puede moverla o quitarla según sea necesario.
            this.tblMenuTableAdapter.Fill(this.parador_SanTiagoDataSet.tblMenu);

            Dictionary<int, string> test = new Dictionary<int, string>();
            test.Add(0, "Inactivo");
            test.Add(1, "Activo");
           
            cbx_Estado.DataSource = new BindingSource(test, null);
            cbx_Estado.DisplayMember = "Value";
            cbx_Estado.ValueMember = "Key";

            // Get combobox selection (in handler)
            string value = ((KeyValuePair<int, string>)cbx_Estado.SelectedItem).Value;

        }

        DatasqlDataContext linq = new DatasqlDataContext();
        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            tblMenu Umenu = new tblMenu
            {
                Descripcion = txtDescripcion.Text,
                Valor = decimal.Parse(txtValor.Text.Trim()),
                Estado =int.Parse(cbx_Estado.SelectedValue.ToString()),
               


            };

            linq.tblMenu.InsertOnSubmit(Umenu);
            linq.SubmitChanges();
            MessageBox.Show("Se han insertado los datos correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tblMenuTableAdapter.Fill(this.parador_SanTiagoDataSet.tblMenu);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            tblMenu shut = linq.tblMenu.Where(x => x.Id == int.Parse(txtlabel.Text.ToString())).Single();
           linq.tblMenu.DeleteOnSubmit(shut);
            linq.SubmitChanges();
            MessageBox.Show("Se ha eliminado correctamente", "!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tblMenuTableAdapter.Fill(this.parador_SanTiagoDataSet.tblMenu);
        }


        private void dgv_Menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string product;
         


            product = dgv_Menu.CurrentRow.Cells[0].Value.ToString();
            txtlabel.Text= product.ToString();
          
        }

        private void dgv_Menu_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // DataGridViewRow row = dgv_Menu.Rows[e.RowIndex];
            
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            try
            {
                var userid = (from x in linq.tblMenu where x.Id == int.Parse(txtlabel.Text.ToString()) select x).ToList();

                txtDescripcion.Text = (from x in userid select x.Descripcion).FirstOrDefault().ToString();
                txtValor.Text = (from x in userid select x.Valor).FirstOrDefault().ToString();
                cbx_Estado.Text = (from x in userid select x.Estado).FirstOrDefault().ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error", "!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
            
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            tblMenu book = linq.tblMenu.Where(x => x.Id == int.Parse(txtlabel.Text)).Single();
            book.Descripcion = txtDescripcion.Text.Trim();
            book.Valor =decimal.Parse( txtValor.Text.Trim());
            book.Estado =int.Parse( cbx_Estado.SelectedValue.ToString());
           linq.SubmitChanges();
            MessageBox.Show("se ha editado corextamente", "muy bien", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.tblMenuTableAdapter.Fill(this.parador_SanTiagoDataSet.tblMenu);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmPrincipal prin = new FrmPrincipal();
            prin.Show();
            this.Hide();
        }
    }
}
