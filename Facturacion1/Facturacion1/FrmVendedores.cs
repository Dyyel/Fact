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
    public partial class FrmVendedores : Form
    {



        DataTable dt = new DataTable();
        SqlConnection oCon = null;

        string fileName = @"C:\prop\vendedores.csv";
        public FrmVendedores()
        {
            InitializeComponent();
        }

       
        private void ConsultarVendedores(string pFiltro)
        {
            string sSQL = "select * from Vendedores ";
            if (pFiltro.Trim().Length > 0)
                sSQL += pFiltro;

            SqlDataAdapter oDa = new SqlDataAdapter(sSQL, oCon);
            dt = new DataTable();
            oDa.Fill(dt);
            DgvVendedores.DataSource = dt;
            DgvVendedores.Refresh();
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string sWhere = "where " + CbxCriterio.SelectedItem + " like '%" + TxtBuscador.Text + "%' ";
            sWhere += " order by " + CbxCriterio.SelectedItem;
            ConsultarVendedores(sWhere);
        }

        

        private void DgvVendedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    DataGridViewRow row = this.DgvVendedores.SelectedRows[0];
                    vendedores vendedores = new vendedores();
                    vendedores.IdVendedores = Int32.Parse(row.Cells[0].Value.ToString());
                    vendedores.Nombre = row.Cells[1].Value.ToString();
                    //vendedores.PorcientoComision = row.Cells[2];
                    vendedores.Estado = row.Cells[3].Value.ToString();
                    FrmEdVendedores fed = new FrmEdVendedores();
                    fed.vendedores = vendedores;
                    fed.ShowDialog();
                }
                catch (Exception ex)
                {

                    return;
                }
                
            }

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            FrmEdVendedores frm = new FrmEdVendedores();
            frm.ShowDialog();
        }

        private void FrmVendedores_Activated(object sender, EventArgs e)
        {

            ConsultarVendedores("");   
        }

        private void ExportarExcel()
        {
            try
            {
                writeFileLine("sep=,");
                writeFileLine("idVendedores, Nombre, PorcientoComision, Estado");

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

        private void FrmVendedores_Load(object sender, EventArgs e)
        {
            CbxCriterio.SelectedIndex = 0;
            oCon = new SqlConnection("data source=.;initial catalog=Facturacion;Integrated Security=True");
            oCon.Open();
            ConsultarVendedores("");
        }
    }
       

    
    }

