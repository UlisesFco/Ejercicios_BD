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

namespace Tarea5BD.General
{
    public partial class frmFuncProc : Form
    {
        public frmFuncProc()
        {
            InitializeComponent();
        }

        OleDbConnection cnOracle;
        private void btnFunc_Click(object sender, EventArgs e)
        {
            String nomEmp; int cantCong;
            OleDbCommand procAlm;
            OleDbParameter par;

            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd03;Password=navcar");
            cnOracle.Open();
            procAlm = new OleDbCommand();
            procAlm.Connection = cnOracle;

            //2- Especificar el llamado a la función.
            procAlm.CommandText = "CantCongresos";
            procAlm.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            // a) Nota: primero hay que definir el tipo de valor que regresará la función.
            par = new OleDbParameter("RETURN_VALUE", OleDbType.Integer,
              4, ParameterDirection.ReturnValue, false, 4, 0, "NomEmp", DataRowVersion.Current, 0);
            procAlm.Parameters.Add(par);

            // b) luego hay que definir los parámetros de entrada (uno en este caso).
            nomEmp = "E1";
            par = new OleDbParameter("nombre", nomEmp);
            procAlm.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try
            {
                procAlm.ExecuteNonQuery();

                //5- Recuperar el valor regresado por la función.
                cantCong = Convert.ToInt16(procAlm.Parameters["RETURN_VALUE"].Value);
                MessageBox.Show("Cantidad de empresas " + nomEmp + ": " + cantCong);
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }

        private void btnProc_Click(object sender, EventArgs e)
        {
            String emp1; String emp2; String res;
            OleDbCommand procAlm;
            OleDbParameter par;

            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd03;Password=navcar");
            cnOracle.Open();
            procAlm = new OleDbCommand();
            procAlm.Connection = cnOracle;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            procAlm.CommandText = "patrocinaMasCongresos";
            procAlm.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            //a) primero todos los de entrada:
            emp1 = "E1";
            par = new OleDbParameter("emp1", emp1);
            procAlm.Parameters.Add(par);

            emp2 = "E2";
            par = new OleDbParameter("emp2", emp2);
            procAlm.Parameters.Add(par);

            //b) luego todos los de salida (uno en este caso):
            par = new OleDbParameter("res", OleDbType.VarChar, 4,
              ParameterDirection.Output, false, 4, 0, "res", DataRowVersion.Current, 0);
            procAlm.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try
            {
                procAlm.ExecuteNonQuery();

                //5- Recuperar el (los) valor(es) regresado(s) por medio del (de los)
                //   parámetro(s) de salida.
                res = Convert.ToString(procAlm.Parameters["res"].Value);
                MessageBox.Show("Empresa: " + res);
            }
            catch (OleDbException err)
            {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMainMenu f = new frmMainMenu();
            f.Show();
            this.Hide();
        }
    }
}
