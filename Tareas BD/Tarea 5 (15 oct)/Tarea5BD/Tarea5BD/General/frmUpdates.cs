using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5BD.General
{
    public partial class frmUpdates : Form
    {
        public frmUpdates()
        {
            InitializeComponent();
        }

        private void frmUpdates_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsAutor.AUTOR_T4' Puede moverla o quitarla según sea necesario.
            this.aUTOR_T4TableAdapter.Fill(this.dsAutor.AUTOR_T4);
            // TODO: esta línea de código carga datos en la tabla 'dsArts.ARTICULO_T4' Puede moverla o quitarla según sea necesario.
            this.aRTICULO_T4TableAdapter.Fill(this.dsArts.ARTICULO_T4);

        }
        //Actualiza los data grid al darle clic al botón
        private void btnActArt_Click(object sender, EventArgs e)
        {
            this.aRTICULO_T4TableAdapter.Update(this.dsArts.ARTICULO_T4);
        }

        private void btnActAut_Click(object sender, EventArgs e)
        {
            this.aUTOR_T4TableAdapter.Update(this.dsAutor.AUTOR_T4);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            f.Show();
            this.Hide();
        }
    }
}
