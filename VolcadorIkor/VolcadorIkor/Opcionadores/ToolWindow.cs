using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace VolcadorIkor.Opcionadores
{
    public partial class ToolWindow : DockContent
    {
        #region PROPIEDADES
        frmPrincipal mdipr;
        #endregion PROPIEDADES
        public ToolWindow()
        {
            InitializeComponent();
        }

        private void ToolWindow_MouseHover(object sender, EventArgs e)
        {

        }
    }
}