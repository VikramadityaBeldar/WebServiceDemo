using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CalculatorWebService
{
    /// <summary>
    /// Summary description for CalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://vikramtech.com/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod(EnableSession = true, Description ="This will add two numbers", CacheDuration = 5)]
        public int Add(int firstNumber, int secondNumber)
        {
            List<string> calculations = Session["calculations"] as List<string> ?? new List<string>();

            int result = firstNumber + secondNumber;

            calculations.Add($"{firstNumber} + {secondNumber} = {result}");
            Session["calculations"] = calculations;

            calculations = Session["calculations"] as List<string>;

            return result;
        }

        [WebMethod(EnableSession = true)]
        public List<string> GetCalculations()
        {

            return Session["calculations"] as List<string>
                ?? new List<string> { "No calculation present" };

        }
    }
}
