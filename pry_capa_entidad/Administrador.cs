using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pry_capa_entidad
{
    public class Administrador
    {
        public String cod_administrador { get; set; }
        public String num_documento { get; set; }
        public String nombre { get; set; }
        public String ape_paterno { get; set; }
        public String ape_materno { get; set; }
        public String telefono { get; set; }
        public String email { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public String direccion { get; set; }
    }
}
