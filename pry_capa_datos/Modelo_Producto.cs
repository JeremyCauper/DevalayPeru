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
    public class Modelo_Producto
    {
        private SqlConnection cn;
        private Conexion obj_cnx = new Conexion();

        public DataTable ListarProducto()
        {
            cn = obj_cnx.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("sp_listar_producto", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void RegistrarProducto(Producto producto)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_registrar_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_producto", SqlDbType.Char, 5).Value = producto.cod_producto;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 150).Value = producto.descripcion;
            cmd.Parameters.Add("@fecha_registro", SqlDbType.Date).Value = producto.fecha_registro;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }

        public void EditarProducto(Producto producto)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_editar_producto", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_producto", SqlDbType.Char, 5).Value = producto.cod_producto;
            cmd.Parameters.Add("@descripcion", SqlDbType.VarChar, 150).Value = producto.descripcion;
            cmd.Parameters.Add("@fecha_registro", SqlDbType.Date).Value = producto.fecha_registro;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }

        public void BorrarProducto(String codigo)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_borrar_producto", cn);
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
