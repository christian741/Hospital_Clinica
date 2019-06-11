using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOSede
/// </summary>
public class DAOSede
{
    public DAOSede()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    /* CRUD SEDE*/
    public void bloquear_Sede(long id_sede)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_bloquear_sede", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Bigint).Value = id_sede;

            conection.Open();

            dataAdapter.Fill(usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }
    public void insertar_Sede(Sede sede)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_insertar_sede", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre_sede", NpgsqlDbType.Varchar, 100).Value = sede.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_descripcion_sede", NpgsqlDbType.Text).Value = sede.Descripcion;
            dataAdapter.SelectCommand.Parameters.Add("_ciudad_sede", NpgsqlDbType.Text).Value = sede.Ciudad;
            dataAdapter.SelectCommand.Parameters.Add("_direccion_sede", NpgsqlDbType.Text).Value = sede.Direccion;
            dataAdapter.SelectCommand.Parameters.Add("_foto_sede", NpgsqlDbType.Text).Value = sede.Foto;
            dataAdapter.SelectCommand.Parameters.Add("_session_sede", NpgsqlDbType.Text).Value = sede.Session;
            dataAdapter.SelectCommand.Parameters.Add("_id_encargado", NpgsqlDbType.Bigint).Value = sede.Encargado;
     
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }
    public void modificar_Sede(Sede sede)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_modificar_user", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Bigint).Value = sede.Id;
            dataAdapter.SelectCommand.Parameters.Add("_nombre_sede", NpgsqlDbType.Varchar, 100).Value = sede.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_descripcion_sede", NpgsqlDbType.Text).Value = sede.Descripcion;
            dataAdapter.SelectCommand.Parameters.Add("_ciudad_sede", NpgsqlDbType.Text).Value = sede.Ciudad;
            dataAdapter.SelectCommand.Parameters.Add("_direccion_sede", NpgsqlDbType.Text).Value = sede.Direccion;
            dataAdapter.SelectCommand.Parameters.Add("_foto_sede", NpgsqlDbType.Text).Value = sede.Foto;
            dataAdapter.SelectCommand.Parameters.Add("_session_sede", NpgsqlDbType.Text).Value = sede.Session;
            dataAdapter.SelectCommand.Parameters.Add("_id_encargado", NpgsqlDbType.Bigint).Value = sede.Encargado;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }
    public DataTable ver_Sede(long id_sede)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_ver_sede", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Bigint).Value = id_sede;

            conection.Open();

            dataAdapter.Fill(usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return usuario;
    }
    public void DesbloquearSede(long id_sede)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_desbloquear_sede", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Bigint).Value = id_sede;

            conection.Open();

            dataAdapter.Fill(usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }
}