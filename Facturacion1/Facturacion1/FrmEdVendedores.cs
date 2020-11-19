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
    public partial class FrmEdVendedores : Form
    {
        public vendedores vendedores { get; set; }
        private Entities1 entities1 = new Entities1();

        public FrmEdVendedores()
        {
            InitializeComponent();
        }

       private void FrmEdVendedores_Load(object sender, EventArgs e)
        {
            if (vendedores != null)
            {
                TxtId.Text = vendedores.IdVendedores.ToString();
                TxtNombre.Text = vendedores.Nombre;
                TxtP.Text = vendedores.PorcientoComision.ToString();
                CbEstado.Text = vendedores.Estado;
            }
        }

     

        private void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
   vendedores vendedores = entities1.vendedores.Find(Int32.Parse(TxtId.Text));
            if (vendedores != null)
            {
                entities1.vendedores.Remove(vendedores);
                entities1.SaveChanges();
                MessageBox.Show("Vendedor eliminado con éxito");

            }
            else
                MessageBox.Show("Vendedor no existente");
            this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar");
                return;
            }
         
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (TxtNombre.Text == "" || TxtP.Text == "" || CbEstado.Text == "" || TxtId.Text != "")
            {
                MessageBox.Show("Datos no validos");
            }
            else
            {
                entities1.vendedores.Add(new vendedores
                {
                    Nombre = TxtNombre.Text,
                    PorcientoComision = decimal.Parse(TxtP.Text),
                    Estado = CbEstado.Text
                });
                entities1.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
                this.Close();
            }
            
        }

        private void TxtP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }
    }
}
