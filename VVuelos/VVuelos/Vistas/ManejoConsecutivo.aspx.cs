using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Konscious.Security.Cryptography;
using System.Diagnostics;

namespace VVuelos.Vistas
{
    public partial class ManejoConsecutivo : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        bool modo; //Si la pagina esta en modo insertar o editar

        protected void Page_Load(object sender, EventArgs e)
        {
            modo = false;
            try
            {
                if (!String.IsNullOrEmpty(Request.QueryString["codigo"].ToString()))//Confirmar si se esta pasando un codigo de consecutivo
                {

                }
            }
            catch
            {

            }
        }

        protected void testButton_Click(object sender, EventArgs e)
        {
            Consecutivos consecutivos = new Consecutivos();
            if (modo)
            {
                consecutivos.insertar_consecutivo(ref mensaje_error, ref numero_error, 2, 2, "123", 1, 1);
            } else
            {
                consecutivos.insertar_consecutivo(ref mensaje_error, ref numero_error, 1, 1, "123", 1, 1);
            }
        }
    }
}