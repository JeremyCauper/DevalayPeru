using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pry_capa_entidad;
using System.Data.SqlClient;
using System.Data;
namespace pry_capa_datos
{
    public class Modelo_Cliente
    {
        private SqlConnection cn;
        private Conexion obj_cnx = new Conexion();

        public DataTable ListarCliente()
        {
            cn = obj_cnx.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("sp_listar_cliente", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void RegistrarCliente(Cliente cliente)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_registrar_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_cliente", SqlDbType.Char, 5).Value = cliente.cod_cliente;
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar, 20).Value = cliente.num_documento;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = cliente.nombre;
            cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar, 30).Value = cliente.ape_paterno;
            cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar, 30).Value = cliente.ape_materno;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = cliente.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = cliente.email;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = cliente.fecha_nacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = cliente.direccion;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
        public void EditarCliente(Cliente cliente)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_editar_cliente", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_cliente", SqlDbType.Char, 5).Value = cliente.cod_cliente;
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar, 20).Value = cliente.num_documento;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = cliente.nombre;
            cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar, 30).Value = cliente.ape_paterno;
            cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar, 30).Value = cliente.ape_materno;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = cliente.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = cliente.email;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = cliente.fecha_nacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = cliente.direccion;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
        public void BorrarCliente(String codigo)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_borrar_cliente", cn);
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
