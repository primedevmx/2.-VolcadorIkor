namespace VolcadorIkor.SqlServer
{
    partial class frmMtoStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMtoStatus));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.TSL_TITTLE = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAR = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.tsbModificar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.uctrlTablaConFiltroStatus = new VolcadorIkor.uctrlTablaConFiltro();
            this.tspTittle.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspTittle
            // 
            this.tspTittle.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue2;
            this.tspTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspTittle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTittle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSL_TITTLE,
            this.tsbCerrar});
            this.tspTittle.Location = new System.Drawing.Point(0, 0);
            this.tspTittle.Name = "tspTittle";
            this.tspTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspTittle.Size = new System.Drawing.Size(728, 25);
            this.tspTittle.TabIndex = 2;
            // 
            // TSL_TITTLE
            // 
            this.TSL_TITTLE.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_TITTLE.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSL_TITTLE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TSL_TITTLE.Name = "TSL_TITTLE";
            this.TSL_TITTLE.Size = new System.Drawing.Size(298, 22);
            this.TSL_TITTLE.Text = "  Mantenimiento de los estatus de pruebas <- ";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbCerrar.Image = global::VolcadorIkor.Properties.Resources.delete_32;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(23, 22);
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.chkAR);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtDescripcion);
            this.groupBox4.Controls.Add(this.txtEstatus);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(728, 159);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Location = new System.Drawing.Point(111, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "-> Determina si el estatus es candidato para ser sometido a pruebas";
            // 
            // chkAR
            // 
            this.chkAR.AutoSize = true;
            this.chkAR.Location = new System.Drawing.Point(97, 20);
            this.chkAR.Name = "chkAR";
            this.chkAR.Size = new System.Drawing.Size(15, 14);
            this.chkAR.TabIndex = 13;
            this.chkAR.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Aplica Reglas?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Estatus";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtDescripcion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDescripcion.Location = new System.Drawing.Point(97, 83);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(513, 56);
            this.txtDescripcion.TabIndex = 5;
            // 
            // txtEstatus
            // 
            this.txtEstatus.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEstatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtEstatus.Location = new System.Drawing.Point(97, 49);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(340, 20);
            this.txtEstatus.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.uctrlTablaConFiltroStatus);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 260);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar doble click al registro para modificar ->>";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue1;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbGuardar,
            this.tsbModificar,
            this.tsbEliminar,
            this.toolStripSeparator1,
            this.tsbLimpiar,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 184);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(728, 25);
            this.toolStrip2.TabIndex = 11;
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbGuardar.BackColor = System.Drawing.Color.Transparent;
            this.tsbGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbGuardar.ForeColor = System.Drawing.Color.White;
            this.tsbGuardar.Image = global::VolcadorIkor.Properties.Resources.accept_database_32;
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(69, 22);
            this.tsbGuardar.Text = "Guardar";
            this.tsbGuardar.ToolTipText = "Procesar Archivos";
            this.tsbGuardar.Click += new System.EventHandler(this.tsbGuardar_Click);
            // 
            // tsbModificar
            // 
            this.tsbModificar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbModificar.BackColor = System.Drawing.Color.Transparent;
            this.tsbModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbModificar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbModificar.ForeColor = System.Drawing.Color.White;
            this.tsbModificar.Image = global::VolcadorIkor.Properties.Resources.add_database_32;
            this.tsbModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModificar.Name = "tsbModificar";
            this.tsbModificar.Size = new System.Drawing.Size(78, 22);
            this.tsbModificar.Text = "Modificar";
            this.tsbModificar.ToolTipText = "Procesar Archivos";
            this.tsbModificar.Visible = false;
            this.tsbModificar.Click += new System.EventHandler(this.tsbModificar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbEliminar.BackColor = System.Drawing.Color.Transparent;
            this.tsbEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbEliminar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEliminar.ForeColor = System.Drawing.Color.White;
            this.tsbEliminar.Image = global::VolcadorIkor.Properties.Resources.delete_32;
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(70, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.ToolTipText = "Procesar Archivos";
            this.tsbEliminar.Visible = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLimpiar
            // 
            this.tsbLimpiar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.tsbLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbLimpiar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbLimpiar.ForeColor = System.Drawing.Color.White;
            this.tsbLimpiar.Image = global::VolcadorIkor.Properties.Resources.monitor_32;
            this.tsbLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLimpiar.Name = "tsbLimpiar";
            this.tsbLimpiar.Size = new System.Drawing.Size(112, 22);
            this.tsbLimpiar.Text = "Limpiar Pantalla";
            this.tsbLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.tsbLimpiar.ToolTipText = "Limpiar Pantalla";
            this.tsbLimpiar.Click += new System.EventHandler(this.tsbLimpiar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // uctrlTablaConFiltroStatus
            // 
            this.uctrlTablaConFiltroStatus.bContador = false;
            this.uctrlTablaConFiltroStatus.bFiltro = true;
            this.uctrlTablaConFiltroStatus.bMostrarGrip = false;
            this.uctrlTablaConFiltroStatus.bTabStopFiltros = false;
            this.uctrlTablaConFiltroStatus.DataSource = null;
            this.uctrlTablaConFiltroStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctrlTablaConFiltroStatus.dtrAgregarFila = null;
            this.uctrlTablaConFiltroStatus.Location = new System.Drawing.Point(3, 16);
            this.uctrlTablaConFiltroStatus.Name = "uctrlTablaConFiltroStatus";
            this.uctrlTablaConFiltroStatus.Size = new System.Drawing.Size(722, 241);
            this.uctrlTablaConFiltroStatus.TabIndex = 0;
            this.uctrlTablaConFiltroStatus.GridDatos_DoubleClick += new VolcadorIkor.uctrlTablaConFiltro.GridDatos_DoubleClickEventHandler(this.uctrlTablaConFiltroStatus_GridDatos_DoubleClick);
            // 
            // frmMtoStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VolcadorIkor.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(728, 473);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tspTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMtoStatus";
            this.Text = "frmMtoStatus";
            this.Load += new System.EventHandler(this.frmMtoStatus_Load);
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel TSL_TITTLE;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private uctrlTablaConFiltro uctrlTablaConFiltroStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkAR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tsbLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton tsbEliminar;
        public System.Windows.Forms.ToolStripButton tsbModificar;
    }
}