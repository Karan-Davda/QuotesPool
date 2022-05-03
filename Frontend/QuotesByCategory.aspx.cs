using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Frontend_QuotesByCategory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillQuoteByCategoryURL();
        FillCategories();
        FillAuthors();
    }

    #region Fill Quote By CategoryURL
    private void FillQuoteByCategoryURL()
    {
        SqlString CategoryURL = SqlString.Null;

        if (Page.RouteData.Values["CategoryURL"] != null)
            CategoryURL = Page.RouteData.Values["CategoryURL"].ToString();

        MST_QuoteBAL balMST_Quote = new MST_QuoteBAL();
        DataTable dtMST_Quote = balMST_Quote.SelectQuoteByCategoryURL(CategoryURL);

        if (dtMST_Quote != null && dtMST_Quote.Rows.Count > 0)
        {
            foreach (DataRow dr in dtMST_Quote.Rows)
            {
                if (!dr["CategoryName"].Equals(DBNull.Value))
                {
                    Page.Title = dr["CategoryName"].ToString() + " Quotes, " + dr["CategoryName"].ToString() + " ";
                    lblCategory1.Text = dr["CategoryName"].ToString() + " Quotes";
                }
            }
            rpQuoteByCategory.DataSource = dtMST_Quote;
            rpQuoteByCategory.DataBind();
        }
    }
    #endregion Fill Quote By CategoryURL

    #region FillCategories
    private void FillCategories()
    {
        DataTable dtMST_Category;
        MST_CategoryBAL balMST_Category = new MST_CategoryBAL();
        dtMST_Category = balMST_Category.SelectForTopCategory();
        if (dtMST_Category != null && dtMST_Category.Rows.Count > 0)
        {
            rpCategory.DataSource = dtMST_Category;
            rpCategory.DataBind();
        }
    }
    #endregion FillCategories

    #region FillAuthors
    private void FillAuthors()
    {
        DataTable dtMST_Author;
        MST_AuthorBAL balMST_Author = new MST_AuthorBAL();
        dtMST_Author = balMST_Author.SelectForTopAuthor();
        if (dtMST_Author != null && dtMST_Author.Rows.Count > 0)
        {
            rpAuthor.DataSource = dtMST_Author;
            rpAuthor.DataBind();
        }
    }
    #endregion FillAuthors
}