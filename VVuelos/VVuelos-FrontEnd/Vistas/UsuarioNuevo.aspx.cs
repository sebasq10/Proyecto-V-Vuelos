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
    public partial class WebForm2 : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        bool revisado = false;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Confirm_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string usr = txtUser.Text;
            string first = txtFirstname.Text;
            string last = txtLastName.Text;
            string secondLast = txtSecLastName.Text;
            string email = txtEmail.Text;
            string pass = txtPass.Text;
            DataSet dataSet;
            dataSet = usuario.cargar_nombre_usuario(ref mensaje_error, ref numero_error, usr);
            if (txtUser.Text != String.Empty &&
                txtUser.Text != String.Empty &&
                txtFirstname.Text != String.Empty &&
                txtLastName.Text != String.Empty &&
                txtSecLastName.Text != String.Empty &&
                txtEmail.Text != String.Empty &&
                txtPass.Text != String.Empty &&
                txtConfPass.Text != String.Empty)
                {
                if (dataSet.Tables[0].Rows.Count > 0) 
                {
                    Response.Write("<script>alert('Este usuario no está dispoible. Porfavor utilice otro');</script>");
                } 
                else 
                {
                    if (txtConfPass.Text == txtPass.Text)
                    {
                        usuario.crear_usuario(ref mensaje_error, ref numero_error, usr, first, last, secondLast, email, pass);
                        Response.Write("<script>alert('Usuario Ingresado exitosamente');</script>");
                        Response.Redirect("InicioSesion.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Las contraseñas insertadas son diferentes');</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('Por favor llene los campos solicitados');</script>");
            }
        }

        protected void Verify_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string usr = txtUser.Text;
            DataSet dataSet;
            dataSet = usuario.cargar_nombre_usuario(ref mensaje_error, ref numero_error, usr);
            if (txtUser.Text != String.Empty)
            {
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    Response.Write("<script>alert('Este usuario no está dispoible. Porfavor utilice otro');</script>");
                    revisado = false;
                }
                else
                {
                    Response.Write("<script>alert('¡Usuario Disponible!');</script>");
                    revisado = true;
                }
            }
            else
            {
                Response.Write("<script>alert('Porfavor ingrese un usuario');</script>");
            }
        }
    }
}