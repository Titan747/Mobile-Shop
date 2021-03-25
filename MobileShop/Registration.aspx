<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="MobileShop.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration</title>
    <meta charset="utf-8"/>
	<meta name="viewport" content="width=device-width, initial-scale=1"/>
	<link href="Content/bootstrap.min.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
			<h2>Mobile Entry</h2>
			<hr />
		</div>
		<div class="container">	
			<div class="row">
				<div class="col-12">
					<div class="form-group">
						<label for="Id">Id</label>
						<asp:TextBox ID="txtId" runat="server" CssClass="form-control" placeholder="Mobile Id" ></asp:TextBox>
					</div>
					<div class="form-group">
						<label for="Mobile">Mobile Name</label>
						<asp:TextBox ID="txtMobile" runat="server" CssClass="form-control" placeholder="Mobile Name"></asp:TextBox>
					</div>
					<div class="form-group">
						<label for="Model">Model</label>
						<asp:TextBox ID="txtModel" runat="server" CssClass="form-control" placeholder="Model Name"></asp:TextBox>
					</div>
					<div class="form-group">
						<label for="Description">Description</label>
						<asp:TextBox ID="txtDescription" runat="server" CssClass="form-control" placeholder="Description"></asp:TextBox>
					</div>
					<div class="form-group">
						<label for="Price">Price</label>
						<asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" placeholder="Price"></asp:TextBox>
					</div>
					<asp:Button ID="btnSave" runat="server" Text="Add" CssClass="btn btn-success" OnClick="btnSave_Click"/>
					<asp:Button ID="btnEdit" runat="server" Text="Edit" CssClass="btn btn-dark" OnClick="btnEdit_Click" />
					<asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="btnUpdate_Click" />
					<asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btn btn-danger" OnClick="btnDelete_Click" />
					<asp:Button ID="btnReset" runat="server" Text="Reset" CssClass="btn btn-secondary" OnClick="btnReset_Click"/>
					<hr />
					<div class="alert alert-success">
						<asp:Label Text="" ID="lblResut" runat="server" CssClass="form-control"/>
					</div>
					<hr />
					<div class="row">
						<div class="col-12">
							<asp:GridView ID="gvMobileDetails" runat="server"></asp:GridView>
						</div>
					</div>
				</div>
			</div>
        </div>
    </form>
</body>
</html>
