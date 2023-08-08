using pry_capa_entidad;
using pry_capa_negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace pry_capa_presentacion.Reportes
{
    public partial class from_consulta_linq : Form
    {
        public from_consulta_linq()
        {
            InitializeComponent();
        }
        Negocio_Almacen n_almacen = new Negocio_Almacen();
        private void from_consulta_linq_Load(object sender, EventArgs e)
        {
            ListarAlmacen();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            ListarAlmacen();
            txt_search.Clear();
        }

        private void ListarAlmacen()
        {
            List<Almacen> lst_almacen = new List<Almacen>();

            lst_almacen = (from DataRow dr in n_almacen.ListarAlmacen().Rows
                           where dr["cod_almacen"].ToString().StartsWith("A")
                           select new Almacen()
                           {
                               cod_almacen = dr["cod_almacen"].ToString(),
                               cantidad = dr["cantidad"].ToString(),
                               unidad = dr["unidad"].ToString(),
                               //fecha_registro = dr["fecha_registro"].ToString(),
                               //precio_venta_unitario = dr["precio_venta_unitario"].ToString(),
                               id_producto = dr["id_producto"].ToString(),
                               id_proveedor = dr["id_proveedor"].ToString()
                           }).ToList();

            dgv_consulta_linq.DataSource = lst_almacen;
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            int index = cmb_search.SelectedIndex;
            String seleccionado = index == 0 ? "cod_almacen" : index == 1 ? "id_producto" : "id_proveedor";

            List <Almacen> lst_almacen = new List<Almacen>();

            lst_almacen = (from DataRow dr in n_almacen.ListarAlmacen().Rows
                           where dr[seleccionado].ToString().StartsWith(txt_search.Text.ToString())
                           select new Almacen()
                           {
                               cod_almacen = dr["cod_almacen"].ToString(),
                               cantidad = dr["cantidad"].ToString(),
                               unidad = dr["unidad"].ToString(),
                               //fecha_registro = dr["fecha_registro"].ToString(),
                               //
                               //precio_venta_unitario = dr["precio_venta_unitario"].ToString(),
                               id_producto = dr["id_producto"].ToString(),
                               id_proveedor = dr["id_proveedor"].ToString()
                           }).ToList();

            dgv_consulta_linq.DataSource = lst_almacen;
        }
    }
}
