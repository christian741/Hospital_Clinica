using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Es la clase Prinicipal del Maanejo de Usurios del Hospital
/// </summary>
/// <remarks>
/// Esta Clase permite add, edit, read, y Block
/// </remarks>
public abstract class User : Cruds_user
{
    

    public User()
    {
      
    }
    /// <param name="id_user">Es el id del usuario en la Data Base</param>
    public abstract void bloquear_User(long id_user);
    /// <param name="user">Es un objeto de tipo Usuario</param>
    public abstract void insertar_User(User user);
    /// <param name="user">Es un objeto de tipo Usuario</param>
    public abstract void modificar_User(User user);
    /// <param name="id_user">Es el id del usuario en la Data Base</param>
    public abstract void ver_User(long id_user);
}