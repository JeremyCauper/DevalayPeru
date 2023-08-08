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
    public partial class from_reporte_cliente_nom : Form
    {
        public from_reporte_cliente_nom()
        {
            InitializeComponent();
        }

        private void from_reporte_cliente_nom_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            ds_cliente dsc = new ds_cliente();
            ds_clienteTableAdapters.dt_clienteTableAdapter dt_c = new ds_clienteTableAdapters.dt_clienteTableAdapter();
            dt_c.FillBy(dsc.dt_cliente, txt_search.Text.ToString());

            cr_cliente crc = new cr_cliente();
            crc.SetDataSource(dsc);
            crv_cliente_nom.ReportSource = crc;

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ListarClientes();
            txt_search.Text = "";
        }

        private void ListarClientes ()
        {
            ds_cliente dsc = new ds_cliente();
            ds_clienteTableAdapters.dt_clienteTableAdapter dt_c = new ds_clienteTableAdapters.dt_clienteTableAdapter();
            dt_c.Fill(dsc.dt_cliente);

            cr_cliente crc = new cr_cliente();
            crc.SetDataSource(dsc);
            crv_cliente_nom.ReportSource = crc;
        }
    }
}
