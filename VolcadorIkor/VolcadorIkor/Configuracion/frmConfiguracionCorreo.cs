using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VolcadorIkor.Configuracion
{
    public partial class frmConfiguracionCorreo : Form
    {
        public frmConfiguracionCorreo()
        {
            InitializeComponent();
        }

        private void btnGuardarReceptora_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.strCuentaReceptora = txtCuentaReceptora.Text.Trim();
            Properties.Settings.Default.Save();

            MessageBox.Show("Se ha registrado correctamente la cuenta de [Correo Electronico]. \n \n - Puede usted continuar. ", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Question);  
        }

        private void btnGuardarEmisora_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.strCuentaEmisora = txtCuentaEmisora.Text.Trim();
            Properties.Settings.Default.Save();

            Properties.Settings.Default.strContrasenaEmisora = txtContraseñaEmisora.Text.Trim();
            Properties.Settings.Default.Save();

            MessageBox.Show("Se ha registrado correctamente la cuenta emisora de [Correo Electronico]. \n \n - Puede usted continuar. ", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Question);  
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmConfiguracionCorreo_Load(object sender, EventArgs e)
        {
            txtCuentaReceptora.Text = Properties.Settings.Default.strCuentaReceptora;
            txtCuentaEmisora.Text = Properties.Settings.Default.strCuentaEmisora;
            txtContraseñaEmisora.Text = Properties.Settings.Default.strContrasenaEmisora;
        }
    }
}
