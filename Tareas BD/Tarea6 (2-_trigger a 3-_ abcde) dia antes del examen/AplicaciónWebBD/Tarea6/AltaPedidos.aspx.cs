using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Tarea6_AltaPedidos : System.Web.UI.Page
{
    //Variables de clase.
    GestorBD.GestorBD GestorBD;
    string rfc, cadSql;
    DataSet Dsgeneral = new DataSet(), DsTabla = new DataSet();
    DataSet DsArticulos = new DataSet(), DsCant = new DataSet();
    DataRow Fila;
    Comunes común = new Comunes();
    string tipo;
    bool primerArt = true;
    int idArt;
    int folioAct;
    int nuevoFolio = 0;
    int i = 0;
    const int ok = 1;
    string selDDL;

    //Acciones iniciales
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            //Lee los pedidos del cliente y carga los folios en el DDLPedidos.
            cadSql = "select * from PCArtículos";
            GestorBD.consBD(cadSql, DsArticulos, "Arts");
            común.cargaDDL(ddlArticulos, DsArticulos, "Arts", "Nombre");
        }
    }
    //Hacer la alta del pedido
    protected void btnAlta_Click(object sender, EventArgs e)
    {
        //Recuperar cosas de la sesión anterior
        string art;
        string fechaAct = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString();
        string rfc = Session["rfc"].ToString();
        art = ddlArticulos.Text;
        tipo = Session["Tipo"].ToString();
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            if (Page.IsValid)
            {
                if (primerArt)
                {
                    //Encontrar el nuevo folio
                    cadSql = "select max(folioP) \"folioMax\" from PCPedidos";
                    GestorBD.consBD(cadSql, Dsgeneral, "folio");
                    nuevoFolio = 1 + Convert.ToInt16(Dsgeneral.Tables["folio"].Rows[0]["folioMax"]);

                    Dsgeneral.Clear();

                    primerArt = false;
                    //folio del cual empezar a poner los artículos
                    folioAct = nuevoFolio - 1;

                }

                //Encontrar el idArt
                cadSql = "select idArt from PCArtículos where nombre='" + ddlArticulos.Text + "'";
                GestorBD.consBD(cadSql, Dsgeneral, "id");
                idArt = Convert.ToInt32(Dsgeneral.Tables["id"].Rows[0]["idArt"]);
                Dsgeneral.Clear();

                //Encontrar precio y monto de los artículos dados
                cadSql = "select precio from PCArtículos where idArt=" + idArt;
                GestorBD.consBD(cadSql, Dsgeneral, "precio");

                double precio = Convert.ToDouble(Dsgeneral.Tables["precio"].Rows[0]["precio"]);
                double monto = Convert.ToDouble(txtNumArts.Text) * precio;

                Dsgeneral.Clear();

                //Alta en Pedidos
                if (tipo == "Cli")
                    cadSql = string.Format("insert into PCPedidos values({0},date'{1}'," +
                        "null,{2},{3},{4},'{5}',null)", nuevoFolio, fechaAct, monto, 0, monto, rfc);
                else
                    cadSql = string.Format("insert into PCPedidos values({0},date'{1}'," +
                        "null,{2},{3},{4},null,'{5}')", nuevoFolio, fechaAct, monto, 0, monto, rfc);

                if (GestorBD.altaBD(cadSql) == ok)
                {   //Alta en Detalle
                    Dsgeneral.Clear();
                    cadSql = string.Format("insert into PCDetalle values({0},{1},{2},0)", nuevoFolio, idArt, txtNumArts.Text);
                    if (GestorBD.altaBD(cadSql) == ok)
                    {
                        lblMensaje.Text = "Alta exitosa";
                    }
                    else
                        lblMensaje.Text = "Error alta en detalle";
                }
                else
                    lblMensaje.Text = "Error alta en Pedidos";
                Dsgeneral.Clear();

                cadSql = string.Format("select folioP,fechaPed,monto,SaldoCli,SaldoFacs from PCPedidos where folioP={0}", nuevoFolio);
                GestorBD.consBD(cadSql, DsTabla, "consTabla");
                Fila = DsTabla.Tables["consTabla"].Rows[0];
                
                cadSql = "select cantAct from PCArtículos where idArt=" + idArt;
                GestorBD.consBD(cadSql,DsCant,"Cant");
                int cantAct = Convert.ToInt32(DsCant.Tables["Cant"].Rows[0]["cantAct"]);//Si hay menos que la cant mínima, se activa el trigger de Oracle
                
                cadSql = string.Format("update PCArtículos set cantAct={0} where idArt={1}",cantAct-Convert.ToInt32(txtNumArts.Text),idArt);
                GestorBD.cambiaBD(cadSql);

                //Añadir una fila extra a la tabla para el siguiente artículo
                TableRow tr = new TableRow();
                int k;
                for (k = 0; k < 5; k++)
                {
                    TableCell tc = new TableCell();
                    tc.Text = " ";
                    tr.Cells.Add(tc);
                }
                tblDatos.Rows.Add(tr);

                tblDatos.Rows[i + 1].Cells[0].Text = nuevoFolio.ToString();
                tblDatos.Rows[i + 1].Cells[1].Text = fechaAct;
                tblDatos.Rows[i + 1].Cells[2].Text = monto.ToString();
                tblDatos.Rows[i + 1].Cells[3].Text = 0.ToString(); //Lo que ha pagado
                tblDatos.Rows[i + 1].Cells[4].Text = monto.ToString(); //Lo que le falta de pagar

                //Cambio variables para la inserción
                nuevoFolio++;
                i++;
                
                //Borrar datos de inserción para nueva alta
                ddlArticulos.SelectedIndex = 0;
                txtNumArts.Text = "";
            Dsgeneral.Clear();
            //Llenar datagrid
            cadSql = "select * from PCDetalle where folioP=" + nuevoFolio;
            GestorBD.consBD(cadSql, Dsgeneral, "Detalle");
            grdPedido.DataSource = Dsgeneral.Tables["Detalle"];
            grdPedido.DataBind();
            }   
    }

    protected void ddlArticulos_SelectedIndexChanged(object sender, EventArgs e)
    {
        selDDL = ddlArticulos.Text;
    }
}