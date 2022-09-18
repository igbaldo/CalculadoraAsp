<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Calculadora._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label ID="Label1" runat="server" Text="Label">Ingrese un numero: </asp:Label>
        <asp:TextBox ID="Numero1" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Label">Ingrese otro: </asp:Label>
        <asp:TextBox ID="Numero2" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="Sumar" runat="server" Text="Sumar" OnClick="Sumar_Click" />
        <asp:Button ID="Restar" runat="server" Text="Restar" OnClick="Restar_Click" />
        <asp:Button ID="Multiplicar" runat="server" Text="Multiplicar" OnClick="Multiplicar_Click" />
        <asp:Button ID="Dividir" runat="server" Text="Dividir" OnClick="Dividir_Click" />
        <br /><br />
        <asp:Label ID="Label3" runat="server" Text="Label">Resultado</asp:Label>
        <asp:TextBox ID="Resultado" runat="server"></asp:TextBox>
        <asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label>
    </div>


</asp:Content>
