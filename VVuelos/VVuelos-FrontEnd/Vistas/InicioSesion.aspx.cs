using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace VVuelos_FrontEnd.Vistas
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string usr = txtUsr.Text;
            string pass = txtPass.Text;
            DataSet dataSet;
            dataSet = usuario.login_usuarios(ref mensaje_error, ref numero_error, usr, pass);
            if (txtUsr.Text != String.Empty && txtPass.Text != String.Empty)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    Session["Cliente"] = usr;
                    string mensaje = Convert.ToString(Session["Cliente"]);
                    Response.Redirect("BuscarVuelos.aspx"); /*Falta Vista*/
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
    }
}