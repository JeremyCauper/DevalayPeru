using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace pry_capa_datos
{
    public class Conexion
    {
        public SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cn_davalyperu"].ConnectionString);
            return cn;
        }

    }
}
