using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    class Helper
    {
        public static string BlogConnectionStringValue(IConfiguration configuration, string name)
        {
            return configuration.GetSection("ConnectionStrings")[name];
        }
    }
}
