using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer
{
    public class ConnecionStrings
    {
        public static string ConStrLocal = @"Data Source = .\SQLEXPRESS ; Initial Catalog=NORTHWND; Integrated Security=True";
        public static string ConStrLive = @"Data Source = .\SQLEXPRESS ; Initial Catalog=NORTHWND; Integrated Security=True";
    }
}

