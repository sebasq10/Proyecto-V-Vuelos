using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos.Vistas
{
    public partial class Bitacora : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {
            Bitacoras bitacoras = new Bitacoras();
            tabla_Bitacora.DataSource = bitacoras.cargar_bitacora(ref mensaje_error, ref numero_error);
            tabla_Bitacora.DataBind();
        }
    }
}