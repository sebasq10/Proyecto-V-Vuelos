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
    public class Paises
    {
        #region propiedades
        private string _cod_pais;

        public string cod_pais
        {
            get { return _cod_pais; }
            set { _cod_pais = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private byte[] _imagen;

        public byte[] imagen
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
        public DataSet cargar_paises(ref string mensajeError, ref int numeroError)
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
                sql = "cargar_paises";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {



                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }



        public DataSet cargar_pais_codigo(ref string mensajeError, ref int numeroError, string codigo_pais)
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
                sql = "cargar_pais_codigo";



                ParamStruct[] parametros = new ParamStruct[1];



                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Pais", SqlDbType.Int, codigo_pais);



                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {



                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }



        public void insertar_pais(ref string mensajeError, ref int numeroError, string cod_pais, string nombre, string imagen)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "insertar_pais";

                ParamStruct[] parametros = new ParamStruct[3];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Pais", SqlDbType.VarChar, cod_pais);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Nombre", SqlDbType.VarChar, nombre);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Imagen", SqlDbType.VarChar, imagen);
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



        public DataSet borrar_pais(ref string mensajeError, ref int numeroError, string codigo_pais)
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
                sql = "borrar_pais";



                ParamStruct[] parametros = new ParamStruct[1];



                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Pais", SqlDbType.Int, codigo_pais);



                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {



                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }



        public void editar_pais(ref string mensajeError, ref int numeroError, string cod_pais, string nombre, string imagen)
        {
            conexion = cls_DAL.trae_conexion("VVuelos", ref mensaje_error, ref numero_error);
            if (conexion == null)
            {
                mensajeError = mensaje_error;
                numeroError = numero_error;
            }
            else
            {
                sql = "editar_pais";



                ParamStruct[] parametros = new ParamStruct[3];



                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Pais", SqlDbType.VarChar, cod_pais);
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