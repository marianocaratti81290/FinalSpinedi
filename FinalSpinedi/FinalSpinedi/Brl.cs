using System;
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

       public static DataTable obtenerProductoSeleccionado(int id_producto)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerProductoSeleccionado_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
                      
               cmd.Parameters.AddWithValue("@id_producto", id_producto);

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

       public static void modificarProducto(int id_producto,string nombre, int estado, int id_proveedor, int cantidad, int precio_publico, int precio_proveedor , string descrip, string fecha, string codBarra)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("modificarProducto_u_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id_producto", id_producto);          
               cmd.Parameters.AddWithValue("@nombre", nombre);
               cmd.Parameters.AddWithValue("@estado", estado);
               cmd.Parameters.AddWithValue("@id_proveedor", id_proveedor);
               cmd.Parameters.AddWithValue("@cantidad", cantidad);
               cmd.Parameters.AddWithValue("@precio_publico", precio_publico);
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

       public static DataTable obtenerProveedor()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerProveedor_q_sp", Comun.establecerConexion);

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

       public static void borrarProducto(int id_producto)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("borrarProducto_d_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@id_producto", id_producto);

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

       public static void agregarUsuario(string nombre, string apellido, string dni, string fecha_nacimiento, string sexo, string cel, string tel, string domicilio,
         string provincia, string localidad, string cp, string email, string usuario, string pass, int habilitar)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("nuevoUsuario_i_sp", Comun.establecerConexion);

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
               cmd.Parameters.AddWithValue("@usr", usuario);
               cmd.Parameters.AddWithValue("@pass", pass);
               cmd.Parameters.AddWithValue("@estado", habilitar);
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

       public static void modificarUsuario(int id_cliente, string nombre, string apellido, string dni, string fecha_nacimiento, string sexo, string cel, string tel, string domicilio,
       string provincia, string localidad, string cp, string email)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("modificarUsuario_u_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id_usuario", id_cliente);
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

       public static DataTable obtenerUsuarios()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerUsuarios_q_sp", Comun.establecerConexion);

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

       public static DataTable obtenerUsuarioSeleccionado(int id_usuario)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerUsuarioSeleccionado_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("id_usuario", id_usuario);

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

       public static void borrarUsuario(int id_usuario)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("borrarUsuario_d_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

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

       public static DataTable obtenerUsuarioxEstado()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerEstadoUsuarios", Comun.establecerConexion);

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

       public static DataTable cambiarEstadoUsuarios(int id_usuario, string estadoActual)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("cambiarEstadoUsuarios_u_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("id_usuario", id_usuario);

               cmd.Parameters.AddWithValue("estado", estadoActual);

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

       public static int PermisosPuntualesUsuarios(string usuario, string formulario)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("PermisosPuntuales_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@usr", usuario);
               cmd.Parameters.AddWithValue("@Formulario", formulario);
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
       public static void ModificarPermisosUsuarioI(string usr, string formulario)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("InsertarPermisosPuntuales_i_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@usr", usr);

               cmd.Parameters.AddWithValue("@formulario", formulario);

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

       public static void ModificarPermisosUsuarioD(string usr, string formulario)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("EliminarPermisosPuntuales_d_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@usr", usr);

               cmd.Parameters.AddWithValue("@formulario", formulario);

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

       public static DataTable PermisosxUsuario(string usr)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("ObtenerPermisosxUsuario_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@usr", usr);

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

       public static void modificarProveedor(int id_producto, string nombre, int estado, string descrip, string tel_fijo, string cel, string referente, string email)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("modificarProveedor_u_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id_producto", id_producto);
               cmd.Parameters.AddWithValue("@nombre", nombre);
               cmd.Parameters.AddWithValue("@estado", estado);
               cmd.Parameters.AddWithValue("@descripcion", descrip);
               cmd.Parameters.AddWithValue("@tel_fijo", tel_fijo);
               cmd.Parameters.AddWithValue("@cel", cel);
               cmd.Parameters.AddWithValue("@nombre_contacto", referente);
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
          public static void agregarProveedor(string nombre, int estado, string descripcion, string tel_fijo, string cel, string referente, string email)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("nuevoProveedor_i_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
              // cmd.Parameters.AddWithValue("@id_producto", id_producto);
               cmd.Parameters.AddWithValue("@nombre", nombre);
               cmd.Parameters.AddWithValue("@estado", estado);
               cmd.Parameters.AddWithValue("@descripcion", descripcion);
               cmd.Parameters.AddWithValue("@tel_fijo", tel_fijo);
               cmd.Parameters.AddWithValue("@cel", cel);
               cmd.Parameters.AddWithValue("@nombre_contacto", referente);
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

          public static void borrarProveedor(int id_proveedor)
          {
              try
              {

                  SqlCommand cmd = new SqlCommand("borrarProveedor_d_sp", Comun.establecerConexion);

                  cmd.CommandType = CommandType.StoredProcedure;

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
