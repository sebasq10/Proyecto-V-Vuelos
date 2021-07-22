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
    public class Bitacoras
    {
        #region propiedades
        private string _usuario;

        public string usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }

        private string _fecha;

        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private string _codigo_registro;

        public string codigo_registro
        {
            get { return _codigo_registro; }
            set { _codigo_registro = value; }
        }

        private string _tipo;

        public string tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
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
        public DataSet cargar_bitacora(ref string mensajeError, ref int numeroError)
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
                sql = "cargar_bitacora";
                ds = cls_DAL.ejecuta_dataset(conexion, sql, true, ref mensaje_error, ref numero_error);
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
