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
    public class Negocio_Gerente
    {
        private Modelo_Gerente m_gerente = new Modelo_Gerente();
        public DataTable ListarGerente()
        {
            return m_gerente.ListarGerente();
        }
        public void RegistrarGerente(Gerente gerente)
        {
            m_gerente.RegistrarGerente(gerente);
        }
        public void EditarGerente(Gerente gerente)
        {
            m_gerente.EditarGerente(gerente);
        }
        public void BorrarGerente(String codigo)
        {
            m_gerente.BorrarGerente(codigo);
        }
    }
}
