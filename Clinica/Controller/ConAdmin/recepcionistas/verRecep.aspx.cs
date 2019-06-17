using AjaxControlToolkit;
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
            String sede = ((Label)e.Row.FindControl("label_sede")).Text;

            DataTable tabla = new DAOSede().ver_Sedes();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if (sede.Equals(tabla.Rows[i]["id_sede"].ToString()))
                {
                    Label lbl_sede = ((Label)e.Row.FindControl("label_sede"));
                    lbl_sede.Text = tabla.Rows[i]["nombre"].ToString();
                }
            }
        }
    }
    
    protected void GV_user_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName.Equals("bloquear"))
        {
            Int64 dato = Convert.ToInt64(e.CommandArgument.ToString());
            new DAOUser().bloquear_User(dato);
        }
        if (e.CommandName.Equals("desbloquear"))
        {
            Int64 dato = Convert.ToInt64(e.CommandArgument.ToString());
            new DAOUser().DesbloquearUser(dato);
        }
        if (e.CommandName.Equals("editar"))
        {
            Int64 dato = Convert.ToInt64(e.CommandArgument.ToString());
            Session["editar"] = dato;
            Response.Redirect("~/View/Admin/recepcionistas/editarRecep.aspx?user=" + dato);

        }
        if (e.CommandName.Equals("info"))
        {
            Int64 dato = Convert.ToInt64(e.CommandArgument.ToString());
            DataTable tabla= new DAOUser().ver_User(dato);
            ((Image)FV_usuario.FindControl("Imagen_user")).ImageUrl = tabla.Rows[0]["foto"].ToString();
            ((Label)FV_usuario.FindControl("label_nombres")).Text = tabla.Rows[0]["primer_nombre"].ToString()+" "+ tabla.Rows[0]["segundo_nombre"].ToString();
            ((Label)FV_usuario.FindControl("label_apellidos")).Text = tabla.Rows[0]["primer_apellido"].ToString() + " " + tabla.Rows[0]["segundo_apellido"].ToString();
            ((Label)FV_usuario.FindControl("label_direccion")).Text = tabla.Rows[0]["direccion"].ToString();
            ((Label)FV_usuario.FindControl("label_telefono")).Text = tabla.Rows[0]["telefono"].ToString();
            ((Label)FV_usuario.FindControl("label_correo")).Text = tabla.Rows[0]["correo"].ToString();
            ((Label)FV_usuario.FindControl("label_clave")).Text = tabla.Rows[0]["clave"].ToString();
            ((Label)FV_usuario.FindControl("label_nacimiento")).Text = tabla.Rows[0]["fecha_nacimieno"].ToString();
            ((Label)FV_usuario.FindControl("label_sexo")).Text = tabla.Rows[0]["sexo"].ToString();


        }

    }

}