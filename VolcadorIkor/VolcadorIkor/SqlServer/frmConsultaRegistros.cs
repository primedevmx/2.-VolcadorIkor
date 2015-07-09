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
    public partial class frmConsultaRegistros : Form
    {
        DataTable _dtSeriales;
        mSeguridad _mSecurity = new mSeguridad();
        DataRow _dROBDs = null;

        public frmConsultaRegistros()
        {
            InitializeComponent();
        }

        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void tsbRefrescarSeriales_Click(object sender, EventArgs e)
        {
            vCargarDatos();
        }

        private void frmConsultaRegistros_Load(object sender, EventArgs e)
        {
            vCargarDatos();
        }

        private void vCargarDatos()
        {
            Cursor.Current = Cursors.WaitCursor;            
            _dtSeriales = _mSecurity.dtLeerDatosTXT("").Tables[2].Copy();
            uctrTbSeriales.DataSource = _dtSeriales.Copy();
            uctrTbSeriales.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uctrTbFiltroMovimientos.DataSource = null;
            _dROBDs = null;
            Cursor.Current = Cursors.Arrow;
        }

        private void uctrTbSeriales_GridDatos_DoubleClick(object sender, uctrlTablaConFiltro.GridDatos_DoubleClickEnventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            _dROBDs = ((DataRowView)uctrTbSeriales.gridDatos.CurrentRow.DataBoundItem).Row;

            if (_dROBDs != null)
            {
                try
                {
                    DataTable dtMovs = _mSecurity.dtLeerDatosTXT(_dROBDs[0].ToString().Trim()).Tables[1].Copy();
                    uctrTbFiltroMovimientos.DataSource = dtMovs.Copy();
                    uctrTbSeriales.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    uctrTbSeriales.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch { }
            }

            Cursor.Current = Cursors.Arrow;
        }


    }
}
