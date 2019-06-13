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
        FV_usuario.Visible = false;
    }

    protected void But_buscar_Click(object sender, EventArgs e)
    {
        long cedula = Convert.ToInt64(text_buscar.Text);
        DataTable datos_usu =new DAOUser().buscar_Cedula(cedula);
        if (datos_usu.Rows.Count < 1)
        {
            

            return;
        }
        else
        {
            if (!datos_usu.Rows[0]["rol_id"].ToString().Equals("7"))
            {
               
               

                return;
            }
            Session["busqueda_id"] = datos_usu.Rows[0]["id_usuario"].ToString();
            Session["busqueda"] = cedula;
            FV_usuario.Visible = true;
            

        }

        return;
    }

    protected void button_sede_Click(object sender, EventArgs e)
    {
        Sede sede = new Sede();
        sede.Nombre = text_sede_nombre_reg.Text;
        sede.Direccion = text_sede_direccion.Text;
        sede.Descripcion = text_sede_descripcion.Text;
        sede.Encargado = Convert.ToInt64(Session["busqueda_id"].ToString());
        sede.Ciudad = text_ciudad_sede.Text;
        sede.Session = Session.SessionID;
        String ruta = FU_registro_sede.PostedFile.FileName;

        if (ruta != null && !(System.IO.Path.GetExtension(ruta).Equals(".jpg") || System.IO.Path.GetExtension(ruta).Equals(".png")))
        {
            return;
        }
        else
        {
            Image_sede.ImageUrl = System.IO.Path.GetFileName(ruta);

            sede.Foto = "~\\Imagenes\\Perfiles\\Sede\\" + System.IO.Path.GetFileName(ruta);

            FU_registro_sede.PostedFile.SaveAs(Server.MapPath(sede.Foto));
        }
        new DAOSede().insertar_Sede(sede);
        Response.Redirect("~/View/Administrador/verSedes.aspx");


    }
}