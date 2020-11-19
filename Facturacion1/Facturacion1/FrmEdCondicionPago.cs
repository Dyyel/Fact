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
    public partial class FrmEdCondicionPago : Form
    {
        public CondicionPago pago { get; set; }
        private Entities1 entities1 = new Entities1();
        public FrmEdCondicionPago()
        {
            InitializeComponent();
        }
        private void BtnGuardar_Click_1(object sender, EventArgs e)
        {

            if (TxtCantidad.Text == "" || TxtDescripcion.Text == "" || CbEstado.Text == "" || TxtId.Text != "")
            {
                MessageBox.Show("Datos no validos");
            }
            else
            {
                entities1.CondicionPago.Add(new CondicionPago
                {
                    Descripcion = TxtDescripcion.Text,
                    CantidadDias = int.Parse(TxtCantidad.Text),
                    Estado = CbEstado.Text
                });
                entities1.SaveChanges();
                MessageBox.Show("Datos guardados con exito");
                this.Close();
            }
            
        }

        private void FrmEdCondicionPago_Load(object sender, EventArgs e)
        {
            if (pago != null)
            {
                TxtId.Text = pago.IdCondicionPago.ToString();
                TxtDescripcion.Text = pago.Descripcion;
                TxtCantidad.Text = pago.CantidadDias.ToString();
                CbEstado.Text = pago.Estado;
            }
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                CondicionPago pago = entities1.CondicionPago.Find(Int32.Parse(TxtId.Text));
                if (pago != null)
                {
                    entities1.CondicionPago.Remove(pago);
                    entities1.SaveChanges();
                    MessageBox.Show("Condicion de pago eliminada con éxito");

                }
                else
                    MessageBox.Show("Condicion de pago no existente");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar");
                return;
            }

        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
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
