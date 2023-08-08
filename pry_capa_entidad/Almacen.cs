using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry_capa_entidad
{
    public class Almacen
    {
        public String cod_almacen { get; set; }
        public String cantidad { get; set; }
        public String unidad { get; set; }
        public DateTime fecha_registro { get; set; }
        public Decimal precio_venta_unitario { get; set; }
        public String id_producto { get; set; }
        public String id_proveedor { get; set; }
    }
}
