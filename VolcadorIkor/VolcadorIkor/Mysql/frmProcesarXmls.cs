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

namespace VolcadorIkor.Mysql
{
    public partial class frmProcesarXmls : Form
    {
        #region PROPIEDADES
        DataTable _dtTemp = null;
        mSeguridad _mSecurity = new mSeguridad();
        #endregion PROPIEDADES
        #region CONSTRUCTORES
        public frmProcesarXmls()
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

            if (Properties.Settings.Default.cModo == "M")
            {
                rbtnManual.Checked = true;
            }
            else if (Properties.Settings.Default.cModo == "A")
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

            strCommand = "SHOW FULL TABLES FROM mysql";


            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //Consulta->>
                dsReturn =
                    MYSQL.MySqlHelper.ExecuteDataSet(_mSecurity.strConnection, strCommand);
                if (dsReturn.Tables[0].Rows.Count > 0)
                {
                  //ok->>
                }

            }
            catch (Exception EX)
            {
                dsReturn = null;
                strSalida = EX.Message + " \r\n \r\n "
                    + " \r\n \r\n - Verifique la configuracion de los parametros del servidor.";

                //Envia correo error en la conexion->>
                fn_envioCorreoAutomatizado(strSalida);

                //Se detiene el monitor para evitar que se sigan enviando correos ->>
                timerMonitorConexion.Stop();
                timerMonitorConexion.Enabled = false;

                //De detiene el daemon ->>
                TSBTN_STOP_Click(null,null);

                
            }  
        } 
        private void rbtnManual_CheckedChanged(object sender, EventArgs e)
        {
            panelAutomatico.Visible = false;
            panelManual.Visible = true;
            Properties.Settings.Default.cModo = "M";
            Properties.Settings.Default.Save();
        }
        private void rbtnAutomatico_CheckedChanged(object sender, EventArgs e)
        {
            panelManual.Visible = false;
            panelAutomatico.Visible = true;
            Properties.Settings.Default.cModo = "A";
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
            dlAbrir.Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
            dlAbrir.Title = "Seleccionar fichero XML a dividir y separar páginas";

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

            //frmConsulta->>
            if (_dtTemp.Rows.Count > 0)
            {
                frmConsulta _FRMCONN = new frmConsulta(0);
                _FRMCONN.StartPosition = FormStartPosition.Manual;
                _FRMCONN.Location = new Point(600, 10);
                _FRMCONN.bLeeItem = true;
                _FRMCONN.GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                _FRMCONN.GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                _FRMCONN.Text = "- Xml(s) -   ";
                _FRMCONN.Seleccionar.Text = "- Archivo(s) a procesar a la base de datos";
                _FRMCONN.Size = new System.Drawing.Size(600, 250);
                _FRMCONN.dt = _dtTemp.Copy();
                _FRMCONN.Show();
            }
            else {
                txtArchivo.Text = "";
            }

        }
        private void tsbProcesar_Click(object sender, EventArgs e)
        {
            //Dataset Xmls Volcados->>
            DataSet DS_XMLS = new DataSet();

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

            //Processo Lectura del XML->>
            try
            {
                foreach (DataRow DR in _dtTemp.Rows)
                {
                    //Leer XML->>
                    DataTable dt = _mSecurity.dtLeerXML(DR[0].ToString().Trim());
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        //FILL THE DATASET->>
                        DS_XMLS.Tables.Add(dt);
                    }                   
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show("- Ocurrió un error al leer el XML: \n\r" + EX.Message,
                          "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            //Processo Insert en DB->>
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

            try
            {

                if (DS_XMLS.Tables.Count > 0)
                {
                    //Ciclo por ImageBarcode->>
                    foreach (DataTable DTEMP in DS_XMLS.Tables)
                    {
                        //Error Lectura-Validacion XML->>
                        if (DTEMP.Columns.Count == 3)
                        {
                            try
                            {
                                //BITACORA DE LOS QUE NO PASARON LA PRUEBA ->>
                                dtInsertaBitacora(DTEMP.Rows[0][0].ToString(), DTEMP.Rows[0][1].ToString(), DTEMP.Rows[0][2].ToString(), DateTime.Now.ToString());
                            }
                            catch { }
                            
                            DataRow DR0 = dtMensajesOutInc.NewRow();
                            DR0[0] = DTEMP.Rows[0][0].ToString().Trim();
                            DR0[1] = DTEMP.Rows[0][1].ToString().Trim();
                            DR0[2] = DTEMP.Rows[0][2].ToString().Trim(); 
                            dtMensajesOutInc.Rows.Add(DR0);
                            
                            continue;                            
                        }

                        //Process Volk->>
                        foreach (DataRow ROW in DTEMP.Rows)
                        {
                            DataTable dTOUT = dtVolcado(ROW[0].ToString().Trim()
                                           , ROW[1].ToString().Trim()
                                           , ROW[2].ToString().Trim()
                                           , ROW[3].ToString().Trim()
                                           , ROW[4].ToString().Trim()
                                           , ROW[5].ToString().Trim()
                                           , ROW[6].ToString().Trim()
                                           , ROW[7].ToString().Trim()
                                           , ROW[8].ToString().Trim());

                            //Salida Mensaje->>
                            if (dTOUT.Rows.Count > 0)
                            {
                                if (dTOUT.Rows[0][0].ToString().Trim() == "PRO")
                                {
                                    DataRow DR1 = dtMensajesOut.NewRow();
                                    DR1[0] = dTOUT.Rows[0][0].ToString().Trim();
                                    DR1[1] = dTOUT.Rows[0][1].ToString().Trim();
                                    DR1[2] = "Se ha abonado correctamente el registro del NumeroPCB=>> " + ROW[0].ToString().Trim()
                                        + " del archivo =>> " + DTEMP.TableName + ".";
                                    dtMensajesOut.Rows.Add(DR1);
                                }
                                else
                                {
                                    DataRow DR0 = dtMensajesOutInc.NewRow();
                                    DR0[0] = dTOUT.Rows[0][0].ToString().Trim();
                                    DR0[1] = dTOUT.Rows[0][1].ToString().Trim();
                                    DR0[2] = "Ha ocurrido un error en el insertado del NumeroPCB=>> " + ROW[0].ToString().Trim()
                                        + " " + dTOUT.Rows[0][1].ToString().Trim()
                                        + " Del archivo =>> " + DTEMP.Rows[0][1].ToString().Trim() + ".";
                                    dtMensajesOutInc.Rows.Add(DR0);

                                }
                            }
                            
                        }

                        try
                        {
                            //BITACORA DE LOS QUE PASARON LA PRUEBA ->>
                            dtInsertaBitacora("PRO", DTEMP.TableName.ToString(), "Operacion realizada correctamente.", DateTime.Now.ToString());
                        }
                        catch { }
                    
                    
                    }


                }

                //Fin Processo->>
                DialogResult _DRs = MessageBox.Show("Ha finalizado correctamente el proceso de volcado de información"
                + "\n\r- ¿Desea visualizar la bitacora de resultados *** INCORRECTOS *** ?",
                          "Mensaje del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (_DRs == DialogResult.No)
                {
                    //frmConsulta->>
                    if (dtMensajesOut.Rows.Count > 0)
                    {
                        frmConsulta _FRMCONN = new frmConsulta(0);
                        _FRMCONN.StartPosition = FormStartPosition.Manual;
                        _FRMCONN.Location = new Point(600, 10);
                        _FRMCONN.bLeeItem = true;
                        _FRMCONN.GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        _FRMCONN.Text = "- Xml(s) -   ";
                        _FRMCONN.Seleccionar.Text = "- Bitácora de Xmls *** PROCESADOS *** ";
                        _FRMCONN.Size = new System.Drawing.Size(600, 450);
                        _FRMCONN.dt = dtMensajesOut.Copy();
                        _FRMCONN.Show();
                        uctrlTablaConFiltroResultados.DataSource = null;


                        //Bitacora->>
                        uctrlTablaConFiltroResultados.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        uctrlTablaConFiltroResultados.DataSource = dtMensajesOut.Copy();

                        return;
                    }
                }
                else
                {
                    //Consulta Bitácora->>
                    if (dtMensajesOutInc.Rows.Count > 0)
                    {
                        frmConsulta _FRMCONN = new frmConsulta(0);
                        _FRMCONN.StartPosition = FormStartPosition.Manual;
                        _FRMCONN.Location = new Point(600, 10);
                        _FRMCONN.bLeeItem = true;
                        _FRMCONN.GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        _FRMCONN.Text = "- Xml(s) -   ";
                        _FRMCONN.Seleccionar.Text = "- Bitácora de Xmls *** INCORRECTOS *** ";
                        _FRMCONN.Size = new System.Drawing.Size(600, 450);
                        _FRMCONN.dt = dtMensajesOutInc.Copy();
                        _FRMCONN.Show();
                        uctrlTablaConFiltroResultados.DataSource = null;

                        //Bitacora->>
                        uctrlTablaConFiltroResultados.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        uctrlTablaConFiltroResultados.DataSource = dtMensajesOutInc.Copy();
                    }
                    else
                    {
                        //Mensaje dt->
                        DataTable dTP = new DataTable();
                        DataColumn DC = new DataColumn("Mensaje del Sistema");
                        dTP.Columns.Add(DC);
                        DataRow DRo = dTP.NewRow();
                        DRo[0] = " [NO] se han producido errores en el proceso, puede usted continuar.";
                        dTP.Rows.Add(DRo);

                        frmConsulta _FRMCONN = new frmConsulta(0);
                        _FRMCONN.StartPosition = FormStartPosition.Manual;
                        _FRMCONN.Location = new Point(600, 10);
                        _FRMCONN.bLeeItem = true;
                        _FRMCONN.GrdDatos.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        _FRMCONN.Text = "- Xml(s) -   ";
                        _FRMCONN.Seleccionar.Text = "- Bitácora de Xmls - Incorrectos - ";
                        _FRMCONN.Size = new System.Drawing.Size(600, 450);
                        _FRMCONN.dt = dTP.Copy();
                        _FRMCONN.Show();
                        uctrlTablaConFiltroResultados.DataSource = null;

                        //Bitacora->>
                        uctrlTablaConFiltroResultados.gridDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        uctrlTablaConFiltroResultados.DataSource = dTP.Copy();


                    
                    }


                }

            }
            catch (Exception EX)
            {
                MessageBox.Show("- Ocurrió un error al Insertar los Registros en MYSQL: \n\r" + EX.Message,
                          "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
        private void tsbLimpiar_Click(object sender, EventArgs e)
        {
            _dtTemp = null;
            uctrlTablaConFiltroResultados.gridDatos.DataSource = null;
            txtArchivo.Text = "";
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
        private DataTable dtVolcado(string strNumeroPCB, string strNumeroSerialPanel, string strNumerodeProduccion, string strModelo
          , string strDobleBinning, string strBinning1, string strBinning2, string strPasoDeLaRuta, string strNumeroDeSet)
        {
            //Mensaje de Salida->>
            DataTable dtRET = new DataTable("REGISTRO_INSERTADO");
            DataColumn dc00 = new DataColumn("chEstatus");
            DataColumn dc11 = new DataColumn("vchArchivo");
            DataColumn dc22 = new DataColumn("vchDescripcion");
            dtRET.Columns.Add(dc00);
            dtRET.Columns.Add(dc11);
            dtRET.Columns.Add(dc22);

            //Comando->>
            string strCommand =
            "INSERT INTO  tblinfopcb (NumeroPCB,NumeroSerialPanel,NumerodeProduccion,Modelo,DobleBinning,Binning1,Binning2,PasoDeLaRuta,NumeroDeSet)" +
            "VALUES (@NumeroPCB,@NumeroSerialPanel,@NumerodeProduccion,@Modelo,@DobleBinning,@Binning1,@Binning2,@PasoDeLaRuta,@NumeroDeSet)";

            //Mysql->>
            MySqlConnection _conn = new MySqlConnection(_mSecurity.strConnection);
            MySqlCommand _cmd;

            try
            {
                _conn.Open();
                _cmd = _conn.CreateCommand();
                _cmd.CommandText = strCommand;
                _cmd.Parameters.AddWithValue("@NumeroPCB", strNumeroPCB);
                _cmd.Parameters.AddWithValue("@NumeroSerialPanel", strNumeroSerialPanel);
                _cmd.Parameters.AddWithValue("@NumerodeProduccion", strNumerodeProduccion);
                _cmd.Parameters.AddWithValue("@Modelo", strModelo);
                _cmd.Parameters.AddWithValue("@DobleBinning", strDobleBinning);
                _cmd.Parameters.AddWithValue("@Binning1", strBinning1);
                _cmd.Parameters.AddWithValue("@Binning2", strBinning2);
                _cmd.Parameters.AddWithValue("@PasoDeLaRuta", strPasoDeLaRuta);
                _cmd.Parameters.AddWithValue("@NumeroDeSet", strNumeroDeSet);
                _cmd.ExecuteNonQuery();

                //Salida Positiva->>
                DataRow dr = dtRET.NewRow();
                dr[0] = "PRO";
                dr[1] = System.IO.Path.GetFileName(txtArchivo.Text);
                dr[2] = "Operación realizada satisfactoriamente.";
                dtRET.Rows.Add(dr);

            }
            catch (Exception EX)
            {
                //Salida Negativa->>
                DataRow dr = dtRET.NewRow();
                dr[0] = "0";
                dr[1] = "- Ocurrió un error al Insertar los Registros en MYSQL: \n\r" + EX.Message;
                dtRET.Rows.Add(dr);
            }
            finally {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }            
            }

            return dtRET;

        }

        private DataTable dtInsertaBitacora(string strEstatus, string strvchArchivo, string strvchDescripcion, string strFecha)
        {
            //Mensaje de Salida->>
            DataTable dtRET = new DataTable("REGISTRO_INSERTADO");
            DataColumn DC1 = new DataColumn("idSalida");
            DataColumn DC2 = new DataColumn("vchMensaje");
            dtRET.Columns.Add(DC1);
            dtRET.Columns.Add(DC2);

            //Comando->>
            string strCommand =
            "INSERT INTO tblBitacoraProceso (idBP ,chEstatus , vchArchivo , vchDescripcion, vchFecha) VALUES (NULL ,@chEstatus  , @vchArchivo , @vchDescripcion , @vchFecha);";

            //Mysql->>
            MySqlConnection _conn = new MySqlConnection(_mSecurity.strConnection);
            MySqlCommand _cmd;

            try
            {
                _conn.Open();
                _cmd = _conn.CreateCommand();
                _cmd.CommandText = strCommand;
                _cmd.Parameters.AddWithValue("@chEstatus", strEstatus);
                _cmd.Parameters.AddWithValue("@vchArchivo", strvchArchivo);
                _cmd.Parameters.AddWithValue("@vchDescripcion", strvchDescripcion);
                _cmd.Parameters.AddWithValue("@vchFecha", strFecha);
                _cmd.ExecuteNonQuery();

                //Salida Positiva->>
                DataRow dr = dtRET.NewRow();
                dr[0] = "1";
                dr[1] = "Operación realizada satisfactoriamente.";
                dtRET.Rows.Add(dr);

            }
            catch (Exception EX)
            {
                //Salida Negativa->>
                DataRow dr = dtRET.NewRow();
                dr[0] = "0";
                dr[1] = "- Ocurrió un error al Insertar los Registros en MYSQL: \n\r" + EX.Message;
                dtRET.Rows.Add(dr);
            }
            finally
            {
                if (_conn.State == ConnectionState.Open)
                {
                    _conn.Close();
                }
            }

            return dtRET;

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
                                + "Por medio de la presente, se notifica que se ha perdido la conexion con el servidor de mysql, "
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

        private void vInicioTimerMonitorConn()
        {
            timerMonitorConexion.Start();
            timerMonitorConexion.Enabled = true;
            timerMonitorConexion.Interval = Convert.ToInt32(Properties.Settings.Default.strMiliTimerConn);            
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
        #endregion UTIL 
    }
}
