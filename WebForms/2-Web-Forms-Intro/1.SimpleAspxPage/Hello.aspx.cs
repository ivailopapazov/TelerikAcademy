using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1.SimpleAspxPage
{
    public partial class Hello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnPrintName_Click(object sender, EventArgs e)
        {
            string name = this.tbName.Text;
            this.lblName.Text = "Hello " + name;
        }
    }
}