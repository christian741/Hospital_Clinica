<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/masterAdmin.master"
    AutoEventWireup="true" CodeFile="~/Controller/ConAdmin/sedes/verSede.aspx.cs" Inherits="View_Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div class="container-fluid" style="text-align: center; background-color: black; color: white">
            <h1>SEDES DE LA CLINICA</h1>
        </div>

        <div class="table-responsive" style="text-align: center;">

            <asp:GridView ID="GV_sedes" runat="server" AllowPaging="True" Style="max-width: 100%" CssClass="table-hover" AutoGenerateColumns="False" DataSourceID="OBDS_sedes" DataKeyNames="id_sede" Width="100%" OnRowDataBound="cargar_Botones_RowDataBound" OnRowCommand="GV_Sede_RowCommand" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                <Columns>

                    <asp:TemplateField HeaderText="Id" Visible="False">
                        <EditItemTemplate>
                            <asp:TextBox ID="txt_id_sede" runat="server" Enabled="False" Text='<%# Bind("id_sede") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lab_id_sede" runat="server" Text='<%# Bind("id_sede") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Nombre" HeaderStyle-CssClass="thead-dark">
                        <EditItemTemplate>
                            <asp:Label ID="label_error_nombre" CssClass="alert-danger" runat="server" Text="" Visible="false"></asp:Label>
                            <asp:TextBox ID="txt_nom_sede" runat="server" MaxLength="4" Text='<%# Bind("nombre") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lab_nom_sede" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                        </ItemTemplate>

                        <HeaderStyle CssClass="thead-dark"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Descripción" HeaderStyle-CssClass="thead-dark">
                        <EditItemTemplate>
                            <asp:Label ID="label_error_des" CssClass="alert-danger" runat="server" Text="" Visible="false"></asp:Label>

                            <asp:TextBox ID="txt_des_sede" runat="server" TextMode="MultiLine" MaxLength="30" Text='<%# Bind("descripcion") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lab_des_sede" runat="server" Text='<%# Bind("descripcion") %>'></asp:Label>
                        </ItemTemplate>

                        <HeaderStyle CssClass="thead-dark"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Ciudad" HeaderStyle-CssClass="thead-dark">
                        <EditItemTemplate>
                            <asp:Label ID="label_error_ciudad" CssClass="alert-danger" runat="server" Text="" Visible="false"></asp:Label>

                            <asp:TextBox ID="txt_cid_sede" runat="server" MaxLength="4" Text='<%# Bind("ciudad") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lab_cid_sede" runat="server" Text='<%# Bind("ciudad") %>'></asp:Label>
                        </ItemTemplate>

                        <HeaderStyle CssClass="thead-dark"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Dirección" HeaderStyle-CssClass="thead-dark">
                        <EditItemTemplate>
                            <asp:Label ID="label_error_direccion" CssClass="alert-danger" runat="server" Text="" Visible="false"></asp:Label>

                            <asp:TextBox ID="txt_dir_sede" runat="server" MaxLength="50" TextMode="MultiLine" Text='<%# Bind("direccion") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lab_dir_sede" runat="server" Text='<%# Bind("direccion") %>'></asp:Label>
                        </ItemTemplate>

                        <HeaderStyle CssClass="thead-dark"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Foto" HeaderStyle-CssClass="thead-dark">
                        <EditItemTemplate>
                            <asp:Image ID="Img_ed_sede" runat="server" ImageUrl='<%# Bind("foto") %>' Width="30%" />
                            <br />
                            <asp:FileUpload ID="FU_ed_Sede" runat="server" />
                            <br />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="img_sede" runat="server" ImageUrl='<%# Bind("foto") %>' Width="30%" />
                        </ItemTemplate>

                        <HeaderStyle CssClass="thead-dark"></HeaderStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Estado" Visible="False">
                        <EditItemTemplate>
                            <asp:Label ID="label_estado" runat="server" Text='<%# Bind("estado") %>'></asp:Label>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="label_estado" runat="server" Text='<%# Bind("estado") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Editar">
                        <EditItemTemplate>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Button ID="but_editar" CssClass="btn btn-info" runat="server" Text="Editar" CommandName="editar" CommandArgument='<%# Bind("id_sede") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="" HeaderStyle-CssClass="thead-dark">
                        <EditItemTemplate>
                            <asp:Button ID="but_bloquear" CssClass="btn btn-danger" runat="server" Text="Bloquear" CommandName="bloquear" CommandArgument='<%# Bind("id_sede") %>' />
                            <asp:Button ID="but_desbloquear" CssClass="btn btn-success" runat="server" Text="Desbloquear" CommandName="desbloquear" CommandArgument='<%# Bind("id_sede") %>' />

                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Button ID="but_desbloquear" runat="server" CssClass="btn btn-success" Text="Desbloquear" CommandName="desbloquear" CommandArgument='<%# Bind("id_sede") %>' />
                            <asp:Button ID="but_bloquear" runat="server" CssClass="btn btn-danger" Text="Bloquear" CommandName="bloquear" CommandArgument='<%# Bind("id_sede") %>' />

                        </ItemTemplate>

                        <HeaderStyle CssClass="thead-dark"></HeaderStyle>
                    </asp:TemplateField>

                </Columns>
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />
            </asp:GridView>
            <asp:ObjectDataSource ID="OBDS_sedes" runat="server" SelectMethod="ver_Sedes" TypeName="DAOSede"></asp:ObjectDataSource>
        </div>

   
</asp:Content>

