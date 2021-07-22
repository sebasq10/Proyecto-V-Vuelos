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
        private string _cuenta;

        public string cuenta
        {
            get { return _cuenta; }
            set { _cuenta = value; }
        }

        private string _contrasena;

        public string contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }


        #endregion
    }
}
