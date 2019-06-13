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
    /*SEARCH*/
    public DataTable buscar_Usuario(long cedula , String password)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_buscar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Bigint).Value = cedula;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar ,100).Value = password;

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
    public DataTable buscar_Usuario_id(long id, String password)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_buscar_usuario_id", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Bigint).Value = id;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar, 100).Value = password;

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
    public DataTable buscar_Cedula(long cedula)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_buscar_cedula", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Bigint).Value = cedula;

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

    /* SECURITY*/
    public void guardadoSession(User usu)
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
      
    }
    public void cerrarSession(User datos)
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
       
    }
    /* CRUD USER*/
    public void bloquear_User(long id_user)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_bloquear_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Bigint).Value = id_user;

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
    public void insertar_User(User user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_insertar_user", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Bigint).Value = user.Cedula;
            dataAdapter.SelectCommand.Parameters.Add("_primer_nombre", NpgsqlDbType.Varchar, 100).Value = user.Primer_nombre;
            dataAdapter.SelectCommand.Parameters.Add("_segundo_nombre", NpgsqlDbType.Varchar, 100).Value = user.Segundo_nombre;
            dataAdapter.SelectCommand.Parameters.Add("_primer_apellido", NpgsqlDbType.Varchar, 100).Value = user.Primer_apellido;
            dataAdapter.SelectCommand.Parameters.Add("_segundo_apellido", NpgsqlDbType.Varchar, 100).Value = user.Segundo_apellido;
            dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = user.Direccion;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Varchar, 20).Value = user.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Varchar, 100).Value = user.Correo;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar, 100).Value = user.Password;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = user.Nacimiento;
            dataAdapter.SelectCommand.Parameters.Add("_sexo", NpgsqlDbType.Varchar, 100).Value = user.Sexo;
            dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Text).Value = user.Foto;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = user.Session;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Integer).Value = user.Sede;
            dataAdapter.SelectCommand.Parameters.Add("_rol", NpgsqlDbType.Integer).Value = user.Rol;

            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = user.Session;

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
    public void modificar_User(User user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_modificar_user", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Bigint).Value = user.Id_user;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Bigint).Value = user.Cedula;
            dataAdapter.SelectCommand.Parameters.Add("_primer_nombre", NpgsqlDbType.Varchar, 100).Value = user.Primer_nombre;
            dataAdapter.SelectCommand.Parameters.Add("_segundo_nombre", NpgsqlDbType.Varchar, 100).Value = user.Segundo_nombre;
            dataAdapter.SelectCommand.Parameters.Add("_primer_apellido", NpgsqlDbType.Varchar, 100).Value = user.Primer_apellido;
            dataAdapter.SelectCommand.Parameters.Add("_segundo_apellido", NpgsqlDbType.Varchar, 100).Value = user.Segundo_apellido;
            dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = user.Direccion;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Varchar, 20).Value = user.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Varchar, 100).Value = user.Correo;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar, 100).Value = user.Password;
            dataAdapter.SelectCommand.Parameters.Add("_fecha", NpgsqlDbType.Date).Value = user.Nacimiento;
            dataAdapter.SelectCommand.Parameters.Add("_sexo", NpgsqlDbType.Varchar, 100).Value = user.Sexo;
            dataAdapter.SelectCommand.Parameters.Add("_foto", NpgsqlDbType.Text).Value = user.Foto;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = user.Session;
            dataAdapter.SelectCommand.Parameters.Add("_sede", NpgsqlDbType.Integer).Value = user.Sede;
            dataAdapter.SelectCommand.Parameters.Add("_rol", NpgsqlDbType.Integer).Value = user.Rol;

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
    public DataTable ver_User(long id_user)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_ver_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Bigint).Value = id_user;

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
    public void DesbloquearUser(long id_user)
    {
        DataTable usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("clinica.f_desbloquear_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id", NpgsqlDbType.Bigint).Value = id_user;

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