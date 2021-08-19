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
                    Response.Write("<script>alert('No existen vuelos en la fecha solicitada');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Por favor llene los campos solicitados');</script>");
            }

        }

        protected void verificar_Asientos_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["Cliente"].ToString() != null)
                {
                    string cod_vuelo = (sender as LinkButton).CommandArgument;
                    Session["Cod_Vuelo"] = cod_vuelo;
                    Response.Redirect("ReservarBoletos.aspx?vuelo=" + cod_vuelo);
                }
                else
                {
                    Response.Write("<script>alert('Por favor inicie sesión');</script>");
                }
            }
            catch
            {
                Response.Write("<script>alert('Por favor inicie sesión');</script>");
            }

        }

        protected void comprar_Asientos_Click(object sender, EventArgs e)
        {

        }

        protected void guardarAccion_Click(object sender, EventArgs e)
        {
            string cod_vuelo = (sender as LinkButton).CommandArgument;
            Reservaciones reservacion = new Reservaciones();
            DataSet dataSet;
            Guid g = Guid.NewGuid();
            string numReserva = g.ToString().Substring(0, 6);
            dataSet = reservacion.cargar_asientos_disponibles(ref mensaje_error, ref numero_error, cod_vuelo);
            if (dataSet.Tables[0].Rows[0][0].ToString() != "0")
            {
                Reservaciones reservacion1 = new Reservaciones();
                DataSet dataSet1;
                dataSet1 = reservacion1.insertar_reservacion(ref mensaje_error, ref numero_error, asientosReservarTxt.Text, cod_vuelo, Session["Cliente"].ToString(), numReserva);
                Response.Write("<script>alert('I guess it worked');</script>");
            }
            else
            {

            }
            Response.Write("<script>alert('No existen mas asientos disponibles en este vuelo');</script>");
        }
    }
}