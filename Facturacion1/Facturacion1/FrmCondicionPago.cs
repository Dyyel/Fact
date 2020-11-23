using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class FrmCondicionPago : Form
    {
        DataTable dt = new DataTable();
        SqlConnection oCon = null;

        string fileName = @"C:\prop\condicionPago.csv";

        public FrmCondicionPago()
        {
            InitializeComponent();
        }

        private void FrmCondicionPago_Load(object sender, EventArgs e)
        {
            CbxCriterio.SelectedIndex = 0;
            oCon = new SqlConnection("data source=.;initial catalog=Facturacion;Integrated Security=True");
            oCon.Open();
            ConsultarCondicionPago("");
        }
        private void ConsultarCondicionPago(string pFiltro)
        {
            string sSQL = "select * from CondicionPago ";
            if (pFiltro.Trim().Length > 0)
                sSQL += pFiltro;

            SqlDataAdapter oDa = new SqlDataAdapter(sSQL, oCon);
            dt = new DataTable();
            oDa.Fill(dt);
            DgvCondicionPago.DataSource = dt;
            DgvCondicionPago.Refresh();
        }
        private void consultarPorCriterio(string pFiltro)
        {
            string sSQL = "select * from CondicionPago ";
            if (pFiltro.Trim().Length > 0)
                sSQL += pFiltro;

            SqlDataAdapter oDa = new SqlDataAdapter(sSQL, oCon);
            dt = new DataTable();
            oDa.Fill(dt);
            DgvCondicionPago.DataSource = dt;
            DgvCondicionPago.Refresh();
        }
        private void FrmArticulos_Activated(object sender, EventArgs e)
        {
            ConsultarCondicionPago("");
        }

        private void BtnAgregar_Click_1(object sender, EventArgs e)
        {
            FrmEdCondicionPago frm = new FrmEdCondicionPago();
            frm.ShowDialog();
        }

        private void BtnBuscar_Click_1(object sender, EventArgs e)
        {
            string sWhere = "where " + CbxCriterio.SelectedItem + " like '%" + TxtBuscador.Text + "%' ";
            sWhere += " order by " + CbxCriterio.SelectedItem;
            consultarPorCriterio(sWhere);
        }

        private void FrmCondicionPago_Activated(object sender, EventArgs e)
        {
            ConsultarCondicionPago("");
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

                MessageBox.Show("Error al seleccionar los datos");
            }
            
        }

        private void ExportarExcel()
        {
            try
            {
                writeFileLine("sep=,");
                writeFileLine("idCondicionPago, Descripcion, CantidadDias, Estado");

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
