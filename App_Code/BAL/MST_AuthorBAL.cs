using QuoteWeb.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_AuthorBAL
/// </summary>
public class MST_AuthorBAL : MST_AuthorBALBase
{
    #region Constructor
    public MST_AuthorBAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    #endregion

    public DataTable SelectComboBox()
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        return dalMST_Author.SelectComboBox();
    }

    public DataTable SelectForAuthor()
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        return dalMST_Author.SelectForAuthor();
    }

    public DataTable SelectQuoteByAuthorURL(SqlString AuthorURL)
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        return dalMST_Author.SelectQuoteByAuthorURL(AuthorURL);
    }

    public DataTable SelectForTopAuthor()
    {
        MST_AuthorDAL dalMST_Author = new MST_AuthorDAL();
        return dalMST_Author.SelectForTopAuthor();
    }
}