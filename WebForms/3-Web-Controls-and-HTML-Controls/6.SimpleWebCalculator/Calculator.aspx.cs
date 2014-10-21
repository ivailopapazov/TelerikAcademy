using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _6.SimpleWebCalculator
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            ViewState.Add("operator", null);
            ViewState.Add("operand", null);
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOne_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "1";
        }

        protected void btnTwo_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "2";
        }

        protected void btnThree_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "3";
        }

        protected void btnPlus_Click(object sender, EventArgs e)
        {
            if (ViewState["operator"] != null)
            {
                this.EvaluateExpression();
            }

            ViewState["operand"] = this.lblResult.Text;
            ViewState["operator"] = "+";
            this.lblResult.Text = "";
        }

        protected void btnFour_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "4";
        }

        protected void btnFive_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "5";
        }

        protected void btnSix_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "6";
        }

        protected void btnMinus_Click(object sender, EventArgs e)
        {
            if (ViewState["operator"] != null)
            {
                this.EvaluateExpression();
            }

            ViewState["operand"] = this.lblResult.Text;
            ViewState["operator"] = "-";
            this.lblResult.Text = "";
        }

        protected void btnSeven_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "7";
        }

        protected void btnEight_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "8";
        }

        protected void btnNine_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "9";
        }

        protected void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (ViewState["operator"] != null)
            {
                this.EvaluateExpression();
            }

            ViewState["operand"] = this.lblResult.Text;
            ViewState["operator"] = "*";
            this.lblResult.Text = "";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            ViewState.Remove("operand");
            ViewState.Remove("operator");
            this.lblResult.Text = "";
        }

        protected void btnZero_Click(object sender, EventArgs e)
        {
            this.lblResult.Text += "0";
        }

        protected void btnDivision_Click(object sender, EventArgs e)
        {
            if (ViewState["operator"] != null)
            {
                this.EvaluateExpression();
            }

            ViewState["operand"] = this.lblResult.Text;
            ViewState["operator"] = "/";
            this.lblResult.Text = "";
        }

        protected void btnSqrt_Click(object sender, EventArgs e)
        {

            if (ViewState["operator"] != null)
            {
                this.EvaluateExpression();
            }

            ViewState["operand"] = this.lblResult.Text;
            ViewState["operator"] = "sqrt";
            this.EvaluateExpression();
        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            this.EvaluateExpression();
        }

        private void EvaluateExpression()
        {
            string expressionOperator = ViewState["operator"].ToString();
            double firstNumber = double.Parse(ViewState["operand"].ToString());
            double secondNumber = double.Parse(this.lblResult.Text);
            double result = 0;

            switch (expressionOperator)
            {
                case "+":
                    result = PerformAddition(firstNumber, secondNumber);
                    break;
                case "-":
                    result = PerformSubstraction(firstNumber, secondNumber);
                    break;
                case "*":
                    result = PerformMultiplication(firstNumber, secondNumber);
                    break;
                case "/":
                    result = PerformDivision(firstNumber, secondNumber);
                    break;
                case "sqrt":
                    result = PerformSqrt(firstNumber);
                    break;
                default:
                    break;
            }

            ViewState["operand"] = result;
            this.lblResult.Text = result.ToString();
            ViewState.Remove("operator");
        }

        private double PerformSqrt(double firstNumber)
        {
            return Math.Sqrt(firstNumber);
        }

        private double PerformDivision(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }

        private double PerformMultiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        private double PerformSubstraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        private double PerformAddition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}