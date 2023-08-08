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
    public partial class from_crud_cliente : Form
    {
        private ControladorControlers controlC = new ControladorControlers();
        Negocio_Cliente n_cliente = new Negocio_Cliente();
        private String accion = "R";
        public from_crud_cliente()
        {
            InitializeComponent();
        }

        private void from_crud_cliente_Load(object sender, EventArgs e)
        {
            ListarCliente();
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
            Cliente cliente = new Cliente();
            cliente.cod_cliente = txt_cod.Text;
            cliente.num_documento = txt_documento.Text;
            cliente.nombre = txt_nombre.Text;
            cliente.ape_paterno = txt_appaterno.Text;
            cliente.ape_materno = txt_apmaterno.Text;
            cliente.telefono = txt_telefono.Text;
            cliente.email = txt_email.Text;
            cliente.fecha_nacimiento = dp_nacimiento.Value;
            cliente.direccion = txt_direccion.Text;

            if (accion == "R")
            {
                n_cliente.RegistrarCliente(cliente);
                controlC.Mensaje("Cliente añadido con exito!");
            }
            else if (accion == "E")
            {
                n_cliente.EditarCliente(cliente);
                controlC.Mensaje("Cliente editado con exito!");
            }

            ListarCliente();
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (controlC.Alerta("¿Seguro de borrar el Cliente?") == DialogResult.No)
            {
                return;
            }
            n_cliente.BorrarCliente(txt_cod.Text);

            ListarCliente();
            accion = "R";
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
            controlC.Mensaje("Cliente eliminado");
        }

        private void dgv_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_cliente.CurrentRow.Selected = true;
            txt_cod.Text = dgv_cliente.CurrentRow.Cells[0].Value.ToString();
            txt_documento.Text = dgv_cliente.CurrentRow.Cells[1].Value.ToString();
            txt_nombre.Text = dgv_cliente.CurrentRow.Cells[2].Value.ToString();
            txt_appaterno.Text = dgv_cliente.CurrentRow.Cells[3].Value.ToString();
            txt_apmaterno.Text = dgv_cliente.CurrentRow.Cells[4].Value.ToString();
            txt_telefono.Text = dgv_cliente.CurrentRow.Cells[5].Value.ToString();
            txt_email.Text = dgv_cliente.CurrentRow.Cells[6].Value.ToString();
            dp_nacimiento.Value = DateTime.Parse(dgv_cliente.CurrentRow.Cells[7].Value.ToString());
            txt_direccion.Text = dgv_cliente.CurrentRow.Cells[8].Value.ToString();

            controlC.HabilitarForm(this, true);
            txt_cod.Enabled = false;
            btn_borrar.Enabled = true;
            btn_guardar.Enabled = true;
            accion = "E";
        }

        private void txt_documento_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlC.PermitirNumEntero(e);
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            controlC.PermitirNumEntero(e);
        }

        private void ListarCliente()
        {
            dgv_cliente.DataSource = n_cliente.ListarCliente();
            int cant = dgv_cliente.RowCount;
            lbl_conteo.Text = cant == 1 ? "Existe " + cant + " cliente" : "Existen " + cant + " clientes";

            controlC.HabilitarForm(this, false);
            controlC.LimpiarForm(this);
        }
    }
}
