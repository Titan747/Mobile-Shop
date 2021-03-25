<%@ Page Title="" Language="C#" MasterPageFile="~/MobileUsers.Master" AutoEventWireup="true" CodeBehind="SearchResult.aspx.cs" Inherits="MobileShop.SearchResult" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<div class="col-row">
		<div class="col-12">
			<asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
		</div>
	</div>
</asp:Content>
