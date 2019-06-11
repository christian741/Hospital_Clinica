using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Principal_Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void but_login_Click(object sender, EventArgs e)
    {
        DataTable datos_usuario = new DAOUser().buscar_Usuario(Convert.ToInt32(text_cedula.Text), text_password.Text);


        if (datos_usuario.Rows.Count > 0)
        {
            if (datos_usuario.Rows[0]["estado"].ToString().Equals("2"))
            {
              
                return;
            }
            if (datos_usuario.Rows[0]["rol_id"].ToString().Equals("1"))
            {
                User usu = new User();
                Session["usuario"] = Convert.ToInt32(datos_usuario.Rows[0]["id_usuario"].ToString());
                Session["rol"] = Convert.ToInt32(datos_usuario.Rows[0]["rol_id"].ToString());
                Session["sede"] = Convert.ToInt32(datos_usuario.Rows[0]["sede_id"].ToString());

                MAC datosConexion = new MAC();

                usu.Id_user = Convert.ToInt32(datos_usuario.Rows[0]["id_usuario"].ToString());
                usu.Ip = datosConexion.ip();
                usu.Mac = datosConexion.mac();
                usu.Session = Session.SessionID;

                new DAOUser().guardadoSession(usu);

                Response.Redirect("../Paciente/indexPaciente.aspx");
            }
            else
            {
                if (datos_usuario.Rows[0]["rol_id"].ToString().Equals("2"))
                {
                    User usu = new User();
                    Session["usuario"] = Convert.ToInt32(datos_usuario.Rows[0]["id_usuario"].ToString());
                    Session["rol"] = Convert.ToInt32(datos_usuario.Rows[0]["rol_id"].ToString());
                    Session["sede"] = Convert.ToInt32(datos_usuario.Rows[0]["sede_id"].ToString());

                    MAC datosConexion = new MAC();

                    usu.Id_user = Convert.ToInt16(datos_usuario.Rows[0]["id_usuario"].ToString());
                    usu.Ip = datosConexion.ip();
                    usu.Mac = datosConexion.mac();
                    usu.Session = Session.SessionID;

                    new DAOUser().guardadoSession(usu);
                   
                    Response.Redirect("../Doctor/indexDoctor.aspx");

                }
                else
                {
                    if (datos_usuario.Rows[0]["rol_id"].ToString().Equals("3"))
                    {
                        User usu = new User();
                        Session["usuario"] = Convert.ToInt32(datos_usuario.Rows[0]["id_usuario"].ToString());
                        Session["rol"] = Convert.ToInt32(datos_usuario.Rows[0]["rol_id"].ToString());
                        Session["sede"] = Convert.ToInt32(datos_usuario.Rows[0]["sede_id"].ToString());
                        MAC datosConexion = new MAC();

                        usu.Id_user = Convert.ToInt16(datos_usuario.Rows[0]["id_usuario"].ToString());
                        usu.Ip = datosConexion.ip();
                        usu.Mac = datosConexion.mac();
                        usu.Session = Session.SessionID;

                        new DAOUser().guardadoSession(usu);
                        Response.Redirect("../Farmaceuta/indexFarma.aspx");

                    }
                    else
                    {
                        if (datos_usuario.Rows[0]["rol_id"].ToString().Equals("4"))
                        {
                            User usu = new User();
                            Session["usuario"] = Convert.ToInt32(datos_usuario.Rows[0]["id_usuario"].ToString());
                            Session["rol"] = Convert.ToInt32(datos_usuario.Rows[0]["rol_id"].ToString());
                            Session["sede"] = Convert.ToInt32(datos_usuario.Rows[0]["sede_id"].ToString());
                            MAC datosConexion = new MAC();

                            usu.Id_user = Convert.ToInt16(datos_usuario.Rows[0]["id_usuario"].ToString());
                            usu.Ip = datosConexion.ip();
                            usu.Mac = datosConexion.mac();
                            usu.Session = Session.SessionID;

                            new DAOUser().guardadoSession(usu);
                            Response.Redirect("../Laboratorista/indexLabo.aspx");

                        }
                        else
                        {
                            if (datos_usuario.Rows[0]["rol_id"].ToString().Equals("5"))
                            {
                                User usu = new User();
                                Session["usuario"] = Convert.ToInt32(datos_usuario.Rows[0]["id_usuario"].ToString());
                                Session["rol"] = Convert.ToInt32(datos_usuario.Rows[0]["rol_id"].ToString());
                                Session["sede"] = Convert.ToInt32(datos_usuario.Rows[0]["sede_id"].ToString());
                                MAC datosConexion = new MAC();

                                usu.Id_user = Convert.ToInt16(datos_usuario.Rows[0]["id_usuario"].ToString());
                                usu.Ip = datosConexion.ip();
                                usu.Mac = datosConexion.mac();
                                usu.Session = Session.SessionID;

                                new DAOUser().guardadoSession(usu);
                                Response.Redirect("../Admin/indexAdmin.aspx");

                            }
                            else
                            {
                                if (datos_usuario.Rows[0]["rol_id"].ToString().Equals("6"))
                                {
                                    User usu = new User();
                                    Session["usuario"] = Convert.ToInt32(datos_usuario.Rows[0]["id_usuario"].ToString());
                                    Session["rol"] = Convert.ToInt32(datos_usuario.Rows[0]["rol_id"].ToString());
                                    Session["sede"] = Convert.ToInt32(datos_usuario.Rows[0]["sede_id"].ToString());
                                    MAC datosConexion = new MAC();

                                    usu.Id_user = Convert.ToInt16(datos_usuario.Rows[0]["id_usuario"].ToString());
                                    usu.Ip = datosConexion.ip();
                                    usu.Mac = datosConexion.mac();
                                    usu.Session = Session.SessionID;

                                    new DAOUser().guardadoSession(usu);
                                    Response.Redirect("../Recepcionista/indexRecep.aspx");

                                }
                                else{
                                    if (datos_usuario.Rows[0]["rol_id"].ToString().Equals("7"))
                                    {
                                        User usu = new User();
                                        Session["usuario"] = Convert.ToInt32(datos_usuario.Rows[0]["id_usuario"].ToString());
                                        Session["rol"] = Convert.ToInt32(datos_usuario.Rows[0]["rol_id"].ToString());
                                        Session["sede"] = Convert.ToInt32(datos_usuario.Rows[0]["sede_id"].ToString());
                                        MAC datosConexion = new MAC();

                                        usu.Id_user = Convert.ToInt16(datos_usuario.Rows[0]["id_usuario"].ToString());
                                        usu.Ip = datosConexion.ip();
                                        usu.Mac = datosConexion.mac();
                                        usu.Session = Session.SessionID;

                                        new DAOUser().guardadoSession(usu);
                                        Response.Redirect("../Admin/Encargados/indexEncargados.aspx");

                                    }
                                }
                            }
                        }


                    }
                }
            }
        }
        Session["usuario"] = null;
        Session["rol"] = null;
        Session["sede"] = null;

       
        return;

    }
}