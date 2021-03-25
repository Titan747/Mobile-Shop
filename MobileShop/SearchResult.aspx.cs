using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileShop
{
	public partial class SearchResult : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			lblResult.Text = "Search results: Amount from - " + Session["fromamt"].ToString() + "to - " + Session["toamt"].ToString() + Session["mobiles"].ToString();
		}
	}
}