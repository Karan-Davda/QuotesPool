using QuoteWeb.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_AuthorBALBase
/// </summary>
public class MST_AuthorBALBase 
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
    public MST_AuthorBALBase()
	{
		//
		// TODO: Add constructor logic here
		//
    }
    #endregion

    #region InsertOperation

    public Boolean Insert(MST_AuthorENT entMST_Author)
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        if (dalMST_Author.Insert(entMST_Author))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Author.Message;
            return false;
        }
    }

    #endregion InsertOperation

    #region UpdateOperation

    public Boolean Update(MST_AuthorENT entMST_Author)
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        if (dalMST_Author.Update(entMST_Author))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Author.Message;
            return false;
        }
    }

    #endregion UpdateOperation

    #region DeleteOperation

    public Boolean Delete(SqlInt32 AuthorID)
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        if (dalMST_Author.Delete(AuthorID))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Author.Message;
            return false;
        }
    }

    #endregion DeleteOperation

    #region SelectOperation

    public MST_AuthorENT SelectPK(SqlInt32 AuthorID)
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        return dalMST_Author.SelectPK(AuthorID);
    }

    public DataTable SelectView(SqlInt32 AuthorID)
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        return dalMST_Author.SelectView(AuthorID);
    }

    public DataTable SelectAll()
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        return dalMST_Author.SelectAll();
    }

    #endregion SelectOperation

    #region ComboBox

    public DataTable SelectComboBox()
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        return dalMST_Author.SelectComboBox();
    }

    #endregion ComboBox
}