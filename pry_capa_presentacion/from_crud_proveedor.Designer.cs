namespace pry_capa_presentacion
{
    partial class from_crud_proveedor
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
            this.dgv_proveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_conteo = new System.Windows.Forms.Label();
            this.btn_borrar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nuevo = new Guna.UI2.WinForms.Guna2Button();
            this.txt_cod = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_ruc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_rs = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_dir = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_tel = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_proveedor
            // 
            this.dgv_proveedor.AllowUserToAddRows = false;
            this.dgv_proveedor.AllowUserToDeleteRows = false;
            this.dgv_proveedor.AllowUserToOrderColumns = true;
            this.dgv_proveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_proveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_proveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_proveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proveedor.Location = new System.Drawing.Point(17, 361);
            this.dgv_proveedor.Name = "dgv_proveedor";
            this.dgv_proveedor.ReadOnly = true;
            this.dgv_proveedor.Size = new System.Drawing.Size(835, 256);
            this.dgv_proveedor.TabIndex = 9;
            this.dgv_proveedor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_proveedor_CellClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(863, 43);
            this.label1.TabIndex = 60;
            this.label1.Text = "MANTENIMIENTO DE PROVEEDOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 63;
            this.label2.Text = "Codigo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(327, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 30);
            this.label3.TabIndex = 61;
            this.label3.Text = "Razon Social";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 30);
            this.label4.TabIndex = 62;
            this.label4.Text = "E - mail";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 30);
            this.label5.TabIndex = 64;
            this.label5.Text = "Direccion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(561, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 30);
            this.label6.TabIndex = 65;
            this.label6.Text = "Telefono";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_conteo
            // 
            this.lbl_conteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_conteo.AutoSize = true;
            this.lbl_conteo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lbl_conteo.ForeColor = System.Drawing.Color.White;
            this.lbl_conteo.Location = new System.Drawing.Point(14, 651);
            this.lbl_conteo.Name = "lbl_conteo";
            this.lbl_conteo.Size = new System.Drawing.Size(153, 17);
            this.lbl_conteo.TabIndex = 63;
            this.lbl_conteo.Text = "Existen 0 proveedores";
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
            this.btn_borrar.Location = new System.Drawing.Point(752, 320);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(100, 30);
            this.btn_borrar.TabIndex = 8;
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
            this.btn_guardar.Location = new System.Drawing.Point(646, 320);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 30);
            this.btn_guardar.TabIndex = 7;
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
            this.btn_nuevo.Location = new System.Drawing.Point(540, 320);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 30);
            this.btn_nuevo.TabIndex = 6;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
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
            this.txt_cod.Location = new System.Drawing.Point(80, 320);
            this.txt_cod.MaxLength = 5;
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.PasswordChar = '\0';
            this.txt_cod.PlaceholderText = "";
            this.txt_cod.SelectedText = "";
            this.txt_cod.Size = new System.Drawing.Size(100, 30);
            this.txt_cod.TabIndex = 0;
            // 
            // txt_ruc
            // 
            this.txt_ruc.BorderRadius = 6;
            this.txt_ruc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ruc.DefaultText = "";
            this.txt_ruc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ruc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ruc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ruc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ruc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_ruc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ruc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_ruc.ForeColor = System.Drawing.Color.White;
            this.txt_ruc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ruc.Location = new System.Drawing.Point(103, 112);
            this.txt_ruc.MaxLength = 11;
            this.txt_ruc.Name = "txt_ruc";
            this.txt_ruc.PasswordChar = '\0';
            this.txt_ruc.PlaceholderText = "";
            this.txt_ruc.SelectedText = "";
            this.txt_ruc.Size = new System.Drawing.Size(204, 30);
            this.txt_ruc.TabIndex = 1;
            this.txt_ruc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ruc_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 30);
            this.label7.TabIndex = 74;
            this.label7.Text = "Ruc";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_rs
            // 
            this.txt_rs.BorderRadius = 6;
            this.txt_rs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_rs.DefaultText = "";
            this.txt_rs.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_rs.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_rs.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rs.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_rs.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_rs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_rs.ForeColor = System.Drawing.Color.White;
            this.txt_rs.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_rs.Location = new System.Drawing.Point(428, 112);
            this.txt_rs.MaxLength = 255;
            this.txt_rs.Name = "txt_rs";
            this.txt_rs.PasswordChar = '\0';
            this.txt_rs.PlaceholderText = "";
            this.txt_rs.SelectedText = "";
            this.txt_rs.Size = new System.Drawing.Size(424, 30);
            this.txt_rs.TabIndex = 2;
            // 
            // txt_dir
            // 
            this.txt_dir.BorderRadius = 6;
            this.txt_dir.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_dir.DefaultText = "";
            this.txt_dir.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_dir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_dir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dir.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_dir.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_dir.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dir.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_dir.ForeColor = System.Drawing.Color.White;
            this.txt_dir.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_dir.Location = new System.Drawing.Point(103, 167);
            this.txt_dir.MaxLength = 255;
            this.txt_dir.Name = "txt_dir";
            this.txt_dir.PasswordChar = '\0';
            this.txt_dir.PlaceholderText = "";
            this.txt_dir.SelectedText = "";
            this.txt_dir.Size = new System.Drawing.Size(749, 30);
            this.txt_dir.TabIndex = 3;
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
            this.txt_email.ForeColor = System.Drawing.Color.White;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(103, 221);
            this.txt_email.MaxLength = 100;
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(432, 30);
            this.txt_email.TabIndex = 4;
            // 
            // txt_tel
            // 
            this.txt_tel.BorderRadius = 6;
            this.txt_tel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tel.DefaultText = "";
            this.txt_tel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_tel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_tel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_tel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_tel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tel.ForeColor = System.Drawing.Color.White;
            this.txt_tel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_tel.Location = new System.Drawing.Point(638, 221);
            this.txt_tel.MaxLength = 9;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.PasswordChar = '\0';
            this.txt_tel.PlaceholderText = "";
            this.txt_tel.SelectedText = "";
            this.txt_tel.Size = new System.Drawing.Size(214, 30);
            this.txt_tel.TabIndex = 5;
            this.txt_tel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tel_KeyPress);
            // 
            // from_crud_proveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(864, 695);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_dir);
            this.Controls.Add(this.txt_rs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_ruc);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.lbl_conteo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_proveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "from_crud_proveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEVALAY PERU";
            this.Load += new System.EventHandler(this.from_crud_proveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_conteo;
        private Guna.UI2.WinForms.Guna2Button btn_borrar;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2Button btn_nuevo;
        private Guna.UI2.WinForms.Guna2TextBox txt_cod;
        private Guna.UI2.WinForms.Guna2TextBox txt_ruc;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txt_rs;
        private Guna.UI2.WinForms.Guna2TextBox txt_dir;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2TextBox txt_tel;
    }
}