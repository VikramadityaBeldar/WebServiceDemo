using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorWebApplication
{
    public partial class CalculatorPage : System.Web.UI.Page
    {
        CalculatorWebApplication.CalculatorWebService.CalculatorWebServiceSoapClient client =
                new CalculatorWebApplication.CalculatorWebService.CalculatorWebServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int result = client.Add(Convert.ToInt32(firstNumber.Text), Convert.ToInt32(secondNumber.Text));

            lblResult.Text = result.ToString();

            gvTransactions.DataSource = client.GetCalculations();
            gvTransactions.DataBind();
            gvTransactions.HeaderRow.Cells[0].Text = "Recent Calculations";

        }
    }
}