using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;
using Control = System.Windows.Forms.Control;

namespace pry_capa_presentacion
{
    public class ControladorControlers
    {

        public void LimpiarForm(Form from)
        {
            foreach (Control control in from.Controls)
            {
                if (control is Guna2TextBox g2textBox)
                {
                    g2textBox.Text = "";
                }
                if (control is Guna2ComboBox g2ComboBox)
                {
                    if (g2ComboBox.SelectedIndex != -1)
                    {
                        g2ComboBox.SelectedIndex = -1;
                    }
                }
            }
        }

        public Boolean ValidarForm(Form from)
        {
            Boolean validez = true;
            foreach (Control control in from.Controls)
            {
                if (control is Guna2TextBox)
                {
                    if (control.Text == "")
                    {
                        validez = false;
                        break;
                    }
                }
                if (control is Guna2ComboBox g2ComboBox)
                {
                    if (g2ComboBox.SelectedIndex == -1)
                    {
                        validez = false;
                        break;
                    }
                }
            }
            return validez;
        }

        public void HabilitarForm(Form from, Boolean estado)
        {
            foreach (Control control in from.Controls)
            {
                if (control is Guna2TextBox || control is Guna2ComboBox || control is Guna2DateTimePicker)
                {
                    control.Enabled = estado;
                }
            }
        }

        public void PermitirNumEntero(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void PermitirNumDecimal( KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        public void Mensaje(String mensaje)
        {
            MessageBox.Show(mensaje, "DEVANLAY PERU", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Alerta(String mensaje)
        {
            DialogResult dr = MessageBox.Show(mensaje, "DEVANLAY PERU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return dr;
        }
    }
}
