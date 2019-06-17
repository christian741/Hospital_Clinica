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

    protected void button_especial_Click(object sender, EventArgs e)
    {
        Especializacion esp = new Especializacion();
        esp.Nombre = text_especializacion_nombre_reg.Text;
        esp.Descripcion = text_descripcion_reg.Text;
        string dato = DDL_edad_esp.SelectedValue;
        if (dato.Equals("3"))
        {
            esp.Edad = 3;
        }
        else
        {
            if (dato.Equals("17"))
            {
                esp.Edad = 17;
            }
            else
            {
                if (dato.Equals("18"))
                {
                    esp.Edad = 18;
                }
                else
                {
                    if (dato.Equals("Todas las Edades"))
                    {
                        esp.Edad = 100;
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        esp.Sexo = DDL_sexo_esp.SelectedValue;
        if (esp.Sexo.Equals("Seleccione un Sexo"))
        {
            return;
        }
        else
        {
            esp.Sexo = DDL_sexo_esp.SelectedValue;
        }

        String dato2 = DDL_prioridad.SelectedValue;
        if (dato2.Equals("Solo Doctores"))
        {
            esp.Prioridad = 2;
        }
        else
        {
            if (dato2.Equals("Todos"))
            {
                esp.Prioridad = 1;
            }
            else
            {
                return;
            }
        }

        esp.Session = Session.SessionID;
        String ruta = FU_registro_esp.PostedFile.FileName;

        if (ruta != null && !(System.IO.Path.GetExtension(ruta).Equals(".jpg") || System.IO.Path.GetExtension(ruta).Equals(".png")))
        {
            return;
        }
        else
        {
            Image_especial.ImageUrl = System.IO.Path.GetFileName(ruta);
 
            esp.Foto = "~\\Imagenes\\Perfiles\\Sede\\" + System.IO.Path.GetFileName(ruta);

            FU_registro_esp.PostedFile.SaveAs(Server.MapPath(esp.Foto));
        }
        new DAOEspecializacion().insertar_Especializacion(esp);
        return;
    }
}