﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace ClienteServidor.Procesos {
    public partial class FrmProgsAlm : Form {
        public FrmProgsAlm() {
            InitializeComponent();
        }
        //================================================
        //Código del procedimiento.

        //Variable para conectarse a Oracle.
        OleDbConnection cnOracle;
        
        //---------Para ORACLE SQL Developer-----------------

        //Ejemplo de ejecución de un procedimiento almacenado (en Oracle).
        //Procedimiento matCantAls2 (ejemplo 3 de las notas asociadas en C2SQL.pdf):
        //dado el nombre de una materia como parámetro, regresa cuántos alumnos
        //la están llevando, por medio de otro parámetro.
        private void button1_Click(object sender, EventArgs e) {
            String nomMat; int cant;
            OleDbCommand procAlm;
            OleDbParameter par;

            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd03;Password=navcar");
            cnOracle.Open();
            procAlm = new OleDbCommand();
            procAlm.Connection = cnOracle;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            procAlm.CommandText = "MatCantAls2";
            procAlm.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            //a) primero todos los de entrada:
            nomMat = "Matemáticas I";
            par = new OleDbParameter("nom", nomMat);
            procAlm.Parameters.Add(par);

            //b) luego todos los de salida (uno en este caso):
            par = new OleDbParameter("cant", OleDbType.Integer,
              4, ParameterDirection.Output, false, 4, 0, "NomMat", DataRowVersion.Current, 0);
            //(Nombre, tipo, longitur, direccion, simepre false, enteros salida, decimales, ...)
            procAlm.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try {
                procAlm.ExecuteNonQuery();

                //5- Recuperar el (los) valor(es) regresado(s) por medio del (de los)
                //   parámetro(s) de salida.
                cant = Convert.ToInt16(procAlm.Parameters["cant"].Value);
                MessageBox.Show("Cant. de alumn@s: " + cant);
            }
            catch (OleDbException err) {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }
        //===========================
        //Código de la función.

        //Ejemplo de ejecución de una función almacenada (en Oracle).
        //Función cantMatersAlum:
        //dado un alumno como parámetro, cuenta la cantidad de materias que lleva.

        private void button2_Click(object sender, EventArgs e) {
            String nom; int cant;
            OleDbCommand procAlm;
            OleDbParameter par;

            //1- Abrir la conexión a la BD.
            cnOracle = new OleDbConnection("Provider=MSDAORA; Data Source=oracle;" +
              "User ID=bd03;Password=navcar");
            cnOracle.Open();
            procAlm = new OleDbCommand();
            procAlm.Connection = cnOracle;

            //2- Especificar el llamado al procedimiento  (en general: al subprograma).
            procAlm.CommandText = "cantMatersAlum";
            procAlm.CommandType = CommandType.StoredProcedure;

            //3- Especificar los parámetros:
            //a) luego todos los de salida (uno en este caso):
            par = new OleDbParameter("RETURN_VALUE", OleDbType.Integer,
              4, ParameterDirection.ReturnValue, false, 4, 0, "NomAl",DataRowVersion.Current,0);
            //(Nombre, tipo, longitur, direccion, simepre false, enteros salida, decimales,"cualquier cadena" ...)
            procAlm.Parameters.Add(par);

            //b) primero todos los de entrada:
            nom = "Rebeca";
            par = new OleDbParameter("nom", nom);
            procAlm.Parameters.Add(par);

            //4- Ejecutar el procedimiento (en general: el subprograma).
            try {
                procAlm.ExecuteNonQuery();

                //5- Recuperar el (los) valor(es) regresado(s) por medio del (de los)
                //   parámetro(s) de salida.
                cant = Convert.ToInt16(procAlm.Parameters["RETURN_VALUE"].Value);
                MessageBox.Show("Cant. de materias: " + cant);
            }
            catch (OleDbException err) {
                MessageBox.Show(err.Message);
            }

            //6- Cerrar la conexión a la BD.
            cnOracle.Close();
        }
    }
}
