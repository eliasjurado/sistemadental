using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace appSistemaDental
{
    class TratamientoDAO
    {
        //Conexion para métodos
        private ConexionBD cnx = new ConexionBD();
        private SqlConnection cn;

        //Metodos
        public DataTable Listar_Tratamiento()
        {
            cn = cnx.Conectar();

            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_TRATAMIENTO", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.Fill(dtb);

            return dtb;
        }

        public DataTable Buscar_Tratamiento_Por_Nombre(string Iniciales)
        {
            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_TRATAMIENTO_POR_DESCRIPCION", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@PL_INICIALES", Iniciales);
            dap.Fill(dtb);

            return dtb;
        }

        public string Codigo_Tratamiento()
        {
            cn = cnx.Conectar();
            string correlativo = string.Empty;
            SqlCommand cmd = new SqlCommand
                ("USP_CODIGO_TRATAMIENTO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cn.Open();
                correlativo = cmd.ExecuteScalar().ToString();
            }
            finally
            {
                cn.Close();
            }
            return correlativo;
        }

        public string Agregar_Tratamiento(
             string PI_ID
            , string PI_DESCRIPCION
            , double PI_PRECIO
            , int PI_IDESPECIALIDAD
            , DateTime PI_FECHAREGISTRO
            )
        {
            cn = cnx.Conectar();
            string mensaje = string.Empty;
            SqlTransaction tr = null;
            SqlCommand cmd = new SqlCommand
                ("USP_AGREGAR_TRATAMIENTO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_ID", PI_ID);
            cmd.Parameters.AddWithValue("@PI_DESCRIPCION", PI_DESCRIPCION);
            cmd.Parameters.AddWithValue("@PI_PRECIO", PI_PRECIO);
            cmd.Parameters.AddWithValue("@PI_IDESPECIALIDAD", PI_IDESPECIALIDAD);
            cmd.Parameters.AddWithValue("@PI_FECHAREGISTRO", PI_FECHAREGISTRO);
          
            int q = 0;

            try
            {
                cn.Open();
                tr = cn.BeginTransaction(IsolationLevel.Serializable);
                cmd.Transaction = tr;
                q = cmd.ExecuteNonQuery();
                tr.Commit();
                mensaje = q.ToString() + " Registro agregado";
            }
            catch (Exception ex)
            {
                tr.Rollback();
                mensaje = ex.Message;
            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }


        public string Actualizar_Tratamiento(
            string PI_ID
            , string PI_DESCRIPCION
            , double PI_PRECIO
            , int PI_IDESPECIALIDAD
            , DateTime PI_FECHAREGISTRO
           )
        {
            cn = cnx.Conectar();

            string mensaje = string.Empty;

            SqlTransaction tr = null;

            SqlCommand cmd = new SqlCommand
                ("USP_ACTUALIZAR_TRATAMIENTO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_ID", PI_ID);
            cmd.Parameters.AddWithValue("@PI_DESCRIPCION", PI_DESCRIPCION);
            cmd.Parameters.AddWithValue("@PI_PRECIO", PI_PRECIO);
            cmd.Parameters.AddWithValue("@PI_IDESPECIALIDAD", PI_IDESPECIALIDAD);
            cmd.Parameters.AddWithValue("@PI_FECHAREGISTRO", PI_FECHAREGISTRO);

            int q = 0;
            try
            {
                cn.Open();
                tr = cn.BeginTransaction(IsolationLevel.Serializable);
                cmd.Transaction = tr;
                q = cmd.ExecuteNonQuery();
                tr.Commit();
                mensaje = q.ToString() + " registro actualizado";
            }
            catch (Exception ex)
            {
                tr.Rollback();
                mensaje = ex.Message;
            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }


        public string Eliminar_Tratamiento(string PI_ID)
        {
            cn = cnx.Conectar();

            string mensaje = string.Empty;

            SqlTransaction tr = null;

            SqlCommand cmd = new SqlCommand
                ("USP_ELIMINAR_TRATAMIENTO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_ID", PI_ID);

            int q = 0;

            try
            {
                cn.Open();
                tr = cn.BeginTransaction(IsolationLevel.Serializable);
                cmd.Transaction = tr;
                q = cmd.ExecuteNonQuery();
                tr.Commit();
                mensaje = q.ToString() + " Registro eliminado";
            }
            catch (Exception ex)
            {
                tr.Rollback();
                mensaje = ex.Message;
            }
            finally
            {
                cn.Close();
            }
            return mensaje;
        }


        //Conexion para cargar combos
        private SqlConnection cn1 = new SqlConnection
            (ConfigurationManager.ConnectionStrings["cadenaconexion"].ConnectionString);

        //--Carga de Combos
        public DataTable Listar_Especialidad()
        {
            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_ESPECIALIDAD", cn1);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.Fill(dtb);

            return dtb;
        }
    }
}
