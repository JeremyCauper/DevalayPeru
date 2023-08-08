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
using System.Windows.Forms;

namespace pry_capa_presentacion
{
    public partial class from_crud_producto : Form
    {
        private ControladorControlers controlC = new ControladorControlers();
        Negocio_Producto n_producto = new Negocio_Producto();
        private String accion = "R";
        public from_crud_producto()
        {
            InitializeComponent();
        }

        private void from_crud_producto_Load(object sender, EventArgs e)
        {
            ListarProducto();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            controlC.LimpiarForm(this);
            controlC.HabilitarForm(this, true);
            txt_cod.Focus();
            btn_borrar.Enabled = false;
            btn_guardar.Enabled = true;
            accion = "R";
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (!controlC.ValidarForm(this))
            {
                controlC.Mensaje("Existen campos vacios o sin seleccionar, por favor verificar");
                return;
            }
            if (controlC.Alerta("¿Esta seguro de guardar la informacion?") == DialogResult.No)
            {
                return;
            }
            Producto producto = new Producto();
            producto.cod_producto = txt_cod.Text;
            producto.descripcion = txt_producto.Text;
            producto.fecha_registro = date_registro.Value;

            if (accion == "R")
            {
                n_producto.RegistrarProducto(producto);
                controlC.Mensaje("Producto registrado con exito!");
            }
            else if (accion == "E")
            {
                n_producto.EditarProducto(producto);
                controlC.Mensaje("Producto editado con exito!");
            }

            ListarProducto();
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (controlC.Alerta("¿Seguro de borrar el producto?") == DialogResult.No)
            {
                return;
            }
            n_producto.BorrarProducto(txt_cod.Text);

            ListarProducto();
            accion = "R";
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
            controlC.Mensaje("Producto eliminado");
        }

        private void dgv_producto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_producto.CurrentRow.Selected = true;
            txt_cod.Text = dgv_producto.CurrentRow.Cells[0].Value.ToString();
            txt_producto.Text = dgv_producto.CurrentRow.Cells[1].Value.ToString();
            date_registro.Value = DateTime.Parse(dgv_producto.CurrentRow.Cells[2].Value.ToString());

            controlC.HabilitarForm(this, true);
            txt_cod.Enabled = false;
            btn_borrar.Enabled = true;
            btn_guardar.Enabled = true;
            accion = "E";
        }


        private void ListarProducto()
        {
            dgv_producto.DataSource = n_producto.ListarProducto();
            int cant = dgv_producto.RowCount;
            lbl_conteo.Text = cant == 1 ? "Existe " + cant + " producto" : "Existen " + cant + " productos";

            controlC.HabilitarForm(this, false);
            controlC.LimpiarForm(this);
        }
    }
}