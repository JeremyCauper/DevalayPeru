using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pry_capa_entidad;

namespace pry_capa_datos
{
    public class Modelo_Gerente
    {
        private SqlConnection cn;
        private Conexion obj_cnx = new Conexion();

        public DataTable ListarGerente()
        {
            cn = obj_cnx.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("sp_listar_gerente", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void RegistrarGerente(Gerente gerente)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_registrar_gerente", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_gerente", SqlDbType.Char, 5).Value = gerente.cod_gerente;
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar, 20).Value = gerente.num_documento;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = gerente.nombre;
            cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar, 30).Value = gerente.ape_paterno;
            cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar, 30).Value = gerente.ape_materno;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = gerente.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = gerente.email;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = gerente.fecha_nacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = gerente.direccion;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
        public void EditarGerente(Gerente gerente)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_editar_gerente", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_gerente", SqlDbType.Char, 5).Value = gerente.cod_gerente;
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar, 20).Value = gerente.num_documento;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = gerente.nombre;
            cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar, 30).Value = gerente.ape_paterno;
            cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar, 30).Value = gerente.ape_materno;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = gerente.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = gerente.email;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = gerente.fecha_nacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = gerente.direccion;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
        public void BorrarGerente(String codigo)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_borrar_gerente", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod", SqlDbType.Char, 5).Value = codigo;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
    }
}
