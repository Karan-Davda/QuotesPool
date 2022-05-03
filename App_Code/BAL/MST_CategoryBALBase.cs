using QuoteWeb.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_CategoryBALBase
/// </summary>
public class MST_CategoryBALBase
{
    #region Private Fields

    private string _Message;

    #endregion Private Fields

    #region Public Properties

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

    #endregion Public Properties

    #region Constructor

    public MST_CategoryBALBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion Constructor

    #region InsertOperation

    public Boolean Insert(MST_CategoryENT entMST_Category)
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        if (dalMST_Category.Insert(entMST_Category))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Category.Message;
            return false;
        }
    }

    #endregion InsertOperation

    #region UpdateOperation

    public Boolean Update(MST_CategoryENT entMST_Category)
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        if (dalMST_Category.Update(entMST_Category))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Category.Message;
            return false;
        }
    }

    #endregion UpdateOperation

    #region DeleteOperation

    public Boolean Delete(SqlInt32 CategoryID)
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        if (dalMST_Category.Delete(CategoryID))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Category.Message;
            return false;
        }
    }

    #endregion DeleteOperation

    #region SelectOperation

    public MST_CategoryENT SelectPK(SqlInt32 CategoryID)
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        return dalMST_Category.SelectPK(CategoryID);
    }

    public DataTable SelectView(SqlInt32 CategoryID)
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        return dalMST_Category.SelectView(CategoryID);
    }

    public DataTable SelectAll()
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        return dalMST_Category.SelectAll();
    }

    #endregion SelectOperation

    #region ComboBox

    public DataTable SelectComboBox()
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        return dalMST_Category.SelectComboBox();
    }

    #endregion ComboBox
	
}