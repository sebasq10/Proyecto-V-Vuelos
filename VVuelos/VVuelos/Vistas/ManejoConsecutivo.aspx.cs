using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Konscious.Security.Cryptography;
using System.Diagnostics;
using System.Data;

namespace VVuelos.Vistas
{
    public partial class ManejoConsecutivo : System.Web.UI.Page
    {
        string mensaje_error;
        string codigostr;
        int numero_error;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["codigo"].ToString() != "0")//Confirmar si se esta pasando un codigo de consecutivo
                {
                    Consecutivos consecutivo = new Consecutivos();
                    DataSet datatest;
                    datatest = consecutivo.cargar_consecutivo_id(ref mensaje_error, ref numero_error, int.Parse(Request.QueryString["codigo"].ToString()));
                    descripcionConsecutivo.SelectedIndex = int.Parse(datatest.Tables[0].Rows[0][1].ToString()) - 1;
                    descripcionConsecutivo.Enabled = false;
                    numeroConsecutivo.Text = datatest.Tables[0].Rows[0][2].ToString();
                    numeroConsecutivo.Enabled = false;
                    prefijoConsecutivo.Text = datatest.Tables[0].Rows[0][3].ToString();
                    rangoConsecutivoInicial.Text = datatest.Tables[0].Rows[0][4].ToString();
                    rangoConsecutivoFinal.Text = datatest.Tables[0].Rows[0][5].ToString();
                }
                else
                {
                    prefijochk.Checked = false;
                    rangochk.Checked = false;
                    rangoConsecutivoInicial.Enabled = false;
                    rangoConsecutivoFinal.Enabled = false;
                    prefijoConsecutivo.Enabled = false;
                }
            }

        }

        protected void prefijochk_CheckedChanged(object sender, EventArgs e)
        {
            if (prefijoConsecutivo.Enabled == false)
            {
                prefijoConsecutivo.Enabled = true;
            }
            else
            {
                prefijoConsecutivo.Enabled = false;
            }
        }

        protected void rangochk_CheckedChanged(object sender, EventArgs e)
        {
            if (rangoConsecutivoInicial.Enabled == false)
            {
                rangoConsecutivoInicial.Enabled = true;
                rangoConsecutivoFinal.Enabled = true;
            }
            else
            {
                rangoConsecutivoInicial.Enabled = false;
                rangoConsecutivoFinal.Enabled = false;
            }
        }

        protected void cancelarConsecutivobtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListaConsecutivos.aspx");
        }

        protected void aceptarConsecutivobtn_Click1(object sender, EventArgs e)
        {
            try
            {
                //Validacion de Datos
                Consecutivos consecutivo = new Consecutivos();
                DataSet datatest;
                datatest = consecutivo.existe_tipo_consecutivo(ref mensaje_error, ref numero_error, int.Parse(descripcionConsecutivo.SelectedValue));
                if (numeroConsecutivo.Text != String.Empty && int.Parse(rangoConsecutivoInicial.Text) < int.Parse(rangoConsecutivoFinal.Text))
                {
                    if (Request.QueryString["codigo"].ToString() != "0")
                    {
                        consecutivo.editar_consecutivo(ref mensaje_error, ref numero_error, int.Parse(descripcionConsecutivo.SelectedValue), prefijoConsecutivo.Text, rangoConsecutivoInicial.Text, rangoConsecutivoFinal.Text);
                        Response.Write("<script>alert('El consecutivo se modificado ingresado de forma satisfactoria');</script>");
                        Response.Redirect("ListaConsecutivos.aspx");
                    }
                    else
                    {
                        if (datatest.Tables[0].Rows.Count == 0)
                        {
                            consecutivo.insertar_consecutivo(ref mensaje_error, ref numero_error, descripcionConsecutivo.SelectedValue, numeroConsecutivo.Text, prefijoConsecutivo.Text, rangoConsecutivoInicial.Text, rangoConsecutivoFinal.Text);
                            Response.Write("<script>alert('El consecutivo se ha ingresado de forma satisfactoria');</script>");
                            Response.Redirect("ListaConsecutivos.aspx");
                        }
                        else
                        {
                            Response.Write("<script>alert('El tipo de Consecutivo que quiere ingresar ya existe, por favor seleccione un valor diferente');</script>");
                        }
                    }
                }
            }

            catch
            {
                Response.Write("<script>alert('Por favor revise los datos e intente de nuevo');</script>");
            }
        }
    }
}