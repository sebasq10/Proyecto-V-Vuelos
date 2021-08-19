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
    public partial class NuevoUsuario : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ConfirmarBtn_Click(object sender, EventArgs e)
        {
            Administradores administrador = new Administradores();
            string usuario = txtUsr.Value;
            string contrasena = txtPass.Value;
            string confContrasena = txtConfPass.Value;
            string email = txtEmail.Value;
            string preguntaSecreta = txtSecAns.Value;
            string respuestaSecreta = txtSecQues.Value;
            string rol1 = "0";
            string rol2 = "0";
            string rol3 = "0";
            string rol4 = "0";

            DataSet dataSet;
            dataSet = administrador.login(ref mensaje_error, ref numero_error, usuario, contrasena);
            if (txtUsr.Value != String.Empty &&
                txtPass.Value != String.Empty &&
                txtConfPass.Value != String.Empty &&
                txtEmail.Value != String.Empty &&
                txtSecQues.Value != String.Empty &&
                txtSecAns.Value != String.Empty)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    Response.Write("<script>alert('Este usuario ya existe. Por favor escoja otro');</script>");
                }
                else
                {
                    if (contrasena == confContrasena)
                    {
                        administrador.insertar_administrador(ref mensaje_error, ref numero_error, usuario, contrasena, email, preguntaSecreta, respuestaSecreta, rol1, rol2, rol3, rol4);
                        Response.Write("<script>alert('Usuario Insertado');</script>");
                        Response.Redirect("ListaUsuarios.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Error de validación de contraseña. Por favor intente de nuevo');</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Por favor llene los campos solicitados');</script>");
            }
        }
    }
}