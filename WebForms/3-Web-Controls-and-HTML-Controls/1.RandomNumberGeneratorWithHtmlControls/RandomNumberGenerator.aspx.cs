using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1.RandomNumberGeneratorWithHtmlControls
{
    public partial class RandomNumberGenerator : System.Web.UI.Page
    {
        private Random rand = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerate_ServerClick(object sender, EventArgs e)
        {
            int minNumber, maxNumber;

            if (!int.TryParse(this.minNumber.Value, out minNumber))
            {
                this.lblResult.InnerText = "Invalid Min Number!";
                return;
            }
            else if (!int.TryParse(this.maxNumber.Value, out maxNumber))
            {
                this.lblResult.InnerText = "Invalid Max Number!";
                return;
            }

            this.lblResult.InnerText = "Generated number: " + rand.Next(minNumber, maxNumber).ToString();
        }
    }
}