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
    public partial class FrmArticulos : Form
    {

        DataTable dt = new DataTable();
        SqlConnection oCon = null;
        
        string fileName = @"C:\prop\articulos.csv";
        public FrmArticulos()
        {
            InitializeComponent();
        }

        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            CbxCriterio.SelectedIndex = 0;
            oCon = new SqlConnection("data source=.;initial catalog=Facturacion;Integrated Security=True");
            oCon.Open();
            consultarArticulos("");
        }

        private void consultarArticulos(string pFiltro)
        {
            string sSQL = "select * from articulos ";
            if (pFiltro.Trim().Length > 0)
                sSQL += pFiltro;

            SqlDataAdapter oDa = new SqlDataAdapter(sSQL, oCon);
            dt = new DataTable();
            oDa.Fill(dt);
            DgvArticulos.DataSource = dt;
            DgvArticulos.Refresh();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string sWhere = "where " + CbxCriterio.SelectedItem + " like '%" + TxtBuscador.Text + "%' ";
            sWhere += " order by " + CbxCriterio.SelectedItem;
            consultarArticulos(sWhere);
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdArticulos frm = new FrmEdArticulos();
            frm.ShowDialog();
        }

        private void FrmArticulos_Activated(object sender, EventArgs e)
        {
            consultarArticulos("");
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

        private void ExportarExcel()
        {
            try
            {
                writeFileLine("sep=,");
                writeFileLine("idArticulos, Descripcion, Cantidad, CostoUnitario, PrecioUnitario, Estado");

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
