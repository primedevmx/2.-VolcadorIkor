using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VolcadorIkor
{
    /// <summary>
    /// Autor: 
    ///     Miguel Gutierrez Arroyo
    /// Fecha: 
    ///     2014/05/06
    /// 
    /// Descripcion: 
    ///     Clase para el modelo de metodos de Seguridad de la Aplicacion.    
    /// 
    /// </summary> 
    public static class clSeguridad
    {
        #region METODOS PÚBLICOS
        public static void vCargaForma(Form Formulario, Form FormularioPadre, string strText)
        {

            Formulario.Text = strText;

            foreach (Form ctr in FormularioPadre.MdiChildren)
            {
                if (ctr.Text == Formulario.Text)
                {
                    ctr.Focus();
                    Formulario.Dispose();
                    return;
                }

            }            

            Formulario.WindowState = FormWindowState.Maximized;
            Formulario.MdiParent = FormularioPadre;
            Formulario.ControlBox = false;

            Formulario.BackgroundImage = VolcadorIkor.Properties.Resources.fondo;
            Formulario.Icon = VolcadorIkor.Properties.Resources.ToolboxWindow;
            Formulario.BackgroundImageLayout = ImageLayout.Stretch;
            Formulario.Show();
            Formulario.WindowState = FormWindowState.Maximized;
            
        }



        #endregion METODOS PÚBLICOS
     
    }
}
