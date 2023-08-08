namespace pry_capa_presentacion.Reportes
{
    partial class from_consulta_linq
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
            this.dgv_consulta_linq = new System.Windows.Forms.DataGridView();
            this.cmb_search = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_limpiar = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta_linq)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_consulta_linq
            // 
            this.dgv_consulta_linq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_consulta_linq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_consulta_linq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta_linq.Location = new System.Drawing.Point(0, 72);
            this.dgv_consulta_linq.Name = "dgv_consulta_linq";
            this.dgv_consulta_linq.Size = new System.Drawing.Size(956, 443);
            this.dgv_consulta_linq.TabIndex = 0;
            // 
            // cmb_search
            // 
            this.cmb_search.BackColor = System.Drawing.Color.Transparent;
            this.cmb_search.BorderColor = System.Drawing.Color.White;
            this.cmb_search.BorderRadius = 6;
            this.cmb_search.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.cmb_search.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmb_search.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_search.ForeColor = System.Drawing.Color.White;
            this.cmb_search.ItemHeight = 30;
            this.cmb_search.Items.AddRange(new object[] {
            "Por Codigo",
            "Por ID Producto",
            "Por ID Proveedor"});
            this.cmb_search.Location = new System.Drawing.Point(90, 19);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(191, 36);
            this.cmb_search.StartIndex = 0;
            this.cmb_search.TabIndex = 91;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Animated = true;
            this.btn_limpiar.BorderRadius = 6;
            this.btn_limpiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_limpiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_limpiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_limpiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_limpiar.FillColor = System.Drawing.Color.Red;
            this.btn_limpiar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(694, 19);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(145, 36);
            this.btn_limpiar.TabIndex = 90;
            this.btn_limpiar.Text = "Limpiar";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 36);
            this.label3.TabIndex = 88;
            this.label3.Text = "Busqueda";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_search
            // 
            this.txt_search.BorderRadius = 6;
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(77)))), ((int)(((byte)(85)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txt_search.ForeColor = System.Drawing.Color.White;
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(298, 19);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "🔍   Buscar";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(376, 36);
            this.txt_search.TabIndex = 87;
            this.txt_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_search_KeyUp);
            // 
            // from_consulta_linq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(956, 515);
            this.Controls.Add(this.cmb_search);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dgv_consulta_linq);
            this.Name = "from_consulta_linq";
            this.Text = "Consulta Almacen LINQ";
            this.Load += new System.EventHandler(this.from_consulta_linq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta_linq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_consulta_linq;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_search;
        private Guna.UI2.WinForms.Guna2Button btn_limpiar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
    }
}