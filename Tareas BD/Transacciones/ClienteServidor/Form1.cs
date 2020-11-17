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

    //Abre la forma de alumnos.
    private void MnuAlumnos_Click(object sender, EventArgs e) {
      TablasCons.FrmAlumnos fa = new TablasCons.FrmAlumnos();
      fa.Show();
    }

    //Abre la forma de la consulta.
    private void MnuConsulta_Click(object sender, EventArgs e) {
      TablasCons.FrmConsulta fc = new TablasCons.FrmConsulta();
      fc.ShowDialog();

    }

    //Ejecución de subprogs. almacenados.
    private void MnuSubprogsAlm_Click(object sender, EventArgs e) {
      Procesos.FrmSubProgsAlm fsa = new Procesos.FrmSubProgsAlm();
      fsa.Show();

    }

    //Abre la forma del GestorBD.
    private void MnuGestorBD_Click(object sender, EventArgs e) {
      Procesos.FrmGestorBD fg = new Procesos.FrmGestorBD();
      fg.Show();
    }
        //Abre la forma de conexion a otras bd
        private void MnuOtrasConsultas_Click(object sender, EventArgs e) {
            TablasCons.FrmOtrasBDs fg = new TablasCons.FrmOtrasBDs();
            fg.Show();
        }

        private void MnuTransact_Click(object sender, EventArgs e) {
            Procesos.FrmTransac ft = new Procesos.FrmTransac();
            ft.Show();
        }
    }
}
