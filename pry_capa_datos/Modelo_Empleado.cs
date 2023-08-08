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
    public class Modelo_Empleado
    {
        private SqlConnection cn;
        private Conexion obj_cnx = new Conexion();


        public DataTable ListarEmpleado()
        {
            cn = obj_cnx.Conectar();
            SqlDataAdapter sda = new SqlDataAdapter("sp_listar_empleado", cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        public void RegistrarEmpleado(Empleado empleado)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_registrar_empleado", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_empleado", SqlDbType.Char, 5).Value = empleado.cod_empleado;
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar, 20).Value = empleado.num_documento;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = empleado.nombre;
            cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar, 30).Value = empleado.ape_paterno;
            cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar, 30).Value = empleado.ape_materno;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = empleado.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = empleado.email;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = empleado.fecha_nacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = empleado.direccion;


            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
        public void EditarEmpleado(Empleado empleado)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_editar_empleado", cn);
            cmd.CommandType = CommandType.StoredProcedure; //
            cmd.Parameters.Add("@cod_empleado", SqlDbType.Char, 5).Value = empleado.cod_empleado;
            cmd.Parameters.Add("@num_documento", SqlDbType.VarChar, 20).Value = empleado.num_documento;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = empleado.nombre;
            cmd.Parameters.Add("@ape_paterno", SqlDbType.VarChar, 30).Value = empleado.ape_paterno;
            cmd.Parameters.Add("@ape_materno", SqlDbType.VarChar, 30).Value = empleado.ape_materno;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 9).Value = empleado.telefono;
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 100).Value = empleado.email;
            cmd.Parameters.Add("@fecha_nacimiento", SqlDbType.Date).Value = empleado.fecha_nacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 100).Value = empleado.direccion;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { }
        }
        public void BorrarEmpleado(String codigo)
        {
            cn = obj_cnx.Conectar();
            cn.Open();
            SqlCommand cmd = new SqlCommand("sp_borrar_empleado", cn);
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
