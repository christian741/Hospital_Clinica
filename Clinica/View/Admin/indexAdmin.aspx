<%@ Page Title="Inicio Admin" Language="C#" MasterPageFile="~/View/Admin/masterAdmin.master" AutoEventWireup="true"
    CodeFile="~/Controller/ConAdmin/indexAdmin.aspx.cs" Inherits="View_Admin_Default" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:FormView ID="FV_usuario" runat="server" DataSourceID="OBDS_user">
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
                                                <asp:Label ID="label_primer_nombre" runat="server" Text='<%# Bind("primer_nombre") %> '></asp:Label>
                                                <asp:Label ID="label_segundo_nombre" runat="server" Text=' <%# Bind("segundo_nombre") %>'></asp:Label>

                                            </td>
                                            <td>
                                                <asp:Label ID="label3" runat="server" Text="Apellido:"></asp:Label>
                                                <asp:Label ID="label_primer_apellido" runat="server" Text=' <%# Bind("primer_apellido") %>'></asp:Label>
                                                <asp:Label ID="label_segundo_apellido" runat="server" Text=' <%# Bind("segundo_apellido") %>'></asp:Label>

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
                                 <!-- ModalPopupExtender -->
                                

                                <asp:Button ID="but_actualizar" CssClass="btn btn-info" runat="server" Text="Actualizar Datos" />

                                <cc1:ModalPopupExtender ID="modal" runat="server" PopupControlID="Panel" TargetControlID="but_actualizar"
                                    CancelControlID="but_salir" BackgroundCssClass="Background">
                                </cc1:ModalPopupExtender>

                                <asp:Panel ID="Panel" runat="server" CssClass="" align="center" Style="display: none">
                                    <div class="card">
                                        <div class="card-body">
                                            <h5 class="card-title"> Verificacion Datos</h5><br />
                                            <p class="card-text">
                                                 <asp:Label ID="label10" runat="server" Text="Digite su Contraseña:"></asp:Label><br />
                                                  <asp:TextBox ID="text_validar_pass" TextMode="Password" runat="server"></asp:TextBox><br />
                                            </p>
                                            <asp:Button ID="button_editar" CssClass="btn btn-outline-primary" runat="server" Text="Validar Password" OnClick="button_editar_Click1" />
                                            <asp:Button ID="but_salir" CssClass="btn btn-danger" runat="server" Text="Salir" />
                                        </div>
                                    </div>
                                </asp:Panel>
                            </td>
                        </tr>

                    </tbody>
                </table>

            </div>
        </ItemTemplate>
    </asp:FormView>


    <asp:Label ID="label_oculto" runat="server" Text=""></asp:Label>

    <cc1:ModalPopupExtender ID="modal2" runat="server" PopupControlID="Panel2" TargetControlID="label_oculto"
        CancelControlID="but_salir" BackgroundCssClass="Background">
    </cc1:ModalPopupExtender>

    <asp:Panel ID="Panel2" runat="server" CssClass="alert-warning" align="center" Style="display: none">
        <div class="card text-white bg-warning">
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

    <asp:ObjectDataSource ID="OBDS_user" runat="server" SelectMethod="ver_User" TypeName="DAOUser">
        <SelectParameters>
            <asp:SessionParameter Name="id_user" SessionField="usuario" Type="Int64" />
        </SelectParameters>
    </asp:ObjectDataSource>



    <script type="text/javascript" src="../../bootstrap/js/min/bootstrap.min.js"></script>
</asp:Content>


