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

       public static int validarPrestamo(int id_activo, string id_estado, int id_libro, int id_socio)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("ValidarPrestamo_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id_activo", id_activo);
               cmd.Parameters.AddWithValue("@id_estado", id_estado);
               cmd.Parameters.AddWithValue("@id_libro", id_libro);
               cmd.Parameters.AddWithValue("@id_socio", id_socio);
               SqlParameter aprobado = new SqlParameter("@aprobado", SqlDbType.Int);
               aprobado.Direction = ParameterDirection.Output;
               cmd.Parameters.Add(aprobado);
               Comun.establecerConexion.Open();
               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();
               return (int)aprobado.Value;
           }
           catch (Exception ex)
           {
               throw ex;
           }

       }

       public static int validarDevolucion(int id_prestamo)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("ValidarDevolucion_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@id_prestamo_obtenido", id_prestamo);
              
               SqlParameter aprobado = new SqlParameter("@aprobado", SqlDbType.Int);
               aprobado.Direction = ParameterDirection.Output;
               cmd.Parameters.Add(aprobado);
               Comun.establecerConexion.Open();
               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();
               return (int)aprobado.Value;
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

       public static void agregarSocio(string apellido,string nombre, string dni, string fecha_nacimiento, string fecha_alta, string direccion, string provincia, string localidad,
           string telefono, string email, string estado, string cp, string observaciones)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("nuevoSocio_i_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               //cmd.Parameters.AddWithValue("@id_cliente", "");          
               cmd.Parameters.AddWithValue("@apellido", apellido);
               cmd.Parameters.AddWithValue("@nombre", nombre);
               cmd.Parameters.AddWithValue("@dni", dni);
               cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
               cmd.Parameters.AddWithValue("@fecha_alta", fecha_alta);
               cmd.Parameters.AddWithValue("@direccion", direccion);
               cmd.Parameters.AddWithValue("@localidad", localidad);
               cmd.Parameters.AddWithValue("@provincia", provincia);
               cmd.Parameters.AddWithValue("@telefono", telefono);
               cmd.Parameters.AddWithValue("@email", email);
               cmd.Parameters.AddWithValue("@sancionado", 0);          
               cmd.Parameters.AddWithValue("@fecha_fin_sancion", "");
               cmd.Parameters.AddWithValue("@activo", 1);
               cmd.Parameters.AddWithValue("@observacion", observaciones);
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

       public static void modificarSocio(int id_socio, string apellido, string nombre, string dni, string fecha_nacimiento, string fecha_alta, string direccion, string localidad, string provincia,
         string telefono, string email, string sancionado, string fecha_sancion, string estado, string observacion)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("modificarSocio_u_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id_socio", id_socio);          
               cmd.Parameters.AddWithValue("@apellido", apellido);
               cmd.Parameters.AddWithValue("@nombre", nombre);
               cmd.Parameters.AddWithValue("@dni", dni);
               cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
               cmd.Parameters.AddWithValue("@fecha_alta", fecha_alta);
               cmd.Parameters.AddWithValue("@direccion", direccion);
               cmd.Parameters.AddWithValue("@localidad", localidad);
               cmd.Parameters.AddWithValue("@provincia", provincia);
               cmd.Parameters.AddWithValue("@telefono", telefono);
               cmd.Parameters.AddWithValue("@email", email);
               cmd.Parameters.AddWithValue("@sancionado", sancionado);
               cmd.Parameters.AddWithValue("@fecha_fin_sancion", fecha_sancion);
               cmd.Parameters.AddWithValue("@activo", estado);
               cmd.Parameters.AddWithValue("@observacion", observacion);

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
       public static DataTable ObtenerLibros()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerLibros_q_sp", Comun.establecerConexion);

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

       public static DataTable obtenerSocioSeleccionado(int id_socio)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerSocioSeleccionado_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("id_socio", id_socio);

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

       public static DataTable obtenerSocio()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerSocio_q_sp", Comun.establecerConexion);

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

       public static DataTable obtenerLibro()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerLibros_q_sp", Comun.establecerConexion);

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

       public static void borrarSocio(int id_socio)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("borrarSocio_d_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               
               cmd.Parameters.AddWithValue("@id_socio", id_socio);
     
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

       public static void modificarCuota(int valor_cuota)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("borrarSocio_d_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@valorCuota", valor_cuota);

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
       public static void agregarLibro(string Titulo, string Autor, string fechaEdicion, string FechaAlta, int Genero, string Editorial, string ISBN, int Donado, string Estado, int Activo, string Observacion)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("nuevoLibro_i_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               //cmd.Parameters.AddWithValue("@id_cliente", "");          
               cmd.Parameters.AddWithValue("@Titulo", Titulo);
               cmd.Parameters.AddWithValue("@Autor", Autor);
               cmd.Parameters.AddWithValue("@fechaEdicion", fechaEdicion);
               cmd.Parameters.AddWithValue("@FechaAlta", FechaAlta);
               cmd.Parameters.AddWithValue("@Genero", Genero);
               cmd.Parameters.AddWithValue("@Editorial", Editorial);
               cmd.Parameters.AddWithValue("@ISBN", ISBN);
               cmd.Parameters.AddWithValue("@Donado", Donado);
               cmd.Parameters.AddWithValue("@Estado", Estado);
               cmd.Parameters.AddWithValue("@Activo", Activo);
               cmd.Parameters.AddWithValue("@Observacion", Observacion);
       
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

       public static DataTable obtenerLibroSeleccionado(int id_producto)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerLibroSeleccionado_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
                      
               cmd.Parameters.AddWithValue("@id_libro", id_producto);

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

       public static void modificarLibro(int id_libro, string titulo, string autor, string fecha_Edicion, string fecha_alta, int genero, string editorial, string isbn, int donado, string estado, int activo, string obs)
       {
           try
           {

               SqlCommand cmd = new SqlCommand("modificarLibro_u_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id_libro", id_libro);          
               cmd.Parameters.AddWithValue("@titulo", titulo);
               cmd.Parameters.AddWithValue("@autor", autor);
               cmd.Parameters.AddWithValue("@fecha_edicion", fecha_Edicion);
               cmd.Parameters.AddWithValue("@fecha_alta", fecha_alta);
               cmd.Parameters.AddWithValue("@genero", genero);
               cmd.Parameters.AddWithValue("@editorial", editorial);
               cmd.Parameters.AddWithValue("@isbn", isbn);
               cmd.Parameters.AddWithValue("@donado", donado);
               cmd.Parameters.AddWithValue("@Estado", estado);
               cmd.Parameters.AddWithValue("@Activo", activo);
               cmd.Parameters.AddWithValue("@Observacion", obs);

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

       public static void agregarUsuario( string usuario, string pass )
       {
           try
           {

               SqlCommand cmd = new SqlCommand("nuevoUsuario_i_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;

               cmd.Parameters.AddWithValue("@usr", pass);
               cmd.Parameters.AddWithValue("@pass", pass);
               
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

       public static void modificarUsuario(int modselection,string usr,string pass )
       {
           try
           {

               SqlCommand cmd = new SqlCommand("modificarUsuario_u_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id", modselection);
               cmd.Parameters.AddWithValue("@usr", usr);
               cmd.Parameters.AddWithValue("@pass", pass);
               
              
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

       public static DataTable obtenerPrestamos()
       {
           try
           {

               SqlCommand cmd = new SqlCommand("obtenerPrestamos_q_sp", Comun.establecerConexion);

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

               cmd.Parameters.AddWithValue("id", id_usuario);

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

               cmd.Parameters.AddWithValue("@id", id_usuario);

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


       public static int validarPrestamo(int id_libro, int id_socio)
       {
           try
           {
               SqlCommand cmd = new SqlCommand("ValidarPrestamo_q_sp", Comun.establecerConexion);

               cmd.CommandType = CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@id_libro", id_libro);
               cmd.Parameters.AddWithValue("@id_socio", id_socio);
               SqlParameter aprobado = new SqlParameter("@aprobado", SqlDbType.Int);
               aprobado.Direction = ParameterDirection.Output;
               cmd.Parameters.Add(aprobado);
               Comun.establecerConexion.Open();
               cmd.ExecuteReader().Close();
               Comun.establecerConexion.Close();
               return (int)aprobado.Value;
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


          public static DataTable buscarUsuario(string buscar)
          {
              try
              {

                  SqlCommand cmd = new SqlCommand("buscarUsuario_q_sp", Comun.establecerConexion);

                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@buscar", buscar);

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

          public static DataTable buscarSocioFiltrado(string buscar, int filtro)
          {
              try
              {

                  SqlCommand cmd = new SqlCommand("buscarSocioFiltrado_q_sp", Comun.establecerConexion);

                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@buscar", buscar);

                  cmd.Parameters.AddWithValue("@filtro", filtro);

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

          public static DataTable buscarLibrosFiltrado(string buscar, int filtro)
          {
              try
              {

                  SqlCommand cmd = new SqlCommand("buscarLibroFiltrado_q_sp", Comun.establecerConexion);

                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@buscar", buscar);

                  cmd.Parameters.AddWithValue("@filtro", filtro);

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
          public static DataTable buscarCliente(string buscar)
          {
              try
              {

                  SqlCommand cmd = new SqlCommand("buscarCliente_q_sp", Comun.establecerConexion);

                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@buscar", buscar);

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

          public static DataTable buscarProducto(string buscar)
          {
              try
              {

                  SqlCommand cmd = new SqlCommand("buscarProductoFiltrado_q_sp", Comun.establecerConexion);

                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@buscar", buscar);

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

          public static DataTable buscarProveedor(string buscar)
          {
              try
              {

                  SqlCommand cmd = new SqlCommand("buscarProveedorFiltrado_q_sp", Comun.establecerConexion);

                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@buscar", buscar);

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

          public static DataTable buscarUsuarioFiltradoEstado(string buscar)
          {
              try
              {

                  SqlCommand cmd = new SqlCommand("buscarUsuarioFiltradoEstado_q_sp", Comun.establecerConexion);

                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@buscar", buscar);

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

          public static DataTable buscarLibro(string buscar)
          {
              try
              {

                  SqlCommand cmd = new SqlCommand("buscarLibro_q_sp", Comun.establecerConexion);

                  cmd.CommandType = CommandType.StoredProcedure;

                  cmd.Parameters.AddWithValue("@buscar", buscar);

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
    
        }

}
