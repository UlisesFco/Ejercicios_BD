using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Tarea6_Datos : System.Web.UI.Page
{
    //Variables de clase.
    GestorBD.GestorBD GestorBD;
    string rfc, cadSql;
    DataSet Dsgeneral = new DataSet(), DsPedidos = new DataSet();
    DataSet DsArtículos = new DataSet(), DsPagos = new DataSet();
    DataRow Fila;
    Comunes común = new Comunes();
    string tipo;
    protected void Page_Load(object sender, EventArgs e)
    {
        string cliente;
        if (!IsPostBack)
        {
            //Recupera valores de Session.
            GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
            rfc = Session["rfc"].ToString();
            tipo = Session["Tipo"].ToString();

            if (tipo == "Cli")
            {
                //Lee los datos del usuario.
                cadSql = "select * from PCUsuarios u, PCClientes c where u.RFC='" + rfc +
                  "' and u.RFC=c.RFC";
                GestorBD.consBD(cadSql, Dsgeneral, "Usuario");

                //Despliega los datos en la tabla.
                Fila = Dsgeneral.Tables["Usuario"].Rows[0];
                TblUsuario.Rows[1].Cells[0].Text = rfc;
                TblUsuario.Rows[1].Cells[1].Text = Fila["Nombre"].ToString();
                TblUsuario.Rows[1].Cells[2].Text = Fila["Domicilio"].ToString();

                //Lee los pedidos del cliente y carga los folios en el DDLPedidos.
                cadSql = "select * from PCPedidos where RFCC='" + rfc + "'";
                GestorBD.consBD(cadSql, DsPedidos, "Pedidos");
                común.cargaDDL(ddlPedidos, DsPedidos, "Pedidos", "FolioP");
                Session["DsPedidos"] = DsPedidos;
            } else if(tipo == "Emp")
            {
                //Lee los datos del usuario.
                cadSql = "select * from PCUsuarios u, PCEmpleados e where u.RFC='" + rfc +
                  "' and u.RFC=e.RFC";
                GestorBD.consBD(cadSql, Dsgeneral, "Usuario");

                //Despliega los datos en la tabla.
                Fila = Dsgeneral.Tables["Usuario"].Rows[0];
                TblUsuario.Rows[1].Cells[0].Text = rfc;
                TblUsuario.Rows[1].Cells[1].Text = Fila["Nombre"].ToString();
                TblUsuario.Rows[1].Cells[2].Text = Fila["Categoría"].ToString();

                //Lee los pedidos del cliente y carga los folios en el DDLPedidos.
                cadSql = "select * from PCPedidos where RFCE='" + rfc + "'";
                GestorBD.consBD(cadSql, DsPedidos, "Pedidos");
                común.cargaDDL(ddlPedidos, DsPedidos, "Pedidos", "FolioP");
                Session["DsPedidos"] = DsPedidos;
            }
            else
            {
                Label3.Visible = true;
                ddlClientes.Visible = true;
                ddlClientes.Enabled = true;

                Label2.Visible = false;
                ddlPedidos.Visible = false;
                ddlPedidos.Enabled = false;

                //Leer nombres del cliente y llenar ddl
                cadSql = "select nombre from PCUsuarios u, PCClientes c where u.RFC=c.rfc";
                GestorBD.consBD(cadSql, DsPedidos, "Pedidos");
                común.cargaDDL(ddlClientes, DsPedidos, "Pedidos", "Nombre");
                Session["DsPedidos"] = DsPedidos;

                //Lee los datos del usuario.
                cadSql = "select * from PCUsuarios u where u.RFC='" + rfc +"'";
                GestorBD.consBD(cadSql, Dsgeneral, "Usuario");

                //Despliega los datos en la tabla.
                Fila = Dsgeneral.Tables["Usuario"].Rows[0];
                TblUsuario.Rows[1].Cells[0].Text = rfc;
                TblUsuario.Rows[1].Cells[1].Text = Fila["Nombre"].ToString();
                TblUsuario.Rows[1].Cells[2].Text = "Gerente";
            }
        }
    }

    protected void ddlPedidos_SelectedIndexChanged(object sender, EventArgs e)
    {
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        tipo = Session["Tipo"].ToString();

        //Primera alternativa: consultando de nuevo a la BD (puede ser costoso, aunque con
        //datos actuales).
        rfc = Session["rfc"].ToString();
        if (tipo == "Cli")
        {
            cadSql = "select * from PCPedidos where RFCC='" + rfc + "' and FolioP=" + ddlPedidos.Text;
            GestorBD.consBD(cadSql, DsPedidos, "Pedidos");
            Fila = DsPedidos.Tables["Pedidos"].Rows[0];


            TblPedido.Rows[1].Cells[0].Text = Fila["FolioP"].ToString();
            TblPedido.Rows[1].Cells[1].Text = Fila["FechaPed"].ToString();
            TblPedido.Rows[1].Cells[2].Text = Fila["Monto"].ToString();
            TblPedido.Rows[1].Cells[3].Text = Fila["SaldoCli"].ToString();
            TblPedido.Rows[1].Cells[4].Text = Fila["SaldoFacs"].ToString();

            //Muestra los artículos que ampara el pedido.
            cadSql = "select Nombre, CantPed, CantEnt from PCArtículos a, PCDetalle d where FolioP=" +
                        ddlPedidos.Text + " and d.IdArt=a.IdArt";
            GestorBD.consBD(cadSql, DsArtículos, "Artículos");
            GrdArticulos.DataSource = DsArtículos.Tables["Artículos"];  //Muestra resultados.
            GrdArticulos.DataBind();

            //Muestra los pagos realizados para el pedido seleccionado.
            cadSql = "select * from PCPagos where FolioP=" + ddlPedidos.Text;
            GestorBD.consBD(cadSql, DsPagos, "Pagos");
            GrdPagos.DataSource = DsPagos.Tables["Pagos"];  //Muestra resultados.
            GrdPagos.DataBind();
        } else if(tipo == "Emp")
        {
            cadSql = "select * from PCPedidos where RFCE='" + rfc + "' and FolioP=" + ddlPedidos.Text;
            GestorBD.consBD(cadSql, DsPedidos, "Pedidos");
            Fila = DsPedidos.Tables["Pedidos"].Rows[0];


            TblPedido.Rows[1].Cells[0].Text = Fila["FolioP"].ToString();
            TblPedido.Rows[1].Cells[1].Text = Fila["FechaPed"].ToString();
            TblPedido.Rows[1].Cells[2].Text = Fila["Monto"].ToString();
            TblPedido.Rows[1].Cells[3].Text = Fila["SaldoCli"].ToString();
            TblPedido.Rows[1].Cells[4].Text = Fila["SaldoFacs"].ToString();

            //Muestra los artículos que ampara el pedido.
            cadSql = "select Nombre, CantPed, CantEnt from PCArtículos a, PCDetalle d where FolioP=" +
                        ddlPedidos.Text + " and d.IdArt=a.IdArt";
            GestorBD.consBD(cadSql, DsArtículos, "Artículos");
            GrdArticulos.DataSource = DsArtículos.Tables["Artículos"];  //Muestra resultados.
            GrdArticulos.DataBind();

            //Muestra los pagos realizados para el pedido seleccionado.
            cadSql = "select * from PCPagos where FolioP=" + ddlPedidos.Text;
            GestorBD.consBD(cadSql, DsPagos, "Pagos");
            GrdPagos.DataSource = DsPagos.Tables["Pagos"];  //Muestra resultados.
            GrdPagos.DataBind();
        }
    }

    protected void ddlClientes_SelectedIndexChanged(object sender, EventArgs e)
    {
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        //tipo = Session["Tipo"].ToString();
        rfc = Session["rfc"].ToString();

        cadSql = "select * from PCPedidos p, PCUsuarios u where nombre='" + ddlClientes.Text + "'";
        GestorBD.consBD(cadSql, DsPedidos, "Pedidos");
        Fila = DsPedidos.Tables["Pedidos"].Rows[0];


        TblPedido.Rows[1].Cells[0].Text = Fila["FolioP"].ToString();
        TblPedido.Rows[1].Cells[1].Text = Fila["FechaPed"].ToString();
        TblPedido.Rows[1].Cells[2].Text = Fila["Monto"].ToString();
        TblPedido.Rows[1].Cells[3].Text = Fila["SaldoCli"].ToString();
        TblPedido.Rows[1].Cells[4].Text = Fila["SaldoFacs"].ToString();

        //Muestra los artículos que ampara el pedido.
        cadSql = "select Nombre, CantPed, CantEnt from PCArtículos a, PCDetalle d, PCUsuarios u where d.IdArt=a.IdArt " 
            + "and d.foliop=p.foliop and p.rfcc=u.rfc and u.nombre='" + ddlClientes.Text +"'";
        GestorBD.consBD(cadSql, DsArtículos, "Artículos");
        GrdArticulos.DataSource = DsArtículos.Tables["Artículos"];  //Muestra resultados.
        GrdArticulos.DataBind();

        //Muestra los pagos realizados para el pedido seleccionado.
        cadSql = "select * from PCPagos pag,PCPedidos ped,PCUsuarios u where pag.foliop=ped.foliop and ped.rfcc=u.rfc and u.nombre='" + ddlClientes.Text +"'";
        GestorBD.consBD(cadSql, DsPagos, "Pagos");
        GrdPagos.DataSource = DsPagos.Tables["Pagos"];  //Muestra resultados.
        GrdPagos.DataBind();
    }
}