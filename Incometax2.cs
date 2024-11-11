using System;
using System.Web;
using System.Web.Services;

namespace WebApplication8
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "INCOME TAX";
        }

        [WebMethod]
        public int Add(int a, int b)
        {
            int c = a + b;
            int g = (c * 5) / 100; // Calculating 5% of the sum
            return g;
        }
    }
}
