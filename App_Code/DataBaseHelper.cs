using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.SqlTypes;
using QuoteWeb;

namespace QuoteWeb.DAL
{
    public class DataBaseHelper
    {
        public DataBaseHelper()
        {

        }

        public Int32 ExecuteNonQuery(SqlDatabase sqlDB, DbCommand dbCMD)
        {
            return sqlDB.ExecuteNonQuery(dbCMD);
        }

        public DataTable LoadDataTable(SqlDatabase sqlDB, DbCommand dbCMD, DataTable dt)
        {
            using (IDataReader dr = sqlDB.ExecuteReader(dbCMD))
            {
                dt.Load(dr);
            }
            return dt;
        }

        public IDataReader ExecuteReader(SqlDatabase sqlDB, DbCommand dbCMD)
        {
            return sqlDB.ExecuteReader(dbCMD);
        }

        public SqlInt32 ExecuteScalar_Int32(SqlDatabase sqlDB, DbCommand dbCMD)
        {
            return Convert.ToInt32(sqlDB.ExecuteScalar(dbCMD));
        }

        public SqlString ExecuteScalar_String(SqlDatabase sqlDB, DbCommand dbCMD)
        {
            return Convert.ToString(sqlDB.ExecuteScalar(dbCMD));
        }


        public DataSet ExecuteDataSet(SqlDatabase sqlDB, DbCommand dbCMD)
        {
            return sqlDB.ExecuteDataSet(dbCMD);
        }
    }
}
