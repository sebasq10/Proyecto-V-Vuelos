using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace VVuelos.Vistas
{
    public partial class login : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string correo = email.Text;
            string contrasena = password.Text;
            DataSet dataSet;
            dataSet = usuario.cargar_nombre_usuario(ref mensaje_error, ref numero_error, correo, contrasena);
            string usr = dataSet.Tables[0].Rows[0][0].ToString();
        }

    }
}