using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolcadorIkor
{
    public partial class frmConsulta : Form
    {
        public DataSet ds;
        public DataTable dt;
        public string resultado = "";
        public string sitem = "";
        public string IDCuenta = "";
        public List<string> omiteFiltro;
        public int intColID = 0;
        public string strColID= "";
        private int iMultiSelect = 0;
        private bool bMultiSelect = true;
        public string sResultadoMS = "";
        public bool bLeeItem = false;
        public DataGridViewSelectedRowCollection drResultado = null;


        /// <summary>
        /// Contructor Forma Consulta
        /// </summary>
        /// <param name="iMultiselect">
        /// 
        /// 0   -   Puede seleccionar Multiple pero no regresa todos solo el del cursor actual.
        /// 1   -   Puede seleccionar Multiple y regresa todos los seleccionados.
        /// 2   -   No acepta Selección Multiple.
        /// 3   -   Al dar doble click en el grid no se cierra, ni se muentra el botón de seleccionar.
        /// 
        /// </param>
        /// 
        public frmConsulta(int iSeleccionMultiple)
        {
            this.bMultiSelect = iSeleccionMultiple == 0 || iSeleccionMultiple == 1 ? true : false;
            this.iMultiSelect = iSeleccionMultiple;
            InitializeComponent();
        }

        public frmConsulta()
        {
            InitializeComponent();            
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            GrdDatos.toolBusqueda.Visible = false;
            try
            {
                if (dt == null)
                {
                    if (ds != null)
                    {
                        if (this.omiteFiltro == null)
                        {
                            this.omiteFiltro = new List<string>();
                        }
                        this.GrdDatos.OmiteFiltroColumnas = this.omiteFiltro;
                        this.GrdDatos.DataSource = ds.Tables[0];
                        GrdDatos.gridDatos.MultiSelect = bMultiSelect;
                    }
                    else
                    {
                        resultado = "";
                        sitem = "";
                        this.Close();
                    }
                }
                else
                {
                    this.GrdDatos.DataSource = dt;
                    foreach (DataGridViewColumn dgc in this.GrdDatos.gridDatos.Columns)
                    {
                        if (dgc.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true) < 250)
                            dgc.Width = dgc.GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
                        else
                            dgc.Width = 250;
                    }
                    GrdDatos.gridDatos.MultiSelect = bMultiSelect;
                }
                if (iMultiSelect == 3)
                {
                    this.Seleccionar.Visible = false;
                }
            }
            catch { }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            sitem = "";
            resultado = "";
            this.Close();
        }

        private void Seleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (iMultiSelect == 1)
                {
                    if (GrdDatos.gridDatos.SelectedRows.Count > 0)
                    {
                        sResultadoMS = "";

                        for (int i = 0; i < GrdDatos.gridDatos.SelectedRows.Count; i++)
                        {
                            if (sResultadoMS.Length > 0)
                                sResultadoMS = sResultadoMS + ",";
                            if (string.IsNullOrEmpty(strColID))
                                sResultadoMS = sResultadoMS +
                                    GrdDatos.gridDatos.SelectedRows[i].Cells[intColID].Value.ToString();
                            else
                                sResultadoMS = sResultadoMS +
                                    GrdDatos.gridDatos.SelectedRows[i].Cells[strColID].Value.ToString();
                        }
                    }
                }
                if (string.IsNullOrEmpty(strColID))
                {
                    resultado = GrdDatos.gridDatos.CurrentRow.Cells[intColID].Value.ToString();
                    if (bLeeItem)
                    {
                        sitem = GrdDatos.gridDatos.CurrentRow.Cells[1].Value.ToString();
                        if(GrdDatos.gridDatos.Columns.Count >= 4)
                            IDCuenta = GrdDatos.gridDatos.CurrentRow.Cells[3].Value.ToString();
                    }

                }
                else
                {
                    resultado = GrdDatos.gridDatos.CurrentRow.Cells[strColID].Value.ToString();
                    if (bLeeItem)
                    {
                        sitem = GrdDatos.gridDatos.CurrentRow.Cells[1].Value.ToString();
                        if (GrdDatos.gridDatos.Columns.Count >= 4)
                            IDCuenta = GrdDatos.gridDatos.CurrentRow.Cells[3].Value.ToString();
                    }
                }
                drResultado = GrdDatos.gridDatos.SelectedRows;
                
                this.Close();
            }
            catch
            {
                resultado = "";
                sResultadoMS = "";
                drResultado = null;
                this.Close();

            }
        }

        private void GrdDatos_GridDatos_DoubleClick(object sender, VolcadorIkor.uctrlTablaConFiltro.GridDatos_DoubleClickEnventArgs e)
        {
            try
            {
                if (iMultiSelect == 3) return;
                if (iMultiSelect == 1)
                {
                    if (GrdDatos.gridDatos.SelectedRows.Count > 0)
                    {
                        sResultadoMS = "";

                        for (int i = 0; i < GrdDatos.gridDatos.SelectedRows.Count; i++)
                        {
                            if (sResultadoMS.Length > 0)
                                sResultadoMS = sResultadoMS + ",";
                            if (string.IsNullOrEmpty(strColID))
                                sResultadoMS = sResultadoMS +
                                    GrdDatos.gridDatos.SelectedRows[i].Cells[intColID].Value.ToString();
                            else
                                sResultadoMS = sResultadoMS +
                                    GrdDatos.gridDatos.SelectedRows[i].Cells[strColID].Value.ToString();
                        }
                    }
                }
                if (string.IsNullOrEmpty(strColID))
                {
                    resultado = GrdDatos.gridDatos.CurrentRow.Cells[intColID].Value.ToString();
                    if (bLeeItem)
                    {
                        sitem = GrdDatos.gridDatos.CurrentRow.Cells[1].Value.ToString();
                        if (GrdDatos.gridDatos.Columns.Count >= 4)
                            IDCuenta = GrdDatos.gridDatos.CurrentRow.Cells[3].Value.ToString();
                    }
                }
                else
                {
                    resultado = GrdDatos.gridDatos.CurrentRow.Cells[strColID].Value.ToString();
                    if (bLeeItem)
                    {
                        sitem = GrdDatos.gridDatos.CurrentRow.Cells[1].Value.ToString();
                        if (GrdDatos.gridDatos.Columns.Count >= 4)
                            IDCuenta = GrdDatos.gridDatos.CurrentRow.Cells[3].Value.ToString();
                    }
                }
                //if (!string.IsNullOrEmpty(strColID))
                //{
                    drResultado = GrdDatos.gridDatos.SelectedRows;
                    this.Close();
                //}
            }
            catch
            {
                drResultado = null;
                resultado = "";
                sResultadoMS = "";
                this.Close();

            }

        }

        private void frmConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {

                resultado = "";
                sitem = "";
                IDCuenta = "";
                this.Close();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Escape)
            {

                resultado = "";
                sitem = "";
                IDCuenta = "";
                this.Close();
            }
            return false;
        }
    }
}