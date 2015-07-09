namespace VolcadorIkor.SqlServer
{
    partial class frmProcesarDATs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProcesarDATs));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.TSL_TITTLE = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.dlAbrir = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnAutomatico = new System.Windows.Forms.RadioButton();
            this.rbtnManual = new System.Windows.Forms.RadioButton();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.panelManual = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.uctrlTablaConFiltroResultados = new VolcadorIkor.uctrlTablaConFiltro();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbProcesar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLimpiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSeleccionarArchivos = new System.Windows.Forms.Button();
            this.txtArchivo = new System.Windows.Forms.TextBox();
            this.panelAutomatico = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.uctrlTablaConFiltroResultadosAuto = new VolcadorIkor.uctrlTablaConFiltro();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBTN_STOP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBTN_START = new System.Windows.Forms.ToolStripButton();
            this.tsbEstatusDaemon = new System.Windows.Forms.ToolStripLabel();
            this.timerMonitorConexion = new System.Windows.Forms.Timer(this.components);
            this.tspTittle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelManual.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panelAutomatico.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tspTittle
            // 
            this.tspTittle.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue1;
            this.tspTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspTittle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTittle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSL_TITTLE,
            this.tsbCerrar});
            this.tspTittle.Location = new System.Drawing.Point(0, 0);
            this.tspTittle.Name = "tspTittle";
            this.tspTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspTittle.Size = new System.Drawing.Size(818, 25);
            this.tspTittle.TabIndex = 1;
            // 
            // TSL_TITTLE
            // 
            this.TSL_TITTLE.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_TITTLE.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSL_TITTLE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TSL_TITTLE.Name = "TSL_TITTLE";
            this.TSL_TITTLE.Size = new System.Drawing.Size(331, 22);
            this.TSL_TITTLE.Text = "  Procesar DATs Y XMLs - Servidor SQL SERVER <- ";
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
            // dlAbrir
            // 
            this.dlAbrir.FileName = "openFileDialog1";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtnAutomatico);
            this.groupBox1.Controls.Add(this.rbtnManual);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 41);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione el modo ->>";
            // 
            // rbtnAutomatico
            // 
            this.rbtnAutomatico.AutoSize = true;
            this.rbtnAutomatico.Location = new System.Drawing.Point(120, 18);
            this.rbtnAutomatico.Name = "rbtnAutomatico";
            this.rbtnAutomatico.Size = new System.Drawing.Size(78, 17);
            this.rbtnAutomatico.TabIndex = 1;
            this.rbtnAutomatico.TabStop = true;
            this.rbtnAutomatico.Text = "Automatico";
            this.rbtnAutomatico.UseVisualStyleBackColor = true;
            this.rbtnAutomatico.CheckedChanged += new System.EventHandler(this.rbtnAutomatico_CheckedChanged);
            // 
            // rbtnManual
            // 
            this.rbtnManual.AutoSize = true;
            this.rbtnManual.Location = new System.Drawing.Point(29, 18);
            this.rbtnManual.Name = "rbtnManual";
            this.rbtnManual.Size = new System.Drawing.Size(60, 17);
            this.rbtnManual.TabIndex = 0;
            this.rbtnManual.TabStop = true;
            this.rbtnManual.Text = "Manual";
            this.rbtnManual.UseVisualStyleBackColor = true;
            this.rbtnManual.CheckedChanged += new System.EventHandler(this.rbtnManual_CheckedChanged);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue1;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(766, 3);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.miniToolStrip.Size = new System.Drawing.Size(813, 25);
            this.miniToolStrip.TabIndex = 10;
            // 
            // panelManual
            // 
            this.panelManual.BackColor = System.Drawing.Color.Transparent;
            this.panelManual.Controls.Add(this.groupBox2);
            this.panelManual.Controls.Add(this.groupBox4);
            this.panelManual.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManual.Location = new System.Drawing.Point(0, 66);
            this.panelManual.Name = "panelManual";
            this.panelManual.Size = new System.Drawing.Size(818, 416);
            this.panelManual.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.toolStrip2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 356);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.uctrlTablaConFiltroResultados);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 41);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(812, 312);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bitácora del proceso ";
            // 
            // uctrlTablaConFiltroResultados
            // 
            this.uctrlTablaConFiltroResultados.bContador = true;
            this.uctrlTablaConFiltroResultados.bFiltro = true;
            this.uctrlTablaConFiltroResultados.bMostrarGrip = true;
            this.uctrlTablaConFiltroResultados.bTabStopFiltros = true;
            this.uctrlTablaConFiltroResultados.DataSource = null;
            this.uctrlTablaConFiltroResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctrlTablaConFiltroResultados.dtrAgregarFila = null;
            this.uctrlTablaConFiltroResultados.Location = new System.Drawing.Point(3, 16);
            this.uctrlTablaConFiltroResultados.Name = "uctrlTablaConFiltroResultados";
            this.uctrlTablaConFiltroResultados.Size = new System.Drawing.Size(806, 293);
            this.uctrlTablaConFiltroResultados.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue1;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbProcesar,
            this.toolStripSeparator1,
            this.tsbLimpiar,
            this.toolStripSeparator2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(812, 25);
            this.toolStrip2.TabIndex = 10;
            // 
            // tsbProcesar
            // 
            this.tsbProcesar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbProcesar.BackColor = System.Drawing.Color.Transparent;
            this.tsbProcesar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbProcesar.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbProcesar.ForeColor = System.Drawing.Color.White;
            this.tsbProcesar.Image = global::VolcadorIkor.Properties.Resources.accept_database_32;
            this.tsbProcesar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProcesar.Name = "tsbProcesar";
            this.tsbProcesar.Size = new System.Drawing.Size(121, 22);
            this.tsbProcesar.Text = "Procesar Archivos";
            this.tsbProcesar.ToolTipText = "Procesar Archivos";
            this.tsbProcesar.Click += new System.EventHandler(this.tsbProcesar_Click);
            this.tsbProcesar.MouseLeave += new System.EventHandler(this.mouseFueraControl);
            this.tsbProcesar.MouseHover += new System.EventHandler(this.mouseSobreControl);
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
            this.tsbLimpiar.MouseLeave += new System.EventHandler(this.mouseFueraControl);
            this.tsbLimpiar.MouseHover += new System.EventHandler(this.mouseSobreControl);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.btnSeleccionarArchivos);
            this.groupBox4.Controls.Add(this.txtArchivo);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(818, 60);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Seleccione su(s) archivo(s) ";
            // 
            // btnSeleccionarArchivos
            // 
            this.btnSeleccionarArchivos.Image = global::VolcadorIkor.Properties.Resources.google_web_search_32;
            this.btnSeleccionarArchivos.Location = new System.Drawing.Point(442, 11);
            this.btnSeleccionarArchivos.Name = "btnSeleccionarArchivos";
            this.btnSeleccionarArchivos.Size = new System.Drawing.Size(40, 40);
            this.btnSeleccionarArchivos.TabIndex = 9;
            this.btnSeleccionarArchivos.UseVisualStyleBackColor = true;
            this.btnSeleccionarArchivos.Click += new System.EventHandler(this.btnSeleccionarArchivos_Click);
            // 
            // txtArchivo
            // 
            this.txtArchivo.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtArchivo.Enabled = false;
            this.txtArchivo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtArchivo.Location = new System.Drawing.Point(7, 22);
            this.txtArchivo.Name = "txtArchivo";
            this.txtArchivo.Size = new System.Drawing.Size(430, 20);
            this.txtArchivo.TabIndex = 3;
            // 
            // panelAutomatico
            // 
            this.panelAutomatico.BackColor = System.Drawing.Color.Transparent;
            this.panelAutomatico.Controls.Add(this.groupBox6);
            this.panelAutomatico.Controls.Add(this.groupBox5);
            this.panelAutomatico.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAutomatico.Location = new System.Drawing.Point(0, 482);
            this.panelAutomatico.Name = "panelAutomatico";
            this.panelAutomatico.Size = new System.Drawing.Size(818, 389);
            this.panelAutomatico.TabIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.uctrlTablaConFiltroResultadosAuto);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(0, 74);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(818, 315);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Bitácora del proceso ";
            // 
            // uctrlTablaConFiltroResultadosAuto
            // 
            this.uctrlTablaConFiltroResultadosAuto.bContador = true;
            this.uctrlTablaConFiltroResultadosAuto.bFiltro = true;
            this.uctrlTablaConFiltroResultadosAuto.bMostrarGrip = true;
            this.uctrlTablaConFiltroResultadosAuto.bTabStopFiltros = true;
            this.uctrlTablaConFiltroResultadosAuto.DataSource = null;
            this.uctrlTablaConFiltroResultadosAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctrlTablaConFiltroResultadosAuto.dtrAgregarFila = null;
            this.uctrlTablaConFiltroResultadosAuto.Location = new System.Drawing.Point(3, 16);
            this.uctrlTablaConFiltroResultadosAuto.Name = "uctrlTablaConFiltroResultadosAuto";
            this.uctrlTablaConFiltroResultadosAuto.Size = new System.Drawing.Size(812, 296);
            this.uctrlTablaConFiltroResultadosAuto.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.toolStrip1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(818, 74);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Opciones del modo automatico ->>";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue1;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.toolStripSeparator3,
            this.TSBTN_STOP,
            this.toolStripSeparator5,
            this.TSBTN_START,
            this.tsbEstatusDaemon});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(812, 55);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.MouseLeave += new System.EventHandler(this.mouseFueraControl);
            this.toolStrip1.MouseHover += new System.EventHandler(this.mouseSobreControl);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 55);
            // 
            // TSBTN_STOP
            // 
            this.TSBTN_STOP.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBTN_STOP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSBTN_STOP.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TSBTN_STOP.Image = global::VolcadorIkor.Properties.Resources.stop_481;
            this.TSBTN_STOP.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBTN_STOP.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTN_STOP.Name = "TSBTN_STOP";
            this.TSBTN_STOP.Size = new System.Drawing.Size(52, 52);
            this.TSBTN_STOP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBTN_STOP.Click += new System.EventHandler(this.TSBTN_STOP_Click);
            this.TSBTN_STOP.MouseLeave += new System.EventHandler(this.mouseFueraControl);
            this.TSBTN_STOP.MouseHover += new System.EventHandler(this.mouseSobreControl);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 55);
            // 
            // TSBTN_START
            // 
            this.TSBTN_START.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBTN_START.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSBTN_START.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSBTN_START.Image = global::VolcadorIkor.Properties.Resources.start_48_wte;
            this.TSBTN_START.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBTN_START.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTN_START.Name = "TSBTN_START";
            this.TSBTN_START.Size = new System.Drawing.Size(52, 52);
            this.TSBTN_START.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBTN_START.Click += new System.EventHandler(this.TSBTN_START_Click);
            this.TSBTN_START.MouseLeave += new System.EventHandler(this.mouseFueraControl);
            this.TSBTN_START.MouseHover += new System.EventHandler(this.mouseSobreControl);
            // 
            // tsbEstatusDaemon
            // 
            this.tsbEstatusDaemon.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEstatusDaemon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsbEstatusDaemon.Name = "tsbEstatusDaemon";
            this.tsbEstatusDaemon.Size = new System.Drawing.Size(0, 52);
            // 
            // timerMonitorConexion
            // 
            this.timerMonitorConexion.Interval = 240000;
            this.timerMonitorConexion.Tick += new System.EventHandler(this.OnTimer_timerMonitorConexion_Event);
            // 
            // frmProcesarDATs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VolcadorIkor.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(818, 846);
            this.Controls.Add(this.panelAutomatico);
            this.Controls.Add(this.panelManual);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tspTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProcesarDATs";
            this.Text = "Configuración del sistema";
            this.Load += new System.EventHandler(this.frmConfiguracion_Load);
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelManual.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panelAutomatico.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel TSL_TITTLE;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.OpenFileDialog dlAbrir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnAutomatico;
        private System.Windows.Forms.RadioButton rbtnManual;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.Panel panelManual;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private uctrlTablaConFiltro uctrlTablaConFiltroResultados;
        private System.Windows.Forms.ToolStrip toolStrip2;
        public System.Windows.Forms.ToolStripButton tsbProcesar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        public System.Windows.Forms.ToolStripButton tsbLimpiar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSeleccionarArchivos;
        private System.Windows.Forms.TextBox txtArchivo;
        private System.Windows.Forms.Panel panelAutomatico;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSBTN_STOP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton TSBTN_START;
        private System.Windows.Forms.GroupBox groupBox6;
        private uctrlTablaConFiltro uctrlTablaConFiltroResultadosAuto;
        private System.Windows.Forms.ToolStripLabel tsbEstatusDaemon;
        private System.Windows.Forms.Timer timerMonitorConexion;
    }
}