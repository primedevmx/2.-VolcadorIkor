using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VolcadorIkor
{
    public partial class SplashScreenFormV2 : Form
    {
        public SplashScreenFormV2(string titulo, string mensaje)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            this.Text = titulo;
        }

        public void fn_Close()
        {
            this.Close();
        }
    }
}