using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Farmaceuta_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button_editar_Click1(object sender, EventArgs e)
    {
        String password = ((TextBox)FV_usuario.FindControl("text_validar_pass")).Text;

        DataTable validar = new DAOUser().buscar_Usuario(Convert.ToInt64(Session["usuario"].ToString()), password);
        if (validar.Rows.Count < 1)
        {
            return;
        }
        else
        {
            Response.Redirect("~/View/Farmaceuta/editarUsuario.aspx");

        }

    }
}