using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using pry_capa_entidad;
using pry_capa_datos;

namespace pry_capa_negocio
{
    public class Negocio_Proveedor
    {
        private Modelo_Proveedor m_proveedor = new Modelo_Proveedor();

        public DataTable ListarProveedor()
        {
            return m_proveedor.ListarProveedor();
        }
        public void RegistrarProveedor(Proveedor proveedor)
        {
            m_proveedor.RegistrarProveedor(proveedor);
        }
        public void EditarProveedor(Proveedor proveedor)
        {
            m_proveedor.EditarProveedor(proveedor);
        }
        public void BorrarProveedor(String codigo)
        {
            m_proveedor.BorrarProveedor(codigo);
        }
    }
}
