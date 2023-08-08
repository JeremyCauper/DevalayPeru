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
    public class Negocio_Cliente
    {
        private Modelo_Cliente m_cliente = new Modelo_Cliente();

        public DataTable ListarCliente()
        {
            return m_cliente.ListarCliente();
        }
        public void RegistrarCliente(Cliente cliente)
        {
            m_cliente.RegistrarCliente(cliente);
        }
        public void EditarCliente(Cliente cliente)
        {
            m_cliente.EditarCliente(cliente);
        }
        public void BorrarCliente(String codigo)
        {
            m_cliente.BorrarCliente(codigo);
        }
    }
}
