<%@ Page Title="HADA P3" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="proWeb.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Products management</h1>
    <p> <!-- Creación de la interfaz de la página web -->
        Code <asp:TextBox ID ="Codebox" runat ="server"></asp:TextBox>

    </p>
    <p>
        Name <asp:TextBox ID ="NameBox" runat ="server"></asp:TextBox>
    </p>
    <p>
        Amount <asp:TextBox ID ="AmountBox" runat ="server"></asp:TextBox>
    </p>
    <p>
        Category  <asp:DropDownList ID ="CategoryList" runat ="server">
                    <asp:ListItem Text="Computing" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Telephony" Value="1"></asp:ListItem>
                    <asp:ListItem Text="Gaming" Value="2"></asp:ListItem>
                    <asp:ListItem Text="Home appliances" Value="3"></asp:ListItem>
                  </asp:DropDownList>
    </p>
    <p>
        Price <asp:TextBox ID="PriceBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Creation Date <asp:TextBox ID="CreationDateBox" runat="server"></asp:TextBox>
    </p>
    <asp:Button Text="Create" ID="CreateButton" runat="server" Height="22px" Width="109px"></asp:Button>
</asp:Content>
