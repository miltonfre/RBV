using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Web.Configuration;
using System.Web.Security;
using System.Resources;
using System.Text.RegularExpressions;
using System.Configuration.Provider;
using RBV_Clases;

namespace RBV_AccesoDatos
{
    public class aspnet_MembershipDA //: RBV_Clases.aspnet_Membership
    {

        public MembershipUser BuscarUsuarioPorNombre(string username)
        {
            RBVDataContext contextoRBV = new RBVDataContext();

            MembershipUser user = Membership.GetUser(username);


            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
         
    }
}
