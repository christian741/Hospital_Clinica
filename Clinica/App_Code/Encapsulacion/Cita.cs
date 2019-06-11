using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cita
/// </summary>
public class Cita
{
    private long id;
    private int especializacion;
    private long paciente;
    private long doctor;
    private int sede;
    private String fecha_cita;
    private String session;
    private String razon;

    public Cita()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public long Id { get => id; set => id = value; }
    public int Especializacion { get => especializacion; set => especializacion = value; }
    public long Paciente { get => paciente; set => paciente = value; }
    public long Doctor { get => doctor; set => doctor = value; }
    public int Sede { get => sede; set => sede = value; }
    public string Fecha_cita { get => fecha_cita; set => fecha_cita = value; }
    public string Session { get => session; set => session = value; }
    public string Razon { get => razon; set => razon = value; }
}