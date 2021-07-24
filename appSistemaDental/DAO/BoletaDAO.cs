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
    public class BoletaDAO
    {
        //Conexion para métodos
        private ConexionBD cnx = new ConexionBD();
        private SqlConnection cn;

        //Metodos
        public string Codigo_Boleta()
        {
            cn = cnx.Conectar();
            string correlativo = string.Empty;
            SqlCommand cmd = new SqlCommand
                ("USP_CODIGO_BOLETA", cn);
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

        /*------------------------------------------------*/
        public string TotalAtencionPaciente(int PI_IDPACIENTE)
        {
            cn = cnx.Conectar();
            string correlativo = string.Empty;
            SqlCommand cmd = new SqlCommand
                ("USP_TOTAL_ATENCION_POR_PACIENTE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_IDPACIENTE", PI_IDPACIENTE);
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
        public string TotalDescuentoPaciente(int PI_IDPACIENTE)
        {
            cn = cnx.Conectar();
            string correlativo = string.Empty;
            SqlCommand cmd = new SqlCommand
                ("USP_TOTAL_DESCUENTO_POR_PACIENTE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_IDPACIENTE", PI_IDPACIENTE);
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
        public string TotalPorcentajeDsctoPaciente(int PI_IDPACIENTE)
        {
            cn = cnx.Conectar();
            string correlativo = string.Empty;
            SqlCommand cmd = new SqlCommand
                ("USP_TOTAL_PORCENTAJE_DESCUENTO_POR_PACIENTE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_IDPACIENTE", PI_IDPACIENTE);
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
        public string TotalPendientePorPagar(int PI_IDPACIENTE)
        {
            cn = cnx.Conectar();
            string correlativo = string.Empty;
            SqlCommand cmd = new SqlCommand
                ("USP_TOTAL_PENDIENTE_POR_PAGAR", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_IDPACIENTE", PI_IDPACIENTE);
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
        /*------------------------------------------------*/

        //Metodos
        public DataTable Listar_BoletaCab()
        {
            cn = cnx.Conectar();

            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_BOLETACAB", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.Fill(dtb);

            return dtb;
        }

        public DataTable Listar_BoletaDet(int PI_IDBOLETACAB)
        {
            cn = cnx.Conectar();

            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_BOLETADET", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@PI_IDBOLETACAB", PI_IDBOLETACAB);
            dap.Fill(dtb);

            return dtb;
        }

        public DataTable Listar_BoletaDetPorPaciente(int PL_IDPACIENTE)
        {
            cn = cnx.Conectar();

            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_TRATAMIENTO_POR_PACIENTE", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@PL_IDPACIENTE", PL_IDPACIENTE);
            dap.Fill(dtb);

            return dtb;
        }




        public string Agregar_BoletaCab(
             int PI_IDBOLETACAB
            , int PI_IDPACIENTE
            , DateTime PI_FECHAATENCION
            , string PI_EMAIL
            , double PI_SUBTOTALCAB
            , double PI_IGVCAB
            , double PI_TOTALCAB
            , double PI_DESCUENTOCAB
            , double PI_TOTALPAGARCAB
            )
        {
            cn = cnx.Conectar();
            string mensaje = string.Empty;
            SqlTransaction tr = null;
            SqlCommand cmd = new SqlCommand
                ("USP_AGREGAR_BOLETACAB", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_IDBOLETACAB", PI_IDBOLETACAB);
            cmd.Parameters.AddWithValue("@PI_IDPACIENTE", PI_IDPACIENTE);
            cmd.Parameters.AddWithValue("@PI_FECHAATENCION", PI_FECHAATENCION);
            cmd.Parameters.AddWithValue("@PI_EMAIL", PI_EMAIL);
            cmd.Parameters.AddWithValue("@PI_SUBTOTALCAB", PI_SUBTOTALCAB);
            cmd.Parameters.AddWithValue("@PI_IGVCAB", PI_IGVCAB);
            cmd.Parameters.AddWithValue("@PI_TOTALCAB", PI_TOTALCAB);
            cmd.Parameters.AddWithValue("@PI_DESCUENTOCAB", PI_DESCUENTOCAB);
            cmd.Parameters.AddWithValue("@PI_TOTALPAGARCAB", PI_TOTALPAGARCAB);

            int q = 0;

            try
            {
                cn.Open();
                tr = cn.BeginTransaction(IsolationLevel.Serializable);
                cmd.Transaction = tr;
                q = cmd.ExecuteNonQuery();
                tr.Commit();
                mensaje = q.ToString() + " Boleta agregada";
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





        public string Agregar_BoletaDet(
             int PI_IDBOLETACAB
            , int PI_IDBOLETADET
            , string PI_IDTRATAMIENTO
            , int PI_CANTIDAD
            , string PI_PIEZAS
            , double PI_SUBTOTALDET
            , double PI_IGVDET
            , double PI_TOTALDET
            )
        {
            cn = cnx.Conectar();
            string mensaje = string.Empty;
            SqlTransaction tr = null;
            SqlCommand cmd = new SqlCommand
                ("USP_AGREGAR_BOLETADET", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_IDBOLETACAB", PI_IDBOLETACAB);
            cmd.Parameters.AddWithValue("@PI_IDBOLETADET", PI_IDBOLETADET);
            cmd.Parameters.AddWithValue("@PI_IDTRATAMIENTO", PI_IDTRATAMIENTO);
            cmd.Parameters.AddWithValue("@PI_CANTIDAD", PI_CANTIDAD);
            cmd.Parameters.AddWithValue("@PI_PIEZAS", PI_PIEZAS);
            cmd.Parameters.AddWithValue("@PI_SUBTOTALDET", PI_SUBTOTALDET);
            cmd.Parameters.AddWithValue("@PI_IGVDET", PI_IGVDET);
            cmd.Parameters.AddWithValue("@PI_TOTALDET", PI_TOTALDET);
            int q = 0;

            try
            {
                cn.Open();
                tr = cn.BeginTransaction(IsolationLevel.Serializable);
                cmd.Transaction = tr;
                q = cmd.ExecuteNonQuery();
                tr.Commit();
                mensaje = q.ToString() + " Boleta agregada";
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
