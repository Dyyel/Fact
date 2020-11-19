using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion1
{
    public partial class FrmVendedores : Form
    {
         


        public vendedores vendedores { get; set; }
        private Entities1 entities1 = new Entities1();
        public FrmVendedores()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ConsultarArticulos();
        }
        private void ConsultarArticulos()
        {
            DgvVendedores.DataSource = entities1.vendedores.ToList();
        }

        private void consultarPorCriterio()
        {
            var vendedores = from em in entities1.vendedores
                           where (em.IdVendedores.ToString().StartsWith(TxtBuscador.Text) ||
                           em.Nombre.StartsWith(TxtBuscador.Text) ||
                           em.Estado.StartsWith(TxtBuscador.Text)
                           )
                           select em;
            DgvVendedores.DataSource = vendedores.ToList();
        }



        private void FrmArticulos_Activated(object sender, EventArgs e)
        {
            ConsultarArticulos();
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void FrmClientes_Activated(object sender, EventArgs e)
        {
            ConsultarArticulos();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgvVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    DataGridViewRow row = this.DgvVendedores.SelectedRows[0];
                    vendedores vendedores = new vendedores();
                    vendedores.IdVendedores = Int32.Parse(row.Cells[0].Value.ToString());
                    vendedores.Nombre = row.Cells[1].Value.ToString();
                    //vendedores.PorcientoComision = row.Cells[2];
                    vendedores.Estado = row.Cells[3].Value.ToString();
                    FrmEdVendedores fed = new FrmEdVendedores();
                    fed.vendedores = vendedores;
                    fed.ShowDialog();
                }
                catch (Exception ex)
                {

                    return;
                }
                
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdVendedores frm = new FrmEdVendedores();
            frm.ShowDialog();
        }

        private void FrmVendedores_Activated(object sender, EventArgs e)
        {
            ConsultarArticulos();
        }
    }
       

    
    }

