<%@ Page Title="Login" Language="C#" MasterPageFile="~/View/Principal/MasterPrincipal.master"
    AutoEventWireup="true" CodeFile="~/Controller/ConPrincipal/login.aspx.cs" Inherits="View_Principal_Default2" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   LOGIN

    <asp:Label ID="label_cedula" runat="server" Text="Cedula:"></asp:Label>
    <asp:TextBox ID="text_cedula" MaxLength="10" placeholder="Digite una Cedula" runat="server"></asp:TextBox>
    <asp:Label ID="label_password" runat="server" Text="Password:"></asp:Label>
    <asp:TextBox ID="text_password" MaxLength="20" TextMode="Password" placeholder="Digite su Password" runat="server"></asp:TextBox>
    <asp:HyperLink ID="HPL_olvide_pass" runat="server">Olvide mi Contraseña</asp:HyperLink>
    <asp:HyperLink ID="HPL_registrarse" runat="server" NavigateUrl="~/View/Principal/registro.aspx">Registrarte</asp:HyperLink>
    <asp:Button ID="but_login" runat="server" Text="Login" OnClick="but_login_Click" />
     <asp:Label ID="label_oculto" runat="server" Text=""></asp:Label>

    <cc1:ModalPopupExtender ID="modal2" runat="server" PopupControlID="Panel2" TargetControlID="label_oculto"
        CancelControlID="but_salir" BackgroundCssClass="Background">
    </cc1:ModalPopupExtender>

    <asp:Panel ID="Panel2" runat="server" CssClass="alert-warning" align="center" Style="display: none">
        <div class="card text-white bg-danger">
            <div class="card-body">
                <h5 class="card-title"> <strong><asp:Label ID="label_titulo_error" CssClass="" runat="server" Text=""></asp:Label></strong><br /></h5>
                <br />
                <p class="card-text">
                      <p class="mb-0">
                      <asp:Label ID="label_error" runat="server" Text=""></asp:Label>
                </p>
                <p class="mb-0"> <asp:Button ID="but_salir" CssClass="btn btn-outline-dark" runat="server" Text="Aceptar" /></p>
            </div>
        </div>
       
      
          
    </asp:Panel>

</asp:Content>

