using Guna.UI2.WinForms;
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
    public partial class from_crud_empleado : Form
    {
        private ControladorControlers controlC = new ControladorControlers();
        private Negocio_Empleado n_empleado = new Negocio_Empleado();
        private String accion = "R";
        public from_crud_empleado()
        {
            InitializeComponent();
        }

        private void from_crud_empleado_Load(object sender, EventArgs e)
        {
            ListarEmpleado();
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
            Empleado empleado = new Empleado();
            empleado.cod_empleado = txt_cod.Text;
            empleado.num_documento = txt_documento.Text;
            empleado.nombre = txt_nombre.Text;
            empleado.ape_paterno = txt_appaterno.Text;
            empleado.ape_materno = txt_apmaterno.Text;
            empleado.telefono = txt_telefono.Text;
            empleado.email = txt_email.Text;
            empleado.fecha_nacimiento = dp_nacimiento.Value;
            empleado.direccion = txt_direccion.Text;

            if (accion == "R")
            {
                n_empleado.RegistrarEmpleado(empleado);
                controlC.Mensaje("Empleado registrado con exito!");
            }
            else if (accion == "E")
            {
                n_empleado.EditarEmpleado(empleado);
                controlC.Mensaje("Empleado editado con exito!");
            }

            ListarEmpleado();
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (controlC.Alerta("¿Seguro de borrar el empleado?") == DialogResult.No)
            {
                return;
            }
            n_empleado.BorrarEmpleado(txt_cod.Text);

            ListarEmpleado();
            accion = "R";
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
            controlC.Mensaje("Empleado eliminado");
        }

        private void dgv_empleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_empleado.CurrentRow.Selected = true;
            txt_cod.Text = dgv_empleado.CurrentRow.Cells[0].Value.ToString();
            txt_documento.Text = dgv_empleado.CurrentRow.Cells[1].Value.ToString();
            txt_nombre.Text = dgv_empleado.CurrentRow.Cells[2].Value.ToString();
            txt_appaterno.Text = dgv_empleado.CurrentRow.Cells[3].Value.ToString();
            txt_apmaterno.Text = dgv_empleado.CurrentRow.Cells[4].Value.ToString();
            txt_telefono.Text = dgv_empleado.CurrentRow.Cells[5].Value.ToString();
            txt_email.Text = dgv_empleado.CurrentRow.Cells[6].Value.ToString();
            dp_nacimiento.Value = DateTime.Parse(dgv_empleado.CurrentRow.Cells[7].Value.ToString());
            txt_direccion.Text = dgv_empleado.CurrentRow.Cells[8].Value.ToString();

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

        private void ListarEmpleado()
        {
            dgv_empleado.DataSource = n_empleado.ListarEmpleado();
            int cant = dgv_empleado.RowCount;
            lbl_conteo.Text = cant == 1 ? "Existe " + cant + " empleado" : "Existen " + cant + " empleados";

            controlC.HabilitarForm(this, false);
            controlC.LimpiarForm(this);
        }
    }
}