using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace VolcadorIkor
{
    public partial class uctrlTablaConFiltro : UserControl
    {
        #region Variables Globales
        DataTable datasource;
        public Dictionary<string, string> Filtro;
        public List<string> OmiteFiltroColumnas = new List<string>();
        public List<int> OmiteFiltroIndices = new List<int>();
        public List<string> FiltroAmplio = new List<string>();
        public List<string> BusquedaDirecta = new List<string>();
        public int intFiltroAmplio = 100;
        public Boolean likeNumerico = false;
        public Boolean filtroBool = false;
        public Boolean bAgregarFilto = true;
        private bool _bContador = false;
        #endregion
        #region Constructores
        public uctrlTablaConFiltro()
        {
            InitializeComponent();
        }
        #endregion
        #region Propiedades
        public bool bContador
        {
            get { return _bContador; }
            set
            {
                _bContador = value;
                pnlContador.Visible = _bContador;
            }
        }
        public DataTable DataSource
        {
            get
            {
                try
                {
                    return (DataTable)gridDatos.DataSource;
                }
                catch
                {
                    return null;
                }
            }
            set
            {
                if (value == null)
                {
                    toolBusqueda.Items.Clear();
                    gridDatos.DataSource = null;
                    lblContador.Text = "0 / 0";
                }
                else
                {
                    try
                    {
                        lblContador.Text = "";
                        datasource = value;
                        Filtro = new Dictionary<string, string>();
                        gridDatos.DataSource = datasource;
                        toolBusqueda.Items.Clear();
                        int index = 0;

                        List<string> nuevaLista = new List<string>();
                        foreach (string s in OmiteFiltroColumnas)
                        {
                            nuevaLista.Add(s.ToUpper());
                        }

                        List<string> FiltroAmplio = new List<string>();
                        foreach (string s in this.FiltroAmplio)
                        {
                            FiltroAmplio.Add(s.ToUpper());
                        }

                        foreach (DataColumn col in value.Columns)
                        {
                            if (nuevaLista.IndexOf(col.ColumnName.ToUpper()) == -1 && OmiteFiltroIndices.IndexOf(index) == -1)
                            {
                                ToolStripLabel lb = new ToolStripLabel(col.ColumnName);
                                ToolStripTextBox txt = new ToolStripTextBox(col.ColumnName);
                                txt.AutoSize = false;
                                txt.Width = FiltroAmplio.IndexOf(col.ColumnName.ToUpper()) == -1 ? 40 : intFiltroAmplio;
                                txt.TextChanged += new EventHandler(txt_TextChanged);
                                lb.ForeColor = Color.LightGray;
                                Font f = lb.Font;
                                lb.Font = new Font(f, FontStyle.Bold);
                                toolBusqueda.Items.Add(lb);
                                toolBusqueda.Items.Add(txt);
                            }
                            index++;
                        }

                        lblContador.Text = datasource.Rows.Count.ToString() + " / " +
                            datasource.Rows.Count.ToString();
                    }
                    catch
                    {
                    }
                }
            }
        }
        public bool bMostrarGrip
        {
            get { return toolBusqueda.GripStyle == ToolStripGripStyle.Visible; }
            set
            {
                if (value)
                    toolBusqueda.GripStyle = ToolStripGripStyle.Visible;
                else toolBusqueda.GripStyle = ToolStripGripStyle.Hidden;
            }
        }
        public bool bFiltro
        {
            get { return bAgregarFilto; }
            set
            {
                bAgregarFilto = value;
                toolBusqueda.Visible = bAgregarFilto;
            }
        }
        public DataRow dtrAgregarFila
        {
            get { try { return datasource.NewRow(); } catch { return null; } }
            set { try { datasource.Rows.Add(value); } catch { } }
        }
        public bool bTabStopFiltros
        {
            get { return toolBusqueda.TabStop; }
            set { toolBusqueda.TabStop = value; }
        }
        #endregion
        #region Crear Eventos
        // EVENTO GRIDDATOS MOSTRAR
        public class GridDatos_MostrarEnventArgs : EventArgs { }
        public delegate void GridDatos_MostrarEventHandler(object sender, GridDatos_MostrarEnventArgs e);
        public event GridDatos_MostrarEventHandler GridDatos_Mostrar;
        protected virtual void OnGridDatos_Mostrar(GridDatos_MostrarEnventArgs e)
        {
            if (GridDatos_Mostrar != null)
            {
                GridDatos_Mostrar(this, e);
            }
        }
        // EVENTO GRIDDATOS SELECCION CAMBIA
        public event System.EventHandler OnSeleccionCambia;
        // EVENTO GRIDDATOS CONTENIDO CLICK
        public event System.EventHandler OnContenido_Click;
        // EVENTO GRIDDATOS CONTENIDO CLICK
        public event System.Windows.Forms.KeyPressEventHandler OnKey_Press;
        // EVENTO GRIDDATOS DOUBLE CLICK
        public class GridDatos_DoubleClickEnventArgs : EventArgs { }
        public delegate void GridDatos_DoubleClickEventHandler(object sender, GridDatos_DoubleClickEnventArgs e);
        public event GridDatos_DoubleClickEventHandler GridDatos_DoubleClick;
        protected virtual void OnGridDatos_DoubleClick(GridDatos_DoubleClickEnventArgs e)
        {
            if (GridDatos_DoubleClick != null)
            {
                GridDatos_DoubleClick(this, e);
            }
        }
        // EVENTO GRIDDATOS CELL DOUBLE CLICK
        public event DataGridViewCellEventHandler cell_Datagrid_DoubleClick;
        // EVENTO FILTRO APLICADO
        public event System.EventHandler OnFiltroAplicado;
        // EVENTO DATAGRID END EDIT
        public event DataGridViewCellEventHandler DataGrid_CellEndEdit;
        // EVENTO DATAGRID DATA ERROR
        public event DataGridViewDataErrorEventHandler DataGrid_DataError;
        public event DataGridViewCellMouseEventHandler DataGrid_ColumnHeaderMC;
        public event DataGridViewCellMouseEventHandler DataGrid_ColumnHeaderMDC;
        #endregion
        #region Eventos del UserControl
        private void txt_TextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox txt = (ToolStripTextBox)sender;
            if (Filtro.ContainsKey(txt.Name))
            {
                Filtro.Remove(txt.Name);
            }
            if (!string.IsNullOrEmpty(txt.Text))
                Filtro.Add(txt.Name, txt.Text);

            string filtro = "1=1";
            foreach (DataColumn col in datasource.Columns)
            {
                string val, newVal;
                if (Filtro.TryGetValue(col.ColumnName, out val))
                {
                    //filtro += " AND [" + col.ColumnName + "]" + val; //borrado por david
                    //
                    //checa si el usuario puso la expresión
                    if (val.Trim().StartsWith("=") || val.Trim().StartsWith("<") || val.Trim().StartsWith(">")
                        || val.Trim().StartsWith("not ") || val.Trim().StartsWith("like ")
                        || val.Trim().StartsWith("in ") || val.Trim().StartsWith("is "))
                    {
                        filtro += " AND [" + col.ColumnName + "]" + val;
                    }
                    else
                    {
                        if (col.DataType == Type.GetType("System.String"))
                        {
                            if (val.Contains("'"))
                                newVal = val;
                            else if (BusquedaDirecta.IndexOf(col.ColumnName) > -1)
                                newVal = "'" + val + "%'";
                            else
                                newVal = "'%" + val + "%'";

                            filtro += " AND [" + col.ColumnName + "] like " + newVal;
                        }
                        else if (col.DataType == Type.GetType("System.Int32"))
                        {
                            if (!likeNumerico)
                                filtro += " AND [" + col.ColumnName + "] = " + val;
                            else
                                filtro += " AND convert( [" + col.ColumnName + "],'System.String') like '" + val + "%'";
                        }
                        else if (col.DataType == Type.GetType("System.Int16"))
                        {
                            if (!likeNumerico)
                                filtro += " AND [" + col.ColumnName + "] = " + val;
                            else
                                filtro += " AND convert( [" + col.ColumnName + "],'System.String') like '" + val + "%'";
                        }
                        else if (col.DataType == Type.GetType("System.Decimal"))
                        {
                            if (!likeNumerico)
                                filtro += " AND [" + col.ColumnName + "] = " + val;
                            else
                                filtro += " AND convert( [" + col.ColumnName + "],'System.String') like '" + val + "%'";
                        }
                        else if (col.DataType == Type.GetType("System.DateTime"))
                        {
                           filtro += " AND convert( [" + col.ColumnName + "],'System.String') like '" + val + "%'";
                        }
                        else if (col.DataType == Type.GetType("System.Boolean"))
                        {
                            if (filtroBool)
                            {
                                val = val.ToUpper().Equals("TRUE") ? "1" : val.ToUpper().Equals("FALSE") ? "0" : val;
                                val = val.ToUpper().Equals("V") ? "1" : val.ToUpper().Equals("F") ? "0" : val;
                                val = val.ToUpper().Equals("S") ? "1" : val.ToUpper().Equals("N") ? "0" : val;
                                val = val.ToUpper().Equals("SI") ? "1" : val.ToUpper().Equals("NO") ? "0" : val;
                                val = val.ToUpper().Equals("VERDADERO") ? "1" : val.ToUpper().Equals("FALSO") ? "0" : val;
                                if (val.Equals("0") || val.Equals("1"))
                                    filtro += " AND [" + col.ColumnName + "] = " + val;
                            }
                        }
                    }
                }
            }
            try
            {

                DataTable Resultados = datasource.Clone();
                foreach (DataRow orow in datasource.Select(filtro))
                {
                    Resultados.ImportRow(orow);
                }
                gridDatos.DataSource = Resultados;

                lblContador.Text = Resultados.Rows.Count.ToString() + " / " +
                    datasource.Rows.Count.ToString();
            }
            catch
            {
                //MessageBox.Show("Error en las fórmulas, revise los filtros.");
            }
            if (OnFiltroAplicado != null)
                OnFiltroAplicado(sender, e);
        }
        private void gridDatos_SelectionChanged(object sender, EventArgs e)
        {

            OnGridDatos_Mostrar(new GridDatos_MostrarEnventArgs());
            if (OnSeleccionCambia != null)
            {
                OnSeleccionCambia(null, null);
            }
        }
        private void gridDatos_DoubleClick(object sender, EventArgs e)
        {
            OnGridDatos_DoubleClick(new GridDatos_DoubleClickEnventArgs());
        }
        private void gridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OnContenido_Click != null)
            {
                OnContenido_Click(sender, e);
            }
        }
        private void gridDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                OnKey_Press(sender, e);
            }
            catch { }
        }
        private void gridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cell_Datagrid_DoubleClick != null)
            {
                cell_Datagrid_DoubleClick(sender, e);
            }
        }
        private void gridDatos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrid_CellEndEdit != null)
                DataGrid_CellEndEdit(sender, e);
        }
        private void gridDatos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (DataGrid_DataError != null)
                DataGrid_DataError(sender, e);
        }
        private void copiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetDataObject(gridDatos.GetClipboardContent());
        }
        private void gridDatos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGrid_ColumnHeaderMC != null)
                DataGrid_ColumnHeaderMC(sender, e);
        }
        private void gridDatos_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DataGrid_ColumnHeaderMDC != null)
                DataGrid_ColumnHeaderMDC(sender, e);
        }
        #endregion
        #region METODOS
        public void Recargar()
        {
            DataSource = datasource;
        }
        #endregion
    }
}
