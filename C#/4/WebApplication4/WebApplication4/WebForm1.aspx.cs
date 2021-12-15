using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int año;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            año = int.Parse(TextBox1.Text);
            TextBox2.Text = esBisiesto(año); 
        }
        protected String esBisiesto(int anio)
        {
            if ((anio % 4 == 0) && ((anio % 100 != 0) || (anio % 400 == 0)))
            {
                return "Es Bisiesto";
            }
            else
            {
                return "No es Bisiesto";
            }
            
        }
    }
}
