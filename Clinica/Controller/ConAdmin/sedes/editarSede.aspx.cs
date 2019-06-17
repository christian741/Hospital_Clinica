using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String sede= Request.QueryString["sede"];
        if (!Session["editar"].ToString().Equals(sede) || Session["editar"]==null)
        {
            Session["editar"] = null;
        }
    }

    protected void button_sede_Click(object sender, EventArgs e)
    {
        Sede sede = new Sede();
        sede.Id = Convert.ToInt32(FV_sede.DataSourceID);
        sede.Nombre = ((TextBox)FV_sede.FindControl("text_sede_nombre_reg")).Text;
        sede.Direccion = ((TextBox)FV_sede.FindControl("text_sede_direccion")).Text;
        sede.Descripcion = ((TextBox)FV_sede.FindControl("text_sede_descripcion")).Text;
        sede.Ciudad = ((TextBox)FV_sede.FindControl("text_ciudad_sede")).Text;
        sede.Session = Session.SessionID;
        String ruta = ((FileUpload)FV_sede.FindControl("FU_registro_sede")).PostedFile.FileName;

        if (ruta != null && !(System.IO.Path.GetExtension(ruta).Equals(".jpg") || System.IO.Path.GetExtension(ruta).Equals(".png")))
        {
            return;
        }
        else
        {

            sede.Foto = "~\\Imagenes\\Perfiles\\Sede\\" + System.IO.Path.GetFileName(ruta);

            ((FileUpload)FV_sede.FindControl("FU_registro_sede")).PostedFile.SaveAs(Server.MapPath(sede.Foto));
        }
        new DAOSede().modificar_Sede(sede);


    }
}