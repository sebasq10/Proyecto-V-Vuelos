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
    public partial class ListaUsuarios : System.Web.UI.Page
    {
        string mensaje_error;
        int numero_error;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Administradores administrador = new Administradores();
                tabla_Usuarios.DataSource = administrador.cargar_administradores(ref mensaje_error, ref numero_error);
                tabla_Usuarios.DataBind();
                usuarioAdministradorchk.Enabled = false;
                usuarioSeguridadchk.Enabled = false;
                usuarioConsecutivochk.Enabled = false;
                usuarioMantenimientochk.Enabled = false;
            }
        }

        protected void seleccionar_Usuario_Click(object sender, EventArgs e)
        {
            string nombre_usuario = (sender as LinkButton).CommandArgument;
            Administradores administrador = new Administradores();
            DataSet datatest;
            datatest = administrador.cargar_nombre_usuario_administrador(ref mensaje_error, ref numero_error, nombre_usuario);
            usuarioSeleccionado.Text = nombre_usuario;
            usuarioAdministradorchk.Enabled = true;
            usuarioSeguridadchk.Enabled = true;
            usuarioConsecutivochk.Enabled = true;
            usuarioMantenimientochk.Enabled = true;
            if (datatest.Tables[0].Rows[0][5].ToString() == "1")
            {
                usuarioAdministradorchk.Checked = true;
            }
            if (datatest.Tables[0].Rows[0][6].ToString() == "1")
            {
                usuarioSeguridadchk.Checked = true;
            }
            if (datatest.Tables[0].Rows[0][7].ToString() == "1")
            {
                usuarioConsecutivochk.Checked = true;
            }
            if (datatest.Tables[0].Rows[0][8].ToString() == "1")
            {
                usuarioMantenimientochk.Checked = true;
            }
        }

        protected void aceptarUsuariobtn_Click(object sender, EventArgs e)
        {
            Administradores administrador = new Administradores();
            administrador.editar_roles_administrador(ref mensaje_error, ref numero_error, usuarioSeleccionado.Text, usuarioAdministradorchk.Checked ? "1" : "0", usuarioSeguridadchk.Checked ? "1" : "0", usuarioConsecutivochk.Checked ? "1" : "0", usuarioMantenimientochk.Checked ? "1" : "0");
        }
    }
}