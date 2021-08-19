using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace VVuelos_FrontEnd.Vistas
{
    public partial class PagoBoletos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {





        }



        protected void btnTarjeta_Clicked(object sender, EventArgs e)
        {
            if (txtNumT.Text != String.Empty &&
            txtMesExp.Text != String.Empty &&
            txtAno.Text != String.Empty &&
            txtCVV.Text != String.Empty &&
            txtMonto.Text != String.Empty &&
            txtTipo.Text != String.Empty)
            {
                lblError.Text = "Compra realizada, Presente su tarjeta en el aeropuerto";
                lblError.ForeColor = Color.Green;
            }
            else
            {
                lblError.Text = "Error, Porfavor rellene todos los campos";
                lblError.ForeColor = Color.Red;
            }
        }



        protected void btnEasyPay_Clicked(object sender, EventArgs e)
        {
            if (TextNumCuenta.Text != String.Empty &&
            txtCodSeg.Text != String.Empty &&
            txtContrasena.Text != String.Empty)
            {
                lblError1.Text = "Compra realizada, Presente su tarjeta en el aeropuerto";
                lblError1.ForeColor = Color.Green;
            }
            else
            {
                lblError1.Text = "Error, Porfavor rellene todos los campos";
                lblError1.ForeColor = Color.Red;
            }
        }
    }
}