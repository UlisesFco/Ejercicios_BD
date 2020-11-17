using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5BD
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
        //Ir a cada forma al darle click al botón
        private void btnUpdates_Click(object sender, EventArgs e)
        {
            General.frmUpdates f = new General.frmUpdates();
            f.Show();
            this.Hide();
        }

        private void btnQueries_Click(object sender, EventArgs e)
        {
            General.frmQueries f = new General.frmQueries();
            f.Show();
            this.Hide();
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            General.frmFuncProc f = new General.frmFuncProc();
            f.Show();
            this.Hide();
        }

        private void btnArticles_Click(object sender, EventArgs e)
        {
            Congresos.frmArticles f = new Congresos.frmArticles();
            f.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Congresos.frmRegister f = new Congresos.frmRegister();
            f.Show();
            this.Hide();
        }
    }
}
