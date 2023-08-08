using pry_capa_entidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry_capa_datos
{
    public class Modelo_Administrador
    {
        private SqlConnection cn;
        private Conexion obj_cnx = new Conexion();

        public DataTable ListarAdministrador()
        {
            cn = obj_cnx.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("sp_listar_administrador", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void RegistrarAdministrador(Administrador administrador)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_registrar_administrador", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_administrador", SqlDbType.Char, 5).Value = administrador.cod_administrador;
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar, 20).Value = administrador.num_documento;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = administrador.nombre;
            cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar, 30).Value = administrador.ape_paterno;
            cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar, 30).Value = administrador.ape_materno;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = administrador.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = administrador.email;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = administrador.fecha_nacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = administrador.direccion;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }

        }
        public void EditarAdministrador(Administrador administrador)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_editar_administrador", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_administrador", SqlDbType.Char, 5).Value = administrador.cod_administrador;
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar, 20).Value = administrador.num_documento;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = administrador.nombre;
            cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar, 30).Value = administrador.ape_paterno;
            cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar, 30).Value = administrador.ape_materno;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = administrador.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = administrador.email;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = administrador.fecha_nacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = administrador.direccion;



            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
        public void BorrarAdministrador(String codigo)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_borrar_administrador", cn);
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
