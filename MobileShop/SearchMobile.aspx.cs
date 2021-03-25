using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileShop
{
	public partial class SearchMobile : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void btnSearch_Click(object sender, EventArgs e)
		{
			Session ["fromamt"] = ddlFrom.SelectedItem.Text;
			Session ["toamt"] = ddlTo.SelectedItem.Text;
			string mobiles = string.Empty;
			for (int i = 0; i < cbklMobiles.Items.Count; i++)
			{
				if (cbklMobiles.Items[i].Selected)
				{
					mobiles = mobiles + cbklMobiles.Items[i].Text+" ";
				}
			}
			Session["mobiles"] = mobiles;
			Response.Redirect("SearchResult.aspx");
		}
	}
}