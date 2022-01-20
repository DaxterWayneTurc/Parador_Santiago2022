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
    public partial class Frm_Mesas : MetroForm
    {
        public Frm_Mesas()
        {
            InitializeComponent();
           
        }

        private void Frm_Mesas_Load(object sender, EventArgs e)
        {

            string t1 = (from x in linq.Color_states where x.Id==1 && x.IdEstado==1 select x.IdEstado).FirstOrDefault().ToString();

            if (t1.ToString()=="1")
            {

                label1.ForeColor = Color.Red;

            }
            else 
            {
                label1.ForeColor = Color.MediumSeaGreen;
            }

            string t2 = (from x in linq.Color_states where x.Id == 2 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t2.ToString() == "1")
            {

                label2.ForeColor = Color.Red;

            }
            else
            {
                label2.ForeColor = Color.MediumSeaGreen;
            }

            string t3 = (from x in linq.Color_states where x.Id == 3 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t3.ToString() == "1")
            {

                label3.ForeColor = Color.Red;

            }
            else
            {
                label3.ForeColor = Color.MediumSeaGreen;
            }

            string t4 = (from x in linq.Color_states where x.Id == 4 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t4.ToString() == "1")
            {

                label4.ForeColor = Color.Red;

            }
            else
            {
                label4.ForeColor = Color.MediumSeaGreen;
            }


            string t5 = (from x in linq.Color_states where x.Id == 5 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t5.ToString() == "1")
            {

                label5.ForeColor = Color.Red;

            }
            else
            {
                label5.ForeColor = Color.MediumSeaGreen;
            }


            string t6 = (from x in linq.Color_states where x.Id == 6 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t6.ToString() == "1")
            {

                label6.ForeColor = Color.Red;

            }
            else
            {
                label6.ForeColor = Color.MediumSeaGreen;
            }



            string t7 = (from x in linq.Color_states where x.Id == 7 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t7.ToString() == "1")
            {

                label7.ForeColor = Color.Red;

            }
            else
            {
                label7.ForeColor = Color.MediumSeaGreen;
            }



            string t8 = (from x in linq.Color_states where x.Id == 8 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t8.ToString() == "1")
            {

                label8.ForeColor = Color.Red;

            }
            else
            {
                label8.ForeColor = Color.MediumSeaGreen;
            }




            string t9 = (from x in linq.Color_states where x.Id == 9 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t9.ToString() == "1")
            {

                label9.ForeColor = Color.Red;

            }
            else
            {
                label9.ForeColor = Color.MediumSeaGreen;
            }


            string t10 = (from x in linq.Color_states where x.Id == 10 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t10.ToString() == "1")
            {

                label10.ForeColor = Color.Red;

            }
            else
            {
                label10.ForeColor = Color.MediumSeaGreen;
            }


            string t11 = (from x in linq.Color_states where x.Id == 11 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t11.ToString() == "1")
            {

                label11.ForeColor = Color.Red;

            }
            else
            {
                label11.ForeColor = Color.MediumSeaGreen;
            }

            string t12 = (from x in linq.Color_states where x.Id == 12 && x.IdEstado == 1 select x.IdEstado).FirstOrDefault().ToString();

            if (t12.ToString() == "1")
            {

                label12.ForeColor = Color.Red;

            }
            else
            {
                label12.ForeColor = Color.MediumSeaGreen;
            }

          


        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        DatasqlDataContext linq = new DatasqlDataContext();
        private void btnMesa1_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string Get_table=(from x in linq.tblMesas where x.Id==1 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 1 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = Get_table;
            lblname.Text = Get_name;
            
        }

        private void btnMesa2_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string Get_table = (from x in linq.tblMesas where x.Id==2 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 2 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = Get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa3_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id==3 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 3 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text =get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa4_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id==4 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 4 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa5_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id == 5 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 5 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa6_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id == 6 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 6 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa7_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id == 7 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 7 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa8_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id == 8 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 8 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa9_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id == 9 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 9 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa10_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id == 10 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 10 select x.Descripcion).FirstOrDefault().ToString();
            lblid.Text = get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa11_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id == 11 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 11 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = get_table;
            lblname.Text = Get_name;
        }

        private void btnMesa12_Click(object sender, EventArgs e)
        {
            btnOrden.Enabled = true;
            string get_table = (from x in linq.tblMesas where x.Id == 12 select x.Id).FirstOrDefault().ToString();
            string Get_name = (from x in linq.tblMesas where x.Id == 12 select x.Descripcion).FirstOrDefault().ToString();

            lblid.Text = get_table;
            lblname.Text = Get_name;
        }

        private void btnOrden_Click(object sender, EventArgs e)
        {

            FrmOrden getids = new FrmOrden(lblname.Text, lblid.Text);
            getids.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Parallevar pr = new Frm_Parallevar();
            pr.Show();
            this.Hide();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmPrincipal prin = new FrmPrincipal();
            prin.Show();
            this.Hide();
        }
    }
}
