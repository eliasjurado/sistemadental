using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace appSistemaDental.DAO
{
    public class PagoDAO
    {
        //Conexion para métodos
        private ConexionBD cnx = new ConexionBD();
        private SqlConnection cn;

        public string Codigo_Pago()
        {
            cn = cnx.Conectar();
            string correlativo = string.Empty;
            SqlCommand cmd = new SqlCommand
                ("USP_CODIGO_PAGO", cn);
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

        public DataTable Listar_PagoPorPaciente(int PI_IDPACIENTE)
        {
            cn = cnx.Conectar();

            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_PAGO_POR_PACIENTE", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@PI_IDPACIENTE", PI_IDPACIENTE);
            dap.Fill(dtb);

            return dtb;
        }

        public string Agregar_Pago(
             int PI_IDPAGO
            , int PI_IDPACIENTE
            , double PI_MONTOPAGO
            , DateTime PI_FECHAPAGO
            )
        {
            cn = cnx.Conectar();
            string mensaje = string.Empty;
            SqlTransaction tr = null;
            SqlCommand cmd = new SqlCommand
                ("USP_AGREGAR_PAGO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_IDPAGO", PI_IDPAGO);
            cmd.Parameters.AddWithValue("@PI_IDPACIENTE", PI_IDPACIENTE);
            cmd.Parameters.AddWithValue("@PI_MONTOPAGO", PI_MONTOPAGO);
            cmd.Parameters.AddWithValue("@PI_FECHAPAGO", PI_FECHAPAGO);

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


        public string Eliminar_Pago(string @PI_IDPAGO)
        {
            cn = cnx.Conectar();

            string mensaje = string.Empty;

            SqlTransaction tr = null;

            SqlCommand cmd = new SqlCommand
                ("USP_ELIMINAR_PAGO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_IDPAGO", PI_IDPAGO);

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

    }
}
