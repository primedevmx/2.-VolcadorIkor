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
    public partial class frmOpcionSql : Form
    {
        frmPrincipal mdipr;

        public frmOpcionSql(Form frmMDI)
        {
            InitializeComponent();
            mdipr = (frmPrincipal)frmMDI;
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnServidorSqlServer_Click(object sender, EventArgs e)
        {
            SqlServer.frmServidorSqlServer frm1 = new SqlServer.frmServidorSqlServer();
            clSeguridad.vCargaForma(frm1, mdipr, "Servidor Sql Server");
        }

        private void btnProcesarXMLs_Click(object sender, EventArgs e)
        {
            SqlServer.frmProcesarDATs frm1 = new SqlServer.frmProcesarDATs();
            clSeguridad.vCargaForma(frm1, mdipr, "Procesar DATs");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlServer.frmMtoStatus frm1 = new SqlServer.frmMtoStatus();
            clSeguridad.vCargaForma(frm1, mdipr, "Mantenimiento de Estatus de Pruebas");
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            SqlServer.frmConsultaRegistros frm1 = new SqlServer.frmConsultaRegistros();
            clSeguridad.vCargaForma(frm1, mdipr, "Consulta de Registros");
        }
    }
}
