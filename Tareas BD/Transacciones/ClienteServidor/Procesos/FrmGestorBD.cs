using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteServidor.Procesos {
  public partial class FrmGestorBD : Form {
    public FrmGestorBD() {
      InitializeComponent();
    }

    //Variables de la clase.
    GestorBD.GestorBD GestorBD;
    DataSet dsAlum = new DataSet(), dsMater= new DataSet(), dsCalifs= new DataSet();
    DataSet dsFolio = new DataSet();
    DataRow fila;
    String cadSql;
    Varios.Comunes comunes = new Varios.Comunes();
    const int OK = 1;
    
    private void FrmGestorBD_Load(object sender, EventArgs e) {
      //1- Acceso a la BD.
      GestorBD = new GestorBD.GestorBD("MSDAORA", "bdalumno", "estudia", "oracle");

      //2- Obtiene los datos de los alumnos y se muestran en el grid.
      cadSql = "select * from Alum";
      GestorBD.consBD(cadSql, dsAlum, "Alumnos");
      dtgGeneral.DataSource = dsAlum.Tables["Alumnos"];
      comunes.cargaCombo(cboAlumnos, dsAlum, "Alumnos", "NomAl");

      //3- Obtiene los datos de las materias y muestra su nombre en el combo.
      cadSql = "select * from Mater";
      GestorBD.consBD(cadSql, dsMater, "Materias");
      //dtgGeneral.DataSource = dsMater.Tables["Materias"];
      comunes.cargaCombo(cboMaterias, dsMater, "Materias", "NomMat");
    }

    //Muestra en el grid las califs. del alumno elegido en el combo.
    private void cboAlumnos_SelectedIndexChanged(object sender, EventArgs e) {

      cadSql = "select nomal, nommat, folio, calif, fecha " +
        "from alum a, historial h, mater m " +
        "where nomal ='" + cboAlumnos.Text + "' and a.cu=h.cu and h.clavem=m.clavem";
      GestorBD.consBD(cadSql, dsCalifs, "Califs");
      dtgGeneral.DataSource = dsCalifs.Tables["Califs"];
    }

    //Agrega una nueva calificación: el alumno y la materia se seleccionan
    //de sus combo box, calificación y fecha de las cajas correspondientes.
    //Inicialmente sólo se habilitan los controles asociados.
    private void btnAltaCalif_Click(object sender, EventArgs e) {
      //Habilita/deshabilita controles (de esta manera se puede guiar lo que el usuario
      //debe hacer).
      cboMaterias.Visible = true; cboCalif.Visible = true; dtpFecha.Visible = true;
      label1.Visible = true;
      btnRegistrarAlta.Visible = true; btnAltaCalif.Enabled = false;
      //btnBajaCalif.Enabled = false; btnCambia.Enabled = false;
    }

    //Prepara y envía la cadena de inserción de la nueva calif.
    private void btnRegistrarAlta_Click(object sender, EventArgs e) {
      int folio; string fecha;
      DataRow[] filasAlum; DataRow[] filasMater;

      //Obtiene el máximo folio y genera el nuevo.
      cadSql = "select max(folio) as maxFolio from historial";
      GestorBD.consBD(cadSql, dsFolio, "Folio");
      fila = dsFolio.Tables["Folio"].Rows[0];   //Recupera la unica fila.
      folio = Convert.ToInt16(fila["maxFolio"]) + 1;         //Nuevo folio.
      //MessageBox.Show(folio.ToString());

      //Obtiene la clave del alumno y materia elegidos en los combos.
      //Se usan los datos que ya están en los dataset respectivos.
      filasAlum = dsAlum.Tables["Alumnos"].Select("NomAl='" + cboAlumnos.Text + "'");
      filasMater = dsMater.Tables["Materias"].Select("NomMat='" + cboMaterias.Text + "'");

      //Construye la fecha para el formato de Oracle.
      fecha = "date'" + dtpFecha.Value.Year + "-" + dtpFecha.Value.Month + "-" +
        dtpFecha.Value.Day + "'";

      //Construye la cadena de inserción.
      cadSql = "insert into Historial values(" + folio + "," + cboCalif.Text + "," + fecha + "," +
        filasAlum[0]["CU"] + "," + filasMater[0]["ClaveM"] + ")";

      //Envía la cadena a la BD.
      if (GestorBD.altaBD(cadSql) == OK)
        MessageBox.Show("Alta exitosa");
      else
        MessageBox.Show("No se pudo insertar la calif.");

      //Habilita/deshabilita controles.
      cboMaterias.Visible = false; cboMaterias.Text = "Materias:";
      cboCalif.Visible = false; cboCalif.Text = "Calificación:";
      dtpFecha.Visible = false; label1.Visible = false;
      btnRegistrarAlta.Visible = false; btnAltaCalif.Enabled = true;
      btnBajaCalif.Enabled = true; btnCambia.Enabled = true;
    }

    //Para obtener el valor de la celda seleccionada al darle clic en el DataGrid
    //existen tres maneras (necesariamente hay que dar clic en la celda elegida):
    //1) nombreDataGrid.CurrentCell.Value;
    //2) nombreDataGrid[ÍndiceColumna, ÍndiceFila].Value;
    //3) nombreDataGrid[NombreColumna, ÍndiceFila].Value
    private void dtgGeneral_Click(object sender, EventArgs e) {
      int fila, col; Object valor;

      //Obtiene fila, columna y valor de la celda elegida.
      //fila = dtgGeneral.CurrentCell.RowIndex; col = dtgGeneral.CurrentCell.ColumnIndex;
      //valor = dtgGeneral.CurrentCell.Value;
      //MessageBox.Show("Fila: " + fila + " Columna: " + col + " Valor: " + valor);

      ////Obtiene sólo el valor.
      //MessageBox.Show("Valor: " + dtgGeneral[col, fila].Value.ToString());
    }

    //Realiza el proceso para eliminar una calificación de Historial.
    //Se usa el folio, de la fila elegida en el grid, para hacer la baja.
    private void btnBajaCalif_Click(object sender, EventArgs e) {
      int folio; String cadSql;
      DialogResult botón;

      //Toma el folio de la calificación seleccionada en el data grid.
      folio = Convert.ToInt16(dtgGeneral["Folio", dtgGeneral.CurrentRow.Index].Value);
      botón = MessageBox.Show("¿Se elimina el registro con folio= " + folio.ToString(),
        "Eliminación", MessageBoxButtons.YesNo);

      //Si se selecciona el botón Yes, del MessageBox, elimina el registro asociado.
      if (botón == DialogResult.Yes) {
        //Construye la cadena de eliminación y la envía para su ejecución.
        cadSql = "delete from Historial where Folio = " + folio;
        if (GestorBD.bajaBD(cadSql) == OK)
          MessageBox.Show("Se eliminó la calificación del folio " + folio + " exitosamente");
        else
          MessageBox.Show("No se pudo eliminar la calificación");
      }
    }

  }
}

