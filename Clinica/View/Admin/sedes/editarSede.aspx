<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/masterAdmin.master" 
    AutoEventWireup="true" CodeFile="~/Controller/ConAdmin/sedes/editarSede.aspx.cs" Inherits="View_Admin_Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:FormView ID="FV_sede" runat="server" DataSourceID="OBDS_editarSede">
        <ItemTemplate>
            <asp:Image ID="Image_sede" runat="server" Width="30%"  ImageUrl='<%# Bind("foto") %>'/>
            <br />
            <asp:Label ID="label_file_sede" runat="server" Text="Seleccione una Imagen: "></asp:Label>
            <br />
            <asp:FileUpload ID="FU_registro_sede" runat="server" />
            <br />
            <br />

            <asp:Label ID="label_sede_reg" runat="server" Text="Nombre de la Sede: "></asp:Label>
            <br />
            <asp:TextBox ID="text_sede_nombre_reg" MaxLength="50" Text='<%# Bind("nombre") %>' runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="label_sede_direccion" runat="server" Text="Dirección de la Sede: "></asp:Label>
            <br />
            <asp:TextBox ID="text_sede_direccion" MaxLength="50" Text='<%# Bind("direccion") %>' runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="label_sede_descripcion" runat="server" Text="Breve Descripcion de la Sede: "></asp:Label>
            <br />
            <asp:TextBox ID="text_sede_descripcion" Text='<%# Bind("descripcion") %>' runat="server"></asp:TextBox>
            <br />
           
            <asp:Label ID="label_ciudad_sede" runat="server" Text="Ciudad de la Sede: "></asp:Label>
            <br />
            <asp:TextBox ID="text_ciudad_sede" Text='<%# Bind("ciudad") %>' runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="button_sede" runat="server" Text="Editar Sede" OnClick="button_sede_Click" CssClass="form-check-label" />
            <br />

        </ItemTemplate>
    </asp:FormView>
    <asp:ObjectDataSource ID="OBDS_editarSede" runat="server" SelectMethod="ver_Sede" TypeName="DAOSede">
        <SelectParameters>
            <asp:QueryStringParameter Name="id_sede" QueryStringField="sede" Type="Int64" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

