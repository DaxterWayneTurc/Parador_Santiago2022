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
    public partial class FrmOrden : MetroForm
    {
        public FrmOrden(string text, string id)
        {
            InitializeComponent();
            label3.Text = text;
            label2.Text = id;


            var menu = (from x in linq.Vista_Menu2 select x);
            dataGridView1.DataSource = menu;
            this.show_menuTableAdapter.Fill(this.parador_SanTiagoDataSet.show_menu, int.Parse(label2.Text));
            try
            {
                string get = (from x in linq.tblFacturas where x.IdMesa == int.Parse(label2.Text) && x.IdEstado == 1 select x.Nombre).FirstOrDefault().ToString();
                if (get == null)
                {
                    txtdescripcion.Text = "";
                }
                else
                {
                    txtdescripcion.Text = get.ToString();

                }

            }
            catch(Exception ex)
            {


            }
           

        }
        DatasqlDataContext linq = new DatasqlDataContext();
         
        private void FrmMenu_Load(object sender, EventArgs e)
        {
          

            this.reportViewer1.RefreshReport();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string product;
            string value;


                product = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                value = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            //listView1.Items.Add(product + "|Valor:" + value);


            string get = (from x in linq.tblMenu where x.Descripcion== dataGridView1.CurrentRow.Cells[0].Value.ToString() select x.Id).FirstOrDefault().ToString();

            //tblMesaOcupacion Umesa_ocupacion = new tblMesaOcupacion {
            //    IdMesa = int.Parse(label2.Text),
            //    FechaHoraInicio = DateTime.Now,
            //    Id_Estado=1

            //};

            tblFacturas Udetails = new tblFacturas
            {

               IdMesa = int.Parse(label2.Text),
               IdMenu = int.Parse(get.ToString()) ,
               Nombre = txtdescripcion.Text.ToString(),
                IdEstado=1


            };

            linq.tblFacturas.InsertOnSubmit(Udetails);
           linq.SubmitChanges();
            this.show_menuTableAdapter.Fill(this.parador_SanTiagoDataSet.show_menu, int.Parse(label2.Text));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        DatasqlDataContext dario = new DatasqlDataContext();

        private void button1_Click(object sender, EventArgs e)

        {
           

            this.FacturaTableAdapter.Fill(parador_SanTiagoDataSet.Factura, int.Parse(label2.Text));


            this.reportViewer1.RefreshReport();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Frm_Mesas m = new Frm_Mesas();
            m.Show();
            this.Hide();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           



        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            //for (int i = listView1.SelectedIndices.Count - 1; i >= 0; i--)
            //{


            //    listView1.Items.RemoveAt(listView1.SelectedIndices[i]);
            //}
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
                
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            var validCustomers = from c in linq.tblFacturas
                                 where c.IdMesa == int.Parse(label2.Text.ToString())
                                 select c;
            foreach (tblFacturas cust in validCustomers)
            {
                cust.IdEstado = 4;
            }

            linq.SubmitChanges();
            MessageBox.Show("se ha cancelado exitosamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            //tblFacturas book = linq.tblFacturas.Where(x => x.Id == int.Parse(label2.Text.ToString())).Single();


        }

        private void lblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string remove;
            remove = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            lblremove.Text = remove;

            var validCustomers = from c in linq.tblFacturas
                                 where c.IdMenu == int.Parse(remove.ToString())
                                 select c;
            //foreach (tblFacturas cust in validCustomers)
            //{
            //    cust.IdMenu = int.Parse(remove.ToString()) ;
            //}            //foreach (tblFacturas cust in validCustomers)
            //{
            //    cust.IdMenu = int.Parse(remove.ToString()) ;
            //}

            linq.tblFacturas.DeleteAllOnSubmit(validCustomers);
            linq.SubmitChanges();

            MessageBox.Show("Se ha eliminado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.show_menuTableAdapter.Fill(this.parador_SanTiagoDataSet.show_menu, int.Parse(label2.Text));



        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
