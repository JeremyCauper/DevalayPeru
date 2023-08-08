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
    public class Negocio_Producto
    {
        private Modelo_Producto m_producto = new Modelo_Producto();

        public DataTable ListarProducto()
        {
            return m_producto.ListarProducto();
        }
        public void RegistrarProducto(Producto producto)
        {
            m_producto.RegistrarProducto(producto);
        }
        public void EditarProducto(Producto producto)
        {
            m_producto.EditarProducto(producto);
        }
        public void BorrarProducto(String codigo)
        {
            m_producto.BorrarProducto(codigo);
        }
    }
}
