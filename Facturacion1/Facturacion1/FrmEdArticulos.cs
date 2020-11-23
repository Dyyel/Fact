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
    public partial class FrmEdArticulos : Form
    {
        public Articulos articulo { get; set; }
        private Entities1 entities1 = new Entities1();
        public FrmEdArticulos()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

            if (TxtCantidad.Text == "" || TxtCosto.Text == "" || TxtDescripcion.Text == "" || TxtPrecio.Text == "" || CbEstado.Text == "" || TxtId.Text != "")
            {
                MessageBox.Show("Datos no validos");
            }
            else
            {
                entities1.Articulos.Add(new Articulos
                {
                    Descripcion = TxtDescripcion.Text,
                    Cantidad = int.Parse(TxtCantidad.Text),
                    CostoUnitario = decimal.Parse(TxtCosto.Text),
                    PrecioUnitario = decimal.Parse(TxtPrecio.Text),
                    Estado = CbEstado.Text
                });
                entities1.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
                this.Close();
            }
           
        }

        private void FrmEdArticulos_Load(object sender, EventArgs e)
        {
            CbEstado.SelectedIndex = 0;
            if (articulo != null)
            {
                TxtId.Text = articulo.idArticulo.ToString();
                TxtDescripcion.Text = articulo.Descripcion;
                TxtCantidad.Text = articulo.Cantidad.ToString();
                TxtCosto.Text = articulo.CostoUnitario.ToString();
                TxtPrecio.Text = articulo.PrecioUnitario.ToString();
                CbEstado.Text = articulo.Estado;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
  Articulos articulo = entities1.Articulos.Find(Int32.Parse(TxtId.Text));
            if (articulo != null)
            {
                entities1.Articulos.Remove(articulo);
                entities1.SaveChanges();
                MessageBox.Show("Artículo eliminado con éxito");

            }
            else
                MessageBox.Show("Artículo no existente");
            this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar");
                return;
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }
            
            else
            {
                e.Handled = true;
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || Char.IsControl(e.KeyChar) || e.KeyChar == '.')
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
        }

        private void CbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "")
            {
                TxtCantidad.Text = "0";
            }
            if (CbEstado.Text == "Agotado")
            {
                TxtCantidad.Text = "0";
                TxtCantidad.Enabled = false;
            }

            else if (CbEstado.Text == "Disponible")
            {
                TxtCantidad.Enabled = true;
                TxtCantidad.Text = "1";
            }
            
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "0")
            {
                CbEstado.Text = "Agotado";
            }
        }
    }
}
