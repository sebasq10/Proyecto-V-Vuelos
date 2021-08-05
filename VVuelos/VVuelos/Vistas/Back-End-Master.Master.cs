using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos.Vistas
{
    public partial class Back_End_Master : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null)
            {
                UsernameLabel.Text = Session["Usuario"].ToString();
            }
        }

        protected void cerrarSesionbtn_Click(object sender, EventArgs e)
        {
            Session["Usuario"] = null;
            Response.Redirect("login.aspx");
        }
    }
}