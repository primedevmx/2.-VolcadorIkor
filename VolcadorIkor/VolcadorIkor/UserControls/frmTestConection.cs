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
    public partial class frmTestConection : Form
    {
        mSeguridad _mSecurity = new mSeguridad();

        string _strConn = "";

        public frmTestConection()
        {
            InitializeComponent();
        }

        public frmTestConection(string strConn, string strName)
        {
            InitializeComponent();
            try
            {
                _strConn = strConn;
                string[] strArrK = _strConn.Split(';');
                //IP->>
                lblIP.Text = strArrK[0].Substring(7);
                //Serever->>
                labelNombreServer.Text = strArrK[2].Substring(9);
            }
            catch { }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            DataSet dsReturn = new DataSet("ParametrosAPP");
            string strCommand = "";
            string strSalida = "";

            strCommand = "SHOW FULL TABLES FROM mysql";
                       
            
            Cursor.Current = Cursors.WaitCursor;

                try
                {
                    //Consulta->>
                    dsReturn =
                        MYSQL.MySqlHelper.ExecuteDataSet(_strConn, strCommand);
                    if (dsReturn.Tables[0].Rows.Count > 0)
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
