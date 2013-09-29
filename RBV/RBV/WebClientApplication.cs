using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Config;

namespace RBV
{
    public class WebClientApplication : HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
              XmlConfigurator.Configure();

        }
     }
}
