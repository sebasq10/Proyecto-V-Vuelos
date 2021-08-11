using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos_FrontEnd.Vistas
{
    public partial class ListaVuelos : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

            Vuelos vueloEntrada = new Vuelos();
            Vuelos vueloSalida = new Vuelos();
            tabla_VuelosEntrada.DataSource = vueloEntrada.cargar_vuelos(ref mensaje_error, ref numero_error, "0");
            tabla_VuelosEntrada.DataBind();
            tabla_VuelosSalidas.DataSource = vueloSalida.cargar_vuelos(ref mensaje_error, ref numero_error, "1");
            tabla_VuelosSalidas.DataBind();
        }
    }
}