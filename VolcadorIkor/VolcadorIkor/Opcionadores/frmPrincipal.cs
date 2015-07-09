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
    public partial class frmPrincipal : Form
    {
        frmMenu menu;
     
        public int ProgressValue
        {
            set
            {
            }

        }

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void vMostrarMenu()
        {
            menu = new frmMenu(this);
            menu.RightToLeftLayout = true;
            menu.Show(dockPanel1, DockState.DockLeftAutoHide);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            vMostrarMenu();            
            string Version;
            try
            {
                Version = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
            catch
            {
                Version = "Desarrollo";
            }


            lblVersion.Text = "Sistema Volcador [XML] IKOR v." + Version;

            ProgressValue = 100;
           
        }
    
        private void mostrarMenúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vMostrarMenu();
        }

        private void dockPanel2_MouseHover(object sender, EventArgs e)
        {

        }

        private void dockPanel2_MouseLeave(object sender, EventArgs e)
        {

        }
    }
}
