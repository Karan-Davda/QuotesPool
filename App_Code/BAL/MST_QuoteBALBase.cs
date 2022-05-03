using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_QuoteBAL
/// </summary>
public class MST_QuoteBALBase
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

    public MST_QuoteBALBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    #endregion Constructor

    #region InsertOperation

    public Boolean Insert(MST_QuoteENT entMST_Quote)
    {
        MST_QuoteDAL dalMST_Quote = new MST_QuoteDAL();
        if (dalMST_Quote.Insert(entMST_Quote))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Quote.Message;
            return false;
        }
    }

    #endregion InsertOperation

    #region UpdateOperation

    public Boolean Update(MST_QuoteENT entMST_Quote)
    {
        MST_QuoteDAL dalMST_Quote = new MST_QuoteDAL();
        if (dalMST_Quote.Update(entMST_Quote))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Quote.Message;
            return false;
        }
    }

    #endregion UpdateOperation

    #region DeleteOperation

    public Boolean Delete(SqlInt32 QuoteID)
    {
        MST_QuoteDAL dalMST_Quote = new MST_QuoteDAL();
        if (dalMST_Quote.Delete(QuoteID))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Quote.Message;
            return false;
        }
    }

    #endregion DeleteOperation

    #region SelectOperation

    public MST_QuoteENT SelectPK(SqlInt32 QuoteID)
    {
        MST_QuoteDAL dalMST_Quote = new MST_QuoteDAL();
        return dalMST_Quote.SelectPK(QuoteID);
    }

    public DataTable SelectView(SqlInt32 QuoteID)
    {
        MST_QuoteDAL dalMST_Quote = new MST_QuoteDAL();
        return dalMST_Quote.SelectView(QuoteID);
    }

    public DataTable SelectAll()
    {
        MST_QuoteDAL dalMST_Quote = new MST_QuoteDAL();
        return dalMST_Quote.SelectAll();
    }

    #endregion SelectOperation

    #region ComboBox

    public DataTable SelectComboBox()
    {
        MST_QuoteDAL dalMST_Quote = new MST_QuoteDAL();
        return dalMST_Quote.SelectComboBox();
    }

    #endregion ComboBox

}