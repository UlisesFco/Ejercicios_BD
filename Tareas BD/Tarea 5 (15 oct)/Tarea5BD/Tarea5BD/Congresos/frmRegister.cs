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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        //Variables de la clase.
        GestorBD.GestorBD GestorBD;
        DataSet dsArt = new DataSet(), dsCon = new DataSet(), dsGen = new DataSet();
        DataRow fila;
        String cadSql;
        Varios.Comunes comunes = new Varios.Comunes();
        const int ok = 1;
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            f.Show();
            this.Hide();
        }

        private void btnAltaArt_Click(object sender, EventArgs e) {
            int idCon, idArt, idExp;
            string fecha;

            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd03", "navcar", "oracle");

            //Conseguir ids para la alta
            cadSql = "select idCon from congreso_t4 where nomCon='" + cbCongreso.Text + "'";
            GestorBD.consBD(cadSql, dsGen, "id1");
            idCon = Convert.ToInt16(dsGen.Tables["id1"].Rows[0]["idCon"]);
            dsGen.Clear();

            cadSql = "select idArt from articulo_t4 where nomArt='" + cbArts.Text + "'";
            GestorBD.consBD(cadSql, dsGen, "id2");
            idArt = Convert.ToInt16(dsGen.Tables["id2"].Rows[0]["idArt"]);
            dsGen.Clear();

            cadSql = "select max(idExp) \"maximo\" from expositor_t4";
            GestorBD.consBD(cadSql, dsGen, "id3");
            idExp = Convert.ToInt16(dsGen.Tables["id3"].Rows[0]["maximo"]);
            idExp++;
            MessageBox.Show(idExp.ToString());
            dsGen.Clear();

            fecha = string.Format("date'{2}-{1}-{0}'", dtpExp.Value.Day, dtpExp.Value.Month, dtpExp.Value.Year);
            //inserts
            cadSql = string.Format("insert into expositor_t4 values({0},'{1}',{2})", idExp.ToString(),tbxExp.Text,fecha);
            if(GestorBD.altaBD(cadSql) == ok)
            {
                cadSql = string.Format("insert into presentado_t4 values({0},{1})", idArt, idCon);
                if(GestorBD.altaBD(cadSql) == ok)
                {
                    cadSql = string.Format("update congreso_t4 set idExp = {0} where idCon = {1}", idExp, idCon);
                    if(GestorBD.cambiaBD(cadSql) == ok) //cambiar por nombre correcto del método de la dll GestorBD
                    {
                        MessageBox.Show("Alta exitosa");
                    }else
                        MessageBox.Show("Error en update");
                }else
                    MessageBox.Show("Error en alta 2");
            }else
                MessageBox.Show("Error en alta 1");


        }
        //Registrar el artículo, se supone que el expositor no está registrado
        private void frmRegister_Load(object sender, EventArgs e)
        {
           
            //1- Acceso a la BD.
            GestorBD = new GestorBD.GestorBD("MSDAORA", "bd03", "navcar", "oracle");

            //2- Obtiene los datos de los articulos y se muestran en el grid.
            cadSql = "select * from articulo_t4";
            GestorBD.consBD(cadSql, dsArt, "Arts");
            comunes.cargaCombo(cbArts, dsArt, "Arts", "nomArt");

            cadSql = "select * from congreso_t4";
            GestorBD.consBD(cadSql, dsCon, "Con");
            comunes.cargaCombo(cbCongreso, dsCon, "Con", "nomCon");

        }
    }
}
