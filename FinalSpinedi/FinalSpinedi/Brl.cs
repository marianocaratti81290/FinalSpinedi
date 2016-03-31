﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Collections;

namespace FinalSpinedi
{
    public static class brl
    {

       public static int logearUsuario(string usuario, string password)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("Logeo_buscarSocio_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@usuario", usuario);
               cmd.Parameters.AddWithValue("@password", password);
               SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
               existe.Direction = ParameterDirection.Output;
               cmd.Parameters.Add(existe);
               Comun.establecerConexion.Open();
               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();
               return (int)existe.Value;
           }
           catch (Exception ex)
          
           {
               throw ex;
           }

       }

       public static int comprobarUsuario(string usuario)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("Logeo_buscarSocio_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@usr", usuario);
               
               SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
               existe.Direction = ParameterDirection.Output;
               cmd.Parameters.Add(existe);
               Comun.establecerConexion.Open();
               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();
               return (int)existe.Value;
           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static void agregarCliente(string nombre,string apellido, string dni, string fecha_nacimiento, string sexo, string cel, string tel, string domicilio,
           string provincia, string localidad, string cp, string email)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("nuevoCliente_i_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               //cmd.Parameters.AddWithValue("@id_cliente", "");          
               cmd.Parameters.AddWithValue("@nombre", nombre);
               cmd.Parameters.AddWithValue("@apellido", apellido);
               cmd.Parameters.AddWithValue("@dni", dni);
               cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
               cmd.Parameters.AddWithValue("@sexo", sexo);
               cmd.Parameters.AddWithValue("@cel", cel);
               cmd.Parameters.AddWithValue("@tel", tel);
               cmd.Parameters.AddWithValue("@domicilio", domicilio);
               cmd.Parameters.AddWithValue("@provincia", provincia);
               cmd.Parameters.AddWithValue("@localidad", localidad);
               cmd.Parameters.AddWithValue("@cp", cp);          
               cmd.Parameters.AddWithValue("@email", email);
               Comun.establecerConexion.Open();

               SqlDataAdapter da = new SqlDataAdapter(cmd);
              
               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static void modificarCliente(int id_cliente, string nombre, string apellido, string dni, string fecha_nacimiento, string sexo, string cel, string tel, string domicilio,
         string provincia, string localidad, string cp, string email)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("modificarCliente_u_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id_cliente", id_cliente);          
               cmd.Parameters.AddWithValue("@nombre", nombre);
               cmd.Parameters.AddWithValue("@apellido", apellido);
               cmd.Parameters.AddWithValue("@dni", dni);
               cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
               cmd.Parameters.AddWithValue("@sexo", sexo);
               cmd.Parameters.AddWithValue("@cel", cel);
               cmd.Parameters.AddWithValue("@tel", tel);
               cmd.Parameters.AddWithValue("@domicilio", domicilio);
               cmd.Parameters.AddWithValue("@provincia", provincia);
               cmd.Parameters.AddWithValue("@localidad", localidad);
               cmd.Parameters.AddWithValue("@cp", cp);
               cmd.Parameters.AddWithValue("@email", email);
               Comun.establecerConexion.Open();

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }
       public static DataTable ObtenerProductos()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerProductos_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               DataTable dt = new DataTable();

               da.Fill(dt);

               return dt;

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static DataTable ObtenerProvincias()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerProvincia_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               DataTable dt = new DataTable();

               da.Fill(dt);

               return dt;

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static DataTable obtenerLocalidadCorrespondiente(string id_provincia)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerLocalidadCorrespondiente_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("valor", id_provincia);

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               DataTable dt = new DataTable();

               da.Fill(dt);

               return dt;

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static DataTable obtenerClienteSeleccionado(int id_cliente)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerClienteSeleccionado_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("id_cliente", id_cliente);

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               DataTable dt = new DataTable();

               da.Fill(dt);

               return dt;

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }
       public static DataTable ObtenerProductosPedidos()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerProductosPendientes_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               DataTable dt = new DataTable();

               da.Fill(dt);

               return dt;

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static DataTable obtenerClientes()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerClientes_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               DataTable dt = new DataTable();

               da.Fill(dt);

               return dt;

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static void borrarCliente(int id_cliente)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("borrarCliente_d_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               
               cmd.Parameters.AddWithValue("@id_cliente", id_cliente);
     
               Comun.establecerConexion.Open();

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static void agregarProducto(string nombre, int estado, int proveedor, int precio_publico, int cantidad, int precio_proveedor, string descrip, string fecha, string codBarra)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("nuevoProducto_i_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               //cmd.Parameters.AddWithValue("@id_cliente", "");          
               cmd.Parameters.AddWithValue("@nombre", nombre);
               cmd.Parameters.AddWithValue("@estado", estado);
               cmd.Parameters.AddWithValue("@id_proveedor", proveedor);
               cmd.Parameters.AddWithValue("@precio_publico", precio_publico);
               cmd.Parameters.AddWithValue("@cantidad", cantidad);
               cmd.Parameters.AddWithValue("@precio_proveedor", precio_proveedor);
               cmd.Parameters.AddWithValue("@descrip", descrip);
               cmd.Parameters.AddWithValue("@fecha", fecha);
               cmd.Parameters.AddWithValue("@codBarra", codBarra);
       
               Comun.establecerConexion.Open();

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static void ConsultarIdProveedor(string id_proveedor)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("consultarIdProveedor_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               //cmd.Parameters.AddWithValue("@id_cliente", "");          
               cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);
              
               Comun.establecerConexion.Open();

               SqlDataAdapter da = new SqlDataAdapter(cmd);

               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();

           }
           catch (Exception ex)
           {
               throw ex;
           }

       }
        }

}
