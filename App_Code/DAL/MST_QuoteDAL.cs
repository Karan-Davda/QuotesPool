using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using QuoteWeb.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_QuoteDAL
/// </summary>
public class MST_QuoteDAL : MST_QuoteDALBase
{
	public MST_QuoteDAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable SelectQuoteByCategoryURL(SqlString CategoryURL)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Quote_SelectByCategoryURL");

            sqlDB.AddInParameter(dbCMD, "@CategoryURL", SqlDbType.VarChar, CategoryURL);

            DataTable dtMST_Quote = new DataTable("PR_MST_Quote_SelectByCategoryURL");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtMST_Quote);

            return dtMST_Quote;
        }
        catch (SqlException sqlex)
        {
            Message = SQLDataExceptionMessage(sqlex);
            if (SQLDataExceptionHandler(sqlex))
                throw;
            return null;
        }
        catch (Exception ex)
        {
            Message = ExceptionMessage(ex);
            if (ExceptionHandler(ex))
                throw;
            return null;
        }
    }

    public DataTable SelectForTodayQuote()
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Quote_SelectQuoteForToday");

            DataTable dtMST_Quote = new DataTable("PR_MST_Quote_SelectQuoteForToday");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtMST_Quote);

            return dtMST_Quote;
        }
        catch (SqlException sqlex)
        {
            Message = SQLDataExceptionMessage(sqlex);
            if (SQLDataExceptionHandler(sqlex))
                throw;
            return null;
        }
        catch (Exception ex)
        {
            Message = ExceptionMessage(ex);
            if (ExceptionHandler(ex))
                throw;
            return null;
        }
    }
}