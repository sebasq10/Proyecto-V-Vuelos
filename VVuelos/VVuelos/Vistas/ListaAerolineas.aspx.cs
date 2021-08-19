using BLL;
using System;
using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VVuelos.Vistas
{
    public partial class ListaAerolineas : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Aerolineas aerolineas = new Aerolineas();
                tabla_aerolineas.DataSource = aerolineas.cargar_aerolineas(ref mensaje_error, ref numero_error);
                tabla_aerolineas.DataBind();
            }
        }
        protected void btnUploadImage_Click(object sender, EventArgs e)
        {
            Aerolineas aerolinea = new Aerolineas();
            if (FileUpload1.HasFile)
            {
                byte[] ImageByteArray = null;
                ImageByteArray = ConvertImageToByteArray(FileUpload1);
                string converted = Convert.ToBase64String(ImageByteArray, 0, ImageByteArray.Length);
                aerolinea.insertar_aerolinea(ref mensaje_error, ref numero_error, codAerolinea.Text, nombreAerolinea.Text, converted);
                Response.Write("<script>alert('Se subió sin problemas la imagen');</script>");
            }
            else { Response.Write("<script>alert('Imagen no seleccionada');</script>"); }
        }

        private byte[] ConvertImageToByteArray(FileUpload fuImage)
        {
            byte[] ImageByteArray;
            try
            {
                MemoryStream ms = new MemoryStream(fuImage.FileBytes);
                ImageByteArray = ms.ToArray();
                return ImageByteArray;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}