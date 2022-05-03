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
/// Summary description for MST_CategoryDALBase
/// </summary>
public class MST_CategoryDALBase : DataBaseConfig
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
    public MST_CategoryDALBase()
	{
		//
		// TODO: Add constructor logic here
		//
    }
    #endregion

    #region InsertOperation

    public Boolean Insert(MST_CategoryENT entMST_Category)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Category_Insert");

            sqlDB.AddOutParameter(dbCMD, "@CategoryID", SqlDbType.Int, 4);
            sqlDB.AddInParameter(dbCMD, "@CategoryName", SqlDbType.VarChar, entMST_Category.CategoryName);
            sqlDB.AddInParameter(dbCMD, "@CategoryIcon", SqlDbType.VarChar, entMST_Category.CategoryIcon);
            sqlDB.AddInParameter(dbCMD, "@CategoryURL", SqlDbType.VarChar, entMST_Category.CategoryURL);
            sqlDB.AddInParameter(dbCMD, "@CategoryDescription", SqlDbType.VarChar, entMST_Category.CategoryDescription);
            sqlDB.AddInParameter(dbCMD, "@IsActive", SqlDbType.Bit, entMST_Category.IsActive);
            sqlDB.AddInParameter(dbCMD, "@Sequence", SqlDbType.Decimal, entMST_Category.Sequence);
            sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entMST_Category.Created);
            sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entMST_Category.Modified);

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.ExecuteNonQuery(sqlDB, dbCMD);

            entMST_Category.CategoryID = (SqlInt32)Convert.ToInt32(dbCMD.Parameters["@CategoryID"].Value);

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

    public Boolean Update(MST_CategoryENT entMST_Category)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Category_Update");

            sqlDB.AddInParameter(dbCMD, "@CategoryID", SqlDbType.Int, entMST_Category.CategoryID);
            sqlDB.AddInParameter(dbCMD, "@CategoryName", SqlDbType.VarChar, entMST_Category.CategoryName);
            sqlDB.AddInParameter(dbCMD, "@CategoryIcon", SqlDbType.VarChar, entMST_Category.CategoryIcon);
            sqlDB.AddInParameter(dbCMD, "@CategoryURL", SqlDbType.VarChar, entMST_Category.CategoryURL);
            sqlDB.AddInParameter(dbCMD, "@CategoryDescription", SqlDbType.VarChar, entMST_Category.CategoryDescription);
            sqlDB.AddInParameter(dbCMD, "@IsActive", SqlDbType.Bit, entMST_Category.IsActive);
            sqlDB.AddInParameter(dbCMD, "@Sequence", SqlDbType.Decimal, entMST_Category.Sequence);
            sqlDB.AddInParameter(dbCMD, "@Created", SqlDbType.DateTime, entMST_Category.Created);
            sqlDB.AddInParameter(dbCMD, "@Modified", SqlDbType.DateTime, entMST_Category.Modified);

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

    public Boolean Delete(SqlInt32 CategoryID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Category_Delete");

            sqlDB.AddInParameter(dbCMD, "@CategoryID", SqlDbType.Int, CategoryID);

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

    public MST_CategoryENT SelectPK(SqlInt32 CategoryID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Category_SelectPK");

            sqlDB.AddInParameter(dbCMD, "@CategoryID", SqlDbType.Int, CategoryID);

            MST_CategoryENT entMST_Category = new MST_CategoryENT();
            DataBaseHelper DBH = new DataBaseHelper();
            using (IDataReader dr = DBH.ExecuteReader(sqlDB, dbCMD))
            {
                while (dr.Read())
                {
                    if (!dr["CategoryID"].Equals(System.DBNull.Value))
                        entMST_Category.CategoryID = Convert.ToInt32(dr["CategoryID"]);

                    if (!dr["CategoryName"].Equals(System.DBNull.Value))
                        entMST_Category.CategoryName = Convert.ToString(dr["CategoryName"]);

                    if (!dr["CategoryIcon"].Equals(System.DBNull.Value))
                        entMST_Category.CategoryIcon = Convert.ToString(dr["CategoryIcon"]);

                    if (!dr["CategoryURL"].Equals(System.DBNull.Value))
                        entMST_Category.CategoryURL = Convert.ToString(dr["CategoryURL"]);

                    if (!dr["CategoryDescription"].Equals(System.DBNull.Value))
                        entMST_Category.CategoryDescription = Convert.ToString(dr["CategoryDescription"]);

                    if (!dr["IsActive"].Equals(System.DBNull.Value))
                        entMST_Category.IsActive = Convert.ToBoolean(dr["IsActive"]);

                    if (!dr["Sequence"].Equals(System.DBNull.Value))
                        entMST_Category.Sequence = Convert.ToDecimal(dr["Sequence"]);

                    if (!dr["Created"].Equals(System.DBNull.Value))
                        entMST_Category.Created = Convert.ToDateTime(dr["Created"]);

                    if (!dr["Modified"].Equals(System.DBNull.Value))
                        entMST_Category.Modified = Convert.ToDateTime(dr["Modified"]);

                }
            }
            return entMST_Category;
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
    public DataTable SelectView(SqlInt32 CategoryID)
    {
        try
        {
            SqlDatabase sqlDB = new SqlDatabase(myConnectionString);
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Category_SelectView");

            sqlDB.AddInParameter(dbCMD, "@CategoryID", SqlDbType.Int, CategoryID);

            DataTable dtMST_Category = new DataTable("PR_MST_Category_SelectView");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtMST_Category);

            return dtMST_Category;
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
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Category_SelectAll");

            DataTable dtMST_Category = new DataTable("PR_MST_Category_SelectAll");

            DataBaseHelper DBH = new DataBaseHelper();
            DBH.LoadDataTable(sqlDB, dbCMD, dtMST_Category);

            return dtMST_Category;
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
            DbCommand dbCMD = sqlDB.GetStoredProcCommand("PR_MST_Category_SelectComboBox");

            DataTable dtADM_Round = new DataTable("PR_MST_Category_SelectComboBox");

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