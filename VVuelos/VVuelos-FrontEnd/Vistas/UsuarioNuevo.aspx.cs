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
    public partial class WebForm2 : System.Web.UI.Page
    {

        string mensaje_error;
        int numero_error;
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
                if (lblVerify.Text != "¡Usuario disponible!") 
                {
                     lblError.Text = "Error de validación de nombre de usuario. Por favor valide correctamente el nombre de usuario";
                     lblError.ForeColor = Color.Red;
                } 
                else 
                {
                    if (txtConfPass.Text == txtPass.Text)
                    {
                        if (lblMessage.Text == "Validacion CAPTCHA confirmada")
                        {
                            usuario.crear_usuario(ref mensaje_error, ref numero_error, usr, first, last, secondLast, email, pass);
                            Response.Write("<script>alert('Usuario Ingresado exitosamente');</script>");
                            Response.Redirect("InicioSesion.aspx");
                        }
                        else 
                        {
                            lblError.Text = "Error de validación de CAPTCHA. Por favor valide correctamente CAPTCHA";
                            lblError.ForeColor = Color.Red;
                        }
                    }
                    else
                    {
                        lblError.Text = "Error de validación de Contraseña. Por favor valide correctamente la contraseña";
                        lblError.ForeColor = Color.Red;
                    }
                }
            }
            else
            {
                lblError.Text = "Por favor rellene los campos solicitados";
                lblError.ForeColor = Color.Red;
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
                    lblVerify.Text = "Usuario no disponible";
                    lblVerify.ForeColor = Color.Red;
                }
                else
                {
                    lblVerify.Text = "¡Usuario disponible!";
                    lblVerify.ForeColor = Color.Green;
                }
            }
            else
            {
                lblVerify.Text = "Por favor ingresar un usuario";
                lblVerify.ForeColor = Color.Orange;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            bool isCaptchaValid = false;
            if (Session["CaptchaText"] != null && Session["CaptchaText"].ToString() == txtCaptchaText.Text)
            {
                isCaptchaValid = true;
            }

            if (isCaptchaValid)
            {
                lblMessage.Text = "Validacion CAPTCHA confirmada";
                lblMessage.ForeColor = Color.Green;
            }
            else
            {
                lblMessage.Text = "Validacion CAPTCHA incorrecta";
                lblMessage.ForeColor = Color.Red;
            }
        }
    }
}