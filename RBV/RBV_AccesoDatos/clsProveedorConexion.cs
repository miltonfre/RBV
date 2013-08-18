using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace RBV_AccesoDatos
{

    public class clsProveedorConexion
    {

        //public clsProveedorConexion()
        //{
        //}


        #region CONSTRUCTORES
        #endregion

        #region ATRIBUTOS
        public string strCadenaConexion;

        #endregion

        #region METODOS GET Y SET
        #endregion

        #region METODOS


        /// <summary>
        /// Obtiene la cadena de conexion
        /// </summary>
        /// <returns> a cadena de conexión predeterminada de la aplicación principal</returns>
        public static SqlConnection ObtenerConexionSql()
        {
            return ObtenerConexionSqlconClave("SII_DSSAConnectionString");
        }


        private static SqlConnection ObtenerConexionSqlconClave(string strClaveConexionString)
        {
            string strCadenaConexion =
                 ConfigurationManager.ConnectionStrings[strClaveConexionString].ToString();

            if (!string.IsNullOrEmpty(strCadenaConexion))
                return new SqlConnection(strCadenaConexion);
            else
                throw new Exception("No se ha definido la cadena de conexión [" + strClaveConexionString + "].");
        }


        #endregion






    }
}
