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
    public partial class Frm_Parallevar : MetroForm
    {
        public Frm_Parallevar()
        {
            InitializeComponent();
        }

        private void Frm_Parallevar_Load(object sender, EventArgs e)
        {
            this.tblMenuTableAdapter.Fill(this.parador_SanTiagoDataSet.tblMenu);
            var data = (from x in linq.tblCliente select x);
            dgv_Cliente.DataSource = data;
            Random r = new Random();
            txtName.Text = r.Next(10, 401).ToString();
            tblCliente Udetails = new tblCliente
            {


                IdCliente = int.Parse(txtName.Text),



        };
           
            linq.tblCliente.InsertOnSubmit(Udetails);
            linq.SubmitChanges();
            txtName.Text = /*Udetails.IdCliente.ToString() */ Udetails.Id.ToString();
            label1.Text = DateTime.Today.Day.ToString();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();

        }

        DatasqlDataContext linq = new DatasqlDataContext();
        private void dgv_menu2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string product;
            string value;


            product = dgv_menu2.CurrentRow.Cells[0].Value.ToString();
            label3.Text = dgv_menu2.CurrentRow.Cells[0].Value.ToString();
            value =dgv_menu2.CurrentRow.Cells[1].Value.ToString();

            //listView1.Items.Add(product + "|Valor:" + value);


            string get = (from x in linq.tblMenu where x.Descripcion == dgv_menu2.CurrentRow.Cells[0].Value.ToString() select x.Id).FirstOrDefault().ToString();

            //tblMesaOcupacion Umesa_ocupacion = new tblMesaOcupacion {
            //    IdMesa = int.Parse(label2.Text),
            //    FechaHoraInicio = DateTime.Now,
            //    Id_Estado=1

            //};
           

            tbl_FechaClientes Udetails = new tbl_FechaClientes
            {

                IdCliente = int.Parse(txtName.Text),
                IdMenu = int.Parse(dgv_menu2.CurrentRow.Cells[0].Value.ToString()),
                Fecha = 19.ToString(),
                IdEstado = 1


            };
     
            linq.tbl_FechaClientes.InsertOnSubmit(Udetails);
            linq.SubmitChanges();

            this.dtg_Orden2.Rows.Add(dgv_menu2.CurrentRow.Cells[1].Value.ToString(), "descripcion");
        }

        private void dtg_Orden2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

   
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(txtName.Text.ToString());
            
            this.factura_llevarTableAdapter.Fill(parador_SanTiagoDataSet.factura_llevar,val,""+19);

       
            this.reportViewer1.RefreshReport();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

            var lin = (from x in linq.Search(txtBuscar.Text.ToString()) select x).ToList();
           dgv_menu2.DataSource = lin;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            tblCliente Udetails = new tblCliente
            {

                
               IdCliente =int.Parse(r.Next(10, 401).ToString())


            };

            linq.tblCliente.InsertOnSubmit(Udetails);
            linq.SubmitChanges();
            var data = (from x in linq.tblCliente select x);
            dgv_Cliente.DataSource = data;

        }

        private void dgv_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
