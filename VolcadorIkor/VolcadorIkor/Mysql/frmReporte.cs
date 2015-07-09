using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VolcadorIkor.Mysql
{
    public partial class frmReporte : Form
    {
        #region PROPIEDADES
        DataTable _dtTemp = null;
        mSeguridad _mSecurity = new mSeguridad();
        #endregion PROPIEDADES

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
        public frmReporte(int iSeleccionMultiple)
        {
            this.bMultiSelect = iSeleccionMultiple == 0 || iSeleccionMultiple == 1 ? true : false;
            this.iMultiSelect = iSeleccionMultiple;
            InitializeComponent();
        }

        public frmReporte()
        {
            this.bMultiSelect = false;
            this.iMultiSelect = 0;

            InitializeComponent();

        }

        void vCargarInfoPCB()
        {
            Cursor.Current = Cursors.WaitCursor;

            DataSet dsReturn = new DataSet("ParametrosAPP");
            string strCommand = "";
            string strSalida = "";

            strCommand = "select 0 as id, p.* from tblinfopcb p ";


            //Mysql->>
            MySqlConnection _conn = new MySqlConnection(_mSecurity.strConnection);
            MySqlCommand _cmd;

            try
            {
                _conn.Open();
                _cmd = _conn.CreateCommand();
                _cmd.CommandText = strCommand;
                MySqlDataAdapter adap = new MySqlDataAdapter(_cmd);
                adap.Fill(dsReturn);

                if (dsReturn.Tables[0].Rows.Count > 0)
                {
                    //Arrange->>
                    for (int i = 0; i <= dsReturn.Tables[0].Rows.Count - 1; i++)
                    {
                        dsReturn.Tables[0].Rows[i][0] = i + 1;

                    }

                    //Arrange 2->>
                    DataTable DTEMPO = dsReturn.Tables[0].Select("id <> 0", "id desc").CopyToDataTable();
                    DataSet dsT = new DataSet();
                    dsT.Tables.Add(DTEMPO);

                    GrdDatos.gridDatos.DataSource = DTEMPO.Copy();
                    GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    this.dt = DTEMPO.Copy();
                    this.ds = dsT.Copy();

                    Cursor.Current = Cursors.Arrow;

                }
                else
                {
                    GrdDatos.gridDatos.DataSource = null;
                    this.dt = null;
                    this.ds = null;


                }


            }
            catch (Exception EX)
            {
                //Salida Negativa->>
                dsReturn = null;
                strSalida = EX.Message + " \r\n \r\n "
                    + " \r\n \r\n - Verifique la configuración de los parámetros del servidor.";
                MessageBox.Show(strSalida, "-ERROR EN LA CONEXIÓN-");
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }
            
        }

        void vCargarBitacora()
        {
            Cursor.Current = Cursors.WaitCursor;

            DataSet dsReturn = new DataSet("ParametrosAPP");
            string strCommand = "";
            string strSalida = "";

            strCommand = "SELECT * FROM  tblbitacoraproceso WHERE 1  order by idBP DESC LIMIT 0 , 1000";

            //Mysql->>
            MySqlConnection _conn = new MySqlConnection(_mSecurity.strConnection);
            MySqlCommand _cmd;

            try
            {
                _conn.Open();
                _cmd = _conn.CreateCommand();
                _cmd.CommandText = strCommand;
                MySqlDataAdapter adap = new MySqlDataAdapter(_cmd);
                adap.Fill(dsReturn);

                if (dsReturn.Tables[0].Rows.Count > 0)
                {

                    GrdDatos.gridDatos.DataSource = dsReturn.Tables[0].Copy();
                    GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    this.dt = dsReturn.Tables[0].Copy();
                    this.ds = dsReturn.Copy();

                    Cursor.Current = Cursors.Arrow;

                }
                else {
                    GrdDatos.gridDatos.DataSource = null;
                    this.dt = null;
                    this.ds = null;

                
                }

            }
            catch (Exception EX)
            {
                //Salida Negativa->>
                dsReturn = null;
                strSalida = EX.Message + " \r\n \r\n "
                    + " \r\n \r\n - Verifique la configuración de los parámetros del servidor.";
                MessageBox.Show(strSalida, "-ERROR EN LA CONEXIÓN-");
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            GrdDatos.toolBusqueda.Visible = true;
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
            Cursor.Current = Cursors.WaitCursor;
            vCargarInfoPCB();
            frmConsulta_Load(null,null);
            Cursor.Current = Cursors.Arrow;
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

        private void tsbBitacora_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            vCargarBitacora();
            frmConsulta_Load(null, null);
            Cursor.Current = Cursors.Arrow;
        }
    }
}