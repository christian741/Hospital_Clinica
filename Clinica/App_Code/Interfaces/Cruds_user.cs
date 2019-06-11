using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cruds
/// </summary>
public interface Cruds_user
{

    void insertar_User(User user);
    void modificar_User(User user);
    void bloquear_User(Int64 id_user);
    DataTable ver_User(Int64 id_user);
    void DesbloquearUser(long id_user);

}