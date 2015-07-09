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
    public partial class frmOpcionMysql : Form
    {
        frmPrincipal mdipr;

        public frmOpcionMysql(Form frmMDI)
        {
            InitializeComponent();
            mdipr = (frmPrincipal)frmMDI;
        }

        private void btnProcesarXMLs_Click(object sender, EventArgs e)
        {
            Mysql.frmProcesarXmls frm1 = new Mysql.frmProcesarXmls();
            clSeguridad.vCargaForma(frm1, mdipr, "Procesar XML(s)");
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            Mysql.frmReporte frm1 = new Mysql.frmReporte();
            clSeguridad.vCargaForma(frm1, mdipr, "Registros");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnServidorMysql_Click(object sender, EventArgs e)
        {
            Mysql.frmServidorMysql frm1 = new Mysql.frmServidorMysql();
            clSeguridad.vCargaForma(frm1, mdipr, "Servidor Mysql");
        }
    }
}
