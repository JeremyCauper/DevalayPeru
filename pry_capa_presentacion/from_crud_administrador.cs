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
    public partial class from_crud_administrador : Form
    {
        private ControladorControlers controlC = new ControladorControlers();
        private Negocio_Administrador n_administrador = new Negocio_Administrador();
        private String accion = "R";
        public from_crud_administrador()
        {
            InitializeComponent();
        }

        private void from_crud_administrador_Load(object sender, EventArgs e)
        {
            ListarAdministrador();
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
            Administrador administrador = new Administrador();
            administrador.cod_administrador = txt_cod.Text;
            administrador.num_documento = txt_documento.Text;
            administrador.nombre = txt_nombre.Text;
            administrador.ape_paterno = txt_appaterno.Text;
            administrador.ape_materno = txt_apmaterno.Text;
            administrador.telefono = txt_telefono.Text;
            administrador.email = txt_email.Text;
            administrador.fecha_nacimiento = dp_nacimiento.Value;
            administrador.direccion = txt_direccion.Text;

            if (accion == "R")
            {
                n_administrador.RegistrarAdministrador(administrador);
                controlC.Mensaje("Administrador registrado con exito!");
            }
            else if (accion == "E")
            {
                n_administrador.EditarAdministrador(administrador);
                controlC.Mensaje("Administrador editado con exito!");
            }

            ListarAdministrador();
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (controlC.Alerta("¿Seguro de borrar el Administrador?") == DialogResult.No)
            {
                return;
            }
            n_administrador.BorrarAdministrador(txt_cod.Text);

            accion = "R";
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
            controlC.Mensaje("Administrador eliminado");
            ListarAdministrador();
        }
        private void dgv_administrador_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_administrador.CurrentRow.Selected = true;
            txt_cod.Text = dgv_administrador.CurrentRow.Cells[0].Value.ToString();
            txt_documento.Text = dgv_administrador.CurrentRow.Cells[1].Value.ToString();
            txt_nombre.Text = dgv_administrador.CurrentRow.Cells[2].Value.ToString();
            txt_appaterno.Text = dgv_administrador.CurrentRow.Cells[3].Value.ToString();
            txt_apmaterno.Text = dgv_administrador.CurrentRow.Cells[4].Value.ToString();
            txt_telefono.Text = dgv_administrador.CurrentRow.Cells[5].Value.ToString();
            txt_email.Text = dgv_administrador.CurrentRow.Cells[6].Value.ToString();
            dp_nacimiento.Value = DateTime.Parse(dgv_administrador.CurrentRow.Cells[7].Value.ToString());
            txt_direccion.Text = dgv_administrador.CurrentRow.Cells[8].Value.ToString();

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
        
        private void ListarAdministrador()
        {
            dgv_administrador.DataSource = n_administrador.ListarAdministrador();
            int cant = dgv_administrador.RowCount;
            lbl_conteo.Text = cant == 1 ? "Existe " + cant + " administrador" : "Existen " + cant + " administradores";

            controlC.HabilitarForm(this, false);
            controlC.LimpiarForm(this);
        }
    }
}
