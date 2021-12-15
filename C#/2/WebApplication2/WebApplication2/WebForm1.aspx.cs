using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        String[] lista;
        String cad;
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cad = TextBox1.Text.ToString();
            lista = cad.Split(',');
            TextBox2.Text = reversa(lista); 
        }
        protected String reversa(String[] lista)
        {
            cad = "]";
            foreach (String i in lista)
            {
                cad = "," + i + cad;
            }
            cad = cad.Substring(1,cad.Length-1);
            cad = "[" + cad;
            return cad;
        }
    }
}