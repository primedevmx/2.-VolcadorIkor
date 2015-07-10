using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using System.Data.Common;
using System.IO;
using System.Xml;
using System.Linq;
using Microsoft.ApplicationBlocks.Data;

namespace VolcadorIkor
{
    public class mSeguridad
    {
        #region PROPIEDADES PRIVADAS
        //Int -->
        private int _idStatusPCB;

        //String-->
        private string _strUsuarioSistema = "";
        private string _strConnFB = "";
        private string _strConnSQL = "";
        private string _strStatusPCB = "";
        private string _strDescripcionEstatusPCB = "";

        //Bool-->
        private bool _bUsuarioAdmin = false;
        private bool _bUsuarioProduc = false;
        private bool _bAplicaReglas = false;
        #endregion PROPIEDADES PRIVADAS
        #region PROPIEDADES PUBLICAS
        //Int-->
        public int idStatusPCB
        {
            get
            {
                return this._idStatusPCB;
            }
            set
            {
                this._idStatusPCB = value;
            }
        }
        //String-->
        public string strUsuarioSistema
        {
            get
            {
                return this._strUsuarioSistema;
            }
            set
            {
                this._strUsuarioSistema = value;
            }
        }
        //String-->
        public string strStatusPCB
        {
            get
            {
                return this._strStatusPCB;
            }
            set
            {
                this._strStatusPCB = value;
            }
        }
        //String-->
        public string strDescripcionEstatusPCB
        {
            get
            {
                return this._strDescripcionEstatusPCB;
            }
            set
            {
                this._strDescripcionEstatusPCB = value;
            }
        }
        //String Connection->>
        public string strConnection
        {
            get
            {
                return this._strConnFB = Properties.Settings.Default.InstanciaServerMysql;
            }
            set
            {
                this._strConnFB = value;
            }
        }
        public string strConnSQL
        {
            get
            {
                return this._strConnSQL = Properties.Settings.Default.InstanciaServerSql;
            }
            set
            {
                this._strConnSQL = value;
            }
        }
       
        //Bool-->
        public bool bUsuarioAdmin
        {
            get
            {
                return this._bUsuarioAdmin;
            }
            set
            {
                this._bUsuarioAdmin = value;
            }
        }
        public bool bUsuarioProduc
        {
            get
            {
                return this._bUsuarioProduc;
            }
            set
            {
                this._bUsuarioProduc = value;
            }
        }
        public bool bAplicaReglas
        {
            get
            {
                return this._bAplicaReglas;
            }
            set
            {
                this._bAplicaReglas = value;
            }
        }
        #endregion PROPIEDADES PUBLICAS
        #region METODOS PUBLICOS
        #region XML
        #region MYSQL
        public DataTable dtLeerXML(string strRutaArchivo)
        {
            //Datatable 1 ->>
            DataTable dtTemp = new DataTable(Path.GetFileName(strRutaArchivo));
            DataColumn dc0 = new DataColumn("NumeroPCB");
            DataColumn dc1 = new DataColumn("NumeroSerialPanel");
            DataColumn dc2 = new DataColumn("NumerodeProduccion");
            DataColumn dc3 = new DataColumn("Modelo");
            DataColumn dc4 = new DataColumn("DobleBinning");
            DataColumn dc5 = new DataColumn("Binning1");
            DataColumn dc6 = new DataColumn("Binning2");
            DataColumn dc7 = new DataColumn("PasoDeLaRuta");
            DataColumn dc8 = new DataColumn("NumeroDeSet");
            dtTemp.Columns.Add(dc0);
            dtTemp.Columns.Add(dc1);
            dtTemp.Columns.Add(dc2);
            dtTemp.Columns.Add(dc3);
            dtTemp.Columns.Add(dc4);
            dtTemp.Columns.Add(dc5);
            dtTemp.Columns.Add(dc6);
            dtTemp.Columns.Add(dc7);
            dtTemp.Columns.Add(dc8);

            //Datatable 2 ->>            
            DataTable dtTemp2 = new DataTable("tblinfopcb_" + Path.GetFileNameWithoutExtension(strRutaArchivo));
            DataColumn dc00 = new DataColumn("chEstatus");
            DataColumn dc11 = new DataColumn("vchArchivo");
            DataColumn dc22 = new DataColumn("vchDescripcion");
            dtTemp2.Columns.Add(dc00);
            dtTemp2.Columns.Add(dc11);
            dtTemp2.Columns.Add(dc22);
            
            //Variables del XML->>
            string strJobAssembly = "";
            string strJobName = "";
            string strBarcodeId = "";
            string strImageBarcodeId = "";

            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(strRutaArchivo);

                XmlNodeList xJob = xDoc.GetElementsByTagName("Job");
                XmlNodeList xBarcode = ((XmlElement)xJob[0]).GetElementsByTagName("Barcode");
                XmlNodeList xImageBarcode = ((XmlElement)xBarcode[0]).GetElementsByTagName("ImageBarcode");

                //Assembly y name->>
                foreach (XmlElement nodo in xJob)
                {
                    strJobAssembly = nodo.GetAttribute("assembly");
                    strJobName = nodo.GetAttribute("name");
                }

                //BarcodeId->>
                foreach (XmlElement nodo in xBarcode)
                {
                    strBarcodeId = nodo.GetAttribute("id");
                }

                //ImageBarcodeId->>
                foreach (XmlElement nodo in xImageBarcode)
                {
                    strImageBarcodeId = nodo.GetAttribute("id");

                    if (strJobAssembly.Trim() == "F16")
                    {
                        if (isInt32(strJobName))
                        {
                            //Correctos F16 y ES NUMERICO EL MODELO->>
                            DataRow DR = dtTemp.NewRow();
                            DR[0] = strImageBarcodeId;
                            DR[1] = strBarcodeId;
                            DR[2] = strJobAssembly;
                            DR[3] = strJobName;
                            DR[4] = "FALSE";
                            DR[5] = "DB";
                            DR[6] = "**";
                            DR[7] = "2";
                            DR[8] = "";
                            dtTemp.Rows.Add(DR);
                        }
                        else {

                            //InCorrectos ->>
                            DataRow DRo = dtTemp2.NewRow();
                            DRo[0] = "ERR";
                            DRo[1] = Path.GetFileName(strRutaArchivo);
                            DRo[2] = "ERROR - [jobname incorrecto]. ";
                            dtTemp2.Rows.Add(DRo);
                            return dtTemp2;  
                        
                        }
                        
                       
                    }
                    else
                    {
                        //InCorrectos ->>
                        DataRow DRo = dtTemp2.NewRow();
                        DRo[0] = "ERR";
                        DRo[1] = Path.GetFileName(strRutaArchivo);
                        DRo[2] = "ERROR - [jobassembly incorrecto]. ";
                        dtTemp2.Rows.Add(DRo);
                        return dtTemp2;                 
                    
                    }

                }

            }
            catch (XmlException EX){
                //Error de estructura->>
                //Mensaje dt->
                DataRow DRo = dtTemp2.NewRow();
                DRo[0] = "ERR";
                DRo[1] = Path.GetFileName(strRutaArchivo);
                DRo[2] = "ERROR LECTURA - [" + EX.Message + "]. "; 
                dtTemp2.Rows.Add(DRo);

                return dtTemp2;

            }



            return dtTemp;
        
        }
        public bool isInt32(String num)
        {
            try
            {
                Int32.Parse(num);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion MYSQL
        #region SQL
        public DataTable dtLeerXML_SQL(string strRutaArchivo)
        {
            //Datatable ->>
            DataTable dtTemp = new DataTable(Path.GetFileName(strRutaArchivo));
            DataColumn dc0 = new DataColumn("vchSerial");
            DataColumn dc1 = new DataColumn("vchStatus");
            DataColumn dc2 = new DataColumn("vchStarttime");
            DataColumn dc3 = new DataColumn("vchNombreArchivo");
            dtTemp.Columns.Add(dc0);
            dtTemp.Columns.Add(dc1);
            dtTemp.Columns.Add(dc2);
            dtTemp.Columns.Add(dc3);

            //Variables del XML->>
            string vchSerial = "";
            string vchStatus = "";
            string vchStarttime = "";
            string vchNombreArchivo = Path.GetFileName(strRutaArchivo);

            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(strRutaArchivo);

                XmlNodeList xSerial = xDoc.GetElementsByTagName("serial");
                XmlNodeList xStatus = xDoc.GetElementsByTagName("status");
                XmlNodeList xStarttime = xDoc.GetElementsByTagName("starttime");

                //xSerial->>
                foreach (XmlElement nodo in xSerial)
                {
                    vchSerial = nodo.InnerText;
                }

                //xStatus->>
                foreach (XmlElement nodo in xStatus)
                {
                    vchStatus = nodo.InnerText;
                }

                //xStarttime->>
                foreach (XmlElement nodo in xStarttime)
                {
                    vchStarttime = nodo.InnerText;
                }

                DataRow dRO = dtTemp.NewRow();
                dRO[0] = vchSerial;
                dRO[1] = vchStatus;
                dRO[2] = vchStarttime;
                dRO[3] = vchNombreArchivo;
                dtTemp.Rows.Add(dRO);
                

            }
            catch (XmlException EX)
            {
                //Error de estructura->>
                //Mensaje dt->
                DataRow DRo = dtTemp.NewRow();
                DRo[0] = "ERR";
                DRo[1] = Path.GetFileName(strRutaArchivo);
                DRo[2] = "ERROR LECTURA - [" + EX.Message + "]. ";
                dtTemp.Rows.Add(DRo);

                return dtTemp;

            }



            return dtTemp;

        }

        public DataTable dtVolcadoSQL(string strSerial, string strStatus, string strStarttime, string strNombreArchivo)
        {
            DataSet dTRet = new DataSet();
            try
            {
                SqlParameter[] arParms = new SqlParameter[8];

                arParms[0] = new SqlParameter("@vchSerial", strSerial);
                arParms[1] = new SqlParameter("@vchStatus", strStatus);
                arParms[2] = new SqlParameter("@vchStatusREV", "PEND");
                arParms[3] = new SqlParameter("@vchStarttime", strStarttime);
                arParms[4] = new SqlParameter("@vchNombreArchivo", strNombreArchivo);
                arParms[5] = new SqlParameter("@intTotalRev", 0);
                arParms[6] = new SqlParameter("@intRevCurso", 0);
                arParms[7] = new SqlParameter("@Accion", 2);

                dTRet = SqlHelper.ExecuteDataset(strConnSQL, CommandType.StoredProcedure, "spPCB_PcbMto", arParms);      
            
            
            }catch{
                dTRet = null;
            }

            return dTRet.Tables[0].Copy();
        }
        #endregion SQL
        #endregion XML
        #region MTO-STATUS
        public DataSet dtObtenerTablaStatusSQL()
        {
            DataSet dsRet = new DataSet();

            try
            {
                SqlParameter[] arParms = new SqlParameter[6];

                arParms[0] = new SqlParameter("@idStatusPCB", 0);
                arParms[1] = new SqlParameter("@vchStatus", "");
                arParms[2] = new SqlParameter("@vchDescripcion", "");
                arParms[3] = new SqlParameter("@bAplicaReglas", 0);
                arParms[4] = new SqlParameter("@bActivo", 0);
                arParms[5] = new SqlParameter("@Accion", 1);

                dsRet = SqlHelper.ExecuteDataset(strConnSQL, CommandType.StoredProcedure, "[dbo].[spPCB_StatusMto]", arParms);
            }
            catch
            {
                dsRet = null;
            }

            return dsRet;


        }
        public DataSet dtMtoStatus()
        {
            DataSet dsRet = new DataSet();

            try
            {
                SqlParameter[] arParms = new SqlParameter[6];

                arParms[0] = new SqlParameter("@idStatusPCB", idStatusPCB);
                arParms[1] = new SqlParameter("@vchStatus", strStatusPCB);
                arParms[2] = new SqlParameter("@vchDescripcion", strDescripcionEstatusPCB);
                arParms[3] = new SqlParameter("@bAplicaReglas", bAplicaReglas);
                arParms[4] = new SqlParameter("@bActivo", 1);
                arParms[5] = new SqlParameter("@Accion", 2);

                dsRet = SqlHelper.ExecuteDataset(strConnSQL, CommandType.StoredProcedure, "[dbo].[spPCB_StatusMto]", arParms);
            }
            catch
            {
                dsRet = null;
            }

            return dsRet;

        }
        public DataSet dtDesactivaStatus()
        {
            DataSet dsRet = new DataSet();

            try
            {
                SqlParameter[] arParms = new SqlParameter[6];

                arParms[0] = new SqlParameter("@idStatusPCB", idStatusPCB);
                arParms[1] = new SqlParameter("@vchStatus", "");
                arParms[2] = new SqlParameter("@vchDescripcion", "");
                arParms[3] = new SqlParameter("@bAplicaReglas", 0);
                arParms[4] = new SqlParameter("@bActivo", 0);
                arParms[5] = new SqlParameter("@Accion", 3);

                dsRet = SqlHelper.ExecuteDataset(strConnSQL, CommandType.StoredProcedure, "[dbo].[spPCB_StatusMto]", arParms);
            }
            catch 
            {
                dsRet = null;
            }

            return dsRet;
        }
        #endregion MTO-STATUS
        #region DAT
        public DataTable dtLeerDAT(string stRuta)
        {
            int counter = 0;
            int counterPCB = 0; //Revisiones encontradas
            int indexOF = 0;
            int totalRev = 0; //Total de Revisiones
            string line;
            string strPanel; //Descripcion del Panel
            string strSerie; //Serie de la revision

            //Datatable ->>
            DataTable dtTemp = new DataTable(Path.GetFileName(stRuta));
            DataColumn dc0 = new DataColumn("vchSerial");
            DataColumn dc1 = new DataColumn("vchStatus");
            DataColumn dc2 = new DataColumn("vchStarttime");
            DataColumn dc3 = new DataColumn("vchNombreArchivo");
            dtTemp.Columns.Add(dc0);
            dtTemp.Columns.Add(dc1);
            dtTemp.Columns.Add(dc2);
            dtTemp.Columns.Add(dc3);

            DataTable dtRET = new DataTable();
            DataColumn DC1 = new DataColumn("strNombreArchivo");
            DataColumn DC2 = new DataColumn("strSerie");
            DataColumn DC3 = new DataColumn("strDescripcionPanel");
            DataColumn DC4 = new DataColumn("intTotalRevisiones");
            DataColumn DC5 = new DataColumn("intFoundPCBs");
            dtRET.Columns.Add(DC1);
            dtRET.Columns.Add(DC2);
            dtRET.Columns.Add(DC3);
            dtRET.Columns.Add(DC4);
            dtRET.Columns.Add(DC5);

            DataRow DRO = dtRET.NewRow();
            dtRET.TableName = System.IO.Path.GetFileName(stRuta);
            DRO[0] = System.IO.Path.GetFileName(stRuta);



            try
            {
                System.IO.StreamReader file =
                    new System.IO.StreamReader(stRuta);

                while ((line = file.ReadLine()) != null)
                {
                    if (line.Contains("PCB"))
                    {
                        if (counter == 2)
                        {
                            //Obtener Descripcion Panel->>
                            indexOF = line.IndexOf("PCB");
                            if (indexOF != -1)
                            {
                                strPanel = line.Substring(75, 30);
                                DRO[2] = strPanel;
                                string[] strPs = strPanel.Trim().Split('(');
                                string[] strPs2 = strPs[1].Split(' ');
                                foreach (string strDato in strPs2)
                                {
                                    if (strDato != "")
                                    { 
                                        try{
                                            totalRev = Convert.ToInt32(strDato);
                                            DRO[3] = totalRev.ToString();
                                            break;
                                        }catch{}
                                    }
                                
                                }

                            }

                            //Serie->>
                            string [] spp = line.Split(',');
                            strSerie = spp[5];
                            DRO[1] = strSerie.Replace("\"", "");

                        }

                        counterPCB++; //No Veces del PCB en el Archivo (Revisiones)
                    }

                    counter++;
                }

                DRO[4] = counterPCB.ToString();
                
                file.Close();

                //Salida->>
                dtRET.Rows.Add(DRO);
            }
            catch (Exception EX){
                //Error de estructura->>
                //Mensaje dt->
                DataRow DRo = dtTemp.NewRow();
                DRo[0] = "ERR";
                DRo[1] = Path.GetFileName(stRuta);
                DRo[2] = "ERROR LECTURA - [" + EX.Message + "]. ";
                dtTemp.Rows.Add(DRo);

                return dtTemp;
            }

            return dtRET.Copy();
         
        }
        public DataTable dtVolcadoDat(string strSerial, string strNombreArchivo, int intTotalRev, int intRevCurso)
        {
            DataSet dsRet = new DataSet();

            try
            {

                SqlParameter[] arParms = new SqlParameter[8];

                arParms[0] = new SqlParameter("@vchSerial", strSerial);
                arParms[1] = new SqlParameter("@vchStatus", "");
                arParms[2] = new SqlParameter("@vchStatusREV", "");
                arParms[3] = new SqlParameter("@vchStarttime", "");
                arParms[4] = new SqlParameter("@vchNombreArchivo", strNombreArchivo);
                arParms[5] = new SqlParameter("@intTotalRev", intTotalRev);
                arParms[6] = new SqlParameter("@intRevCurso", intRevCurso);
                arParms[7] = new SqlParameter("@Accion", 3);

                dsRet = SqlHelper.ExecuteDataset(strConnSQL, CommandType.StoredProcedure, "spPCB_PcbMto", arParms);  


            }
            catch {
                dsRet = null;
            }

            return dsRet.Tables[0].Copy();
        
        }
        public DataSet dtLeerDatosTXT(string strSerial)
        {
            DataSet dsTemp
                = new DataSet();

            try
            {
                SqlParameter[] arParms = new SqlParameter[8];

                arParms[0] = new SqlParameter("@vchSerial", strSerial);
                arParms[1] = new SqlParameter("@vchStatus", "");
                arParms[2] = new SqlParameter("@vchStatusREV", "");
                arParms[3] = new SqlParameter("@vchStarttime", "");
                arParms[4] = new SqlParameter("@vchNombreArchivo", "");
                arParms[5] = new SqlParameter("@intTotalRev", 0);
                arParms[6] = new SqlParameter("@intRevCurso", 0);
                arParms[7] = new SqlParameter("@Accion", 1);

                dsTemp = SqlHelper.ExecuteDataset(strConnSQL, CommandType.StoredProcedure, "spPCB_PcbMto", arParms);  


            }
            catch {
                dsTemp = null;
            }
            
            return dsTemp;        
        }
         public DataSet dtObtenerTipoGOLD(string strStatus)
        {
            DataSet dsTemp
                = new DataSet();
             
             string strCommand = "SELECT bAplicaReglas FROM [dbo].[tblPCB_Status] WHERE vchStatus = '"+strStatus+"'";

            try
            {
                dsTemp = SqlHelper.ExecuteDataset(strConnSQL, CommandType.Text, strCommand);  
                
            }
            catch {
                dsTemp = null;
            }
            
            return dsTemp;        
        }
        #endregion DAT
        #endregion METODOS PUBLICOS
    }
}
