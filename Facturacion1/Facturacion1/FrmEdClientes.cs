using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Facturacion1
{
    public partial class FrmEdClientes : Form
    {
        public Clientes clientes { get; set; }
        private Entities1 entities1 = new Entities1();

        public FrmEdClientes()
        {
            InitializeComponent();
        }


       
        private void FrmEdClientes_Load(object sender, EventArgs e)
        {
           
            if (clientes != null)
            {
                TxtId.Text = clientes.IdCliente.ToString();
                TxtNombreComercial.Text = clientes.NombreComercial;
                TxtCedula.Text = clientes.Cédula;
                CbEstado.Text = clientes.Estado;
            }
        }
        
       
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombreComercial.Text == "" || TxtCedula.Text == "" || CbEstado.Text == "" || TxtId.Text != "")
            {
                MessageBox.Show("Datos no validos");
            }

            else
            {
                try
                {
                    if (validaCedula(TxtCedula.Text))
                    {

                        entities1.Clientes.Add(new Clientes
                        {
                            NombreComercial = TxtNombreComercial.Text,

                            Cédula = TxtCedula.Text,

                            Estado = CbEstado.Text
                        });

                        entities1.SaveChanges();
                        MessageBox.Show("Datos guardados con exito");
                        this.Close();

                    }
                    else
                    {
                        if (!validaCedula(TxtCedula.Text))
                        {
                            MessageBox.Show("Cedula no valida");
                            TxtCedula.Clear();
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Datos guardados incorrectamente");
                }
            }
            

            
               
          



        }
        
          
           
            public static bool validaCedula(string pCedula)
        {
            int vnTotal = 0;
            int pLongCed = pCedula.Length;
            int[] digitoMult = new int[11] { 1, 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            if (pCedula =="" || pCedula.Length < 11 )
            {
                return false;
            }
            for (int vDig = 1; vDig <= pLongCed; vDig++)
            {
                int vCalculo = int.Parse(pCedula.Substring(vDig - 1, 1)) * digitoMult[vDig - 1];
                if (vCalculo < 10)
                    vnTotal += vCalculo;
                else
                    vnTotal += int.Parse(vCalculo.ToString().Substring(0, 1)) + int.Parse(vCalculo.ToString().Substring(1, 1));
            }if (vnTotal % 10 == 0)
                return true;
            else
                return false;
        }



        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
            Clientes clientes = entities1.Clientes.Find(Int32.Parse(TxtId.Text));
            if (clientes != null)
            {
                entities1.Clientes.Remove(clientes);
                entities1.SaveChanges();
                MessageBox.Show("Cliente eliminado con éxito");

            }
            else
                MessageBox.Show("Cliente no existente");
            this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar");
                return ;
            }
           
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TxtNombreComercial_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
