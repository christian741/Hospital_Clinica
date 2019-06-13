using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Doctor_masterDoctor : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["usuario"] == null || !Session["rol"].ToString().Equals("2"))
        {
            Response.Redirect("../Principal/index.aspx");
        }
        DataTable foto = new DAOUser().ver_User(Convert.ToInt64(Session["usuario"].ToString()));
        image_user.ImageUrl = foto.Rows[0]["foto"].ToString();
        
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
