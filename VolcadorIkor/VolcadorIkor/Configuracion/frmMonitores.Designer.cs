namespace VolcadorIkor.Configuracion
{
    partial class frmMonitores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonitores));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBTN_STOP = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBTN_START = new System.Windows.Forms.ToolStripButton();
            this.tsbEstatusDaemon = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericCorreoElectronico = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.timerMonitorConexion = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBTN_STOP_SQL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.TSBTN_START_SQL = new System.Windows.Forms.ToolStripButton();
            this.tsbEstatusDaemon_SQL = new System.Windows.Forms.ToolStripLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGuardar_SQLSERVER = new System.Windows.Forms.Button();
            this.numericCorreoSQL = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.timerMonitorConexionSQL = new System.Windows.Forms.Timer(this.components);
            this.toolStrip2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCorreoElectronico)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCorreoSQL)).BeginInit();
            this.toolStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue1;
            this.toolStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.tsbCerrar});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip2.Size = new System.Drawing.Size(805, 25);
            this.toolStrip2.TabIndex = 6;
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(174, 22);
            this.toolStripLabel3.Text = "Configuración de Monitores <- ";
            // 
            // tsbCerrar
            // 
            this.tsbCerrar.BackColor = System.Drawing.Color.Transparent;
            this.tsbCerrar.BackgroundImage = global::VolcadorIkor.Properties.Resources.delete_32;
            this.tsbCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbCerrar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbCerrar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tsbCerrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCerrar.Name = "tsbCerrar";
            this.tsbCerrar.Size = new System.Drawing.Size(23, 22);
            this.tsbCerrar.Click += new System.EventHandler(this.tsbCerrar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Transparent;
            this.groupBox6.Controls.Add(this.groupBox1);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.Controls.Add(this.numericCorreoElectronico);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.toolStrip1);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(0, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(805, 205);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "-->  MYSQL ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 80);
            this.groupBox1.TabIndex = 94;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Monitor de la conexion ( Activar desde equipo remoto ).";
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue2;
            this.toolStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.toolStripSeparator3,
            this.TSBTN_STOP,
            this.toolStripSeparator5,
            this.TSBTN_START,
            this.tsbEstatusDaemon});
            this.toolStrip3.Location = new System.Drawing.Point(3, 22);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip3.Size = new System.Drawing.Size(793, 55);
            this.toolStrip3.TabIndex = 12;
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
            // 
            // tsbEstatusDaemon
            // 
            this.tsbEstatusDaemon.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEstatusDaemon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsbEstatusDaemon.Name = "tsbEstatusDaemon";
            this.tsbEstatusDaemon.Size = new System.Drawing.Size(0, 52);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(36, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 93;
            this.label1.Text = "-> Minutos";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 92;
            this.button1.Text = "Guard&ar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericCorreoElectronico
            // 
            this.numericCorreoElectronico.Location = new System.Drawing.Point(33, 72);
            this.numericCorreoElectronico.Name = "numericCorreoElectronico";
            this.numericCorreoElectronico.Size = new System.Drawing.Size(120, 20);
            this.numericCorreoElectronico.TabIndex = 91;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(10, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(338, 12);
            this.label15.TabIndex = 90;
            this.label15.Text = "->> Ingrese el tiempo en minutos que el monitor estará verificando";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgDark2;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(799, 25);
            this.toolStrip1.TabIndex = 5;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(373, 22);
            this.toolStripLabel1.Text = "Ejecución del monitor de conexión (correo electrónico) de MYSQL<- ";
            // 
            // timerMonitorConexion
            // 
            this.timerMonitorConexion.Tick += new System.EventHandler(this.OnTimer_timerMonitorConexion_Event);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnGuardar_SQLSERVER);
            this.groupBox2.Controls.Add(this.numericCorreoSQL);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.toolStrip5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 230);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 205);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "-->  SQL-SERVER ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.toolStrip4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 122);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(799, 80);
            this.groupBox3.TabIndex = 94;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Monitor de la conexion ( Activar desde equipo remoto ). ";
            // 
            // toolStrip4
            // 
            this.toolStrip4.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue2;
            this.toolStrip4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.TSBTN_STOP_SQL,
            this.toolStripSeparator6,
            this.TSBTN_START_SQL,
            this.tsbEstatusDaemon_SQL});
            this.toolStrip4.Location = new System.Drawing.Point(3, 22);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip4.Size = new System.Drawing.Size(793, 55);
            this.toolStrip4.TabIndex = 12;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 55);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 55);
            // 
            // TSBTN_STOP_SQL
            // 
            this.TSBTN_STOP_SQL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBTN_STOP_SQL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSBTN_STOP_SQL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TSBTN_STOP_SQL.Image = global::VolcadorIkor.Properties.Resources.stop_481;
            this.TSBTN_STOP_SQL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBTN_STOP_SQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTN_STOP_SQL.Name = "TSBTN_STOP_SQL";
            this.TSBTN_STOP_SQL.Size = new System.Drawing.Size(52, 52);
            this.TSBTN_STOP_SQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBTN_STOP_SQL.Click += new System.EventHandler(this.TSBTN_STOP_SQL_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 55);
            // 
            // TSBTN_START_SQL
            // 
            this.TSBTN_START_SQL.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSBTN_START_SQL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.TSBTN_START_SQL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TSBTN_START_SQL.Image = global::VolcadorIkor.Properties.Resources.start_48_wte;
            this.TSBTN_START_SQL.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.TSBTN_START_SQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSBTN_START_SQL.Name = "TSBTN_START_SQL";
            this.TSBTN_START_SQL.Size = new System.Drawing.Size(52, 52);
            this.TSBTN_START_SQL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TSBTN_START_SQL.Click += new System.EventHandler(this.TSBTN_START_SQL_Click);
            // 
            // tsbEstatusDaemon_SQL
            // 
            this.tsbEstatusDaemon_SQL.Font = new System.Drawing.Font("Segoe UI", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbEstatusDaemon_SQL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tsbEstatusDaemon_SQL.Name = "tsbEstatusDaemon_SQL";
            this.tsbEstatusDaemon_SQL.Size = new System.Drawing.Size(0, 52);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(36, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 93;
            this.label2.Text = "-> Minutos";
            // 
            // btnGuardar_SQLSERVER
            // 
            this.btnGuardar_SQLSERVER.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar_SQLSERVER.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar_SQLSERVER.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar_SQLSERVER.Location = new System.Drawing.Point(273, 84);
            this.btnGuardar_SQLSERVER.Name = "btnGuardar_SQLSERVER";
            this.btnGuardar_SQLSERVER.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar_SQLSERVER.TabIndex = 92;
            this.btnGuardar_SQLSERVER.Text = "Guard&ar";
            this.btnGuardar_SQLSERVER.UseVisualStyleBackColor = false;
            this.btnGuardar_SQLSERVER.Click += new System.EventHandler(this.btnGuardar_SQLSERVER_Click);
            // 
            // numericCorreoSQL
            // 
            this.numericCorreoSQL.Location = new System.Drawing.Point(33, 72);
            this.numericCorreoSQL.Name = "numericCorreoSQL";
            this.numericCorreoSQL.Size = new System.Drawing.Size(120, 20);
            this.numericCorreoSQL.TabIndex = 91;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 12);
            this.label3.TabIndex = 90;
            this.label3.Text = "->> Ingrese el tiempo en minutos que el monitor estará verificando";
            // 
            // toolStrip5
            // 
            this.toolStrip5.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgDark2;
            this.toolStrip5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel4});
            this.toolStrip5.Location = new System.Drawing.Point(3, 16);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip5.Size = new System.Drawing.Size(799, 25);
            this.toolStrip5.TabIndex = 5;
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(383, 22);
            this.toolStripLabel4.Text = "Ejecución del monitor de conexión (correo electrónico) SQL SERVER<- ";
            // 
            // timerMonitorConexionSQL
            // 
            this.timerMonitorConexionSQL.Tick += new System.EventHandler(this.OnTimer_timerMonitorConexion_SQL_Event);
            // 
            // frmMonitores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VolcadorIkor.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(805, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.toolStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMonitores";
            this.Text = "frmMonitores";
            this.Load += new System.EventHandler(this.frmMonitores_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCorreoElectronico)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCorreoSQL)).EndInit();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown numericCorreoElectronico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton TSBTN_STOP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton TSBTN_START;
        private System.Windows.Forms.ToolStripLabel tsbEstatusDaemon;
        private System.Windows.Forms.Timer timerMonitorConexion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton TSBTN_STOP_SQL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton TSBTN_START_SQL;
        private System.Windows.Forms.ToolStripLabel tsbEstatusDaemon_SQL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGuardar_SQLSERVER;
        private System.Windows.Forms.NumericUpDown numericCorreoSQL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.Timer timerMonitorConexionSQL;
    }
}