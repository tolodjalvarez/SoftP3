using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Soft_P3.Datos
{
    class FLogin
    {
        public static DataSet ValidarLogin(string sUsuario, string sPassword)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                 {
                    FDBHelper.MakeParam("@Usuario", SqlDbType.VarChar, 0, sUsuario),
                    FDBHelper.MakeParam("@Password", SqlDbType.VarChar, 0, sPassword),

                 };
            return FDBHelper.ExecuteDataSet("usp_Data_FLogin_ValidarLogin", dbParams);

        }
    }
}
