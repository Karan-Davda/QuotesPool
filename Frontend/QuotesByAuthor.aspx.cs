using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Frontend_QuotesByAuthor : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        FillAuthorQuote();
    }
    #region Fill Quote By CategoryURL
    private void FillAuthorQuote()
    {
        SqlString AuthorURL = SqlString.Null;

        if (Page.RouteData.Values["AuthorURL"] != null)
            AuthorURL = Page.RouteData.Values["AuthorURL"].ToString();

        MST_AuthorBAL balMST_Author = new MST_AuthorBAL();
        DataTable dtMST_Author = balMST_Author.SelectQuoteByAuthorURL(AuthorURL);

        if (dtMST_Author != null && dtMST_Author.Rows.Count > 0)
        {
            foreach (DataRow dr in dtMST_Author.Rows)
            {
                if (!dr["AuthorName"].Equals(DBNull.Value))
                {
                    Page.Title = dr["AuthorName"].ToString() + " Quotes, " + dr["AuthorName"].ToString() + " ";
                    //lblCategoryName.Text = dr["AuthorName"].ToString() + " Quotes";
                    //lblCategory1.Text = dr["AuthorName"].ToString() + " Quotes";
                    lblAuthorName.Text = dr["AuthorName"].ToString();
                }

                if (!dr["Occupation"].Equals(DBNull.Value))
                {
                    lblOccupation.Text = dr["Occupation"].ToString();
                }

                if (!dr["AuthorDOB"].Equals(DBNull.Value))
                {
                    lblAuthorDOB.Text = dr["AuthorDOB"].ToString();
                    lblAuthorDOB.ToolTip = dr["AuthorName"].ToString() + " was born in " + dr["AuthorDOB"].ToString();
                }

                if (!dr["Birthplace"].Equals(DBNull.Value))
                {
                    lblBirthplace.Text = dr["Birthplace"].ToString();
                    lblBirthplace.ToolTip = dr["AuthorName"].ToString() + " 's birthplace - " + dr["Birthplace"].ToString();
                }
                else
                {
                    lblBirthplace.Text = "Unknown";
                    lblBirthplace.ToolTip = "Unknown";
                }

                if (!dr["Remarks"].Equals(DBNull.Value))
                {
                    lblRemarks.Text = dr["Remarks"].ToString();
                }

                if (!dr["Image"].Equals(DBNull.Value))
                {
                    imgAuthor.ImageUrl = dr["Image"].ToString();
                    imgAuthor.AlternateText = dr["AuthorName"].ToString();
                }
                else
                {
                    imgAuthor.ImageUrl = "~/Content/img/CommonAuthorImage.jpg";
                    imgAuthor.AlternateText = dr["AuthorName"].ToString();
                }

                //    if (!dr["WikiURL"].Equals(DBNull.Value))
                //    {
                //        hlWikiAuthor.NavigateUrl = dr["WikiURL"].ToString();
                //        hlWikiAuthor.ToolTip = "Read more about " + dr["AuthorName"].ToString();
                //    }
            }
            rpAuthorQuote.DataSource = dtMST_Author;
            rpAuthorQuote.DataBind();
        }
    }
    #endregion Fill Quote By CategoryURL
}