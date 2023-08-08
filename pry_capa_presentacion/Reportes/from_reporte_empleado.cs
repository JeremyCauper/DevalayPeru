using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry_capa_presentacion.Reportes
{
    public partial class from_reporte_empleado : Form
    {
        public from_reporte_empleado()
        {
            InitializeComponent();
        }

        private void from_reporte_empleado_Load(object sender, EventArgs e)
        {
            ds_empleado dse = new ds_empleado();
            ds_empleadoTableAdapters.dt_empleadoTableAdapter dt_e = new ds_empleadoTableAdapters.dt_empleadoTableAdapter();
            dt_e.Fill(dse.dt_empleado);

            cr_empleado cre = new cr_empleado();
            cre.SetDataSource(dse);
            crv_empleado.ReportSource = cre;
        }
    }
}
