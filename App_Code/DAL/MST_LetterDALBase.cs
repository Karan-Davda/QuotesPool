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
/// Summary description for MST_LetterDALBase
/// </summary>
public class MST_LetterDALBase : DataBaseConfig
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
    public MST_LetterDALBase()
	{
		//
		// TODO: Add constructor logic here
		//
    }
    #endregion

    #region InsertOperation

    public Boolean Insert(MST_LetterENT entMST_Letter)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Letter_Insert");

            sqlDB.AddOutParameter(dbCMD, "@LetterID", SqlDbType.Int, 4);
            sqlDB.AddInParameter(dbCMD, "@LetterName", SqlDbType.VarChar, entMST_Letter.LetterName);
            sqlDB.AddInParameter(dbCMD, "@LetterURL", SqlDbType.VarChar, entMST_Letter.LetterURL);
            sqlDB.AddInParameter(dbCMD, "@Image", SqlDbType.VarChar, entMST_Letter.Image);
            sqlDB.AddInParameter(dbCMD, "@IsActive", SqlDbType.Bit, entMST_Letter.IsActive);
            sqlDB.AddInParameter(dbCMD, "@Sequence", SqlDbType.Decimal, entMST_Letter.Sequence);
            sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entMST_Letter.Created);
            sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entMST_Letter.Modified);

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.ExecuteNonQuery(sqlDB, dbCMD);

            entMST_Letter.LetterID = (SqlInt32)Convert.ToInt32(dbCMD.Parameters["@LetterID"].Value);

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

    public Boolean Update(MST_LetterENT entMST_Letter)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Letter_Update");

            sqlDB.AddInParameter(dbCMD, "@LetterID", SqlDbType.Int, entMST_Letter.LetterID);
            sqlDB.AddInParameter(dbCMD, "@LetterName", SqlDbType.VarChar, entMST_Letter.LetterName);
            sqlDB.AddInParameter(dbCMD, "@LetterURL", SqlDbType.VarChar, entMST_Letter.LetterURL);
            sqlDB.AddInParameter(dbCMD, "@Image", SqlDbType.VarChar, entMST_Letter.Image);
            sqlDB.AddInParameter(dbCMD, "@IsActive", SqlDbType.Bit, entMST_Letter.IsActive);
            sqlDB.AddInParameter(dbCMD, "@Sequence", SqlDbType.Decimal, entMST_Letter.Sequence);
            sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entMST_Letter.Created);
            sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entMST_Letter.Modified);

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

    public Boolean Delete(SqlInt32 LetterID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Letter_Delete");

            sqlDB.AddInParameter(dbCMD, "@LetterID", SqlDbType.Int, LetterID);

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

    public MST_LetterENT SelectPK(SqlInt32 LetterID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Letter_SelectPK");

            sqlDB.AddInParameter(dbCMD, "@LetterID", SqlDbType.Int, LetterID);

            MST_LetterENT entMST_Letter = new MST_LetterENT();
            DataBaseHelper DBH = new DataBaseHelper();
            using (IDataReader dr = DBH.ExecuteReader(sqlDB, dbCMD))
            {
                while (dr.Read())
                {
                    if (!dr["LetterID"].Equals(System.DBNull.Value))
                        entMST_Letter.LetterID = Convert.ToInt32(dr["LetterID"]);

                    if (!dr["LetterName"].Equals(System.DBNull.Value))
                        entMST_Letter.LetterName = Convert.ToString(dr["LetterName"]);

                    if (!dr["LetterURL"].Equals(System.DBNull.Value))
                        entMST_Letter.LetterURL = Convert.ToString(dr["LetterURL"]);

                    if (!dr["Image"].Equals(System.DBNull.Value))
                        entMST_Letter.Image = Convert.ToString(dr["Image"]);

                    if (!dr["IsActive"].Equals(System.DBNull.Value))
                        entMST_Letter.IsActive = Convert.ToBoolean(dr["IsActive"]);

                    if (!dr["Sequence"].Equals(System.DBNull.Value))
                        entMST_Letter.Sequence = Convert.ToDecimal(dr["Sequence"]);

                    if (!dr["Created"].Equals(System.DBNull.Value))
                        entMST_Letter.Created = Convert.ToDateTime(dr["Created"]);

                    if (!dr["Modified"].Equals(System.DBNull.Value))
                        entMST_Letter.Modified = Convert.ToDateTime(dr["Modified"]);

                }
            }
            return entMST_Letter;
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
    public DataTable SelectView(SqlInt32 LetterID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Letter_SelectView");

            sqlDB.AddInParameter(dbCMD, "@LetterID", SqlDbType.Int, LetterID);

            DataTable dtMST_Letter = new DataTable("PR_MST_Letter_SelectView");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtMST_Letter);

            return dtMST_Letter;
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
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Letter_SelectAll");

            DataTable dtMST_Letter = new DataTable("PR_MST_Letter_SelectAll");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtMST_Letter);

            return dtMST_Letter;
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
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Letter_SelectComboBox");

            DataTable dtADM_Round = new DataTable("PR_MST_Letter_SelectComboBox");

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