using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MST_QuoteBAL
/// </summary>
public class MST_QuoteBAL : MST_QuoteBALBase
{
	public MST_QuoteBAL()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public DataTable SelectQuoteByCategoryURL(SqlString CategoryURL)
    {
        MST_QuoteDAL dalMST_Quote = new MST_QuoteDAL();
        return dalMST_Quote.SelectQuoteByCategoryURL(CategoryURL);
    }

    public DataTable SelectForTodayQuote()
    {
        MST_QuoteDAL dalMST_Quote = new MST_QuoteDAL();
        return dalMST_Quote.SelectForTodayQuote();
    }
}