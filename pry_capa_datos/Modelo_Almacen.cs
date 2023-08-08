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
    public class Modelo_Almacen
    {
        private SqlConnection cn;
        private Conexion obj_cnx = new Conexion();

        public DataTable ListarAlmacen()
        {
            cn = obj_cnx.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("sp_listar_almacen", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void RegistrarAlmacen(Almacen almacen)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_registrar_almacen", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_almacen", SqlDbType.Char, 5).Value = almacen.cod_almacen;
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = almacen.cantidad;
            cmd.Parameters.Add("@unidad", SqlDbType.VarChar, 50).Value = almacen.unidad;
            cmd.Parameters.Add("@fecha_registro", SqlDbType.Date).Value = almacen.fecha_registro;
            cmd.Parameters.Add("@precio_venta_unitario", SqlDbType.Decimal).Value = almacen.precio_venta_unitario;
            cmd.Parameters.Add("@id_producto", SqlDbType.Char, 5).Value = almacen.id_producto;
            cmd.Parameters.Add("@id_proveedor", SqlDbType.Char, 5).Value = almacen.id_proveedor;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }

        public void EditarAlmacen(Almacen almacen)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_editar_almacen", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_almacen", SqlDbType.Char, 5).Value = almacen.cod_almacen;
            cmd.Parameters.Add("@cantidad", SqlDbType.Int).Value = almacen.cantidad;
            cmd.Parameters.Add("@unidad", SqlDbType.VarChar, 50).Value = almacen.unidad;
            cmd.Parameters.Add("@fecha_registro", SqlDbType.Date).Value = almacen.fecha_registro;
            cmd.Parameters.Add("@precio_venta_unitario", SqlDbType.Decimal).Value = almacen.precio_venta_unitario;
            cmd.Parameters.Add("@id_producto", SqlDbType.Char, 5).Value = almacen.id_producto;
            cmd.Parameters.Add("@id_proveedor", SqlDbType.Char, 5).Value = almacen.id_proveedor;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }

        public void BorrarAlmacen(String codigo)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_borrar_almacen", cn);
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
