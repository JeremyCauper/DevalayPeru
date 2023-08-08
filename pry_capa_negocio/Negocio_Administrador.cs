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
    public class Negocio_Administrador
    {
        private Modelo_Administrador m_administrador = new Modelo_Administrador();

        public DataTable ListarAdministrador()
        {
            return m_administrador.ListarAdministrador();
        }
        public void RegistrarAdministrador(Administrador administrador)
        {
            m_administrador.RegistrarAdministrador(administrador);
        }
        public void EditarAdministrador(Administrador administrador)
        {
            m_administrador.EditarAdministrador(administrador);
        }
        public void BorrarAdministrador(String codigo)
        {
            m_administrador.BorrarAdministrador(codigo);
        }
    }
}
