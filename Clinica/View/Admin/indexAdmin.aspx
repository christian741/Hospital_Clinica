<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/masterAdmin.master" AutoEventWireup="true"
    CodeFile="~/Controller/ConAdmin/indexAdmin.aspx.cs" Inherits="View_Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:FormView ID="FV_usuario" runat="server" >
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
                                <asp:Label ID="label7" runat="server" Text="Contraseña:"></asp:Label>
                                <asp:Label ID="label_clave" runat="server" Text="***********"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row"></th>
                            <td>
                                <asp:Label ID="label8" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                                <asp:Label ID="label_nacimiento" runat="server" Text='<%# Bind("fecha_nacimieno","{0:d}") %>'></asp:Label>

                            </td>
                            <td>
                                <asp:Label ID="label9" runat="server" Text="Sexo:"></asp:Label>
                                <asp:Label ID="label_sexo" runat="server" Text='<%# Bind("sexo") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <th scope="row"></th>
                            <td></td>
                            <td>
                                <!-- Button trigger modal -->
                                <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#Especial">
                                    Actualizar Datos
                                </button>


                                <!-- Modal -->
                                <div class="modal fade" id="Especial" tabindex="-1" role="dialog" aria-labelledby="Especial1" aria-hidden="true">
                                    <div class="modal-dialog modal-dialog-scrollable" role="document">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                                <h5 class="modal-title" id="Especial1">Validación del Usuario</h5>
                                                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                                    <span aria-hidden="true">&times;</span>
                                                </button>
                                            </div>
                                            <div class="modal-body">

                                                <asp:Label ID="label10" runat="server" Text="Digite su Contraseña:"></asp:Label>

                                                <asp:TextBox ID="text_validar_pass" TextMode="Password" runat="server"></asp:TextBox>

                                            </div>
                                            <div class="modal-footer">
                                                <asp:Button ID="button_editar" runat="server" Text="Validar Password" OnClick="button_editar_Click1" />

                                                <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </td>
                        </tr>

                    </tbody>
                </table>

            </div>
        </ItemTemplate>
    </asp:FormView>
    

   

</asp:Content>

