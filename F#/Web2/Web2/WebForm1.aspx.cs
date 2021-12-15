using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = 10;
            int b = 4;
            String cad = TextBox1.Text.ToString();
            String[] lista = cad.Split(',');
            String[] c = PortableLibrary1.ejercicio2.inversa(lista);
            String resp = "[";
            foreach (string i in c)
            {
                resp = resp + i.ToString() + ",";
            }
            resp = resp.Substring(0, resp.Length - 1) + "]";
            TextBox2.Text = resp;
        }
    }
}