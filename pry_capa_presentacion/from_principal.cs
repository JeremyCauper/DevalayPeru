using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;


namespace pry_capa_presentacion
{
    public partial class from_principal : Form
    {
        public String usuario = "";
        public from_principal()
        {
            InitializeComponent();
        }

        private void from_principal_Load(object sender, EventArgs e)
        {
            lbl_mover_formulario.Text = "Bienvenido " + usuario.ToUpper();
            btn_empleado_Click(sender, e);
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            Selecion_Item(1);
            from_crud_empleado frm_c_empleado = new from_crud_empleado();
            AbrirForm(frm_c_empleado);
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            Selecion_Item(2);
            from_crud_proveedor frm_c_proveedor = new from_crud_proveedor();
            AbrirForm(frm_c_proveedor);
        }
        private void btn_administrador_Click(object sender, EventArgs e)
        {
            Selecion_Item(3);
            from_crud_administrador frm_c_administrador = new from_crud_administrador();
            AbrirForm(frm_c_administrador);
        }

        private void btn_almacen_Click(object sender, EventArgs e)
        {
            Selecion_Item(4);
            AbrirForm(new from_crud_almacen());
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            Selecion_Item(5);
            AbrirForm(new from_crud_producto());
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Selecion_Item(6);
            AbrirForm(new from_crud_cliente());
        }
        private void btn_gerente_Click(object sender, EventArgs e)
        {
            Selecion_Item(7);
            AbrirForm(new from_crud_gerente());
        }
        private void btn_cr_empleado_Click(object sender, EventArgs e)
        {
            Reportes.from_reporte_empleado from_cr_empleado = new Reportes.from_reporte_empleado();
            from_cr_empleado.ShowDialog();
        }
        private void btn_cr_empleado_cod_Click(object sender, EventArgs e)
        {
            Reportes.from_reporte_empleado_cod from_cr_emplado_cod = new Reportes.from_reporte_empleado_cod();
            from_cr_emplado_cod.ShowDialog();
        }
        private void btn_cr_producto_Click(object sender, EventArgs e)
        {
            Reportes.from_reporte_producto_cod from_cr_producto_cod = new Reportes.from_reporte_producto_cod();
            from_cr_producto_cod.ShowDialog();
        }
        private void btn_cr_clientes_Click(object sender, EventArgs e)
        {
            Reportes.from_reporte_cliente_nom from_cr_cliente_nom = new Reportes.from_reporte_cliente_nom();
            from_cr_cliente_nom.ShowDialog();
        }
        private void btn_cr_linq_alc_Click(object sender, EventArgs e)
        {
            Reportes.from_consulta_linq from_linq_almacen = new Reportes.from_consulta_linq();
            from_linq_almacen.ShowDialog();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que desea cerrar DEVANLEY PERU?", "DEVALAY PERU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Selecion_Item(int itm)
        {
            btn_empleado.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 1)? "#343A40" : "#007BFF");
            btn_proveedor.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 2) ? "#343A40" : "#007BFF");
            btn_administrador.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 3) ? "#343A40" : "#007BFF");
            btn_almacen.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 4) ? "#343A40" : "#007BFF");
            btn_producto.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 5) ? "#343A40" : "#007BFF");
            btn_cliente.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 6) ? "#343A40" : "#007BFF");
            btn_gerente.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 7) ? "#343A40" : "#007BFF");
            /*btn_cr_empleado.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 8) ? "#343A40" : "#007BFF");
            btn_cr_empleado_cod.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 9) ? "#343A40" : "#007BFF");
            btn_cr_producto.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 10) ? "#343A40" : "#007BFF");
            btn_cr_clientes.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 11) ? "#343A40" : "#007BFF");
            btn_cr_linq_alc.FillColor = System.Drawing.ColorTranslator.FromHtml((itm == 12) ? "#343A40" : "#007BFF");*/
        }

        public void AbrirForm(Form formulario)
        {
            this.toolStripContainer1.ContentPanel.Controls.Clear();
            formulario.MdiParent = this;
            this.toolStripContainer1.ContentPanel.Controls.Add(formulario);
            formulario.Show();
        }

        private void lbl_mover_formulario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0xA1, 0x2, 0);
        }
        [DllImport("user32.dll")]
        public static extern int ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
