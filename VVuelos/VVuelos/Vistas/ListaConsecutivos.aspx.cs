using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos
{
    public partial class ListaConsecutivos : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {
            Consecutivos consecutivos = new Consecutivos();
            tabla_Consecutivos.DataSource = consecutivos.cargar_consecutivo(ref mensaje_error, ref numero_error);
            tabla_Consecutivos.DataBind();
        }

        protected void seleccionar_Consecutivo_Click(object sender, EventArgs e)
        {
            string numero_codigo = (sender as LinkButton).CommandArgument;
            Response.Redirect("ManejoConsecutivo.aspx?codigo="+ numero_codigo);
        }

        protected void nuevoConsecutivobtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ManejoConsecutivo.aspx?codigo=0");
        }
    }
}