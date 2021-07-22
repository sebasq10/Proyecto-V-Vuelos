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
    public class Puertas
    {
        #region propiedades
        private string _cod_puerta;

        public string cod_puerta
        {
            get { return _cod_puerta; }
            set { _cod_puerta = value; }
        }

        private string _numero;

        public string numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private string _detalle;

        public string detalle
        {
            get { return _detalle; }
            set { _detalle = value; }
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

        public DataSet cargar_puertas(ref string mensajeError, ref int numeroError)
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
                sql = "cargar_puertas";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public DataSet cargar_puerta_codigo(ref string mensajeError, ref int numeroError, string cod_puerta)
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
                sql = "cargar_puerta_codigo";

                ParamStruct[] parametros = new ParamStruct[1];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Puerta", SqlDbType.VarChar, cod_puerta);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public void insertar_puerta(ref string mensajeError, ref int numeroError, string numero, string detalle)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "insertar_puerta";

                ParamStruct[] parametros = new ParamStruct[2];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Descripcion", SqlDbType.VarChar, numero);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Consecutivo", SqlDbType.VarChar, detalle);

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
