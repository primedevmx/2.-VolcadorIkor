using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VolcadorIkor.SqlServer
{
    public partial class frmServidorSqlServer : Form
    {
        public frmServidorSqlServer()
        {
            InitializeComponent();
            v_CargarDatos();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            UserControls.frmTestConectionSql FRMM = new UserControls.frmTestConectionSql(this.txtCC.Text.Trim(), "[SQL SERVER-BD]");
            FRMM.ShowDialog();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string strKey = "";

            try
            {
                //Escribir->>
                Properties.Settings.Default.InstanciaServerSql = txtCC.Text.Trim();
                Properties.Settings.Default.Save();

                //Leer->>
                strKey = Properties.Settings.Default.InstanciaServerSql;
                if (strKey != "")
                {
                    this.v_CargarDatos();

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

        private void v_CargarDatos()
        {
            //Data Source=192.168.48.182\SQLEXPRESS;initial catalog=dbPCB;
            //user id=root;password=admin;Connection Timeout=180000
             
            string strKey = "";

            try
            {
                //Leer->>
                strKey = Properties.Settings.Default.InstanciaServerSql;
                txtCC.Text = strKey;
                if (strKey != "")
                {
                    txtCC.Text = strKey;
                    string[] strArr = strKey.Split(';');
                    string[] strArr2 = strArr[0].Split('\\');
                    txtIP.Text = strArr2[0].Substring(12);
                    txtPuerto.Text = strArr2[1];
                    txtNombreBD.Text = strArr[1].Substring(16);
                    txtUserBD.Text = strArr[2].Substring(8);
                    txtPasswodBD.Text = strArr[3].Substring(9);
                }
                else
                {
                    txtCC.Text = "";
                }
            }
            catch { }
        }

        private string strArmaCCSS()
        {
            //Data Source=192.168.48.182\SQLEXPRESS;initial catalog=dbPCB;
            //user id=root;password=admin;Connection Timeout=180000

            string strRet = "";

            strRet = "Data Source=" + txtIP.Text.Trim() + "\\" + txtPuerto.Text.Trim() + ";" + "initial catalog=" +
                txtNombreBD.Text.Trim() + ";user id=" + txtUserBD.Text.Trim() + ";password=" + txtPasswodBD.Text.Trim() + ";Connection Timeout=180000";

            return strRet;
        }

        private void txtUserBD_TextChanged(object sender, EventArgs e)
        {
            txtCC.Text = strArmaCCSS();
        }

    }
}
