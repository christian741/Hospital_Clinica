<%@ Page Title="Registro" Language="C#" MasterPageFile="~/View/Principal/MasterPrincipal.master" 
    AutoEventWireup="true" CodeFile="~/Controller/ConPrincipal/registro.aspx.cs" Inherits="View_Principal_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

    REGISTRARSE

    <asp:Image ID="image_registro" runat="server" Width="30%" />
    <asp:FileUpload ID="FU_imagen" runat="server" />

    <asp:Label ID="label_cedula" runat="server" Text="Cedula:"></asp:Label>
    <asp:TextBox ID="text_cedula" runat="server" MaxLength="10" placeholder="Digite una Cedula:"></asp:TextBox>
    <asp:Label ID="label_primer_nombre" runat="server" Text="Primer Nombre:"></asp:Label>
    <asp:TextBox ID="text_primer_nombre" runat="server" MaxLength="20" placeholder="Digite su Primer Nombre"></asp:TextBox>
     
    <asp:Label ID="label_segundo_nombre" runat="server" Text="Segundo Nombre:"></asp:Label>
    <asp:TextBox ID="text_segundo_nombre" runat="server" MaxLength="20" placeholder="Digite su Segundo Nombre"></asp:TextBox>
    
    <asp:Label ID="label_primer_apellido" runat="server" Text="Primer Apellido:"></asp:Label>
    <asp:TextBox ID="text_primer_apellido" runat="server" MaxLength="20" placeholder="Digite su Primer Apellido"></asp:TextBox>
    
    <asp:Label ID="label_segundo_apellido" runat="server" Text="Segundo Apellido:"></asp:Label>
    <asp:TextBox ID="text_segundo_apellido" runat="server" MaxLength="20" placeholder="Digite su Segundo Apellido"></asp:TextBox>
    
    <asp:Label ID="label_direccion" runat="server" Text="Direccion:"></asp:Label>
    <asp:TextBox ID="text_direccion" TextMode="MultiLine" runat="server" MaxLength="30" placeholder="Digite su Direcciòn"></asp:TextBox>
     
    <asp:Label ID="label_telefono" runat="server" Text="Telefono:"></asp:Label>
    <asp:TextBox ID="text_telefono" runat="server" MaxLength="10"></asp:TextBox>
   
    <asp:Label ID="label_correo" runat="server" Text="Correo:"></asp:Label>
    <asp:TextBox ID="text_correo" MaxLength="20" TextMode="Email" runat="server"  placeholder="Digite su Correo Electronico"></asp:TextBox>

    <asp:Label ID="label_password" runat="server" Text="Contraseña:"></asp:Label>
    <asp:TextBox ID="text_pass" MaxLength="20" TextMode="Password" runat="server" placeholder="Digite su Contraseña"></asp:TextBox>

    <asp:Label ID="label_confirmation" runat="server" Text="Confirmar Contraseña:"></asp:Label>
    <asp:TextBox ID="text_confirmacion_pass" MaxLength="20" TextMode="Password" runat="server"></asp:TextBox>
        
    <asp:Label ID="label_sexo" runat="server" Text="Seleccione un Sexo:"></asp:Label>
    <asp:DropDownList ID="DDL_sexo" runat="server">
        <asp:ListItem>Seleccione un Sexo</asp:ListItem>
        <asp:ListItem>Maculino</asp:ListItem>
        <asp:ListItem>Femenino</asp:ListItem>
        <asp:ListItem>Otro</asp:ListItem>
    </asp:DropDownList>

    <asp:Label ID="label_fecha" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
    <asp:TextBox ID="text_fecha" TextMode="Date" runat="server"></asp:TextBox>

    <asp:Button ID="but_registrar" runat="server" Text="Registrarse" OnClick="but_registrar_Click" />
</asp:Content>

