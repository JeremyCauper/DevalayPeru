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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private String usuario="admin", password="admin123";
        private void btn_cerrar_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            lbl_line_user.BackColor = SystemColors.Highlight;
            lbl_line_pass.BackColor = SystemColors.ControlLight;
        }

        private void txt_pass_Enter(object sender, EventArgs e)
        {
            lbl_line_pass.BackColor = SystemColors.Highlight;
            lbl_line_user.BackColor = SystemColors.ControlLight;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "")
            {
                Mensajes("!Por favor ingrese el usuario¡");
                txt_user.Focus();
                return;
            }
            if (txt_pass.Text == "")
            {
                Mensajes("!Por favor ingrese la contraseña¡");
                txt_pass.Focus();
                return;
            }
            if (txt_user.Text != usuario)
            {
                Mensajes("El usuario no es valido");
                txt_user.Focus();
                return;
            }
            if (txt_pass.Text != password)
            {
                Mensajes("La contraseña no es valida");
                txt_user.Focus();
                return;
            }
            this.Hide();
            from_principal fm_Principal = new from_principal();
            fm_Principal.ShowDialog();
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Mensajes(String msg)
        {
            MessageBox.Show(msg, "DEVANLAY PERU");
        }
    }
}
