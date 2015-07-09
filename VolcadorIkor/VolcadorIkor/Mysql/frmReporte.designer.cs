namespace VolcadorIkor.Mysql
{
    partial class frmReporte
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            this.pnlAccion = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbBitacora = new System.Windows.Forms.ToolStripButton();
            this.Seleccionar = new System.Windows.Forms.ToolStripButton();
            this.Cancelar = new System.Windows.Forms.ToolStripButton();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.GrdDatos = new VolcadorIkor.uctrlTablaConFiltro();
            this.pnlAccion.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAccion
            // 
            this.pnlAccion.Controls.Add(this.toolStrip2);
            this.pnlAccion.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAccion.Location = new System.Drawing.Point(0, 0);
            this.pnlAccion.Name = "pnlAccion";
            this.pnlAccion.Size = new System.Drawing.Size(501, 27);
            this.pnlAccion.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue1;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbBitacora,
            this.Seleccionar,
            this.Cancelar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(501, 27);
            this.toolStrip2.TabIndex = 33;
            this.toolStrip2.Text = "toolStrip2";
            this.toolStrip2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsulta_KeyUp);
            // 
            // tsbBitacora
            // 
            this.tsbBitacora.BackColor = System.Drawing.Color.Transparent;
            this.tsbBitacora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbBitacora.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbBitacora.ForeColor = System.Drawing.Color.White;
            this.tsbBitacora.Image = global::VolcadorIkor.Properties.Resources.View_Details_32;
            this.tsbBitacora.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBitacora.Name = "tsbBitacora";
            this.tsbBitacora.Size = new System.Drawing.Size(235, 24);
            this.tsbBitacora.Text = "Cargar registros tblBitacoraProceso ->>";
            this.tsbBitacora.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbBitacora.ToolTipText = "Seleccionar";
            this.tsbBitacora.Click += new System.EventHandler(this.tsbBitacora_Click);
            // 
            // Seleccionar
            // 
            this.Seleccionar.BackColor = System.Drawing.Color.Transparent;
            this.Seleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Seleccionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seleccionar.ForeColor = System.Drawing.Color.White;
            this.Seleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(192, 24);
            this.Seleccionar.Text = "Cargar registros tblInfoPCB ->>";
            this.Seleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Seleccionar.ToolTipText = "Seleccionar";
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Cancelar.BackgroundImage = global::VolcadorIkor.Properties.Resources.delete_32;
            this.Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Cancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(23, 24);
            this.Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // pnlGrid
            // 
            this.pnlGrid.Controls.Add(this.GrdDatos);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(0, 27);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Size = new System.Drawing.Size(501, 187);
            this.pnlGrid.TabIndex = 1;
            // 
            // GrdDatos
            // 
            this.GrdDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrdDatos.bContador = true;
            this.GrdDatos.bFiltro = true;
            this.GrdDatos.bMostrarGrip = true;
            this.GrdDatos.bTabStopFiltros = false;
            this.GrdDatos.DataSource = null;
            this.GrdDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrdDatos.dtrAgregarFila = null;
            this.GrdDatos.Location = new System.Drawing.Point(0, 0);
            this.GrdDatos.Name = "GrdDatos";
            this.GrdDatos.Size = new System.Drawing.Size(501, 187);
            this.GrdDatos.TabIndex = 0;
            this.GrdDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsulta_KeyUp);
            // 
            // frmReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 214);
            this.Controls.Add(this.pnlGrid);
            this.Controls.Add(this.pnlAccion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporte";
            this.Text = " Consulta";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmConsulta_KeyUp);
            this.pnlAccion.ResumeLayout(false);
            this.pnlAccion.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAccion;
        private System.Windows.Forms.Panel pnlGrid;
        public VolcadorIkor.uctrlTablaConFiltro GrdDatos;
        public System.Windows.Forms.ToolStripButton Seleccionar;
        public System.Windows.Forms.ToolStripButton Cancelar;
        public System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton tsbBitacora;
    }
}