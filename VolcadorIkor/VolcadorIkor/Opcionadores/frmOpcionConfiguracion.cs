using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VolcadorIkor.Opcionadores
{
    public partial class frmOpcionConfiguracion : Form
    {
        frmPrincipal mdipr;

        public frmOpcionConfiguracion(Form frmMDI)
        {
            InitializeComponent();
            mdipr = (frmPrincipal)frmMDI;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnMonitores_Click(object sender, EventArgs e)
        {
            Configuracion.frmMonitores frm1 = new Configuracion.frmMonitores();
            clSeguridad.vCargaForma(frm1, mdipr, "Configuración de Monitores");
        }

        private void btnRepositorios_Click(object sender, EventArgs e)
        {
            Configuracion.frmConfiguracionRepositorios frm1 = new Configuracion.frmConfiguracionRepositorios();
            clSeguridad.vCargaForma(frm1, mdipr, "Configuración de Repositorios");
        }

        private void btnCuentasCorreo_Click(object sender, EventArgs e)
        {
            Configuracion.frmConfiguracionCorreo frm1 = new Configuracion.frmConfiguracionCorreo();
            clSeguridad.vCargaForma(frm1, mdipr, "Configuración de Cuentas de Correo");
        }

        private void btnServidorSqlServer_Click(object sender, EventArgs e)
        {
            SqlServer.frmServidorSqlServer frm1 = new SqlServer.frmServidorSqlServer();
            clSeguridad.vCargaForma(frm1, mdipr, "Servidor Sql Server");
        }

        private void btnServidorMysql_Click(object sender, EventArgs e)
        {
            Mysql.frmServidorMysql frm1 = new Mysql.frmServidorMysql();
            clSeguridad.vCargaForma(frm1, mdipr, "Servidor Mysql");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
