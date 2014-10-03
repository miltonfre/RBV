using System.Configuration;
using RBV_AccesoDatos.Properties;
using System;

namespace RBV_AccesoDatos
{
    partial class RBVDataContext
    {
        public RBVDataContext()
            : base(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString, mappingSource)
        {
        }
    }
}
