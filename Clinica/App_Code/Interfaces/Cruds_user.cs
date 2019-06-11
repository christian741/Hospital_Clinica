using System;
using System.Collections.Generic;
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
    void ver_User(Int64 id_user);
    void bloquearUser(long cedula);
    void DesbloquearUser(long cedula);

}