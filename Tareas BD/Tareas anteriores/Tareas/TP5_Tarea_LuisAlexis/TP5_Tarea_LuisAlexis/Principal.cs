using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP5_Tarea_LuisAlexis
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            Procesos.frmVerCarr f = new Procesos.frmVerCarr();
            f.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Procesos.frmNuevaIns f = new Procesos.frmNuevaIns();
            f.ShowDialog();
        }
    }
}
