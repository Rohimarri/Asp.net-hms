<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="menu.aspx.cs" Inherits="HMS.menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Label ID="lblItemNo" runat="server" Text="ItemNo"></asp:Label>
    <asp:TextBox ID="txtItemNo" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblCode" runat="server" Text="Code"></asp:Label>
    <asp:TextBox ID="txtCode" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblItemName" runat="server" Text="ItemName"></asp:Label>
    <asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
    <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="lblQuantity" runat="server" Text="Quantity"></asp:Label>
    <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
    
    
    <br />
    <asp:CheckBox ID="chkActive" runat="server"  Text="Active"/>
    <div>
        <asp:button ID="btnSubmit" runat="server" OnClick="btn_submit_click" Text="Submit" />
        <asp:button ID="btnUpdate" runat="server" OnClick="btn_Update_click" Text="Update" />
        <asp:button ID="btndelete" runat="server" OnClick="btn_delete_click" Text="delete" />
    </div>
    
</asp:Content>
