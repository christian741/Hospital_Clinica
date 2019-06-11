using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Farmaceuta_masterFarma : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"] == null || !Session["rol"].ToString().Equals("3"))
        {
            Response.Redirect("../Principal/index.aspx");
        }
    }
    protected void but_cerrar_Click(object sender, EventArgs e)
    {
        User usu = new User();
        usu.Session = Session.SessionID;
        new DAOUser().cerrarSession(usu);
        Session["usuario"] = null;
        Session["sede"] = null;
        Session["rol"] = null;
        Response.Redirect("../Principal/index.aspx");
    }
}
