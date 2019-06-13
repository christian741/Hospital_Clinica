using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Principal_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void but_registrar_Click(object sender, EventArgs e)
    {
        User user = new User();
        long cedula = Convert.ToInt64(text_cedula.Text);
        DataTable datos = new DAOUser().buscar_Cedula(cedula);
        if (datos.Rows.Count > 0)
        {
            return;
        }
        else
        {
            user.Cedula = Convert.ToInt64(text_cedula.Text);
        }
        user.Primer_nombre = text_primer_nombre.Text;
        user.Segundo_nombre = text_segundo_nombre.Text;
        user.Primer_apellido = text_primer_apellido.Text;
        user.Segundo_apellido = text_segundo_apellido.Text;
        user.Direccion = text_direccion.Text;
        user.Telefono = text_telefono.Text;
        user.Correo = text_correo.Text;
        user.Password = text_pass.Text;
        String confirmacion = text_confirmacion_pass.Text;
        if (!user.Password.Equals(confirmacion))
        {
            return;
        }
        user.Nacimiento = Convert.ToDateTime(text_fecha.Text);
        String sexo = DDL_sexo.SelectedValue;
        if (sexo.Equals("Seleccione un Sexo"))
        {
            return;
        }
        else
        {
            user.Sexo = DDL_sexo.SelectedValue;
        }
        user.Session = Session.SessionID;
        user.Rol = Convert.ToInt16(Session["rol"].ToString());
        user.Sede = Convert.ToInt32(Session["sede"].ToString());
        FileUpload file = FU_imagen;
        if (file.PostedFile.FileName != null && !(System.IO.Path.GetExtension(file.PostedFile.FileName).Equals(".jpg") || System.IO.Path.GetExtension(file.PostedFile.FileName).Equals(".png")))
        {
            return;
        }
        else
        {

            user.Foto = "~\\Imagenes\\Perfiles\\Paciente\\" + System.IO.Path.GetFileName(file.PostedFile.FileName);

            file.PostedFile.SaveAs(Server.MapPath(user.Foto));
        }
        new DAOUser().insertar_User(user);
        Response.Redirect("~/View/Principal/registro.aspx");
    }

}
