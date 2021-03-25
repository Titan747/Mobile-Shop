using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileShop
{
	public partial class MobileUserHome : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (Session["mobile"] != null)
			{
				lblMessage.Text = "Mobile: " + Session["mobile"].ToString() + "<br/>" +
								  "Model: " + Session["model"].ToString() + "<br/>" +
								  "Price: " + Session["price"].ToString();
			}
			else
			{
				lblMessage.Text = "Enter the Information";
			}
		}
	}
}