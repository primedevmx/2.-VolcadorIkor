using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VolcadorIkor.Mysql
{
    public partial class frmServidorMysql : Form
    {
        public frmServidorMysql()
        {
            InitializeComponent();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            UserControls.frmTestConection FRMM = new UserControls.frmTestConection(this.txtCC.Text.Trim(), "[MYSQL-BD]");
            FRMM.ShowDialog();
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

        private void frmServidorMysql_Load(object sender, EventArgs e)
        {
            this.vCargarDatos();          

        }

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

        private void txtUserBD_TextChanged(object sender, EventArgs e)
        {
            txtCC.Text = strArmaCCSS();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
