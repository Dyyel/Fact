using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            SqlConnection ocon = new SqlConnection("Data Source=.;Initial Catalog=Facturacion;Integrated Security=True");
            ocon.Open();

            string claveEncriptadaMD5 = getMD5Hash(TxtContrasena.Text);
            //string claveEncriptadaSHA1 = getSha1Hash(txtContrasena.Text);

            //MessageBox.Show("Clave MD5:\n\r" + claveEncriptadaMD5, "Error");
            //MessageBox.Show("Clave SHA1:\n\r" + claveEncriptadaSHA1, "Error");

            string sSQL = "select 'S' from Usuarios where Estado = 'A' and Contrasena = '" + claveEncriptadaMD5 + "' and idusuario = '" + TxtUsuario.Text + "'";
            SqlCommand ocmd = new SqlCommand(sSQL, ocon);
            string sExiste = "";
            string sRol = "";

            string rolBdd = "select Rol from Usuarios where idusuario = '" + TxtUsuario.Text + "'";
            SqlCommand rol = new SqlCommand(rolBdd, ocon);
            try
            {
                
                sExiste = ocmd.ExecuteScalar().ToString();
                sRol = rol.ExecuteScalar().ToString();
                Console.WriteLine(sRol);
            }
            catch (Exception ex)
            {
               
                string sError = ex.Message;
                
            }


           
            if (!String.IsNullOrEmpty(sExiste) && sRol == "Admin")
            {
                FrmMenuAdmin frmMenu = new FrmMenuAdmin();
                this.Hide();
                frmMenu.Show();
    
            }

            else if (!String.IsNullOrEmpty(sExiste) && sRol == "Usuario")
            {
                FrmMenuUsuarios frmMenu = new FrmMenuUsuarios();
                this.Hide();
                frmMenu.Show();
            }

            else
            {
                MessageBox.Show("Datos incorrectos", "Error");
            }
        }

        public string getMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        internal static string getSha1Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha1 = new System.Security.Cryptography.SHA1Managed())
            {
                byte[] textData = Encoding.UTF8.GetBytes(text);

                byte[] hash = sha1.ComputeHash(textData);

                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }
    }
}
