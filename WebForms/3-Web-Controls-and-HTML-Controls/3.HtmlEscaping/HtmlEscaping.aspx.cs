using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3.HtmlEscaping
{
    public partial class HtmlEscaping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            string input = this.tbInput.Text;

            this.tbResult.Text = input;
            this.lblResult.Text = Server.HtmlEncode(input);
        }
    }
}