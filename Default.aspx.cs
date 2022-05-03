using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Title = "Quote of the Day, Famous Quotes, Inspirational - Motivational Quotes, Positive, Popular Quotes Collections";
        //FillTodayQuote();
        FillCategories();
        FillAuthors();
    }

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

    #region FillTodayQuote
    //private void FillTodayQuote()
    //{
    //    DataTable dtMST_Quote;
    //    MST_QuoteBAL balMST_Quote = new MST_QuoteBAL();
    //    dtMST_Quote = balMST_Quote.SelectForTodayQuote();
    //    if (dtMST_Quote != null && dtMST_Quote.Rows.Count > 0)
    //    {
    //        foreach (DataRow dr in dtMST_Quote.Rows)
    //        {
    //            if (!dr["CategoryName"].Equals(DBNull.Value))
    //            {
    //                hlCategoryName.Text = dr["CategoryName"].ToString();
    //                hlCategoryName.ToolTip = dr["CategoryName"].ToString() + " quotes";
    //            }

    //            if (!dr["CategoryURL"].Equals(DBNull.Value))
    //            {
    //                hlCategoryName.NavigateUrl = "~/" + dr["CategoryURL"].ToString() + "/quotes";
    //            }

    //            if (!dr["AuthorName"].Equals(DBNull.Value))
    //            {
    //                hlAuthor.Text = dr["AuthorName"].ToString();
    //                hlAuthor.ToolTip = dr["AuthorName"].ToString() + " quotes";
    //            }

    //            if (!dr["AuthorURL"].Equals(DBNull.Value))
    //            {
    //                hlAuthor.NavigateUrl = "~/" + dr["AuthorURL"].ToString() + "/quotes";
    //            }

    //            if (!dr["Quote"].Equals(DBNull.Value))
    //            {
    //                lblQuote.Text = dr["Quote"].ToString();
    //            }

    //            if (!dr["Today"].Equals(DBNull.Value))
    //            {
    //                lblToday.Text = dr["Today"].ToString();
    //            }
    //        }

    //    }
    //}
    #endregion FillTodayQuote
}