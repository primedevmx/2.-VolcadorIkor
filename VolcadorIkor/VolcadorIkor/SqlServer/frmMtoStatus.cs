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
    public partial class frmMtoStatus : Form
    {
        #region Variasbles globales
        mSeguridad _mSec = new mSeguridad();
        DataSet _dsTablaStatus = new DataSet();
        DataRow _dROBDs = null;

        #endregion Variasbles globales
        #region Constructores
        public frmMtoStatus()
        {
            InitializeComponent();
        }
        #endregion Constructores
        #region Eventos
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            DataSet dsGuardarStatus = new DataSet();

            //Previa Validacion ->>
            if (_dROBDs != null)
            {
                return;
            }

            string error;
            if (!bValidarDatos(out error))
            {
                MessageBox.Show(error, "Validar Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }	

            DialogResult _DR = MessageBox.Show("- ¿Está seguro de [Guardar] su registro?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_DR == DialogResult.No)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            //VALORES->>
            _mSec.idStatusPCB = -1;
            _mSec.strStatusPCB = txtEstatus.Text.Trim();
            _mSec.strDescripcionEstatusPCB = txtDescripcion.Text.Trim();
            _mSec.bAplicaReglas = chkAR.Checked;

            //GUARDA->>
            dsGuardarStatus = _mSec.dtMtoStatus();

            if ((dsGuardarStatus != null && dsGuardarStatus.Tables[0].Rows.Count > 0) && dsGuardarStatus.Tables[0].Rows[0][0].ToString().Trim() == "OK")
            {
                tsbLimpiar_Click(null, null);

                MessageBox.Show("Operación realizada satisfactoriamente. \n - Puede usted continuar. ", "Mensaje del Sistema"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cursor.Current = Cursors.Arrow;

            }
            else
            {
                MessageBox.Show("Connect BD Fail: <<- \n ", "Atención"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }
        private void tsbModificar_Click(object sender, EventArgs e)
        {
            DataSet dsModificarStatus = new DataSet();

            //Previa Validacion ->>
            if (_dROBDs == null)
            {
                MessageBox.Show("Favor de Seleccionar un registro a [Modificar]", "Atención"
                                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult _DR = MessageBox.Show("- ¿Está seguro de [Modificar] su registro?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_DR == DialogResult.No)
            {
                return;
            }

            Cursor.Current = Cursors.WaitCursor;

            //VALORES->>
            _mSec.idStatusPCB = Convert.ToInt32(_dROBDs[0]);
            _mSec.strStatusPCB = txtEstatus.Text.Trim();
            _mSec.strDescripcionEstatusPCB = txtDescripcion.Text.Trim();
            _mSec.bAplicaReglas = chkAR.Checked;

            //MODIFICA->>
            dsModificarStatus = _mSec.dtMtoStatus();

            if ((dsModificarStatus != null && dsModificarStatus.Tables[0].Rows.Count > 0) && dsModificarStatus.Tables[0].Rows[0][0].ToString().Trim() == "OK")
            {
                tsbLimpiar_Click(null, null);

                MessageBox.Show("Operación realizada satisfactoriamente. \n - Puede usted continuar. ", "Mensaje del Sistema"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cursor.Current = Cursors.Arrow;

            }
            else
            {
                MessageBox.Show("Connect BD Fail: <<- \n ", "Atención"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }
        private void tsbLimpiar_Click(object sender, EventArgs e)
        {
            tsbEliminar.Visible = false;
            tsbModificar.Visible = false;
            tsbGuardar.Visible = true;

            chkAR.Checked = Convert.ToBoolean(0);
            txtEstatus.Text = "";
            txtDescripcion.Text = "";

            _dROBDs = null;

            vCargarDatos();
        }
        private void frmMtoStatus_Load(object sender, EventArgs e)
        {
            vCargarDatos();
        }
        private void uctrlTablaConFiltroStatus_GridDatos_DoubleClick(object sender, uctrlTablaConFiltro.GridDatos_DoubleClickEnventArgs e)
        {
            _dROBDs = ((DataRowView)uctrlTablaConFiltroStatus.gridDatos.CurrentRow.DataBoundItem).Row;

            if (_dROBDs != null)
            {
                tsbEliminar.Visible = true;
                tsbModificar.Visible = true;
                tsbGuardar.Visible = false;

                //Asig de Valores->>
                chkAR.Checked = Convert.ToBoolean(_dROBDs[3]);
                txtEstatus.Text = _dROBDs[1].ToString();
                txtDescripcion.Text = _dROBDs[2].ToString();
            }


        }
        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            DataSet dsEliminarStatus = new DataSet();

            //Previa Validacion ->>
            if (_dROBDs == null)
            {
                MessageBox.Show("Favor de Seleccionar un registro a [Eliminar]", "Atención"
                                      , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult _DR = MessageBox.Show("- ¿Está seguro de [Eliminar] su registro?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_DR == DialogResult.No)
            {
                return;
            }

            //VALORES->>
            _mSec.idStatusPCB = Convert.ToInt32(_dROBDs[0]);

            //MODIFICA->>
            dsEliminarStatus = _mSec.dtDesactivaStatus();

            if ((dsEliminarStatus != null && dsEliminarStatus.Tables[0].Rows.Count > 0) && dsEliminarStatus.Tables[0].Rows[0][0].ToString().Trim() == "OK")
            {
                tsbLimpiar_Click(null, null);

                MessageBox.Show("Operación realizada satisfactoriamente. \n - Puede usted continuar. ", "Mensaje del Sistema"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cursor.Current = Cursors.Arrow;

            }
            else
            {
                MessageBox.Show("Connect BD Fail: <<- \n ", "Atención"
                                       , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
        #endregion Eventos
        #region Metodos
        private void vCargarDatos()
        {
            _dsTablaStatus = _mSec.dtObtenerTablaStatusSQL();
            uctrlTablaConFiltroStatus.DataSource = _dsTablaStatus.Tables[0].Copy();
            #region SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
            this.uctrlTablaConFiltroStatus.gridDatos.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;
            this.uctrlTablaConFiltroStatus.gridDatos.MultiSelect = false;
            #endregion SELECCIONAR SOLO UNA ROW DATAGRIDVIEW
            #region DESACTIVAR SORTMODE
            foreach (DataGridViewColumn columna in uctrlTablaConFiltroStatus.gridDatos.Columns)
            {
                columna.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            #endregion DESACTIVAR SORTMODE

            this.uctrlTablaConFiltroStatus.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private bool bValidarDatos(out string err)
        {
            err = "";
            if (txtEstatus.Text == "") { err = "Debe Especificar el Nombre del Estatus."; }
            else if (txtDescripcion.Text == "") { err = "Debe Especificar la Descripcion del Estatus."; }

            return (err == "");
        }
        #endregion Metodos
    }
}
