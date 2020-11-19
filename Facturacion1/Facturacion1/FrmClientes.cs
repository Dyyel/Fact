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
    public partial class FrmClientes : Form
    {


        public Clientes clientes { get; set; }
        private Entities1 entities1 = new Entities1();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            ConsultarArticulos();
        }
        private void ConsultarArticulos()
        {
            DgvClientes.DataSource = entities1.Clientes.ToList();
        }

        private void consultarPorCriterio()
        {
            var cliente = from em in entities1.Clientes
                           where (em.IdCliente.ToString().StartsWith(TxtBuscador.Text) ||
                           em.NombreComercial.StartsWith(TxtBuscador.Text) ||
                           em.Cédula.StartsWith(TxtBuscador.Text) ||
                           em.Estado.StartsWith(TxtBuscador.Text)
                           )
                           select em;
            DgvClientes.DataSource = cliente.ToList();
        }



        private void FrmArticulos_Activated(object sender, EventArgs e)
        {
            ConsultarArticulos();
        }

        

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            FrmEdClientes frm = new FrmEdClientes();
            frm.ShowDialog();
        }

        private void DgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.DgvClientes.SelectedRows[0];
                Clientes clientes = new Clientes();
                clientes.IdCliente = Int32.Parse(row.Cells[0].Value.ToString());
                clientes.NombreComercial = row.Cells[1].Value.ToString();
                clientes.Cédula = row.Cells[2].Value.ToString();
                clientes.Estado = row.Cells[3].Value.ToString();
                FrmEdClientes fed = new FrmEdClientes();
                fed.clientes = clientes;
                fed.ShowDialog();
            }
            catch (Exception ex)
            {

                return;
            }
            
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
    }
}

