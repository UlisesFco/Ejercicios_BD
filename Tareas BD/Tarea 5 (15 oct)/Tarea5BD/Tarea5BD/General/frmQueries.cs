using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace Tarea5BD.General
{
    public partial class frmQueries : Form
    {
        public frmQueries()
        {
            InitializeComponent();
        }

        //Variables de clase
        GestorBD.GestorBD gBD;
        DataSet dsCantArts = new DataSet();
        DataSet dsNomInst = new DataSet();
        DataSet dsAutsCong = new DataSet();
        DataSet dsEmpFin = new DataSet();
        string cadSql;

        private void btnCantArts_Click(object sender, EventArgs e)
        {
            gBD = new GestorBD.GestorBD("MSDAORA", "bd03", "navcar", "oracle");
            cadSql = "select distinct numarts, I4.nomins from Autor_T4 A4, Institucion_T4 I4 where A4.idOrg = I4.idOrg";
            gBD.consBD(cadSql, dsCantArts, "Arts");
            dgvGeneral.DataSource = dsCantArts.Tables["Arts"];
            MessageBox.Show("se ejecutó la consulta");
        }

        private void btnNomInst_Click(object sender, EventArgs e)
        {
            gBD = new GestorBD.GestorBD("MSDAORA", "bd03", "navcar", "oracle");
            cadSql = "select distinct nomIns, pais from organizacion_t4 o, institucion_t4 i, congreso_t4 c, presentado_t4 p, articulo_t4 art, " +
                    "financiamiento_t4 f, recibe_t4 r, autor_t4 a where o.idorg = i.idorg and a.idorg = i.idorg " +
                    "and f.idorg = o.idorg and a.idaut = art.idaut and art.idart = p.idart and p.idcon = c.idcon";
            gBD.consBD(cadSql, dsNomInst, "Nombres");
            dgvGeneral.DataSource = dsNomInst.Tables["Nombres"];
            MessageBox.Show("se ejecutó la consulta");
        }

        private void btnAutsCong_Click(object sender, EventArgs e)
        {
            gBD = new GestorBD.GestorBD("MSDAORA", "bd03", "navcar", "oracle");
            cadSql = "select A4.nomAut,  count(Prest4.idArt) \"Cant Articulos\" " +
                    "from Autor_T4 A4, Articulo_T4 Art4, Presentado_T4 Prest4, Congreso_T4 Con4 " +
                    "where A4.idAut = Art4.idAut and Art4.idArt = Prest4.idArt and Prest4.idCon = Con4.idCon " +
                    "group by nomAut " +
                    "having count(Prest4.idArt) >= (select count(*) from Presentado_T4 P4, Congreso_T4 C4 where C4.idCon = P4.idCon)";
            gBD.consBD(cadSql, dsAutsCong, "Auts");
            dgvGeneral.DataSource = dsAutsCong.Tables["Auts"];
            MessageBox.Show("se ejecutó la consulta");
        }

        private void btnEmpFin_Click(object sender, EventArgs e)
        {
            gBD = new GestorBD.GestorBD("MSDAORA", "bd03", "navcar", "oracle");
            cadSql = "select nomEmp, sum(aportacion) \"suma aportacion\", count(*) \"Congresos participados\" " +
                      "from empresa_t4 e, organiza_t4 o, congreso_t4 c " +
                      "where e.idorg = o.idorg and c.idcon = o.idcon " +
                      "group by nomEmp " +
                      "having count(*) > 2";
            gBD.consBD(cadSql, dsEmpFin, "Emp");
            dgvGeneral.DataSource = dsEmpFin.Tables["Emp"];
            MessageBox.Show("se ejecutó la consulta");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            f.Show();
            this.Hide();
        }
    }
}
