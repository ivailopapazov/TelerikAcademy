using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.HelloAsp.Net
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            this.lblHello.Text = "Hello ASP.NET from C# code!";
            this.lblPath.Text = Assembly.GetExecutingAssembly().Location;
        }
    }
}