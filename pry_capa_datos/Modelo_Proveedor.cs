using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pry_capa_entidad;

namespace pry_capa_datos
{
    public class Modelo_Proveedor
    {

        private SqlConnection cn;
        private Conexion obj_cnx = new Conexion();

        public DataTable ListarProveedor()
        {
            cn = obj_cnx.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("sp_listar_proveedor", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void RegistrarProveedor(Proveedor proveedor)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_registrar_proveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_proveedor", SqlDbType.Char, 5).Value = proveedor.cod_proveedor;
            cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 11).Value = proveedor.ruc;
            cmd.Parameters.Add("@razon_social", SqlDbType.VarChar, 255).Value = proveedor.razon_social;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 255).Value = proveedor.direccion;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = proveedor.email;
            cmd.Parameters.Add("@telefono", SqlDbType.Char, 9).Value = proveedor.telefono;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
        public void EditarProveedor(Proveedor proveedor)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_editar_proveedor", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_proveedor", SqlDbType.Char, 5).Value = proveedor.cod_proveedor;
            cmd.Parameters.Add("@ruc", SqlDbType.VarChar, 11).Value = proveedor.ruc;
            cmd.Parameters.Add("@razon_social", SqlDbType.VarChar, 255).Value = proveedor.razon_social;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 255).Value = proveedor.direccion;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = proveedor.email;
            cmd.Parameters.Add("@telefono", SqlDbType.Char, 9).Value = proveedor.telefono;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
        public void BorrarProveedor(String codigo)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_borrar_proveedor", cn);
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
