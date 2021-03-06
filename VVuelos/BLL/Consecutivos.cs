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
    public class Consecutivos
    {
        #region propiedades
        private int _id_consecutivo;

        public int id_consecutivo
        {
            get { return _id_consecutivo; }
            set { _id_consecutivo = value; }
        }

        private int _descripcion;

        public int descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private int _consecutivo;

        public int consecutivo
        {
            get { return _consecutivo; }
            set { _consecutivo = value; }
        }

        private string _prefijo;

        public string prefijo
        {
            get { return _prefijo; }
            set { _prefijo = value; }
        }

        private int _rango_inicial;

        public int rango_inicial
        {
            get { return _rango_inicial; }
            set { _rango_inicial = value; }
        }

        private int _rango_final;

        public int rango_final
        {
            get { return _rango_final; }
            set { _rango_final = value; }
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

        public DataSet cargar_consecutivo(ref string mensajeError, ref int numeroError)
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
                sql = "cargar_consecutivos";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public DataSet cargar_consecutivo_id(ref string mensajeError, ref int numeroError, int codigo_consecutivo)
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
                sql = "cargar_consecutivo_id";

                ParamStruct[] parametros = new ParamStruct[1];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@ID_Consecutivo", SqlDbType.Int, codigo_consecutivo);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }


        public void insertar_consecutivo(ref string mensajeError, ref int numeroError, string descripcion, string consecutivo, string prefijo, string rango_inicial, string rango_final)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            } else
            {
                sql = "insertar_consecutivo";

                ParamStruct[] parametros = new ParamStruct[5];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Descripcion", SqlDbType.VarChar, descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Consecutivo", SqlDbType.VarChar, consecutivo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Prefijo", SqlDbType.VarChar, prefijo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Rango_Inicial", SqlDbType.VarChar, rango_inicial);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 4, "@Rango_Final", SqlDbType.VarChar, rango_final);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {
                    
                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
            }
        }

        public DataSet existe_tipo_consecutivo(ref string mensajeError, ref int numeroError, int descripcion)
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
                sql = "existe_tipo_consecutivo";

                ParamStruct[] parametros = new ParamStruct[1];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Descripcion", SqlDbType.Int, descripcion);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public void editar_consecutivo(ref string mensajeError, ref int numeroError, int descripcion, string prefijo, string rango_inicial, string rango_final)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "editar_consecutivo";

                ParamStruct[] parametros = new ParamStruct[4];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Descripcion", SqlDbType.VarChar, descripcion);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Prefijo", SqlDbType.VarChar, prefijo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Rango_Inicial", SqlDbType.VarChar, rango_inicial);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Rango_Final", SqlDbType.VarChar, rango_final);

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
