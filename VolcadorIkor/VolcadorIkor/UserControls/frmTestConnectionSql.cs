using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Forms;

namespace VolcadorIkor.UserControls
{
    public partial class frmTestConectionSql : Form
    {
        mSeguridad _mSecurity = new mSeguridad();

        string _strConn = "";

        public frmTestConectionSql()
        {
            InitializeComponent();
        }

        public frmTestConectionSql(string strConn, string strName)
        {
            InitializeComponent();
            try
            {
                _strConn = strConn;
                string[] strArrK = _strConn.Split(';');
                string[] strArrK2 = strArrK[0].Split('\\');
                //IP->>
                lblIP.Text = strArrK2[0].Substring(12);
                //Serever->>
                labelNombreServer.Text = strArrK2[1];
            }
            catch { }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            DataSet dsReturn = new DataSet("ParametrosAPP");
            string strCommand = "";
            string strSalida = "";

            strCommand = "SELECT TOP 1 * FROM [dbo].[tblPCB_Status]";


            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //Consulta->>
                dsReturn =
                    Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(_strConn, CommandType.Text, strCommand);

                if (dsReturn!= null)
                {
                    txtSalida.Text = "Operacion realizada satisfactoriamente. - Se ha establecido correctamente la configuración de la [Base de Datos] del Servidor. \r\n \r\n -  Sistema IKOR.";
                    tslConn.Text = " - Conexión Exitosa - ";
                    tslConn.ForeColor = System.Drawing.Color.LightGreen;

                    Cursor.Current = Cursors.Arrow;

                }

            }
            catch (Exception EX)
            {
                dsReturn = null;
                strSalida = EX.Message + " \r\n \r\n "
                    + " \r\n \r\n - Verifique la configuración de los parámetros del servidor.";
                MessageBox.Show(strSalida, "-ERROR EN LA CONEXIÓN-");
                txtSalida.Text = strSalida;
                tslConn.Text = " - Error en la conexión - ";
                tslConn.ForeColor = System.Drawing.Color.Coral;
            }

        }

    }
}
