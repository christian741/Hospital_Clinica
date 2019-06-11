using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Sede
/// </summary>
public class Sede
{
    private int id;
    private String nombre;
    private String direccion;
    private String descripcion;
    private String encargado;
    private String ciudad;
    private String foto;
    private String session;
    public Sede()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

   

    public string Nombre { get => nombre; set => nombre = value; }
    public string Direccion { get => direccion; set => direccion = value; }
    public string Ciudad { get => ciudad; set => ciudad = value; }
    public string Foto { get => foto; set => foto = value; }
    public string Session { get => session; set => session = value; }
    public string Encargado { get => encargado; set => encargado = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Id { get => id; set => id = value; }
}