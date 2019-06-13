<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/masterAdmin.master" 
    AutoEventWireup="true" CodeFile="~/Controller/ConAdmin/sedes/registrarSede.aspx.cs" Inherits="View_Admin_Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:Image ID="Image_sede" runat="server" Width="30%" />
    <br />
    <asp:Label ID="label_file_sede" runat="server" Text="Seleccione una Imagen: "></asp:Label>
    <br />
    <asp:FileUpload ID="FU_registro_sede" runat="server" />
    <br />
    <br />

    <asp:Label ID="label_sede_reg" runat="server" Text="Nombre de la Sede: "></asp:Label>
    <br />
    <asp:TextBox ID="text_sede_nombre_reg" MaxLength="50" placeholder="Digite el Nombre de la Sede" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="label_sede_direccion" runat="server" Text="Dirección de la Sede: "></asp:Label>
    <br />
    <asp:TextBox ID="text_sede_direccion" MaxLength="50" placeholder="Digite la Dirección de la Sede" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="label_sede_descripcion" runat="server" Text="Breve Descripcion de la Sede: "></asp:Label>
    <br />
    <asp:TextBox ID="text_sede_descripcion" placeholder="Digite una Descripción de la Sede" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="label_buscar" runat="server" Text="Buscar Encargado por Cedula"></asp:Label>
    <br />
    <asp:Label ID="label_error_busqueda" runat="server" Text=""></asp:Label>
    <br />
    <asp:TextBox ID="text_buscar" placeholder="Digite la Cedula" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="But_buscar" runat="server"  Text="Buscar" OnClick="But_buscar_Click"  />
    <br />
    
    <br />
    <asp:Label ID="label_encargado_sede" runat="server" Text="Nombre del Encargado de la Sede: "></asp:Label>
    <asp:FormView ID="FV_usuario" runat="server" DataSourceID="OBDS_busquedaUser">
        <ItemTemplate>
            <div class="table-responsive">
                <table class="table table-lg">
                    <thead>
                        <tr>

                            <caption>Información del Administrador</caption>
                            <div class="container-fluid" style="text-align: center">
                                INFORMACION DEL USUARIO
                            </div>

                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row"></th>
                            <td>
                                <asp:Image ID="Imagen_usu" runat="server" ImageUrl='<%# Bind("foto") %>' Width="30%" CssClass="rounded-circle" />
                            </td>
                            <td style="padding-right: 200px">
                                <table class="table table-sm" style="width: 100%">
                                    <thead>
                                        <tr class=" table-active;table-info;">
                                            Datos Personales
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <th scope="row"></th>
                                            <td>
                                                <asp:Label ID="label1" runat="server" Text="Cedula:"></asp:Label>
                                                <asp:Label ID="label_cedula" runat="server" Text='<%# Bind("cedula") %>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="label2" runat="server" Text="Nombre:"></asp:Label>
                                                <asp:Label ID="label_nombre" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                            </td>
                                            <td>
                                                <asp:Label ID="label3" runat="server" Text="Apellido:"></asp:Label>
                                                <asp:Label ID="label_apellido" runat="server" Text='<%# Bind("apellido") %>'></asp:Label>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>


                        </tr>
                        <tr>
                            <th scope="row"></th>
                            <td>
                                <asp:Label ID="label4" runat="server" Text="Telefono:"></asp:Label>
                                <asp:Label ID="label_telefono" runat="server" Text='<%# Bind("telefono") %>'></asp:Label>

                            </td>
                            <td>
                                <asp:Label ID="label5" runat="server" Text="Dirección:"></asp:Label>
                                <asp:Label ID="label_direccion" runat="server" Text='<%# Bind("direccion") %>'></asp:Label>
                            </td>

                        </tr>
                        <tr>
                            <th scope="row"></th>
                            <td>
                                <asp:Label ID="label6" runat="server" Text="Correo:"></asp:Label>
                                <asp:Label ID="label_correo" runat="server" Text='<%# Bind("correo") %>'></asp:Label>

                            </td>
                            <td>
                                 <asp:Label ID="label8" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                                <asp:Label ID="label_nacimiento" runat="server" Text='<%# Bind("fecha_nacimieno","{0:d}") %>'></asp:Label>

                            </td>
                        </tr>
                        <tr>
                            <th scope="row"></th>
                            <td>
                                 <asp:Label ID="label9" runat="server" Text="Sexo:"></asp:Label>
                                <asp:Label ID="label_sexo" runat="server" Text='<%# Bind("sexo") %>'></asp:Label>
                            </td>
                           
                        </tr>
                        
                    </tbody>
                </table>

            </div>
        </ItemTemplate>
    </asp:FormView>




   

    <asp:ObjectDataSource ID="OBDS_busquedaUser" runat="server" SelectMethod="buscar_Cedula" TypeName="DAOUser">
        <SelectParameters>
            <asp:SessionParameter Name="cedula" SessionField="busqueda" Type="Int64" />
        </SelectParameters>
    </asp:ObjectDataSource>




   

    <br />
    <asp:Label ID="label_ciudad_sede" runat="server" Text="Ciudad de la Sede: "></asp:Label>
    <br />
    <asp:TextBox ID="text_ciudad_sede" placeholder="Digite la Ciudad de la Sede" runat="server"></asp:TextBox>
    <br />
    <br />


    
    <br />
    <asp:Button ID="button_sede" runat="server" Text="Registrar Sede" OnClick="button_sede_Click" CssClass="form-check-label" />
    <br />

</asp:Content>

