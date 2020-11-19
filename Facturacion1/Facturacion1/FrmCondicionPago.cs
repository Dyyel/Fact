using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion1
{
    public partial class FrmCondicionPago : Form
    {
        public CondicionPago pago { get; set; }
        private Entities1 entities1 = new Entities1();

        public FrmCondicionPago()
        {
            InitializeComponent();
        }

        private void FrmCondicionPago_Load(object sender, EventArgs e)
        {
            ConsultarCondicionPago();
        }
        private void ConsultarCondicionPago()
        {
            DgvCondicionPago.DataSource = entities1.CondicionPago.ToList();
        }
        private void consultarPorCriterio()
        {
            var pago = from em in entities1.CondicionPago
                           where (em.IdCondicionPago.ToString().StartsWith(TxtBuscador.Text) ||
                           em.Descripcion.StartsWith(TxtBuscador.Text) ||
                           em.Estado.StartsWith(TxtBuscador.Text)
                           )
                           select em;
            DgvCondicionPago.DataSource = pago.ToList();
        }
        private void FrmArticulos_Activated(object sender, EventArgs e)
        {
            ConsultarCondicionPago();
        }
        private void DgvCondicionPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            FrmEdCondicionPago frm = new FrmEdCondicionPago();
            frm.ShowDialog();
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void FrmCondicionPago_Activated(object sender, EventArgs e)
        {
            ConsultarCondicionPago();
        }

        private void DgvCondicionPago_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void DgvCondicionPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.DgvCondicionPago.SelectedRows[0];
                CondicionPago pago = new CondicionPago();
                pago.IdCondicionPago = Int32.Parse(row.Cells[0].Value.ToString());
                pago.Descripcion = row.Cells[1].Value.ToString();
                pago.CantidadDias = Int32.Parse(row.Cells[2].Value.ToString());
                pago.Estado = row.Cells[3].Value.ToString();
                FrmEdCondicionPago fed = new FrmEdCondicionPago();
                fed.pago = pago;
                fed.ShowDialog();
            }
            catch (Exception ex)
            {

                return;
            }
            
        }
    }
}
