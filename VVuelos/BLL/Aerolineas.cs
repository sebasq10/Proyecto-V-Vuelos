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
    public class Aerolineas
    {
        #region propiedades
        private string _cod_aerolinea;



        public string cod_aerolinea
        {
            get { return _cod_aerolinea; }
            set { _cod_aerolinea = value; }
        }



        private string _nombre;



        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }



        private string _imagen;



        public string imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
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
        public DataSet cargar_aerolineas(ref string mensajeError, ref int numeroError)
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
                sql = "cargar_aerolineas";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {



                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }



        public DataSet cargar_aerolinea_codigo(ref string mensajeError, ref int numeroError, string codigo_aerolinea)
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
                sql = "cargar_aerolinea_codigo";



                ParamStruct[] parametros = new ParamStruct[1];



                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Aerolinea", SqlDbType.Int, codigo_aerolinea);



                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {



                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }



        public void insertar_aerolinea(ref string mensajeError, ref int numeroError, string cod_aerolinea, string nombre, string imagen)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "insertar_aerlinea";



                ParamStruct[] parametros = new ParamStruct[3];



                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Aerolinea", SqlDbType.VarChar, cod_aerolinea);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Nombre", SqlDbType.VarChar, nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Imagen", SqlDbType.VarChar, imagen);



                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {



                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
            }
        }



        public DataSet borrar_aerolinea(ref string mensajeError, ref int numeroError, string codigo_aerolinea)
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
                sql = "borrar_aerolinea";



                ParamStruct[] parametros = new ParamStruct[1];



                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Aerolinea", SqlDbType.Int, codigo_aerolinea);



                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {



                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }



        public void editar_aerolinea(ref string mensajeError, ref int numeroError, string cod_aerolinea, string nombre, string imagen)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "editar_aerlinea";



                ParamStruct[] parametros = new ParamStruct[3];



                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Aerolinea", SqlDbType.VarChar, cod_aerolinea);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Nombre", SqlDbType.VarChar, nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Imagen", SqlDbType.VarChar, imagen);



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