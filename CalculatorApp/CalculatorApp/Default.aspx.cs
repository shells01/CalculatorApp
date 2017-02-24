using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(TextBox1.Text);
            int second = int.Parse(TextBox2.Text);
            int result = first + second;
            resultLabel.Text = result.ToString();
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(TextBox1.Text);
            int second = int.Parse(TextBox2.Text);
            int result = first - second;
            resultLabel.Text = result.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            int first = int.Parse(TextBox1.Text);
            int second = int.Parse(TextBox2.Text);
            int result = first * second;
            resultLabel.Text = result.ToString();
        }

        protected void divideButton_Click(object sender, EventArgs e)
        {
            double first = double.Parse(TextBox1.Text);
            double second = double.Parse(TextBox2.Text);
            double result = first / second;
            resultLabel.Text = result.ToString();
        }
    }
}