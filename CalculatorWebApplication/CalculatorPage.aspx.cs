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
            if (!IsPostBack)
            {
                panelAdd2.Visible = true;
                panelAdd3.Visible = false;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(firstNumber.Text);
            int b = Convert.ToInt32(secondNumber.Text);
            int result = client.Add(a, b);
            lblResult.Text = "Result: " + result;
            BindGrid();

        }

        protected void btnAdd3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtFirst3.Text);
            int b = Convert.ToInt32(txtSecond3.Text);
            int c = Convert.ToInt32(txtThird3.Text);
            int result = client.Add1(a, b, c);
            lblResult.Text = "Result: " + result;
            BindGrid();
        }

        protected void ddlOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlOperation.SelectedValue == "2")
            {
                panelAdd2.Visible = true;
                panelAdd3.Visible = false;
            }
            else
            {
                panelAdd2.Visible = false;
                panelAdd3.Visible = true;
            }
        }

        private void BindGrid()
        {
            gvTransactions.DataSource = client.GetCalculations();
            gvTransactions.DataBind();
            gvTransactions.HeaderRow.Cells[0].Text = "Recent Calculations";
        }
    }
}