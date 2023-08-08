namespace pry_capa_presentacion.Reportes
{
    partial class from_reporte_empleado
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
            this.crv_empleado = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_empleado
            // 
            this.crv_empleado.ActiveViewIndex = -1;
            this.crv_empleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_empleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_empleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_empleado.Location = new System.Drawing.Point(0, 0);
            this.crv_empleado.Name = "crv_empleado";
            this.crv_empleado.Size = new System.Drawing.Size(884, 661);
            this.crv_empleado.TabIndex = 0;
            this.crv_empleado.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // from_reporte_empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.crv_empleado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "from_reporte_empleado";
            this.ShowIcon = false;
            this.Text = "Reporte de empleados";
            this.Load += new System.EventHandler(this.from_reporte_empleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_empleado;
    }
}