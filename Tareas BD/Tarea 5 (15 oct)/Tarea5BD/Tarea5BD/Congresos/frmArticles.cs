using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea5BD.Congresos
{
    public partial class frmArticles : Form
    {
        public frmArticles()
        {
            InitializeComponent();
        }
        //Variables de la clase.
        GestorBD.GestorBD GestorBD;
        DataSet dsAut = new DataSet(), dsArts = new DataSet(), dsCalifs = new DataSet();
        DataSet dsFolio = new DataSet();
        DataRow fila;
        String cadSql;
        Varios.Comunes comunes = new Varios.Comunes();

        private void btnDatos_Click(object sender, EventArgs e)
        {
            string año, mes, dia, fecha, autor;
            autor = cbAutor.Text;
            año = dtpFecha.Value.Year.ToString();
            mes = dtpFecha.Value.Month.ToString();
            dia = dtpFecha.Value.Day.ToString();
            fecha = string.Format("date'{2}-{1}-{0}'",dtpFecha.Value.Day,dtpFecha.Value.Month,dtpFecha.Value.Year);
            cadSql = string.Format("select distinct nomAut, nomIns, f.idfin, nomCon, fechaIni, count(nomCon) " +
                "from Autor_T4 a, Institucion_t4 i, financiamiento_t4 f, articulo_t4 art, presentado_t4 p, congreso_t4 c " + 
                "where a.idaut=art.idaut and p.idart =art.idart and p.idcon = c.idcon and i.idorg=a.idorg and f.idorg=i.idorg " +
                "and c.fechaini >= {0} and nomAut='{1}' group by nomAut,nomIns,f.idfin,nomCon,fechaIni", fecha,autor);
            GestorBD.consBD(cadSql, dsArts, "Arts");
            dgvGen.DataSource = dsArts.Tables["Arts"];
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            f.Show();
            this.Hide();
        }

        const int ok = 1;
        private void frmArticles_Load(object sender, EventArgs e)
        {
            //1- Acceso a la BD.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd03", "navcar", "oracle");

            //2- Obtiene los datos de los alumnos y se muestran en el grid.
            cadSql = "select * from autor_t4";
            GestorBD.consBD(cadSql, dsAut, "Autores");
            //dgvGen.DataSource = dsAut.Tables["Autores"];
            comunes.cargaCombo(cbAutor, dsAut, "Autores", "nomAut");
        }
    }
}
