using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos.Vistas
{
    public partial class ListaAerolineas : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {
            Aerolineas aerolineas = new Aerolineas();
            tabla_Aerolineas.DataSource = aerolineas.cargar_aerolinea(ref mensaje_error, ref numero_error);
            tabla_Aerolineas.DataBind();
        }
    }
}