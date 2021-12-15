using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int datos = int.Parse(TextBox1.Text);
            int horas = PortableLibrary1.ejercicio3.horas(datos);
            int minutos = PortableLibrary1.ejercicio3.minutos(datos);
            int segundos = PortableLibrary1.ejercicio3.segundos(datos);
            TextBox2.Text = horas + ":" + minutos + ":" + segundos;
        }
    }
}