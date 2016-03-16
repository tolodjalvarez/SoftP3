using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace Soft_P3.Datos
{
    class FDBHelper
    {
        public static DataSet ExecuteDataSet(string sqlSpName, SqlParameter[] dbParams)
        {
            DataSet ds = null;
            //try
            //{
            ds = new DataSet();
            SqlCommand cmd = new SqlCommand(sqlSpName, conexion.ObtenerConexion());
            cmd.CommandTimeout = 600;

            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            if (dbParams != null)
            {
                foreach (SqlParameter dbParam in dbParams)
                {
                    da.SelectCommand.Parameters.Add(dbParam);
                }
            }
            da.Fill(ds);
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            return ds;
        }

        public static SqlParameter MakeParam(string paramName, SqlDbType dbType, int size, object objValue)
        {
            SqlParameter param;

            if (size > 0)
                param = new SqlParameter(paramName, dbType, size);
            else
                param = new SqlParameter(paramName, dbType);

            param.Value = objValue;

            return param;
        }
    }
}
