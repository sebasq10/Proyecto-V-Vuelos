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
    public class Administradores
    {
        #region propiedades
        private string _nombre_usuario;

        public string nombre_usuario
        {
            get { return _nombre_usuario; }
            set { _nombre_usuario = value; }
        }

        private string _contrasena;

        public string contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }

        private string _email;

        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _pregunta_sec;

        public string pregunta_sec
        {
            get { return _pregunta_sec; }
            set { _pregunta_sec = value; }
        }

        private string _respuesta_sec;

        public string respuesta_sec
        {
            get { return _respuesta_sec; }
            set { _respuesta_sec = value; }
        }

        private string _rol1;

        public string rol1
        {
            get { return _rol1; }
            set { _rol1 = value; }
        }

        private string _rol2;

        public string rol2
        {
            get { return _rol2; }
            set { _rol2 = value; }
        }

        private string _rol3;

        public string rol3
        {
            get { return _rol3; }
            set { _rol3 = value; }
        }

        private string _rol4;

        public string rol4
        {
            get { return _rol4; }
            set { _rol4 = value; }
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

        public DataSet login(ref string mensajeError, ref int numeroError, string usuario, string contrasena)
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
                sql = "login";

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

        public DataSet cargar_nombre_usuario_administrador(ref string mensajeError, ref int numeroError, string usuario)
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
                sql = "cargar_nombre_usuario_administrador";

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

        public DataSet cargar_administradores(ref string mensajeError, ref int numeroError)
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
                sql = "cargar_administradores";

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public void editar_roles_administrador(ref string mensajeError, ref int numeroError, string nombre_usuario, string rol1, string rol2, string rol3, string rol4)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "editar_roles_administrador";

                ParamStruct[] parametros = new ParamStruct[5];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Nombre_Usuario", SqlDbType.VarChar, nombre_usuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Rol1", SqlDbType.VarChar, rol1);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Rol2", SqlDbType.VarChar, rol2);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Rol3", SqlDbType.VarChar, rol3);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Rol4", SqlDbType.VarChar, rol4);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
            }
        }

        public void insertar_administrador(ref string mensajeError, ref int numeroError, string nombre_usuario, string contrasena, string email, string preguntaSeguridad, string respuestaSeguridad, string rol1, string rol2, string rol3, string rol4)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "insertar_administrador";

                ParamStruct[] parametros = new ParamStruct[9];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Nombre_Usuario", SqlDbType.VarChar, nombre_usuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Contrasena", SqlDbType.VarChar, contrasena);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Email", SqlDbType.VarChar, email);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Pregunta_Sec", SqlDbType.VarChar, preguntaSeguridad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Respuesta_sec", SqlDbType.VarChar, respuestaSeguridad);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 5, "@Rol1", SqlDbType.VarChar, rol1);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 6, "@Rol2", SqlDbType.VarChar, rol2);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 7, "@Rol3", SqlDbType.VarChar, rol3);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 8, "@Rol4", SqlDbType.VarChar, rol4);
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

        public void editar_contrasena_administrador(ref string mensajeError, ref int numeroError, string nombre_usuario, string contrasena)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "editar_contrasena_administrador";

                ParamStruct[] parametros = new ParamStruct[2];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@nombre_usuario", SqlDbType.VarChar, nombre_usuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@contrasena", SqlDbType.VarChar, contrasena);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
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

