<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="menuvw.aspx.cs" Inherits="HMS.menuvw" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <formview id="gridvw" runat="server">
         <h3>Menu</h3>
        <div>
            
             
                <asp:Gridview ID="gvMenu" runat="server" AutoGenerateColumns="false" >
                <Columns>
                    <asp:BoundField DataField="ItemNo" HeaderText="ItemNo" />
                    <asp:BoundField DataField="Code" HeaderText="Code" />
                    <asp:BoundField DataField="ItemName" HeaderText="ItemName" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" />
                    <asp:BoundField DataField="Active" HeaderText="Active" />
                </Columns>
            </asp:Gridview>
                    
            </div>
        
     </formview>
    
</asp:Content>
