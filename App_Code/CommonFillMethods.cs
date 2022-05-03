using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using QuoteWeb.DAL;
using QuoteWeb;
namespace QuoteWeb
{
	public class CommonFillMethods
	{
		public CommonFillMethods()
		{
		}
		public static void FillDropDownListCategoryID(DropDownList ddl)
		{
            MST_CategoryBAL balMST_Category = new MST_CategoryBAL();
            ddl.DataSource = balMST_Category.SelectComboBox();
            ddl.DataValueField = "CategoryID";
            ddl.DataTextField = "CategoryName";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem(" Select One ", "-99"));
		}


        public static void FillDropDownListAuthorID(DropDownList ddl)
        {
            MST_AuthorBAL balMST_Author = new MST_AuthorBAL();
            ddl.DataSource = balMST_Author.SelectComboBox();
            ddl.DataValueField = "AuthorID";
            ddl.DataTextField = "AuthorName";
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem(" Select One ", "-99"));
        }

        public static void FillDropDownListFilterType(DropDownList ddl)
        {
            //ddl.Items.Insert(0, new ListItem(" Select Filter Type ", "-99"));
            //ddl.Items.Insert(01, new ListItem("DropDown", "DropDown"));
            //ddl.Items.Insert(02, new ListItem("RadioButton", "RadioButton"));
            //ddl.Items.Insert(03, new ListItem("TextBox", "TextBox"));
            //ddl.Items.Insert(04, new ListItem("CheckBoxList", "CheckBoxList"));
        }

		public static void FillDropDownListCategoryFilterID(DropDownList ddl)
		{
            //CategoryFilterBAL balCategoryFilter = new CategoryFilterBAL();
            //ddl.DataSource = balCategoryFilter.SelectComboBox();
            //ddl.DataValueField = "CategoryFilterID";
            //ddl.DataTextField = "FilterName";
            //ddl.DataBind();
            //ddl.Items.Insert(0 , new ListItem(" Select One ","-99"));
		}
		public static void FillDropDownListCategoryFilterValueID(DropDownList ddl)
		{
            //CategoryFilterValuesBAL balCategoryFilterValues = new CategoryFilterValuesBAL();
            //ddl.DataSource = balCategoryFilterValues.SelectComboBox();
            //ddl.DataValueField = "CategoryFilterValueID";
            //ddl.DataTextField = "CategoryFilterValues";
            //ddl.DataBind();
            //ddl.Items.Insert(0 , new ListItem(" Select One ","-99"));
		}
		public static void FillDropDownListCountryID(DropDownList ddl)
		{
            //CountryBAL balCountry = new CountryBAL();
            //ddl.DataSource = balCountry.SelectComboBox();
            //ddl.DataValueField = "CountryID";
            //ddl.DataTextField = "CountryName";
            //ddl.DataBind();
            //ddl.Items.Insert(0 , new ListItem(" Select One ","-99"));
		}
		public static void FillDropDownListCurrencyID(DropDownList ddl)
		{
            //CurrencyBAL balCurrency = new CurrencyBAL();
            //ddl.DataSource = balCurrency.SelectComboBox();
            //ddl.DataValueField = "CurrencyID";
            //ddl.DataTextField = "CurrencyName";
            //ddl.DataBind();
            //ddl.Items.Insert(0 , new ListItem(" Select One ","-99"));
		}
		public static void FillDropDownListCustomerID(DropDownList ddl)
		{
            //CustomerBAL balCustomer = new CustomerBAL();
            //ddl.DataSource = balCustomer.SelectComboBox();
            //ddl.DataValueField = "CustomerID";
            //ddl.DataTextField = "FirstName";
            //ddl.DataBind();
            //ddl.Items.Insert(0 , new ListItem(" Select One ","-99"));
		}
		public static void FillDropDownListCustomerEnquiryID(DropDownList ddl)
		{
            //CustomerEnquiryBAL balCustomerEnquiry = new CustomerEnquiryBAL();
            //ddl.DataSource = balCustomerEnquiry.SelectComboBox();
            //ddl.DataValueField = "CustomerEnquiryID";
            //ddl.DataTextField = "CustomerID";
            //ddl.DataBind();
            //ddl.Items.Insert(0 , new ListItem(" Select One ","-99"));
		}
		public static void FillDropDownListProductID(DropDownList ddl)
		{
            //ProductBAL balProduct = new ProductBAL();
            //ddl.DataSource = balProduct.SelectComboBox();
            //ddl.DataValueField = "ProductID";
            //ddl.DataTextField = "ProductName";
            //ddl.DataBind();
            //ddl.Items.Insert(0 , new ListItem(" Select One ","-99"));
		}
	}
}
