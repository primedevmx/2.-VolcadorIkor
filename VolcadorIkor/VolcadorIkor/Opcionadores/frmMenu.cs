using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MdiTabStrip.Design;
using MdiTabStrip;

namespace VolcadorIkor.Opcionadores
{
    /// <summary>
    /// Autor: 
    ///     Miguel Gutierrez Arroyo
    /// Fecha: 
    ///     2014/05/06
    /// 
    /// Descripcion: 
    ///     Menu Dinámico de la Aplicación
    /// Acciones: 
    ///     Desplegar Modulos
    /// 
    /// </summary> 
    public partial class frmMenu : ToolWindow
    {
        #region PROPIEDADES
        frmPrincipal mdipr;
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmMenu(Form frmMDI)
        {
            mdipr = (frmPrincipal)frmMDI;
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region METODOS
        #endregion METODOS
        #region EVENTOS
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmOpcionConfiguracion frmConf = new frmOpcionConfiguracion(mdipr);
            clSeguridad.vCargaForma(frmConf, mdipr, "Menú Configuración");
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Mysql.frmProcesarXmls frm1 = new Mysql.frmProcesarXmls();
            clSeguridad.vCargaForma(frm1, mdipr, "Procesar XML(s)");
        }
        #endregion EVENTOS

        private void frmMenu_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStrip3_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Mysql.frmReporte frm1 = new Mysql.frmReporte();
            clSeguridad.vCargaForma(frm1, mdipr, "Registros");
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmOpcionMysql frmMysql = new frmOpcionMysql(mdipr);
            clSeguridad.vCargaForma(frmMysql, mdipr, "Menú Mysql");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmOpcionSql frmMysql = new frmOpcionSql(mdipr);
            clSeguridad.vCargaForma(frmMysql, mdipr, "Menú Sql Server");
        }

      
    }
}