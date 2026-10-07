using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Task.Entities;

namespace TaskManager.Desktop
{
    public partial class FrmMain : Form
    {
        private Cuenta _miCuenta;
        public FrmMain(Cuenta cuenta)
        {
            InitializeComponent();
            _miCuenta = cuenta;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAplicacion_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
