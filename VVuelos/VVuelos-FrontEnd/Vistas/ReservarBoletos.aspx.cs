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
    public partial class ProcesarBoletos : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cerrarAccion_Click(object sender, EventArgs e)
        {
            Response.Redirect("BuscarVuelos.aspx");
        }

        protected void guardarAccion_Click(object sender, EventArgs e)
        {
            Reservaciones reservacion = new Reservaciones();
            DataSet dataSet;
            Guid g = Guid.NewGuid();
            string numReserva = g.ToString().Substring(0, 6);
            string cod_vuelo = Session["Cod_Vuelo"].ToString();
            string usuario = Session["Cliente"].ToString();
            dataSet = reservacion.cargar_asientos_disponibles(ref mensaje_error, ref numero_error, cod_vuelo);
            if (dataSet.Tables[0].Rows[0][0].ToString() != "0")
            {
                Reservaciones reservacion1 = new Reservaciones();
                DataSet dataSet1;
                dataSet1 = reservacion1.insertar_reservacion(ref mensaje_error, ref numero_error, asientosReservarTxt.Text, cod_vuelo, usuario, numReserva);
                Response.Write("<script>alert('Su número de reserva es: " + numReserva + "');</script>");
            }
            else
            {
                Response.Write("<script>alert('No existen mas asientos disponibles en este vuelo');</script>");
            }
        }
    }
}