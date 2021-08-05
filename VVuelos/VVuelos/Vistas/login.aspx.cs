using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace VVuelos.Vistas
{
    public partial class login : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {
            Administradores administrador = new Administradores();
            string correo = email.Text;
            string contrasena = password.Text;
            DataSet dataSet;
            dataSet = administrador.login(ref mensaje_error, ref numero_error, correo, contrasena);
            if (email.Text != String.Empty && password.Text != String.Empty)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    Session["Usuario"] = email.Text;
                    string mensaje = Convert.ToString(Session["Usuario"]);
                    Response.Redirect("ListaUsuarios.aspx");
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