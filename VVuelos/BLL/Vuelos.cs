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
    public class Vuelos
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

        public DataSet cargar_vuelos(ref string mensajeError, ref int numeroError, string Tipo_Vuelo)
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
                sql = "cargar_vuelos";

                ParamStruct[] parametros = new ParamStruct[1];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Tipo_Vuelo", SqlDbType.VarChar, Tipo_Vuelo);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }
        #endregion
    }
}
