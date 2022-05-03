using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_LetterBALBase
/// </summary>
public class MST_LetterBALBase
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
    public MST_LetterBALBase()
	{
		//
		// TODO: Add constructor logic here
		//
    }
    #endregion

    #region InsertOperation

    public Boolean Insert(MST_LetterENT entMST_Letter)
    {
        MST_LetterDAL dalMST_Letter = new MST_LetterDAL();
        if (dalMST_Letter.Insert(entMST_Letter))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Letter.Message;
            return false;
        }
    }

    #endregion InsertOperation

    #region UpdateOperation

    public Boolean Update(MST_LetterENT entMST_Letter)
    {
        MST_LetterDAL dalMST_Letter = new MST_LetterDAL();
        if (dalMST_Letter.Update(entMST_Letter))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Letter.Message;
            return false;
        }
    }

    #endregion UpdateOperation

    #region DeleteOperation

    public Boolean Delete(SqlInt32 LetterID)
    {
        MST_LetterDAL dalMST_Letter = new MST_LetterDAL();
        if (dalMST_Letter.Delete(LetterID))
        {
            return true;
        }
        else
        {
            this.Message = dalMST_Letter.Message;
            return false;
        }
    }

    #endregion DeleteOperation

    #region SelectOperation

    public MST_LetterENT SelectPK(SqlInt32 LetterID)
    {
        MST_LetterDAL dalMST_Letter = new MST_LetterDAL();
        return dalMST_Letter.SelectPK(LetterID);
    }

    public DataTable SelectView(SqlInt32 LetterID)
    {
        MST_LetterDAL dalMST_Letter = new MST_LetterDAL();
        return dalMST_Letter.SelectView(LetterID);
    }

    public DataTable SelectAll()
    {
        MST_LetterDAL dalMST_Letter = new MST_LetterDAL();
        return dalMST_Letter.SelectAll();
    }

    #endregion SelectOperation

    #region ComboBox

    public DataTable SelectComboBox()
    {
        MST_LetterDAL dalMST_Letter = new MST_LetterDAL();
        return dalMST_Letter.SelectComboBox();
    }

    #endregion ComboBox
}