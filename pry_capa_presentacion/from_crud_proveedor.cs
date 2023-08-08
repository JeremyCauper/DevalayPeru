using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using pry_capa_negocio;
using pry_capa_entidad;

namespace pry_capa_presentacion
{
    public partial class from_crud_proveedor : Form
    {
        private ControladorControlers controlC = new ControladorControlers();
        private Negocio_Proveedor n_proveedor = new Negocio_Proveedor();
        private String accion = "R";
        public from_crud_proveedor()
        {
            InitializeComponent();
        }
        private void from_crud_proveedor_Load(object sender, EventArgs e)
        {
            ListarProveedor();
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
            Proveedor proveedor = new Proveedor();
            proveedor.cod_proveedor = txt_cod.Text;
            proveedor.ruc = txt_ruc.Text;
            proveedor.email = txt_email.Text;
            proveedor.direccion = txt_dir.Text;
            proveedor.razon_social = txt_rs.Text;
            proveedor.telefono = txt_tel.Text;

            if (accion == "R")
            {
                n_proveedor.RegistrarProveedor(proveedor);
                controlC.Mensaje("Proveedor registrado con exito!");
            }
            else if (accion == "E")
            {
                n_proveedor.EditarProveedor(proveedor);
                controlC.Mensaje("Proveedor editado con exito!");
            }

            ListarProveedor();
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
        }
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (controlC.Alerta("¿Seguro de borrar el proveedor?") == DialogResult.No)
            {
                return;
            }
            n_proveedor.BorrarProveedor(txt_cod.Text);

            ListarProveedor();
            accion = "R";
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
            controlC.Mensaje("Proveedor eliminado");
        }
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgv_proveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_proveedor.CurrentRow.Selected = true;
            txt_cod.Text = dgv_proveedor.CurrentRow.Cells[0].Value.ToString();
            txt_ruc.Text = dgv_proveedor.CurrentRow.Cells[1].Value.ToString();
            txt_rs.Text = dgv_proveedor.CurrentRow.Cells[2].Value.ToString();
            txt_dir.Text = dgv_proveedor.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dgv_proveedor.CurrentRow.Cells[4].Value.ToString();
            txt_tel.Text = dgv_proveedor.CurrentRow.Cells[5].Value.ToString();

            controlC.HabilitarForm(this, true);
            txt_cod.Enabled = false;
            btn_borrar.Enabled = true;
            btn_guardar.Enabled = true;
            accion = "E";
        }

        private void txt_ruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlC.PermitirNumEntero(e);
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlC.PermitirNumEntero(e);
        }

        private void ListarProveedor()
        {
            dgv_proveedor.DataSource = n_proveedor.ListarProveedor();
            int cant = dgv_proveedor.RowCount;
            lbl_conteo.Text = cant == 1 ? "Existe " + cant + " proveedor" : "Existen " + cant + " proveedores";

            controlC.HabilitarForm(this, false);
            controlC.LimpiarForm(this);
        }
    }
}
