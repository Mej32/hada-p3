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
                  </asp:DropDownList>
    </p>
    <p>
        Price <asp:TextBox ID="PriceBox" runat="server"></asp:TextBox>
    </p>
    <p>
        Creation Date <asp:TextBox ID="CreationDateBox" runat="server"></asp:TextBox>
    </p>
    <!-- Diferentes botones de final de página los cuales usará el usuario para interactuar con la base de datos -->
    <asp:Button Text="Create" ID="CreateButton" runat="server" Height="22px" Width="110px" style="margin-right:20px; margin-left:20px;" OnClick="Create_click"></asp:Button>
    <asp:Button Text="Update" ID="UpdateButton" runat="server" Height="22px" Width="110px" style="margin-right:20px;" OnClick="Update_click"></asp:Button>
    <asp:Button Text="Delete" ID="DeleteButton" runat="server" Height="22px" Width="110px" style="margin-right:20px;" OnClick="Delete_click"></asp:Button>
    <asp:Button Text="Read" ID="ReadButton" runat="server" Height="22px" Width="110px" style="margin-right:20px;" OnClick="Read_click"></asp:Button>
    <asp:Button Text="Read First" ID="ReadFirstButton" runat="server" Height="22px" Width="110px" style="margin-right:20px;" OnClick="ReadFirst_click"></asp:Button>
    <asp:Button Text="Read Prev" ID="ReadPrevButton" runat="server" Height="22px" Width="110px" style="margin-right:20px;" OnClick="ReadPrev_click"></asp:Button>
    <asp:Button Text="Read Next" ID="ReadNextButton" runat="server" Height="22px" Width="110px" style="margin-right:20px;" Onclick="ReadNext_click"></asp:Button>
    <br />
    <asp:Label ID="EtiquetaExito" runat="server" Text="Product operation has been sucess!" style="color:forestgreen; font:italic" Visible="false"></asp:Label>
    <asp:Label ID="EtiquetaFallo" runat="server" Text="Product operation has failed." style="color:red; font:italic" Visible="false"></asp:Label>
</asp:Content>
