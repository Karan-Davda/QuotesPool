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
/// Summary description for MST_AuthorDALBase
/// </summary>
public class MST_AuthorDALBase : DataBaseConfig
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
    public MST_AuthorDALBase()
	{
		//
		// TODO: Add constructor logic here
		//
    }
    #endregion

    #region InsertOperation

    public Boolean Insert(MST_AuthorENT entMST_Author)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Author_Insert");

            sqlDB.AddOutParameter(dbCMD, "@AuthorID", SqlDbType.Int, 4);
            sqlDB.AddInParameter(dbCMD, "@LetterID", SqlDbType.Int, entMST_Author.LetterID);
            sqlDB.AddInParameter(dbCMD, "@AuthorName", SqlDbType.VarChar, entMST_Author.AuthorName);
            sqlDB.AddInParameter(dbCMD, "@NickName", SqlDbType.VarChar, entMST_Author.NickName);
            sqlDB.AddInParameter(dbCMD, "@AuthorURL", SqlDbType.VarChar, entMST_Author.AuthorURL);
            sqlDB.AddInParameter(dbCMD, "@AuthorDOB", SqlDbType.VarChar, entMST_Author.AuthorDOB);
            sqlDB.AddInParameter(dbCMD, "@AuthorDead", SqlDbType.VarChar, entMST_Author.AuthorDead);
            sqlDB.AddInParameter(dbCMD, "@Birthplace", SqlDbType.VarChar, entMST_Author.Birthplace);
            sqlDB.AddInParameter(dbCMD, "@Image", SqlDbType.VarChar, entMST_Author.Image);
            sqlDB.AddInParameter(dbCMD, "@Remarks", SqlDbType.VarChar, entMST_Author.Remarks);
            sqlDB.AddInParameter(dbCMD, "@IsActive", SqlDbType.Bit, entMST_Author.IsActive);
            sqlDB.AddInParameter(dbCMD, "@Sequence", SqlDbType.Decimal, entMST_Author.Sequence);
            sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entMST_Author.Created);
            sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entMST_Author.Modified);
            sqlDB.AddInParameter(dbCMD, "@Occupation", SqlDbType.VarChar, entMST_Author.Occupation);
            sqlDB.AddInParameter(dbCMD, "@WikiURL", SqlDbType.VarChar, entMST_Author.WikiURL);

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.ExecuteNonQuery(sqlDB, dbCMD);

            entMST_Author.AuthorID = (SqlInt32)Convert.ToInt32(dbCMD.Parameters["@AuthorID"].Value);

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

    public Boolean Update(MST_AuthorENT entMST_Author)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Author_Update");

            sqlDB.AddInParameter(dbCMD, "@AuthorID", SqlDbType.Int, entMST_Author.AuthorID);
            sqlDB.AddInParameter(dbCMD, "@LetterID", SqlDbType.Int, entMST_Author.LetterID);
            sqlDB.AddInParameter(dbCMD, "@AuthorName", SqlDbType.VarChar, entMST_Author.AuthorName);
            sqlDB.AddInParameter(dbCMD, "@NickName", SqlDbType.VarChar, entMST_Author.NickName);
            sqlDB.AddInParameter(dbCMD, "@AuthorURL", SqlDbType.VarChar, entMST_Author.AuthorURL);
            sqlDB.AddInParameter(dbCMD, "@AuthorDOB", SqlDbType.VarChar, entMST_Author.AuthorDOB);
            sqlDB.AddInParameter(dbCMD, "@AuthorDead", SqlDbType.VarChar, entMST_Author.AuthorDead);
            sqlDB.AddInParameter(dbCMD, "@Birthplace", SqlDbType.VarChar, entMST_Author.Birthplace);
            sqlDB.AddInParameter(dbCMD, "@Image", SqlDbType.VarChar, entMST_Author.Image);
            sqlDB.AddInParameter(dbCMD, "@Remarks", SqlDbType.VarChar, entMST_Author.Remarks);
            sqlDB.AddInParameter(dbCMD, "@IsActive", SqlDbType.Bit, entMST_Author.IsActive);
            sqlDB.AddInParameter(dbCMD, "@Sequence", SqlDbType.Decimal, entMST_Author.Sequence);
            sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entMST_Author.Created);
            sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entMST_Author.Modified);
            sqlDB.AddInParameter(dbCMD, "@Occupation", SqlDbType.VarChar, entMST_Author.Occupation);
            sqlDB.AddInParameter(dbCMD, "@WikiURL", SqlDbType.VarChar, entMST_Author.WikiURL);

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

    public Boolean Delete(SqlInt32 AuthorID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Author_Delete");

            sqlDB.AddInParameter(dbCMD, "@AuthorID", SqlDbType.Int, AuthorID);

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

    public MST_AuthorENT SelectPK(SqlInt32 AuthorID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Author_SelectPK");

            sqlDB.AddInParameter(dbCMD, "@AuthorID", SqlDbType.Int, AuthorID);

            MST_AuthorENT entMST_Author = new MST_AuthorENT();
            DataBaseHelper DBH = new DataBaseHelper();
            using (IDataReader dr = DBH.ExecuteReader(sqlDB, dbCMD))
            {
                while (dr.Read())
                {
                    if (!dr["AuthorID"].Equals(System.DBNull.Value))
                        entMST_Author.AuthorID = Convert.ToInt32(dr["AuthorID"]);

                    if (!dr["AuthorName"].Equals(System.DBNull.Value))
                        entMST_Author.AuthorName = Convert.ToString(dr["AuthorName"]);

                    if (!dr["AuthorURL"].Equals(System.DBNull.Value))
                        entMST_Author.AuthorURL = Convert.ToString(dr["AuthorURL"]);

                    if (!dr["AuthorDOB"].Equals(System.DBNull.Value))
                        entMST_Author.AuthorDOB = Convert.ToString(dr["AuthorDOB"]);

                    if (!dr["AuthorDead"].Equals(System.DBNull.Value))
                        entMST_Author.AuthorDead = Convert.ToString(dr["AuthorDead"]);

                    if (!dr["Birthplace"].Equals(System.DBNull.Value))
                        entMST_Author.Birthplace = Convert.ToString(dr["Birthplace"]);

                    if (!dr["Image"].Equals(System.DBNull.Value))
                        entMST_Author.Image = Convert.ToString(dr["Image"]);

                    if (!dr["Remarks"].Equals(System.DBNull.Value))
                        entMST_Author.Remarks = Convert.ToString(dr["Remarks"]);

                    if (!dr["IsActive"].Equals(System.DBNull.Value))
                        entMST_Author.IsActive = Convert.ToBoolean(dr["IsActive"]);

                    if (!dr["Sequence"].Equals(System.DBNull.Value))
                        entMST_Author.Sequence = Convert.ToDecimal(dr["Sequence"]);

                    if (!dr["Created"].Equals(System.DBNull.Value))
                        entMST_Author.Created = Convert.ToDateTime(dr["Created"]);

                    if (!dr["Modified"].Equals(System.DBNull.Value))
                        entMST_Author.Modified = Convert.ToDateTime(dr["Modified"]);

                    if (!dr["Occupation"].Equals(System.DBNull.Value))
                        entMST_Author.Occupation = Convert.ToString(dr["Occupation"]);

                    if (!dr["WikiURL"].Equals(System.DBNull.Value))
                        entMST_Author.WikiURL = Convert.ToString(dr["WikiURL"]);

                }
            }
            return entMST_Author;
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
    public DataTable SelectView(SqlInt32 AuthorID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Author_SelectView");

            sqlDB.AddInParameter(dbCMD, "@AuthorID", SqlDbType.Int, AuthorID);

            DataTable dtMST_Author = new DataTable("PR_MST_Author_SelectView");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtMST_Author);

            return dtMST_Author;
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
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Author_SelectAll");

            DataTable dtMST_Author = new DataTable("PR_MST_Author_SelectAll");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtMST_Author);

            return dtMST_Author;
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
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Author_SelectComboBox");

            DataTable dtADM_Round = new DataTable("PR_MST_Author_SelectComboBox");

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
}