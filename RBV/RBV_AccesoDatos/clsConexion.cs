using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace RBV_AccesoDatos
{
    public class clsConexion
    {
        /// <summary>
        /// Metodo que Obtiene un Dataset
        /// </summary>
        /// <param name="sp">string con el nombre del procedimiento almacenado</param>
        /// <param name="parametros">SqlParameter[] con la lista de parametros.</param>
        /// <param name="tablas">string[] con la lista de tablas.</param>        
        public DataSet ObtenerDataSet(string strProcedimientoAlmacenado, SqlParameter[] astrParametros, string[] astrTablas)
        {
            DataSet ds = new DataSet();
                RBVDataContext obj = new RBVDataContext();
             empresa objempresa=   obj.empresas.Where(p => p.idEmpresa == 1).SingleOrDefault();
            //obj.aspnet_Memberships.
            using (SqlConnection objConexion = clsProveedorConexion.ObtenerConexionSql())
            {
                SqlCommand objCommand = CrearComando(objConexion, strProcedimientoAlmacenado);
                foreach (SqlParameter parametro in astrParametros)
                {
                    objCommand.Parameters.Add(parametro);
                }
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = objCommand;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = objConexion;
                objConexion.Open();

                for (int i = 0; i < astrTablas.Length; i++)
                {
                    string strTablaOrigen = "Table";
                    if (i > 0)
                    {
                        strTablaOrigen = strTablaOrigen + i;
                    }
                    da.TableMappings.Add(strTablaOrigen, astrTablas[i]);
                }

                da.Fill(ds);
            }
            return ds;
        }

        /// <summary>
        /// Metodo que crea un comando select
        /// </summary>
        /// <param name="objConexion">SqlConnection con la conexion.</param>
        /// <param name="strProcedimientoAlmacenado">string con el nombre del sp</param>
        /// <returns>OleDbCommand</returns>
        private SqlCommand CrearComando(SqlConnection objConexion, string strProcedimientoAlmacenado)
        {
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = strProcedimientoAlmacenado;
            objCommand.Connection = objConexion;
            return objCommand;
        }

        /// <summary>
        /// Metodo que obtiene un datatable
        /// </summary>
        /// <param name="sp">string con el nombre del procedimiento almacenado</param>
        /// <param name="parametros">SqlParameter[] con la lista de parametros</param>
        /// <param name="dt">DataTable a llenar</param>
        public DataTable ObtenerDataTable(string strProcedimientoAlmacenado, SqlParameter[] astrParametros)
        {
            DataTable dt = new DataTable();

            using (SqlConnection objConexion = clsProveedorConexion.ObtenerConexionSql())
            {
                SqlCommand objCommand = CrearComando(objConexion, strProcedimientoAlmacenado);
                foreach (SqlParameter parametro in astrParametros)
                {
                    objCommand.Parameters.Add(parametro);
                }
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = objCommand;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Connection = objConexion;
                objConexion.Open();
                da.Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// Metodo que Actualiza en la base de datos
        /// </summary>
        /// <param name="strProcedimientoAlmacenado">string con el nombre del procedimiento almacenado</param>
        /// <param name="astrParametros">SqlParameter[] con la lista de parametros</param>
        /// <returns>int con el valor del command</returns>
        public int EjecutarStoreProcedure(string strProcedimientoAlmacenado, SqlParameter[] astrParametros)
        {

            using (SqlConnection objConexion = clsProveedorConexion.ObtenerConexionSql())
            {
                SqlCommand objCommand = CrearComando(objConexion, strProcedimientoAlmacenado);

                foreach (SqlParameter parametro in astrParametros)
                {
                    objCommand.Parameters.Add(parametro);
                }
                objConexion.Open();
                return objCommand.ExecuteNonQuery();

            }
        }

    }
}
