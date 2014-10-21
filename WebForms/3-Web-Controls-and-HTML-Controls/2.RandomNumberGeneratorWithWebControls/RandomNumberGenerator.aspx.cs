using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2.RandomNumberGeneratorWithWebControls
{
    public partial class RandomNumberGenerator : System.Web.UI.Page
    {
        private Random rand = new Random();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            int minNumber, maxNumber;

            if (!int.TryParse(this.tbMinNumber.Text, out minNumber))
            {
                this.lblResult.Text = "Invalid Min Number!";
                return;
            }
            else if (!int.TryParse(this.tbMaxNumber.Text, out maxNumber))
            {
                this.lblResult.Text = "Invalid Max Number!";
                return;
            }

            this.lblResult.Text = rand.Next(minNumber, maxNumber).ToString();
        }
    }
}