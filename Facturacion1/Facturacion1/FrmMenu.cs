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
    public partial class FrmMenuAdmin : Form
    {
        public FrmMenuAdmin()
        {
            InitializeComponent();
        }

        private void atrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticulos frmArticulo = new FrmArticulos();
            frmArticulo.ShowDialog();        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes();
            frmClientes.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendedores frmVendedores = new FrmVendedores();
            frmVendedores.ShowDialog();
        }

        private void condicionDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCondicionPago FrmCondicionPago = new FrmCondicionPago();
            FrmCondicionPago.ShowDialog();
        }
    }
}
