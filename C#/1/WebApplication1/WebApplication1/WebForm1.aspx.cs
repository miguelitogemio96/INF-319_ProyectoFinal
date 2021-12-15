using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String[] lista;
        String[] aux;
        String cad;
        int a;
        int b;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cad = TextBox1.Text.ToString();
            lista = cad.Split(',');
            TextBox2.Text = calcular(lista);
        }
        protected String calcular(String[] lista)
        {
            cad = "[";
            foreach (String i in lista)
            {
                aux = i.Split(' ');
                a = int.Parse(aux[0]);
                b = int.Parse(aux[1]);
                cad = cad + (a + b) + ",";
            }
            cad = cad.Remove(cad.Length - 1);
            cad = cad + "]";
            return cad;
        }
    }
}