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
    public partial class ListaPuertas : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Puertas puertas = new Puertas();
                tabla_Puertas.DataSource = puertas.cargar_puertas(ref mensaje_error, ref numero_error);
                tabla_Puertas.DataBind();
            }
        }

        protected void editar_Puerta_Click(object sender, EventArgs e)
        {
            string codigo_puerta = (sender as LinkButton).CommandArgument;
            Puertas puertas = new Puertas();
            DataSet datatest;
            datatest = puertas.cargar_puerta_codigo(ref mensaje_error, ref numero_error, codigo_puerta);
            codigoPuerta.Text = datatest.Tables[0].Rows[0][0].ToString();
        }
    }
}