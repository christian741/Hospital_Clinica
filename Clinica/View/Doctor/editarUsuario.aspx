<%@ Page Title="" Language="C#" MasterPageFile="~/View/Doctor/masterDoctor.master" 
    AutoEventWireup="true" CodeFile="~/Controller/ConDoctor/editarUsuario.aspx.cs" Inherits="View_Doctor_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <asp:FormView ID="FV_usuario" runat="server" DataSourceID="OBDS_editUser">
        <ItemTemplate>
            <div class="table-responsive">
                <table class="table table-sm">
                    <thead>
                        <tr>

                            <caption>Información del Administrador</caption>
                            <div class="container-fluid" style="text-align: center">
                                EDICIÓN INFORMACION DEL USUARIO
                            </div>

                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope="row"></th>
                            <td>
                                <asp:Image ID="Imagen_usu" runat="server" ImageUrl='<%# Bind("foto") %>' Width="30%" CssClass="rounded-circle" />
                                <asp:FileUpload ID="File_usu" runat="server" />

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
                                                <asp:Label ID="label_id" runat="server" Text='<%# Bind("id_usuario") %>' Visible="false"></asp:Label>
                                                <asp:Label ID="label2" runat="server" Text='<%# Bind("cedula") %>' Visible="false"></asp:Label>

                                                <asp:Label ID="label_ced" runat="server" Text="Cedula:"></asp:Label>
                                                <asp:TextBox ID="txt_cedula" runat="server" TextMode="Number" MaxLength="10" Text='<%# Bind("cedula") %>'></asp:TextBox>
                                                <asp:Label ID="error_ced" runat="server" Visible="false"></asp:Label>
                                                <br />
                                                <br />

                                            </td>
                                            <td>
                                                <asp:Label ID="label3" runat="server" Text='<%# Bind("nombre") %>' Visible="false"></asp:Label>

                                                <asp:Label ID="label_nom" runat="server" Text="Nombre:"></asp:Label>
                                                <asp:TextBox ID="txt_primer_nombre" runat="server" MaxLength="50" Text='<%# Bind("primer_nombre") %>'></asp:TextBox>
                                                <asp:TextBox ID="txt_segundo_nombre" runat="server" MaxLength="50" Text='<%# Bind("segundo_nombre") %>'></asp:TextBox>

                                                <asp:Label ID="error_nom" runat="server" Visible="false"></asp:Label>
                                                <br />
                                                <br />
                                            </td>
                                            <td>
                                                <asp:Label ID="label4" runat="server" Text='<%# Bind("apellido") %>' Visible="false"></asp:Label>
                                                <asp:Label ID="label_apellido" runat="server" Text="Apellido:"></asp:Label>
                                                <asp:TextBox ID="txt_primer_apellido" runat="server" MaxLength="50" Text=' <%# Bind("primer_apellido") %>'></asp:TextBox>
                                                <asp:TextBox ID="text_segundo_apellido" runat="server" MaxLength="50" Text='<%# Bind("segundo_apellido") %>'></asp:TextBox>

                                                <asp:Label ID="error_ape" runat="server" Visible="false"></asp:Label>
                                                <br />
                                                <br />
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </td>


                        </tr>
                        <tr>
                            <th scope="row"></th>
                            <td>
                                <asp:Label ID="label5" runat="server" Text='<%# Bind("telefono") %>' Visible="false"></asp:Label>

                                <asp:Label ID="label_tel" runat="server" Text="Telefono:"></asp:Label>
                                <asp:TextBox ID="txt_telefono" TextMode="Phone" MaxLength="10" runat="server" Text='<%# Bind("telefono") %>'></asp:TextBox>
                                <asp:Label ID="error_tel" runat="server" Visible="false"></asp:Label>
                                <br />
                                <br />
                            </td>
                            <td>
                                <asp:Label ID="label6" runat="server" Text='<%# Bind("direccion") %>' Visible="false"></asp:Label>

                                <asp:Label ID="label_dir" runat="server" Text="Dirección:"></asp:Label>
                                <asp:TextBox ID="txt_direccion" MaxLength="50" runat="server" Text='<%# Bind("direccion") %>'></asp:TextBox>
                                <asp:Label ID="error_dir" runat="server" Visible="false"></asp:Label>
                                <br />
                                <br />
                            </td>


                        </tr>
                        <tr>
                            <th scope="row"></th>
                            <td>
                                <asp:Label ID="label7" runat="server" Text='<%# Bind("correo") %>' Visible="false"></asp:Label>

                                <asp:Label ID="label_correo" runat="server" Text="Correo:"></asp:Label>
                                <asp:TextBox ID="txt_correo" MaxLength="50" TextMode="Email" runat="server" Text='<%# Bind("correo") %>'></asp:TextBox>
                                <asp:Label ID="error_correo" runat="server" Visible="false"></asp:Label>
                                <br />
                                <br />
                            </td>
                            <td>
                                <asp:Label ID="label8" runat="server" Text='<%# Bind("clave") %>' Visible="false"></asp:Label>

                                <asp:Label ID="label_contraseña" runat="server" Text="Contraseña:"></asp:Label>
                                <asp:Label ID="txt_clave" runat="server" Text='<%# Bind("clave") %>'></asp:Label>

                                <br />
                                <asp:Label ID="label_nuevaContra" runat="server" Text="Escriba la nueva Contraseña:"></asp:Label>
                                <asp:TextBox ID="txt_contraseña" runat="server" MaxLength="16" TextMode="Password"></asp:TextBox>

                                <asp:Label ID="error_clave" runat="server" Visible="false"></asp:Label>
                                <br />
                                <br />

                            </td>
                        </tr>
                        <tr>
                            <th scope="row"></th>
                            <td>e
                                <asp:Label ID="label_nac" runat="server" Text="Fecha de Nacimiento:"></asp:Label>
                                <asp:Label ID="label9" runat="server" Text='<%# Bind("fecha_nacimieno") %>'></asp:Label>
                                <br />
                                <asp:TextBox ID="txt_nacimiento" runat="server" TextMode="Date"></asp:TextBox>
                                <asp:Label ID="error_nac" runat="server" Visible="false"></asp:Label>
                                <br />
                                <br />
                            </td>
                            <td>
                                <asp:Label ID="label_sexo" runat="server" Text="Sexo:"></asp:Label>

                                <asp:Label ID="label_10" runat="server" Text='<%# Bind("sexo") %>'></asp:Label>

                                <asp:Label ID="labeledi_sex" runat="server" Text="Seleccione su Sexo"></asp:Label>
                                <br />
                                <asp:DropDownList ID="DDL_sexo_doc" runat="server">
                                    <asp:ListItem>Seleccione un Sexo</asp:ListItem>
                                    <asp:ListItem>Maculino</asp:ListItem>
                                    <asp:ListItem>Femenino</asp:ListItem>
                                    <asp:ListItem>Otro</asp:ListItem>
                                </asp:DropDownList>
                                <asp:Label ID="error_sexo" runat="server" Visible="false"></asp:Label>
                                <br />
                                <br />

                            </td>
                        </tr>
                        <tr>
                            <th scope="row"></th>
                            <td></td>
                            <td>
                                <asp:Button ID="button_editar" runat="server" Text="Actualizar Datos" OnClick="button_editar_Click" />
                                <asp:Button ID="button_salir" runat="server" Text="Salir" OnClick="button_salir_Click" />

                            </td>
                        </tr>

                    </tbody>
                </table>

            </div>
        </ItemTemplate>
    </asp:FormView>



    <asp:ObjectDataSource ID="OBDS_editUser" runat="server" SelectMethod="ver_User" TypeName="DAOUser">
        <SelectParameters>
            <asp:SessionParameter Name="id_user" SessionField="usuario" Type="Int64" />
        </SelectParameters>
    </asp:ObjectDataSource>

</asp:Content>

