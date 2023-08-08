namespace pry_capa_presentacion
{
    partial class from_crud_cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_cod = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_borrar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nuevo = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_conteo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_cliente = new System.Windows.Forms.DataGridView();
            this.txt_direccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_documento = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dp_nacimiento = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_telefono = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_appaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_apmaterno = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cod
            // 
            this.txt_cod.BorderRadius = 6;
            this.txt_cod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cod.DefaultText = "";
            this.txt_cod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_cod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_cod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_cod.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_cod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cod.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cod.ForeColor = System.Drawing.Color.White;
            this.txt_cod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_cod.Location = new System.Drawing.Point(78, 293);
            this.txt_cod.MaxLength = 5;
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.PasswordChar = '\0';
            this.txt_cod.PlaceholderText = "";
            this.txt_cod.SelectedText = "";
            this.txt_cod.Size = new System.Drawing.Size(147, 30);
            this.txt_cod.TabIndex = 98;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 99;
            this.label2.Text = "Codigo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_borrar
            // 
            this.btn_borrar.Animated = true;
            this.btn_borrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_borrar.BorderRadius = 10;
            this.btn_borrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_borrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_borrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_borrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_borrar.Enabled = false;
            this.btn_borrar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btn_borrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_borrar.ForeColor = System.Drawing.Color.White;
            this.btn_borrar.Image = global::pry_capa_presentacion.Properties.Resources.basura_white;
            this.btn_borrar.Location = new System.Drawing.Point(747, 293);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(100, 30);
            this.btn_borrar.TabIndex = 93;
            this.btn_borrar.Text = "Borrar";
            this.btn_borrar.Click += new System.EventHandler(this.btn_borrar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Animated = true;
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BorderRadius = 10;
            this.btn_guardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardar.Enabled = false;
            this.btn_guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Image = global::pry_capa_presentacion.Properties.Resources.disco_white;
            this.btn_guardar.Location = new System.Drawing.Point(641, 293);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 30);
            this.btn_guardar.TabIndex = 92;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Animated = true;
            this.btn_nuevo.BackColor = System.Drawing.Color.Transparent;
            this.btn_nuevo.BorderRadius = 10;
            this.btn_nuevo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_nuevo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_nuevo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_nuevo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_nuevo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_nuevo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_nuevo.ForeColor = System.Drawing.Color.White;
            this.btn_nuevo.Image = global::pry_capa_presentacion.Properties.Resources.agregar_usuario_white;
            this.btn_nuevo.Location = new System.Drawing.Point(535, 293);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 30);
            this.btn_nuevo.TabIndex = 91;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // lbl_conteo
            // 
            this.lbl_conteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_conteo.AutoSize = true;
            this.lbl_conteo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lbl_conteo.ForeColor = System.Drawing.Color.White;
            this.lbl_conteo.Location = new System.Drawing.Point(12, 652);
            this.lbl_conteo.Name = "lbl_conteo";
            this.lbl_conteo.Size = new System.Drawing.Size(153, 17);
            this.lbl_conteo.TabIndex = 97;
            this.lbl_conteo.Text = "Existen 0 proveedores";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 43);
            this.label1.TabIndex = 95;
            this.label1.Text = "MANTENIMIENTO DE CLIENTE";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_cliente
            // 
            this.dgv_cliente.AllowUserToAddRows = false;
            this.dgv_cliente.AllowUserToDeleteRows = false;
            this.dgv_cliente.AllowUserToOrderColumns = true;
            this.dgv_cliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_cliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.dgv_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cliente.Location = new System.Drawing.Point(15, 334);
            this.dgv_cliente.Name = "dgv_cliente";
            this.dgv_cliente.ReadOnly = true;
            this.dgv_cliente.Size = new System.Drawing.Size(832, 290);
            this.dgv_cliente.TabIndex = 94;
            this.dgv_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cliente_CellClick);
            // 
            // txt_direccion
            // 
            this.txt_direccion.BorderRadius = 6;
            this.txt_direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_direccion.DefaultText = "";
            this.txt_direccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_direccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_direccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_direccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_direccion.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_direccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_direccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_direccion.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_direccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_direccion.Location = new System.Drawing.Point(122, 226);
            this.txt_direccion.MaxLength = 100;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PasswordChar = '\0';
            this.txt_direccion.PlaceholderText = "";
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.Size = new System.Drawing.Size(435, 30);
            this.txt_direccion.TabIndex = 114;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(14, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 30);
            this.label10.TabIndex = 115;
            this.label10.Text = "Direccion";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_documento
            // 
            this.txt_documento.BorderRadius = 6;
            this.txt_documento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_documento.DefaultText = "";
            this.txt_documento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_documento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_documento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_documento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_documento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_documento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_documento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_documento.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_documento.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_documento.Location = new System.Drawing.Point(122, 82);
            this.txt_documento.MaxLength = 20;
            this.txt_documento.Name = "txt_documento";
            this.txt_documento.PasswordChar = '\0';
            this.txt_documento.PlaceholderText = "";
            this.txt_documento.SelectedText = "";
            this.txt_documento.Size = new System.Drawing.Size(213, 30);
            this.txt_documento.TabIndex = 112;
            this.txt_documento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_documento_KeyPress);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(11, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 30);
            this.label9.TabIndex = 113;
            this.label9.Text = "N° documento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(580, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 30);
            this.label8.TabIndex = 111;
            this.label8.Text = "Fec. Nac.";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dp_nacimiento
            // 
            this.dp_nacimiento.BorderColor = System.Drawing.Color.White;
            this.dp_nacimiento.BorderRadius = 6;
            this.dp_nacimiento.BorderThickness = 1;
            this.dp_nacimiento.Checked = true;
            this.dp_nacimiento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.dp_nacimiento.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dp_nacimiento.ForeColor = System.Drawing.SystemColors.Control;
            this.dp_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_nacimiento.Location = new System.Drawing.Point(657, 226);
            this.dp_nacimiento.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dp_nacimiento.MinDate = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            this.dp_nacimiento.Name = "dp_nacimiento";
            this.dp_nacimiento.Size = new System.Drawing.Size(186, 30);
            this.dp_nacimiento.TabIndex = 110;
            this.dp_nacimiento.Value = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // txt_email
            // 
            this.txt_email.BorderRadius = 6;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(122, 180);
            this.txt_email.MaxLength = 100;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(372, 30);
            this.txt_email.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(14, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 30);
            this.label7.TabIndex = 109;
            this.label7.Text = "E-mail";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_telefono
            // 
            this.txt_telefono.BorderRadius = 6;
            this.txt_telefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telefono.DefaultText = "";
            this.txt_telefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_telefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_telefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_telefono.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_telefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telefono.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_telefono.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_telefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_telefono.Location = new System.Drawing.Point(583, 180);
            this.txt_telefono.MaxLength = 9;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.PasswordChar = '\0';
            this.txt_telefono.PlaceholderText = "";
            this.txt_telefono.SelectedText = "";
            this.txt_telefono.Size = new System.Drawing.Size(260, 30);
            this.txt_telefono.TabIndex = 103;
            this.txt_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefono_KeyPress);
            // 
            // txt_appaterno
            // 
            this.txt_appaterno.BorderRadius = 6;
            this.txt_appaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_appaterno.DefaultText = "";
            this.txt_appaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_appaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_appaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_appaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_appaterno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_appaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_appaterno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_appaterno.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_appaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_appaterno.Location = new System.Drawing.Point(122, 132);
            this.txt_appaterno.MaxLength = 30;
            this.txt_appaterno.Name = "txt_appaterno";
            this.txt_appaterno.PasswordChar = '\0';
            this.txt_appaterno.PlaceholderText = "";
            this.txt_appaterno.SelectedText = "";
            this.txt_appaterno.Size = new System.Drawing.Size(289, 30);
            this.txt_appaterno.TabIndex = 101;
            // 
            // txt_apmaterno
            // 
            this.txt_apmaterno.BorderRadius = 6;
            this.txt_apmaterno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_apmaterno.DefaultText = "";
            this.txt_apmaterno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_apmaterno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_apmaterno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_apmaterno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_apmaterno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_apmaterno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_apmaterno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_apmaterno.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_apmaterno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_apmaterno.Location = new System.Drawing.Point(556, 132);
            this.txt_apmaterno.MaxLength = 30;
            this.txt_apmaterno.Name = "txt_apmaterno";
            this.txt_apmaterno.PasswordChar = '\0';
            this.txt_apmaterno.PlaceholderText = "";
            this.txt_apmaterno.SelectedText = "";
            this.txt_apmaterno.Size = new System.Drawing.Size(287, 30);
            this.txt_apmaterno.TabIndex = 102;
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderRadius = 6;
            this.txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.DefaultText = "";
            this.txt_nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nombre.ForeColor = System.Drawing.SystemColors.Control;
            this.txt_nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nombre.Location = new System.Drawing.Point(441, 82);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.PlaceholderText = "";
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.Size = new System.Drawing.Size(402, 30);
            this.txt_nombre.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(512, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 30);
            this.label6.TabIndex = 107;
            this.label6.Text = "Telefono";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(445, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 105;
            this.label5.Text = "Ape. Materno";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 30);
            this.label4.TabIndex = 106;
            this.label4.Text = "Ape. Paterno";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(363, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 30);
            this.label3.TabIndex = 104;
            this.label3.Text = "Nombres";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // from_crud_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(864, 695);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_documento);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dp_nacimiento);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.txt_appaterno);
            this.Controls.Add(this.txt_apmaterno);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.lbl_conteo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_cliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "from_crud_cliente";
            this.Text = "from_crud_cliente";
            this.Load += new System.EventHandler(this.from_crud_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_cod;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_borrar;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2Button btn_nuevo;
        private System.Windows.Forms.Label lbl_conteo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_cliente;
        private Guna.UI2.WinForms.Guna2TextBox txt_direccion;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txt_documento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2DateTimePicker dp_nacimiento;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_telefono;
        private Guna.UI2.WinForms.Guna2TextBox txt_appaterno;
        private Guna.UI2.WinForms.Guna2TextBox txt_apmaterno;
        private Guna.UI2.WinForms.Guna2TextBox txt_nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}