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
    public class Reservaciones
    {
        #region propiedades


        #endregion

        #region variables_conexion
        SqlConnection conexion;
        string mensaje_error;
        int numero_error;
        string sql;
        DataSet ds;
        #endregion


        #region procedimientos

        public DataSet cargar_asientos_disponibles(ref string mensajeError, ref int numeroError, string Cod_Vuelo)
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
                sql = "cargar_asientos_disponibles";

                ParamStruct[] parametros = new ParamStruct[1];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cod_Vuelo", SqlDbType.VarChar, Cod_Vuelo);

                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, parametros, ref mensaje_error, ref numero_error);
                if (numero_error != 0)
                {

                    mensajeError = mensaje_error;
                    numeroError = numero_error;
                }
                return ds;
            }
        }

        public DataSet insertar_reservacion(ref string mensajeError, ref int numeroError, string cantidadBoletos, string Cod_Vuelo, string nombreUsuario, string numeroReserva)
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
                sql = "insertar_reservacion";

                ParamStruct[] parametros = new ParamStruct[4];

                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 0, "@Cantidad_Boletos", SqlDbType.VarChar, cantidadBoletos);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 1, "@Vuelos_Cod_Vuelo", SqlDbType.VarChar, Cod_Vuelo);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 2, "@Usuario_Nombre_Usuario", SqlDbType.VarChar, nombreUsuario);
                cls_DAL.agregar_datos_estructura_parametros(ref parametros, 3, "@Numero_Reserva", SqlDbType.VarChar, numeroReserva);

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