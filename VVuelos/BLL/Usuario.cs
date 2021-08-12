using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Usuario
    {
        #region propiedades
        private string _nombre_usuario;

        public string nombre_usuario
        {
            get { return _nombre_usuario; }
            set { _nombre_usuario = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _primer_apellido;

        public string primer_apellido
        {
            get { return _primer_apellido; }
            set { _primer_apellido = value; }
        }

        private string _segundo_apellido;

        public string segundo_apellido
        {
            get { return _segundo_apellido; }
            set { _segundo_apellido = value; }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _contrasena;

        public string contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }


        #endregion

        #region variables_conexion
        SqlConnection conexion;
        string mensaje_error;
        int numero_error;
        string sql;
        DataSet ds;
        #endregion


        #region procedimientos
        public DataSet login_usuarios(ref string mensajeError, ref int numeroError, string usuario, string contrasena)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
                return ds;
            }
            else
            {
                sql = "login_usuarios";

                ParamStruct[] parametros = new ParamStruct[2];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Nombre_Usuario", SqlDbType.VarChar, usuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Contrasena", SqlDbType.VarChar, contrasena);
  

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public DataSet cargar_usuarios(ref string mensajeError, ref int numeroError)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
                return ds;
            }
            else
            {
                sql = "cargar_usuarios";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public DataSet crear_usuario(ref string mensajeError, ref int numeroError, string usuario, string nombre, string pApellido, string sApellido, string email, string contrasena)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
                return ds;
            }
            else
            {
                sql = "insertar_usuario";

                ParamStruct[] parametros = new ParamStruct[6];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Nombre_Usuario", SqlDbType.VarChar, usuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Nombre", SqlDbType.VarChar, nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Primer_Apellido", SqlDbType.VarChar, pApellido);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Segundo_Apellido", SqlDbType.VarChar, sApellido);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Email", SqlDbType.VarChar, email);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@Contrasena", SqlDbType.VarChar, contrasena);
                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public DataSet cargar_nombre_usuario(ref string mensajeError, ref int numeroError, string usuario)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
                return ds;
            }
            else
            {
                sql = "cargar_nombre_usuario";

                ParamStruct[] parametros = new ParamStruct[1];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Nombre_Usuario", SqlDbType.VarChar, usuario);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public void editar_contrasena_usuario(ref string mensajeError, ref int numeroError, string usuario, string contrasena)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "editar_contrasena_usuario";

                ParamStruct[] parametros = new ParamStruct[2];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Nombre_Usuario", SqlDbType.VarChar, usuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Contrasena", SqlDbType.VarChar, contrasena);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);

                cls_DAL.conectar(conexion, ref mensaje_error, ref numero_error);
                cls_DAL.ejecuta_sqlcommand(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                cls_DAL.desconectar(conexion, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
            }
        }
        #endregion
    }
}
