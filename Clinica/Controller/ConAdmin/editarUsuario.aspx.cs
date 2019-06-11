using System;
using System.Collections.Generic;
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

        Response.Redirect("~/View/Admin/indexAdmin.aspx");
    }
}