using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos_FrontEnd.Vistas
{
    public partial class Front_End_Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Crear_Click(object sender, EventArgs e)
        {
            Response.Redirect("UsuarioNuevo.aspx");
        }

        protected void Accesar_Click(object sender, EventArgs e)
        {
            Response.Redirect("InicioSesion.aspx");
        }

        protected void BackEnd_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:60012/Vistas/login");
        }
    }
}