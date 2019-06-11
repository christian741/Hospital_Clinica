using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void cargar_Botones_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            Button btn1 = ((Button)e.Row.FindControl("but_bloquear"));
            Button btn2 = ((Button)e.Row.FindControl("but_desbloquear"));
            String est_lab = ((Label)e.Row.FindControl("label_estado")).Text;
            if (est_lab.Equals("1"))
            {

                btn1.Visible = true;
                btn2.Visible = false;
            }
            else
            {
                btn1.Visible = false;
                btn2.Visible = true;
            }

        }


    }
    protected void GV_Sede_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("bloquear"))
        {
            long dato = Convert.ToInt32(e.CommandArgument.ToString());
            new DAOSede().bloquear_Sede(dato);
            Response.Redirect("~/View/Admin/sedes/verSedes.aspx");


        }
        else
        {
            if (e.CommandName.Equals("desbloquear"))
            {
                long dato = Convert.ToInt32(e.CommandArgument.ToString());

                new DAOSede().DesbloquearSede(dato);
                Response.Redirect("~/View/Admin/sedes/verSedes.aspx");

            }
        }
    }
}