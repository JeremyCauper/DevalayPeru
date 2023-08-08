using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;

namespace pry_capa_presentacion
{
    /// <summary>
    /// Lógica de interacción para from_login.xaml
    /// </summary>
    public partial class from_login : Window
    {
        public String usuario = "admin", password = "admin123";
        public from_login()
        {
            InitializeComponent();
        }

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            txt_user.Focus();
        }

        private void txt_user_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key.ToString() == "Return")
            {
                txt_pass.Focus();
            }
        }

        private void txt_pass_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key.ToString() == "Return")
            {
                ValidarLogin();
            }
        }

        private void btnIniciar_Click(object sender, RoutedEventArgs e)
        {
            ValidarLogin();
        }

        private void btnSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Mensajes(String msj, int icono)
        {
            System.Windows.Forms.MessageBox.Show(msj, "DEVANLAY PERU", MessageBoxButtons.OK, (MessageBoxIcon)icono);
        }

        private void ValidarLogin()
        {
            if (txt_user.Text == "")
            {
                Mensajes("!Por favor ingrese el usuario¡", 64);
                txt_user.Focus();
                return;
            }
            if (txt_pass.Password == "")
            {
                Mensajes("!Por favor ingrese la contraseña¡", 64);
                txt_pass.Focus();
                return;
            }
            if (txt_user.Text != usuario)
            {
                Mensajes("Usuario invalido", 16);
                txt_user.Focus();
                return;
            }
            if (txt_pass.Password != password)
            {
                Mensajes("Contraseña invalida", 16);
                txt_pass.Focus();
                return;
            }

            this.Hide();
            from_principal fm_Principal = new from_principal();
            fm_Principal.usuario = usuario;
            fm_Principal.ShowDialog();
            this.Close();
        }
    }
}
