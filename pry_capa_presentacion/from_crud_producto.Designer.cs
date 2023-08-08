namespace pry_capa_presentacion
{
    partial class from_crud_producto
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
            this.txt_producto = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_borrar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_nuevo = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_conteo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_producto = new System.Windows.Forms.DataGridView();
            this.txt_cod = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_registro = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_producto
            // 
            this.txt_producto.BorderRadius = 6;
            this.txt_producto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_producto.DefaultText = "";
            this.txt_producto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_producto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_producto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_producto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_producto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_producto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_producto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_producto.ForeColor = System.Drawing.Color.White;
            this.txt_producto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_producto.Location = new System.Drawing.Point(98, 106);
            this.txt_producto.MaxLength = 150;
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.PasswordChar = '\0';
            this.txt_producto.PlaceholderText = "";
            this.txt_producto.SelectedText = "";
            this.txt_producto.Size = new System.Drawing.Size(753, 40);
            this.txt_producto.TabIndex = 68;
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
            this.btn_borrar.Location = new System.Drawing.Point(751, 256);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(100, 30);
            this.btn_borrar.TabIndex = 74;
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
            this.btn_guardar.Location = new System.Drawing.Point(645, 256);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 30);
            this.btn_guardar.TabIndex = 73;
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
            this.btn_nuevo.Location = new System.Drawing.Point(539, 256);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(100, 30);
            this.btn_nuevo.TabIndex = 72;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // lbl_conteo
            // 
            this.lbl_conteo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_conteo.AutoSize = true;
            this.lbl_conteo.Font = new System.Drawing.Font("Arial", 11.25F);
            this.lbl_conteo.ForeColor = System.Drawing.Color.White;
            this.lbl_conteo.Location = new System.Drawing.Point(13, 653);
            this.lbl_conteo.Name = "lbl_conteo";
            this.lbl_conteo.Size = new System.Drawing.Size(153, 17);
            this.lbl_conteo.TabIndex = 79;
            this.lbl_conteo.Text = "Existen 0 proveedores";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 40);
            this.label3.TabIndex = 77;
            this.label3.Text = "Producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label1.TabIndex = 76;
            this.label1.Text = "MANTENIMIENTO DE PRODUCTO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_producto
            // 
            this.dgv_producto.AllowUserToAddRows = false;
            this.dgv_producto.AllowUserToDeleteRows = false;
            this.dgv_producto.AllowUserToOrderColumns = true;
            this.dgv_producto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_producto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_producto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgv_producto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.dgv_producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_producto.Location = new System.Drawing.Point(16, 300);
            this.dgv_producto.Name = "dgv_producto";
            this.dgv_producto.ReadOnly = true;
            this.dgv_producto.Size = new System.Drawing.Size(835, 317);
            this.dgv_producto.TabIndex = 75;
            this.dgv_producto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_producto_CellClick);
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
            this.txt_cod.Location = new System.Drawing.Point(79, 256);
            this.txt_cod.MaxLength = 5;
            this.txt_cod.Name = "txt_cod";
            this.txt_cod.PasswordChar = '\0';
            this.txt_cod.PlaceholderText = "";
            this.txt_cod.SelectedText = "";
            this.txt_cod.Size = new System.Drawing.Size(139, 30);
            this.txt_cod.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 30);
            this.label2.TabIndex = 81;
            this.label2.Text = "Codigo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // date_registro
            // 
            this.date_registro.BorderColor = System.Drawing.Color.White;
            this.date_registro.BorderRadius = 6;
            this.date_registro.BorderThickness = 1;
            this.date_registro.Checked = true;
            this.date_registro.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.date_registro.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.date_registro.ForeColor = System.Drawing.Color.White;
            this.date_registro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_registro.Location = new System.Drawing.Point(658, 167);
            this.date_registro.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.date_registro.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.date_registro.Name = "date_registro";
            this.date_registro.Size = new System.Drawing.Size(193, 30);
            this.date_registro.TabIndex = 89;
            this.date_registro.Value = new System.DateTime(2023, 5, 19, 0, 26, 24, 286);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(547, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 88;
            this.label5.Text = "Fec. Registro";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // from_crud_producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(864, 695);
            this.Controls.Add(this.date_registro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_cod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_producto);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.lbl_conteo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "from_crud_producto";
            this.Text = "from_crud_producto";
            this.Load += new System.EventHandler(this.from_crud_producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_producto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txt_producto;
        private Guna.UI2.WinForms.Guna2Button btn_borrar;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2Button btn_nuevo;
        private System.Windows.Forms.Label lbl_conteo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_producto;
        private Guna.UI2.WinForms.Guna2TextBox txt_cod;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_registro;
        private System.Windows.Forms.Label label5;
    }
}