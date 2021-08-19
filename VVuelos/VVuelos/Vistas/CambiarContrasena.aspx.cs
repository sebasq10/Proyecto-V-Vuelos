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
    public partial class CambiarContrasena : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CambiarContrasena_Click(object sender, EventArgs e)
        {
            Administradores administrador = new Administradores();
            string usuario = Session["Usuario"].ToString();
            string contrasena = txtPass.Value;
            string newContrasena = txtNewPass.Value;
            string confContrasena = txtPassConf.Value;

            DataSet dataSet;
            dataSet = administrador.login(ref mensaje_error, ref numero_error, usuario, contrasena);

            if (txtPass.Value != String.Empty &&
                txtNewPass.Value != String.Empty &&
                txtPassConf.Value != String.Empty)
            {
                if (newContrasena == confContrasena)
                {
                    if (newContrasena != contrasena)
                    {
                        administrador.editar_contrasena_administrador(ref mensaje_error, ref numero_error, usuario, newContrasena);
                        Response.Redirect("login.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('La nueva contrsaeña es igual a la vieja contraseña. Por favor ingrese una nueva contraseña');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Error de validación de contraseña. Por favor revise la validación de la nueva contraseña');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Por favor llene los campos solicitados');</script>");
            }
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaUsuarios.aspx");
        }
    }
}