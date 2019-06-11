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
public  class User 
{
    private long id_user;
    private long cedula;
    private String primer_nombre;
    private String segundo_nombre;
    private String primer_apellido;
    private String segundo_apellido;
    private String direccion;
    private long telefono;
    private String correo;
    private String password;
    private DateTime nacimiento;
    private String sexo;
    private String foto;
    private String session;
    private int sede;
    private short rol;
    private string mac;
    private string ip;
   


    public User()
    {
      
    }

    public long Id_user { get => id_user; set => id_user = value; }
    public string Primer_nombre { get => primer_nombre; set => primer_nombre = value; }
    public string Segundo_nombre { get => segundo_nombre; set => segundo_nombre = value; }
    public string Primer_apellido { get => primer_apellido; set => primer_apellido = value; }
    public string Segundo_apellido { get => segundo_apellido; set => segundo_apellido = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public long Telefono { get => telefono; set => telefono = value; }
    public string Correo { get => correo; set => correo = value; }
    public string Password { get => password; set => password = value; }
    public DateTime Nacimiento { get => nacimiento; set => nacimiento = value; }
    public string Sexo { get => sexo; set => sexo = value; }
    public string Foto { get => foto; set => foto = value; }
    public string Session { get => Session; set => Session = value; }
    public int Sede { get => sede; set => sede = value; }
    public short Rol { get => rol; set => rol = value; }
    public string Mac { get => mac; set => mac = value; }
    public string Ip { get => ip; set => ip = value; }
    public long Cedula { get => cedula; set => cedula = value; }
}