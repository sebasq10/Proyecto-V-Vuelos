using BLL;
using System;
using System.Collections.Generic;
using System.Data;
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
            if (!IsPostBack)
            {
                Aerolineas aerolineas = new Aerolineas();
                tabla_Aerolineas.DataSource = aerolineas.cargar_aerolineas(ref mensaje_error, ref numero_error);
                tabla_Aerolineas.DataBind();
            }
        }

        protected void editar_Aerolinea_Click(object sender, EventArgs e)
        {
            string codigo_aerolinea = (sender as LinkButton).CommandArgument;
            Aerolineas aerolineas = new Aerolineas();
            DataSet datatest;
            datatest = aerolineas.cargar_aerolinea_codigo(ref mensaje_error, ref numero_error, codigo_aerlinea);
            codigoPuerta.Text = datatest.Tables[0].Rows[0][0].ToString();
        }
    }
}