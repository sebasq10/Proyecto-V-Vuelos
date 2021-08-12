using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos_FrontEnd.Vistas
{
    public partial class BuscarVuelos : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void buscarVuelosbtn_Click(object sender, EventArgs e)
        {
            Vuelos vuelo = new Vuelos();
            string destino = Destinotxt.Text;
            string fecha1 = Fechatxt.Text;
            DateTime fecha = Convert.ToDateTime(fecha1);
            string x = fecha.ToString("MM/dd/yyyy");
            fecha = Convert.ToDateTime(x);
            DataSet dataSet;
            if (Destinotxt.Text != String.Empty && Fechatxt.Text != String.Empty)
            {
                dataSet = vuelo.cargar_vuelos_filtro(ref mensaje_error, ref numero_error, fecha, destino);
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    tabla_BuscarVuelos.DataSource = dataSet;
                    tabla_BuscarVuelos.DataBind();
                }
                else
                {
                    Response.Write("<script>alert('El usuario o contrasena ingresado no es correcto');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Por favor llene los campos solicitados');</script>");
            }
        
        }

        protected void seleccionar_Vuelo_Click(object sender, EventArgs e)
        {
            string seleccionvuelo = (sender as LinkButton).CommandArgument;
        }
    }
}