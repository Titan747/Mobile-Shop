<%@ Page Title="" Language="C#" MasterPageFile="~/MobileUsers.Master" AutoEventWireup="true" CodeBehind="Mobiles.aspx.cs" Inherits="MobileShop.Mobiles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style>
		.product{
			height:150px;
			background-color:lightblue;
			border:1px solid #fe7f7f;
			text-align:center;
			font-weight:bold;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h2>
		Mobiles
	</h2>
	<hr />
	<div class="row">
		<div class="col-4 product">
			<div>Apple Iphone 12</div>
			<div>
				<img src="Images/Iphone.jpg" alt="Iphone" height="120" width="150"/>
			</div>
		</div>
		<div class="col-4 product">
			<div>Google Pixel</div>
			<div>
				<img src="Images/Google Pixel.jpg" alt="Pixel" height="120" width="150"/>
			</div>
		</div>
		<div class="col-4 product">
			<div>Black Berry</div>
			<div>
				<img src="Images/Black Berry.jpg" alt="Black Berry" height="120" width="150"/>
			</div>
		</div>
	</div>
	<div class="row">
		<div class="col-4 product">
			<div>Samsung S21</div>
			<div>
				<img src="Images/Samsung Galaxy S21.jpg" alt="Samsung" height="120" width="150"/>
			</div>
		</div>
		<div class="col-4 product">
			<div>One Plus 7t</div>
			<div>
				<img src="Images/One Plus 7t.jpg" alt="One Plus" height="120" width="150"/>
			</div>
		</div>
		<div class="col-4 product">
			<div>Nokia</div>
			<div>
				<img src="Images/Nokia 6.1.jpg" alt="Nokia" height="120" width="150"/>
			</div>
		</div>
	</div>
</asp:Content>
