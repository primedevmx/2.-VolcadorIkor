namespace VolcadorIkor
{
    partial class uctrlTablaConFiltro
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uctrlTablaConFiltro));
            this.gridDatos = new System.Windows.Forms.DataGridView();
            this.copiarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContador = new System.Windows.Forms.Panel();
            this.lblContador = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolBusqueda = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).BeginInit();
            this.pnlContador.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridDatos
            // 
            this.gridDatos.AllowUserToAddRows = false;
            this.gridDatos.AllowUserToDeleteRows = false;
            this.gridDatos.AllowUserToOrderColumns = true;
            this.gridDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gridDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.gridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDatos.Location = new System.Drawing.Point(0, 43);
            this.gridDatos.Name = "gridDatos";
            this.gridDatos.ReadOnly = true;
            this.gridDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDatos.Size = new System.Drawing.Size(631, 346);
            this.gridDatos.TabIndex = 1;
            this.gridDatos.TabStop = false;
            this.gridDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDatos_CellContentClick);
            this.gridDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDatos_CellDoubleClick);
            this.gridDatos.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDatos_CellEndEdit);
            this.gridDatos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDatos_ColumnHeaderMouseClick);
            this.gridDatos.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridDatos_ColumnHeaderMouseDoubleClick);
            this.gridDatos.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.gridDatos_DataError);
            this.gridDatos.SelectionChanged += new System.EventHandler(this.gridDatos_SelectionChanged);
            this.gridDatos.DoubleClick += new System.EventHandler(this.gridDatos_DoubleClick);
            this.gridDatos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridDatos_KeyPress);
            // 
            // copiarDatosToolStripMenuItem
            // 
            this.copiarDatosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarDatosToolStripMenuItem.Image")));
            this.copiarDatosToolStripMenuItem.Name = "copiarDatosToolStripMenuItem";
            this.copiarDatosToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.copiarDatosToolStripMenuItem.Text = "Copiar";
            this.copiarDatosToolStripMenuItem.Click += new System.EventHandler(this.copiarDatosToolStripMenuItem_Click);
            // 
            // pnlContador
            // 
            this.pnlContador.BackgroundImage = global::VolcadorIkor.Properties.Resources.fondoIKOR1;
            this.pnlContador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlContador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContador.Controls.Add(this.lblContador);
            this.pnlContador.Controls.Add(this.label2);
            this.pnlContador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContador.Location = new System.Drawing.Point(0, 25);
            this.pnlContador.Name = "pnlContador";
            this.pnlContador.Size = new System.Drawing.Size(631, 18);
            this.pnlContador.TabIndex = 4;
            // 
            // lblContador
            // 
            this.lblContador.BackColor = System.Drawing.Color.Transparent;
            this.lblContador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(68, 0);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(561, 16);
            this.lblContador.TabIndex = 0;
            this.lblContador.Text = "lblContador";
            this.lblContador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Registros:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolBusqueda
            // 
            this.toolBusqueda.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgDark2;
            this.toolBusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolBusqueda.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBusqueda.Location = new System.Drawing.Point(0, 0);
            this.toolBusqueda.Name = "toolBusqueda";
            this.toolBusqueda.Size = new System.Drawing.Size(631, 25);
            this.toolBusqueda.TabIndex = 1;
            this.toolBusqueda.Text = "toolStrip1";
            // 
            // uctrlTablaConFiltro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridDatos);
            this.Controls.Add(this.pnlContador);
            this.Controls.Add(this.toolBusqueda);
            this.Name = "uctrlTablaConFiltro";
            this.Size = new System.Drawing.Size(631, 389);
            ((System.ComponentModel.ISupportInitialize)(this.gridDatos)).EndInit();
            this.pnlContador.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView gridDatos;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copiarDatosToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContador;
        private System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ToolStrip toolBusqueda;
    }
}
