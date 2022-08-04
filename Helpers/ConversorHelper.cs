using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names.Helpers
{
    public static class ConversorHelper
    {

        public static DateTime CDateTime(string data)
        {
            try
            {
               return DateTime.Parse(data);
            }
            catch (Exception)
            {
                return DateTime.MinValue;
                
            }
        }
    }
}
