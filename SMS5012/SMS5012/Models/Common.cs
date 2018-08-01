using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS5012.Models
{
    public static class Common
    {
        public static string ConnectionString()
        {
            string conString = @"server=BITMTRAINER-301\SQLEXPRESS; database=SMS5012; integrated security=true;";
            return conString;
        }
    }
}
