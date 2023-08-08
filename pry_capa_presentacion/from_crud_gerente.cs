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
    public partial class from_crud_gerente : Form
    {
        private ControladorControlers controlC = new ControladorControlers();
        private Negocio_Gerente n_gerente = new Negocio_Gerente();
        private String accion = "R";
        public from_crud_gerente()
        {
            InitializeComponent();
        }

        private void from_crud_gerente_Load(object sender, EventArgs e)
        {
            ListarGerente();
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
            Gerente gerente = new Gerente();
            gerente.cod_gerente = txt_cod.Text;
            gerente.num_documento = txt_documento.Text;
            gerente.nombre = txt_nombre.Text;
            gerente.ape_paterno = txt_appaterno.Text;
            gerente.ape_materno = txt_apmaterno.Text;
            gerente.telefono = txt_telefono.Text;
            gerente.email = txt_email.Text;
            gerente.fecha_nacimiento = dp_nacimiento.Value;
            gerente.direccion = txt_direccion.Text;

            if (accion == "R")
            {
                n_gerente.RegistrarGerente(gerente);
                controlC.Mensaje("Gerente añadido con exito!");
            }
            else if (accion == "E")
            {
                n_gerente.EditarGerente(gerente);
                controlC.Mensaje("Gerente editado con exito!");
            }

            ListarGerente();
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (controlC.Alerta("¿Seguro de borrar el Gerente?") == DialogResult.No)
            {
                return;
            }
            n_gerente.BorrarGerente(txt_cod.Text);

            ListarGerente();
            accion = "R";
            btn_guardar.Enabled = false;
            btn_borrar.Enabled = false;
            controlC.Mensaje("Gerente eliminado");
        }

        private void dgv_gerente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_gerente.CurrentRow.Selected = true;
            txt_cod.Text = dgv_gerente.CurrentRow.Cells[0].Value.ToString();
            txt_documento.Text = dgv_gerente.CurrentRow.Cells[1].Value.ToString();
            txt_nombre.Text = dgv_gerente.CurrentRow.Cells[2].Value.ToString();
            txt_appaterno.Text = dgv_gerente.CurrentRow.Cells[3].Value.ToString();
            txt_apmaterno.Text = dgv_gerente.CurrentRow.Cells[4].Value.ToString();
            txt_telefono.Text = dgv_gerente.CurrentRow.Cells[5].Value.ToString();
            txt_email.Text = dgv_gerente.CurrentRow.Cells[6].Value.ToString();
            dp_nacimiento.Value = DateTime.Parse(dgv_gerente.CurrentRow.Cells[7].Value.ToString());
            txt_direccion.Text = dgv_gerente.CurrentRow.Cells[8].Value.ToString();

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

        private void ListarGerente()
        {
            dgv_gerente.DataSource = n_gerente.ListarGerente();
            int cant = dgv_gerente.RowCount;
            lbl_conteo.Text = cant == 1 ? "Existe " + cant + " gerente" : "Existen " + cant + " gerentes";

            controlC.HabilitarForm(this, false);
            controlC.LimpiarForm(this);
        }
    }
}
