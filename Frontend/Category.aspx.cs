using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Frontend_Category : System.Web.UI.Page
{
    #region Page Load
    protected void Page_Load(object sender, EventArgs e)
    {
        FillCategory();
        Page.Title = "Category wise multiple choice questions | .in";
    }
    #endregion Page Load

    #region FillCategory
    private void FillCategory()
    {
        DataTable dtMST_Category;
        MST_CategoryBAL balMST_Category = new MST_CategoryBAL();
        dtMST_Category = balMST_Category.SelectForCategory();
        if (dtMST_Category != null && dtMST_Category.Rows.Count > 0)
        {
            rpCategory.DataSource = dtMST_Category;
            rpCategory.DataBind();
        }
    }
    #endregion FillCategory
}