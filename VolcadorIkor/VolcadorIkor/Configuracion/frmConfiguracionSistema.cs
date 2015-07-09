using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VolcadorIkor.Configuracion
{
    public partial class frmConfiguracionSistema : Form
    {
        #region CONSTRUCTORES
        public frmConfiguracionSistema()
        {
            InitializeComponent();
            this.vCargarDatos();           
        }
        #endregion CONSTRUCTORES
        #region EVENTOS
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string strKey = "";

            try
            {
                //Escribir->>
                Properties.Settings.Default.InstanciaServerMysql = txtCC.Text.Trim();
                Properties.Settings.Default.Save();

                //Leer->>
                strKey = Properties.Settings.Default.InstanciaServerMysql;
                if (strKey != "")
                {
                    this.vCargarDatos();           

                    MessageBox.Show("Se ha registrado correctamente la [Instancia del Servidor]. \n \n - Puede usted continuar. ", "Atención"
                    , MessageBoxButtons.OK, MessageBoxIcon.Question);                    
                }
            }
            catch { }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void txtCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar_Click(null,null);
            }
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            UserControls.frmTestConection FRMM = new UserControls.frmTestConection(this.txtCC.Text.Trim(), "[SECURITY BD]");
            FRMM.ShowDialog();
        }
        private void txtUserBD_TextChanged(object sender, EventArgs e)
        {
            txtCC.Text = strArmaCCSS();
        }
        private void frmRegistraServidor_Load(object sender, EventArgs e)
        {
            txtCuentaReceptora.Text = Properties.Settings.Default.strCuentaReceptora;
            txtCuentaEmisora.Text = Properties.Settings.Default.strCuentaEmisora;
            txtContraseñaEmisora.Text = Properties.Settings.Default.strContrasenaEmisora;
            txtRepositorio.Text = Properties.Settings.Default.strRepoXMLs;
            txtRepositorioDAT.Text = Properties.Settings.Default.strRepoDATs;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
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
        private void rbtnServidorMysql_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }
        private void rbtnCuentasCorreo_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = false;
            panel2.Visible = true;
        }
        private void rbtnRepoXMLs_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel3.Visible = true;
            panel2.Visible = false;
        }
        private void btnGuardarRepositorio_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.strRepoXMLs = txtRepositorio.Text.Trim();
            Properties.Settings.Default.Save();
            MessageBox.Show("Se ha registrado correctamente el directorio de repositorio de [XMLs]. \n \n - Puede usted continuar. ", "Atención"
                   , MessageBoxButtons.OK, MessageBoxIcon.Question);  

        }
        private void btnSeleccionarRepositorio_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowNewFolderButton = false;

            this.folderBrowserDialog1.RootFolder =
                                        System.Environment.SpecialFolder.MyComputer;

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRepositorio.Text = this.folderBrowserDialog1.SelectedPath;
            }

        }
        private void btnSeleccionarRepositorioDAT_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowNewFolderButton = false;

            this.folderBrowserDialog1.RootFolder =
                                        System.Environment.SpecialFolder.MyComputer;

            DialogResult result = this.folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRepositorioDAT.Text = this.folderBrowserDialog1.SelectedPath;
            }
        }
        private void btnGuardarRepositorioDAT_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.strRepoDATs = txtRepositorioDAT.Text.Trim();
            Properties.Settings.Default.Save();
            MessageBox.Show("Se ha registrado correctamente el directorio de repositorio de [DATs]. \n \n - Puede usted continuar. ", "Atención"
                   , MessageBoxButtons.OK, MessageBoxIcon.Question); 
        }
        #endregion EVENTOS     
        #region METODOS
        private string strArmaCCSS()
        {
            //Server=localhost;Port=3306;Database=dbIkor;Uid=root;Pwd=admin;

            string strRet = "";

            strRet = "Server=" + txtIP.Text.Trim() + ";Port=" + txtPuerto.Text.Trim() + ";Database=" +
                txtNombreBD.Text.Trim() + ";Uid=" + txtUserBD.Text.Trim() + ";Pwd=" + txtPasswodBD.Text.Trim();

            return strRet;
        }
        private void vCargarDatos()
        {
            string strKey = "";

            try
            {
                //Leer->>
                strKey = Properties.Settings.Default.InstanciaServerMysql;
                txtCC.Text = strKey;
                if (strKey != "")
                {
                    txtCC.Text = strKey;
                    string[] strArr = strKey.Split(';');
                    txtIP.Text = strArr[0].Substring(7);
                    txtPuerto.Text = strArr[1].Substring(5);
                    txtNombreBD.Text = strArr[2].Substring(9);
                    txtUserBD.Text = strArr[3].Substring(4);
                    txtPasswodBD.Text = strArr[4].Substring(4);                 
                }
                else
                {
                    txtCC.Text = "";
                }
            }
            catch { }        
        }
        #endregion METODOS              
    }

}
