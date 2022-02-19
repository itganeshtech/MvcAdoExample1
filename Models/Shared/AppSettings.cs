using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcAdoExample1.Models.Shared
{
    public class AppSettings
    {
        public static string ConnectionString()
        {
            return @"Data Source=DESKTOP-Q684RHH;Initial Catalog=TestDB2;Persist Security Info=True;User ID=sa;Password=sa123";
        }
    }
}
