using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void button_salir_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/View/Admin/indexAdmin.aspx");

    }

    protected void button_editar_Click(object sender, EventArgs e)
    {
        User user = new User();
        user.Id_user = Convert.ToInt64(Session["usuario"].ToString());
        Int64 cedula_label = Convert.ToInt64(((Label)FV_usuario.FindControl("label2")).Text);
        user.Cedula = Convert.ToInt64(((TextBox)FV_usuario.FindControl("txt_cedula")).Text);
        if (cedula_label == user.Cedula)
        {

        }
        else
        {
            DataTable datos = new DAOUser().buscar_Cedula(user.Cedula);

            if (datos.Rows.Count > 0)
            {
                
               
                return;
            }
            else
            {
                user.Cedula = Convert.ToInt64(((TextBox)FV_usuario.FindControl("txt_cedula")).Text);
            }
        }
        user.Primer_nombre= ((TextBox)FV_usuario.FindControl("txt_primer_nombre")).Text;
        user.Segundo_nombre = ((TextBox)FV_usuario.FindControl("txt_segundo_nombre")).Text;
        user.Primer_apellido= ((TextBox)FV_usuario.FindControl("txt_primer_apellido")).Text;
        user.Segundo_apellido=((TextBox)FV_usuario.FindControl("text_segundo_apellido")).Text;
        user.Direccion = ((TextBox)FV_usuario.FindControl("txt_direccion")).Text;
        user.Telefono = ((TextBox)FV_usuario.FindControl("txt_telefono")).Text;
        user.Correo = ((TextBox)FV_usuario.FindControl("txt_correo")).Text;
        user.Password = ((TextBox)FV_usuario.FindControl("txt_contraseña")).Text;
        String confirmacion = ((TextBox)FV_usuario.FindControl("txt_contraseña_confirm")).Text;
        if (!user.Password.Equals(confirmacion))
        {
            return;
        }
        user.Nacimiento = Convert.ToDateTime(((TextBox)FV_usuario.FindControl("txt_nacimiento")).Text);
        user.Sexo = ((DropDownList)FV_usuario.FindControl("DDL_sexo_doc")).SelectedValue;
        if (user.Sexo.Equals("Seleccione un Sexo"))
        {
            user.Sexo = ((Label)FV_usuario.FindControl("label_10")).Text;
        }
        else
        {
            user.Sexo = ((DropDownList)FV_usuario.FindControl("DDL_sexo_doc")).SelectedValue;

        }
        user.Session = Session.SessionID;
        user.Rol = Convert.ToInt16(Session["rol"].ToString());
        user.Sede = Convert.ToInt32(Session["sede"].ToString());
        FileUpload file = ((FileUpload)FV_usuario.FindControl("File_usu"));
        if (file.PostedFile.FileName != null && !(System.IO.Path.GetExtension(file.PostedFile.FileName).Equals(".jpg") || System.IO.Path.GetExtension(file.PostedFile.FileName).Equals(".png")))
        {
            user.Foto = ((Image)FV_usuario.FindControl("Imagen_usu")).ImageUrl.ToString();
        }
        else
        {

            user.Foto = "~\\Imagenes\\Perfiles\\Administrador\\" + System.IO.Path.GetFileName(file.PostedFile.FileName);

            file.PostedFile.SaveAs(Server.MapPath(user.Foto));
        }
        new DAOUser().modificar_User(user);
        Response.Redirect("~/View/Admin/indexAdmin.aspx");
    }

  
}