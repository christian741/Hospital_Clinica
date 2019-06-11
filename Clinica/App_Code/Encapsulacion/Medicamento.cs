﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Medicamento
/// </summary>
public class Medicamento
{
    private long codigo;
    private string nombre;
    private string descripcion;
    private string stock;
    private string session;
    private int sede;
       
    public Medicamento()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public long Codigo { get => codigo; set => codigo = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public string Stock { get => stock; set => stock = value; }
    public string Session { get => session; set => session = value; }
    public int Sede { get => sede; set => sede = value; }
}