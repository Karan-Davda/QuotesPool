using QuoteWeb.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_CategoryBAL
/// </summary>
public class MST_CategoryBAL : MST_CategoryBALBase
{
    #region Constructor
    public MST_CategoryBAL()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    #endregion 

    public DataTable SelectComboBox()
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        return dalMST_Category.SelectComboBox();
    }

    public DataTable SelectForCategory()
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        return dalMST_Category.SelectForCategory();
    }

    public DataTable SelectForTopCategory()
    {
        MST_CategoryDAL dalMST_Category = new MST_CategoryDAL();
        return dalMST_Category.SelectForTopCategory();
    }
}