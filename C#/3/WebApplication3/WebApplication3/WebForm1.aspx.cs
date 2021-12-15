using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {        
        int segundos;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            segundos = int.Parse(TextBox1.Text);
            TextBox2.Text = hora(segundos); 
        }
        protected String hora(int segundos)
        {
            return segundos/3600 + ":" + ((segundos%3600)/60) + ":" + ((segundos%3600)%60);            
        }
    }
}