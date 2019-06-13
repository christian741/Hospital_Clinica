﻿using AjaxControlToolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Admin_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void button_cancelar_Click(object sender, EventArgs e)
    {
        ((ModalPopupExtender)FV_usuario.FindControl("modal")).Hide();
    }

    protected void button_editar_Click1(object sender, EventArgs e)
    {
        String password = ((TextBox)FV_usuario.FindControl("text_validar_pass")).Text;

        DataTable validar = new DAOUser().buscar_Usuario_id(Convert.ToInt64(Session["usuario"].ToString()), password);
        if (validar.Rows.Count < 1)
        {
            return;
        }
        else
        {

            ((ModalPopupExtender)FV_usuario.FindControl("modal")).Hide();
             Response.Redirect("~/View/Admin/editarUsuario.aspx");

        }

    }
}