﻿using System;
using System.Security;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RBV_AccesoDatos;

namespace RBV_Negocio
{
    public class aspnet_MembershipBO
    {
        public bool ValidateUser(string username, string password)
        {
            aspnet_MembershipDA membershipDA = new aspnet_MembershipDA();
            return membershipDA.ValidateUser(username, password);
        }
    }
}
