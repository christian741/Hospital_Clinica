<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/masterAdmin.master" 
    AutoEventWireup="true" CodeFile="~/Controller/ConAdmin/recepcionistas/verRecep.aspx.cs" Inherits="View_Admin_Default3" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="table-responsive" style="text-align: center;">
        <asp:GridView ID="GV_user" runat="server" AllowPaging="True" AllowSorting="True" DataSourceID="OBDS_Laboratorista" AutoGenerateColumns="False" OnRowDataBound="cargar_Botones_RowDataBound" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="Informacion">
                    <ItemTemplate>
                        <asp:Button ID="but_mas_info" CssClass="btn btn-primary" runat="server" Text="Mas Info" CommandName="info" CommandArgument='<%# Bind("id_usuario") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Id" Visible="False">
                    <ItemTemplate>
                        <asp:Label ID="label_id" runat="server" Text='<%# Bind("id_usuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Cedula">
                    <ItemTemplate>
                        <asp:Label ID="label_cedula" runat="server" Text='<%# Bind("cedula") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Primer Nombre">
                    <ItemTemplate>
                        <asp:Label ID="label_primer_nombre" runat="server" Text='<%# Bind("primer_nombre") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Segundo Nombre">
                    <ItemTemplate>
                        <asp:Label ID="label_segundo_nombre" runat="server" Text='<%# Bind("segundo_nombre") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Primer Apellido">
                    <ItemTemplate>
                        <asp:Label ID="label_primer_apellido" runat="server" Text='<%# Bind("primer_apellido") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField HeaderText="Segundo Apellido">
                    <ItemTemplate>
                        <asp:Label ID="label_segundo_apellido" runat="server" Text='<%# Bind("segundo_apellido") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Editar">
                    <ItemTemplate>
                        <asp:Button ID="but_editar" CssClass="btn btn-warning" runat="server" Text="Editar" CommandName="editar" CommandArgument='<%# Bind("id_usuario") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="">
                   <ItemTemplate>
                        <asp:Button ID="but_bloquear" runat="server" Text="Bloquear" CssClass="btn btn-danger" CommandName="bloquear" CommandArgument='<%# Bind("id_usuario") %>' />
                        <asp:Button ID="but_desbloquear" runat="server" Text="Desbloquear" CssClass="btn btn-success" CommandName="desbloquear" CommandArgument='<%# Bind("id_usuario") %>' />

                    </ItemTemplate>
                </asp:TemplateField>

            </Columns>

            <EditRowStyle BackColor="#999999" />

            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" ForeColor="#333333" Font-Bold="True" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

        </asp:GridView>
        </div>
     <!-- ModalPopupExtender -->

    <cc1:modalpopupextender id="modal" runat="server" popupcontrolid="Panel" targetcontrolid="but_actualizar"
        cancelcontrolid="but_salir" backgroundcssclass="Background">
    </cc1:modalpopupextender>

    <asp:Panel ID="Panel" runat="server" CssClass="Popup_user" align="center" Style="display: none" ScrollBars="Horizontal">
        Datos User
                                   
        <asp:FormView ID="FV_usuario" runat="server" DataSourceID="OBDS_user">
        <ItemTemplate>
            <asp:Label ID="label_imagen" runat="server" Text="Seleccionar Imagen"></asp:Label>
            <asp:Image ID="Imagen_user" runat="server" Width="30%" />
            <asp:Label ID="label1" runat="server" Text="Nombres:"></asp:Label>
            <asp:Label ID="label_nombres" runat="server" Text=""></asp:Label>
            <asp:Label ID="label2" runat="server" Text="Apellidos:"></asp:Label>
            <asp:Label ID="label_apellidos" runat="server" Text=""></asp:Label>
            <asp:Label ID="label3" runat="server" Text="Direccion:"></asp:Label>
            <asp:Label ID="label_direccion" runat="server" Text=""></asp:Label>
            <asp:Label ID="label5" runat="server" Text="Telefono:"></asp:Label>
            <asp:Label ID="label_telefono" runat="server" Text=""></asp:Label>
            <asp:Label ID="label4" runat="server" Text="Correo:"></asp:Label>
            <asp:Label ID="label_correo" runat="server" Text=""></asp:Label>
            <asp:Label ID="label7" runat="server" Text="Contraseña:"></asp:Label>
            <asp:Label ID="label_clave" runat="server" Text="************"></asp:Label>
            <asp:Label ID="label9" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
            <asp:Label ID="label_nacimiento" runat="server" Text=""></asp:Label>
            <asp:Label ID="label11" runat="server" Text="Sexo:"></asp:Label>
            <asp:Label ID="label_sexo" runat="server" Text=""></asp:Label>
        </ItemTemplate>
        </asp:FormView>
        <asp:Button ID="but_salir" CssClass="btn btn-dark" runat="server" Text="Salir" />

    </asp:Panel>
</asp:Content>

