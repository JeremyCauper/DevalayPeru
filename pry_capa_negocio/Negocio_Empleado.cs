using pry_capa_datos;
using pry_capa_entidad;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry_capa_negocio
{
    public class Negocio_Empleado
    {
        private Modelo_Empleado m_mpleado = new Modelo_Empleado();

        public DataTable ListarEmpleado()
        {
            return m_mpleado.ListarEmpleado();
        }
        public void RegistrarEmpleado(Empleado empleado)
        {
            m_mpleado.RegistrarEmpleado(empleado);
        }
        public void EditarEmpleado(Empleado empleado)
        {
            m_mpleado.EditarEmpleado(empleado);
        }
        public void BorrarEmpleado(String codigo)
        {
            m_mpleado.BorrarEmpleado(codigo);
        }
    }
}
