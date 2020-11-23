using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion1
{
    public partial class FrmClientes : Form
    {


        DataTable dt = new DataTable();
        SqlConnection oCon = null;

        string fileName = @"C:\prop\clientes.csv";
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            CbxCriterio.SelectedIndex = 0;
            oCon = new SqlConnection("data source=.;initial catalog=Facturacion;Integrated Security=True");
            oCon.Open();
            ConsultarClientes("");
        }
        private void ConsultarClientes(string pFiltro)
        {
            string sSQL = "select * from Clientes ";
            if (pFiltro.Trim().Length > 0)
                sSQL += pFiltro;

            SqlDataAdapter oDa = new SqlDataAdapter(sSQL, oCon);
            dt = new DataTable();
            oDa.Fill(dt);
            DgvClientes.DataSource = dt;
            DgvClientes.Refresh();
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

                MessageBox.Show("No se pudieron seleccionar los datos");
            }
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string sWhere = "where " + CbxCriterio.SelectedItem + " like '%" + TxtBuscador.Text + "%' ";
            sWhere += " order by " + CbxCriterio.SelectedItem;
            ConsultarClientes(sWhere);
        }

        private void FrmClientes_Activated(object sender, EventArgs e)
        {
            ConsultarClientes("");
        }

        private void ExportarExcel()
        {
            try
            {
                writeFileLine("sep=,");
                writeFileLine("idCliente, Nombre Comercial, Cedula, Estado");

                foreach (DataRow row in dt.Rows)
                {
                    string linea = "";
                    foreach (DataColumn dc in dt.Columns)
                    {
                        linea += row[dc].ToString() + ",";
                    }
                    writeFileLine(linea);
                }

                Process.Start(fileName);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al abrir el archivo");
            }

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        private void writeFileLine(string pLine)
        {
            using (System.IO.StreamWriter w = File.AppendText(fileName))
            {
                w.WriteLine(pLine);
            }
        }
    }
}

