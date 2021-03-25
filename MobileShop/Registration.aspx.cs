using Mobile.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MobileShop
{
	public partial class Registration : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			// Presentation Layer --> Business Layer --> Data Layer

			//Data Layer --> Business Layer --> Presentation Layer
		}
		
		protected void btnSave_Click(object sender, EventArgs e)
		{
				MobileEntry mobileEntry = new MobileEntry();
				//string mobile = txtMobile.Text;
				//string model = txtModel.Text;
				//string price = txtPrice.Text;
				//string Description = txtDescription.Text;
				//Session["mobile"] = mobile;
				//Session["model"] = model;
				//Session["price"] = price;
				//Session["Description"] = Description;

				DataTable dtResult = mobileEntry.InsertMobile(Convert.ToInt32(txtId.Text), txtMobile.Text, txtModel.Text, Convert.ToInt32(txtPrice.Text), txtDescription.Text);
				lblResut.Text = "Inserted";
				//Response.Redirect("MobileUserHome.aspx");

				DataTable dtSelectMobiles = mobileEntry.SelectAllMobiles();
				gvMobileDetails.DataSource = dtSelectMobiles;
				gvMobileDetails.DataBind();
		}
		public DataTable GetMobile()
		{
			MobileEntry mobileEntry = new MobileEntry();
			DataTable dtSelectMobile = mobileEntry.SelectAllMobiles();
			return dtSelectMobile;
		}
		protected void btnUpdate_Click(object sender, EventArgs e)
		{
			MobileEntry mobileEntry = new MobileEntry();
			//DataTable dtSelectMobile = mobileEntry.SelectMobileById(Convert.ToInt32(txtmobileid.Text));
			DataTable dtResult = mobileEntry.UpdateMobile(Convert.ToInt32(txtId.Text),txtMobile.Text, txtModel.Text, Convert.ToInt32(txtPrice.Text), txtDescription.Text);
			gvMobileDetails.DataSource = GetMobile();
			gvMobileDetails.DataBind();
		}

		protected void btnDelete_Click(object sender, EventArgs e)
		{
			MobileEntry mobileEntry = new MobileEntry();
			DataTable dtResult = mobileEntry.DeleteMobileById(Convert.ToInt32(txtId.Text));
			lblResut.Text = "Deleted";
			DataTable dtSelectMobiles = mobileEntry.SelectAllMobiles();
			gvMobileDetails.DataSource = dtSelectMobiles;
			gvMobileDetails.DataBind();
		}

		protected void btnReset_Click(object sender, EventArgs e)
		{
				txtId.Text = string.Empty;
				txtMobile.Text = string.Empty;
				txtModel.Text = string.Empty;
				txtDescription.Text = string.Empty;
				txtPrice.Text = string.Empty;
		}

		protected void btnEdit_Click(object sender, EventArgs e)
		{
			MobileEntry mobileEntry = new MobileEntry();
			DataTable dtSelectMobile = mobileEntry.SelectMobileById(Convert.ToInt32(txtId.Text));
			txtMobile.Text = dtSelectMobile.Rows[0][1].ToString();
			txtModel.Text = dtSelectMobile.Rows[0][2].ToString();
			txtPrice.Text = dtSelectMobile.Rows[0][3].ToString();
			txtDescription.Text = dtSelectMobile.Rows[0][4].ToString();
		}
	}
}