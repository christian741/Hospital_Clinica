<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/masterAdmin.master" 
    AutoEventWireup="true" CodeFile="~/Controller/ConAdmin/especializacion/registrarEspecial.aspx.cs" Inherits="View_Admin_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Image ID="Image_especial" runat="server" Width="30%" />
    <br />

    <br />
    <asp:Label ID="label_especializacion_reg" runat="server" Text="Nombre de Especialización: "></asp:Label>
    <br />
    <asp:TextBox ID="text_especializacion_nombre_reg" placeholder="Digite el Nombre de la Especialización" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="label_descripcion_reg" runat="server" Text="Descripción: "></asp:Label>
    <br />
    <asp:TextBox ID="text_descripcion_reg" placeholder="Digite La Descripción de la Especialización" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="label_file_espe" runat="server" Text="Seleccione una Imagen: "></asp:Label>
    <br />
    <asp:FileUpload ID="FU_registro_esp" runat="server" />
    <br />
    <br />
    <asp:Label ID="label_edad_esp" runat="server" Text="Seleccione una Edad que aplica: "></asp:Label>
    <br />
    <asp:DropDownList ID="DDL_edad_esp" runat="server">
        <asp:ListItem>Seleccione una Edad</asp:ListItem>
        <asp:ListItem Value="3">Bebes</asp:ListItem>
        <asp:ListItem Value="17">Menores de edad</asp:ListItem>
        <asp:ListItem Value="18">Mayores de Edad</asp:ListItem>
        <asp:ListItem Value="Todas las Edades"></asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="label_sexo_esp" runat="server" Text="Seleccione el Sexo que aplica la Especialización: "></asp:Label>
    <br />
    <asp:DropDownList ID="DDL_sexo_esp" runat="server">
        <asp:ListItem>Seleccione un Sexo</asp:ListItem>
        <asp:ListItem>Maculino</asp:ListItem>
        <asp:ListItem>Femenino</asp:ListItem>
        <asp:ListItem>Ambos Sexos</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="label_prioridad" runat="server" Text="Seleccione los Permisos que Tiene la Especialización"></asp:Label>
    <br />
    <asp:DropDownList ID="DDL_prioridad" runat="server">
        <asp:ListItem>Seleccione un Permiso</asp:ListItem>
        <asp:ListItem>Solo Doctores</asp:ListItem>
        <asp:ListItem>Todos</asp:ListItem>
    </asp:DropDownList>
    <br />


    <asp:Button ID="button_especial" runat="server" Text="Registrar Especialización" OnClick="button_especial_Click" />
    <br />

</asp:Content>

