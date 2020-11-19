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
    public partial class FrmArticulos : Form
    {

        public Articulos articulo { get; set; }
        private Entities1 entities1 = new Entities1();
        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            ConsultarArticulos();
        }

        private void ConsultarArticulos()
        {
            DgvArticulos.DataSource = entities1.Articulos.ToList();
        }

        private void consultarPorCriterio()
        {
            var articulo = from em in entities1.Articulos
                           where (em.idArticulo.ToString().StartsWith(TxtBuscador.Text) ||
                           em.Descripcion.StartsWith(TxtBuscador.Text) ||
                           em.Estado.StartsWith(TxtBuscador.Text)
                           )
                           select em;
            DgvArticulos.DataSource = articulo.ToList();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            consultarPorCriterio();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdArticulos frm = new FrmEdArticulos();
            frm.ShowDialog();
        }

        private void FrmArticulos_Activated(object sender, EventArgs e)
        {
            ConsultarArticulos();
        }

        private void DgvArticulos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.DgvArticulos.SelectedRows[0];
                Articulos articulo = new Articulos();
                articulo.idArticulo = Int32.Parse(row.Cells[0].Value.ToString());
                articulo.Descripcion = row.Cells[1].Value.ToString();
                articulo.Cantidad = Int32.Parse(row.Cells[2].Value.ToString());
                articulo.CostoUnitario = decimal.Parse(row.Cells[3].Value.ToString());
                articulo.PrecioUnitario = decimal.Parse(row.Cells[4].Value.ToString());
                articulo.Estado = row.Cells[5].Value.ToString();
                FrmEdArticulos fed = new FrmEdArticulos();
                fed.articulo = articulo;
                fed.ShowDialog();
            }
            catch (Exception ex)
            {
                return;
            }
           

        }
    }
}
