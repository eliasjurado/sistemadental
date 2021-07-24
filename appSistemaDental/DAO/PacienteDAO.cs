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
    public class PacienteDAO
    {
        
        //Conexion para métodos
        private ConexionBD cnx = new ConexionBD();
        private SqlConnection cn;      

        //Metodos
        public DataTable Listar_Pacientes()
        {
            cn = cnx.Conectar();

            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_PACIENTES", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.Fill(dtb);

            return dtb;
        }

        public DataTable Buscar_Pacientes_Por_Nombre_O_Apellido(string Iniciales)
        {
            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_PACIENTES_POR_NOMBRE_O_APELLIDO", cn);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@PL_INICIALES", Iniciales);
            dap.Fill(dtb);

            return dtb;
        }

        public string Codigo_Paciente()
        {
            cn = cnx.Conectar();
            string correlativo = string.Empty;
            SqlCommand cmd = new SqlCommand
                ("USP_CODIGO_PACIENTES", cn);
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


        public string Agregar_Paciente(
             string PI_ID
            ,DateTime PI_FECHAREGISTRO
            ,string PI_NOMBRES
            ,string PI_APELLIDOS
            ,string PI_DNI
            ,DateTime PI_FECHANACIMIENTO
            ,string PI_SEXO
            ,string PI_TELMOVIL
            ,string PI_TELFIJO
            ,string PI_EMAIL
            ,string PI_DEPARTAMENTO
            ,string PI_PROVINCIA
            ,string PI_DISTRITO
            ,string PI_DIRECCION
            ,string PI_MOTIVOCONSULTA
            ,string PI_ALERGIAS
            ,string PI_MEDICAMENTOS
            ,string PI_ENFERMEDADES
            ,string PI_EXEXTRAORAL
            ,string PI_EXINTRAORAL
            ,string PI_COMOCONOCIO
            )
        {
            cn = cnx.Conectar();
            string mensaje = string.Empty;
            SqlTransaction tr = null;
            SqlCommand cmd = new SqlCommand
                ("USP_AGREGAR_PACIENTE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_ID",  PI_ID);
            cmd.Parameters.AddWithValue("@PI_FECHAREGISTRO",  PI_FECHAREGISTRO);
            cmd.Parameters.AddWithValue("@PI_NOMBRES",  PI_NOMBRES);
            cmd.Parameters.AddWithValue("@PI_APELLIDOS",  PI_APELLIDOS);
            cmd.Parameters.AddWithValue("@PI_DNI",  PI_DNI);
            cmd.Parameters.AddWithValue("@PI_FECHANACIMIENTO",  PI_FECHANACIMIENTO);
            cmd.Parameters.AddWithValue("@PI_SEXO",  PI_SEXO);
            cmd.Parameters.AddWithValue("@PI_TELMOVIL",  PI_TELMOVIL);
            cmd.Parameters.AddWithValue("@PI_TELFIJO",  PI_TELFIJO);
            cmd.Parameters.AddWithValue("@PI_EMAIL",  PI_EMAIL);
            cmd.Parameters.AddWithValue("@PI_DEPARTAMENTO",  PI_DEPARTAMENTO);
            cmd.Parameters.AddWithValue("@PI_PROVINCIA",  PI_PROVINCIA);
            cmd.Parameters.AddWithValue("@PI_DISTRITO",  PI_DISTRITO);
            cmd.Parameters.AddWithValue("@PI_DIRECCION",  PI_DIRECCION);
            cmd.Parameters.AddWithValue("@PI_MOTIVOCONSULTA",  PI_MOTIVOCONSULTA);
            cmd.Parameters.AddWithValue("@PI_ALERGIAS", PI_ALERGIAS);
            cmd.Parameters.AddWithValue("@PI_MEDICAMENTOS",  PI_MEDICAMENTOS);
            cmd.Parameters.AddWithValue("@PI_ENFERMEDADES",  PI_ENFERMEDADES);
            cmd.Parameters.AddWithValue("@PI_EXEXTRAORAL",  PI_EXEXTRAORAL);
            cmd.Parameters.AddWithValue("@PI_EXINTRAORAL",  PI_EXINTRAORAL);
            cmd.Parameters.AddWithValue("@PI_COMOCONOCIO",  PI_COMOCONOCIO);

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

        public string Actualizar_Paciente(
             string PI_ID
            , DateTime PI_FECHAREGISTRO
            , string PI_NOMBRES
            , string PI_APELLIDOS
            , string PI_DNI
            , DateTime PI_FECHANACIMIENTO
            , string PI_SEXO
            , string PI_TELMOVIL
            , string PI_TELFIJO
            , string PI_EMAIL
            , string PI_DEPARTAMENTO
            , string PI_PROVINCIA
            , string PI_DISTRITO
            , string PI_DIRECCION
            , string PI_MOTIVOCONSULTA
            , string PI_ALERGIAS
            , string PI_MEDICAMENTOS
            , string PI_ENFERMEDADES
            , string PI_EXEXTRAORAL
            , string PI_EXINTRAORAL
            , string PI_COMOCONOCIO
            )
        {
            cn = cnx.Conectar();

            string mensaje = string.Empty;

            SqlTransaction tr = null;

            SqlCommand cmd = new SqlCommand
                ("USP_ACTUALIZAR_PACIENTE", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PI_ID", PI_ID);
            cmd.Parameters.AddWithValue("@PI_FECHAREGISTRO", PI_FECHAREGISTRO);
            cmd.Parameters.AddWithValue("@PI_NOMBRES", PI_NOMBRES);
            cmd.Parameters.AddWithValue("@PI_APELLIDOS", PI_APELLIDOS);
            cmd.Parameters.AddWithValue("@PI_DNI", PI_DNI);
            cmd.Parameters.AddWithValue("@PI_FECHANACIMIENTO", PI_FECHANACIMIENTO);
            cmd.Parameters.AddWithValue("@PI_SEXO", PI_SEXO);
            cmd.Parameters.AddWithValue("@PI_TELMOVIL", PI_TELMOVIL);
            cmd.Parameters.AddWithValue("@PI_TELFIJO", PI_TELFIJO);
            cmd.Parameters.AddWithValue("@PI_EMAIL", PI_EMAIL);
            cmd.Parameters.AddWithValue("@PI_DEPARTAMENTO", PI_DEPARTAMENTO);
            cmd.Parameters.AddWithValue("@PI_PROVINCIA", PI_PROVINCIA);
            cmd.Parameters.AddWithValue("@PI_DISTRITO", PI_DISTRITO);
            cmd.Parameters.AddWithValue("@PI_DIRECCION", PI_DIRECCION);
            cmd.Parameters.AddWithValue("@PI_MOTIVOCONSULTA", PI_MOTIVOCONSULTA);
            cmd.Parameters.AddWithValue("@PI_ALERGIAS", PI_ALERGIAS);
            cmd.Parameters.AddWithValue("@PI_MEDICAMENTOS", PI_MEDICAMENTOS);
            cmd.Parameters.AddWithValue("@PI_ENFERMEDADES", PI_ENFERMEDADES);
            cmd.Parameters.AddWithValue("@PI_EXEXTRAORAL", PI_EXEXTRAORAL);
            cmd.Parameters.AddWithValue("@PI_EXINTRAORAL", PI_EXINTRAORAL);
            cmd.Parameters.AddWithValue("@PI_COMOCONOCIO", PI_COMOCONOCIO);

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


        public string Eliminar_Paciente(string PI_ID)
        {
            cn = cnx.Conectar();

            string mensaje = string.Empty;

            SqlTransaction tr = null;

            SqlCommand cmd = new SqlCommand
                ("USP_ELIMINAR_PACIENTE", cn);
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
        public DataTable Listar_Sexo()
        {
            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_SEXO", cn1);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.Fill(dtb);

            return dtb;
        }

        public DataTable Listar_Departamento()
        {
            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_DEPARTAMENTO", cn1);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.Fill(dtb);

            return dtb;
        }

        public DataTable Listar_Provincia(string Departamento)
        {
            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_PROVINCIA", cn1);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@PL_DEPARTAMENTO", Departamento);
            dap.Fill(dtb);

            return dtb;
        }

        public DataTable Listar_Distrito(string Provincia)
        {
            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_DISTRITO", cn1);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.SelectCommand.Parameters.AddWithValue("@PL_PROVINCIA", Provincia);
            dap.Fill(dtb);

            return dtb;
        }

        public DataTable Listar_Como_Conocio()
        {
            DataTable dtb = new DataTable();

            SqlDataAdapter dap = new SqlDataAdapter
                ("USP_LISTAR_COMOCONOCIO", cn1);
            dap.SelectCommand.CommandType = CommandType.StoredProcedure;
            dap.Fill(dtb);

            return dtb;
        }


    }
}
