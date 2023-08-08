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
    public partial class from_crud_almacen : Form
    {
        private ControladorControlers controlC = new ControladorControlers();
        Negocio_Almacen n_almacen = new Negocio_Almacen();
        Negocio_Producto n_producto = new Negocio_Producto();
        Negocio_Proveedor n_proveedor = new Negocio_Proveedor();
        private String accion = "R";
        public from_crud_almacen()
        {
            InitializeComponent();
        }

        private void from_crud_almacen_Load(object sender, EventArgs e)
        {
            ListarAlmacen();

            cmb_producto.DataSource = n_producto.ListarProducto();
            cmb_producto.DisplayMember = "descripcion";
            cmb_producto.ValueMember = "cod_producto";
            cmb_producto.SelectedIndex = -1;

            cmb_proveedor.DataSource = n_proveedor.ListarProveedor();
            cmb_proveedor.DisplayMember = "razon_social";
            cmb_proveedor.ValueMember = "cod_proveedor";
            cmb_proveedor.SelectedIndex = -1;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            controlC.LimpiarForm(this);
            controlC.LimpiarForm(this);
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
            Almacen almacen = new Almacen();
            almacen.cod_almacen = txt_cod.Text;
            almacen.cantidad = txt_cantidad.Text;
            almacen.unidad = txt_unidad.Text;
            almacen.fecha_registro = dp_ingreso.Value;
            almacen.precio_venta_unitario = Decimal.Parse(txt_precio.Text);
            almacen.id_producto = cmb_producto.SelectedValue.ToString();
            almacen.id_proveedor = cmb_proveedor.SelectedValue.ToString();

            if (accion == "R")
            {
                n_almacen.RegistrarAlmacen(almacen);
                controlC.Mensaje("Registro añadido con exito!");
            }
            else if (accion == "E")
            {
                n_almacen.EditarAlmacen(almacen);
                controlC.Mensaje("Registro editado con exito!");
            }

            ListarAlmacen();
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (controlC.Alerta("¿Seguro de borrar el Administrador?") == DialogResult.No)
            {
                return;
            }
            n_almacen.BorrarAlmaceno(txt_cod.Text);

            ListarAlmacen();
            accion = "R";
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
            controlC.Mensaje("Registro eliminado");
        }
        private void dgv_almacen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_almacen.CurrentRow.Selected = true;

            txt_cod.Text = dgv_almacen.CurrentRow.Cells[0].Value.ToString();
            txt_cantidad.Text = dgv_almacen.CurrentRow.Cells[1].Value.ToString();
            txt_unidad.Text = dgv_almacen.CurrentRow.Cells[2].Value.ToString();
            dp_ingreso.Value = DateTime.Parse(dgv_almacen.CurrentRow.Cells[3].Value.ToString());
            txt_precio.Text = dgv_almacen.CurrentRow.Cells[4].Value.ToString();
            cmb_producto.SelectedValue = dgv_almacen.CurrentRow.Cells[5].Value.ToString();
            cmb_proveedor.SelectedValue = dgv_almacen.CurrentRow.Cells[6].Value.ToString();

            controlC.HabilitarForm(this, true);
            txt_cod.Enabled = false;
            btn_borrar.Enabled = true;
            btn_guardar.Enabled = true;
            accion = "E";
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlC.PermitirNumEntero(e);
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlC.PermitirNumDecimal(e);
        }

        private void ListarAlmacen()
        {
            dgv_almacen.DataSource = n_almacen.ListarAlmacen();
            int cant = dgv_almacen.RowCount;
            lbl_conteo.Text = cant == 1 ? "Existe " + cant + " registro" : "Existen " + cant + " registros";

            controlC.HabilitarForm(this, false);
            controlC.LimpiarForm(this);
            controlC.LimpiarForm(this);
            controlC.LimpiarForm(this);
        }
    }
}
