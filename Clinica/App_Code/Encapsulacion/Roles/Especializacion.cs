using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Especializacion
/// </summary>
public class Especializacion
{
    private int id;
    private String nombre;
    private String descripcion;
    private String foto;
    private string session;
    private short edad;
    private String sexo;
    private short prioridad;


    public Especializacion()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public string Foto { get => foto; set => foto = value; }
    public string Session { get => session; set => session = value; }
    public short Edad { get => edad; set => edad = value; }
    public string Sexo { get => sexo; set => sexo = value; }
    public short Prioridad { get => prioridad; set => prioridad = value; }
}