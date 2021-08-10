using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos_FrontEnd
{
    public partial class _Default : Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void transfer_Click(object sender, EventArgs e)
        {
            Administradores administrador = new Administradores();
            DataSet dataSet;
            dataSet = administrador.login(ref mensaje_error, ref numero_error, "prueba3", "123");
                if (dataSet.Tables[0].Rows.Count > 0)
                {
                    Response.Redirect("http://localhost:60012/Vistas/login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('El usuario o contrasena ingresado no es correcto');</script>");
                }
        }
    }
}