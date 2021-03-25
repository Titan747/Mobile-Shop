<%@ Page Title="" Language="C#" MasterPageFile="~/MobileUsers.Master" AutoEventWireup="true" CodeBehind="SearchMobile.aspx.cs" Inherits="MobileShop.SearchMobile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="row">
		<div class="col-6">
			<div class="form-group">
				<label for="Range">Amount Range</label>
				<asp:DropDownList ID="ddlFrom" runat="server" CssClass="form-control">
					<asp:ListItem Text="Select"/>
					<asp:ListItem Text="1000"/>
					<asp:ListItem Text="3000"/>
					<asp:ListItem Text="5000"/>
				</asp:DropDownList>
			</div>
			<div class="form-group">
				<asp:DropDownList ID="ddlTo" runat="server" CssClass="form-control">
					<asp:ListItem Text="Select"/>
					<asp:ListItem Text="2000"/>
					<asp:ListItem Text="3000"/>
					<asp:ListItem Text="7000"/>
				</asp:DropDownList>
			</div>
		</div>
		<div class="col-6">
			<div class="form-group">
				<label for="SelectMobile">Select</label>
				<asp:CheckBoxList ID="cbklMobiles" runat="server" CssClass="form-check-input" RepeatDirection="Horizontal">
					<asp:ListItem Text="Apple"/>
					<asp:ListItem Text="Google"/>
					<asp:ListItem Text="Black Berry"/>
					<asp:ListItem Text="Samsung"/>
					<asp:ListItem Text="One Plus"/>
					<asp:ListItem Text="Nokia"/>
				</asp:CheckBoxList>
			</div>
		</div>
		<div class="col-12">
			<asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn btn-primary"/>
		</div>
	</div>
</asp:Content>
