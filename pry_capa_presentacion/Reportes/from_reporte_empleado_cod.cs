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
    public partial class from_reporte_empleado_cod : Form
    {
        public from_reporte_empleado_cod()
        {
            InitializeComponent();
        }
        private void from_reporte_empleado_cod_Load(object sender, EventArgs e)
        {
            ListarEmpleado();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ListarEmpleado();
            txt_search.Text = "";
        }

        private void ListarEmpleado()
        {
            ds_empleado dse = new ds_empleado();
            ds_empleadoTableAdapters.dt_empleadoTableAdapter dt_e = new ds_empleadoTableAdapters.dt_empleadoTableAdapter();
            dt_e.Fill(dse.dt_empleado);

            cr_empleado cre = new cr_empleado();
            cre.SetDataSource(dse);
            crv_empleado_cod.ReportSource = cre;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ds_empleado dse = new ds_empleado();
            ds_empleadoTableAdapters.dt_empleadoTableAdapter dt_e = new ds_empleadoTableAdapters.dt_empleadoTableAdapter();
            dt_e.FillBy(dse.dt_empleado, txt_search.Text.ToString());

            cr_empleado cre = new cr_empleado();
            cre.SetDataSource(dse);
            crv_empleado_cod.ReportSource = cre;
        }

    }
}
