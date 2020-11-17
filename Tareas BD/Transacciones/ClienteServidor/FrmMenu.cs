using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServidor {
  public partial class FrmMenú : Form {
    public FrmMenú() {
      InitializeComponent();
    }

    private void MnuSalir_Click(object sender, EventArgs e) {
      Application.Exit();   //Salir de la aplicación.
    }

        //Abrimos la forma Alumnos
        private void tablasToolStripMenuItem_Click(object sender, EventArgs e) {

        }

        private void MnuAlumnos_Click(object sender, EventArgs e) {
            TablasCons.FrmAlumnos fa = new TablasCons.FrmAlumnos();
            fa.Show(); //Si se puede cambiar de forma
        }

        private void alumCalifsToolStripMenuItem_Click(object sender, EventArgs e) {
            TablasCons.FrmConsulta fc = new TablasCons.FrmConsulta();
            fc.ShowDialog(); //No salir de esa forma hasta que se de la condición 
        }
        //Ejecutar subprogramas almecenados
        private void subProgsAlm_Click(object sender, EventArgs e) {
            Procesos.FrmProgsAlm fsp = new Procesos.FrmProgsAlm();
            fsp.Show();
        }

        private void MnuGestorBD_Click(object sender, EventArgs e) {
            Procesos.FrmGestorBD fgbd = new Procesos.FrmGestorBD();
            fgbd.Show();
        }
    }
}
