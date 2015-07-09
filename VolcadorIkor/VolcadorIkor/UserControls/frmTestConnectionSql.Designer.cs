namespace VolcadorIkor.UserControls
{
    partial class frmTestConectionSql
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTestConectionSql));
            this.gbUsuarioAdmin = new System.Windows.Forms.GroupBox();
            this.labelNombreServer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslConn = new System.Windows.Forms.ToolStripLabel();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.tspTittle = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.gbUsuarioAdmin.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tspTittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsuarioAdmin
            // 
            this.gbUsuarioAdmin.Controls.Add(this.labelNombreServer);
            this.gbUsuarioAdmin.Controls.Add(this.label3);
            this.gbUsuarioAdmin.Controls.Add(this.lblIP);
            this.gbUsuarioAdmin.Controls.Add(this.label1);
            this.gbUsuarioAdmin.Controls.Add(this.toolStrip1);
            this.gbUsuarioAdmin.Controls.Add(this.txtSalida);
            this.gbUsuarioAdmin.Controls.Add(this.btnTestConnection);
            this.gbUsuarioAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUsuarioAdmin.Location = new System.Drawing.Point(0, 25);
            this.gbUsuarioAdmin.Name = "gbUsuarioAdmin";
            this.gbUsuarioAdmin.Size = new System.Drawing.Size(321, 301);
            this.gbUsuarioAdmin.TabIndex = 18;
            this.gbUsuarioAdmin.TabStop = false;
            this.gbUsuarioAdmin.Text = "Ping";
            // 
            // labelNombreServer
            // 
            this.labelNombreServer.AutoSize = true;
            this.labelNombreServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreServer.Location = new System.Drawing.Point(100, 44);
            this.labelNombreServer.Name = "labelNombreServer";
            this.labelNombreServer.Size = new System.Drawing.Size(28, 15);
            this.labelNombreServer.TabIndex = 87;
            this.labelNombreServer.Text = "[IP]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 86;
            this.label3.Text = "[SERVER]->>";
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(71, 20);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(28, 15);
            this.lblIP.TabIndex = 85;
            this.lblIP.Text = "[IP]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "[IP]->>";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgDark2;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslConn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 273);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStrip1.Size = new System.Drawing.Size(315, 25);
            this.toolStrip1.TabIndex = 83;
            // 
            // tslConn
            // 
            this.tslConn.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tslConn.Font = new System.Drawing.Font("Segoe UI", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslConn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tslConn.Name = "tslConn";
            this.tslConn.Size = new System.Drawing.Size(37, 22);
            this.tslConn.Text = "  Listo";
            // 
            // txtSalida
            // 
            this.txtSalida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSalida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(22, 107);
            this.txtSalida.Multiline = true;
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSalida.Size = new System.Drawing.Size(283, 154);
            this.txtSalida.TabIndex = 82;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.Transparent;
            this.btnTestConnection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTestConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConnection.Location = new System.Drawing.Point(22, 73);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(263, 23);
            this.btnTestConnection.TabIndex = 81;
            this.btnTestConnection.Text = "Generar P&i&ng";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // tspTittle
            // 
            this.tspTittle.BackgroundImage = global::VolcadorIkor.Properties.Resources.bgBlue2;
            this.tspTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspTittle.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tspTittle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.tspTittle.Location = new System.Drawing.Point(0, 0);
            this.tspTittle.Name = "tspTittle";
            this.tspTittle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tspTittle.Size = new System.Drawing.Size(321, 25);
            this.tspTittle.TabIndex = 17;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(236, 22);
            this.toolStripLabel1.Text = " Probar conexion con la BD del Servidor <- ";
            // 
            // frmTestConectionSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 326);
            this.Controls.Add(this.gbUsuarioAdmin);
            this.Controls.Add(this.tspTittle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTestConectionSql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probar Conexion";
            this.gbUsuarioAdmin.ResumeLayout(false);
            this.gbUsuarioAdmin.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tspTittle.ResumeLayout(false);
            this.tspTittle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuarioAdmin;
        private System.Windows.Forms.ToolStrip tspTittle;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslConn;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreServer;
        private System.Windows.Forms.Label label3;
    }
}