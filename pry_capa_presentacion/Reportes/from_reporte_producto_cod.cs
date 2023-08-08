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
    public partial class from_reporte_producto_cod : Form
    {
        public from_reporte_producto_cod()
        {
            InitializeComponent();
        }

        private void from_reporte_producto_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ListarProductos();
            txt_search.Text = "";
        }

        private void ListarProductos()
        {
            ds_producto dsp = new ds_producto();
            ds_productoTableAdapters.dt_productoTableAdapter dt_p = new ds_productoTableAdapters.dt_productoTableAdapter();
            dt_p.Fill(dsp.dt_producto);

            cr_producto crp = new cr_producto();
            crp.SetDataSource(dsp);
            crv_producto_cod.ReportSource = crp;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ds_producto dsp = new ds_producto();
            ds_productoTableAdapters.dt_productoTableAdapter dt_p = new ds_productoTableAdapters.dt_productoTableAdapter();
            dt_p.FillBy(dsp.dt_producto, txt_search.Text.ToString());

            cr_producto crp = new cr_producto();
            crp.SetDataSource(dsp);
            crv_producto_cod.ReportSource = crp;

        }

    }
}
