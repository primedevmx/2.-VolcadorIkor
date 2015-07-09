namespace VolcadorIkor.Opcionadores
{
    partial class frmOpcionSql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpcionSql));
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.TSL_TITTLE = new System.Windows.Forms.ToolStripLabel();
            this.tsbCerrar = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServidorSqlServer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcesarXMLs = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.tspTittle.SuspendLayout();
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
            this.tspTittle.Size = new System.Drawing.Size(644, 25);
            this.tspTittle.TabIndex = 5;
            // 
            // TSL_TITTLE
            // 
            this.TSL_TITTLE.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.TSL_TITTLE.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSL_TITTLE.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TSL_TITTLE.Name = "TSL_TITTLE";
            this.TSL_TITTLE.Size = new System.Drawing.Size(259, 22);
            this.TSL_TITTLE.Text = "  Seleccione su opción en Sql Server <- ";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "[Servidor Sql Server]";
            // 
            // btnServidorSqlServer
            // 
            this.btnServidorSqlServer.Image = global::VolcadorIkor.Properties.Resources.data_configuration_128;
            this.btnServidorSqlServer.Location = new System.Drawing.Point(22, 53);
            this.btnServidorSqlServer.Name = "btnServidorSqlServer";
            this.btnServidorSqlServer.Size = new System.Drawing.Size(156, 131);
            this.btnServidorSqlServer.TabIndex = 9;
            this.btnServidorSqlServer.UseVisualStyleBackColor = true;
            this.btnServidorSqlServer.Click += new System.EventHandler(this.btnServidorSqlServer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "[Procesar DATs]";
            // 
            // btnProcesarXMLs
            // 
            this.btnProcesarXMLs.Image = global::VolcadorIkor.Properties.Resources.xls_128;
            this.btnProcesarXMLs.Location = new System.Drawing.Point(238, 53);
            this.btnProcesarXMLs.Name = "btnProcesarXMLs";
            this.btnProcesarXMLs.Size = new System.Drawing.Size(156, 131);
            this.btnProcesarXMLs.TabIndex = 11;
            this.btnProcesarXMLs.UseVisualStyleBackColor = true;
            this.btnProcesarXMLs.Click += new System.EventHandler(this.btnProcesarXMLs_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "[Estatus de Pruebas]";
            // 
            // button1
            // 
            this.button1.Image = global::VolcadorIkor.Properties.Resources.electrical_threshold_128;
            this.button1.Location = new System.Drawing.Point(450, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 131);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "[Consultas]";
            // 
            // btnConsultas
            // 
            this.btnConsultas.Image = global::VolcadorIkor.Properties.Resources.google_blog_search_1282;
            this.btnConsultas.Location = new System.Drawing.Point(22, 230);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(156, 131);
            this.btnConsultas.TabIndex = 15;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // frmOpcionSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VolcadorIkor.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(644, 427);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnProcesarXMLs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnServidorSqlServer);
            this.Controls.Add(this.tspTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmOpcionSql";
            this.Text = "frmOpcionSql";
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel TSL_TITTLE;
        private System.Windows.Forms.ToolStripButton tsbCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServidorSqlServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcesarXMLs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConsultas;
    }
}