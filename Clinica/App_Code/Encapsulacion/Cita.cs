using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Cita
/// </summary>
public class Cita
{
    private int id;
    private int especializacion;
    private int paciente;
    private int doctor;
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

    public int Id { get => id; set => id = value; }
    public int Especializacion { get => especializacion; set => especializacion = value; }
    public int Paciente { get => paciente; set => paciente = value; }
    public int Doctor { get => doctor; set => doctor = value; }
    public int Sede { get => sede; set => sede = value; }
    public String Fecha_cita { get => fecha_cita; set => fecha_cita = value; }
    public string Session { get => session; set => session = value; }
    public string Razon { get => razon; set => razon = value; }
}