using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tarea6_Menu : System.Web.UI.Page
{
    string tipo;
    //Acciones al cargar la página
    protected void Page_Load(object sender, EventArgs e)
    {
        tipo = "Tipo de usuario: " + Session["Tipo"].ToString();
        Label2.Text = tipo;
        if (Session["Tipo"].ToString() != "Ger")
        {
            linkAlta.Visible = true;
            linkAlta.Enabled = true;
            linkAlta.NavigateUrl = "~/Tarea6/AltaPedidos.aspx";
        }
    }
}