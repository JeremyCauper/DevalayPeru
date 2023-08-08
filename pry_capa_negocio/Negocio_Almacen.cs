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
    public class Negocio_Almacen
    {
        private Modelo_Almacen m_almacen = new Modelo_Almacen();

        public DataTable ListarAlmacen()
        {
            return m_almacen.ListarAlmacen();
        }
        public void RegistrarAlmacen(Almacen almacen)
        {
            m_almacen.RegistrarAlmacen(almacen);
        }
        public void EditarAlmacen(Almacen almacen)
        {
            m_almacen.EditarAlmacen(almacen);
        }
        public void BorrarAlmaceno(String almacen)
        {
            m_almacen.BorrarAlmacen(almacen);
        }
    }
}
