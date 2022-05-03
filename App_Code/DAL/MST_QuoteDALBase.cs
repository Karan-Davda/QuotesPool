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
/// Summary description for MST_QuoteDALBase
/// </summary>
public class MST_QuoteDALBase : DataBaseConfig
{
    #region Properties

    private string _Message;
    public string Message
    {
        get
        {
            return _Message;
        }
        set
        {
            _Message = value;
        }
    }

    #endregion Properties

    #region Constructor

    public MST_QuoteDALBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion Constructor

    #region InsertOperation

    public Boolean Insert(MST_QuoteENT entMST_Quote)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Quote_Insert");

            sqlDB.AddOutParameter(dbCMD, "@QuoteID", SqlDbType.Int, 4);
            sqlDB.AddInParameter(dbCMD, "@Quote", SqlDbType.VarChar, entMST_Quote.Quote);
            sqlDB.AddInParameter(dbCMD, "@CategoryID", SqlDbType.Int, entMST_Quote.CategoryID);
            sqlDB.AddInParameter(dbCMD, "@AuthorID", SqlDbType.Int, entMST_Quote.AuthorID);
            sqlDB.AddInParameter(dbCMD, "@Image", SqlDbType.VarChar, entMST_Quote.Image);
            sqlDB.AddInParameter(dbCMD, "@IsActive", SqlDbType.Bit, entMST_Quote.IsActive);
            sqlDB.AddInParameter(dbCMD, "@Sequence", SqlDbType.Decimal, entMST_Quote.Sequence);
            sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entMST_Quote.Created);
            sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entMST_Quote.Modified);

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.ExecuteNonQuery(sqlDB, dbCMD);

            entMST_Quote.QuoteID = (SqlInt32)Convert.ToInt32(dbCMD.Parameters["@QuoteID"].Value);

            return true;
        }
        catch (SqlException sqlex)
        {
            Message = SQLDataExceptionMessage(sqlex);
            if (SQLDataExceptionHandler(sqlex))
                throw;
            return false;
        }
        catch (Exception ex)
        {
            Message = ExceptionMessage(ex);
            if (ExceptionHandler(ex))
                throw;
            return false;
        }
    }

    #endregion InsertOperation

    #region UpdateOperation

    public Boolean Update(MST_QuoteENT entMST_Quote)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Quote_Update");

            sqlDB.AddInParameter(dbCMD, "@QuoteID", SqlDbType.Int, entMST_Quote.QuoteID);
            sqlDB.AddInParameter(dbCMD, "@Quote", SqlDbType.VarChar, entMST_Quote.Quote);
            sqlDB.AddInParameter(dbCMD, "@CategoryID", SqlDbType.Int, entMST_Quote.CategoryID);
            sqlDB.AddInParameter(dbCMD, "@AuthorID", SqlDbType.Int, entMST_Quote.AuthorID);
            sqlDB.AddInParameter(dbCMD, "@Image", SqlDbType.VarChar, entMST_Quote.Image);
            sqlDB.AddInParameter(dbCMD, "@IsActive", SqlDbType.Bit, entMST_Quote.IsActive);
            sqlDB.AddInParameter(dbCMD, "@Sequence", SqlDbType.Decimal, entMST_Quote.Sequence);
            sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entMST_Quote.Created);
            sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entMST_Quote.Modified);

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.ExecuteNonQuery(sqlDB, dbCMD);

            return true;
        }
        catch (SqlException sqlex)
        {
            Message = SQLDataExceptionMessage(sqlex);
            if (SQLDataExceptionHandler(sqlex))
                throw;
            return false;
        }
        catch (Exception ex)
        {
            Message = ExceptionMessage(ex);
            if (ExceptionHandler(ex))
                throw;
            return false;
        }
    }

    #endregion UpdateOperation

    #region DeleteOperation

    public Boolean Delete(SqlInt32 QuoteID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Quote_Delete");

            sqlDB.AddInParameter(dbCMD, "@QuoteID", SqlDbType.Int, QuoteID);

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.ExecuteNonQuery(sqlDB, dbCMD);

            return true;
        }
        catch (SqlException sqlex)
        {
            Message = SQLDataExceptionMessage(sqlex);
            if (SQLDataExceptionHandler(sqlex))
                throw;
            return false;
        }
        catch (Exception ex)
        {
            Message = ExceptionMessage(ex);
            if (ExceptionHandler(ex))
                throw;
            return false;
        }
    }

    #endregion DeleteOperation

    #region SelectOperation

    public MST_QuoteENT SelectPK(SqlInt32 QuoteID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Quote_SelectPK");

            sqlDB.AddInParameter(dbCMD, "@QuoteID", SqlDbType.Int, QuoteID);

            MST_QuoteENT entMST_Quote = new MST_QuoteENT();
            DataBaseHelper DBH = new DataBaseHelper();
            using (IDataReader dr = DBH.ExecuteReader(sqlDB, dbCMD))
            {
                while (dr.Read())
                {
                    if (!dr["QuoteID"].Equals(System.DBNull.Value))
                        entMST_Quote.QuoteID = Convert.ToInt32(dr["QuoteID"]);

                    if (!dr["Quote"].Equals(System.DBNull.Value))
                        entMST_Quote.Quote = Convert.ToString(dr["Quote"]);

                    if (!dr["CategoryID"].Equals(System.DBNull.Value))
                        entMST_Quote.CategoryID = Convert.ToInt32(dr["CategoryID"]);

                    if (!dr["AuthorID"].Equals(System.DBNull.Value))
                        entMST_Quote.AuthorID = Convert.ToInt32(dr["AuthorID"]);

                    if (!dr["IsActive"].Equals(System.DBNull.Value))
                        entMST_Quote.IsActive = Convert.ToBoolean(dr["IsActive"]);

                    if (!dr["Sequence"].Equals(System.DBNull.Value))
                        entMST_Quote.Sequence = Convert.ToDecimal(dr["Sequence"]);

                    if (!dr["Created"].Equals(System.DBNull.Value))
                        entMST_Quote.Created = Convert.ToDateTime(dr["Created"]);

                    if (!dr["Modified"].Equals(System.DBNull.Value))
                        entMST_Quote.Modified = Convert.ToDateTime(dr["Modified"]);

                }
            }
            return entMST_Quote;
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
    public DataTable SelectView(SqlInt32 QuoteID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Quote_SelectView");

            sqlDB.AddInParameter(dbCMD, "@QuoteID", SqlDbType.Int, QuoteID);

            DataTable dtMST_Quote = new DataTable("PR_MST_Quote_SelectView");

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
    public DataTable SelectAll()
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Quote_SelectAll");

            DataTable dtMST_Quote = new DataTable("PR_MST_Quote_SelectAll");

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

    #endregion SelectOperation

    #region ComboBox

    public DataTable SelectComboBox()
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Quote_SelectComboBox");

            DataTable dtADM_Round = new DataTable("PR_MST_Quote_SelectComboBox");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtADM_Round);

            return dtADM_Round;
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

    #endregion ComboBox

    #region AutoComplete


    #endregion AutoComplete

}