<%@ Page Title="" Language="C#" MasterPageFile="~/View/Principal/MasterPrincipal.master"
    AutoEventWireup="true" CodeFile="~/Controller/ConPrincipal/login.aspx.cs" Inherits="View_Principal_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   LOGIN

    <asp:Label ID="label_cedula" runat="server" Text="Cedula:"></asp:Label>
    <asp:TextBox ID="text_cedula" MaxLength="10" placeholder="Digite una Cedula" runat="server"></asp:TextBox>
    <asp:Label ID="label_password" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="text_password" MaxLength="20" TextMode="Password" placeholder="Digite su Password" runat="server"></asp:TextBox>
    <asp:HyperLink ID="HPL_olvide_pass" runat="server">Olvide mi Contraseña</asp:HyperLink>
    <asp:Button ID="but_login" runat="server" Text="Login" OnClick="but_login_Click" />
</asp:Content>

