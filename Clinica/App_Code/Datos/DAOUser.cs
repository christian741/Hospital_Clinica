using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de DAOUser
/// </summary>
public class DAOUser : Cruds_user
{
    public DAOUser()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    public DataTable buscar_Usuario(long cedula , String password)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_datos_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Bigint).Value = cedula;
            dataAdapter.SelectCommand.Parameters.Add("_password", NpgsqlDbType.Bigint).Value = password;

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
    public DataTable guardadoSession(User usu)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("security.f_guardado_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = usu.Id_user;
            dataAdapter.SelectCommand.Parameters.Add("_ip", NpgsqlDbType.Varchar, 100).Value = usu.Ip;
            dataAdapter.SelectCommand.Parameters.Add("_mac", NpgsqlDbType.Varchar, 100).Value = usu.Mac;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = usu.Session;

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
        return Usuario;
    }
    public DataTable cerrarSession(User datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("security.f_cerrar_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;

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
        return Usuario;
    }

    public void bloquear_User(long id_user)
    {
        throw new NotImplementedException();
    }
    public void insertar_User(User user)
    {
        throw new NotImplementedException();
    }
    public void modificar_User(User user)
    {
        throw new NotImplementedException();
    }
    public void ver_User(long id_user)
    {
        throw new NotImplementedException();
    }
    public void bloquearUser(long cedula)
    {
        throw new NotImplementedException();
    }
    public void DesbloquearUser(long cedula)
    {
        throw new NotImplementedException();
    }
}