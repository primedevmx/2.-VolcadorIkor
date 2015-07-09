using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Windows.Forms;


namespace VolcadorIkor.SqlServer
{
    public partial class frmProcesarDATs : Form
    {
        #region PROPIEDADES
        DataTable _dtTemp = null;
        mSeguridad _mSecurity = new mSeguridad();
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmProcesarDATs()
        {
            InitializeComponent();
        }
        #endregion CONSTRUCTORES
        #region EVENTOS
        #region VENTANA
        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            //GroupBox->>
            groupBox6.Text = "Bitácora del proceso -> Reporitorio -> [" + Properties.Settings.Default.strRepoXMLs + "]";

            if (Properties.Settings.Default.cModoD == "M")
            {
                rbtnManual.Checked = true;
            }
            else if (Properties.Settings.Default.cModoD == "A")
            {
                rbtnAutomatico.Checked = true;
            }

            //Timer->>
            vInicioTimerMonitorConn();

        }
        //Monitor de la conexion->>
        private void OnTimer_timerMonitorConexion_Event(object sender, EventArgs e)
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
                    Microsoft.ApplicationBlocks.Data.SqlHelper.ExecuteDataset(_mSecurity.strConnSQL, CommandType.Text, strCommand);


                if (dsReturn.Tables[0].Rows.Count > 0)
                {
                    //ok->>
                }

            }
            catch (Exception EX)
            {
                dsReturn = null;
                strSalida = EX.Message + " \r\n \r\n "
                    + " \r\n \r\n - Verifique la configuracion de los parametros del servidor sql.";

                //Envia correo error en la conexion->>
                fn_envioCorreoAutomatizado(strSalida);

                //Se detiene el monitor para evitar que se sigan enviando correos ->>
                timerMonitorConexion.Stop();
                timerMonitorConexion.Enabled = false;

                //De detiene el daemon ->>
                TSBTN_STOP_Click(null, null);


            }

            
        }
        private void rbtnManual_CheckedChanged(object sender, EventArgs e)
        {
            panelAutomatico.Visible = false;
            panelManual.Visible = true;
            Properties.Settings.Default.cModoD = "M";
            Properties.Settings.Default.Save();
        }
        private void rbtnAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            panelManual.Visible = false;
            panelAutomatico.Visible = true;
            Properties.Settings.Default.cModoD = "A";
            Properties.Settings.Default.Save();
        }
        private void tsbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion VENTANA
        #region MANUAL
        private void btnSeleccionarArchivos_Click(object sender, EventArgs e)
        {
            //Limpiar->>
            tsbLimpiar_Click(null,null);
            //Tabla Temporal->>
            _dtTemp = new DataTable("ArchivosProcesar");
            DataColumn dC = new DataColumn("Archivo(s)_a_procesar");
            _dtTemp.Columns.Add(dC);

            //Dialog prop->>
            dlAbrir.CheckFileExists = true;
            dlAbrir.CheckPathExists = true;
            dlAbrir.Multiselect = true;
            dlAbrir.DefaultExt = "xml";
            dlAbrir.FileName = "";
            dlAbrir.Filter = "Archivos XML (*.xml)|*.xml|DAT Files (*.dat)|*.dat";
            dlAbrir.Title = "Seleccionar fichero XML o DAT a dividir y separar páginas";

            //Dialog->>
            if (dlAbrir.ShowDialog() == DialogResult.OK)
            {
                foreach (string str in dlAbrir.FileNames)
                {
                    DataRow dR = _dtTemp.NewRow();
                    dR[0] = str;
                    _dtTemp.Rows.Add(dR);
                    txtArchivo.Text += str + ";";
                }
            }

        }
        private void tsbProcesar_Click(object sender, EventArgs e)
        {
            #region PREVIAS VALIDACIONES
            //Dataset Xmls Volcados->>
            DataSet DS_XMLS = new DataSet();
            DataSet _DS_DATS = new DataSet();
            string STR_TIPO = "";

            //Previa Validacion->>
            if (_dtTemp == null || _dtTemp.Rows.Count == 0)
            {
                MessageBox.Show("- Favor de seleccionar uno o mas [Xml(s)] a procesar.",
                            "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult _DR = MessageBox.Show("Se encuentra apunto de volcar a la base de datos " + Convert.ToString(_dtTemp.Rows.Count) + " archivo(s)."
                + "\n\r- ¿Está correcta la información?",
                            "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_DR == DialogResult.No)
            {
                return;
            }
            #endregion PREVIAS VALIDACIONES

            try
            {
                #region DEFINICION DE VARIABLES
                //Mensaje Correcto->>
                DataTable dtMensajesOut = new DataTable("Mensajes_Salida");
                DataColumn dCArchivo = new DataColumn("chEstatus");
                DataColumn dCNumeroPCB = new DataColumn("vchArchivo");
                DataColumn dCMensaje = new DataColumn("vchDescripcion");
                dtMensajesOut.Columns.Add(dCArchivo);
                dtMensajesOut.Columns.Add(dCNumeroPCB);
                dtMensajesOut.Columns.Add(dCMensaje);

                //Mensaje InCorrecto->>
                DataTable dtMensajesOutInc = new DataTable("Mensajes_Salida");
                DataColumn dCArchivoInc = new DataColumn("chEstatus");
                DataColumn dCNumeroPCBInc = new DataColumn("vchArchivo");
                DataColumn dCMensajeInc = new DataColumn("vchDescripcion");
                dtMensajesOutInc.Columns.Add(dCArchivoInc);
                dtMensajesOutInc.Columns.Add(dCNumeroPCBInc);
                dtMensajesOutInc.Columns.Add(dCMensajeInc);
                #endregion DEFINICION DE VARIABLES
                #region LEER ARCHIVOS XMLS-DAT
                //Processo Lectura del XML->>            
                foreach (DataRow DR in _dtTemp.Rows)
                {
                    STR_TIPO = System.IO.Path.GetExtension(_dtTemp.Rows[0][0].ToString().Trim());
                    //Leer XML->>
                    if (STR_TIPO.ToUpper().Trim() == ".XML")
                    {
                        DataTable dt = _mSecurity.dtLeerXML_SQL(DR[0].ToString().Trim());
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            //FILL THE DATASET->>
                            DS_XMLS.Tables.Add(dt);
                        }
                    }
                    else if (STR_TIPO.ToUpper().Trim() == ".DAT")
                    {
                        DataTable dt = _mSecurity.dtLeerDAT(DR[0].ToString().Trim());
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            //FILL THE DATASET->>
                            _DS_DATS.Tables.Add(dt);
                        }
                    }

                }
                #endregion LEER ARCHIVOS XMLS-DAT

            try
            {
                #region FOREACH ARCHIVOS XML
                if (STR_TIPO.ToUpper().Trim() == ".XML")
                {
                    foreach (DataTable DTT in DS_XMLS.Tables)
                    {
                        //Error Lectura-Validacion XML->>
                        if (DTT.Columns.Count == 3)
                        {
                            DataRow DR0 = dtMensajesOutInc.NewRow();
                            DR0[0] = DTT.Rows[0][0].ToString().Trim();
                            DR0[1] = DTT.Rows[0][1].ToString().Trim();
                            DR0[2] = DTT.Rows[0][2].ToString().Trim();
                            dtMensajesOutInc.Rows.Add(DR0);

                            continue;
                        }

                        //Process Volk->>
                        DataTable DT_VOLK_SQL = _mSecurity.dtVolcadoSQL(DTT.Rows[0][0].ToString().Trim()
                            , DTT.Rows[0][1].ToString().Trim(), DTT.Rows[0][2].ToString().Trim(), DTT.Rows[0][3].ToString().Trim());

                        if ((DT_VOLK_SQL != null && DT_VOLK_SQL.Rows.Count > 0) && DT_VOLK_SQL.Rows[0][0].ToString().Trim() == "OK")
                        {
                            DataRow DR1 = dtMensajesOut.NewRow();
                            DR1[0] = DTT.Rows[0][0].ToString().Trim();
                            DR1[1] = DTT.Rows[0][1].ToString().Trim();
                            DR1[2] = "Se ha ejecutado correctamente el proceso de la Serie=>> " + DTT.Rows[0][0].ToString().Trim()
                                + " del archivo =>> " + DTT.TableName.ToString().Trim() + ".";
                            dtMensajesOut.Rows.Add(DR1);

                        }
                        else
                        {
                            DataRow DR0 = dtMensajesOutInc.NewRow();
                            DR0[0] = DTT.Rows[0][0].ToString().Trim();
                            DR0[1] = DTT.Rows[0][1].ToString().Trim();
                            DR0[2] = "Ha ocurrido un error en el insertado del Serie=>> " + DTT.Rows[0].ToString().Trim()
                                + " " + DTT.Rows[0][1].ToString().Trim()
                                + " Del archivo =>> " + DTT.TableName.ToString().Trim() + ".";
                            dtMensajesOutInc.Rows.Add(DR0);

                        }

                        #region RESPALDO DE ARCHIVO PROCESADO
                        if (Convert.ToBoolean(Properties.Settings.Default.bAplicaResp))
                        {
                            //Respaldo proceso ->>
                            try
                            {
                                string [] str = txtArchivo.Text.Split(';');
                                string strRuta = System.IO.Path.GetDirectoryName(str[0]);
                                //Copiar archivo->
                                System.IO.File.Copy(strRuta + "\\" + DTT.TableName.ToString().Trim()
                                    , Properties.Settings.Default.strRespaldoSQL + "\\" + DTT.TableName.ToString().Trim(), true);

                                if (System.IO.File.Exists(strRuta + "\\" + DTT.TableName.ToString().Trim()))
                                {
                                    try
                                    {
                                        System.IO.File.Delete(strRuta + "\\" + DTT.TableName.ToString().Trim());
                                    }
                                    catch { }

                                }
                            }
                            catch { }

                        }
                        #endregion RESPALDO DE ARCHIVO PROCESADO

                    }//FOREACH XMLS
                }
                #endregion FOREACH ARCHIVOS XML
                #region FOREACH ARCHIVOS DAT
                if (STR_TIPO.ToUpper().Trim() == ".DAT")
                {
                    foreach (DataTable DTT in _DS_DATS.Tables)
                    {

                        //Error Lectura-Validacion XML->>
                        if (DTT.Columns.Count == 3)
                        {
                            DataRow DR0 = dtMensajesOutInc.NewRow();
                            DR0[0] = DTT.Rows[0][0].ToString().Trim();
                            DR0[1] = DTT.Rows[0][1].ToString().Trim();
                            DR0[2] = DTT.Rows[0][2].ToString().Trim();
                            dtMensajesOutInc.Rows.Add(DR0);

                            continue;
                        }

                        //VOLK->>
                        DataTable dtDAT 
                            = _mSecurity.dtVolcadoDat(DTT.Rows[0][1].ToString().Trim(), DTT.TableName.ToString().Trim(),
                           Convert.ToInt32(DTT.Rows[0][3].ToString().Trim()) ,Convert.ToInt32(DTT.Rows[0][4].ToString().Trim()));

                        if ((dtDAT != null && dtDAT.Rows.Count > 0) && dtDAT.Rows[0][0].ToString().Trim() == "OK")
                        {
                            DataRow DR1 = dtMensajesOut.NewRow();
                            DR1[0] = DTT.Rows[0][0].ToString().Trim();
                            DR1[1] = DTT.Rows[0][1].ToString().Trim();
                            DR1[2] = "Se ha ejecutado correctamente el proceso de la Serie=>> " + DTT.Rows[0][1].ToString().Trim()
                                + " del archivo =>> " + DTT.TableName.ToString().Trim() + ".";
                            dtMensajesOut.Rows.Add(DR1);

                        }
                        else
                        {
                            DataRow DR0 = dtMensajesOutInc.NewRow();
                            DR0[0] = DTT.Rows[0][0].ToString().Trim();
                            DR0[1] = DTT.Rows[0][1].ToString().Trim();
                            DR0[2] = "Ha ocurrido un error en el insertado del Serie=>> " + DTT.Rows[0][0].ToString().Trim()
                                + " " + DTT.Rows[0][1].ToString().Trim()
                                + " Del archivo =>> " + DTT.TableName.ToString().Trim() + ".";
                            dtMensajesOutInc.Rows.Add(DR0);

                        }

                        #region TXT
                        //Genera TXT->>
                        DataSet DS_TXT = _mSecurity.dtLeerDatosTXT(DTT.Rows[0][1].ToString().Trim());
                        try
                        {                            
                            string fic = Properties.Settings.Default.strRepoTXTs + DS_TXT.Tables[0].Rows[0][1].ToString().Trim() + ".txt";
                            string texto = DS_TXT.Tables[0].Rows[0][1].ToString().Trim()+","+DS_TXT.Tables[0].Rows[0][3].ToString().Trim()+","+DS_TXT.Tables[0].Rows[0][4].ToString().Trim()+","+DS_TXT.Tables[0].Rows[0][5].ToString().Trim();

                            System.IO.StreamWriter sw = new System.IO.StreamWriter(fic);
                            sw.WriteLine(texto);
                            sw.Close();
                        }
                        catch { }
                        #endregion TXT

                        #region RESPALDO DE ARCHIVO PROCESADO
                        if (Convert.ToBoolean(Properties.Settings.Default.bAplicaResp))
                        {
                            //Respaldo proceso ->>
                            try
                            {
                                string[] str = txtArchivo.Text.Split(';');
                                string strRuta = System.IO.Path.GetDirectoryName(str[0]);
                                //Copiar archivo->
                                System.IO.File.Copy(strRuta + "\\" + DTT.TableName.ToString().Trim()
                                    , Properties.Settings.Default.strRespaldoSQL + "\\" + DTT.TableName.ToString().Trim(), true);

                                if (System.IO.File.Exists(strRuta + "\\" + DTT.TableName.ToString().Trim()))
                                {
                                    try
                                    {
                                        System.IO.File.Delete(strRuta + "\\" + DTT.TableName.ToString().Trim());
                                    }
                                    catch { }

                                }
                            }
                            catch { }

                        }
                        #endregion RESPALDO DE ARCHIVO PROCESADO

                    }//FOREACH DATS

                }
                #endregion FOREACH ARCHIVOS DAT
            }
            catch(Exception EX) {
                    MessageBox.Show("- Ocurrió un error en SQL: \n\r" + EX.Message,
                            "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

              #region SALIDA DEL PROCESO MANUAL  

             //frmConsulta->>
                if (dtMensajesOut.Rows.Count > 0)
                {
                    //Bitacora->>
                    uctrlTablaConFiltroResultados.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    uctrlTablaConFiltroResultados.DataSource = dtMensajesOut.Copy();

                    //Consulta Bitácora->>
                    if (dtMensajesOutInc.Rows.Count > 0)
                    {
                        foreach (DataRow DRRR in dtMensajesOutInc.Rows)
                        {
                            dtMensajesOut.ImportRow(DRRR);
                        }

                        //Bitacora->>
                        uctrlTablaConFiltroResultados.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        uctrlTablaConFiltroResultados.DataSource = dtMensajesOut.Copy();
                        
                    }
     
                }

                #endregion SALIDA DEL PROCESO MANUAL    


            }catch (Exception EX) {
                MessageBox.Show("- Ocurrió un error al leer el XML: \n\r" + EX.Message,
                          "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }
        private void tsbLimpiar_Click(object sender, EventArgs e)
        {
            try
            {
                _dtTemp = null;
                uctrlTablaConFiltroResultados.gridDatos.DataSource = null;
                uctrlTablaConFiltroResultados.gridDatos = null;
                txtArchivo.Text = "";
            }
            catch { }
        }
        #endregion MANUAL
        #region AUTOMATICO
        private void TSBTN_START_Click(object sender, EventArgs e)
        {
            #region VENTANA
            tsbEstatusDaemon.Text = " Estatus - Activado <- ";
            tsbEstatusDaemon.ForeColor = Color.LightGreen;
            TSBTN_START.Enabled = false;
            TSBTN_STOP.Enabled = true;
            groupBox5.Text = "Opciones del modo automatico ->> Estatus - Activado";
            #endregion VENTANA

            //Timer->>
            vInicioTimerMonitorConn();

        }
        private void TSBTN_STOP_Click(object sender, EventArgs e)
        {
            #region VENTANA
            TSBTN_START.Enabled = true;
            tsbEstatusDaemon.Text = " Estatus - Detenido <- ";
            tsbEstatusDaemon.ForeColor = Color.White;
            TSBTN_STOP.Enabled = false;
            groupBox5.Text = "Opciones del modo automatico ->> Estatus - Detenido";
            #endregion VENTANA
        }
        #endregion AUTOMATICO
        #endregion EVENTOS
        #region METODOS
       
        private void vInicioTimerMonitorConn()
        {
            timerMonitorConexion.Start();
            timerMonitorConexion.Enabled = true;
            timerMonitorConexion.Interval = Convert.ToInt32(Properties.Settings.Default.strMiliTimerConnSQL);
        }

        #endregion METODOS
        #region UTIL
        private void mouseSobreControl(object sender, EventArgs e)
        {

            try
            {
                string strTipo = sender.GetType().ToString();
                switch (strTipo)
                {
                    case "System.Windows.Forms.ToolStripDropDownButton":
                        {
                            ToolStripDropDownButton tsdddbGral = (ToolStripDropDownButton)sender;
                            tsdddbGral.ForeColor = Color.Black;
                            break;
                        }
                    case "System.Windows.Forms.ToolStripMenuItem":
                        {
                            ToolStripMenuItem tsmiGral = (ToolStripMenuItem)sender;
                            tsmiGral.ForeColor = Color.Black;
                            break;
                        }
                    default:
                        {
                            ToolStripButton tsbtnGral = (ToolStripButton)sender;
                            tsbtnGral.ForeColor = Color.Black;
                            break;
                        }
                }
            }
            catch
            {

            }
        }
        private void mouseFueraControl(object sender, EventArgs e)
        {
            try
            {
                string strTipo = sender.GetType().ToString();
                switch (strTipo)
                {
                    case "System.Windows.Forms.ToolStripDropDownButton":
                        {
                            ToolStripDropDownButton tsdddbGral = (ToolStripDropDownButton)sender;
                            tsdddbGral.ForeColor = Color.White;
                            break;
                        }
                    case "System.Windows.Forms.ToolStripMenuItem":
                        {
                            ToolStripMenuItem tsmiGral = (ToolStripMenuItem)sender;
                            tsmiGral.ForeColor = Color.White;
                            break;
                        }
                    default:
                        {
                            ToolStripButton tsbtnGral = (ToolStripButton)sender;
                            tsbtnGral.ForeColor = Color.White;
                            break;
                        }
                }
            }
            catch
            {

            }
        }
        private void fn_envioCorreoAutomatizado(string strMsgErr)
        {
            try
            {
                char[] cCut = { ',', ';', ':', '-', ' ' };
                string[] strPara = Properties.Settings.Default.strCuentaReceptora.ToString().Split(cCut);

                foreach (string strDato in strPara)
                {
                    string strMssg =
                          "<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">"
                        + "<HTML><HEAD><META http-equiv=Content-Type content=\"text/html; charset=iso-8859-1\">"
                        + "</HEAD>"
                        + "<BODY>"
                            + "<table align = 'center' width = 1200>"
                                + "<tr><td><font size = '3' face = 'Calibri'>Buen D&iacute;a,</font> " + strDato + " </td>"
                                + "<td align = 'right'><font size = '2' face = 'Calibri'>" + DateTime.Now.ToString("D") + "</font></td></tr>"
                            + "</table>"
                            + "<p><font size = '3' face = 'Calibri'>"
                                + "Por medio de la presente, se notifica que se ha perdido la conexion con el servidor sql, "
                                + "<br>y por consiguiente el daemon volcador ha sido detenido. " + DateTime.Now.ToString() + ".</br>"
                                + "<br> </br>"
                                + "<br> Mensaje del error: </br>"
                                + "<br>" + strMsgErr + "</br>"
                            + "</font></p>"
                            + "<p><font size = '3' face = 'Calibri'>"
                                + "[Daemon Ikor]."
                            + "</font></p>"
                            + "<p><font size = '1' face = 'Calibri'>"
                                + "<hr color = #E46C0A>"
                                + "Correo generado autom&aacute;ticamente desde el [Daemon Ikor]."
                            + "</font></p>"
                        + "</BODY>";

                    MailMessage message = new MailMessage();
                    MailAddress fromAddress = new MailAddress(Properties.Settings.Default.strCuentaEmisora);
                    MailAddress toAddress = new MailAddress(strDato, "");
                    message.From = fromAddress;
                    message.To.Add(toAddress);
                    message.Subject = "Daemon Ikor - Volcador Detenido";
                    message.Body = strMssg;
                    System.Net.Mime.ContentType mType = new System.Net.Mime.ContentType("text/html");
                    System.Net.Mail.AlternateView mView = System.Net.Mail.AlternateView.CreateAlternateViewFromString(strMssg, mType);
                    message.AlternateViews.Add(mView);
                    message.Priority = System.Net.Mail.MailPriority.High;
                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.Credentials = new System.Net.NetworkCredential(Properties.Settings.Default.strCuentaEmisora, Properties.Settings.Default.strContrasenaEmisora);
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(message);
                }

            }
            catch
            {
            }
        }

        #endregion UTIL
    }
}
