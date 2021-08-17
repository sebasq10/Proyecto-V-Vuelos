using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

namespace VVuelos_FrontEnd.Vistas
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Cambiar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string usr = txtUsr.Text;
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string confPass = txtConfPass.Text;
            DataSet dataSet;
            dataSet = usuario.login_usuarios(ref mensaje_error, ref numero_error, usr, oldPass);
            if (txtUsr.Text != String.Empty && 
                txtOldPass.Text != String.Empty && 
                txtNewPass.Text != String.Empty && 
                txtConfPass.Text != String.Empty)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    if (newPass == confPass)
                    {
                        usuario.editar_contrasena_usuario(ref mensaje_error, ref numero_error, usr, newPass);
                        Response.Write("<script>alert('Contraseña cambiada');</script>");
                        Response.Redirect("InicioSesion.aspx");
                    }
                    else
                    {
                        lblError.Text = "Los espacios de nueva contraseña son diferentes";
                        lblError.ForeColor = Color.Red;
                    }
                }
                else
                {
                    lblError.Text = "El usuario o vieja contraseña ingresada no es correcta";
                    lblError.ForeColor = Color.Red;
                }
            }
            else
            {
                lblError.Text = "Por favor llene los campos solicitados";
                lblError.ForeColor = Color.Red;
            }
        }
    }
}