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
                cargar = false;
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
            numeroPuerta.Text = datatest.Tables[0].Rows[0][1].ToString();
            if (datatest.Tables[0].Rows[0][2].ToString() == "1")
            {
                puertachk.Checked = true;
            }
            else
            {
                puertachk.Checked = false;
            }
            string var = datatest.Tables[0].Rows[0][0].ToString();
        }

        protected void aceptarPuertabtn_Click(object sender, EventArgs e)
        {
            Puertas puertas = new Puertas();
            var estadoPuerta = "0";
            if (puertachk.Checked == true)
            {
                estadoPuerta = "1";
            }
            else
            {
                estadoPuerta = "0";
            }

            puertas.editar_puerta(ref mensaje_error, ref numero_error, codigoPuerta.Text, numeroPuerta.Text, estadoPuerta);
            Response.Redirect("ListaPuertas.aspx");
        }

        protected void cancelarPuertabtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaPuertas.aspx");
        }
    }
}