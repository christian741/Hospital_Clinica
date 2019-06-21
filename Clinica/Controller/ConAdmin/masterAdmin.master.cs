using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_masterAdmin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (Session["usuario"] == null || !Session["rol"].ToString().Equals("5"))
            {
                Response.Redirect("~/View/Principal/index.aspx");
            }
            DataTable foto = new DAOUser().ver_User(Convert.ToInt64(Session["usuario"].ToString()));
            image_user.ImageUrl = foto.Rows[0]["foto"].ToString();
        }
        catch (Exception ex)
        {
            if (ex.Equals(ex))
            {
                Response.Redirect("~/View/Principal/index.aspx");
            }

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

        Response.Redirect("~/View/Principal/index.aspx");
    }
}
